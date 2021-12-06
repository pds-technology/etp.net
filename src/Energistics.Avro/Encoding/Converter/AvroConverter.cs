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

namespace Energistics.Avro.Encoding.Converter
{
    /// <summary>
    /// Static methods to support encoding and decoding .NET primitives.
    /// </summary>
    public static partial class AvroConverter
    {
        private const long TicksPerMicrosecond = TimeSpan.TicksPerMillisecond / 1000L;
        private const long TicksPerMonth = TimeSpan.TicksPerDay * 30L;
        private const long UnixEpochTicks = 621355968000000000L; // new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Ticks

        /// <summary>
        /// Converts a double to a byte array in the correct byte order.
        /// </summary>
        /// <param name="float">The float to convert.</param>
        /// <returns>The byte array.</returns>
        public static byte[] FloatToBytes(float @float) => new FloatBytes(@float).Bytes;

        /// <summary>
        /// Converts a byte array in correct byte order to a float.
        /// </summary>
        /// <param name="bytes">The byte array to convert.</param>
        /// <returns>The float.</returns>
        public static float BytesToFloat(byte[] bytes) => new FloatBytes(bytes).Value;

        /// <summary>
        /// Converts a double to a byte array in the correct byte order.
        /// </summary>
        /// <param name="double">The double to convert.</param>
        /// <returns>The byte array.</returns>
        public static byte[] DoubleToBytes(double @double) => new DoubleBytes(@double).Bytes;

        /// <summary>
        /// Converts a byte array in correct byte order to a double.
        /// </summary>
        /// <param name="bytes">The byte array to convert.</param>
        /// <returns>The double.</returns>
        public static double BytesToDouble(byte[] bytes) => new DoubleBytes(bytes).Value;
    }
}
