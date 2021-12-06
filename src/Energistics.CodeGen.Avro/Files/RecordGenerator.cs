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
    public class RecordGenerator : FileCodeGenerator<TypeInfoCollectionGenerationContext>
    {
        public RecordGenerator(string @namespace, string fileName, RecordInfo recordInfo)
            : base(@namespace, fileName)
        {
            RecordInfo = recordInfo;
        }

        public RecordInfo RecordInfo { get; }

        public override void Generate(TypeInfoCollectionGenerationContext context, CodeWriter writer)
        {
            writer.ApacheHeader("ETP DevKit", "1.2", "2021");
            writer.UsingNamespaces("System", "System.Collections.Generic", "Energistics.Avro");

            writer.WithNamespace(Namespace, () =>
            {
                writer.Attribute("AvroNamedType", new List<string> { $"\"{RecordInfo.AvroName}\"", $"\"{RecordInfo.AvroNamespace}\"" });
                writer.WithPublicPartialClass(RecordInfo.Name, Enumerable.Empty<string>(), () =>
                {
                    writer.PublicStaticReadonlyAutoImplementedProperty("string", "CanonicalSchema", initializerExpression: $"\"{RecordInfo.GetCanonicalSchema().Replace("\"", "\\\"")}\"");
                    for (int i = 0; i < RecordInfo.FieldNames.Count; i++)
                    {
                        var fieldName = RecordInfo.FieldNames[i];
                        var fieldAvroName = RecordInfo.AvroFieldNames[i];
                        var fieldTypeInfo = RecordInfo.FieldTypeInfos[i];

                        writer.Attribute("AvroRecordField", new List<string> { $"\"{fieldAvroName}\"" });
                        foreach (var innerTypeInfo in new List<TypeInfo> { fieldTypeInfo }.Concat(fieldTypeInfo.GetAllInnerTypeInfos()))
                        {
                            if (innerTypeInfo is ChoiceInfo choiceInfo)
                            {
                                var avroTypes = string.Join(", ", choiceInfo.ChoiceTypeInfos.Select(cti => $"\"{cti.AvroFullName}\""));
                                var types = string.Join(", ", choiceInfo.ChoiceTypeInfos.Select(cti => cti.IsNull ? "null" : $"typeof({cti.FullName})"));
                                writer.Attribute("AvroChoice", new List<string> { $"new string[] {{ {avroTypes} }}", $"new Type[] {{ {types} }}" });
                            }
                            else if (innerTypeInfo is NullableInfo nullableInfo)
                            {
                                writer.Attribute("AvroNullable", new List<string> { nullableInfo.NullFirst ? "true" : "false", $"\"{nullableInfo.ValueTypeInfo.AvroFullName}\"" });
                            }
                        }
                        writer.PublicAutoImplementedProperty(fieldTypeInfo.DeclaredType, fieldName);
                    }
                });
            });
        }
    }
}
