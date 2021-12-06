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
    public sealed class Enum : NamedType
    {
        public Enum(Token token, SchemaName name, string doc, IEnumerable<string> aliases, IEnumerable<string> symbols)
            : base(token, name, doc, aliases, Enumerable.Empty<string>())
        {
            Symbols = symbols.ToList();
        }

        public IReadOnlyList<string> Symbols { get; }

        public static string GetCanonicalSchema(string enumName, IReadOnlyList<string> symbols)
        {
            return $"{{\"name\":\"{enumName}\",\"type\":\"enum\",\"symbols\":[{string.Join(",", symbols.Select(s => $"\"{s}\""))}]}}";
        }
    }
}
