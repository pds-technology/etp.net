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
using System.Linq;

namespace Energistics.Avro.Encoding
{
    public static partial class TestData
    {
        private class ArrayTestCase : TestCase<Array>
        {
            public ArrayTestCase()
            {
                AvroEncode = (t, encoder) => encoder.EncodeArray(t.Value);
                AvroDecode = (t, decoder) => decoder.DecodeArray(ArrayType);
            }

            public Type ArrayType { get; set; }
        }

        private static void EncodeArray(this IAvroEncoder encoder, Array value)
        {
            switch (value)
            {
                case bool[] b: encoder.EncodeArrayOfBoolean(b); return;
                case int[] i: encoder.EncodeArrayOfInt(i); return;
                case long[] l: encoder.EncodeArrayOfLong(l); return;
                case float[] f: encoder.EncodeArrayOfFloat(f); return;
                case double[] d: encoder.EncodeArrayOfDouble(d); return;
                case string[] s: encoder.EncodeArrayOfString(s); return;
                case byte[][] by: encoder.EncodeArrayOfBytes(by); return;
                default:
                    throw new ArgumentException("Invalid array", nameof(value));
            }
        }

        public static IList DecodeArray(this IAvroDecoder decoder, Type type)
        {
            if (type == typeof(bool[])) return decoder.DecodeArrayOfBoolean().ToArray();
            if (type == typeof(int[])) return decoder.DecodeArrayOfInt().ToArray();
            if (type == typeof(long[])) return decoder.DecodeArrayOfLong().ToArray();
            if (type == typeof(float[])) return decoder.DecodeArrayOfFloat().ToArray();
            if (type == typeof(double[])) return decoder.DecodeArrayOfDouble().ToArray();
            if (type == typeof(string[])) return decoder.DecodeArrayOfString().ToArray();
            if (type == typeof(byte[][])) return decoder.DecodeArrayOfBytes().ToArray();

            throw new ArgumentException("Invalid array type", nameof(type));
        }

        public static TestCase<Array>[] Array => new TestCase<Array>[] { EmptyArray, ArrayOfBoolean, ArrayOfInt, ArrayOfLong, ArrayOfFloat, ArrayOfDouble, ArrayOfString, ArrayOfBytes };

        public static TestCase<Array> EmptyArray => new ArrayTestCase
        {
            Name = nameof(EmptyArray),
            Value = new bool[] { },
            BinaryEncoding = new byte[] { 0x00 },
            BinaryByteCount = 1L,
            JsonEncoding = "[]",
            JsonByteCount = 2L,
            ArrayType = typeof(bool[]),
        };

        public static TestCase<Array> ArrayOfBoolean => new ArrayTestCase
        {
            Name = nameof(ArrayOfBoolean),
            Value = new bool[] { true, false },
            BinaryEncoding = new byte[] { 0x04, 0x01, 0x00, 0x00 },
            BinaryByteCount = 4L,
            JsonEncoding = "[true,false]",
            JsonByteCount = 12L,
            ArrayType = typeof(bool[]),
        };

        public static TestCase<Array> ArrayOfInt => new ArrayTestCase
        {
            Name = nameof(ArrayOfInt),
            Value = new int[] { -1, 0, 1, 64 },
            BinaryEncoding = new byte[] { 0x08, 0x01, 0x00, 0x02, 0x80, 0x01, 0x00 },
            BinaryByteCount = 7L,
            JsonEncoding = "[-1,0,1,64]",
            JsonByteCount = 11L,
            ArrayType = typeof(int[]),
        };

        public static TestCase<Array> ArrayOfLong => new ArrayTestCase
        {
            Name = nameof(ArrayOfLong),
            Value = new long[] { -1L, 0L, 1L, -36028797018963968L },
            BinaryEncoding = new byte[] { 0x08, 0x01, 0x00, 0x02, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0x00 },
            BinaryByteCount = 13L,
            JsonEncoding = "[-1,0,1,-36028797018963968]",
            JsonByteCount = 27L,
            ArrayType = typeof(long[]),
        };

        public static TestCase<Array> ArrayOfFloat => new ArrayTestCase
        {
            Name = nameof(ArrayOfFloat),
            Value = new float[] { (float)Math.PI, 1e7F, float.NaN, float.PositiveInfinity, float.NegativeInfinity },
            BinaryEncoding = new byte[] { 0x0A, 0xDB, 0x0F, 0x49, 0x40, 0x80, 0x96, 0x18, 0x4B, 0x00, 0x00, 0xC0, 0xFF, 0x00, 0x00, 0x80, 0x7F, 0x00, 0x00, 0x80, 0xFF, 0x00 },
            BinaryByteCount = 22L,
            JsonEncoding = "[3.14159274,10000000,null,1.7976931348623157E308,-1.7976931348623157E308]",
            JsonByteCount = 73L,
            ArrayType = typeof(float[]),
        };

        public static TestCase<Array> ArrayOfDouble => new ArrayTestCase
        {
            Name = nameof(ArrayOfDouble),
            Value = new double[] { Math.PI, 1e7, double.NaN, double.PositiveInfinity, double.NegativeInfinity },
            BinaryEncoding = new byte[] { 0x0A, 0x18, 0x2D, 0x44, 0x54, 0xFB, 0x21, 0x09, 0x40, 0x00, 0x00, 0x00, 0x00, 0xD0, 0x12, 0x63, 0x41, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF8, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF0, 0x7F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF0, 0xFF, 0x00 },
            BinaryByteCount = 42L,
            JsonEncoding = "[3.1415926535897931,10000000,null,1.7976931348623157E308,-1.7976931348623157E308]",
            JsonByteCount = 81L,
            ArrayType = typeof(double[]),
        };

        public static TestCase<Array> ArrayOfString => new ArrayTestCase
        {
            Name = nameof(ArrayOfString),
            Value = new string[] { "test", "abc", "\u0000\u0001\u0002\u0003\u0004\u0005\u0006\u0007\b\t\n" },
            BinaryEncoding = new byte[] { 0x06, 0x08, (byte)'t', (byte)'e', (byte)'s', (byte)'t', 0x06, (byte)'a', (byte)'b', (byte)'c', 0x16, 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x00 },
            BinaryByteCount = 23L,
            JsonEncoding = "[\"test\",\"abc\",\"\\u0000\\u0001\\u0002\\u0003\\u0004\\u0005\\u0006\\u0007\\b\\t\\n\"]",
            JsonByteCount = 71L,
            ArrayType = typeof(string[]),
        };

        public static TestCase<Array> ArrayOfBytes => new ArrayTestCase
        {
            Name = nameof(ArrayOfBytes),
            Value = new byte[][] { new byte[] { 0, 1, 2 }, new byte[] { 3, 4, 5 } },
            BinaryEncoding = new byte[] { 0x04, 0x06, 0x00, 0x01, 0x02, 0x06, 0x03, 0x04, 0x05, 0x00 },
            BinaryByteCount = 10L,
            JsonEncoding = "[\"\\u0000\\u0001\\u0002\",\"\\u0003\\u0004\\u0005\"]",
            JsonByteCount = 43L,
            ArrayType = typeof(byte[][]),
        };
    }
}
