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
    /// Extension methods for decoders.
    /// </summary>
    public static partial class DecoderExtensions
    {
        public static TAvroObject DecodeAvroObject<TAvroObject>(this IAvroDecoder decoder)
            where TAvroObject : class, IAvroObject, new()
        {
            TAvroObject @object = new TAvroObject();
            @object.Decode(decoder);
            return @object;
        }
        public static bool? DecodeNullableBoolean(this IAvroDecoder decoder, INullableTypeConverter converter)
        {
            bool? value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullStruct<bool>();
            else
                value = decoder.DecodeBoolean();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<bool> DecodeArrayOfBoolean(this IAvroDecoder decoder)
        {
            IList<bool> array = new List<bool>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeBoolean());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, bool> DecodeMapOfBoolean(this IAvroDecoder decoder)
        {
            IDictionary<string, bool> map = new Dictionary<string, bool>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeBoolean();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static int? DecodeNullableInt(this IAvroDecoder decoder, INullableTypeConverter converter)
        {
            int? value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullStruct<int>();
            else
                value = decoder.DecodeInt();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<int> DecodeArrayOfInt(this IAvroDecoder decoder)
        {
            IList<int> array = new List<int>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeInt());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, int> DecodeMapOfInt(this IAvroDecoder decoder)
        {
            IDictionary<string, int> map = new Dictionary<string, int>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeInt();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static long? DecodeNullableLong(this IAvroDecoder decoder, INullableTypeConverter converter)
        {
            long? value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullStruct<long>();
            else
                value = decoder.DecodeLong();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<long> DecodeArrayOfLong(this IAvroDecoder decoder)
        {
            IList<long> array = new List<long>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeLong());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, long> DecodeMapOfLong(this IAvroDecoder decoder)
        {
            IDictionary<string, long> map = new Dictionary<string, long>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeLong();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static float? DecodeNullableFloat(this IAvroDecoder decoder, INullableTypeConverter converter)
        {
            float? value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullStruct<float>();
            else
                value = decoder.DecodeFloat();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<float> DecodeArrayOfFloat(this IAvroDecoder decoder)
        {
            IList<float> array = new List<float>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeFloat());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, float> DecodeMapOfFloat(this IAvroDecoder decoder)
        {
            IDictionary<string, float> map = new Dictionary<string, float>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeFloat();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static double? DecodeNullableDouble(this IAvroDecoder decoder, INullableTypeConverter converter)
        {
            double? value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullStruct<double>();
            else
                value = decoder.DecodeDouble();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<double> DecodeArrayOfDouble(this IAvroDecoder decoder)
        {
            IList<double> array = new List<double>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeDouble());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, double> DecodeMapOfDouble(this IAvroDecoder decoder)
        {
            IDictionary<string, double> map = new Dictionary<string, double>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeDouble();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static string DecodeNullableString(this IAvroDecoder decoder, INullableTypeConverter converter)
        {
            string value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullClass<string>();
            else
                value = decoder.DecodeString();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<string> DecodeArrayOfString(this IAvroDecoder decoder)
        {
            IList<string> array = new List<string>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeString());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, string> DecodeMapOfString(this IAvroDecoder decoder)
        {
            IDictionary<string, string> map = new Dictionary<string, string>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeString();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static byte[] DecodeNullableBytes(this IAvroDecoder decoder, INullableTypeConverter converter)
        {
            byte[] value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullClass<byte[]>();
            else
                value = decoder.DecodeBytes();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<byte[]> DecodeArrayOfBytes(this IAvroDecoder decoder)
        {
            IList<byte[]> array = new List<byte[]>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeBytes());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, byte[]> DecodeMapOfBytes(this IAvroDecoder decoder)
        {
            IDictionary<string, byte[]> map = new Dictionary<string, byte[]>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeBytes();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static TAvroObject DecodeNullableAvroObject<TAvroObject>(this IAvroDecoder decoder, INullableTypeConverter converter)
            where TAvroObject : class, IAvroObject, new()
        {
            TAvroObject value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullClass<TAvroObject>();
            else
                value = decoder.DecodeAvroObject<TAvroObject>();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<TAvroObject> DecodeArrayOfAvroObject<TAvroObject>(this IAvroDecoder decoder)
            where TAvroObject : class, IAvroObject, new()
        {
            IList<TAvroObject> array = new List<TAvroObject>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeAvroObject<TAvroObject>());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, TAvroObject> DecodeMapOfAvroObject<TAvroObject>(this IAvroDecoder decoder)
            where TAvroObject : class, IAvroObject, new()
        {
            IDictionary<string, TAvroObject> map = new Dictionary<string, TAvroObject>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeAvroObject<TAvroObject>();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static TEnum? DecodeNullableEnum<TEnum>(this IAvroDecoder decoder, INullableTypeConverter converter)
            where TEnum : struct, System.Enum
        {
            TEnum? value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullStruct<TEnum>();
            else
                value = decoder.DecodeEnum<TEnum>();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<TEnum> DecodeArrayOfEnum<TEnum>(this IAvroDecoder decoder)
            where TEnum : struct, System.Enum
        {
            IList<TEnum> array = new List<TEnum>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeEnum<TEnum>());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, TEnum> DecodeMapOfEnum<TEnum>(this IAvroDecoder decoder)
            where TEnum : struct, System.Enum
        {
            IDictionary<string, TEnum> map = new Dictionary<string, TEnum>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeEnum<TEnum>();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static System.DateTime? DecodeNullableDateDateTimeAsInt(this IAvroDecoder decoder, INullableTypeConverter converter)
        {
            System.DateTime? value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullStruct<System.DateTime>();
            else
                value = decoder.DecodeDateDateTimeAsInt();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<System.DateTime> DecodeArrayOfDateDateTimeAsInt(this IAvroDecoder decoder)
        {
            IList<System.DateTime> array = new List<System.DateTime>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeDateDateTimeAsInt());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, System.DateTime> DecodeMapOfDateDateTimeAsInt(this IAvroDecoder decoder)
        {
            IDictionary<string, System.DateTime> map = new Dictionary<string, System.DateTime>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeDateDateTimeAsInt();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static System.TimeSpan? DecodeNullableDurationTimeSpanAsIso8601String(this IAvroDecoder decoder, INullableTypeConverter converter)
        {
            System.TimeSpan? value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullStruct<System.TimeSpan>();
            else
                value = decoder.DecodeDurationTimeSpanAsIso8601String();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<System.TimeSpan> DecodeArrayOfDurationTimeSpanAsIso8601String(this IAvroDecoder decoder)
        {
            IList<System.TimeSpan> array = new List<System.TimeSpan>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeDurationTimeSpanAsIso8601String());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, System.TimeSpan> DecodeMapOfDurationTimeSpanAsIso8601String(this IAvroDecoder decoder)
        {
            IDictionary<string, System.TimeSpan> map = new Dictionary<string, System.TimeSpan>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeDurationTimeSpanAsIso8601String();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static System.TimeSpan? DecodeNullableDurationTimeSpanAsFixed(this IAvroDecoder decoder, INullableTypeConverter converter)
        {
            System.TimeSpan? value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullStruct<System.TimeSpan>();
            else
                value = decoder.DecodeDurationTimeSpanAsFixed();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<System.TimeSpan> DecodeArrayOfDurationTimeSpanAsFixed(this IAvroDecoder decoder)
        {
            IList<System.TimeSpan> array = new List<System.TimeSpan>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeDurationTimeSpanAsFixed());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, System.TimeSpan> DecodeMapOfDurationTimeSpanAsFixed(this IAvroDecoder decoder)
        {
            IDictionary<string, System.TimeSpan> map = new Dictionary<string, System.TimeSpan>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeDurationTimeSpanAsFixed();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static System.DateTime? DecodeNullableLocalTimestampMicrosDateTimeAsLong(this IAvroDecoder decoder, INullableTypeConverter converter)
        {
            System.DateTime? value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullStruct<System.DateTime>();
            else
                value = decoder.DecodeLocalTimestampMicrosDateTimeAsLong();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<System.DateTime> DecodeArrayOfLocalTimestampMicrosDateTimeAsLong(this IAvroDecoder decoder)
        {
            IList<System.DateTime> array = new List<System.DateTime>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeLocalTimestampMicrosDateTimeAsLong());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, System.DateTime> DecodeMapOfLocalTimestampMicrosDateTimeAsLong(this IAvroDecoder decoder)
        {
            IDictionary<string, System.DateTime> map = new Dictionary<string, System.DateTime>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeLocalTimestampMicrosDateTimeAsLong();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static System.DateTime? DecodeNullableLocalTimestampMillisDateTimeAsLong(this IAvroDecoder decoder, INullableTypeConverter converter)
        {
            System.DateTime? value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullStruct<System.DateTime>();
            else
                value = decoder.DecodeLocalTimestampMillisDateTimeAsLong();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<System.DateTime> DecodeArrayOfLocalTimestampMillisDateTimeAsLong(this IAvroDecoder decoder)
        {
            IList<System.DateTime> array = new List<System.DateTime>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeLocalTimestampMillisDateTimeAsLong());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, System.DateTime> DecodeMapOfLocalTimestampMillisDateTimeAsLong(this IAvroDecoder decoder)
        {
            IDictionary<string, System.DateTime> map = new Dictionary<string, System.DateTime>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeLocalTimestampMillisDateTimeAsLong();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static System.TimeSpan? DecodeNullableMicrosecondsTimeSpanAsLong(this IAvroDecoder decoder, INullableTypeConverter converter)
        {
            System.TimeSpan? value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullStruct<System.TimeSpan>();
            else
                value = decoder.DecodeMicrosecondsTimeSpanAsLong();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<System.TimeSpan> DecodeArrayOfMicrosecondsTimeSpanAsLong(this IAvroDecoder decoder)
        {
            IList<System.TimeSpan> array = new List<System.TimeSpan>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeMicrosecondsTimeSpanAsLong());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, System.TimeSpan> DecodeMapOfMicrosecondsTimeSpanAsLong(this IAvroDecoder decoder)
        {
            IDictionary<string, System.TimeSpan> map = new Dictionary<string, System.TimeSpan>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeMicrosecondsTimeSpanAsLong();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static System.TimeSpan? DecodeNullableMillisecondsTimeSpanAsLong(this IAvroDecoder decoder, INullableTypeConverter converter)
        {
            System.TimeSpan? value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullStruct<System.TimeSpan>();
            else
                value = decoder.DecodeMillisecondsTimeSpanAsLong();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<System.TimeSpan> DecodeArrayOfMillisecondsTimeSpanAsLong(this IAvroDecoder decoder)
        {
            IList<System.TimeSpan> array = new List<System.TimeSpan>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeMillisecondsTimeSpanAsLong());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, System.TimeSpan> DecodeMapOfMillisecondsTimeSpanAsLong(this IAvroDecoder decoder)
        {
            IDictionary<string, System.TimeSpan> map = new Dictionary<string, System.TimeSpan>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeMillisecondsTimeSpanAsLong();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static System.TimeSpan? DecodeNullableTimeMicrosTimeSpanAsLong(this IAvroDecoder decoder, INullableTypeConverter converter)
        {
            System.TimeSpan? value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullStruct<System.TimeSpan>();
            else
                value = decoder.DecodeTimeMicrosTimeSpanAsLong();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<System.TimeSpan> DecodeArrayOfTimeMicrosTimeSpanAsLong(this IAvroDecoder decoder)
        {
            IList<System.TimeSpan> array = new List<System.TimeSpan>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeTimeMicrosTimeSpanAsLong());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, System.TimeSpan> DecodeMapOfTimeMicrosTimeSpanAsLong(this IAvroDecoder decoder)
        {
            IDictionary<string, System.TimeSpan> map = new Dictionary<string, System.TimeSpan>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeTimeMicrosTimeSpanAsLong();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static System.TimeSpan? DecodeNullableTimeMillisTimeSpanAsInt(this IAvroDecoder decoder, INullableTypeConverter converter)
        {
            System.TimeSpan? value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullStruct<System.TimeSpan>();
            else
                value = decoder.DecodeTimeMillisTimeSpanAsInt();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<System.TimeSpan> DecodeArrayOfTimeMillisTimeSpanAsInt(this IAvroDecoder decoder)
        {
            IList<System.TimeSpan> array = new List<System.TimeSpan>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeTimeMillisTimeSpanAsInt());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, System.TimeSpan> DecodeMapOfTimeMillisTimeSpanAsInt(this IAvroDecoder decoder)
        {
            IDictionary<string, System.TimeSpan> map = new Dictionary<string, System.TimeSpan>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeTimeMillisTimeSpanAsInt();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static System.DateTime? DecodeNullableTimestampDateTimeAsIso8601String(this IAvroDecoder decoder, INullableTypeConverter converter)
        {
            System.DateTime? value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullStruct<System.DateTime>();
            else
                value = decoder.DecodeTimestampDateTimeAsIso8601String();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<System.DateTime> DecodeArrayOfTimestampDateTimeAsIso8601String(this IAvroDecoder decoder)
        {
            IList<System.DateTime> array = new List<System.DateTime>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeTimestampDateTimeAsIso8601String());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, System.DateTime> DecodeMapOfTimestampDateTimeAsIso8601String(this IAvroDecoder decoder)
        {
            IDictionary<string, System.DateTime> map = new Dictionary<string, System.DateTime>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeTimestampDateTimeAsIso8601String();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static System.DateTime? DecodeNullableTimestampMicrosDateTimeAsLong(this IAvroDecoder decoder, INullableTypeConverter converter)
        {
            System.DateTime? value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullStruct<System.DateTime>();
            else
                value = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<System.DateTime> DecodeArrayOfTimestampMicrosDateTimeAsLong(this IAvroDecoder decoder)
        {
            IList<System.DateTime> array = new List<System.DateTime>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeTimestampMicrosDateTimeAsLong());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, System.DateTime> DecodeMapOfTimestampMicrosDateTimeAsLong(this IAvroDecoder decoder)
        {
            IDictionary<string, System.DateTime> map = new Dictionary<string, System.DateTime>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeTimestampMicrosDateTimeAsLong();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static System.DateTime? DecodeNullableTimestampMillisDateTimeAsLong(this IAvroDecoder decoder, INullableTypeConverter converter)
        {
            System.DateTime? value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullStruct<System.DateTime>();
            else
                value = decoder.DecodeTimestampMillisDateTimeAsLong();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<System.DateTime> DecodeArrayOfTimestampMillisDateTimeAsLong(this IAvroDecoder decoder)
        {
            IList<System.DateTime> array = new List<System.DateTime>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeTimestampMillisDateTimeAsLong());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, System.DateTime> DecodeMapOfTimestampMillisDateTimeAsLong(this IAvroDecoder decoder)
        {
            IDictionary<string, System.DateTime> map = new Dictionary<string, System.DateTime>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeTimestampMillisDateTimeAsLong();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static System.Guid? DecodeNullableUuidGuidAsRfc4122String(this IAvroDecoder decoder, INullableTypeConverter converter)
        {
            System.Guid? value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullStruct<System.Guid>();
            else
                value = decoder.DecodeUuidGuidAsRfc4122String();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<System.Guid> DecodeArrayOfUuidGuidAsRfc4122String(this IAvroDecoder decoder)
        {
            IList<System.Guid> array = new List<System.Guid>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeUuidGuidAsRfc4122String());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, System.Guid> DecodeMapOfUuidGuidAsRfc4122String(this IAvroDecoder decoder)
        {
            IDictionary<string, System.Guid> map = new Dictionary<string, System.Guid>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeUuidGuidAsRfc4122String();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static System.Guid? DecodeNullableUuidGuidAsBytes(this IAvroDecoder decoder, INullableTypeConverter converter)
        {
            System.Guid? value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullStruct<System.Guid>();
            else
                value = decoder.DecodeUuidGuidAsBytes();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<System.Guid> DecodeArrayOfUuidGuidAsBytes(this IAvroDecoder decoder)
        {
            IList<System.Guid> array = new List<System.Guid>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeUuidGuidAsBytes());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, System.Guid> DecodeMapOfUuidGuidAsBytes(this IAvroDecoder decoder)
        {
            IDictionary<string, System.Guid> map = new Dictionary<string, System.Guid>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeUuidGuidAsBytes();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
        public static System.Guid? DecodeNullableUuidGuidAsFixed(this IAvroDecoder decoder, INullableTypeConverter converter)
        {
            System.Guid? value;
            var isNull = decoder.DecodeUnionStart(converter);
            if (isNull)
                value = decoder.DecodeNullStruct<System.Guid>();
            else
                value = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeUnionEnd(isNull);
            return value;
        }
        public static IList<System.Guid> DecodeArrayOfUuidGuidAsFixed(this IAvroDecoder decoder)
        {
            IList<System.Guid> array = new List<System.Guid>();
            var c = decoder.DecodeArrayStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeArrayItemSeparator();
                    array.Add(decoder.DecodeUuidGuidAsFixed());
                    b = true;
                }
                c = decoder.DecodeArrayBlockStart();
            }
            decoder.DecodeArrayEnd();
            return array;
        }
        public static IDictionary<string, System.Guid> DecodeMapOfUuidGuidAsFixed(this IAvroDecoder decoder)
        {
            IDictionary<string, System.Guid> map = new Dictionary<string, System.Guid>();
            var c = decoder.DecodeMapStart();
            var b = false;
            while (c > 0)
            {
                for (var i = 0; i < c; i++)
                {
                    if (b)
                        decoder.DecodeMapValueSeparator();
                    var key = decoder.DecodeMapKey();
                    map[key] = decoder.DecodeUuidGuidAsFixed();
                    b = true;
                }
                c = decoder.DecodeMapBlockStart();
            }
            decoder.DecodeMapEnd();
            return map;
        }
    }
}
