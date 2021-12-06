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
    /// An attribute marking Avro unions that are not just nullable types.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = true, AllowMultiple = true)]
    public sealed class AvroChoiceAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new <see cref="AvroChoiceAttribute"/>.
        /// </summary>
        /// <param name="types">The allowed types in the union, in schema order.</param>
        public AvroChoiceAttribute(Type[] types)
        {
            Types = types;
        }

        /// <summary>
        /// Initializes a new <see cref="AvroChoiceAttribute"/>.
        /// </summary>
        /// <param name="avroTypes">The allowed avro types in the union, in schema order.</param>
        /// <param name="types">The allowed .NET types in the union, in schema order.</param>
        public AvroChoiceAttribute(string[] avroTypes, Type[] types)
        {
            Types = types;
        }

        /// <summary>
        /// The allowed avro types in the union, in schema order.
        /// </summary>
        public string[] AvroTypes { get; }

        /// <summary>
        /// The allowed .NET types in the union, in schema order.
        /// </summary>
        public System.Type[] Types { get; }
    }
}
