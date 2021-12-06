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

using Energistics.CodeGen.Avro.Code.TypeInfos;
using Energistics.CodeGen.Code;
using System.Collections.Generic;

namespace Energistics.CodeGen.Avro.Code
{
    /// <summary>
    /// Helper extension methods for <see cref="CodeWriter"/>s for Avro code generation.
    /// </summary>
    public static class AvroCodeWriterExtensions
    {
        public static List<string> GetTypeConverters(this TypeInfo typeInfo) => typeInfo.GetTypeConvertersInternal();
        public static void DeclareEncodeAvroObject(this CodeWriter writer) => writer.DeclareEncodeAvroObjectInternal();
        public static void DeclarDecodeAvroObject(this CodeWriter writer) => writer.DeclareDecodeAvroObjectInternal();
        public static void DeclareAvroFixedEncode(this CodeWriter writer, FixedInfo fixedInfo) => writer.DeclareAvroFixedEncodeInternal(fixedInfo);
        public static void DeclareAvroFixedDecode(this CodeWriter writer, FixedInfo fixedInfo) => writer.DeclareAvroFixedDecodeInternal(fixedInfo);
        public static void DeclareAvroRecordEncode(this CodeWriter writer, RecordInfo recordInfo) => writer.DeclareAvroRecordEncodeInternal(recordInfo);
        public static void DeclareAvroRecordDecode(this CodeWriter writer, RecordInfo recordInfo) => writer.DeclareAvroRecordDecodeInternal(recordInfo);
        public static void DeclareEncodeNullable(this CodeWriter writer, NullableInfo nullableInfo) => writer.DeclareEncodeNullableInternal(nullableInfo);
        public static void DeclareDecodeNullable(this CodeWriter writer, NullableInfo nullableInfo) => writer.DeclareDecodeNullableInternal(nullableInfo);
        public static void DeclareNullableTypeConverter(this CodeWriter writer, NullableInfo nullableInfo, bool @internal = false) => writer.DeclareNullableTypeConverterInternal(nullableInfo, @internal);
        public static void DeclareEncodeChoice(this CodeWriter writer, ChoiceInfo choiceInfo) => writer.DeclareEncodeChoiceInternal(choiceInfo);
        public static void DeclareDecodeChoice(this CodeWriter writer, ChoiceInfo choiceInfo) => writer.DeclareDecodeChoiceInternal(choiceInfo);
        public static void DeclareChoiceTypeConverter(this CodeWriter writer, ChoiceInfo choiceInfo, bool @internal = false) => writer.DeclareChoiceTypeConverterInternal(choiceInfo, @internal);
        public static void DeclareEncodeArray(this CodeWriter writer, ArrayInfo arrayInfo) => writer.DeclareEncodeCollectionInternal(arrayInfo);
        public static void DeclareDecodeArray(this CodeWriter writer, ArrayInfo arrayInfo) => writer.DeclareDecodeCollectionInternal(arrayInfo);
        public static void DeclareEncodeMap(this CodeWriter writer, MapInfo mapInfo) => writer.DeclareEncodeCollectionInternal(mapInfo);
        public static void DeclareDecodeMap(this CodeWriter writer, MapInfo mapInfo) => writer.DeclareDecodeCollectionInternal(mapInfo);

    }
}
