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
    /// Enum representing different supported encodings for <see cref="System.Guid"/>.
    /// </summary>
    public enum GuidEncodingStyle
    {
        /// <summary>
        /// A string in RFC-4122 format (e.g., 00112233-4455-6677-8899-aabbccddeeff)
        /// </summary>
        Rfc4122String,

        /// <summary>
        /// As an array of bytes.
        /// </summary>
        Bytes,

        /// <summary>
        /// As a fixed array of 16 bytes.
        /// </summary>
        Fixed
    }
}
