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

namespace Energistics.CodeGen.Avro.Code
{
    public interface ITypeResolver
    {
        bool CanResolveLogical(Type logical, string typeDescriptor, string baseTypeDescriptor, TypeInfo baseTypeResult, string logicalType, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos);

        TypeInfo ResolveLogical(Type logical, string typeDescriptor, string baseTypeDescriptor, TypeInfo baseTypeResult, string logicalType, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos);

        bool CanResolvePrimitive(string primitiveName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos);

        TypeInfo ResolvePrimitive(string primitiveName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos);

        bool CanResolveRecord(Type record, string recordName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos);

        TypeInfo ResolveRecord(Type record, string recordName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos);

        bool CanResolveRecordFields(Type record, string recordName, TypeInfo recordResult, List<string> fieldNames, List<string> fieldValueDescriptors, List<TypeInfo> fieldValueResults, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos);

        void ResolveRecordFields(Type record, string recordName, TypeInfo recordResult, List<string> fieldNames, List<string> fieldValueDescriptors, List<TypeInfo> fieldValueResults, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos);

        bool CanResolveEnum(Type @enum, string enumName, IReadOnlyList<string> symbols, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos);

        TypeInfo ResolveEnum(Type @enum, string enumName, IReadOnlyList<string> symbols, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos);

        bool CanResolveFixed(Type @fixed, string fixedName, long size, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos);

        TypeInfo ResolveFixed(Type @fixed, string fixedName, long size, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos);

        bool CanResolveArray(Type array, string typeDescriptor, string itemsDescriptor, TypeInfo itemsResult, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos);

        TypeInfo ResolveArray(Type array, string typeDescriptor, string itemsDescriptor, TypeInfo itemsResult, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos);

        bool CanResolveMap(Type map, string typeDescriptor, string valuesDescriptor, TypeInfo valuesResult, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos);

        TypeInfo ResolveMap(Type map, string typeDescriptor, string valuesDescriptor, TypeInfo valuesResult, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos);

        bool CanResolveNullable(Type nullable, string typeDescriptor, bool nullFirst, string valueDescriptor, TypeInfo valueResult, string uniqueName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos);

        TypeInfo ResolveNullable(Type nullable, string typeDescriptor, bool nullFirst, string valueDescriptor, TypeInfo valueResult, string uniqueName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos);

        bool CanResolveChoice(Type choice, string typeDescriptor, IReadOnlyList<string> valueDescriptors, IReadOnlyList<TypeInfo> valueResults, string uniqueName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos);

        TypeInfo ResolveChoice(Type choice, string typeDescriptor, IReadOnlyList<string> valueDescriptors, IReadOnlyList<TypeInfo> valueResults, string uniqueName, NavigationContext context, NamingOptions namingOptions, Dictionary<string, int> uniqueNameCounters, Dictionary<string, TypeInfo> createdTypeInfos);
    }
}
