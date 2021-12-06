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

using System.Collections.Generic;

namespace Energistics.Avro.Schemas.Types
{
    public class Primitive : Type
    {
        public static Primitive Null { get; } = new Primitive("null", true);
        public static Primitive Boolean { get; } = new Primitive("boolean", false);
        public static Primitive Int { get; } = new Primitive("int", false);
        public static Primitive Long { get; } = new Primitive("long", false);
        public static Primitive Float { get; } = new Primitive("float", false);
        public static Primitive Double { get; } = new Primitive("double", false);
        public static Primitive Bytes { get; } = new Primitive("bytes", false);
        public static Primitive String { get; } = new Primitive("string", false);
        public static IReadOnlyList<Primitive> Primitives { get; } = new List<Primitive> { Null, Boolean, Int, Long, Float, Double, Bytes, String };
        private static Dictionary<string, Primitive> PrimitivesByName { get; } = new Dictionary<string, Primitive>
        {
            [Null.Name] = Null,
            [Boolean.Name] = Boolean,
            [Int.Name] = Int,
            [Long.Name] = Long,
            [Float.Name] = Float,
            [Double.Name] = Double,
            [Bytes.Name] = Bytes,
            [String.Name] = String,
        };

        private Primitive(string name, bool isNull)
            : base(SchemaName.Create(name))
        {
            IsNull = isNull;
        }

        public override bool IsNull { get; }

        public static bool IsPrimitiveName(SchemaName name) => IsPrimitiveName(name.FullName);

        public static bool IsPrimitiveName(string name)
        {
            return name == Null.FullName
                || name == Boolean.FullName
                || name == Int.FullName
                || name == Long.FullName
                || name == Float.FullName
                || name == Double.FullName
                || name == Bytes.FullName
                || name == String.FullName;
        }

        public static Primitive GetPrimitive(SchemaName name) => GetPrimitive(name.FullName);

        public static Primitive GetPrimitive(string name)
        {
            if (!PrimitivesByName.TryGetValue(name, out Primitive primitive))
                throw new System.ArgumentException($"Unrecognized primitive name: '{name}'.");

            return primitive;
        }

        public static string GetDescriptor(string typeName) => typeName;

        public static string GetCanonicalSchema(string typeName) => $"\"{typeName}\"";
    }
}
