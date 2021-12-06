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
    /// Abstract base class for generating code for a single output file.
    /// </summary>
    /// <typeparam name="TContext">The generation context type.</typeparam>
    public abstract class FileCodeGenerator<TContext> : IFileCodeGenerator<TContext>
        where TContext : GenerationContext
    {
        /// <summary>
        /// Initializes a new <see cref="FileCodeGenerator{TContext}"/> instance.
        /// </summary>
        /// <param name="namespace">The namespace that this generator creates code in.</param>
        /// <param name="fileName">The file name for the generated code.</param>
        protected FileCodeGenerator(string @namespace, string fileName)
        {
            Namespace = @namespace;
            FileName = fileName;
        }

        /// <summary>
        /// The namespace that this generator creates code in.
        /// </summary>
        public string Namespace { get; }

        /// <summary>
        /// The file name for the generated code.
        /// </summary>
        public string FileName { get; }

        /// <summary>
        /// Abstract method that derived classes must implement to generate the output file for this generator.
        /// </summary>
        /// <param name="context">The generation context.</param>
        /// <param name="writer">The writer to write generated content to.</param>
        public abstract void Generate(TContext context, CodeWriter writer);
    }
}
