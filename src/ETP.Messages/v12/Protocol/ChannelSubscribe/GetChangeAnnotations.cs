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
    [AvroNamedType("GetChangeAnnotations", "Energistics.Etp.v12.Protocol.ChannelSubscribe")]
    public partial class GetChangeAnnotations
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChangeAnnotations\",\"fields\":[{\"name\":\"channels\",\"type\":{\"type\":\"map\",\"values\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ChannelData.ChannelChangeRequestInfo\",\"fields\":[{\"name\":\"sinceChangeTime\",\"type\":\"long\"},{\"name\":\"channelIds\",\"type\":{\"type\":\"array\",\"items\":\"long\"}}]}}},{\"name\":\"latestOnly\",\"type\":\"boolean\"}]}";
        [AvroRecordField("channels")]
        public IDictionary<string, Energistics.Etp.v12.Datatypes.ChannelData.ChannelChangeRequestInfo> Channels { get; set; }
        [AvroRecordField("latestOnly")]
        public bool LatestOnly { get; set; }
    }
}
