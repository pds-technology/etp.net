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
using Energistics.CodeGen.Code;

namespace Energistics.CodeGen.Avro.Code
{
    public abstract class TypeInfo
    {
        protected TypeInfo(Type type, string avroName, string avroNamespace, string name, string @namespace)
        {
            Type = type;
            AvroName = avroName;
            AvroNamespace = avroNamespace;
            AvroFullName = string.IsNullOrEmpty(AvroNamespace) ? AvroName : $"{AvroNamespace}.{AvroName}";

            Name = name;
            Namespace = @namespace;
            FullName = string.IsNullOrEmpty(Namespace) ? Name : $"{Namespace}.{Name}";
        }

        public Type Type { get; }

        public string AvroName { get; }

        public string AvroNamespace { get; }

        public string AvroFullName { get; }

        public string Name { get; }

        public string Namespace { get; }

        public string FullName { get; }

        public virtual string VariablePrefix => "v";

        public virtual string VariableInitializer => null;

        public virtual string MethodParameterName => "value";

        public virtual string TypeInfix => Name;

        public virtual string MethodTypeInfix => TypeInfix;

        public virtual string InstanceType => FullName;

        public virtual string DeclaredType => FullName;

        public virtual string BaseClassOrInterface => null;

        public virtual bool HasGenericConstraint => false;

        public virtual bool IsNull => false;

        public abstract bool IsStruct { get; }

        public virtual TypeInfo InnermostVisibleTypeInfo => this;

        public virtual string ValueIfNotNull(string variable) => variable;

        public string GenericTypeDeclaration => $"<{DeclaredType}>";

        public WhereClause WhereClause
        {
            get
            {
                if (InnermostVisibleTypeInfo.HasGenericConstraint)
                {
                    var constraints = new System.Collections.Generic.List<string>();
                    constraints.Add(InnermostVisibleTypeInfo.IsStruct ? "struct" : "class");
                    if (!string.IsNullOrEmpty(InnermostVisibleTypeInfo.BaseClassOrInterface))
                        constraints.Add(InnermostVisibleTypeInfo.BaseClassOrInterface);
                    if (!InnermostVisibleTypeInfo.IsStruct)
                        constraints.Add("new()");
                    return new WhereClause { Type = InnermostVisibleTypeInfo.FullName, Constraints = constraints };
                }
                else
                    return null;
            }
        }

        public MethodParameter MethodParameter => new MethodParameter { Type = DeclaredType, Name = MethodParameterName };
    }
}
