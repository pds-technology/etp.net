//-----------------------------------------------------------------------
// ETP DevKit, 1.2
// 
// Copyright 2021 Energistics
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
// 
//-----------------------------------------------------------------------
// This code has been automatically generated.
// Changes will be lost the next time it is regenerated.
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Energistics.Avro;

namespace Energistics.Etp.v12.Protocol.Core
{
    [AvroNamedType("RequestSession", "Energistics.Etp.v12.Protocol.Core")]
    public partial class RequestSession
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Protocol.Core.RequestSession\",\"fields\":[{\"name\":\"applicationName\",\"type\":\"string\"},{\"name\":\"applicationVersion\",\"type\":\"string\"},{\"name\":\"clientInstanceId\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.Uuid\",\"type\":\"fixed\",\"size\":16}},{\"name\":\"requestedProtocols\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.SupportedProtocol\",\"fields\":[{\"name\":\"protocol\",\"type\":\"int\"},{\"name\":\"protocolVersion\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.Version\",\"fields\":[{\"name\":\"major\",\"type\":\"int\"},{\"name\":\"minor\",\"type\":\"int\"},{\"name\":\"revision\",\"type\":\"int\"},{\"name\":\"patch\",\"type\":\"int\"}]}},{\"name\":\"role\",\"type\":\"string\"},{\"name\":\"protocolCapabilities\",\"type\":{\"type\":\"map\",\"values\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.DataValue\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"boolean\",\"int\",\"long\",\"float\",\"double\",\"string\",{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"boolean\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfNullableBoolean\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"boolean\"]}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"int\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfNullableInt\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"int\"]}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"long\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfNullableLong\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"long\"]}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"float\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"double\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfString\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"string\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfBytes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"bytes\"}}]},\"bytes\",{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.AnySparseArray\",\"fields\":[{\"name\":\"slices\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.AnySubarray\",\"fields\":[{\"name\":\"start\",\"type\":\"long\"},{\"name\":\"slice\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.AnyArray\",\"fields\":[{\"name\":\"item\",\"type\":[\"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"Energistics.Etp.v12.Datatypes.ArrayOfString\",\"bytes\"]}]}}]}}}]}]}]}}}]}}},{\"name\":\"supportedDataObjects\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.SupportedDataObject\",\"fields\":[{\"name\":\"qualifiedType\",\"type\":\"string\"},{\"name\":\"dataObjectCapabilities\",\"type\":{\"type\":\"map\",\"values\":\"Energistics.Etp.v12.Datatypes.DataValue\"}}]}}},{\"name\":\"supportedCompression\",\"type\":{\"type\":\"array\",\"items\":\"string\"}},{\"name\":\"supportedFormats\",\"type\":{\"type\":\"array\",\"items\":\"string\"}},{\"name\":\"currentDateTime\",\"type\":\"long\"},{\"name\":\"earliestRetainedChangeTime\",\"type\":\"long\"},{\"name\":\"serverAuthorizationRequired\",\"type\":\"boolean\"},{\"name\":\"endpointCapabilities\",\"type\":{\"type\":\"map\",\"values\":\"Energistics.Etp.v12.Datatypes.DataValue\"}}]}";
        [AvroRecordField("applicationName")]
        public string ApplicationName { get; set; }
        [AvroRecordField("applicationVersion")]
        public string ApplicationVersion { get; set; }
        [AvroRecordField("clientInstanceId")]
        public System.Guid ClientInstanceId { get; set; }
        [AvroRecordField("requestedProtocols")]
        public IList<Energistics.Etp.v12.Datatypes.SupportedProtocol> RequestedProtocols { get; set; }
        [AvroRecordField("supportedDataObjects")]
        public IList<Energistics.Etp.v12.Datatypes.SupportedDataObject> SupportedDataObjects { get; set; }
        [AvroRecordField("supportedCompression")]
        public IList<string> SupportedCompression { get; set; }
        [AvroRecordField("supportedFormats")]
        public IList<string> SupportedFormats { get; set; }
        [AvroRecordField("currentDateTime")]
        public System.DateTime CurrentDateTime { get; set; }
        [AvroRecordField("earliestRetainedChangeTime")]
        public System.DateTime EarliestRetainedChangeTime { get; set; }
        [AvroRecordField("serverAuthorizationRequired")]
        public bool ServerAuthorizationRequired { get; set; }
        [AvroRecordField("endpointCapabilities")]
        public IDictionary<string, Energistics.Etp.v12.Datatypes.DataValue> EndpointCapabilities { get; set; }
    }
}
