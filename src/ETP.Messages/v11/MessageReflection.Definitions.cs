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

namespace Energistics.Etp.v11
{
    /// <summary>
    /// Provides ETP message information by message type.
    /// </summary>
    public static partial class MessageReflection
    {
        /// <summary>
        /// The dictionary of ETP protocols by message type.
        /// </summary>
        public static Dictionary<Type, int> ProtocolByMessage { get; } = new Dictionary<Type, int>()
        {
            [typeof(Energistics.Etp.v11.Protocol.Core.RequestSession)] = 0,
            [typeof(Energistics.Etp.v11.Protocol.Core.OpenSession)] = 0,
            [typeof(Energistics.Etp.v11.Protocol.Core.CloseSession)] = 0,
            [typeof(Energistics.Etp.v11.Protocol.Core.RenewSecurityToken)] = 0,
            [typeof(Energistics.Etp.v11.Protocol.Core.ProtocolException)] = 0,
            [typeof(Energistics.Etp.v11.Protocol.Core.Acknowledge)] = 0,
            [typeof(Energistics.Etp.v11.Protocol.ChannelStreaming.Start)] = 1,
            [typeof(Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelDescribe)] = 1,
            [typeof(Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelMetadata)] = 1,
            [typeof(Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelData)] = 1,
            [typeof(Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelStreamingStart)] = 1,
            [typeof(Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelStreamingStop)] = 1,
            [typeof(Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelDataChange)] = 1,
            [typeof(Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelRemove)] = 1,
            [typeof(Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelRangeRequest)] = 1,
            [typeof(Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelStatusChange)] = 1,
            [typeof(Energistics.Etp.v11.Protocol.ChannelDataFrame.RequestChannelData)] = 2,
            [typeof(Energistics.Etp.v11.Protocol.ChannelDataFrame.ChannelMetadata)] = 2,
            [typeof(Energistics.Etp.v11.Protocol.ChannelDataFrame.ChannelDataFrameSet)] = 2,
            [typeof(Energistics.Etp.v11.Protocol.Discovery.GetResources)] = 3,
            [typeof(Energistics.Etp.v11.Protocol.Discovery.GetResourcesResponse)] = 3,
            [typeof(Energistics.Etp.v11.Protocol.Store.GetObject)] = 4,
            [typeof(Energistics.Etp.v11.Protocol.Store.PutObject)] = 4,
            [typeof(Energistics.Etp.v11.Protocol.Store.DeleteObject)] = 4,
            [typeof(Energistics.Etp.v11.Protocol.Store.Object)] = 4,
            [typeof(Energistics.Etp.v11.Protocol.StoreNotification.NotificationRequest)] = 5,
            [typeof(Energistics.Etp.v11.Protocol.StoreNotification.ChangeNotification)] = 5,
            [typeof(Energistics.Etp.v11.Protocol.StoreNotification.DeleteNotification)] = 5,
            [typeof(Energistics.Etp.v11.Protocol.StoreNotification.CancelNotification)] = 5,
            [typeof(Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectDelete)] = 6,
            [typeof(Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectDeleteRange)] = 6,
            [typeof(Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectGet)] = 6,
            [typeof(Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectGetRange)] = 6,
            [typeof(Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectPut)] = 6,
            [typeof(Energistics.Etp.v11.Protocol.GrowingObject.ObjectFragment)] = 6,
            [typeof(Energistics.Etp.v11.Protocol.DataArray.DataArray)] = 7,
            [typeof(Energistics.Etp.v11.Protocol.DataArray.GetDataArray)] = 7,
            [typeof(Energistics.Etp.v11.Protocol.DataArray.GetDataArraySlice)] = 7,
            [typeof(Energistics.Etp.v11.Protocol.DataArray.PutDataArray)] = 7,
            [typeof(Energistics.Etp.v11.Protocol.DataArray.PutDataArraySlice)] = 7,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_AddToStore)] = 8,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_AddToStoreResponse)] = 8,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_DeleteFromStore)] = 8,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_DeleteFromStoreResponse)] = 8,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_GetBaseMsg)] = 8,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_GetBaseMsgResponse)] = 8,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_GetCap)] = 8,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_GetCapResponse)] = 8,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_GetFromStore)] = 8,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_GetFromStoreResponse)] = 8,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_GetVersion)] = 8,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_GetVersionResponse)] = 8,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_UpdateInStore)] = 8,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_UpdateInStoreResponse)] = 8,
        };
        /// <summary>
        /// The dictionary of ETP message types by message type.
        /// </summary>
        public static Dictionary<Type, int> MessageTypeByMessage { get; } = new Dictionary<Type, int>()
        {
            [typeof(Energistics.Etp.v11.Protocol.Core.RequestSession)] = 1,
            [typeof(Energistics.Etp.v11.Protocol.Core.OpenSession)] = 2,
            [typeof(Energistics.Etp.v11.Protocol.Core.CloseSession)] = 5,
            [typeof(Energistics.Etp.v11.Protocol.Core.RenewSecurityToken)] = 6,
            [typeof(Energistics.Etp.v11.Protocol.Core.ProtocolException)] = 1000,
            [typeof(Energistics.Etp.v11.Protocol.Core.Acknowledge)] = 1001,
            [typeof(Energistics.Etp.v11.Protocol.ChannelStreaming.Start)] = 0,
            [typeof(Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelDescribe)] = 1,
            [typeof(Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelMetadata)] = 2,
            [typeof(Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelData)] = 3,
            [typeof(Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelStreamingStart)] = 4,
            [typeof(Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelStreamingStop)] = 5,
            [typeof(Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelDataChange)] = 6,
            [typeof(Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelRemove)] = 8,
            [typeof(Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelRangeRequest)] = 9,
            [typeof(Energistics.Etp.v11.Protocol.ChannelStreaming.ChannelStatusChange)] = 10,
            [typeof(Energistics.Etp.v11.Protocol.ChannelDataFrame.RequestChannelData)] = 1,
            [typeof(Energistics.Etp.v11.Protocol.ChannelDataFrame.ChannelMetadata)] = 3,
            [typeof(Energistics.Etp.v11.Protocol.ChannelDataFrame.ChannelDataFrameSet)] = 4,
            [typeof(Energistics.Etp.v11.Protocol.Discovery.GetResources)] = 1,
            [typeof(Energistics.Etp.v11.Protocol.Discovery.GetResourcesResponse)] = 2,
            [typeof(Energistics.Etp.v11.Protocol.Store.GetObject)] = 1,
            [typeof(Energistics.Etp.v11.Protocol.Store.PutObject)] = 2,
            [typeof(Energistics.Etp.v11.Protocol.Store.DeleteObject)] = 3,
            [typeof(Energistics.Etp.v11.Protocol.Store.Object)] = 4,
            [typeof(Energistics.Etp.v11.Protocol.StoreNotification.NotificationRequest)] = 1,
            [typeof(Energistics.Etp.v11.Protocol.StoreNotification.ChangeNotification)] = 2,
            [typeof(Energistics.Etp.v11.Protocol.StoreNotification.DeleteNotification)] = 3,
            [typeof(Energistics.Etp.v11.Protocol.StoreNotification.CancelNotification)] = 4,
            [typeof(Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectDelete)] = 1,
            [typeof(Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectDeleteRange)] = 2,
            [typeof(Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectGet)] = 3,
            [typeof(Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectGetRange)] = 4,
            [typeof(Energistics.Etp.v11.Protocol.GrowingObject.GrowingObjectPut)] = 5,
            [typeof(Energistics.Etp.v11.Protocol.GrowingObject.ObjectFragment)] = 6,
            [typeof(Energistics.Etp.v11.Protocol.DataArray.DataArray)] = 1,
            [typeof(Energistics.Etp.v11.Protocol.DataArray.GetDataArray)] = 2,
            [typeof(Energistics.Etp.v11.Protocol.DataArray.GetDataArraySlice)] = 3,
            [typeof(Energistics.Etp.v11.Protocol.DataArray.PutDataArray)] = 4,
            [typeof(Energistics.Etp.v11.Protocol.DataArray.PutDataArraySlice)] = 5,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_AddToStore)] = 1,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_AddToStoreResponse)] = 2,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_DeleteFromStore)] = 3,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_DeleteFromStoreResponse)] = 4,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_GetBaseMsg)] = 5,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_GetBaseMsgResponse)] = 6,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_GetCap)] = 7,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_GetCapResponse)] = 8,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_GetFromStore)] = 9,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_GetFromStoreResponse)] = 10,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_GetVersion)] = 11,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_GetVersionResponse)] = 12,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMLS_UpdateInStore)] = 13,
            [typeof(Energistics.Etp.v11.Protocol.WitsmlSoap.WMSL_UpdateInStoreResponse)] = 14,
        };
    }
}
