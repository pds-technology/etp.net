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
using Energistics.Json.Tokens;
using System.Collections.Generic;
using System.Linq;

namespace Energistics.Avro.Schemas
{
    internal static class JsonExtensions
    {
        internal static string Name(this Token token) => token.GetValue("name");

        internal static string Namespace(this Token token) => token.GetValue("namespace");

        internal static string Doc(this Token token) => token.GetValue("doc");

        internal static IEnumerable<string> Aliases(this Token token) => token.GetArray("aliases")?.Cast<String>().Select(t => t.GetValue()) ?? Enumerable.Empty<string>();

        internal static bool IsLogicalType(this Token token) => token.LogicalType() != null;

        internal static string LogicalType(this Token token) => token.GetValue("logicalType");

        internal static bool HasSymbols(this Token token) => token.GetArray("symbols") != null;

        internal static IEnumerable<string> Symbols(this Token token) => token.GetArray("symbols")?.Cast<String>().Select(t => t.GetValue()) ?? Enumerable.Empty<string>();

        internal static Token Default(this Token token) => token.GetToken("default");

        internal static Token Type(this Token token) => token.GetToken("type");

        internal static bool HasType(this Token token) => token.GetToken("type") != null;

        internal static bool IsProtocol(this Token token) => token.GetToken("protocol") != null;

        internal static bool IsComplexType(this Token token) => token.IsNamedType() || token.IsAvroMap() || token.IsAvroArray();

        internal static bool HasName(this Token token) => !string.IsNullOrEmpty(token.Name());

        internal static bool IsNamedType(this Token token) => token.IsFixed() || token.IsRecord() || token.IsEnum();

        internal static bool IsFixed(this Token token) => token.GetValue("type") == "fixed";

        internal static bool IsRecord(this Token token) => token.GetValue("type") == "record";

        internal static bool IsEnum(this Token token) => token.GetValue("type") == "enum";

        internal static bool IsAvroArray(this Token token) => token.GetValue("type") == "array";

        internal static bool IsAvroMap(this Token token) => token.GetValue("type") == "map";

        internal static bool HasSize(this Token token) => token.GetToken("size") != null;

        internal static long Size(this Token token) => token.GetLongValue("size");

        internal static bool IsUnion(this Token token) => token is Array;

        internal static Token Values(this Token token) => token.GetToken("values");

        internal static Token Items(this Token token) => token.GetToken("items");

        internal static Array Fields(this Token token) => token.GetArray("fields");
    }
}
