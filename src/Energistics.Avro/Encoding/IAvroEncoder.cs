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

namespace Energistics.Avro.Encoding
{
    /// <summary>
    /// An interface for encoding Avro data
    /// </summary>
    public interface IAvroEncoder : IPrimitiveEncoder
    {
        void EncodeFixed(long byteCount, byte[] bytes);
        void EncodeEnum<TEnum>(TEnum value) where TEnum : struct, System.Enum;
        void EncodeRecordStart(string type, int fieldCount);
        void EncodeRecordFieldName(string name);
        void EncodeRecordFieldSeparator();
        void EncodeRecordEnd();
        void EncodeRecordSeparator();
        void EncodeArrayStart(int totalCount, int blockCount, long? blockByteCount = null);
        void EncodeArrayBlockStart(int count, long? byteCount = null);
        void EncodeArrayItemSeparator();
        void EncodeArrayEnd();
        void EncodeMapStart(int totalCount, int blockCount, long? blockByteCount = null);
        void EncodeMapBlockStart(int count, long? byteCount = null);
        void EncodeMapKey(string key);
        void EncodeMapValueSeparator();
        void EncodeMapEnd();
        void EncodeUnionStart(int typeIndex, IChoiceTypeConverter converter);
        void EncodeUnionStart(bool isNull, INullableTypeConverter converter);
        void EncodeUnionEnd(bool isNull);
    }
}
