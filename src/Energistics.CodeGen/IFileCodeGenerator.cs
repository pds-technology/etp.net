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

using Energistics.CodeGen.Code;

namespace Energistics.CodeGen
{
    /// <summary>
    /// Common interface for file code generators.
    /// </summary>
    public interface IFileCodeGenerator<TContext>
        where TContext : GenerationContext
    {
        /// <summary>
        /// The namespace that this generator creates code in.
        /// </summary>
        string Namespace { get; }

        /// <summary>
        /// The file name for the generated code.
        /// </summary>
        string FileName { get; }

        /// <summary>
        /// Method that generates the output file for this generator.
        /// </summary>
        /// <param name="context">The generation context.</param>
        /// <param name="writer">The writer to write generated content to.</param>
        void Generate(TContext context, CodeWriter writer);
    }
}
