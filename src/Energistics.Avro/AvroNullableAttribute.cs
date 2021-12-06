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

namespace Energistics.Avro
{
    /// <summary>
    /// An attribute marking Avro unions that are just nullable types.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = true, AllowMultiple = true)]
    public sealed class AvroNullableAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new <see cref="AvroNullableAttribute"/> with <see cref="NullFirst"/> set to <c>true</c>.
        /// </summary>
        /// <param name="valueType">The value type.</param>
        public AvroNullableAttribute(bool nullFirst, Type valueType)
            : this(nullFirst, valueType.GetAvroTypeName())
        {
        }

        /// <summary>
        /// Initializes a new <see cref="AvroNullableAttribute"/>.
        /// </summary>
        /// <param name="nullFirst"></param>
        public AvroNullableAttribute(bool nullFirst, string valueAvroType)
        {
            NullFirst = nullFirst;
            ValueAvroType = valueAvroType;
        }

        /// <summary>
        /// Indicates whether the null value is the first or second value in the nullable union.
        /// </summary>
        public bool NullFirst { get; }

        /// <summary>
        /// The non-null value Avro type.
        /// </summary>
        public string ValueAvroType { get; }
    }
}
