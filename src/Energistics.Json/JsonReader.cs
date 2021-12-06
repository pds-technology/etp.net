//----------------------------------------------------------------------- 
// ETP DevKit, 1.2
//
// Copyright 2019 Energistics
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

using Energistics.Json.Tokens;
using System.Collections.Generic;
using System.IO;

namespace Energistics.Json
{
    /// <summary>
    /// A class for JSON decoding
    /// </summary>
    public sealed class JsonReader : System.IDisposable
    {
        public JsonReader(string json)
            : this(new StringReader(json))
        {
            OwnReader = true;
        }

        public JsonReader(Stream stream)
            : this (new StreamReader(stream, System.Text.Encoding.UTF8, true, 1024, true))
        {
            OwnReader = true;
        }

        public JsonReader(TextReader reader)
        {
            Reader = reader;
            ReadChar(); // Read first character
        }

        private bool Disposed { get; set; }

        private TextReader Reader { get; }

        private bool OwnReader { get; }

        private char CurChar { get; set; }

        private bool Eof { get; set; }

        private int Line { get; set; } = 1;

        private int Col { get; set; }

        private int ValueStartLine { get; set; }

        private int ValueStartCol { get; set; }

        private class State
        {
            public State(int startLine, int startCol, bool complete, Token token)
            {
                Token = token;
                Complete = complete;
                StartLine = startLine;
                StartCol = startCol;
            }

            public Token Token { get; }

            public bool Complete { get; }

            public int StartLine { get; }

            public int StartCol { get; }

            public Object Object => Token as Object;

            public Array Array => Token as Array;
        }

        private Stack<State> Stack { get; } = new Stack<State>();

        private State Top { get; set; }

        public Token Read()
        {
            SkipToContent();
            while (!Eof)
            {
                if (Top == null)
                {
                    ReadInitialState();
                }
                else if (Top.Token.IsContainer())
                {
                    if (Top.Complete)
                        throw new InvalidDataException($"Unexpected Content at Line: {Line}; Column: {Col}");

                    if (Top.Token is Object)
                        ReadObjectContent();
                    else if (Top.Token is Array)
                        ReadArrayContent();
                    else
                        throw new InvalidDataException($"Unexpected Content at Line: {Line}; Column: {Col}");
                }
                else
                    throw new InvalidDataException($"Unexpected Content at Line: {Line}; Column: {Col}");

                SkipToContent();
            }

            if (Stack.Count == 0)
                throw new InvalidDataException($"No JSON content found");
            else if (Stack.Count > 1)
                throw new InvalidDataException($"Unexpected End of Content at Line: {Line}; Column: {Col}");

            if (!Top.Complete)
                throw new InvalidDataException($"Unexpected End of Content at Line: {Line}; Column: {Col}");

            return Top.Token;
        }

        private void PushState(State state)
        {
            Top = state;
            Stack.Push(state);
        }

        private void PopState()
        {
            var top = Stack.Pop();
            if (Stack.Count == 0)
            {
                Top = null;
                if (top.Token.IsContainer()) // Special case for completed arrays and objects at the root level
                    PushState(new State(top.StartLine, top.StartCol, true, top.Token));
            }
            else
            {
                Top = Stack.Peek();
            }
        }

        private void ReadInitialState()
        {
            var state = ReadValueStart();
            PushState(state);
        }

        private State ReadValueStart()
        {
            ValueStartLine = Line;
            ValueStartCol = Col;

            if (IsObjectStart())
                return ReadObjectStart();
            else if (IsArrayStart())
                return ReadArrayStart();
            else if (IsScalarStart())
                return new State(ValueStartLine, ValueStartCol, true, ReadScalar());
            else
                throw new InvalidDataException($"Invalid Content at Line: {ValueStartLine}; Column: {ValueStartCol}");
        }

