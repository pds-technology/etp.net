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
    /// An attribute marking Avro named type classes (record and fixed) and enumerations (enum).
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum, Inherited = true, AllowMultiple = false)]
    public sealed class AvroNamedTypeAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new <see cref="AvroNamedTypeAttribute"/>.
        /// </summary>
        /// <param name="name">The type name.</param>
        public AvroNamedTypeAttribute(string name)
            : this(name, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new <see cref="AvroNamedTypeAttribute"/>.
        /// </summary>
        /// <param name="name">The type name.</param>
        /// <param name="namespace">The type namespace.</param>
        public AvroNamedTypeAttribute(string name, string @namespace)
        {
            Name = name;
            Namespace = @namespace;
        }

        /// <summary>
        /// The type name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The type namespace.
        /// </summary>
        public string Namespace { get; }

        /// <summary>
        /// The full name of the type
        /// </summary>
        public string FullName => string.IsNullOrEmpty(Namespace) ? Name : $"{Namespace}.{Name}";
    }
}
