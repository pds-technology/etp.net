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
    /// An interface for converting type information from Avro unions that are just nullable classes.
    /// </summary>
    public interface INullableTypeConverter
    {
        /// <summary>
        /// Gets the union type index depending on whether the value is null or not.
        /// </summary>
        /// <param name="isNull">Whether or not the value is null.</param>
        /// <returns>The value's union type index.</returns>
        int IsNullToTypeIndex(bool isNull);

        /// <summary>
        /// Gets the union type name depending on whether the value is null or not.
        /// </summary>
        /// <param name="isNull">Whether or not the value is null.</param>
        /// <returns>The type's Avro type name.</returns>
        string IsNullToTypeName(bool isNull);

        /// <summary>
        /// Converts a union type index to whether the value should be null or not.
        /// </summary>
        /// <param name="typeIndex">The type index to convert.</param>
        /// <returns>Whether the value should be null or not.</returns>
        bool TypeIndexToIsNull(int typeIndex);

        /// <summary>
        /// Converts an Avro type name to whether the value should be null or not.
        /// </summary>
        /// <param name="typeName">The Avro type name to convert.</param>
        /// <returns>Whether the value should be null or not.</returns>
        bool TypeNameToIsNull(string typeName);
    }
}
