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

namespace Energistics.CodeGen.Avro.Code.TypeInfos.LogicalTypeInfos
{
    public class TimestampInfo : LogicalInfo
    {
        public TimestampInfo(TypeInfo baseTypeInfo, string avroName, string avroNamespace, string name, string @namespace, string encodingStyle, bool isStruct)
            : base(baseTypeInfo, avroName, avroNamespace, name, @namespace, "timestamp", "Timestamp", encodingStyle, isStruct)
        {
        }

        private TimestampInfo(TypeInfo baseTypeInfo, TypeInfo defaultBaseTypeInfo, string name, string @namespace, string encodingStyle, bool isStruct)
            : this(baseTypeInfo ?? defaultBaseTypeInfo, (baseTypeInfo ?? defaultBaseTypeInfo)?.AvroName, (baseTypeInfo ?? defaultBaseTypeInfo)?.AvroNamespace, name, @namespace, encodingStyle, isStruct)
        {
        }

        public static TimestampInfo TimestampDateTimeAsIso8601String(TypeInfo baseTypeInfo = null) => new TimestampInfo(baseTypeInfo, PrimitiveInfo.String, "DateTime", "System", "Iso8601String", true);
        public static TimestampInfo TimestampDateTimeOffsetAsIso8601String(TypeInfo baseTypeInfo = null) => new TimestampInfo(baseTypeInfo, PrimitiveInfo.String, "DateTimeOffset", "System", "Iso8601String", true);
    }
}