        private State ReadObjectStart()
        {
            if (!IsObjectStart())
                throw new InvalidDataException($"Invalid Object at Line: {ValueStartLine}; Column: {ValueStartCol}");

            var @object = new Object();

            ReadChar(); // Consume object start
            SkipToContent();

            if (Eof)
                throw new InvalidDataException($"Invalid Object at Line: {ValueStartLine}; Column: {ValueStartLine}: Unexpected End of Content at Line: {Line}; Column: {Col}");
            else if (IsObjectEnd())
            {
                ReadChar(); // Consume object end
                return new State(ValueStartLine, ValueStartCol, true, @object);
            }
            else
                return new State(ValueStartLine, ValueStartCol, false, @object);
        }

        private void ReadObjectContent()
        {
            while (true)
            {
                if (Top.Object.Values.Count > 0)
                {
                    if (IsSeparator())
                    {
                        ReadChar(); // Consume separator
                        SkipToContent();
                    }
                    else if (IsObjectEnd())
                    {
                        ReadChar(); // Consume object end
                        PopState();
                        return;
                    }
                    else
                        throw new InvalidDataException($"Invalid Object at Line: {Top.StartLine}; Column: {Top.StartCol}: Invalid Content at Line: {Line}; Column: {Col}");
                }

                if (Eof || !IsStringStart())
                    throw new InvalidDataException($"Invalid Object at Line: {Top.StartLine}; Column: {Top.StartCol}: Invalid Content at Line: {ValueStartLine}; Column: {ValueStartCol}");

                var name = ReadString();
                SkipToContent();
                if (Eof || !IsPropertyNameValueSeparator())
                    throw new InvalidDataException($"Invalid Object at Line: {ValueStartLine}; Column: {ValueStartCol}: Invalid Content at Line: {Line}; Column: {Col}");

                ReadChar(); // Consume property separator
                SkipToContent();

                if (Eof || !IsValueStart())
                    throw new InvalidDataException($"Invalid Object at Line: {Top.StartLine}; Column: {Top.StartCol}: Invalid Content at Line: {Line}; Column: {Col}");

                var value = ReadValueStart();
                Top.Object.Values.Add(name.Value, value.Token);
                if (!value.Complete)
                {
                    PushState(value);
                    return; // Short circuit when entering a nested object or array
                }

                SkipToContent();
            }
        }

        private State ReadArrayStart()
        {
            if (!IsArrayStart())
                throw new InvalidDataException($"Invalid Array at Line: {ValueStartLine}; Column: {ValueStartCol}");

            var @array = new Array();

            ReadChar(); // Consume array start
            SkipToContent();

            if (Eof)
                throw new InvalidDataException($"Invalid Array at Line: {ValueStartLine}; Column: {ValueStartLine}: Unexpected End of Content at Line: {Line}; Column: {Col}");
            else if (IsArrayEnd())
            {
                ReadChar(); // Consume array end
                return new State(ValueStartLine, ValueStartCol, true, @array);
            }
            else
                return new State(ValueStartLine, ValueStartCol, false, @array);
        }

        private void ReadArrayContent()
        {
            while (true)
            {
                if (Top.Array.Values.Count > 0)
                {
                    if (IsSeparator())
                    {
                        ReadChar(); // Consume separator
                        SkipToContent();
                    }
                    else if (IsArrayEnd())
                    {
                        ReadChar(); // Consume array end
                        PopState();
                        return;
                    }
                    else
                        throw new InvalidDataException($"Invalid Array at Line: {Top.StartLine}; Column: {Top.StartCol}: Invalid Content at Line: {Line}; Column: {Col}");
                }

                if (Eof || !IsValueStart())
                    throw new InvalidDataException($"Invalid Array at Line: {Top.StartLine}; Column: {Top.StartCol}: Invalid Content at Line: {Line}; Column: {Col}");

                var value = ReadValueStart();
                Top.Array.Values.Add(value.Token);
                if (!value.Complete)
                {
                    PushState(value);
                    return; // Short circuit when entering a nested array or array
                }

                SkipToContent();
            }
        }

