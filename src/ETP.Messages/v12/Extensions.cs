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
using System.Text.RegularExpressions;
using Energistics.Etp.Common;
using Energistics.Etp.Common.Datatypes;
using Energistics.Etp.Common.Datatypes.ChannelData;
using Energistics.Etp.Common.Datatypes.DataArrayTypes;
using Energistics.Etp.Common.Datatypes.Object;
using Energistics.Etp.Common.Protocol.Core;
using Energistics.Etp.v12.Datatypes;
using Energistics.Etp.v12.Datatypes.Object;
using Newtonsoft.Json;

namespace Energistics.Etp.v12
{
    namespace Datatypes
    {
        namespace ChannelData
        {
            public partial class ChannelMetadataRecord : IChannelMetadataRecord
            {
                [JsonIgnore]
                string IChannelMetadataRecord.Uuid
                {
                    get { return null; }
                    set { }
                }

                [JsonIgnore]
                long IChannelMetadataRecord.ChannelId
                {
                    get { return Id; }
                    set { Id = value; }
                }

                [JsonIgnore]
                string IChannelMetadataRecord.ChannelUri
                {
                    get { return Uri; }
                    set { Uri = value; }
                }

                int IChannelMetadataRecord.Status
                {
                    get { return (int)Status; }
                    set { Status = (ActiveStatusKind)value; }
                }

                [JsonIgnore]
                long? IChannelMetadataRecord.StartIndex
                {
                    get { return null; }
                    set { }
                }

                [JsonIgnore]
                long? IChannelMetadataRecord.EndIndex
                {
                    get { return null; }
                    set { }
                }

                [JsonIgnore]
                string IChannelMetadataRecord.ContentType
                {
                    get { return null; }
                    set { }
                }

                [JsonIgnore]
                string IChannelMetadataRecord.Description
                {
                    get { return null; }
                    set { }
                }

                IList IChannelMetadataRecord.Indexes
                {
                    get { return Indexes as IList; }
                    set { Indexes = value as IList<IndexMetadataRecord>; }
                }

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
                    get { return null; }
                    set { }
                }

                IList IChannelMetadataRecord.AttributeMetadata
                {
                    get { return AttributeMetadata as IList; }
                    set { AttributeMetadata = value as IList<AttributeMetadataRecord>; }
                }

                string IChannelMetadataRecord.DataType
                {
                    get { return this.DataType.ToString("F"); }
                    set
                    {
                        Enum.TryParse<DataValueType>(value, out var dataType);
                        this.DataType = dataType;
                    }
                }

                [JsonIgnore]
                bool IUuidGuidSource.IsUuidValidGuid => CommonExtensions.IsValidGuid(((IChannelMetadataRecord)this).Uuid);

                [JsonIgnore]
                string IUuidGuidSource.RawUuid => ((IChannelMetadataRecord)this).Uuid;

                [JsonIgnore]
                Guid IUuidGuidSource.UuidGuid => CommonExtensions.ToGuid(((IChannelMetadataRecord)this).Uuid);

                [JsonIgnore]

                string IUuidGuidSource.DisplayUuid => ((IChannelMetadataRecord)this).Uuid;
            }

            public partial class ChannelRangeInfo : IChannelRangeInfo
            {
                [JsonIgnore]
                object IChannelRangeInfo.StartIndex
                {
                    get { return EnsureInterval().StartIndex.Item; }
                    set { EnsureInterval().StartIndex.Item = value; }
                }

                [JsonIgnore]
                object IChannelRangeInfo.EndIndex
                {
                    get { return EnsureInterval().EndIndex.Item; }
                    set { EnsureInterval().EndIndex.Item = value; }
                }

                [JsonIgnore]
                string IChannelRangeInfo.Uom
                {
                    get { return EnsureInterval().Uom; }
                    set { EnsureInterval().Uom = value; }
                }

