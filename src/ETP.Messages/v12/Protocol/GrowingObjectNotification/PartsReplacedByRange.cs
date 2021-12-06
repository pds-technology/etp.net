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

namespace Energistics.Etp.v12.Protocol.GrowingObjectNotification
{
    [AvroNamedType("PartsReplacedByRange", "Energistics.Etp.v12.Protocol.GrowingObjectNotification")]
    public partial class PartsReplacedByRange
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsReplacedByRange\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"requestUuid\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.Uuid\",\"type\":\"fixed\",\"size\":16}},{\"name\":\"changeTime\",\"type\":\"long\"},{\"name\":\"deletedInterval\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.Object.IndexInterval\",\"fields\":[{\"name\":\"startIndex\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.IndexValue\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"long\",\"double\",{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.PassIndexedDepth\",\"fields\":[{\"name\":\"pass\",\"type\":\"long\"},{\"name\":\"direction\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.PassDirection\",\"type\":\"enum\",\"symbols\":[\"Up\",\"HoldingSteady\",\"Down\"]}},{\"name\":\"depth\",\"type\":\"double\"}]}]}]}},{\"name\":\"endIndex\",\"type\":\"Energistics.Etp.v12.Datatypes.IndexValue\"},{\"name\":\"uom\",\"type\":\"string\"},{\"name\":\"depthDatum\",\"type\":\"string\"}]}},{\"name\":\"includeOverlappingIntervals\",\"type\":\"boolean\"},{\"name\":\"format\",\"type\":\"string\"},{\"name\":\"parts\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.Object.ObjectPart\",\"fields\":[{\"name\":\"uid\",\"type\":\"string\"},{\"name\":\"data\",\"type\":\"bytes\"}]}}}]}";
        [AvroRecordField("uri")]
        public string Uri { get; set; }
        [AvroRecordField("requestUuid")]
        public System.Guid RequestUuid { get; set; }
        [AvroRecordField("changeTime")]
        public System.DateTime ChangeTime { get; set; }
        [AvroRecordField("deletedInterval")]
        public Energistics.Etp.v12.Datatypes.Object.IndexInterval DeletedInterval { get; set; }
        [AvroRecordField("includeOverlappingIntervals")]
        public bool IncludeOverlappingIntervals { get; set; }
        [AvroRecordField("format")]
        public string Format { get; set; }
        [AvroRecordField("parts")]
        public IList<Energistics.Etp.v12.Datatypes.Object.ObjectPart> Parts { get; set; }
    }
}
