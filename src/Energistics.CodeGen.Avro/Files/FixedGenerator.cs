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
using Energistics.CodeGen.Avro.Code;
using System.Collections.Generic;
using Energistics.CodeGen.Avro.Code.TypeInfos;
using System.Linq;

namespace Energistics.CodeGen.Avro.Files
{
    public class FixedGenerator : FileCodeGenerator<TypeInfoCollectionGenerationContext>
    {
        public FixedGenerator(string @namespace, string fileName, FixedInfo fixedInfo)
            : base(@namespace, fileName)
        {
            FixedInfo = fixedInfo;
        }

        public FixedInfo FixedInfo { get; }

        public override void Generate(TypeInfoCollectionGenerationContext context, CodeWriter writer)
        {
            writer.ApacheHeader("ETP DevKit", "1.2", "2021");
            writer.UsingNamespaces("Energistics.Avro");

            writer.WithNamespace(Namespace, () =>
            {
                writer.Attribute("AvroNamedType", new List<string> { $"\"{FixedInfo.AvroName}\"", $"\"{FixedInfo.AvroNamespace}\"" });
                writer.WithPublicPartialClass(FixedInfo.Name, Enumerable.Empty<string>(), () =>
                {
                    writer.PublicStaticReadonlyAutoImplementedProperty("string", "CanonicalSchema", initializerExpression: $"\"{FixedInfo.GetCanonicalSchema().Replace("\"", "\\\"")}\"");
                    writer.PublicStaticReadonlyAutoImplementedProperty("long", "ByteCount", initializerExpression: $"{FixedInfo.Size}L");
                    writer.PublicAutoImplementedProperty("byte[]", "Bytes");
                });
            });
        }
    }
}
