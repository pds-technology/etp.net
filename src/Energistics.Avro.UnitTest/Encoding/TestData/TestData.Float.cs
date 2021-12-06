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

namespace Energistics.Avro.Encoding
{
    public static partial class TestData
    {
        private class FloatTestCase : TestCase<float>
        {
            public FloatTestCase()
            {
                PrimitiveEncode = (t, encoder) => encoder.EncodeFloat(t.Value);
                PrimitiveDecode = (t, decoder) => decoder.DecodeFloat();
                Convert = (t) => AvroConverter.FloatToBytes(t.Value);
                Unconvert = (t) => AvroConverter.BytesToFloat((byte[])t.Converted);
            }
        }

        public static TestCase<float>[] Float => new TestCase<float>[] { FloatPi, FloatMinusPi, Float1e7, Float1eMinus7, FloatNaN, FloatPositiveInfinity, FloatNegativeInfinity };

        public static TestCase<float> FloatPi => new FloatTestCase
        {
            Name = nameof(FloatPi),
            Value = (float)Math.PI,
            BinaryEncoding = new byte[] { 0xDB, 0x0F, 0x49, 0x40 },
            BinaryByteCount = 4L,
            JsonEncoding = "3.14159274",
            JsonByteCount = 10L,
            Converted = new byte[] { 0xDB, 0x0F, 0x49, 0x40 },
        };

        public static TestCase<float> FloatMinusPi => new FloatTestCase
        {
            Name = nameof(FloatMinusPi),
            Value = (float)-Math.PI,
            BinaryEncoding = new byte[] { 0xDB, 0x0F, 0x49, 0xC0, },
            BinaryByteCount = 4L,
            JsonEncoding = "-3.14159274",
            JsonByteCount = 11L,
            Converted = new byte[] { 0xDB, 0x0F, 0x49, 0xC0, },
        };

        public static TestCase<float> Float1e7 => new FloatTestCase
        {
            Name = nameof(Float1e7),
            Value = 1e7F,
            BinaryEncoding = new byte[] { 0x80, 0x96, 0x18, 0x4B },
            BinaryByteCount = 4L,
            JsonEncoding = "10000000",
            JsonByteCount = 8L,
            Converted = new byte[] { 0x80, 0x96, 0x18, 0x4B },
        };

        public static TestCase<float> Float1eMinus7 => new FloatTestCase
        {
            Name = nameof(Float1eMinus7),
            Value = 1e-7F,
            BinaryEncoding = new byte[] { 0x95, 0xBF, 0xD6, 0x33 },
            BinaryByteCount = 4L,
            JsonEncoding = "1.00000001E-07",
            JsonByteCount = 14L,
            Converted = new byte[] { 0x95, 0xBF, 0xD6, 0x33 },
        };

        public static TestCase<float> FloatNaN => new FloatTestCase
        {
            Name = nameof(FloatNaN),
            Value = float.NaN,
            BinaryEncoding = new byte[] { 0x00, 0x00, 0xC0, 0xFF },
            BinaryByteCount = 4L,
            JsonEncoding = "null",
            JsonByteCount = 4L,
            Converted = new byte[] { 0x00, 0x00, 0xC0, 0xFF },
        };

        public static TestCase<float> FloatPositiveInfinity => new FloatTestCase
        {
            Name = nameof(FloatPositiveInfinity),
            Value = float.PositiveInfinity,
            BinaryEncoding = new byte[] { 0x00, 0x00, 0x80, 0x7F },
            BinaryByteCount = 4,
            JsonEncoding = "1.7976931348623157E308",
            JsonByteCount = 22,
            Converted = new byte[] { 0x00, 0x00, 0x80, 0x7F },
        };

        public static TestCase<float> FloatNegativeInfinity => new FloatTestCase
        {
            Name = nameof(FloatNegativeInfinity),
            Value = float.NegativeInfinity,
            BinaryEncoding = new byte[] { 0x00, 0x00, 0x80, 0xFF },
            BinaryByteCount = 4L,
            JsonEncoding = "-1.7976931348623157E308",
            JsonByteCount = 23L,
            Converted = new byte[] { 0x00, 0x00, 0x80, 0xFF },
        };
    }
}
