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

namespace Energistics.Etp.v12.Protocol.DataArray
{
    [AvroNamedType("PutUninitializedDataArrays", "Energistics.Etp.v12.Protocol.DataArray")]
    public partial class PutUninitializedDataArrays
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Protocol.DataArray.PutUninitializedDataArrays\",\"fields\":[{\"name\":\"dataArrays\",\"type\":{\"type\":\"map\",\"values\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.DataArrayTypes.PutUninitializedDataArrayType\",\"fields\":[{\"name\":\"uid\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"pathInResource\",\"type\":\"string\"}]}},{\"name\":\"metadata\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayMetadata\",\"fields\":[{\"name\":\"dimensions\",\"type\":{\"type\":\"array\",\"items\":\"long\"}},{\"name\":\"preferredSubarrayDimensions\",\"type\":{\"type\":\"array\",\"items\":\"long\"}},{\"name\":\"transportArrayType\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.AnyArrayType\",\"type\":\"enum\",\"symbols\":[\"arrayOfBoolean\",\"arrayOfInt\",\"arrayOfLong\",\"arrayOfFloat\",\"arrayOfDouble\",\"arrayOfString\",\"bytes\"]}},{\"name\":\"logicalArrayType\",\"type\":{\"name\":\"Energistics.Etp.v12.Datatypes.AnyLogicalArrayType\",\"type\":\"enum\",\"symbols\":[\"arrayOfBoolean\",\"arrayOfInt8\",\"arrayOfUInt8\",\"arrayOfInt16LE\",\"arrayOfInt32LE\",\"arrayOfInt64LE\",\"arrayOfUInt16LE\",\"arrayOfUInt32LE\",\"arrayOfUInt64LE\",\"arrayOfFloat32LE\",\"arrayOfDouble64LE\",\"arrayOfInt16BE\",\"arrayOfInt32BE\",\"arrayOfInt64BE\",\"arrayOfUInt16BE\",\"arrayOfUInt32BE\",\"arrayOfUInt64BE\",\"arrayOfFloat32BE\",\"arrayOfDouble64BE\",\"arrayOfString\",\"arrayOfCustom\"]}},{\"name\":\"storeLastWrite\",\"type\":\"long\"},{\"name\":\"storeCreated\",\"type\":\"long\"},{\"name\":\"customData\",\"type\":{\"type\":\"map\",\"values\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.DataValue\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"boolean\",\"int\",\"long\",\"float\",\"double\",\"string\",{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"boolean\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfNullableBoolean\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"boolean\"]}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"int\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfNullableInt\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"int\"]}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"long\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfNullableLong\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"long\"]}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"float\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"double\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfString\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"string\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfBytes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"bytes\"}}]},\"bytes\",{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.AnySparseArray\",\"fields\":[{\"name\":\"slices\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.AnySubarray\",\"fields\":[{\"name\":\"start\",\"type\":\"long\"},{\"name\":\"slice\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.AnyArray\",\"fields\":[{\"name\":\"item\",\"type\":[\"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"Energistics.Etp.v12.Datatypes.ArrayOfString\",\"bytes\"]}]}}]}}}]}]}]}}}]}}]}}}]}";
        [AvroRecordField("dataArrays")]
        public IDictionary<string, Energistics.Etp.v12.Datatypes.DataArrayTypes.PutUninitializedDataArrayType> DataArrays { get; set; }
    }
}
