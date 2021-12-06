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
    public abstract class AvroEncoderExtensionTest
    {
        private void RunEncodeTest<T>(TestCase<T> testCase)
        {
            var (expected, actual) = Encode(testCase, (encoder) => testCase.AvroEncode(testCase, encoder));

            TestCaseAssert.AreEqual(expected, actual, testCase);
        }

        protected abstract (object expected, object actual) Encode(TestCase testCase, Action<IAvroEncoder> action);

        [TestMethod]
        public void AvroEncoderExtensionTest_Encode_Guid()
        {
            foreach (var testCase in TestData.Guid)
                RunEncodeTest(testCase);
        }

        [TestMethod]
        public void AvroEncoderExtensionTest_Encode_DateTime()
        {
            foreach (var testCase in TestData.DateTime)
                RunEncodeTest(testCase);
        }

        [TestMethod]
        public void AvroEncoderExtensionTest_Encode_DateTimeOffset()
        {
            foreach (var testCase in TestData.DateTimeOffset)
                RunEncodeTest(testCase);
        }

        [TestMethod]
        public void AvroEncoderExtensionTest_Encode_TimeSpan()
        {
            foreach (var testCase in TestData.TimeSpan)
                RunEncodeTest(testCase);
        }

        [TestMethod]
        public void AvroEncoderExtensionTest_Encode_Array()
        {
            foreach (var testCase in TestData.Array)
                RunEncodeTest(testCase);
        }

        [TestMethod]
        public void AvroEncoderExtensionTest_Encode_Map()
        {
            foreach (var testCase in TestData.Map)
                RunEncodeTest(testCase);
        }

        [TestMethod]
        public void AvroEncoderExtensionTest_Encode_Enum()
        {
            foreach (var testCase in TestData.Enum)
                RunEncodeTest(testCase);
        }

        [TestMethod]
        public void AvroEncoderExtensionTest_Encode_Fixed()
        {
            foreach (var testCase in TestData.Fixed)
                RunEncodeTest(testCase);
        }

        [TestMethod]
        public void AvroEncoderExtensionTest_Encode_Record()
        {
            foreach (var testCase in TestData.Record)
                RunEncodeTest(testCase);
        }
    }
}
