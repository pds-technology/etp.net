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

namespace Energistics.Avro.Encoding
{
    /// <summary>
    /// An interface for converting type information from Avro unions that are not just nullable types.
    /// </summary>
    public interface IChoiceTypeConverter
    {
        /// <summary>
        /// Determines if the specified union type index is valid for the union.
        /// </summary>
        /// <param name="typeIndex">The type index to check.</param>
        /// <returns><c>true</c> if the type index is valid for the union; <c>false</c> otherweise.</returns>
        bool IsValid(int typeIndex);

        /// <summary>
        /// Converts a value to its union type index.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The value's type index on success; -1 on failure.</returns>
        int ValueToTypeIndex(object value);

        /// <summary>
        /// Converts a union type index to its Avro type name.
        /// </summary>
        /// <param name="typeIndex">The union type index to convert.</param>
        /// <returns>The value's Avro type name.</returns>
        string TypeIndexToTypeName(int typeIndex);

        /// <summary>
        /// Converts a union type index to whether or not it represents a null value.
        /// </summary>
        /// <param name="typeIndex">The union type index to convert.</param>
        /// <returns>Whether or not the type index represents a null value.</returns>
        bool TypeIndexToIsNull(int typeIndex);

        /// <summary>
        /// Converts an Avro type name to its union type index.
        /// </summary>
        /// <param name="typeName">The Avro type name to convert.</param>
        /// <returns>The union type index.</returns>
        int TypeNameToTypeIndex(string typeName);
    }
}
