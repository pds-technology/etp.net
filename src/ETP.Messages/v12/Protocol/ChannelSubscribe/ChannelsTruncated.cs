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

namespace Energistics.Etp.v12.Protocol.ChannelSubscribe
{
    [AvroNamedType("ChannelsTruncated", "Energistics.Etp.v12.Protocol.ChannelSubscribe")]
    public partial class ChannelsTruncated
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Protocol.ChannelSubscribe.ChannelsTruncated\",\"fields\":[{\"name\":\"channels\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.TruncateInfo\",\"fields\":[{\"name\":\"channelId\",\"type\":\"long\"},{\"name\":\"newEndIndex\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.IndexValue\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"long\",\"double\",{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.PassIndexedDepth\",\"fields\":[{\"name\":\"pass\",\"type\":\"long\"},{\"name\":\"direction\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.PassDirection\",\"type\":\"enum\",\"symbols\":[\"Up\",\"HoldingSteady\",\"Down\"]}},{\"name\":\"depth\",\"type\":\"double\"}]}]}]}}]}}},{\"name\":\"changeTime\",\"type\":\"long\"}]}";
        [AvroRecordField("channels")]
        public IList<Energistics.Etp.v12.Datatypes.ChannelData.TruncateInfo> Channels { get; set; }
        [AvroRecordField("changeTime")]
        public System.DateTime ChangeTime { get; set; }
    }
}
