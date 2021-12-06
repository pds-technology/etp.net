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
using Energistics.Avro.Encoding;
using Energistics.Etp.Common;

namespace Energistics.Etp.v12.Protocol.Core
{
    public partial class RequestSession : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Core.RequestSession>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.Core.RequestSession> IEtpMessageBody<Energistics.Etp.v12.Protocol.Core.RequestSession>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class OpenSession : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Core.OpenSession>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.Core.OpenSession> IEtpMessageBody<Energistics.Etp.v12.Protocol.Core.OpenSession>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class CloseSession : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Core.CloseSession>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.Core.CloseSession> IEtpMessageBody<Energistics.Etp.v12.Protocol.Core.CloseSession>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class Authorize : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Core.Authorize>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.Core.Authorize> IEtpMessageBody<Energistics.Etp.v12.Protocol.Core.Authorize>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class AuthorizeResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Core.AuthorizeResponse>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.Core.AuthorizeResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.Core.AuthorizeResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class Ping : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Core.Ping>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.Core.Ping> IEtpMessageBody<Energistics.Etp.v12.Protocol.Core.Ping>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class Pong : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Core.Pong>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.Core.Pong> IEtpMessageBody<Energistics.Etp.v12.Protocol.Core.Pong>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class ProtocolException : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Core.ProtocolException>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.Core.ProtocolException> IEtpMessageBody<Energistics.Etp.v12.Protocol.Core.ProtocolException>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Errors.GetEnumerator();
            while (itemCount < Errors.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.Core.ProtocolException
                {
                    Error = Error,
                    Errors = new Dictionary<string, Energistics.Etp.v12.Datatypes.ErrorInfo>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Errors.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Errors[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.Core.ProtocolException>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ErrorInfo>(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Errors[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
    public partial class Acknowledge : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Core.Acknowledge>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.Core.Acknowledge> IEtpMessageBody<Energistics.Etp.v12.Protocol.Core.Acknowledge>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
}
namespace Energistics.Etp.v12.Protocol.ChannelStreaming
{
    public partial class ChannelMetadata : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelStreaming.ChannelMetadata>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelStreaming.ChannelMetadata> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelStreaming.ChannelMetadata>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class ChannelData : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelStreaming.ChannelData>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelStreaming.ChannelData> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelStreaming.ChannelData>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class StartStreaming : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelStreaming.StartStreaming>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelStreaming.StartStreaming> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelStreaming.StartStreaming>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class StopStreaming : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelStreaming.StopStreaming>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelStreaming.StopStreaming> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelStreaming.StopStreaming>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class TruncateChannels : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelStreaming.TruncateChannels>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelStreaming.TruncateChannels> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelStreaming.TruncateChannels>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
}
namespace Energistics.Etp.v12.Protocol.ChannelDataFrame
{
    public partial class GetFrameMetadata : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameMetadata>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameMetadata> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameMetadata>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetFrameMetadataResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameMetadataResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameMetadataResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameMetadataResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var itemCount2 = 0;
            var enumerator = Indexes.GetEnumerator();
            var enumerator2 = Channels.GetEnumerator();
            while (itemCount < Indexes.Count && itemCount2 < Channels.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameMetadataResponse
                {
                    Uri = Uri,
                    Indexes = new List<Energistics.Etp.v12.Datatypes.ChannelData.IndexMetadataRecord>(),
                    Channels = new List<Energistics.Etp.v12.Datatypes.ChannelData.FrameChannelMetadataRecord>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Indexes.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Indexes.Add(v);
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameMetadataResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeArrayItemSeparator();
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.IndexMetadataRecord>(v);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Indexes.Add(v);
                }
                while (byteCounter.ByteCount < targetSize && itemCount2++ < Channels.Count)
                {
                    enumerator2.MoveNext();
                    var v = enumerator2.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Channels.Add(v);
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameMetadataResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeArrayItemSeparator();
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.FrameChannelMetadataRecord>(v);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Channels.Add(v);
                }
                yield return copy;
            }
        }
    }
    public partial class GetFrame : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrame>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrame> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrame>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetFrameResponseHeader : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameResponseHeader>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameResponseHeader> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameResponseHeader>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class CancelGetFrame : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataFrame.CancelGetFrame>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelDataFrame.CancelGetFrame> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataFrame.CancelGetFrame>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetFrameResponseRows : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameResponseRows>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameResponseRows> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameResponseRows>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Frame.GetEnumerator();
            while (itemCount < Frame.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameResponseRows
                {
                    Frame = new List<Energistics.Etp.v12.Datatypes.ChannelData.FrameRow>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Frame.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Frame.Add(v);
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameResponseRows>(copy);
                        continue;
                    }
                    byteCounter.EncodeArrayItemSeparator();
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.FrameRow>(v);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Frame.Add(v);
                }
                yield return copy;
            }
        }
    }
}
namespace Energistics.Etp.v12.Protocol.Discovery
{
    public partial class GetResources : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Discovery.GetResources>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.Discovery.GetResources> IEtpMessageBody<Energistics.Etp.v12.Protocol.Discovery.GetResources>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetResourcesResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Discovery.GetResourcesResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.Discovery.GetResourcesResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.Discovery.GetResourcesResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Resources.GetEnumerator();
            while (itemCount < Resources.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.Discovery.GetResourcesResponse
                {
                    Resources = new List<Energistics.Etp.v12.Datatypes.Object.Resource>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Resources.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Resources.Add(v);
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.Discovery.GetResourcesResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeArrayItemSeparator();
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.Resource>(v);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Resources.Add(v);
                }
                yield return copy;
            }
        }
    }
    public partial class GetDeletedResources : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Discovery.GetDeletedResources>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.Discovery.GetDeletedResources> IEtpMessageBody<Energistics.Etp.v12.Protocol.Discovery.GetDeletedResources>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetDeletedResourcesResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Discovery.GetDeletedResourcesResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.Discovery.GetDeletedResourcesResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.Discovery.GetDeletedResourcesResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = DeletedResources.GetEnumerator();
            while (itemCount < DeletedResources.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.Discovery.GetDeletedResourcesResponse
                {
                    DeletedResources = new List<Energistics.Etp.v12.Datatypes.Object.DeletedResource>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < DeletedResources.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.DeletedResources.Add(v);
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.Discovery.GetDeletedResourcesResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeArrayItemSeparator();
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.DeletedResource>(v);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.DeletedResources.Add(v);
                }
                yield return copy;
            }
        }
    }
    public partial class GetResourcesEdgesResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Discovery.GetResourcesEdgesResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.Discovery.GetResourcesEdgesResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.Discovery.GetResourcesEdgesResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Edges.GetEnumerator();
            while (itemCount < Edges.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.Discovery.GetResourcesEdgesResponse
                {
                    Edges = new List<Energistics.Etp.v12.Datatypes.Object.Edge>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Edges.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Edges.Add(v);
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.Discovery.GetResourcesEdgesResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeArrayItemSeparator();
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.Edge>(v);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Edges.Add(v);
                }
                yield return copy;
            }
        }
    }
}
namespace Energistics.Etp.v12.Protocol.Store
{
    public partial class GetDataObjects : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Store.GetDataObjects>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.Store.GetDataObjects> IEtpMessageBody<Energistics.Etp.v12.Protocol.Store.GetDataObjects>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class PutDataObjects : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Store.PutDataObjects>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.Store.PutDataObjects> IEtpMessageBody<Energistics.Etp.v12.Protocol.Store.PutDataObjects>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = DataObjects.GetEnumerator();
            while (itemCount < DataObjects.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.Store.PutDataObjects
                {
                    DataObjects = new Dictionary<string, Energistics.Etp.v12.Datatypes.Object.DataObject>(),
                    PruneContainedObjects = PruneContainedObjects,
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < DataObjects.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.DataObjects[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.Store.PutDataObjects>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.DataObject>(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.DataObjects[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
    public partial class DeleteDataObjects : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Store.DeleteDataObjects>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.Store.DeleteDataObjects> IEtpMessageBody<Energistics.Etp.v12.Protocol.Store.DeleteDataObjects>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetDataObjectsResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Store.GetDataObjectsResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.Store.GetDataObjectsResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.Store.GetDataObjectsResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = DataObjects.GetEnumerator();
            while (itemCount < DataObjects.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.Store.GetDataObjectsResponse
                {
                    DataObjects = new Dictionary<string, Energistics.Etp.v12.Datatypes.Object.DataObject>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < DataObjects.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.DataObjects[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.Store.GetDataObjectsResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.DataObject>(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.DataObjects[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
    public partial class Chunk : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Store.Chunk>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.Store.Chunk> IEtpMessageBody<Energistics.Etp.v12.Protocol.Store.Chunk>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class PutDataObjectsResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Store.PutDataObjectsResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.Store.PutDataObjectsResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.Store.PutDataObjectsResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Success.GetEnumerator();
            while (itemCount < Success.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.Store.PutDataObjectsResponse
                {
                    Success = new Dictionary<string, Energistics.Etp.v12.Datatypes.Object.PutResponse>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Success.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Success[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.Store.PutDataObjectsResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.PutResponse>(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Success[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
    public partial class DeleteDataObjectsResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Store.DeleteDataObjectsResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.Store.DeleteDataObjectsResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.Store.DeleteDataObjectsResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = DeletedUris.GetEnumerator();
            while (itemCount < DeletedUris.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.Store.DeleteDataObjectsResponse
                {
                    DeletedUris = new Dictionary<string, Energistics.Etp.v12.Datatypes.ArrayOfString>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < DeletedUris.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.DeletedUris[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.Store.DeleteDataObjectsResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ArrayOfString>(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.DeletedUris[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
}
namespace Energistics.Etp.v12.Protocol.StoreNotification
{
    public partial class ObjectChanged : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreNotification.ObjectChanged>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.StoreNotification.ObjectChanged> IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreNotification.ObjectChanged>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class ObjectDeleted : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreNotification.ObjectDeleted>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.StoreNotification.ObjectDeleted> IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreNotification.ObjectDeleted>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class UnsubscribeNotifications : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreNotification.UnsubscribeNotifications>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.StoreNotification.UnsubscribeNotifications> IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreNotification.UnsubscribeNotifications>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class ObjectAccessRevoked : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreNotification.ObjectAccessRevoked>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.StoreNotification.ObjectAccessRevoked> IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreNotification.ObjectAccessRevoked>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class SubscribeNotifications : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreNotification.SubscribeNotifications>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.StoreNotification.SubscribeNotifications> IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreNotification.SubscribeNotifications>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class SubscriptionEnded : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreNotification.SubscriptionEnded>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.StoreNotification.SubscriptionEnded> IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreNotification.SubscriptionEnded>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class UnsolicitedStoreNotifications : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreNotification.UnsolicitedStoreNotifications>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.StoreNotification.UnsolicitedStoreNotifications> IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreNotification.UnsolicitedStoreNotifications>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class Chunk : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreNotification.Chunk>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.StoreNotification.Chunk> IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreNotification.Chunk>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class SubscribeNotificationsResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreNotification.SubscribeNotificationsResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.StoreNotification.SubscribeNotificationsResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreNotification.SubscribeNotificationsResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Success.GetEnumerator();
            while (itemCount < Success.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.StoreNotification.SubscribeNotificationsResponse
                {
                    Success = new Dictionary<string, string>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Success.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Success[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.StoreNotification.SubscribeNotificationsResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeString(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Success[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
    public partial class ObjectActiveStatusChanged : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreNotification.ObjectActiveStatusChanged>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.StoreNotification.ObjectActiveStatusChanged> IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreNotification.ObjectActiveStatusChanged>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
}
namespace Energistics.Etp.v12.Protocol.GrowingObject
{
    public partial class DeleteParts : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.DeleteParts>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObject.DeleteParts> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.DeleteParts>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetParts : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.GetParts>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObject.GetParts> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.GetParts>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetPartsByRange : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.GetPartsByRange>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObject.GetPartsByRange> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.GetPartsByRange>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class PutParts : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.PutParts>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObject.PutParts> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.PutParts>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetPartsResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.GetPartsResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObject.GetPartsResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.GetPartsResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Parts.GetEnumerator();
            while (itemCount < Parts.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.GrowingObject.GetPartsResponse
                {
                    Uri = Uri,
                    Format = Format,
                    Parts = new Dictionary<string, Energistics.Etp.v12.Datatypes.Object.ObjectPart>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Parts.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Parts[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.GrowingObject.GetPartsResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.ObjectPart>(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Parts[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
    public partial class ReplacePartsByRange : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.ReplacePartsByRange>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObject.ReplacePartsByRange> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.ReplacePartsByRange>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Parts.GetEnumerator();
            while (itemCount < Parts.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.GrowingObject.ReplacePartsByRange
                {
                    Uri = Uri,
                    DeleteInterval = DeleteInterval,
                    IncludeOverlappingIntervals = IncludeOverlappingIntervals,
                    Format = Format,
                    Parts = new List<Energistics.Etp.v12.Datatypes.Object.ObjectPart>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Parts.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Parts.Add(v);
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.GrowingObject.ReplacePartsByRange>(copy);
                        continue;
                    }
                    byteCounter.EncodeArrayItemSeparator();
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.ObjectPart>(v);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Parts.Add(v);
                }
                yield return copy;
            }
        }
    }
    public partial class GetPartsMetadata : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.GetPartsMetadata>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObject.GetPartsMetadata> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.GetPartsMetadata>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetPartsMetadataResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.GetPartsMetadataResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObject.GetPartsMetadataResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.GetPartsMetadataResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Metadata.GetEnumerator();
            while (itemCount < Metadata.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.GrowingObject.GetPartsMetadataResponse
                {
                    Metadata = new Dictionary<string, Energistics.Etp.v12.Datatypes.Object.PartsMetadataInfo>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Metadata.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Metadata[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.GrowingObject.GetPartsMetadataResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.PartsMetadataInfo>(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Metadata[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
    public partial class GetPartsByRangeResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.GetPartsByRangeResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObject.GetPartsByRangeResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.GetPartsByRangeResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Parts.GetEnumerator();
            while (itemCount < Parts.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.GrowingObject.GetPartsByRangeResponse
                {
                    Uri = Uri,
                    Format = Format,
                    Parts = new List<Energistics.Etp.v12.Datatypes.Object.ObjectPart>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Parts.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Parts.Add(v);
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.GrowingObject.GetPartsByRangeResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeArrayItemSeparator();
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.ObjectPart>(v);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Parts.Add(v);
                }
                yield return copy;
            }
        }
    }
    public partial class DeletePartsResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.DeletePartsResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObject.DeletePartsResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.DeletePartsResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Success.GetEnumerator();
            while (itemCount < Success.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.GrowingObject.DeletePartsResponse
                {
                    Success = new Dictionary<string, string>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Success.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Success[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.GrowingObject.DeletePartsResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeString(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Success[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
    public partial class PutPartsResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.PutPartsResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObject.PutPartsResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.PutPartsResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Success.GetEnumerator();
            while (itemCount < Success.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.GrowingObject.PutPartsResponse
                {
                    Success = new Dictionary<string, string>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Success.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Success[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.GrowingObject.PutPartsResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeString(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Success[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
    public partial class GetGrowingDataObjectsHeader : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.GetGrowingDataObjectsHeader>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObject.GetGrowingDataObjectsHeader> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.GetGrowingDataObjectsHeader>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetGrowingDataObjectsHeaderResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.GetGrowingDataObjectsHeaderResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObject.GetGrowingDataObjectsHeaderResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.GetGrowingDataObjectsHeaderResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = DataObjects.GetEnumerator();
            while (itemCount < DataObjects.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.GrowingObject.GetGrowingDataObjectsHeaderResponse
                {
                    DataObjects = new Dictionary<string, Energistics.Etp.v12.Datatypes.Object.DataObject>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < DataObjects.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.DataObjects[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.GrowingObject.GetGrowingDataObjectsHeaderResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.DataObject>(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.DataObjects[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
    public partial class PutGrowingDataObjectsHeader : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.PutGrowingDataObjectsHeader>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObject.PutGrowingDataObjectsHeader> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.PutGrowingDataObjectsHeader>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class PutGrowingDataObjectsHeaderResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.PutGrowingDataObjectsHeaderResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObject.PutGrowingDataObjectsHeaderResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.PutGrowingDataObjectsHeaderResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Success.GetEnumerator();
            while (itemCount < Success.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.GrowingObject.PutGrowingDataObjectsHeaderResponse
                {
                    Success = new Dictionary<string, string>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Success.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Success[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.GrowingObject.PutGrowingDataObjectsHeaderResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeString(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Success[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
    public partial class ReplacePartsByRangeResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.ReplacePartsByRangeResponse>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObject.ReplacePartsByRangeResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.ReplacePartsByRangeResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetChangeAnnotations : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.GetChangeAnnotations>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObject.GetChangeAnnotations> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.GetChangeAnnotations>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetChangeAnnotationsResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.GetChangeAnnotationsResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObject.GetChangeAnnotationsResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObject.GetChangeAnnotationsResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Changes.GetEnumerator();
            while (itemCount < Changes.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.GrowingObject.GetChangeAnnotationsResponse
                {
                    Changes = new Dictionary<string, Energistics.Etp.v12.Datatypes.Object.ChangeResponseInfo>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Changes.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Changes[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.GrowingObject.GetChangeAnnotationsResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.ChangeResponseInfo>(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Changes[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
}
namespace Energistics.Etp.v12.Protocol.GrowingObjectNotification
{
    public partial class PartsChanged : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsChanged>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsChanged> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsChanged>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class PartsDeleted : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsDeleted>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsDeleted> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsDeleted>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class UnsubscribePartNotification : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObjectNotification.UnsubscribePartNotification>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObjectNotification.UnsubscribePartNotification> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObjectNotification.UnsubscribePartNotification>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class PartsReplacedByRange : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsReplacedByRange>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsReplacedByRange> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsReplacedByRange>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Parts.GetEnumerator();
            while (itemCount < Parts.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsReplacedByRange
                {
                    Uri = Uri,
                    RequestUuid = RequestUuid,
                    ChangeTime = ChangeTime,
                    DeletedInterval = DeletedInterval,
                    IncludeOverlappingIntervals = IncludeOverlappingIntervals,
                    Format = Format,
                    Parts = new List<Energistics.Etp.v12.Datatypes.Object.ObjectPart>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Parts.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Parts.Add(v);
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsReplacedByRange>(copy);
                        continue;
                    }
                    byteCounter.EncodeArrayItemSeparator();
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.ObjectPart>(v);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Parts.Add(v);
                }
                yield return copy;
            }
        }
    }
    public partial class SubscribePartNotifications : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObjectNotification.SubscribePartNotifications>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObjectNotification.SubscribePartNotifications> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObjectNotification.SubscribePartNotifications>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class PartSubscriptionEnded : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartSubscriptionEnded>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartSubscriptionEnded> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartSubscriptionEnded>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class UnsolicitedPartNotifications : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObjectNotification.UnsolicitedPartNotifications>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObjectNotification.UnsolicitedPartNotifications> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObjectNotification.UnsolicitedPartNotifications>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class SubscribePartNotificationsResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObjectNotification.SubscribePartNotificationsResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObjectNotification.SubscribePartNotificationsResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObjectNotification.SubscribePartNotificationsResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Success.GetEnumerator();
            while (itemCount < Success.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.GrowingObjectNotification.SubscribePartNotificationsResponse
                {
                    Success = new Dictionary<string, string>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Success.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Success[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.GrowingObjectNotification.SubscribePartNotificationsResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeString(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Success[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
}
namespace Energistics.Etp.v12.Protocol.DataArray
{
    public partial class GetDataArraysResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.GetDataArraysResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.DataArray.GetDataArraysResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.GetDataArraysResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = DataArrays.GetEnumerator();
            while (itemCount < DataArrays.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.DataArray.GetDataArraysResponse
                {
                    DataArrays = new Dictionary<string, Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArray>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < DataArrays.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.DataArrays[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.DataArray.GetDataArraysResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArray>(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.DataArrays[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
    public partial class GetDataArrays : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.GetDataArrays>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.DataArray.GetDataArrays> IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.GetDataArrays>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetDataSubarrays : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.GetDataSubarrays>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.DataArray.GetDataSubarrays> IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.GetDataSubarrays>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class PutDataArrays : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.PutDataArrays>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.DataArray.PutDataArrays> IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.PutDataArrays>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class PutDataSubarrays : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.PutDataSubarrays>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.DataArray.PutDataSubarrays> IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.PutDataSubarrays>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetDataArrayMetadata : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.GetDataArrayMetadata>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.DataArray.GetDataArrayMetadata> IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.GetDataArrayMetadata>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetDataArrayMetadataResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.GetDataArrayMetadataResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.DataArray.GetDataArrayMetadataResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.GetDataArrayMetadataResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = ArrayMetadata.GetEnumerator();
            while (itemCount < ArrayMetadata.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.DataArray.GetDataArrayMetadataResponse
                {
                    ArrayMetadata = new Dictionary<string, Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayMetadata>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < ArrayMetadata.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.ArrayMetadata[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.DataArray.GetDataArrayMetadataResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayMetadata>(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.ArrayMetadata[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
    public partial class GetDataSubarraysResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.GetDataSubarraysResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.DataArray.GetDataSubarraysResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.GetDataSubarraysResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = DataSubarrays.GetEnumerator();
            while (itemCount < DataSubarrays.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.DataArray.GetDataSubarraysResponse
                {
                    DataSubarrays = new Dictionary<string, Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArray>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < DataSubarrays.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.DataSubarrays[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.DataArray.GetDataSubarraysResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArray>(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.DataSubarrays[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
    public partial class PutUninitializedDataArrays : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.PutUninitializedDataArrays>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.DataArray.PutUninitializedDataArrays> IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.PutUninitializedDataArrays>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class PutDataArraysResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.PutDataArraysResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.DataArray.PutDataArraysResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.PutDataArraysResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Success.GetEnumerator();
            while (itemCount < Success.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.DataArray.PutDataArraysResponse
                {
                    Success = new Dictionary<string, string>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Success.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Success[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.DataArray.PutDataArraysResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeString(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Success[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
    public partial class PutDataSubarraysResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.PutDataSubarraysResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.DataArray.PutDataSubarraysResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.PutDataSubarraysResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Success.GetEnumerator();
            while (itemCount < Success.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.DataArray.PutDataSubarraysResponse
                {
                    Success = new Dictionary<string, string>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Success.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Success[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.DataArray.PutDataSubarraysResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeString(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Success[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
    public partial class PutUninitializedDataArraysResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.PutUninitializedDataArraysResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.DataArray.PutUninitializedDataArraysResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.DataArray.PutUninitializedDataArraysResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Success.GetEnumerator();
            while (itemCount < Success.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.DataArray.PutUninitializedDataArraysResponse
                {
                    Success = new Dictionary<string, string>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Success.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Success[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.DataArray.PutUninitializedDataArraysResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeString(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Success[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
}
namespace Energistics.Etp.v12.Protocol.DiscoveryQuery
{
    public partial class FindResources : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.DiscoveryQuery.FindResources>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.DiscoveryQuery.FindResources> IEtpMessageBody<Energistics.Etp.v12.Protocol.DiscoveryQuery.FindResources>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class FindResourcesResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.DiscoveryQuery.FindResourcesResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.DiscoveryQuery.FindResourcesResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.DiscoveryQuery.FindResourcesResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Resources.GetEnumerator();
            while (itemCount < Resources.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.DiscoveryQuery.FindResourcesResponse
                {
                    Resources = new List<Energistics.Etp.v12.Datatypes.Object.Resource>(),
                    ServerSortOrder = ServerSortOrder,
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Resources.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Resources.Add(v);
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.DiscoveryQuery.FindResourcesResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeArrayItemSeparator();
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.Resource>(v);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Resources.Add(v);
                }
                yield return copy;
            }
        }
    }
}
namespace Energistics.Etp.v12.Protocol.StoreQuery
{
    public partial class FindDataObjects : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreQuery.FindDataObjects>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.StoreQuery.FindDataObjects> IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreQuery.FindDataObjects>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class FindDataObjectsResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreQuery.FindDataObjectsResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.StoreQuery.FindDataObjectsResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreQuery.FindDataObjectsResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = DataObjects.GetEnumerator();
            while (itemCount < DataObjects.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.StoreQuery.FindDataObjectsResponse
                {
                    DataObjects = new List<Energistics.Etp.v12.Datatypes.Object.DataObject>(),
                    ServerSortOrder = ServerSortOrder,
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < DataObjects.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.DataObjects.Add(v);
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.StoreQuery.FindDataObjectsResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeArrayItemSeparator();
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.DataObject>(v);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.DataObjects.Add(v);
                }
                yield return copy;
            }
        }
    }
    public partial class Chunk : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreQuery.Chunk>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.StoreQuery.Chunk> IEtpMessageBody<Energistics.Etp.v12.Protocol.StoreQuery.Chunk>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
}
namespace Energistics.Etp.v12.Protocol.GrowingObjectQuery
{
    public partial class FindParts : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObjectQuery.FindParts>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObjectQuery.FindParts> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObjectQuery.FindParts>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class FindPartsResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObjectQuery.FindPartsResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.GrowingObjectQuery.FindPartsResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.GrowingObjectQuery.FindPartsResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Parts.GetEnumerator();
            while (itemCount < Parts.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.GrowingObjectQuery.FindPartsResponse
                {
                    Uri = Uri,
                    ServerSortOrder = ServerSortOrder,
                    Format = Format,
                    Parts = new List<Energistics.Etp.v12.Datatypes.Object.ObjectPart>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Parts.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Parts.Add(v);
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.GrowingObjectQuery.FindPartsResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeArrayItemSeparator();
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.ObjectPart>(v);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Parts.Add(v);
                }
                yield return copy;
            }
        }
    }
}
namespace Energistics.Etp.v12.Protocol.Transaction
{
    public partial class StartTransaction : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Transaction.StartTransaction>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.Transaction.StartTransaction> IEtpMessageBody<Energistics.Etp.v12.Protocol.Transaction.StartTransaction>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class StartTransactionResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Transaction.StartTransactionResponse>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.Transaction.StartTransactionResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.Transaction.StartTransactionResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class CommitTransaction : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Transaction.CommitTransaction>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.Transaction.CommitTransaction> IEtpMessageBody<Energistics.Etp.v12.Protocol.Transaction.CommitTransaction>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class RollbackTransaction : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Transaction.RollbackTransaction>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.Transaction.RollbackTransaction> IEtpMessageBody<Energistics.Etp.v12.Protocol.Transaction.RollbackTransaction>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class CommitTransactionResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Transaction.CommitTransactionResponse>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.Transaction.CommitTransactionResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.Transaction.CommitTransactionResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class RollbackTransactionResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Transaction.RollbackTransactionResponse>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.Transaction.RollbackTransactionResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.Transaction.RollbackTransactionResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
}
namespace Energistics.Etp.v12.Protocol.ChannelSubscribe
{
    public partial class GetChannelMetadata : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChannelMetadata>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChannelMetadata> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChannelMetadata>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetChannelMetadataResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChannelMetadataResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChannelMetadataResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChannelMetadataResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Metadata.GetEnumerator();
            while (itemCount < Metadata.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChannelMetadataResponse
                {
                    Metadata = new Dictionary<string, Energistics.Etp.v12.Datatypes.ChannelData.ChannelMetadataRecord>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Metadata.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Metadata[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChannelMetadataResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.ChannelMetadataRecord>(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Metadata[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
    public partial class SubscribeChannels : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscribeChannels>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscribeChannels> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscribeChannels>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class ChannelData : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.ChannelData>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelSubscribe.ChannelData> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.ChannelData>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class RangeReplaced : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.RangeReplaced>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelSubscribe.RangeReplaced> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.RangeReplaced>.Split(long targetSize, IAvroByteCounter byteCounter) => Split(targetSize, byteCounter);
    }
    public partial class UnsubscribeChannels : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.UnsubscribeChannels>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelSubscribe.UnsubscribeChannels> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.UnsubscribeChannels>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class SubscriptionsStopped : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscriptionsStopped>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscriptionsStopped> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscriptionsStopped>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = ChannelIds.GetEnumerator();
            while (itemCount < ChannelIds.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscriptionsStopped
                {
                    Reason = Reason,
                    ChannelIds = new Dictionary<string, long>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < ChannelIds.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.ChannelIds[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscriptionsStopped>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeLong(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.ChannelIds[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
    public partial class GetRanges : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.GetRanges>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelSubscribe.GetRanges> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.GetRanges>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetRangesResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.GetRangesResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelSubscribe.GetRangesResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.GetRangesResponse>.Split(long targetSize, IAvroByteCounter byteCounter) => Split(targetSize, byteCounter);
    }
    public partial class CancelGetRanges : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.CancelGetRanges>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelSubscribe.CancelGetRanges> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.CancelGetRanges>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class SubscribeChannelsResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscribeChannelsResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscribeChannelsResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscribeChannelsResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Success.GetEnumerator();
            while (itemCount < Success.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscribeChannelsResponse
                {
                    Success = new Dictionary<string, string>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Success.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Success[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscribeChannelsResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeString(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Success[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
    public partial class ChannelsTruncated : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.ChannelsTruncated>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelSubscribe.ChannelsTruncated> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.ChannelsTruncated>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetChangeAnnotations : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChangeAnnotations>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChangeAnnotations> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChangeAnnotations>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetChangeAnnotationsResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChangeAnnotationsResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChangeAnnotationsResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChangeAnnotationsResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Changes.GetEnumerator();
            while (itemCount < Changes.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChangeAnnotationsResponse
                {
                    Changes = new Dictionary<string, Energistics.Etp.v12.Datatypes.Object.ChangeResponseInfo>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Changes.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Changes[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChangeAnnotationsResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.ChangeResponseInfo>(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Changes[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
}
namespace Energistics.Etp.v12.Protocol.ChannelDataLoad
{
    public partial class OpenChannels : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataLoad.OpenChannels>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelDataLoad.OpenChannels> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataLoad.OpenChannels>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class OpenChannelsResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataLoad.OpenChannelsResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelDataLoad.OpenChannelsResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataLoad.OpenChannelsResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Channels.GetEnumerator();
            while (itemCount < Channels.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.ChannelDataLoad.OpenChannelsResponse
                {
                    Channels = new Dictionary<string, Energistics.Etp.v12.Datatypes.ChannelData.OpenChannelInfo>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Channels.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Channels[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.ChannelDataLoad.OpenChannelsResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.ChannelData.OpenChannelInfo>(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Channels[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
    public partial class CloseChannels : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataLoad.CloseChannels>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelDataLoad.CloseChannels> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataLoad.CloseChannels>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class ChannelData : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataLoad.ChannelData>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelDataLoad.ChannelData> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataLoad.ChannelData>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class ReplaceRange : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataLoad.ReplaceRange>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelDataLoad.ReplaceRange> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataLoad.ReplaceRange>.Split(long targetSize, IAvroByteCounter byteCounter) => Split(targetSize, byteCounter);
    }
    public partial class ChannelsClosed : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataLoad.ChannelsClosed>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelDataLoad.ChannelsClosed> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataLoad.ChannelsClosed>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Id.GetEnumerator();
            while (itemCount < Id.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.ChannelDataLoad.ChannelsClosed
                {
                    Reason = Reason,
                    Id = new Dictionary<string, long>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Id.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Id[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.ChannelDataLoad.ChannelsClosed>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeLong(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Id[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
    public partial class ReplaceRangeResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataLoad.ReplaceRangeResponse>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelDataLoad.ReplaceRangeResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataLoad.ReplaceRangeResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class TruncateChannels : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataLoad.TruncateChannels>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelDataLoad.TruncateChannels> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataLoad.TruncateChannels>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class TruncateChannelsResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataLoad.TruncateChannelsResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.ChannelDataLoad.TruncateChannelsResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.ChannelDataLoad.TruncateChannelsResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = ChannelsTruncatedTime.GetEnumerator();
            while (itemCount < ChannelsTruncatedTime.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.ChannelDataLoad.TruncateChannelsResponse
                {
                    ChannelsTruncatedTime = new Dictionary<string, System.DateTime>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < ChannelsTruncatedTime.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.ChannelsTruncatedTime[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.ChannelDataLoad.TruncateChannelsResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeTimestampMicrosDateTimeAsLong(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.ChannelsTruncatedTime[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
}
namespace Energistics.Etp.v12.Protocol.Dataspace
{
    public partial class GetDataspaces : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Dataspace.GetDataspaces>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.Dataspace.GetDataspaces> IEtpMessageBody<Energistics.Etp.v12.Protocol.Dataspace.GetDataspaces>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetDataspacesResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Dataspace.GetDataspacesResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.Dataspace.GetDataspacesResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.Dataspace.GetDataspacesResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Dataspaces.GetEnumerator();
            while (itemCount < Dataspaces.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.Dataspace.GetDataspacesResponse
                {
                    Dataspaces = new List<Energistics.Etp.v12.Datatypes.Object.Dataspace>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Dataspaces.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Dataspaces.Add(v);
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.Dataspace.GetDataspacesResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeArrayItemSeparator();
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.Dataspace>(v);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Dataspaces.Add(v);
                }
                yield return copy;
            }
        }
    }
    public partial class PutDataspaces : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Dataspace.PutDataspaces>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.Dataspace.PutDataspaces> IEtpMessageBody<Energistics.Etp.v12.Protocol.Dataspace.PutDataspaces>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class DeleteDataspaces : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Dataspace.DeleteDataspaces>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.Dataspace.DeleteDataspaces> IEtpMessageBody<Energistics.Etp.v12.Protocol.Dataspace.DeleteDataspaces>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class DeleteDataspacesResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Dataspace.DeleteDataspacesResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.Dataspace.DeleteDataspacesResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.Dataspace.DeleteDataspacesResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Success.GetEnumerator();
            while (itemCount < Success.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.Dataspace.DeleteDataspacesResponse
                {
                    Success = new Dictionary<string, string>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Success.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Success[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.Dataspace.DeleteDataspacesResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeString(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Success[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
    public partial class PutDataspacesResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.Dataspace.PutDataspacesResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.Dataspace.PutDataspacesResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.Dataspace.PutDataspacesResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = Success.GetEnumerator();
            while (itemCount < Success.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.Dataspace.PutDataspacesResponse
                {
                    Success = new Dictionary<string, string>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < Success.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.Success[v.Key] = v.Value;
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.Dataspace.PutDataspacesResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeMapValueSeparator();
                    byteCounter.EncodeMapKey(v.Key);
                    byteCounter.EncodeString(v.Value);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.Success[v.Key] = v.Value;
                }
                yield return copy;
            }
        }
    }
}
namespace Energistics.Etp.v12.Protocol.SupportedTypes
{
    public partial class GetSupportedTypes : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.SupportedTypes.GetSupportedTypes>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.Protocol.SupportedTypes.GetSupportedTypes> IEtpMessageBody<Energistics.Etp.v12.Protocol.SupportedTypes.GetSupportedTypes>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetSupportedTypesResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.Protocol.SupportedTypes.GetSupportedTypesResponse>
    {
        bool IEtpMessageBody.CanSplit() => true;
        IEnumerable<Energistics.Etp.v12.Protocol.SupportedTypes.GetSupportedTypesResponse> IEtpMessageBody<Energistics.Etp.v12.Protocol.SupportedTypes.GetSupportedTypesResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            var itemCount = 0;
            var enumerator = SupportedTypes.GetEnumerator();
            while (itemCount < SupportedTypes.Count)
            {
                var copy = new Energistics.Etp.v12.Protocol.SupportedTypes.GetSupportedTypesResponse
                {
                    SupportedTypes = new List<Energistics.Etp.v12.Datatypes.Object.SupportedType>(),
                };
                var added = false;
                byteCounter.Reset();
                while (byteCounter.ByteCount < targetSize && itemCount++ < SupportedTypes.Count)
                {
                    enumerator.MoveNext();
                    var v = enumerator.Current;
                    if (!added)
                    {
                        added = true;
                        copy.SupportedTypes.Add(v);
                        byteCounter.EncodeAvroObject<Energistics.Etp.v12.Protocol.SupportedTypes.GetSupportedTypesResponse>(copy);
                        continue;
                    }
                    byteCounter.EncodeArrayItemSeparator();
                    byteCounter.EncodeAvroObject<Energistics.Etp.v12.Datatypes.Object.SupportedType>(v);
                    if (byteCounter.ByteCount <= targetSize)
                        copy.SupportedTypes.Add(v);
                }
                yield return copy;
            }
        }
    }
}
namespace Energistics.Etp.v12.PrivateProtocols.WitsmlSoap
{
    public partial class WMLS_AddToStore : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_AddToStore>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_AddToStore> IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_AddToStore>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMLS_AddToStoreResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_AddToStoreResponse>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_AddToStoreResponse> IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_AddToStoreResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMLS_DeleteFromStore : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_DeleteFromStore>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_DeleteFromStore> IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_DeleteFromStore>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMLS_DeleteFromStoreResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_DeleteFromStoreResponse>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_DeleteFromStoreResponse> IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_DeleteFromStoreResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMLS_GetBaseMsg : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetBaseMsg>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetBaseMsg> IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetBaseMsg>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMLS_GetBaseMsgResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetBaseMsgResponse>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetBaseMsgResponse> IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetBaseMsgResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMLS_GetCap : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetCap>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetCap> IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetCap>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMLS_GetCapResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetCapResponse>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetCapResponse> IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetCapResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMLS_GetFromStore : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetFromStore>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetFromStore> IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetFromStore>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMLS_GetFromStoreResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetFromStoreResponse>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetFromStoreResponse> IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetFromStoreResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMLS_GetVersion : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetVersion>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetVersion> IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetVersion>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMLS_GetVersionResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetVersionResponse>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetVersionResponse> IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetVersionResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMLS_UpdateInStore : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_UpdateInStore>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_UpdateInStore> IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_UpdateInStore>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMLS_UpdateInStoreResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_UpdateInStoreResponse>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_UpdateInStoreResponse> IEtpMessageBody<Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_UpdateInStoreResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
}
