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

namespace Energistics.Avro.Encoding
{
    public static partial class TestData
    {
        private class LongTestCase : TestCase<long>
        {
            public LongTestCase()
            {
                PrimitiveEncode = (t, encoder) => encoder.EncodeLong(t.Value);
                PrimitiveDecode = (t, decoder) => decoder.DecodeLong();
            }
        }

        public static TestCase<long>[] Long => new TestCase<long>[] { Long0, Long1, LongMinus1, Long64, LongMinus64, Long1048576, LongMinus1048576, Long36028797018963968, LongMinus36028797018963968 };

        public static TestCase<long> Long0 => new LongTestCase
        {
            Name = nameof(Long0),
            Value = 0L,
            BinaryEncoding = new byte[] { 0 },
            BinaryByteCount = 1L,
            JsonEncoding = "0",
            JsonByteCount = 1L,
        };

        public static TestCase<long> Long1 => new LongTestCase
        {
            Name = nameof(Long1),
            Value = 1L,
            BinaryEncoding = new byte[] { 2 },
            BinaryByteCount = 1L,
            JsonEncoding = "1",
            JsonByteCount = 1L,
        };

        public static TestCase<long> LongMinus1 => new LongTestCase
        {
            Name = nameof(LongMinus1),
            Value = -1L,
            BinaryEncoding = new byte[] { 1 },
            BinaryByteCount = 1L,
            JsonEncoding = "-1",
            JsonByteCount = 2L,
        };

        public static TestCase<long> Long64 => new LongTestCase
        {
            Name = nameof(Long64),
            Value = 64L,
            BinaryEncoding = new byte[] { 0x80, 0x01 },
            BinaryByteCount = 2L,
            JsonEncoding = "64",
            JsonByteCount = 2L,
        };

        public static TestCase<long> LongMinus64 => new LongTestCase
        {
            Name = nameof(LongMinus64),
            Value = -64L,
            BinaryEncoding = new byte[] { 0x7F },
            BinaryByteCount = 1L,
            JsonEncoding = "-64",
            JsonByteCount = 3L,
        };

        public static TestCase<long> Long1048576 => new LongTestCase
        {
            Name = nameof(Long1048576),
            Value = 1048576L,
            BinaryEncoding = new byte[] { 0x80, 0x80, 0x80, 0x01 },
            BinaryByteCount = 4L,
            JsonEncoding = "1048576",
            JsonByteCount = 7L,
        };

        public static TestCase<long> LongMinus1048576 => new LongTestCase
        {
            Name = nameof(LongMinus1048576),
            Value = -1048576L,
            BinaryEncoding = new byte[] { 0xFF, 0xFF, 0x7F },
            BinaryByteCount = 3L,
            JsonEncoding = "-1048576",
            JsonByteCount = 8L,
        };

        public static TestCase<long> Long36028797018963968 => new LongTestCase
        {
            Name = nameof(Long36028797018963968),
            Value = 36028797018963968L,
            BinaryEncoding = new byte[] { 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x01 },
            BinaryByteCount = 9L,
            JsonEncoding = "36028797018963968",
            JsonByteCount = 17L,
        };

        public static TestCase<long> LongMinus36028797018963968 => new LongTestCase
        {
            Name = nameof(LongMinus36028797018963968),
            Value = -36028797018963968L,
            BinaryEncoding = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F },
            BinaryByteCount = 8L,
            JsonEncoding = "-36028797018963968",
            JsonByteCount = 18L,
        };
    }
}
