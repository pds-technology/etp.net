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

using Energistics.Etp.Common.Datatypes;
using Energistics.Etp.Common.Datatypes.DataArrayTypes;
using System;
using System.Collections.Generic;

namespace Energistics.Etp.Common
{
    /// <summary>
    /// Extensions for common data types.
    /// </summary>
    public static class CommonExtensions
    {
        /// <summary>
        /// Converts an <see cref="IUuid"/> instance to a UUID with a concrete type.
        /// </summary>
        /// <typeparam name="TUuid">The concrete UUID type.</typeparam>
        /// <param name="uuid">The <see cref="IUuid"/> to convert</param>
        /// <returns>The converted UUID.</returns>
        public static TUuid ToUuid<TUuid>(this IUuid uuid)
            where TUuid : class, IUuid, new()
        {
            return uuid == null
                ? null
                : uuid as TUuid ?? new TUuid { Value = uuid.Value };
        }

        /// <summary>
        /// Checks if the UUID can be converted to a valid <see cref="Guid"/> instance.
        /// </summary>
        /// <param name="uuid">The UUID.</param>
        /// <returns><c>true</c> if the UUID can be converted to a valid <see cref="Guid"/> instance; <c>false</c> otherwise.</returns>
        public static bool IsValidGuid(this IUuid uuid)
        {
            return uuid?.Value?.Length == 16;
        }

        /// <summary>
        /// Checks if the string can be converted to a valid <see cref="Guid"/> instance.
        /// </summary>
        /// <param name="uuid">The string.</param>
        /// <returns><c>true</c> if the string can be converted to a valid <see cref="Guid"/> instance; <c>false</c> otherwise.</returns>
        public static bool IsValidGuid(string uuid)
        {
            return string.IsNullOrEmpty(uuid) ? false : Guid.TryParse(uuid, out _);
        }

        /// <summary>
        /// Converts the UUID to a <see cref="Guid"/> instance.
        /// </summary>
        /// <param name="uuid">The UUID.</param>
        /// <returns>A new <see cref="Guid"/> instance.</returns>
        public static Guid ToGuid(this IUuid uuid)
        {
            return !uuid.IsValidGuid()
                 ? default(Guid)
                 : new Guid(GuidUtility.GetSwappedBytes(uuid.Value));
        }

        /// <summary>
        /// Converts the string to a <see cref="Guid"/> instance.
        /// </summary>
        /// <param name="uuid">The string.</param>
        /// <returns>A new <see cref="Guid"/> instance.</returns>
        public static Guid ToGuid(string uuid)
        {
            if (string.IsNullOrEmpty(uuid))
                return default(Guid);

            Guid guid;
            Guid.TryParse(uuid, out guid);
            return guid;
        }

        /// <summary>
        /// Converts the UUID to a base64 encoded string
        /// </summary>
        /// <param name="uuid">The UUID.</param>
        /// <returns>The base64 encoded string representation of the UUID.</returns>
        public static string ToBase64String(this IUuid uuid)
        {
            return Convert.ToBase64String(uuid?.Value ?? new byte[0]);
        }

        /// <summary>
        /// Converts the <see cref="Guid"/> to a UUID instance.
        /// </summary>
        /// <typeparam name="TUuid">The concrete UUID type.</typeparam>
        /// <param name="guid">The unique identifier.</param>
        /// <returns>A new UUID instance.</returns>
        public static TUuid ToUuid<TUuid>(this Guid guid)
            where TUuid : class, IUuid, new()
        {
            return new TUuid
            {
                Value = GuidUtility.GetSwappedBytes(guid.ToByteArray()),
            };
        }

        /// <summary>
        /// Converts an <see cref="IDataValue"/> instance to a contact with a concrete type.
        /// </summary>
        /// <typeparam name="TDataValue">The concrete contact type.</typeparam>
        /// <param name="value">The <see cref="IDataValue"/> to convert</param>
        /// <returns>The converted contact.</returns>
        public static TDataValue ToDataValue<TDataValue>(this IDataValue value)
            where TDataValue : class, IDataValue, new()
        {
            return value == null
                ? null
                : value as TDataValue ?? new TDataValue { Item = value.Item };
        }

