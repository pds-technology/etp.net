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
    [AvroNamedType("TestRecord", "Energistics.Avro.Encoding.TestObjects")]
    public partial class TestRecord
    {
        public static string CanonicalSchema { get; } = "{\"type\":\"record\",\"name\":\"Energistics.Avro.Encoding.TestObjects.TestRecord\",\"fields\":[{\"name\":\"boolean\",\"type\":\"boolean\"},{\"name\":\"int\",\"type\":\"int\"},{\"name\":\"long\",\"type\":\"long\"},{\"name\":\"float\",\"type\":\"float\"},{\"name\":\"double\",\"type\":\"double\"},{\"name\":\"string\",\"type\":\"string\"},{\"name\":\"bytes\",\"type\":\"bytes\"},{\"name\":\"enum\",\"type\":{\"name\":\"Energistics.Avro.Encoding.TestObjects.TestEnum\",\"type\":\"enum\",\"symbols\":[\"value1\",\"value2\",\"value3\",\"value4\",\"value5\"]}},{\"name\":\"fixed\",\"type\":{\"name\":\"Energistics.Avro.Encoding.TestObjects.TestFixed\",\"type\":\"fixed\",\"size\":4}},{\"name\":\"record\",\"type\":{\"type\":\"record\",\"name\":\"Energistics.Avro.Encoding.TestObjects.TestSimpleRecord\",\"fields\":[{\"name\":\"test\",\"type\":\"string\"}]}},{\"name\":\"arrayOfBoolean\",\"type\":{\"type\":\"array\",\"items\":\"boolean\"}},{\"name\":\"arrayOfInt\",\"type\":{\"type\":\"array\",\"items\":\"int\"}},{\"name\":\"arrayOfLong\",\"type\":{\"type\":\"array\",\"items\":\"long\"}},{\"name\":\"arrayOfFloat\",\"type\":{\"type\":\"array\",\"items\":\"float\"}},{\"name\":\"arrayOfDouble\",\"type\":{\"type\":\"array\",\"items\":\"double\"}},{\"name\":\"arrayOfString\",\"type\":{\"type\":\"array\",\"items\":\"string\"}},{\"name\":\"arrayOfBytes\",\"type\":{\"type\":\"array\",\"items\":\"bytes\"}},{\"name\":\"arrayOfEnum\",\"type\":{\"type\":\"array\",\"items\":\"Energistics.Avro.Encoding.TestObjects.TestEnum\"}},{\"name\":\"arrayOfFixed\",\"type\":{\"type\":\"array\",\"items\":\"Energistics.Avro.Encoding.TestObjects.TestFixed\"}},{\"name\":\"arrayOfRecord\",\"type\":{\"type\":\"array\",\"items\":\"Energistics.Avro.Encoding.TestObjects.TestSimpleRecord\"}},{\"name\":\"mapOfBoolean\",\"type\":{\"type\":\"map\",\"values\":\"boolean\"}},{\"name\":\"mapOfInt\",\"type\":{\"type\":\"map\",\"values\":\"int\"}},{\"name\":\"mapOfLong\",\"type\":{\"type\":\"map\",\"values\":\"long\"}},{\"name\":\"mapOfFloat\",\"type\":{\"type\":\"map\",\"values\":\"float\"}},{\"name\":\"mapOfDouble\",\"type\":{\"type\":\"map\",\"values\":\"double\"}},{\"name\":\"mapOfString\",\"type\":{\"type\":\"map\",\"values\":\"string\"}},{\"name\":\"mapOfBytes\",\"type\":{\"type\":\"map\",\"values\":\"bytes\"}},{\"name\":\"mapOfEnum\",\"type\":{\"type\":\"map\",\"values\":\"Energistics.Avro.Encoding.TestObjects.TestEnum\"}},{\"name\":\"mapOfFixed\",\"type\":{\"type\":\"map\",\"values\":\"Energistics.Avro.Encoding.TestObjects.TestFixed\"}},{\"name\":\"mapOfRecord\",\"type\":{\"type\":\"map\",\"values\":\"Energistics.Avro.Encoding.TestObjects.TestSimpleRecord\"}},{\"name\":\"nullableBooleanNullFirst\",\"type\":[\"null\",\"boolean\"]},{\"name\":\"nullableIntNullFirst\",\"type\":[\"null\",\"int\"]},{\"name\":\"nullableLongNullFirst\",\"type\":[\"null\",\"long\"]},{\"name\":\"nullableFloatNullFirst\",\"type\":[\"null\",\"float\"]},{\"name\":\"nullableDoubleNullFirst\",\"type\":[\"null\",\"double\"]},{\"name\":\"nullableStringNullFirst\",\"type\":[\"null\",\"string\"]},{\"name\":\"nullableBytesNullFirst\",\"type\":[\"null\",\"bytes\"]},{\"name\":\"nullableEnumNullFirst\",\"type\":[\"null\",\"Energistics.Avro.Encoding.TestObjects.TestEnum\"]},{\"name\":\"nullableFixedNullFirst\",\"type\":[\"null\",\"Energistics.Avro.Encoding.TestObjects.TestFixed\"]},{\"name\":\"nullableRecordNullFirst\",\"type\":[\"null\",\"Energistics.Avro.Encoding.TestObjects.TestSimpleRecord\"]},{\"name\":\"nullableBooleanValueFirst\",\"type\":[\"boolean\",\"null\"]},{\"name\":\"nullableIntValueFirst\",\"type\":[\"int\",\"null\"]},{\"name\":\"nullableLongValueFirst\",\"type\":[\"long\",\"null\"]},{\"name\":\"nullableFloatValueFirst\",\"type\":[\"float\",\"null\"]},{\"name\":\"nullableDoubleValueFirst\",\"type\":[\"double\",\"null\"]},{\"name\":\"nullableStringValueFirst\",\"type\":[\"string\",\"null\"]},{\"name\":\"nullableBytesValueFirst\",\"type\":[\"bytes\",\"null\"]},{\"name\":\"nullableEnumValueFirst\",\"type\":[\"Energistics.Avro.Encoding.TestObjects.TestEnum\",\"null\"]},{\"name\":\"nullableFixedValueFirst\",\"type\":[\"Energistics.Avro.Encoding.TestObjects.TestFixed\",\"null\"]},{\"name\":\"nullableRecordValueFirst\",\"type\":[\"Energistics.Avro.Encoding.TestObjects.TestSimpleRecord\",\"null\"]},{\"name\":\"choiceOfIntArrayMapEnumFixedRecord\",\"type\":[\"int\",{\"type\":\"array\",\"items\":\"int\"},{\"type\":\"map\",\"values\":\"int\"},\"Energistics.Avro.Encoding.TestObjects.TestEnum\",\"Energistics.Avro.Encoding.TestObjects.TestFixed\",\"Energistics.Avro.Encoding.TestObjects.TestSimpleRecord\"]}]}";
        [AvroRecordField("boolean")]
        public bool Boolean { get; set; }
        [AvroRecordField("int")]
        public int Int { get; set; }
        [AvroRecordField("long")]
        public long Long { get; set; }
        [AvroRecordField("float")]
        public float Float { get; set; }
        [AvroRecordField("double")]
        public double Double { get; set; }
        [AvroRecordField("string")]
        public string String { get; set; }
        [AvroRecordField("bytes")]
        public byte[] Bytes { get; set; }
        [AvroRecordField("enum")]
        public Energistics.Avro.Encoding.TestObjects.TestEnum Enum { get; set; }
        [AvroRecordField("fixed")]
        public Energistics.Avro.Encoding.TestObjects.TestFixed Fixed { get; set; }
        [AvroRecordField("record")]
        public Energistics.Avro.Encoding.TestObjects.TestSimpleRecord Record { get; set; }
        [AvroRecordField("arrayOfBoolean")]
        public IList<bool> ArrayOfBoolean { get; set; }
        [AvroRecordField("arrayOfInt")]
        public IList<int> ArrayOfInt { get; set; }
        [AvroRecordField("arrayOfLong")]
        public IList<long> ArrayOfLong { get; set; }
        [AvroRecordField("arrayOfFloat")]
        public IList<float> ArrayOfFloat { get; set; }
        [AvroRecordField("arrayOfDouble")]
        public IList<double> ArrayOfDouble { get; set; }
        [AvroRecordField("arrayOfString")]
        public IList<string> ArrayOfString { get; set; }
        [AvroRecordField("arrayOfBytes")]
        public IList<byte[]> ArrayOfBytes { get; set; }
        [AvroRecordField("arrayOfEnum")]
        public IList<Energistics.Avro.Encoding.TestObjects.TestEnum> ArrayOfEnum { get; set; }
        [AvroRecordField("arrayOfFixed")]
        public IList<Energistics.Avro.Encoding.TestObjects.TestFixed> ArrayOfFixed { get; set; }
        [AvroRecordField("arrayOfRecord")]
        public IList<Energistics.Avro.Encoding.TestObjects.TestSimpleRecord> ArrayOfRecord { get; set; }
        [AvroRecordField("mapOfBoolean")]
        public IDictionary<string, bool> MapOfBoolean { get; set; }
        [AvroRecordField("mapOfInt")]
        public IDictionary<string, int> MapOfInt { get; set; }
        [AvroRecordField("mapOfLong")]
        public IDictionary<string, long> MapOfLong { get; set; }
        [AvroRecordField("mapOfFloat")]
        public IDictionary<string, float> MapOfFloat { get; set; }
        [AvroRecordField("mapOfDouble")]
        public IDictionary<string, double> MapOfDouble { get; set; }
        [AvroRecordField("mapOfString")]
        public IDictionary<string, string> MapOfString { get; set; }
        [AvroRecordField("mapOfBytes")]
        public IDictionary<string, byte[]> MapOfBytes { get; set; }
        [AvroRecordField("mapOfEnum")]
        public IDictionary<string, Energistics.Avro.Encoding.TestObjects.TestEnum> MapOfEnum { get; set; }
        [AvroRecordField("mapOfFixed")]
        public IDictionary<string, Energistics.Avro.Encoding.TestObjects.TestFixed> MapOfFixed { get; set; }
        [AvroRecordField("mapOfRecord")]
        public IDictionary<string, Energistics.Avro.Encoding.TestObjects.TestSimpleRecord> MapOfRecord { get; set; }
        [AvroRecordField("nullableBooleanNullFirst")]
        [AvroNullable(true, "boolean")]
        public bool? NullableBooleanNullFirst { get; set; }
        [AvroRecordField("nullableIntNullFirst")]
        [AvroNullable(true, "int")]
        public int? NullableIntNullFirst { get; set; }
        [AvroRecordField("nullableLongNullFirst")]
        [AvroNullable(true, "long")]
        public long? NullableLongNullFirst { get; set; }
        [AvroRecordField("nullableFloatNullFirst")]
        [AvroNullable(true, "float")]
        public float? NullableFloatNullFirst { get; set; }
        [AvroRecordField("nullableDoubleNullFirst")]
        [AvroNullable(true, "double")]
        public double? NullableDoubleNullFirst { get; set; }
        [AvroRecordField("nullableStringNullFirst")]
        [AvroNullable(true, "string")]
        public string NullableStringNullFirst { get; set; }
        [AvroRecordField("nullableBytesNullFirst")]
        [AvroNullable(true, "bytes")]
        public byte[] NullableBytesNullFirst { get; set; }
        [AvroRecordField("nullableEnumNullFirst")]
        [AvroNullable(true, "Energistics.Avro.Encoding.TestObjects.TestEnum")]
        public Energistics.Avro.Encoding.TestObjects.TestEnum? NullableEnumNullFirst { get; set; }
        [AvroRecordField("nullableFixedNullFirst")]
        [AvroNullable(true, "Energistics.Avro.Encoding.TestObjects.TestFixed")]
        public Energistics.Avro.Encoding.TestObjects.TestFixed NullableFixedNullFirst { get; set; }
        [AvroRecordField("nullableRecordNullFirst")]
        [AvroNullable(true, "Energistics.Avro.Encoding.TestObjects.TestSimpleRecord")]
        public Energistics.Avro.Encoding.TestObjects.TestSimpleRecord NullableRecordNullFirst { get; set; }
        [AvroRecordField("nullableBooleanValueFirst")]
        [AvroNullable(false, "boolean")]
        public bool? NullableBooleanValueFirst { get; set; }
        [AvroRecordField("nullableIntValueFirst")]
        [AvroNullable(false, "int")]
        public int? NullableIntValueFirst { get; set; }
        [AvroRecordField("nullableLongValueFirst")]
        [AvroNullable(false, "long")]
        public long? NullableLongValueFirst { get; set; }
        [AvroRecordField("nullableFloatValueFirst")]
        [AvroNullable(false, "float")]
        public float? NullableFloatValueFirst { get; set; }
        [AvroRecordField("nullableDoubleValueFirst")]
        [AvroNullable(false, "double")]
        public double? NullableDoubleValueFirst { get; set; }
        [AvroRecordField("nullableStringValueFirst")]
        [AvroNullable(false, "string")]
        public string NullableStringValueFirst { get; set; }
        [AvroRecordField("nullableBytesValueFirst")]
        [AvroNullable(false, "bytes")]
        public byte[] NullableBytesValueFirst { get; set; }
        [AvroRecordField("nullableEnumValueFirst")]
        [AvroNullable(false, "Energistics.Avro.Encoding.TestObjects.TestEnum")]
        public Energistics.Avro.Encoding.TestObjects.TestEnum? NullableEnumValueFirst { get; set; }
        [AvroRecordField("nullableFixedValueFirst")]
        [AvroNullable(false, "Energistics.Avro.Encoding.TestObjects.TestFixed")]
        public Energistics.Avro.Encoding.TestObjects.TestFixed NullableFixedValueFirst { get; set; }
        [AvroRecordField("nullableRecordValueFirst")]
        [AvroNullable(false, "Energistics.Avro.Encoding.TestObjects.TestSimpleRecord")]
        public Energistics.Avro.Encoding.TestObjects.TestSimpleRecord NullableRecordValueFirst { get; set; }
        [AvroRecordField("choiceOfIntArrayMapEnumFixedRecord")]
        [AvroChoice(new string[] { "int", "array", "map", "Energistics.Avro.Encoding.TestObjects.TestEnum", "Energistics.Avro.Encoding.TestObjects.TestFixed", "Energistics.Avro.Encoding.TestObjects.TestSimpleRecord" }, new Type[] { typeof(int), typeof(int), typeof(int), typeof(Energistics.Avro.Encoding.TestObjects.TestEnum), typeof(Energistics.Avro.Encoding.TestObjects.TestFixed), typeof(Energistics.Avro.Encoding.TestObjects.TestSimpleRecord) })]
        public object ChoiceOfIntArrayMapEnumFixedRecord { get; set; }
    }
}