        private Scalar ReadScalar()
        {
            if (IsLiteralStart())
                return ReadLiteral();
            else if (IsStringStart())
                return ReadString();
            else if (IsNumberStart())
                return ReadNumber();
            else
                throw new InvalidDataException($"Invalid Value at Line: {Line}; Column: {Col}");
        }

        private Literal ReadLiteral()
        {
            if (IsTrueStart())
                return ReadTrue();
            else if (IsFalseStart())
                return ReadFalse();
            else if (IsNullStart())
                return ReadNull();

            throw new InvalidDataException($"Invalid Literal at Line: {ValueStartLine}; Column: {ValueStartCol}");
        }

        private True ReadTrue()
        {
            if (CurChar == 't' && ReadChar() == 'r' && ReadChar() == 'u' && ReadChar() == 'e')
            {
                ReadChar(); // Consume final 'e'
                return Literal.True;
            }

            throw new InvalidDataException($"Invalid Literal at Line: {ValueStartLine}; Column: {ValueStartCol}");
        }

        private False ReadFalse()
        {
            if (CurChar == 'f' && ReadChar() == 'a' && ReadChar() == 'l' && ReadChar() == 's' && ReadChar() == 'e')
            {
                ReadChar(); // Consume final 'e'
                return Literal.False;
            }

            throw new InvalidDataException($"Invalid Literal at Line: {ValueStartLine}; Column: {ValueStartCol}");
        }

        private Null ReadNull()
        {
            if (CurChar == 'n' && ReadChar() == 'u' && ReadChar() == 'l' && !Eof && ReadChar() == 'l')
            {
                ReadChar(); // Consume final 'l'
                return Literal.Null;
            }

            throw new InvalidDataException($"Invalid Literal at Line: {ValueStartLine}; Column: {ValueStartCol}");
        }

        private String ReadString()
        {
            if (!IsStringStart())
                throw new InvalidDataException($"Invalid String at Line: {ValueStartLine}; Column: {ValueStartCol}");

            var sb = new System.Text.StringBuilder();
            var escaping = false;
            ReadChar(); // Consume initial "

            while (!Eof && !(!escaping && IsStringEnd()))
            {
                if (!IsStringChar())
                    throw new InvalidDataException($"Invalid String at Line: {ValueStartLine}; Column: {ValueStartCol}: Invalid Character at Line: {Line}; Column: {Col}");
                else if (IsEscapeStart() && !escaping)
                {
                    escaping = true;
                    sb.Append(CurChar);
                }
                else if (escaping)
                {
                    if (IsHexEscape())
                    {
                        var hexLine = Line;
                        var hexCol = Col;
                        sb.Append(CurChar);
                        for (int i = 0; i < 4; i++)
                        {
                            ReadChar();
                            if (Eof || IsStringEnd() || !IsHex())
                                throw new InvalidDataException($"Invalid String at Line: {ValueStartLine}; Column: {ValueStartCol}: Invalid Hex Escape at Line: {hexLine}; Column: {hexCol}");
                            sb.Append(CurChar);
                        }
                    }
                    else if (IsEscape())
                        sb.Append(CurChar);
                    else
                        throw new InvalidDataException($"Invalid String at Line: {ValueStartLine}; Column: {ValueStartCol}: Invalid Escape Character '\\{CurChar}' at Line: {Line}; Column: {Col}");
                    escaping = false;
                }
                else
                    sb.Append(CurChar);

                ReadChar();
            }

            if (Eof)
                throw new InvalidDataException($"Invalid String at Line: {ValueStartLine}; Column: {ValueStartCol}");

            var @string = String.FromEncodedValue(sb.ToString());
            ReadChar();
            return @string;
        }

