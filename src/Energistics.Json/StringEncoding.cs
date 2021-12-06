//-----------------------------------------------------------------------
// ETP DevKit, 1.2
// 
// Copyright 2021 Energistics
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

using System.IO;

namespace Energistics.Json
{
    /// <summary>
    /// Helper methods for JSON string encoding.
    /// </summary>
    public static partial class StringEncoding
    {
        /// <summary>
        /// Encodes a string.
        /// </summary>
        /// <param name="string">The string to encode.</param>
        /// <param name="writer">The writer to write the encoded string to.</param>
        public static void Encode(string @string, TextWriter writer)
        {
            for (int i = 0; i < @string.Length; i++)
            {
                if (@string[i] < 256)
                    writer.Write(CharStrings[@string[i]]);
                else
                    writer.Write(@string[i]);
            }
        }

        /// <summary>
        /// Encodes a string.
        /// </summary>
        /// <param name="string">The string to encode.</param>
        /// <returns>The encoded string.</returns>
        public static string Encode(string @string)
        {
            using (var writer = new StringWriter())
            {
                Encode(@string, writer);
                return writer.ToString();
            }
        }

        /// <summary>
        /// Decodes a string.
        /// </summary>
        /// <param name="string">The string to decode.</param>
        /// <returns>The decoded string.</returns>
        public static string Decode(string @string)
        {
            var count = GetDecodedCharCount(@string);
            if (count == @string.Length)
                return @string;

            var chars = new char[count];
            var c = 0;
            for (int i = 0; i < @string.Length;)
            {
                if (@string[i] == '\\')
                {
                    chars[c++] = (char)DecodeEscapedChar(@string, ref i);
                }
                else
                {
                    chars[c++] = @string[i++];
                }
            }

            return new string(chars);
        }

        /// <summary>
        /// Decodes a string.
        /// </summary>
        /// <param name="sb">The string builder with the string to decode.</param>
        /// <returns>The decoded string.</returns>
        public static string Decode(System.Text.StringBuilder sb)
        {
            var count = GetDecodedCharCount(sb);
            if (count == sb.Length)
                return sb.ToString();

            var chars = new char[count];
            var c = 0;
            for (int i = 0; i < sb.Length;)
            {
                if (sb[i] == '\\')
                {
                    chars[c++] = (char)DecodeEscapedChar(sb, ref i);
                }
                else
                {
                    chars[c++] = sb[i++];
                }
            }

            return new string(chars);
        }

        /// <summary>
        /// Gets whether the input character is a valid JSON escape character or note
        /// </summary>
        /// <param name="c">The character to check.</param>
        /// <returns><c>true</c> if the character is a valid escape character; <c>false</c> otherwise.</returns>
        public static bool IsValidEscape(char c)
        {
            switch (c)
            {
                case '"':
                case '\\':
                case '/':
                case 'b':
                case 'f':
                case 'n':
                case 'r':
                case 't': 
                case 'u': return true;
                default: return false;
            }
        }

        /// <summary>
        /// Gets the character count of the decoded string for an encoded string.
        /// </summary>
        /// <param name="string">The encoded string to get the decoded character count for.</param>
        /// <returns>The character count of the decoded string for the encoded string.</returns>
        public static int GetDecodedCharCount(string @string)
        {
            var count = @string.Length;
            for (int i = 0; i < @string.Length;)
            {
                if (@string[i] == '\\')
                {
                    switch (@string[++i])
                    {
                        case '"':
                        case '\\':
                        case '/':
                        case 'b':
                        case 'f':
                        case 'n':
                        case 'r':
                        case 't': --count; ++i; break;
                        case 'u': count -= 5; i += 4; break;
                        default: throw new InvalidDataException($"Unexpected '\\{@string[i]} in: '{@string}'");
                    }
                }
                else
                {
                    i++;
                }
            }

            return count;
        }

