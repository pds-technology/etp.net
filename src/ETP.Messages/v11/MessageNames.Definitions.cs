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

using System.Collections.Generic;

namespace Energistics.Etp.v11
{
    /// <summary>
    /// Provides string representations of protocol message names.
    /// </summary>
    public static partial class MessageNames
    {
        /// <summary>
        /// The dictionary of message names.
        /// </summary>
        public static Dictionary<int, Dictionary<int, string>> Names { get; } = new Dictionary<int, Dictionary<int, string>>()
        {
            [0] = new Dictionary<int, string>
            {
                [1] = "RequestSession",
                [2] = "OpenSession",
                [5] = "CloseSession",
                [6] = "RenewSecurityToken",
                [1000] = "ProtocolException",
                [1001] = "Acknowledge",
            },
            [1] = new Dictionary<int, string>
            {
                [0] = "Start",
                [1] = "ChannelDescribe",
                [2] = "ChannelMetadata",
                [3] = "ChannelData",
                [4] = "ChannelStreamingStart",
                [5] = "ChannelStreamingStop",
                [6] = "ChannelDataChange",
                [8] = "ChannelRemove",
                [9] = "ChannelRangeRequest",
                [10] = "ChannelStatusChange",
            },
            [2] = new Dictionary<int, string>
            {
                [1] = "RequestChannelData",
                [3] = "ChannelMetadata",
                [4] = "ChannelDataFrameSet",
            },
            [3] = new Dictionary<int, string>
            {
                [1] = "GetResources",
                [2] = "GetResourcesResponse",
            },
            [4] = new Dictionary<int, string>
            {
                [1] = "GetObject",
                [2] = "PutObject",
                [3] = "DeleteObject",
                [4] = "Object",
            },
            [5] = new Dictionary<int, string>
            {
                [1] = "NotificationRequest",
                [2] = "ChangeNotification",
                [3] = "DeleteNotification",
                [4] = "CancelNotification",
            },
            [6] = new Dictionary<int, string>
            {
                [1] = "GrowingObjectDelete",
                [2] = "GrowingObjectDeleteRange",
                [3] = "GrowingObjectGet",
                [4] = "GrowingObjectGetRange",
                [5] = "GrowingObjectPut",
                [6] = "ObjectFragment",
            },
            [7] = new Dictionary<int, string>
            {
                [1] = "DataArray",
                [2] = "GetDataArray",
                [3] = "GetDataArraySlice",
                [4] = "PutDataArray",
                [5] = "PutDataArraySlice",
            },
            [8] = new Dictionary<int, string>
            {
                [1] = "WMLS_AddToStore",
                [2] = "WMSL_AddToStoreResponse",
                [3] = "WMLS_DeleteFromStore",
                [4] = "WMSL_DeleteFromStoreResponse",
                [5] = "WMLS_GetBaseMsg",
                [6] = "WMSL_GetBaseMsgResponse",
                [7] = "WMLS_GetCap",
                [8] = "WMSL_GetCapResponse",
                [9] = "WMLS_GetFromStore",
                [10] = "WMSL_GetFromStoreResponse",
                [11] = "WMLS_GetVersion",
                [12] = "WMSL_GetVersionResponse",
                [13] = "WMLS_UpdateInStore",
                [14] = "WMSL_UpdateInStoreResponse",
            },
        };
    }
}
