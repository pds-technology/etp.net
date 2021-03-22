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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Energistics.Etp.Common;
using Energistics.Etp.Common.Datatypes;
using Energistics.Etp.Common.Datatypes.ChannelData;
using Energistics.Etp.Common.Datatypes.DataArrayTypes;
using Energistics.Etp.Common.Datatypes.Object;
using Energistics.Etp.Common.Protocol.Core;
using Energistics.Etp.v11.Datatypes;
using Newtonsoft.Json;

namespace Energistics.Etp.v11
{
    namespace Datatypes
    {
        namespace ChannelData
        {
            public partial class ChannelMetadataRecord : IChannelMetadataRecord
            {
                [JsonIgnore]
                int IChannelMetadataRecord.Status
                {
                    get { return (int) Status; }
                    set { Status = (ChannelStatuses) value; }
                }

                [JsonIgnore]
                IList IChannelMetadataRecord.Indexes
                {
                    get { return Indexes as IList; }
                    set { Indexes = value as IList<IndexMetadataRecord>; }
                }

                [JsonIgnore]
                IReadOnlyDataValueDictionary IChannelMetadataRecord.CustomData
                {
                    get { return CustomData.ToDataValueDictionary(); }
                }

                IDataValueDictionary IChannelMetadataRecord.GetOrCreateCustomData()
                {
                    if (CustomData == null)
                        CustomData = new Dictionary<string, DataValue>();

                    return CustomData.ToDataValueDictionary();
                }

                void IChannelMetadataRecord.SetCustomDataFrom(IReadOnlyDictionary<string, IDataValue> dictionary)
                {
                    CustomData = dictionary.ToValueDictionary<DataValue>();
                }

                [JsonIgnore]
                IDataObject IChannelMetadataRecord.DomainObject
                {
                    get { return DomainObject; }
                    set { DomainObject = (Object.DataObject)value; }
                }

                [JsonIgnore]
                IList IChannelMetadataRecord.AttributeMetadata
                {
                    get { return null; }
                    set { }
                }

                [JsonIgnore]
                bool IUuidGuidSource.IsUuidValidGuid => CommonExtensions.IsValidGuid(Uuid);

                [JsonIgnore]
                string IUuidGuidSource.RawUuid => Uuid;

                [JsonIgnore]
                Guid IUuidGuidSource.UuidGuid => CommonExtensions.ToGuid(Uuid);

                [JsonIgnore]
                string IUuidGuidSource.DisplayUuid => Uuid;
            }

            public partial class ChannelRangeInfo : IChannelRangeInfo
            {
                IList<long> IChannelRangeInfo.ChannelIds
                {
                    get { return ChannelId; }
                    set { ChannelId = value; }
                }

                object IChannelRangeInfo.StartIndex
                {
                    get { return StartIndex; }
                    set { StartIndex = (long) value; }
                }

                object IChannelRangeInfo.EndIndex
                {
                    get { return EndIndex; }
                    set { EndIndex = (long) value; }
                }

                [JsonIgnore]
                public string Uom
                {
                    get { return null; }
                    set { }
                }

                [JsonIgnore]
                public string DepthDatum
                {
                    get { return null; }
                    set { }
                }
            }

            public partial class ChannelStreamingInfo : IChannelStreamingInfo
            {
                IStreamingStartIndex IChannelStreamingInfo.StartIndex
                {
                    get { return StartIndex; }
                    set { StartIndex = value as StreamingStartIndex; }
                }
            }

            public partial class DataItem : IDataItem
            {
                IList IDataItem.Indexes
                {
                    get { return Indexes as IList; }
                    set { Indexes = value as IList<long>; }
                }

                IDataValue IDataItem.Value
                {
                    get { return Value; }
                    set { Value = value.ToDataValue<DataValue>(); }
                }

                IList IDataItem.ValueAttributes
                {
                    get { return ValueAttributes as IList; }
                    set { ValueAttributes = value as IList<DataAttribute>; }
                }
            }

            public partial class IndexMetadataRecord : IIndexMetadataRecord
            {
                [JsonIgnore]
                int IIndexMetadataRecord.IndexKind
                {
                    get { return (int) IndexType; }
                    set { IndexType = (ChannelIndexTypes) value; }
                }

                int IIndexMetadataRecord.Direction
                {
                    get { return (int) Direction; }
                    set { Direction = (IndexDirections) value; }
                }

                [JsonIgnore]
                object IIndexMetadataRecord.StartIndex
                {
                    get { return null; }
                    set { }
                }

                [JsonIgnore]
                object IIndexMetadataRecord.EndIndex
                {
                    get { return null; }
                    set { }
                }

                [JsonIgnore]
                IReadOnlyDataValueDictionary IIndexMetadataRecord.CustomData
                {
                    get { return CustomData.ToDataValueDictionary(); }
                }

