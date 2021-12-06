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
using System;
using System.Collections.Generic;
using System.IO;

namespace Energistics.CodeGen
{
    /// <summary>
    /// Abstract base class for code generators.
    /// </summary>
    /// <typeparam name="TContext">The generation context type.</typeparam>
    public abstract class CodeGenerator<TContext> : ICodeGenerator<TContext>
        where TContext : GenerationContext
    {
        private List<IFileCodeGenerator<TContext>> Generators { get; } = new List<IFileCodeGenerator<TContext>>();

        /// <summary>
        /// Generates code within the specified context.
        /// </summary>
        /// <param name="context">The generation context.</param>
        public void Generate(TContext context)
        {
            RegisterAllGenerators(context);

            foreach (var generator in Generators)
            {
                Console.WriteLine($"Generating {generator.FileName}...");
                GenerateInContext(context, generator);
            }
        }

        /// <summary>
        /// The name of the generator.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Abstract method that must be overridden in derived classes to provide the code generators for the project.
        /// </summary>
        /// <param name="context">The generation context.</param>
        protected abstract void RegisterAllGenerators(TContext context);

        /// <summary>
        /// Registers a specific generator instance.
        /// </summary>
        /// <typeparam name="TContext">The type of generation context used by the generator.</typeparam>
        /// <param name="generator">The generator instance to register.</param>
        protected void RegisterGenerator(IFileCodeGenerator<TContext> generator)
        {
            Generators.Add(generator);
        }

        /// <summary>
        /// Executes a generation function accepting a <see cref="TextWriter"/> as input in the specified generation context.
        /// </summary>
        /// <param name="context">The generation context.</param>
        /// <param name="generator">The generation function to call with the <see cref="TextWriter"/>.</param>
        protected static void GenerateInContext(TContext context, IFileCodeGenerator<TContext> generator)
        {
            var outputFilePath = GetOutputFilePath(context, generator.Namespace, generator.FileName);
            if (context.OutputToConsole)
                generator.Generate(context, new CodeWriter(Console.Out));
            else
            {
                using (var writer = new StreamWriter(outputFilePath, false, System.Text.Encoding.UTF8))
                    generator.Generate(context, new CodeWriter(writer));
            }
        }

        private static string GetOutputFilePath(TContext context, string @namespace, string fileName)
        {
            if (@namespace == null)
                throw new ArgumentNullException(nameof(@namespace));
            if (fileName == null)
                throw new ArgumentNullException(nameof(fileName));
            if (@namespace.Length == 0)
                throw new ArgumentException("Emtpy string", nameof(@namespace));
            if (fileName.Length == 0)
                throw new ArgumentException("Emtpy string", nameof(fileName));

            if (@namespace == context.RootNamespace)
                return Path.Combine(context.OutputRootFolderPath, fileName);
            else if (@namespace.StartsWith(context.RootNamespace))
            {
                var segments = new List<string> { context.OutputRootFolderPath };
                segments.AddRange(@namespace.Substring(context.RootNamespace.Length + 1).Split('.'));
                segments.Add(fileName);
                return Path.Combine(segments.ToArray());
            }
            else
                throw new ArgumentException($"Namespace '{@namespace}' is not related to root namespace: {context.RootNamespace}", @namespace);
        }
    }
}
