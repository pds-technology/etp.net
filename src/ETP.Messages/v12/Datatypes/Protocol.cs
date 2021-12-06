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

using Energistics.Avro;

namespace Energistics.Etp.v12.Datatypes
{
    [AvroNamedType("Protocol", "Energistics.Etp.v12.Datatypes")]
    public enum Protocol
    {
        [AvroEnumSymbol("Core")]
        Core,
        [AvroEnumSymbol("ChannelStreaming")]
        ChannelStreaming,
        [AvroEnumSymbol("ChannelDataFrame")]
        ChannelDataFrame,
        [AvroEnumSymbol("Discovery")]
        Discovery,
        [AvroEnumSymbol("Store")]
        Store,
        [AvroEnumSymbol("StoreNotification")]
        StoreNotification,
        [AvroEnumSymbol("GrowingObject")]
        GrowingObject,
        [AvroEnumSymbol("GrowingObjectNotification")]
        GrowingObjectNotification,
        [AvroEnumSymbol("DEPRECATED_8")]
        DEPRECATED_8,
        [AvroEnumSymbol("DataArray")]
        DataArray,
        [AvroEnumSymbol("RESERVED_10")]
        RESERVED_10,
        [AvroEnumSymbol("RESERVED_11")]
        RESERVED_11,
        [AvroEnumSymbol("RESERVED_12")]
        RESERVED_12,
        [AvroEnumSymbol("DiscoveryQuery")]
        DiscoveryQuery,
        [AvroEnumSymbol("StoreQuery")]
        StoreQuery,
        [AvroEnumSymbol("RESERVED_15")]
        RESERVED_15,
        [AvroEnumSymbol("GrowingObjectQuery")]
        GrowingObjectQuery,
        [AvroEnumSymbol("RESERVED_17")]
        RESERVED_17,
        [AvroEnumSymbol("Transaction")]
        Transaction,
        [AvroEnumSymbol("RESERVED_19")]
        RESERVED_19,
        [AvroEnumSymbol("RESERVED_20")]
        RESERVED_20,
        [AvroEnumSymbol("ChannelSubscribe")]
        ChannelSubscribe,
        [AvroEnumSymbol("ChannelDataLoad")]
        ChannelDataLoad,
        [AvroEnumSymbol("RESERVED_23")]
        RESERVED_23,
        [AvroEnumSymbol("Dataspace")]
        Dataspace,
        [AvroEnumSymbol("SupportedTypes")]
        SupportedTypes,
    }
}
