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
    [AvroNamedType("AnyArray", "Energistics.Datatypes")]
    public partial class AnyArray
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Datatypes.AnyArray\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",{\"type\":\"record\",\"name\":\"Energistics.Datatypes.ArrayOfBoolean\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"boolean\"}}]},\"bytes\",{\"type\":\"record\",\"name\":\"Energistics.Datatypes.ArrayOfInt\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"int\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Datatypes.ArrayOfLong\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"long\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Datatypes.ArrayOfFloat\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"float\"}}]},{\"type\":\"record\",\"name\":\"Energistics.Datatypes.ArrayOfDouble\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"double\"}}]}]}]}";
        [AvroRecordField("item")]
        [AvroChoice(new string[] { "null", "Energistics.Datatypes.ArrayOfBoolean", "bytes", "Energistics.Datatypes.ArrayOfInt", "Energistics.Datatypes.ArrayOfLong", "Energistics.Datatypes.ArrayOfFloat", "Energistics.Datatypes.ArrayOfDouble" }, new Type[] { null, typeof(Energistics.Etp.v11.Datatypes.ArrayOfBoolean), typeof(byte[]), typeof(Energistics.Etp.v11.Datatypes.ArrayOfInt), typeof(Energistics.Etp.v11.Datatypes.ArrayOfLong), typeof(Energistics.Etp.v11.Datatypes.ArrayOfFloat), typeof(Energistics.Etp.v11.Datatypes.ArrayOfDouble) })]
        public object Item { get; set; }
    }
}
