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

namespace Energistics.CodeGen.Avro.Code
{
    public sealed class NamingOptions
    {
        public NamingStyle NamespaceNamingStyle { get; set; }
        public NamingStyle ClassNamingStyle { get; set; }
        public NamingStyle FieldNamingStyle { get; set; }
        public IReadOnlyDictionary<string, string> NamespaceSubstitutions { get; set; }

        public static NamingOptions Default { get; } = new NamingOptions
        {
            NamespaceNamingStyle = NamingStyle.AvroName,
            ClassNamingStyle = NamingStyle.AvroName,
            FieldNamingStyle = NamingStyle.AvroName,
            NamespaceSubstitutions = new Dictionary<string, string>(),
        };
    }
}
