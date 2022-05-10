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

using Energistics.Avro.Encoding.Converter;
using Energistics.Json;
using Energistics.Json.Tokens;
using System.Collections.Generic;
using System.IO;

namespace Energistics.Avro.Encoding.Json
{
    /// <summary>
    /// A class for JSON Avro decoding
    /// </summary>
    public class JsonAvroDecoder : JsonPrimitiveDecoder, IAvroDecoder
    {
        public JsonAvroDecoder(string json)
            : base(json)
        {
        }

        public JsonAvroDecoder(string json, JsonFloatingPointSettings floatingPointSettings)
            : base(json, floatingPointSettings)
        {
        }

        public JsonAvroDecoder(Stream stream)
            : base(stream)
        {
        }

        public JsonAvroDecoder(Stream stream, JsonFloatingPointSettings floatingPointSettings)
            : base(stream, floatingPointSettings)
        {
        }

        public JsonAvroDecoder(TextReader reader)
            : base(reader)
        {
        }

        public JsonAvroDecoder(TextReader reader, JsonFloatingPointSettings floatingPointSettings)
            : base(reader, floatingPointSettings)
        {
        }

        public JsonAvroDecoder(JsonReader reader)
            : base(reader)
        {
        }

        public JsonAvroDecoder(JsonReader reader, JsonFloatingPointSettings floatingPointSettings)
            : base(reader, floatingPointSettings)
        {
        }

        public byte[] DecodeFixed(long byteCount)
        {
            var bytes = DecodeBytes();
            if (bytes.Length != byteCount)
                throw new InvalidDataException($"Expected fixed byte array length of {byteCount} but actual length is {bytes.Length}.");

            return bytes;
        }

        private Stack<IEnumerator<Token>> ArrayEnumerators { get; } = new Stack<IEnumerator<Token>>();

        private IEnumerator<Token> TopArrayEnumerator { get; set; }

        private Stack<IEnumerator<KeyValuePair<string, Token>>> MapEnumerators { get; } = new Stack<IEnumerator<KeyValuePair<string, Token>>>();

        private IEnumerator<KeyValuePair<string, Token>> TopMapEnumerator { get; set; }

        private string CurrentMapKey => TopMapEnumerator.Current.Key;

        private void PushArrayEnumerator(IEnumerator<Token> enumerator)
        {
            TopArrayEnumerator = enumerator;
            ArrayEnumerators.Push(enumerator);

            AdvanceArrayEnumerator();
        }

        public void AdvanceArrayEnumerator()
        {
            if (TopArrayEnumerator.MoveNext())
                PushToken(TopArrayEnumerator.Current);
        }

        private void PopArrayEnumerator()
        {
            TopArrayEnumerator.Dispose();
            ArrayEnumerators.Pop();
            TopArrayEnumerator = ArrayEnumerators.Count > 0 ? ArrayEnumerators.Peek() : null;
        }

        private void PushMapEnumerator(IEnumerator<KeyValuePair<string, Token>> enumerator)
        {
            TopMapEnumerator = enumerator;
            MapEnumerators.Push(enumerator);

            AdvanceMapEnumerator();
        }

        public void AdvanceMapEnumerator()
        {
            if (TopMapEnumerator.MoveNext())
                PushToken(TopMapEnumerator.Current.Value);
        }

        private void PopMapEnumerator()
        {
            TopMapEnumerator.Dispose();
            MapEnumerators.Pop();
            TopMapEnumerator = MapEnumerators.Count > 0 ? MapEnumerators.Peek() : null;
        }

        public TEnum DecodeEnum<TEnum>() where TEnum : struct, System.Enum => AvroEnumConverter<TEnum>.StringToEnum(DecodeString());

        public void DecodeRecordStart(string type, int fieldCount)
        {
            if (!(Top is Object))
                throw new InvalidDataException($"Expected JSON object: {Top}.");
        }

        public void DecodeRecordFieldName(string name)
        {
            var field = Top.GetToken(name);
            if (field == null)
                throw new InvalidDataException($"Missing field '{name}': {Top}.");
            PushToken(field);
        }

        public void DecodeRecordFieldSeparator() { }

        public void DecodeRecordEnd()
        {
            var token = PopToken();
            if (!(token is Object))
                throw new InvalidDataException($"Expected JSON object: {token}.");
        }

        public void DecodeRecordSeparator() { }

        public int DecodeArrayStart()
        {
            if (!(Top is Energistics.Json.Tokens.Array array))
                throw new InvalidDataException($"Expected JSON array: {Top}.");

            PushArrayEnumerator(array.GetEnumerator());
            return array.Count;
        }

        public int DecodeArrayBlockStart() => 0;

        public void DecodeArrayItemSeparator() => AdvanceArrayEnumerator();

        public void DecodeArrayEnd()
        {
            var token = PopToken();
            if (!(token is Array))
                throw new InvalidDataException($"Expected JSON array: {token}.");

            PopArrayEnumerator();
        }

        public int DecodeMapStart()
        {
            if (!(Top is Energistics.Json.Tokens.Object @object))
                throw new InvalidDataException($"Expected JSON object: {Top}.");

            PushMapEnumerator(@object.GetEnumerator());
            return @object.Count;
        }

        public int DecodeMapBlockStart() => 0;

        public string DecodeMapKey() => CurrentMapKey;

        public void DecodeMapValueSeparator() => AdvanceMapEnumerator();

        public void DecodeMapEnd()
        {
            var token = PopToken();
            if (!(token is Object))
                throw new InvalidDataException($"Expected JSON object: {token}.");

            PopMapEnumerator();
        }

        public int DecodeUnionStart(IChoiceTypeConverter converter) => converter.TypeNameToTypeIndex(DecodeUnionStart());

        public bool DecodeUnionStart(INullableTypeConverter converter) => converter.TypeNameToIsNull(DecodeUnionStart());

        private string DecodeUnionStart()
        {
            if (Top is Null)
                return "null";

            var count = DecodeMapStart();
            if (count != 1)
                throw new InvalidDataException($"Expected JSON object with a single value: {Top}.");

            return CurrentMapKey;
        }

        public void DecodeUnionEnd(bool isNull)
        {
            if (!isNull)
                DecodeMapEnd();
        }
    }
}
