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

namespace Energistics.Etp.v11.Protocol.Core
{
    public partial class RequestSession : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.Core.RequestSession>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.Core.RequestSession> IEtpMessageBody<Energistics.Etp.v11.Protocol.Core.RequestSession>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class OpenSession : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.Core.OpenSession>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.Core.OpenSession> IEtpMessageBody<Energistics.Etp.v11.Protocol.Core.OpenSession>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class CloseSession : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.Core.CloseSession>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.Core.CloseSession> IEtpMessageBody<Energistics.Etp.v11.Protocol.Core.CloseSession>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class RenewSecurityToken : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.Core.RenewSecurityToken>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.Core.RenewSecurityToken> IEtpMessageBody<Energistics.Etp.v11.Protocol.Core.RenewSecurityToken>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class ProtocolException : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.Core.ProtocolException>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.Core.ProtocolException> IEtpMessageBody<Energistics.Etp.v11.Protocol.Core.ProtocolException>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class Acknowledge : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.Core.Acknowledge>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.Core.Acknowledge> IEtpMessageBody<Energistics.Etp.v11.Protocol.Core.Acknowledge>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
}
namespace Energistics.Etp.v11.Protocol.ChannelStreaming
{
    public partial class Start : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelStreaming.Start>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.ChannelStreaming.Start> IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelStreaming.Start>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class ChannelDescribe : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelDescribe>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelDescribe> IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelDescribe>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class ChannelMetadata : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelMetadata>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelMetadata> IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelMetadata>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class ChannelData : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelData>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelData> IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelData>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class ChannelStreamingStart : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelStreamingStart>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelStreamingStart> IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelStreamingStart>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class ChannelStreamingStop : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelStreamingStop>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelStreamingStop> IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelStreamingStop>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class ChannelDataChange : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelDataChange>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelDataChange> IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelDataChange>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class ChannelRemove : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelRemove>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelRemove> IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelRemove>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class ChannelRangeRequest : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelRangeRequest>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelRangeRequest> IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelRangeRequest>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class ChannelStatusChange : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelStatusChange>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelStatusChange> IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelStatusChange>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
}
namespace Energistics.Etp.v11.Protocol.ChannelDataFrame
{
    public partial class RequestChannelData : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelDataFrame.RequestChannelData>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.ChannelDataFrame.RequestChannelData> IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelDataFrame.RequestChannelData>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class ChannelMetadata : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelDataFrame.ChannelMetadata>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.ChannelDataFrame.ChannelMetadata> IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelDataFrame.ChannelMetadata>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class ChannelDataFrameSet : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelDataFrame.ChannelDataFrameSet>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.ChannelDataFrame.ChannelDataFrameSet> IEtpMessageBody<Energistics.Etp.v11.Protocol.ChannelDataFrame.ChannelDataFrameSet>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
}
namespace Energistics.Etp.v11.Protocol.Discovery
{
    public partial class GetResources : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.Discovery.GetResources>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.Discovery.GetResources> IEtpMessageBody<Energistics.Etp.v11.Protocol.Discovery.GetResources>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetResourcesResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.Discovery.GetResourcesResponse>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.Discovery.GetResourcesResponse> IEtpMessageBody<Energistics.Etp.v11.Protocol.Discovery.GetResourcesResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
}
namespace Energistics.Etp.v11.Protocol.Store
{
    public partial class GetObject : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.Store.GetObject>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.Store.GetObject> IEtpMessageBody<Energistics.Etp.v11.Protocol.Store.GetObject>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class PutObject : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.Store.PutObject>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.Store.PutObject> IEtpMessageBody<Energistics.Etp.v11.Protocol.Store.PutObject>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class DeleteObject : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.Store.DeleteObject>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.Store.DeleteObject> IEtpMessageBody<Energistics.Etp.v11.Protocol.Store.DeleteObject>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class Object : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.Store.Object>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.Store.Object> IEtpMessageBody<Energistics.Etp.v11.Protocol.Store.Object>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
}
namespace Energistics.Etp.v11.Protocol.StoreNotification
{
    public partial class NotificationRequest : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.StoreNotification.NotificationRequest>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.StoreNotification.NotificationRequest> IEtpMessageBody<Energistics.Etp.v11.Protocol.StoreNotification.NotificationRequest>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class ChangeNotification : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.StoreNotification.ChangeNotification>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.StoreNotification.ChangeNotification> IEtpMessageBody<Energistics.Etp.v11.Protocol.StoreNotification.ChangeNotification>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class DeleteNotification : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.StoreNotification.DeleteNotification>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.StoreNotification.DeleteNotification> IEtpMessageBody<Energistics.Etp.v11.Protocol.StoreNotification.DeleteNotification>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class CancelNotification : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.StoreNotification.CancelNotification>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.StoreNotification.CancelNotification> IEtpMessageBody<Energistics.Etp.v11.Protocol.StoreNotification.CancelNotification>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
}
namespace Energistics.Etp.v11.Protocol.GrowingObject
{
    public partial class GrowingObjectDelete : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectDelete>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectDelete> IEtpMessageBody<Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectDelete>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GrowingObjectDeleteRange : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectDeleteRange>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectDeleteRange> IEtpMessageBody<Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectDeleteRange>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GrowingObjectGet : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectGet>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectGet> IEtpMessageBody<Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectGet>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GrowingObjectGetRange : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectGetRange>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectGetRange> IEtpMessageBody<Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectGetRange>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GrowingObjectPut : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectPut>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectPut> IEtpMessageBody<Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectPut>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class ObjectFragment : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.GrowingObject.ObjectFragment>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.GrowingObject.ObjectFragment> IEtpMessageBody<Energistics.Etp.v11.Protocol.GrowingObject.ObjectFragment>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
}
namespace Energistics.Etp.v11.Protocol.DataArray
{
    public partial class DataArray : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.DataArray.DataArray>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.DataArray.DataArray> IEtpMessageBody<Energistics.Etp.v11.Protocol.DataArray.DataArray>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetDataArray : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.DataArray.GetDataArray>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.DataArray.GetDataArray> IEtpMessageBody<Energistics.Etp.v11.Protocol.DataArray.GetDataArray>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class GetDataArraySlice : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.DataArray.GetDataArraySlice>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.DataArray.GetDataArraySlice> IEtpMessageBody<Energistics.Etp.v11.Protocol.DataArray.GetDataArraySlice>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class PutDataArray : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.DataArray.PutDataArray>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.DataArray.PutDataArray> IEtpMessageBody<Energistics.Etp.v11.Protocol.DataArray.PutDataArray>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class PutDataArraySlice : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.DataArray.PutDataArraySlice>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.DataArray.PutDataArraySlice> IEtpMessageBody<Energistics.Etp.v11.Protocol.DataArray.PutDataArraySlice>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
}
namespace Energistics.Etp.v11.Protocol.WitsmlSoap
{
    public partial class WMLS_AddToStore : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_AddToStore>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_AddToStore> IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_AddToStore>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMSL_AddToStoreResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_AddToStoreResponse>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_AddToStoreResponse> IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_AddToStoreResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMLS_DeleteFromStore : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_DeleteFromStore>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_DeleteFromStore> IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_DeleteFromStore>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMSL_DeleteFromStoreResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_DeleteFromStoreResponse>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_DeleteFromStoreResponse> IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_DeleteFromStoreResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMLS_GetBaseMsg : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_GetBaseMsg>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_GetBaseMsg> IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_GetBaseMsg>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMSL_GetBaseMsgResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_GetBaseMsgResponse>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_GetBaseMsgResponse> IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_GetBaseMsgResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMLS_GetCap : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_GetCap>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_GetCap> IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_GetCap>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMSL_GetCapResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_GetCapResponse>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_GetCapResponse> IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_GetCapResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMLS_GetFromStore : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_GetFromStore>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_GetFromStore> IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_GetFromStore>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMSL_GetFromStoreResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_GetFromStoreResponse>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_GetFromStoreResponse> IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_GetFromStoreResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMLS_GetVersion : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_GetVersion>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_GetVersion> IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_GetVersion>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMSL_GetVersionResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_GetVersionResponse>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_GetVersionResponse> IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_GetVersionResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMLS_UpdateInStore : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_UpdateInStore>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_UpdateInStore> IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_UpdateInStore>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
    public partial class WMSL_UpdateInStoreResponse : IEtpMessageBody, IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_UpdateInStoreResponse>
    {
        bool IEtpMessageBody.CanSplit() => false;
        IEnumerable<Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_UpdateInStoreResponse> IEtpMessageBody<Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_UpdateInStoreResponse>.Split(long targetSize, IAvroByteCounter byteCounter)
        {
            yield return this;
        }
    }
}
