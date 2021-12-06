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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Energistics.Avro.Encoding
{
    [TestClass]
    public abstract class AvroDecoderExtensionTest
    {
        private void RunDecodeTest<T>(TestCase<T> testCase)
        {
            var (expected, actual) = Decode(testCase, (decoder) => testCase.AvroDecode(testCase, decoder));

            TestCaseAssert.AreEqual(expected, actual, testCase);
        }

        protected abstract (object expected, object actual) Decode(TestCase testCase, Func<IAvroDecoder, object> action);

        [TestMethod]
        public void AvroDecoderExtensionTest_Decode_Guid()
        {
            foreach (var testCase in TestData.Guid)
                RunDecodeTest(testCase);
        }

        [TestMethod]
        public void AvroDecoderExtensionTest_Decode_DateTime()
        {
            foreach (var testCase in TestData.DateTime)
                RunDecodeTest(testCase);
        }

        [TestMethod]
        public void AvroDecoderExtensionTest_Decode_DateTimeOffset()
        {
            foreach (var testCase in TestData.DateTimeOffset)
                RunDecodeTest(testCase);
        }

        [TestMethod]
        public void AvroDecoderExtensionTest_Decode_TimeSpan()
        {
            foreach (var testCase in TestData.TimeSpan)
                RunDecodeTest(testCase);
        }

        [TestMethod]
        public void AvroDecoderExtensionTest_Decode_Array()
        {
            foreach (var testCase in TestData.Array)
                RunDecodeTest(testCase);
        }

        [TestMethod]
        public void AvroDecoderExtensionTest_Decode_Map()
        {
            foreach (var testCase in TestData.Map)
                RunDecodeTest(testCase);
        }

        [TestMethod]
        public void AvroDecoderExtensionTest_Decode_Enum()
        {
            foreach (var testCase in TestData.Enum)
                RunDecodeTest(testCase);
        }

        [TestMethod]
        public void AvroDecoderExtensionTest_Decode_Fixed()
        {
            foreach (var testCase in TestData.Fixed)
                RunDecodeTest(testCase);
        }

        [TestMethod]
        public void AvroDecoderExtensionTest_Decode_Record()
        {
            foreach (var testCase in TestData.Record)
                RunDecodeTest(testCase);
        }
    }
}
