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
        /// <summary>
        /// Converts an ISO 8601 string to a <see cref="TimeSpan"/>.
        /// </summary>
        /// <param name="duration">The ISO 8601 string.</param>
        /// <returns>The <see cref="TimeSpan"/>.</returns>
        public static TimeSpan Iso8601StringToTimeSpan(string duration)
        {
            return System.Xml.XmlConvert.ToTimeSpan(duration);
        }

        /// <summary>
        /// Converts a <see cref="TimeSpan"/> to an ISO 8601 string.
        /// </summary>
        /// <param name="duration">The <see cref="TimeSpan"/> duration.</param>
        /// <returns>The ISO 8601 string.</returns>
        public static string TimeSpanToIso8601String(TimeSpan duration)
        {
            return System.Xml.XmlConvert.ToString(duration);
        }

        /// <summary>
        /// Converts an milliseconds value to a <see cref="TimeSpan"/>.
        /// </summary>
        /// <param name="milliseconds">The milliseconds value.</param>
        /// <returns>The <see cref="TimeSpan"/>.</returns>
        public static TimeSpan MillisecondsToTimeSpan(long milliseconds)
        {
            var ticks = milliseconds * TimeSpan.TicksPerMillisecond;
            return new TimeSpan(ticks);
        }

        /// <summary>
        /// Converts a <see cref="TimeSpan"/> to a milliseconds value.
        /// </summary>
        /// <param name="time">The <see cref="TimeSpan"/> time.</param>
        /// <returns>The milliseconds value.</returns>
        public static long TimeSpanToMilliseconds(TimeSpan duration)
        {
            return duration.Ticks / TimeSpan.TicksPerMillisecond;
        }

        /// <summary>
        /// Converts an microseconds value to a <see cref="TimeSpan"/>.
        /// </summary>
        /// <param name="microseconds">The microseconds value.</param>
        /// <returns>The <see cref="TimeSpan"/>.</returns>
        public static TimeSpan MicrosecondsToTimeSpan(long microseconds)
        {
            var ticks = microseconds * TicksPerMicrosecond;
            return new TimeSpan(ticks);
        }

        /// <summary>
        /// Converts a <see cref="TimeSpan"/> to a microseconds value.
        /// </summary>
        /// <param name="time">The <see cref="TimeSpan"/> time.</param>
        /// <returns>The microseconds value.</returns>
        public static long TimeSpanToMicroseconds(TimeSpan duration)
        {
            return duration.Ticks / TicksPerMicrosecond;
        }

        /// <summary>
        /// Converts an Avro time-millis value to a <see cref="TimeSpan"/>.
        /// </summary>
        /// <param name="time">The Avro time-millis value.</param>
        /// <returns>The <see cref="TimeSpan"/>.</returns>
        public static TimeSpan TimeMillisToTimeSpan(int time)
        {
            var ticks = time * TimeSpan.TicksPerMillisecond;
            return new TimeSpan(ticks);
        }

        /// <summary>
        /// Converts a <see cref="TimeSpan"/> to a time-millis value.
        /// </summary>
        /// <param name="time">The <see cref="TimeSpan"/> time.</param>
        /// <returns>The UTC time-millis.</returns>
        public static int TimeSpanToTimeMillis(TimeSpan time)
        {
            return (int)(time.Ticks / TimeSpan.TicksPerMillisecond);
        }

        /// <summary>
        /// Converts an Avro time-micros value to a <see cref="TimeSpan"/>.
        /// </summary>
        /// <param name="time">The Avro time-micros value.</param>
        /// <returns>The <see cref="TimeSpan"/>.</returns>
        public static TimeSpan TimeMicrosToTimeSpan(long time)
        {
            var ticks = time * TicksPerMicrosecond;
            return new TimeSpan(ticks);
        }

        /// <summary>
        /// Converts a <see cref="TimeSpan"/> to a time-micros value.
        /// </summary>
        /// <param name="time">The <see cref="TimeSpan"/> time.</param>
        /// <returns>The UTC time-micros.</returns>
        public static long TimeSpanToTimeMicros(TimeSpan time)
        {
            return time.Ticks / TicksPerMicrosecond;
        }

        /// <summary>
        /// Converts an Avro duration value to a <see cref="TimeSpan"/>.
        /// </summary>
        /// <param name="duration">The Avro duration value.</param>
        /// <returns>The <see cref="TimeSpan"/>.</returns>
        public static TimeSpan DurationToTimeSpan(byte[] duration)
        {
            var wrapper = new DurationBytes(duration);
            var ticks = wrapper.Months * TicksPerMonth + wrapper.Days * TimeSpan.TicksPerDay + wrapper.Milliseconds * TimeSpan.TicksPerMillisecond;
            return new TimeSpan(ticks);
        }

        /// <summary>
        /// Converts a <see cref="TimeSpan"/> to a duration value.
        /// </summary>
        /// <param name="time">The <see cref="TimeSpan"/> duration.</param>
        /// <returns>The duration.</returns>
        public static byte[] TimeSpanToDuration(TimeSpan duration)
        {
            var months = duration.Ticks / TicksPerMonth;
            var days = (duration.Ticks % TicksPerMonth) / TimeSpan.TicksPerDay;
            var milliseconds = (duration.Ticks % TimeSpan.TicksPerDay) / TimeSpan.TicksPerMillisecond;
            return new DurationBytes((uint)months, (uint)days, (uint)milliseconds).Bytes;
        }
    }
}
