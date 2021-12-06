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
    public class Record : NamedType
    {
        public Record(Token token, SchemaName name, string doc, IEnumerable<string> aliases, IEnumerable<string> dependencies)
            : base(token, name, doc, aliases, dependencies)
        {
            Fields = new List<Field>();
        }

        public void SetFields(IEnumerable<Field> fields) => Fields = fields.ToList();

        public IReadOnlyList<Field> Fields { get; private set; }

        public static string GetCanonicalSchema(string recordName, IReadOnlyList<string> fieldNames, IReadOnlyList<string> fieldValueCanonicalSchemas)
        {
            var fields = fieldNames.Select((f, i) => $"{{\"name\":\"{f}\",\"type\":{fieldValueCanonicalSchemas[i]}}}");
            return $"{{\"type\":\"record\",\"name\":\"{recordName}\",\"fields\":[{string.Join(",", fields)}]}}";
        }
    }
}