        /// <summary>
        /// Converts an <see cref="IDataValue"/> instance to string.
        /// </summary>
        /// <param name="value">The <see cref="IDataValue"/> to convert</param>
        /// <returns>The converted contact.</returns>
        public static string ToStringValue(this IDataValue value)
        {
            return value?.Item == null
                ? null
                : value.Item as string ?? $"{value.Item}";
        }

        /// <summary>
        /// Converts a string instance to a contact with a concrete type.
        /// </summary>
        /// <typeparam name="TDataValue">The concrete contact type.</typeparam>
        /// <param name="value">The string to convert</param>
        /// <returns>The converted contact.</returns>
        public static TDataValue ToDataValue<TDataValue>(string value)
            where TDataValue : class, IDataValue, new()
        {
            return value == null
                ? null
                : new TDataValue { Item = value };
        }

        /// <summary>
        /// Converts a dictionary with contacts of concrete type to an <see cref="IDictionary{string, IDataValue}"/> instance.
        /// </summary>
        /// <param name="dictionary">The dictionary to convert.</param>
        /// <typeparam name="TDataValue">The concrete contact type.</typeparam>
        /// <returns>The converted dictionary.</returns>
        public static IDataValueDictionary ToDataValueDictionary<TDataValue>(this IDictionary<string, TDataValue> dictionary)
            where TDataValue : class, IDataValue, new()
        {
            return dictionary == null
                ? null
                : new EtpDataValueDictionaryWrapper<TDataValue>(dictionary);
        }

        /// <summary>
        /// Converts a dictionary with contacts of concrete type to an <see cref="IDictionary{string, IDataValue}"/> instance.
        /// </summary>
        /// <param name="dictionary">The dictionary to convert.</param>
        /// <typeparam name="TDataValue">The concrete contact type.</typeparam>
        /// <returns>The converted dictionary.</returns>
        public static IDataValueDictionary ToDataValueDictionary<TDataValue>(this IDictionary<string, string> dictionary)
            where TDataValue : class, IDataValue, new()
        {
            return dictionary == null
                ? null
                : new EtpStringDictionaryWrapper<TDataValue>(dictionary);
        }

        /// <summary>
        /// Converts a <see cref="IDictionary{string, IDataValue}"/> instance to a dictionary with a contacts with a concrete type.
        /// </summary>
        /// <param name="dictionary">The dictionary to convert.</param>
        /// <typeparam name="TDataValue">The concrete contact type.</typeparam>
        /// <returns>The converted dictionary.</returns>
        public static IDictionary<string, TDataValue> ToValueDictionary<TDataValue>(this IReadOnlyDictionary<string, IDataValue> dictionary)
            where TDataValue : class, IDataValue, new()
        {
            if (dictionary == null)
                return null;

            var convertedDictionary = new Dictionary<string, TDataValue>();
            foreach (var kvp in dictionary)
            {
                convertedDictionary[kvp.Key] = kvp.Value.ToDataValue<TDataValue>();
            }

            return convertedDictionary;
        }

        /// <summary>
        /// Converts a dictionary with contacts to a string dictionary.
        /// </summary>
        /// <param name="dictionary">The dictionary to convert.</param>
        /// <typeparam name="TDataValue">The contact type.</typeparam>
        /// <returns>The converted dictionary.</returns>
        public static IDictionary<string, string> ToStringDictionary<TDataValue>(this IReadOnlyDictionary<string, TDataValue> dictionary)
            where TDataValue : IDataValue
        {
            if (dictionary == null)
                return null;

            var convertedDictionary = new Dictionary<string, string>();
            foreach (var kvp in dictionary)
            {
                convertedDictionary[kvp.Key] = kvp.Value.ToStringValue();
            }

            return convertedDictionary;
        }

