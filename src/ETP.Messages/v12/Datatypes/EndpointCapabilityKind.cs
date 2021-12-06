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
    [AvroNamedType("EndpointCapabilityKind", "Energistics.Etp.v12.Datatypes")]
    public enum EndpointCapabilityKind
    {
        [AvroEnumSymbol("ActiveTimeoutPeriod")]
        ActiveTimeoutPeriod,
        [AvroEnumSymbol("AuthorizationDetails")]
        AuthorizationDetails,
        [AvroEnumSymbol("ChangePropagationPeriod")]
        ChangePropagationPeriod,
        [AvroEnumSymbol("ChangeRetentionPeriod")]
        ChangeRetentionPeriod,
        [AvroEnumSymbol("MaxConcurrentMultipart")]
        MaxConcurrentMultipart,
        [AvroEnumSymbol("MaxDataObjectSize")]
        MaxDataObjectSize,
        [AvroEnumSymbol("MaxPartSize")]
        MaxPartSize,
        [AvroEnumSymbol("MaxSessionClientCount")]
        MaxSessionClientCount,
        [AvroEnumSymbol("MaxSessionGlobalCount")]
        MaxSessionGlobalCount,
        [AvroEnumSymbol("MaxWebSocketFramePayloadSize")]
        MaxWebSocketFramePayloadSize,
        [AvroEnumSymbol("MaxWebSocketMessagePayloadSize")]
        MaxWebSocketMessagePayloadSize,
        [AvroEnumSymbol("MultipartMessageTimeoutPeriod")]
        MultipartMessageTimeoutPeriod,
        [AvroEnumSymbol("ResponseTimeoutPeriod")]
        ResponseTimeoutPeriod,
        [AvroEnumSymbol("RequestSessionTimeoutPeriod")]
        RequestSessionTimeoutPeriod,
        [AvroEnumSymbol("SessionEstablishmentTimeoutPeriod")]
        SessionEstablishmentTimeoutPeriod,
        [AvroEnumSymbol("SupportsAlternateRequestUris")]
        SupportsAlternateRequestUris,
        [AvroEnumSymbol("SupportsMessageHeaderExtensions")]
        SupportsMessageHeaderExtensions,
    }
}
