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

namespace Energistics.Avro.Schemas
{
    public abstract class Type
    {
        protected Type(Token token, SchemaName name)
            : this(token, name, null, null, null)
        {
        }

        protected Type(SchemaName name)
            : this(null, name, null, null, null)
        {
        }

        protected Type(Token token, SchemaName name, string doc, IEnumerable<string> aliases, IEnumerable<string> dependencies)
        {
            Token = token;

            SchemaName = name;
            Doc = doc ?? string.Empty;
            Aliases = aliases?.ToList() ?? new List<string>();
            Dependencies = dependencies?.ToList() ?? new List<string>();
        }


        public Token Token { get; }

        private SchemaName SchemaName { get; }

        public string Name => SchemaName.Name;

        public string Namespace => SchemaName.Namespace;

        public string FullName => SchemaName.FullName;

        public virtual bool IsNull => false;

        public string Doc { get; }

        public IReadOnlyList<string> Aliases { get; }

        public IReadOnlyList<string> Dependencies { get; }
    }
}
