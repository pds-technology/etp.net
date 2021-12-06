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

namespace Energistics.Avro.Encoding.Json
{
    [TestClass]
    public class JsonAvroDecoderExtensionTest : AvroDecoderExtensionTest
    {
        protected override (object expected, object actual) Decode(TestCase testCase, Func<IAvroDecoder, object> action)
        {
            using (var stream = new MemoryStream())
            {
                using (var writer = new StreamWriter(stream, System.Text.Encoding.UTF8, 1024, true))
                    writer.Write(testCase.JsonEncoding);

                stream.Position = 0;

                var decoder = new JsonAvroDecoder(stream);
                return (testCase.Value, action(decoder));
            }
        }
    }
}