                [JsonIgnore]
                string IChannelRangeInfo.DepthDatum
                {
                    get { return EnsureInterval().DepthDatum; }
                    set { EnsureInterval().DepthDatum = value; }
                }

                private IndexInterval EnsureInterval()
                {
                    if (Interval == null)
                        Interval = new IndexInterval();

                    if (Interval.StartIndex == null)
                        Interval.StartIndex = new IndexValue();

                    if (Interval.EndIndex == null)
                        Interval.EndIndex = new IndexValue();

                    return Interval;
                }
            }

            public partial class DataItem : IDataItem
            {
                IList IDataItem.Indexes
                {
                    get { return Indexes as IList; }
                    set { Indexes = value as IList<IndexValue>; }
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
                string IIndexMetadataRecord.Mnemonic
                {
                    get { return Name; }
                    set { Name = value; }
                }

                int IIndexMetadataRecord.IndexKind
                {
                    get { return (int)IndexKind; }
                    set { IndexKind = (ChannelIndexKind) value; }
                }

                int IIndexMetadataRecord.Direction
                {
                    get { return (int)Direction; }
                    set { Direction = (IndexDirection)value; }
                }

                [JsonIgnore]
                object IIndexMetadataRecord.StartIndex
                {
                    get { return EnsureInterval().StartIndex.Item; }
                    set { EnsureInterval().StartIndex.Item = value; }
                }

                [JsonIgnore]
                object IIndexMetadataRecord.EndIndex
                {
                    get { return EnsureInterval().EndIndex.Item; }
                    set { EnsureInterval().EndIndex.Item = value; }
                }

                [JsonIgnore]
                string IIndexMetadataRecord.Uom
                {
                    get { return EnsureInterval().Uom; }
                    set { EnsureInterval().Uom = value; }
                }

                [JsonIgnore]
                string IIndexMetadataRecord.DepthDatum
                {
                    get { return EnsureInterval().DepthDatum; }
                    set { EnsureInterval().DepthDatum = value; }
                }

                [JsonIgnore]
                string IIndexMetadataRecord.Uri
                {
                    get { return null; }
                    set { }
                }

                [JsonIgnore]
                string IIndexMetadataRecord.Description
                {
                    get { return null; }
                    set { }
                }

                [JsonIgnore]
                string IIndexMetadataRecord.TimeDatum
                {
                    get { return null; }
                    set { }
                }

                [JsonIgnore]
                int IIndexMetadataRecord.Scale
                {
                    get { return 0; }
                    set { }
                }

                IReadOnlyDataValueDictionary IIndexMetadataRecord.CustomData
                {
                    get { return null; }
                }

                IDataValueDictionary IIndexMetadataRecord.GetOrCreateCustomData()
                {
                    return null;
                }

                void IIndexMetadataRecord.SetCustomDataFrom(IReadOnlyDictionary<string, IDataValue> dictionary)
                {
                }

                private IndexInterval EnsureInterval()
                {
                    if (Interval == null)
                        Interval = new IndexInterval();

                    if (Interval.StartIndex == null)
                        Interval.StartIndex = new IndexValue();

                    if (Interval.EndIndex == null)
                        Interval.EndIndex = new IndexValue();

                    return Interval;
                }
            }
        }

        namespace DataArrayTypes
        {
            public partial class DataArray : IDataArray
            {
                IAnyArray IDataArray.Data
                {
                    get { return Data; }
                    set { Data = value.ToAnyArray<AnyArray>(); }
                }
            }
        }

        namespace Object
        {
            public partial class DataObject : IDataObject, IBlobIdGuidSource
            {
                IResource IDataObject.Resource
                {
                    get { return Resource; }
                    set { Resource = (Resource)value; }
                }

                [JsonIgnore]
                string IDataObject.ContentEncoding
                {
                    get { return null; }
                    set { }
                }

                [JsonIgnore]
                public IUuidGuidSource BlobIdGuid => new UuidGuidSource(BlobId);
            }