                IDataValueDictionary IIndexMetadataRecord.GetOrCreateCustomData()
                {
                    if (CustomData == null)
                        CustomData = new Dictionary<string, DataValue>();

                    return CustomData.ToDataValueDictionary();
                }

                void IIndexMetadataRecord.SetCustomDataFrom(IReadOnlyDictionary<string, IDataValue> dictionary)
                {
                    CustomData = dictionary.ToValueDictionary<DataValue>();
                }
            }

            public partial class StreamingStartIndex : IStreamingStartIndex { }

            internal class ChannelDescribeSubscription : IChannelDescribeSubscription
            {
                public ChannelDescribeSubscription(Guid namespaceId) { NamespaceId = namespaceId; }
                public Guid NamespaceId { get; }

                public string Uri { get; set; }

                public IUuidGuidSource RequestUuidGuid => new HashedStringGuidSource(NamespaceId, Uri);
            }
        }

        namespace Object
        {
            public partial class DataObject : IDataObject
            {
                IResource IDataObject.Resource
                {
                    get { return Resource; }
                    set { Resource = (Resource) value; }
                }
            }

            public partial class Resource : IResource
            {
                [JsonIgnore]
                IList<string> IResource.AlternateUris { get { return null; } set { } }

                [JsonIgnore]
                int? IResource.SourceCount { get { return null; } set { } }

                [JsonIgnore]
                int? IResource.TargetCount
                {
                    get { return HasChildren < 0 ? (int?) null : HasChildren; }
                    set { HasChildren = value ?? -1; }
                }

                [JsonIgnore]
                int? IResource.HasChildren
                {
                    get { return HasChildren < 0 ? (int?)null : HasChildren; }
                    set { HasChildren = value ?? -1; }
                }

                [JsonIgnore]
                long? IResource.LastChanged
                {
                    get { return LastChanged < 0 ? (long?) null : LastChanged; }
                    set { LastChanged = value ?? -1; }
                }

                [JsonIgnore]
                bool? IResource.ObjectNotifiable
                {
                    get { return ObjectNotifiable; }
                    set { ObjectNotifiable = value ?? false; }
                }

                [JsonIgnore]
                bool? IResource.ChannelSubscribable
                {
                    get { return ChannelSubscribable; }
                    set { ChannelSubscribable = value ?? false; }
                }

                [JsonIgnore]
                long? IResource.StoreLastWrite {  get { return null; } set { } }

                [JsonIgnore]
                string IResource.DataObjectType
                {
                    get { return ContentType == null ? null : new EtpContentType(ContentType).ToDataObjectType(); }
                    set { ContentType = value == null ? null : new EtpDataObjectType(value).ToContentType(); }
                }

                [JsonIgnore]
                public bool IsUuidValidGuid => CommonExtensions.IsValidGuid(Uuid);

                [JsonIgnore]
                public string RawUuid => Uuid;

                [JsonIgnore]
                public Guid UuidGuid => CommonExtensions.ToGuid(Uuid);

                [JsonIgnore]
                public string DisplayUuid => Uuid;

                IReadOnlyDataValueDictionary IResource.CustomData
                {
                    get { return CustomData.ToDataValueDictionary<DataValue>(); }
                }

                IDataValueDictionary IResource.GetOrCreateCustomData()
                {
                    if (CustomData == null)
                        CustomData = new Dictionary<string, string>();

                    return CustomData.ToDataValueDictionary<DataValue>();
                }

                void IResource.SetCustomDataFrom(IReadOnlyDictionary<string, IDataValue> dictionary)
                {
                    CustomData = dictionary.ToStringDictionary();
                }
            }

            public partial class NotificationRequestRecord : IRequestUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource RequestUuidGuid => new StringGuidSource(Uuid);
            }
        }

        public partial class Contact : IContact { }

        public partial class AnyArray : IAnyArray { }

        public partial class ArrayOfBoolean : IEtpArray<bool> { }

        public partial class ArrayOfDouble : IEtpArray<double> { }

        public partial class ArrayOfFloat: IEtpArray<float> { }

        public partial class ArrayOfInt : IEtpArray<int> { }

        public partial class ArrayOfLong : IEtpArray<long> { }

        public partial class DataAttribute : IDataAttribute
        {
            IDataValue IDataAttribute.AttributeValue
            {
                get { return AttributeValue; }
                set { AttributeValue = value.ToDataValue<DataValue>(); }
            }
        }

        public partial class DataValue : IDataValue { }

        public partial class MessageHeader : IMessageHeader
        {
            EtpVersion IMessageHeader.EtpVersion => EtpVersion.v11;

            [JsonIgnore]
            DateTime IMessageHeader.Timestamp { get; set; }
        }

