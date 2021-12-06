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

namespace Energistics.Etp.v11.Protocol.DataArray
{
    [AvroNamedType("GetDataArraySlice", "Energistics.Protocol.DataArray")]
    public partial class GetDataArraySlice
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Protocol.DataArray.GetDataArraySlice\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"start\",\"type\":{\"type\":\"array\",\"items\":\"long\"}},{\"name\":\"count\",\"type\":{\"type\":\"array\",\"items\":\"long\"}}]}";
        [AvroRecordField("uri")]
        public string Uri { get; set; }
        [AvroRecordField("start")]
        public IList<long> Start { get; set; }
        [AvroRecordField("count")]
        public IList<long> Count { get; set; }
    }
}
