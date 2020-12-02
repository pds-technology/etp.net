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

namespace Energistics.Etp.v12
{
    /// <summary>
    /// Provides enumerations of protocol message types.
    /// </summary>
    public static class MessageTypes
    {
        /// <summary>
        /// An enumeration of Core protocol message types.
        /// </summary>
        public enum Core
        {
            RequestSession = 1,
            OpenSession = 2,
            CloseSession = 5,
            RenewSecurityToken = 6,
            RenewSecurityTokenResponse = 7,
            Ping = 8,
            Pong = 9,
            ProtocolException = 1000,
            Acknowledge = 1001,
        }

        /// <summary>
        /// An enumeration of ChannelStreaming protocol message types.
        /// </summary>
        public enum ChannelStreaming
        {
            ChannelMetadata = 1,
            ChannelData = 2,
            StartStreaming = 3,
            StopStreaming = 4,
            TruncateChannels = 5,
        }

        /// <summary>
        /// An enumeration of ChannelDataFrame protocol message types.
        /// </summary>
        public enum ChannelDataFrame
        {
            GetFrameMetadata = 1,
            GetFrameMetadataResponse = 2,
            GetFrame = 3,
            GetFrameResponseHeader = 4,
            CancelGetFrame = 5,
            GetFrameResponseRows = 6,
        }

        /// <summary>
        /// An enumeration of Discovery protocol message types.
        /// </summary>
        public enum Discovery
        {
            GetResources = 1,
            GetResourcesResponse = 4,
            GetDeletedResources = 5,
            GetDeletedResourcesResponse = 6,
            GetResourcesEdgesResponse = 7,
        }

        /// <summary>
        /// An enumeration of Store protocol message types.
        /// </summary>
        public enum Store
        {
            GetDataObjects = 1,
            PutDataObjects = 2,
            DeleteDataObjects = 3,
            GetDataObjectsResponse = 4,
            Chunk = 8,
            PutDataObjectsResponse = 9,
            DeleteDataObjectsResponse = 10,
        }

        /// <summary>
        /// An enumeration of StoreNotification protocol message types.
        /// </summary>
        public enum StoreNotification
        {
            ObjectChanged = 2,
            ObjectDeleted = 3,
            UnsubscribeNotifications = 4,
            ObjectAccessRevoked = 5,
            SubscribeNotifications = 6,
            SubscriptionEnded = 7,
            UnsolicitedStoreNotifications = 8,
            Chunk = 9,
            SubscribeNotificationsResponse = 10,
            ObjectActiveStatusChanged = 11,
        }

        /// <summary>
        /// An enumeration of GrowingObject protocol message types.
        /// </summary>
        public enum GrowingObject
        {
            DeleteParts = 1,
            GetParts = 3,
            GetPartsByRange = 4,
            PutParts = 5,
            GetPartsResponse = 6,
            ReplacePartsByRange = 7,
            GetPartsMetadata = 8,
            GetPartsMetadataResponse = 9,
            GetPartsByRangeResponse = 10,
            DeletePartsResponse = 11,
            PutPartsResponse = 13,
            GetGrowingDataObjectsHeader = 14,
            GetGrowingDataObjectsHeaderResponse = 15,
            PutGrowingDataObjectsHeader = 16,
            PutGrowingDataObjectsHeaderResponse = 17,
            ReplacePartsByRangeResponse = 18,
        }

        /// <summary>
        /// An enumeration of GrowingObjectNotification protocol message types.
        /// </summary>
        public enum GrowingObjectNotification
        {
            PartsChanged = 2,
            PartsDeleted = 3,
            UnsubscribePartNotification = 4,
            PartsReplacedByRange = 6,
            SubscribePartNotifications = 7,
            PartSubscriptionEnded = 8,
            UnsolicitedPartNotifications = 9,
            SubscribePartNotificationsResponse = 10,
        }

