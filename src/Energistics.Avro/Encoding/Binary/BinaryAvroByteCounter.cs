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

namespace Energistics.Avro.Encoding.Binary
{
    /// <summary>
    /// A class for counting the bytes required for binary Avro encoding
    /// </summary>
    public class BinaryAvroByteCounter : BinaryPrimitiveByteCounter, IAvroByteCounter
    {
        private void EncodeBlockStart(int count, long? byteCount)
        {
            if (byteCount == null)
                EncodeInt(count);
            else
            {
                EncodeInt(-count);
                EncodeLong(byteCount.Value);
            }
        }

        public void EncodeFixed(long byteCount, byte[] value) => Increment(value.Length);

        public void EncodeEnum<TEnum>(TEnum value) where TEnum : struct, System.Enum => EncodeInt(AvroEnumConverter<TEnum>.EnumToInt(value));

        public void EncodeRecordStart(string type, int fieldCount) { }

        public void EncodeRecordFieldName(string name) { }

        public void EncodeRecordFieldSeparator() { }

        public void EncodeRecordEnd() { }

        public void EncodeRecordSeparator() { }

        public void EncodeArrayStart(int totalCount, int blockCount, long? blockByteCount = null) => EncodeBlockStart(blockCount, blockByteCount);

        public void EncodeArrayBlockStart(int count, long? byteCount = null) => EncodeBlockStart(count, byteCount);

        public void EncodeArrayItemSeparator() { }

        public void EncodeArrayEnd() { }

        public void EncodeMapStart(int totalCount, int blockCount, long? blockByteCount = null) => EncodeBlockStart(blockCount, blockByteCount);

        public void EncodeMapBlockStart(int count, long? byteCount = null) => EncodeBlockStart(count, byteCount);

        public void EncodeMapKey(string key) => EncodeString(key);

        public void EncodeMapValueSeparator() { }

        public void EncodeMapEnd() { }

        public void EncodeUnionStart(int typeIndex, IChoiceTypeConverter converter) => EncodeUnionStart(typeIndex);

        public void EncodeUnionStart(bool isNull, INullableTypeConverter converter) => EncodeUnionStart(converter.IsNullToTypeIndex(isNull));

        private void EncodeUnionStart(int typeIndex) => EncodeInt(typeIndex);

        public void EncodeUnionEnd(bool isNull) { }
    }
}
