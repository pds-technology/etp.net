//-----------------------------------------------------------------------
// ETP DevKit, 1.2
// 
// Copyright 2021 Energistics
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use file except in compliance with the License.
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
// 
//-----------------------------------------------------------------------
// code has been automatically generated.
// Changes will be lost the next time it is regenerated.
//-----------------------------------------------------------------------

using System;
using System.Globalization;

namespace Energistics.Avro.Encoding.Converter
{
    /// <summary>
    /// Static methods to support encoding and decoding .NET primitives.
    /// </summary>
    public static partial class AvroConverter
    {
        /// <summary>
        /// Converts a <see cref="Guid"/> to a uuid string in the correct byte order.
        /// </summary>
        /// <param name="guid">The <see cref="Guid"/> to convert.</param>
        /// <returns>The uuid string.</returns>
        public static string GuidToRfc4122String(Guid guid) => guid.ToString("D", CultureInfo.InvariantCulture);

        /// <summary>
        /// Converts a RFC 4122 string to a <see cref="Guid"/>.
        /// </summary>
        /// <param name="string">The RFC 4122 string to convert.</param>
        /// <returns>The <see cref="Guid"/>.</returns>
        public static Guid Rfc4122StringToGuid(string @string) => Guid.Parse(@string);

        /// <summary>
        /// Converts a <see cref="Guid"/> to a byte array in the correct byte order.
        /// </summary>
        /// <param name="guid">The <see cref="Guid"/> to convert.</param>
        /// <returns>The byte array.</returns>
        public static byte[] GuidToBytes(Guid guid) => new GuidBytes(guid).Bytes;

        /// <summary>
        /// Converts a byte array in correct byte order to a <see cref="Guid"/>.
        /// </summary>
        /// <param name="bytes">The byte array to convert.</param>
        /// <returns>The <see cref="Guid"/>.</returns>
        public static Guid BytesToGuid(byte[] bytes) => new GuidBytes(bytes).Value;

        /// <summary>
        /// Converts a <see cref="Guid"/> to a fixed byte array in the correct byte order.
        /// </summary>
        /// <param name="guid">The <see cref="Guid"/> to convert.</param>
        /// <returns>The byte array.</returns>
        public static byte[] GuidToFixed(Guid guid) => GuidToBytes(guid);

        /// <summary>
        /// Converts a fixed byte array in correct byte order to a <see cref="Guid"/>.
        /// </summary>
        /// <param name="bytes">The fixed byte array to convert.</param>
        /// <returns>The <see cref="Guid"/>.</returns>
        public static Guid FixedToGuid(byte[] @fixed) => BytesToGuid(@fixed);
    }
}
