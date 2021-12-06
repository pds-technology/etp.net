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
using Energistics.CodeGen.Avro.Code.TypeInfos;

namespace Energistics.CodeGen.Avro.Files
{
    public class DecoderExtensionsGenerator : FileCodeGenerator<GenerationContext>
    {
        public DecoderExtensionsGenerator()
            : base("Energistics.Avro.Encoding", "DecoderExtensions.generated.cs")
        {
        }

        public override void Generate(GenerationContext context, CodeWriter writer)
        {
            writer.ApacheHeader("ETP DevKit", "1.2", "2021");
            writer.UsingNamespaces("System", "System.Collections.Generic");
            writer.WithNamespace(Namespace, () =>
            {
                writer.XmlSummary($"Extension methods for decoders.");
                writer.WithPublicStaticPartialClass("DecoderExtensions", () =>
                {
                    writer.DeclarDecodeAvroObject();

                    var typeInfoCollection = new TypeInfoCollection();
                    typeInfoCollection.AddPrimitives();
                    typeInfoCollection.AddRepresentativeTypes();

                    foreach (var typeInfo in typeInfoCollection.TypeInfosByDescriptor.Values)
                    {
                        if (typeInfo.IsNull)
                            continue;

                        var nullableInfo = new NullableInfo(null, typeInfo, true, NullableInfo.CreateUniqueNamePrefix(typeInfo, true));
                        var arrayInfo = new ArrayInfo(null, typeInfo);
                        var mapInfo = new MapInfo(null, typeInfo);

                        writer.DeclareDecodeNullable(nullableInfo);
                        writer.DeclareDecodeArray(arrayInfo);
                        writer.DeclareDecodeMap(mapInfo);
                    }
                });
            });
        }
    }
}
