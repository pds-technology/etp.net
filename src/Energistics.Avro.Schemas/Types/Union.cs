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
using System.Linq;

namespace Energistics.Avro.Schemas.Types
{
    public abstract class Union : Type
    {
        protected Union(Token token, SchemaName name, IEnumerable<Type> allowedTypes)
            : base(token, name)
        {
            AllowedTypes = allowedTypes.ToList();
        }

        public IReadOnlyList<Type> AllowedTypes { get; }

        public int NullIndex
        {
            get
            {
                for (int i = 0; i < AllowedTypes.Count; i++)
                {
                    if (AllowedTypes[i].IsNull)
                        return i;
                }

                return -1;
            }
        }

        public int FirstNonNullIndex => AllowedTypes[0].IsNull ? 1 : 0;

        protected static string GetDescriptor(string typeName, IEnumerable<string> unionValueDescriptors) => $"{typeName} of [{string.Join(", ", unionValueDescriptors)}]";

        protected static string GetCanonicalSchema(IEnumerable<string> unionValueCanonicalSchemas)
        {
            return $"[{string.Join(",", unionValueCanonicalSchemas)}]";
        }
    }
}
