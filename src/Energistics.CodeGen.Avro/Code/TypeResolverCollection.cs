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
using System.Collections.Generic;
using System.Linq;

namespace Energistics.CodeGen.Avro.Code
{
    public sealed class TypeResolverCollection : ITypeResolver
    {
        private List<ITypeResolver> Resolvers { get; } = new List<ITypeResolver>();

        public void AddResolver(ITypeResolver resolver) => Resolvers.Add(resolver);

        public bool CanResolveLogical(Type logical, string typeDescriptor, string baseTypeDescriptor, TypeInfo baseTypeResult, string logicalType, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
             => Resolvers.Any(r => r.CanResolveLogical(logical, typeDescriptor, baseTypeDescriptor, baseTypeResult, logicalType, context, namingOptions, uniqueNameCounters, createdTypeInfos));

        public TypeInfo ResolveLogical(Type logical, string typeDescriptor, string baseTypeDescriptor, TypeInfo baseTypeResult, string logicalType, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
             => Resolvers.FirstOrDefault(r => r.CanResolveLogical(logical, typeDescriptor, baseTypeDescriptor, baseTypeResult, logicalType, context, namingOptions, uniqueNameCounters, createdTypeInfos))?.ResolveLogical(logical, typeDescriptor, baseTypeDescriptor, baseTypeResult, logicalType, context, namingOptions, uniqueNameCounters, createdTypeInfos);

        public bool CanResolvePrimitive(string primitiveName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
             => Resolvers.Any(r => r.CanResolvePrimitive(primitiveName, context, namingOptions, uniqueNameCounters, createdTypeInfos));

        public TypeInfo ResolvePrimitive(string primitiveName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
             => Resolvers.FirstOrDefault(r => r.CanResolvePrimitive(primitiveName, context, namingOptions, uniqueNameCounters, createdTypeInfos))?.ResolvePrimitive(primitiveName, context, namingOptions, uniqueNameCounters, createdTypeInfos);

        public bool CanResolveRecord(Type record, string recordName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
             => Resolvers.Any(r => r.CanResolveRecord(record, recordName, context, namingOptions, uniqueNameCounters, createdTypeInfos));

        public TypeInfo ResolveRecord(Type record, string recordName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
             => Resolvers.FirstOrDefault(r => r.CanResolveRecord(record, recordName, context, namingOptions, uniqueNameCounters, createdTypeInfos))?.ResolveRecord(record, recordName, context, namingOptions, uniqueNameCounters, createdTypeInfos);

        public bool CanResolveRecordFields(Type record, string recordName, TypeInfo recordResult, List<string> fieldNames, List<string> fieldValueDescriptors, List<TypeInfo> fieldValueResults, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
             => Resolvers.Any(r => r.CanResolveRecordFields(record, recordName, recordResult, fieldNames, fieldValueDescriptors, fieldValueResults, context, namingOptions, uniqueNameCounters, createdTypeInfos));

        public void ResolveRecordFields(Type record, string recordName, TypeInfo recordResult, List<string> fieldNames, List<string> fieldValueDescriptors, List<TypeInfo> fieldValueResults, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
        {
            foreach (var r in Resolvers)
            {
                if (r.CanResolveRecordFields(record, recordName, recordResult, fieldNames, fieldValueDescriptors, fieldValueResults, context, namingOptions, uniqueNameCounters, createdTypeInfos))
                    r.ResolveRecordFields(record, recordName, recordResult, fieldNames, fieldValueDescriptors, fieldValueResults, context, namingOptions, uniqueNameCounters, createdTypeInfos);
            }
        }

        public bool CanResolveEnum(Type @enum, string enumName, IReadOnlyList<string> symbols, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
             => Resolvers.Any(r => r.CanResolveEnum(@enum, enumName, symbols, context, namingOptions, uniqueNameCounters, createdTypeInfos));

        public TypeInfo ResolveEnum(Type @enum, string enumName, IReadOnlyList<string> symbols, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
             => Resolvers.FirstOrDefault(r => r.CanResolveEnum(@enum, enumName, symbols, context, namingOptions, uniqueNameCounters, createdTypeInfos))?.ResolveEnum(@enum, enumName, symbols, context, namingOptions, uniqueNameCounters, createdTypeInfos);

        public bool CanResolveFixed(Type @fixed, string fixedName, long size, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
             => Resolvers.Any(r => r.CanResolveFixed(@fixed, fixedName, size, context, namingOptions, uniqueNameCounters, createdTypeInfos));

        public TypeInfo ResolveFixed(Type @fixed, string fixedName, long size, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
             => Resolvers.FirstOrDefault(r => r.CanResolveFixed(@fixed, fixedName, size, context, namingOptions, uniqueNameCounters, createdTypeInfos))?.ResolveFixed(@fixed, fixedName, size, context, namingOptions, uniqueNameCounters, createdTypeInfos);

        public bool CanResolveArray(Type array, string typeDescriptor, string itemsDescriptor, TypeInfo itemsResult, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
             => Resolvers.Any(r => r.CanResolveArray(array, typeDescriptor, itemsDescriptor, itemsResult, context, namingOptions, uniqueNameCounters, createdTypeInfos));

        public TypeInfo ResolveArray(Type array, string typeDescriptor, string itemsDescriptor, TypeInfo itemsResult, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
             => Resolvers.FirstOrDefault(r => r.CanResolveArray(array, typeDescriptor, itemsDescriptor, itemsResult, context, namingOptions, uniqueNameCounters, createdTypeInfos))?.ResolveArray(array, typeDescriptor, itemsDescriptor, itemsResult, context, namingOptions, uniqueNameCounters, createdTypeInfos);

        public bool CanResolveMap(Type map, string typeDescriptor, string valuesDescriptor, TypeInfo valuesResult, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
             => Resolvers.Any(r => r.CanResolveMap(map, typeDescriptor, valuesDescriptor, valuesResult, context, namingOptions, uniqueNameCounters, createdTypeInfos));

        public TypeInfo ResolveMap(Type map, string typeDescriptor, string valuesDescriptor, TypeInfo valuesResult, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
             => Resolvers.FirstOrDefault(r => r.CanResolveMap(map, typeDescriptor, valuesDescriptor, valuesResult, context, namingOptions, uniqueNameCounters, createdTypeInfos))?.ResolveMap(map, typeDescriptor, valuesDescriptor, valuesResult, context, namingOptions, uniqueNameCounters, createdTypeInfos);

        public bool CanResolveNullable(Type nullable, string typeDescriptor, bool nullFirst, string valueDescriptor, TypeInfo valueResult, string uniqueName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
             => Resolvers.Any(r => r.CanResolveNullable(nullable, typeDescriptor, nullFirst, valueDescriptor, valueResult, uniqueName, context, namingOptions, uniqueNameCounters, createdTypeInfos));

        public TypeInfo ResolveNullable(Type nullable, string typeDescriptor, bool nullFirst, string valueDescriptor, TypeInfo valueResult, string uniqueName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
             => Resolvers.FirstOrDefault(r => r.CanResolveNullable(nullable, typeDescriptor, nullFirst, valueDescriptor, valueResult, uniqueName, context, namingOptions, uniqueNameCounters, createdTypeInfos))?.ResolveNullable(nullable, typeDescriptor, nullFirst, valueDescriptor, valueResult, uniqueName, context, namingOptions, uniqueNameCounters, createdTypeInfos);

        public bool CanResolveChoice(Type choice, string typeDescriptor, IReadOnlyList<string> valueDescriptors, IReadOnlyList<TypeInfo> valueResults, string uniqueName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
             => Resolvers.Any(r => r.CanResolveChoice(choice, typeDescriptor, valueDescriptors, valueResults, uniqueName, context, namingOptions, uniqueNameCounters, createdTypeInfos));

        public TypeInfo ResolveChoice(Type choice, string typeDescriptor, IReadOnlyList<string> valueDescriptors, IReadOnlyList<TypeInfo> valueResults, string uniqueName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos)
             => Resolvers.FirstOrDefault(r => r.CanResolveChoice(choice, typeDescriptor, valueDescriptors, valueResults, uniqueName, context, namingOptions, uniqueNameCounters, createdTypeInfos))?.ResolveChoice(choice, typeDescriptor, valueDescriptors, valueResults, uniqueName, context, namingOptions, uniqueNameCounters, createdTypeInfos);
    }
}
