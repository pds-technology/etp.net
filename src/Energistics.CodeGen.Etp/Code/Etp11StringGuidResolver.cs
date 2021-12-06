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
    public class Etp11StringGuidResolver : TypeResolverBase
    {
        private static HashSet<string> UuidFields = new HashSet<string> { "uuid", "requestUuid", "sessionId" };

        public override bool CanResolveRecordFields(Type record, string recordName, TypeInfo recordResult, List<string> fieldNames, List<string> fieldValueDescriptors, List<TypeInfo> fieldValueResults, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
            => fieldNames.Any(UuidFields.Contains);

        public override void ResolveRecordFields(Type record, string recordName, TypeInfo recordResult, List<string> fieldNames, List<string> fieldValueDescriptors, List<TypeInfo> fieldValueResults, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
        {
            for (int i = 0; i < fieldNames.Count; i++)
            {
                var fieldName = fieldNames[i];
                var fieldValueDescriptor = fieldValueDescriptors[i];
                var fieldValueResult = fieldValueResults[i];

                if (UuidFields.Contains(fieldName))
                {
                    if (fieldValueResult is PrimitiveInfo p && p.Name == PrimitiveInfo.String.Name)
                    {
                        TypeInfo uuidInfo = UuidInfo.UuidGuidAsRfc4122String(fieldValueResult);
                        var uuidDescriptor = uuidInfo.GetDescriptor();
                        if (createdTypeInfos.ContainsKey(uuidDescriptor))
                            uuidInfo = createdTypeInfos[uuidDescriptor];
                        else
                            createdTypeInfos[uuidDescriptor] = uuidInfo;

                        fieldValueResult = uuidInfo;
                        fieldValueDescriptor = uuidDescriptor;
                    }
                    else if (fieldValueResult is NullableInfo n && n.ValueTypeInfo is PrimitiveInfo np && np.Name == PrimitiveInfo.String.Name)
                    {
                        TypeInfo uuidInfo = UuidInfo.UuidGuidAsRfc4122String(n.ValueTypeInfo);
                        var uuidDescriptor = uuidInfo.GetDescriptor();
                        if (createdTypeInfos.ContainsKey(uuidDescriptor))
                            uuidInfo = createdTypeInfos[uuidDescriptor];
                        else
                            createdTypeInfos[uuidDescriptor] = uuidInfo;

                        var nullableDescriptor = Energistics.Avro.Schemas.Types.Nullable.GetDescriptor(n.NullFirst, uuidDescriptor);
                        if (!createdTypeInfos.TryGetValue(nullableDescriptor, out var nullableInfo))
                        {
                            var uniqueName = uniqueNameCounters.GetUniqueName(NullableInfo.CreateUniqueNamePrefix(uuidInfo, n.NullFirst));
                            nullableInfo = new NullableInfo(null, uuidInfo, n.NullFirst, uniqueName);
                            createdTypeInfos[nullableDescriptor] = nullableInfo;
                        }

                        fieldValueResult = nullableInfo;
                        fieldValueDescriptor = nullableDescriptor;
                    }
                }

                fieldNames[i] = fieldName;
                fieldValueDescriptors[i] = fieldValueDescriptor;
                fieldValueResults[i] = fieldValueResult;
            }
        }
    }
}