        /// <summary>
        /// An enumeration of DataArray protocol message types.
        /// </summary>
        public enum DataArray
        {
            GetDataArraysResponse = 1,
            GetDataArrays = 2,
            GetDataSubarrays = 3,
            PutDataArrays = 4,
            PutDataSubarrays = 5,
            GetDataArrayMetadata = 6,
            GetDataArrayMetadataResponse = 7,
            GetDataSubarraysResponse = 8,
            PutUninitializedDataArrays = 9,
            PutDataArraysResponse = 10,
            PutDataSubarraysResponse = 11,
            PutUninitializedDataArraysResponse = 12,
        }

        /// <summary>
        /// An enumeration of DiscoveryQuery protocol message types.
        /// </summary>
        public enum DiscoveryQuery
        {
            FindResources = 1,
            FindResourcesResponse = 2,
        }

        /// <summary>
        /// An enumeration of StoreQuery protocol message types.
        /// </summary>
        public enum StoreQuery
        {
            FindDataObjects = 1,
            FindDataObjectsResponse = 2,
            Chunk = 3,
        }

        /// <summary>
        /// An enumeration of GrowingObjectQuery protocol message types.
        /// </summary>
        public enum GrowingObjectQuery
        {
            FindParts = 1,
            FindPartsResponse = 2,
        }

        /// <summary>
        /// An enumeration of Transaction protocol message types.
        /// </summary>
        public enum Transaction
        {
            StartTransaction = 1,
            StartTransactionResponse = 2,
            CommitTransaction = 3,
            RollbackTransaction = 4,
            CommitTransactionResponse = 5,
            RollbackTransactionResponse = 6,
        }

        /// <summary>
        /// An enumeration of ChannelSubscribe protocol message types.
        /// </summary>
        public enum ChannelSubscribe
        {
            GetChannelMetadata = 1,
            GetChannelMetadataResponse = 2,
            SubscribeChannels = 3,
            ChannelData = 4,
            RangeReplaced = 6,
            UnsubscribeChannels = 7,
            SubscriptionsStopped = 8,
            GetRanges = 9,
            GetRangesResponse = 10,
            CancelGetRanges = 11,
            SubscribeChannelsResponse = 12,
            ChannelsTruncated = 13,
            GetChangeAnnotations = 14,
            GetChangeAnnotationsResponse = 15,
        }

        /// <summary>
        /// An enumeration of ChannelDataLoad protocol message types.
        /// </summary>
        public enum ChannelDataLoad
        {
            OpenChannels = 1,
            OpenChannelsResponse = 2,
            CloseChannels = 3,
            ChannelData = 4,
            ReplaceRange = 6,
            ChannelsClosed = 7,
            ReplaceRangeResponse = 8,
            TruncateChannels = 9,
            TruncateChannelsResponse = 10,
        }

        /// <summary>
        /// An enumeration of Dataspace protocol message types.
        /// </summary>
        public enum Dataspace
        {
            GetDataspaces = 1,
            GetDataspacesResponse = 2,
            PutDataspaces = 3,
            DeleteDataspaces = 4,
            DeleteDataspacesResponse = 5,
            PutDataspacesResponse = 6,
        }

        /// <summary>
        /// An enumeration of SupportedTypes protocol message types.
        /// </summary>
        public enum SupportedTypes
        {
            GetSupportedTypes = 1,
            GetSupportedTypesResponse = 2,
        }

        /// <summary>
        /// An enumeration of WitsmlSoap protocol message types.
        /// </summary>
        public enum WitsmlSoap
        {
            WMLS_AddToStore = 1,
            WMLS_AddToStoreResponse = 2,
            WMLS_DeleteFromStore = 3,
            WMLS_DeleteFromStoreResponse = 4,
            WMLS_GetBaseMsg = 5,
            WMLS_GetBaseMsgResponse = 6,
            WMLS_GetCap = 7,
            WMLS_GetCapResponse = 8,
            WMLS_GetFromStore = 9,
            WMLS_GetFromStoreResponse = 10,
            WMLS_GetVersion = 11,
            WMLS_GetVersionResponse = 12,
            WMLS_UpdateInStore = 13,
            WMLS_UpdateInStoreResponse = 14,
        }
    }
}
