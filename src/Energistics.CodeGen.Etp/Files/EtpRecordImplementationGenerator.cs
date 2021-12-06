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
    public class EtpRecordImplementationGenerator : FileCodeGenerator<TypeInfoCollectionGenerationContext>
    {
        public EtpRecordImplementationGenerator(string @namespace)
            : base(@namespace, "Extensions.IEtpRecord.cs")
        {
        }

        private static HashSet<string> StoreTimestampFields { get; } = new HashSet<string> { "changeTime", "channelChangeTime", "channelsTruncatedTime", "currentDateTime", "deletedTime", "earliestRetainedChangeTime", "responseTimestamp", "storeCreated", "storeLastWrite" };

        private static HashSet<string> ExcludedMessages { get; } = new HashSet<string>
        {
            "Energistics.Protocol.Store.PutObject",

            "Energistics.Etp.v12.Protocol.GrowingObject.PutParts",
            "Energistics.Etp.v12.Protocol.DataArray.PutDataSubarrays",
            "Energistics.Etp.v12.Protocol.DataArray.PutDataArrays",
            "Energistics.Etp.v12.Protocol.DataArray.PutUninitializedDataArrays",
            "Energistics.Etp.v12.Protocol.Dataspace.PutDataspaces",
            "Energistics.Etp.v12.Protocol.GrowingObject.PutGrowingDataObjectsHeader",
            "Energistics.Etp.v12.Protocol.Store.PutDataObjects",
        };

        public override void Generate(TypeInfoCollectionGenerationContext context, CodeWriter writer)
        {
            writer.ApacheHeader("ETP DevKit", "1.2", "2021");
            writer.UsingNamespaces("System", "System.Linq", "Energistics.Avro.Encoding.Converter", "Energistics.Etp.Common");

            var timestampFields = GetTimestampFields(context.TypeInfoCollection);

            foreach (var group in context.TypeInfoCollection.RecordInfos().GroupBy(r => r.Namespace))
            {
                writer.WithNamespace(group.First().Namespace, () =>
                {
                    foreach (var recordInfo in group)
                    {
                        var interfaces = new List<string> { "IEtpRecord" };
                        writer.WithPublicPartialClass(recordInfo.Name, interfaces, () =>
                        {
                            var expression = timestampFields.ContainsKey(recordInfo.AvroFullName)
                                ? GenerateGetLatestChangeTimestampExpression(recordInfo, timestampFields[recordInfo.AvroFullName])
                                : "0L";

                            writer.ExplicitInterfaceMethod("System.DateTime", "GetLatestChangeTimestamp", "IEtpRecord", Enumerable.Empty<MethodParameter>(), expression);
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
            foreach (var enumInfo in typeInfoCollection.EnumInfos())
                hasTimestamp[enumInfo.AvroFullName] = false;
            foreach (var fixedInfo in typeInfoCollection.FixedInfos())
                hasTimestamp[fixedInfo.AvroFullName] = false;
            foreach (var primitiveInfo in PrimitiveInfo.PrimitiveInfos)
                hasTimestamp[primitiveInfo.AvroFullName] = false;

            while (queue.Count > 0)
            {
                var recordInfo = queue.Dequeue();
                if (hasTimestamp.ContainsKey(recordInfo.AvroFullName))
                    continue;
                var namedDependencies = recordInfo.GetNamedTypeDependencies();
                if (namedDependencies.Any(d => !hasTimestamp.ContainsKey(d)))
                {
                    queue.Enqueue(recordInfo);
                    continue;
                }

                var recordTimestampFields = new List<int>();
                timestampFields[recordInfo.AvroFullName] = recordTimestampFields;
                if (recordInfo.IsMessageBody() && ExcludedMessages.Contains(recordInfo.AvroFullName))
                {
                    hasTimestamp[recordInfo.AvroFullName] = false;
                    continue;
                }

                for (int i = 0; i < recordInfo.AvroFieldNames.Count; i++)
                {
                    if (StoreTimestampFields.Contains(recordInfo.AvroFieldNames[i]) || HasNestedTimestamp(recordInfo.FieldTypeInfos[i], hasTimestamp))
                        recordTimestampFields.Add(i);
                }

                hasTimestamp[recordInfo.AvroFullName] = recordTimestampFields.Count > 0;
            }

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
