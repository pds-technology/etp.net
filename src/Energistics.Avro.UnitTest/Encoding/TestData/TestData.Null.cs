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
        public static TestCase<object> Null => new TestCase<object>
        {
            Name = nameof(Null),
            BinaryEncoding = new byte[]{ },
            BinaryByteCount = 0L,
            JsonEncoding = "null",
            JsonByteCount = 4L,
            PrimitiveEncode = (t, encoder) => encoder.EncodeNull(),
            PrimitiveDecode = (t, decoder) => { decoder.DecodeNull(); return null; }, 
        };
    }
}