            public partial class Resource : IResource
            {
                private static readonly Regex _UuidRegex = new Regex(@"[^(]*\(([^)]*)\)", RegexOptions.Compiled | RegexOptions.CultureInvariant);

                [JsonIgnore]
                string IResource.Uuid
                {
                    get
                    {
                        if (Uri == null) return null;

                        var match = _UuidRegex.Match(Uri);
                        if (!match.Success)
                            return null;

                        return match.Groups[1].Value;
                    }
                    set { }
                }

                [JsonIgnore]
                string IResource.ContentType
                {
                    get { return DataObjectType == null ? null : new EtpDataObjectType(DataObjectType).ToContentType(); }
                    set { DataObjectType = value == null ? null : new EtpContentType(value).ToDataObjectType(); }
                }

                [JsonIgnore]
                string IResource.ResourceType
                {
                    get { return "DataObject"; }
                    set
                    {
                    }
                }

                [JsonIgnore]
                bool? IResource.ChannelSubscribable { get { return null; } set { } }

                [JsonIgnore]
                bool? IResource.ObjectNotifiable { get { return null; } set { } }

                [JsonIgnore]
                int? IResource.HasChildren
                {
                    get { return TargetCount == null ? -1 : TargetCount; }
                    set { TargetCount = value < 0 ? null : value; }
                }

                [JsonIgnore]
                long? IResource.LastChanged
                {
                    get { return LastChanged; }
                    set { LastChanged = value ?? 0L; }
                }

                [JsonIgnore]
                long? IResource.StoreLastWrite
                {
                    get { return StoreLastWrite; }
                    set { StoreLastWrite = value ?? 0L; }
                }

                [JsonIgnore]
                bool IUuidGuidSource.IsUuidValidGuid => CommonExtensions.IsValidGuid(((IResource)this).Uuid);

                [JsonIgnore]
                string IUuidGuidSource.RawUuid => ((IResource)this).Uuid;

                [JsonIgnore]
                Guid IUuidGuidSource.UuidGuid => CommonExtensions.ToGuid(((IResource)this).Uuid);

                [JsonIgnore]
                public string DisplayUuid => ((IResource)this).Uuid;

                IReadOnlyDataValueDictionary IResource.CustomData
                {
                    get { return CustomData.ToDataValueDictionary(); }
                }

                IDataValueDictionary IResource.GetOrCreateCustomData()
                {
                    if (CustomData == null)
                        CustomData = new Dictionary<string, DataValue>();

                    return CustomData.ToDataValueDictionary();
                }

                void IResource.SetCustomDataFrom(IReadOnlyDictionary<string, IDataValue> dictionary)
                {
                    CustomData = dictionary.ToValueDictionary<DataValue>();
                }
            }

            public partial class ObjectPart : IObjectPart
            {
            }

            public partial class SubscriptionInfo : IRequestUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource RequestUuidGuid => new UuidGuidSource(RequestUuid);
            }
        }

        public partial class Contact : IContact { }

        public partial class ErrorInfo : IErrorInfo
        {
            [JsonIgnore]
            EtpVersion IErrorInfo.EtpVersion => EtpVersion.v12;
        }

        public partial class AnyArray : IAnyArray { }

        public partial class ArrayOfBoolean : IEtpArray<bool> { }

        public partial class ArrayOfDouble : IEtpArray<double> { }

        public partial class ArrayOfFloat : IEtpArray<float> { }

        public partial class ArrayOfInt : IEtpArray<int> { }

        public partial class ArrayOfLong : IEtpArray<long> { }

        public partial class ArrayOfString : IEtpArray<string> { }

        public partial class DataAttribute : IDataAttribute
        {
            IDataValue IDataAttribute.AttributeValue
            {
                get { return AttributeValue; }
                set { AttributeValue = value.ToDataValue<DataValue>(); }
            }
        }

        public partial class DataValue : IDataValue { }

        public partial class IndexValue : IIndexValue { }

