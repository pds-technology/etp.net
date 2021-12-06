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

using Energistics.Avro.Encoding.TestObjects;

namespace Energistics.Avro.Encoding
{
    public static partial class TestData
    {
        private class FixedTestCase : TestCase<TestFixed>
        {
            public FixedTestCase()
            {
                AvroEncode = (t, encoder) => encoder.EncodeAvroObject<TestFixed>(t.Value);
                AvroDecode = (t, decoder) => decoder.DecodeAvroObject<TestFixed>();
            }
        }

        public static TestCase<TestFixed>[] Fixed => new TestCase<TestFixed>[] { TestFixed };

        public static TestCase<TestFixed> TestFixed => new FixedTestCase
        {
            Name = nameof(TestFixed),
            Value = new TestFixed { Bytes = new byte[] { 0, 1, 2, 3 } },
            BinaryEncoding = new byte[] { 0, 1, 2, 3 },
            BinaryByteCount = 4L,
            JsonEncoding = "\"\\u0000\\u0001\\u0002\\u0003\"",
            JsonByteCount = 26L,
        };
    }
}
