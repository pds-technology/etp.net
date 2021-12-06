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

using Energistics.Json;
using Energistics.Json.Tokens;
using System.Collections.Generic;
using System.IO;

namespace Energistics.Avro.Encoding.Json
{
    /// <summary>
    /// A class for JSON Avro primitive decoding
    /// </summary>
    public class JsonPrimitiveDecoder : IPrimitiveDecoder
    {
        public JsonPrimitiveDecoder(string json)
            : this(json, JsonFloatingPointSettings.Default)
        {
            OwnReader = true;
        }

        public JsonPrimitiveDecoder(string json, JsonFloatingPointSettings floatingPointSettings)
            : this(new JsonReader(json), floatingPointSettings)
        {
            OwnReader = true;
        }

        public JsonPrimitiveDecoder(Stream stream)
            : this(stream, JsonFloatingPointSettings.Default)
        {
            OwnReader = true;
        }

        public JsonPrimitiveDecoder(Stream stream, JsonFloatingPointSettings floatingPointSettings)
            : this(new JsonReader(stream), floatingPointSettings)
        {
            OwnReader = true;
        }

        public JsonPrimitiveDecoder(TextReader reader)
            : this(reader, JsonFloatingPointSettings.Default)
        {
            OwnReader = true;
        }

        public JsonPrimitiveDecoder(TextReader reader, JsonFloatingPointSettings floatingPointSettings)
            : this(new JsonReader(reader), floatingPointSettings)
        {
            OwnReader = true;
        }

        public JsonPrimitiveDecoder(JsonReader reader)
            : this(reader, JsonFloatingPointSettings.Default)
        {
        }

        public JsonPrimitiveDecoder(JsonReader reader, JsonFloatingPointSettings floatingPointSettings)
        {
            Reader = reader;
            FloatingPointSettings = floatingPointSettings;
            PushToken(Reader.Read());
            FloatingPointEncodingProperties = JsonFloatingPointEncodingProperties.ForEncodingAndSettings(System.Text.Encoding.UTF8, floatingPointSettings);
        }

        private JsonReader Reader { get; }

        protected Token Top { get; private set; }

        private Stack<Token> TokenStack { get; } = new Stack<Token>();

        private bool Disposed { get; set; }

        private bool OwnReader { get; }

        public JsonFloatingPointSettings FloatingPointSettings { get; }

        private JsonFloatingPointEncodingProperties FloatingPointEncodingProperties { get; }

        protected void PushToken(Token token)
        {
            Top = token;
            TokenStack.Push(token);
        }

        protected Token PopToken()
        {
            var popped = TokenStack.Pop();
            Top = TokenStack.Count > 0 ? TokenStack.Peek() : null;
            return popped;
        }

        public void DecodeNull()
        {
            var token = PopToken();
            if (!(token is Null))
                throw new InvalidDataException($"Value is not null: '{token}'");
        }

        public T DecodeNullClass<T>() where T : class
        {
            DecodeNull();
            return null;
        }

        public T? DecodeNullStruct<T>() where T : struct
        {
            DecodeNull();
            return null;
        }

        public bool DecodeBoolean()
        {
            var token = PopToken();
            if (!(token is Bool))
                throw new InvalidDataException($"Value is not boolean: '{token}'");

            return token is True ? true : false;
        }

        public int DecodeInt()
        {
            var token = PopToken();
            if (!(token is Number n))
                throw new InvalidDataException($"Value is not number: '{token}'");

            return n.GetIntValue();
        }

        public long DecodeLong()
        {
            var token = PopToken();
            if (!(token is Number n))
                throw new InvalidDataException($"Value is not number: '{token}'");

            return n.GetLongValue();
        }

        public float DecodeFloat()
        {
            var token = PopToken();
            if (token == null)
                throw new InvalidDataException($"Value is not number: '{token}'");
            else if (token == FloatingPointEncodingProperties.NaNToken)
                return float.NaN;
            else if (token == FloatingPointEncodingProperties.PositiveInfinityToken)
                return float.PositiveInfinity;
            else if (token == FloatingPointEncodingProperties.NegativeInfinityToken)
                return float.NegativeInfinity;
            else if (token is Number n)
                return n.GetFloatValue();

            throw new InvalidDataException($"Value is not number: '{token}'");
        }

        public double DecodeDouble()
        {
            var token = PopToken();
            if (token == null)
                throw new InvalidDataException($"Value is not number: '{token}'");
            else if (token == FloatingPointEncodingProperties.NaNToken)
                return float.NaN;
            else if (token == FloatingPointEncodingProperties.PositiveInfinityToken)
                return float.PositiveInfinity;
            else if (token == FloatingPointEncodingProperties.NegativeInfinityToken)
                return float.NegativeInfinity;
            else if (token is Number n)
                return n.GetDoubleValue();

            throw new InvalidDataException($"Value is not number: '{token}'");
        }

        public string DecodeString()
        {
            var token = PopToken();
            if (!(token is String s))
                throw new InvalidDataException($"Value is not string: '{token}'");

            return s.GetValue();
        }

        public byte[] DecodeBytes()
        {
            var token = PopToken();
            if (!(token is String s))
                throw new InvalidDataException($"Value is not string: '{token}'");

            return BytesEncoding.Decode(s.EncodedValue);
        }

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
        // ~JsonPrimitiveDecoder()
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
