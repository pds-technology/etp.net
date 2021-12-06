//----------------------------------------------------------------------- 
// ETP DevKit, 1.2
//
// Copyright 2019 Energistics
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

using Energistics.Avro.Encoding.TestObjects;
using System;
using System.Collections.Generic;

namespace Energistics.Avro.Encoding
{
    public static partial class TestData
    {
        private class RecordTestCase<TAvroObject> : TestCase<IAvroRecord>
            where TAvroObject : class, IAvroRecord, new()
        {
            public RecordTestCase()
            {
                AvroEncode = (t, encoder) => encoder.EncodeAvroObject<TAvroObject>(t.Value);
                AvroDecode = (t, decoder) => decoder.DecodeAvroObject<TAvroObject>();
            }
        }

        public static TestCase<IAvroRecord>[] Record => new TestCase<IAvroRecord>[]
        {
            TestSimpleRecord, TestComplexRecord,
            EmptyRecord,
            BooleanRecord, IntRecord, LongRecord, FloatRecord, DoubleRecord, StringRecord, BytesRecord, EnumRecord, FixedRecord, RecordRecord,
            ArrayOfBooleanRecord, ArrayOfIntRecord, ArrayOfLongRecord, ArrayOfFloatRecord, ArrayOfDoubleRecord, ArrayOfStringRecord, ArrayOfBytesRecord, ArrayOfEnumRecord, ArrayOfFixedRecord, ArrayOfRecordRecord,
            MapOfBooleanRecord, MapOfIntRecord, MapOfLongRecord, MapOfFloatRecord, MapOfDoubleRecord, MapOfStringRecord, MapOfBytesRecord, MapOfEnumRecord, MapOfFixedRecord, MapOfRecordRecord,
            NullableBooleanNullFirstRecordValue, NullableIntNullFirstRecordValue, NullableLongNullFirstRecordValue, NullableFloatNullFirstRecordValue, NullableDoubleNullFirstRecordValue, NullableStringNullFirstRecordValue, NullableBytesNullFirstRecordValue, NullableEnumNullFirstRecordValue, NullableFixedNullFirstRecordValue, NullableRecordNullFirstRecordValue,
            NullableBooleanNullFirstRecordNull, NullableIntNullFirstRecordNull, NullableLongNullFirstRecordNull, NullableFloatNullFirstRecordNull, NullableDoubleNullFirstRecordNull, NullableStringNullFirstRecordNull, NullableBytesNullFirstRecordNull, NullableEnumNullFirstRecordNull, NullableFixedNullFirstRecordNull, NullableRecordNullFirstRecordNull,
            NullableBooleanValueFirstRecordValue, NullableIntValueFirstRecordValue, NullableLongValueFirstRecordValue, NullableFloatValueFirstRecordValue, NullableDoubleValueFirstRecordValue, NullableStringValueFirstRecordValue, NullableBytesValueFirstRecordValue, NullableEnumValueFirstRecordValue, NullableFixedValueFirstRecordValue, NullableRecordValueFirstRecordValue,
            NullableBooleanValueFirstRecordNull, NullableIntValueFirstRecordNull, NullableLongValueFirstRecordNull, NullableFloatValueFirstRecordNull, NullableDoubleValueFirstRecordNull, NullableStringValueFirstRecordNull, NullableBytesValueFirstRecordNull, NullableEnumValueFirstRecordNull, NullableFixedValueFirstRecordNull, NullableRecordValueFirstRecordNull,
            ChoiceOfIntArrayMapEnumFixedRecordRecordInt, ChoiceOfIntArrayMapEnumFixedRecordRecordArray, ChoiceOfIntArrayMapEnumFixedRecordRecordMap, ChoiceOfIntArrayMapEnumFixedRecordRecordEnum, ChoiceOfIntArrayMapEnumFixedRecordRecordFixed, ChoiceOfIntArrayMapEnumFixedRecordRecordRecord,
        };

        public static TestCase<IAvroRecord> TestSimpleRecord => new RecordTestCase<TestSimpleRecord>
        {
            Name = nameof(TestSimpleRecord),
            Value = new TestObjects.TestSimpleRecord { Test = "abc" },
            BinaryEncoding = new byte[] { 0x06, (byte)'a', (byte)'b', (byte)'c', },
            BinaryByteCount = 4L,
            JsonEncoding = "{\"test\":\"abc\"}",
            JsonByteCount = 14L,
        };

        public static TestCase<IAvroRecord> TestComplexRecord => new RecordTestCase<TestComplexRecord>
        {
            Name = nameof(TestComplexRecord),
            Value = new TestObjects.TestComplexRecord { Test = "abc", Test2 = 2, },
            BinaryEncoding = new byte[] { 0x06, (byte)'a', (byte)'b', (byte)'c', 0x04 },
            BinaryByteCount = 5L,
            JsonEncoding = "{\"test\":\"abc\",\"test2\":2}",
            JsonByteCount = 24L,
        };

        public static TestCase<IAvroRecord> EmptyRecord => new RecordTestCase<EmptyRecord>
        {
            Name = nameof(EmptyRecord),
            Value = new TestObjects.EmptyRecord { },
            BinaryEncoding = new byte[] { },
            BinaryByteCount = 0L,
            JsonEncoding = "{}",
            JsonByteCount = 2L,
        };

