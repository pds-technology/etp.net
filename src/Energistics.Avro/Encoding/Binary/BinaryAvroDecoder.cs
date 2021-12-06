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

namespace Energistics.Avro.Encoding.Binary
{
    /// <summary>
    /// A class for binary Avro decoding
    /// </summary>
    public class BinaryAvroDecoder : BinaryPrimitiveDecoder, IAvroDecoder
    {
        public BinaryAvroDecoder(byte[] bytes)
            : base(bytes)
        {
        }

        public BinaryAvroDecoder(Stream stream)
            : base(stream)
        {
        }

        private int DecodeBlockStart()
        {
            var blockCount = DecodeLong();
            if (blockCount < 0)
            {
                blockCount = -blockCount;
                DecodeLong(); // Ignore block size
            }

            if (blockCount > int.MaxValue) throw new InvalidDataException("Max block count exceeded.");

            return (int)blockCount;
        }

        public byte[] DecodeFixed(long byteCount)
        {
            if (byteCount > int.MaxValue) throw new InvalidDataException("Max byte array length exceeded.");

            return DecodeRaw((int)byteCount);
        }

        public TEnum DecodeEnum<TEnum>() where TEnum : struct, System.Enum => AvroEnumConverter<TEnum>.IntToEnum(DecodeInt());

        public void DecodeRecordStart(string type, int fieldCount) { }

        public void DecodeRecordFieldName(string name) { }

        public void DecodeRecordFieldSeparator() { }

        public void DecodeRecordEnd() { }

        public void DecodeRecordSeparator() { }

        public int DecodeArrayStart() => DecodeBlockStart();

        public int DecodeArrayBlockStart() => DecodeBlockStart();

        public void DecodeArrayItemSeparator() { }

        public void DecodeArrayEnd() { }

        public int DecodeMapStart() => DecodeBlockStart();

        public int DecodeMapBlockStart() => DecodeBlockStart();

        public string DecodeMapKey() => DecodeString();

        public void DecodeMapValueSeparator() { }

        public void DecodeMapEnd() { }

        public int DecodeUnionStart(IChoiceTypeConverter converter) => DecodeUnionStart();

        public bool DecodeUnionStart(INullableTypeConverter converter) => converter.TypeIndexToIsNull(DecodeUnionStart());

        private int DecodeUnionStart() => DecodeInt();

        public void DecodeUnionEnd(bool isNull) { }
    }
}
