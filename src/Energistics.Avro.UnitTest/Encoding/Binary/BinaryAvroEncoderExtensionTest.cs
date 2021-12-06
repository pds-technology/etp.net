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
using System.IO;

namespace Energistics.Avro.Encoding.Binary
{
    [TestClass]
    public class BinaryAvroEncoderExtensionTest : AvroEncoderExtensionTest
    {
        protected override (object expected, object actual) Encode(TestCase testCase, Action<IAvroEncoder> action)
        {
            using (var stream = new MemoryStream())
            {
                var encoder = new BinaryAvroEncoder(stream);
                action(encoder);
                return (testCase.BinaryEncoding, stream.ToArray());
            }
        }
    }
}
