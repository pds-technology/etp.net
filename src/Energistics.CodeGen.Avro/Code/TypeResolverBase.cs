//----------------------------------------------------------------------- 
// ETP DevKit, 1.2
//
// Copyright 2021 Energistics
// 
// Licensed under the Apache License, Version 2.0 (the "License")
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

namespace Energistics.CodeGen.Avro.Code
{
    public abstract class TypeResolverBase : ITypeResolver
    {
        public virtual bool CanResolveLogical(Type logical, string typeDescriptor, string baseTypeDescriptor, TypeInfo baseTypeResult, string logicalType, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos) => false;

        public virtual TypeInfo ResolveLogical(Type logical, string typeDescriptor, string baseTypeDescriptor, TypeInfo baseTypeResult, string logicalType, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos) => null;

        public virtual bool CanResolvePrimitive(string primitiveName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos) => false;

        public virtual TypeInfo ResolvePrimitive(string primitiveName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos) => null;

        public virtual bool CanResolveRecord(Type record, string recordName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos) => false;

        public virtual TypeInfo ResolveRecord(Type record, string recordName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos) => null;

        public virtual bool CanResolveRecordFields(Type record, string recordName, TypeInfo recordResult, List<string> fieldNames, List<string> fieldValueDescriptors, List<TypeInfo> fieldValueResults, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos) => false;

        public virtual void ResolveRecordFields(Type record, string recordName, TypeInfo recordResult, List<string> fieldNames, List<string> fieldValueDescriptors, List<TypeInfo> fieldValueResults, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos) { }

        public virtual bool CanResolveEnum(Type @enum, string enumName, IReadOnlyList<string> symbols, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos) => false;

        public virtual TypeInfo ResolveEnum(Type @enum, string enumName, IReadOnlyList<string> symbols, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos) => null;

        public virtual bool CanResolveFixed(Type @fixed, string fixedName, long size, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos) => false;

        public virtual TypeInfo ResolveFixed(Type @fixed, string fixedName, long size, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos) => null;

        public virtual bool CanResolveArray(Type array, string typeDescriptor, string itemsDescriptor, TypeInfo itemsResult, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos) => false;

        public virtual TypeInfo ResolveArray(Type array, string typeDescriptor, string itemsDescriptor, TypeInfo itemsResult, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos) => null;

        public virtual bool CanResolveMap(Type map, string typeDescriptor, string valuesDescriptor, TypeInfo valuesResult, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos) => false;

        public virtual TypeInfo ResolveMap(Type map, string typeDescriptor, string valuesDescriptor, TypeInfo valuesResult, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos) => null;

        public virtual bool CanResolveNullable(Type nullable, string typeDescriptor, bool nullFirst, string valueDescriptor, TypeInfo valueResult, string uniqueName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos) => false;

        public virtual TypeInfo ResolveNullable(Type nullable, string typeDescriptor, bool nullFirst, string valueDescriptor, TypeInfo valueResult, string uniqueName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos) => null;

        public virtual bool CanResolveChoice(Type choice, string typeDescriptor, IReadOnlyList<string> valueDescriptors, IReadOnlyList<TypeInfo> valueResults, string uniqueName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos) => false;

        public virtual TypeInfo ResolveChoice(Type choice, string typeDescriptor, IReadOnlyList<string> valueDescriptors, IReadOnlyList<TypeInfo> valueResults, string uniqueName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos) => null;
    }
}
