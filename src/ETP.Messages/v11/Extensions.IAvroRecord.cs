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

namespace Energistics.Etp.v11.Datatypes
{
    public partial class AnyArray : IAvroRecord
    {
        private static ChoiceTypeConverter ChoiceOfNullArrayOfBooleanBytesArrayOfIntArrayOfLongArrayOfFloatArrayOfDoubleTypeConverter { get; } = new ChoiceTypeConverter(new string[] { "null", "Energistics.Datatypes.ArrayOfBoolean", "bytes", "Energistics.Datatypes.ArrayOfInt", "Energistics.Datatypes.ArrayOfLong", "Energistics.Datatypes.ArrayOfFloat", "Energistics.Datatypes.ArrayOfDouble" }, new Type[] { null, typeof(Energistics.Etp.v11.Datatypes.ArrayOfBoolean), typeof(byte[]), typeof(Energistics.Etp.v11.Datatypes.ArrayOfInt), typeof(Energistics.Etp.v11.Datatypes.ArrayOfLong), typeof(Energistics.Etp.v11.Datatypes.ArrayOfFloat), typeof(Energistics.Etp.v11.Datatypes.ArrayOfDouble) });
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.AnyArray";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.AnyArray", 1);
            encoder.EncodeRecordFieldName("item");
            encoder.EncodeChoiceOfNullArrayOfBooleanBytesArrayOfIntArrayOfLongArrayOfFloatArrayOfDouble(Item, ChoiceOfNullArrayOfBooleanBytesArrayOfIntArrayOfLongArrayOfFloatArrayOfDoubleTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.AnyArray", 1);
            decoder.DecodeRecordFieldName("item");
            Item = decoder.DecodeChoiceOfNullArrayOfBooleanBytesArrayOfIntArrayOfLongArrayOfFloatArrayOfDouble(ChoiceOfNullArrayOfBooleanBytesArrayOfIntArrayOfLongArrayOfFloatArrayOfDoubleTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfBoolean : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.ArrayOfBoolean";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.ArrayOfBoolean", 1);
            encoder.EncodeRecordFieldName("values");
            encoder.EncodeArrayOfBoolean(Values);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.ArrayOfBoolean", 1);
            decoder.DecodeRecordFieldName("values");
            Values = decoder.DecodeArrayOfBoolean();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfDouble : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.ArrayOfDouble";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.ArrayOfDouble", 1);
            encoder.EncodeRecordFieldName("values");
            encoder.EncodeArrayOfDouble(Values);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.ArrayOfDouble", 1);
            decoder.DecodeRecordFieldName("values");
            Values = decoder.DecodeArrayOfDouble();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfFloat : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.ArrayOfFloat";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.ArrayOfFloat", 1);
            encoder.EncodeRecordFieldName("values");
            encoder.EncodeArrayOfFloat(Values);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.ArrayOfFloat", 1);
            decoder.DecodeRecordFieldName("values");
            Values = decoder.DecodeArrayOfFloat();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfInt : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.ArrayOfInt";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.ArrayOfInt", 1);
            encoder.EncodeRecordFieldName("values");
            encoder.EncodeArrayOfInt(Values);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.ArrayOfInt", 1);
            decoder.DecodeRecordFieldName("values");
            Values = decoder.DecodeArrayOfInt();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ArrayOfLong : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.ArrayOfLong";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.ArrayOfLong", 1);
            encoder.EncodeRecordFieldName("values");
            encoder.EncodeArrayOfLong(Values);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.ArrayOfLong", 1);
            decoder.DecodeRecordFieldName("values");
            Values = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class Contact : IAvroRecord
    {
        private static NullableTypeConverter NullableStringNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "string");
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.Contact";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.Contact", 4);
            encoder.EncodeRecordFieldName("organizationName");
            encoder.EncodeNullableString(OrganizationName, NullableStringNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("contactName");
            encoder.EncodeNullableString(ContactName, NullableStringNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("contactPhone");
            encoder.EncodeNullableString(ContactPhone, NullableStringNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("contactEmail");
            encoder.EncodeNullableString(ContactEmail, NullableStringNullFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.Contact", 4);
            decoder.DecodeRecordFieldName("organizationName");
            OrganizationName = decoder.DecodeNullableString(NullableStringNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("contactName");
            ContactName = decoder.DecodeNullableString(NullableStringNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("contactPhone");
            ContactPhone = decoder.DecodeNullableString(NullableStringNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("contactEmail");
            ContactEmail = decoder.DecodeNullableString(NullableStringNullFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class DataAttribute : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.DataAttribute";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.DataAttribute", 2);
            encoder.EncodeRecordFieldName("attributeId");
            encoder.EncodeInt(AttributeId);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("attributeValue");
            encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.DataValue>(AttributeValue);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.DataAttribute", 2);
            decoder.DecodeRecordFieldName("attributeId");
            AttributeId = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("attributeValue");
            AttributeValue = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.DataValue>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class DataValue : IAvroRecord
    {
        private static ChoiceTypeConverter ChoiceOfNullDoubleFloatIntLongStringArrayOfDoubleBooleanBytesTypeConverter { get; } = new ChoiceTypeConverter(new string[] { "null", "double", "float", "int", "long", "string", "Energistics.Datatypes.ArrayOfDouble", "boolean", "bytes" }, new Type[] { null, typeof(double), typeof(float), typeof(int), typeof(long), typeof(string), typeof(Energistics.Etp.v11.Datatypes.ArrayOfDouble), typeof(bool), typeof(byte[]) });
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.DataValue";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.DataValue", 1);
            encoder.EncodeRecordFieldName("item");
            encoder.EncodeChoiceOfNullDoubleFloatIntLongStringArrayOfDoubleBooleanBytes(Item, ChoiceOfNullDoubleFloatIntLongStringArrayOfDoubleBooleanBytesTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.DataValue", 1);
            decoder.DecodeRecordFieldName("item");
            Item = decoder.DecodeChoiceOfNullDoubleFloatIntLongStringArrayOfDoubleBooleanBytes(ChoiceOfNullDoubleFloatIntLongStringArrayOfDoubleBooleanBytesTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class MessageHeader : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.MessageHeader";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.MessageHeader", 5);
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
            decoder.DecodeRecordStart("Energistics.Datatypes.MessageHeader", 5);
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
    public partial class ServerCapabilities : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.ServerCapabilities";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.ServerCapabilities", 6);
            encoder.EncodeRecordFieldName("applicationName");
            encoder.EncodeString(ApplicationName);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("applicationVersion");
            encoder.EncodeString(ApplicationVersion);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("supportedProtocols");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.SupportedProtocol>(SupportedProtocols);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("supportedObjects");
            encoder.EncodeArrayOfString(SupportedObjects);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("contactInformation");
            encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.Contact>(ContactInformation);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("supportedEncodings");
            encoder.EncodeString(SupportedEncodings);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.ServerCapabilities", 6);
            decoder.DecodeRecordFieldName("applicationName");
            ApplicationName = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("applicationVersion");
            ApplicationVersion = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("supportedProtocols");
            SupportedProtocols = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.SupportedProtocol>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("supportedObjects");
            SupportedObjects = decoder.DecodeArrayOfString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("contactInformation");
            ContactInformation = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.Contact>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("supportedEncodings");
            SupportedEncodings = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class SupportedProtocol : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.SupportedProtocol";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.SupportedProtocol", 4);
            encoder.EncodeRecordFieldName("protocol");
            encoder.EncodeInt(Protocol);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("protocolVersion");
            encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.Version>(ProtocolVersion);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("role");
            encoder.EncodeString(Role);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("protocolCapabilities");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v11.Datatypes.DataValue>(ProtocolCapabilities);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.SupportedProtocol", 4);
            decoder.DecodeRecordFieldName("protocol");
            Protocol = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("protocolVersion");
            ProtocolVersion = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.Version>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("role");
            Role = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("protocolCapabilities");
            ProtocolCapabilities = decoder.DecodeMapOfAvroObject<Energistics.Etp.v11.Datatypes.DataValue>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class Version : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.Version";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.Version", 4);
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
            decoder.DecodeRecordStart("Energistics.Datatypes.Version", 4);
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
namespace Energistics.Etp.v11.Datatypes.ChannelData
{
    public partial class ChannelMetadataRecord : IAvroRecord
    {
        private static NullableTypeConverter NullableLongNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "long");
        private static NullableTypeConverter NullableStringNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "string");
        private static NullableTypeConverter NullableUuidGuidAsRfc4122StringNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "string");
        private static NullableTypeConverter NullableDataObjectNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "Energistics.Datatypes.Object.DataObject");
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.ChannelData.ChannelMetadataRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.ChannelData.ChannelMetadataRecord", 16);
            encoder.EncodeRecordFieldName("channelUri");
            encoder.EncodeString(ChannelUri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("channelId");
            encoder.EncodeLong(ChannelId);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("indexes");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.ChannelData.IndexMetadataRecord>(Indexes);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("channelName");
            encoder.EncodeString(ChannelName);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("dataType");
            encoder.EncodeString(DataType);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("uom");
            encoder.EncodeString(Uom);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("startIndex");
            encoder.EncodeNullableLong(StartIndex, NullableLongNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("endIndex");
            encoder.EncodeNullableLong(EndIndex, NullableLongNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("description");
            encoder.EncodeString(Description);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("status");
            encoder.EncodeEnum<Energistics.Etp.v11.Datatypes.ChannelData.ChannelStatuses>(Status);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("contentType");
            encoder.EncodeNullableString(ContentType, NullableStringNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("source");
            encoder.EncodeString(Source);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("measureClass");
            encoder.EncodeString(MeasureClass);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("uuid");
            encoder.EncodeNullableUuidGuidAsRfc4122String(Uuid, NullableUuidGuidAsRfc4122StringNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("customData");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v11.Datatypes.DataValue>(CustomData);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("domainObject");
            encoder.EncodeNullableAvroObject<Energistics.Etp.v11.Datatypes.Object.DataObject>(DomainObject, NullableDataObjectNullFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.ChannelData.ChannelMetadataRecord", 16);
            decoder.DecodeRecordFieldName("channelUri");
            ChannelUri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("channelId");
            ChannelId = decoder.DecodeLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("indexes");
            Indexes = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.ChannelData.IndexMetadataRecord>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("channelName");
            ChannelName = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("dataType");
            DataType = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("uom");
            Uom = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("startIndex");
            StartIndex = decoder.DecodeNullableLong(NullableLongNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("endIndex");
            EndIndex = decoder.DecodeNullableLong(NullableLongNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("description");
            Description = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("status");
            Status = decoder.DecodeEnum<Energistics.Etp.v11.Datatypes.ChannelData.ChannelStatuses>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("contentType");
            ContentType = decoder.DecodeNullableString(NullableStringNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("source");
            Source = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("measureClass");
            MeasureClass = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("uuid");
            Uuid = decoder.DecodeNullableUuidGuidAsRfc4122String(NullableUuidGuidAsRfc4122StringNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("customData");
            CustomData = decoder.DecodeMapOfAvroObject<Energistics.Etp.v11.Datatypes.DataValue>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("domainObject");
            DomainObject = decoder.DecodeNullableAvroObject<Energistics.Etp.v11.Datatypes.Object.DataObject>(NullableDataObjectNullFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ChannelRangeInfo : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.ChannelData.ChannelRangeInfo";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.ChannelData.ChannelRangeInfo", 3);
            encoder.EncodeRecordFieldName("channelId");
            encoder.EncodeArrayOfLong(ChannelId);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("startIndex");
            encoder.EncodeLong(StartIndex);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("endIndex");
            encoder.EncodeLong(EndIndex);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.ChannelData.ChannelRangeInfo", 3);
            decoder.DecodeRecordFieldName("channelId");
            ChannelId = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("startIndex");
            StartIndex = decoder.DecodeLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("endIndex");
            EndIndex = decoder.DecodeLong();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ChannelStreamingInfo : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.ChannelData.ChannelStreamingInfo";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.ChannelData.ChannelStreamingInfo", 3);
            encoder.EncodeRecordFieldName("channelId");
            encoder.EncodeLong(ChannelId);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("startIndex");
            encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.ChannelData.StreamingStartIndex>(StartIndex);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("receiveChangeNotification");
            encoder.EncodeBoolean(ReceiveChangeNotification);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.ChannelData.ChannelStreamingInfo", 3);
            decoder.DecodeRecordFieldName("channelId");
            ChannelId = decoder.DecodeLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("startIndex");
            StartIndex = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.ChannelData.StreamingStartIndex>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("receiveChangeNotification");
            ReceiveChangeNotification = decoder.DecodeBoolean();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class DataFrame : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.ChannelData.DataFrame";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.ChannelData.DataFrame", 2);
            encoder.EncodeRecordFieldName("index");
            encoder.EncodeArrayOfLong(Index);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.DataValue>(Data);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.ChannelData.DataFrame", 2);
            decoder.DecodeRecordFieldName("index");
            Index = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.DataValue>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class DataItem : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.ChannelData.DataItem";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.ChannelData.DataItem", 4);
            encoder.EncodeRecordFieldName("indexes");
            encoder.EncodeArrayOfLong(Indexes);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("channelId");
            encoder.EncodeLong(ChannelId);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("value");
            encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.DataValue>(Value);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("valueAttributes");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.DataAttribute>(ValueAttributes);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.ChannelData.DataItem", 4);
            decoder.DecodeRecordFieldName("indexes");
            Indexes = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("channelId");
            ChannelId = decoder.DecodeLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("value");
            Value = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.DataValue>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("valueAttributes");
            ValueAttributes = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.DataAttribute>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class IndexMetadataRecord : IAvroRecord
    {
        private static NullableTypeConverter NullableStringNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "string");
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.ChannelData.IndexMetadataRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.ChannelData.IndexMetadataRecord", 10);
            encoder.EncodeRecordFieldName("indexType");
            encoder.EncodeEnum<Energistics.Etp.v11.Datatypes.ChannelData.ChannelIndexTypes>(IndexType);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("uom");
            encoder.EncodeString(Uom);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("depthDatum");
            encoder.EncodeNullableString(DepthDatum, NullableStringNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("direction");
            encoder.EncodeEnum<Energistics.Etp.v11.Datatypes.ChannelData.IndexDirections>(Direction);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("mnemonic");
            encoder.EncodeNullableString(Mnemonic, NullableStringNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("description");
            encoder.EncodeNullableString(Description, NullableStringNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeNullableString(Uri, NullableStringNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("customData");
            encoder.EncodeMapOfAvroObject<Energistics.Etp.v11.Datatypes.DataValue>(CustomData);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("scale");
            encoder.EncodeInt(Scale);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("timeDatum");
            encoder.EncodeNullableString(TimeDatum, NullableStringNullFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.ChannelData.IndexMetadataRecord", 10);
            decoder.DecodeRecordFieldName("indexType");
            IndexType = decoder.DecodeEnum<Energistics.Etp.v11.Datatypes.ChannelData.ChannelIndexTypes>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("uom");
            Uom = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("depthDatum");
            DepthDatum = decoder.DecodeNullableString(NullableStringNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("direction");
            Direction = decoder.DecodeEnum<Energistics.Etp.v11.Datatypes.ChannelData.IndexDirections>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("mnemonic");
            Mnemonic = decoder.DecodeNullableString(NullableStringNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("description");
            Description = decoder.DecodeNullableString(NullableStringNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeNullableString(NullableStringNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("customData");
            CustomData = decoder.DecodeMapOfAvroObject<Energistics.Etp.v11.Datatypes.DataValue>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("scale");
            Scale = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("timeDatum");
            TimeDatum = decoder.DecodeNullableString(NullableStringNullFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class StreamingStartIndex : IAvroRecord
    {
        private static ChoiceTypeConverter ChoiceOfNullIntLongTypeConverter { get; } = new ChoiceTypeConverter(new string[] { "null", "int", "long" }, new Type[] { null, typeof(int), typeof(long) });
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.ChannelData.StreamingStartIndex";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.ChannelData.StreamingStartIndex", 1);
            encoder.EncodeRecordFieldName("item");
            encoder.EncodeChoiceOfNullIntLong(Item, ChoiceOfNullIntLongTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.ChannelData.StreamingStartIndex", 1);
            decoder.DecodeRecordFieldName("item");
            Item = decoder.DecodeChoiceOfNullIntLong(ChoiceOfNullIntLongTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v11.Datatypes.Object
{
    public partial class DataObject : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.Object.DataObject";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.Object.DataObject", 3);
            encoder.EncodeRecordFieldName("resource");
            encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.Object.Resource>(Resource);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("contentEncoding");
            encoder.EncodeString(ContentEncoding);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeBytes(Data);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.Object.DataObject", 3);
            decoder.DecodeRecordFieldName("resource");
            Resource = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.Object.Resource>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("contentEncoding");
            ContentEncoding = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeBytes();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GrowingObjectIndex : IAvroRecord
    {
        private static ChoiceTypeConverter ChoiceOfNullLongDoubleTypeConverter { get; } = new ChoiceTypeConverter(new string[] { "null", "long", "double" }, new Type[] { null, typeof(long), typeof(double) });
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.Object.GrowingObjectIndex";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.Object.GrowingObjectIndex", 1);
            encoder.EncodeRecordFieldName("item");
            encoder.EncodeChoiceOfNullLongDouble(Item, ChoiceOfNullLongDoubleTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.Object.GrowingObjectIndex", 1);
            decoder.DecodeRecordFieldName("item");
            Item = decoder.DecodeChoiceOfNullLongDouble(ChoiceOfNullLongDoubleTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class NotificationRequestRecord : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.Object.NotificationRequestRecord";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.Object.NotificationRequestRecord", 5);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("uuid");
            encoder.EncodeUuidGuidAsRfc4122String(Uuid);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("includeObjectData");
            encoder.EncodeBoolean(IncludeObjectData);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("startTime");
            encoder.EncodeTimestampMicrosDateTimeAsLong(StartTime);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("objectTypes");
            encoder.EncodeArrayOfString(ObjectTypes);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.Object.NotificationRequestRecord", 5);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("uuid");
            Uuid = decoder.DecodeUuidGuidAsRfc4122String();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("includeObjectData");
            IncludeObjectData = decoder.DecodeBoolean();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("startTime");
            StartTime = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("objectTypes");
            ObjectTypes = decoder.DecodeArrayOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ObjectChange : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.Object.ObjectChange";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.Object.ObjectChange", 3);
            encoder.EncodeRecordFieldName("changeType");
            encoder.EncodeEnum<Energistics.Etp.v11.Datatypes.Object.ObjectChangeTypes>(ChangeType);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("changeTime");
            encoder.EncodeTimestampMicrosDateTimeAsLong(ChangeTime);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("dataObject");
            encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.Object.DataObject>(DataObject);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.Object.ObjectChange", 3);
            decoder.DecodeRecordFieldName("changeType");
            ChangeType = decoder.DecodeEnum<Energistics.Etp.v11.Datatypes.Object.ObjectChangeTypes>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("changeTime");
            ChangeTime = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("dataObject");
            DataObject = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.Object.DataObject>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class Resource : IAvroRecord
    {
        private static NullableTypeConverter NullableUuidGuidAsRfc4122StringNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "string");
        string IAvroObject.AvroTypeName => "Energistics.Datatypes.Object.Resource";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Datatypes.Object.Resource", 10);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("contentType");
            encoder.EncodeString(ContentType);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("name");
            encoder.EncodeString(Name);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("channelSubscribable");
            encoder.EncodeBoolean(ChannelSubscribable);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("customData");
            encoder.EncodeMapOfString(CustomData);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("resourceType");
            encoder.EncodeString(ResourceType);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("hasChildren");
            encoder.EncodeInt(HasChildren);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("uuid");
            encoder.EncodeNullableUuidGuidAsRfc4122String(Uuid, NullableUuidGuidAsRfc4122StringNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("lastChanged");
            encoder.EncodeTimestampMicrosDateTimeAsLong(LastChanged);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("objectNotifiable");
            encoder.EncodeBoolean(ObjectNotifiable);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Datatypes.Object.Resource", 10);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("contentType");
            ContentType = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("name");
            Name = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("channelSubscribable");
            ChannelSubscribable = decoder.DecodeBoolean();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("customData");
            CustomData = decoder.DecodeMapOfString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("resourceType");
            ResourceType = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("hasChildren");
            HasChildren = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("uuid");
            Uuid = decoder.DecodeNullableUuidGuidAsRfc4122String(NullableUuidGuidAsRfc4122StringNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("lastChanged");
            LastChanged = decoder.DecodeTimestampMicrosDateTimeAsLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("objectNotifiable");
            ObjectNotifiable = decoder.DecodeBoolean();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v11.Protocol.ChannelDataFrame
{
    public partial class ChannelDataFrameSet : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.ChannelDataFrame.ChannelDataFrameSet";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.ChannelDataFrame.ChannelDataFrameSet", 2);
            encoder.EncodeRecordFieldName("channels");
            encoder.EncodeArrayOfLong(Channels);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.ChannelData.DataFrame>(Data);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.ChannelDataFrame.ChannelDataFrameSet", 2);
            decoder.DecodeRecordFieldName("channels");
            Channels = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.ChannelData.DataFrame>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ChannelMetadata : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.ChannelDataFrame.ChannelMetadata";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.ChannelDataFrame.ChannelMetadata", 1);
            encoder.EncodeRecordFieldName("channels");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.ChannelData.ChannelMetadataRecord>(Channels);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.ChannelDataFrame.ChannelMetadata", 1);
            decoder.DecodeRecordFieldName("channels");
            Channels = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.ChannelData.ChannelMetadataRecord>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class RequestChannelData : IAvroRecord
    {
        private static NullableTypeConverter NullableLongNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "long");
        string IAvroObject.AvroTypeName => "Energistics.Protocol.ChannelDataFrame.RequestChannelData";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.ChannelDataFrame.RequestChannelData", 3);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("fromIndex");
            encoder.EncodeNullableLong(FromIndex, NullableLongNullFirstTypeConverter);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("toIndex");
            encoder.EncodeNullableLong(ToIndex, NullableLongNullFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.ChannelDataFrame.RequestChannelData", 3);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("fromIndex");
            FromIndex = decoder.DecodeNullableLong(NullableLongNullFirstTypeConverter);
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("toIndex");
            ToIndex = decoder.DecodeNullableLong(NullableLongNullFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v11.Protocol.ChannelStreaming
{
    public partial class ChannelData : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.ChannelStreaming.ChannelData";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.ChannelStreaming.ChannelData", 1);
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.ChannelData.DataItem>(Data);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.ChannelStreaming.ChannelData", 1);
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.ChannelData.DataItem>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ChannelDataChange : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.ChannelStreaming.ChannelDataChange";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.ChannelStreaming.ChannelDataChange", 4);
            encoder.EncodeRecordFieldName("channelId");
            encoder.EncodeLong(ChannelId);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("startIndex");
            encoder.EncodeLong(StartIndex);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("endIndex");
            encoder.EncodeLong(EndIndex);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.ChannelData.DataItem>(Data);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.ChannelStreaming.ChannelDataChange", 4);
            decoder.DecodeRecordFieldName("channelId");
            ChannelId = decoder.DecodeLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("startIndex");
            StartIndex = decoder.DecodeLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("endIndex");
            EndIndex = decoder.DecodeLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.ChannelData.DataItem>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ChannelDescribe : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.ChannelStreaming.ChannelDescribe";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.ChannelStreaming.ChannelDescribe", 1);
            encoder.EncodeRecordFieldName("uris");
            encoder.EncodeArrayOfString(Uris);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.ChannelStreaming.ChannelDescribe", 1);
            decoder.DecodeRecordFieldName("uris");
            Uris = decoder.DecodeArrayOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ChannelMetadata : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.ChannelStreaming.ChannelMetadata";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.ChannelStreaming.ChannelMetadata", 1);
            encoder.EncodeRecordFieldName("channels");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.ChannelData.ChannelMetadataRecord>(Channels);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.ChannelStreaming.ChannelMetadata", 1);
            decoder.DecodeRecordFieldName("channels");
            Channels = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.ChannelData.ChannelMetadataRecord>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ChannelRangeRequest : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.ChannelStreaming.ChannelRangeRequest";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.ChannelStreaming.ChannelRangeRequest", 1);
            encoder.EncodeRecordFieldName("channelRanges");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.ChannelData.ChannelRangeInfo>(ChannelRanges);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.ChannelStreaming.ChannelRangeRequest", 1);
            decoder.DecodeRecordFieldName("channelRanges");
            ChannelRanges = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.ChannelData.ChannelRangeInfo>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ChannelRemove : IAvroRecord
    {
        private static NullableTypeConverter NullableStringNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "string");
        string IAvroObject.AvroTypeName => "Energistics.Protocol.ChannelStreaming.ChannelRemove";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.ChannelStreaming.ChannelRemove", 2);
            encoder.EncodeRecordFieldName("channelId");
            encoder.EncodeLong(ChannelId);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("removeReason");
            encoder.EncodeNullableString(RemoveReason, NullableStringNullFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.ChannelStreaming.ChannelRemove", 2);
            decoder.DecodeRecordFieldName("channelId");
            ChannelId = decoder.DecodeLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("removeReason");
            RemoveReason = decoder.DecodeNullableString(NullableStringNullFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ChannelStatusChange : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.ChannelStreaming.ChannelStatusChange";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.ChannelStreaming.ChannelStatusChange", 2);
            encoder.EncodeRecordFieldName("channelId");
            encoder.EncodeLong(ChannelId);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("status");
            encoder.EncodeEnum<Energistics.Etp.v11.Datatypes.ChannelData.ChannelStatuses>(Status);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.ChannelStreaming.ChannelStatusChange", 2);
            decoder.DecodeRecordFieldName("channelId");
            ChannelId = decoder.DecodeLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("status");
            Status = decoder.DecodeEnum<Energistics.Etp.v11.Datatypes.ChannelData.ChannelStatuses>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ChannelStreamingStart : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.ChannelStreaming.ChannelStreamingStart";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.ChannelStreaming.ChannelStreamingStart", 1);
            encoder.EncodeRecordFieldName("channels");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.ChannelData.ChannelStreamingInfo>(Channels);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.ChannelStreaming.ChannelStreamingStart", 1);
            decoder.DecodeRecordFieldName("channels");
            Channels = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.ChannelData.ChannelStreamingInfo>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ChannelStreamingStop : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.ChannelStreaming.ChannelStreamingStop";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.ChannelStreaming.ChannelStreamingStop", 1);
            encoder.EncodeRecordFieldName("channels");
            encoder.EncodeArrayOfLong(Channels);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.ChannelStreaming.ChannelStreamingStop", 1);
            decoder.DecodeRecordFieldName("channels");
            Channels = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class Start : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.ChannelStreaming.Start";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.ChannelStreaming.Start", 2);
            encoder.EncodeRecordFieldName("maxMessageRate");
            encoder.EncodeInt(MaxMessageRate);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("maxDataItems");
            encoder.EncodeInt(MaxDataItems);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.ChannelStreaming.Start", 2);
            decoder.DecodeRecordFieldName("maxMessageRate");
            MaxMessageRate = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("maxDataItems");
            MaxDataItems = decoder.DecodeInt();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v11.Protocol.Core
{
    public partial class Acknowledge : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.Core.Acknowledge";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.Core.Acknowledge", 0);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.Core.Acknowledge", 0);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class CloseSession : IAvroRecord
    {
        private static NullableTypeConverter NullableStringNullFirstTypeConverter { get; } = new NullableTypeConverter(true, "string");
        string IAvroObject.AvroTypeName => "Energistics.Protocol.Core.CloseSession";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.Core.CloseSession", 1);
            encoder.EncodeRecordFieldName("reason");
            encoder.EncodeNullableString(Reason, NullableStringNullFirstTypeConverter);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.Core.CloseSession", 1);
            decoder.DecodeRecordFieldName("reason");
            Reason = decoder.DecodeNullableString(NullableStringNullFirstTypeConverter);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class OpenSession : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.Core.OpenSession";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.Core.OpenSession", 5);
            encoder.EncodeRecordFieldName("applicationName");
            encoder.EncodeString(ApplicationName);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("applicationVersion");
            encoder.EncodeString(ApplicationVersion);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("sessionId");
            encoder.EncodeUuidGuidAsRfc4122String(SessionId);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("supportedProtocols");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.SupportedProtocol>(SupportedProtocols);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("supportedObjects");
            encoder.EncodeArrayOfString(SupportedObjects);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.Core.OpenSession", 5);
            decoder.DecodeRecordFieldName("applicationName");
            ApplicationName = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("applicationVersion");
            ApplicationVersion = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("sessionId");
            SessionId = decoder.DecodeUuidGuidAsRfc4122String();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("supportedProtocols");
            SupportedProtocols = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.SupportedProtocol>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("supportedObjects");
            SupportedObjects = decoder.DecodeArrayOfString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ProtocolException : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.Core.ProtocolException";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.Core.ProtocolException", 2);
            encoder.EncodeRecordFieldName("errorCode");
            encoder.EncodeInt(ErrorCode);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("errorMessage");
            encoder.EncodeString(ErrorMessage);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.Core.ProtocolException", 2);
            decoder.DecodeRecordFieldName("errorCode");
            ErrorCode = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("errorMessage");
            ErrorMessage = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class RenewSecurityToken : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.Core.RenewSecurityToken";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.Core.RenewSecurityToken", 1);
            encoder.EncodeRecordFieldName("token");
            encoder.EncodeString(Token);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.Core.RenewSecurityToken", 1);
            decoder.DecodeRecordFieldName("token");
            Token = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class RequestSession : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.Core.RequestSession";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.Core.RequestSession", 4);
            encoder.EncodeRecordFieldName("applicationName");
            encoder.EncodeString(ApplicationName);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("applicationVersion");
            encoder.EncodeString(ApplicationVersion);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("requestedProtocols");
            encoder.EncodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.SupportedProtocol>(RequestedProtocols);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("supportedObjects");
            encoder.EncodeArrayOfString(SupportedObjects);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.Core.RequestSession", 4);
            decoder.DecodeRecordFieldName("applicationName");
            ApplicationName = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("applicationVersion");
            ApplicationVersion = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("requestedProtocols");
            RequestedProtocols = decoder.DecodeArrayOfAvroObject<Energistics.Etp.v11.Datatypes.SupportedProtocol>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("supportedObjects");
            SupportedObjects = decoder.DecodeArrayOfString();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v11.Protocol.DataArray
{
    public partial class DataArray : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.DataArray.DataArray";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.DataArray.DataArray", 2);
            encoder.EncodeRecordFieldName("dimensions");
            encoder.EncodeArrayOfLong(Dimensions);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.AnyArray>(Data);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.DataArray.DataArray", 2);
            decoder.DecodeRecordFieldName("dimensions");
            Dimensions = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.AnyArray>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetDataArray : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.DataArray.GetDataArray";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.DataArray.GetDataArray", 1);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.DataArray.GetDataArray", 1);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetDataArraySlice : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.DataArray.GetDataArraySlice";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.DataArray.GetDataArraySlice", 3);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("start");
            encoder.EncodeArrayOfLong(Start);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("count");
            encoder.EncodeArrayOfLong(Count);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.DataArray.GetDataArraySlice", 3);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("start");
            Start = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("count");
            Count = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PutDataArray : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.DataArray.PutDataArray";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.DataArray.PutDataArray", 3);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.AnyArray>(Data);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("dimensions");
            encoder.EncodeArrayOfLong(Dimensions);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.DataArray.PutDataArray", 3);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.AnyArray>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("dimensions");
            Dimensions = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PutDataArraySlice : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.DataArray.PutDataArraySlice";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.DataArray.PutDataArraySlice", 5);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.AnyArray>(Data);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("dimensions");
            encoder.EncodeArrayOfLong(Dimensions);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("start");
            encoder.EncodeArrayOfLong(Start);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("count");
            encoder.EncodeArrayOfLong(Count);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.DataArray.PutDataArraySlice", 5);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.AnyArray>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("dimensions");
            Dimensions = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("start");
            Start = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("count");
            Count = decoder.DecodeArrayOfLong();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v11.Protocol.Discovery
{
    public partial class GetResources : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.Discovery.GetResources";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.Discovery.GetResources", 1);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.Discovery.GetResources", 1);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetResourcesResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.Discovery.GetResourcesResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.Discovery.GetResourcesResponse", 1);
            encoder.EncodeRecordFieldName("resource");
            encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.Object.Resource>(Resource);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.Discovery.GetResourcesResponse", 1);
            decoder.DecodeRecordFieldName("resource");
            Resource = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.Object.Resource>();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v11.Protocol.GrowingObject
{
    public partial class GrowingObjectDelete : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.GrowingObject.GrowingObjectDelete";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.GrowingObject.GrowingObjectDelete", 2);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("uid");
            encoder.EncodeString(Uid);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.GrowingObject.GrowingObjectDelete", 2);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("uid");
            Uid = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GrowingObjectDeleteRange : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.GrowingObject.GrowingObjectDeleteRange";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.GrowingObject.GrowingObjectDeleteRange", 5);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("startIndex");
            encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.Object.GrowingObjectIndex>(StartIndex);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("endIndex");
            encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.Object.GrowingObjectIndex>(EndIndex);
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
            decoder.DecodeRecordStart("Energistics.Protocol.GrowingObject.GrowingObjectDeleteRange", 5);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("startIndex");
            StartIndex = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.Object.GrowingObjectIndex>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("endIndex");
            EndIndex = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.Object.GrowingObjectIndex>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("uom");
            Uom = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("depthDatum");
            DepthDatum = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GrowingObjectGet : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.GrowingObject.GrowingObjectGet";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.GrowingObject.GrowingObjectGet", 2);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("uid");
            encoder.EncodeString(Uid);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.GrowingObject.GrowingObjectGet", 2);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("uid");
            Uid = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GrowingObjectGetRange : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.GrowingObject.GrowingObjectGetRange";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.GrowingObject.GrowingObjectGetRange", 5);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("startIndex");
            encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.Object.GrowingObjectIndex>(StartIndex);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("endIndex");
            encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.Object.GrowingObjectIndex>(EndIndex);
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
            decoder.DecodeRecordStart("Energistics.Protocol.GrowingObject.GrowingObjectGetRange", 5);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("startIndex");
            StartIndex = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.Object.GrowingObjectIndex>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("endIndex");
            EndIndex = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.Object.GrowingObjectIndex>();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("uom");
            Uom = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("depthDatum");
            DepthDatum = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GrowingObjectPut : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.GrowingObject.GrowingObjectPut";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.GrowingObject.GrowingObjectPut", 4);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("contentType");
            encoder.EncodeString(ContentType);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("contentEncoding");
            encoder.EncodeString(ContentEncoding);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeBytes(Data);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.GrowingObject.GrowingObjectPut", 4);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("contentType");
            ContentType = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("contentEncoding");
            ContentEncoding = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeBytes();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ObjectFragment : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.GrowingObject.ObjectFragment";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.GrowingObject.ObjectFragment", 4);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("contentType");
            encoder.EncodeString(ContentType);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("contentEncoding");
            encoder.EncodeString(ContentEncoding);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("data");
            encoder.EncodeBytes(Data);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.GrowingObject.ObjectFragment", 4);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("contentType");
            ContentType = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("contentEncoding");
            ContentEncoding = decoder.DecodeString();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("data");
            Data = decoder.DecodeBytes();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v11.Protocol.Store
{
    public partial class DeleteObject : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.Store.DeleteObject";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.Store.DeleteObject", 1);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.Store.DeleteObject", 1);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class GetObject : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.Store.GetObject";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.Store.GetObject", 1);
            encoder.EncodeRecordFieldName("uri");
            encoder.EncodeString(Uri);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.Store.GetObject", 1);
            decoder.DecodeRecordFieldName("uri");
            Uri = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class Object : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.Store.Object";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.Store.Object", 1);
            encoder.EncodeRecordFieldName("dataObject");
            encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.Object.DataObject>(DataObject);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.Store.Object", 1);
            decoder.DecodeRecordFieldName("dataObject");
            DataObject = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.Object.DataObject>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class PutObject : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.Store.PutObject";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.Store.PutObject", 1);
            encoder.EncodeRecordFieldName("dataObject");
            encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.Object.DataObject>(DataObject);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.Store.PutObject", 1);
            decoder.DecodeRecordFieldName("dataObject");
            DataObject = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.Object.DataObject>();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v11.Protocol.StoreNotification
{
    public partial class CancelNotification : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.StoreNotification.CancelNotification";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.StoreNotification.CancelNotification", 1);
            encoder.EncodeRecordFieldName("requestUuid");
            encoder.EncodeUuidGuidAsRfc4122String(RequestUuid);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.StoreNotification.CancelNotification", 1);
            decoder.DecodeRecordFieldName("requestUuid");
            RequestUuid = decoder.DecodeUuidGuidAsRfc4122String();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class ChangeNotification : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.StoreNotification.ChangeNotification";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.StoreNotification.ChangeNotification", 1);
            encoder.EncodeRecordFieldName("change");
            encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.Object.ObjectChange>(Change);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.StoreNotification.ChangeNotification", 1);
            decoder.DecodeRecordFieldName("change");
            Change = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.Object.ObjectChange>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class DeleteNotification : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.StoreNotification.DeleteNotification";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.StoreNotification.DeleteNotification", 1);
            encoder.EncodeRecordFieldName("delete");
            encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.Object.ObjectChange>(Delete);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.StoreNotification.DeleteNotification", 1);
            decoder.DecodeRecordFieldName("delete");
            Delete = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.Object.ObjectChange>();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class NotificationRequest : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.StoreNotification.NotificationRequest";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.StoreNotification.NotificationRequest", 1);
            encoder.EncodeRecordFieldName("request");
            encoder.EncodeAvroObject<Energistics.Etp.v11.Datatypes.Object.NotificationRequestRecord>(Request);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.StoreNotification.NotificationRequest", 1);
            decoder.DecodeRecordFieldName("request");
            Request = decoder.DecodeAvroObject<Energistics.Etp.v11.Datatypes.Object.NotificationRequestRecord>();
            decoder.DecodeRecordEnd();
        }
    }
}
namespace Energistics.Etp.v11.Protocol.WitsmlSoap
{
    public partial class WMLS_AddToStore : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.WitsmlSoap.WMLS_AddToStore";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.WitsmlSoap.WMLS_AddToStore", 4);
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
            decoder.DecodeRecordStart("Energistics.Protocol.WitsmlSoap.WMLS_AddToStore", 4);
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
    public partial class WMLS_DeleteFromStore : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.WitsmlSoap.WMLS_DeleteFromStore";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.WitsmlSoap.WMLS_DeleteFromStore", 4);
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
            decoder.DecodeRecordStart("Energistics.Protocol.WitsmlSoap.WMLS_DeleteFromStore", 4);
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
    public partial class WMLS_GetBaseMsg : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.WitsmlSoap.WMLS_GetBaseMsg";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.WitsmlSoap.WMLS_GetBaseMsg", 1);
            encoder.EncodeRecordFieldName("ReturnValueIn");
            encoder.EncodeInt(ReturnValueIn);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.WitsmlSoap.WMLS_GetBaseMsg", 1);
            decoder.DecodeRecordFieldName("ReturnValueIn");
            ReturnValueIn = decoder.DecodeInt();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class WMLS_GetCap : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.WitsmlSoap.WMLS_GetCap";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.WitsmlSoap.WMLS_GetCap", 1);
            encoder.EncodeRecordFieldName("OptionsIn");
            encoder.EncodeString(OptionsIn);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.WitsmlSoap.WMLS_GetCap", 1);
            decoder.DecodeRecordFieldName("OptionsIn");
            OptionsIn = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class WMLS_GetFromStore : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.WitsmlSoap.WMLS_GetFromStore";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.WitsmlSoap.WMLS_GetFromStore", 4);
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
            decoder.DecodeRecordStart("Energistics.Protocol.WitsmlSoap.WMLS_GetFromStore", 4);
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
    public partial class WMLS_GetVersion : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.WitsmlSoap.WMLS_GetVersion";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.WitsmlSoap.WMLS_GetVersion", 0);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.WitsmlSoap.WMLS_GetVersion", 0);
            decoder.DecodeRecordEnd();
        }
    }
    public partial class WMLS_UpdateInStore : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.WitsmlSoap.WMLS_UpdateInStore";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.WitsmlSoap.WMLS_UpdateInStore", 4);
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
            decoder.DecodeRecordStart("Energistics.Protocol.WitsmlSoap.WMLS_UpdateInStore", 4);
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
    public partial class WMSL_AddToStoreResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.WitsmlSoap.WMSL_AddToStoreResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.WitsmlSoap.WMSL_AddToStoreResponse", 2);
            encoder.EncodeRecordFieldName("Result");
            encoder.EncodeInt(Result);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("SuppMsgOut");
            encoder.EncodeString(SuppMsgOut);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.WitsmlSoap.WMSL_AddToStoreResponse", 2);
            decoder.DecodeRecordFieldName("Result");
            Result = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("SuppMsgOut");
            SuppMsgOut = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class WMSL_DeleteFromStoreResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.WitsmlSoap.WMSL_DeleteFromStoreResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.WitsmlSoap.WMSL_DeleteFromStoreResponse", 2);
            encoder.EncodeRecordFieldName("Result");
            encoder.EncodeInt(Result);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("SuppMsgOut");
            encoder.EncodeString(SuppMsgOut);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.WitsmlSoap.WMSL_DeleteFromStoreResponse", 2);
            decoder.DecodeRecordFieldName("Result");
            Result = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("SuppMsgOut");
            SuppMsgOut = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class WMSL_GetBaseMsgResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.WitsmlSoap.WMSL_GetBaseMsgResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.WitsmlSoap.WMSL_GetBaseMsgResponse", 1);
            encoder.EncodeRecordFieldName("Result");
            encoder.EncodeString(Result);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.WitsmlSoap.WMSL_GetBaseMsgResponse", 1);
            decoder.DecodeRecordFieldName("Result");
            Result = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class WMSL_GetCapResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.WitsmlSoap.WMSL_GetCapResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.WitsmlSoap.WMSL_GetCapResponse", 3);
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
            decoder.DecodeRecordStart("Energistics.Protocol.WitsmlSoap.WMSL_GetCapResponse", 3);
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
    public partial class WMSL_GetFromStoreResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.WitsmlSoap.WMSL_GetFromStoreResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.WitsmlSoap.WMSL_GetFromStoreResponse", 3);
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
            decoder.DecodeRecordStart("Energistics.Protocol.WitsmlSoap.WMSL_GetFromStoreResponse", 3);
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
    public partial class WMSL_GetVersionResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.WitsmlSoap.WMSL_GetVersionResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.WitsmlSoap.WMSL_GetVersionResponse", 1);
            encoder.EncodeRecordFieldName("Result");
            encoder.EncodeString(Result);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.WitsmlSoap.WMSL_GetVersionResponse", 1);
            decoder.DecodeRecordFieldName("Result");
            Result = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
    public partial class WMSL_UpdateInStoreResponse : IAvroRecord
    {
        string IAvroObject.AvroTypeName => "Energistics.Protocol.WitsmlSoap.WMSL_UpdateInStoreResponse";
        void IAvroObject.Encode(IAvroEncoder encoder)
        {
            encoder.EncodeRecordStart("Energistics.Protocol.WitsmlSoap.WMSL_UpdateInStoreResponse", 2);
            encoder.EncodeRecordFieldName("Result");
            encoder.EncodeInt(Result);
            encoder.EncodeRecordFieldSeparator();
            encoder.EncodeRecordFieldName("SuppMsgOut");
            encoder.EncodeString(SuppMsgOut);
            encoder.EncodeRecordEnd();
        }
        void IAvroObject.Decode(IAvroDecoder decoder)
        {
            decoder.DecodeRecordStart("Energistics.Protocol.WitsmlSoap.WMSL_UpdateInStoreResponse", 2);
            decoder.DecodeRecordFieldName("Result");
            Result = decoder.DecodeInt();
            decoder.DecodeRecordFieldSeparator();
            decoder.DecodeRecordFieldName("SuppMsgOut");
            SuppMsgOut = decoder.DecodeString();
            decoder.DecodeRecordEnd();
        }
    }
}
