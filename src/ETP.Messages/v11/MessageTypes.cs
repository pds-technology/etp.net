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

namespace Energistics.Etp.v11
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
            Acknowledge = 1001,
        }

        /// <summary>
        /// An enumeration of ChannelStreaming protocol message types.
        /// </summary>
        public enum ChannelStreaming
        {
            Start = 0,
            ChannelDescribe = 1,
            ChannelMetadata = 2,
            ChannelData = 3,
            ChannelStreamingStart = 4,
            ChannelStreamingStop = 5,
            ChannelDataChange = 6,
            ChannelRemove = 8,
            ChannelRangeRequest = 9,
            ChannelStatusChange = 10,
        }

        /// <summary>
        /// An enumeration of ChannelDataFrame protocol message types.
        /// </summary>
        public enum ChannelDataFrame
        {
            RequestChannelData = 1,
            ChannelMetadata = 3,
            ChannelDataFrameSet = 4,
        }

        /// <summary>
        /// An enumeration of Discovery protocol message types.
        /// </summary>
        public enum Discovery
        {
            GetResources = 1,
            GetResourcesResponse = 2,
        }

        /// <summary>
        /// An enumeration of Store protocol message types.
        /// </summary>
        public enum Store
        {
            GetObject = 1,
            PutObject = 2,
            DeleteObject = 3,
            Object = 4,
        }

        /// <summary>
        /// An enumeration of StoreNotification protocol message types.
        /// </summary>
        public enum StoreNotification
        {
            NotificationRequest = 1,
            ChangeNotification = 2,
            DeleteNotification = 3,
            CancelNotification = 4,
        }

        /// <summary>
        /// An enumeration of GrowingObject protocol message types.
        /// </summary>
        public enum GrowingObject
        {
            GrowingObjectDelete = 1,
            GrowingObjectDeleteRange = 2,
            GrowingObjectGet = 3,
            GrowingObjectGetRange = 4,
            GrowingObjectPut = 5,
            ObjectFragment = 6,
        }

        /// <summary>
        /// An enumeration of DataArray protocol message types.
        /// </summary>
        public enum DataArray
        {
            DataArray = 1,
            GetDataArray = 2,
            GetDataArraySlice = 3,
            PutDataArray = 4,
            PutDataArraySlice = 5,
        }

        /// <summary>
        /// An enumeration of WitsmlSoap protocol message types.
        /// </summary>
        public enum WitsmlSoap
        {
            WMLS_AddToStore = 1,
            WMSL_AddToStoreResponse = 2,
            WMLS_DeleteFromStore = 3,
            WMSL_DeleteFromStoreResponse = 4,
            WMLS_GetBaseMsg = 5,
            WMSL_GetBaseMsgResponse = 6,
            WMLS_GetCap = 7,
            WMSL_GetCapResponse = 8,
            WMLS_GetFromStore = 9,
            WMSL_GetFromStoreResponse = 10,
            WMLS_GetVersion = 11,
            WMSL_GetVersionResponse = 12,
            WMLS_UpdateInStore = 13,
            WMSL_UpdateInStoreResponse = 14,
        }
    }
}
