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

namespace Energistics.Etp.v11.Protocol.GrowingObject
{
    [AvroNamedType("GrowingObjectGetRange", "Energistics.Protocol.GrowingObject")]
    public partial class GrowingObjectGetRange
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Protocol.GrowingObject.GrowingObjectGetRange\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"startIndex\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Datatypes.Object.GrowingObjectIndex\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"long\",\"double\"]}]}},{\"name\":\"endIndex\",\"type\":\"Energistics.Datatypes.Object.GrowingObjectIndex\"},{\"name\":\"uom\",\"type\":\"string\"},{\"name\":\"depthDatum\",\"type\":\"string\"}]}";
        [AvroRecordField("uri")]
        public string Uri { get; set; }
        [AvroRecordField("startIndex")]
        public Energistics.Etp.v11.Datatypes.Object.GrowingObjectIndex StartIndex { get; set; }
        [AvroRecordField("endIndex")]
        public Energistics.Etp.v11.Datatypes.Object.GrowingObjectIndex EndIndex { get; set; }
        [AvroRecordField("uom")]
        public string Uom { get; set; }
        [AvroRecordField("depthDatum")]
        public string DepthDatum { get; set; }
    }
}
