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
    public static class NavigationExtensions
    {
        private static ISchemaNavigator<Type, TResult> GetNavigator<TResult>(this Type type) => new TypeNavigator<TResult>();

        private static ISchemaNavigator<TypeInfo, TResult> GetNavigator<TResult>(this TypeInfo typeInfo) => new TypeInfoNavigator<TResult>();

        public static Dictionary<string, TypeInfo> CreateTypeInfos(this Type type, NamingOptions namingOptions, ITypeResolver typeResolver, Dictionary<string, TypeInfo> existingTypeInfos, Dictionary<string, int> uniqueNameCounters) => type.GetNavigator<TypeInfo>().CreateTypeInfos(type, namingOptions, typeResolver, existingTypeInfos, uniqueNameCounters);

        private static Dictionary<string, TypeInfo> CreateTypeInfos(this ISchemaNavigator<Type, TypeInfo> navigator, Type type, NamingOptions namingOptions, ITypeResolver typeResolver, Dictionary<string, TypeInfo> existingTypeInfos, Dictionary<string, int> uniqueNameCounters)
        {
            var typeInfoCreator = new TypeInfoCreator(existingTypeInfos, uniqueNameCounters, typeResolver, namingOptions);
            navigator.Navigate(type, typeInfoCreator);
            return typeInfoCreator.CreatedTypeInfos;
        }

        public static string GetDescriptor(this TypeInfo typeInfo) => typeInfo.GetNavigator<string>().GetDescriptor(typeInfo);

        public static string GetCanonicalSchema(this TypeInfo typeInfo) => typeInfo.GetNavigator<string>().GetCanonicalSchema(typeInfo);

        public static IEnumerable<string> GetNamedTypeDependencies(this TypeInfo typeInfo) => typeInfo.GetNavigator<IEnumerable<string>>().GetNamedTypeDependencies(typeInfo, typeInfo.AvroFullName);

        public static IEnumerable<string> GetAllDependencies(this TypeInfo typeInfo) => typeInfo.GetNavigator<IEnumerable<string>>().GetAllDependencies(typeInfo, typeInfo.GetDescriptor());
    }
}
