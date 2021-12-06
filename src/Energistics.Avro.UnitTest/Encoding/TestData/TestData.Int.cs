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
        private class IntTestCase : TestCase<int>
        {
            public IntTestCase()
            {
                PrimitiveEncode = (t, encoder) => encoder.EncodeInt(t.Value);
                PrimitiveDecode = (t, decoder) => decoder.DecodeInt();
            }
        }

        public static TestCase<int>[] Int => new TestCase<int>[] { Int0, Int1, IntMinus1, Int64, IntMinus64, Int1048576, IntMinus1048576 };

        public static TestCase<int> Int0 => new IntTestCase
        {
            Name = nameof(Int0),
            Value = 0,
            BinaryEncoding = new byte[] { 0 },
            BinaryByteCount = 1L,
            JsonEncoding = "0",
            JsonByteCount = 1L,
        };

        public static TestCase<int> Int1 => new IntTestCase
        {
            Value = 1,
            BinaryEncoding = new byte[] { 2 },
            BinaryByteCount = 1L,
            JsonEncoding = "1",
            JsonByteCount = 1L,
        };

        public static TestCase<int> IntMinus1 => new IntTestCase
        {
            Name = nameof(IntMinus1),
            Value = -1,
            BinaryEncoding = new byte[] { 1 },
            BinaryByteCount = 1L,
            JsonEncoding = "-1",
            JsonByteCount = 2L,
        };

        public static TestCase<int> Int64 => new IntTestCase
        {
            Name = nameof(Int64),
            Value = 64,
            BinaryEncoding = new byte[] { 0x80, 0x01 },
            BinaryByteCount = 2L,
            JsonEncoding = "64",
            JsonByteCount = 2L,
        };

        public static TestCase<int> IntMinus64 => new IntTestCase
        {
            Name = nameof(IntMinus64),
            Value = -64,
            BinaryEncoding = new byte[] { 0x7F },
            BinaryByteCount = 1L,
            JsonEncoding = "-64",
            JsonByteCount = 3L,
        };

        public static TestCase<int> Int1048576 => new IntTestCase
        {
            Name = nameof(Int1048576),
            Value = 1048576,
            BinaryEncoding = new byte[] { 0x80, 0x80, 0x80, 0x01 },
            BinaryByteCount = 4L,
            JsonEncoding = "1048576",
            JsonByteCount = 7L,
        };

        public static TestCase<int> IntMinus1048576 => new IntTestCase
        {
            Name = nameof(IntMinus1048576),
            Value = -1048576,
            BinaryEncoding = new byte[] { 0xFF, 0xFF, 0x7F },
            BinaryByteCount = 3L,
            JsonEncoding = "-1048576",
            JsonByteCount = 8L,
        };
    }
}
