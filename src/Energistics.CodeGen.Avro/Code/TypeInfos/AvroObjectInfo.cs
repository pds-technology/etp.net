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
    public class AvroObjectInfo : NamedTypeInfo
    {
        protected AvroObjectInfo(Record record, string avroName, string avroNamespace, string name, string @namespace)
            : base(record, avroName, avroNamespace, name, @namespace)
        {
        }

        protected AvroObjectInfo(Fixed @fixed, string avroName, string avroNamespace, string name, string @namespace)
            : base(@fixed, avroName, avroNamespace, name, @namespace)
        {
        }

        protected AvroObjectInfo(string name)
            : base(null, name, null, name, null)
        {
        }

        public override string VariableInitializer => $"new {InstanceType}()";

        public static AvroObjectInfo TAvroObject { get; } = new AvroObjectInfo("TAvroObject");

        public override string TypeInfix => "AvroObject";

        public override string VariablePrefix => "o";

        public override string MethodParameterName => "@object";

        public override string BaseClassOrInterface => "IAvroObject";

        public override bool HasGenericConstraint => true;

        public override bool IsStruct => false;
    }
}
