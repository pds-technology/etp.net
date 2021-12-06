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
using System.Collections.Generic;

namespace Energistics.Avro.Encoding.Json
{
    /// <summary>
    /// A class for counting the bytes required for JSON Avro encoding
    /// </summary>
    public class JsonAvroByteCounter : JsonPrimitiveByteCounter, IAvroByteCounter
    {
        public JsonAvroByteCounter()
        {
        }

        public JsonAvroByteCounter(JsonFloatingPointSettings floatingPointSettings)
            : base(floatingPointSettings)
        {
        }

        public JsonAvroByteCounter(System.Text.Encoding encoding)
            : base(encoding)
        {
        }

        public JsonAvroByteCounter(System.Text.Encoding encoding, JsonFloatingPointSettings floatingPointSettings)
            : base(encoding, floatingPointSettings)
        {
        }

        private void EncodeObjectStart() => Increment(1L);

        private void EncodeObjectMemberName(string name)
        {
            EncodeString(name);
            Increment(1L);
        }

        private void EncodeSeparator() => Increment(1L);

        private void EncodeObjectEnd() => Increment(1L);

        public void EncodeFixed(long byteCount, byte[] value) => EncodeBytes(value);

        public void EncodeEnum<TEnum>(TEnum value) where TEnum : struct, System.Enum => EncodeString(AvroEnumConverter<TEnum>.EnumToString(value));

        public void EncodeRecordStart(string type, int fieldCount) => EncodeObjectStart();

        public void EncodeRecordFieldName(string name) => EncodeObjectMemberName(name);

        public void EncodeRecordFieldSeparator() => EncodeSeparator();

        public void EncodeRecordEnd() => EncodeObjectEnd();

        public void EncodeRecordSeparator() => EncodeSeparator();

        public void EncodeArrayStart(int totalCount, int blockCount, long? blockByteCount = null) => Increment(1L);

        public void EncodeArrayBlockStart(int count, long? byteCount = null) { }

        public void EncodeArrayItemSeparator() => EncodeSeparator();

        public void EncodeArrayEnd() => Increment(1L);

        public void EncodeMapStart(int totalCount, int blockCount, long? blockByteCount = null) => EncodeObjectStart();

        public void EncodeMapBlockStart(int count, long? byteCount = null) { }

        public void EncodeMapKey(string key) => EncodeObjectMemberName(key);

        public void EncodeMapValueSeparator() => EncodeSeparator();

        public void EncodeMapEnd() => EncodeObjectEnd();

        public void EncodeUnionStart(int index, bool isNull)
        {
            if (isNull)
                EncodeNull();
            else
                EncodeObjectStart();
        }

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
