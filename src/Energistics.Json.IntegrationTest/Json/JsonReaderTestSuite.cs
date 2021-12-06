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
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Energistics.Json
{
    [TestClass]
    public class JsonReaderTestSuite
    {
        private static HashSet<string> AllowedFailures = new HashSet<string>
        {
            "i_string_utf16BE_no_BOM.json",
            "i_string_utf16LE_no_BOM.json"
        };

        private static HashSet<string> TestsToSkip = new HashSet<string>
        {
        };

        private static HashSet<string> TestsToExecute = new HashSet<string>
        {
        };

        public static void RunTest(string filePath)
        {
            var fileName = Path.GetFileName(filePath);
            if (TestsToSkip.Contains(fileName) || (TestsToExecute.Count > 0 && !TestsToExecute.Contains(fileName)))
            {
                Trace.WriteLine($"Skipped {fileName}.");
                return;
            }

            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var reader = new JsonReader(stream))
            {
                Trace.WriteLine(fileName);
                try
                {
                    var token = reader.Read();
                    if (fileName.StartsWith("n_") && !AllowedFailures.Contains(fileName))
                        Assert.Fail($"{fileName}: No exception thrown.");
                    if (token == null && !fileName.StartsWith("n_") && !AllowedFailures.Contains(fileName))
                        Assert.Fail($"{fileName}: Read returned null.");
                }
                catch (InvalidDataException ex)
                {
                    if (!fileName.StartsWith("n_") && !AllowedFailures.Contains(fileName))
                        Assert.Fail($"{fileName}: {ex.Message}");
                }
            }
        }

        [TestMethod]
        public void JsonReaderTestSuite_Parsing()
        {
            var folderPath = Path.Combine(Environment.CurrentDirectory, "JSONTestSuite", "test_parsing");
            foreach (var filePath in Directory.GetFiles(folderPath, "*.json"))
                RunTest(filePath);
        }
    }
}