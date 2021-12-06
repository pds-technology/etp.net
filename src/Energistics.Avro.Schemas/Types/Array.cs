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

namespace Energistics.Avro.Schemas.Types
{
    public class Array : Collection
    {
        public Array(Token token, Type items)
            : base(token, ArrayName, items, ItemsName)
        {
        }

        public Array(Type items)
            : this(null, items)
        {
        }

        public Type Items => Elements;

        private static SchemaName ArrayName { get; } = SchemaName.Create("array");

        private static string ItemsName { get; } = "items";

        public static string GetDescriptor(string itemsDescriptor) => GetDescriptor(ArrayName.FullName, itemsDescriptor);

        public static string GetCanonicalSchema(string itemsCanonicalSchema) => GetCanonicalSchema(ArrayName.FullName, ItemsName, itemsCanonicalSchema);
    }
}
