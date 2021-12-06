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
    public abstract class PrimitiveEncoderTest
    {
        private void RunEncodeTest<T>(TestCase<T> testCase)
        {
            var (expected, actual) = Encode(testCase, (encoder) => testCase.PrimitiveEncode(testCase, encoder));

            TestCaseAssert.AreEqual(expected, actual, testCase);
        }

        protected abstract (object expected, object actual) Encode(TestCase testCase, Action<IPrimitiveEncoder> action);


        [TestMethod]
        public void PrimitiveEncoderTest_Encode_Null()
        {
            RunEncodeTest(TestData.Null);
        }

        [TestMethod]
        public void PrimitiveEncoderTest_Encode_Boolean()
        {
            foreach (var testCase in TestData.Boolean)
                RunEncodeTest(testCase);
        }

        [TestMethod]
        public void PrimitiveEncoderTest_Encode_Int()
        {
            foreach (var testCase in TestData.Int)
                RunEncodeTest(testCase);
        }

        [TestMethod]
        public void PrimitiveEncoderTest_Encode_Long()
        {
            foreach (var testCase in TestData.Long)
                RunEncodeTest(testCase);
        }

        [TestMethod]
        public void PrimitiveEncoderTest_Encode_Float()
        {
            foreach (var testCase in TestData.Float)
                RunEncodeTest(testCase);
        }

        [TestMethod]
        public void PrimitiveEncoderTest_Encode_Double()
        {
            foreach (var testCase in TestData.Double)
                RunEncodeTest(testCase);
        }

        [TestMethod]
        public void PrimitiveEncoderTest_Encode_String()
        {
            foreach (var testCase in TestData.String)
                RunEncodeTest(testCase);
        }

        [TestMethod]
        public void PrimitiveEncoderTest_Encode_Bytes()
        {
            foreach (var testCase in TestData.Bytes)
                RunEncodeTest(testCase);
        }
    }
}
