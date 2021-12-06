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
using System.IO;

namespace Energistics.Avro.Encoding.Json
{
    /// <summary>
    /// A class for JSON Avro encoding
    /// </summary>
    public class JsonAvroEncoder : JsonPrimitiveEncoder, IAvroEncoder
    {
        public JsonAvroEncoder(Stream stream)
            : base(stream)
        {
        }

        public JsonAvroEncoder(TextWriter writer)
            : base(writer)
        {
        }

        public JsonAvroEncoder(Stream stream, JsonFloatingPointSettings floatingPointSettings)
            : base(stream, floatingPointSettings)
        {
        }

        public JsonAvroEncoder(TextWriter writer, JsonFloatingPointSettings floatingPointSettings)
            : base(writer, floatingPointSettings)
        {
        }

        private void EncodeObjectStart() => EncodeRaw('{');

        private void EncodeObjectMemberName(string name)
        {
            EncodeString(name);
            EncodeRaw(':');
        }

        private void EncodeSeparator() => EncodeRaw(',');

        private void EncodeObjectEnd() => EncodeRaw('}');

        public void EncodeFixed(long byteCount, byte[] value) => EncodeBytes(value);

        public void EncodeEnum<TEnum>(TEnum value) where TEnum : struct, System.Enum => EncodeString(AvroEnumConverter<TEnum>.EnumToString(value));

        public void EncodeRecordStart(string type, int fieldCount) => EncodeObjectStart();

        public void EncodeRecordFieldName(string name) => EncodeObjectMemberName(name);

        public void EncodeRecordFieldSeparator() => EncodeSeparator();

        public void EncodeRecordEnd() => EncodeObjectEnd();

        public void EncodeRecordSeparator() => EncodeSeparator();

        public void EncodeArrayStart(int totalCount, int blockCount, long? blockByteCount = null) => EncodeRaw('[');

        public void EncodeArrayBlockStart(int count, long? byteCount = null) { }

        public void EncodeArrayItemSeparator() => EncodeSeparator();

        public void EncodeArrayEnd() => EncodeRaw(']');

        public void EncodeMapStart(int totalCount, int blockCount, long? blockByteCount = null) => EncodeObjectStart();

        public void EncodeMapBlockStart(int count, long? byteCount = null) { }

        public void EncodeMapKey(string key) => EncodeObjectMemberName(key);

        public void EncodeMapValueSeparator() => EncodeSeparator();

        public void EncodeMapEnd() => EncodeObjectEnd();

        public void EncodeUnionStart(int typeIndex, IChoiceTypeConverter converter) => EncodeUnionStart(converter.TypeIndexToIsNull(typeIndex), converter.TypeIndexToTypeName(typeIndex));

        public void EncodeUnionStart(bool isNull, INullableTypeConverter converter) => EncodeUnionStart(isNull, converter.IsNullToTypeName(isNull));

        private void EncodeUnionStart(bool isNull, string typeName)
        {
            if (!isNull)
            {
                EncodeObjectStart();
                EncodeObjectMemberName(typeName);
            }
        }

        public void EncodeUnionEnd(bool isNull)
        {
            if (!isNull)
                EncodeObjectEnd();
        }
    }
}
