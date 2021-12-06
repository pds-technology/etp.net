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
    public class Choice : Union
    {
        public Choice(Token token, IEnumerable<Type> allowedTypes)
            : base(token, ChoiceName, allowedTypes)
        {
        }

        public Choice(IEnumerable<Type> allowedTypes)
            : this(null, allowedTypes)
        {
        }

        private static SchemaName ChoiceName { get; } = SchemaName.Create("choice");

        public static string GetDescriptor(IEnumerable<string> choiceDescriptors) => GetDescriptor(ChoiceName.FullName, choiceDescriptors);

        new public static string GetCanonicalSchema(IEnumerable<string> unionValueCanonicalSchemas) => Union.GetCanonicalSchema(unionValueCanonicalSchemas);
    }
}
