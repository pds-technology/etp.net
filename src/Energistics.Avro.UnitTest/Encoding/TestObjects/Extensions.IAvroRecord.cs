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
using Energistics.Avro.Encoding;

namespace Energistics.Avro.Encoding.TestObjects
{
    public partial class ArrayOfBooleanRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.arrayOfBooleanRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.arrayOfBooleanRecord", 1);
            encoder.EncodeRecordFieldName("arrayOfBoolean");
            encoder.EncodeArrayOfBoolean(ArrayOfBoolean);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.arrayOfBooleanRecord", 1);
            decoder.DecodeRecordFieldName("arrayOfBoolean");
            ArrayOfBoolean = decoder.DecodeArrayOfBoolean();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfBytesRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.arrayOfBytesRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.arrayOfBytesRecord", 1);
            encoder.EncodeRecordFieldName("arrayOfBytes");
            encoder.EncodeArrayOfBytes(ArrayOfBytes);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.arrayOfBytesRecord", 1);
            decoder.DecodeRecordFieldName("arrayOfBytes");
            ArrayOfBytes = decoder.DecodeArrayOfBytes();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfDoubleRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.arrayOfDoubleRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.arrayOfDoubleRecord", 1);
            encoder.EncodeRecordFieldName("arrayOfDouble");
            encoder.EncodeArrayOfDouble(ArrayOfDouble);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.arrayOfDoubleRecord", 1);
            decoder.DecodeRecordFieldName("arrayOfDouble");
            ArrayOfDouble = decoder.DecodeArrayOfDouble();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfEnumRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.arrayOfEnumRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.arrayOfEnumRecord", 1);
            encoder.EncodeRecordFieldName("arrayOfEnum");
            encoder.EncodeArrayOfEnum<Energistics.Avro.Encoding.TestObjects.TestEnum>(ArrayOfEnum);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.arrayOfEnumRecord", 1);
            decoder.DecodeRecordFieldName("arrayOfEnum");
            ArrayOfEnum = decoder.DecodeArrayOfEnum<Energistics.Avro.Encoding.TestObjects.TestEnum>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfFixedRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.arrayOfFixedRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.arrayOfFixedRecord", 1);
            encoder.EncodeRecordFieldName("arrayOfFixed");
            encoder.EncodeArrayOfAvroObject<Energistics.Avro.Encoding.TestObjects.TestFixed>(ArrayOfFixed);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.arrayOfFixedRecord", 1);
            decoder.DecodeRecordFieldName("arrayOfFixed");
            ArrayOfFixed = decoder.DecodeArrayOfAvroObject<Energistics.Avro.Encoding.TestObjects.TestFixed>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfFloatRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.arrayOfFloatRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.arrayOfFloatRecord", 1);
            encoder.EncodeRecordFieldName("arrayOfFloat");
            encoder.EncodeArrayOfFloat(ArrayOfFloat);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.arrayOfFloatRecord", 1);
            decoder.DecodeRecordFieldName("arrayOfFloat");
            ArrayOfFloat = decoder.DecodeArrayOfFloat();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfIntRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.arrayOfIntRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.arrayOfIntRecord", 1);
            encoder.EncodeRecordFieldName("arrayOfInt");
            encoder.EncodeArrayOfInt(ArrayOfInt);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.arrayOfIntRecord", 1);
            decoder.DecodeRecordFieldName("arrayOfInt");
            ArrayOfInt = decoder.DecodeArrayOfInt();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfLongRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.arrayOfLongRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.arrayOfLongRecord", 1);
            encoder.EncodeRecordFieldName("arrayOfLong");
            encoder.EncodeArrayOfLong(ArrayOfLong);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.arrayOfLongRecord", 1);
            decoder.DecodeRecordFieldName("arrayOfLong");
            ArrayOfLong = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfRecordRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.arrayOfRecordRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.arrayOfRecordRecord", 1);
            encoder.EncodeRecordFieldName("arrayOfRecord");
            encoder.EncodeArrayOfAvroObject<Energistics.Avro.Encoding.TestObjects.TestSimpleRecord>(ArrayOfRecord);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.arrayOfRecordRecord", 1);
            decoder.DecodeRecordFieldName("arrayOfRecord");
            ArrayOfRecord = decoder.DecodeArrayOfAvroObject<Energistics.Avro.Encoding.TestObjects.TestSimpleRecord>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfStringRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.arrayOfStringRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.arrayOfStringRecord", 1);
            encoder.EncodeRecordFieldName("arrayOfString");
            encoder.EncodeArrayOfString(ArrayOfString);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.arrayOfStringRecord", 1);
            decoder.DecodeRecordFieldName("arrayOfString");
            ArrayOfString = decoder.DecodeArrayOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class BooleanRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.booleanRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.booleanRecord", 1);
            encoder.EncodeRecordFieldName("boolean");
            encoder.EncodeBoolean(Boolean);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.booleanRecord", 1);
            decoder.DecodeRecordFieldName("boolean");
            Boolean = decoder.DecodeBoolean();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class BytesRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.bytesRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.bytesRecord", 1);
            encoder.EncodeRecordFieldName("bytes");
            encoder.EncodeBytes(Bytes);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.bytesRecord", 1);
            decoder.DecodeRecordFieldName("bytes");
            Bytes = decoder.DecodeBytes();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ChoiceOfIntArrayMapEnumFixedRecordRecord : IAvroRecord
    {
        private static ChoiceTypeConverter ChoiceOfIntArrayOfIntMapOfIntTestEnumTestFixedTestSimpleRecordTypeConverter { get; } = new ChoiceTypeConverter(new string[] { "int", "array", "map", "Energistics.Avro.Encoding.TestObjects.TestEnum", "Energistics.Avro.Encoding.TestObjects.TestFixed", "Energistics.Avro.Encoding.TestObjects.TestSimpleRecord" }, new Type[] { typeof(int), typeof(IList<int>), typeof(IDictionary<string, int>), typeof(Energistics.Avro.Encoding.TestObjects.TestEnum), typeof(Energistics.Avro.Encoding.TestObjects.TestFixed), typeof(Energistics.Avro.Encoding.TestObjects.TestSimpleRecord) });
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.choiceOfIntArrayMapEnumFixedRecordRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.choiceOfIntArrayMapEnumFixedRecordRecord", 1);
            encoder.EncodeRecordFieldName("choiceOfIntArrayMapEnumFixedRecord");
            encoder.EncodeChoiceOfIntArrayOfIntMapOfIntTestEnumTestFixedTestSimpleRecord(ChoiceOfIntArrayMapEnumFixedRecord, ChoiceOfIntArrayOfIntMapOfIntTestEnumTestFixedTestSimpleRecordTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.choiceOfIntArrayMapEnumFixedRecordRecord", 1);
            decoder.DecodeRecordFieldName("choiceOfIntArrayMapEnumFixedRecord");
            ChoiceOfIntArrayMapEnumFixedRecord = decoder.DecodeChoiceOfIntArrayOfIntMapOfIntTestEnumTestFixedTestSimpleRecord(ChoiceOfIntArrayOfIntMapOfIntTestEnumTestFixedTestSimpleRecordTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class DoubleRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.doubleRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.doubleRecord", 1);
            encoder.EncodeRecordFieldName("double");
            encoder.EncodeDouble(Double);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.doubleRecord", 1);
            decoder.DecodeRecordFieldName("double");
            Double = decoder.DecodeDouble();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class EmptyRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.emptyRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.emptyRecord", 0);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.emptyRecord", 0);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class EnumRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.enumRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.enumRecord", 1);
            encoder.EncodeRecordFieldName("enum");
            encoder.EncodeEnum<Energistics.Avro.Encoding.TestObjects.TestEnum>(Enum);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.enumRecord", 1);
            decoder.DecodeRecordFieldName("enum");
            Enum = decoder.DecodeEnum<Energistics.Avro.Encoding.TestObjects.TestEnum>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class FixedRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.fixedRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.fixedRecord", 1);
            encoder.EncodeRecordFieldName("fixed");
            encoder.EncodeAvroObject<Energistics.Avro.Encoding.TestObjects.TestFixed>(Fixed);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.fixedRecord", 1);
            decoder.DecodeRecordFieldName("fixed");
            Fixed = decoder.DecodeAvroObject<Energistics.Avro.Encoding.TestObjects.TestFixed>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class FloatRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.floatRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.floatRecord", 1);
            encoder.EncodeRecordFieldName("float");
            encoder.EncodeFloat(Float);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.floatRecord", 1);
            decoder.DecodeRecordFieldName("float");
            Float = decoder.DecodeFloat();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class IntRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.intRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.intRecord", 1);
            encoder.EncodeRecordFieldName("int");
            encoder.EncodeInt(Int);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.intRecord", 1);
            decoder.DecodeRecordFieldName("int");
            Int = decoder.DecodeInt();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class LongRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.longRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.longRecord", 1);
            encoder.EncodeRecordFieldName("long");
            encoder.EncodeLong(Long);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.longRecord", 1);
            decoder.DecodeRecordFieldName("long");
            Long = decoder.DecodeLong();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class MapOfBooleanRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.mapOfBooleanRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.mapOfBooleanRecord", 1);
            encoder.EncodeRecordFieldName("mapOfBoolean");
            encoder.EncodeMapOfBoolean(MapOfBoolean);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.mapOfBooleanRecord", 1);
            decoder.DecodeRecordFieldName("mapOfBoolean");
            MapOfBoolean = decoder.DecodeMapOfBoolean();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class MapOfBytesRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.mapOfBytesRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.mapOfBytesRecord", 1);
            encoder.EncodeRecordFieldName("mapOfBytes");
            encoder.EncodeMapOfBytes(MapOfBytes);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.mapOfBytesRecord", 1);
            decoder.DecodeRecordFieldName("mapOfBytes");
            MapOfBytes = decoder.DecodeMapOfBytes();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class MapOfDoubleRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.mapOfDoubleRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.mapOfDoubleRecord", 1);
            encoder.EncodeRecordFieldName("mapOfDouble");
            encoder.EncodeMapOfDouble(MapOfDouble);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.mapOfDoubleRecord", 1);
            decoder.DecodeRecordFieldName("mapOfDouble");
            MapOfDouble = decoder.DecodeMapOfDouble();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class MapOfEnumRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.mapOfEnumRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.mapOfEnumRecord", 1);
            encoder.EncodeRecordFieldName("mapOfEnum");
            encoder.EncodeMapOfEnum<Energistics.Avro.Encoding.TestObjects.TestEnum>(MapOfEnum);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.mapOfEnumRecord", 1);
            decoder.DecodeRecordFieldName("mapOfEnum");
            MapOfEnum = decoder.DecodeMapOfEnum<Energistics.Avro.Encoding.TestObjects.TestEnum>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class MapOfFixedRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.mapOfFixedRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.mapOfFixedRecord", 1);
            encoder.EncodeRecordFieldName("mapOfFixed");
            encoder.EncodeMapOfAvroObject<Energistics.Avro.Encoding.TestObjects.TestFixed>(MapOfFixed);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.mapOfFixedRecord", 1);
            decoder.DecodeRecordFieldName("mapOfFixed");
            MapOfFixed = decoder.DecodeMapOfAvroObject<Energistics.Avro.Encoding.TestObjects.TestFixed>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class MapOfFloatRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.mapOfFloatRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.mapOfFloatRecord", 1);
            encoder.EncodeRecordFieldName("mapOfFloat");
            encoder.EncodeMapOfFloat(MapOfFloat);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.mapOfFloatRecord", 1);
            decoder.DecodeRecordFieldName("mapOfFloat");
            MapOfFloat = decoder.DecodeMapOfFloat();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class MapOfIntRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.mapOfIntRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.mapOfIntRecord", 1);
            encoder.EncodeRecordFieldName("mapOfInt");
            encoder.EncodeMapOfInt(MapOfInt);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.mapOfIntRecord", 1);
            decoder.DecodeRecordFieldName("mapOfInt");
            MapOfInt = decoder.DecodeMapOfInt();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class MapOfLongRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.mapOfLongRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.mapOfLongRecord", 1);
            encoder.EncodeRecordFieldName("mapOfLong");
            encoder.EncodeMapOfLong(MapOfLong);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.mapOfLongRecord", 1);
            decoder.DecodeRecordFieldName("mapOfLong");
            MapOfLong = decoder.DecodeMapOfLong();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class MapOfRecordRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.mapOfRecordRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.mapOfRecordRecord", 1);
            encoder.EncodeRecordFieldName("mapOfRecord");
            encoder.EncodeMapOfAvroObject<Energistics.Avro.Encoding.TestObjects.TestSimpleRecord>(MapOfRecord);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.mapOfRecordRecord", 1);
            decoder.DecodeRecordFieldName("mapOfRecord");
            MapOfRecord = decoder.DecodeMapOfAvroObject<Energistics.Avro.Encoding.TestObjects.TestSimpleRecord>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class MapOfStringRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.mapOfStringRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.mapOfStringRecord", 1);
            encoder.EncodeRecordFieldName("mapOfString");
            encoder.EncodeMapOfString(MapOfString);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.mapOfStringRecord", 1);
            decoder.DecodeRecordFieldName("mapOfString");
            MapOfString = decoder.DecodeMapOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class NullableBooleanNullFirstRecord : IAvroRecord
    {
        private static NullableTypeConverter NullableBooleanNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "boolean");
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.nullableBooleanNullFirstRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableBooleanNullFirstRecord", 1);
            encoder.EncodeRecordFieldName("nullableBooleanNullFirst");
            encoder.EncodeNullableBoolean(NullableBooleanNullFirst, NullableBooleanNullFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableBooleanNullFirstRecord", 1);
            decoder.DecodeRecordFieldName("nullableBooleanNullFirst");
            NullableBooleanNullFirst = decoder.DecodeNullableBoolean(NullableBooleanNullFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class NullableBooleanValueFirstRecord : IAvroRecord
    {
        private static NullableTypeConverter NullableBooleanValueFirstTypeConverter { get; } = new NullableTypeConverter(false, "boolean");
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.nullableBooleanValueFirstRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableBooleanValueFirstRecord", 1);
            encoder.EncodeRecordFieldName("nullableBooleanValueFirst");
            encoder.EncodeNullableBoolean(NullableBooleanValueFirst, NullableBooleanValueFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableBooleanValueFirstRecord", 1);
            decoder.DecodeRecordFieldName("nullableBooleanValueFirst");
            NullableBooleanValueFirst = decoder.DecodeNullableBoolean(NullableBooleanValueFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class NullableBytesNullFirstRecord : IAvroRecord
    {
        private static NullableTypeConverter NullableBytesNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "bytes");
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.nullableBytesNullFirstRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableBytesNullFirstRecord", 1);
            encoder.EncodeRecordFieldName("nullableBytesNullFirst");
            encoder.EncodeNullableBytes(NullableBytesNullFirst, NullableBytesNullFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableBytesNullFirstRecord", 1);
            decoder.DecodeRecordFieldName("nullableBytesNullFirst");
            NullableBytesNullFirst = decoder.DecodeNullableBytes(NullableBytesNullFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class NullableBytesValueFirstRecord : IAvroRecord
    {
        private static NullableTypeConverter NullableBytesValueFirstTypeConverter { get; } = new NullableTypeConverter(false, "bytes");
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.nullableBytesValueFirstRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableBytesValueFirstRecord", 1);
            encoder.EncodeRecordFieldName("nullableBytesValueFirst");
            encoder.EncodeNullableBytes(NullableBytesValueFirst, NullableBytesValueFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableBytesValueFirstRecord", 1);
            decoder.DecodeRecordFieldName("nullableBytesValueFirst");
            NullableBytesValueFirst = decoder.DecodeNullableBytes(NullableBytesValueFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class NullableDoubleNullFirstRecord : IAvroRecord
    {
        private static NullableTypeConverter NullableDoubleNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "double");
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.nullableDoubleNullFirstRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableDoubleNullFirstRecord", 1);
            encoder.EncodeRecordFieldName("nullableDoubleNullFirst");
            encoder.EncodeNullableDouble(NullableDoubleNullFirst, NullableDoubleNullFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableDoubleNullFirstRecord", 1);
            decoder.DecodeRecordFieldName("nullableDoubleNullFirst");
            NullableDoubleNullFirst = decoder.DecodeNullableDouble(NullableDoubleNullFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class NullableDoubleValueFirstRecord : IAvroRecord
    {
        private static NullableTypeConverter NullableDoubleValueFirstTypeConverter { get; } = new NullableTypeConverter(false, "double");
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.nullableDoubleValueFirstRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableDoubleValueFirstRecord", 1);
            encoder.EncodeRecordFieldName("nullableDoubleValueFirst");
            encoder.EncodeNullableDouble(NullableDoubleValueFirst, NullableDoubleValueFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableDoubleValueFirstRecord", 1);
            decoder.DecodeRecordFieldName("nullableDoubleValueFirst");
            NullableDoubleValueFirst = decoder.DecodeNullableDouble(NullableDoubleValueFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class NullableEnumNullFirstRecord : IAvroRecord
    {
        private static NullableTypeConverter NullableTestEnumNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "Energistics.Avro.Encoding.TestObjects.TestEnum");
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.nullableEnumNullFirstRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableEnumNullFirstRecord", 1);
            encoder.EncodeRecordFieldName("nullableEnumNullFirst");
            encoder.EncodeNullableEnum<Energistics.Avro.Encoding.TestObjects.TestEnum>(NullableEnumNullFirst, NullableTestEnumNullFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableEnumNullFirstRecord", 1);
            decoder.DecodeRecordFieldName("nullableEnumNullFirst");
            NullableEnumNullFirst = decoder.DecodeNullableEnum<Energistics.Avro.Encoding.TestObjects.TestEnum>(NullableTestEnumNullFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class NullableEnumValueFirstRecord : IAvroRecord
    {
        private static NullableTypeConverter NullableTestEnumValueFirstTypeConverter { get; } = new NullableTypeConverter(false, "Energistics.Avro.Encoding.TestObjects.TestEnum");
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.nullableEnumValueFirstRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableEnumValueFirstRecord", 1);
            encoder.EncodeRecordFieldName("nullableEnumValueFirst");
            encoder.EncodeNullableEnum<Energistics.Avro.Encoding.TestObjects.TestEnum>(NullableEnumValueFirst, NullableTestEnumValueFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableEnumValueFirstRecord", 1);
            decoder.DecodeRecordFieldName("nullableEnumValueFirst");
            NullableEnumValueFirst = decoder.DecodeNullableEnum<Energistics.Avro.Encoding.TestObjects.TestEnum>(NullableTestEnumValueFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class NullableFixedNullFirstRecord : IAvroRecord
    {
        private static NullableTypeConverter NullableTestFixedNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "Energistics.Avro.Encoding.TestObjects.TestFixed");
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.nullableFixedNullFirstRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableFixedNullFirstRecord", 1);
            encoder.EncodeRecordFieldName("nullableFixedNullFirst");
            encoder.EncodeNullableAvroObject<Energistics.Avro.Encoding.TestObjects.TestFixed>(NullableFixedNullFirst, NullableTestFixedNullFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableFixedNullFirstRecord", 1);
            decoder.DecodeRecordFieldName("nullableFixedNullFirst");
            NullableFixedNullFirst = decoder.DecodeNullableAvroObject<Energistics.Avro.Encoding.TestObjects.TestFixed>(NullableTestFixedNullFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class NullableFixedValueFirstRecord : IAvroRecord
    {
        private static NullableTypeConverter NullableTestFixedValueFirstTypeConverter { get; } = new NullableTypeConverter(false, "Energistics.Avro.Encoding.TestObjects.TestFixed");
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.nullableFixedValueFirstRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableFixedValueFirstRecord", 1);
            encoder.EncodeRecordFieldName("nullableFixedValueFirst");
            encoder.EncodeNullableAvroObject<Energistics.Avro.Encoding.TestObjects.TestFixed>(NullableFixedValueFirst, NullableTestFixedValueFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableFixedValueFirstRecord", 1);
            decoder.DecodeRecordFieldName("nullableFixedValueFirst");
            NullableFixedValueFirst = decoder.DecodeNullableAvroObject<Energistics.Avro.Encoding.TestObjects.TestFixed>(NullableTestFixedValueFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class NullableFloatNullFirstRecord : IAvroRecord
    {
        private static NullableTypeConverter NullableFloatNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "float");
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.nullableFloatNullFirstRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableFloatNullFirstRecord", 1);
            encoder.EncodeRecordFieldName("nullableFloatNullFirst");
            encoder.EncodeNullableFloat(NullableFloatNullFirst, NullableFloatNullFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableFloatNullFirstRecord", 1);
            decoder.DecodeRecordFieldName("nullableFloatNullFirst");
            NullableFloatNullFirst = decoder.DecodeNullableFloat(NullableFloatNullFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class NullableFloatValueFirstRecord : IAvroRecord
    {
        private static NullableTypeConverter NullableFloatValueFirstTypeConverter { get; } = new NullableTypeConverter(false, "float");
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.nullableFloatValueFirstRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableFloatValueFirstRecord", 1);
            encoder.EncodeRecordFieldName("nullableFloatValueFirst");
            encoder.EncodeNullableFloat(NullableFloatValueFirst, NullableFloatValueFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableFloatValueFirstRecord", 1);
            decoder.DecodeRecordFieldName("nullableFloatValueFirst");
            NullableFloatValueFirst = decoder.DecodeNullableFloat(NullableFloatValueFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class NullableIntNullFirstRecord : IAvroRecord
    {
        private static NullableTypeConverter NullableIntNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "int");
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.nullableIntNullFirstRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableIntNullFirstRecord", 1);
            encoder.EncodeRecordFieldName("nullableIntNullFirst");
            encoder.EncodeNullableInt(NullableIntNullFirst, NullableIntNullFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableIntNullFirstRecord", 1);
            decoder.DecodeRecordFieldName("nullableIntNullFirst");
            NullableIntNullFirst = decoder.DecodeNullableInt(NullableIntNullFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class NullableIntValueFirstRecord : IAvroRecord
    {
        private static NullableTypeConverter NullableIntValueFirstTypeConverter { get; } = new NullableTypeConverter(false, "int");
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.nullableIntValueFirstRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableIntValueFirstRecord", 1);
            encoder.EncodeRecordFieldName("nullableIntValueFirst");
            encoder.EncodeNullableInt(NullableIntValueFirst, NullableIntValueFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableIntValueFirstRecord", 1);
            decoder.DecodeRecordFieldName("nullableIntValueFirst");
            NullableIntValueFirst = decoder.DecodeNullableInt(NullableIntValueFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class NullableLongNullFirstRecord : IAvroRecord
    {
        private static NullableTypeConverter NullableLongNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "long");
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.nullableLongNullFirstRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableLongNullFirstRecord", 1);
            encoder.EncodeRecordFieldName("nullableLongNullFirst");
            encoder.EncodeNullableLong(NullableLongNullFirst, NullableLongNullFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableLongNullFirstRecord", 1);
            decoder.DecodeRecordFieldName("nullableLongNullFirst");
            NullableLongNullFirst = decoder.DecodeNullableLong(NullableLongNullFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class NullableLongValueFirstRecord : IAvroRecord
    {
        private static NullableTypeConverter NullableLongValueFirstTypeConverter { get; } = new NullableTypeConverter(false, "long");
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.nullableLongValueFirstRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableLongValueFirstRecord", 1);
            encoder.EncodeRecordFieldName("nullableLongValueFirst");
            encoder.EncodeNullableLong(NullableLongValueFirst, NullableLongValueFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableLongValueFirstRecord", 1);
            decoder.DecodeRecordFieldName("nullableLongValueFirst");
            NullableLongValueFirst = decoder.DecodeNullableLong(NullableLongValueFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class NullableRecordNullFirstRecord : IAvroRecord
    {
        private static NullableTypeConverter NullableTestSimpleRecordNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "Energistics.Avro.Encoding.TestObjects.TestSimpleRecord");
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.nullableRecordNullFirstRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableRecordNullFirstRecord", 1);
            encoder.EncodeRecordFieldName("nullableRecordNullFirst");
            encoder.EncodeNullableAvroObject<Energistics.Avro.Encoding.TestObjects.TestSimpleRecord>(NullableRecordNullFirst, NullableTestSimpleRecordNullFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableRecordNullFirstRecord", 1);
            decoder.DecodeRecordFieldName("nullableRecordNullFirst");
            NullableRecordNullFirst = decoder.DecodeNullableAvroObject<Energistics.Avro.Encoding.TestObjects.TestSimpleRecord>(NullableTestSimpleRecordNullFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class NullableRecordValueFirstRecord : IAvroRecord
    {
        private static NullableTypeConverter NullableTestSimpleRecordValueFirstTypeConverter { get; } = new NullableTypeConverter(false, "Energistics.Avro.Encoding.TestObjects.TestSimpleRecord");
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.nullableRecordValueFirstRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableRecordValueFirstRecord", 1);
            encoder.EncodeRecordFieldName("nullableRecordValueFirst");
            encoder.EncodeNullableAvroObject<Energistics.Avro.Encoding.TestObjects.TestSimpleRecord>(NullableRecordValueFirst, NullableTestSimpleRecordValueFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableRecordValueFirstRecord", 1);
            decoder.DecodeRecordFieldName("nullableRecordValueFirst");
            NullableRecordValueFirst = decoder.DecodeNullableAvroObject<Energistics.Avro.Encoding.TestObjects.TestSimpleRecord>(NullableTestSimpleRecordValueFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class NullableStringNullFirstRecord : IAvroRecord
    {
        private static NullableTypeConverter NullableStringNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "string");
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.nullableStringNullFirstRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableStringNullFirstRecord", 1);
            encoder.EncodeRecordFieldName("nullableStringNullFirst");
            encoder.EncodeNullableString(NullableStringNullFirst, NullableStringNullFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableStringNullFirstRecord", 1);
            decoder.DecodeRecordFieldName("nullableStringNullFirst");
            NullableStringNullFirst = decoder.DecodeNullableString(NullableStringNullFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class NullableStringValueFirstRecord : IAvroRecord
    {
        private static NullableTypeConverter NullableStringValueFirstTypeConverter { get; } = new NullableTypeConverter(false, "string");
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.nullableStringValueFirstRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableStringValueFirstRecord", 1);
            encoder.EncodeRecordFieldName("nullableStringValueFirst");
            encoder.EncodeNullableString(NullableStringValueFirst, NullableStringValueFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.nullableStringValueFirstRecord", 1);
            decoder.DecodeRecordFieldName("nullableStringValueFirst");
            NullableStringValueFirst = decoder.DecodeNullableString(NullableStringValueFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class RecordRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.recordRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.recordRecord", 1);
            encoder.EncodeRecordFieldName("record");
            encoder.EncodeAvroObject<Energistics.Avro.Encoding.TestObjects.TestSimpleRecord>(Record);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.recordRecord", 1);
            decoder.DecodeRecordFieldName("record");
            Record = decoder.DecodeAvroObject<Energistics.Avro.Encoding.TestObjects.TestSimpleRecord>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class StringRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.stringRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.stringRecord", 1);
            encoder.EncodeRecordFieldName("string");
            encoder.EncodeString(String);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.stringRecord", 1);
            decoder.DecodeRecordFieldName("string");
            String = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class TestComplexRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.TestComplexRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.TestComplexRecord", 2);
            encoder.EncodeRecordFieldName("test");
            encoder.EncodeString(Test);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("test2");
            encoder.EncodeInt(Test2);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.TestComplexRecord", 2);
            decoder.DecodeRecordFieldName("test");
            Test = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("test2");
            Test2 = decoder.DecodeInt();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class TestSimpleRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Avro.Encoding.TestObjects.TestSimpleRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Avro.Encoding.TestObjects.TestSimpleRecord", 1);
            encoder.EncodeRecordFieldName("test");
            encoder.EncodeString(Test);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Avro.Encoding.TestObjects.TestSimpleRecord", 1);
            decoder.DecodeRecordFieldName("test");
            Test = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
}
