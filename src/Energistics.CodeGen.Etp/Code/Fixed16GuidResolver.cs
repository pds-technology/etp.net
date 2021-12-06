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
using Energistics.Avro.Schemas.Types;
using Energistics.CodeGen.Avro.Code;
using Energistics.CodeGen.Avro.Code.TypeInfos;
using Energistics.CodeGen.Avro.Code.TypeInfos.LogicalTypeInfos;
using System.Collections.Generic;

namespace Energistics.CodeGen.Etp.Code
{
    public class Fixed16GuidResolver : TypeResolverBase
    {
        public override bool CanResolveFixed(Type @fixed, string fixedName, long size, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
            => (@fixed as Fixed).Size == 16L;

        public override TypeInfo ResolveFixed(Type @fixed, string fixedName, long size, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
        {
            if (!createdTypeInfos.TryGetValue(@fixed.FullName, out var fixedInfo))
            {
                fixedInfo = new FixedInfo(@fixed as Fixed, @fixed.Name, @fixed.Namespace, @fixed.GetClassName(namingOptions), @fixed.GetNamespace(namingOptions), (@fixed as Fixed).Size);
                createdTypeInfos[fixedInfo.FullName] = fixedInfo;
            }
            return UuidInfo.UuidGuidAsFixed(fixedInfo);
        }
    }
}
