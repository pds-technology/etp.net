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

namespace Energistics.CodeGen.Code
{
    /// <summary>
    /// Scope for generated code.
    /// </summary>
    internal sealed class CodeScope
    {
        private Dictionary<string, int> Variables { get; } = new Dictionary<string, int>();

        public int IndentationLevel { get; set; }

        /// <summary>
        /// Gets a unique variable name within the scope starting with the prefix.
        /// </summary>
        /// <param name="prefix">The variable name prefix.</param>
        /// <returns>The unique variable name.</returns>
        public string GetUniqueVariable(string prefix)
        {
            if (Variables.TryGetValue(prefix, out var count))
            {
                Variables[prefix] = count + 1;
                return $"{prefix}{count + 1}";
            }
            else
            {
                Variables[prefix] = 1;
                return prefix;
            }
        }
    }
}
