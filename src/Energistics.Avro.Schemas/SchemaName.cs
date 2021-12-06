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

using Energistics.Json;
using System.Text.RegularExpressions;

namespace Energistics.Avro.Schemas
{
    public sealed class SchemaName
    {
        private SchemaName(string name, string @namespace)
        {
            Name = name;
            Namespace = @namespace;
        }

        public static SchemaName Create(Token token) => Create(token, null);

        public static SchemaName Create(Token token, SchemaName enclosingName)
        {
            var name = token.Name();
            var @namespace = token.Namespace();
            return Create(name, @namespace, enclosingName);
        }

        public static SchemaName Create(string name) => Create(name, null, null);

        public static SchemaName Create(string name, string @namespace, SchemaName enclosingName)
        {
            if (string.IsNullOrEmpty(@namespace))
                @namespace = enclosingName?.Namespace;

            if (IsPrimitiveName(name))
                @namespace = null;

            if (HasNamespace(name))
            {
                @namespace = GetNamespace(name);
                name = name.Substring(@namespace.Length + 1);
            }

            if (!string.IsNullOrEmpty(name) && !Regex.IsMatch(name, @"^[A-Za-z_][A-Za-z0-9_]*$", RegexOptions.CultureInvariant))
                throw new System.ArgumentException($"Invalid name: '{name}'.", nameof(name));
            if (!string.IsNullOrEmpty(@namespace) && !Regex.IsMatch(@namespace, @"^[A-Za-z_][A-Za-z0-9_]*(?:\.[A-Za-z_][A-Za-z0-9_]*)*$", RegexOptions.CultureInvariant))
                throw new System.ArgumentException($"Invalid namespace: '{@namespace}'.", nameof(@namespace));

            return new SchemaName(name, @namespace);
        }

        public string Name { get; }

        public string Namespace { get; }

        public string FullName => string.IsNullOrEmpty(Namespace) ? Name : $"{Namespace}.{Name}";

        private static bool HasNamespace(string name) => (name?.LastIndexOf('.') ?? -1) != -1;

        private static string GetNamespace(string name) => HasNamespace(name) ? name.Substring(0, name.LastIndexOf('.')) : null;

        private static bool IsPrimitiveName(string name)
        {
            switch (name)
            {
                case "null":
                case "boolean":
                case "int":
                case "long":
                case "float":
                case "double":
                case "bytes":
                case "string":
                    return true;
                default: return false;
            }
        }
    }
}
