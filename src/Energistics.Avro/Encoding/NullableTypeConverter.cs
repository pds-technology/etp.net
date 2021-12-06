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

using System;

namespace Energistics.Avro.Encoding
{
    /// <summary>
    /// A base class for converting type information from Avro unions that are just nullable types.
    /// </summary>
    public class NullableTypeConverter : INullableTypeConverter
    {
        /// <summary>
        /// Initializes a <see cref="NullableTypeConverter"/> instance.
        /// </summary>
        /// <param name="nullFirst">Whether or not the null type is the first type index.</param>
        /// <param name="valueType">The value type.</param>
        public NullableTypeConverter(bool nullFirst, Type valueType)
            : this(nullFirst, valueType.GetAvroTypeName())
        {
        }

        /// <summary>
        /// Initializes a <see cref="NullableTypeConverter"/> instance.
        /// </summary>
        /// <param name="nullFirst">Whether or not the null type is the first type index.</param>
        /// <param name="valueAvroType">The value avro type.</param>
        public NullableTypeConverter(bool nullFirst, string valueAvroType)
        {
            ValueTypeIndex = nullFirst ? 1 : 0;
            NullTypeIndex = nullFirst ? 0 : 1;
            ValueAvroType = valueAvroType;
        }

        /// <summary>
        /// The value type index.
        /// </summary>
        protected int ValueTypeIndex { get; }

        /// <summary>
        /// The null value type index.
        /// </summary>
        protected int NullTypeIndex { get; }

        /// <summary>
        /// The non-null value Avro type.
        /// </summary>
        protected string ValueAvroType { get; }

        /// <summary>
        /// The null value Avro type.
        /// </summary>
        protected static string NullAvroType { get; } = "null";

        /// <summary>
        /// Gets the union type index depending on whether the value is null or not.
        /// </summary>
        /// <param name="isNull">Whether or not the value is null.</param>
        /// <returns>The value's union type index.</returns>
        public int IsNullToTypeIndex(bool isNull) => isNull ? NullTypeIndex : ValueTypeIndex;

        /// <summary>
        /// Gets the union type name depending on whether the value is null or not.
        /// </summary>
        /// <param name="isNull">Whether or not the value is null.</param>
        /// <returns>The type's Avro type name.</returns>
        public string IsNullToTypeName(bool isNull) => isNull ? NullAvroType : ValueAvroType;

        /// <summary>
        /// Converts a union type index to whether the value should be null or not.
        /// </summary>
        /// <param name="typeIndex">The type index to convert.</param>
        /// <returns>Whether the value should be null or not.</returns>
        public bool TypeIndexToIsNull(int typeIndex)
        {
            if (typeIndex == ValueTypeIndex)
                return false;
            else if (typeIndex == NullTypeIndex)
                return true;
            else
                throw new ArgumentException($"Unrecognized type index: {typeIndex}.", nameof(typeIndex));
        }

        /// <summary>
        /// Converts an Avro type name to whether the value should be null or not.
        /// </summary>
        /// <param name="typeName">The Avro type name to convert.</param>
        /// <returns>Whether the value should be null or not.</returns>
        public bool TypeNameToIsNull(string typeName)
        {
            if (typeName == null) throw new ArgumentNullException(nameof(typeName));

            if (typeName == ValueAvroType)
                return false;
            else if (typeName == NullAvroType)
                return true;
            else
                throw new System.ArgumentException($"Unrecognized type name: {typeName}.", nameof(typeName));
        }
    }
}
