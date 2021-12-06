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

namespace Energistics.Etp.v11
{
    /// <summary>
    /// Extension methods for encoding.
    /// </summary>
    internal static class EncodingExtensions
    {
        private static ChoiceTypeConverter ChoiceOfNullArrayOfBooleanBytesArrayOfIntArrayOfLongArrayOfFloatArrayOfDoubleTypeConverter { get; } = new ChoiceTypeConverter(new string[] { "null", "Energistics.Datatypes.ArrayOfBoolean", "bytes", "Energistics.Datatypes.ArrayOfInt", "Energistics.Datatypes.ArrayOfLong", "Energistics.Datatypes.ArrayOfFloat", "Energistics.Datatypes.ArrayOfDouble" }, new Type[] { null, typeof(Energistics.Etp.v11.Datatypes.ArrayOfBoolean), typeof(byte[]), typeof(Energistics.Etp.v11.Datatypes.ArrayOfInt), typeof(Energistics.Etp.v11.Datatypes.ArrayOfLong), typeof(Energistics.Etp.v11.Datatypes.ArrayOfFloat), typeof(Energistics.Etp.v11.Datatypes.ArrayOfDouble) });
        private static ChoiceTypeConverter ChoiceOfNullDoubleFloatIntLongStringArrayOfDoubleBooleanBytesTypeConverter { get; } = new ChoiceTypeConverter(new string[] { "null", "double", "float", "int", "long", "string", "Energistics.Datatypes.ArrayOfDouble", "boolean", "bytes" }, new Type[] { null, typeof(double), typeof(float), typeof(int), typeof(long), typeof(string), typeof(Energistics.Etp.v11.Datatypes.ArrayOfDouble), typeof(bool), typeof(byte[]) });
        private static ChoiceTypeConverter ChoiceOfNullIntLongTypeConverter { get; } = new ChoiceTypeConverter(new string[] { "null", "int", "long" }, new Type[] { null, typeof(int), typeof(long) });
        private static ChoiceTypeConverter ChoiceOfNullLongDoubleTypeConverter { get; } = new ChoiceTypeConverter(new string[] { "null", "long", "double" }, new Type[] { null, typeof(long), typeof(double) });
        private static NullableTypeConverter NullableDataObjectNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "Energistics.Datatypes.Object.DataObject");
        private static NullableTypeConverter NullableUuidGuidAsRfc4122StringNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "string");
        private static NullableTypeConverter NullableLongNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "long");
        private static NullableTypeConverter NullableStringNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "string");
        public static void EncodeChoiceOfNullArrayOfBooleanBytesArrayOfIntArrayOfLongArrayOfFloatArrayOfDouble(this IAvroEncoder encoder, object value, IChoiceTypeConverter converter)
        {
            var isNull = value == null;
            var index = converter.ValueToTypeIndex(value);
            encoder.EncodeUnionStart(index, converter);
            switch (index)
            {
                case 0: encoder.EncodeNull(); break;
                case 1: encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.ArrayOfBoolean>((Energistics.Etp.v11.Datatypes.ArrayOfBoolean)value); break;
                case 2: encoder.EncodeBytes((byte[])value); break;
                case 3: encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.ArrayOfInt>((Energistics.Etp.v11.Datatypes.ArrayOfInt)value); break;
                case 4: encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.ArrayOfLong>((Energistics.Etp.v11.Datatypes.ArrayOfLong)value); break;
                case 5: encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.ArrayOfFloat>((Energistics.Etp.v11.Datatypes.ArrayOfFloat)value); break;
                case 6: encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.ArrayOfDouble>((Energistics.Etp.v11.Datatypes.ArrayOfDouble)value); break;
                default: throw new System.IO.InvalidDataException($"Unexpected type: {value?.GetType().FullName}");
            }
            encoder.EncodeUnionEnd(isNull);
        }
        public static object DecodeChoiceOfNullArrayOfBooleanBytesArrayOfIntArrayOfLongArrayOfFloatArrayOfDouble(this IAvroDecoder decoder, IChoiceTypeConverter converter)
        {
            object value;
            var index = decoder.DecodeUnionStart(converter);
            switch (index)
            {
                case 0: value = decoder.DecodeNullClass<object>(); break;
                case 1: value = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.ArrayOfBoolean>(); break;
                case 2: value = decoder.DecodeBytes(); break;
                case 3: value = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.ArrayOfInt>(); break;
                case 4: value = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.ArrayOfLong>(); break;
                case 5: value = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.ArrayOfFloat>(); break;
                case 6: value = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.ArrayOfDouble>(); break;
                default: throw new System.IO.InvalidDataException($"Unexpected type index: {index}");
            }
            var isNull = value == null;
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static void EncodeChoiceOfNullDoubleFloatIntLongStringArrayOfDoubleBooleanBytes(this IAvroEncoder encoder, object value, IChoiceTypeConverter converter)
        {
            var isNull = value == null;
            var index = converter.ValueToTypeIndex(value);
            encoder.EncodeUnionStart(index, converter);
            switch (index)
            {
                case 0: encoder.EncodeNull(); break;
                case 1: encoder.EncodeDouble((double)value); break;
                case 2: encoder.EncodeFloat((float)value); break;
                case 3: encoder.EncodeInt((int)value); break;
                case 4: encoder.EncodeLong((long)value); break;
                case 5: encoder.EncodeString((string)value); break;
                case 6: encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.ArrayOfDouble>((Energistics.Etp.v11.Datatypes.ArrayOfDouble)value); break;
                case 7: encoder.EncodeBoolean((bool)value); break;
                case 8: encoder.EncodeBytes((byte[])value); break;
                default: throw new System.IO.InvalidDataException($"Unexpected type: {value?.GetType().FullName}");
            }
            encoder.EncodeUnionEnd(isNull);
        }
        public static object DecodeChoiceOfNullDoubleFloatIntLongStringArrayOfDoubleBooleanBytes(this IAvroDecoder decoder, IChoiceTypeConverter converter)
        {
            object value;
            var index = decoder.DecodeUnionStart(converter);
            switch (index)
            {
                case 0: value = decoder.DecodeNullClass<object>(); break;
                case 1: value = decoder.DecodeDouble(); break;
                case 2: value = decoder.DecodeFloat(); break;
                case 3: value = decoder.DecodeInt(); break;
                case 4: value = decoder.DecodeLong(); break;
                case 5: value = decoder.DecodeString(); break;
                case 6: value = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.ArrayOfDouble>(); break;
                case 7: value = decoder.DecodeBoolean(); break;
                case 8: value = decoder.DecodeBytes(); break;
                default: throw new System.IO.InvalidDataException($"Unexpected type index: {index}");
            }
            var isNull = value == null;
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static void EncodeChoiceOfNullIntLong(this IAvroEncoder encoder, object value, IChoiceTypeConverter converter)
        {
            var isNull = value == null;
            var index = converter.ValueToTypeIndex(value);
            encoder.EncodeUnionStart(index, converter);
            switch (index)
            {
                case 0: encoder.EncodeNull(); break;
                case 1: encoder.EncodeInt((int)value); break;
                case 2: encoder.EncodeLong((long)value); break;
                default: throw new System.IO.InvalidDataException($"Unexpected type: {value?.GetType().FullName}");
            }
            encoder.EncodeUnionEnd(isNull);
        }
        public static object DecodeChoiceOfNullIntLong(this IAvroDecoder decoder, IChoiceTypeConverter converter)
        {
            object value;
            var index = decoder.DecodeUnionStart(converter);
            switch (index)
            {
                case 0: value = decoder.DecodeNullClass<object>(); break;
                case 1: value = decoder.DecodeInt(); break;
                case 2: value = decoder.DecodeLong(); break;
                default: throw new System.IO.InvalidDataException($"Unexpected type index: {index}");
            }
            var isNull = value == null;
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static void EncodeChoiceOfNullLongDouble(this IAvroEncoder encoder, object value, IChoiceTypeConverter converter)
        {
            var isNull = value == null;
            var index = converter.ValueToTypeIndex(value);
            encoder.EncodeUnionStart(index, converter);
            switch (index)
            {
                case 0: encoder.EncodeNull(); break;
                case 1: encoder.EncodeLong((long)value); break;
                case 2: encoder.EncodeDouble((double)value); break;
                default: throw new System.IO.InvalidDataException($"Unexpected type: {value?.GetType().FullName}");
            }
            encoder.EncodeUnionEnd(isNull);
        }
        public static object DecodeChoiceOfNullLongDouble(this IAvroDecoder decoder, IChoiceTypeConverter converter)
        {
            object value;
            var index = decoder.DecodeUnionStart(converter);
            switch (index)
            {
                case 0: value = decoder.DecodeNullClass<object>(); break;
                case 1: value = decoder.DecodeLong(); break;
                case 2: value = decoder.DecodeDouble(); break;
                default: throw new System.IO.InvalidDataException($"Unexpected type index: {index}");
            }
            var isNull = value == null;
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
    }
}
