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

namespace Energistics.CodeGen.Avro.Code.TypeInfos
{
    public class PrimitiveInfo : TypeInfo
    {
        private PrimitiveInfo(Primitive primitive, string avroName, string name, string typeInfix, string variablePrefix, string methodParameterName, bool isStruct, bool isNull)
            : base(primitive, avroName, null, name, null)
        {
            TypeInfix = typeInfix;
            VariablePrefix = variablePrefix;
            MethodParameterName = methodParameterName;
            IsStruct = isStruct;
            IsNull = isNull;
        }

        public static PrimitiveInfo Null { get; } = new PrimitiveInfo(Primitive.Null, "null", "object", "Null", "o", "@null", isStruct: false, isNull: true);

        public static PrimitiveInfo Boolean { get; } = new PrimitiveInfo(Primitive.Boolean, "boolean", "bool", "Boolean", "b", "boolean", isStruct: true, isNull: false);

        public static PrimitiveInfo Int { get; } = new PrimitiveInfo(Primitive.Int, "int", "int", "Int", "i", "@int", isStruct: true, isNull: false);

        public static PrimitiveInfo Long { get; } = new PrimitiveInfo(Primitive.Long, "long", "long", "Long", "l", "@long", isStruct: true, isNull: false);

        public static PrimitiveInfo Float { get; } = new PrimitiveInfo(Primitive.Float, "float", "float", "Float", "f", "@float", isStruct: true, isNull: false);

        public static PrimitiveInfo Double { get; } = new PrimitiveInfo(Primitive.Double, "double", "double", "Double", "d", "@double", isStruct: true, isNull: false);

        public static PrimitiveInfo String { get; } = new PrimitiveInfo(Primitive.String, "string", "string", "String", "s", "@string", isStruct: false, isNull: false);

        public static PrimitiveInfo Bytes { get; } = new PrimitiveInfo(Primitive.Bytes, "bytes", "byte[]", "Bytes", "b", "bytes", isStruct: false, isNull: false);

        internal static PrimitiveInfo MapKey { get; } = new PrimitiveInfo(Primitive.String, "string", "string", "MapKey", "k", "key", false, false);

        public static IReadOnlyList<PrimitiveInfo> PrimitiveInfos { get; } = new List<PrimitiveInfo> { Null, Boolean, Int, Long, Float, Double, String, Bytes };

        private static Dictionary<string, PrimitiveInfo> PrimitiveInfosByName { get; } = new Dictionary<string, PrimitiveInfo>
        {
            [Null.AvroName] = Null,
            [Boolean.AvroName] = Boolean,
            [Int.AvroName] = Int,
            [Long.AvroName] = Long,
            [Float.AvroName] = Float,
            [Double.AvroName] = Double,
            [Bytes.AvroName] = Bytes,
            [String.AvroName] = String,
        };

        public override string VariablePrefix { get; }

        public override string MethodParameterName { get; }

        public override string TypeInfix { get; }

        public override bool HasGenericConstraint => false;

        public override bool IsNull { get; }

        public override bool IsStruct { get; }

        public static PrimitiveInfo GetPrimitiveInfo(string name)
        {
            if (!PrimitiveInfosByName.TryGetValue(name, out PrimitiveInfo primitiveInfo))
                throw new System.ArgumentException($"Unrecognized primitive name: '{name}'.");

            return primitiveInfo;
        }
    }
}
