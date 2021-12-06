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

using Energistics.Avro.Schemas;
using Energistics.Avro.Schemas.Navigation;
using Energistics.Avro.Schemas.Types;
using Energistics.CodeGen.Avro.Code.TypeInfos;
using System.Collections.Generic;

namespace Energistics.CodeGen.Avro.Code
{
    public class TypeInfoNavigator<TResult> : ISchemaNavigator<TypeInfo, TResult>
    {
        public TResult Navigate(TypeInfo root, ISchemaVisitor<TypeInfo, TResult> visitor) => Navigate(root, (SchemaName)null, visitor);

        public TResult Navigate(TypeInfo root, SchemaName rootName, ISchemaVisitor<TypeInfo, TResult> visitor)
        {
            var navigatedNamedTypes = new HashSet<string>();
            var (descriptor, result) = Navigate(root, new NavigationContext(rootName), navigatedNamedTypes, visitor);

            return result;
        }

        private (string, TResult) Navigate(TypeInfo typeInfo, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<TypeInfo, TResult> visitor)
        {
            if (typeInfo is LogicalInfo logical)
                return NavigateLogicalInfo(logical, context, navigatedNamedTypes, visitor);
            else
                return NavigateBase(typeInfo, context, navigatedNamedTypes, visitor);
        }

        private (string, TResult) NavigateBase(TypeInfo typeInfo, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<TypeInfo, TResult> visitor)
        {
            switch (typeInfo)
            {
                case LogicalInfo logicalInfo: return NavigateLogicalInfo(logicalInfo, context, navigatedNamedTypes, visitor);
                case PrimitiveInfo primitiveInfo: return NavigatePrimitiveInfo(primitiveInfo, context, navigatedNamedTypes, visitor);
                case RecordInfo recordInfo: return NavigateRecordInfo(recordInfo, context, navigatedNamedTypes, visitor);
                case EnumInfo enumInfo: return NavigateEnumInfo(enumInfo, context, navigatedNamedTypes, visitor);
                case FixedInfo fixedInfo: return NavigateFixedInfo(fixedInfo, context, navigatedNamedTypes, visitor);
                case ArrayInfo arrayInfo: return NavigateArrayInfo(arrayInfo, context, navigatedNamedTypes, visitor);
                case MapInfo mapInfo: return NavigateMapInfo(mapInfo, context, navigatedNamedTypes, visitor);
                case NullableInfo nullableInfo: return NavigateNullableInfo(nullableInfo, context, navigatedNamedTypes, visitor);
                case ChoiceInfo choiceInfo: return NavigateChoiceInfo(choiceInfo, context, navigatedNamedTypes, visitor);
                case AvroObjectInfo objectInfo: return NavigateAvroObjectInfo(objectInfo, context, navigatedNamedTypes, visitor);
                default:
                    throw new System.IO.InvalidDataException($"Unexpected typeInfo: '{typeInfo?.GetType()}'");
            }
        }

        private (string, TResult) NavigateLogicalInfo(LogicalInfo logicalInfo, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<TypeInfo, TResult> visitor)
        {
            var (baseTypeDescriptor, baseTypeResult) = NavigateBase(logicalInfo.BaseTypeInfo, context, navigatedNamedTypes, visitor);
            var descriptor = Logical.GetDescriptor(baseTypeDescriptor, logicalInfo.AvroLogicalName);
            var result = visitor.VisitLogical(logicalInfo, descriptor, baseTypeDescriptor, baseTypeResult, logicalInfo.AvroLogicalName, context);
            return (descriptor, result);
        }

        private (string, TResult) NavigatePrimitiveInfo(PrimitiveInfo primitiveInfo, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<TypeInfo, TResult> visitor)
        {
            var descriptor = Primitive.GetDescriptor(primitiveInfo.AvroFullName);
            if (!navigatedNamedTypes.Add(descriptor)) // Short-circuit if already navigated.
            {
                var r = visitor.VisitTypeName(descriptor, context);
                return (descriptor, r);
            }

            var result = visitor.VisitPrimitive(descriptor, context);
            return (descriptor, result);
        }

        private (string, TResult) NavigateRecordInfo(RecordInfo recordInfo, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<TypeInfo, TResult> visitor)
        {
            var descriptor = Record.GetDescriptor(recordInfo.AvroFullName);
            if (!navigatedNamedTypes.Add(descriptor)) // Short-circuit if already navigated.
            {
                var r = visitor.VisitTypeName(descriptor, context);
                return (descriptor, r);
            }

            var result = visitor.VisitRecord(recordInfo, descriptor, context);

            var fieldNames = new List<string>();
            var fieldValueDescriptors = new List<string>();
            var fieldValueResults = new List<TResult>();
            for (int i = 0; i < recordInfo.FieldNames.Count; i++)
            {
                var (fieldValueDescriptor, fieldValueResult) = Navigate(recordInfo.FieldTypeInfos[i], new NavigationContext(SchemaName.Create(recordInfo.AvroFullName), recordInfo.FieldNames[i]), navigatedNamedTypes, visitor);
                fieldNames.Add(recordInfo.AvroFieldNames[i]);
                fieldValueDescriptors.Add(fieldValueDescriptor);
                fieldValueResults.Add(fieldValueResult);
            }

            result = visitor.VisitRecordFields(recordInfo, descriptor, result, fieldNames, fieldValueDescriptors, fieldValueResults, context);

            return (descriptor, result);
        }

