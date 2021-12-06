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

namespace Energistics.Etp.v12.Datatypes.DataArrayTypes
{
    [AvroNamedType("PutDataArraysType", "Energistics.Etp.v12.Datatypes.DataArrayTypes")]
    public partial class PutDataArraysType
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.DataArrayTypes.PutDataArraysType\",\"fields\":[{\"name\":\"uid\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"pathInResource\",\"type\":\"string\"}]}},{\"name\":\"array\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArray\",\"fields\":[{\"name\":\"dimensions\",\"type\":{\"type\":\"array\",\"items\":\"long\"}},{\"name\":\"data\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.AnyArray\",\"fields\":[{\"name\":\"item\",\"type\":[{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"boolean\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"int\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"long\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"float\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"double\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfString\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"string\"}}]},\"bytes\"]}]}}]}},{\"name\":\"customData\",\"type\":{\"type\":\"map\",\"values\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.DataValue\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"boolean\",\"int\",\"long\",\"float\",\"double\",\"string\",\"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfNullableBoolean\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"boolean\"]}}]},\"Energistics.Etp.v12.Datatypes.ArrayOfInt\",{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfNullableInt\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"int\"]}}]},\"Energistics.Etp.v12.Datatypes.ArrayOfLong\",{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfNullableLong\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"long\"]}}]},\"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"Energistics.Etp.v12.Datatypes.ArrayOfString\",{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfBytes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"bytes\"}}]},\"bytes\",{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.AnySparseArray\",\"fields\":[{\"name\":\"slices\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.AnySubarray\",\"fields\":[{\"name\":\"start\",\"type\":\"long\"},{\"name\":\"slice\",\"type\":\"Energistics.Etp.v12.Datatypes.AnyArray\"}]}}}]}]}]}}}]}";
        [AvroRecordField("uid")]
        public Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier Uid { get; set; }
        [AvroRecordField("array")]
        public Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArray Array { get; set; }
        [AvroRecordField("customData")]
        public IDictionary<string, Energistics.Etp.v12.Datatypes.DataValue> CustomData { get; set; }
    }
}
