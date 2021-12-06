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

namespace Energistics.Etp.v11.Protocol.Core
{
    [AvroNamedType("OpenSession", "Energistics.Protocol.Core")]
    public partial class OpenSession
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Protocol.Core.OpenSession\",\"fields\":[{\"name\":\"applicationName\",\"type\":\"string\"},{\"name\":\"applicationVersion\",\"type\":\"string\"},{\"name\":\"sessionId\",\"type\":\"string\"},{\"name\":\"supportedProtocols\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"Energistics.Datatypes.SupportedProtocol\",\"fields\":[{\"name\":\"protocol\",\"type\":\"int\"},{\"name\":\"protocolVersion\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Datatypes.Version\",\"fields\":[{\"name\":\"major\",\"type\":\"int\"},{\"name\":\"minor\",\"type\":\"int\"},{\"name\":\"revision\",\"type\":\"int\"},{\"name\":\"patch\",\"type\":\"int\"}]}},{\"name\":\"role\",\"type\":\"string\"},{\"name\":\"protocolCapabilities\",\"type\":{\"type\":\"map\",\"values\":{\"type\":\"record\",\"name\":\"Energistics.Datatypes.DataValue\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"double\",\"float\",\"int\",\"long\",\"string\",{\"type\":\"record\",\"name\":\"Energistics.Datatypes.ArrayOfDouble\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"double\"}}]},\"boolean\",\"bytes\"]}]}}}]}}},{\"name\":\"supportedObjects\",\"type\":{\"type\":\"array\",\"items\":\"string\"}}]}";
        [AvroRecordField("applicationName")]
        public string ApplicationName { get; set; }
        [AvroRecordField("applicationVersion")]
        public string ApplicationVersion { get; set; }
        [AvroRecordField("sessionId")]
        public System.Guid SessionId { get; set; }
        [AvroRecordField("supportedProtocols")]
        public IList<Energistics.Etp.v11.Datatypes.SupportedProtocol> SupportedProtocols { get; set; }
        [AvroRecordField("supportedObjects")]
        public IList<string> SupportedObjects { get; set; }
    }
}
