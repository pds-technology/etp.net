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
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Energistics.Etp.Common.Datatypes
{
    /// <summary>
    /// Represents a content type supported by the Energistics Transfer Protocol (ETP).
    /// </summary>
    public struct EtpDataObjectType : IDataObjectType
    {
        private static readonly Regex Pattern = new Regex(@"^(witsml|resqml|prodml|eml)([0-9]{2})\.((obj_|cs_|part_)?(\w+))?$", RegexOptions.CultureInvariant | RegexOptions.Compiled);
        private static readonly string[] PartSchemas = { "TrajectoryStation", "MudlogReportInterval", "WellboreGeometrySection" };
        private const string Format = "{0}{1}.{2}";
        private readonly string _dataType;

        private static readonly Dictionary<string, Dictionary<string, string>> _familyVersionLookup = new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase)
        {
            ["eml"] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                ["20"] = "2.0",
                ["21"] = "2.1",
                ["22"] = "2.2",
            },
            ["witsml"] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                ["13"] = "1.3.1.1",
                ["14"] = "1.4.1.1",
                ["20"] = "2.0",
            },
            ["prodml"] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                ["12"] = "1.2.2",
                ["13"] = "1.3",
                ["20"] = "2.0",
                ["21"] = "2.1",
            },
            ["resqml"] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                ["11"] = "1.1",
                ["20"] = "2.0.1",
                ["21"] = "2.1",
            },

        };

        private static readonly Dictionary<string, Dictionary<string, string>> _familyShortVersionLookup = new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase)
        {
            ["eml"] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                ["2.0"] = "20",
                ["2.1"] = "21",
                ["2.2"] = "22",
            },
            ["witsml"] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                ["1.3.1.1"] = "13",
                ["1.4.1.1"] = "14",
                ["2.0"] = "20",
            },
            ["prodml"] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                ["1.2.2"] = "12",
                ["1.3"] = "13",
                ["2.0"] = "20",
                ["2.1"] = "21",
            },
            ["resqml"] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                ["1.1"] = "11",
                ["2.0.1"] = "20",
                ["2.1"] = "21",
            },

        };

        /// <summary>
        /// Initializes a new instance of the <see cref="EtpDataObjectType"/> struct.
        /// </summary>
        /// <param name="dataType">The data type.</param>
        public EtpDataObjectType(string dataType)
        {
            var match = Pattern.Match(dataType);

            IsValid = match.Success;

            Family = TryGetFamily(GetValue(match, 1));
            ShortVersion = TryGetFamilyShortVersion(Family, GetValue(match, 2));
            Version = TryGetFamilyVersionFromShortVersion(Family, ShortVersion);
            ObjectType = GetObjectType(GetValue(match, 3), ShortVersion);

            _dataType = string.Format(Format, Family, ShortVersion, ObjectType);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EtpDataObjectType"/> struct.
        /// </summary>
        /// <param name="family">The ML family name.</param>
        /// <param name="version">The version.</param>
        public EtpDataObjectType(string family, string version) : this(family, version, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EtpDataObjectType" /> struct.
        /// </summary>
        /// <param name="family">The ML family name.</param>
        /// <param name="version">The version.</param>
        /// <param name="objectType">The object type.</param>
        /// <param name="format">The format.</param>
        public EtpDataObjectType(string family, string version, string objectType)
        {
            IsValid = true;

            Family = TryGetFamily(family);
            Version = TryGetFamilyVersion(family, version);
            ShortVersion = TryGetFamilyShortVersionFromVersion(family, version);
            ObjectType = GetObjectType(objectType, ShortVersion);

            _dataType = string.Format(Format, Family, ShortVersion, ObjectType);
        }

        /// <summary>
        /// Returns this as a data type string.
        /// </summary>
        string IDataObjectType.DataObjectType
        {
            get { return this; }
        }

        /// <summary>
        /// Returns this as a content type string.
        /// </summary>
        string IDataObjectType.ContentType
        {
            get { return ToContentType(); }
        }

        /// <summary>
        /// Gets the ML family name.
        /// </summary>
        /// <value>The ML family.</value>
        public string Family { get; }

        /// <summary>
        /// Gets the short version.
        /// </summary>
        /// <value>The version.</value>
        public string ShortVersion { get; }

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
        /// </summary>
        /// <value><c>true</c> if this instance is a base content type; otherwise, <c>false</c>.</value>
        public bool IsBaseType
        {
            get { return string.IsNullOrWhiteSpace(ObjectType); }
        }

        /// <summary>
        /// Determines whether this instance is related to the specified <see cref="EtpDataObjectType"/>.
        /// </summary>
        /// <param name="other">The other content type.</param>
        /// <returns>
        ///   <c>true</c> if the two <see cref="EtpDataObjectType"/> instances share the same family and
        ///   version; otherwise, <c>false</c>.
        /// </returns>
        public bool IsRelatedTo(EtpDataObjectType other)
        {
            return string.Equals(Family, other.Family, StringComparison.InvariantCultureIgnoreCase)
                && string.Equals(Version, other.Version, StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        /// Initializes a new instance of <see cref="EtpDataObjectType"/> based on the
        /// current ML family name, version number and the specified object type.
        /// </summary>
        /// <param name="objectType">The object type.</param>
        /// <returns>The new <see cref="EtpDataObjectType"/> instance.</returns>
        public EtpDataObjectType For(string objectType)
        {
            return new EtpDataObjectType(Family, Version, objectType);
        }

        /// <summary>
        /// Initializes a new instance of <see cref="EtpContentType"/> based on the
        /// current ML family name, version number and the specified object type.
        /// </summary>
        /// <returns>The new <see cref="EtpContentType"/> instance.</returns>
        public EtpContentType ToContentType()
        {
            return new EtpContentType(Family, Version, ObjectType);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return _dataType;
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (!(obj is EtpDataObjectType))
                return false;

            return Equals((EtpDataObjectType)obj);
        }

        /// <summary>
        /// Determines whether the specified <see cref="EtpDataObjectType" />, is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="EtpDataObjectType" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="EtpDataObjectType" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(EtpDataObjectType other)
        {
            return string.Equals(other, this, StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return _dataType.GetHashCode();
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="EtpDataObjectType"/> to <see cref="System.String"/>.
        /// </summary>
        /// <param name="contentType">Type of the content.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator string(EtpDataObjectType contentType)
        {
            return contentType.ToString();
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
        /// Tries to get the family from the candidate text.
        /// </summary>
        /// <param name="family">The candidate family.</param>
        /// <returns>The canonical family name or <c>null</c> if the candidate is not recongized.</returns>
        private static string TryGetFamily(string family)
        {
            if (string.IsNullOrEmpty(family))
                return null;

            if (_familyVersionLookup.ContainsKey(family))
                return family.ToLowerInvariant();

            return null;
        }

        /// <summary>
        /// Tries to get the family short version from the candidate text.
        /// </summary>
        /// <param name="family">The family.</param>
        /// <param name="shortVersion">The candidate short version.</param>
        /// <returns>The canonical family short version or <c>null</c> if the candidate is not recongized.</returns>
        private static string TryGetFamilyShortVersion(string family, string shortVersion)
        {
            if (string.IsNullOrEmpty(family) || !_familyVersionLookup.ContainsKey(family))
                return null;

            if (_familyVersionLookup[family].ContainsKey(shortVersion))
                return shortVersion;

            return null;
        }

        /// <summary>
        /// Tries to get the family version from the candidate text.
        /// </summary>
        /// <param name="family">The family.</param>
        /// <param name="shortVersion">The short version.</param>
        /// <returns>The canonical family version name or <c>null</c> if the candidate is not recongized.</returns>
        private static string TryGetFamilyVersionFromShortVersion(string family, string shortVersion)
        {
            if (string.IsNullOrEmpty(family))
                return null;

            string version;
            if (_familyVersionLookup[family].TryGetValue(shortVersion, out version))
                return version;

            return null;
        }

        /// <summary>
        /// Tries to get the family version from the candidate text.
        /// </summary>
        /// <param name="family">The family.</param>
        /// <param name="version">The version.</param>
        /// <returns>The canonical family version name or <c>null</c> if the candidate is not recongized.</returns>
        private static string TryGetFamilyVersion(string family, string version)
        {
            if (string.IsNullOrEmpty(family) || !_familyShortVersionLookup.ContainsKey(family))
                return null;

            if (_familyShortVersionLookup[family].ContainsKey(version))
                return version;

            return null;
        }

        /// <summary>
        /// Tries to get the family short version from the candidate text.
        /// </summary>
        /// <param name="family">The family.</param>
        /// <param name="version">The version.</param>
        /// <returns>The canonical family short version name or <c>null</c> if the candidate is not recongized.</returns>
        private static string TryGetFamilyShortVersionFromVersion(string family, string version)
        {
            if (string.IsNullOrEmpty(family))
                return null;

            string shortVersion;
            if (_familyShortVersionLookup[family].TryGetValue(version, out shortVersion))
                return shortVersion;

            return null;
        }

        /// <summary>
        /// Gets the object type name.
        /// </summary>
        /// <param name="objectType">The candidate object type.</param>
        /// <param name="shortVersion">The object's short version.</param>
        /// <returns>The formatted object type.</returns>
        public static string GetObjectType(string objectType, string shortVersion)
        {
            if (string.IsNullOrWhiteSpace(objectType))
                return null;

            if (!shortVersion.StartsWith("1") && objectType.StartsWith("obj_"))
                return objectType;

            var index = objectType.IndexOf('_');

            if (index > -1)
            {
                objectType = objectType.Substring(index + 1);
            }

            return objectType;
        }
    }
}