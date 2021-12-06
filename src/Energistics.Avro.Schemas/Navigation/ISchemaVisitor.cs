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

namespace Energistics.Avro.Schemas.Navigation
{
    public interface ISchemaVisitor<TSchema, TResult>
    {
        TResult VisitTypeName(string typeDescriptor, NavigationContext context);

        TResult VisitLogical(TSchema logical, string typeDescriptor, string baseTypeDescriptor, TResult baseTypeResult, string logicalType, NavigationContext context);

        TResult VisitPrimitive(string primitiveName, NavigationContext context);

        TResult VisitRecord(TSchema record, string recordName, NavigationContext context);

        TResult VisitRecordFields(TSchema record, string recordName, TResult recordResult, IReadOnlyList<string> fieldNames, IReadOnlyList<string> fieldValueDescriptors, IReadOnlyList<TResult> fieldValueResults, NavigationContext context);

        TResult VisitEnum(TSchema @enum, string enumName, IReadOnlyList<string> symbols, NavigationContext context);

        TResult VisitFixed(TSchema @fixed, string fixedName, long size, NavigationContext context);

        TResult VisitArray(TSchema array, string typeDescriptor, string itemsDescriptor, TResult itemsResult, NavigationContext context);

        TResult VisitMap(TSchema map, string typeDescriptor, string valuesDescriptor, TResult valuesResult, NavigationContext context);

        TResult VisitNullable(TSchema nullable, string typeDescriptor, bool nullFirst, string valueDescriptor, TResult valueResult, NavigationContext context);

        TResult VisitChoice(TSchema choice, string typeDescriptor, IReadOnlyList<string> valueDescriptors, IReadOnlyList<TResult> valueResults, NavigationContext context);
    }
}