        private (string, TResult) NavigateEnumInfo(EnumInfo enumInfo, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<TypeInfo, TResult> visitor)
        {
            var descriptor = Enum.GetDescriptor(enumInfo.AvroFullName);
            if (!navigatedNamedTypes.Add(descriptor)) // Short-circuit if already navigated.
            {
                var r = visitor.VisitTypeName(descriptor, context);
                return (descriptor, r);
            }

            var result = visitor.VisitEnum(enumInfo, descriptor, enumInfo.Symbols, context);
            return (descriptor, result);
        }

        private (string, TResult) NavigateFixedInfo(FixedInfo fixedInfo, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<TypeInfo, TResult> visitor)
        {
            var descriptor = Fixed.GetDescriptor(fixedInfo.AvroFullName);
            if (!navigatedNamedTypes.Add(descriptor)) // Short-circuit if already navigated.
            {
                var r = visitor.VisitTypeName(descriptor, context);
                return (descriptor, r);
            }

            var result = visitor.VisitFixed(fixedInfo, descriptor, fixedInfo.Size, context);
            return (descriptor, result);
        }

        private (string, TResult) NavigateArrayInfo(ArrayInfo arrayInfo, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<TypeInfo, TResult> visitor)
        {
            var (itemsDescriptor, itemsResult) = Navigate(arrayInfo.ElementTypeInfo, context, navigatedNamedTypes, visitor);
            var descriptor = Array.GetDescriptor(itemsDescriptor);
            var result = visitor.VisitArray(arrayInfo, descriptor, itemsDescriptor, itemsResult, context);

            return (descriptor, result);
        }

        private (string, TResult) NavigateMapInfo(MapInfo mapInfo, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<TypeInfo, TResult> visitor)
        {
            var (valuesDescriptor, valuesResult) = Navigate(mapInfo.ElementTypeInfo, context, navigatedNamedTypes, visitor);
            var descriptor = Map.GetDescriptor(valuesDescriptor);
            var result = visitor.VisitMap(mapInfo, descriptor, valuesDescriptor, valuesResult, context);

            return (descriptor, result);
        }

        private (string, TResult) NavigateNullableInfo(NullableInfo nullableInfo, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<TypeInfo, TResult> visitor)
        {
            var (nullDescriptor, nullResult) = Navigate(nullableInfo.NullTypeInfo, context, navigatedNamedTypes, visitor);
            var (valueDescriptor, valueResult) = Navigate(nullableInfo.ValueTypeInfo, context, navigatedNamedTypes, visitor);

            var descriptor = Nullable.GetDescriptor(nullableInfo.NullFirst, valueDescriptor);
            var result = visitor.VisitNullable(nullableInfo, descriptor, nullableInfo.NullFirst, valueDescriptor, valueResult, context);
            return (descriptor, result);
        }

        private (string, TResult) NavigateChoiceInfo(ChoiceInfo choiceInfo, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<TypeInfo, TResult> visitor)
        {
            var unionValueDescriptors = new List<string>();
            var unionValueResults = new List<TResult>();
            foreach (var t in choiceInfo.ChoiceTypeInfos)
            {
                var (unionValueDescriptor, unionValueResult) = Navigate(t, context, navigatedNamedTypes, visitor);
                unionValueDescriptors.Add(unionValueDescriptor);
                unionValueResults.Add(unionValueResult);
            }

            var descriptor = Choice.GetDescriptor(unionValueDescriptors);
            var result = visitor.VisitChoice(choiceInfo, descriptor, unionValueDescriptors, unionValueResults, context);
            return (descriptor, result);
        }

        private (string, TResult) NavigateAvroObjectInfo(AvroObjectInfo objectInfo, NavigationContext context, HashSet<string> navigatedNamedTypes, ISchemaVisitor<TypeInfo, TResult> visitor)
        {
            var descriptor = objectInfo.AvroFullName;
            if (!navigatedNamedTypes.Add(descriptor)) // Short-circuit if already navigated.
            {
                var r = visitor.VisitTypeName(descriptor, context);
                return (descriptor, r);
            }

            var result = visitor.VisitTypeName(descriptor, context);
            return (descriptor, result);
        }
    }
}
