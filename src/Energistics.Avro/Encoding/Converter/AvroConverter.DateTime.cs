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
        public static readonly DateTime UtcMinDateTime = new DateTime(0L, DateTimeKind.Utc);

        /// <summary>
        /// Converts an ISO 8601 string to a UTC <see cref="DateTime"/>.
        /// </summary>
        /// <param name="timestamp">The ISO 8601 string.</param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime Iso8601StringToDateTime(string timestamp)
        {
            return Iso8601StringToDateTimeOffset(timestamp).UtcDateTime;
        }

        /// <summary>
        /// Converts a <see cref="DateTime"/> to an ISO 8601 string.
        /// </summary>
        /// <param name="timestamp">The <see cref="DateTime"/> timestamp.</param>
        /// <returns>The ISO 8601 string.</returns>
        public static string DateTimeToIso8601String(DateTime timestamp)
        {
            return timestamp.ToString("O", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts an Avro date value to an unspecified <see cref="DateTime"/>.
        /// </summary>
        /// <param name="date">The Avro date value.</param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime DateToDateTime(int date)
        {
            var ticks = UnixEpochTicks + date * TimeSpan.TicksPerDay;
            return new DateTime(ticks);
        }

        /// <summary>
        /// Converts a <see cref="DateTime"/> to a date value.
        /// The <see cref="DateTime"/> is not converted before creating the date value.
        /// </summary>
        /// <param name="date">The <see cref="DateTime"/> date.</param>
        /// <returns>The Avro date.</returns>
        public static int DateTimeToDate(DateTime date)
        {
            var ticks = date.Ticks - UnixEpochTicks;
            return (int)(ticks / TimeSpan.TicksPerDay);
        }

        /// <summary>
        /// Converts an Avro time-millis value to an unspecified <see cref="DateTime"/>.
        /// </summary>
        /// <param name="time">The Avro time-millis value.</param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime TimeMillisToDateTime(int time)
        {
            var ticks = time * TimeSpan.TicksPerMillisecond;
            return new DateTime(ticks, DateTimeKind.Unspecified);
        }

        /// <summary>
        /// Converts a <see cref="DateTime"/> to a time-millis value.
        /// The <see cref="DateTime"/> is not converted before creating the time-millis value.
        /// </summary>
        /// <param name="time">The <see cref="DateTime"/> time.</param>
        /// <returns>The time-millis.</returns>
        public static int DateTimeToTimeMillis(DateTime time)
        {
            var ticks = time.Ticks % TimeSpan.TicksPerDay;
            return (int)(ticks / TimeSpan.TicksPerMillisecond);
        }

        /// <summary>
        /// Converts an Avro time-micros value to an unspecified <see cref="DateTime"/>.
        /// </summary>
        /// <param name="time">The Avro time-micros value.</param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime TimeMicrosToDateTime(long time)
        {
            var ticks = time * TicksPerMicrosecond;
            return new DateTime(ticks, DateTimeKind.Unspecified);
        }

        /// <summary>
        /// Converts a <see cref="DateTime"/> to a time-micros value.
        /// The <see cref="DateTime"/> is not converted before creating the time-micros value.
        /// </summary>
        /// <param name="time">The <see cref="DateTime"/> time.</param>
        /// <returns>The time-micros.</returns>
        public static long DateTimeToTimeMicros(DateTime time)
        {
            var ticks = time.Ticks % TimeSpan.TicksPerDay;
            return ticks / TicksPerMicrosecond;
        }

        /// <summary>
        /// Converts an Avro timestamp-millis value to a UTC <see cref="DateTime"/>.
        /// </summary>
        /// <param name="timestamp">The Avro timestamp-millis value.</param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime TimestampMillisUtcToDateTime(long timestamp)
        {
            var ticks = timestamp * TimeSpan.TicksPerMillisecond;
            return new DateTime(ticks + UnixEpochTicks, DateTimeKind.Utc);
        }

        /// <summary>
        /// Converts a <see cref="DateTime"/> to a UTC timestamp-millis value.
        /// The <see cref="DateTime"/> is converted to universal time before creating the timestamp-millis value.
        /// </summary>
        /// <param name="timestamp">The <see cref="DateTime"/> timestamp.</param>
        /// <returns>The UTC timestamp-millis.</returns>
        public static long DateTimeToTimestampMillisUtc(DateTime timestamp)
        {
            var ticks = timestamp.ToUniversalTime().Ticks - UnixEpochTicks;
            return ticks / TimeSpan.TicksPerMillisecond;
        }

        /// <summary>
        /// Converts an Avro timestamp-micros value to a UTC <see cref="DateTime"/>.
        /// </summary>
        /// <param name="timestamp">The Avro timestamp-micros value.</param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime TimestampMicrosUtcToDateTime(long timestamp)
        {
            var ticks = timestamp * TicksPerMicrosecond;
            return new DateTime(ticks + UnixEpochTicks, DateTimeKind.Utc);
        }

        /// <summary>
        /// Converts a <see cref="DateTime"/> to a UTC timestamp-micros value.
        /// The <see cref="DateTime"/> is converted to universal time before creating the timestamp-micros value.
        /// </summary>
        /// <param name="timestamp">The <see cref="DateTime"/> timestamp.</param>
        /// <returns>The UTC timestamp-micros.</returns>
        public static long DateTimeToTimestampMicrosUtc(DateTime timestamp)
        {
            var ticks = timestamp.ToUniversalTime().Ticks - UnixEpochTicks;
            return ticks / TicksPerMicrosecond;
        }

        /// <summary>
        /// Converts an Avro timestamp-millis-local value to a local <see cref="DateTime"/>.
        /// </summary>
        /// <param name="timestamp">The Avro timestamp-millis-local value.</param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime TimestampMillisLocalToDateTime(long timestamp)
        {
            var ticks = timestamp * TimeSpan.TicksPerMillisecond;
            return new DateTime(ticks + UnixEpochTicks, DateTimeKind.Local);
        }

        /// <summary>
        /// Converts a <see cref="DateTime"/> to a timestamp-millis-local value.
        /// The <see cref="DateTime"/> is converted to local time before creating the timestamp-millis-local value.
        /// </summary>
        /// <param name="timestamp">The <see cref="DateTime"/> timestamp.</param>
        /// <returns>The timestamp-millis-local.</returns>
        public static long DateTimeToTimestampMillisLocal(DateTime timestamp)
        {
            var ticks = timestamp.ToLocalTime().Ticks - UnixEpochTicks;
            return ticks / TimeSpan.TicksPerMillisecond;
        }

        /// <summary>
        /// Converts an Avro timestamp-micros-local value to a local <see cref="DateTime"/>.
        /// </summary>
        /// <param name="timestamp">The Avro timestamp-micros-local value.</param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public static DateTime TimestampMicrosLocalToDateTime(long timestamp)
        {
            var ticks = timestamp * TicksPerMicrosecond;
            return new DateTime(ticks + UnixEpochTicks, DateTimeKind.Local);
        }

        /// <summary>
        /// Converts a <see cref="DateTime"/> to a timestamp-micros-local value.
        /// The <see cref="DateTime"/> is converted to local time before creating the timestamp-micros-local value.
        /// </summary>
        /// <param name="timestamp">The <see cref="DateTime"/> timestamp.</param>
        /// <returns>The timestamp-micros-local.</returns>
        public static long DateTimeToTimestampMicrosLocal(DateTime timestamp)
        {
            var ticks = timestamp.ToLocalTime().Ticks - UnixEpochTicks;
            return ticks / TicksPerMicrosecond;
        }
    }
}
