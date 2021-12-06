//----------------------------------------------------------------------- 
// ETP DevKit, 1.2
//
// Copyright 2021 Energistics
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

using Energistics.CodeGen.Code;

namespace Energistics.CodeGen.Json.Files
{
    public class StringEncodingGenerator : FileCodeGenerator<GenerationContext>
    {
        public StringEncodingGenerator()
            : base("Energistics.Json", "StringEncoding.generated.cs")
        {
        }

        public override void Generate(GenerationContext context, CodeWriter writer)
        {
            writer.ApacheHeader("ETP DevKit", "1.2", "2021");
            writer.WithNamespace(Namespace, () =>
            {
                writer.XmlSummary($"Lookups for JSON string encoding.");
                writer.WithPublicStaticPartialClass("StringEncoding", () =>
                {
                    writer.XmlSummary($"JSON encodings to use for the first 256 characters.");
                    writer.PublicStaticReadonlyField("string[]", "CharStrings", initializerBlock: () =>
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            var sb = new System.Text.StringBuilder();
                            for (int j = 0; j < 32; j++)
                            {
                                sb.Append($"@\"{GetEncodedString((char)(i * 32 + j))}\",");
                            }
                            writer.WriteLine($"{sb}");
                        }
                    });
                });
            });
        }

        private static string GetEncodedString(char c)
        {
            if (c == '"')
                return @"\""""";
            else if (c == '\\')
                return @"\\";
            else if (c == '\b')
                return @"\b";
            else if (c == '\f')
                return @"\f";
            else if (c == '\n')
                return @"\n";
            else if (c == '\r')
                return @"\r";
            else if (c == '\t')
                return @"\t";
            else if (c < 0x20 || (c >= 0x7F && c <= 0x9F))
                return $@"\u{((int)c):X4}";
            else
                return $"{c}";
        }
    }
}
