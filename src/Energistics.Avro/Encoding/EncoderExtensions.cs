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

using Energistics.Avro.Encoding.Converter;
using System;

namespace Energistics.Avro.Encoding
{
    /// <summary>
    /// Extension methods for encoders.
    /// </summary>
    public static partial class EncoderExtensions
    {
        public static void EncodeUuidGuidAsRfc4122String(this IAvroEncoder encoder, Guid value) => encoder.EncodeString(AvroConverter.GuidToRfc4122String(value));

        public static void EncodeUuidGuidAsBytes(this IAvroEncoder encoder, Guid value) => encoder.EncodeBytes(AvroConverter.GuidToBytes(value));

        public static void EncodeUuidGuidAsFixed(this IAvroEncoder encoder, Guid value) => encoder.EncodeFixed(16L, AvroConverter.GuidToBytes(value));

        public static void EncodeTimestampDateTimeAsIso8601String(this IAvroEncoder encoder, DateTime value) => encoder.EncodeString(AvroConverter.DateTimeToIso8601String(value));

        public static void EncodeDateDateTimeAsInt(this IAvroEncoder encoder, DateTime value) => encoder.EncodeInt(AvroConverter.DateTimeToDate(value));

        public static void EncodeTimeMillisDateTimeAsInt(this IAvroEncoder encoder, DateTime value) => encoder.EncodeInt(AvroConverter.DateTimeToTimeMillis(value));

        public static void EncodeTimeMicrosDateTimeAsLong(this IAvroEncoder encoder, DateTime value) => encoder.EncodeLong(AvroConverter.DateTimeToTimeMicros(value));

        public static void EncodeTimestampMillisDateTimeAsLong(this IAvroEncoder encoder, DateTime value) => encoder.EncodeLong(AvroConverter.DateTimeToTimestampMillisUtc(value));

        public static void EncodeTimestampMicrosDateTimeAsLong(this IAvroEncoder encoder, DateTime value) => encoder.EncodeLong(AvroConverter.DateTimeToTimestampMicrosUtc(value));

        public static void EncodeLocalTimestampMillisDateTimeAsLong(this IAvroEncoder encoder, DateTime value) => encoder.EncodeLong(AvroConverter.DateTimeToTimestampMillisLocal(value));

        public static void EncodeLocalTimestampMicrosDateTimeAsLong(this IAvroEncoder encoder, DateTime value) => encoder.EncodeLong(AvroConverter.DateTimeToTimestampMicrosLocal(value));

        public static void EncodeTimestampDateTimeOffsetAsIso8601String(this IAvroEncoder encoder, DateTimeOffset value) => encoder.EncodeString(AvroConverter.DateTimeOffsetToIso8601String(value));

        public static void EncodeDateDateTimeOffsetAsInt(this IAvroEncoder encoder, DateTimeOffset value) => encoder.EncodeInt(AvroConverter.DateTimeOffsetToDate(value));

        public static void EncodeTimeMillisDateTimeOffsetAsInt(this IAvroEncoder encoder, DateTimeOffset value) => encoder.EncodeInt(AvroConverter.DateTimeOffsetToTimeMillis(value));

        public static void EncodeTimeMicrosDateTimeOffsetAsLong(this IAvroEncoder encoder, DateTimeOffset value) => encoder.EncodeLong(AvroConverter.DateTimeOffsetToTimeMicros(value));

        public static void EncodeTimestampMillisDateTimeOffsetAsLong(this IAvroEncoder encoder, DateTimeOffset value) => encoder.EncodeLong(AvroConverter.DateTimeOffsetToTimestampMillisUtc(value));

        public static void EncodeTimestampMicrosDateTimeOffsetAsLong(this IAvroEncoder encoder, DateTimeOffset value) => encoder.EncodeLong(AvroConverter.DateTimeOffsetToTimestampMicrosUtc(value));

        public static void EncodeLocalTimestampMillisDateTimeOffsetAsLong(this IAvroEncoder encoder, DateTimeOffset value) => encoder.EncodeLong(AvroConverter.DateTimeOffsetToTimestampMillisLocal(value));

        public static void EncodeLocalTimestampMicrosDateTimeOffsetAsLong(this IAvroEncoder encoder, DateTimeOffset value) => encoder.EncodeLong(AvroConverter.DateTimeOffsetToTimestampMicrosLocal(value));

        public static void EncodeDurationTimeSpanAsIso8601String(this IAvroEncoder encoder, TimeSpan value) => encoder.EncodeString(AvroConverter.TimeSpanToIso8601String(value));

        public static void EncodeMillisecondsTimeSpanAsLong(this IAvroEncoder encoder, TimeSpan value) => encoder.EncodeLong(AvroConverter.TimeSpanToMilliseconds(value));

        public static void EncodeMicrosecondsTimeSpanAsLong(this IAvroEncoder encoder, TimeSpan value) => encoder.EncodeLong(AvroConverter.TimeSpanToMicroseconds(value));

        public static void EncodeTimeMillisTimeSpanAsInt(this IAvroEncoder encoder, TimeSpan value) => encoder.EncodeInt(AvroConverter.TimeSpanToTimeMillis(value));

        public static void EncodeTimeMicrosTimeSpanAsLong(this IAvroEncoder encoder, TimeSpan value) => encoder.EncodeLong(AvroConverter.TimeSpanToTimeMicros(value));

        public static void EncodeDurationTimeSpanAsFixed(this IAvroEncoder encoder, TimeSpan value) => encoder.EncodeFixed(12L, AvroConverter.TimeSpanToDuration(value));
    }
}
