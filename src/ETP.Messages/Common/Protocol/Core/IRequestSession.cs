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
using System;
using System.Collections.Generic;

namespace Energistics.Etp.Common.Protocol.Core
{
    public interface IRequestSession : Avro.Specific.ISpecificRecord
    {
        string ApplicationName { get; set; }

        string ApplicationVersion { get; set; }

        bool IsClientInstanceIdValid { get; }

        string RawClientInstanceId { get; }

        Guid ClientInstanceId { get; set; }

        IReadOnlyList<ISupportedProtocol> RequestedProtocols { get; }

        void SetRequestedProtocolsFrom(IEnumerable<ISupportedProtocol> requestedProtocols);

        IReadOnlyList<ISupportedDataObject> SupportedDataObjects { get; }

        void SetSupportedDataObjectsFrom(IEnumerable<ISupportedDataObject> supportedDataObjects);

        IList<string> SupportedCompression { get; set; }

        IList<string> SupportedFormats { get; set; }

        long CurrentDateTime { get; set; }

        IReadOnlyDataValueDictionary EndpointCapabilities { get; }

        IDataValueDictionary GetOrCreateEndpointCapabilities();

        void SetEndpointCapabilitiesFrom(IReadOnlyDictionary<string, IDataValue> dictionary);
    }
}
