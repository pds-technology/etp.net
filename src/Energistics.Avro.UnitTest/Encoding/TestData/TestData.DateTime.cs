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
        private class DateTimeTestCase : TestCase<DateTime>
        {
            public DateTimeTestCase()
            {
                AvroEncode = (t, encoder) => encoder.EncodeDateTime(t.Value, (DateTimeEncodingStyle)t.EncodingStyle);
                AvroDecode = (t, decoder) => decoder.DecodeDateTime((DateTimeEncodingStyle)t.EncodingStyle);
            }
        }

        public static void EncodeDateTime(this IAvroEncoder encoder, DateTime value, DateTimeEncodingStyle style)
        {
            switch (style)
            {
                case DateTimeEncodingStyle.Iso8601String: encoder.EncodeTimestampDateTimeAsIso8601String(value); return;
                case DateTimeEncodingStyle.Date: encoder.EncodeDateDateTimeAsInt(value); return;
                case DateTimeEncodingStyle.TimeMillis: encoder.EncodeTimeMillisDateTimeAsInt(value); return;
                case DateTimeEncodingStyle.TimeMicros: encoder.EncodeTimeMicrosDateTimeAsLong(value); return;
                case DateTimeEncodingStyle.TimestampMillisUtc: encoder.EncodeTimestampMillisDateTimeAsLong(value); return;
                case DateTimeEncodingStyle.TimestampMicrosUtc: encoder.EncodeTimestampMicrosDateTimeAsLong(value); return;
                case DateTimeEncodingStyle.TimestampMillisLocal: encoder.EncodeLocalTimestampMillisDateTimeAsLong(value); return;
                case DateTimeEncodingStyle.TimestampMicrosLocal: encoder.EncodeLocalTimestampMicrosDateTimeAsLong(value); return;
                default:
                    throw new ArgumentException("Invalid style", nameof(style));
            }
        }

        public static DateTime DecodeDateTime(this IAvroDecoder decoder, DateTimeEncodingStyle style)
        {
            switch (style)
            {
                case DateTimeEncodingStyle.Iso8601String: return decoder.DecodeTimestampDateTimeAsIso8601String();
                case DateTimeEncodingStyle.Date: return decoder.DecodeDateDateTimeAsInt();
                case DateTimeEncodingStyle.TimeMillis: return decoder.DecodeTimeMillisDateTimeAsInt();
                case DateTimeEncodingStyle.TimeMicros: return decoder.DecodeTimeMicrosDateTimeAsLong();
                case DateTimeEncodingStyle.TimestampMillisUtc: return decoder.DecodeTimestampMillisDateTimeAsLong();
                case DateTimeEncodingStyle.TimestampMicrosUtc: return decoder.DecodeTimestampMicrosDateTimeAsLong();
                case DateTimeEncodingStyle.TimestampMillisLocal: return decoder.DecodeLocalTimestampMillisDateTimeAsLong();
                case DateTimeEncodingStyle.TimestampMicrosLocal: return decoder.DecodeLocalTimestampMicrosDateTimeAsLong();
                default:
                    throw new ArgumentException("Invalid style", nameof(style));
            }
        }

        public static TestCase<DateTime>[] DateTime => new TestCase<DateTime>[] { DateTimeAsIso8601String, DateTimeAsDate, DateTimeAsTimeMillis, DateTimeAsTimeMicros, DateTimeAsTimestampMillisUtc, DateTimeAsTimestampMicrosUtc, DateTimeAsTimestampMillisLocal, DateTimeAsTimestampMicrosLocal };

        public static TestCase<DateTime> DateTimeAsIso8601String => new DateTimeTestCase
        {
            Name = nameof(DateTimeAsIso8601String),
            Value = System.DateTime.ParseExact("2021-10-22T11:39:27.3470000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
            BinaryEncoding = new byte[] { 0x38, 0x32, 0x30, 0x32, 0x31, 0x2D, 0x31, 0x30, 0x2D, 0x32, 0x32, 0x54, 0x31, 0x31, 0x3A, 0x33, 0x39, 0x3A, 0x32, 0x37, 0x2E, 0x33, 0x34, 0x37, 0x30, 0x30, 0x30, 0x30, 0x5A },
            BinaryByteCount = 29L,
            JsonEncoding = "\"2021-10-22T11:39:27.3470000Z\"",
            JsonByteCount = 30L,
            Convert = (t) => AvroConverter.DateTimeToIso8601String(t.Value),
            Unconvert = (t) => AvroConverter.Iso8601StringToDateTime((string)t.Converted),
            Converted = "2021-10-22T11:39:27.3470000Z",
            EncodingStyle = DateTimeEncodingStyle.Iso8601String,
        };

        public static TestCase<DateTime> DateTimeAsDate => new DateTimeTestCase
        {
            Name = nameof(DateTimeAsDate),
            Value = System.DateTime.ParseExact("2021-10-22T00:00:00.0000000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
            BinaryEncoding = new byte[] { 0xD4, 0xA7, 0x02 },
            BinaryByteCount = 3L,
            JsonEncoding = "18922",
            JsonByteCount = 5L,
            Convert = (t) => AvroConverter.DateTimeToDate(t.Value),
            Unconvert = (t) => AvroConverter.DateToDateTime((int)t.Converted),
            Converted = 18922,
            EncodingStyle = DateTimeEncodingStyle.Date,
        };

        public static TestCase<DateTime> DateTimeAsTimeMillis => new DateTimeTestCase
        {
            Name = nameof(DateTimeAsTimeMillis),
            Value = System.DateTime.ParseExact("0001-01-01T11:39:27.3470000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
            BinaryEncoding = new byte[] { 0xE6, 0xFB, 0x82, 0x28 },
            BinaryByteCount = 4L,
            JsonEncoding = "41967347",
            JsonByteCount = 8L,
            Convert = (t) => AvroConverter.DateTimeToTimeMillis(t.Value),
            Unconvert = (t) => AvroConverter.TimeMillisToDateTime((int)t.Converted),
            Converted = 41967347,
            EncodingStyle = DateTimeEncodingStyle.TimeMillis,
        };

        public static TestCase<DateTime> DateTimeAsTimeMicros => new DateTimeTestCase
        {
            Name = nameof(DateTimeAsTimeMicros),
            Value = System.DateTime.ParseExact("0001-01-01T11:39:27.3475680Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
            BinaryEncoding = new byte[] { 0xE0, 0x9D, 0x97, 0xD7, 0xB8, 0x02 },
            BinaryByteCount = 6L,
            JsonEncoding = "41967347568",
            JsonByteCount = 11L,
            Convert = (t) => AvroConverter.DateTimeToTimeMicros(t.Value),
            Unconvert = (t) => AvroConverter.TimeMicrosToDateTime((long)t.Converted),
            Converted = 41967347568L,
            EncodingStyle = DateTimeEncodingStyle.TimeMicros,
        };

        public static TestCase<DateTime> DateTimeAsTimestampMillisUtc => new DateTimeTestCase
        {
            Name = nameof(DateTimeAsTimestampMillisUtc),
            Value = System.DateTime.ParseExact("2021-10-22T11:39:27.3470000Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
            BinaryEncoding = new byte[] { 0xE6, 0xDB, 0xE3, 0xFC, 0x94, 0x5F },
            BinaryByteCount = 6L,
            JsonEncoding = "1634902767347",
            JsonByteCount = 13L,
            Convert = (t) => AvroConverter.DateTimeToTimestampMillisUtc(t.Value),
            Unconvert = (t) => AvroConverter.TimestampMillisUtcToDateTime((long)t.Converted),
            Converted = 1634902767347L,
            EncodingStyle = DateTimeEncodingStyle.TimestampMillisUtc,
        };

        public static TestCase<DateTime> DateTimeAsTimestampMicrosUtc => new DateTimeTestCase
        {
            Name = nameof(DateTimeAsTimestampMicrosUtc),
            Value = System.DateTime.ParseExact("2021-10-22T11:39:27.3475680Z", "O", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
            BinaryEncoding = new byte[] { 0xE0, 0x9D, 0x85, 0xEB, 0xEE, 0xBB, 0xE7, 0x05 },
            BinaryByteCount = 8L,
            JsonEncoding = "1634902767347568",
            JsonByteCount = 16L,
            Convert = (t) => AvroConverter.DateTimeToTimestampMicrosUtc(t.Value),
            Unconvert = (t) => AvroConverter.TimestampMicrosUtcToDateTime((long)t.Converted),
            Converted = 1634902767347568L,
            EncodingStyle = DateTimeEncodingStyle.TimestampMicrosUtc,
        };

        public static TestCase<DateTime> DateTimeAsTimestampMillisLocal => new DateTimeTestCase
        {
            Name = nameof(DateTimeAsTimestampMillisLocal),
            Value = System.DateTime.Parse("2021-10-22T11:39:27.3470000", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal),
            BinaryEncoding = new byte[] { 0xE6, 0xDB, 0xE3, 0xFC, 0x94, 0x5F },
            BinaryByteCount = 6L,
            JsonEncoding = "1634902767347",
            JsonByteCount = 13L,
            Convert = (t) => AvroConverter.DateTimeToTimestampMillisLocal(t.Value),
            Unconvert = (t) => AvroConverter.TimestampMillisLocalToDateTime((long)t.Converted),
            Converted = 1634902767347L,
            EncodingStyle = DateTimeEncodingStyle.TimestampMillisLocal,
        };

        public static TestCase<DateTime> DateTimeAsTimestampMicrosLocal => new DateTimeTestCase
        {
            Name = nameof(DateTimeAsTimestampMicrosLocal),
            Value = System.DateTime.Parse("2021-10-22T11:39:27.3475680", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal),
            BinaryEncoding = new byte[] { 0xE0, 0x9D, 0x85, 0xEB, 0xEE, 0xBB, 0xE7, 0x05 },
            BinaryByteCount = 8L,
            JsonEncoding = "1634902767347568",
            JsonByteCount = 16L,
            Convert = (t) => AvroConverter.DateTimeToTimestampMicrosLocal(t.Value),
            Unconvert = (t) => AvroConverter.TimestampMicrosLocalToDateTime((long)t.Converted),
            Converted = 1634902767347568L,
            EncodingStyle = DateTimeEncodingStyle.TimestampMicrosLocal,
        };
    }
}
