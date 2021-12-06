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

namespace Energistics.Avro.Schemas.Navigation
{
    public sealed class NavigationContext
    {
        public NavigationContext(SchemaName schemaName)
        {
            EnclosingName = schemaName?.Name;
            EnclosingNamespace = schemaName?.Namespace;
            EnclosingFullName = schemaName?.FullName;
        }

        public NavigationContext(SchemaName schemaName, string fieldName)
        {
            EnclosingName = schemaName?.Name;
            EnclosingNamespace = schemaName?.Namespace;
            EnclosingFullName = schemaName?.FullName;
            EnclosingFieldName = fieldName;
        }

        public NavigationContext(Type type)
        {
            EnclosingName = type?.Name;
            EnclosingNamespace = type?.Namespace;
            EnclosingFullName = type?.FullName;
        }

        public NavigationContext(Type type, string fieldName)
        {
            EnclosingName = type?.Name;
            EnclosingNamespace = type?.Namespace;
            EnclosingFullName = type?.FullName;
            EnclosingFieldName = fieldName;
        }

        public string EnclosingName { get; }

        public string EnclosingNamespace { get; }

        public string EnclosingFullName { get; }

        public string EnclosingFieldName { get; }
    }
}
