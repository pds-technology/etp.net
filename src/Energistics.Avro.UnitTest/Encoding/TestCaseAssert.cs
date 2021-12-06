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
using System.Collections;

namespace Energistics.Avro.Encoding
{
    public static class TestCaseAssert
    {
        public static void AreEqual(object expected, object actual, TestCase testCase, string key = null)
        {
            if (expected == null || actual == null)
                Assert.AreEqual(expected, actual, $"{testCase.Name}:{key} Null");

            if (expected is string se && actual is string sa)
                AreEqual(se, sa, testCase, key);
            else if (expected is byte[] be && actual is byte[] ba)
                AreEqual(be, ba, testCase, key);
            else if (expected is IAvroFixed afe && actual is IAvroFixed afa)
                AreEqual(afe.Bytes, afa.Bytes, testCase, key);
            else if (expected is IAvroObject iaoe && actual is IAvroObject iaoa)
                AreEqual(iaoe, iaoa, testCase, key);
            else if (expected is IList liste && actual is IList lista)
                AreEqual(liste, lista, testCase, key);
            else if (expected is IDictionary dicte && actual is IDictionary dicta)
                AreEqual(dicte, dicta, testCase, key);
            else
                Assert.AreEqual(expected, actual, $"{testCase.Name}{(string.IsNullOrEmpty(key) ? string.Empty : $":{key}")}");
        }

        public static void AreEqual(IAvroObject expected, IAvroObject actual, TestCase testCase, string key = null)
        {
            Assert.AreEqual(expected.GetType(), actual.GetType(), $"{testCase.Name}:{key} GetType");
            foreach (var property in expected.GetType().GetProperties())
            {
                var expectedValue = property.GetValue(expected);
                var actualValue = property.GetValue(actual);
                AreEqual(expectedValue, actualValue, testCase, $"{key} {property.Name}");
            }
        }

        public static void AreEqual(IDictionary expected, IDictionary actual, TestCase testCase, string key = null)
        {
            Assert.AreEqual(expected.Count, actual.Count, $"{testCase.Name}:{key} Count");
            foreach (var k in expected.Keys)
            {
                if (!actual.Contains(k))
                    Assert.Fail($"{testCase.Name}:{key} actual missing key '{k}'.");
                AreEqual(expected[k], actual[k], testCase, $"{key} Key: '{k}'");
            }
        }

        public static void AreEqual(byte[] expected, byte[] actual, TestCase testCase, string key = null)
        {
            Assert.AreEqual(expected.Length, actual.Length, $"{testCase.Name}:{key} Length");
            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], $"{testCase.Name}:{key} {i}");
        }

        public static void AreEqual(string expected, string actual, TestCase testCase, string key = null)
        {
            Assert.AreEqual(expected.Length, actual.Length, $"{testCase.Name}:{key} Length in Expected: '{expected}'; Actual: '{actual}'");
            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], $"{testCase.Name}:{key} {i} in Expected: '{expected}'; Actual: '{actual}'");
        }

        public static void AreEqual(IList expected, IList actual, TestCase testCase, string key = null)
        {
            Assert.AreEqual(expected.Count, actual.Count, $"{testCase.Name}:{key} Length");
            for (int i = 0; i < expected.Count; i++)
                AreEqual(expected[i], actual[i], testCase, $"{key} Array: {i}");
        }
    }
}
