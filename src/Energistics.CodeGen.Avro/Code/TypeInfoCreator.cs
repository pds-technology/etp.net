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
using Energistics.Avro.Schemas;
using Energistics.Avro.Schemas.Navigation;
using Energistics.CodeGen.Avro.Code.TypeInfos;
using System.Linq;

namespace Energistics.CodeGen.Avro.Code
{
    public sealed class TypeInfoCreator : ISchemaVisitor<Type, TypeInfo>
    {
        public TypeInfoCreator(Dictionary<string, TypeInfo> existingTypes, Dictionary<string, int> uniqueNameCounters, ITypeResolver typeResolver, NamingOptions namingOptions)
        {
            CreatedTypeInfos = existingTypes;
            UniqueNameCounters = uniqueNameCounters;
            TypeResolver = typeResolver;
            NamingOptions = namingOptions;
        }

        public ITypeResolver TypeResolver { get; }

        public Dictionary<string, TypeInfo> CreatedTypeInfos { get; }

        private Dictionary<string, int> UniqueNameCounters { get; }

        public NamingOptions NamingOptions { get; }

        public TypeInfo VisitTypeName(string typeDescriptor, NavigationContext context)
        {
            if (!CreatedTypeInfos.TryGetValue(typeDescriptor, out var typeInfo))
                throw new System.InvalidOperationException($"TypeInfo '{typeInfo}' not defined.");

            return typeInfo;
        }

        public TypeInfo VisitLogical(Type logical, string typeDescriptor, string baseTypeDescriptor, TypeInfo baseTypeResult, string logicalType, NavigationContext context)
        {
            if (CreatedTypeInfos.TryGetValue(typeDescriptor, out var typeInfo))
                return typeInfo;

            if (!TypeResolver.CanResolveLogical(logical, typeDescriptor, baseTypeDescriptor, baseTypeResult, logicalType, context, NamingOptions, UniqueNameCounters, CreatedTypeInfos))
                return baseTypeResult;

            typeInfo = TypeResolver.ResolveLogical(logical, typeDescriptor, baseTypeDescriptor, baseTypeResult, logicalType, context, NamingOptions, UniqueNameCounters, CreatedTypeInfos);
            CreatedTypeInfos[typeDescriptor] = typeInfo;
            return typeInfo;
        }

        public TypeInfo VisitPrimitive(string primitiveName, NavigationContext context)
        {
            if (CreatedTypeInfos.TryGetValue(primitiveName, out var typeInfo))
                return typeInfo;

            if (TypeResolver.CanResolvePrimitive(primitiveName, context, NamingOptions, UniqueNameCounters, CreatedTypeInfos))
                typeInfo = TypeResolver.ResolvePrimitive(primitiveName, context, NamingOptions, UniqueNameCounters, CreatedTypeInfos);
            else
                typeInfo = PrimitiveInfo.GetPrimitiveInfo(primitiveName);
            CreatedTypeInfos[primitiveName] = typeInfo;
            return typeInfo;
        }

        public TypeInfo VisitRecord(Type record, string recordName, NavigationContext context)
        {
            if (CreatedTypeInfos.TryGetValue(recordName, out var typeInfo))
                return typeInfo;

            if (TypeResolver.CanResolveRecord(record, recordName, context, NamingOptions, UniqueNameCounters, CreatedTypeInfos))
                typeInfo = TypeResolver.ResolveRecord(record, recordName, context, NamingOptions, UniqueNameCounters, CreatedTypeInfos);
            else
                typeInfo = new RecordInfo(record as Record, record.Name, record.Namespace, record.GetClassName(NamingOptions), record.GetNamespace(NamingOptions));

            CreatedTypeInfos[recordName] = typeInfo;

            return typeInfo;
        }

        public TypeInfo VisitRecordFields(Type record, string recordName, TypeInfo recordResult, IReadOnlyList<string> fieldNames, IReadOnlyList<string> fieldValueDescriptors, IReadOnlyList<TypeInfo> fieldValueResults, NavigationContext context)
        {
            var fieldNamesList = fieldNames.ToList();
            var fieldValueDescriptorsList = fieldValueDescriptors.ToList();
            var fieldValueResultsList = fieldValueResults.ToList();

            if (TypeResolver.CanResolveRecordFields(record, recordName, recordResult, fieldNamesList, fieldValueDescriptorsList, fieldValueResultsList, context, NamingOptions, UniqueNameCounters, CreatedTypeInfos))
                TypeResolver.ResolveRecordFields(record, recordName, recordResult, fieldNamesList, fieldValueDescriptorsList, fieldValueResultsList, context, NamingOptions, UniqueNameCounters, CreatedTypeInfos);

            (recordResult as RecordInfo).SetFields(fieldNamesList, fieldNames.Select(n => record.GetFieldName(n, NamingOptions)), fieldValueResultsList);

            return recordResult;
        }