        /// <summary>
        /// Converts an <see cref="IVersion"/> instance to an <see cref="EtpVersion"/>.
        /// </summary>
        /// <param name="version">The <see cref="IVersion"/> to convert.</param>
        /// <returns>The converted version.</returns>
        public static EtpVersion ToEtpVersion(this IVersion version)
        {
            if (version == null)
                return EtpVersion.Unknown;

            if (version.Major == 1 && version.Minor == 1 && version.Revision == 0 && version.Patch == 0)
                return EtpVersion.v11;
            if (version.Major == 1 && version.Minor == 2 && version.Revision == 0 && version.Patch == 0)
                return EtpVersion.v12;

            return EtpVersion.Unknown;
        }

        /// <summary>
        /// Converts an <see cref="EtpVersion"/> instance to an <see cref="IVersion"/>.
        /// </summary>
        /// <param name="version">The <see cref="EtpVersion"/> to convert.</param>
        /// <returns>The converted version.</returns>
        public static TVersion ToVersion<TVersion>(this EtpVersion version)
            where TVersion : IVersion, new()
        {
            switch (version)
            {
                case EtpVersion.v11: return new TVersion { Major = 1, Minor = 1, Revision = 0, Patch = 0, };
                case EtpVersion.v12: return new TVersion { Major = 1, Minor = 2, Revision = 0, Patch = 0, };
                default: return new TVersion();
            }
        }

        /// <summary>
        /// Converts an <see cref="EtpVersion"/> instance to an <see cref="System.Version"/>.
        /// </summary>
        /// <param name="version">The <see cref="EtpVersion"/> to convert.</param>
        /// <returns>The converted version.</returns>
        public static System.Version ToSystemVersion(this EtpVersion version)
        {
            switch (version)
            {
                case EtpVersion.v11: return new System.Version(1, 1, 0, 0);
                case EtpVersion.v12: return new System.Version(1, 2, 0, 0);
                default: return new System.Version();
            }
        }

        /// <summary>
        /// Converts an <see cref="ISupportedProtocol"/> instance to a SupportedProtocol with a concrete type.
        /// </summary>
        /// <typeparam name="TSupportedProtocol">The concrete supported protocol type.</typeparam>
        /// <param name="supportedProtocol">The <see cref="ISupportedProtocol"/> to convert</param>
        /// <returns>The converted supported protocol.</returns>
        public static TSupportedProtocol ToSupportedProtocol<TSupportedProtocol>(this ISupportedProtocol supportedProtocol)
            where TSupportedProtocol : class, ISupportedProtocol, new()
        {
            if (supportedProtocol == null)
                return null;
            if (supportedProtocol is TSupportedProtocol)
                return supportedProtocol as TSupportedProtocol;

            var converted = new TSupportedProtocol
            {
                EtpVersion = supportedProtocol.EtpVersion,
                Protocol = supportedProtocol.Protocol,
                Role = supportedProtocol.Role,
            };
            converted.SetProtocolCapabilitiesFrom(supportedProtocol.ProtocolCapabilities);

            return converted;
        }

        /// <summary>
        /// Converts an <see cref="ISupportedDataObject"/> instance to a SupportedDataObject with a concrete type.
        /// </summary>
        /// <typeparam name="TSupportedDataObject">The concrete supported data object type.</typeparam>
        /// <param name="SupportedDataObject">The <see cref="ISupportedDataObject"/> to convert</param>
        /// <returns>The converted data object.</returns>
        public static TSupportedDataObject ToSupportedDataObject<TSupportedDataObject>(this ISupportedDataObject supportedDataObject)
            where TSupportedDataObject : class, ISupportedDataObject, new()
        {
            if (supportedDataObject == null)
                return null;
            if (supportedDataObject is TSupportedDataObject)
                return supportedDataObject as TSupportedDataObject;

            var converted = new TSupportedDataObject
            {
                QualifiedType = supportedDataObject.QualifiedType,
                DataObjectCapabilities = supportedDataObject.DataObjectCapabilities,
            };

            return converted;
        }

