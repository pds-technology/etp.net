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
        private class DoubleTestCase : TestCase<double>
        {
            public DoubleTestCase()
            {
                PrimitiveEncode = (t, encoder) => encoder.EncodeDouble(t.Value);
                PrimitiveDecode = (t, decoder) => decoder.DecodeDouble();
                Convert = (t) => AvroConverter.DoubleToBytes(t.Value);
                Unconvert = (t) => AvroConverter.BytesToDouble((byte[])t.Converted);
            }
        }

        public static TestCase<double>[] Double => new TestCase<double>[] { DoublePi, DoubleMinusPi, Double1e7, Double1eMinus7, DoubleNaN, DoublePositiveInfinity, DoubleNegativeInfinity };

        public static TestCase<double> DoublePi => new DoubleTestCase
        {
            Name = nameof(DoublePi),
            Value = Math.PI,
            BinaryEncoding = new byte[] { 0x18, 0x2D, 0x44, 0x54, 0xFB, 0x21, 0x09, 0x40 },
            BinaryByteCount = 8L,
            JsonEncoding = "3.1415926535897931",
            JsonByteCount = 18L,
            Converted = new byte[] { 0x18, 0x2D, 0x44, 0x54, 0xFB, 0x21, 0x09, 0x40 },
        };

        public static TestCase<double> DoubleMinusPi => new DoubleTestCase
        {
            Name = nameof(DoubleMinusPi),
            Value = -Math.PI,
            BinaryEncoding = new byte[] { 0x18, 0x2D, 0x44, 0x54, 0xFB, 0x21, 0x09, 0xC0 },
            BinaryByteCount = 8L,
            JsonEncoding = "-3.1415926535897931",
            JsonByteCount = 19L,
            Converted = new byte[] { 0x18, 0x2D, 0x44, 0x54, 0xFB, 0x21, 0x09, 0xC0 },
        };

        public static TestCase<double> Double1e7 => new DoubleTestCase
        {
            Name = nameof(Double1e7),
            Value = 1e7,
            BinaryEncoding = new byte[] { 0x00, 0x00, 0x00, 0x00, 0xD0, 0x12, 0x63, 0x41 },
            BinaryByteCount = 8L,
            JsonEncoding = "10000000",
            JsonByteCount = 8L,
            Converted = new byte[] { 0x00, 0x00, 0x00, 0x00, 0xD0, 0x12, 0x63, 0x41 },
        };

        public static TestCase<double> Double1eMinus7 => new DoubleTestCase
        {
            Name = nameof(Double1eMinus7),
            Value = 1e-7,
            BinaryEncoding = new byte[] { 0x48, 0xAF, 0xBC, 0x9A, 0xF2, 0xD7, 0x7A, 0x3E },
            BinaryByteCount = 8L,
            JsonEncoding = "9.9999999999999995E-08",
            JsonByteCount = 22L,
            Converted = new byte[] { 0x48, 0xAF, 0xBC, 0x9A, 0xF2, 0xD7, 0x7A, 0x3E },
        };

        public static TestCase<double> DoubleNaN => new DoubleTestCase
        {
            Name = nameof(DoubleNaN),
            Value = double.NaN,
            BinaryEncoding = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF8, 0xFF },
            BinaryByteCount = 8L,
            JsonEncoding = "null",
            JsonByteCount = 4L,
            Converted = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF8, 0xFF },
        };

        public static TestCase<double> DoublePositiveInfinity => new DoubleTestCase
        {
            Name = nameof(DoublePositiveInfinity),
            Value = double.PositiveInfinity,
            BinaryEncoding = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF0, 0x7F },
            BinaryByteCount = 8L,
            JsonEncoding = "1.7976931348623157E308",
            JsonByteCount = 22L,
            Converted = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF0, 0x7F },
        };

        public static TestCase<double> DoubleNegativeInfinity => new DoubleTestCase
        {
            Name = nameof(DoubleNegativeInfinity),
            Value = double.NegativeInfinity,
            BinaryEncoding = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF0, 0xFF },
            BinaryByteCount = 8L,
            JsonEncoding = "-1.7976931348623157E308",
            JsonByteCount = 23L,
            Converted = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF0, 0xFF },
        };
    }
}
