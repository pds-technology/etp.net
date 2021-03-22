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

using System.Collections.Generic;

namespace Energistics.Etp.v12
{
    /// <summary>
    /// Provides string representations of protocol message names.
    /// </summary>
    public static partial class MessageNames
    {
        /// <summary>
        /// The dictionary of protocol names.
        /// </summary>
        private static Dictionary<int, Dictionary<int, string>> Names { get; } = new Dictionary<int, Dictionary<int, string>>
        {
            [0] = new Dictionary<int, string>
            {
                [1] = "RequestSession",
                [2] = "OpenSession",
                [5] = "CloseSession",
                [6] = "RenewSecurityToken",
                [7] = "RenewSecurityTokenResponse",
                [8] = "Ping",
                [9] = "Pong",
                [1000] = "ProtocolException",
                [1001] = "Acknowledge",
            },
            [1] = new Dictionary<int, string>
            {
                [1] = "ChannelMetadata",
                [2] = "ChannelData",
                [3] = "StartStreaming",
                [4] = "StopStreaming",
                [5] = "TruncateChannels",
            },
            [2] = new Dictionary<int, string>
            {
                [1] = "GetFrameMetadata",
                [2] = "GetFrameMetadataResponse",
                [3] = "GetFrame",
                [4] = "GetFrameResponseHeader",
                [5] = "CancelGetFrame",
                [6] = "GetFrameResponseRows",
            },
            [3] = new Dictionary<int, string>
            {
                [1] = "GetResources",
                [4] = "GetResourcesResponse",
                [5] = "GetDeletedResources",
                [6] = "GetDeletedResourcesResponse",
                [7] = "GetResourcesEdgesResponse",
            },
            [4] = new Dictionary<int, string>
            {
                [1] = "GetDataObjects",
                [2] = "PutDataObjects",
                [3] = "DeleteDataObjects",
                [4] = "GetDataObjectsResponse",
                [8] = "Chunk",
                [9] = "PutDataObjectsResponse",
                [10] = "DeleteDataObjectsResponse",
            },
            [5] = new Dictionary<int, string>
            {
                [2] = "ObjectChanged",
                [3] = "ObjectDeleted",
                [4] = "UnsubscribeNotifications",
                [5] = "ObjectAccessRevoked",
                [6] = "SubscribeNotifications",
                [7] = "SubscriptionEnded",
                [8] = "UnsolicitedStoreNotifications",
                [9] = "Chunk",
                [10] = "SubscribeNotificationsResponse",
                [11] = "ObjectActiveStatusChanged",
            },
            [6] = new Dictionary<int, string>
            {
                [1] = "DeleteParts",
                [3] = "GetParts",
                [4] = "GetPartsByRange",
                [5] = "PutParts",
                [6] = "GetPartsResponse",
                [7] = "ReplacePartsByRange",
                [8] = "GetPartsMetadata",
                [9] = "GetPartsMetadataResponse",
                [10] = "GetPartsByRangeResponse",
                [11] = "DeletePartsResponse",
                [13] = "PutPartsResponse",
                [14] = "GetGrowingDataObjectsHeader",
                [15] = "GetGrowingDataObjectsHeaderResponse",
                [16] = "PutGrowingDataObjectsHeader",
                [17] = "PutGrowingDataObjectsHeaderResponse",
                [18] = "ReplacePartsByRangeResponse",
            },
            [7] = new Dictionary<int, string>
            {
                [2] = "PartsChanged",
                [3] = "PartsDeleted",
                [4] = "UnsubscribePartNotification",
                [6] = "PartsReplacedByRange",
                [7] = "SubscribePartNotifications",
                [8] = "PartSubscriptionEnded",
                [9] = "UnsolicitedPartNotifications",
                [10] = "SubscribePartNotificationsResponse",
            },
            [9] = new Dictionary<int, string>
            {
                [1] = "GetDataArraysResponse",
                [2] = "GetDataArrays",
                [3] = "GetDataSubarrays",
                [4] = "PutDataArrays",
                [5] = "PutDataSubarrays",
                [6] = "GetDataArrayMetadata",
                [7] = "GetDataArrayMetadataResponse",
                [8] = "GetDataSubarraysResponse",
                [9] = "PutUninitializedDataArrays",
                [10] = "PutDataArraysResponse",
                [11] = "PutDataSubarraysResponse",
                [12] = "PutUninitializedDataArraysResponse",
            },
            [13] = new Dictionary<int, string>
            {
                [1] = "FindResources",
                [2] = "FindResourcesResponse",
            },
            [14] = new Dictionary<int, string>
            {
                [1] = "FindDataObjects",
                [2] = "FindDataObjectsResponse",
                [3] = "Chunk",
            },
            [16] = new Dictionary<int, string>
            {
                [1] = "FindParts",
                [2] = "FindPartsResponse",
            },
            [18] = new Dictionary<int, string>
            {
                [1] = "StartTransaction",
                [2] = "StartTransactionResponse",
                [3] = "CommitTransaction",
                [4] = "RollbackTransaction",
                [5] = "CommitTransactionResponse",
                [6] = "RollbackTransactionResponse",
            },
            [21] = new Dictionary<int, string>
            {
                [1] = "GetChannelMetadata",
                [2] = "GetChannelMetadataResponse",
                [3] = "SubscribeChannels",
                [4] = "ChannelData",
                [6] = "RangeReplaced",
                [7] = "UnsubscribeChannels",
                [8] = "SubscriptionsStopped",
                [9] = "GetRanges",
                [10] = "GetRangesResponse",
                [11] = "CancelGetRanges",
                [12] = "SubscribeChannelsResponse",
                [13] = "ChannelsTruncated",
                [14] = "GetChangeAnnotations",
                [15] = "GetChangeAnnotationsResponse",
            },
            [22] = new Dictionary<int, string>
            {
                [1] = "OpenChannels",
                [2] = "OpenChannelsResponse",
                [3] = "CloseChannels",
                [4] = "ChannelData",
                [6] = "ReplaceRange",
                [7] = "ChannelsClosed",
                [8] = "ReplaceRangeResponse",
                [9] = "TruncateChannels",
                [10] = "TruncateChannelsResponse",
            },
            [24] = new Dictionary<int, string>
            {
                [1] = "GetDataspaces",
                [2] = "GetDataspacesResponse",
                [3] = "PutDataspaces",
                [4] = "DeleteDataspaces",
                [5] = "DeleteDataspacesResponse",
                [6] = "PutDataspacesResponse",
            },
            [25] = new Dictionary<int, string>
            {
                [1] = "GetSupportedTypes",
                [2] = "GetSupportedTypesResponse",
            },
            [2100] = new Dictionary<int, string>
            {
                [1] = "WMLS_AddToStore",
                [2] = "WMLS_AddToStoreResponse",
                [3] = "WMLS_DeleteFromStore",
                [4] = "WMLS_DeleteFromStoreResponse",
                [5] = "WMLS_GetBaseMsg",
                [6] = "WMLS_GetBaseMsgResponse",
                [7] = "WMLS_GetCap",
                [8] = "WMLS_GetCapResponse",
                [9] = "WMLS_GetFromStore",
                [10] = "WMLS_GetFromStoreResponse",
                [11] = "WMLS_GetVersion",
                [12] = "WMLS_GetVersionResponse",
                [13] = "WMLS_UpdateInStore",
                [14] = "WMLS_UpdateInStoreResponse",
            },
        };
    }
}
