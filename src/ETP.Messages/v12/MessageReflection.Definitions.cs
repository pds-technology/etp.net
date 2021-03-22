﻿using System;
using System.Collections.Generic;


namespace Energistics.Etp.v12
{
    /// <summary>
    /// Provides ETP message information by message type.
    /// </summary>
    public static partial class MessageReflection
    {
        /// <summary>
        /// The hash set of ETP messages.
        /// </summary>
        private static Dictionary<Type, int> ProtocolByMessage { get; } = new Dictionary<Type, int>
        {
            [typeof(Energistics.Etp.v12.Protocol.Core.RequestSession)] = 0,
            [typeof(Energistics.Etp.v12.Protocol.Core.OpenSession)] = 0,
            [typeof(Energistics.Etp.v12.Protocol.Core.CloseSession)] = 0,
            [typeof(Energistics.Etp.v12.Protocol.Core.RenewSecurityToken)] = 0,
            [typeof(Energistics.Etp.v12.Protocol.Core.RenewSecurityTokenResponse)] = 0,
            [typeof(Energistics.Etp.v12.Protocol.Core.Ping)] = 0,
            [typeof(Energistics.Etp.v12.Protocol.Core.Pong)] = 0,
            [typeof(Energistics.Etp.v12.Protocol.Core.ProtocolException)] = 0,
            [typeof(Energistics.Etp.v12.Protocol.Core.Acknowledge)] = 0,
            [typeof(Energistics.Etp.v12.Protocol.ChannelStreaming.ChannelMetadata)] = 1,
            [typeof(Energistics.Etp.v12.Protocol.ChannelStreaming.ChannelData)] = 1,
            [typeof(Energistics.Etp.v12.Protocol.ChannelStreaming.StartStreaming)] = 1,
            [typeof(Energistics.Etp.v12.Protocol.ChannelStreaming.StopStreaming)] = 1,
            [typeof(Energistics.Etp.v12.Protocol.ChannelStreaming.TruncateChannels)] = 1,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameMetadata)] = 2,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameMetadataResponse)] = 2,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrame)] = 2,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameResponseHeader)] = 2,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataFrame.CancelGetFrame)] = 2,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameResponseRows)] = 2,
            [typeof(Energistics.Etp.v12.Protocol.Discovery.GetResources)] = 3,
            [typeof(Energistics.Etp.v12.Protocol.Discovery.GetResourcesResponse)] = 3,
            [typeof(Energistics.Etp.v12.Protocol.Discovery.GetDeletedResources)] = 3,
            [typeof(Energistics.Etp.v12.Protocol.Discovery.GetDeletedResourcesResponse)] = 3,
            [typeof(Energistics.Etp.v12.Protocol.Discovery.GetResourcesEdgesResponse)] = 3,
            [typeof(Energistics.Etp.v12.Protocol.Store.GetDataObjects)] = 4,
            [typeof(Energistics.Etp.v12.Protocol.Store.PutDataObjects)] = 4,
            [typeof(Energistics.Etp.v12.Protocol.Store.DeleteDataObjects)] = 4,
            [typeof(Energistics.Etp.v12.Protocol.Store.GetDataObjectsResponse)] = 4,
            [typeof(Energistics.Etp.v12.Protocol.Store.Chunk)] = 4,
            [typeof(Energistics.Etp.v12.Protocol.Store.PutDataObjectsResponse)] = 4,
            [typeof(Energistics.Etp.v12.Protocol.Store.DeleteDataObjectsResponse)] = 4,
            [typeof(Energistics.Etp.v12.Protocol.StoreNotification.ObjectChanged)] = 5,
            [typeof(Energistics.Etp.v12.Protocol.StoreNotification.ObjectDeleted)] = 5,
            [typeof(Energistics.Etp.v12.Protocol.StoreNotification.UnsubscribeNotifications)] = 5,
            [typeof(Energistics.Etp.v12.Protocol.StoreNotification.ObjectAccessRevoked)] = 5,
            [typeof(Energistics.Etp.v12.Protocol.StoreNotification.SubscribeNotifications)] = 5,
            [typeof(Energistics.Etp.v12.Protocol.StoreNotification.SubscriptionEnded)] = 5,
            [typeof(Energistics.Etp.v12.Protocol.StoreNotification.UnsolicitedStoreNotifications)] = 5,
            [typeof(Energistics.Etp.v12.Protocol.StoreNotification.Chunk)] = 5,
            [typeof(Energistics.Etp.v12.Protocol.StoreNotification.SubscribeNotificationsResponse)] = 5,
            [typeof(Energistics.Etp.v12.Protocol.StoreNotification.ObjectActiveStatusChanged)] = 5,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.DeleteParts)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.GetParts)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.GetPartsByRange)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.PutParts)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.GetPartsResponse)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.ReplacePartsByRange)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.GetPartsMetadata)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.GetPartsMetadataResponse)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.GetPartsByRangeResponse)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.DeletePartsResponse)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.PutPartsResponse)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.GetGrowingDataObjectsHeader)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.GetGrowingDataObjectsHeaderResponse)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.PutGrowingDataObjectsHeader)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.PutGrowingDataObjectsHeaderResponse)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.ReplacePartsByRangeResponse)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsChanged)] = 7,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsDeleted)] = 7,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObjectNotification.UnsubscribePartNotification)] = 7,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsReplacedByRange)] = 7,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObjectNotification.SubscribePartNotifications)] = 7,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartSubscriptionEnded)] = 7,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObjectNotification.UnsolicitedPartNotifications)] = 7,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObjectNotification.SubscribePartNotificationsResponse)] = 7,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.GetDataArraysResponse)] = 9,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.GetDataArrays)] = 9,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.GetDataSubarrays)] = 9,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.PutDataArrays)] = 9,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.PutDataSubarrays)] = 9,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.GetDataArrayMetadata)] = 9,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.GetDataArrayMetadataResponse)] = 9,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.GetDataSubarraysResponse)] = 9,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.PutUninitializedDataArrays)] = 9,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.PutDataArraysResponse)] = 9,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.PutDataSubarraysResponse)] = 9,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.PutUninitializedDataArraysResponse)] = 9,
            [typeof(Energistics.Etp.v12.Protocol.DiscoveryQuery.FindResources)] = 13,
            [typeof(Energistics.Etp.v12.Protocol.DiscoveryQuery.FindResourcesResponse)] = 13,
            [typeof(Energistics.Etp.v12.Protocol.StoreQuery.FindDataObjects)] = 14,
            [typeof(Energistics.Etp.v12.Protocol.StoreQuery.FindDataObjectsResponse)] = 14,
            [typeof(Energistics.Etp.v12.Protocol.StoreQuery.Chunk)] = 14,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObjectQuery.FindParts)] = 16,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObjectQuery.FindPartsResponse)] = 16,
            [typeof(Energistics.Etp.v12.Protocol.Transaction.StartTransaction)] = 18,
            [typeof(Energistics.Etp.v12.Protocol.Transaction.StartTransactionResponse)] = 18,
            [typeof(Energistics.Etp.v12.Protocol.Transaction.CommitTransaction)] = 18,
            [typeof(Energistics.Etp.v12.Protocol.Transaction.RollbackTransaction)] = 18,
            [typeof(Energistics.Etp.v12.Protocol.Transaction.CommitTransactionResponse)] = 18,
            [typeof(Energistics.Etp.v12.Protocol.Transaction.RollbackTransactionResponse)] = 18,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChannelMetadata)] = 21,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChannelMetadataResponse)] = 21,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscribeChannels)] = 21,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.ChannelData)] = 21,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.RangeReplaced)] = 21,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.UnsubscribeChannels)] = 21,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscriptionsStopped)] = 21,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.GetRanges)] = 21,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.GetRangesResponse)] = 21,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.CancelGetRanges)] = 21,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscribeChannelsResponse)] = 21,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.ChannelsTruncated)] = 21,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChangeAnnotations)] = 21,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChangeAnnotationsResponse)] = 21,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataLoad.OpenChannels)] = 22,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataLoad.OpenChannelsResponse)] = 22,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataLoad.CloseChannels)] = 22,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataLoad.ChannelData)] = 22,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataLoad.ReplaceRange)] = 22,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataLoad.ChannelsClosed)] = 22,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataLoad.ReplaceRangeResponse)] = 22,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataLoad.TruncateChannels)] = 22,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataLoad.TruncateChannelsResponse)] = 22,
            [typeof(Energistics.Etp.v12.Protocol.Dataspace.GetDataspaces)] = 24,
            [typeof(Energistics.Etp.v12.Protocol.Dataspace.GetDataspacesResponse)] = 24,
            [typeof(Energistics.Etp.v12.Protocol.Dataspace.PutDataspaces)] = 24,
            [typeof(Energistics.Etp.v12.Protocol.Dataspace.DeleteDataspaces)] = 24,
            [typeof(Energistics.Etp.v12.Protocol.Dataspace.DeleteDataspacesResponse)] = 24,
            [typeof(Energistics.Etp.v12.Protocol.Dataspace.PutDataspacesResponse)] = 24,
            [typeof(Energistics.Etp.v12.Protocol.SupportedTypes.GetSupportedTypes)] = 25,
            [typeof(Energistics.Etp.v12.Protocol.SupportedTypes.GetSupportedTypesResponse)] = 25,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_AddToStore)] = 2100,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_AddToStoreResponse)] = 2100,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_DeleteFromStore)] = 2100,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_DeleteFromStoreResponse)] = 2100,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetBaseMsg)] = 2100,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetBaseMsgResponse)] = 2100,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetCap)] = 2100,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetCapResponse)] = 2100,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetFromStore)] = 2100,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetFromStoreResponse)] = 2100,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetVersion)] = 2100,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetVersionResponse)] = 2100,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_UpdateInStore)] = 2100,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_UpdateInStoreResponse)] = 2100,
        };

        /// <summary>
        /// The hash set of ETP messages.
        /// </summary>
        private static Dictionary<Type, int> MessageTypeByMessage { get; } = new Dictionary<Type, int>
        {
            [typeof(Energistics.Etp.v12.Protocol.Core.RequestSession)] = 1,
            [typeof(Energistics.Etp.v12.Protocol.Core.OpenSession)] = 2,
            [typeof(Energistics.Etp.v12.Protocol.Core.CloseSession)] = 5,
            [typeof(Energistics.Etp.v12.Protocol.Core.RenewSecurityToken)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.Core.RenewSecurityTokenResponse)] = 7,
            [typeof(Energistics.Etp.v12.Protocol.Core.Ping)] = 8,
            [typeof(Energistics.Etp.v12.Protocol.Core.Pong)] = 9,
            [typeof(Energistics.Etp.v12.Protocol.Core.ProtocolException)] = 1000,
            [typeof(Energistics.Etp.v12.Protocol.Core.Acknowledge)] = 1001,
            [typeof(Energistics.Etp.v12.Protocol.ChannelStreaming.ChannelMetadata)] = 1,
            [typeof(Energistics.Etp.v12.Protocol.ChannelStreaming.ChannelData)] = 2,
            [typeof(Energistics.Etp.v12.Protocol.ChannelStreaming.StartStreaming)] = 3,
            [typeof(Energistics.Etp.v12.Protocol.ChannelStreaming.StopStreaming)] = 4,
            [typeof(Energistics.Etp.v12.Protocol.ChannelStreaming.TruncateChannels)] = 5,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameMetadata)] = 1,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameMetadataResponse)] = 2,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrame)] = 3,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameResponseHeader)] = 4,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataFrame.CancelGetFrame)] = 5,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataFrame.GetFrameResponseRows)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.Discovery.GetResources)] = 1,
            [typeof(Energistics.Etp.v12.Protocol.Discovery.GetResourcesResponse)] = 4,
            [typeof(Energistics.Etp.v12.Protocol.Discovery.GetDeletedResources)] = 5,
            [typeof(Energistics.Etp.v12.Protocol.Discovery.GetDeletedResourcesResponse)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.Discovery.GetResourcesEdgesResponse)] = 7,
            [typeof(Energistics.Etp.v12.Protocol.Store.GetDataObjects)] = 1,
            [typeof(Energistics.Etp.v12.Protocol.Store.PutDataObjects)] = 2,
            [typeof(Energistics.Etp.v12.Protocol.Store.DeleteDataObjects)] = 3,
            [typeof(Energistics.Etp.v12.Protocol.Store.GetDataObjectsResponse)] = 4,
            [typeof(Energistics.Etp.v12.Protocol.Store.Chunk)] = 8,
            [typeof(Energistics.Etp.v12.Protocol.Store.PutDataObjectsResponse)] = 9,
            [typeof(Energistics.Etp.v12.Protocol.Store.DeleteDataObjectsResponse)] = 10,
            [typeof(Energistics.Etp.v12.Protocol.StoreNotification.ObjectChanged)] = 2,
            [typeof(Energistics.Etp.v12.Protocol.StoreNotification.ObjectDeleted)] = 3,
            [typeof(Energistics.Etp.v12.Protocol.StoreNotification.UnsubscribeNotifications)] = 4,
            [typeof(Energistics.Etp.v12.Protocol.StoreNotification.ObjectAccessRevoked)] = 5,
            [typeof(Energistics.Etp.v12.Protocol.StoreNotification.SubscribeNotifications)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.StoreNotification.SubscriptionEnded)] = 7,
            [typeof(Energistics.Etp.v12.Protocol.StoreNotification.UnsolicitedStoreNotifications)] = 8,
            [typeof(Energistics.Etp.v12.Protocol.StoreNotification.Chunk)] = 9,
            [typeof(Energistics.Etp.v12.Protocol.StoreNotification.SubscribeNotificationsResponse)] = 10,
            [typeof(Energistics.Etp.v12.Protocol.StoreNotification.ObjectActiveStatusChanged)] = 11,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.DeleteParts)] = 1,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.GetParts)] = 3,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.GetPartsByRange)] = 4,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.PutParts)] = 5,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.GetPartsResponse)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.ReplacePartsByRange)] = 7,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.GetPartsMetadata)] = 8,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.GetPartsMetadataResponse)] = 9,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.GetPartsByRangeResponse)] = 10,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.DeletePartsResponse)] = 11,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.PutPartsResponse)] = 13,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.GetGrowingDataObjectsHeader)] = 14,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.GetGrowingDataObjectsHeaderResponse)] = 15,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.PutGrowingDataObjectsHeader)] = 16,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.PutGrowingDataObjectsHeaderResponse)] = 17,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObject.ReplacePartsByRangeResponse)] = 18,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsChanged)] = 2,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsDeleted)] = 3,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObjectNotification.UnsubscribePartNotification)] = 4,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartsReplacedByRange)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObjectNotification.SubscribePartNotifications)] = 7,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObjectNotification.PartSubscriptionEnded)] = 8,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObjectNotification.UnsolicitedPartNotifications)] = 9,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObjectNotification.SubscribePartNotificationsResponse)] = 10,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.GetDataArraysResponse)] = 1,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.GetDataArrays)] = 2,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.GetDataSubarrays)] = 3,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.PutDataArrays)] = 4,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.PutDataSubarrays)] = 5,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.GetDataArrayMetadata)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.GetDataArrayMetadataResponse)] = 7,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.GetDataSubarraysResponse)] = 8,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.PutUninitializedDataArrays)] = 9,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.PutDataArraysResponse)] = 10,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.PutDataSubarraysResponse)] = 11,
            [typeof(Energistics.Etp.v12.Protocol.DataArray.PutUninitializedDataArraysResponse)] = 12,
            [typeof(Energistics.Etp.v12.Protocol.DiscoveryQuery.FindResources)] = 1,
            [typeof(Energistics.Etp.v12.Protocol.DiscoveryQuery.FindResourcesResponse)] = 2,
            [typeof(Energistics.Etp.v12.Protocol.StoreQuery.FindDataObjects)] = 1,
            [typeof(Energistics.Etp.v12.Protocol.StoreQuery.FindDataObjectsResponse)] = 2,
            [typeof(Energistics.Etp.v12.Protocol.StoreQuery.Chunk)] = 3,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObjectQuery.FindParts)] = 1,
            [typeof(Energistics.Etp.v12.Protocol.GrowingObjectQuery.FindPartsResponse)] = 2,
            [typeof(Energistics.Etp.v12.Protocol.Transaction.StartTransaction)] = 1,
            [typeof(Energistics.Etp.v12.Protocol.Transaction.StartTransactionResponse)] = 2,
            [typeof(Energistics.Etp.v12.Protocol.Transaction.CommitTransaction)] = 3,
            [typeof(Energistics.Etp.v12.Protocol.Transaction.RollbackTransaction)] = 4,
            [typeof(Energistics.Etp.v12.Protocol.Transaction.CommitTransactionResponse)] = 5,
            [typeof(Energistics.Etp.v12.Protocol.Transaction.RollbackTransactionResponse)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChannelMetadata)] = 1,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChannelMetadataResponse)] = 2,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscribeChannels)] = 3,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.ChannelData)] = 4,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.RangeReplaced)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.UnsubscribeChannels)] = 7,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscriptionsStopped)] = 8,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.GetRanges)] = 9,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.GetRangesResponse)] = 10,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.CancelGetRanges)] = 11,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscribeChannelsResponse)] = 12,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.ChannelsTruncated)] = 13,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChangeAnnotations)] = 14,
            [typeof(Energistics.Etp.v12.Protocol.ChannelSubscribe.GetChangeAnnotationsResponse)] = 15,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataLoad.OpenChannels)] = 1,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataLoad.OpenChannelsResponse)] = 2,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataLoad.CloseChannels)] = 3,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataLoad.ChannelData)] = 4,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataLoad.ReplaceRange)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataLoad.ChannelsClosed)] = 7,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataLoad.ReplaceRangeResponse)] = 8,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataLoad.TruncateChannels)] = 9,
            [typeof(Energistics.Etp.v12.Protocol.ChannelDataLoad.TruncateChannelsResponse)] = 10,
            [typeof(Energistics.Etp.v12.Protocol.Dataspace.GetDataspaces)] = 1,
            [typeof(Energistics.Etp.v12.Protocol.Dataspace.GetDataspacesResponse)] = 2,
            [typeof(Energistics.Etp.v12.Protocol.Dataspace.PutDataspaces)] = 3,
            [typeof(Energistics.Etp.v12.Protocol.Dataspace.DeleteDataspaces)] = 4,
            [typeof(Energistics.Etp.v12.Protocol.Dataspace.DeleteDataspacesResponse)] = 5,
            [typeof(Energistics.Etp.v12.Protocol.Dataspace.PutDataspacesResponse)] = 6,
            [typeof(Energistics.Etp.v12.Protocol.SupportedTypes.GetSupportedTypes)] = 1,
            [typeof(Energistics.Etp.v12.Protocol.SupportedTypes.GetSupportedTypesResponse)] = 2,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_AddToStore)] = 1,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_AddToStoreResponse)] = 2,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_DeleteFromStore)] = 3,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_DeleteFromStoreResponse)] = 4,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetBaseMsg)] = 5,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetBaseMsgResponse)] = 6,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetCap)] = 7,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetCapResponse)] = 8,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetFromStore)] = 9,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetFromStoreResponse)] = 10,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetVersion)] = 11,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetVersionResponse)] = 12,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_UpdateInStore)] = 13,
            [typeof(Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_UpdateInStoreResponse)] = 14,
        };
    }
}