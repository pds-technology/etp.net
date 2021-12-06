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

using Energistics.Json;
using System.Collections.Generic;

namespace Energistics.Avro.Schemas.Types
{
    public class Nullable : Union
    {
        public Nullable(Token token, Type value, bool nullFirst)
            : base(token, NullableName, nullFirst ? new List<Type> { Primitive.Null, value } : new List<Type> { value, Primitive.Null })
        {
        }

        public Nullable(Type value, bool nullFirst)
            : this(null, value, nullFirst)
        {
        }

        public bool NullFirst => NullIndex == 0;

        public int ValueIndex => FirstNonNullIndex;

        private static SchemaName NullableName { get; } = SchemaName.Create("nullable");

        public static string GetDescriptor(bool nullFirst, string valueDescriptor) => GetDescriptor(NullableName.FullName, nullFirst ? new string[] { Primitive.GetDescriptor(Primitive.Null.FullName), valueDescriptor } : new string[] { valueDescriptor, Primitive.GetDescriptor(Primitive.Null.FullName) });

        public static string GetCanonicalSchema(bool nullFirst, string valueCanonicalSchema) => Union.GetCanonicalSchema(nullFirst ? new string[] { Primitive.GetCanonicalSchema(Primitive.Null.FullName), valueCanonicalSchema } : new string[] { valueCanonicalSchema, Primitive.GetCanonicalSchema(Primitive.Null.FullName) } );

        public Type Value => AllowedTypes[FirstNonNullIndex];
    }
}
