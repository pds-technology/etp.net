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

namespace Energistics.Etp.v11.Datatypes.ChannelData
{
    [AvroNamedType("IndexMetadataRecord", "Energistics.Datatypes.ChannelData")]
    public partial class IndexMetadataRecord
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Datatypes.ChannelData.IndexMetadataRecord\",\"fields\":[{\"name\":\"indexType\",\"type\":{\"name\":\"Energistics.Datatypes.ChannelData.ChannelIndexTypes\",\"type\":\"enum\",\"symbols\":[\"Time\",\"Depth\"]}},{\"name\":\"uom\",\"type\":\"string\"},{\"name\":\"depthDatum\",\"type\":[\"null\",\"string\"]},{\"name\":\"direction\",\"type\":{\"name\":\"Energistics.Datatypes.ChannelData.IndexDirections\",\"type\":\"enum\",\"symbols\":[\"Increasing\",\"Decreasing\"]}},{\"name\":\"mnemonic\",\"type\":[\"null\",\"string\"]},{\"name\":\"description\",\"type\":[\"null\",\"string\"]},{\"name\":\"uri\",\"type\":[\"null\",\"string\"]},{\"name\":\"customData\",\"type\":{\"type\":\"map\",\"values\":{\"type\":\"record\",\"name\":\"Energistics.Datatypes.DataValue\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"double\",\"float\",\"int\",\"long\",\"string\",{\"type\":\"record\",\"name\":\"Energistics.Datatypes.ArrayOfDouble\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"double\"}}]},\"boolean\",\"bytes\"]}]}}},{\"name\":\"scale\",\"type\":\"int\"},{\"name\":\"timeDatum\",\"type\":[\"null\",\"string\"]}]}";
        [AvroRecordField("indexType")]
        public Energistics.Etp.v11.Datatypes.ChannelData.ChannelIndexTypes IndexType { get; set; }
        [AvroRecordField("uom")]
        public string Uom { get; set; }
        [AvroRecordField("depthDatum")]
        [AvroNullable(true, "string")]
        public string DepthDatum { get; set; }
        [AvroRecordField("direction")]
        public Energistics.Etp.v11.Datatypes.ChannelData.IndexDirections Direction { get; set; }
        [AvroRecordField("mnemonic")]
        [AvroNullable(true, "string")]
        public string Mnemonic { get; set; }
        [AvroRecordField("description")]
        [AvroNullable(true, "string")]
        public string Description { get; set; }
        [AvroRecordField("uri")]
        [AvroNullable(true, "string")]
        public string Uri { get; set; }
        [AvroRecordField("customData")]
        public IDictionary<string, Energistics.Etp.v11.Datatypes.DataValue> CustomData { get; set; }
        [AvroRecordField("scale")]
        public int Scale { get; set; }
        [AvroRecordField("timeDatum")]
        [AvroNullable(true, "string")]
        public string TimeDatum { get; set; }
    }
}
