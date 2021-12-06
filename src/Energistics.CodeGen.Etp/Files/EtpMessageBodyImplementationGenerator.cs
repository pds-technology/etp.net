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
using Energistics.CodeGen.Etp.Code;
using System.Collections.Generic;
using System.Linq;
using Energistics.CodeGen.Avro.Code.TypeInfos;
using Energistics.CodeGen.Avro.Code.TypeInfos.LogicalTypeInfos;

namespace Energistics.CodeGen.Etp.Files
{
    public class EtpMessageBodyImplementationGenerator : FileCodeGenerator<TypeInfoCollectionGenerationContext>
    {
        public EtpMessageBodyImplementationGenerator(string @namespace)
            : base(@namespace, "Extensions.IEtpMessageBody.cs")
        {
        }

        private static HashSet<string> IgnoredMultipartMessages { get; } = new HashSet<string>
        {
            "Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameResponseHeader",
        };

        private static HashSet<string> IgnoredSecondCollections { get; } = new HashSet<string>
        {
            "channelIds",
        };

        private static HashSet<string> CustomImplementations { get; } = new HashSet<string>
        {
            "Energistics.Etp.v12.Protocol.ChannelDataLoad.ReplaceRange",
            "Energistics.Etp.v12.Protocol.ChannelSubscribe.RangeReplaced",
            "Energistics.Etp.v12.Protocol.ChannelSubscribe.GetRangesResponse",
        };

