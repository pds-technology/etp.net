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
    /// An attribute marking Avro record fields.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public sealed class AvroRecordFieldAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new <see cref="AvroRecordFieldAttribute"/>.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        public AvroRecordFieldAttribute(string fieldName)
        {
            FieldName = fieldName;
        }

        /// <summary>
        /// The field name.
        /// </summary>
        public string FieldName { get; }
    }
}
