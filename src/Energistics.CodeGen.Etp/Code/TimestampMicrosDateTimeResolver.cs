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

using Energistics.Avro.Schemas;
using Energistics.Avro.Schemas.Navigation;
using Energistics.CodeGen.Avro.Code;
using Energistics.CodeGen.Avro.Code.TypeInfos;
using Energistics.CodeGen.Avro.Code.TypeInfos.LogicalTypeInfos;
using System.Collections.Generic;
using System.Linq;

namespace Energistics.CodeGen.Etp.Code
{
    public class TimestampMicrosDateTimeResolver : TypeResolverBase
    {
        private static HashSet<string> TimestampFields { get; } = new HashSet<string> { "changeTime", "channelChangeTime", "channelsTruncatedTime", "currentDateTime", "deletedTime", "deleteTimeFilter", "earliestRetainedChangeTime", "lastChanged", "responseTimestamp", "sinceChangeTime", "startTime", "storeCreated", "storeLastWrite", "storeLastWriteFilter" };

        public override bool CanResolveRecordFields(Type record, string recordName, TypeInfo recordResult, List<string> fieldNames, List<string> fieldValueDescriptors, List<TypeInfo> fieldValueResults, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
            => fieldNames.Any(TimestampFields.Contains);

        public override void ResolveRecordFields(Type record, string recordName, TypeInfo recordResult, List<string> fieldNames, List<string> fieldValueDescriptors, List<TypeInfo> fieldValueResults, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
        {
            for (int i = 0; i < fieldNames.Count; i++)
            {
                var fieldName = fieldNames[i];
                var fieldValueDescriptor = fieldValueDescriptors[i];
                var fieldValueResult = fieldValueResults[i];

                if (TimestampFields.Contains(fieldName))
                {
                    if (fieldValueResult is PrimitiveInfo p && p.Name == PrimitiveInfo.Long.Name)
                    {
                        TypeInfo timestampInfo = TimestampMicrosInfo.TimestampMicrosDateTimeAsLong(fieldValueResult);
                        var timestampDescriptor = timestampInfo.GetDescriptor();
                        if (createdTypeInfos.ContainsKey(timestampDescriptor))
                            timestampInfo = createdTypeInfos[timestampDescriptor];
                        else
                            createdTypeInfos[timestampDescriptor] = timestampInfo;

                        fieldValueResult = timestampInfo;
                        fieldValueDescriptor = timestampDescriptor;
                    }
                    else if (fieldValueResult is NullableInfo n && n.ValueTypeInfo is PrimitiveInfo np && np.Name == PrimitiveInfo.Long.Name)
                    {
                        TypeInfo timestampInfo = TimestampMicrosInfo.TimestampMicrosDateTimeAsLong(n.ValueTypeInfo);
                        var timestampDescriptor = timestampInfo.GetDescriptor();
                        if (createdTypeInfos.ContainsKey(timestampDescriptor))
                            timestampInfo = createdTypeInfos[timestampDescriptor];
                        else
                            createdTypeInfos[timestampDescriptor] = timestampInfo;

                        var nullableDescriptor = Energistics.Avro.Schemas.Types.Nullable.GetDescriptor(n.NullFirst, timestampDescriptor);
                        if (!createdTypeInfos.TryGetValue(nullableDescriptor, out var nullableInfo))
                        {
                            var uniqueName = uniqueNameCounters.GetUniqueName(NullableInfo.CreateUniqueNamePrefix(timestampInfo, n.NullFirst));
                            nullableInfo = new NullableInfo(null, timestampInfo, n.NullFirst, uniqueName);
                            createdTypeInfos[nullableDescriptor] = nullableInfo;
                        }

                        fieldValueResult = nullableInfo;
                        fieldValueDescriptor = nullableDescriptor;
                    }
                    else if (fieldValueResult is MapInfo m && m.ElementTypeInfo is PrimitiveInfo mp && mp.Name == PrimitiveInfo.Long.Name)
                    {
                        TypeInfo timestampInfo = TimestampMicrosInfo.TimestampMicrosDateTimeAsLong(m.ElementTypeInfo);
                        var timestampDescriptor = timestampInfo.GetDescriptor();
                        if (createdTypeInfos.ContainsKey(timestampDescriptor))
                            timestampInfo = createdTypeInfos[timestampDescriptor];
                        else
                            createdTypeInfos[timestampDescriptor] = timestampInfo;

                        var mapDescriptor = Energistics.Avro.Schemas.Types.Map.GetDescriptor(timestampDescriptor);
                        if (!createdTypeInfos.TryGetValue(mapDescriptor, out var mapInfo))
                        {
                            mapInfo = new MapInfo(null, timestampInfo);
                            createdTypeInfos[mapDescriptor] = mapInfo;
                        }

                        fieldValueResult = mapInfo;
                        fieldValueDescriptor = mapDescriptor;
                    }
                    else
                    {
                        System.Console.WriteLine($"MISSING TIMESTAMP TYPE ------------------- {fieldValueDescriptor}");
                    }


                    fieldNames[i] = fieldName;
                    fieldValueDescriptors[i] = fieldValueDescriptor;
                    fieldValueResults[i] = fieldValueResult;
                }
            }
        }

    }
}