        public override void Generate(TypeInfoCollectionGenerationContext context, CodeWriter writer)
        {
            writer.ApacheHeader("ETP DevKit", "1.2", "2021");
            writer.UsingNamespaces("System", "System.Collections.Generic", "Energistics.Avro.Encoding", "Energistics.Etp.Common");

            foreach (var group in context.TypeInfoCollection.RecordInfoMessageBodies().GroupBy(r => r.ProtocolNumber()))
            {
                writer.WithNamespace(group.First().Namespace, () =>
                {
                    foreach (var recordInfo in group)
                    {
                        var splitParameters = new List<MethodParameter>
                        {
                            new MethodParameter { Type = PrimitiveInfo.Long.FullName, Name = "targetSize" },
                            new MethodParameter { Type = "IAvroByteCounter", Name = "byteCounter" },
                        };
                        var interfaces = new List<string> { "IEtpMessageBody", $"IEtpMessageBody<{recordInfo.FullName}>" };
                        writer.WithPublicPartialClass(recordInfo.Name, interfaces, () =>
                        {
                            if (recordInfo.IsMultiPart() && !IgnoredMultipartMessages.Contains(recordInfo.AvroFullName) && recordInfo.FieldTypeInfos.Any(fti => fti is CollectionInfo))
                            {
                                var recordEncodeMethod = MethodInfo.Encode(recordInfo);
                                var recordTypeConverters = recordInfo.GetTypeConverters();

                                writer.ExplicitInterfaceMethod($"bool", "CanSplit", "IEtpMessageBody", Enumerable.Empty<MethodParameter>(), $"true");
                                if (CustomImplementations.Contains(recordInfo.AvroFullName))
                                {
                                    writer.ExplicitInterfaceMethod($"IEnumerable<{recordInfo.FullName}>", "Split", $"IEtpMessageBody<{recordInfo.FullName}>", splitParameters, "Split(targetSize, byteCounter)");
                                    return;
                                }

                                writer.WithExplicitInterfaceMethod($"IEnumerable<{recordInfo.FullName}>", "Split", $"IEtpMessageBody<{recordInfo.FullName}>", splitParameters, () =>
                                {
                                    var collectionCount = recordInfo.FieldTypeInfos.Count(rti => rti is CollectionInfo);
                                    var collectionFields = new List<int>();
                                    for (int i = 0; i < recordInfo.FieldNames.Count; i++)
                                    {
                                        if (recordInfo.FieldTypeInfos[i] is CollectionInfo && (collectionCount == 1 || !IgnoredSecondCollections.Contains(recordInfo.AvroFieldNames[i])))
                                            collectionFields.Add(i);
                                    }
                                    var itemCounts = collectionFields.Select(i => writer.Var("itemCount", "0")).ToList();
                                    var enumerators = collectionFields.Select(i => writer.Var("enumerator", $"{recordInfo.FieldNames[i]}.GetEnumerator()")).ToList();
                                    writer.MultiLineWhile(string.Join(" && ", itemCounts.Select((ic, i) => $"{ic} < {recordInfo.FieldNames[collectionFields[i]]}.Count")), () =>
                                    {
                                        var copy = writer.Var("copy", $"new {recordInfo.FullName}", () =>
                                        {
                                            for (int i = 0; i < recordInfo.FieldNames.Count; i++)
                                            {
                                                if (collectionFields.Contains(i))
                                                {
                                                    writer.PropertyInitializer(recordInfo.FieldNames[i], recordInfo.FieldTypeInfos[i].VariableInitializer);
                                                }
                                                else
                                                {
                                                    writer.PropertyInitializer(recordInfo.FieldNames[i], recordInfo.FieldNames[i]);
                                                }
                                            }
                                        });
                                        var added = writer.Var("added", "false");
                                        writer.WriteLine($"byteCounter.Reset();");

                                        for (int i = 0; i < collectionFields.Count; i++)
                                        {
                                            var item = collectionFields[i];
                                            var fieldName = recordInfo.FieldNames[item];
                                            var fieldTypeInfo = recordInfo.FieldTypeInfos[item] as CollectionInfo;
                                            var keyMethod = fieldTypeInfo.ElementsHaveNames ? MethodInfo.Encode(fieldTypeInfo.ElementNameTypeInfo) : null;
                                            var fieldEncodeMethod = MethodInfo.Encode(fieldTypeInfo);
                                            var fieldValueEncodeMethod = MethodInfo.Encode(fieldTypeInfo.ElementTypeInfo);
                                            var fieldValueTypeConverters = fieldTypeInfo.ElementTypeInfo.GetTypeConverters();

                                            writer.MultiLineWhile($"byteCounter.ByteCount < targetSize && {itemCounts[i]}++ < {recordInfo.FieldNames[collectionFields[i]]}.Count", () =>
                                            {
                                                writer.WriteLine($"{enumerators[i]}.MoveNext();");
                                                var v = writer.Var("v", $"{enumerators[i]}.Current");
                                                writer.MultiLineIf($"!{added}", () =>
                                                {
                                                    writer.WriteLine($"{added} = true;");
                                                    if (fieldTypeInfo.ElementsHaveNames)
                                                    {
                                                        writer.WriteLine($"{copy}.{fieldName}[{fieldTypeInfo.ElementVariableName(v)}] = {fieldTypeInfo.ElementVariableValue(v)};");
                                                    }
                                                    else
                                                    {
                                                        writer.WriteLine($"{copy}.{fieldName}.Add({v});");
                                                    }
                                                    var recordEncodeParams = new List<string> { copy };
                                                    recordEncodeParams.AddRange(recordTypeConverters);
                                                    writer.WriteLine($"byteCounter.{recordEncodeMethod.FullName()}({string.Join(", ", recordEncodeParams)});");
                                                    writer.Continue();
                                                });
                                                writer.WriteLine($"byteCounter.{fieldEncodeMethod.Name($"{fieldTypeInfo.Element}Separator")}();");
                                                if (fieldTypeInfo.ElementsHaveNames)
                                                    writer.WriteLine($"byteCounter.{keyMethod.Name()}({fieldTypeInfo.ElementVariableName(v)});");

                                                var valueEncodeParams = new List<string> { fieldTypeInfo.ElementVariableValue(v) };
                                                valueEncodeParams.AddRange(fieldValueTypeConverters);
                                                writer.WriteLine($"byteCounter.{fieldValueEncodeMethod.FullName()}({string.Join(", ", valueEncodeParams)});");
                                                writer.If($"byteCounter.ByteCount <= targetSize", () =>
                                                {
                                                    if (fieldTypeInfo.ElementsHaveNames)
                                                    {
                                                        writer.WriteLine($"{copy}.{fieldName}[{fieldTypeInfo.ElementVariableName(v)}] = {fieldTypeInfo.ElementVariableValue(v)};");
                                                    }
                                                    else
                                                    {
                                                        writer.WriteLine($"{copy}.{fieldName}.Add({v});");
                                                    }
                                                });
                                            });
                                        }
                                        writer.YieldReturn(copy);
                                    });
                                });
                            }
                            else
                            {
                                writer.ExplicitInterfaceMethod($"bool", "CanSplit", "IEtpMessageBody", Enumerable.Empty<MethodParameter>(), "false");
                                writer.WithExplicitInterfaceMethod($"IEnumerable<{recordInfo.FullName}>", "Split", $"IEtpMessageBody<{recordInfo.FullName}>", splitParameters, () =>
                                {
                                    writer.YieldReturn("this");
                                });
                            }
                        });
                    }
                });
            }
        }

