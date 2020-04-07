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
            ProtocolException = 1000,
            Acknowledge = 1001
        }

        /// <summary>
        /// An enumeration of Channel Streaming protocol message types.
        /// </summary>
        public enum ChannelStreaming
        {           
            ChannelMetadata = 1,
            ChannelData = 2,
            StartStreaming = 3,
            StopStreaming = 4
        }
        

        /// <summary>
        /// An enumeration of Discovery protocol message types.
        /// </summary>
        public enum Discovery
        {
            GetResources = 1,
            GetResourcesResponse = 4,
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
            Chunk = 8
        }

        /// <summary>
        /// An enumeration of Store Notification protocol message types.
        /// </summary>
        public enum StoreNotification
        {
            ObjectChanged= 2,
            ObjectDeleted = 3,
            UnsubscribeNotifications = 4,
            ObjectAccessRevoked = 5,
            SubscribeNotifications = 6,
            SubscriptionEnded = 7,
            UnsolicitedStoreNotifications = 8,
            Chunk = 9
        }

        /// <summary>
        /// An enumeration of Growing Object protocol message types.
        /// </summary>
        public enum GrowingObject
        {
            DeleteParts = 1,
            DeletePartsByRange = 2,
            GetParts = 3,
            GetPartsByRange = 4,
            PutParts = 5,
            GetPartsResponse = 6,
            ReplacePartsByRange = 7,
            GetPartsMetadata = 8,
            GetPartsMetadataResponse = 9,            
            GetPartsByRangeResponse = 10
        }

        /// <summary>
        /// An enumeration of Data Array protocol message types.
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
            PutUninitializedDataArray = 9            
        }

        /// <summary>
        /// An enumeration of ChannelDataLoad protocol message types.
        /// </summary>
        public enum ChannelDataLoad
        {
            OpenChannels = 1,
            OpenChannelsResponse = 2,
            CloseChannel = 3,
            RealtimeData = 4,
            ReplaceRange = 6,
            ChannelClosed = 7
        }

        /// <summary>
        /// An enumeration of ChannelSubscribe protocol message types.
        /// </summary>
        public enum ChannelSubscribe
        {         
            GetChannelMetadata = 1,
            GetChannelMetadataResponse = 2,
            SubscribeChannels = 3,
            RealtimeData = 4,
            ReplaceRange = 6,
            UnsubscribeChannels = 7,
            SubscriptionsStopped = 8,
            GetRanges = 9,
            GetRangesResponse = 10,
            CancelGetRanges = 11,
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
        }

        /// <summary>
        /// An enumeration of DiscoveryQuery protocol message types.
        /// </summary>
        public enum DiscoveryQuery
        {
            FindResources = 1,
            FindResourcesResponse = 2
        }

        /// <summary>
        /// An enumeration of GrowingObjectNotification protocol message types.
        /// </summary>
        public enum GrowingObjectNotification
        {
            PartsChanged = 2,
            PartsDeleted = 3,
            UnsubscribePartNotification = 4,
            PartsDeletedByRange = 5,
            PartsReplacedByRange = 6,
            SubscribePartNotification = 7,
            PartSubscriptionEnded = 8,
            UnsolicitedPartNotifications = 9
        }

        /// <summary>
        /// An enumeration of GrowingObjectQuery protocol message types.
        /// </summary>
        public enum GrowingObjectQuery
        {
            FindParts = 1,
            FindPartsResponse = 2
        }

        /// <summary>
        /// An enumeration of StoreQuery protocol message types.
        /// </summary>
        public enum StoreQuery
        {
            FindObjects = 1,
            FindObjectsResponse = 2,
            Chunk = 3
        }

        /// <summary>
        /// An enumeration of SupportedTypes protocol message types.
        /// </summary>
        public enum SupportedTypes
        {
            GetSupportedTypes = 1,
            GetSupportedTypesResponse = 2
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
            CommitTransactionResponse = 5
        }

        /// <summary>
        /// An enumeration of Witsml Soap protocol message types.
        /// </summary>
        public enum WitsmlSoap
        {
            WMLS_AddToStore = 1,
            WMLS_AddToStoreResponse,
            WMLS_DeleteFromStore,
            WMLS_DeleteFromStoreResponse,
            WMLS_GetBaseMsg,
            WMLS_GetBaseMsgResponse,
            WMLS_GetCap,
            WMLS_GetCapResponse,
            WMLS_GetFromStore,
            WMLS_GetFromStoreResponse,
            WMLS_GetVersion,
            WMLS_GetVersionResponse,
            WMLS_UpdateInStore,
            WMLS_UpdateInStoreResponse
        }
    }
}
