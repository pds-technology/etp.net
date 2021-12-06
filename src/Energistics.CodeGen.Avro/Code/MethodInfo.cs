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

namespace Energistics.CodeGen.Avro.Code
{
    public sealed class MethodInfo
    {
        public static MethodInfo Encode(TypeInfo typeInfo) => new MethodInfo(typeInfo.MethodTypeInfix, typeInfo.TypeInfix, "Encode{typeInfix}{infix}{genericDeclaration}", typeInfo.InnermostVisibleTypeInfo.HasGenericConstraint ? typeInfo.InnermostVisibleTypeInfo.GenericTypeDeclaration : string.Empty, false);
        public static MethodInfo Decode(TypeInfo typeInfo) => new MethodInfo(typeInfo.MethodTypeInfix, typeInfo.TypeInfix, "Decode{typeInfix}{infix}{genericDeclaration}", typeInfo.InnermostVisibleTypeInfo.HasGenericConstraint ? typeInfo.InnermostVisibleTypeInfo.GenericTypeDeclaration : string.Empty, true, typeInfo.DeclaredType, typeInfo.MethodParameter.Name, typeInfo.VariableInitializer);
        public static MethodInfo VoidDecode(TypeInfo typeInfo) => new MethodInfo(typeInfo.MethodTypeInfix, typeInfo.TypeInfix, "Decode{typeInfix}{infix}{genericDeclaration}", typeInfo.InnermostVisibleTypeInfo.HasGenericConstraint ? typeInfo.InnermostVisibleTypeInfo.GenericTypeDeclaration : string.Empty, false);
        public MethodInfo(string methodTypeInfix, string typeInfix, string nameFormat, string genericDeclaration, bool hasReturnValue, string returnType = null, string returnVariablePrefix = null, string returnVariableInitializer = null)
        {
            MethodTypeInfix = methodTypeInfix;
            TypeInfix = typeInfix;
            NameFormat = nameFormat;
            GenericDeclaration = genericDeclaration;
            HasReturnValue = hasReturnValue;
            ReturnType = HasReturnValue ? returnType : "void";
            ReturnVariablePrefix = returnVariablePrefix ?? string.Empty;
            ReturnVariableInitializer = returnVariableInitializer ?? string.Empty;
        }
        public string MethodTypeInfix { get; }
        public string TypeInfix { get; }
        public string GenericDeclaration { get; }
        public string ReturnType { get; }
        public string NameFormat { get; }
        public bool HasReturnValue { get; }
        public string UpdateReturnVariableFormat { get; }
        public string ReturnVariablePrefix { get; }
        public string ReturnVariableInitializer { get; }
        public string BaseName() => BaseName(string.Empty);
        public string BaseName(string infix) => FormattedName(string.Empty, infix, string.Empty);
        public string FullName() => FullName(string.Empty);
        public string FullName(string infix) => FormattedName(MethodTypeInfix, infix, GenericDeclaration);
        public string Name() => Name(string.Empty);
        public string Name(string infix) => FormattedName(TypeInfix, infix, string.Empty);
        private string FormattedName(string typeInfix, string infix, string genericDeclaration) => NameFormat.Replace("{infix}", infix).Replace("{typeInfix}", typeInfix).Replace("{genericDeclaration}", genericDeclaration);
    }
}
