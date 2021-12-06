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

using Energistics.Avro.Schemas.Navigation.Visitors;
using Energistics.Json;
using System.Collections.Generic;
using System.Linq;

namespace Energistics.Avro.Schemas.Navigation
{
    public static class NavigationExtensions
    {
        private static ISchemaNavigator<Token, TResult> GetNavigator<TResult>(this Token token) => new JsonNavigator<TResult>();

        private static ISchemaNavigator<Type, TResult> GetNavigator<TResult>(this Type type) => new TypeNavigator<TResult>();

        public static string GetDescriptor(this Type type) => type.GetNavigator<string>().GetDescriptor(type);

        public static string GetDescriptor(this Token token) => token.GetNavigator<string>().GetDescriptor(token);

        public static string GetDescriptor<TSchema>(this ISchemaNavigator<TSchema, string> navigator, TSchema schema)
        {
            return navigator.Navigate(schema, new DescriptorCreator<TSchema>());
        }

        public static string GetCanonicalSchema(this Type type) => type.GetNavigator<string>().GetCanonicalSchema(type);

        public static string GetCanonicalSchema(this Token token) => token.GetNavigator<string>().GetCanonicalSchema(token);

        public static string GetCanonicalSchema<TSchema>(this ISchemaNavigator<TSchema, string> navigator, TSchema schema)
        {
            return navigator.Navigate(schema, new CanonicalSchemaCreator<TSchema>());
        }

        public static IEnumerable<string> GetNamedTypeDependencies(this Type type) => type.GetNavigator<IEnumerable<string>>().GetNamedTypeDependencies(type, type.FullName);

        public static IEnumerable<string> GetNamedTypeDependencies(this Token token) => token.GetNavigator<IEnumerable<string>>().GetNamedTypeDependencies(token, SchemaName.Create(token).FullName);

        public static IEnumerable<string> GetNamedTypeDependencies<TSchema>(this ISchemaNavigator<TSchema, IEnumerable<string>> navigator, TSchema schema, string excludedName)
        {
            return navigator.Navigate(schema, new NamedTypeDependencyFinder<TSchema>()).Distinct().Except(new string[] { excludedName }).OrderBy(s => s);
        }

        public static IEnumerable<string> GetAllDependencies(this Type type) => type.GetNavigator<IEnumerable<string>>().GetAllDependencies(type, type.GetDescriptor());

        public static IEnumerable<string> GetAllDependencies(this Token token) => token.GetNavigator<IEnumerable<string>>().GetAllDependencies(token, token.GetDescriptor());

        public static IEnumerable<string> GetAllDependencies<TSchema>(this ISchemaNavigator<TSchema, IEnumerable<string>> navigator, TSchema schema, string excludedDescriptor)
        {
            return navigator.Navigate(schema, new DescriptorDependencyFinder<TSchema>()).Distinct().Except(new string[] { excludedDescriptor }).OrderBy(s => s);
        }

        public static Dictionary<string, Type> CreateTypes(this Token token) => token.GetNavigator<Type>().CreateTypes(token, null, new Dictionary<string, Type>());

        public static Dictionary<string, Type> CreateTypes(this Token token, SchemaName enclosingName) => token.GetNavigator<Type>().CreateTypes(token, enclosingName, new Dictionary<string, Type>());

        public static Dictionary<string, Type> CreateTypes(this Token token, Dictionary<string, Type> existingTypes) => token.GetNavigator<Type>().CreateTypes(token, null, existingTypes);

        public static Dictionary<string, Type> CreateTypes(this Token token, SchemaName enclosingName, Dictionary<string, Type> existingTypes) => token.GetNavigator<Type>().CreateTypes(token, enclosingName, existingTypes);

        public static Dictionary<string, Type> CreateTypes(this ISchemaNavigator<Token, Type> navigator, Token token, SchemaName enclosingName, Dictionary<string, Type> existingTypes)
        {
            var typeCreator = new TypeCreator(existingTypes);
            navigator.Navigate(token, enclosingName, typeCreator);
            return typeCreator.Types;
        }
    }
}
