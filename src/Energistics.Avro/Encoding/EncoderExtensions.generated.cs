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

namespace Energistics.Avro.Encoding
{
    /// <summary>
    /// Extension methods for encoders.
    /// </summary>
    public static partial class EncoderExtensions
    {
        public static void EncodeAvroObject<TAvroObject>(this IAvroEncoder encoder, IAvroObject @object) where TAvroObject : class, IAvroObject, new() => @object.Encode(encoder);
        public static void EncodeNullableBoolean(this IAvroEncoder encoder, bool? value, INullableTypeConverter converter)
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeBoolean(value.Value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfBoolean(this IAvroEncoder encoder, IList<bool> array)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeBoolean(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfBoolean(this IAvroEncoder encoder, IDictionary<string, bool> map)
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeBoolean(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableInt(this IAvroEncoder encoder, int? value, INullableTypeConverter converter)
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeInt(value.Value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfInt(this IAvroEncoder encoder, IList<int> array)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeInt(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfInt(this IAvroEncoder encoder, IDictionary<string, int> map)
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeInt(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableLong(this IAvroEncoder encoder, long? value, INullableTypeConverter converter)
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeLong(value.Value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfLong(this IAvroEncoder encoder, IList<long> array)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeLong(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfLong(this IAvroEncoder encoder, IDictionary<string, long> map)
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeLong(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableFloat(this IAvroEncoder encoder, float? value, INullableTypeConverter converter)
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeFloat(value.Value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfFloat(this IAvroEncoder encoder, IList<float> array)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeFloat(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfFloat(this IAvroEncoder encoder, IDictionary<string, float> map)
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeFloat(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableDouble(this IAvroEncoder encoder, double? value, INullableTypeConverter converter)
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeDouble(value.Value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfDouble(this IAvroEncoder encoder, IList<double> array)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeDouble(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfDouble(this IAvroEncoder encoder, IDictionary<string, double> map)
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeDouble(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableString(this IAvroEncoder encoder, string value, INullableTypeConverter converter)
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeString(value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfString(this IAvroEncoder encoder, IList<string> array)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeString(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfString(this IAvroEncoder encoder, IDictionary<string, string> map)
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeString(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableBytes(this IAvroEncoder encoder, byte[] value, INullableTypeConverter converter)
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeBytes(value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfBytes(this IAvroEncoder encoder, IList<byte[]> array)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeBytes(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfBytes(this IAvroEncoder encoder, IDictionary<string, byte[]> map)
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeBytes(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableAvroObject<TAvroObject>(this IAvroEncoder encoder, TAvroObject value, INullableTypeConverter converter)
            where TAvroObject : class, IAvroObject, new()
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeAvroObject<TAvroObject>(value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfAvroObject<TAvroObject>(this IAvroEncoder encoder, IList<TAvroObject> array)
            where TAvroObject : class, IAvroObject, new()
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeAvroObject<TAvroObject>(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfAvroObject<TAvroObject>(this IAvroEncoder encoder, IDictionary<string, TAvroObject> map)
            where TAvroObject : class, IAvroObject, new()
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeAvroObject<TAvroObject>(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableEnum<TEnum>(this IAvroEncoder encoder, TEnum? value, INullableTypeConverter converter)
            where TEnum : struct, System.Enum
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeEnum<TEnum>(value.Value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfEnum<TEnum>(this IAvroEncoder encoder, IList<TEnum> array)
            where TEnum : struct, System.Enum
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeEnum<TEnum>(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfEnum<TEnum>(this IAvroEncoder encoder, IDictionary<string, TEnum> map)
            where TEnum : struct, System.Enum
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeEnum<TEnum>(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableDateDateTimeAsInt(this IAvroEncoder encoder, System.DateTime? value, INullableTypeConverter converter)
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeDateDateTimeAsInt(value.Value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfDateDateTimeAsInt(this IAvroEncoder encoder, IList<System.DateTime> array)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeDateDateTimeAsInt(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfDateDateTimeAsInt(this IAvroEncoder encoder, IDictionary<string, System.DateTime> map)
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeDateDateTimeAsInt(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableDurationTimeSpanAsIso8601String(this IAvroEncoder encoder, System.TimeSpan? value, INullableTypeConverter converter)
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeDurationTimeSpanAsIso8601String(value.Value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfDurationTimeSpanAsIso8601String(this IAvroEncoder encoder, IList<System.TimeSpan> array)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeDurationTimeSpanAsIso8601String(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfDurationTimeSpanAsIso8601String(this IAvroEncoder encoder, IDictionary<string, System.TimeSpan> map)
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeDurationTimeSpanAsIso8601String(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableDurationTimeSpanAsFixed(this IAvroEncoder encoder, System.TimeSpan? value, INullableTypeConverter converter)
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeDurationTimeSpanAsFixed(value.Value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfDurationTimeSpanAsFixed(this IAvroEncoder encoder, IList<System.TimeSpan> array)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeDurationTimeSpanAsFixed(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfDurationTimeSpanAsFixed(this IAvroEncoder encoder, IDictionary<string, System.TimeSpan> map)
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeDurationTimeSpanAsFixed(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableLocalTimestampMicrosDateTimeAsLong(this IAvroEncoder encoder, System.DateTime? value, INullableTypeConverter converter)
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeLocalTimestampMicrosDateTimeAsLong(value.Value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfLocalTimestampMicrosDateTimeAsLong(this IAvroEncoder encoder, IList<System.DateTime> array)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeLocalTimestampMicrosDateTimeAsLong(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfLocalTimestampMicrosDateTimeAsLong(this IAvroEncoder encoder, IDictionary<string, System.DateTime> map)
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeLocalTimestampMicrosDateTimeAsLong(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableLocalTimestampMillisDateTimeAsLong(this IAvroEncoder encoder, System.DateTime? value, INullableTypeConverter converter)
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeLocalTimestampMillisDateTimeAsLong(value.Value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfLocalTimestampMillisDateTimeAsLong(this IAvroEncoder encoder, IList<System.DateTime> array)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeLocalTimestampMillisDateTimeAsLong(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfLocalTimestampMillisDateTimeAsLong(this IAvroEncoder encoder, IDictionary<string, System.DateTime> map)
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeLocalTimestampMillisDateTimeAsLong(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableMicrosecondsTimeSpanAsLong(this IAvroEncoder encoder, System.TimeSpan? value, INullableTypeConverter converter)
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeMicrosecondsTimeSpanAsLong(value.Value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfMicrosecondsTimeSpanAsLong(this IAvroEncoder encoder, IList<System.TimeSpan> array)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeMicrosecondsTimeSpanAsLong(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfMicrosecondsTimeSpanAsLong(this IAvroEncoder encoder, IDictionary<string, System.TimeSpan> map)
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeMicrosecondsTimeSpanAsLong(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableMillisecondsTimeSpanAsLong(this IAvroEncoder encoder, System.TimeSpan? value, INullableTypeConverter converter)
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeMillisecondsTimeSpanAsLong(value.Value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfMillisecondsTimeSpanAsLong(this IAvroEncoder encoder, IList<System.TimeSpan> array)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeMillisecondsTimeSpanAsLong(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfMillisecondsTimeSpanAsLong(this IAvroEncoder encoder, IDictionary<string, System.TimeSpan> map)
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeMillisecondsTimeSpanAsLong(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableTimeMicrosTimeSpanAsLong(this IAvroEncoder encoder, System.TimeSpan? value, INullableTypeConverter converter)
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeTimeMicrosTimeSpanAsLong(value.Value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfTimeMicrosTimeSpanAsLong(this IAvroEncoder encoder, IList<System.TimeSpan> array)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeTimeMicrosTimeSpanAsLong(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfTimeMicrosTimeSpanAsLong(this IAvroEncoder encoder, IDictionary<string, System.TimeSpan> map)
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeTimeMicrosTimeSpanAsLong(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableTimeMillisTimeSpanAsInt(this IAvroEncoder encoder, System.TimeSpan? value, INullableTypeConverter converter)
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeTimeMillisTimeSpanAsInt(value.Value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfTimeMillisTimeSpanAsInt(this IAvroEncoder encoder, IList<System.TimeSpan> array)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeTimeMillisTimeSpanAsInt(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfTimeMillisTimeSpanAsInt(this IAvroEncoder encoder, IDictionary<string, System.TimeSpan> map)
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeTimeMillisTimeSpanAsInt(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableTimestampDateTimeAsIso8601String(this IAvroEncoder encoder, System.DateTime? value, INullableTypeConverter converter)
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeTimestampDateTimeAsIso8601String(value.Value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfTimestampDateTimeAsIso8601String(this IAvroEncoder encoder, IList<System.DateTime> array)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeTimestampDateTimeAsIso8601String(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfTimestampDateTimeAsIso8601String(this IAvroEncoder encoder, IDictionary<string, System.DateTime> map)
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeTimestampDateTimeAsIso8601String(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableTimestampMicrosDateTimeAsLong(this IAvroEncoder encoder, System.DateTime? value, INullableTypeConverter converter)
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeTimestampMicrosDateTimeAsLong(value.Value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfTimestampMicrosDateTimeAsLong(this IAvroEncoder encoder, IList<System.DateTime> array)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeTimestampMicrosDateTimeAsLong(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfTimestampMicrosDateTimeAsLong(this IAvroEncoder encoder, IDictionary<string, System.DateTime> map)
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeTimestampMicrosDateTimeAsLong(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableTimestampMillisDateTimeAsLong(this IAvroEncoder encoder, System.DateTime? value, INullableTypeConverter converter)
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeTimestampMillisDateTimeAsLong(value.Value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfTimestampMillisDateTimeAsLong(this IAvroEncoder encoder, IList<System.DateTime> array)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeTimestampMillisDateTimeAsLong(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfTimestampMillisDateTimeAsLong(this IAvroEncoder encoder, IDictionary<string, System.DateTime> map)
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeTimestampMillisDateTimeAsLong(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableUuidGuidAsRfc4122String(this IAvroEncoder encoder, System.Guid? value, INullableTypeConverter converter)
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeUuidGuidAsRfc4122String(value.Value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfUuidGuidAsRfc4122String(this IAvroEncoder encoder, IList<System.Guid> array)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeUuidGuidAsRfc4122String(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfUuidGuidAsRfc4122String(this IAvroEncoder encoder, IDictionary<string, System.Guid> map)
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeUuidGuidAsRfc4122String(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableUuidGuidAsBytes(this IAvroEncoder encoder, System.Guid? value, INullableTypeConverter converter)
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeUuidGuidAsBytes(value.Value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfUuidGuidAsBytes(this IAvroEncoder encoder, IList<System.Guid> array)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeUuidGuidAsBytes(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfUuidGuidAsBytes(this IAvroEncoder encoder, IDictionary<string, System.Guid> map)
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeUuidGuidAsBytes(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
        public static void EncodeNullableUuidGuidAsFixed(this IAvroEncoder encoder, System.Guid? value, INullableTypeConverter converter)
        {
            var isNull = value == null;
            encoder.EncodeUnionStart(isNull, converter);
            if (isNull)
                encoder.EncodeNull();
            else
                encoder.EncodeUuidGuidAsFixed(value.Value);
            encoder.EncodeUnionEnd(isNull);
        }
        public static void EncodeArrayOfUuidGuidAsFixed(this IAvroEncoder encoder, IList<System.Guid> array)
        {
            encoder.EncodeArrayStart(array.Count, array.Count);
            var b = false;
            foreach (var v in array)
            {
                if (b)
                    encoder.EncodeArrayItemSeparator();
                encoder.EncodeUuidGuidAsFixed(v);
                b = true;
            }
            if (array.Count > 0)
                encoder.EncodeArrayBlockStart(0);
            encoder.EncodeArrayEnd();
        }
        public static void EncodeMapOfUuidGuidAsFixed(this IAvroEncoder encoder, IDictionary<string, System.Guid> map)
        {
            encoder.EncodeMapStart(map.Count, map.Count);
            var b = false;
            foreach (var v in map)
            {
                if (b)
                    encoder.EncodeMapValueSeparator();
                encoder.EncodeMapKey(v.Key);
                encoder.EncodeUuidGuidAsFixed(v.Value);
                b = true;
            }
            if (map.Count > 0)
                encoder.EncodeMapBlockStart(0);
            encoder.EncodeMapEnd();
        }
    }
}