        /// <summary>
        /// Converts an <see cref="IDataArray"/> instance to a data array with a concrete type.
        /// </summary>
        /// <typeparam name="TDataArray">The concrete data array type.</typeparam>
        /// <param name="value">The <see cref="IDataArray"/> to convert</param>
        /// <returns>The converted data array.</returns>
        public static TDataArray ToDataArray<TDataArray>(this IDataArray value)
            where TDataArray : class, IDataArray, new()
        {
            return value == null
                ? null
                : value as TDataArray ?? new TDataArray { Dimensions = value.Dimensions, Data = value.Data };
        }

        /// <summary>
        /// Converts an <see cref="IAnyArray"/> instance to an any array with a concrete type.
        /// </summary>
        /// <typeparam name="TAnyArray">The concrete any array type.</typeparam>
        /// <param name="value">The <see cref="IAnyArray"/> to convert</param>
        /// <returns>The converted any array.</returns>
        public static TAnyArray ToAnyArray<TAnyArray>(this IAnyArray value)
            where TAnyArray : class, IAnyArray, new()
        {
            return value == null
                ? null
                : value as TAnyArray ?? new TAnyArray { Item = value.Item };
        }

        /// <summary>
        /// Converts an <see cref="IErrorInfo"/> instance to an error info with a concrete type.
        /// </summary>
        /// <typeparam name="TErrorInfo">The concrete error info type.</typeparam>
        /// <param name="error">The <see cref="IErrorInfo"/> to convert</param>
        /// <returns>The converted error info.</returns>
        public static TErrorInfo ToErrorInfo<TErrorInfo>(this IErrorInfo error)
            where TErrorInfo : class, IErrorInfo, new()
        {
            return error == null
                ? null
                : error as TErrorInfo ?? new TErrorInfo { Code = error.Code, Message = error.Message };
        }

        /// <summary>
        /// Converts a <see cref="IDictionary{string, IErrorInfo}"/> instance to a <see cref="IDictionary{string, TErrorInfo}"/> instance.
        /// </summary>
        /// <param name="dictionary">The dictionary to convert.</param>
        /// <typeparam name="TErrorInfo">The output error type.</typeparam>
        /// <returns>The converted dictionary.</returns>
        public static IDictionary<string, TErrorInfo> ToErrorDictionary<TErrorInfo>(this IDictionary<string, IErrorInfo> dictionary)
            where TErrorInfo : class, IErrorInfo, new()
        {
            if (dictionary == null)
                return null;
            if (dictionary is IDictionary<string, TErrorInfo>)
                return dictionary as IDictionary<string, TErrorInfo>;

            var convertedDictionary = new Dictionary<string, TErrorInfo>();
            foreach (var kvp in dictionary)
            {
                convertedDictionary[kvp.Key] = kvp.Value.ToErrorInfo<TErrorInfo>();
            }

            return convertedDictionary;
        }

        /// <summary>
        /// Converts an <see cref="IContact"/> instance to a contact with a concrete type.
        /// </summary>
        /// <typeparam name="TContact">The concrete contact type.</typeparam>
        /// <param name="value">The <see cref="IContact"/> to convert</param>
        /// <returns>The converted contact.</returns>
        public static TContact ToContact<TContact>(this IContact value)
            where TContact : class, IContact, new()
        {
            return value == null
                ? null
                : value as TContact ?? new TContact { OrganizationName = value.OrganizationName, ContactName = value.ContactName, ContactPhone = value.ContactPhone, ContactEmail = value.ContactEmail };
        }

