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
    public abstract class PrimitiveDecoderTest
    {
        private void RunDecodeTest<T>(TestCase<T> testCase)
        {
            var (expected, actual) = Decode(testCase, (decoder) => testCase.PrimitiveDecode(testCase, decoder));

            TestCaseAssert.AreEqual(expected, actual, testCase);
        }

        protected abstract (object expected, object actual) Decode(TestCase testCase, Func<IPrimitiveDecoder, object> action);

        [TestMethod]
        public void PrimitiveDecoderTest_Decode_Null()
        {
            RunDecodeTest(TestData.Null);
        }

        [TestMethod]
        public void PrimitiveDecoderTest_Decode_Boolean()
        {
            foreach (var testCase in TestData.Boolean)
                RunDecodeTest(testCase);
        }

        [TestMethod]
        public void PrimitiveDecoderTest_Decode_Int()
        {
            foreach (var testCase in TestData.Int)
                RunDecodeTest(testCase);
        }

        [TestMethod]
        public void PrimitiveDecoderTest_Decode_Long()
        {
            foreach (var testCase in TestData.Long)
                RunDecodeTest(testCase);
        }

        [TestMethod]
        public void PrimitiveDecoderTest_Decode_Float()
        {
            foreach (var testCase in TestData.Float)
                RunDecodeTest(testCase);
        }

        [TestMethod]
        public void PrimitiveDecoderTest_Decode_Double()
        {
            foreach (var testCase in TestData.Double)
                RunDecodeTest(testCase);
        }

        [TestMethod]
        public void PrimitiveDecoderTest_Decode_String()
        {
            foreach (var testCase in TestData.String)
                RunDecodeTest(testCase);
        }

        [TestMethod]
        public void PrimitiveDecoderTest_Decode_Bytes()
        {
            foreach (var testCase in TestData.Bytes)
                RunDecodeTest(testCase);
        }
    }
}
