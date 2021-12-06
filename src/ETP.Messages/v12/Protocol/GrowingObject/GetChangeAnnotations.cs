﻿//-----------------------------------------------------------------------
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

namespace Energistics.Etp.v12.Protocol.GrowingObject
{
    [AvroNamedType("GetChangeAnnotations", "Energistics.Etp.v12.Protocol.GrowingObject")]
    public partial class GetChangeAnnotations
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Protocol.GrowingObject.GetChangeAnnotations\",\"fields\":[{\"name\":\"sinceChangeTime\",\"type\":\"long\"},{\"name\":\"uris\",\"type\":{\"type\":\"map\",\"values\":\"string\"}},{\"name\":\"latestOnly\",\"type\":\"boolean\"}]}";
        [AvroRecordField("sinceChangeTime")]
        public System.DateTime SinceChangeTime { get; set; }
        [AvroRecordField("uris")]
        public IDictionary<string, string> Uris { get; set; }
        [AvroRecordField("latestOnly")]
        public bool LatestOnly { get; set; }
    }
}