        public partial class MessageHeader : IMessageHeader
        {
            EtpVersion IMessageHeader.EtpVersion => EtpVersion.v12;

            [JsonIgnore]
            DateTime IMessageHeader.Timestamp { get; set; }
        }

        public partial class MessageHeaderExtension : IMessageHeaderExtension
        {
            IReadOnlyDataValueDictionary IMessageHeaderExtension.Extension
            {
                get { return Extension.ToDataValueDictionary(); }
            }

            IDataValueDictionary IMessageHeaderExtension.GetOrCreateExtension()
            {
                if (Extension == null)
                    Extension = new Dictionary<string, DataValue>();

                return Extension.ToDataValueDictionary();
            }

            void IMessageHeaderExtension.SetExtensionFrom(IReadOnlyDictionary<string, IDataValue> dictionary)
            {
                Extension = dictionary.ToValueDictionary<DataValue>();
            }
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

        public partial class Uuid : IUuid { }

        public partial class SupportedDataObject : ISupportedDataObject
        {
            IDataObjectType ISupportedDataObject.QualifiedType { get { return new EtpDataObjectType(QualifiedType); } set { QualifiedType = value.DataObjectType.ToString(); } }
        }

        public partial class ServerCapabilities : IServerCapabilities
        {
            IContact IServerCapabilities.ContactInformation { get { return ContactInformation; } set { ContactInformation = value.ToContact<Contact>(); } }

            IReadOnlyList<ISupportedProtocol> IServerCapabilities.SupportedProtocols => new List<ISupportedProtocol>(SupportedProtocols);

            void IServerCapabilities.SetSupportedProtocolsFrom(IEnumerable<ISupportedProtocol> supportedProtocols)
            {
                SupportedProtocols = new List<SupportedProtocol>(supportedProtocols.Select(p => p.ToSupportedProtocol<SupportedProtocol>()));
            }

            IReadOnlyList<ISupportedDataObject> IServerCapabilities.SupportedDataObjects => new List<ISupportedDataObject>(SupportedDataObjects);

            void IServerCapabilities.SetSupportedDataObjectsFrom(IEnumerable<ISupportedDataObject> supportedDataObjects)
            {
                SupportedDataObjects = new List<SupportedDataObject>(supportedDataObjects.Select(d => d.ToSupportedDataObject<SupportedDataObject>()));
            }

            IReadOnlyDataValueDictionary IServerCapabilities.EndpointCapabilities
            {
                get { return EndpointCapabilities.ToDataValueDictionary(); }
            }

            IDataValueDictionary IServerCapabilities.GetOrCreateEndpointCapabilities()
            {
                if (EndpointCapabilities == null)
                    EndpointCapabilities = new Dictionary<string, DataValue>();

                return EndpointCapabilities.ToDataValueDictionary();
            }

            void IServerCapabilities.SetEndpointCapabilitiesFrom(IReadOnlyDictionary<string, IDataValue> dictionary)
            {
                EndpointCapabilities = dictionary.ToValueDictionary<DataValue>();
            }
        }

    }

    namespace Protocol
    {
        namespace ChannelDataFrame
        {
            public partial class CancelGetFrame : IRequestUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource RequestUuidGuid => new UuidGuidSource(RequestUuid);
            }

