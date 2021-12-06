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

namespace Energistics.Etp.v12
{
    /// <summary>
    /// Provides string representations of ETP protocol names.
    /// </summary>
    public static partial class ProtocolNames
    {
        /// <summary>
        /// The dictionary of protocol names.
        /// </summary>
        public static Dictionary<int, string> Names { get; } = new Dictionary<int, string>()
        {
            [0] = "Core",
            [1] = "ChannelStreaming",
            [2] = "ChannelDataFrame",
            [3] = "Discovery",
            [4] = "Store",
            [5] = "StoreNotification",
            [6] = "GrowingObject",
            [7] = "GrowingObjectNotification",
            [9] = "DataArray",
            [13] = "DiscoveryQuery",
            [14] = "StoreQuery",
            [16] = "GrowingObjectQuery",
            [18] = "Transaction",
            [21] = "ChannelSubscribe",
            [22] = "ChannelDataLoad",
            [24] = "Dataspace",
            [25] = "SupportedTypes",
            [2100] = "WitsmlSoap",
        };
    }
}
