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
using Energistics.Avro.Schemas.Navigation;
using Energistics.Avro.Schemas.Types;
using System.Collections.Generic;
using System.Linq;

namespace Energistics.Avro.Schemas
{
    public sealed class TypeCollection
    {
        public TypeCollection()
        {
            foreach (var primitive in Primitive.Primitives)
                TypesByName[primitive.FullName] = primitive;
            foreach (var primitive in Primitive.Primitives)
                TypesByDescriptor[primitive.FullName] = primitive;
        }

        public Dictionary<string, Type> TypesByName { get; } = new Dictionary<string, Type>();

        public Dictionary<string, Type> TypesByDescriptor { get; } = new Dictionary<string, Type>();

        public void ParseProtocolTypes(string protocol)
        {
            var reader = new JsonReader(protocol);
            var token = reader.Read();

            ParseProtocolTypes(token);
        }

        public void ParseProtocolTypes(Token protocol)
        {
            if (!protocol.IsProtocol())
                throw new System.ArgumentException("Not an Avro protocol.", nameof(protocol));

            var types = protocol.GetArray("types");
            if (types == null)
                return;

            var protocolName = SchemaName.Create(protocol);

            foreach (var type in types)
                type.CreateTypes(protocolName, TypesByDescriptor);

            foreach (var type in TypesByDescriptor.Values.Where(t => t is NamedType))
                TypesByName[type.FullName] = type;
        }
    }
}
