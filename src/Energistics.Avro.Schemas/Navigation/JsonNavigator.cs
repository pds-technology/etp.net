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
using Energistics.Json;
using Energistics.Json.Tokens;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Energistics.Avro.Schemas.Navigation
{
    public class JsonNavigator<TResult> : ISchemaNavigator<Token, TResult>
    {
        public TResult Navigate(Token root, ISchemaVisitor<Token, TResult> visitor) => Navigate(root, null, visitor);

        public TResult Navigate(Token root, SchemaName rootName, ISchemaVisitor<Token, TResult> visitor)
        {
            var navigatedNamedTypes = new HashSet<string>();
            var (descriptor, result) = Navigate(root, new NavigationContext(rootName), navigatedNamedTypes, visitor);

            return result;
        }

        private (string, TResult) Navigate(Token type, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<Token, TResult> visitor)
        {
            if (type.IsLogicalType())
                return NavigateLogical(type, context, navigatedNamedTypes, visitor);
            else
                return NavigateBase(type, context, navigatedNamedTypes, visitor);
        }

        private (string, TResult) NavigateBase(Token type, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<Token, TResult> visitor)
        {
            if (type is String)
            {
                var name = SchemaName.Create(type.GetValue());
                if (Primitive.IsPrimitiveName(name))
                    return NavigatePrimitive(name, context, navigatedNamedTypes, visitor);

                var result = visitor.VisitTypeName(name.FullName, context);
                return (name.FullName, result);
            }
            else if (type is Object)
            {
                if (type.IsComplexType())
                {
                    if (type.IsRecord())
                        return NavigateRecord(type, context, navigatedNamedTypes, visitor);
                    else if (type.IsEnum())
                        return NavigateEnum(type, context, navigatedNamedTypes, visitor);
                    else if (type.IsFixed())
                        return NavigateFixed(type, context, navigatedNamedTypes, visitor);
                    else if (type.IsAvroArray())
                        return NavigateArray(type, context, navigatedNamedTypes, visitor);
                    else if (type.IsAvroMap())
                        return NavigateMap(type, context, navigatedNamedTypes, visitor);
                    else
                        throw new InvalidDataException($"Unexpected type definition: '{type}'");
                }
                else if (type.HasType())
                    return Navigate(type.Type(), context, navigatedNamedTypes, visitor);
                else
                    throw new InvalidDataException($"Unexpected type definition: '{type}'");
            }
            else if (type is Json.Tokens.Array)
            {
                return NavigateUnion(type, context, navigatedNamedTypes, visitor);
            }
            else
            {
                throw new InvalidDataException($"Unexpected type definition: '{type}'");
            }
        }

        private (string, TResult) NavigateLogical(Token logical, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<Token, TResult> visitor)
        {
            var (baseTypeDescriptor, baseTypeResult) = NavigateBase(logical, context, navigatedNamedTypes, visitor);
            var descriptor = Logical.GetDescriptor(baseTypeDescriptor, logical.LogicalType());
            var result = visitor.VisitLogical(logical, descriptor, baseTypeDescriptor, baseTypeResult, logical.LogicalType(), context);
            return (descriptor, result);
        }

        private (string, TResult) NavigatePrimitive(SchemaName primitiveName, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<Token, TResult> visitor)
        {
            var descriptor = Primitive.GetDescriptor(primitiveName.FullName);
            if (!navigatedNamedTypes.Add(descriptor)) // Short-circuit if already navigated.
            {
                var r = visitor.VisitTypeName(descriptor, context);
                return (descriptor, r);
            }

            var result = visitor.VisitPrimitive(descriptor, context);
            return (descriptor, result);
        }

        private (string, TResult) NavigateRecord(Token record, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<Token, TResult> visitor)
        {
            var name = SchemaName.Create(record, SchemaName.Create(context.EnclosingName, context.EnclosingNamespace, null));
            var descriptor = Record.GetDescriptor(name.FullName);
            if (!navigatedNamedTypes.Add(descriptor)) // Short-circuit if already navigated.
            {
                var r = visitor.VisitTypeName(descriptor, context);
                return (descriptor, r);
            }

            var fields = record.Fields();
            if (fields == null)
                throw new InvalidDataException($"Missing fields in record definition: '{name.FullName}'");

            var result = visitor.VisitRecord(record, descriptor, context);

            var fieldNames = new List<string>();
            var fieldValueDescriptors = new List<string>();
            var fieldValueResults = new List<TResult>();
            foreach (var field in fields)
            {
                var (fieldName, fieldValueDescriptor, fieldValueResult) = NavigateRecordField(record, new NavigationContext(name), field, navigatedNamedTypes, visitor);
                fieldNames.Add(fieldName);
                fieldValueDescriptors.Add(fieldValueDescriptor);
                fieldValueResults.Add(fieldValueResult);
            }

            result = visitor.VisitRecordFields(record, descriptor, result, fieldNames, fieldValueDescriptors, fieldValueResults, context);

            return (descriptor, result);
        }

        private (string, string, TResult) NavigateRecordField(Token record, NavigationContext context, Token field, HashSet<string> navigatedNamedTypes, ISchemaVisitor<Token, TResult> visitor)
        {
            if (!field.HasName())
                throw new InvalidDataException($"Missing field name for field in record '{context.EnclosingFullName}': '{field}'");

            var name = field.Name();
            var type = field.Type();
            if (type == null)
                throw new InvalidDataException($"Missing field type for field in record '{context.EnclosingFullName}': '{name}'");

            var (descriptor, result) = Navigate(type, new NavigationContext(SchemaName.Create(context.EnclosingName, context.EnclosingNamespace, null), name), navigatedNamedTypes, visitor);
            return (name, descriptor, result);
        }

        private (string, TResult) NavigateEnum(Token @enum, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<Token, TResult> visitor)
        {
            var name = SchemaName.Create(@enum, SchemaName.Create(context.EnclosingName, context.EnclosingNamespace, null));
            var descriptor = Enum.GetDescriptor(name.FullName);
            if (!navigatedNamedTypes.Add(descriptor)) // Short-circuit if already navigated.
            {
                var r = visitor.VisitTypeName(descriptor, context);
                return (descriptor, r);
            }

            if (!@enum.HasSymbols())
                throw new InvalidDataException($"Missing symbols enum: '{name.FullName}'");

            var result = visitor.VisitEnum(@enum, descriptor, @enum.Symbols().ToList(), context);
            return (descriptor, result);
        }

        private (string, TResult) NavigateFixed(Token @fixed, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<Token, TResult> visitor)
        {
            var name = SchemaName.Create(@fixed, SchemaName.Create(context.EnclosingName, context.EnclosingNamespace, null));
            var descriptor = Fixed.GetDescriptor(name.FullName);
            if (!navigatedNamedTypes.Add(descriptor)) // Short-circuit if already navigated.
            {
                var r = visitor.VisitTypeName(descriptor, context);
                return (descriptor, r);
            }

            if (!@fixed.HasSize())
                throw new InvalidDataException($"Missing size in fixed: '{name.FullName}'");

            var result = visitor.VisitFixed(@fixed, descriptor, @fixed.Size(), context);
            return (descriptor, result);
        }

        private (string, TResult) NavigateArray(Token array, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<Token, TResult> visitor)
        {
            var items = array.Items();
            if (items == null)
                throw new InvalidDataException($"Missing items in array in '{context.EnclosingFullName}': '{array}'");

            var (itemsDescriptor, itemsResult) = Navigate(items, context, navigatedNamedTypes, visitor);
            var descriptor = Types.Array.GetDescriptor(itemsDescriptor);
            var result = visitor.VisitArray(array, descriptor, itemsDescriptor, itemsResult, context);

            return (descriptor, result);
        }

        private (string, TResult) NavigateMap(Token map, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<Token, TResult> visitor)
        {
            var values = map.Values();
            if (values == null)
                throw new InvalidDataException($"Missing values in map in '{context.EnclosingFullName}': '{map}'");

            var (valuesDescriptor, valuesResult) = Navigate(values, context, navigatedNamedTypes, visitor);
            var descriptor = Map.GetDescriptor(valuesDescriptor);
            var result = visitor.VisitMap(map, descriptor, valuesDescriptor, valuesResult, context);
            return (descriptor, result);
        }

        private (string, TResult) NavigateUnion(Token union, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<Token, TResult> visitor)
        {
            if (!(union is Json.Tokens.Array array))
                throw new InvalidDataException($"Invalid union in '{context.EnclosingFullName}': '{union}'");

            var unionValueDescriptors = new List<string>();
            var unionValueResults = new List<TResult>();
            foreach (var type in array)
            {
                var (unionValueDescriptor, unionValueResult) = Navigate(type, context, navigatedNamedTypes, visitor);
                unionValueDescriptors.Add(unionValueDescriptor);
                unionValueResults.Add(unionValueResult);
            }

            if (array.Count == 2 && unionValueDescriptors.Any(d => d == Primitive.Null.Name))
            {
                var nullFirst = unionValueDescriptors[0] == Primitive.Null.Name;
                var valueIndex = nullFirst ? 1 : 0;
                var descriptor = Nullable.GetDescriptor(nullFirst, unionValueDescriptors[valueIndex]);
                var result = visitor.VisitNullable(union, descriptor, nullFirst, unionValueDescriptors[valueIndex], unionValueResults[valueIndex], context);
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
