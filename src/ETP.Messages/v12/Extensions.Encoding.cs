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

namespace Energistics.Etp.v12
{
    /// <summary>
    /// Extension methods for encoding.
    /// </summary>
    internal static class EncodingExtensions
    {
        private static ChoiceTypeConverter ChoiceOfArrayOfBooleanArrayOfIntArrayOfLongArrayOfFloatArrayOfDoubleArrayOfStringBytesTypeConverter { get; } = new ChoiceTypeConverter(new string[] { "Energistics.Etp.v12.Datatypes.ArrayOfBoolean", "Energistics.Etp.v12.Datatypes.ArrayOfInt", "Energistics.Etp.v12.Datatypes.ArrayOfLong", "Energistics.Etp.v12.Datatypes.ArrayOfFloat", "Energistics.Etp.v12.Datatypes.ArrayOfDouble", "Energistics.Etp.v12.Datatypes.ArrayOfString", "bytes" }, new Type[] { typeof(Energistics.Etp.v12.Datatypes.ArrayOfBoolean), typeof(Energistics.Etp.v12.Datatypes.ArrayOfInt), typeof(Energistics.Etp.v12.Datatypes.ArrayOfLong), typeof(Energistics.Etp.v12.Datatypes.ArrayOfFloat), typeof(Energistics.Etp.v12.Datatypes.ArrayOfDouble), typeof(Energistics.Etp.v12.Datatypes.ArrayOfString), typeof(byte[]) });
        private static ChoiceTypeConverter ChoiceOfNullBooleanIntLongFloatDoubleStringArrayOfBooleanArrayOfNullableBooleanArrayOfIntArrayOfNullableIntArrayOfLongArrayOfNullableLongArrayOfFloatArrayOfDoubleArrayOfStringArrayOfBytesBytesAnySparseArrayTypeConverter { get; } = new ChoiceTypeConverter(new string[] { "null", "boolean", "int", "long", "float", "double", "string", "Energistics.Etp.v12.Datatypes.ArrayOfBoolean", "Energistics.Etp.v12.Datatypes.ArrayOfNullableBoolean", "Energistics.Etp.v12.Datatypes.ArrayOfInt", "Energistics.Etp.v12.Datatypes.ArrayOfNullableInt", "Energistics.Etp.v12.Datatypes.ArrayOfLong", "Energistics.Etp.v12.Datatypes.ArrayOfNullableLong", "Energistics.Etp.v12.Datatypes.ArrayOfFloat", "Energistics.Etp.v12.Datatypes.ArrayOfDouble", "Energistics.Etp.v12.Datatypes.ArrayOfString", "Energistics.Etp.v12.Datatypes.ArrayOfBytes", "bytes", "Energistics.Etp.v12.Datatypes.AnySparseArray" }, new Type[] { null, typeof(bool), typeof(int), typeof(long), typeof(float), typeof(double), typeof(string), typeof(Energistics.Etp.v12.Datatypes.ArrayOfBoolean), typeof(Energistics.Etp.v12.Datatypes.ArrayOfNullableBoolean), typeof(Energistics.Etp.v12.Datatypes.ArrayOfInt), typeof(Energistics.Etp.v12.Datatypes.ArrayOfNullableInt), typeof(Energistics.Etp.v12.Datatypes.ArrayOfLong), typeof(Energistics.Etp.v12.Datatypes.ArrayOfNullableLong), typeof(Energistics.Etp.v12.Datatypes.ArrayOfFloat), typeof(Energistics.Etp.v12.Datatypes.ArrayOfDouble), typeof(Energistics.Etp.v12.Datatypes.ArrayOfString), typeof(Energistics.Etp.v12.Datatypes.ArrayOfBytes), typeof(byte[]), typeof(Energistics.Etp.v12.Datatypes.AnySparseArray) });
        private static ChoiceTypeConverter ChoiceOfNullLongDoublePassIndexedDepthTypeConverter { get; } = new ChoiceTypeConverter(new string[] { "null", "long", "double", "Energistics.Etp.v12.Datatypes.ChannelData.PassIndexedDepth" }, new Type[] { null, typeof(long), typeof(double), typeof(Energistics.Etp.v12.Datatypes.ChannelData.PassIndexedDepth) });
        private static NullableTypeConverter NullableBooleanNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "boolean");
        private static NullableTypeConverter NullableErrorInfoNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "Energistics.Etp.v12.Datatypes.ErrorInfo");
        private static NullableTypeConverter NullableActiveStatusKindNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind");
        private static NullableTypeConverter NullableIntNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "int");
        private static NullableTypeConverter NullableUuidGuidAsFixedNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "Energistics.Etp.v12.Datatypes.Uuid");
        private static NullableTypeConverter NullableTimestampMicrosDateTimeAsLongNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "long");
        private static NullableTypeConverter NullableLongNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "long");
        public static void EncodeChoiceOfArrayOfBooleanArrayOfIntArrayOfLongArrayOfFloatArrayOfDoubleArrayOfStringBytes(this IAvroEncoder encoder, object value, IChoiceTypeConverter converter)
        {
            var isNull = value == null;
            var index = converter.ValueToTypeIndex(value);
            encoder.EncodeUnionStart(index, converter);
            switch (index)
            {
                case 0: encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfBoolean>((Energistics.Etp.v12.Datatypes.ArrayOfBoolean)value); break;
                case 1: encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfInt>((Energistics.Etp.v12.Datatypes.ArrayOfInt)value); break;
                case 2: encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfLong>((Energistics.Etp.v12.Datatypes.ArrayOfLong)value); break;
                case 3: encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfFloat>((Energistics.Etp.v12.Datatypes.ArrayOfFloat)value); break;
                case 4: encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfDouble>((Energistics.Etp.v12.Datatypes.ArrayOfDouble)value); break;
                case 5: encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfString>((Energistics.Etp.v12.Datatypes.ArrayOfString)value); break;
                case 6: encoder.EncodeBytes((byte[])value); break;
                default: throw new System.IO.InvalidDataException($"Unexpected type: {value?.GetType().FullName}");
            }
            encoder.EncodeUnionEnd(isNull);
        }
        public static object DecodeChoiceOfArrayOfBooleanArrayOfIntArrayOfLongArrayOfFloatArrayOfDoubleArrayOfStringBytes(this IAvroDecoder decoder, IChoiceTypeConverter converter)
        {
            object value;
            var index = decoder.DecodeUnionStart(converter);
            switch (index)
            {
                case 0: value = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfBoolean>(); break;
                case 1: value = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfInt>(); break;
                case 2: value = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfLong>(); break;
                case 3: value = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfFloat>(); break;
                case 4: value = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfDouble>(); break;
                case 5: value = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfString>(); break;
                case 6: value = decoder.DecodeBytes(); break;
                default: throw new System.IO.InvalidDataException($"Unexpected type index: {index}");
            }
            var isNull = value == null;
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static void EncodeChoiceOfNullBooleanIntLongFloatDoubleStringArrayOfBooleanArrayOfNullableBooleanArrayOfIntArrayOfNullableIntArrayOfLongArrayOfNullableLongArrayOfFloatArrayOfDoubleArrayOfStringArrayOfBytesBytesAnySparseArray(this IAvroEncoder encoder, object value, IChoiceTypeConverter converter)
        {
            var isNull = value == null;
            var index = converter.ValueToTypeIndex(value);
            encoder.EncodeUnionStart(index, converter);
            switch (index)
            {
                case 0: encoder.EncodeNull(); break;
                case 1: encoder.EncodeBoolean((bool)value); break;
                case 2: encoder.EncodeInt((int)value); break;
                case 3: encoder.EncodeLong((long)value); break;
                case 4: encoder.EncodeFloat((float)value); break;
                case 5: encoder.EncodeDouble((double)value); break;
                case 6: encoder.EncodeString((string)value); break;
                case 7: encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfBoolean>((Energistics.Etp.v12.Datatypes.ArrayOfBoolean)value); break;
                case 8: encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfNullableBoolean>((Energistics.Etp.v12.Datatypes.ArrayOfNullableBoolean)value); break;
                case 9: encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfInt>((Energistics.Etp.v12.Datatypes.ArrayOfInt)value); break;
                case 10: encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfNullableInt>((Energistics.Etp.v12.Datatypes.ArrayOfNullableInt)value); break;
                case 11: encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfLong>((Energistics.Etp.v12.Datatypes.ArrayOfLong)value); break;
                case 12: encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfNullableLong>((Energistics.Etp.v12.Datatypes.ArrayOfNullableLong)value); break;
                case 13: encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfFloat>((Energistics.Etp.v12.Datatypes.ArrayOfFloat)value); break;
                case 14: encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfDouble>((Energistics.Etp.v12.Datatypes.ArrayOfDouble)value); break;
                case 15: encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfString>((Energistics.Etp.v12.Datatypes.ArrayOfString)value); break;
                case 16: encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfBytes>((Energistics.Etp.v12.Datatypes.ArrayOfBytes)value); break;
                case 17: encoder.EncodeBytes((byte[])value); break;
                case 18: encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.AnySparseArray>((Energistics.Etp.v12.Datatypes.AnySparseArray)value); break;
                default: throw new System.IO.InvalidDataException($"Unexpected type: {value?.GetType().FullName}");
            }
            encoder.EncodeUnionEnd(isNull);
        }
        public static object DecodeChoiceOfNullBooleanIntLongFloatDoubleStringArrayOfBooleanArrayOfNullableBooleanArrayOfIntArrayOfNullableIntArrayOfLongArrayOfNullableLongArrayOfFloatArrayOfDoubleArrayOfStringArrayOfBytesBytesAnySparseArray(this IAvroDecoder decoder, IChoiceTypeConverter converter)
        {
            object value;
            var index = decoder.DecodeUnionStart(converter);
            switch (index)
            {
                case 0: value = decoder.DecodeNullClass<object>(); break;
                case 1: value = decoder.DecodeBoolean(); break;
                case 2: value = decoder.DecodeInt(); break;
                case 3: value = decoder.DecodeLong(); break;
                case 4: value = decoder.DecodeFloat(); break;
                case 5: value = decoder.DecodeDouble(); break;
                case 6: value = decoder.DecodeString(); break;
                case 7: value = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfBoolean>(); break;
                case 8: value = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfNullableBoolean>(); break;
                case 9: value = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfInt>(); break;
                case 10: value = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfNullableInt>(); break;
                case 11: value = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfLong>(); break;
                case 12: value = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfNullableLong>(); break;
                case 13: value = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfFloat>(); break;
                case 14: value = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfDouble>(); break;
                case 15: value = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfString>(); break;
                case 16: value = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfBytes>(); break;
                case 17: value = decoder.DecodeBytes(); break;
                case 18: value = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.AnySparseArray>(); break;
                default: throw new System.IO.InvalidDataException($"Unexpected type index: {index}");
            }
            var isNull = value == null;
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static void EncodeChoiceOfNullLongDoublePassIndexedDepth(this IAvroEncoder encoder, object value, IChoiceTypeConverter converter)
        {
            var isNull = value == null;
            var index = converter.ValueToTypeIndex(value);
            encoder.EncodeUnionStart(index, converter);
            switch (index)
            {
                case 0: encoder.EncodeNull(); break;
                case 1: encoder.EncodeLong((long)value); break;
                case 2: encoder.EncodeDouble((double)value); break;
                case 3: encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.PassIndexedDepth>((Energistics.Etp.v12.Datatypes.ChannelData.PassIndexedDepth)value); break;
                default: throw new System.IO.InvalidDataException($"Unexpected type: {value?.GetType().FullName}");
            }
            encoder.EncodeUnionEnd(isNull);
        }
        public static object DecodeChoiceOfNullLongDoublePassIndexedDepth(this IAvroDecoder decoder, IChoiceTypeConverter converter)
        {
            object value;
            var index = decoder.DecodeUnionStart(converter);
            switch (index)
            {
                case 0: value = decoder.DecodeNullClass<object>(); break;
                case 1: value = decoder.DecodeLong(); break;
                case 2: value = decoder.DecodeDouble(); break;
                case 3: value = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.PassIndexedDepth>(); break;
                default: throw new System.IO.InvalidDataException($"Unexpected type index: {index}");
            }
            var isNull = value == null;
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static void EncodeArrayOfNullableBoolean(this IAvroEncoder encoder, IList<bool?> array, INullableTypeConverter nestedConverter)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeNullableBoolean(v, nestedConverter);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static IList<bool?> DecodeArrayOfNullableBoolean(this IAvroDecoder decoder, INullableTypeConverter nestedConverter)
        {
            IList<bool?> array = new List<bool?>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeNullableBoolean(nestedConverter));
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static void EncodeArrayOfNullableInt(this IAvroEncoder encoder, IList<int?> array, INullableTypeConverter nestedConverter)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeNullableInt(v, nestedConverter);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static IList<int?> DecodeArrayOfNullableInt(this IAvroDecoder decoder, INullableTypeConverter nestedConverter)
        {
            IList<int?> array = new List<int?>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeNullableInt(nestedConverter));
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static void EncodeArrayOfNullableLong(this IAvroEncoder encoder, IList<long?> array, INullableTypeConverter nestedConverter)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeNullableLong(v, nestedConverter);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static IList<long?> DecodeArrayOfNullableLong(this IAvroDecoder decoder, INullableTypeConverter nestedConverter)
        {
            IList<long?> array = new List<long?>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeNullableLong(nestedConverter));
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static void EncodeMapOfArrayOfAvroObject<TAvroObject>(this IAvroEncoder encoder, IDictionary<string, IList<TAvroObject>> map)
            where TAvroObject : class, IAvroObject, new()
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeArrayOfAvroObject<TAvroObject>(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static IDictionary<string, IList<TAvroObject>> DecodeMapOfArrayOfAvroObject<TAvroObject>(this IAvroDecoder decoder)
            where TAvroObject : class, IAvroObject, new()
        {
            IDictionary<string, IList<TAvroObject>> map = new Dictionary<string, IList<TAvroObject>>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeArrayOfAvroObject<TAvroObject>();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
    }
}
