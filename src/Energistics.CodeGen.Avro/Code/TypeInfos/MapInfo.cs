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

namespace Energistics.CodeGen.Avro.Code.TypeInfos
{
    public class MapInfo : CollectionInfo
    {
        public MapInfo(Collection collection, TypeInfo valuesTypeInfo)
            : base(collection, "map", valuesTypeInfo)
        {
        }

        public override string VariablePrefix => "m";

        public override string MethodParameterName => "map";

        public override string TypeInfix => "Map";

        public override string InstanceType => $"Dictionary<string, {ElementTypeInfo.DeclaredType}>";

        public override string DeclaredType => $"IDictionary<string, {ElementTypeInfo.DeclaredType}>";

        public override string ElementCollection => "Values";
        public override string Element => "Value";
        public override bool ElementsHaveNames => true;
        public override string ElementName => "Key";
        public override string ElementVariableNameFormat => "{elementVariable}.Key";
        public override string ElementVariableValueFormat => "{elementVariable}.Value";

        public override TypeInfo ElementNameTypeInfo => PrimitiveInfo.MapKey;
    }
}
