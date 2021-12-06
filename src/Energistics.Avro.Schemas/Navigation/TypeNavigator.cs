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

namespace Energistics.Avro.Schemas.Navigation
{
    public class TypeNavigator<TResult> : ISchemaNavigator<Type, TResult>
    {
        public TResult Navigate(Type root, ISchemaVisitor<Type, TResult> visitor) => Navigate(root, (SchemaName)null, visitor);

        public TResult Navigate(Type root, SchemaName rootName, ISchemaVisitor<Type, TResult> visitor)
        {
            var navigatedNamedTypes = new HashSet<string>();
            var (descriptor, result) = Navigate(root, new NavigationContext(rootName), navigatedNamedTypes, visitor);

            return result;
        }

        private (string, TResult) Navigate(Type type, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<Type, TResult> visitor)
        {
            if (type is Logical logical)
                return NavigateLogical(logical, context, navigatedNamedTypes, visitor);
            else
                return NavigateBase(type, context, navigatedNamedTypes, visitor);
        }

        private (string, TResult) NavigateBase(Type type, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<Type, TResult> visitor)
        {
            switch (type)
            {
                case Logical logical: return NavigateLogical(logical, context, navigatedNamedTypes, visitor);
                case Primitive primitive: return NavigatePrimitive(primitive, context, navigatedNamedTypes, visitor);
                case Record record: return NavigateRecord(record, context, navigatedNamedTypes, visitor);
                case Enum @enum: return NavigateEnum(@enum, context, navigatedNamedTypes, visitor);
                case Fixed @fixed: return NavigateFixed(@fixed, context, navigatedNamedTypes, visitor);
                case Array array: return NavigateArray(array, context, navigatedNamedTypes, visitor);
                case Map map: return NavigateMap(map, context, navigatedNamedTypes, visitor);
                case Union union: return NavigateUnion(union, context, navigatedNamedTypes, visitor);
                default:
                    throw new System.IO.InvalidDataException($"Unexpected type: '{type?.GetType()}'");
            }
        }

        private (string, TResult) NavigateLogical(Logical logical, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<Type, TResult> visitor)
        {
            var (baseTypeDescriptor, baseTypeResult) = NavigateBase(logical, context, navigatedNamedTypes, visitor);
            var descriptor = Logical.GetDescriptor(baseTypeDescriptor, logical.LogicalType);
            var result = visitor.VisitLogical(logical, descriptor, baseTypeDescriptor, baseTypeResult, logical.LogicalType, context);
            return (descriptor, result);
        }

        private (string, TResult) NavigatePrimitive(Primitive primitive, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<Type, TResult> visitor)
        {
            var descriptor = Primitive.GetDescriptor(primitive.FullName);
            if (!navigatedNamedTypes.Add(descriptor)) // Short-circuit if already navigated.
            {
                var r = visitor.VisitTypeName(descriptor, context);
                return (descriptor, r);
            }

            var result = visitor.VisitPrimitive(descriptor, context);
            return (descriptor, result);
        }

        private (string, TResult) NavigateRecord(Record record, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<Type, TResult> visitor)
        {
            var descriptor = Record.GetDescriptor(record.FullName);
            if (!navigatedNamedTypes.Add(descriptor)) // Short-circuit if already navigated.
            {
                var r = visitor.VisitTypeName(descriptor, context);
                return (descriptor, r);
            }

            var result = visitor.VisitRecord(record, descriptor, context);

            var fieldNames = new List<string>();
            var fieldValueDescriptors = new List<string>();
            var fieldValueResults = new List<TResult>();
            foreach (var field in record.Fields)
            {
                var (fieldValueDescriptor, fieldValueResult) = Navigate(field.Type, new NavigationContext(record, field.Name), navigatedNamedTypes, visitor);
                fieldNames.Add(field.Name);
                fieldValueDescriptors.Add(fieldValueDescriptor);
                fieldValueResults.Add(fieldValueResult);
            }

            result = visitor.VisitRecordFields(record, descriptor, result, fieldNames, fieldValueDescriptors, fieldValueResults, context);

            return (descriptor, result);
        }

        private (string, TResult) NavigateEnum(Enum @enum, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<Type, TResult> visitor)
        {
            var descriptor = Enum.GetDescriptor(@enum.FullName);
            if (!navigatedNamedTypes.Add(descriptor)) // Short-circuit if already navigated.
            {
                var r = visitor.VisitTypeName(descriptor, context);
                return (descriptor, r);
            }

            var result = visitor.VisitEnum(@enum, descriptor, @enum.Symbols, context);
            return (descriptor, result);
        }

        private (string, TResult) NavigateFixed(Fixed @fixed, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<Type, TResult> visitor)
        {
            var descriptor = Fixed.GetDescriptor(@fixed.FullName);
            if (!navigatedNamedTypes.Add(descriptor)) // Short-circuit if already navigated.
            {
                var r = visitor.VisitTypeName(descriptor, context);
                return (descriptor, r);
            }

            var result = visitor.VisitFixed(@fixed, descriptor, @fixed.Size, context);
            return (descriptor, result);
        }

        private (string, TResult) NavigateArray(Array array, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<Type, TResult> visitor)
        {
            var (itemsDescriptor, itemsResult) = Navigate(array.Items, context, navigatedNamedTypes, visitor);
            var descriptor = Array.GetDescriptor(itemsDescriptor);
            var result = visitor.VisitArray(array, descriptor, itemsDescriptor, itemsResult, context);

            return (descriptor, result);
        }

        private (string, TResult) NavigateMap(Map map, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<Type, TResult> visitor)
        {
            var (valuesDescriptor, valuesResult) = Navigate(map.Values, context, navigatedNamedTypes, visitor);
            var descriptor = Map.GetDescriptor(valuesDescriptor);
            var result = visitor.VisitMap(map, descriptor, valuesDescriptor, valuesResult, context);

            return (descriptor, result);
        }

        private (string, TResult) NavigateUnion(Union union, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<Type, TResult> visitor)
        {
            var unionValueDescriptors = new List<string>();
            var unionValueResults = new List<TResult>();
            foreach (var t in union.AllowedTypes)
            {
                var (unionValueDescriptor, unionValueResult) = Navigate(t, context, navigatedNamedTypes, visitor);
                unionValueDescriptors.Add(unionValueDescriptor);
                unionValueResults.Add(unionValueResult);
            }

            if (union is Nullable nullable)
            {
                var descriptor = Nullable.GetDescriptor(nullable.NullFirst, unionValueDescriptors[nullable.ValueIndex]);
                var result = visitor.VisitNullable(nullable, descriptor, nullable.NullFirst, unionValueDescriptors[nullable.ValueIndex], unionValueResults[nullable.ValueIndex], context);
                return (descriptor, result);
            }
            else
            {
                var descriptor = Choice.GetDescriptor(unionValueDescriptors);
                var result = visitor.VisitChoice(union, descriptor, unionValueDescriptors, unionValueResults, context);
                return (descriptor, result);
            }
        }
    }
}
