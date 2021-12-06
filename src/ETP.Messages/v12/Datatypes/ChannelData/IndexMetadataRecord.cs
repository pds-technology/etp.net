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

namespace Energistics.Etp.v12.Datatypes.ChannelData
{
    [AvroNamedType("IndexMetadataRecord", "Energistics.Etp.v12.Datatypes.ChannelData")]
    public partial class IndexMetadataRecord
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.IndexMetadataRecord\",\"fields\":[{\"name\":\"indexKind\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.ChannelIndexKind\",\"type\":\"enum\",\"symbols\":[\"DateTime\",\"ElapsedTime\",\"MeasuredDepth\",\"TrueVerticalDepth\",\"PassIndexedDepth\",\"Pressure\",\"Temperature\",\"Scalar\"]}},{\"name\":\"interval\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.Object.IndexInterval\",\"fields\":[{\"name\":\"startIndex\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.IndexValue\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"long\",\"double\",{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.PassIndexedDepth\",\"fields\":[{\"name\":\"pass\",\"type\":\"long\"},{\"name\":\"direction\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.PassDirection\",\"type\":\"enum\",\"symbols\":[\"Up\",\"HoldingSteady\",\"Down\"]}},{\"name\":\"depth\",\"type\":\"double\"}]}]}]}},{\"name\":\"endIndex\",\"type\":\"Energistics.Etp.v12.Datatypes.IndexValue\"},{\"name\":\"uom\",\"type\":\"string\"},{\"name\":\"depthDatum\",\"type\":\"string\"}]}},{\"name\":\"direction\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.IndexDirection\",\"type\":\"enum\",\"symbols\":[\"Increasing\",\"Decreasing\",\"Unordered\"]}},{\"name\":\"name\",\"type\":\"string\"},{\"name\":\"uom\",\"type\":\"string\"},{\"name\":\"depthDatum\",\"type\":\"string\"},{\"name\":\"indexPropertyKindUri\",\"type\":\"string\"},{\"name\":\"filterable\",\"type\":\"boolean\"}]}";
        [AvroRecordField("indexKind")]
        public Energistics.Etp.v12.Datatypes.ChannelData.ChannelIndexKind IndexKind { get; set; }
        [AvroRecordField("interval")]
        public Energistics.Etp.v12.Datatypes.Object.IndexInterval Interval { get; set; }
        [AvroRecordField("direction")]
        public Energistics.Etp.v12.Datatypes.ChannelData.IndexDirection Direction { get; set; }
        [AvroRecordField("name")]
        public string Name { get; set; }
        [AvroRecordField("uom")]
        public string Uom { get; set; }
        [AvroRecordField("depthDatum")]
        public string DepthDatum { get; set; }
        [AvroRecordField("indexPropertyKindUri")]
        public string IndexPropertyKindUri { get; set; }
        [AvroRecordField("filterable")]
        public bool Filterable { get; set; }
    }
}
