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

namespace Energistics.Etp.v12.Protocol.SupportedTypes
{
    [AvroNamedType("GetSupportedTypes", "Energistics.Etp.v12.Protocol.SupportedTypes")]
    public partial class GetSupportedTypes
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Protocol.SupportedTypes.GetSupportedTypes\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"scope\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.Object.ContextScopeKind\",\"type\":\"enum\",\"symbols\":[\"self\",\"sources\",\"targets\",\"sourcesOrSelf\",\"targetsOrSelf\"]}},{\"name\":\"returnEmptyTypes\",\"type\":\"boolean\"},{\"name\":\"countObjects\",\"type\":\"boolean\"}]}";
        [AvroRecordField("uri")]
        public string Uri { get; set; }
        [AvroRecordField("scope")]
        public Energistics.Etp.v12.Datatypes.Object.ContextScopeKind Scope { get; set; }
        [AvroRecordField("returnEmptyTypes")]
        public bool ReturnEmptyTypes { get; set; }
        [AvroRecordField("countObjects")]
        public bool CountObjects { get; set; }
    }
}
