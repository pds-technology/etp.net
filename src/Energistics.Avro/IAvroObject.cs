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

namespace Energistics.Avro
{
    /// <summary>
    /// An interface class for Avro objects.
    /// </summary>
    public interface IAvroObject
    {
        /// <summary>
        /// Gets the Avro type name for the object.
        /// </summary>
        string AvroTypeName { get; }

        /// <summary>
        /// Encodes this object.
        /// </summary>
        /// <param name="encoder">The encoder to use to encode the object.</param>
        void Encode(IAvroEncoder encoder);


        /// <summary>
        /// Decodes this object.
        /// </summary>
        /// <param name="decoder">The decoder to use to decode the object.</param>
        void Decode(IAvroDecoder decoder);
    }
}
