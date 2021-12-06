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
// 
//-----------------------------------------------------------------------
// This code has been automatically generated.
// Changes will be lost the next time it is regenerated.
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Energistics.Avro;
using Energistics.Avro.Encoding;

namespace Energistics.Avro.Encoding.TestObjects
{
    /// <summary>
    /// Extension methods for encoding.
    /// </summary>
    internal static class EncodingExtensions
    {
        internal static ChoiceTypeConverter ChoiceOfIntArrayOfIntMapOfIntTestEnumTestFixedTestSimpleRecordTypeConverter { get; } = new ChoiceTypeConverter(new string[] { "int", "array", "map", "Energistics.Avro.Encoding.TestObjects.TestEnum", "Energistics.Avro.Encoding.TestObjects.TestFixed", "Energistics.Avro.Encoding.TestObjects.TestSimpleRecord" }, new Type[] { typeof(int), typeof(IList<int>), typeof(IDictionary<string, int>), typeof(Energistics.Avro.Encoding.TestObjects.TestEnum), typeof(Energistics.Avro.Encoding.TestObjects.TestFixed), typeof(Energistics.Avro.Encoding.TestObjects.TestSimpleRecord) });
        internal static NullableTypeConverter NullableBooleanValueFirstTypeConverter { get; } = new NullableTypeConverter(false, "boolean");
        internal static NullableTypeConverter NullableBytesValueFirstTypeConverter { get; } = new NullableTypeConverter(false, "bytes");
        internal static NullableTypeConverter NullableDoubleValueFirstTypeConverter { get; } = new NullableTypeConverter(false, "double");
        internal static NullableTypeConverter NullableTestEnumValueFirstTypeConverter { get; } = new NullableTypeConverter(false, "Energistics.Avro.Encoding.TestObjects.TestEnum");
        internal static NullableTypeConverter NullableTestFixedValueFirstTypeConverter { get; } = new NullableTypeConverter(false, "Energistics.Avro.Encoding.TestObjects.TestFixed");
        internal static NullableTypeConverter NullableTestSimpleRecordValueFirstTypeConverter { get; } = new NullableTypeConverter(false, "Energistics.Avro.Encoding.TestObjects.TestSimpleRecord");
        internal static NullableTypeConverter NullableFloatValueFirstTypeConverter { get; } = new NullableTypeConverter(false, "float");
        internal static NullableTypeConverter NullableIntValueFirstTypeConverter { get; } = new NullableTypeConverter(false, "int");
        internal static NullableTypeConverter NullableLongValueFirstTypeConverter { get; } = new NullableTypeConverter(false, "long");
        internal static NullableTypeConverter NullableBooleanNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "boolean");
        internal static NullableTypeConverter NullableBytesNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "bytes");
        internal static NullableTypeConverter NullableDoubleNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "double");
        internal static NullableTypeConverter NullableTestEnumNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "Energistics.Avro.Encoding.TestObjects.TestEnum");
        internal static NullableTypeConverter NullableTestFixedNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "Energistics.Avro.Encoding.TestObjects.TestFixed");
        internal static NullableTypeConverter NullableTestSimpleRecordNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "Energistics.Avro.Encoding.TestObjects.TestSimpleRecord");
        internal static NullableTypeConverter NullableFloatNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "float");
        internal static NullableTypeConverter NullableIntNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "int");
        internal static NullableTypeConverter NullableLongNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "long");
        internal static NullableTypeConverter NullableStringNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "string");
        internal static NullableTypeConverter NullableStringValueFirstTypeConverter { get; } = new NullableTypeConverter(false, "string");
        public static void EncodeChoiceOfIntArrayOfIntMapOfIntTestEnumTestFixedTestSimpleRecord(this IAvroEncoder encoder, object value, IChoiceTypeConverter converter)
        {
            var isNull = value == null;
            var index = converter.ValueToTypeIndex(value);
            encoder.EncodeUnionStart(index, converter);
            switch (index)
            {
                case 0: encoder.EncodeInt((int)value); break;
                case 1: encoder.EncodeArrayOfInt((IList<int>)value); break;
                case 2: encoder.EncodeMapOfInt((IDictionary<string, int>)value); break;
                case 3: encoder.EncodeEnum<Energistics.Avro.Encoding.TestObjects.TestEnum>((Energistics.Avro.Encoding.TestObjects.TestEnum)value); break;
                case 4: encoder.EncodeAvroObject<Energistics.Avro.Encoding.TestObjects.TestFixed>((Energistics.Avro.Encoding.TestObjects.TestFixed)value); break;
                case 5: encoder.EncodeAvroObject<Energistics.Avro.Encoding.TestObjects.TestSimpleRecord>((Energistics.Avro.Encoding.TestObjects.TestSimpleRecord)value); break;
                default: throw new System.IO.InvalidDataException($"Unexpected type: {value?.GetType().FullName}");
            }
            encoder.EncodeUnionEnd(isNull);
        }
        public static object DecodeChoiceOfIntArrayOfIntMapOfIntTestEnumTestFixedTestSimpleRecord(this IAvroDecoder decoder, IChoiceTypeConverter converter)
        {
            object value;
            var index = decoder.DecodeUnionStart(converter);
            switch (index)
            {
                case 0: value = decoder.DecodeInt(); break;
                case 1: value = decoder.DecodeArrayOfInt(); break;
                case 2: value = decoder.DecodeMapOfInt(); break;
                case 3: value = decoder.DecodeEnum<Energistics.Avro.Encoding.TestObjects.TestEnum>(); break;
                case 4: value = decoder.DecodeAvroObject<Energistics.Avro.Encoding.TestObjects.TestFixed>(); break;
                case 5: value = decoder.DecodeAvroObject<Energistics.Avro.Encoding.TestObjects.TestSimpleRecord>(); break;
                default: throw new System.IO.InvalidDataException($"Unexpected type index: {index}");
            }
            var isNull = value == null;
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
    }
}
