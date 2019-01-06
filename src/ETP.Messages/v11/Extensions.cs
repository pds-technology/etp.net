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

using System.Collections;
using System.Collections.Generic;
using Energistics.Etp.Common.Datatypes;
using Energistics.Etp.Common.Datatypes.ChannelData;
using Energistics.Etp.Common.Datatypes.Object;
using Energistics.Etp.Common.Protocol.Core;
using Newtonsoft.Json;

namespace Energistics.Etp.v11
{
    namespace Datatypes
    {
        namespace ChannelData
        {
            public partial class ChannelMetadataRecord : IChannelMetadataRecord
            {
                int IChannelMetadataRecord.Status
                {
                    get { return (int) Status; }
                    set { Status = (ChannelStatuses) value; }
                }

                IList IChannelMetadataRecord.Indexes
                {
                    get { return Indexes as IList; }
                    set { Indexes = value as IList<IndexMetadataRecord>; }
                }

                IDictionary IChannelMetadataRecord.CustomData
                {
                    get { return CustomData as IDictionary; }
                    set { CustomData = value as IDictionary<string, DataValue>; }
                }

                IDataObject IChannelMetadataRecord.DomainObject
                {
                    get { return DomainObject; }
                    set { DomainObject = (Object.DataObject)value; }
                }

                [JsonIgnore]
                public IList AttributeMetadata
                {
                    get { return null; }
                    set { }
                }
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
                    set { Value = value as DataValue; }
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
                public int IndexKind
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
                public object StartIndex
                {
                    get { return null; }
                    set { }
                }

                [JsonIgnore]
                public object EndIndex
                {
                    get { return null; }
                    set { }
                }

                IDictionary IIndexMetadataRecord.CustomData
                {
                    get { return CustomData as IDictionary; }
                    set { CustomData = value as IDictionary<string, DataValue>; }
                }
            }

            public partial class StreamingStartIndex : IStreamingStartIndex { }
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
                public int? TargetCount
                {
                    get { return HasChildren < 0 ? (int?) null : HasChildren; }
                    set { HasChildren = value ?? -1; }
                }

                long? IResource.LastChanged
                {
                    get { return LastChanged < 0 ? (long?) null : LastChanged; }
                    set { LastChanged = value ?? -1; }
                }
            }
        }

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
                set { AttributeValue = value as DataValue; }
            }
        }

        public partial class DataValue : IDataValue { }

        public partial class MessageHeader : IMessageHeader { }

        public partial class SupportedProtocol : ISupportedProtocol
        {
            IDictionary ISupportedProtocol.ProtocolCapabilities
            {
                get { return ProtocolCapabilities as IDictionary; }
                set { ProtocolCapabilities = value as IDictionary<string, DataValue>; }
            }
        }
    }

    namespace Protocol
    {
        namespace Core
        {
            public partial class Acknowledge : IAcknowledge { }

            public partial class ProtocolException : IProtocolException { }
        }
    }
}
