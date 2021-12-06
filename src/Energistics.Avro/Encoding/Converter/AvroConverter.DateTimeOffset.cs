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
        public static readonly DateTimeOffset UtcMinDateTimeOffset = new DateTimeOffset(0L, TimeSpan.Zero);

        /// <summary>
        /// Converts an ISO 8601 string to a <see cref="DateTimeOffset"/>.
        /// </summary>
        /// <param name="timestamp">The ISO 8601 string.</param>
        /// <returns>The <see cref="DateTimeOffset"/>.</returns>
        public static DateTimeOffset Iso8601StringToDateTimeOffset(string timestamp)
        {
            return DateTimeOffset.Parse(timestamp, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts a <see cref="DateTimeOffset"/> to an ISO 8601 string.
        /// </summary>
        /// <param name="timestamp">The <see cref="DateTimeOffset"/> timestamp.</param>
        /// <returns>The ISO 8601 string.</returns>
        public static string DateTimeOffsetToIso8601String(DateTimeOffset timestamp)
        {
            return timestamp.ToString("O", CultureInfo.InvariantCulture).Replace("+00:00", "Z");
        }

        /// <summary>
        /// Converts an Avro date value to a UTC <see cref="DateTimeOffset"/>.
        /// </summary>
        /// <param name="date">The Avro date value.</param>
        /// <returns>The <see cref="DateTimeOffset"/>.</returns>
        public static DateTimeOffset DateToDateTimeOffset(int date)
        {
            var ticks = UnixEpochTicks + date * TimeSpan.TicksPerDay;
            return new DateTimeOffset(ticks, TimeSpan.Zero);
        }

        /// <summary>
        /// Converts a <see cref="DateTimeOffset"/> to a date value.
        /// The <see cref="DateTimeOffset"/> is not converted before creating the date value.
        /// </summary>
        /// <param name="date">The <see cref="DateTimeOffset"/> date.</param>
        /// <returns>The Avro date.</returns>
        public static int DateTimeOffsetToDate(DateTimeOffset date)
        {
            var ticks = date.Ticks - UnixEpochTicks;
            return (int)(ticks / TimeSpan.TicksPerDay);
        }

        /// <summary>
        /// Converts an Avro time-millis value to a UTC <see cref="DateTimeOffset"/>.
        /// </summary>
        /// <param name="time">The Avro time-millis value.</param>
        /// <returns>The <see cref="DateTimeOffset"/>.</returns>
        public static DateTimeOffset TimeMillisToDateTimeOffset(int time)
        {
            var ticks = time * TimeSpan.TicksPerMillisecond;
            return new DateTimeOffset(ticks, TimeSpan.Zero);
        }

        /// <summary>
        /// Converts a <see cref="DateTimeOffset"/> to a time-millis value.
        /// The <see cref="DateTimeOffset"/> is not converted before creating the time-millis value.
        /// </summary>
        /// <param name="time">The <see cref="DateTimeOffset"/> time.</param>
        /// <returns>The time-millis.</returns>
        public static int DateTimeOffsetToTimeMillis(DateTimeOffset time)
        {
            var ticks = time.Ticks % TimeSpan.TicksPerDay;
            return (int)(ticks / TimeSpan.TicksPerMillisecond);
        }

        /// <summary>
        /// Converts an Avro time-micros value to a UTC <see cref="DateTimeOffset"/>.
        /// </summary>
        /// <param name="time">The Avro time-micros value.</param>
        /// <returns>The <see cref="DateTimeOffset"/>.</returns>
        public static DateTimeOffset TimeMicrosToDateTimeOffset(long time)
        {
            var ticks = time * TicksPerMicrosecond;
            return new DateTimeOffset(ticks, TimeSpan.Zero);
        }

        /// <summary>
        /// Converts a <see cref="DateTimeOffset"/> to a time-micros value.
        /// The <see cref="DateTimeOffset"/> is not converted before creating the time-micros value.
        /// </summary>
        /// <param name="time">The <see cref="DateTimeOffset"/> time.</param>
        /// <returns>The time-micros.</returns>
        public static long DateTimeOffsetToTimeMicros(DateTimeOffset time)
        {
            var ticks = time.Ticks % TimeSpan.TicksPerDay;
            return ticks / TicksPerMicrosecond;
        }

        /// <summary>
        /// Converts an Avro timestamp-millis value to a UTC <see cref="DateTimeOffset"/>.
        /// </summary>
        /// <param name="timestamp">The Avro timestamp-millis value.</param>
        /// <returns>The <see cref="DateTimeOffset"/>.</returns>
        public static DateTimeOffset TimestampMillisUtcToDateTimeOffset(long timestamp)
        {
            var ticks = timestamp * TimeSpan.TicksPerMillisecond;
            return new DateTimeOffset(ticks + UnixEpochTicks, TimeSpan.Zero);
        }

        /// <summary>
        /// Converts a <see cref="DateTimeOffset"/> to a UTC timestamp-millis value.
        /// The <see cref="DateTimeOffset"/> is converted to universal time before creating the timestamp-millis value.
        /// </summary>
        /// <param name="timestamp">The <see cref="DateTimeOffset"/> timestamp.</param>
        /// <returns>The UTC timestamp-millis.</returns>
        public static long DateTimeOffsetToTimestampMillisUtc(DateTimeOffset timestamp)
        {
            var ticks = timestamp.ToUniversalTime().Ticks - UnixEpochTicks;
            return ticks / TimeSpan.TicksPerMillisecond;
        }

        /// <summary>
        /// Converts an Avro timestamp-micros value to a UTC <see cref="DateTimeOffset"/>.
        /// </summary>
        /// <param name="timestamp">The Avro timestamp-micros value.</param>
        /// <returns>The <see cref="DateTimeOffset"/>.</returns>
        public static DateTimeOffset TimestampMicrosUtcToDateTimeOffset(long timestamp)
        {
            var ticks = timestamp * TicksPerMicrosecond;
            return new DateTimeOffset(ticks + UnixEpochTicks, TimeSpan.Zero);
        }

        /// <summary>
        /// Converts a <see cref="DateTimeOffset"/> to a UTC timestamp-micros value.
        /// The <see cref="DateTimeOffset"/> is converted to universal time before creating the timestamp-micros value.
        /// </summary>
        /// <param name="timestamp">The <see cref="DateTimeOffset"/> timestamp.</param>
        /// <returns>The UTC timestamp-micros.</returns>
        public static long DateTimeOffsetToTimestampMicrosUtc(DateTimeOffset timestamp)
        {
            var ticks = timestamp.ToUniversalTime().Ticks - UnixEpochTicks;
            return ticks / TicksPerMicrosecond;
        }

        /// <summary>
        /// Converts an Avro timestamp-millis-local value to a local <see cref="DateTimeOffset"/>.
        /// </summary>
        /// <param name="timestamp">The Avro timestamp-millis-local value.</param>
        /// <returns>The <see cref="DateTimeOffset"/>.</returns>
        public static DateTimeOffset TimestampMillisLocalToDateTimeOffset(long timestamp)
        {
            return new DateTimeOffset(TimestampMillisLocalToDateTime(timestamp));
        }

        /// <summary>
        /// Converts a <see cref="DateTimeOffset"/> to a timestamp-millis-local value.
        /// The current timezone offset for the <see cref="DateTimeOffset"/> is treated as the local timezone for the timestamp-millis-local value.
        /// </summary>
        /// <param name="timestamp">The <see cref="DateTimeOffset"/> timestamp.</param>
        /// <returns>The timestamp-millis-local.</returns>
        public static long DateTimeOffsetToTimestampMillisLocal(DateTimeOffset timestamp)
        {
            var ticks = timestamp.Ticks - UnixEpochTicks;
            return ticks / TimeSpan.TicksPerMillisecond;
        }

        /// <summary>
        /// Converts an Avro timestamp-micros-local value to a local <see cref="DateTimeOffset"/>.
        /// </summary>
        /// <param name="timestamp">The Avro timestamp-micros-local value.</param>
        /// <returns>The <see cref="DateTimeOffset"/>.</returns>
        public static DateTimeOffset TimestampMicrosLocalToDateTimeOffset(long timestamp)
        {
            return new DateTimeOffset(TimestampMicrosLocalToDateTime(timestamp));
        }

        /// <summary>
        /// Converts a <see cref="DateTimeOffset"/> to a timestamp-micros-local value.
        /// The current timezone offset for the <see cref="DateTimeOffset"/> is treated as the local timezone for the timestamp-micros-local value.
        /// </summary>
        /// <param name="timestamp">The <see cref="DateTimeOffset"/> timestamp.</param>
        /// <returns>The timestamp-micros-local.</returns>
        public static long DateTimeOffsetToTimestampMicrosLocal(DateTimeOffset timestamp)
        {
            var ticks = timestamp.Ticks - UnixEpochTicks;
            return ticks / TicksPerMicrosecond;
        }
    }
}
