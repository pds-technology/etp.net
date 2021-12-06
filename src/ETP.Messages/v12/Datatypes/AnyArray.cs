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

namespace Energistics.Etp.v12.Datatypes
{
    [AvroNamedType("AnyArray", "Energistics.Etp.v12.Datatypes")]
    public partial class AnyArray
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.AnyArray\",\"fields\":[{\"name\":\"item\",\"type\":[{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"boolean\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"int\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"long\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"float\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"double\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Etp.v12.Datatypes.ArrayOfString\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"string\"}}]},\"bytes\"]}]}";
        [AvroRecordField("item")]
        [AvroChoice(new string[] { "Energistics.Etp.v12.Datatypes.ArrayOfBoolean", "Energistics.Etp.v12.Datatypes.ArrayOfInt", "Energistics.Etp.v12.Datatypes.ArrayOfLong", "Energistics.Etp.v12.Datatypes.ArrayOfFloat", "Energistics.Etp.v12.Datatypes.ArrayOfDouble", "Energistics.Etp.v12.Datatypes.ArrayOfString", "bytes" }, new Type[] { typeof(Energistics.Etp.v12.Datatypes.ArrayOfBoolean), typeof(Energistics.Etp.v12.Datatypes.ArrayOfInt), typeof(Energistics.Etp.v12.Datatypes.ArrayOfLong), typeof(Energistics.Etp.v12.Datatypes.ArrayOfFloat), typeof(Energistics.Etp.v12.Datatypes.ArrayOfDouble), typeof(Energistics.Etp.v12.Datatypes.ArrayOfString), typeof(byte[]) })]
        public object Item { get; set; }
    }
}
