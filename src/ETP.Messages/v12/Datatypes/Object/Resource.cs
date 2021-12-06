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
    [AvroNamedType("Resource", "Energistics.Etp.v12.Datatypes.Object")]
    public partial class Resource
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.Object.Resource\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"alternateUris\",\"type\":{\"type\":\"array\",\"items\":\"string\"}},{\"name\":\"name\",\"type\":\"string\"},{\"name\":\"sourceCount\",\"type\":[\"null\",\"int\"]},{\"name\":\"targetCount\",\"type\":[\"null\",\"int\"]},{\"name\":\"lastChanged\",\"type\":\"long\"},{\"name\":\"storeLastWrite\",\"type\":\"long\"},{\"name\":\"storeCreated\",\"type\":\"long\"},{\"name\":\"activeStatus\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind\",\"type\":\"enum\",\"symbols\":[\"Active\",\"Inactive\"]}},{\"name\":\"customData\",\"type\":{\"type\":\"map\",\"values\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.DataValue\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"boolean\",\"int\",\"long\",\"float\",\"double\",\"string\",{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"boolean\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfNullableBoolean\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"boolean\"]}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"int\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfNullableInt\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"int\"]}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"long\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfNullableLong\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"long\"]}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"float\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"double\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfString\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"string\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfBytes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"bytes\"}}]},\"bytes\",{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.AnySparseArray\",\"fields\":[{\"name\":\"slices\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.AnySubarray\",\"fields\":[{\"name\":\"start\",\"type\":\"long\"},{\"name\":\"slice\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.AnyArray\",\"fields\":[{\"name\":\"item\",\"type\":[\"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"Energistics.Etp.v12.Datatypes.ArrayOfString\",\"bytes\"]}]}}]}}}]}]}]}}}]}";
        [AvroRecordField("uri")]
        public string Uri { get; set; }
        [AvroRecordField("alternateUris")]
        public IList<string> AlternateUris { get; set; }
        [AvroRecordField("name")]
        public string Name { get; set; }
        [AvroRecordField("sourceCount")]
        [AvroNullable(true, "int")]
        public int? SourceCount { get; set; }
        [AvroRecordField("targetCount")]
        [AvroNullable(true, "int")]
        public int? TargetCount { get; set; }
        [AvroRecordField("lastChanged")]
        public System.DateTime LastChanged { get; set; }
        [AvroRecordField("storeLastWrite")]
        public System.DateTime StoreLastWrite { get; set; }
        [AvroRecordField("storeCreated")]
        public System.DateTime StoreCreated { get; set; }
        [AvroRecordField("activeStatus")]
        public Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind ActiveStatus { get; set; }
        [AvroRecordField("customData")]
        public IDictionary<string, Energistics.Etp.v12.Datatypes.DataValue> CustomData { get; set; }
    }
}
