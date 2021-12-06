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

namespace Energistics.Etp.v12.Protocol.DiscoveryQuery
{
    [AvroNamedType("FindResources", "Energistics.Etp.v12.Protocol.DiscoveryQuery")]
    public partial class FindResources
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Protocol.DiscoveryQuery.FindResources\",\"fields\":[{\"name\":\"context\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.Object.ContextInfo\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"depth\",\"type\":\"int\"},{\"name\":\"dataObjectTypes\",\"type\":{\"type\":\"array\",\"items\":\"string\"}},{\"name\":\"navigableEdges\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.Object.RelationshipKind\",\"type\":\"enum\",\"symbols\":[\"Primary\",\"Secondary\",\"Both\"]}},{\"name\":\"includeSecondaryTargets\",\"type\":\"boolean\"},{\"name\":\"includeSecondarySources\",\"type\":\"boolean\"}]}},{\"name\":\"scope\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.Object.ContextScopeKind\",\"type\":\"enum\",\"symbols\":[\"self\",\"sources\",\"targets\",\"sourcesOrSelf\",\"targetsOrSelf\"]}},{\"name\":\"storeLastWriteFilter\",\"type\":[\"null\",\"long\"]},{\"name\":\"activeStatusFilter\",\"type\":[\"null\",{\"name\":\"Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind\",\"type\":\"enum\",\"symbols\":[\"Active\",\"Inactive\"]}]}]}";
        [AvroRecordField("context")]
        public Energistics.Etp.v12.Datatypes.Object.ContextInfo Context { get; set; }
        [AvroRecordField("scope")]
        public Energistics.Etp.v12.Datatypes.Object.ContextScopeKind Scope { get; set; }
        [AvroRecordField("storeLastWriteFilter")]
        [AvroNullable(true, "long")]
        public System.DateTime? StoreLastWriteFilter { get; set; }
        [AvroRecordField("activeStatusFilter")]
        [AvroNullable(true, "Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind")]
        public Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind? ActiveStatusFilter { get; set; }
    }
}
