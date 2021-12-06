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

namespace Energistics.Etp.v12.Protocol.ChannelDataFrame
{
    [AvroNamedType("GetFrame", "Energistics.Etp.v12.Protocol.ChannelDataFrame")]
    public partial class GetFrame
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrame\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"includeAllChannelSecondaryIndexes\",\"type\":\"boolean\"},{\"name\":\"requestedInterval\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.Object.IndexInterval\",\"fields\":[{\"name\":\"startIndex\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.IndexValue\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"long\",\"double\",{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.PassIndexedDepth\",\"fields\":[{\"name\":\"pass\",\"type\":\"long\"},{\"name\":\"direction\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.PassDirection\",\"type\":\"enum\",\"symbols\":[\"Up\",\"HoldingSteady\",\"Down\"]}},{\"name\":\"depth\",\"type\":\"double\"}]}]}]}},{\"name\":\"endIndex\",\"type\":\"Energistics.Etp.v12.Datatypes.IndexValue\"},{\"name\":\"uom\",\"type\":\"string\"},{\"name\":\"depthDatum\",\"type\":\"string\"}]}},{\"name\":\"requestUuid\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.Uuid\",\"type\":\"fixed\",\"size\":16}},{\"name\":\"requestedSecondaryIntervals\",\"type\":{\"type\":\"array\",\"items\":\"Energistics.Etp.v12.Datatypes.Object.IndexInterval\"}}]}";
        [AvroRecordField("uri")]
        public string Uri { get; set; }
        [AvroRecordField("includeAllChannelSecondaryIndexes")]
        public bool IncludeAllChannelSecondaryIndexes { get; set; }
        [AvroRecordField("requestedInterval")]
        public Energistics.Etp.v12.Datatypes.Object.IndexInterval RequestedInterval { get; set; }
        [AvroRecordField("requestUuid")]
        public System.Guid RequestUuid { get; set; }
        [AvroRecordField("requestedSecondaryIntervals")]
        public IList<Energistics.Etp.v12.Datatypes.Object.IndexInterval> RequestedSecondaryIntervals { get; set; }
    }
}
