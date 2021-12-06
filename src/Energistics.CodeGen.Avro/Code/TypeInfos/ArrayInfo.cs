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
    public class ArrayInfo : CollectionInfo
    {
        public ArrayInfo(Collection collection, TypeInfo itemsTypeInfo)
            : base(collection, "array", itemsTypeInfo)
        {
        }

        public override string VariablePrefix => "a";

        public override string MethodParameterName => "array";

        public override string TypeInfix => "Array";

        public override string InstanceType => $"List<{ElementTypeInfo.DeclaredType}>";

        public override string DeclaredType => $"IList<{ElementTypeInfo.DeclaredType}>";

        public override string ElementCollection => "Items";
        public override string Element => "Item";
        public override bool ElementsHaveNames => false;
        public override string ElementName => null;
        public override string ElementVariableNameFormat => null;
        public override string ElementVariableValueFormat => "{elementVariable}";

        public override TypeInfo ElementNameTypeInfo => null;
    }
}