        public static TestCase<IAvroRecord> BooleanRecord => new RecordTestCase<BooleanRecord>
        {
            Name = nameof(BooleanRecord),
            Value = new TestObjects.BooleanRecord { Boolean = true, },
            BinaryEncoding = new byte[] { 0x01 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"boolean\":true}",
            JsonByteCount = 16L,
        };

        public static TestCase<IAvroRecord> IntRecord => new RecordTestCase<IntRecord>
        {
            Name = nameof(IntRecord),
            Value = new TestObjects.IntRecord { Int = 2, },
            BinaryEncoding = new byte[] { 0x04 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"int\":2}",
            JsonByteCount = 9L,
        };

        public static TestCase<IAvroRecord> LongRecord => new RecordTestCase<LongRecord>
        {
            Name = nameof(LongRecord),
            Value = new TestObjects.LongRecord { Long = 1L, },
            BinaryEncoding = new byte[] { 0x02 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"long\":1}",
            JsonByteCount = 10L,
        };

        public static TestCase<IAvroRecord> FloatRecord => new RecordTestCase<FloatRecord>
        {
            Name = nameof(FloatRecord),
            Value = new TestObjects.FloatRecord { Float = (float)Math.PI, },
            BinaryEncoding = new byte[] { 0xDB, 0x0F, 0x49, 0x40 },
            BinaryByteCount = 4L,
            JsonEncoding = "{\"float\":3.14159274}",
            JsonByteCount = 20L,
        };

        public static TestCase<IAvroRecord> DoubleRecord => new RecordTestCase<DoubleRecord>
        {
            Name = nameof(DoubleRecord),
            Value = new TestObjects.DoubleRecord { Double = Math.PI, },
            BinaryEncoding = new byte[] { 0x18, 0x2D, 0x44, 0x54, 0xFB, 0x21, 0x09, 0x40 },
            BinaryByteCount = 8L,
            JsonEncoding = "{\"double\":3.1415926535897931}",
            JsonByteCount = 29L,
        };

        public static TestCase<IAvroRecord> StringRecord => new RecordTestCase<StringRecord>
        {
            Name = nameof(StringRecord),
            Value = new TestObjects.StringRecord { String = "abc", },
            BinaryEncoding = new byte[] { 0x06, (byte)'a', (byte)'b', (byte)'c', },
            BinaryByteCount = 4L,
            JsonEncoding = "{\"string\":\"abc\"}",
            JsonByteCount = 16L,
        };

        public static TestCase<IAvroRecord> BytesRecord => new RecordTestCase<BytesRecord>
        {
            Name = nameof(BytesRecord),
            Value = new TestObjects.BytesRecord { Bytes = new byte[] { 0, 1, 2}, },
            BinaryEncoding = new byte[] { 0x06, 0x00, 0x01, 0x02 },
            BinaryByteCount = 4L,
            JsonEncoding = "{\"bytes\":\"\\u0000\\u0001\\u0002\"}",
            JsonByteCount = 30L,
        };

        public static TestCase<IAvroRecord> EnumRecord => new RecordTestCase<EnumRecord>
        {
            Name = nameof(EnumRecord),
            Value = new TestObjects.EnumRecord { Enum = TestEnum.value3, },
            BinaryEncoding = new byte[] { 0x04 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"enum\":\"value3\"}",
            JsonByteCount = 17L,
        };

        public static TestCase<IAvroRecord> FixedRecord => new RecordTestCase<FixedRecord>
        {
            Name = nameof(FixedRecord),
            Value = new TestObjects.FixedRecord { Fixed = new TestFixed { Bytes = new byte[] {0, 1, 2, 3} }, },
            BinaryEncoding = new byte[] { 0x00, 0x01, 0x02, 0x03 },
            BinaryByteCount = 4L,
            JsonEncoding = "{\"fixed\":\"\\u0000\\u0001\\u0002\\u0003\"}",
            JsonByteCount = 36L,
        };

        public static TestCase<IAvroRecord> RecordRecord => new RecordTestCase<RecordRecord>
        {
            Name = nameof(RecordRecord),
            Value = new TestObjects.RecordRecord { Record = new TestSimpleRecord { Test = "abc" }, },
            BinaryEncoding = new byte[] { 0x06, (byte)'a', (byte)'b', (byte)'c', },
            BinaryByteCount = 4L,
            JsonEncoding = "{\"record\":{\"test\":\"abc\"}}",
            JsonByteCount = 25L,
        };

        public static TestCase<IAvroRecord> ArrayOfBooleanRecord => new RecordTestCase<ArrayOfBooleanRecord>
        {
            Name = nameof(ArrayOfBooleanRecord),
            Value = new TestObjects.ArrayOfBooleanRecord { ArrayOfBoolean = new bool[] { true, false }, },
            BinaryEncoding = new byte[] { 0x04, 0x01, 0x00, 0x00 },
            BinaryByteCount = 4L,
            JsonEncoding = "{\"arrayOfBoolean\":[true,false]}",
            JsonByteCount = 31L,
        };

        public static TestCase<IAvroRecord> ArrayOfIntRecord => new RecordTestCase<ArrayOfIntRecord>
        {
            Name = nameof(ArrayOfIntRecord),
            Value = new TestObjects.ArrayOfIntRecord { ArrayOfInt = new int[] { -1, 0, 1, 64 }, },
            BinaryEncoding = new byte[] { 0x08, 0x01, 0x00, 0x02, 0x80, 0x01, 0x00 },
            BinaryByteCount = 7L,
            JsonEncoding = "{\"arrayOfInt\":[-1,0,1,64]}",
            JsonByteCount = 26L,
        };

        public static TestCase<IAvroRecord> ArrayOfLongRecord => new RecordTestCase<ArrayOfLongRecord>
        {
            Name = nameof(ArrayOfLongRecord),
            Value = new TestObjects.ArrayOfLongRecord { ArrayOfLong = new long[] { -1L, 0L, 1L, -36028797018963968L }, },
            BinaryEncoding = new byte[] { 0x08, 0x01, 0x00, 0x02, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0x00 },
            BinaryByteCount = 13L,
            JsonEncoding = "{\"arrayOfLong\":[-1,0,1,-36028797018963968]}",
            JsonByteCount = 43L,
        };

        public static TestCase<IAvroRecord> ArrayOfFloatRecord => new RecordTestCase<ArrayOfFloatRecord>
        {
            Name = nameof(ArrayOfFloatRecord),
            Value = new TestObjects.ArrayOfFloatRecord { ArrayOfFloat = new float[] { (float)Math.PI, 1e7F, float.NaN, float.PositiveInfinity, float.NegativeInfinity }, },
            BinaryEncoding = new byte[] { 0x0A, 0xDB, 0x0F, 0x49, 0x40, 0x80, 0x96, 0x18, 0x4B, 0x00, 0x00, 0xC0, 0xFF, 0x00, 0x00, 0x80, 0x7F, 0x00, 0x00, 0x80, 0xFF, 0x00 },
            BinaryByteCount = 22L,
            JsonEncoding = "{\"arrayOfFloat\":[3.14159274,10000000,null,1.7976931348623157E308,-1.7976931348623157E308]}",
            JsonByteCount = 90L,
        };

        public static TestCase<IAvroRecord> ArrayOfDoubleRecord => new RecordTestCase<ArrayOfDoubleRecord>
        {
            Name = nameof(ArrayOfDoubleRecord),
            Value = new TestObjects.ArrayOfDoubleRecord { ArrayOfDouble = new double[] { Math.PI, 1e7, double.NaN, double.PositiveInfinity, double.NegativeInfinity }, },
            BinaryEncoding = new byte[] { 0x0A, 0x18, 0x2D, 0x44, 0x54, 0xFB, 0x21, 0x09, 0x40, 0x00, 0x00, 0x00, 0x00, 0xD0, 0x12, 0x63, 0x41, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF8, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF0, 0x7F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF0, 0xFF, 0x00 },
            BinaryByteCount = 42L,
            JsonEncoding = "{\"arrayOfDouble\":[3.1415926535897931,10000000,null,1.7976931348623157E308,-1.7976931348623157E308]}",
            JsonByteCount = 99L,
        };

        public static TestCase<IAvroRecord> ArrayOfStringRecord => new RecordTestCase<ArrayOfStringRecord>
        {
            Name = nameof(ArrayOfStringRecord),
            Value = new TestObjects.ArrayOfStringRecord { ArrayOfString = new string[] { "test", "abc", "\u0000\u0001\u0002\u0003\u0004\u0005\u0006\u0007\b\t\n" }, },
            BinaryEncoding = new byte[] { 0x06, 0x08, (byte)'t', (byte)'e', (byte)'s', (byte)'t', 0x06, (byte)'a', (byte)'b', (byte)'c', 0x16, 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x00 },
            BinaryByteCount = 23L,
            JsonEncoding = "{\"arrayOfString\":[\"test\",\"abc\",\"\\u0000\\u0001\\u0002\\u0003\\u0004\\u0005\\u0006\\u0007\\b\\t\\n\"]}",
            JsonByteCount = 89L,
        };

        public static TestCase<IAvroRecord> ArrayOfBytesRecord => new RecordTestCase<ArrayOfBytesRecord>
        {
            Name = nameof(ArrayOfBytesRecord),
            Value = new TestObjects.ArrayOfBytesRecord { ArrayOfBytes = new byte[][] { new byte[] { 0, 1, 2 }, new byte[] { 3, 4, 5 } } },
            BinaryEncoding = new byte[] { 0x04, 0x06, 0x00, 0x01, 0x02, 0x06, 0x03, 0x04, 0x05, 0x00 },
            BinaryByteCount = 10L,
            JsonEncoding = "{\"arrayOfBytes\":[\"\\u0000\\u0001\\u0002\",\"\\u0003\\u0004\\u0005\"]}",
            JsonByteCount = 60L,
        };

        public static TestCase<IAvroRecord> ArrayOfEnumRecord => new RecordTestCase<ArrayOfEnumRecord>
        {
            Name = nameof(ArrayOfEnumRecord),
            Value = new TestObjects.ArrayOfEnumRecord { ArrayOfEnum = new TestEnum[] { TestEnum.value2, TestEnum.value3 }, },
            BinaryEncoding = new byte[] { 0x04, 0x02, 0x04, 0x00 },
            BinaryByteCount = 4L,
            JsonEncoding = "{\"arrayOfEnum\":[\"value2\",\"value3\"]}",
            JsonByteCount = 35L,
        };

        public static TestCase<IAvroRecord> ArrayOfFixedRecord => new RecordTestCase<ArrayOfFixedRecord>
        {
            Name = nameof(ArrayOfFixedRecord),
            Value = new TestObjects.ArrayOfFixedRecord { ArrayOfFixed = new TestFixed[] { new TestFixed { Bytes = new byte[] { 0, 1, 2, 3 } }, new TestFixed { Bytes = new byte[] { 4, 5, 6, 7 }, }, }, },
            BinaryEncoding = new byte[] { 0x04, 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x00 },
            BinaryByteCount = 10L,
            JsonEncoding = "{\"arrayOfFixed\":[\"\\u0000\\u0001\\u0002\\u0003\",\"\\u0004\\u0005\\u0006\\u0007\"]}",
            JsonByteCount = 72L,
        };

        public static TestCase<IAvroRecord> ArrayOfRecordRecord => new RecordTestCase<ArrayOfRecordRecord>
        {
            Name = nameof(ArrayOfRecordRecord),
            Value = new TestObjects.ArrayOfRecordRecord { ArrayOfRecord = new TestSimpleRecord[] { new TestSimpleRecord { Test = "abc" }, new TestSimpleRecord { Test = "def" } } },
            BinaryEncoding = new byte[] { 0x04, 0x06, (byte)'a', (byte)'b', (byte)'c', 0x06, (byte)'d', (byte)'e', (byte)'f', 0x00, },
            BinaryByteCount = 10L,
            JsonEncoding = "{\"arrayOfRecord\":[{\"test\":\"abc\"},{\"test\":\"def\"}]}",
            JsonByteCount = 49L,
        };

        public static TestCase<IAvroRecord> MapOfBooleanRecord => new RecordTestCase<MapOfBooleanRecord>
        {
            Name = nameof(MapOfBooleanRecord),
            Value = new TestObjects.MapOfBooleanRecord { MapOfBoolean = new Dictionary<string, bool> { ["a"] = true, ["b"] = false }, },
            BinaryEncoding = new byte[] { 0x04, 0x02, (byte)'a', 0x01, 0x02, (byte)'b', 0x00, 0x00 },
            BinaryByteCount = 8L,
            JsonEncoding = "{\"mapOfBoolean\":{\"a\":true,\"b\":false}}",
            JsonByteCount = 37L,
        };

        public static TestCase<IAvroRecord> MapOfIntRecord => new RecordTestCase<MapOfIntRecord>
        {
            Name = nameof(MapOfIntRecord),
            Value = new TestObjects.MapOfIntRecord { MapOfInt = new Dictionary<string, int> { ["a"] = -1, ["b"] = 0, ["c"] = 1, ["d"] = 64 }, },
            BinaryEncoding = new byte[] { 0x08, 0x02, (byte)'a', 0x01, 0x02, (byte)'b', 0x00, 0x02, (byte)'c', 0x02, 0x02, (byte)'d', 0x80, 0x01, 0x00 },
            BinaryByteCount = 15L,
            JsonEncoding = "{\"mapOfInt\":{\"a\":-1,\"b\":0,\"c\":1,\"d\":64}}",
            JsonByteCount = 40L,
        };

        public static TestCase<IAvroRecord> MapOfLongRecord => new RecordTestCase<MapOfLongRecord>
        {
            Name = nameof(MapOfLongRecord),
            Value = new TestObjects.MapOfLongRecord { MapOfLong = new Dictionary<string, long> { ["a"] = -1, ["b"] = 0, ["c"] = 1, ["d"] = -36028797018963968L }, },
            BinaryEncoding = new byte[] { 0x08, 0x02, (byte)'a', 0x01, 0x02, (byte)'b', 0x00, 0x02, (byte)'c', 0x02, 0x02, (byte)'d', 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x7F, 0x00 },
            BinaryByteCount = 21L,
            JsonEncoding = "{\"mapOfLong\":{\"a\":-1,\"b\":0,\"c\":1,\"d\":-36028797018963968}}",
            JsonByteCount = 57L,
        };

        public static TestCase<IAvroRecord> MapOfFloatRecord => new RecordTestCase<MapOfFloatRecord>
        {
            Name = nameof(MapOfFloatRecord),
            Value = new TestObjects.MapOfFloatRecord { MapOfFloat = new Dictionary<string, float> { ["a"] = (float)Math.PI, ["b"] = 1e7F, ["c"] = float.NaN, ["d"] = float.PositiveInfinity, ["e"] = float.NegativeInfinity }, },
            BinaryEncoding = new byte[] { 0x0A, 0x02, (byte)'a', 0xDB, 0x0F, 0x49, 0x40, 0x02, (byte)'b', 0x80, 0x96, 0x18, 0x4B, 0x02, (byte)'c', 0x00, 0x00, 0xC0, 0xFF, 0x02, (byte)'d', 0x00, 0x00, 0x80, 0x7F, 0x02, (byte)'e', 0x00, 0x00, 0x80, 0xFF, 0x00 },
            BinaryByteCount = 32L,
            JsonEncoding = "{\"mapOfFloat\":{\"a\":3.14159274,\"b\":10000000,\"c\":null,\"d\":1.7976931348623157E308,\"e\":-1.7976931348623157E308}}",
            JsonByteCount = 108L,
        };

        public static TestCase<IAvroRecord> MapOfDoubleRecord => new RecordTestCase<MapOfDoubleRecord>
        {
            Name = nameof(MapOfDoubleRecord),
            Value = new TestObjects.MapOfDoubleRecord { MapOfDouble = new Dictionary<string, double> { ["a"] = Math.PI, ["b"] = 1e7, ["c"] = double.NaN, ["d"] = double.PositiveInfinity, ["e"] = double.NegativeInfinity }, },
            BinaryEncoding = new byte[] { 0x0A, 0x02, (byte)'a', 0x18, 0x2D, 0x44, 0x54, 0xFB, 0x21, 0x09, 0x40, 0x02, (byte)'b', 0x00, 0x00, 0x00, 0x00, 0xD0, 0x12, 0x63, 0x41, 0x02, (byte)'c', 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF8, 0xFF, 0x02, (byte)'d', 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF0, 0x7F, 0x02, (byte)'e', 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF0, 0xFF, 0x00 },
            BinaryByteCount = 52L,
            JsonEncoding = "{\"mapOfDouble\":{\"a\":3.1415926535897931,\"b\":10000000,\"c\":null,\"d\":1.7976931348623157E308,\"e\":-1.7976931348623157E308}}",
            JsonByteCount = 117L,
        };

        public static TestCase<IAvroRecord> MapOfStringRecord => new RecordTestCase<MapOfStringRecord>
        {
            Name = nameof(MapOfStringRecord),
            Value = new TestObjects.MapOfStringRecord { MapOfString = new Dictionary<string, string> { ["a"] = "test", ["b"] = "abc", ["c"] = "\u0000\u0001\u0002\u0003\u0004\u0005\u0006\u0007\b\t\n" }, },
            BinaryEncoding = new byte[] { 0x06, 0x02, (byte)'a', 0x08, (byte)'t', (byte)'e', (byte)'s', (byte)'t', 0x02, (byte)'b', 0x06, (byte)'a', (byte)'b', (byte)'c', 0x02, (byte)'c', 0x16, 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x00 },
            BinaryByteCount = 29L,
            JsonEncoding = "{\"mapOfString\":{\"a\":\"test\",\"b\":\"abc\",\"c\":\"\\u0000\\u0001\\u0002\\u0003\\u0004\\u0005\\u0006\\u0007\\b\\t\\n\"}}",
            JsonByteCount = 99L,
        };

        public static TestCase<IAvroRecord> MapOfBytesRecord => new RecordTestCase<MapOfBytesRecord>
        {
            Name = nameof(MapOfBytesRecord),
            Value = new TestObjects.MapOfBytesRecord { MapOfBytes = new Dictionary<string, byte[]> { ["a"] = new byte[] { 0, 1, 2 }, ["b"] = new byte[] { 3, 4, 5 } }, },
            BinaryEncoding = new byte[] { 0x04, 0x02, (byte)'a', 0x06, 0x00, 0x01, 0x02, 0x02, (byte)'b', 0x06, 0x03, 0x04, 0x05, 0x00 },
            BinaryByteCount = 14L,
            JsonEncoding = "{\"mapOfBytes\":{\"a\":\"\\u0000\\u0001\\u0002\",\"b\":\"\\u0003\\u0004\\u0005\"}}",
            JsonByteCount = 66L,
        };

        public static TestCase<IAvroRecord> MapOfEnumRecord => new RecordTestCase<MapOfEnumRecord>
        {
            Name = nameof(MapOfEnumRecord),
            Value = new TestObjects.MapOfEnumRecord { MapOfEnum = new Dictionary<string, TestEnum> { ["a"] = TestEnum.value2, ["b"] = TestEnum.value3 }, },
            BinaryEncoding = new byte[] { 0x04, 0x02, (byte)'a', 0x02, 0x02, (byte)'b', 0x04, 0x00 },
            BinaryByteCount = 8L,
            JsonEncoding = "{\"mapOfEnum\":{\"a\":\"value2\",\"b\":\"value3\"}}",
            JsonByteCount = 41L,
        };

        public static TestCase<IAvroRecord> MapOfFixedRecord => new RecordTestCase<MapOfFixedRecord>
        {
            Name = nameof(MapOfFixedRecord),
            Value = new TestObjects.MapOfFixedRecord { MapOfFixed = new Dictionary<string, TestFixed> { ["a"] = new TestFixed { Bytes = new byte[] { 0, 1, 2, 3 } }, ["b"] = new TestFixed { Bytes = new byte[] { 4, 5, 6, 7 }, }, }, },
            BinaryEncoding = new byte[] { 0x04, 0x02, (byte)'a', 0x00, 0x01, 0x02, 0x03, 0x02, (byte)'b', 0x04, 0x05, 0x06, 0x07, 0x00 },
            BinaryByteCount = 14L,
            JsonEncoding = "{\"mapOfFixed\":{\"a\":\"\\u0000\\u0001\\u0002\\u0003\",\"b\":\"\\u0004\\u0005\\u0006\\u0007\"}}",
            JsonByteCount = 78L,
        };

        public static TestCase<IAvroRecord> MapOfRecordRecord => new RecordTestCase<MapOfRecordRecord>
        {
            Name = nameof(MapOfRecordRecord),
            Value = new TestObjects.MapOfRecordRecord { MapOfRecord = new Dictionary<string, TestSimpleRecord> { ["a"] = new TestSimpleRecord { Test = "abc" }, ["b"] = new TestSimpleRecord { Test = "def" } } },
            BinaryEncoding = new byte[] { 0x04, 0x02, (byte)'a', 0x06, (byte)'a', (byte)'b', (byte)'c', 0x02, (byte)'b', 0x06, (byte)'d', (byte)'e', (byte)'f', 0x00, },
            BinaryByteCount = 14L,
            JsonEncoding = "{\"mapOfRecord\":{\"a\":{\"test\":\"abc\"},\"b\":{\"test\":\"def\"}}}",
            JsonByteCount = 55L,
        };

        public static TestCase<IAvroRecord> NullableBooleanNullFirstRecordValue => new RecordTestCase<NullableBooleanNullFirstRecord>
        {
            Name = nameof(NullableBooleanNullFirstRecordValue),
            Value = new TestObjects.NullableBooleanNullFirstRecord { NullableBooleanNullFirst = true, },
            BinaryEncoding = new byte[] { 0x02, 0x01 },
            BinaryByteCount = 2L,
            JsonEncoding = "{\"nullableBooleanNullFirst\":{\"boolean\":true}}",
            JsonByteCount = 45L,
        };

        public static TestCase<IAvroRecord> NullableIntNullFirstRecordValue => new RecordTestCase<NullableIntNullFirstRecord>
        {
            Name = nameof(NullableIntNullFirstRecordValue),
            Value = new TestObjects.NullableIntNullFirstRecord { NullableIntNullFirst = 2, },
            BinaryEncoding = new byte[] { 0x02, 0x04 },
            BinaryByteCount = 2L,
            JsonEncoding = "{\"nullableIntNullFirst\":{\"int\":2}}",
            JsonByteCount = 34L,
        };

        public static TestCase<IAvroRecord> NullableLongNullFirstRecordValue => new RecordTestCase<NullableLongNullFirstRecord>
        {
            Name = nameof(NullableLongNullFirstRecordValue),
            Value = new TestObjects.NullableLongNullFirstRecord { NullableLongNullFirst = 1L, },
            BinaryEncoding = new byte[] { 0x02, 0x02 },
            BinaryByteCount = 2L,
            JsonEncoding = "{\"nullableLongNullFirst\":{\"long\":1}}",
            JsonByteCount = 36L,
        };

        public static TestCase<IAvroRecord> NullableFloatNullFirstRecordValue => new RecordTestCase<NullableFloatNullFirstRecord>
        {
            Name = nameof(NullableFloatNullFirstRecordValue),
            Value = new TestObjects.NullableFloatNullFirstRecord { NullableFloatNullFirst = (float)Math.PI, },
            BinaryEncoding = new byte[] { 0x02, 0xDB, 0x0F, 0x49, 0x40 },
            BinaryByteCount = 5L,
            JsonEncoding = "{\"nullableFloatNullFirst\":{\"float\":3.14159274}}",
            JsonByteCount = 47L,
        };

        public static TestCase<IAvroRecord> NullableDoubleNullFirstRecordValue => new RecordTestCase<NullableDoubleNullFirstRecord>
        {
            Name = nameof(NullableDoubleNullFirstRecordValue),
            Value = new TestObjects.NullableDoubleNullFirstRecord { NullableDoubleNullFirst = Math.PI, },
            BinaryEncoding = new byte[] { 0x02, 0x18, 0x2D, 0x44, 0x54, 0xFB, 0x21, 0x09, 0x40 },
            BinaryByteCount = 9L,
            JsonEncoding = "{\"nullableDoubleNullFirst\":{\"double\":3.1415926535897931}}",
            JsonByteCount = 57L,
        };

        public static TestCase<IAvroRecord> NullableStringNullFirstRecordValue => new RecordTestCase<NullableStringNullFirstRecord>
        {
            Name = nameof(NullableStringNullFirstRecordValue),
            Value = new TestObjects.NullableStringNullFirstRecord { NullableStringNullFirst = "abc", },
            BinaryEncoding = new byte[] { 0x02, 0x06, (byte)'a', (byte)'b', (byte)'c', },
            BinaryByteCount = 5L,
            JsonEncoding = "{\"nullableStringNullFirst\":{\"string\":\"abc\"}}",
            JsonByteCount = 44L,
        };

        public static TestCase<IAvroRecord> NullableBytesNullFirstRecordValue => new RecordTestCase<NullableBytesNullFirstRecord>
        {
            Name = nameof(NullableBytesNullFirstRecordValue),
            Value = new TestObjects.NullableBytesNullFirstRecord { NullableBytesNullFirst = new byte[] { 0, 1, 2 }, },
            BinaryEncoding = new byte[] { 0x02, 0x06, 0x00, 0x01, 0x02 },
            BinaryByteCount = 5L,
            JsonEncoding = "{\"nullableBytesNullFirst\":{\"bytes\":\"\\u0000\\u0001\\u0002\"}}",
            JsonByteCount = 57L,
        };

        public static TestCase<IAvroRecord> NullableEnumNullFirstRecordValue => new RecordTestCase<NullableEnumNullFirstRecord>
        {
            Name = nameof(NullableEnumNullFirstRecordValue),
            Value = new TestObjects.NullableEnumNullFirstRecord { NullableEnumNullFirst = TestEnum.value3, },
            BinaryEncoding = new byte[] { 0x02, 0x04 },
            BinaryByteCount = 2L,
            JsonEncoding = "{\"nullableEnumNullFirst\":{\"Energistics.Avro.Encoding.TestObjects.TestEnum\":\"value3\"}}",
            JsonByteCount = 85L,
        };

        public static TestCase<IAvroRecord> NullableFixedNullFirstRecordValue => new RecordTestCase<NullableFixedNullFirstRecord>
        {
            Name = nameof(NullableFixedNullFirstRecordValue),
            Value = new TestObjects.NullableFixedNullFirstRecord { NullableFixedNullFirst = new TestFixed { Bytes = new byte[] { 0, 1, 2, 3 } }, },
            BinaryEncoding = new byte[] { 0x02, 0x00, 0x01, 0x02, 0x03 },
            BinaryByteCount = 5L,
            JsonEncoding = "{\"nullableFixedNullFirst\":{\"Energistics.Avro.Encoding.TestObjects.TestFixed\":\"\\u0000\\u0001\\u0002\\u0003\"}}",
            JsonByteCount = 105L,
        };

        public static TestCase<IAvroRecord> NullableRecordNullFirstRecordValue => new RecordTestCase<NullableRecordNullFirstRecord>
        {
            Name = nameof(NullableRecordNullFirstRecordValue),
            Value = new TestObjects.NullableRecordNullFirstRecord { NullableRecordNullFirst = new TestSimpleRecord { Test = "abc" }, },
            BinaryEncoding = new byte[] { 0x02, 0x06, (byte)'a', (byte)'b', (byte)'c', },
            BinaryByteCount = 5L,
            JsonEncoding = "{\"nullableRecordNullFirst\":{\"Energistics.Avro.Encoding.TestObjects.TestSimpleRecord\":{\"test\":\"abc\"}}}",
            JsonByteCount = 101L,
        };

        public static TestCase<IAvroRecord> NullableBooleanNullFirstRecordNull => new RecordTestCase<NullableBooleanNullFirstRecord>
        {
            Name = nameof(NullableBooleanNullFirstRecordNull),
            Value = new TestObjects.NullableBooleanNullFirstRecord { NullableBooleanNullFirst = null, },
            BinaryEncoding = new byte[] { 0x00 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"nullableBooleanNullFirst\":null}",
            JsonByteCount = 33L,
        };

        public static TestCase<IAvroRecord> NullableIntNullFirstRecordNull => new RecordTestCase<NullableIntNullFirstRecord>
        {
            Name = nameof(NullableIntNullFirstRecordNull),
            Value = new TestObjects.NullableIntNullFirstRecord { NullableIntNullFirst = null, },
            BinaryEncoding = new byte[] { 0x00 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"nullableIntNullFirst\":null}",
            JsonByteCount = 29L,
        };

        public static TestCase<IAvroRecord> NullableLongNullFirstRecordNull => new RecordTestCase<NullableLongNullFirstRecord>
        {
            Name = nameof(NullableLongNullFirstRecordNull),
            Value = new TestObjects.NullableLongNullFirstRecord { NullableLongNullFirst = null, },
            BinaryEncoding = new byte[] { 0x00 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"nullableLongNullFirst\":null}",
            JsonByteCount = 30L,
        };

        public static TestCase<IAvroRecord> NullableFloatNullFirstRecordNull => new RecordTestCase<NullableFloatNullFirstRecord>
        {
            Name = nameof(NullableFloatNullFirstRecordNull),
            Value = new TestObjects.NullableFloatNullFirstRecord { NullableFloatNullFirst = null, },
            BinaryEncoding = new byte[] { 0x00 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"nullableFloatNullFirst\":null}",
            JsonByteCount = 31L,
        };

        public static TestCase<IAvroRecord> NullableDoubleNullFirstRecordNull => new RecordTestCase<NullableDoubleNullFirstRecord>
        {
            Name = nameof(NullableDoubleNullFirstRecordNull),
            Value = new TestObjects.NullableDoubleNullFirstRecord { NullableDoubleNullFirst = null, },
            BinaryEncoding = new byte[] { 0x00 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"nullableDoubleNullFirst\":null}",
            JsonByteCount = 32L,
        };

        public static TestCase<IAvroRecord> NullableStringNullFirstRecordNull => new RecordTestCase<NullableStringNullFirstRecord>
        {
            Name = nameof(NullableStringNullFirstRecordNull),
            Value = new TestObjects.NullableStringNullFirstRecord { NullableStringNullFirst = null, },
            BinaryEncoding = new byte[] { 0x00 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"nullableStringNullFirst\":null}",
            JsonByteCount = 32L,
        };

        public static TestCase<IAvroRecord> NullableBytesNullFirstRecordNull => new RecordTestCase<NullableBytesNullFirstRecord>
        {
            Name = nameof(NullableBytesNullFirstRecordNull),
            Value = new TestObjects.NullableBytesNullFirstRecord { NullableBytesNullFirst = null, },
            BinaryEncoding = new byte[] { 0x00 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"nullableBytesNullFirst\":null}",
            JsonByteCount = 31L,
        };

        public static TestCase<IAvroRecord> NullableEnumNullFirstRecordNull => new RecordTestCase<NullableEnumNullFirstRecord>
        {
            Name = nameof(NullableEnumNullFirstRecordNull),
            Value = new TestObjects.NullableEnumNullFirstRecord { NullableEnumNullFirst = null, },
            BinaryEncoding = new byte[] { 0x00 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"nullableEnumNullFirst\":null}",
            JsonByteCount = 30L,
        };

        public static TestCase<IAvroRecord> NullableFixedNullFirstRecordNull => new RecordTestCase<NullableFixedNullFirstRecord>
        {
            Name = nameof(NullableFixedNullFirstRecordNull),
            Value = new TestObjects.NullableFixedNullFirstRecord { NullableFixedNullFirst = null, },
            BinaryEncoding = new byte[] { 0x00 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"nullableFixedNullFirst\":null}",
            JsonByteCount = 31L,
        };

        public static TestCase<IAvroRecord> NullableRecordNullFirstRecordNull => new RecordTestCase<NullableRecordNullFirstRecord>
        {
            Name = nameof(NullableRecordNullFirstRecordNull),
            Value = new TestObjects.NullableRecordNullFirstRecord { NullableRecordNullFirst = null, },
            BinaryEncoding = new byte[] { 0x00 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"nullableRecordNullFirst\":null}",
            JsonByteCount = 32L,
        };

        public static TestCase<IAvroRecord> NullableBooleanValueFirstRecordValue => new RecordTestCase<NullableBooleanValueFirstRecord>
        {
            Name = nameof(NullableBooleanValueFirstRecordValue),
            Value = new TestObjects.NullableBooleanValueFirstRecord { NullableBooleanValueFirst = true, },
            BinaryEncoding = new byte[] { 0x00, 0x01 },
            BinaryByteCount = 2L,
            JsonEncoding = "{\"nullableBooleanValueFirst\":{\"boolean\":true}}",
            JsonByteCount = 46L,
        };

        public static TestCase<IAvroRecord> NullableIntValueFirstRecordValue => new RecordTestCase<NullableIntValueFirstRecord>
        {
            Name = nameof(NullableIntValueFirstRecordValue),
            Value = new TestObjects.NullableIntValueFirstRecord { NullableIntValueFirst = 2, },
            BinaryEncoding = new byte[] { 0x00, 0x04 },
            BinaryByteCount = 2L,
            JsonEncoding = "{\"nullableIntValueFirst\":{\"int\":2}}",
            JsonByteCount = 35L,
        };

        public static TestCase<IAvroRecord> NullableLongValueFirstRecordValue => new RecordTestCase<NullableLongValueFirstRecord>
        {
            Name = nameof(NullableLongValueFirstRecordValue),
            Value = new TestObjects.NullableLongValueFirstRecord { NullableLongValueFirst = 1L, },
            BinaryEncoding = new byte[] { 0x00, 0x02 },
            BinaryByteCount = 2L,
            JsonEncoding = "{\"nullableLongValueFirst\":{\"long\":1}}",
            JsonByteCount = 37L,
        };

        public static TestCase<IAvroRecord> NullableFloatValueFirstRecordValue => new RecordTestCase<NullableFloatValueFirstRecord>
        {
            Name = nameof(NullableFloatValueFirstRecordValue),
            Value = new TestObjects.NullableFloatValueFirstRecord { NullableFloatValueFirst = (float)Math.PI, },
            BinaryEncoding = new byte[] { 0x00, 0xDB, 0x0F, 0x49, 0x40 },
            BinaryByteCount = 5L,
            JsonEncoding = "{\"nullableFloatValueFirst\":{\"float\":3.14159274}}",
            JsonByteCount = 48L,
        };

        public static TestCase<IAvroRecord> NullableDoubleValueFirstRecordValue => new RecordTestCase<NullableDoubleValueFirstRecord>
        {
            Name = nameof(NullableDoubleValueFirstRecordValue),
            Value = new TestObjects.NullableDoubleValueFirstRecord { NullableDoubleValueFirst = Math.PI, },
            BinaryEncoding = new byte[] { 0x00, 0x18, 0x2D, 0x44, 0x54, 0xFB, 0x21, 0x09, 0x40 },
            BinaryByteCount = 9L,
            JsonEncoding = "{\"nullableDoubleValueFirst\":{\"double\":3.1415926535897931}}",
            JsonByteCount = 58L,
        };

        public static TestCase<IAvroRecord> NullableStringValueFirstRecordValue => new RecordTestCase<NullableStringValueFirstRecord>
        {
            Name = nameof(NullableStringValueFirstRecordValue),
            Value = new TestObjects.NullableStringValueFirstRecord { NullableStringValueFirst = "abc", },
            BinaryEncoding = new byte[] { 0x00, 0x06, (byte)'a', (byte)'b', (byte)'c', },
            BinaryByteCount = 5L,
            JsonEncoding = "{\"nullableStringValueFirst\":{\"string\":\"abc\"}}",
            JsonByteCount = 45L,
        };

        public static TestCase<IAvroRecord> NullableBytesValueFirstRecordValue => new RecordTestCase<NullableBytesValueFirstRecord>
        {
            Name = nameof(NullableBytesValueFirstRecordValue),
            Value = new TestObjects.NullableBytesValueFirstRecord { NullableBytesValueFirst = new byte[] { 0, 1, 2 }, },
            BinaryEncoding = new byte[] { 0x00, 0x06, 0x00, 0x01, 0x02 },
            BinaryByteCount = 5L,
            JsonEncoding = "{\"nullableBytesValueFirst\":{\"bytes\":\"\\u0000\\u0001\\u0002\"}}",
            JsonByteCount = 58L,
        };

        public static TestCase<IAvroRecord> NullableEnumValueFirstRecordValue => new RecordTestCase<NullableEnumValueFirstRecord>
        {
            Name = nameof(NullableEnumValueFirstRecordValue),
            Value = new TestObjects.NullableEnumValueFirstRecord { NullableEnumValueFirst = TestEnum.value3, },
            BinaryEncoding = new byte[] { 0x00, 0x04 },
            BinaryByteCount = 2L,
            JsonEncoding = "{\"nullableEnumValueFirst\":{\"Energistics.Avro.Encoding.TestObjects.TestEnum\":\"value3\"}}",
            JsonByteCount = 86L,
        };

        public static TestCase<IAvroRecord> NullableFixedValueFirstRecordValue => new RecordTestCase<NullableFixedValueFirstRecord>
        {
            Name = nameof(NullableFixedValueFirstRecordValue),
            Value = new TestObjects.NullableFixedValueFirstRecord { NullableFixedValueFirst = new TestFixed { Bytes = new byte[] { 0, 1, 2, 3 } }, },
            BinaryEncoding = new byte[] { 0x00, 0x00, 0x01, 0x02, 0x03 },
            BinaryByteCount = 5L,
            JsonEncoding = "{\"nullableFixedValueFirst\":{\"Energistics.Avro.Encoding.TestObjects.TestFixed\":\"\\u0000\\u0001\\u0002\\u0003\"}}",
            JsonByteCount = 106L,
        };

        public static TestCase<IAvroRecord> NullableRecordValueFirstRecordValue => new RecordTestCase<NullableRecordValueFirstRecord>
        {
            Name = nameof(NullableRecordValueFirstRecordValue),
            Value = new TestObjects.NullableRecordValueFirstRecord { NullableRecordValueFirst = new TestSimpleRecord { Test = "abc" }, },
            BinaryEncoding = new byte[] { 0x00, 0x06, (byte)'a', (byte)'b', (byte)'c', },
            BinaryByteCount = 5L,
            JsonEncoding = "{\"nullableRecordValueFirst\":{\"Energistics.Avro.Encoding.TestObjects.TestSimpleRecord\":{\"test\":\"abc\"}}}",
            JsonByteCount = 102L,
        };

        public static TestCase<IAvroRecord> NullableBooleanValueFirstRecordNull => new RecordTestCase<NullableBooleanValueFirstRecord>
        {
            Name = nameof(NullableBooleanValueFirstRecordNull),
            Value = new TestObjects.NullableBooleanValueFirstRecord { NullableBooleanValueFirst = null, },
            BinaryEncoding = new byte[] { 0x02 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"nullableBooleanValueFirst\":null}",
            JsonByteCount = 34L,
        };

        public static TestCase<IAvroRecord> NullableIntValueFirstRecordNull => new RecordTestCase<NullableIntValueFirstRecord>
        {
            Name = nameof(NullableIntValueFirstRecordNull),
            Value = new TestObjects.NullableIntValueFirstRecord { NullableIntValueFirst = null, },
            BinaryEncoding = new byte[] { 0x02 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"nullableIntValueFirst\":null}",
            JsonByteCount = 30L,
        };

        public static TestCase<IAvroRecord> NullableLongValueFirstRecordNull => new RecordTestCase<NullableLongValueFirstRecord>
        {
            Name = nameof(NullableLongValueFirstRecordNull),
            Value = new TestObjects.NullableLongValueFirstRecord { NullableLongValueFirst = null, },
            BinaryEncoding = new byte[] { 0x02 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"nullableLongValueFirst\":null}",
            JsonByteCount = 31L,
        };

        public static TestCase<IAvroRecord> NullableFloatValueFirstRecordNull => new RecordTestCase<NullableFloatValueFirstRecord>
        {
            Name = nameof(NullableFloatValueFirstRecordNull),
            Value = new TestObjects.NullableFloatValueFirstRecord { NullableFloatValueFirst = null, },
            BinaryEncoding = new byte[] { 0x02 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"nullableFloatValueFirst\":null}",
            JsonByteCount = 32L,
        };

        public static TestCase<IAvroRecord> NullableDoubleValueFirstRecordNull => new RecordTestCase<NullableDoubleValueFirstRecord>
        {
            Name = nameof(NullableDoubleValueFirstRecordNull),
            Value = new TestObjects.NullableDoubleValueFirstRecord { NullableDoubleValueFirst = null, },
            BinaryEncoding = new byte[] { 0x02 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"nullableDoubleValueFirst\":null}",
            JsonByteCount = 33L,
        };

        public static TestCase<IAvroRecord> NullableStringValueFirstRecordNull => new RecordTestCase<NullableStringValueFirstRecord>
        {
            Name = nameof(NullableStringValueFirstRecordNull),
            Value = new TestObjects.NullableStringValueFirstRecord { NullableStringValueFirst = null, },
            BinaryEncoding = new byte[] { 0x02 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"nullableStringValueFirst\":null}",
            JsonByteCount = 33L,
        };

        public static TestCase<IAvroRecord> NullableBytesValueFirstRecordNull => new RecordTestCase<NullableBytesValueFirstRecord>
        {
            Name = nameof(NullableBytesValueFirstRecordNull),
            Value = new TestObjects.NullableBytesValueFirstRecord { NullableBytesValueFirst = null, },
            BinaryEncoding = new byte[] { 0x02 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"nullableBytesValueFirst\":null}",
            JsonByteCount = 32L,
        };

        public static TestCase<IAvroRecord> NullableEnumValueFirstRecordNull => new RecordTestCase<NullableEnumValueFirstRecord>
        {
            Name = nameof(NullableEnumValueFirstRecordNull),
            Value = new TestObjects.NullableEnumValueFirstRecord { NullableEnumValueFirst = null, },
            BinaryEncoding = new byte[] { 0x02 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"nullableEnumValueFirst\":null}",
            JsonByteCount = 31L,
        };

        public static TestCase<IAvroRecord> NullableFixedValueFirstRecordNull => new RecordTestCase<NullableFixedValueFirstRecord>
        {
            Name = nameof(NullableFixedValueFirstRecordNull),
            Value = new TestObjects.NullableFixedValueFirstRecord { NullableFixedValueFirst = null, },
            BinaryEncoding = new byte[] { 0x02 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"nullableFixedValueFirst\":null}",
            JsonByteCount = 32L,
        };

        public static TestCase<IAvroRecord> NullableRecordValueFirstRecordNull => new RecordTestCase<NullableRecordValueFirstRecord>
        {
            Name = nameof(NullableRecordValueFirstRecordNull),
            Value = new TestObjects.NullableRecordValueFirstRecord { NullableRecordValueFirst = null, },
            BinaryEncoding = new byte[] { 0x02 },
            BinaryByteCount = 1L,
            JsonEncoding = "{\"nullableRecordValueFirst\":null}",
            JsonByteCount = 33L,
        };

        public static TestCase<IAvroRecord> ChoiceOfIntArrayMapEnumFixedRecordRecordInt => new RecordTestCase<ChoiceOfIntArrayMapEnumFixedRecordRecord>
        {
            Name = nameof(ChoiceOfIntArrayMapEnumFixedRecordRecordInt),
            Value = new TestObjects.ChoiceOfIntArrayMapEnumFixedRecordRecord { ChoiceOfIntArrayMapEnumFixedRecord = 2, },
            BinaryEncoding = new byte[] { 0x00, 0x04 },
            BinaryByteCount = 2L,
            JsonEncoding = "{\"choiceOfIntArrayMapEnumFixedRecord\":{\"int\":2}}",
            JsonByteCount = 48L,
        };

        public static TestCase<IAvroRecord> ChoiceOfIntArrayMapEnumFixedRecordRecordArray => new RecordTestCase<ChoiceOfIntArrayMapEnumFixedRecordRecord>
        {
            Name = nameof(ChoiceOfIntArrayMapEnumFixedRecordRecordArray),
            Value = new TestObjects.ChoiceOfIntArrayMapEnumFixedRecordRecord { ChoiceOfIntArrayMapEnumFixedRecord = new int[] { -1, 0, 1, 64 }, },
            BinaryEncoding = new byte[] { 0x02, 0x08, 0x01, 0x00, 0x02, 0x80, 0x01, 0x00 },
            BinaryByteCount = 8L,
            JsonEncoding = "{\"choiceOfIntArrayMapEnumFixedRecord\":{\"array\":[-1,0,1,64]}}",
            JsonByteCount = 60L,
        };

        public static TestCase<IAvroRecord> ChoiceOfIntArrayMapEnumFixedRecordRecordMap => new RecordTestCase<ChoiceOfIntArrayMapEnumFixedRecordRecord>
        {
            Name = nameof(ChoiceOfIntArrayMapEnumFixedRecordRecordMap),
            Value = new TestObjects.ChoiceOfIntArrayMapEnumFixedRecordRecord { ChoiceOfIntArrayMapEnumFixedRecord = new Dictionary<string, int> { ["a"] = -1, ["b"] = 0, ["c"] = 1, ["d"] = 64 }, },
            BinaryEncoding = new byte[] { 0x04, 0x08, 0x02, (byte)'a', 0x01, 0x02, (byte)'b', 0x00, 0x02, (byte)'c', 0x02, 0x02, (byte)'d', 0x80, 0x01, 0x00 },
            BinaryByteCount = 16L,
            JsonEncoding = "{\"choiceOfIntArrayMapEnumFixedRecord\":{\"map\":{\"a\":-1,\"b\":0,\"c\":1,\"d\":64}}}",
            JsonByteCount = 74L,
        };

        public static TestCase<IAvroRecord> ChoiceOfIntArrayMapEnumFixedRecordRecordEnum => new RecordTestCase<ChoiceOfIntArrayMapEnumFixedRecordRecord>
        {
            Name = nameof(ChoiceOfIntArrayMapEnumFixedRecordRecordEnum),
            Value = new TestObjects.ChoiceOfIntArrayMapEnumFixedRecordRecord { ChoiceOfIntArrayMapEnumFixedRecord = TestEnum.value3, },
            BinaryEncoding = new byte[] { 0x06, 0x04 },
            BinaryByteCount = 2L,
            JsonEncoding = "{\"choiceOfIntArrayMapEnumFixedRecord\":{\"Energistics.Avro.Encoding.TestObjects.TestEnum\":\"value3\"}}",
            JsonByteCount = 98L,
        };

        public static TestCase<IAvroRecord> ChoiceOfIntArrayMapEnumFixedRecordRecordFixed => new RecordTestCase<ChoiceOfIntArrayMapEnumFixedRecordRecord>
        {
            Name = nameof(ChoiceOfIntArrayMapEnumFixedRecordRecordFixed),
            Value = new TestObjects.ChoiceOfIntArrayMapEnumFixedRecordRecord { ChoiceOfIntArrayMapEnumFixedRecord = new TestFixed { Bytes = new byte[] { 0, 1, 2, 3 } }, },
            BinaryEncoding = new byte[] { 0x08, 0x00, 0x01, 0x02, 0x03 },
            BinaryByteCount = 5L,
            JsonEncoding = "{\"choiceOfIntArrayMapEnumFixedRecord\":{\"Energistics.Avro.Encoding.TestObjects.TestFixed\":\"\\u0000\\u0001\\u0002\\u0003\"}}",
            JsonByteCount = 117L,
        };

        public static TestCase<IAvroRecord> ChoiceOfIntArrayMapEnumFixedRecordRecordRecord => new RecordTestCase<ChoiceOfIntArrayMapEnumFixedRecordRecord>
        {
            Name = nameof(ChoiceOfIntArrayMapEnumFixedRecordRecordRecord),
            Value = new TestObjects.ChoiceOfIntArrayMapEnumFixedRecordRecord { ChoiceOfIntArrayMapEnumFixedRecord = new TestSimpleRecord { Test = "abc" }, },
            BinaryEncoding = new byte[] { 0x0A, 0x06, (byte)'a', (byte)'b', (byte)'c', },
            BinaryByteCount = 5L,
            JsonEncoding = "{\"choiceOfIntArrayMapEnumFixedRecord\":{\"Energistics.Avro.Encoding.TestObjects.TestSimpleRecord\":{\"test\":\"abc\"}}}",
            JsonByteCount = 112L,
        };
    }
}