        private static Dictionary<string, List<int>> GetTimestampFields(TypeInfoCollection typeInfoCollection)
        {
            var queue = new Queue<RecordInfo>(typeInfoCollection.RecordInfos());
            var hasTimestamp = new Dictionary<string, bool>();
            var timestampFields = new Dictionary<string, List<int>>();
            //foreach (var enumInfo in typeInfoCollection.EnumInfos())
            //    hasTimestamp[enumInfo.AvroFullName] = false;
            //foreach (var fixedInfo in typeInfoCollection.FixedInfos())
            //    hasTimestamp[fixedInfo.AvroFullName] = false;
            //foreach (var primitiveInfo in PrimitiveInfo.PrimitiveInfos)
            //    hasTimestamp[primitiveInfo.AvroFullName] = false;

            //while (queue.Count > 0)
            //{
            //    var recordInfo = queue.Dequeue();
            //    if (hasTimestamp.ContainsKey(recordInfo.AvroFullName))
            //        continue;
            //    var namedDependencies = recordInfo.GetNamedTypeDependencies();
            //    if (namedDependencies.Any(d => !hasTimestamp.ContainsKey(d)))
            //    {
            //        queue.Enqueue(recordInfo);
            //        continue;
            //    }

            //    var recordTimestampFields = new List<int>();
            //    timestampFields[recordInfo.AvroFullName] = recordTimestampFields;
            //    if (recordInfo.IsMessageBody() && ExcludedMessages.Contains(recordInfo.AvroFullName))
            //    {
            //        hasTimestamp[recordInfo.AvroFullName] = false;
            //        continue;
            //    }

            //    for (int i = 0; i < recordInfo.AvroFieldNames.Count; i++)
            //    {
            //        if (StoreTimestampFields.Contains(recordInfo.AvroFieldNames[i]) || HasNestedTimestamp(recordInfo.FieldTypeInfos[i], hasTimestamp))
            //            recordTimestampFields.Add(i);
            //    }

            //    hasTimestamp[recordInfo.AvroFullName] = recordTimestampFields.Count > 0;
            //}

            return timestampFields;
        }

        private static bool HasNestedTimestamp(TypeInfo typeInfo, Dictionary<string, bool> hasTimestamp)
        {
            while (typeInfo != null)
            {
                var innerTypeInfo = typeInfo.GetInnerTypeInfo();
                if (innerTypeInfo == null)
                {
                    if (hasTimestamp.TryGetValue(typeInfo.GetDescriptor(), out var b))
                        return b;

                    return false;
                }
                typeInfo = innerTypeInfo;
            }

            return false;
        }

        private static string GenerateGetLatestChangeTimestampExpression(RecordInfo recordInfo, List<int> timestampFields)
        {
            if (timestampFields.Count == 0)
                return "AvroConverter.UtcMinDateTime";
            else if (timestampFields.Count == 1)
                return GenerateGetLatestChangeTimestampExpression(recordInfo.FieldNames[timestampFields[0]], recordInfo.FieldTypeInfos[timestampFields[0]]);
            else
                return $"CommonExtensions.Max({string.Join(", ", timestampFields.Select(i => GenerateGetLatestChangeTimestampExpression(recordInfo.FieldNames[i], recordInfo.FieldTypeInfos[i])))})";
        }

