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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Energistics.Avro.Encoding
{
    public static partial class TestData
    {
        private class MapTestCase : TestCase<IDictionary>
        {
            public MapTestCase()
            {
                AvroEncode = (t, encoder) => encoder.EncodeMap(t.Value);
                AvroDecode = (t, decoder) => decoder.DecodeMap(ValueType);
            }

            public Type ValueType { get; set; }
        }

        private static void EncodeMap(this IAvroEncoder encoder, IDictionary value)
        {
            switch (value)
            {
                case Dictionary<string, bool> b: encoder.EncodeMapOfBoolean(b); return;
                case Dictionary<string, int> i: encoder.EncodeMapOfInt(i); return;
                case Dictionary<string, long> l: encoder.EncodeMapOfLong(l); return;
                case Dictionary<string, float> f: encoder.EncodeMapOfFloat(f); return;
                case Dictionary<string, double> d: encoder.EncodeMapOfDouble(d); return;
                case Dictionary<string, string> s: encoder.EncodeMapOfString(s); return;
                case Dictionary<string, byte[]> by: encoder.EncodeMapOfBytes(by); return;
                default:
                    throw new ArgumentException("Invalid map", nameof(value));
            }
        }

        public static IDictionary DecodeMap(this IAvroDecoder decoder, Type type)
        {
            if (type == typeof(bool)) return decoder.DecodeMapOfBoolean() as IDictionary;
            if (type == typeof(int)) return decoder.DecodeMapOfInt() as IDictionary;
            if (type == typeof(long)) return decoder.DecodeMapOfLong() as IDictionary;
            if (type == typeof(float)) return decoder.DecodeMapOfFloat() as IDictionary;
            if (type == typeof(double)) return decoder.DecodeMapOfDouble() as IDictionary;
            if (type == typeof(string)) return decoder.DecodeMapOfString() as IDictionary;
            if (type == typeof(byte[])) return decoder.DecodeMapOfBytes() as IDictionary;

            throw new ArgumentException("Invalid value type", nameof(type));
        }

        public static TestCase<IDictionary>[] Map => new TestCase<IDictionary>[] { EmptyMap, MapOfBoolean, MapOfInt, MapOfLong, MapOfFloat, MapOfDouble, MapOfString, MapOfBytes };

        public static TestCase<IDictionary> EmptyMap => new MapTestCase
        {
            Name = nameof(EmptyMap),
            Value = new Dictionary<string, bool> { },
            BinaryEncoding = new byte[] { 0x00 },
            BinaryByteCount = 1L,
            JsonEncoding = "{}",
            JsonByteCount = 2L,
            ValueType = typeof(bool),
        };

        public static TestCase<IDictionary> MapOfBoolean => new MapTestCase
        {
            Name = nameof(MapOfBoolean),
            Value = new Dictionary<string, bool> { ["a"] = true, ["b"] = false },
            BinaryEncoding = new byte[] { 0x04, 0x02, (byte)'a', 0x01, 0x02, (byte)'b', 0x00, 0x00 },
            BinaryByteCount = 8L,
            JsonEncoding = "{\"a\":true,\"b\":false}",
            JsonByteCount = 20L,
            ValueType = typeof(bool),
        };

        public static TestCase<IDictionary> MapOfInt => new MapTestCase
        {
            Name = nameof(MapOfInt),
            Value = new Dictionary<string, int> { ["a"] = -1, ["b"] = 0, ["c"] = 1, ["d"] = 64 },
            BinaryEncoding = new byte[] { 0x08, 0x02, (byte)'a', 0x01, 0x02, (byte)'b', 0x00, 0x02, (byte)'c', 0x02, 0x02, (byte)'d', 0x80, 0x01, 0x00 },
            BinaryByteCount = 15L,
            JsonEncoding = "{\"a\":-1,\"b\":0,\"c\":1,\"d\":64}",
            JsonByteCount = 27L,
            ValueType = typeof(int),
        };

        public static TestCase<IDictionary> MapOfLong => new MapTestCase
        {
            Name = nameof(MapOfLong),
            Value = new Dictionary<string, long> { ["a"] = -1, ["b"] = 0, ["c"] = 1, ["d"] = -36028797018963968L },
            BinaryEncoding = new byte[] { 0x08, 0x02, (byte)'a', 0x01, 0x02, (byte)'b', 0x00, 0x02, (byte)'c', 0x02, 0x02, (byte)'d', 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0x00 },
            BinaryByteCount = 21L,
            JsonEncoding = "{\"a\":-1,\"b\":0,\"c\":1,\"d\":-36028797018963968}",
            JsonByteCount = 43L,
            ValueType = typeof(long),
        };

        public static TestCase<IDictionary> MapOfFloat => new MapTestCase
        {
            Name = nameof(MapOfFloat),
            Value = new Dictionary<string, float> { ["a"] = (float)Math.PI, ["b"] = 1e7F, ["c"] = float.NaN, ["d"] = float.PositiveInfinity, ["e"] = float.NegativeInfinity },
            BinaryEncoding = new byte[] { 0x0A, 0x02, (byte)'a', 0xDB, 0x0F, 0x49, 0x40, 0x02, (byte)'b', 0x80, 0x96, 0x18, 0x4B, 0x02, (byte)'c', 0x00, 0x00, 0xC0, 0xFF, 0x02, (byte)'d', 0x00, 0x00, 0x80, 0x7F, 0x02, (byte)'e', 0x00, 0x00, 0x80, 0xFF, 0x00 },
            BinaryByteCount = 32L,
            JsonEncoding = "{\"a\":3.14159274,\"b\":10000000,\"c\":null,\"d\":1.7976931348623157E308,\"e\":-1.7976931348623157E308}",
            JsonByteCount = 93L,
            ValueType = typeof(float),
        };

        public static TestCase<IDictionary> MapOfDouble => new MapTestCase
        {
            Name = nameof(MapOfDouble),
            Value = new Dictionary<string, double> { ["a"] = Math.PI, ["b"] = 1e7, ["c"] = double.NaN, ["d"] = double.PositiveInfinity, ["e"] = double.NegativeInfinity },
            BinaryEncoding = new byte[] { 0x0A, 0x02, (byte)'a', 0x18, 0x2D, 0x44, 0x54, 0xFB, 0x21, 0x09, 0x40, 0x02, (byte)'b', 0x00, 0x00, 0x00, 0x00, 0xD0, 0x12, 0x63, 0x41, 0x02, (byte)'c', 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF8, 0xFF, 0x02, (byte)'d', 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF0, 0x7F, 0x02, (byte)'e', 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF0, 0xFF, 0x00 },
            BinaryByteCount = 52L,
            JsonEncoding = "{\"a\":3.1415926535897931,\"b\":10000000,\"c\":null,\"d\":1.7976931348623157E308,\"e\":-1.7976931348623157E308}",
            JsonByteCount = 101L,
            ValueType = typeof(double),
        };

        public static TestCase<IDictionary> MapOfString => new MapTestCase
        {
            Name = nameof(MapOfString),
            Value = new Dictionary<string, string> { ["a"] = "test", ["b"] = "abc", ["c"] = "\u0000\u0001\u0002\u0003\u0004\u0005\u0006\u0007\b\t\n" },
            BinaryEncoding = new byte[] { 0x06, 0x02, (byte)'a', 0x08, (byte)'t', (byte)'e', (byte)'s', (byte)'t', 0x02, (byte)'b', 0x06, (byte)'a', (byte)'b', (byte)'c', 0x02, (byte)'c', 0x16, 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x00 },
            BinaryByteCount = 29L,
            JsonEncoding = "{\"a\":\"test\",\"b\":\"abc\",\"c\":\"\\u0000\\u0001\\u0002\\u0003\\u0004\\u0005\\u0006\\u0007\\b\\t\\n\"}",
            JsonByteCount = 83L,
            ValueType = typeof(string),
        };

        public static TestCase<IDictionary> MapOfBytes => new MapTestCase
        {
            Name = nameof(MapOfBytes),
            Value = new Dictionary<string, byte[]> { ["a"] = new byte[] { 0, 1, 2 }, ["b"] = new byte[] { 3, 4, 5 } },
            BinaryEncoding = new byte[] { 0x04, 0x02, (byte)'a', 0x06, 0x00, 0x01, 0x02, 0x02, (byte)'b', 0x06, 0x03, 0x04, 0x05, 0x00 },
            BinaryByteCount = 14L,
            JsonEncoding = "{\"a\":\"\\u0000\\u0001\\u0002\",\"b\":\"\\u0003\\u0004\\u0005\"}",
            JsonByteCount = 51L,
            ValueType = typeof(byte[]),
        };
    }
}
