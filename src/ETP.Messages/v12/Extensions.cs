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
using Energistics.Etp.Common.Datatypes;
using Energistics.Etp.Common.Datatypes.ChannelData;
using Energistics.Etp.Common.Datatypes.Object;
using Energistics.Etp.Common.Protocol.Core;
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
                public string Uuid
                {
                    get { return null; }
                    set { }
                }

                [JsonIgnore]
                public long ChannelId
                {
                    get { return Id; }
                    set { Id = value; }
                }

                [JsonIgnore]
                public string ChannelUri
                {
                    get { return Uri; }
                    set { Uri = value; }
                }

                int IChannelMetadataRecord.Status
                {
                    get { return (int)Status; }
                    set { Status = (ChannelStatusKind)value; }
                }

                [JsonIgnore]
                public long? StartIndex
                {
                    get { return null; }
                    set { }
                }

                [JsonIgnore]
                public long? EndIndex
                {
                    get { return null; }
                    set { }
                }

                [JsonIgnore]
                public string ContentType
                {
                    get { return null; }
                    set { }
                }

                [JsonIgnore]
                public string Description
                {
                    get { return null; }
                    set { }
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

                [JsonIgnore]
                public IDataObject DomainObject
                {
                    get { return null; }
                    set { }
                }

                IList IChannelMetadataRecord.AttributeMetadata
                {
                    get { return AttributeMetadata as IList; }
                    set { AttributeMetadata = value as IList<AttributeMetadataRecord>; }
                }
            }

            public partial class ChannelRangeInfo : IChannelRangeInfo
            {
                [JsonIgnore]
                public object StartIndex
                {
                    get { return EnsureInterval().StartIndex.Item; }
                    set { EnsureInterval().StartIndex.Item = value; }
                }

                [JsonIgnore]
                public object EndIndex
                {
                    get { return EnsureInterval().EndIndex.Item; }
                    set { EnsureInterval().EndIndex.Item = value; }
                }

                [JsonIgnore]
                public string Uom
                {
                    get { return EnsureInterval().Uom; }
                    set { EnsureInterval().Uom = value; }
                }

                [JsonIgnore]
                public string DepthDatum
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
                public string Mnemonic
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
                public object StartIndex
                {
                    get { return EnsureInterval().StartIndex.Item; }
                    set { EnsureInterval().StartIndex.Item = value; }
                }

                [JsonIgnore]
                public object EndIndex
                {
                    get { return EnsureInterval().EndIndex.Item; }
                    set { EnsureInterval().EndIndex.Item = value; }
                }

                [JsonIgnore]
                public string Uom
                {
                    get { return EnsureInterval().Uom; }
                    set { EnsureInterval().Uom = value; }
                }

                [JsonIgnore]
                public string DepthDatum
                {
                    get { return EnsureInterval().DepthDatum; }
                    set { EnsureInterval().DepthDatum = value; }
                }

                [JsonIgnore]
                public string Uri
                {
                    get { return null; }
                    set { }
                }

                [JsonIgnore]
                public string Description
                {
                    get { return null; }
                    set { }
                }

                [JsonIgnore]
                public string TimeDatum
                {
                    get { return null; }
                    set { }
                }

                [JsonIgnore]
                public int Scale
                {
                    get { return 0; }
                    set { }
                }

                [JsonIgnore]
                public IDictionary CustomData
                {
                    get { return null; }
                    set { }
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

        namespace Object
        {
            public partial class DataObject : IDataObject
            {
                IResource IDataObject.Resource
                {
                    get { return Resource; }
                    set { Resource = (Resource) value; }
                }

                [JsonIgnore]
                public string ContentEncoding
                {
                    get { return null; }
                    set { }
                }
            }

            public partial class Resource : IResource
            {
                [JsonIgnore]
                public string Uuid
                {
                    get { return null; }
                    set { }
                }

                string IResource.ResourceType
                {
                    get { return ResourceType.ToString(); }
                    set
                    {
                        ResourceKind enumValue;
                        Enum.TryParse(value, out enumValue);
                        ResourceType = enumValue;
                    }
                }

                [JsonIgnore]
                public bool ChannelSubscribable
                {
                    get { return false; }
                    set { }
                }
            }
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
                set { AttributeValue = value as DataValue; }
            }
        }

        public partial class DataValue : IDataValue { }

        public partial class IndexValue : IIndexValue { }

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
