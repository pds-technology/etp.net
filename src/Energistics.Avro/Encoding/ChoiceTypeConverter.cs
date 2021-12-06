//----------------------------------------------------------------------- 
// ETP DevKit, 1.2
//
// Copyright 2019 Energistics
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

using System.Collections.Generic;
using System.Linq;

namespace Energistics.Avro.Encoding
{
    /// <summary>
    /// A class for converting type information from Avro unions that are not just nullable types.
    /// </summary>
    public class ChoiceTypeConverter : IChoiceTypeConverter
    {
        /// <summary>
        /// Initializes a <see cref="ChoiceTypeConverter"/> instance.
        /// </summary>
        /// <param name="types">The list of .NET types in the union, in schema order.</param>
        public ChoiceTypeConverter(IEnumerable<System.Type> types)
            : this(types?.Select(t => t.GetAvroTypeName()), types)
        {
        }

        /// <summary>
        /// Initializes a <see cref="ChoiceTypeConverter"/> instance.
        /// </summary>
        /// <param name="avroTypes">The list of avro types in the union, in schema order.</param>
        /// <param name="types">The list of .NET types in the union, in schema order.</param>
        public ChoiceTypeConverter(IEnumerable<string> avroTypes, IEnumerable<System.Type> types)
        {
            if (types == null)
                throw new System.ArgumentNullException(nameof(types));
            if (!types.Any())
                throw new System.ArgumentException("No types.", nameof(types));

            Types = types.ToArray();
            AvroTypes = avroTypes?.ToArray() ?? Types.Select(t => t.GetAvroTypeName()).ToArray();
            MaxTypeIndex = AvroTypes.Length - 1;

            for (int i = 0; i < AvroTypes.Length; i++)
            {
                if (Types[i] == null)
                {
                    IsNullable = true;
                    NullTypeIndex = i;
                }
                else
                    TypeToTypeIndexMap[Types[i]] = i;

                TypeNameToTypeIndexMap[AvroTypes[i]] = i;
            }
        }

        private int MaxTypeIndex { get; }

        private System.Type[] Types { get; }

        private string[] AvroTypes { get; }
        
        private bool IsNullable { get; }
        
        private int NullTypeIndex { get; }

        private Dictionary<System.Type, int> TypeToTypeIndexMap { get; } = new Dictionary<System.Type, int>();

        private Dictionary<string, int> TypeNameToTypeIndexMap { get; } = new Dictionary<string, int>();

        /// <summary>
        /// Determines if the specified union type index is valid for the union.
        /// </summary>
        /// <param name="typeIndex">The type index to check.</param>
        /// <returns><c>true</c> if the type index is valid for the union; <c>false</c> otherweise.</returns>
        public bool IsValid(int typeIndex) => typeIndex >= 0 && typeIndex <= MaxTypeIndex;

        /// <summary>
        /// Converts a value to its union type index.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The value's type index on success; -1 on failure.</returns>
        public int ValueToTypeIndex(object value)
        {
            if (value == null)
                return IsNullable ? NullTypeIndex : -1;

            var type = value.GetType();
            if (TypeToTypeIndexMap.TryGetValue(type, out int index))
                return index;

            // Slow loop to cover interfaces / derived classes
            for (int i = 0; i < Types.Length; i++)
            {
                if (Types[i] == null)
                    continue;

                if (Types[i].IsAssignableFrom(type))
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// Converts a union type index to its Avro type name.
        /// </summary>
        /// <param name="typeIndex">The union type index to convert.</param>
        /// <returns>The value's Avro type name.</returns>
        public string TypeIndexToTypeName(int typeIndex)
        {
            if (!IsValid(typeIndex))
                throw new System.ArgumentException($"Unrecognized type index: {typeIndex}.", nameof(typeIndex));

            return AvroTypes[typeIndex];
        }

        /// <summary>
        /// Converts a union type index to whether or not it represents a null value.
        /// </summary>
        /// <param name="typeIndex">The union type index to convert.</param>
        /// <returns>Whether or not the type index represents a null value.</returns>
        public bool TypeIndexToIsNull(int typeIndex)
        {
            if (!IsValid(typeIndex))
                throw new System.ArgumentException($"Unrecognized type index: {typeIndex}.", nameof(typeIndex));

            return IsNullable && typeIndex == NullTypeIndex;
        }

        /// <summary>
        /// Converts an Avro type name to its union type index.
        /// </summary>
        /// <param name="typeName">The Avro type name to convert.</param>
        /// <returns>The union type index.</returns>
        public int TypeNameToTypeIndex(string typeName)
        {
            if (typeName == null)
                throw new System.ArgumentNullException(nameof(typeName));

            if (TypeNameToTypeIndexMap.TryGetValue(typeName, out int index))
                return index;

            throw new System.ArgumentException($"Unrecognized type name: {typeName}.", nameof(typeName));
        }
    }
}
