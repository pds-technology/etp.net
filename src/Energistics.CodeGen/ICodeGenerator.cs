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

namespace Energistics.CodeGen
{
    /// <summary>
    /// Common interface for code generators.
    /// </summary>
    public interface ICodeGenerator<TContext>
        where TContext : GenerationContext
    {
        /// <summary>
        /// The name of the generator.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Generates code within the specified context.
        /// </summary>
        /// <param name="context">The generation context.</param>
        void Generate(TContext context);
    }
}
