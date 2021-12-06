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
using Energistics.Avro.Encoding;
using System;
using System.Globalization;

namespace Energistics.Avro.Encoding
{
    public static partial class TestData
    {
        private class DateTimeOffsetTestCase : TestCase<DateTimeOffset>
        {
            public DateTimeOffsetTestCase()
            {
                AvroEncode = (t, encoder) => encoder.EncodeDateTimeOffset(t.Value, (DateTimeEncodingStyle)t.EncodingStyle);
                AvroDecode = (t, decoder) => decoder.DecodeDateTimeOffset((DateTimeEncodingStyle)t.EncodingStyle);
            }
        }

        public static void EncodeDateTimeOffset(this IAvroEncoder encoder, DateTimeOffset value, DateTimeEncodingStyle style)
        {
            switch (style)
            {
                case DateTimeEncodingStyle.Iso8601String: encoder.EncodeTimestampDateTimeOffsetAsIso8601String(value); return;
                case DateTimeEncodingStyle.Date: encoder.EncodeDateDateTimeOffsetAsInt(value); return;
                case DateTimeEncodingStyle.TimeMillis: encoder.EncodeTimeMillisDateTimeOffsetAsInt(value); return;
                case DateTimeEncodingStyle.TimeMicros: encoder.EncodeTimeMicrosDateTimeOffsetAsLong(value); return;
                case DateTimeEncodingStyle.TimestampMillisUtc: encoder.EncodeTimestampMillisDateTimeOffsetAsLong(value); return;
                case DateTimeEncodingStyle.TimestampMicrosUtc: encoder.EncodeTimestampMicrosDateTimeOffsetAsLong(value); return;
                case DateTimeEncodingStyle.TimestampMillisLocal: encoder.EncodeLocalTimestampMillisDateTimeOffsetAsLong(value); return;
                case DateTimeEncodingStyle.TimestampMicrosLocal: encoder.EncodeLocalTimestampMicrosDateTimeOffsetAsLong(value); return;
                default:
                    throw new ArgumentException("Invalid style", nameof(style));
            }
        }

        public static DateTimeOffset DecodeDateTimeOffset(this IAvroDecoder decoder, DateTimeEncodingStyle style)
        {
            switch (style)
            {
                case DateTimeEncodingStyle.Iso8601String: return decoder.DecodeTimestampDateTimeOffsetAsIso8601String();
                case DateTimeEncodingStyle.Date: return decoder.DecodeDateDateTimeOffsetAsInt();
                case DateTimeEncodingStyle.TimeMillis: return decoder.DecodeTimeMillisDateTimeOffsetAsInt();
                case DateTimeEncodingStyle.TimeMicros: return decoder.DecodeTimeMicrosDateTimeOffsetAsLong();
                case DateTimeEncodingStyle.TimestampMillisUtc: return decoder.DecodeTimestampMillisDateTimeOffsetAsLong();
                case DateTimeEncodingStyle.TimestampMicrosUtc: return decoder.DecodeTimestampMicrosDateTimeOffsetAsLong();
                case DateTimeEncodingStyle.TimestampMillisLocal: return decoder.DecodeTimestampMillisLocalDateTimeOffsetAsLong();
                case DateTimeEncodingStyle.TimestampMicrosLocal: return decoder.DecodeTimestampMicrosLocalDateTimeOffsetAsLong();
                default:
                    throw new ArgumentException("Invalid style", nameof(style));
            }
        }

        public static TestCase<DateTimeOffset>[] DateTimeOffset => new TestCase<DateTimeOffset>[] { DateTimeOffsetAsIso8601String, DateTimeOffsetAsDate, DateTimeOffsetAsTimeMillis, DateTimeOffsetAsTimeMicros, DateTimeOffsetAsTimestampMillisUtc, DateTimeOffsetAsTimestampMicrosUtc, DateTimeOffsetAsTimestampMillisLocal, DateTimeOffsetAsTimestampMicrosLocal };

