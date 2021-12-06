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
        private class EnumTestCase : TestCase<TestEnum>
        {
            public EnumTestCase()
            {
                AvroEncode = (t, encoder) => encoder.EncodeEnum(t.Value);
                AvroDecode = (t, decoder) => decoder.DecodeEnum<TestEnum>();
            }
        }

        public static TestCase<TestEnum>[] Enum => new TestCase<TestEnum>[] { TestEnumValue2, TestEnumValue3 };

        public static TestCase<TestEnum> TestEnumValue2 => new EnumTestCase
        {
            Name = nameof(TestEnumValue2),
            Value = TestEnum.value2,
            BinaryEncoding = new byte[] { 2 },
            BinaryByteCount = 1L,
            JsonEncoding = "\"value2\"",
            JsonByteCount = 8L,
        };

        public static TestCase<TestEnum> TestEnumValue3 => new EnumTestCase
        {
            Name = nameof(TestEnumValue3),
            Value = TestEnum.value3,
            BinaryEncoding = new byte[] { 4 },
            BinaryByteCount = 1L,
            JsonEncoding = "\"value3\"",
            JsonByteCount = 8L,
        };
    }
}
