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

using System.Collections.Generic;
using System.Linq;

namespace Energistics.Avro.Schemas.Navigation.Visitors
{
    public sealed class NamedTypeDependencyFinder<TSchema> : ISchemaVisitor<TSchema, IEnumerable<string>>
    {
        public IEnumerable<string> VisitTypeName(string typeDescriptor, NavigationContext context)
        {
            yield return typeDescriptor;
        }

        public IEnumerable<string> VisitLogical(TSchema logical, string typeDescriptor, string baseTypeDescriptor, IEnumerable<string> baseTypeResult, string logicalType, NavigationContext context)
        {
            return Enumerable.Empty<string>();
        }

        public IEnumerable<string> VisitPrimitive(string primitiveName, NavigationContext context)
        {
            return Enumerable.Empty<string>();
        }

        public IEnumerable<string> VisitRecord(TSchema record, string recordName, NavigationContext context)
        {
            yield return recordName;
        }

        public IEnumerable<string> VisitRecordFields(TSchema record, string recordName, IEnumerable<string> recordResult, IReadOnlyList<string> fieldNames, IReadOnlyList<string> fieldValueDescriptors, IReadOnlyList<IEnumerable<string>> fieldValueResults, NavigationContext context)
        {
            foreach (var fieldValueResult in fieldValueResults)
                foreach (var descriptor in fieldValueResult)
                    yield return descriptor;

            foreach (var descriptor in recordResult)
                yield return descriptor;
        }

        public IEnumerable<string> VisitEnum(TSchema @enum, string enumName, IReadOnlyList<string> symbols, NavigationContext context)
        {
            yield return enumName;
        }

        public IEnumerable<string> VisitFixed(TSchema @fixed, string fixedName, long size, NavigationContext context)
        {
            yield return fixedName;
        }

        public IEnumerable<string> VisitArray(TSchema array, string typeDescriptor, string itemsDescriptor, IEnumerable<string> itemsResult, NavigationContext context)
        {
            foreach (var descriptor in itemsResult)
                yield return descriptor;
        }

        public IEnumerable<string> VisitMap(TSchema map, string typeDescriptor, string valuesDescriptor, IEnumerable<string> valuesResult, NavigationContext context)
        {
            foreach (var descriptor in valuesResult)
                yield return descriptor;
        }

        public IEnumerable<string> VisitNullable(TSchema nullable, string typeDescriptor, bool nullFirst, string valueDescriptor, IEnumerable<string> valueResult, NavigationContext context)
        {
            foreach (var descriptor in valueResult)
                yield return descriptor;
        }

        public IEnumerable<string> VisitChoice(TSchema choice, string typeDescriptor, IReadOnlyList<string> valueDescriptors, IReadOnlyList<IEnumerable<string>> valueResults, NavigationContext context)
        {
            foreach (var valueResult in valueResults)
                foreach (var descriptor in valueResult)
                    yield return descriptor;
        }
    }
}
