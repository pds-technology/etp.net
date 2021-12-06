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

namespace Energistics.Etp.v11.Datatypes
{
    [AvroNamedType("MessageHeader", "Energistics.Datatypes")]
    public partial class MessageHeader
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Datatypes.MessageHeader\",\"fields\":[{\"name\":\"protocol\",\"type\":\"int\"},{\"name\":\"messageType\",\"type\":\"int\"},{\"name\":\"correlationId\",\"type\":\"long\"},{\"name\":\"messageId\",\"type\":\"long\"},{\"name\":\"messageFlags\",\"type\":\"int\"}]}";
        [AvroRecordField("protocol")]
        public int Protocol { get; set; }
        [AvroRecordField("messageType")]
        public int MessageType { get; set; }
        [AvroRecordField("correlationId")]
        public long CorrelationId { get; set; }
        [AvroRecordField("messageId")]
        public long MessageId { get; set; }
        [AvroRecordField("messageFlags")]
        public int MessageFlags { get; set; }
    }
}
