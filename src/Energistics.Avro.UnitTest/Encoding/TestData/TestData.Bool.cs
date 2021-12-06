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
        private class BoolTestCase : TestCase<bool>
        {
            public BoolTestCase()
            {
                PrimitiveEncode = (t, encoder) => encoder.EncodeBoolean(t.Value);
                PrimitiveDecode = (t, decoder) => decoder.DecodeBoolean();
            }
        }

        public static TestCase<bool>[] Boolean => new TestCase<bool>[] { BoolTrue, BoolFalse };

        public static TestCase<bool> BoolTrue => new BoolTestCase
        {
            Name = nameof(BoolTrue),
            Value = true,
            BinaryEncoding = new byte[] { 1 },
            BinaryByteCount = 1L,
            JsonEncoding = "true",
            JsonByteCount = 4L,
        };

        public static TestCase<bool> BoolFalse => new BoolTestCase
        {
            Name = nameof(BoolFalse),
            Value = false,
            BinaryEncoding = new byte[] { 0 },
            BinaryByteCount = 1L,
            JsonEncoding = "false",
            JsonByteCount = 5L,
        };
    }
}