        /// <summary>
        /// Gets the character count of the decoded string for an encoded string.
        /// </summary>
        /// <param name="sb">The string builder with the encoded string to get the decoded character count for.</param>
        /// <returns>The character count of the decoded string for the encoded string.</returns>
        public static int GetDecodedCharCount(System.Text.StringBuilder sb)
        {
            var count = sb.Length;
            for (int i = 0; i < sb.Length;)
            {
                if (sb[i] == '\\')
                {
                    switch (sb[++i])
                    {
                        case '"':
                        case '\\':
                        case '/':
                        case 'b':
                        case 'f':
                        case 'n':
                        case 'r':
                        case 't': --count; ++i; break;
                        case 'u': count -= 5; i += 4; break;
                        default: throw new InvalidDataException($"Unexpected '\\{sb[i]} in: '{sb}'");
                    }
                }
                else
                {
                    i++;
                }
            }

            return count;
        }

        /// <summary>
        /// Decodes an escaped character in a string.
        /// </summary>
        /// <param name="string">The string with the escaped character.</param>
        /// <param name="pos">The position in the string the escaped character starts at.</param>
        /// <returns>The escaped character.</returns>
        public static int DecodeEscapedChar(string @string, ref int pos)
        {
            if (pos > @string.Length - 2)
                throw new InvalidDataException($"Unexpected '\\' in '{@string}'");
            switch (@string[++pos])
            {
                case '"' : ++pos; return '"' ;
                case '\\': ++pos; return '\\';
                case '/' : ++pos; return '/' ;
                case 'b' : ++pos; return '\b';
                case 'f' : ++pos; return '\f';
                case 'n' : ++pos; return '\n';
                case 'r' : ++pos; return '\r';
                case 't' : ++pos; return '\t';
                case 'u' :
                    {
                        ++pos;
                        if (pos > @string.Length - 4)
                            throw new InvalidDataException($"Invalid '\\u' in '{@string}'");
                        int c = 0;
                        for (int i = 0; i < 4; i++)
                        {
                            int x = @string[pos + i];
                            if (x >= '0' && x <= '9')
                                x -= '0';
                            else if (x >= 'A' && x <= 'F')
                                x = 10 + (x - 'A');
                            else if (x >= 'a' && x <= 'f')
                                x -= 10 + (x - 'a');
                            else
                                throw new InvalidDataException($"Invalid hex escape '\\u{@string.Substring(pos, 4)}' in '{@string}'");
                            c |= x << ((3 - i) * 4);
                        }
                        pos += 4;
                        return (char)c;
                    }
                default: throw new InvalidDataException($"Unexpected '\\{@string[pos]} in: '{@string}'");
            }
        }

        /// <summary>
        /// Decodes an escaped character in a string.
        /// </summary>
        /// <param name="sb">The string builder with the escaped character.</param>
        /// <param name="pos">The position in the string the escaped character starts at.</param>
        /// <returns>The escaped character.</returns>
        public static int DecodeEscapedChar(System.Text.StringBuilder sb, ref int pos)
        {
            if (pos > sb.Length - 2)
                throw new InvalidDataException($"Unexpected '\\' in '{sb}'");
            switch (sb[++pos])
            {
                case '"': ++pos; return '"';
                case '\\': ++pos; return '\\';
                case '/': ++pos; return '/';
                case 'b': ++pos; return '\b';
                case 'f': ++pos; return '\f';
                case 'n': ++pos; return '\n';
                case 'r': ++pos; return '\r';
                case 't': ++pos; return '\t';
                case 'u':
                    {
                        ++pos;
                        if (pos > sb.Length - 4)
                            throw new InvalidDataException($"Invalid '\\u' in '{sb}'");
                        int c = 0;
                        for (int i = 0; i < 4; i++)
                        {
                            int x = sb[pos + i];
                            if (x >= '0' && x <= '9')
                                x -= '0';
                            else if (x >= 'A' && x <= 'F')
                                x = 10 + (x - 'A');
                            else if (x >= 'a' && x <= 'f')
                                x -= 10 + (x - 'a');
                            else
                                throw new InvalidDataException($"Invalid hex escape '\\u{sb.ToString(pos, 4)}' in '{sb}'");
                            c |= x << ((3 - i) * 4);
                        }
                        pos += 4;
                        return (char)c;
                    }
                default: throw new InvalidDataException($"Unexpected '\\{sb[pos]} in: '{sb}'");
            }
        }
    }
}
