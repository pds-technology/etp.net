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

using Energistics.Avro.Encoding;
using System.Collections.Generic;

namespace Energistics.Etp.Common
{
    /// <summary>
    /// An interface class for ETP Avro message body records.
    /// </summary>
    public interface IEtpMessageBody : IEtpRecord
    {
        /// <summary>
        /// Whether or nto this record can be split into multiple records.
        /// </summary>
        /// <returns><c>true</c> if this record can be split; <c>false</c> otherwise.</returns>
        bool CanSplit();
    }

    /// <summary>
    /// An interface class for ETP Avro message body records.
    /// </summary>
    public interface IEtpMessageBody<TMessageBody> : IEtpMessageBody
        where TMessageBody : class, IEtpMessageBody, new()
    {
        /// <summary>
        /// If this record can be split, splits this record into two or more sub records based on the target size. If the record cannot be split, returns this record.
        /// </summary>
        /// <param name="targetSize">The target size of individual message bodies in bytes.</param>
        /// <param name="byteCounter">The byte counter to use to count size in bytes.</param>
        /// <returns>The split records.</returns>
        IEnumerable<TMessageBody> Split(long targetSize, IAvroByteCounter byteCounter);
    }
}
