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

using Energistics.Avro.Schemas.Types;
using System.Collections.Generic;

namespace Energistics.Avro.Schemas.Navigation.Visitors
{
    public sealed class CanonicalSchemaCreator<TSchema> : ISchemaVisitor<TSchema, string>
    {
        public string VisitTypeName(string typeDescriptor, NavigationContext context)
        {
            return $"\"{typeDescriptor}\"";
        }

        public string VisitLogical(TSchema logical, string typeDescriptor, string baseTypeDescriptor, string baseTypeResult, string logicalType, NavigationContext context)
        {
            return baseTypeResult;
        }

        public string VisitPrimitive(string primitiveName, NavigationContext context)
        {
            return Primitive.GetCanonicalSchema(primitiveName);
        }

        public string VisitRecord(TSchema record, string recordName, NavigationContext context)
        {
            return null;
        }

        public string VisitRecordFields(TSchema record, string recordName, string recordResult, IReadOnlyList<string> fieldNames, IReadOnlyList<string> fieldValueDescriptors, IReadOnlyList<string> fieldValueResults, NavigationContext context)
        {
            return Record.GetCanonicalSchema(recordName, fieldNames, fieldValueResults);
        }

        public string VisitEnum(TSchema @enum, string enumName, IReadOnlyList<string> symbols, NavigationContext context)
        {
            return Enum.GetCanonicalSchema(enumName, symbols);
        }

        public string VisitFixed(TSchema @fixed, string fixedName, long size, NavigationContext context)
        {
            return Fixed.GetCanonicalSchema(fixedName, size);
        }

        public string VisitArray(TSchema array, string typeDescriptor, string itemsDescriptor, string itemsResult, NavigationContext context)
        {
            return Array.GetCanonicalSchema(itemsResult);
        }

        public string VisitMap(TSchema map, string typeDescriptor, string valuesDescriptor, string valuesResult, NavigationContext context)
        {
            return Map.GetCanonicalSchema(valuesResult);
        }

        public string VisitNullable(TSchema nullable, string typeDescriptor, bool nullFirst, string valueDescriptor, string valueResult, NavigationContext context)
        {
            return Nullable.GetCanonicalSchema(nullFirst, valueResult);
        }

        public string VisitChoice(TSchema choice, string typeDescriptor, IReadOnlyList<string> valueDescriptors, IReadOnlyList<string> valueResults, NavigationContext context)
        {
            return Choice.GetCanonicalSchema(valueResults);
        }
    }
}