        private Number ReadNumber()
        {
            if (!IsNumberStart())
                throw new InvalidDataException($"Invalid Number at Line: {ValueStartLine}; Column: {ValueStartCol}");

            var sb = new System.Text.StringBuilder();
            sb.Append(CurChar);

            if (CurChar == '-')
                sb.Append(ReadChar());

            if (Eof || !IsDigit())
                throw new InvalidDataException($"Invalid Number at Line: {ValueStartLine}; Column: {ValueStartCol}");

            var digits = 0; // do while loop will overcount by 1.
            var leadingZero = CurChar == '0';
            do { sb.Append(ReadChar()); digits++; } while (!Eof && IsDigit());

            if (digits > 1 && leadingZero)
                throw new InvalidDataException($"Invalid Number at Line: {ValueStartLine}; Column: {ValueStartCol}");


            if (!Eof && CurChar == '.') // Handle Fraction
            {
                sb.Append(ReadChar());

                if (Eof || !IsDigit())
                    throw new InvalidDataException($"Invalid Number at Line: {ValueStartLine}; Column: {ValueStartCol}");

                do { sb.Append(ReadChar()); } while (!Eof && IsDigit());
            }

            if (Eof || !IsExponentStart())
            {
                sb.Remove(sb.Length - 1, 1);
                return new Number(sb.ToString());
            }

            sb.Append(ReadChar());

            if (Eof || (!IsExponentSign() && !IsDigit()))
                throw new InvalidDataException($"Invalid Number at Line: {ValueStartLine}; Column: {ValueStartCol}");

            if (IsExponentSign())
            {
                sb.Append(ReadChar());

                if (Eof || !IsDigit())
                    throw new InvalidDataException($"Invalid Number at Line: {ValueStartLine}; Column: {ValueStartCol}");
            }

            do { sb.Append(ReadChar()); } while (!Eof && IsDigit());

            sb.Remove(sb.Length - 1, 1);
            return new Number(sb.ToString());
        }

        private char ReadChar()
        {
            if (Eof) return CurChar;

            var cur = Reader.Read();
            if (cur == -1)
                Eof = true;
            else
            {
                CurChar = (char)cur;
                Col++;
                if (CurChar == 0x0A)
                {
                    Line++;
                    Col = 1;
                }
            }
            return CurChar;
        }
        private void SkipToContent()
        {
            while (!Eof && IsWhitespace())
                ReadChar();
        }
        private bool IsDigit() => CurChar >= '0' && CurChar <= '9';
        private bool IsHex() => IsDigit() || (CurChar >= 'a' && CurChar <= 'f') || (CurChar >= 'A' && CurChar <= 'F');
        private bool IsEscapeStart() => CurChar == '\\';
        private bool IsEscape() => StringEncoding.IsValidEscape(CurChar);
        private bool IsHexEscape() => CurChar == 'u';
        private bool IsStringChar() => CurChar >= 0x20;
        private bool IsWhitespace() => CurChar == 0x20 || CurChar == 0x0A || CurChar == 0x0D || CurChar == 0x09;
        private bool IsSeparator() => CurChar == ',';
        private bool IsObjectStart() => CurChar == '{';
        private bool IsObjectEnd() => CurChar == '}';
        private bool IsArrayStart() => CurChar == '[';
        private bool IsArrayEnd() => CurChar == ']';
        private bool IsStringStart() => CurChar == '"';
        private bool IsStringEnd() => CurChar == '"';
        private bool IsNumberStart() => CurChar == '-' || IsDigit();
        private bool IsExponentStart() => CurChar == 'e' || CurChar == 'E';
        private bool IsExponentSign() => CurChar == '+' || CurChar == '-';
        private bool IsTrueStart() => CurChar == 't';
        private bool IsFalseStart() => CurChar == 'f';
        private bool IsNullStart() => CurChar == 'n';
        private bool IsPropertyNameValueSeparator() => CurChar == ':';
        private bool IsLiteralStart() => IsTrueStart() || IsFalseStart() || IsNullStart();
        private bool IsContainerStart() => IsObjectStart() || IsArrayStart();
        private bool IsScalarStart() => IsStringStart() || IsNumberStart() || IsLiteralStart();
        private bool IsValueStart() => IsContainerStart() || IsScalarStart();

        private void Dispose(bool disposing)
        {
            if (!Disposed)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    if (OwnReader)
                        Reader.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                Disposed = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~JsonReader()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            System.GC.SuppressFinalize(this);
        }
    }
}
