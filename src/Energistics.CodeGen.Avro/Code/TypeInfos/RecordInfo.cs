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
using System.Collections.Generic;
using System.Linq;

namespace Energistics.CodeGen.Avro.Code.TypeInfos
{
    public class RecordInfo : AvroObjectInfo
    {
        public RecordInfo(Record record, string avroName, string avroNamespace, string name, string @namespace)
            : base(record, avroName, avroNamespace, name, @namespace)
        {
        }

        private RecordInfo(string name)
            : base(name)
        {
        }

        public void SetFields(IEnumerable<string> avroFieldNames, IEnumerable<string> fieldNames, IEnumerable<TypeInfo> fieldTypeInfos)
        {
            AvroFieldNames = avroFieldNames?.ToList() ?? new List<string>();
            FieldNames = fieldNames?.ToList() ?? new List<string>();
            FieldTypeInfos = fieldTypeInfos?.ToList() ?? new List<TypeInfo>();
        }

        public override string BaseClassOrInterface => "IAvroRecord";

        public override string MethodTypeInfix => "AvroObject";

        public override string TypeInfix => "Record";

        public static RecordInfo TRecord { get; } = new RecordInfo("TRecord");

        public IReadOnlyList<string> AvroFieldNames { get; private set; }

        public IReadOnlyList<string> FieldNames { get; private set; }

        public IReadOnlyList<TypeInfo> FieldTypeInfos { get; private set; }
    }
}
