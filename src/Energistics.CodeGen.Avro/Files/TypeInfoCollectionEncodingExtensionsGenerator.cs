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

namespace Energistics.CodeGen.Avro.Files
{
    public class TypeInfoCollectionEncodingExtensionsGenerator : FileCodeGenerator<TypeInfoCollectionGenerationContext>
    {
        public TypeInfoCollectionEncodingExtensionsGenerator(string @namespace)
            : base(@namespace, "Extensions.Encoding.cs")
        {
        }

        public bool InternalTypeConverters { get; set; } = false;

        public override void Generate(TypeInfoCollectionGenerationContext context, CodeWriter writer)
        {
            writer.ApacheHeader("ETP DevKit", "1.2", "2021");
            writer.UsingNamespaces("System", "System.Collections.Generic", "Energistics.Avro", "Energistics.Avro.Encoding");
            writer.WithNamespace(Namespace, () =>
            {
                writer.XmlSummary($"Extension methods for encoding.");
                writer.WithInternalStaticClass("EncodingExtensions", () =>
                {
                    foreach (var choiceInfo in context.TypeInfoCollection.ChoiceInfos())
                        writer.DeclareChoiceTypeConverter(choiceInfo, @internal: InternalTypeConverters);
                    foreach (var choiceInfo in context.TypeInfoCollection.NullableInfos())
                        writer.DeclareNullableTypeConverter(choiceInfo, @internal: InternalTypeConverters);
                    foreach (var choiceInfo in context.TypeInfoCollection.ChoiceInfos())
                    {
                        writer.DeclareEncodeChoice(choiceInfo);
                        writer.DeclareDecodeChoice(choiceInfo);
                    }
                    foreach (var nullableInfo in context.TypeInfoCollection.NullableInfosWithNestedValue())
                    {
                        writer.DeclareEncodeNullable(nullableInfo);
                        writer.DeclareDecodeNullable(nullableInfo);
                    }
                    foreach (var arrayInfo in context.TypeInfoCollection.ArrayInfosWithNestedValue())
                    {
                        writer.DeclareEncodeArray(arrayInfo);
                        writer.DeclareDecodeArray(arrayInfo);
                    }
                    foreach (var mapInfo in context.TypeInfoCollection.MapInfosWithNestedValue())
                    {
                        writer.DeclareEncodeMap(mapInfo);
                        writer.DeclareDecodeMap(mapInfo);
                    }
                });
            });
        }
    }
}