        public partial class SupportedProtocol : ISupportedProtocol
        {
            [JsonIgnore]
            string ISupportedProtocol.CounterpartRole => Roles.GetCounterpartRole(Role);

            [JsonIgnore]
            EtpVersion ISupportedProtocol.EtpVersion
            {
                get { return ProtocolVersion.ToEtpVersion(); }
                set { ProtocolVersion = value.ToVersion<Version>(); }
            }

            [JsonIgnore]
            IReadOnlyDataValueDictionary ISupportedProtocol.ProtocolCapabilities
            {
                get { return ProtocolCapabilities.ToDataValueDictionary(); }
            }

            IDataValueDictionary ISupportedProtocol.GetOrCreateProtocolCapabilities()
            {
                if (ProtocolCapabilities == null)
                    ProtocolCapabilities = new Dictionary<string, DataValue>();

                return ProtocolCapabilities.ToDataValueDictionary();
            }

            void ISupportedProtocol.SetProtocolCapabilitiesFrom(IReadOnlyDictionary<string, IDataValue> dictionary)
            {
                ProtocolCapabilities = dictionary.ToValueDictionary<DataValue>();
            }
        }

        public partial class Version : IVersion { }

        public class SupportedDataObject : ISupportedDataObject
        {
            public IDataObjectType QualifiedType { get; set; }

            public IList<string> DataObjectCapabilities { get { return new List<string>(); } set { } }
        }

        public partial class ServerCapabilities : IServerCapabilities
        {
            IContact IServerCapabilities.ContactInformation { get { return ContactInformation; } set { ContactInformation = value.ToContact<Contact>(); } }

            IReadOnlyList<ISupportedProtocol> IServerCapabilities.SupportedProtocols => new List<ISupportedProtocol>(SupportedProtocols);

            void IServerCapabilities.SetSupportedProtocolsFrom(IEnumerable<ISupportedProtocol> supportedProtocols)
            {
                SupportedProtocols = new List<SupportedProtocol>(supportedProtocols.Select(p => p.ToSupportedProtocol<SupportedProtocol>()));
            }

            IReadOnlyList<ISupportedDataObject> IServerCapabilities.SupportedDataObjects => new List<ISupportedDataObject>(SupportedObjects.Select(o => new SupportedDataObject { QualifiedType = new EtpContentType(o) }));

            void IServerCapabilities.SetSupportedDataObjectsFrom(IEnumerable<ISupportedDataObject> supportedDataObjects)
            {
                SupportedObjects = new List<string>(supportedDataObjects.Select(d => d.QualifiedType.ContentType.ToString()));
            }

            IList<string> IServerCapabilities.SupportedCompression { get { return null; } set { } }

            IList<string> IServerCapabilities.SupportedFormats { get { return new List<string> { Formats.Xml }; } set { } }

            IList<string> IServerCapabilities.SupportedEncodings { get { return SupportedEncodings?.Split(';'); }  set { SupportedEncodings = value == null ? null : string.Join(";", value); } }

            IReadOnlyDataValueDictionary IServerCapabilities.EndpointCapabilities
            {
                get { return new EtpDataValueDictionaryWrapper<DataValue>(); }
            }

            IDataValueDictionary IServerCapabilities.GetOrCreateEndpointCapabilities()
            {
                return new EtpDataValueDictionaryWrapper<DataValue>(); ;
            }

