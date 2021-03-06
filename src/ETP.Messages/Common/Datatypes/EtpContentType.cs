﻿//----------------------------------------------------------------------- 
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
using System.Linq;
using System.Text.RegularExpressions;

namespace Energistics.Etp.Common.Datatypes
{
    /// <summary>
    /// Represents a content type supported by the Energistics Transfer Protocol (ETP).
    /// </summary>
    public sealed class EtpContentType : IDataObjectType
    {
        private static readonly Regex Pattern = new Regex(@"^application/x\-(witsml|resqml|prodml|eml)\+(xml|json);version=([0-9.]+)((;)?|(;type=((obj_|cs_|part_)?(\w+))(;)?)?)$", RegexOptions.CultureInvariant | RegexOptions.Compiled);
        private static readonly string[] PartSchemas = { "TrajectoryStation", "MudlogReportInterval", "WellboreGeometrySection" };
        private const string BaseFormat = "application/x-{0}+{1};version={2}";
        private const string TypeFormat = ";type={0}";
        private readonly string _contentType;

        /// <summary>
        /// Content type for a dataspace.
        /// </summary>
        public const string DataspaceContentType = "application/x-etp;version=1.1;type=dataspace";

        /// <summary>
        /// Initializes a new instance of the <see cref="EtpContentType"/> struct.
        /// </summary>
        /// <param name="contentType">Type of the content.</param>
        public EtpContentType(string contentType)
        {
            var match = Pattern.Match(contentType);

            _contentType = contentType;
            IsValid = match.Success;

            Family = GetValue(match, 1);
            Format = GetValue(match, 2);
            Version = GetValue(match, 3);
            ObjectType = FormatObjectType(GetValue(match, 9), Version);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EtpContentType"/> struct.
        /// </summary>
        /// <param name="family">The ML family name.</param>
        /// <param name="version">The version.</param>
        public EtpContentType(string family, string version) : this(family, version, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EtpContentType" /> struct.
        /// </summary>
        /// <param name="family">The ML family name.</param>
        /// <param name="version">The version.</param>
        /// <param name="objectType">The object type.</param>
        /// <param name="format">The format.</param>
        public EtpContentType(string family, string version, string objectType, string format = Formats.Xml)
        {
            IsValid = true;

            Family = family;
            Format = format;
            Version = version;
            ObjectType = FormatObjectType(objectType, Version);

            _contentType = string.Format(BaseFormat, family, format, version) + FormatType(ObjectType, Version);
        }

        /// <summary>
        /// Returns this as a data object type string.
        /// </summary>
        EtpDataObjectType IDataObjectType.DataObjectType
        {
            get { return ToDataObjectType(); }
        }

        /// <summary>
        /// Returns this as a content type string.
        /// </summary>
        EtpContentType IDataObjectType.ContentType
        {
            get { return this; }
        }

        /// <summary>
        /// Gets a consistent, version-indepentent key for this data object type.
        /// </summary>
        public string Key => ToDataObjectType().Key;

        /// <summary>
        /// Gets the ML family name.
        /// </summary>
        /// <value>The ML family.</value>
        public string Family { get; }

        /// <summary>
        /// Gets the format.
        /// </summary>
        /// <value>The format.</value>
        public string Format { get; }

        /// <summary>
        /// Gets the version.
        /// </summary>
        /// <value>The version.</value>
        public string Version { get; }

        /// <summary>
        /// Gets the type of the object.
        /// </summary>
        /// <value>The type of the object.</value>
        public string ObjectType { get; }

        /// <summary>
        /// Returns true if a valid content type was specified.
        /// </summary>
        /// <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        public bool IsValid { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is a base content type.
        /// Base types are derived from URIs that do not information about an object.
        /// They only provide information about a family and version.
        /// </summary>
        /// <value><c>true</c> if this instance is a base content type; otherwise, <c>false</c>.</value>
        public bool IsBaseType
        {
            get { return string.IsNullOrWhiteSpace(ObjectType); }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is a wildcard content type.
        /// </summary>
        /// <value><c>true</c> if this instance is a wildcard content type; otherwise, <c>false</c>.</value>
        public bool IsWildcard
        {
            get { return ObjectType == "*"; }
        }

        /// <summary>
        /// Determines whether this instance is related to the specified <see cref="EtpContentType"/>.
        /// </summary>
        /// <param name="other">The other content type.</param>
        /// <returns>
        ///   <c>true</c> if the two <see cref="EtpContentType"/> instances share the same family and
        ///   version; otherwise, <c>false</c>.
        /// </returns>
        public bool IsRelatedTo(EtpContentType other)
        {
            return string.Equals(Family, other.Family, StringComparison.OrdinalIgnoreCase)
                && string.Equals(Version, other.Version, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Initializes a new instance of <see cref="EtpContentType"/> based on the
        /// current ML family name, version number and the specified object type.
        /// </summary>
        /// <param name="objectType">The object type.</param>
        /// <returns>The new <see cref="EtpContentType"/> instance.</returns>
        public EtpContentType For(string objectType)
        {
            return new EtpContentType(Family, Version, objectType);
        }


        /// <summary>
        /// Initializes a new instance of <see cref="EtpDataObjectType"/> based on the
        /// current ML family name, version number and the specified object type.
        /// </summary>
        /// <returns>The new <see cref="EtpDataObjectType"/> instance.</returns>
        public EtpDataObjectType ToDataObjectType()
        {
            return new EtpDataObjectType(Family, Version, ObjectType);
        }

        /// <summary>
        /// Initializes a new instance of <see cref="EtpContentType"/> based on the
        /// current ML family name, version number, object type and XML format.
        /// </summary>
        /// <returns>The new <see cref="EtpContentType"/> instance.</returns>
        public EtpContentType AsXml()
        {
            return new EtpContentType(Family, Version, ObjectType);
        }

        /// <summary>
        /// Initializes a new instance of <see cref="EtpContentType"/> based on the
        /// current ML family name, version number, object type and XML format.
        /// </summary>
        /// <returns>The new <see cref="EtpContentType"/> instance.</returns>
        public EtpContentType AsJson()
        {
            return new EtpContentType(Family, Version, ObjectType, Formats.Json);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return _contentType;
        }

        #region Equality and Inequality

        /// <summary>
        /// Determines whether the specified <see cref="EtpContentType" />, is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="EtpContentType" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="EtpContentType" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(EtpContentType other)
        {
            if (other == null) return false;
            var contentType = ToString() ?? string.Empty;
            var otherContentType = other.ToString() ?? string.Empty;

            return string.Equals(contentType, otherContentType, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj) => Equals(obj as EtpDataObjectType);

        /// <summary>
        /// Determines whether two <see cref="EtpContentType" />s are equivalent.
        /// </summary>
        /// <param name="lhs">The <see cref="EtpContentType" /> on the left-hand side of the operator.</param>
        /// <param name="rhs">The <see cref="EtpContentType" /> on the right-hand side of the operator.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="EtpContentType" /> instances are equivalent; otherwise, <c>false</c>.
        /// </returns>
        public static bool operator ==(EtpContentType lhs, EtpContentType rhs) => Equals(lhs, rhs);

        /// <summary>
        /// Determines whether two <see cref="EtpContentType" />s are not equivalent.
        /// </summary>
        /// <param name="lhs">The <see cref="EtpContentType" /> on the left-hand side of the operator.</param>
        /// <param name="rhs">The <see cref="EtpContentType" /> on the right-hand side of the operator.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="EtpContentType" /> instances are not equivalent; otherwise, <c>false</c>.
        /// </returns>
        public static bool operator !=(EtpContentType lhs, EtpContentType rhs) => !Equals(lhs, rhs);

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return _contentType.ToLowerInvariant().GetHashCode();
        }

        #endregion

        /// <summary>
        /// Performs an implicit conversion from <see cref="EtpContentType"/> to <see cref="System.String"/>.
        /// </summary>
        /// <param name="contentType">Type of the content.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator string(EtpContentType contentType)
        {
            return contentType.ToString();
        }

        /// <summary>
        /// Formats the object type based on the specified object type name.
        /// </summary>
        /// <param name="objectType">The object type.</param>
        /// <param name="version">The data schema version.</param>
        /// <returns>The formatted object type.</returns>
        public static string FormatObjectType(string objectType, string version)
        {
            if (string.IsNullOrWhiteSpace(objectType))
                return string.Empty;

            if (objectType.StartsWith("part_"))
                return objectType;

            var index = objectType.IndexOf('_');

            if (index > -1)
            {
                objectType = objectType.Substring(index + 1);
            }

            System.Version ver;

            // Capitalize object type when version >= 2.0
            objectType = (TryParseVersion(version, out ver) && ver.Major >= 2
                       ? objectType.Substring(0, 1).ToUpperInvariant()
                       : objectType.Substring(0, 1).ToLowerInvariant())
                       + objectType.Substring(1);

            return objectType;
        }

        /// <summary>
        /// Gets the value contained within the specified match at the specified index.
        /// </summary>
        /// <param name="match">The match.</param>
        /// <param name="index">The index.</param>
        /// <returns>The matched value found at the specified index.</returns>
        private static string GetValue(Match match, int index)
        {
            return match.Success && match.Groups.Count > index
                ? match.Groups[index].Value
                : null;
        }

        /// <summary>
        /// Formats the specified schema type for appending to a content type.
        /// </summary>
        /// <param name="schemaType">Type of the object.</param>
        /// <param name="version">The data schema version.</param>
        /// <returns>The formatted content type segment.</returns>
        private static string FormatType(string schemaType, string version)
        {
            if (string.IsNullOrWhiteSpace(schemaType))
                return string.Empty;

            System.Version ver;

            if (TryParseVersion(version, out ver) && ver.Major >= 2 && PartSchemas.Contains(schemaType))
                schemaType = $"part_{schemaType}";

            return string.Format(TypeFormat, schemaType);
        }

        /// <summary>
        /// Tries to convert the string representation of a version number to an equivalent System.Version
        /// object, and returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="version">The version.</param>
        /// <param name="result">The result.</param>
        /// <returns>true if the input parameter was converted successfully; otherwise, false.</returns>
        private static bool TryParseVersion(string version, out System.Version result)
        {
            if (!string.IsNullOrWhiteSpace(version) && !version.Contains("_"))
                return System.Version.TryParse(version, out result);

            result = new System.Version(0, 0);

            return false;
        }
    }
}
