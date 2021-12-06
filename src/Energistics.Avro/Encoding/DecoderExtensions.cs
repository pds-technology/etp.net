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
    /// Extension methods for decoders.
    /// </summary>
    public static partial class DecoderExtensions
    {
        public static Guid DecodeUuidGuidAsRfc4122String(this IAvroDecoder decoder) => AvroConverter.Rfc4122StringToGuid(decoder.DecodeString());

        public static Guid DecodeUuidGuidAsBytes(this IAvroDecoder decoder) => AvroConverter.BytesToGuid(decoder.DecodeBytes());

        public static Guid DecodeUuidGuidAsFixed(this IAvroDecoder decoder) => AvroConverter.BytesToGuid(decoder.DecodeFixed(16L));

        public static DateTime DecodeTimestampDateTimeAsIso8601String(this IAvroDecoder decoder) => AvroConverter.Iso8601StringToDateTime(decoder.DecodeString());

        public static DateTime DecodeDateDateTimeAsInt(this IAvroDecoder decoder) => AvroConverter.DateToDateTime(decoder.DecodeInt());

        public static DateTime DecodeTimeMillisDateTimeAsInt(this IAvroDecoder decoder) => AvroConverter.TimeMillisToDateTime(decoder.DecodeInt());

        public static DateTime DecodeTimeMicrosDateTimeAsLong(this IAvroDecoder decoder) => AvroConverter.TimeMicrosToDateTime(decoder.DecodeLong());

        public static DateTime DecodeTimestampMillisDateTimeAsLong(this IAvroDecoder decoder) => AvroConverter.TimestampMillisUtcToDateTime(decoder.DecodeLong());

        public static DateTime DecodeTimestampMicrosDateTimeAsLong(this IAvroDecoder decoder) => AvroConverter.TimestampMicrosUtcToDateTime(decoder.DecodeLong());

        public static DateTime DecodeLocalTimestampMillisDateTimeAsLong(this IAvroDecoder decoder) => AvroConverter.TimestampMillisLocalToDateTime(decoder.DecodeLong());

        public static DateTime DecodeLocalTimestampMicrosDateTimeAsLong(this IAvroDecoder decoder) => AvroConverter.TimestampMicrosLocalToDateTime(decoder.DecodeLong());

        public static DateTimeOffset DecodeTimestampDateTimeOffsetAsIso8601String(this IAvroDecoder decoder) => AvroConverter.Iso8601StringToDateTimeOffset(decoder.DecodeString());

        public static DateTimeOffset DecodeDateDateTimeOffsetAsInt(this IAvroDecoder decoder) => AvroConverter.DateToDateTimeOffset(decoder.DecodeInt());

        public static DateTimeOffset DecodeTimeMillisDateTimeOffsetAsInt(this IAvroDecoder decoder) => AvroConverter.TimeMillisToDateTimeOffset(decoder.DecodeInt());

        public static DateTimeOffset DecodeTimeMicrosDateTimeOffsetAsLong(this IAvroDecoder decoder) => AvroConverter.TimeMicrosToDateTimeOffset(decoder.DecodeLong());

        public static DateTimeOffset DecodeTimestampMillisDateTimeOffsetAsLong(this IAvroDecoder decoder) => AvroConverter.TimestampMillisUtcToDateTimeOffset(decoder.DecodeLong());

        public static DateTimeOffset DecodeTimestampMicrosDateTimeOffsetAsLong(this IAvroDecoder decoder) => AvroConverter.TimestampMicrosUtcToDateTimeOffset(decoder.DecodeLong());

        public static DateTimeOffset DecodeTimestampMillisLocalDateTimeOffsetAsLong(this IAvroDecoder decoder) => AvroConverter.TimestampMillisLocalToDateTimeOffset(decoder.DecodeLong());

        public static DateTimeOffset DecodeTimestampMicrosLocalDateTimeOffsetAsLong(this IAvroDecoder decoder) => AvroConverter.TimestampMicrosLocalToDateTimeOffset(decoder.DecodeLong());

        public static TimeSpan DecodeDurationTimeSpanAsIso8601String(this IAvroDecoder decoder) => AvroConverter.Iso8601StringToTimeSpan(decoder.DecodeString());

        public static TimeSpan DecodeMillisecondsTimeSpanAsLong(this IAvroDecoder decoder) => AvroConverter.MillisecondsToTimeSpan(decoder.DecodeLong());

        public static TimeSpan DecodeMicrosecondsTimeSpanAsLong(this IAvroDecoder decoder) => AvroConverter.MicrosecondsToTimeSpan(decoder.DecodeLong());

        public static TimeSpan DecodeTimeMillisTimeSpanAsInt(this IAvroDecoder decoder) => AvroConverter.TimeMillisToTimeSpan(decoder.DecodeInt());

        public static TimeSpan DecodeTimeMicrosTimeSpanAsLong(this IAvroDecoder decoder) => AvroConverter.TimeMicrosToTimeSpan(decoder.DecodeLong());

        public static TimeSpan DecodeDurationTimeSpanAsFixed(this IAvroDecoder decoder) => AvroConverter.DurationToTimeSpan(decoder.DecodeFixed(12L));
    }
}
