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

namespace Energistics.Avro.Encoding.Converter
{
    [TestClass]
    public class AvroConverterTest
    {
        private void Convert<T>(TestCase<T> testCase)
        {
            var expected = testCase.Converted;
            var actual = testCase.Convert(testCase);
            TestCaseAssert.AreEqual(expected, actual, testCase);
        }

        private void Unconvert<T>(TestCase<T> testCase)
        {
            var expected = testCase.Value;
            var actual = testCase.Unconvert(testCase);
            TestCaseAssert.AreEqual(expected, actual, testCase);
        }

        [TestMethod]
        public void AvroConverterTest_Convert_Float()
        {
            foreach (var testCase in TestData.Float)
                Convert(testCase);
        }

        [TestMethod]
        public void AvroConverterTest_Unconvert_Float()
        {
            foreach (var testCase in TestData.Float)
                Unconvert(testCase);
        }

        [TestMethod]
        public void AvroConverterTest_Convert_Double()
        {
            foreach (var testCase in TestData.Double)
                Convert(testCase);
        }

        [TestMethod]
        public void AvroConverterTest_Unconvert_Double()
        {
            foreach (var testCase in TestData.Double)
                Unconvert(testCase);
        }

        [TestMethod]
        public void AvroConverterTest_Convert_Guid()
        {
            foreach (var testCase in TestData.Guid)
                Convert(testCase);
        }

        [TestMethod]
        public void AvroConverterTest_Unconvert_Guid()
        {
            foreach (var testCase in TestData.Guid)
                Unconvert(testCase);
        }

        [TestMethod]
        public void AvroConverterTest_Convert_DateTime()
        {
            foreach (var testCase in TestData.DateTime)
                Convert(testCase);
        }

        [TestMethod]
        public void AvroConverterTest_Unconvert_DateTime()
        {
            foreach (var testCase in TestData.DateTime)
                Unconvert(testCase);
        }

        [TestMethod]
        public void AvroConverterTest_Convert_DateTimeOffset()
        {
            foreach (var testCase in TestData.DateTimeOffset)
                Convert(testCase);
        }

        [TestMethod]
        public void AvroConverterTest_Unconvert_DateTimeOffset()
        {
            foreach (var testCase in TestData.DateTimeOffset)
                Unconvert(testCase);
        }

        [TestMethod]
        public void AvroConverterTest_Convert_TimeSpan()
        {
            foreach (var testCase in TestData.TimeSpan)
                Convert(testCase);
        }

        [TestMethod]
        public void AvroConverterTest_Unconvert_TimeSpan()
        {
            foreach (var testCase in TestData.TimeSpan)
                Unconvert(testCase);
        }
    }
}