            void IServerCapabilities.SetEndpointCapabilitiesFrom(IReadOnlyDictionary<string, IDataValue> dictionary)
            {
            }
        }
    }

    namespace Protocol
    {
        namespace Core
        {
            public partial class Acknowledge : IAcknowledge { }

            public partial class ProtocolException : IProtocolException, IErrorInfo
            {
                [JsonIgnore]
                int IErrorInfo.Code
                {
                    get { return ErrorCode; }
                    set { ErrorCode = value; }
                }

                [JsonIgnore]
                string IErrorInfo.Message
                {
                    get { return ErrorMessage; }
                    set { ErrorMessage = value; }
                }

                [JsonIgnore]
                EtpVersion IErrorInfo.EtpVersion => EtpVersion.v11;
            }

            public partial class RequestSession : IRequestSession
            {
                bool IRequestSession.IsClientInstanceIdValid => true;

                string IRequestSession.RawClientInstanceId => null;

                Guid IRequestSession.ClientInstanceId { get { return default(Guid); } set { } }

                IReadOnlyList<ISupportedProtocol> IRequestSession.RequestedProtocols => new List<ISupportedProtocol>(RequestedProtocols);

                void IRequestSession.SetRequestedProtocolsFrom(IEnumerable<ISupportedProtocol> requestedProtocols)
                {
                    RequestedProtocols = new List<SupportedProtocol>(requestedProtocols.Select(p => p.ToSupportedProtocol<SupportedProtocol>()));
                }

                IReadOnlyList<ISupportedDataObject> IRequestSession.SupportedDataObjects => new List<ISupportedDataObject>(SupportedObjects.Select(o => new SupportedDataObject { QualifiedType = new EtpContentType(o) }));

                void IRequestSession.SetSupportedDataObjectsFrom(IEnumerable<ISupportedDataObject> supportedDataObjects)
                {
                    SupportedObjects = new List<string>(supportedDataObjects.Select(d => d.QualifiedType.ContentType.ToString()));
                }

                IList<string> IRequestSession.SupportedCompression { get { return new List<string>(); } set { } }

                IList<string> IRequestSession.SupportedFormats { get { return new List<string> { Formats.Xml }; } set { } }

                long IRequestSession.CurrentDateTime { get { return 0; } set { } }

                IReadOnlyDataValueDictionary IRequestSession.EndpointCapabilities
                {
                    get { return new EtpDataValueDictionaryWrapper<DataValue>(); }
                }

                IDataValueDictionary IRequestSession.GetOrCreateEndpointCapabilities()
                {
                    return new EtpDataValueDictionaryWrapper<DataValue>(); ;
                }

                void IRequestSession.SetEndpointCapabilitiesFrom(IReadOnlyDictionary<string, IDataValue> dictionary)
                {
                }
            }

            public partial class OpenSession : IOpenSession
            {
                bool IOpenSession.IsServerInstanceIdValid => true;

                string IOpenSession.RawServerInstanceId => null;

                Guid IOpenSession.ServerInstanceId { get { return default(Guid); } set { } }

                IReadOnlyList<ISupportedProtocol> IOpenSession.SupportedProtocols => new List<ISupportedProtocol>(SupportedProtocols);

                void IOpenSession.SetSupportedProtocolsFrom(IEnumerable<ISupportedProtocol> supportedProtocols)
                {
                    SupportedProtocols = new List<SupportedProtocol>(supportedProtocols.Select(p => p.ToSupportedProtocol<SupportedProtocol>()));
                }

                IReadOnlyList<ISupportedDataObject> IOpenSession.SupportedDataObjects => new List<ISupportedDataObject>(SupportedObjects.Select(o => new SupportedDataObject { QualifiedType = new EtpContentType(o) }));

                void IOpenSession.SetSupportedDataObjectsFrom(IEnumerable<ISupportedDataObject> supportedDataObjects)
                {
                    SupportedObjects = new List<string>(supportedDataObjects.Select(d => d.QualifiedType.ContentType.ToString()));
                }


                string IOpenSession.RawSessionId => new StringGuidSource(SessionId).RawUuid;

                bool IOpenSession.IsSessionIdValid => new StringGuidSource(SessionId).IsUuidValidGuid;

                Guid IOpenSession.SessionId { get { return new StringGuidSource(SessionId).UuidGuid; } set { SessionId = value.ToString(); } }

                string IOpenSession.SupportedCompression { get { return null; } set { } }

                IList<string> IOpenSession.SupportedFormats { get { return new List<string> { Formats.Xml }; } set { } }

                long IOpenSession.CurrentDateTime { get { return 0; } set { } }

                IReadOnlyDataValueDictionary IOpenSession.EndpointCapabilities
                {
                    get { return new EtpDataValueDictionaryWrapper<DataValue>(); }
                }

                IDataValueDictionary IOpenSession.GetOrCreateEndpointCapabilities()
                {
                    return new EtpDataValueDictionaryWrapper<DataValue>(); ;
                }

                void IOpenSession.SetEndpointCapabilitiesFrom(IReadOnlyDictionary<string, IDataValue> dictionary)
                {
                }
            }

            public partial class CloseSession : ICloseSession { }
        }

        namespace ChannelStreaming
        {
            public partial class ChannelDescribe : IChannelDescribeSubscriptionSource
            {
                public IList<IChannelDescribeSubscription> GetSubscriptions(Guid sessionId)
                    => new List<IChannelDescribeSubscription>(Uris?.Select(uri => new Datatypes.ChannelData.ChannelDescribeSubscription(sessionId) { Uri = uri }));
            }
        }

        namespace DataArray
        {
            public partial class DataArray : IDataArray
            {
                IAnyArray IDataArray.Data { get { return Data; } set { Data = value.ToAnyArray<AnyArray>(); } }
            }
        }

        namespace GrowingObject
        {
            public partial class GrowingObjectPut : IObjectPart
            {
                [JsonIgnore]
                string IObjectPart.Uid { get { return null;  } set { } }
            }
        }

        namespace StoreNotification
        {
            public partial class CancelNotification : IRequestUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource RequestUuidGuid => new StringGuidSource(RequestUuid);
            }
        }
    }
}