            public partial class GetFrame : IRequestUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource RequestUuidGuid => new UuidGuidSource(RequestUuid);
            }
        }

        namespace ChannelSubscribe
        {
            public partial class CancelGetRanges: IRequestUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource RequestUuidGuid => new UuidGuidSource(RequestUuid);
            }

            public partial class GetRanges : IRequestUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource RequestUuidGuid => new UuidGuidSource(RequestUuid);
            }
        }

        namespace Core
        {
            public partial class Acknowledge : IAcknowledge { }

            public partial class ProtocolException : IProtocolException
            {
                int IProtocolException.ErrorCode
                {
                    get { return Error?.Code ?? 0; }
                    set
                    {
                        if (Error == null)
                            Error = new Datatypes.ErrorInfo();

                        Error.Code = value;
                    }
                }

                string IProtocolException.ErrorMessage
                {
                    get { return Error?.Message; }
                    set
                    {
                        if (Error == null)
                            Error = new Datatypes.ErrorInfo();

                        Error.Message = value;
                    }
                }
            }

            public partial class RequestSession : IRequestSession
            {
                bool IRequestSession.IsClientInstanceIdValid => ClientInstanceId.IsValidGuid();

                string IRequestSession.RawClientInstanceId => new UuidGuidSource(ClientInstanceId).RawUuid;

                Guid IRequestSession.ClientInstanceId { get { return new UuidGuidSource(ClientInstanceId).UuidGuid; } set { ClientInstanceId = value.ToUuid<Uuid>(); } }

                IReadOnlyList<ISupportedProtocol> IRequestSession.RequestedProtocols => new List<ISupportedProtocol>(RequestedProtocols);

                void IRequestSession.SetRequestedProtocolsFrom(IEnumerable<ISupportedProtocol> requestedProtocols)
                {
                    RequestedProtocols = new List<SupportedProtocol>(requestedProtocols.Select(p => p.ToSupportedProtocol<SupportedProtocol>()));
                }

                IReadOnlyList<ISupportedDataObject> IRequestSession.SupportedDataObjects => new List<ISupportedDataObject>(SupportedDataObjects);

                void IRequestSession.SetSupportedDataObjectsFrom(IEnumerable<ISupportedDataObject> supportedDataObjects)
                {
                    SupportedDataObjects = new List<SupportedDataObject>(supportedDataObjects.Select(d => d.ToSupportedDataObject<SupportedDataObject>()));
                }

                IReadOnlyDataValueDictionary IRequestSession.EndpointCapabilities
                {
                    get { return EndpointCapabilities.ToDataValueDictionary(); }
                }

                IDataValueDictionary IRequestSession.GetOrCreateEndpointCapabilities()
                {
                    if (EndpointCapabilities == null)
                        EndpointCapabilities = new Dictionary<string, DataValue>();

                    return EndpointCapabilities.ToDataValueDictionary();
                }

                void IRequestSession.SetEndpointCapabilitiesFrom(IReadOnlyDictionary<string, IDataValue> dictionary)
                {
                    EndpointCapabilities = dictionary.ToValueDictionary<DataValue>();
                }
            }

            public partial class OpenSession : IOpenSession
            {
                bool IOpenSession.IsServerInstanceIdValid => ServerInstanceId.IsValidGuid();

                string IOpenSession.RawServerInstanceId => new UuidGuidSource(ServerInstanceId).RawUuid;

                Guid IOpenSession.ServerInstanceId { get { return new UuidGuidSource(ServerInstanceId).UuidGuid; } set { ServerInstanceId = value.ToUuid<Uuid>(); } }

                IReadOnlyList<ISupportedProtocol> IOpenSession.SupportedProtocols => new List<ISupportedProtocol>(SupportedProtocols);

                void IOpenSession.SetSupportedProtocolsFrom(IEnumerable<ISupportedProtocol> supportedProtocols)
                {
                    SupportedProtocols = new List<SupportedProtocol>(supportedProtocols.Select(p => p.ToSupportedProtocol<SupportedProtocol>()));
                }

                IReadOnlyList<ISupportedDataObject> IOpenSession.SupportedDataObjects => new List<ISupportedDataObject>(SupportedDataObjects);

                void IOpenSession.SetSupportedDataObjectsFrom(IEnumerable<ISupportedDataObject> supportedDataObjects)
                {
                    SupportedDataObjects = new List<SupportedDataObject>(supportedDataObjects.Select(d => d.ToSupportedDataObject<SupportedDataObject>()));
                }

                string IOpenSession.RawSessionId => new UuidGuidSource(SessionId).RawUuid;

                bool IOpenSession.IsSessionIdValid => new UuidGuidSource(SessionId).IsUuidValidGuid;

                Guid IOpenSession.SessionId { get { return new UuidGuidSource(SessionId).UuidGuid; } set { SessionId = value.ToUuid<Uuid>(); } }

                IReadOnlyDataValueDictionary IOpenSession.EndpointCapabilities
                {
                    get { return EndpointCapabilities.ToDataValueDictionary(); }
                }

                IDataValueDictionary IOpenSession.GetOrCreateEndpointCapabilities()
                {
                    if (EndpointCapabilities == null)
                        EndpointCapabilities = new Dictionary<string, DataValue>();

                    return EndpointCapabilities.ToDataValueDictionary();
                }

                void IOpenSession.SetEndpointCapabilitiesFrom(IReadOnlyDictionary<string, IDataValue> dictionary)
                {
                    EndpointCapabilities = dictionary.ToValueDictionary<DataValue>();
                }
            }

            public partial class CloseSession : ICloseSession { }
        }

        namespace GrowingObjectNotification
        {
            public partial class PartsChanged : IRequestUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource RequestUuidGuid => new UuidGuidSource(RequestUuid);
            }

            public partial class PartsDeleted : IRequestUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource RequestUuidGuid => new UuidGuidSource(RequestUuid);
            }

            public partial class PartsReplacedByRange : IRequestUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource RequestUuidGuid => new UuidGuidSource(RequestUuid);
            }

            public partial class PartSubscriptionEnded : IRequestUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource RequestUuidGuid => new UuidGuidSource(RequestUuid);
            }

            public partial class UnsubscribePartNotification : IRequestUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource RequestUuidGuid => new UuidGuidSource(RequestUuid);
            }
        }

        namespace Store
        {
            public partial class Chunk : IBlobIdGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource BlobIdGuid => new UuidGuidSource(BlobId);
            }
        }

        namespace StoreNotification
        {
            public partial class Chunk : IBlobIdGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource BlobIdGuid => new UuidGuidSource(BlobId);
            }

            public partial class ObjectAccessRevoked : IRequestUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource RequestUuidGuid => new UuidGuidSource(RequestUuid);
            }

            public partial class ObjectActiveStatusChanged : IRequestUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource RequestUuidGuid => new UuidGuidSource(RequestUuid);
            }

            public partial class ObjectChanged : IRequestUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource RequestUuidGuid => new UuidGuidSource(RequestUuid);
            }

            public partial class ObjectDeleted : IRequestUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource RequestUuidGuid => new UuidGuidSource(RequestUuid);
            }

            public partial class SubscriptionEnded : IRequestUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource RequestUuidGuid => new UuidGuidSource(RequestUuid);
            }

            public partial class UnsubscribeNotifications : IRequestUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource RequestUuidGuid => new UuidGuidSource(RequestUuid);
            }
        }

        namespace StoreQuery
        {
            public partial class Chunk : IBlobIdGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource BlobIdGuid => new UuidGuidSource(BlobId);
            }
        }

        namespace Transaction
        {
            public partial class CommitTransaction : ITransactionUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource TransactionUuidGuid => new UuidGuidSource(TransactionUuid);
            }

            public partial class CommitTransactionResponse : ITransactionUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource TransactionUuidGuid => new UuidGuidSource(TransactionUuid);
            }

            public partial class RollbackTransaction : ITransactionUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource TransactionUuidGuid => new UuidGuidSource(TransactionUuid);
            }

            public partial class RollbackTransactionResponse : ITransactionUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource TransactionUuidGuid => new UuidGuidSource(TransactionUuid);
            }

            public partial class StartTransactionResponse : ITransactionUuidGuidSource
            {
                [JsonIgnore]
                public IUuidGuidSource TransactionUuidGuid => new UuidGuidSource(TransactionUuid);
            }
        }
    }
}
