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
using System;
using System.Globalization;

namespace Energistics.Avro.Encoding
{
    public static partial class TestData
    {
        private class TimeSpanTestCase : TestCase<TimeSpan>
        {
            public TimeSpanTestCase()
            {
                AvroEncode = (t, encoder) => encoder.EncodeTimeSpan(t.Value, (TimeSpanEncodingStyle)t.EncodingStyle);
                AvroDecode = (t, decoder) => decoder.DecodeTimeSpan((TimeSpanEncodingStyle)t.EncodingStyle);
            }
        }

        public static void EncodeTimeSpan(this IAvroEncoder encoder, TimeSpan value, TimeSpanEncodingStyle style)
        {
            switch (style)
            {
                case TimeSpanEncodingStyle.Iso8601String: encoder.EncodeDurationTimeSpanAsIso8601String(value); return;
                case TimeSpanEncodingStyle.Milliseconds: encoder.EncodeMillisecondsTimeSpanAsLong(value); return;
                case TimeSpanEncodingStyle.Microseconds: encoder.EncodeMicrosecondsTimeSpanAsLong(value); return;
                case TimeSpanEncodingStyle.TimeMillis: encoder.EncodeTimeMillisTimeSpanAsInt(value); return;
                case TimeSpanEncodingStyle.TimeMicros: encoder.EncodeTimeMicrosTimeSpanAsLong(value); return;
                case TimeSpanEncodingStyle.Duration: encoder.EncodeDurationTimeSpanAsFixed(value); return;
                default:
                    throw new ArgumentException("Invalid style", nameof(style));
            }
        }

        public static TimeSpan DecodeTimeSpan(this IAvroDecoder decoder, TimeSpanEncodingStyle style)
        {
            switch (style)
            {
                case TimeSpanEncodingStyle.Iso8601String: return decoder.DecodeDurationTimeSpanAsIso8601String();
                case TimeSpanEncodingStyle.Milliseconds: return decoder.DecodeMillisecondsTimeSpanAsLong();
                case TimeSpanEncodingStyle.Microseconds: return decoder.DecodeMicrosecondsTimeSpanAsLong();
                case TimeSpanEncodingStyle.TimeMillis: return decoder.DecodeTimeMillisTimeSpanAsInt();
                case TimeSpanEncodingStyle.TimeMicros: return decoder.DecodeTimeMicrosTimeSpanAsLong();
                case TimeSpanEncodingStyle.Duration: return decoder.DecodeDurationTimeSpanAsFixed();
                default:
                    throw new ArgumentException("Invalid style", nameof(style));
            }
        }

        public static TestCase<TimeSpan>[] TimeSpan => new TestCase<TimeSpan>[] { TimeSpanAsIso8601String, TimeSpanAsMilliseconds, TimeSpanAsMicroseconds, TimeSpanAsTimeMillis, TimeSpanAsTimeMicros, TimeSpanAsDuration };

        public static TestCase<TimeSpan> TimeSpanAsIso8601String => new TimeSpanTestCase
        {
            Name = nameof(TimeSpanAsIso8601String),
            Value = System.TimeSpan.ParseExact("22.11:39:27.347", "c", CultureInfo.InvariantCulture),
            BinaryEncoding = new byte[] { 0x24, 0x50, 0x32, 0x32, 0x44, 0x54, 0x31, 0x31, 0x48, 0x33, 0x39, 0x4D, 0x32, 0x37, 0x2E, 0x33, 0x34, 0x37, 0x53 },
            BinaryByteCount = 19L,
            JsonEncoding = "\"P22DT11H39M27.347S\"",
            JsonByteCount = 20L,
            Convert = (t) => AvroConverter.TimeSpanToIso8601String(t.Value),
            Unconvert = (t) => AvroConverter.Iso8601StringToTimeSpan((string)t.Converted),
            Converted = "P22DT11H39M27.347S",
            EncodingStyle = TimeSpanEncodingStyle.Iso8601String,
        };
        
