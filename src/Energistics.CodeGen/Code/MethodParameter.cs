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

namespace Energistics.CodeGen.Code
{
    /// <summary>
    /// Represents a method parameter
    /// </summary>
    public sealed class MethodParameter
    {
        /// <summary>
        /// The type of the parameter
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The name of the parameter
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The default value for the parameter, if any.
        /// </summary>
        public string DefaultValue { get; set; }

        public string Declaration => $"{Type} {Name}{(string.IsNullOrEmpty(DefaultValue) ? string.Empty : $" = {DefaultValue}")}";
    }
}
