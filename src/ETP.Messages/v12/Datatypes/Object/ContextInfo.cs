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
    [AvroNamedType("ContextInfo", "Energistics.Etp.v12.Datatypes.Object")]
    public partial class ContextInfo
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.Object.ContextInfo\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"depth\",\"type\":\"int\"},{\"name\":\"dataObjectTypes\",\"type\":{\"type\":\"array\",\"items\":\"string\"}},{\"name\":\"navigableEdges\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.Object.RelationshipKind\",\"type\":\"enum\",\"symbols\":[\"Primary\",\"Secondary\",\"Both\"]}},{\"name\":\"includeSecondaryTargets\",\"type\":\"boolean\"},{\"name\":\"includeSecondarySources\",\"type\":\"boolean\"}]}";
        [AvroRecordField("uri")]
        public string Uri { get; set; }
        [AvroRecordField("depth")]
        public int Depth { get; set; }
        [AvroRecordField("dataObjectTypes")]
        public IList<string> DataObjectTypes { get; set; }
        [AvroRecordField("navigableEdges")]
        public Energistics.Etp.v12.Datatypes.Object.RelationshipKind NavigableEdges { get; set; }
        [AvroRecordField("includeSecondaryTargets")]
        public bool IncludeSecondaryTargets { get; set; }
        [AvroRecordField("includeSecondarySources")]
        public bool IncludeSecondarySources { get; set; }
    }
}