        public static TestCase<TimeSpan> TimeSpanAsMilliseconds => new TimeSpanTestCase
        {
            Name = nameof(TimeSpanAsMilliseconds),
            Value = System.TimeSpan.ParseExact("22.11:39:27.347", "c", CultureInfo.InvariantCulture),
            BinaryEncoding = new byte[] { 0xE6, 0x9B, 0xE2, 0xBC, 0x0E },
            BinaryByteCount = 5L,
            JsonEncoding = "1942767347",
            JsonByteCount = 10L,
            Convert = (t) => AvroConverter.TimeSpanToMilliseconds(t.Value),
            Unconvert = (t) => AvroConverter.MillisecondsToTimeSpan((long)t.Converted),
            Converted = 1942767347L,
            EncodingStyle = TimeSpanEncodingStyle.Milliseconds,
        };

        public static TestCase<TimeSpan> TimeSpanAsMicroseconds => new TimeSpanTestCase
        {
            Name = nameof(TimeSpanAsMicroseconds),
            Value = System.TimeSpan.ParseExact("22.11:39:27.347568", "c", CultureInfo.InvariantCulture),
            BinaryEncoding = new byte[] { 0xE0, 0x9D, 0xA9, 0xDF, 0x8A, 0x71 },
            BinaryByteCount = 6L,
            JsonEncoding = "1942767347568",
            JsonByteCount = 13L,
            Convert = (t) => AvroConverter.TimeSpanToMicroseconds(t.Value),
            Unconvert = (t) => AvroConverter.MicrosecondsToTimeSpan((long)t.Converted),
            Converted = 1942767347568L,
            EncodingStyle = TimeSpanEncodingStyle.Microseconds,
        };

        public static TestCase<TimeSpan> TimeSpanAsTimeMillis => new TimeSpanTestCase
        {
            Name = nameof(TimeSpanAsTimeMillis),
            Value = System.TimeSpan.ParseExact("11:39:27.347", "c", CultureInfo.InvariantCulture),
            BinaryEncoding = new byte[] { 0xE6, 0xFB, 0x82, 0x28 },
            BinaryByteCount = 4L,
            JsonEncoding = "41967347",
            JsonByteCount = 8L,
            Convert = (t) => AvroConverter.TimeSpanToTimeMillis(t.Value),
            Unconvert = (t) => AvroConverter.TimeMillisToTimeSpan((int)t.Converted),
            Converted = 41967347,
            EncodingStyle = TimeSpanEncodingStyle.TimeMillis,
        };

        public static TestCase<TimeSpan> TimeSpanAsTimeMicros => new TimeSpanTestCase
        {
            Name = nameof(TimeSpanAsTimeMicros),
            Value = System.TimeSpan.ParseExact("11:39:27.347568", "c", CultureInfo.InvariantCulture),
            BinaryEncoding = new byte[] { 0xE0, 0x9D, 0x97, 0xD7, 0xB8, 0x02 },
            BinaryByteCount = 6L,
            JsonEncoding = "41967347568",
            JsonByteCount = 11L,
            Convert = (t) => AvroConverter.TimeSpanToTimeMicros(t.Value),
            Unconvert = (t) => AvroConverter.TimeMicrosToTimeSpan((long)t.Converted),
            Converted = 41967347568L,
            EncodingStyle = TimeSpanEncodingStyle.TimeMicros,
        };

        public static TestCase<TimeSpan> TimeSpanAsDuration => new TimeSpanTestCase
        {
            Name = nameof(TimeSpanAsDuration), // 0x02 80 5E F3
            Value = System.TimeSpan.ParseExact("22.11:39:27.347", "c", CultureInfo.InvariantCulture),
            BinaryEncoding = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x16, 0x00, 0x00, 0x00, 0xF3, 0x5E, 0x80, 0x02 },
            BinaryByteCount = 12L,
            JsonEncoding = "\"\\u0000\\u0000\\u0000\\u0000\\u0016\\u0000\\u0000\\u0000ó^\\u0080\\u0002\"",
            JsonByteCount = 65L,
            Convert = (t) => AvroConverter.TimeSpanToDuration(t.Value),
            Unconvert = (t) => AvroConverter.DurationToTimeSpan((byte[])t.Converted),
            Converted = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x16, 0x00, 0x00, 0x00, 0xF3, 0x5E, 0x80, 0x02 },
            EncodingStyle = TimeSpanEncodingStyle.Duration,
        };
    }
}
