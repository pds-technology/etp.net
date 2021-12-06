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
using Energistics.Avro.Encoding;
using Energistics.Avro.Encoding.Converter;
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
                    get { return this.DataKind.ToString("F"); }
                    set
                    {
                        Enum.TryParse<ChannelDataKind>(value, out var dataType);
                        this.DataKind = dataType;
                    }
                }

                private static readonly Regex _UuidRegex = new Regex(@"[^(]*\(([^)]*)\)", RegexOptions.Compiled | RegexOptions.CultureInvariant);

                [JsonIgnore]
                Guid IUuidSource.Uuid
                {
                    get
                    {
                        if (Uri == null) return default(Guid);

                        var match = _UuidRegex.Match(Uri);
                        if (!match.Success)
                            return default(Guid);

                        return Guid.Parse(match.Groups[1].Value);
                    }
                }
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
                    get { return Uom; }
                    set { Uom = value; }
                }

                [JsonIgnore]
                string IIndexMetadataRecord.DepthDatum
                {
                    get { return DepthDatum; }
                    set { DepthDatum = value; }
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
            public partial class DataObject : IDataObject, IBlobIdSource
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
            }

            public partial class Resource : IResource
            {
                private static readonly Regex _UuidRegex = new Regex(@"[^(]*\(([^)]*)\)", RegexOptions.Compiled | RegexOptions.CultureInvariant);

                [JsonIgnore]
                Guid IUuidSource.Uuid
                {
                    get
                    {
                        if (Uri == null) return default(Guid);

                        var match = _UuidRegex.Match(Uri);
                        if (!match.Success)
                            return default(Guid);

                        return Guid.Parse(match.Groups[1].Value);
                    }
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
                DateTime? IResource.StoreLastWrite
                {
                    get { return StoreLastWrite; }
                    set { StoreLastWrite = value ?? AvroConverter.UtcMinDateTime; }
                }

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

            public partial class SubscriptionInfo : IRequestUuidSource
            {
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

        public partial class SupportedDataObject : ISupportedDataObject
        {
            [JsonIgnore]
            EtpVersion ISupportedDataObject.EtpVersion => EtpVersion.v12;

            [JsonIgnore]
            IDataObjectType ISupportedDataObject.QualifiedType { get { return new EtpDataObjectType(QualifiedType); } set { QualifiedType = value.DataObjectType.ToString(); } }

            [JsonIgnore]
            IReadOnlyDataValueDictionary ISupportedDataObject.DataObjectCapabilities
            {
                get { return DataObjectCapabilities.ToDataValueDictionary(); }
            }

            IDataValueDictionary ISupportedDataObject.GetOrCreateDataObjectCapabilities()
            {
                if (DataObjectCapabilities == null)
                    DataObjectCapabilities = new Dictionary<string, DataValue>();

                return DataObjectCapabilities.ToDataValueDictionary();
            }

            void ISupportedDataObject.SetDataObjectCapabilitiesFrom(IReadOnlyDictionary<string, IDataValue> dictionary)
            {
                DataObjectCapabilities = dictionary.ToValueDictionary<DataValue>();
            }
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
            public partial class CancelGetFrame : IRequestUuidSource
            {
            }

            public partial class GetFrame : IRequestUuidSource
            {
            }
        }

        namespace ChannelDataLoad
        {
            public partial class ReplaceRange
            {
                private IEnumerable<ReplaceRange> Split(long targetSize, IAvroByteCounter byteCounter)
                {
                    if (Data.Count == 0)
                        yield return this;

                    var itemCount = 0;
                    var enumerator = Data.GetEnumerator();
                    var prevIndexes = Data[0].Indexes.ToList();
                    var prevIndexCount = prevIndexes.Count;
                    var first = true;

                    while (itemCount < Data.Count)
                    {
                        var copy = new Energistics.Etp.v12.Protocol.ChannelDataLoad.ReplaceRange
                        {
                            Data = new List<Energistics.Etp.v12.Datatypes.ChannelData.DataItem>(),
                        };
                        var added = false;
                        byteCounter.Reset();
                        while (byteCounter.ByteCount < targetSize && itemCount++ < Data.Count)
                        {
                            enumerator.MoveNext();
                            var v = enumerator.Current;
                            if (!added)
                            {
                                added = true;
                                if (!first)
                                {
                                    if (v.Indexes.Count == 0)
                                    {
                                        for (int i = 0; i < prevIndexCount; i++)
                                            v.Indexes.Add(prevIndexes[i]);
                                    }
                                    else
                                    {
                                        for (int i = 0; i < v.Indexes.Count; i++)
                                        {
                                            if (v.Indexes[i].Item == null && i < prevIndexCount)
                                                v.Indexes[i] = prevIndexes[i];
                                            else if (i < prevIndexCount)
                                                prevIndexes[i] = v.Indexes[i];
                                            else
                                                prevIndexes.Add(v.Indexes[i]);
                                        }
                                    }
                                    prevIndexCount = v.Indexes.Count;
                                }
                                copy.Data.Add(v);
                                byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.ChannelDataLoad.ReplaceRange>(copy);
                                first = false;
                                continue;
                            }
                            byteCounter.EncodeArrayItemSeparator();
                            if (v.Indexes.Count == 0)
                            {
                                for (int i = 0; i < prevIndexCount; i++)
                                    v.Indexes.Add(prevIndexes[i]);
                            }
                            else
                            {
                                for (int i = 0; i < v.Indexes.Count; i++)
                                {
                                    if (v.Indexes[i].Item == null && i < prevIndexCount)
                                        v.Indexes[i] = prevIndexes[i];
                                    else if (i < prevIndexCount)
                                        prevIndexes[i] = v.Indexes[i];
                                    else
                                        prevIndexes.Add(v.Indexes[i]);
                                }
                            }
                            prevIndexCount = v.Indexes.Count;
                            byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.DataItem>(v);
                            if (byteCounter.ByteCount <= targetSize)
                                copy.Data.Add(v);
                        }
                        yield return copy;
                    }
                }
            }

        }

        namespace ChannelSubscribe
        {
            public partial class CancelGetRanges: IRequestUuidSource
            {
            }

            public partial class GetRanges : IRequestUuidSource
            {
            }

            public partial class GetRangesResponse
            {
                private IEnumerable<GetRangesResponse> Split(long targetSize, IAvroByteCounter byteCounter)
                {
                    if (Data.Count == 0)
                        yield return this;

                    var itemCount = 0;
                    var enumerator = Data.GetEnumerator();
                    var prevIndexes = Data[0].Indexes.ToList();
                    var prevIndexCount = prevIndexes.Count;
                    var first = true;

                    while (itemCount < Data.Count)
                    {
                        var copy = new Energistics.Etp.v12.Protocol.ChannelSubscribe.GetRangesResponse
                        {
                            Data = new List<Energistics.Etp.v12.Datatypes.ChannelData.DataItem>(),
                        };
                        var added = false;
                        byteCounter.Reset();
                        while (byteCounter.ByteCount < targetSize && itemCount++ < Data.Count)
                        {
                            enumerator.MoveNext();
                            var v = enumerator.Current;
                            if (!added)
                            {
                                added = true;
                                if (!first)
                                {
                                    if (v.Indexes.Count == 0)
                                    {
                                        for (int i = 0; i < prevIndexCount; i++)
                                            v.Indexes.Add(prevIndexes[i]);
                                    }
                                    else
                                    {
                                        for (int i = 0; i < v.Indexes.Count; i++)
                                        {
                                            if (v.Indexes[i].Item == null && i < prevIndexCount)
                                                v.Indexes[i] = prevIndexes[i];
                                            else if (i < prevIndexCount)
                                                prevIndexes[i] = v.Indexes[i];
                                            else
                                                prevIndexes.Add(v.Indexes[i]);
                                        }
                                    }
                                    prevIndexCount = v.Indexes.Count;
                                }
                                copy.Data.Add(v);
                                byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.ChannelSubscribe.GetRangesResponse>(copy);
                                first = false;
                                continue;
                            }
                            byteCounter.EncodeArrayItemSeparator();
                            if (v.Indexes.Count == 0)
                            {
                                for (int i = 0; i < prevIndexCount; i++)
                                    v.Indexes.Add(prevIndexes[i]);
                            }
                            else
                            {
                                for (int i = 0; i < v.Indexes.Count; i++)
                                {
                                    if (v.Indexes[i].Item == null && i < prevIndexCount)
                                        v.Indexes[i] = prevIndexes[i];
                                    else if (i < prevIndexCount)
                                        prevIndexes[i] = v.Indexes[i];
                                    else
                                        prevIndexes.Add(v.Indexes[i]);
                                }
                            }
                            prevIndexCount = v.Indexes.Count;
                            byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.DataItem>(v);
                            if (byteCounter.ByteCount <= targetSize)
                                copy.Data.Add(v);
                        }
                        yield return copy;
                    }
                }
            }

            public partial class RangeReplaced
            {
                private IEnumerable<RangeReplaced> Split(long targetSize, IAvroByteCounter byteCounter)
                {
                    if (Data.Count == 0)
                        yield return this;

                    var itemCount = 0;
                    var enumerator = Data.GetEnumerator();
                    var prevIndexes = Data[0].Indexes.ToList();
                    var prevIndexCount = prevIndexes.Count;
                    var first = true;

                    while (itemCount < Data.Count)
                    {
                        var copy = new Energistics.Etp.v12.Protocol.ChannelSubscribe.RangeReplaced
                        {
                            Data = new List<Energistics.Etp.v12.Datatypes.ChannelData.DataItem>(),
                        };
                        var added = false;
                        byteCounter.Reset();
                        while (byteCounter.ByteCount < targetSize && itemCount++ < Data.Count)
                        {
                            enumerator.MoveNext();
                            var v = enumerator.Current;
                            if (!added)
                            {
                                added = true;
                                if (!first)
                                {
                                    if (v.Indexes.Count == 0)
                                    {
                                        for (int i = 0; i < prevIndexCount; i++)
                                            v.Indexes.Add(prevIndexes[i]);
                                    }
                                    else
                                    {
                                        for (int i = 0; i < v.Indexes.Count; i++)
                                        {
                                            if (v.Indexes[i].Item == null && i < prevIndexCount)
                                                v.Indexes[i] = prevIndexes[i];
                                            else if (i < prevIndexCount)
                                                prevIndexes[i] = v.Indexes[i];
                                            else
                                                prevIndexes.Add(v.Indexes[i]);
                                        }
                                    }
                                    prevIndexCount = v.Indexes.Count;
                                }
                                copy.Data.Add(v);
                                byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.ChannelSubscribe.RangeReplaced>(copy);
                                first = false;
                                continue;
                            }
                            byteCounter.EncodeArrayItemSeparator();
                            if (v.Indexes.Count == 0)
                            {
                                for (int i = 0; i < prevIndexCount; i++)
                                    v.Indexes.Add(prevIndexes[i]);
                            }
                            else
                            {
                                for (int i = 0; i < v.Indexes.Count; i++)
                                {
                                    if (v.Indexes[i].Item == null && i < prevIndexCount)
                                        v.Indexes[i] = prevIndexes[i];
                                    else if (i < prevIndexCount)
                                        prevIndexes[i] = v.Indexes[i];
                                    else
                                        prevIndexes.Add(v.Indexes[i]);
                                }
                            }
                            prevIndexCount = v.Indexes.Count;
                            byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.DataItem>(v);
                            if (byteCounter.ByteCount <= targetSize)
                                copy.Data.Add(v);
                        }
                        yield return copy;
                    }
                }
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

            public partial class Ping : IPing { }

            public partial class Pong : IPong { }
        }

        namespace GrowingObjectNotification
        {
            public partial class PartsChanged : IRequestUuidSource
            {
            }

            public partial class PartsDeleted : IRequestUuidSource
            {
            }

            public partial class PartsReplacedByRange : IRequestUuidSource
            {
            }

            public partial class PartSubscriptionEnded : IRequestUuidSource
            {
            }

            public partial class UnsubscribePartNotification : IRequestUuidSource
            {
            }
        }

        namespace Store
        {
            public partial class Chunk : IBlobIdSource
            {
                [JsonIgnore]
                Guid? IBlobIdSource.BlobId => BlobId;
            }
        }

        namespace StoreNotification
        {
            public partial class Chunk : IBlobIdSource
            {
                [JsonIgnore]
                Guid? IBlobIdSource.BlobId => BlobId;
            }

            public partial class ObjectAccessRevoked : IRequestUuidSource
            {
            }

            public partial class ObjectActiveStatusChanged : IRequestUuidSource
            {
            }

            public partial class ObjectChanged : IRequestUuidSource
            {
            }

            public partial class ObjectDeleted : IRequestUuidSource
            {
            }

            public partial class SubscriptionEnded : IRequestUuidSource
            {
            }

            public partial class UnsubscribeNotifications : IRequestUuidSource
            {
            }
        }

        namespace StoreQuery
        {
            public partial class Chunk : IBlobIdSource
            {
                [JsonIgnore]
                Guid? IBlobIdSource.BlobId => BlobId;
            }
        }

        namespace Transaction
        {
            public partial class CommitTransaction : ITransactionUuidSource
            {
            }

            public partial class CommitTransactionResponse : ITransactionUuidSource
            {
            }

            public partial class RollbackTransaction : ITransactionUuidSource
            {
            }

            public partial class RollbackTransactionResponse : ITransactionUuidSource
            {
            }

            public partial class StartTransactionResponse : ITransactionUuidSource
            {
            }
        }
    }
}
