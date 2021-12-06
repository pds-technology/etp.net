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

using Energistics.Avro.Schemas.Types;

namespace Energistics.CodeGen.Avro.Code.TypeInfos
{
    public class FixedInfo : AvroObjectInfo
    {
        public FixedInfo(Fixed @fixed, string avroName, string avroNamespace, string name, string @namespace, long size)
            : base(@fixed, avroName, avroNamespace, name, @namespace)
        {
            Size = size;
        }

        private FixedInfo(string name)
            : base(name)
        {
        }

        public override string MethodTypeInfix => "AvroObject";

        public override string TypeInfix => "Fixed";

        public override string BaseClassOrInterface => "IAvroFixed";

        public static FixedInfo TFixed { get; } = new FixedInfo("TFixed");

        public long Size { get; }
    }
}