        private static string GenerateGetLatestChangeTimestampExpression(string fieldName, TypeInfo fieldTypeInfo)
        {
            var min = "AvroConverter.UtcMinDateTime";

            if (fieldTypeInfo is TimestampMicrosInfo)
                return $"{fieldName}";
            else if (fieldTypeInfo is NullableInfo n && n.ValueTypeInfo is TimestampMicrosInfo)
                return $"{fieldName} ?? {min}";
            else if (fieldTypeInfo is RecordInfo)
                return $"((IEtpRecord){fieldName}).GetLatestChangeTimestamp()";
            else if (fieldTypeInfo is ArrayInfo a)
            {
                if (a.ElementTypeInfo is ArrayInfo aa)
                {
                    if (aa.ElementTypeInfo is TimestampMicrosInfo)
                        return $"{fieldName}.Count == 0 ? {min} : {fieldName}.SelectMany(a => a).Max()";
                    else if (aa.ElementTypeInfo is RecordInfo)
                        return $"{fieldName}.Count == 0 ? {min} : {fieldName}.SelectMany(a => a).Select(r => ((IEtpRecord)r).GetLatestChangeTimestamp()).Max()";
                    else
                        throw new System.InvalidOperationException();
                }
                else if (a.ElementTypeInfo is MapInfo am)
                {
                    if (am.ElementTypeInfo is TimestampMicrosInfo)
                        return $"{fieldName}.Count == 0 ? {min} : {fieldName}.SelectMany(m => m.Values).Max()";
                    else if (am.ElementTypeInfo is RecordInfo)
                        return $"{fieldName}.Count == 0 ? {min} : {fieldName}.SelectMany(m => m.Values).Select(r => ((IEtpRecord)r).GetLatestChangeTimestamp()).Max()";
                    else
                        throw new System.InvalidOperationException();
                }
                else if (a.ElementTypeInfo is TimestampMicrosInfo)
                    return $"{fieldName}.Count == 0 ? {min} : {fieldName}.Max()";
                else if (a.ElementTypeInfo is RecordInfo)
                    return $"{fieldName}.Count == 0 ? {min} : {fieldName}.Select(r => ((IEtpRecord)r).GetLatestChangeTimestamp()).Max()";
                else
                    throw new System.InvalidOperationException();
            }
            else if (fieldTypeInfo is MapInfo m)
            {
                if (m.ElementTypeInfo is ArrayInfo ma)
                {
                    if (ma.ElementTypeInfo is TimestampMicrosInfo)
                        return $"{fieldName}.Count == 0 ? {min} : {fieldName}.Values.SelectMany(a => a).Max()";
                    else if (ma.ElementTypeInfo is RecordInfo)
                        return $"{fieldName}.Count == 0 ? {min} : {fieldName}.Values.SelectMany(a => a).Select(r => ((IEtpRecord)r).GetLatestChangeTimestamp()).Max()";
                    else
                        throw new System.InvalidOperationException();
                }
                else if (m.ElementTypeInfo is MapInfo mm)
                {
                    if (mm.ElementTypeInfo is TimestampMicrosInfo)
                        return $"{fieldName}.Count == 0 ? {min} : {fieldName}.Values.SelectMany(m => m.Values).Max()";
                    else if (mm.ElementTypeInfo is RecordInfo)
                        return $"{fieldName}.Count == 0 ? {min} : {fieldName}.Values.SelectMany(m => m.Values).Select(r => ((IEtpRecord)r).GetLatestChangeTimestamp()).Max()";
                    else
                        throw new System.InvalidOperationException();
                }
                else if (m.ElementTypeInfo is TimestampMicrosInfo)
                    return $"{fieldName}.Count == 0 ? {min} : {fieldName}.Values.Max()";
                else if (m.ElementTypeInfo is RecordInfo)
                    return $"{fieldName}.Count == 0 ? {min} : {fieldName}.Values.Select(r => ((IEtpRecord)r).GetLatestChangeTimestamp()).Max()";
                else
                    throw new System.InvalidOperationException();
            }
            else
                throw new System.InvalidOperationException();
        }
    }
}
