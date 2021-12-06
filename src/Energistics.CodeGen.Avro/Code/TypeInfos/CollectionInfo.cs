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
    public abstract class CollectionInfo : TypeInfo
    {
        protected CollectionInfo(Collection collection, string collectionAvroName, TypeInfo elementTypeInfo)
            : base(collection, collectionAvroName, null, elementTypeInfo?.Name, elementTypeInfo?.Namespace)
        {
            ElementTypeInfo = elementTypeInfo;
        }

        public override string VariableInitializer => $"new {InstanceType}()";

        public override string MethodTypeInfix => $"{TypeInfix}Of{ElementTypeInfo.MethodTypeInfix}";
        public override bool IsStruct => false;
        public override TypeInfo InnermostVisibleTypeInfo => ElementTypeInfo.InnermostVisibleTypeInfo;

        public override string BaseClassOrInterface => ElementTypeInfo.BaseClassOrInterface;
        public override bool HasGenericConstraint => ElementTypeInfo.HasGenericConstraint;


        public abstract TypeInfo ElementNameTypeInfo { get; }
        public TypeInfo ElementTypeInfo { get; }

        public abstract string ElementCollection { get; }
        public abstract string Element { get; }
        public abstract bool ElementsHaveNames { get; }

        public abstract string ElementName { get; }
        public abstract string ElementVariableNameFormat { get; }
        public abstract string ElementVariableValueFormat { get; }

        public string ElementVariableName(string elementVariable) => ElementVariableNameFormat.Replace("{elementVariable}", elementVariable);
        public string ElementVariableValue(string elementVariable) => ElementVariableValueFormat.Replace("{elementVariable}", elementVariable);
    }
}
