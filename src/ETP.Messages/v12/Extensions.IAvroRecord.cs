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

namespace Energistics.Etp.v12.Datatypes
{
    public partial class AnyArray : IAvroRecord
    {
        private static ChoiceTypeConverter ChoiceOfArrayOfBooleanArrayOfIntArrayOfLongArrayOfFloatArrayOfDoubleArrayOfStringBytesTypeConverter { get; } = new ChoiceTypeConverter(new string[] { "Energistics.Etp.v12.Datatypes.ArrayOfBoolean", "Energistics.Etp.v12.Datatypes.ArrayOfInt", "Energistics.Etp.v12.Datatypes.ArrayOfLong", "Energistics.Etp.v12.Datatypes.ArrayOfFloat", "Energistics.Etp.v12.Datatypes.ArrayOfDouble", "Energistics.Etp.v12.Datatypes.ArrayOfString", "bytes" }, new Type[] { typeof(Energistics.Etp.v12.Datatypes.ArrayOfBoolean), typeof(Energistics.Etp.v12.Datatypes.ArrayOfInt), typeof(Energistics.Etp.v12.Datatypes.ArrayOfLong), typeof(Energistics.Etp.v12.Datatypes.ArrayOfFloat), typeof(Energistics.Etp.v12.Datatypes.ArrayOfDouble), typeof(Energistics.Etp.v12.Datatypes.ArrayOfString), typeof(byte[]) });
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.AnyArray";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.AnyArray", 1);
            encoder.EncodeRecordFieldName("item");
            encoder.EncodeChoiceOfArrayOfBooleanArrayOfIntArrayOfLongArrayOfFloatArrayOfDoubleArrayOfStringBytes(Item, ChoiceOfArrayOfBooleanArrayOfIntArrayOfLongArrayOfFloatArrayOfDoubleArrayOfStringBytesTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.AnyArray", 1);
            decoder.DecodeRecordFieldName("item");
            Item = decoder.DecodeChoiceOfArrayOfBooleanArrayOfIntArrayOfLongArrayOfFloatArrayOfDoubleArrayOfStringBytes(ChoiceOfArrayOfBooleanArrayOfIntArrayOfLongArrayOfFloatArrayOfDoubleArrayOfStringBytesTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class AnySparseArray : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.AnySparseArray";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.AnySparseArray", 1);
            encoder.EncodeRecordFieldName("slices");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.AnySubarray>(Slices);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.AnySparseArray", 1);
            decoder.DecodeRecordFieldName("slices");
            Slices = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.AnySubarray>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class AnySubarray : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.AnySubarray";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.AnySubarray", 2);
            encoder.EncodeRecordFieldName("start");
            encoder.EncodeLong(Start);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("slice");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.AnyArray>(Slice);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.AnySubarray", 2);
            decoder.DecodeRecordFieldName("start");
            Start = decoder.DecodeLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("slice");
            Slice = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.AnyArray>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfBoolean : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ArrayOfBoolean";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ArrayOfBoolean", 1);
            encoder.EncodeRecordFieldName("values");
            encoder.EncodeArrayOfBoolean(Values);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ArrayOfBoolean", 1);
            decoder.DecodeRecordFieldName("values");
            Values = decoder.DecodeArrayOfBoolean();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfBytes : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ArrayOfBytes";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ArrayOfBytes", 1);
            encoder.EncodeRecordFieldName("values");
            encoder.EncodeArrayOfBytes(Values);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ArrayOfBytes", 1);
            decoder.DecodeRecordFieldName("values");
            Values = decoder.DecodeArrayOfBytes();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfDouble : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ArrayOfDouble";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ArrayOfDouble", 1);
            encoder.EncodeRecordFieldName("values");
            encoder.EncodeArrayOfDouble(Values);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ArrayOfDouble", 1);
            decoder.DecodeRecordFieldName("values");
            Values = decoder.DecodeArrayOfDouble();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfFloat : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ArrayOfFloat";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ArrayOfFloat", 1);
            encoder.EncodeRecordFieldName("values");
            encoder.EncodeArrayOfFloat(Values);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ArrayOfFloat", 1);
            decoder.DecodeRecordFieldName("values");
            Values = decoder.DecodeArrayOfFloat();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfInt : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ArrayOfInt";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ArrayOfInt", 1);
            encoder.EncodeRecordFieldName("values");
            encoder.EncodeArrayOfInt(Values);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ArrayOfInt", 1);
            decoder.DecodeRecordFieldName("values");
            Values = decoder.DecodeArrayOfInt();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfLong : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ArrayOfLong";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ArrayOfLong", 1);
            encoder.EncodeRecordFieldName("values");
            encoder.EncodeArrayOfLong(Values);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ArrayOfLong", 1);
            decoder.DecodeRecordFieldName("values");
            Values = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfNullableBoolean : IAvroRecord
    {
        private static NullableTypeConverter NullableBooleanNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "boolean");
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ArrayOfNullableBoolean";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ArrayOfNullableBoolean", 1);
            encoder.EncodeRecordFieldName("values");
            encoder.EncodeArrayOfNullableBoolean(Values, NullableBooleanNullFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ArrayOfNullableBoolean", 1);
            decoder.DecodeRecordFieldName("values");
            Values = decoder.DecodeArrayOfNullableBoolean(NullableBooleanNullFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfNullableInt : IAvroRecord
    {
        private static NullableTypeConverter NullableIntNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "int");
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ArrayOfNullableInt";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ArrayOfNullableInt", 1);
            encoder.EncodeRecordFieldName("values");
            encoder.EncodeArrayOfNullableInt(Values, NullableIntNullFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ArrayOfNullableInt", 1);
            decoder.DecodeRecordFieldName("values");
            Values = decoder.DecodeArrayOfNullableInt(NullableIntNullFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfNullableLong : IAvroRecord
    {
        private static NullableTypeConverter NullableLongNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "long");
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ArrayOfNullableLong";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ArrayOfNullableLong", 1);
            encoder.EncodeRecordFieldName("values");
            encoder.EncodeArrayOfNullableLong(Values, NullableLongNullFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ArrayOfNullableLong", 1);
            decoder.DecodeRecordFieldName("values");
            Values = decoder.DecodeArrayOfNullableLong(NullableLongNullFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfString : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ArrayOfString";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ArrayOfString", 1);
            encoder.EncodeRecordFieldName("values");
            encoder.EncodeArrayOfString(Values);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ArrayOfString", 1);
            decoder.DecodeRecordFieldName("values");
            Values = decoder.DecodeArrayOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class AttributeMetadataRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.AttributeMetadataRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.AttributeMetadataRecord", 7);
            encoder.EncodeRecordFieldName("attributeId");
            encoder.EncodeInt(AttributeId);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("attributeName");
            encoder.EncodeString(AttributeName);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("dataKind");
            encoder.EncodeEnum<Energistics.Etp.v12.Datatypes.ChannelData.ChannelDataKind>(DataKind);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("uom");
            encoder.EncodeString(Uom);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("depthDatum");
            encoder.EncodeString(DepthDatum);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("attributePropertyKindUri");
            encoder.EncodeString(AttributePropertyKindUri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("axisVectorLengths");
            encoder.EncodeArrayOfInt(AxisVectorLengths);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.AttributeMetadataRecord", 7);
            decoder.DecodeRecordFieldName("attributeId");
            AttributeId = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("attributeName");
            AttributeName = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("dataKind");
            DataKind = decoder.DecodeEnum<Energistics.Etp.v12.Datatypes.ChannelData.ChannelDataKind>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("uom");
            Uom = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("depthDatum");
            DepthDatum = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("attributePropertyKindUri");
            AttributePropertyKindUri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("axisVectorLengths");
            AxisVectorLengths = decoder.DecodeArrayOfInt();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class Contact : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.Contact";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.Contact", 4);
            encoder.EncodeRecordFieldName("organizationName");
            encoder.EncodeString(OrganizationName);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("contactName");
            encoder.EncodeString(ContactName);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("contactPhone");
            encoder.EncodeString(ContactPhone);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("contactEmail");
            encoder.EncodeString(ContactEmail);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.Contact", 4);
            decoder.DecodeRecordFieldName("organizationName");
            OrganizationName = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("contactName");
            ContactName = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("contactPhone");
            ContactPhone = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("contactEmail");
            ContactEmail = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class DataAttribute : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.DataAttribute";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.DataAttribute", 2);
            encoder.EncodeRecordFieldName("attributeId");
            encoder.EncodeInt(AttributeId);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("attributeValue");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.DataValue>(AttributeValue);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.DataAttribute", 2);
            decoder.DecodeRecordFieldName("attributeId");
            AttributeId = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("attributeValue");
            AttributeValue = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.DataValue>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class DataValue : IAvroRecord
    {
        private static ChoiceTypeConverter ChoiceOfNullBooleanIntLongFloatDoubleStringArrayOfBooleanArrayOfNullableBooleanArrayOfIntArrayOfNullableIntArrayOfLongArrayOfNullableLongArrayOfFloatArrayOfDoubleArrayOfStringArrayOfBytesBytesAnySparseArrayTypeConverter { get; } = new ChoiceTypeConverter(new string[] { "null", "boolean", "int", "long", "float", "double", "string", "Energistics.Etp.v12.Datatypes.ArrayOfBoolean", "Energistics.Etp.v12.Datatypes.ArrayOfNullableBoolean", "Energistics.Etp.v12.Datatypes.ArrayOfInt", "Energistics.Etp.v12.Datatypes.ArrayOfNullableInt", "Energistics.Etp.v12.Datatypes.ArrayOfLong", "Energistics.Etp.v12.Datatypes.ArrayOfNullableLong", "Energistics.Etp.v12.Datatypes.ArrayOfFloat", "Energistics.Etp.v12.Datatypes.ArrayOfDouble", "Energistics.Etp.v12.Datatypes.ArrayOfString", "Energistics.Etp.v12.Datatypes.ArrayOfBytes", "bytes", "Energistics.Etp.v12.Datatypes.AnySparseArray" }, new Type[] { null, typeof(bool), typeof(int), typeof(long), typeof(float), typeof(double), typeof(string), typeof(Energistics.Etp.v12.Datatypes.ArrayOfBoolean), typeof(Energistics.Etp.v12.Datatypes.ArrayOfNullableBoolean), typeof(Energistics.Etp.v12.Datatypes.ArrayOfInt), typeof(Energistics.Etp.v12.Datatypes.ArrayOfNullableInt), typeof(Energistics.Etp.v12.Datatypes.ArrayOfLong), typeof(Energistics.Etp.v12.Datatypes.ArrayOfNullableLong), typeof(Energistics.Etp.v12.Datatypes.ArrayOfFloat), typeof(Energistics.Etp.v12.Datatypes.ArrayOfDouble), typeof(Energistics.Etp.v12.Datatypes.ArrayOfString), typeof(Energistics.Etp.v12.Datatypes.ArrayOfBytes), typeof(byte[]), typeof(Energistics.Etp.v12.Datatypes.AnySparseArray) });
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.DataValue";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.DataValue", 1);
            encoder.EncodeRecordFieldName("item");
            encoder.EncodeChoiceOfNullBooleanIntLongFloatDoubleStringArrayOfBooleanArrayOfNullableBooleanArrayOfIntArrayOfNullableIntArrayOfLongArrayOfNullableLongArrayOfFloatArrayOfDoubleArrayOfStringArrayOfBytesBytesAnySparseArray(Item, ChoiceOfNullBooleanIntLongFloatDoubleStringArrayOfBooleanArrayOfNullableBooleanArrayOfIntArrayOfNullableIntArrayOfLongArrayOfNullableLongArrayOfFloatArrayOfDoubleArrayOfStringArrayOfBytesBytesAnySparseArrayTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.DataValue", 1);
            decoder.DecodeRecordFieldName("item");
            Item = decoder.DecodeChoiceOfNullBooleanIntLongFloatDoubleStringArrayOfBooleanArrayOfNullableBooleanArrayOfIntArrayOfNullableIntArrayOfLongArrayOfNullableLongArrayOfFloatArrayOfDoubleArrayOfStringArrayOfBytesBytesAnySparseArray(ChoiceOfNullBooleanIntLongFloatDoubleStringArrayOfBooleanArrayOfNullableBooleanArrayOfIntArrayOfNullableIntArrayOfLongArrayOfNullableLongArrayOfFloatArrayOfDoubleArrayOfStringArrayOfBytesBytesAnySparseArrayTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ErrorInfo : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ErrorInfo";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ErrorInfo", 2);
            encoder.EncodeRecordFieldName("message");
            encoder.EncodeString(Message);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("code");
            encoder.EncodeInt(Code);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ErrorInfo", 2);
            decoder.DecodeRecordFieldName("message");
            Message = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("code");
            Code = decoder.DecodeInt();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class IndexValue : IAvroRecord
    {
        private static ChoiceTypeConverter ChoiceOfNullLongDoublePassIndexedDepthTypeConverter { get; } = new ChoiceTypeConverter(new string[] { "null", "long", "double", "Energistics.Etp.v12.Datatypes.ChannelData.PassIndexedDepth" }, new Type[] { null, typeof(long), typeof(double), typeof(Energistics.Etp.v12.Datatypes.ChannelData.PassIndexedDepth) });
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.IndexValue";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.IndexValue", 1);
            encoder.EncodeRecordFieldName("item");
            encoder.EncodeChoiceOfNullLongDoublePassIndexedDepth(Item, ChoiceOfNullLongDoublePassIndexedDepthTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.IndexValue", 1);
            decoder.DecodeRecordFieldName("item");
            Item = decoder.DecodeChoiceOfNullLongDoublePassIndexedDepth(ChoiceOfNullLongDoublePassIndexedDepthTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class MessageHeader : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.MessageHeader";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.MessageHeader", 5);
            encoder.EncodeRecordFieldName("protocol");
            encoder.EncodeInt(Protocol);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("messageType");
            encoder.EncodeInt(MessageType);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("correlationId");
            encoder.EncodeLong(CorrelationId);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("messageId");
            encoder.EncodeLong(MessageId);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("messageFlags");
            encoder.EncodeInt(MessageFlags);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.MessageHeader", 5);
            decoder.DecodeRecordFieldName("protocol");
            Protocol = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("messageType");
            MessageType = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("correlationId");
            CorrelationId = decoder.DecodeLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("messageId");
            MessageId = decoder.DecodeLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("messageFlags");
            MessageFlags = decoder.DecodeInt();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class MessageHeaderExtension : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.MessageHeaderExtension";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.MessageHeaderExtension", 1);
            encoder.EncodeRecordFieldName("extension");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>(Extension);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.MessageHeaderExtension", 1);
            decoder.DecodeRecordFieldName("extension");
            Extension = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ServerCapabilities : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ServerCapabilities";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ServerCapabilities", 9);
            encoder.EncodeRecordFieldName("applicationName");
            encoder.EncodeString(ApplicationName);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("applicationVersion");
            encoder.EncodeString(ApplicationVersion);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("contactInformation");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Contact>(ContactInformation);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("supportedCompression");
            encoder.EncodeArrayOfString(SupportedCompression);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("supportedEncodings");
            encoder.EncodeArrayOfString(SupportedEncodings);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("supportedFormats");
            encoder.EncodeArrayOfString(SupportedFormats);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("supportedDataObjects");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.SupportedDataObject>(SupportedDataObjects);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("supportedProtocols");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.SupportedProtocol>(SupportedProtocols);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("endpointCapabilities");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>(EndpointCapabilities);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ServerCapabilities", 9);
            decoder.DecodeRecordFieldName("applicationName");
            ApplicationName = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("applicationVersion");
            ApplicationVersion = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("contactInformation");
            ContactInformation = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.Contact>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("supportedCompression");
            SupportedCompression = decoder.DecodeArrayOfString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("supportedEncodings");
            SupportedEncodings = decoder.DecodeArrayOfString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("supportedFormats");
            SupportedFormats = decoder.DecodeArrayOfString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("supportedDataObjects");
            SupportedDataObjects = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.SupportedDataObject>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("supportedProtocols");
            SupportedProtocols = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.SupportedProtocol>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("endpointCapabilities");
            EndpointCapabilities = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class SupportedDataObject : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.SupportedDataObject";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.SupportedDataObject", 2);
            encoder.EncodeRecordFieldName("qualifiedType");
            encoder.EncodeString(QualifiedType);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("dataObjectCapabilities");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>(DataObjectCapabilities);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.SupportedDataObject", 2);
            decoder.DecodeRecordFieldName("qualifiedType");
            QualifiedType = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("dataObjectCapabilities");
            DataObjectCapabilities = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class SupportedProtocol : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.SupportedProtocol";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.SupportedProtocol", 4);
            encoder.EncodeRecordFieldName("protocol");
            encoder.EncodeInt(Protocol);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("protocolVersion");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Version>(ProtocolVersion);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("role");
            encoder.EncodeString(Role);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("protocolCapabilities");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>(ProtocolCapabilities);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.SupportedProtocol", 4);
            decoder.DecodeRecordFieldName("protocol");
            Protocol = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("protocolVersion");
            ProtocolVersion = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.Version>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("role");
            Role = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("protocolCapabilities");
            ProtocolCapabilities = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class Version : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.Version";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.Version", 4);
            encoder.EncodeRecordFieldName("major");
            encoder.EncodeInt(Major);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("minor");
            encoder.EncodeInt(Minor);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("revision");
            encoder.EncodeInt(Revision);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("patch");
            encoder.EncodeInt(Patch);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.Version", 4);
            decoder.DecodeRecordFieldName("major");
            Major = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("minor");
            Minor = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("revision");
            Revision = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("patch");
            Patch = decoder.DecodeInt();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v12.Datatypes.ChannelData
{
    public partial class ChannelChangeRequestInfo : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ChannelData.ChannelChangeRequestInfo";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.ChannelChangeRequestInfo", 2);
            encoder.EncodeRecordFieldName("sinceChangeTime");
            encoder.EncodeTimestampMicrosDateTimeAsLong(SinceChangeTime);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("channelIds");
            encoder.EncodeArrayOfLong(ChannelIds);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.ChannelChangeRequestInfo", 2);
            decoder.DecodeRecordFieldName("sinceChangeTime");
            SinceChangeTime = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("channelIds");
            ChannelIds = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ChannelMetadataRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ChannelData.ChannelMetadataRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.ChannelMetadataRecord", 13);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("id");
            encoder.EncodeLong(Id);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("indexes");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.IndexMetadataRecord>(Indexes);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("channelName");
            encoder.EncodeString(ChannelName);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("dataKind");
            encoder.EncodeEnum<Energistics.Etp.v12.Datatypes.ChannelData.ChannelDataKind>(DataKind);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("uom");
            encoder.EncodeString(Uom);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("depthDatum");
            encoder.EncodeString(DepthDatum);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("channelClassUri");
            encoder.EncodeString(ChannelClassUri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("status");
            encoder.EncodeEnum<Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind>(Status);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("source");
            encoder.EncodeString(Source);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("axisVectorLengths");
            encoder.EncodeArrayOfInt(AxisVectorLengths);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("attributeMetadata");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.AttributeMetadataRecord>(AttributeMetadata);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("customData");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>(CustomData);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.ChannelMetadataRecord", 13);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("id");
            Id = decoder.DecodeLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("indexes");
            Indexes = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.IndexMetadataRecord>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("channelName");
            ChannelName = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("dataKind");
            DataKind = decoder.DecodeEnum<Energistics.Etp.v12.Datatypes.ChannelData.ChannelDataKind>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("uom");
            Uom = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("depthDatum");
            DepthDatum = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("channelClassUri");
            ChannelClassUri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("status");
            Status = decoder.DecodeEnum<Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("source");
            Source = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("axisVectorLengths");
            AxisVectorLengths = decoder.DecodeArrayOfInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("attributeMetadata");
            AttributeMetadata = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.AttributeMetadataRecord>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("customData");
            CustomData = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ChannelRangeInfo : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ChannelData.ChannelRangeInfo";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.ChannelRangeInfo", 3);
            encoder.EncodeRecordFieldName("channelIds");
            encoder.EncodeArrayOfLong(ChannelIds);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("interval");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.IndexInterval>(Interval);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("secondaryIntervals");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.IndexInterval>(SecondaryIntervals);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.ChannelRangeInfo", 3);
            decoder.DecodeRecordFieldName("channelIds");
            ChannelIds = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("interval");
            Interval = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.Object.IndexInterval>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("secondaryIntervals");
            SecondaryIntervals = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.IndexInterval>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ChannelSubscribeInfo : IAvroRecord
    {
        private static NullableTypeConverter NullableIntNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "int");
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ChannelData.ChannelSubscribeInfo";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.ChannelSubscribeInfo", 4);
            encoder.EncodeRecordFieldName("channelId");
            encoder.EncodeLong(ChannelId);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("startIndex");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.IndexValue>(StartIndex);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("dataChanges");
            encoder.EncodeBoolean(DataChanges);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("requestLatestIndexCount");
            encoder.EncodeNullableInt(RequestLatestIndexCount, NullableIntNullFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.ChannelSubscribeInfo", 4);
            decoder.DecodeRecordFieldName("channelId");
            ChannelId = decoder.DecodeLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("startIndex");
            StartIndex = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.IndexValue>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("dataChanges");
            DataChanges = decoder.DecodeBoolean();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("requestLatestIndexCount");
            RequestLatestIndexCount = decoder.DecodeNullableInt(NullableIntNullFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class DataItem : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ChannelData.DataItem";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.DataItem", 4);
            encoder.EncodeRecordFieldName("channelId");
            encoder.EncodeLong(ChannelId);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("indexes");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.IndexValue>(Indexes);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("value");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.DataValue>(Value);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("valueAttributes");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.DataAttribute>(ValueAttributes);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.DataItem", 4);
            decoder.DecodeRecordFieldName("channelId");
            ChannelId = decoder.DecodeLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("indexes");
            Indexes = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.IndexValue>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("value");
            Value = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.DataValue>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("valueAttributes");
            ValueAttributes = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.DataAttribute>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class FrameChannelMetadataRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ChannelData.FrameChannelMetadataRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.FrameChannelMetadataRecord", 11);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("channelName");
            encoder.EncodeString(ChannelName);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("dataKind");
            encoder.EncodeEnum<Energistics.Etp.v12.Datatypes.ChannelData.ChannelDataKind>(DataKind);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("uom");
            encoder.EncodeString(Uom);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("depthDatum");
            encoder.EncodeString(DepthDatum);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("channelPropertyKindUri");
            encoder.EncodeString(ChannelPropertyKindUri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("status");
            encoder.EncodeEnum<Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind>(Status);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("source");
            encoder.EncodeString(Source);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("axisVectorLengths");
            encoder.EncodeArrayOfInt(AxisVectorLengths);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("attributeMetadata");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.AttributeMetadataRecord>(AttributeMetadata);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("customData");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>(CustomData);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.FrameChannelMetadataRecord", 11);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("channelName");
            ChannelName = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("dataKind");
            DataKind = decoder.DecodeEnum<Energistics.Etp.v12.Datatypes.ChannelData.ChannelDataKind>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("uom");
            Uom = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("depthDatum");
            DepthDatum = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("channelPropertyKindUri");
            ChannelPropertyKindUri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("status");
            Status = decoder.DecodeEnum<Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("source");
            Source = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("axisVectorLengths");
            AxisVectorLengths = decoder.DecodeArrayOfInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("attributeMetadata");
            AttributeMetadata = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.AttributeMetadataRecord>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("customData");
            CustomData = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class FramePoint : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ChannelData.FramePoint";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.FramePoint", 2);
            encoder.EncodeRecordFieldName("value");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.DataValue>(Value);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("valueAttributes");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.DataAttribute>(ValueAttributes);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.FramePoint", 2);
            decoder.DecodeRecordFieldName("value");
            Value = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.DataValue>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("valueAttributes");
            ValueAttributes = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.DataAttribute>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class FrameRow : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ChannelData.FrameRow";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.FrameRow", 2);
            encoder.EncodeRecordFieldName("indexes");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.IndexValue>(Indexes);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("points");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.FramePoint>(Points);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.FrameRow", 2);
            decoder.DecodeRecordFieldName("indexes");
            Indexes = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.IndexValue>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("points");
            Points = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.FramePoint>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class IndexMetadataRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ChannelData.IndexMetadataRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.IndexMetadataRecord", 8);
            encoder.EncodeRecordFieldName("indexKind");
            encoder.EncodeEnum<Energistics.Etp.v12.Datatypes.ChannelData.ChannelIndexKind>(IndexKind);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("interval");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.IndexInterval>(Interval);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("direction");
            encoder.EncodeEnum<Energistics.Etp.v12.Datatypes.ChannelData.IndexDirection>(Direction);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("name");
            encoder.EncodeString(Name);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("uom");
            encoder.EncodeString(Uom);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("depthDatum");
            encoder.EncodeString(DepthDatum);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("indexPropertyKindUri");
            encoder.EncodeString(IndexPropertyKindUri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("filterable");
            encoder.EncodeBoolean(Filterable);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.IndexMetadataRecord", 8);
            decoder.DecodeRecordFieldName("indexKind");
            IndexKind = decoder.DecodeEnum<Energistics.Etp.v12.Datatypes.ChannelData.ChannelIndexKind>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("interval");
            Interval = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.Object.IndexInterval>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("direction");
            Direction = decoder.DecodeEnum<Energistics.Etp.v12.Datatypes.ChannelData.IndexDirection>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("name");
            Name = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("uom");
            Uom = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("depthDatum");
            DepthDatum = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("indexPropertyKindUri");
            IndexPropertyKindUri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("filterable");
            Filterable = decoder.DecodeBoolean();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class OpenChannelInfo : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ChannelData.OpenChannelInfo";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.OpenChannelInfo", 3);
            encoder.EncodeRecordFieldName("metadata");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.ChannelMetadataRecord>(Metadata);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("preferRealtime");
            encoder.EncodeBoolean(PreferRealtime);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("dataChanges");
            encoder.EncodeBoolean(DataChanges);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.OpenChannelInfo", 3);
            decoder.DecodeRecordFieldName("metadata");
            Metadata = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.ChannelMetadataRecord>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("preferRealtime");
            PreferRealtime = decoder.DecodeBoolean();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("dataChanges");
            DataChanges = decoder.DecodeBoolean();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PassIndexedDepth : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ChannelData.PassIndexedDepth";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.PassIndexedDepth", 3);
            encoder.EncodeRecordFieldName("pass");
            encoder.EncodeLong(Pass);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("direction");
            encoder.EncodeEnum<Energistics.Etp.v12.Datatypes.ChannelData.PassDirection>(Direction);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("depth");
            encoder.EncodeDouble(Depth);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.PassIndexedDepth", 3);
            decoder.DecodeRecordFieldName("pass");
            Pass = decoder.DecodeLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("direction");
            Direction = decoder.DecodeEnum<Energistics.Etp.v12.Datatypes.ChannelData.PassDirection>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("depth");
            Depth = decoder.DecodeDouble();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class TruncateInfo : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.ChannelData.TruncateInfo";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.TruncateInfo", 2);
            encoder.EncodeRecordFieldName("channelId");
            encoder.EncodeLong(ChannelId);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("newEndIndex");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.IndexValue>(NewEndIndex);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.ChannelData.TruncateInfo", 2);
            decoder.DecodeRecordFieldName("channelId");
            ChannelId = decoder.DecodeLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("newEndIndex");
            NewEndIndex = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.IndexValue>();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v12.Datatypes.DataArrayTypes
{
    public partial class DataArray : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArray";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArray", 2);
            encoder.EncodeRecordFieldName("dimensions");
            encoder.EncodeArrayOfLong(Dimensions);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.AnyArray>(Data);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArray", 2);
            decoder.DecodeRecordFieldName("dimensions");
            Dimensions = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.AnyArray>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class DataArrayIdentifier : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier", 2);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("pathInResource");
            encoder.EncodeString(PathInResource);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier", 2);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("pathInResource");
            PathInResource = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class DataArrayMetadata : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayMetadata";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayMetadata", 7);
            encoder.EncodeRecordFieldName("dimensions");
            encoder.EncodeArrayOfLong(Dimensions);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("preferredSubarrayDimensions");
            encoder.EncodeArrayOfLong(PreferredSubarrayDimensions);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("transportArrayType");
            encoder.EncodeEnum<Energistics.Etp.v12.Datatypes.AnyArrayType>(TransportArrayType);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("logicalArrayType");
            encoder.EncodeEnum<Energistics.Etp.v12.Datatypes.AnyLogicalArrayType>(LogicalArrayType);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("storeLastWrite");
            encoder.EncodeTimestampMicrosDateTimeAsLong(StoreLastWrite);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("storeCreated");
            encoder.EncodeTimestampMicrosDateTimeAsLong(StoreCreated);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("customData");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>(CustomData);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayMetadata", 7);
            decoder.DecodeRecordFieldName("dimensions");
            Dimensions = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("preferredSubarrayDimensions");
            PreferredSubarrayDimensions = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("transportArrayType");
            TransportArrayType = decoder.DecodeEnum<Energistics.Etp.v12.Datatypes.AnyArrayType>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("logicalArrayType");
            LogicalArrayType = decoder.DecodeEnum<Energistics.Etp.v12.Datatypes.AnyLogicalArrayType>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("storeLastWrite");
            StoreLastWrite = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("storeCreated");
            StoreCreated = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("customData");
            CustomData = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetDataSubarraysType : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.DataArrayTypes.GetDataSubarraysType";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.DataArrayTypes.GetDataSubarraysType", 3);
            encoder.EncodeRecordFieldName("uid");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier>(Uid);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("starts");
            encoder.EncodeArrayOfLong(Starts);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("counts");
            encoder.EncodeArrayOfLong(Counts);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.DataArrayTypes.GetDataSubarraysType", 3);
            decoder.DecodeRecordFieldName("uid");
            Uid = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("starts");
            Starts = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("counts");
            Counts = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PutDataArraysType : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.DataArrayTypes.PutDataArraysType";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.DataArrayTypes.PutDataArraysType", 3);
            encoder.EncodeRecordFieldName("uid");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier>(Uid);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("array");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArray>(Array);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("customData");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>(CustomData);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.DataArrayTypes.PutDataArraysType", 3);
            decoder.DecodeRecordFieldName("uid");
            Uid = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("array");
            Array = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArray>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("customData");
            CustomData = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PutDataSubarraysType : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.DataArrayTypes.PutDataSubarraysType";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.DataArrayTypes.PutDataSubarraysType", 4);
            encoder.EncodeRecordFieldName("uid");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier>(Uid);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.AnyArray>(Data);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("starts");
            encoder.EncodeArrayOfLong(Starts);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("counts");
            encoder.EncodeArrayOfLong(Counts);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.DataArrayTypes.PutDataSubarraysType", 4);
            decoder.DecodeRecordFieldName("uid");
            Uid = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.AnyArray>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("starts");
            Starts = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("counts");
            Counts = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PutUninitializedDataArrayType : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.DataArrayTypes.PutUninitializedDataArrayType";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.DataArrayTypes.PutUninitializedDataArrayType", 2);
            encoder.EncodeRecordFieldName("uid");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier>(Uid);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("metadata");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayMetadata>(Metadata);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.DataArrayTypes.PutUninitializedDataArrayType", 2);
            decoder.DecodeRecordFieldName("uid");
            Uid = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("metadata");
            Metadata = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayMetadata>();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v12.Datatypes.Object
{
    public partial class ChangeAnnotation : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.Object.ChangeAnnotation";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.Object.ChangeAnnotation", 2);
            encoder.EncodeRecordFieldName("changeTime");
            encoder.EncodeTimestampMicrosDateTimeAsLong(ChangeTime);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("interval");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.IndexInterval>(Interval);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.Object.ChangeAnnotation", 2);
            decoder.DecodeRecordFieldName("changeTime");
            ChangeTime = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("interval");
            Interval = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.Object.IndexInterval>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ChangeResponseInfo : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.Object.ChangeResponseInfo";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.Object.ChangeResponseInfo", 2);
            encoder.EncodeRecordFieldName("responseTimestamp");
            encoder.EncodeTimestampMicrosDateTimeAsLong(ResponseTimestamp);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("changes");
            encoder.EncodeMapOfArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.ChangeAnnotation>(Changes);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.Object.ChangeResponseInfo", 2);
            decoder.DecodeRecordFieldName("responseTimestamp");
            ResponseTimestamp = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("changes");
            Changes = decoder.DecodeMapOfArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.ChangeAnnotation>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ContextInfo : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.Object.ContextInfo";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.Object.ContextInfo", 6);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("depth");
            encoder.EncodeInt(Depth);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("dataObjectTypes");
            encoder.EncodeArrayOfString(DataObjectTypes);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("navigableEdges");
            encoder.EncodeEnum<Energistics.Etp.v12.Datatypes.Object.RelationshipKind>(NavigableEdges);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("includeSecondaryTargets");
            encoder.EncodeBoolean(IncludeSecondaryTargets);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("includeSecondarySources");
            encoder.EncodeBoolean(IncludeSecondarySources);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.Object.ContextInfo", 6);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("depth");
            Depth = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("dataObjectTypes");
            DataObjectTypes = decoder.DecodeArrayOfString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("navigableEdges");
            NavigableEdges = decoder.DecodeEnum<Energistics.Etp.v12.Datatypes.Object.RelationshipKind>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("includeSecondaryTargets");
            IncludeSecondaryTargets = decoder.DecodeBoolean();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("includeSecondarySources");
            IncludeSecondarySources = decoder.DecodeBoolean();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class DataObject : IAvroRecord
    {
        private static NullableTypeConverter NullableUuidGuidAsFixedNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "Energistics.Etp.v12.Datatypes.Uuid");
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.Object.DataObject";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.Object.DataObject", 4);
            encoder.EncodeRecordFieldName("resource");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.Resource>(Resource);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("format");
            encoder.EncodeString(Format);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("blobId");
            encoder.EncodeNullableUuidGuidAsFixed(BlobId, NullableUuidGuidAsFixedNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeBytes(Data);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.Object.DataObject", 4);
            decoder.DecodeRecordFieldName("resource");
            Resource = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.Object.Resource>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("format");
            Format = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("blobId");
            BlobId = decoder.DecodeNullableUuidGuidAsFixed(NullableUuidGuidAsFixedNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeBytes();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class Dataspace : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.Object.Dataspace";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.Object.Dataspace", 5);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("path");
            encoder.EncodeString(Path);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("storeLastWrite");
            encoder.EncodeTimestampMicrosDateTimeAsLong(StoreLastWrite);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("storeCreated");
            encoder.EncodeTimestampMicrosDateTimeAsLong(StoreCreated);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("customData");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>(CustomData);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.Object.Dataspace", 5);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("path");
            Path = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("storeLastWrite");
            StoreLastWrite = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("storeCreated");
            StoreCreated = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("customData");
            CustomData = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class DeletedResource : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.Object.DeletedResource";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.Object.DeletedResource", 3);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("deletedTime");
            encoder.EncodeTimestampMicrosDateTimeAsLong(DeletedTime);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("customData");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>(CustomData);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.Object.DeletedResource", 3);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("deletedTime");
            DeletedTime = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("customData");
            CustomData = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class Edge : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.Object.Edge";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.Object.Edge", 4);
            encoder.EncodeRecordFieldName("sourceUri");
            encoder.EncodeString(SourceUri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("targetUri");
            encoder.EncodeString(TargetUri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("relationshipKind");
            encoder.EncodeEnum<Energistics.Etp.v12.Datatypes.Object.RelationshipKind>(RelationshipKind);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("customData");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>(CustomData);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.Object.Edge", 4);
            decoder.DecodeRecordFieldName("sourceUri");
            SourceUri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("targetUri");
            TargetUri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("relationshipKind");
            RelationshipKind = decoder.DecodeEnum<Energistics.Etp.v12.Datatypes.Object.RelationshipKind>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("customData");
            CustomData = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class IndexInterval : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.Object.IndexInterval";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.Object.IndexInterval", 4);
            encoder.EncodeRecordFieldName("startIndex");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.IndexValue>(StartIndex);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("endIndex");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.IndexValue>(EndIndex);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("uom");
            encoder.EncodeString(Uom);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("depthDatum");
            encoder.EncodeString(DepthDatum);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.Object.IndexInterval", 4);
            decoder.DecodeRecordFieldName("startIndex");
            StartIndex = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.IndexValue>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("endIndex");
            EndIndex = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.IndexValue>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("uom");
            Uom = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("depthDatum");
            DepthDatum = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ObjectChange : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.Object.ObjectChange";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.Object.ObjectChange", 3);
            encoder.EncodeRecordFieldName("changeKind");
            encoder.EncodeEnum<Energistics.Etp.v12.Datatypes.Object.ObjectChangeKind>(ChangeKind);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("changeTime");
            encoder.EncodeTimestampMicrosDateTimeAsLong(ChangeTime);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("dataObject");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.DataObject>(DataObject);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.Object.ObjectChange", 3);
            decoder.DecodeRecordFieldName("changeKind");
            ChangeKind = decoder.DecodeEnum<Energistics.Etp.v12.Datatypes.Object.ObjectChangeKind>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("changeTime");
            ChangeTime = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("dataObject");
            DataObject = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.Object.DataObject>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ObjectPart : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.Object.ObjectPart";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.Object.ObjectPart", 2);
            encoder.EncodeRecordFieldName("uid");
            encoder.EncodeString(Uid);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeBytes(Data);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.Object.ObjectPart", 2);
            decoder.DecodeRecordFieldName("uid");
            Uid = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeBytes();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PartsMetadataInfo : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.Object.PartsMetadataInfo";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.Object.PartsMetadataInfo", 4);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("name");
            encoder.EncodeString(Name);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("index");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.IndexMetadataRecord>(Index);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("customData");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>(CustomData);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.Object.PartsMetadataInfo", 4);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("name");
            Name = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("index");
            Index = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.IndexMetadataRecord>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("customData");
            CustomData = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PutResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.Object.PutResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.Object.PutResponse", 4);
            encoder.EncodeRecordFieldName("createdContainedObjectUris");
            encoder.EncodeArrayOfString(CreatedContainedObjectUris);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("deletedContainedObjectUris");
            encoder.EncodeArrayOfString(DeletedContainedObjectUris);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("joinedContainedObjectUris");
            encoder.EncodeArrayOfString(JoinedContainedObjectUris);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("unjoinedContainedObjectUris");
            encoder.EncodeArrayOfString(UnjoinedContainedObjectUris);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.Object.PutResponse", 4);
            decoder.DecodeRecordFieldName("createdContainedObjectUris");
            CreatedContainedObjectUris = decoder.DecodeArrayOfString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("deletedContainedObjectUris");
            DeletedContainedObjectUris = decoder.DecodeArrayOfString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("joinedContainedObjectUris");
            JoinedContainedObjectUris = decoder.DecodeArrayOfString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("unjoinedContainedObjectUris");
            UnjoinedContainedObjectUris = decoder.DecodeArrayOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class Resource : IAvroRecord
    {
        private static NullableTypeConverter NullableIntNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "int");
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.Object.Resource";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.Object.Resource", 10);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("alternateUris");
            encoder.EncodeArrayOfString(AlternateUris);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("name");
            encoder.EncodeString(Name);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("sourceCount");
            encoder.EncodeNullableInt(SourceCount, NullableIntNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("targetCount");
            encoder.EncodeNullableInt(TargetCount, NullableIntNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("lastChanged");
            encoder.EncodeTimestampMicrosDateTimeAsLong(LastChanged);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("storeLastWrite");
            encoder.EncodeTimestampMicrosDateTimeAsLong(StoreLastWrite);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("storeCreated");
            encoder.EncodeTimestampMicrosDateTimeAsLong(StoreCreated);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("activeStatus");
            encoder.EncodeEnum<Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind>(ActiveStatus);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("customData");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>(CustomData);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.Object.Resource", 10);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("alternateUris");
            AlternateUris = decoder.DecodeArrayOfString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("name");
            Name = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("sourceCount");
            SourceCount = decoder.DecodeNullableInt(NullableIntNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("targetCount");
            TargetCount = decoder.DecodeNullableInt(NullableIntNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("lastChanged");
            LastChanged = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("storeLastWrite");
            StoreLastWrite = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("storeCreated");
            StoreCreated = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("activeStatus");
            ActiveStatus = decoder.DecodeEnum<Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("customData");
            CustomData = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class SubscriptionInfo : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.Object.SubscriptionInfo";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.Object.SubscriptionInfo", 5);
            encoder.EncodeRecordFieldName("context");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.ContextInfo>(Context);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("scope");
            encoder.EncodeEnum<Energistics.Etp.v12.Datatypes.Object.ContextScopeKind>(Scope);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("requestUuid");
            encoder.EncodeUuidGuidAsFixed(RequestUuid);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("includeObjectData");
            encoder.EncodeBoolean(IncludeObjectData);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("format");
            encoder.EncodeString(Format);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.Object.SubscriptionInfo", 5);
            decoder.DecodeRecordFieldName("context");
            Context = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.Object.ContextInfo>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("scope");
            Scope = decoder.DecodeEnum<Energistics.Etp.v12.Datatypes.Object.ContextScopeKind>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("requestUuid");
            RequestUuid = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("includeObjectData");
            IncludeObjectData = decoder.DecodeBoolean();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("format");
            Format = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class SupportedType : IAvroRecord
    {
        private static NullableTypeConverter NullableIntNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "int");
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Datatypes.Object.SupportedType";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Datatypes.Object.SupportedType", 3);
            encoder.EncodeRecordFieldName("dataObjectType");
            encoder.EncodeString(DataObjectType);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("objectCount");
            encoder.EncodeNullableInt(ObjectCount, NullableIntNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("relationshipKind");
            encoder.EncodeEnum<Energistics.Etp.v12.Datatypes.Object.RelationshipKind>(RelationshipKind);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Datatypes.Object.SupportedType", 3);
            decoder.DecodeRecordFieldName("dataObjectType");
            DataObjectType = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("objectCount");
            ObjectCount = decoder.DecodeNullableInt(NullableIntNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("relationshipKind");
            RelationshipKind = decoder.DecodeEnum<Energistics.Etp.v12.Datatypes.Object.RelationshipKind>();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v12.PrivateProtocols.WitsmlSoap
{
    public partial class WMLS_AddToStore : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_AddToStore";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_AddToStore", 4);
            encoder.EncodeRecordFieldName("WMLtypeIn");
            encoder.EncodeString(WMLtypeIn);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("XMLin");
            encoder.EncodeString(XMLin);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("OptionsIn");
            encoder.EncodeString(OptionsIn);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("CapabilitiesIn");
            encoder.EncodeString(CapabilitiesIn);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_AddToStore", 4);
            decoder.DecodeRecordFieldName("WMLtypeIn");
            WMLtypeIn = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("XMLin");
            XMLin = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("OptionsIn");
            OptionsIn = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("CapabilitiesIn");
            CapabilitiesIn = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class WMLS_AddToStoreResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_AddToStoreResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_AddToStoreResponse", 2);
            encoder.EncodeRecordFieldName("Result");
            encoder.EncodeInt(Result);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("SuppMsgOut");
            encoder.EncodeString(SuppMsgOut);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_AddToStoreResponse", 2);
            decoder.DecodeRecordFieldName("Result");
            Result = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("SuppMsgOut");
            SuppMsgOut = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class WMLS_DeleteFromStore : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_DeleteFromStore";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_DeleteFromStore", 4);
            encoder.EncodeRecordFieldName("WMLtypeIn");
            encoder.EncodeString(WMLtypeIn);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("XMLin");
            encoder.EncodeString(XMLin);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("OptionsIn");
            encoder.EncodeString(OptionsIn);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("CapabilitiesIn");
            encoder.EncodeString(CapabilitiesIn);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_DeleteFromStore", 4);
            decoder.DecodeRecordFieldName("WMLtypeIn");
            WMLtypeIn = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("XMLin");
            XMLin = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("OptionsIn");
            OptionsIn = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("CapabilitiesIn");
            CapabilitiesIn = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class WMLS_DeleteFromStoreResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_DeleteFromStoreResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_DeleteFromStoreResponse", 2);
            encoder.EncodeRecordFieldName("Result");
            encoder.EncodeInt(Result);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("SuppMsgOut");
            encoder.EncodeString(SuppMsgOut);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_DeleteFromStoreResponse", 2);
            decoder.DecodeRecordFieldName("Result");
            Result = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("SuppMsgOut");
            SuppMsgOut = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class WMLS_GetBaseMsg : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetBaseMsg";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetBaseMsg", 1);
            encoder.EncodeRecordFieldName("ReturnValueIn");
            encoder.EncodeInt(ReturnValueIn);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetBaseMsg", 1);
            decoder.DecodeRecordFieldName("ReturnValueIn");
            ReturnValueIn = decoder.DecodeInt();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class WMLS_GetBaseMsgResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetBaseMsgResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetBaseMsgResponse", 1);
            encoder.EncodeRecordFieldName("Result");
            encoder.EncodeString(Result);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetBaseMsgResponse", 1);
            decoder.DecodeRecordFieldName("Result");
            Result = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class WMLS_GetCap : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetCap";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetCap", 1);
            encoder.EncodeRecordFieldName("OptionsIn");
            encoder.EncodeString(OptionsIn);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetCap", 1);
            decoder.DecodeRecordFieldName("OptionsIn");
            OptionsIn = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class WMLS_GetCapResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetCapResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetCapResponse", 3);
            encoder.EncodeRecordFieldName("Result");
            encoder.EncodeInt(Result);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("CapabilitiesOut");
            encoder.EncodeString(CapabilitiesOut);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("SuppMsgOut");
            encoder.EncodeString(SuppMsgOut);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetCapResponse", 3);
            decoder.DecodeRecordFieldName("Result");
            Result = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("CapabilitiesOut");
            CapabilitiesOut = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("SuppMsgOut");
            SuppMsgOut = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class WMLS_GetFromStore : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetFromStore";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetFromStore", 4);
            encoder.EncodeRecordFieldName("WMLtypeIn");
            encoder.EncodeString(WMLtypeIn);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("XMLin");
            encoder.EncodeString(XMLin);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("OptionsIn");
            encoder.EncodeString(OptionsIn);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("CapabilitiesIn");
            encoder.EncodeString(CapabilitiesIn);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetFromStore", 4);
            decoder.DecodeRecordFieldName("WMLtypeIn");
            WMLtypeIn = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("XMLin");
            XMLin = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("OptionsIn");
            OptionsIn = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("CapabilitiesIn");
            CapabilitiesIn = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class WMLS_GetFromStoreResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetFromStoreResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetFromStoreResponse", 3);
            encoder.EncodeRecordFieldName("Result");
            encoder.EncodeInt(Result);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("XMLout");
            encoder.EncodeString(XMLout);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("SuppMsgOut");
            encoder.EncodeString(SuppMsgOut);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetFromStoreResponse", 3);
            decoder.DecodeRecordFieldName("Result");
            Result = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("XMLout");
            XMLout = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("SuppMsgOut");
            SuppMsgOut = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class WMLS_GetVersion : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetVersion";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetVersion", 0);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetVersion", 0);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class WMLS_GetVersionResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetVersionResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetVersionResponse", 1);
            encoder.EncodeRecordFieldName("Result");
            encoder.EncodeString(Result);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetVersionResponse", 1);
            decoder.DecodeRecordFieldName("Result");
            Result = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class WMLS_UpdateInStore : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_UpdateInStore";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_UpdateInStore", 4);
            encoder.EncodeRecordFieldName("WMLtypeIn");
            encoder.EncodeString(WMLtypeIn);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("XMLin");
            encoder.EncodeString(XMLin);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("OptionsIn");
            encoder.EncodeString(OptionsIn);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("CapabilitiesIn");
            encoder.EncodeString(CapabilitiesIn);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_UpdateInStore", 4);
            decoder.DecodeRecordFieldName("WMLtypeIn");
            WMLtypeIn = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("XMLin");
            XMLin = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("OptionsIn");
            OptionsIn = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("CapabilitiesIn");
            CapabilitiesIn = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class WMLS_UpdateInStoreResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_UpdateInStoreResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_UpdateInStoreResponse", 2);
            encoder.EncodeRecordFieldName("Result");
            encoder.EncodeInt(Result);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("SuppMsgOut");
            encoder.EncodeString(SuppMsgOut);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_UpdateInStoreResponse", 2);
            decoder.DecodeRecordFieldName("Result");
            Result = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("SuppMsgOut");
            SuppMsgOut = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v12.Protocol.ChannelDataFrame
{
    public partial class CancelGetFrame : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelDataFrame.CancelGetFrame";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataFrame.CancelGetFrame", 1);
            encoder.EncodeRecordFieldName("requestUuid");
            encoder.EncodeUuidGuidAsFixed(RequestUuid);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataFrame.CancelGetFrame", 1);
            decoder.DecodeRecordFieldName("requestUuid");
            RequestUuid = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetFrame : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrame";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrame", 5);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("includeAllChannelSecondaryIndexes");
            encoder.EncodeBoolean(IncludeAllChannelSecondaryIndexes);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("requestedInterval");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.IndexInterval>(RequestedInterval);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("requestUuid");
            encoder.EncodeUuidGuidAsFixed(RequestUuid);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("requestedSecondaryIntervals");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.IndexInterval>(RequestedSecondaryIntervals);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrame", 5);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("includeAllChannelSecondaryIndexes");
            IncludeAllChannelSecondaryIndexes = decoder.DecodeBoolean();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("requestedInterval");
            RequestedInterval = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.Object.IndexInterval>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("requestUuid");
            RequestUuid = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("requestedSecondaryIntervals");
            RequestedSecondaryIntervals = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.IndexInterval>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetFrameMetadata : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameMetadata";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameMetadata", 2);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("includeAllChannelSecondaryIndexes");
            encoder.EncodeBoolean(IncludeAllChannelSecondaryIndexes);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameMetadata", 2);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("includeAllChannelSecondaryIndexes");
            IncludeAllChannelSecondaryIndexes = decoder.DecodeBoolean();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetFrameMetadataResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameMetadataResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameMetadataResponse", 3);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("indexes");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.IndexMetadataRecord>(Indexes);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("channels");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.FrameChannelMetadataRecord>(Channels);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameMetadataResponse", 3);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("indexes");
            Indexes = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.IndexMetadataRecord>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("channels");
            Channels = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.FrameChannelMetadataRecord>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetFrameResponseHeader : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameResponseHeader";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameResponseHeader", 2);
            encoder.EncodeRecordFieldName("channelUris");
            encoder.EncodeArrayOfString(ChannelUris);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("indexes");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.IndexMetadataRecord>(Indexes);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameResponseHeader", 2);
            decoder.DecodeRecordFieldName("channelUris");
            ChannelUris = decoder.DecodeArrayOfString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("indexes");
            Indexes = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.IndexMetadataRecord>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetFrameResponseRows : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameResponseRows";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameResponseRows", 1);
            encoder.EncodeRecordFieldName("frame");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.FrameRow>(Frame);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameResponseRows", 1);
            decoder.DecodeRecordFieldName("frame");
            Frame = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.FrameRow>();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v12.Protocol.ChannelDataLoad
{
    public partial class ChannelData : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelDataLoad.ChannelData";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataLoad.ChannelData", 1);
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.DataItem>(Data);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataLoad.ChannelData", 1);
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.DataItem>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ChannelsClosed : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelDataLoad.ChannelsClosed";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataLoad.ChannelsClosed", 2);
            encoder.EncodeRecordFieldName("reason");
            encoder.EncodeString(Reason);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("id");
            encoder.EncodeMapOfLong(Id);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataLoad.ChannelsClosed", 2);
            decoder.DecodeRecordFieldName("reason");
            Reason = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("id");
            Id = decoder.DecodeMapOfLong();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class CloseChannels : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelDataLoad.CloseChannels";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataLoad.CloseChannels", 1);
            encoder.EncodeRecordFieldName("id");
            encoder.EncodeMapOfLong(Id);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataLoad.CloseChannels", 1);
            decoder.DecodeRecordFieldName("id");
            Id = decoder.DecodeMapOfLong();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class OpenChannels : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelDataLoad.OpenChannels";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataLoad.OpenChannels", 1);
            encoder.EncodeRecordFieldName("uris");
            encoder.EncodeMapOfString(Uris);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataLoad.OpenChannels", 1);
            decoder.DecodeRecordFieldName("uris");
            Uris = decoder.DecodeMapOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class OpenChannelsResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelDataLoad.OpenChannelsResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataLoad.OpenChannelsResponse", 1);
            encoder.EncodeRecordFieldName("channels");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.OpenChannelInfo>(Channels);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataLoad.OpenChannelsResponse", 1);
            decoder.DecodeRecordFieldName("channels");
            Channels = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.OpenChannelInfo>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ReplaceRange : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelDataLoad.ReplaceRange";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataLoad.ReplaceRange", 3);
            encoder.EncodeRecordFieldName("changedInterval");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.IndexInterval>(ChangedInterval);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("channelIds");
            encoder.EncodeArrayOfLong(ChannelIds);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.DataItem>(Data);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataLoad.ReplaceRange", 3);
            decoder.DecodeRecordFieldName("changedInterval");
            ChangedInterval = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.Object.IndexInterval>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("channelIds");
            ChannelIds = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.DataItem>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ReplaceRangeResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelDataLoad.ReplaceRangeResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataLoad.ReplaceRangeResponse", 1);
            encoder.EncodeRecordFieldName("channelChangeTime");
            encoder.EncodeTimestampMicrosDateTimeAsLong(ChannelChangeTime);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataLoad.ReplaceRangeResponse", 1);
            decoder.DecodeRecordFieldName("channelChangeTime");
            ChannelChangeTime = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class TruncateChannels : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelDataLoad.TruncateChannels";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataLoad.TruncateChannels", 1);
            encoder.EncodeRecordFieldName("channels");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.TruncateInfo>(Channels);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataLoad.TruncateChannels", 1);
            decoder.DecodeRecordFieldName("channels");
            Channels = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.TruncateInfo>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class TruncateChannelsResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelDataLoad.TruncateChannelsResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataLoad.TruncateChannelsResponse", 1);
            encoder.EncodeRecordFieldName("channelsTruncatedTime");
            encoder.EncodeMapOfTimestampMicrosDateTimeAsLong(ChannelsTruncatedTime);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelDataLoad.TruncateChannelsResponse", 1);
            decoder.DecodeRecordFieldName("channelsTruncatedTime");
            ChannelsTruncatedTime = decoder.DecodeMapOfTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v12.Protocol.ChannelStreaming
{
    public partial class ChannelData : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelStreaming.ChannelData";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelStreaming.ChannelData", 1);
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.DataItem>(Data);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelStreaming.ChannelData", 1);
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.DataItem>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ChannelMetadata : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelStreaming.ChannelMetadata";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelStreaming.ChannelMetadata", 1);
            encoder.EncodeRecordFieldName("channels");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.ChannelMetadataRecord>(Channels);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelStreaming.ChannelMetadata", 1);
            decoder.DecodeRecordFieldName("channels");
            Channels = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.ChannelMetadataRecord>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class StartStreaming : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelStreaming.StartStreaming";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelStreaming.StartStreaming", 0);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelStreaming.StartStreaming", 0);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class StopStreaming : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelStreaming.StopStreaming";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelStreaming.StopStreaming", 0);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelStreaming.StopStreaming", 0);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class TruncateChannels : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelStreaming.TruncateChannels";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelStreaming.TruncateChannels", 1);
            encoder.EncodeRecordFieldName("channels");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.TruncateInfo>(Channels);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelStreaming.TruncateChannels", 1);
            decoder.DecodeRecordFieldName("channels");
            Channels = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.TruncateInfo>();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v12.Protocol.ChannelSubscribe
{
    public partial class CancelGetRanges : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelSubscribe.CancelGetRanges";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.CancelGetRanges", 1);
            encoder.EncodeRecordFieldName("requestUuid");
            encoder.EncodeUuidGuidAsFixed(RequestUuid);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.CancelGetRanges", 1);
            decoder.DecodeRecordFieldName("requestUuid");
            RequestUuid = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ChannelData : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelSubscribe.ChannelData";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.ChannelData", 1);
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.DataItem>(Data);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.ChannelData", 1);
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.DataItem>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ChannelsTruncated : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelSubscribe.ChannelsTruncated";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.ChannelsTruncated", 2);
            encoder.EncodeRecordFieldName("channels");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.TruncateInfo>(Channels);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("changeTime");
            encoder.EncodeTimestampMicrosDateTimeAsLong(ChangeTime);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.ChannelsTruncated", 2);
            decoder.DecodeRecordFieldName("channels");
            Channels = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.TruncateInfo>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("changeTime");
            ChangeTime = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetChangeAnnotations : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChangeAnnotations";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChangeAnnotations", 2);
            encoder.EncodeRecordFieldName("channels");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.ChannelChangeRequestInfo>(Channels);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("latestOnly");
            encoder.EncodeBoolean(LatestOnly);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChangeAnnotations", 2);
            decoder.DecodeRecordFieldName("channels");
            Channels = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.ChannelChangeRequestInfo>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("latestOnly");
            LatestOnly = decoder.DecodeBoolean();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetChangeAnnotationsResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChangeAnnotationsResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChangeAnnotationsResponse", 1);
            encoder.EncodeRecordFieldName("changes");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.ChangeResponseInfo>(Changes);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChangeAnnotationsResponse", 1);
            decoder.DecodeRecordFieldName("changes");
            Changes = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.ChangeResponseInfo>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetChannelMetadata : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChannelMetadata";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChannelMetadata", 1);
            encoder.EncodeRecordFieldName("uris");
            encoder.EncodeMapOfString(Uris);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChannelMetadata", 1);
            decoder.DecodeRecordFieldName("uris");
            Uris = decoder.DecodeMapOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetChannelMetadataResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChannelMetadataResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChannelMetadataResponse", 1);
            encoder.EncodeRecordFieldName("metadata");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.ChannelMetadataRecord>(Metadata);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChannelMetadataResponse", 1);
            decoder.DecodeRecordFieldName("metadata");
            Metadata = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.ChannelMetadataRecord>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetRanges : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelSubscribe.GetRanges";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.GetRanges", 2);
            encoder.EncodeRecordFieldName("requestUuid");
            encoder.EncodeUuidGuidAsFixed(RequestUuid);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("channelRanges");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.ChannelRangeInfo>(ChannelRanges);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.GetRanges", 2);
            decoder.DecodeRecordFieldName("requestUuid");
            RequestUuid = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("channelRanges");
            ChannelRanges = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.ChannelRangeInfo>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetRangesResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelSubscribe.GetRangesResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.GetRangesResponse", 1);
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.DataItem>(Data);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.GetRangesResponse", 1);
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.DataItem>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class RangeReplaced : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelSubscribe.RangeReplaced";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.RangeReplaced", 4);
            encoder.EncodeRecordFieldName("changeTime");
            encoder.EncodeTimestampMicrosDateTimeAsLong(ChangeTime);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("channelIds");
            encoder.EncodeArrayOfLong(ChannelIds);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("changedInterval");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.IndexInterval>(ChangedInterval);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.DataItem>(Data);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.RangeReplaced", 4);
            decoder.DecodeRecordFieldName("changeTime");
            ChangeTime = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("channelIds");
            ChannelIds = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("changedInterval");
            ChangedInterval = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.Object.IndexInterval>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.DataItem>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class SubscribeChannels : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscribeChannels";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscribeChannels", 1);
            encoder.EncodeRecordFieldName("channels");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.ChannelSubscribeInfo>(Channels);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscribeChannels", 1);
            decoder.DecodeRecordFieldName("channels");
            Channels = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.ChannelSubscribeInfo>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class SubscribeChannelsResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscribeChannelsResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscribeChannelsResponse", 1);
            encoder.EncodeRecordFieldName("success");
            encoder.EncodeMapOfString(Success);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscribeChannelsResponse", 1);
            decoder.DecodeRecordFieldName("success");
            Success = decoder.DecodeMapOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class SubscriptionsStopped : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscriptionsStopped";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscriptionsStopped", 2);
            encoder.EncodeRecordFieldName("reason");
            encoder.EncodeString(Reason);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("channelIds");
            encoder.EncodeMapOfLong(ChannelIds);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscriptionsStopped", 2);
            decoder.DecodeRecordFieldName("reason");
            Reason = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("channelIds");
            ChannelIds = decoder.DecodeMapOfLong();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class UnsubscribeChannels : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.ChannelSubscribe.UnsubscribeChannels";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.UnsubscribeChannels", 1);
            encoder.EncodeRecordFieldName("channelIds");
            encoder.EncodeMapOfLong(ChannelIds);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.ChannelSubscribe.UnsubscribeChannels", 1);
            decoder.DecodeRecordFieldName("channelIds");
            ChannelIds = decoder.DecodeMapOfLong();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v12.Protocol.Core
{
    public partial class Acknowledge : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Core.Acknowledge";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Core.Acknowledge", 0);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Core.Acknowledge", 0);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class Authorize : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Core.Authorize";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Core.Authorize", 2);
            encoder.EncodeRecordFieldName("authorization");
            encoder.EncodeString(Authorization);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("supplementalAuthorization");
            encoder.EncodeMapOfString(SupplementalAuthorization);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Core.Authorize", 2);
            decoder.DecodeRecordFieldName("authorization");
            Authorization = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("supplementalAuthorization");
            SupplementalAuthorization = decoder.DecodeMapOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class AuthorizeResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Core.AuthorizeResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Core.AuthorizeResponse", 2);
            encoder.EncodeRecordFieldName("success");
            encoder.EncodeBoolean(Success);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("challenges");
            encoder.EncodeArrayOfString(Challenges);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Core.AuthorizeResponse", 2);
            decoder.DecodeRecordFieldName("success");
            Success = decoder.DecodeBoolean();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("challenges");
            Challenges = decoder.DecodeArrayOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class CloseSession : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Core.CloseSession";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Core.CloseSession", 1);
            encoder.EncodeRecordFieldName("reason");
            encoder.EncodeString(Reason);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Core.CloseSession", 1);
            decoder.DecodeRecordFieldName("reason");
            Reason = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class OpenSession : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Core.OpenSession";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Core.OpenSession", 11);
            encoder.EncodeRecordFieldName("applicationName");
            encoder.EncodeString(ApplicationName);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("applicationVersion");
            encoder.EncodeString(ApplicationVersion);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("serverInstanceId");
            encoder.EncodeUuidGuidAsFixed(ServerInstanceId);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("supportedProtocols");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.SupportedProtocol>(SupportedProtocols);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("supportedDataObjects");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.SupportedDataObject>(SupportedDataObjects);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("supportedCompression");
            encoder.EncodeString(SupportedCompression);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("supportedFormats");
            encoder.EncodeArrayOfString(SupportedFormats);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("currentDateTime");
            encoder.EncodeTimestampMicrosDateTimeAsLong(CurrentDateTime);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("earliestRetainedChangeTime");
            encoder.EncodeTimestampMicrosDateTimeAsLong(EarliestRetainedChangeTime);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("sessionId");
            encoder.EncodeUuidGuidAsFixed(SessionId);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("endpointCapabilities");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>(EndpointCapabilities);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Core.OpenSession", 11);
            decoder.DecodeRecordFieldName("applicationName");
            ApplicationName = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("applicationVersion");
            ApplicationVersion = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("serverInstanceId");
            ServerInstanceId = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("supportedProtocols");
            SupportedProtocols = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.SupportedProtocol>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("supportedDataObjects");
            SupportedDataObjects = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.SupportedDataObject>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("supportedCompression");
            SupportedCompression = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("supportedFormats");
            SupportedFormats = decoder.DecodeArrayOfString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("currentDateTime");
            CurrentDateTime = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("earliestRetainedChangeTime");
            EarliestRetainedChangeTime = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("sessionId");
            SessionId = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("endpointCapabilities");
            EndpointCapabilities = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class Ping : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Core.Ping";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Core.Ping", 1);
            encoder.EncodeRecordFieldName("currentDateTime");
            encoder.EncodeTimestampMicrosDateTimeAsLong(CurrentDateTime);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Core.Ping", 1);
            decoder.DecodeRecordFieldName("currentDateTime");
            CurrentDateTime = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class Pong : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Core.Pong";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Core.Pong", 1);
            encoder.EncodeRecordFieldName("currentDateTime");
            encoder.EncodeTimestampMicrosDateTimeAsLong(CurrentDateTime);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Core.Pong", 1);
            decoder.DecodeRecordFieldName("currentDateTime");
            CurrentDateTime = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ProtocolException : IAvroRecord
    {
        private static NullableTypeConverter NullableErrorInfoNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "Energistics.Etp.v12.Datatypes.ErrorInfo");
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Core.ProtocolException";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Core.ProtocolException", 2);
            encoder.EncodeRecordFieldName("error");
            encoder.EncodeNullableAvroObject<Energistics.Etp.v12.Datatypes.ErrorInfo>(Error, NullableErrorInfoNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("errors");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.ErrorInfo>(Errors);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Core.ProtocolException", 2);
            decoder.DecodeRecordFieldName("error");
            Error = decoder.DecodeNullableAvroObject<Energistics.Etp.v12.Datatypes.ErrorInfo>(NullableErrorInfoNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("errors");
            Errors = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.ErrorInfo>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class RequestSession : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Core.RequestSession";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Core.RequestSession", 11);
            encoder.EncodeRecordFieldName("applicationName");
            encoder.EncodeString(ApplicationName);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("applicationVersion");
            encoder.EncodeString(ApplicationVersion);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("clientInstanceId");
            encoder.EncodeUuidGuidAsFixed(ClientInstanceId);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("requestedProtocols");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.SupportedProtocol>(RequestedProtocols);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("supportedDataObjects");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.SupportedDataObject>(SupportedDataObjects);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("supportedCompression");
            encoder.EncodeArrayOfString(SupportedCompression);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("supportedFormats");
            encoder.EncodeArrayOfString(SupportedFormats);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("currentDateTime");
            encoder.EncodeTimestampMicrosDateTimeAsLong(CurrentDateTime);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("earliestRetainedChangeTime");
            encoder.EncodeTimestampMicrosDateTimeAsLong(EarliestRetainedChangeTime);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("serverAuthorizationRequired");
            encoder.EncodeBoolean(ServerAuthorizationRequired);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("endpointCapabilities");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>(EndpointCapabilities);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Core.RequestSession", 11);
            decoder.DecodeRecordFieldName("applicationName");
            ApplicationName = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("applicationVersion");
            ApplicationVersion = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("clientInstanceId");
            ClientInstanceId = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("requestedProtocols");
            RequestedProtocols = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.SupportedProtocol>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("supportedDataObjects");
            SupportedDataObjects = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.SupportedDataObject>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("supportedCompression");
            SupportedCompression = decoder.DecodeArrayOfString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("supportedFormats");
            SupportedFormats = decoder.DecodeArrayOfString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("currentDateTime");
            CurrentDateTime = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("earliestRetainedChangeTime");
            EarliestRetainedChangeTime = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("serverAuthorizationRequired");
            ServerAuthorizationRequired = decoder.DecodeBoolean();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("endpointCapabilities");
            EndpointCapabilities = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataValue>();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v12.Protocol.DataArray
{
    public partial class GetDataArrayMetadata : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.DataArray.GetDataArrayMetadata";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.GetDataArrayMetadata", 1);
            encoder.EncodeRecordFieldName("dataArrays");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier>(DataArrays);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.GetDataArrayMetadata", 1);
            decoder.DecodeRecordFieldName("dataArrays");
            DataArrays = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetDataArrayMetadataResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.DataArray.GetDataArrayMetadataResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.GetDataArrayMetadataResponse", 1);
            encoder.EncodeRecordFieldName("arrayMetadata");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayMetadata>(ArrayMetadata);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.GetDataArrayMetadataResponse", 1);
            decoder.DecodeRecordFieldName("arrayMetadata");
            ArrayMetadata = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayMetadata>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetDataArrays : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.DataArray.GetDataArrays";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.GetDataArrays", 1);
            encoder.EncodeRecordFieldName("dataArrays");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier>(DataArrays);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.GetDataArrays", 1);
            decoder.DecodeRecordFieldName("dataArrays");
            DataArrays = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetDataArraysResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.DataArray.GetDataArraysResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.GetDataArraysResponse", 1);
            encoder.EncodeRecordFieldName("dataArrays");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArray>(DataArrays);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.GetDataArraysResponse", 1);
            decoder.DecodeRecordFieldName("dataArrays");
            DataArrays = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArray>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetDataSubarrays : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.DataArray.GetDataSubarrays";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.GetDataSubarrays", 1);
            encoder.EncodeRecordFieldName("dataSubarrays");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.GetDataSubarraysType>(DataSubarrays);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.GetDataSubarrays", 1);
            decoder.DecodeRecordFieldName("dataSubarrays");
            DataSubarrays = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.GetDataSubarraysType>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetDataSubarraysResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.DataArray.GetDataSubarraysResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.GetDataSubarraysResponse", 1);
            encoder.EncodeRecordFieldName("dataSubarrays");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArray>(DataSubarrays);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.GetDataSubarraysResponse", 1);
            decoder.DecodeRecordFieldName("dataSubarrays");
            DataSubarrays = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArray>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PutDataArrays : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.DataArray.PutDataArrays";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.PutDataArrays", 1);
            encoder.EncodeRecordFieldName("dataArrays");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.PutDataArraysType>(DataArrays);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.PutDataArrays", 1);
            decoder.DecodeRecordFieldName("dataArrays");
            DataArrays = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.PutDataArraysType>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PutDataArraysResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.DataArray.PutDataArraysResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.PutDataArraysResponse", 1);
            encoder.EncodeRecordFieldName("success");
            encoder.EncodeMapOfString(Success);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.PutDataArraysResponse", 1);
            decoder.DecodeRecordFieldName("success");
            Success = decoder.DecodeMapOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PutDataSubarrays : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.DataArray.PutDataSubarrays";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.PutDataSubarrays", 1);
            encoder.EncodeRecordFieldName("dataSubarrays");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.PutDataSubarraysType>(DataSubarrays);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.PutDataSubarrays", 1);
            decoder.DecodeRecordFieldName("dataSubarrays");
            DataSubarrays = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.PutDataSubarraysType>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PutDataSubarraysResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.DataArray.PutDataSubarraysResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.PutDataSubarraysResponse", 1);
            encoder.EncodeRecordFieldName("success");
            encoder.EncodeMapOfString(Success);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.PutDataSubarraysResponse", 1);
            decoder.DecodeRecordFieldName("success");
            Success = decoder.DecodeMapOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PutUninitializedDataArrays : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.DataArray.PutUninitializedDataArrays";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.PutUninitializedDataArrays", 1);
            encoder.EncodeRecordFieldName("dataArrays");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.PutUninitializedDataArrayType>(DataArrays);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.PutUninitializedDataArrays", 1);
            decoder.DecodeRecordFieldName("dataArrays");
            DataArrays = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.PutUninitializedDataArrayType>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PutUninitializedDataArraysResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.DataArray.PutUninitializedDataArraysResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.PutUninitializedDataArraysResponse", 1);
            encoder.EncodeRecordFieldName("success");
            encoder.EncodeMapOfString(Success);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.DataArray.PutUninitializedDataArraysResponse", 1);
            decoder.DecodeRecordFieldName("success");
            Success = decoder.DecodeMapOfString();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v12.Protocol.Dataspace
{
    public partial class DeleteDataspaces : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Dataspace.DeleteDataspaces";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Dataspace.DeleteDataspaces", 1);
            encoder.EncodeRecordFieldName("uris");
            encoder.EncodeMapOfString(Uris);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Dataspace.DeleteDataspaces", 1);
            decoder.DecodeRecordFieldName("uris");
            Uris = decoder.DecodeMapOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class DeleteDataspacesResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Dataspace.DeleteDataspacesResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Dataspace.DeleteDataspacesResponse", 1);
            encoder.EncodeRecordFieldName("success");
            encoder.EncodeMapOfString(Success);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Dataspace.DeleteDataspacesResponse", 1);
            decoder.DecodeRecordFieldName("success");
            Success = decoder.DecodeMapOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetDataspaces : IAvroRecord
    {
        private static NullableTypeConverter NullableTimestampMicrosDateTimeAsLongNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "long");
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Dataspace.GetDataspaces";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Dataspace.GetDataspaces", 1);
            encoder.EncodeRecordFieldName("storeLastWriteFilter");
            encoder.EncodeNullableTimestampMicrosDateTimeAsLong(StoreLastWriteFilter, NullableTimestampMicrosDateTimeAsLongNullFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Dataspace.GetDataspaces", 1);
            decoder.DecodeRecordFieldName("storeLastWriteFilter");
            StoreLastWriteFilter = decoder.DecodeNullableTimestampMicrosDateTimeAsLong(NullableTimestampMicrosDateTimeAsLongNullFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetDataspacesResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Dataspace.GetDataspacesResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Dataspace.GetDataspacesResponse", 1);
            encoder.EncodeRecordFieldName("dataspaces");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.Dataspace>(Dataspaces);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Dataspace.GetDataspacesResponse", 1);
            decoder.DecodeRecordFieldName("dataspaces");
            Dataspaces = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.Dataspace>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PutDataspaces : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Dataspace.PutDataspaces";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Dataspace.PutDataspaces", 1);
            encoder.EncodeRecordFieldName("dataspaces");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.Dataspace>(Dataspaces);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Dataspace.PutDataspaces", 1);
            decoder.DecodeRecordFieldName("dataspaces");
            Dataspaces = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.Dataspace>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PutDataspacesResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Dataspace.PutDataspacesResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Dataspace.PutDataspacesResponse", 1);
            encoder.EncodeRecordFieldName("success");
            encoder.EncodeMapOfString(Success);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Dataspace.PutDataspacesResponse", 1);
            decoder.DecodeRecordFieldName("success");
            Success = decoder.DecodeMapOfString();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v12.Protocol.Discovery
{
    public partial class GetDeletedResources : IAvroRecord
    {
        private static NullableTypeConverter NullableTimestampMicrosDateTimeAsLongNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "long");
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Discovery.GetDeletedResources";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Discovery.GetDeletedResources", 3);
            encoder.EncodeRecordFieldName("dataspaceUri");
            encoder.EncodeString(DataspaceUri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("deleteTimeFilter");
            encoder.EncodeNullableTimestampMicrosDateTimeAsLong(DeleteTimeFilter, NullableTimestampMicrosDateTimeAsLongNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("dataObjectTypes");
            encoder.EncodeArrayOfString(DataObjectTypes);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Discovery.GetDeletedResources", 3);
            decoder.DecodeRecordFieldName("dataspaceUri");
            DataspaceUri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("deleteTimeFilter");
            DeleteTimeFilter = decoder.DecodeNullableTimestampMicrosDateTimeAsLong(NullableTimestampMicrosDateTimeAsLongNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("dataObjectTypes");
            DataObjectTypes = decoder.DecodeArrayOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetDeletedResourcesResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Discovery.GetDeletedResourcesResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Discovery.GetDeletedResourcesResponse", 1);
            encoder.EncodeRecordFieldName("deletedResources");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.DeletedResource>(DeletedResources);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Discovery.GetDeletedResourcesResponse", 1);
            decoder.DecodeRecordFieldName("deletedResources");
            DeletedResources = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.DeletedResource>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetResources : IAvroRecord
    {
        private static NullableTypeConverter NullableTimestampMicrosDateTimeAsLongNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "long");
        private static NullableTypeConverter NullableActiveStatusKindNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind");
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Discovery.GetResources";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Discovery.GetResources", 6);
            encoder.EncodeRecordFieldName("context");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.ContextInfo>(Context);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("scope");
            encoder.EncodeEnum<Energistics.Etp.v12.Datatypes.Object.ContextScopeKind>(Scope);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("countObjects");
            encoder.EncodeBoolean(CountObjects);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("storeLastWriteFilter");
            encoder.EncodeNullableTimestampMicrosDateTimeAsLong(StoreLastWriteFilter, NullableTimestampMicrosDateTimeAsLongNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("activeStatusFilter");
            encoder.EncodeNullableEnum<Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind>(ActiveStatusFilter, NullableActiveStatusKindNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("includeEdges");
            encoder.EncodeBoolean(IncludeEdges);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Discovery.GetResources", 6);
            decoder.DecodeRecordFieldName("context");
            Context = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.Object.ContextInfo>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("scope");
            Scope = decoder.DecodeEnum<Energistics.Etp.v12.Datatypes.Object.ContextScopeKind>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("countObjects");
            CountObjects = decoder.DecodeBoolean();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("storeLastWriteFilter");
            StoreLastWriteFilter = decoder.DecodeNullableTimestampMicrosDateTimeAsLong(NullableTimestampMicrosDateTimeAsLongNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("activeStatusFilter");
            ActiveStatusFilter = decoder.DecodeNullableEnum<Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind>(NullableActiveStatusKindNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("includeEdges");
            IncludeEdges = decoder.DecodeBoolean();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetResourcesEdgesResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Discovery.GetResourcesEdgesResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Discovery.GetResourcesEdgesResponse", 1);
            encoder.EncodeRecordFieldName("edges");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.Edge>(Edges);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Discovery.GetResourcesEdgesResponse", 1);
            decoder.DecodeRecordFieldName("edges");
            Edges = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.Edge>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetResourcesResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Discovery.GetResourcesResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Discovery.GetResourcesResponse", 1);
            encoder.EncodeRecordFieldName("resources");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.Resource>(Resources);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Discovery.GetResourcesResponse", 1);
            decoder.DecodeRecordFieldName("resources");
            Resources = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.Resource>();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v12.Protocol.DiscoveryQuery
{
    public partial class FindResources : IAvroRecord
    {
        private static NullableTypeConverter NullableTimestampMicrosDateTimeAsLongNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "long");
        private static NullableTypeConverter NullableActiveStatusKindNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind");
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.DiscoveryQuery.FindResources";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.DiscoveryQuery.FindResources", 4);
            encoder.EncodeRecordFieldName("context");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.ContextInfo>(Context);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("scope");
            encoder.EncodeEnum<Energistics.Etp.v12.Datatypes.Object.ContextScopeKind>(Scope);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("storeLastWriteFilter");
            encoder.EncodeNullableTimestampMicrosDateTimeAsLong(StoreLastWriteFilter, NullableTimestampMicrosDateTimeAsLongNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("activeStatusFilter");
            encoder.EncodeNullableEnum<Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind>(ActiveStatusFilter, NullableActiveStatusKindNullFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.DiscoveryQuery.FindResources", 4);
            decoder.DecodeRecordFieldName("context");
            Context = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.Object.ContextInfo>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("scope");
            Scope = decoder.DecodeEnum<Energistics.Etp.v12.Datatypes.Object.ContextScopeKind>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("storeLastWriteFilter");
            StoreLastWriteFilter = decoder.DecodeNullableTimestampMicrosDateTimeAsLong(NullableTimestampMicrosDateTimeAsLongNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("activeStatusFilter");
            ActiveStatusFilter = decoder.DecodeNullableEnum<Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind>(NullableActiveStatusKindNullFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class FindResourcesResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.DiscoveryQuery.FindResourcesResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.DiscoveryQuery.FindResourcesResponse", 2);
            encoder.EncodeRecordFieldName("resources");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.Resource>(Resources);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("serverSortOrder");
            encoder.EncodeString(ServerSortOrder);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.DiscoveryQuery.FindResourcesResponse", 2);
            decoder.DecodeRecordFieldName("resources");
            Resources = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.Resource>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("serverSortOrder");
            ServerSortOrder = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v12.Protocol.GrowingObject
{
    public partial class DeleteParts : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObject.DeleteParts";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.DeleteParts", 2);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("uids");
            encoder.EncodeMapOfString(Uids);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.DeleteParts", 2);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("uids");
            Uids = decoder.DecodeMapOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class DeletePartsResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObject.DeletePartsResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.DeletePartsResponse", 1);
            encoder.EncodeRecordFieldName("success");
            encoder.EncodeMapOfString(Success);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.DeletePartsResponse", 1);
            decoder.DecodeRecordFieldName("success");
            Success = decoder.DecodeMapOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetChangeAnnotations : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObject.GetChangeAnnotations";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.GetChangeAnnotations", 3);
            encoder.EncodeRecordFieldName("sinceChangeTime");
            encoder.EncodeTimestampMicrosDateTimeAsLong(SinceChangeTime);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("uris");
            encoder.EncodeMapOfString(Uris);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("latestOnly");
            encoder.EncodeBoolean(LatestOnly);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.GetChangeAnnotations", 3);
            decoder.DecodeRecordFieldName("sinceChangeTime");
            SinceChangeTime = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("uris");
            Uris = decoder.DecodeMapOfString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("latestOnly");
            LatestOnly = decoder.DecodeBoolean();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetChangeAnnotationsResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObject.GetChangeAnnotationsResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.GetChangeAnnotationsResponse", 1);
            encoder.EncodeRecordFieldName("changes");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.ChangeResponseInfo>(Changes);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.GetChangeAnnotationsResponse", 1);
            decoder.DecodeRecordFieldName("changes");
            Changes = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.ChangeResponseInfo>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetGrowingDataObjectsHeader : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObject.GetGrowingDataObjectsHeader";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.GetGrowingDataObjectsHeader", 2);
            encoder.EncodeRecordFieldName("uris");
            encoder.EncodeMapOfString(Uris);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("format");
            encoder.EncodeString(Format);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.GetGrowingDataObjectsHeader", 2);
            decoder.DecodeRecordFieldName("uris");
            Uris = decoder.DecodeMapOfString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("format");
            Format = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetGrowingDataObjectsHeaderResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObject.GetGrowingDataObjectsHeaderResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.GetGrowingDataObjectsHeaderResponse", 1);
            encoder.EncodeRecordFieldName("dataObjects");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.DataObject>(DataObjects);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.GetGrowingDataObjectsHeaderResponse", 1);
            decoder.DecodeRecordFieldName("dataObjects");
            DataObjects = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.DataObject>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetParts : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObject.GetParts";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.GetParts", 3);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("format");
            encoder.EncodeString(Format);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("uids");
            encoder.EncodeMapOfString(Uids);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.GetParts", 3);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("format");
            Format = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("uids");
            Uids = decoder.DecodeMapOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetPartsByRange : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObject.GetPartsByRange";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.GetPartsByRange", 4);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("format");
            encoder.EncodeString(Format);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("indexInterval");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.IndexInterval>(IndexInterval);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("includeOverlappingIntervals");
            encoder.EncodeBoolean(IncludeOverlappingIntervals);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.GetPartsByRange", 4);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("format");
            Format = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("indexInterval");
            IndexInterval = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.Object.IndexInterval>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("includeOverlappingIntervals");
            IncludeOverlappingIntervals = decoder.DecodeBoolean();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetPartsByRangeResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObject.GetPartsByRangeResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.GetPartsByRangeResponse", 3);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("format");
            encoder.EncodeString(Format);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("parts");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.ObjectPart>(Parts);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.GetPartsByRangeResponse", 3);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("format");
            Format = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("parts");
            Parts = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.ObjectPart>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetPartsMetadata : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObject.GetPartsMetadata";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.GetPartsMetadata", 1);
            encoder.EncodeRecordFieldName("uris");
            encoder.EncodeMapOfString(Uris);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.GetPartsMetadata", 1);
            decoder.DecodeRecordFieldName("uris");
            Uris = decoder.DecodeMapOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetPartsMetadataResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObject.GetPartsMetadataResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.GetPartsMetadataResponse", 1);
            encoder.EncodeRecordFieldName("metadata");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.PartsMetadataInfo>(Metadata);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.GetPartsMetadataResponse", 1);
            decoder.DecodeRecordFieldName("metadata");
            Metadata = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.PartsMetadataInfo>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetPartsResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObject.GetPartsResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.GetPartsResponse", 3);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("format");
            encoder.EncodeString(Format);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("parts");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.ObjectPart>(Parts);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.GetPartsResponse", 3);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("format");
            Format = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("parts");
            Parts = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.ObjectPart>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PutGrowingDataObjectsHeader : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObject.PutGrowingDataObjectsHeader";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.PutGrowingDataObjectsHeader", 1);
            encoder.EncodeRecordFieldName("dataObjects");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.DataObject>(DataObjects);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.PutGrowingDataObjectsHeader", 1);
            decoder.DecodeRecordFieldName("dataObjects");
            DataObjects = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.DataObject>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PutGrowingDataObjectsHeaderResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObject.PutGrowingDataObjectsHeaderResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.PutGrowingDataObjectsHeaderResponse", 1);
            encoder.EncodeRecordFieldName("success");
            encoder.EncodeMapOfString(Success);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.PutGrowingDataObjectsHeaderResponse", 1);
            decoder.DecodeRecordFieldName("success");
            Success = decoder.DecodeMapOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PutParts : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObject.PutParts";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.PutParts", 3);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("format");
            encoder.EncodeString(Format);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("parts");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.ObjectPart>(Parts);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.PutParts", 3);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("format");
            Format = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("parts");
            Parts = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.ObjectPart>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PutPartsResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObject.PutPartsResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.PutPartsResponse", 1);
            encoder.EncodeRecordFieldName("success");
            encoder.EncodeMapOfString(Success);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.PutPartsResponse", 1);
            decoder.DecodeRecordFieldName("success");
            Success = decoder.DecodeMapOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ReplacePartsByRange : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObject.ReplacePartsByRange";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.ReplacePartsByRange", 5);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("deleteInterval");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.IndexInterval>(DeleteInterval);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("includeOverlappingIntervals");
            encoder.EncodeBoolean(IncludeOverlappingIntervals);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("format");
            encoder.EncodeString(Format);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("parts");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.ObjectPart>(Parts);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.ReplacePartsByRange", 5);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("deleteInterval");
            DeleteInterval = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.Object.IndexInterval>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("includeOverlappingIntervals");
            IncludeOverlappingIntervals = decoder.DecodeBoolean();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("format");
            Format = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("parts");
            Parts = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.ObjectPart>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ReplacePartsByRangeResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObject.ReplacePartsByRangeResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.ReplacePartsByRangeResponse", 0);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObject.ReplacePartsByRangeResponse", 0);
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v12.Protocol.GrowingObjectNotification
{
    public partial class PartsChanged : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsChanged";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsChanged", 6);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("requestUuid");
            encoder.EncodeUuidGuidAsFixed(RequestUuid);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("changeKind");
            encoder.EncodeEnum<Energistics.Etp.v12.Datatypes.Object.ObjectChangeKind>(ChangeKind);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("changeTime");
            encoder.EncodeTimestampMicrosDateTimeAsLong(ChangeTime);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("format");
            encoder.EncodeString(Format);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("parts");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.ObjectPart>(Parts);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsChanged", 6);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("requestUuid");
            RequestUuid = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("changeKind");
            ChangeKind = decoder.DecodeEnum<Energistics.Etp.v12.Datatypes.Object.ObjectChangeKind>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("changeTime");
            ChangeTime = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("format");
            Format = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("parts");
            Parts = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.ObjectPart>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PartsDeleted : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsDeleted";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsDeleted", 4);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("requestUuid");
            encoder.EncodeUuidGuidAsFixed(RequestUuid);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("changeTime");
            encoder.EncodeTimestampMicrosDateTimeAsLong(ChangeTime);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("uids");
            encoder.EncodeArrayOfString(Uids);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsDeleted", 4);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("requestUuid");
            RequestUuid = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("changeTime");
            ChangeTime = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("uids");
            Uids = decoder.DecodeArrayOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PartsReplacedByRange : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsReplacedByRange";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsReplacedByRange", 7);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("requestUuid");
            encoder.EncodeUuidGuidAsFixed(RequestUuid);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("changeTime");
            encoder.EncodeTimestampMicrosDateTimeAsLong(ChangeTime);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("deletedInterval");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.IndexInterval>(DeletedInterval);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("includeOverlappingIntervals");
            encoder.EncodeBoolean(IncludeOverlappingIntervals);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("format");
            encoder.EncodeString(Format);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("parts");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.ObjectPart>(Parts);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsReplacedByRange", 7);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("requestUuid");
            RequestUuid = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("changeTime");
            ChangeTime = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("deletedInterval");
            DeletedInterval = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.Object.IndexInterval>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("includeOverlappingIntervals");
            IncludeOverlappingIntervals = decoder.DecodeBoolean();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("format");
            Format = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("parts");
            Parts = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.ObjectPart>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PartSubscriptionEnded : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartSubscriptionEnded";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartSubscriptionEnded", 2);
            encoder.EncodeRecordFieldName("reason");
            encoder.EncodeString(Reason);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("requestUuid");
            encoder.EncodeUuidGuidAsFixed(RequestUuid);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartSubscriptionEnded", 2);
            decoder.DecodeRecordFieldName("reason");
            Reason = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("requestUuid");
            RequestUuid = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class SubscribePartNotifications : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObjectNotification.SubscribePartNotifications";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObjectNotification.SubscribePartNotifications", 1);
            encoder.EncodeRecordFieldName("request");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.SubscriptionInfo>(Request);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObjectNotification.SubscribePartNotifications", 1);
            decoder.DecodeRecordFieldName("request");
            Request = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.SubscriptionInfo>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class SubscribePartNotificationsResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObjectNotification.SubscribePartNotificationsResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObjectNotification.SubscribePartNotificationsResponse", 1);
            encoder.EncodeRecordFieldName("success");
            encoder.EncodeMapOfString(Success);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObjectNotification.SubscribePartNotificationsResponse", 1);
            decoder.DecodeRecordFieldName("success");
            Success = decoder.DecodeMapOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class UnsolicitedPartNotifications : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObjectNotification.UnsolicitedPartNotifications";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObjectNotification.UnsolicitedPartNotifications", 1);
            encoder.EncodeRecordFieldName("subscriptions");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.SubscriptionInfo>(Subscriptions);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObjectNotification.UnsolicitedPartNotifications", 1);
            decoder.DecodeRecordFieldName("subscriptions");
            Subscriptions = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.SubscriptionInfo>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class UnsubscribePartNotification : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObjectNotification.UnsubscribePartNotification";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObjectNotification.UnsubscribePartNotification", 1);
            encoder.EncodeRecordFieldName("requestUuid");
            encoder.EncodeUuidGuidAsFixed(RequestUuid);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObjectNotification.UnsubscribePartNotification", 1);
            decoder.DecodeRecordFieldName("requestUuid");
            RequestUuid = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v12.Protocol.GrowingObjectQuery
{
    public partial class FindParts : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObjectQuery.FindParts";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObjectQuery.FindParts", 2);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("format");
            encoder.EncodeString(Format);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObjectQuery.FindParts", 2);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("format");
            Format = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class FindPartsResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.GrowingObjectQuery.FindPartsResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObjectQuery.FindPartsResponse", 4);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("serverSortOrder");
            encoder.EncodeString(ServerSortOrder);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("format");
            encoder.EncodeString(Format);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("parts");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.ObjectPart>(Parts);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.GrowingObjectQuery.FindPartsResponse", 4);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("serverSortOrder");
            ServerSortOrder = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("format");
            Format = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("parts");
            Parts = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.ObjectPart>();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v12.Protocol.Store
{
    public partial class Chunk : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Store.Chunk";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Store.Chunk", 3);
            encoder.EncodeRecordFieldName("blobId");
            encoder.EncodeUuidGuidAsFixed(BlobId);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeBytes(Data);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("final");
            encoder.EncodeBoolean(Final);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Store.Chunk", 3);
            decoder.DecodeRecordFieldName("blobId");
            BlobId = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeBytes();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("final");
            Final = decoder.DecodeBoolean();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class DeleteDataObjects : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Store.DeleteDataObjects";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Store.DeleteDataObjects", 2);
            encoder.EncodeRecordFieldName("uris");
            encoder.EncodeMapOfString(Uris);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("pruneContainedObjects");
            encoder.EncodeBoolean(PruneContainedObjects);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Store.DeleteDataObjects", 2);
            decoder.DecodeRecordFieldName("uris");
            Uris = decoder.DecodeMapOfString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("pruneContainedObjects");
            PruneContainedObjects = decoder.DecodeBoolean();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class DeleteDataObjectsResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Store.DeleteDataObjectsResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Store.DeleteDataObjectsResponse", 1);
            encoder.EncodeRecordFieldName("deletedUris");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfString>(DeletedUris);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Store.DeleteDataObjectsResponse", 1);
            decoder.DecodeRecordFieldName("deletedUris");
            DeletedUris = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfString>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetDataObjects : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Store.GetDataObjects";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Store.GetDataObjects", 2);
            encoder.EncodeRecordFieldName("uris");
            encoder.EncodeMapOfString(Uris);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("format");
            encoder.EncodeString(Format);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Store.GetDataObjects", 2);
            decoder.DecodeRecordFieldName("uris");
            Uris = decoder.DecodeMapOfString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("format");
            Format = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetDataObjectsResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Store.GetDataObjectsResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Store.GetDataObjectsResponse", 1);
            encoder.EncodeRecordFieldName("dataObjects");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.DataObject>(DataObjects);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Store.GetDataObjectsResponse", 1);
            decoder.DecodeRecordFieldName("dataObjects");
            DataObjects = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.DataObject>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PutDataObjects : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Store.PutDataObjects";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Store.PutDataObjects", 2);
            encoder.EncodeRecordFieldName("dataObjects");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.DataObject>(DataObjects);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("pruneContainedObjects");
            encoder.EncodeBoolean(PruneContainedObjects);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Store.PutDataObjects", 2);
            decoder.DecodeRecordFieldName("dataObjects");
            DataObjects = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.DataObject>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("pruneContainedObjects");
            PruneContainedObjects = decoder.DecodeBoolean();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PutDataObjectsResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Store.PutDataObjectsResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Store.PutDataObjectsResponse", 1);
            encoder.EncodeRecordFieldName("success");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.PutResponse>(Success);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Store.PutDataObjectsResponse", 1);
            decoder.DecodeRecordFieldName("success");
            Success = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.PutResponse>();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v12.Protocol.StoreNotification
{
    public partial class Chunk : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.StoreNotification.Chunk";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.StoreNotification.Chunk", 3);
            encoder.EncodeRecordFieldName("blobId");
            encoder.EncodeUuidGuidAsFixed(BlobId);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeBytes(Data);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("final");
            encoder.EncodeBoolean(Final);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.StoreNotification.Chunk", 3);
            decoder.DecodeRecordFieldName("blobId");
            BlobId = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeBytes();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("final");
            Final = decoder.DecodeBoolean();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ObjectAccessRevoked : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.StoreNotification.ObjectAccessRevoked";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.StoreNotification.ObjectAccessRevoked", 3);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("changeTime");
            encoder.EncodeTimestampMicrosDateTimeAsLong(ChangeTime);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("requestUuid");
            encoder.EncodeUuidGuidAsFixed(RequestUuid);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.StoreNotification.ObjectAccessRevoked", 3);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("changeTime");
            ChangeTime = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("requestUuid");
            RequestUuid = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ObjectActiveStatusChanged : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.StoreNotification.ObjectActiveStatusChanged";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.StoreNotification.ObjectActiveStatusChanged", 4);
            encoder.EncodeRecordFieldName("activeStatus");
            encoder.EncodeEnum<Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind>(ActiveStatus);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("changeTime");
            encoder.EncodeTimestampMicrosDateTimeAsLong(ChangeTime);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("resource");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.Resource>(Resource);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("requestUuid");
            encoder.EncodeUuidGuidAsFixed(RequestUuid);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.StoreNotification.ObjectActiveStatusChanged", 4);
            decoder.DecodeRecordFieldName("activeStatus");
            ActiveStatus = decoder.DecodeEnum<Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("changeTime");
            ChangeTime = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("resource");
            Resource = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.Object.Resource>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("requestUuid");
            RequestUuid = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ObjectChanged : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.StoreNotification.ObjectChanged";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.StoreNotification.ObjectChanged", 2);
            encoder.EncodeRecordFieldName("change");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.ObjectChange>(Change);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("requestUuid");
            encoder.EncodeUuidGuidAsFixed(RequestUuid);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.StoreNotification.ObjectChanged", 2);
            decoder.DecodeRecordFieldName("change");
            Change = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.Object.ObjectChange>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("requestUuid");
            RequestUuid = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ObjectDeleted : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.StoreNotification.ObjectDeleted";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.StoreNotification.ObjectDeleted", 3);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("changeTime");
            encoder.EncodeTimestampMicrosDateTimeAsLong(ChangeTime);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("requestUuid");
            encoder.EncodeUuidGuidAsFixed(RequestUuid);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.StoreNotification.ObjectDeleted", 3);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("changeTime");
            ChangeTime = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("requestUuid");
            RequestUuid = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class SubscribeNotifications : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.StoreNotification.SubscribeNotifications";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.StoreNotification.SubscribeNotifications", 1);
            encoder.EncodeRecordFieldName("request");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.SubscriptionInfo>(Request);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.StoreNotification.SubscribeNotifications", 1);
            decoder.DecodeRecordFieldName("request");
            Request = decoder.DecodeMapOfAvroObject<Energistics.Etp.v12.Datatypes.Object.SubscriptionInfo>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class SubscribeNotificationsResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.StoreNotification.SubscribeNotificationsResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.StoreNotification.SubscribeNotificationsResponse", 1);
            encoder.EncodeRecordFieldName("success");
            encoder.EncodeMapOfString(Success);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.StoreNotification.SubscribeNotificationsResponse", 1);
            decoder.DecodeRecordFieldName("success");
            Success = decoder.DecodeMapOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class SubscriptionEnded : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.StoreNotification.SubscriptionEnded";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.StoreNotification.SubscriptionEnded", 2);
            encoder.EncodeRecordFieldName("reason");
            encoder.EncodeString(Reason);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("requestUuid");
            encoder.EncodeUuidGuidAsFixed(RequestUuid);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.StoreNotification.SubscriptionEnded", 2);
            decoder.DecodeRecordFieldName("reason");
            Reason = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("requestUuid");
            RequestUuid = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class UnsolicitedStoreNotifications : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.StoreNotification.UnsolicitedStoreNotifications";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.StoreNotification.UnsolicitedStoreNotifications", 1);
            encoder.EncodeRecordFieldName("subscriptions");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.SubscriptionInfo>(Subscriptions);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.StoreNotification.UnsolicitedStoreNotifications", 1);
            decoder.DecodeRecordFieldName("subscriptions");
            Subscriptions = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.SubscriptionInfo>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class UnsubscribeNotifications : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.StoreNotification.UnsubscribeNotifications";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.StoreNotification.UnsubscribeNotifications", 1);
            encoder.EncodeRecordFieldName("requestUuid");
            encoder.EncodeUuidGuidAsFixed(RequestUuid);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.StoreNotification.UnsubscribeNotifications", 1);
            decoder.DecodeRecordFieldName("requestUuid");
            RequestUuid = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v12.Protocol.StoreQuery
{
    public partial class Chunk : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.StoreQuery.Chunk";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.StoreQuery.Chunk", 3);
            encoder.EncodeRecordFieldName("blobId");
            encoder.EncodeUuidGuidAsFixed(BlobId);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeBytes(Data);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("final");
            encoder.EncodeBoolean(Final);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.StoreQuery.Chunk", 3);
            decoder.DecodeRecordFieldName("blobId");
            BlobId = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeBytes();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("final");
            Final = decoder.DecodeBoolean();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class FindDataObjects : IAvroRecord
    {
        private static NullableTypeConverter NullableTimestampMicrosDateTimeAsLongNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "long");
        private static NullableTypeConverter NullableActiveStatusKindNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind");
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.StoreQuery.FindDataObjects";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.StoreQuery.FindDataObjects", 5);
            encoder.EncodeRecordFieldName("context");
            encoder.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.ContextInfo>(Context);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("scope");
            encoder.EncodeEnum<Energistics.Etp.v12.Datatypes.Object.ContextScopeKind>(Scope);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("storeLastWriteFilter");
            encoder.EncodeNullableTimestampMicrosDateTimeAsLong(StoreLastWriteFilter, NullableTimestampMicrosDateTimeAsLongNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("activeStatusFilter");
            encoder.EncodeNullableEnum<Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind>(ActiveStatusFilter, NullableActiveStatusKindNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("format");
            encoder.EncodeString(Format);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.StoreQuery.FindDataObjects", 5);
            decoder.DecodeRecordFieldName("context");
            Context = decoder.DecodeAvroObject<Energistics.Etp.v12.Datatypes.Object.ContextInfo>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("scope");
            Scope = decoder.DecodeEnum<Energistics.Etp.v12.Datatypes.Object.ContextScopeKind>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("storeLastWriteFilter");
            StoreLastWriteFilter = decoder.DecodeNullableTimestampMicrosDateTimeAsLong(NullableTimestampMicrosDateTimeAsLongNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("activeStatusFilter");
            ActiveStatusFilter = decoder.DecodeNullableEnum<Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind>(NullableActiveStatusKindNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("format");
            Format = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class FindDataObjectsResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.StoreQuery.FindDataObjectsResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.StoreQuery.FindDataObjectsResponse", 2);
            encoder.EncodeRecordFieldName("dataObjects");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.DataObject>(DataObjects);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("serverSortOrder");
            encoder.EncodeString(ServerSortOrder);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.StoreQuery.FindDataObjectsResponse", 2);
            decoder.DecodeRecordFieldName("dataObjects");
            DataObjects = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.DataObject>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("serverSortOrder");
            ServerSortOrder = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v12.Protocol.SupportedTypes
{
    public partial class GetSupportedTypes : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.SupportedTypes.GetSupportedTypes";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.SupportedTypes.GetSupportedTypes", 4);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("scope");
            encoder.EncodeEnum<Energistics.Etp.v12.Datatypes.Object.ContextScopeKind>(Scope);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("returnEmptyTypes");
            encoder.EncodeBoolean(ReturnEmptyTypes);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("countObjects");
            encoder.EncodeBoolean(CountObjects);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.SupportedTypes.GetSupportedTypes", 4);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("scope");
            Scope = decoder.DecodeEnum<Energistics.Etp.v12.Datatypes.Object.ContextScopeKind>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("returnEmptyTypes");
            ReturnEmptyTypes = decoder.DecodeBoolean();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("countObjects");
            CountObjects = decoder.DecodeBoolean();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetSupportedTypesResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.SupportedTypes.GetSupportedTypesResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.SupportedTypes.GetSupportedTypesResponse", 1);
            encoder.EncodeRecordFieldName("supportedTypes");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.SupportedType>(SupportedTypes);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.SupportedTypes.GetSupportedTypesResponse", 1);
            decoder.DecodeRecordFieldName("supportedTypes");
            SupportedTypes = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v12.Datatypes.Object.SupportedType>();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v12.Protocol.Transaction
{
    public partial class CommitTransaction : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Transaction.CommitTransaction";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Transaction.CommitTransaction", 1);
            encoder.EncodeRecordFieldName("transactionUuid");
            encoder.EncodeUuidGuidAsFixed(TransactionUuid);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Transaction.CommitTransaction", 1);
            decoder.DecodeRecordFieldName("transactionUuid");
            TransactionUuid = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class CommitTransactionResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Transaction.CommitTransactionResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Transaction.CommitTransactionResponse", 3);
            encoder.EncodeRecordFieldName("transactionUuid");
            encoder.EncodeUuidGuidAsFixed(TransactionUuid);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("successful");
            encoder.EncodeBoolean(Successful);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("failureReason");
            encoder.EncodeString(FailureReason);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Transaction.CommitTransactionResponse", 3);
            decoder.DecodeRecordFieldName("transactionUuid");
            TransactionUuid = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("successful");
            Successful = decoder.DecodeBoolean();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("failureReason");
            FailureReason = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class RollbackTransaction : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Transaction.RollbackTransaction";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Transaction.RollbackTransaction", 1);
            encoder.EncodeRecordFieldName("transactionUuid");
            encoder.EncodeUuidGuidAsFixed(TransactionUuid);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Transaction.RollbackTransaction", 1);
            decoder.DecodeRecordFieldName("transactionUuid");
            TransactionUuid = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class RollbackTransactionResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Transaction.RollbackTransactionResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Transaction.RollbackTransactionResponse", 3);
            encoder.EncodeRecordFieldName("transactionUuid");
            encoder.EncodeUuidGuidAsFixed(TransactionUuid);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("successful");
            encoder.EncodeBoolean(Successful);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("failureReason");
            encoder.EncodeString(FailureReason);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Transaction.RollbackTransactionResponse", 3);
            decoder.DecodeRecordFieldName("transactionUuid");
            TransactionUuid = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("successful");
            Successful = decoder.DecodeBoolean();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("failureReason");
            FailureReason = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class StartTransaction : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Transaction.StartTransaction";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Transaction.StartTransaction", 3);
            encoder.EncodeRecordFieldName("readOnly");
            encoder.EncodeBoolean(ReadOnly);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("message");
            encoder.EncodeString(Message);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("dataspaceUris");
            encoder.EncodeArrayOfString(DataspaceUris);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Transaction.StartTransaction", 3);
            decoder.DecodeRecordFieldName("readOnly");
            ReadOnly = decoder.DecodeBoolean();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("message");
            Message = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("dataspaceUris");
            DataspaceUris = decoder.DecodeArrayOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class StartTransactionResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Etp.v12.Protocol.Transaction.StartTransactionResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Etp.v12.Protocol.Transaction.StartTransactionResponse", 3);
            encoder.EncodeRecordFieldName("transactionUuid");
            encoder.EncodeUuidGuidAsFixed(TransactionUuid);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("successful");
            encoder.EncodeBoolean(Successful);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("failureReason");
            encoder.EncodeString(FailureReason);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Etp.v12.Protocol.Transaction.StartTransactionResponse", 3);
            decoder.DecodeRecordFieldName("transactionUuid");
            TransactionUuid = decoder.DecodeUuidGuidAsFixed();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("successful");
            Successful = decoder.DecodeBoolean();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("failureReason");
            FailureReason = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
}
