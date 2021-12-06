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
    public class NullableInfo : TypeInfo
    {
        public NullableInfo(Nullable nullable, TypeInfo valueTypeInfo, bool nullFirst, string uniqueName)
            : base(nullable, "union", null, valueTypeInfo?.Name, valueTypeInfo?.Namespace)
        {
            UniqueName = uniqueName;
            ValueTypeInfo = valueTypeInfo;
            NullFirst = nullFirst;
        }

        public static string CreateUniqueNamePrefix(TypeInfo valueTypeInfo, bool nullFirst)
        {
            return $"Nullable{(valueTypeInfo is NamedTypeInfo ? valueTypeInfo.Name : valueTypeInfo.MethodTypeInfix)}{(nullFirst ? "NullFirst" : "ValueFirst")}";
        }
        public string UniqueName { get; }

        public TypeInfo ValueTypeInfo { get; }

        public TypeInfo NullTypeInfo => PrimitiveInfo.Null;

        public override string MethodTypeInfix => $"Nullable{ValueTypeInfo.MethodTypeInfix}";

        public override string InstanceType => $"{ValueTypeInfo.InstanceType}{(IsStruct ? "?" : string.Empty)}";

        public override string DeclaredType => $"{ValueTypeInfo.DeclaredType}{(IsStruct ? "?" : string.Empty)}";

        public override string BaseClassOrInterface => ValueTypeInfo.BaseClassOrInterface;

        public override bool HasGenericConstraint => ValueTypeInfo.HasGenericConstraint;

        public override bool IsStruct => ValueTypeInfo.IsStruct;

        public override TypeInfo InnermostVisibleTypeInfo => ValueTypeInfo.InnermostVisibleTypeInfo;

        public override string ValueIfNotNull(string variable) => IsStruct ? $"{variable}.Value" : variable;

        public string NullTypeInfix => IsStruct ? "Struct" : "Class";

        public bool NullFirst { get; }

        public string Converter => $"{UniqueName}TypeConverter";
    }
}
