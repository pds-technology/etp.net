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

namespace Energistics.Etp.v12.Protocol.ChannelDataLoad
{
    [AvroNamedType("ReplaceRange", "Energistics.Etp.v12.Protocol.ChannelDataLoad")]
    public partial class ReplaceRange
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Protocol.ChannelDataLoad.ReplaceRange\",\"fields\":[{\"name\":\"changedInterval\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.Object.IndexInterval\",\"fields\":[{\"name\":\"startIndex\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.IndexValue\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"long\",\"double\",{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.PassIndexedDepth\",\"fields\":[{\"name\":\"pass\",\"type\":\"long\"},{\"name\":\"direction\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.PassDirection\",\"type\":\"enum\",\"symbols\":[\"Up\",\"HoldingSteady\",\"Down\"]}},{\"name\":\"depth\",\"type\":\"double\"}]}]}]}},{\"name\":\"endIndex\",\"type\":\"Energistics.Etp.v12.Datatypes.IndexValue\"},{\"name\":\"uom\",\"type\":\"string\"},{\"name\":\"depthDatum\",\"type\":\"string\"}]}},{\"name\":\"channelIds\",\"type\":{\"type\":\"array\",\"items\":\"long\"}},{\"name\":\"data\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.DataItem\",\"fields\":[{\"name\":\"channelId\",\"type\":\"long\"},{\"name\":\"indexes\",\"type\":{\"type\":\"array\",\"items\":\"Energistics.Etp.v12.Datatypes.IndexValue\"}},{\"name\":\"value\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.DataValue\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"boolean\",\"int\",\"long\",\"float\",\"double\",\"string\",{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"boolean\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfNullableBoolean\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"boolean\"]}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"int\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfNullableInt\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"int\"]}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"long\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfNullableLong\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"long\"]}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"float\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"double\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfString\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"string\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfBytes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"bytes\"}}]},\"bytes\",{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.AnySparseArray\",\"fields\":[{\"name\":\"slices\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.AnySubarray\",\"fields\":[{\"name\":\"start\",\"type\":\"long\"},{\"name\":\"slice\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.AnyArray\",\"fields\":[{\"name\":\"item\",\"type\":[\"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"Energistics.Etp.v12.Datatypes.ArrayOfString\",\"bytes\"]}]}}]}}}]}]}]}},{\"name\":\"valueAttributes\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.DataAttribute\",\"fields\":[{\"name\":\"attributeId\",\"type\":\"int\"},{\"name\":\"attributeValue\",\"type\":\"Energistics.Etp.v12.Datatypes.DataValue\"}]}}}]}}}]}";
        [AvroRecordField("changedInterval")]
        public Energistics.Etp.v12.Datatypes.Object.IndexInterval ChangedInterval { get; set; }
        [AvroRecordField("channelIds")]
        public IList<long> ChannelIds { get; set; }
        [AvroRecordField("data")]
        public IList<Energistics.Etp.v12.Datatypes.ChannelData.DataItem> Data { get; set; }
    }
}
