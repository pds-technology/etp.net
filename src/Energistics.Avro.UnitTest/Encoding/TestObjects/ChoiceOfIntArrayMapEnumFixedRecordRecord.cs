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

namespace Energistics.Avro.Encoding.TestObjects
{
    [AvroNamedType("choiceOfIntArrayMapEnumFixedRecordRecord", "Energistics.Avro.Encoding.TestObjects")]
    public partial class ChoiceOfIntArrayMapEnumFixedRecordRecord
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Avro.Encoding.TestObjects.choiceOfIntArrayMapEnumFixedRecordRecord\",\"fields\":[{\"name\":\"choiceOfIntArrayMapEnumFixedRecord\",\"type\":[\"int\",{\"type\":\"array\",\"items\":\"int\"},{\"type\":\"map\",\"values\":\"int\"},{\"name\":\"Energistics.Avro.Encoding.TestObjects.TestEnum\",\"type\":\"enum\",\"symbols\":[\"value1\",\"value2\",\"value3\",\"value4\",\"value5\"]},{\"name\":\"Energistics.Avro.Encoding.TestObjects.TestFixed\",\"type\":\"fixed\",\"size\":4},{\"type\":\"record\",\"name\":\"Energistics.Avro.Encoding.TestObjects.TestSimpleRecord\",\"fields\":[{\"name\":\"test\",\"type\":\"string\"}]}]}]}";
        [AvroRecordField("choiceOfIntArrayMapEnumFixedRecord")]
        [AvroChoice(new string[] { "int", "array", "map", "Energistics.Avro.Encoding.TestObjects.TestEnum", "Energistics.Avro.Encoding.TestObjects.TestFixed", "Energistics.Avro.Encoding.TestObjects.TestSimpleRecord" }, new Type[] { typeof(int), typeof(int), typeof(int), typeof(Energistics.Avro.Encoding.TestObjects.TestEnum), typeof(Energistics.Avro.Encoding.TestObjects.TestFixed), typeof(Energistics.Avro.Encoding.TestObjects.TestSimpleRecord) })]
        public object ChoiceOfIntArrayMapEnumFixedRecord { get; set; }
    }
}