        /// <summary>
        /// Converts a data object type to a wildcard matching its entire family.
        /// </summary>
        /// <param name="dataObjectType">The data object type to convert.</param>
        /// <returns>The converted data object type.</returns>
        public static IDataObjectType ToWildCard(this IDataObjectType dataObjectType)
        {
            if (dataObjectType == null || !dataObjectType.IsValid || dataObjectType.IsBaseType)
                return null;
            if (dataObjectType.IsWildcard)
                return dataObjectType;

            return new EtpDataObjectType(dataObjectType.Family, dataObjectType.Version, "*");
        }

        /// <summary>
        /// Checks if the specified data object type matches the other data object type.  Matches against wildcards are allowed.
        /// </summary>
        /// <param name="dataObjectType">The data object type to compare.</param>
        /// <param name="otherDataObjectType">The data object type to compare against.</param>
        /// <returns><c>true</c> if the data object type matches the other data object type; <c>false</c> otherwise.</returns>
        public static bool Matches(this IDataObjectType dataObjectType, IDataObjectType otherDataObjectType)
        {
            if (dataObjectType == null && otherDataObjectType == null)
                return true;
            if (dataObjectType == null || otherDataObjectType == null)
                return false;

            var familyMatches = StringMatches(dataObjectType.Family, otherDataObjectType.Family);
            var versionMatches = StringMatches(dataObjectType.Version, otherDataObjectType.Version);
            if (!familyMatches || !versionMatches)
                return false;

            return StringMatches(dataObjectType.ObjectType, otherDataObjectType.ObjectType) || dataObjectType.IsWildcard || otherDataObjectType.IsWildcard;
        }

        /// <summary>
        /// Checks if the specified data object types have matching families and versions.
        /// </summary>
        /// <param name="dataObjectType">The data object type to compare.</param>
        /// <param name="otherDataObjectType">The data object type to compare against.</param>
        /// <returns><c>true</c> if the data object type matches the other data object type; <c>false</c> otherwise.</returns>
        public static bool MatchesFamilyAndVersion(this IDataObjectType dataObjectType, IDataObjectType otherDataObjectType)
        {
            if (dataObjectType == null && otherDataObjectType == null)
                return true;
            if (dataObjectType == null || otherDataObjectType == null)
                return false;

            var familyMatches = StringMatches(dataObjectType.Family, otherDataObjectType.Family);
            var versionMatches = StringMatches(dataObjectType.Version, otherDataObjectType.Version);
            return familyMatches && versionMatches;
        }

        /// <summary>
        /// Checks if the specified data object type exactly matches the other data object type.  With exact matches, wildcards
        /// only match other wildcards, not specific data object types.
        /// </summary>
        /// <param name="dataObjectType">The data object type to compare.</param>
        /// <param name="otherDataObjectType">The data object type to compare against.</param>
        /// <returns><c>true</c> if the data object type matches the other data object type; <c>false</c> otherwise.</returns>
        public static bool MatchesExact(this IDataObjectType dataObjectType, IDataObjectType otherDataObjectType)
        {
            if (dataObjectType == null && otherDataObjectType == null)
                return true;
            if (dataObjectType == null || otherDataObjectType == null)
                return false;

            var familyMatches = StringMatches(dataObjectType.Family, otherDataObjectType.Family);
            var versionMatches = StringMatches(dataObjectType.Version, otherDataObjectType.Version);
            if (!familyMatches || !versionMatches)
                return false;

            return StringMatches(dataObjectType.ObjectType, otherDataObjectType.ObjectType);
        }

        /// <summary>
        /// Checks if two strings are either both null or empty or are equal ignoring case.
        /// </summary>
        /// <param name="left">The left string.</param>
        /// <param name="right">The right string.</param>
        /// <returns><c>true</c> if both strings are either null or empty or are equal ignoring case.</returns>
        private static bool StringMatches(string left, string right)
        {
            if (string.IsNullOrEmpty(left) && string.IsNullOrEmpty(right))
                return true;

            return string.Equals(left, right, StringComparison.OrdinalIgnoreCase);
        }
    }
}