        public TypeInfo VisitEnum(Type @enum, string enumName, IReadOnlyList<string> symbols, NavigationContext context)
        {
            if (CreatedTypeInfos.TryGetValue(enumName, out var typeInfo))
                return typeInfo;

            if (TypeResolver.CanResolveEnum(@enum, enumName, symbols, context, NamingOptions, UniqueNameCounters, CreatedTypeInfos))
                typeInfo = TypeResolver.ResolveEnum(@enum, enumName, symbols, context, NamingOptions, UniqueNameCounters, CreatedTypeInfos);
            else
                typeInfo = new EnumInfo(@enum as Enum, @enum.Name, @enum.Namespace, @enum.GetClassName(NamingOptions), @enum.GetNamespace(NamingOptions), symbols);
            CreatedTypeInfos[enumName] = typeInfo;
            return typeInfo;
        }

        public TypeInfo VisitFixed(Type @fixed, string fixedName, long size, NavigationContext context)
        {
            if (CreatedTypeInfos.TryGetValue(fixedName, out var typeInfo))
                return typeInfo;

            if (TypeResolver.CanResolveFixed(@fixed, fixedName, size, context, NamingOptions, UniqueNameCounters, CreatedTypeInfos))
                typeInfo = TypeResolver.ResolveFixed(@fixed, fixedName, size, context, NamingOptions, UniqueNameCounters, CreatedTypeInfos);
            else
                typeInfo = new FixedInfo(@fixed as Fixed, @fixed.Name, @fixed.Namespace, @fixed.GetClassName(NamingOptions), @fixed.GetNamespace(NamingOptions), size);
            CreatedTypeInfos[fixedName] = typeInfo;
            return typeInfo;
        }

        public TypeInfo VisitArray(Type array, string typeDescriptor, string itemsDescriptor, TypeInfo itemsResult, NavigationContext context)
        {
            if (CreatedTypeInfos.TryGetValue(typeDescriptor, out var typeInfo))
                return typeInfo;

            if (TypeResolver.CanResolveArray(array, typeDescriptor, itemsDescriptor, itemsResult, context, NamingOptions, UniqueNameCounters, CreatedTypeInfos))
                typeInfo = TypeResolver.ResolveArray(array, typeDescriptor, itemsDescriptor, itemsResult, context, NamingOptions, UniqueNameCounters, CreatedTypeInfos);
            else
                typeInfo = new ArrayInfo(array as Array, itemsResult);
            CreatedTypeInfos[typeDescriptor] = typeInfo;
            return typeInfo;
        }

        public TypeInfo VisitMap(Type map, string typeDescriptor, string valuesDescriptor, TypeInfo valuesResult, NavigationContext context)
        {
            if (CreatedTypeInfos.TryGetValue(typeDescriptor, out var typeInfo))
                return typeInfo;

            if (TypeResolver.CanResolveMap(map, typeDescriptor, valuesDescriptor, valuesResult, context, NamingOptions, UniqueNameCounters, CreatedTypeInfos))
                typeInfo = TypeResolver.ResolveMap(map, typeDescriptor, valuesDescriptor, valuesResult, context, NamingOptions, UniqueNameCounters, CreatedTypeInfos);
            else
                typeInfo = new MapInfo(map as Map, valuesResult);
            CreatedTypeInfos[typeDescriptor] = typeInfo;
            return typeInfo;
        }

        public TypeInfo VisitNullable(Type nullable, string typeDescriptor, bool nullFirst, string valueDescriptor, TypeInfo valueResult, NavigationContext context)
        {
            if (CreatedTypeInfos.TryGetValue(typeDescriptor, out var typeInfo))
                return typeInfo;

            var uniqueName = UniqueNameCounters.GetUniqueName(NullableInfo.CreateUniqueNamePrefix(valueResult, nullFirst));
            if (TypeResolver.CanResolveNullable(nullable, typeDescriptor, nullFirst, valueDescriptor, valueResult, uniqueName, context, NamingOptions, UniqueNameCounters, CreatedTypeInfos))
                typeInfo = TypeResolver.ResolveNullable(nullable, typeDescriptor, nullFirst, valueDescriptor, valueResult, uniqueName, context, NamingOptions, UniqueNameCounters, CreatedTypeInfos);
            else
                typeInfo = new NullableInfo(nullable as Nullable, valueResult, nullFirst, uniqueName);

            CreatedTypeInfos[typeDescriptor] = typeInfo;
            return typeInfo;
        }

        public TypeInfo VisitChoice(Type choice, string typeDescriptor, IReadOnlyList<string> valueDescriptors, IReadOnlyList<TypeInfo> valueResults, NavigationContext context)
        {
            if (CreatedTypeInfos.TryGetValue(typeDescriptor, out var typeInfo))
                return typeInfo;

            var uniqueName = UniqueNameCounters.GetUniqueName(ChoiceInfo.CreateUniqueNamePrefix(valueResults));
            if (TypeResolver.CanResolveChoice(choice, typeDescriptor, valueDescriptors, valueResults, uniqueName, context, NamingOptions, UniqueNameCounters, CreatedTypeInfos))
                typeInfo = TypeResolver.ResolveChoice(choice, typeDescriptor, valueDescriptors, valueResults, uniqueName, context, NamingOptions, UniqueNameCounters, CreatedTypeInfos);
            else
                typeInfo = new ChoiceInfo(choice as Choice, uniqueName, valueResults);
            CreatedTypeInfos[typeDescriptor] = typeInfo;
            return typeInfo;
        }
    }
}
