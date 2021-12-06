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
// 
//-----------------------------------------------------------------------
// This code has been automatically generated.
// Changes will be lost the next time it is regenerated.
//-----------------------------------------------------------------------

using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace Energistics.Avro
{
    /// <summary>
    /// Extension methods for reflection.
    /// </summary>
    public static class ReflectionExtensions
    {
        /// <summary>
        /// Gets the full Avro type name for the specified type.
        /// For primitive types, the Avro primitive typeis returned.
        /// For other types, the name will be defined by, in order of precedence,
        /// an <see cref="AvroNamedTypeAttribute"/>, a <see cref="DataContractAttribute"/>, or the type's full name.
        /// </summary>
        /// <param name="type">The type to get the full Avro type name for.</param>
        /// <returns>The full Avro type name for the type.</returns>
        public static string GetAvroTypeName(this Type type)
        {
            if (type == null)
                return "null";
            else if (type == typeof(int))
                return "int";
            else if (type == typeof(long))
                return "long";
            else if (type == typeof(float))
                return "float";
            else if (type == typeof(double))
                return "double";
            else if (type == typeof(string))
                return "string";
            else if (type == typeof(byte[]))
                return "bytes";
            else
            {
                var avroType = type.GetCustomAttribute<AvroNamedTypeAttribute>();
                if (avroType != null)
                    return avroType.FullName;

                var dataContract = type.GetCustomAttribute<DataContractAttribute>();
                if (dataContract != null)
                {
                    if (string.IsNullOrEmpty(dataContract.Namespace))
                        return dataContract.Name;
                    else
                        return $"{dataContract.Namespace}.{dataContract.Name}";
                }
 
                return type.FullName;
            }
        }

        /// <summary>
        /// Gets the Avro enum symbol for an enum value.
        /// </summary>
        /// <param name="fieldInfo">The <see cref="FieldInfo"/> representing the enum value.</param>
        /// <returns>The enum's avro symobl.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string GetAvroEnumSymbol(this FieldInfo fieldInfo)
        {
            if (fieldInfo == null)
                throw new ArgumentNullException(nameof(fieldInfo));

            var @enum = fieldInfo.GetCustomAttribute<AvroEnumSymbolAttribute>();
            if (@enum == null)
                return fieldInfo.Name;
            else
                return @enum.Symbol;
        }

        internal static TAttribute GetCustomAttribute<TAttribute>(this MemberInfo memberInfo)
        {
            var attributes = memberInfo.GetCustomAttributes(typeof(TAttribute), true);
            return attributes.Cast<TAttribute>().FirstOrDefault();
        }
    }
}
