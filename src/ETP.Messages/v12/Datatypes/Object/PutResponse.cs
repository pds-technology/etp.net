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

namespace Energistics.Etp.v12.Datatypes.Object
{
    [AvroNamedType("PutResponse", "Energistics.Etp.v12.Datatypes.Object")]
    public partial class PutResponse
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.Object.PutResponse\",\"fields\":[{\"name\":\"createdContainedObjectUris\",\"type\":{\"type\":\"array\",\"items\":\"string\"}},{\"name\":\"deletedContainedObjectUris\",\"type\":{\"type\":\"array\",\"items\":\"string\"}},{\"name\":\"joinedContainedObjectUris\",\"type\":{\"type\":\"array\",\"items\":\"string\"}},{\"name\":\"unjoinedContainedObjectUris\",\"type\":{\"type\":\"array\",\"items\":\"string\"}}]}";
        [AvroRecordField("createdContainedObjectUris")]
        public IList<string> CreatedContainedObjectUris { get; set; }
        [AvroRecordField("deletedContainedObjectUris")]
        public IList<string> DeletedContainedObjectUris { get; set; }
        [AvroRecordField("joinedContainedObjectUris")]
        public IList<string> JoinedContainedObjectUris { get; set; }
        [AvroRecordField("unjoinedContainedObjectUris")]
        public IList<string> UnjoinedContainedObjectUris { get; set; }
    }
}
