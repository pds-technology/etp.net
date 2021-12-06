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

namespace Energistics.Avro.Encoding
{
    /// <summary>
    /// Enum representing different supported encodings for <see cref="System.TimeSpan"/>.
    /// </summary>
    public enum TimeSpanEncodingStyle
    {
        /// <summary>
        /// An ISO 8601 duration
        /// </summary>
        Iso8601String,

        /// <summary>
        /// A 64-bit integer representing the number of of milliseconds.
        /// </summary>
        Milliseconds,

        /// <summary>
        /// A 64-bit integer representing the number of of microseconds.
        /// </summary>
        Microseconds,

        /// <summary>
        /// An 32-bit integer representing the number of milliseconds after midnight, 00:00:00.000, with no reference to a particular calendar, time zone or date.
        /// </summary>
        TimeMillis,

        /// <summary>
        /// An 32-bit integer representing the number of microseconds after midnight, 00:00:00.000000, with no reference to a particular calendar, time zone or date.
        /// </summary>
        TimeMicros,

        /// <summary>
        /// 3 32-bit integers representing an amount of time defined by a number of months, days and milliseconds
        /// </summary>
        Duration,
    }
}
