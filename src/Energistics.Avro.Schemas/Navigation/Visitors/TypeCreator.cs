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
using Energistics.Avro.Schemas.Types;
using System.Collections.Generic;
using System.Linq;

namespace Energistics.Avro.Schemas.Navigation.Visitors
{
    public sealed class TypeCreator : ISchemaVisitor<Token, Type>
    {
        public TypeCreator()
            : this(new Dictionary<string, Type>())
        {
        }

        public TypeCreator(Dictionary<string, Type> existingTypes)
        {
            Types = existingTypes;
        }

        public Dictionary<string, Type> Types { get; }

        public Type VisitTypeName(string typeDescriptor, NavigationContext context)
        {
            if (!Types.TryGetValue(typeDescriptor, out var type))
                throw new System.InvalidOperationException($"Type '{type}' not defined.");

            return type;
        }

        public Type VisitLogical(Token logical, string typeDescriptor, string baseTypeDescriptor, Type baseTypeResult, string logicalType, NavigationContext context)
        {
            if (Types.TryGetValue(typeDescriptor, out var type))
                return type;

            type = new Logical(logical, baseTypeResult, logicalType);
            Types[typeDescriptor] = type;
            return type;
        }

        public Type VisitPrimitive(string primitiveName, NavigationContext context)
        {
            if (Types.TryGetValue(primitiveName, out var type))
                return type;

            type = Primitive.GetPrimitive(primitiveName);
            Types[primitiveName] = type;
            return type;
        }

        public Type VisitRecord(Token record, string recordName, NavigationContext context)
        {
            if (Types.TryGetValue(recordName, out var type))
                return type;

            var dependencies = record.GetNamedTypeDependencies();
            type = new Record(record, SchemaName.Create(recordName), record.Doc(), record.Aliases(), dependencies);
            Types[recordName] = type;
            return type;
        }

        public Type VisitRecordFields(Token record, string recordName, Type recordResult, IReadOnlyList<string> fieldNames, IReadOnlyList<string> fieldValueDescriptors, IReadOnlyList<Type> fieldValueResults, NavigationContext context)
        {
            var fields = fieldValueResults.Select((t, i) => new Field(fieldNames[i], t)).ToList();
            (recordResult as Record).SetFields(fields);

            return recordResult;
        }

        public Type VisitEnum(Token @enum, string enumName, IReadOnlyList<string> symbols, NavigationContext context)
        {
            if (Types.TryGetValue(enumName, out var type))
                return type;

            type = new Enum(@enum, SchemaName.Create(enumName), @enum.Doc(), @enum.Aliases(), @enum.Symbols());
            Types[enumName] = type;
            return type;
        }

        public Type VisitFixed(Token @fixed, string fixedName, long size, NavigationContext context)
        {
            if (Types.TryGetValue(fixedName, out var type))
                return type;

            type = new Fixed(@fixed, SchemaName.Create(fixedName), @fixed.Doc(), @fixed.Aliases(), size);
            Types[fixedName] = type;
            return type;
        }

        public Type VisitArray(Token array, string typeDescriptor, string itemsDescriptor, Type itemsResult, NavigationContext context)
        {
            if (Types.TryGetValue(typeDescriptor, out var type))
                return type;

            type = new Array(array, itemsResult);
            Types[typeDescriptor] = type;
            return type;
        }

        public Type VisitMap(Token map, string typeDescriptor, string valuesDescriptor, Type valuesResult, NavigationContext context)
        {
            if (Types.TryGetValue(typeDescriptor, out var type))
                return type;

            type = new Map(map, valuesResult);
            Types[typeDescriptor] = type;
            return type;
        }

        public Type VisitNullable(Token nullable, string typeDescriptor, bool nullFirst, string valueDescriptor, Type valueResult, NavigationContext context)
        {
            if (Types.TryGetValue(typeDescriptor, out var type))
                return type;

            type = new Nullable(nullable, valueResult, nullFirst);
            Types[typeDescriptor] = type;
            return type;
        }

        public Type VisitChoice(Token choice, string typeDescriptor, IReadOnlyList<string> valueDescriptors, IReadOnlyList<Type> valueResults, NavigationContext context)
        {
            if (Types.TryGetValue(typeDescriptor, out var type))
                return type;

            type = new Choice(choice, valueResults);
            Types[typeDescriptor] = type;
            return type;
        }
    }
}
