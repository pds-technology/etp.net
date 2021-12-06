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
    public class AvroFixedImplementationGenerator : FileCodeGenerator<TypeInfoCollectionGenerationContext>
    {
        public AvroFixedImplementationGenerator(string @namespace)
            : base(@namespace, "Extensions.IAvroFixed.cs")
        {
        }

        public override void Generate(TypeInfoCollectionGenerationContext context, CodeWriter writer)
        {
            writer.ApacheHeader("ETP DevKit", "1.2", "2021");
            writer.UsingNamespaces("Energistics.Avro", "Energistics.Avro.Encoding");

            foreach (var group in context.TypeInfoCollection.FixedInfos().GroupBy(f => f.Namespace))
            {
                writer.WithNamespace(group.First().Namespace, () =>
                {
                    foreach (var fixedInfo in group)
                    {
                        var interfaces = new List<string> { FixedInfo.TFixed.BaseClassOrInterface };
                        writer.WithPublicPartialClass(fixedInfo.Name, interfaces, () =>
                        {
                            writer.ExplicitInterfaceReadonlyProperty("long", "ByteCount", FixedInfo.TFixed.BaseClassOrInterface, getExpression: $"ByteCount");
                            writer.ExplicitInterfaceProperty("byte[]", "Bytes", FixedInfo.TFixed.BaseClassOrInterface, getExpression: $"Bytes", setExpression: $"Bytes = value");
                            writer.ExplicitInterfaceReadonlyProperty("string", "AvroTypeName", AvroObjectInfo.TAvroObject.BaseClassOrInterface, getExpression: $"\"{fixedInfo.AvroFullName}\"");
                            writer.DeclareAvroFixedEncode(fixedInfo);
                            writer.DeclareAvroFixedDecode(fixedInfo);
                        });
                    }
                });
            }
        }
    }
}
