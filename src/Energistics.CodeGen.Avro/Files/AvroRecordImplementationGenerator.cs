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
    public class AvroRecordImplementationGenerator : FileCodeGenerator<TypeInfoCollectionGenerationContext>
    {
        public AvroRecordImplementationGenerator(string @namespace)
            : base(@namespace, "Extensions.IAvroRecord.cs")
        {
        }

        public override void Generate(TypeInfoCollectionGenerationContext context, CodeWriter writer)
        {
            writer.ApacheHeader("ETP DevKit", "1.2", "2021");
            writer.UsingNamespaces("System", "System.Collections.Generic", "Energistics.Avro", "Energistics.Avro.Encoding");

            foreach (var group in context.TypeInfoCollection.RecordInfos().GroupBy(r => r.Namespace))
            {
                writer.WithNamespace(group.First().Namespace, () =>
                {
                    foreach (var recordInfo in group)
                    {
                        var interfaces = new List<string> { RecordInfo.TRecord.BaseClassOrInterface };
                        writer.WithPublicPartialClass(recordInfo.Name, interfaces, () =>
                        {
                            // Choice and Nullable Converters
                            var visitedDescriptors = new HashSet<string>();
                            foreach (var fieldTypeInfo in recordInfo.FieldTypeInfos)
                            {
                                var innerTypeInfo = fieldTypeInfo;
                                while (innerTypeInfo != null)
                                {
                                    if (visitedDescriptors.Add(innerTypeInfo.GetDescriptor()))
                                    {
                                        if (innerTypeInfo is ChoiceInfo choiceInfo)
                                            writer.DeclareChoiceTypeConverter(choiceInfo);
                                        else if (innerTypeInfo is NullableInfo nullableInfo)
                                            writer.DeclareNullableTypeConverter(nullableInfo);
                                    }
                                    innerTypeInfo = innerTypeInfo.GetInnerTypeInfo();
                                }
                            }

                            // IEtpRecord
                            writer.ExplicitInterfaceReadonlyProperty("string", "AvroTypeName", AvroObjectInfo.TAvroObject.BaseClassOrInterface, getExpression: $"\"{recordInfo.AvroFullName}\"");
                            writer.DeclareAvroRecordEncode(recordInfo);
                            writer.DeclareAvroRecordDecode(recordInfo);
                        });
                    }
                });
            }
        }
    }
}
