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

using Energistics.Avro.Schemas.Types;
using System.Collections.Generic;
using System.Linq;

namespace Energistics.CodeGen.Avro.Code.TypeInfos
{
    public class ChoiceInfo : TypeInfo
    {
        public ChoiceInfo(Choice choice, string uniqueName, IEnumerable<TypeInfo> choiceTypeInfos)
            : base(choice, "union", null, "Choice", null)
        {
            ChoiceTypeInfos = choiceTypeInfos.ToList();
            UniqueName = uniqueName;
        }

        public static string CreateUniqueNamePrefix(IEnumerable<TypeInfo> choiceTypeInfos)
        {
            return $"ChoiceOf{(string.Concat(choiceTypeInfos.Select(vr => vr is NamedTypeInfo ? vr.Name : vr.MethodTypeInfix)))}";
        }

        public string UniqueName { get; }

        public override string MethodTypeInfix => UniqueName;

        public override string InstanceType => $"object";

        public override string DeclaredType => InstanceType;

        public IReadOnlyList<TypeInfo> ChoiceTypeInfos { get; }

        public string NullTypeInfix => "Class";

        public string Converter => $"{UniqueName}TypeConverter";

        public override bool IsStruct => false;
    }
}
