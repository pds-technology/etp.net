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

namespace Energistics.Etp.v11.Datatypes.Object
{
    [AvroNamedType("Resource", "Energistics.Datatypes.Object")]
    public partial class Resource
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Datatypes.Object.Resource\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"contentType\",\"type\":\"string\"},{\"name\":\"name\",\"type\":\"string\"},{\"name\":\"channelSubscribable\",\"type\":\"boolean\"},{\"name\":\"customData\",\"type\":{\"type\":\"map\",\"values\":\"string\"}},{\"name\":\"resourceType\",\"type\":\"string\"},{\"name\":\"hasChildren\",\"type\":\"int\"},{\"name\":\"uuid\",\"type\":[\"null\",\"string\"]},{\"name\":\"lastChanged\",\"type\":\"long\"},{\"name\":\"objectNotifiable\",\"type\":\"boolean\"}]}";
        [AvroRecordField("uri")]
        public string Uri { get; set; }
        [AvroRecordField("contentType")]
        public string ContentType { get; set; }
        [AvroRecordField("name")]
        public string Name { get; set; }
        [AvroRecordField("channelSubscribable")]
        public bool ChannelSubscribable { get; set; }
        [AvroRecordField("customData")]
        public IDictionary<string, string> CustomData { get; set; }
        [AvroRecordField("resourceType")]
        public string ResourceType { get; set; }
        [AvroRecordField("hasChildren")]
        public int HasChildren { get; set; }
        [AvroRecordField("uuid")]
        [AvroNullable(true, "string")]
        public System.Guid? Uuid { get; set; }
        [AvroRecordField("lastChanged")]
        public System.DateTime LastChanged { get; set; }
        [AvroRecordField("objectNotifiable")]
        public bool ObjectNotifiable { get; set; }
    }
}