        public static TestCase<DateTimeOffset> DateTimeOffsetAsIso8601String => new DateTimeOffsetTestCase
        {
            Name = nameof(DateTimeOffsetAsIso8601String),
            Value = System.DateTimeOffset.ParseExact("2021-10-22T11:39:27.3470000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
            BinaryEncoding = new byte[] { 0x38, 0x32, 0x30, 0x32, 0x31, 0x2D, 0x31, 0x30, 0x2D, 0x32, 0x32, 0x54, 0x31, 0x31, 0x3A, 0x33, 0x39, 0x3A, 0x32, 0x37, 0x2E, 0x33, 0x34, 0x37, 0x30, 0x30, 0x30, 0x30, 0x5A },
            BinaryByteCount = 29L,
            JsonEncoding = "\"2021-10-22T11:39:27.3470000Z\"",
            JsonByteCount = 30L,
            Convert = (t) => AvroConverter.DateTimeOffsetToIso8601String(t.Value),
            Unconvert = (t) => AvroConverter.Iso8601StringToDateTimeOffset((string)t.Converted),
            Converted = "2021-10-22T11:39:27.3470000Z",
            EncodingStyle = DateTimeEncodingStyle.Iso8601String,
        };

        public static TestCase<DateTimeOffset> DateTimeOffsetAsDate => new DateTimeOffsetTestCase
        {
            Name = nameof(DateTimeOffsetAsDate),
            Value = System.DateTimeOffset.ParseExact("2021-10-22T00:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
            BinaryEncoding = new byte[] { 0xD4, 0xA7, 0x02 },
            BinaryByteCount = 3L,
            JsonEncoding = "18922",
            JsonByteCount = 5L,
            Convert = (t) => AvroConverter.DateTimeOffsetToDate(t.Value),
            Unconvert = (t) => AvroConverter.DateToDateTimeOffset((int)t.Converted),
            Converted = 18922,
            EncodingStyle = DateTimeEncodingStyle.Date,
        };

        public static TestCase<DateTimeOffset> DateTimeOffsetAsTimeMillis => new DateTimeOffsetTestCase
        {
            Name = nameof(DateTimeOffsetAsTimeMillis),
            Value = System.DateTimeOffset.ParseExact("0001-01-01T11:39:27.3470000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
            BinaryEncoding = new byte[] { 0xE6, 0xFB, 0x82, 0x28 },
            BinaryByteCount = 4L,
            JsonEncoding = "41967347",
            JsonByteCount = 8L,
            Convert = (t) => AvroConverter.DateTimeOffsetToTimeMillis(t.Value),
            Unconvert = (t) => AvroConverter.TimeMillisToDateTimeOffset((int)t.Converted),
            Converted = 41967347,
            EncodingStyle = DateTimeEncodingStyle.TimeMillis,
        };

        public static TestCase<DateTimeOffset> DateTimeOffsetAsTimeMicros => new DateTimeOffsetTestCase
        {
            Name = nameof(DateTimeOffsetAsTimeMicros),
            Value = System.DateTimeOffset.ParseExact("0001-01-01T11:39:27.3475680Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
            BinaryEncoding = new byte[] { 0xE0, 0x9D, 0x97, 0xD7, 0xB8, 0x02 },
            BinaryByteCount = 6L,
            JsonEncoding = "41967347568",
            JsonByteCount = 11L,
            Convert = (t) => AvroConverter.DateTimeOffsetToTimeMicros(t.Value),
            Unconvert = (t) => AvroConverter.TimeMicrosToDateTimeOffset((long)t.Converted),
            Converted = 41967347568L,
            EncodingStyle = DateTimeEncodingStyle.TimeMicros,
        };

        public static TestCase<DateTimeOffset> DateTimeOffsetAsTimestampMillisUtc => new DateTimeOffsetTestCase
        {
            Name = nameof(DateTimeOffsetAsTimestampMillisUtc),
            Value = System.DateTimeOffset.ParseExact("2021-10-22T11:39:27.3470000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
            BinaryEncoding = new byte[] { 0xE6, 0xDB, 0xE3, 0xFC, 0x94, 0x5F },
            BinaryByteCount = 6L,
            JsonEncoding = "1634902767347",
            JsonByteCount = 13L,
            Convert = (t) => AvroConverter.DateTimeOffsetToTimestampMillisUtc(t.Value),
            Unconvert = (t) => AvroConverter.TimestampMillisUtcToDateTimeOffset((long)t.Converted),
            Converted = 1634902767347L,
            EncodingStyle = DateTimeEncodingStyle.TimestampMillisUtc,
        };

        public static TestCase<DateTimeOffset> DateTimeOffsetAsTimestampMicrosUtc => new DateTimeOffsetTestCase
        {
            Name = nameof(DateTimeOffsetAsTimestampMicrosUtc),
            Value = System.DateTimeOffset.ParseExact("2021-10-22T11:39:27.3475680Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
            BinaryEncoding = new byte[] { 0xE0, 0x9D, 0x85, 0xEB, 0xEE, 0xBB, 0xE7, 0x05 },
            BinaryByteCount = 8L,
            JsonEncoding = "1634902767347568",
            JsonByteCount = 16L,
            Convert = (t) => AvroConverter.DateTimeOffsetToTimestampMicrosUtc(t.Value),
            Unconvert = (t) => AvroConverter.TimestampMicrosUtcToDateTimeOffset((long)t.Converted),
            Converted = 1634902767347568L,
            EncodingStyle = DateTimeEncodingStyle.TimestampMicrosUtc,
        };

        public static TestCase<DateTimeOffset> DateTimeOffsetAsTimestampMillisLocal => new DateTimeOffsetTestCase
        {
            Name = nameof(DateTimeOffsetAsTimestampMillisLocal),
            Value = System.DateTimeOffset.Parse("2021-10-22T11:39:27.3470000", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal),
            BinaryEncoding = new byte[] { 0xE6, 0xDB, 0xE3, 0xFC, 0x94, 0x5F },
            BinaryByteCount = 6L,
            JsonEncoding = "1634902767347",
            JsonByteCount = 13L,
            Convert = (t) => AvroConverter.DateTimeOffsetToTimestampMillisLocal(t.Value),
            Unconvert = (t) => AvroConverter.TimestampMillisLocalToDateTimeOffset((long)t.Converted),
            Converted = 1634902767347L,
            EncodingStyle = DateTimeEncodingStyle.TimestampMillisLocal,
        };

        public static TestCase<DateTimeOffset> DateTimeOffsetAsTimestampMicrosLocal => new DateTimeOffsetTestCase
        {
            Name = nameof(DateTimeOffsetAsTimestampMicrosLocal),
            Value = System.DateTimeOffset.Parse("2021-10-22T11:39:27.3475680", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal),
            BinaryEncoding = new byte[] { 0xE0, 0x9D, 0x85, 0xEB, 0xEE, 0xBB, 0xE7, 0x05 },
            BinaryByteCount = 8L,
            JsonEncoding = "1634902767347568",
            JsonByteCount = 16L,
            Convert = (t) => AvroConverter.DateTimeOffsetToTimestampMicrosLocal(t.Value),
            Unconvert = (t) => AvroConverter.TimestampMicrosLocalToDateTimeOffset((long)t.Converted),
            Converted = 1634902767347568L,
            EncodingStyle = DateTimeEncodingStyle.TimestampMicrosLocal,
        };
    }
}
