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

using Energistics.Avro.Schemas;
using System.Collections.Generic;
using System.Linq;

namespace Energistics.CodeGen.Avro.Code
{
    public static class TypeExtensions
    {
        public static string GetNamespace(this Type type, NamingOptions namingOptions)
        {
            if (string.IsNullOrEmpty(type.Namespace))
                return string.Empty;

            var @namespace = type.Namespace;
            foreach (var kvp in namingOptions.NamespaceSubstitutions)
            {
                if (kvp.Key == @namespace || @namespace.StartsWith($"{kvp.Key}."))
                {
                    @namespace = kvp.Value + @namespace.Substring(kvp.Key.Length);
                    break;
                }
            }

            var components = @namespace.Split('.').Select(s =>
            {
                switch (namingOptions.NamespaceNamingStyle)
                {
                    case NamingStyle.AvroName: return s.ToSafeName();
                    case NamingStyle.PascalCase: return s.ToPascalCase();
                    default: throw new System.ArgumentException($"Invalid NamingStyle: {namingOptions.ClassNamingStyle}");
                }
            });
            
            return string.Join(".", components);
        }

        public static string GetClassName(this Type type, NamingOptions namingOptions)
        {
            switch (namingOptions.ClassNamingStyle)
            {
                case NamingStyle.AvroName: return type.Name.ToSafeName();
                case NamingStyle.PascalCase: return type.Name.ToPascalCase();
                default: throw new System.ArgumentException($"Invalid NamingStyle: {namingOptions.ClassNamingStyle}");
            }
        }

        public static string GetFieldName(this Type type, string fieldName, NamingOptions namingOptions)
        {
            switch (namingOptions.FieldNamingStyle)
            {
                case NamingStyle.AvroName: return fieldName.ToSafeName();
                case NamingStyle.PascalCase: return fieldName.ToPascalCase();
                default: throw new System.ArgumentException($"Invalid NamingStyle: {namingOptions.FieldNamingStyle}");
            }
        }

        private static HashSet<string> ReservedWords = new HashSet<string>
        {
            "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked", "class", "const", "continue", "decimal", "default", "delegate", "do", "double",
            "else", "enum", "event", "explicit", "extern", "false", "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal",
            "is", "lock", "long", "namespace", "new", "null", "object", "operator", "out", "override", "params", "private", "protected", "public", "readonly", "ref", "return",
            "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked",
            "unsafe", "ushort", "using", "virtual", "void", "volatile", "while"
        };

        private static string ToPascalCase(this string s) => string.IsNullOrEmpty(s) ? s : s.Substring(0, 1).ToUpperInvariant() + s.Substring(1);

        private static string ToSafeName(this string s) => ReservedWords.Contains(s) ? $"@{s}" : s;
    }
}
