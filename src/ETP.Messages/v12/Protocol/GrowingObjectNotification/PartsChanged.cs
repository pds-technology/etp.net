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
    [AvroNamedType("PartsChanged", "Energistics.Etp.v12.Protocol.GrowingObjectNotification")]
    public partial class PartsChanged
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsChanged\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"requestUuid\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.Uuid\",\"type\":\"fixed\",\"size\":16}},{\"name\":\"changeKind\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.Object.ObjectChangeKind\",\"type\":\"enum\",\"symbols\":[\"insert\",\"update\",\"authorized\",\"joined\",\"unjoined\",\"joinedSubscription\",\"unjoinedSubscription\"]}},{\"name\":\"changeTime\",\"type\":\"long\"},{\"name\":\"format\",\"type\":\"string\"},{\"name\":\"parts\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.Object.ObjectPart\",\"fields\":[{\"name\":\"uid\",\"type\":\"string\"},{\"name\":\"data\",\"type\":\"bytes\"}]}}}]}";
        [AvroRecordField("uri")]
        public string Uri { get; set; }
        [AvroRecordField("requestUuid")]
        public System.Guid RequestUuid { get; set; }
        [AvroRecordField("changeKind")]
        public Energistics.Etp.v12.Datatypes.Object.ObjectChangeKind ChangeKind { get; set; }
        [AvroRecordField("changeTime")]
        public System.DateTime ChangeTime { get; set; }
        [AvroRecordField("format")]
        public string Format { get; set; }
        [AvroRecordField("parts")]
        public IList<Energistics.Etp.v12.Datatypes.Object.ObjectPart> Parts { get; set; }
    }
}
