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
    public class UuidInfo : LogicalInfo
    {
        public UuidInfo(TypeInfo baseTypeInfo, string avroName, string avroNamespace, string name, string @namespace, string encodingStyle, bool isStruct)
            : base(baseTypeInfo, avroName, avroNamespace, name, @namespace, "uuid", "Uuid", encodingStyle, isStruct)
        {
        }

        private UuidInfo(TypeInfo baseTypeInfo, TypeInfo defaultBaseTypeInfo, string name, string @namespace, string encodingStyle, bool isStruct)
            : this(baseTypeInfo ?? defaultBaseTypeInfo, (baseTypeInfo ?? defaultBaseTypeInfo)?.AvroName, (baseTypeInfo ?? defaultBaseTypeInfo)?.AvroNamespace, name, @namespace, encodingStyle, isStruct)
        {
        }

        public static UuidInfo UuidGuidAsRfc4122String(TypeInfo baseTypeInfo = null) => new UuidInfo(baseTypeInfo, PrimitiveInfo.String, "Guid", "System", "Rfc4122String", true);
        public static UuidInfo UuidGuidAsBytes(TypeInfo baseTypeInfo = null) => new UuidInfo(baseTypeInfo, PrimitiveInfo.Bytes, "Guid", "System", "Bytes", true);
        public static UuidInfo UuidGuidAsFixed(TypeInfo baseTypeInfo = null) => new UuidInfo(baseTypeInfo, FixedInfo.TFixed, "Guid", "System", "Fixed", true);
    }
}
