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

using Energistics.CodeGen.Avro.Code;
using Energistics.CodeGen.Avro.Code.TypeInfos;
using Energistics.Json;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Energistics.CodeGen.Etp.Code
{
    internal static class TypeInfoExtensions
    {
        public static IEnumerable<RecordInfo> RecordInfoMessageBodies(this TypeInfoCollection typeInfoCollection)
            => typeInfoCollection.TypeInfosByName.Values.Where(t => t is RecordInfo).Cast<RecordInfo>().Where(r => r.IsMessageBody()).OrderBy(r => r.ProtocolNumber()).ThenBy(r => r.MessageType());

        public static bool IsMessageBody(this RecordInfo recordInfo) => recordInfo?.Type?.Token?.GetValue("protocol") != null;

        public static int ProtocolNumber(this RecordInfo recordInfo) => int.Parse(recordInfo?.Type?.Token?.GetValue("protocol") ?? "-1", NumberStyles.Integer, CultureInfo.InvariantCulture);

        public static string ProtocolName(this RecordInfo recordInfo) => recordInfo?.Namespace.Split('.').LastOrDefault();

        public static int MessageType(this RecordInfo recordInfo) => int.Parse(recordInfo?.Type?.Token?.GetValue("messageType") ?? "-1", NumberStyles.Integer, CultureInfo.InvariantCulture);

        public static bool IsMultiPart(this RecordInfo recordInfo) => recordInfo?.Type?.Token?.GetBoolValue("multipartFlag") ?? false;
        public static IEnumerable<IGrouping<int, RecordInfo>> GroupedByProtocol(this IEnumerable<RecordInfo> enumerable) => enumerable.GroupBy(r => r.ProtocolNumber());
    }
}
