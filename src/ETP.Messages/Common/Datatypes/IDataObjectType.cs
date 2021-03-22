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

namespace Energistics.Etp.Common.Datatypes
{
    public interface IDataObjectType
    {
        /// <summary>
        /// Returns true if a valid content type was specified.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        bool IsValid { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is a base content type.
        /// Base types are derived from URIs that do not information about an object.
        /// They only provide information about a family and version.
        /// </summary>
        /// <value><c>true</c> if this instance is a base content type; otherwise, <c>false</c>.</value>
        bool IsBaseType { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is a wildcard content type.
        /// </summary>
        /// <value><c>true</c> if this instance is a wildcard content type; otherwise, <c>false</c>.</value>
        bool IsWildcard { get; }

        /// <summary>
        /// Gets a consistent, version-indepentent key for this data object type.
        /// </summary>
        string Key { get; }

        /// <summary>
        /// Gets the ML family name.
        /// </summary>
        /// <value>The ML family.</value>
        string Family { get; }

        /// <summary>
        /// Gets the version.
        /// </summary>
        /// <value>The version.</value>
        string Version { get; }

        /// <summary>
        /// Gets the type of the object.
        /// </summary>
        /// <value>The type of the object.</value>
        string ObjectType { get; }

        /// <summary>
        /// Gets this as an <see cref="EtpDataObjectType"/> instance.
        /// </summary>
        EtpDataObjectType DataObjectType { get; }

        /// <summary>
        /// Gets this as an <see cref="EtpContentType"/> instance.
        /// </summary>
        EtpContentType ContentType { get; }
    }
}