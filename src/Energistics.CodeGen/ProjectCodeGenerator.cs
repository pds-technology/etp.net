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

using System;
using System.Collections.Generic;
using System.IO;

namespace Energistics.CodeGen
{
    /// <summary>
    /// Abstract base class for project code generators. Project code generators generate code for one or more files in a project.
    /// </summary>
    public abstract class ProjectCodeGenerator
    {
        /// <summary>
        /// Initializes a new <see cref="ProjectCodeGenerator"/> instance.
        /// </summary>
        /// <param name="solutionFileName">The file name, including file extension, of the solution containing the project to generate code for.</param>
        /// <param name="projectFileName">The file name, including file extension, of the project to generate code for.</param>
        /// <param name="projectRootNamespace">The root namespace of the project to generate code in.</param>
        protected ProjectCodeGenerator(string solutionFileName, string projectFileName, string projectRootNamespace)
        {
            if (projectRootNamespace == null)
                throw new ArgumentNullException(nameof(projectRootNamespace));
            if (solutionFileName == null)
                throw new ArgumentNullException(nameof(solutionFileName));
            if (projectFileName == null)
                throw new ArgumentNullException(nameof(projectFileName));
            if (projectRootNamespace.Length == 0)
                throw new ArgumentException("Emtpy string", nameof(projectRootNamespace));
            if (solutionFileName.Length == 0)
                throw new ArgumentException("Emtpy string", nameof(solutionFileName));
            if (projectFileName.Length == 0)
                throw new ArgumentException("Emtpy string", nameof(projectFileName));

            SolutionFileName = solutionFileName;
            ProjectFileName = projectFileName;
            ProjectRootNamespace = projectRootNamespace;

            if (Path.IsPathRooted(SolutionFileName))
            {
                if (!File.Exists(SolutionFileName))
                    throw new ArgumentException("File does not exist", nameof(solutionFileName));

                SolutionFolderPath = Path.GetDirectoryName(SolutionFileName);
            }
            else
            {
                SolutionFolderPath = GetSolutionFolderPath(SolutionFileName);
                if (string.IsNullOrEmpty(SolutionFolderPath))
                    throw new ArgumentException("File not found", nameof(solutionFileName));
            }

            if (Path.IsPathRooted(ProjectFileName))
            {
                if (!File.Exists(ProjectFileName))
                    throw new ArgumentException("File does not exist", nameof(projectFileName));

                ProjectFolderPath = Path.GetDirectoryName(ProjectFileName);
            }
            else
            {
                ProjectFolderPath = GetProjectFolderPath(SolutionFolderPath, ProjectFileName);
                if (string.IsNullOrEmpty(ProjectFolderPath))
                    throw new ArgumentException("File not found", nameof(projectFileName));
            }
        }

        /// <summary>
        /// The file name, including file extension, of the solution containing the project to generate code for.
        /// </summary>
        public string SolutionFileName { get; }

        /// <summary>
        /// The path to the folder containing the solution file.
        /// </summary>
        public string SolutionFolderPath { get; }

        /// <summary>
        /// The file name, including file extension, of the project to generate code for.
        /// </summary>
        public string ProjectFileName { get; }

        /// <summary>
        /// The path to the folder containing the project file.
        /// </summary>
        public string ProjectFolderPath { get; }

        /// <summary>
        /// The root namespace of the project to generate code in.
        /// </summary>
        public string ProjectRootNamespace { get; }

        private Dictionary<Type, GenerationContext> Contexts { get; } = new Dictionary<Type, GenerationContext>();

        private List<Action> Generators { get; } = new List<Action>();


        /// <summary>
        /// Generates code for the project.
        /// </summary>
        public void GenerateAll()
        {
            RegisterContext(new GenerationContext(ProjectFolderPath, ProjectRootNamespace, false));
            RegisterAdditionalContexts();
            RegisterAllGenerators();

            foreach (var generator in Generators)
                generator();
        }

        /// <summary>
        /// Virtual method to be overridden by derived classes if more than the standard <see cref="GenerationContext"/> is required.
        /// </summary>
        protected virtual void RegisterAdditionalContexts()
        {
        }

        /// <summary>
        /// Abstract method that must be overridden in derived classes to provide the code generators for the project.
        /// </summary>
        protected abstract void RegisterAllGenerators();

        /// <summary>
        /// Registers a specific context instance. Only one instance per type is stored.
        /// </summary>
        /// <typeparam name="TContext">The type of generation context.</typeparam>
        /// <param name="context">The generation context to register.</param>
        protected void RegisterContext<TContext>(TContext context)
            where TContext : GenerationContext
        {
            Contexts[typeof(TContext)] = context;
        }

        /// <summary>
        /// Registers a specific generator instance.
        /// </summary>
        /// <typeparam name="TContext">The type of generation context used by the generator.</typeparam>
        /// <param name="generator">The generator instance to register.</param>
        protected void RegisterGenerator<TContext>(ICodeGenerator<TContext> generator)
            where TContext : GenerationContext
        {
            Generators.Add(() =>
            {
                var context = GetContext<TContext>();
                Console.WriteLine($"Executing {generator.Name}...");
                generator.Generate(context);
            });
        }

        /// <summary>
        /// Registers a single file generator for the specified file code generator.
        /// </summary>
        /// <typeparam name="TContext">The type of generation context used by the generator.</typeparam>
        /// <param name="fileGenerator">The file generator instance to register.</param>
        protected void RegisterSingleFileGenerator<TContext>(IFileCodeGenerator<TContext> fileGenerator)
            where TContext : GenerationContext
        {
            var generator = new SingleFileCodeGenerator<TContext>(fileGenerator);
            RegisterGenerator(generator);
        }

        private TContext GetContext<TContext>()
            where TContext : GenerationContext
        {
            return Contexts[typeof(TContext)] as TContext;
        }

        private static string GetSolutionFolderPath(string solutionFileName)
        {
            if (string.IsNullOrEmpty(solutionFileName))
                return null;

            var searchFolderPath = Environment.CurrentDirectory;
            do
            {
                if (File.Exists(Path.Combine(searchFolderPath, solutionFileName)))
                    return searchFolderPath;

                searchFolderPath = Directory.GetParent(searchFolderPath)?.FullName;
            }
            while (searchFolderPath != null);

            return null;
        }

        private static string GetProjectFolderPath(string searchFolderPath, string projectFileName)
        {
            if (string.IsNullOrEmpty(searchFolderPath))
                return null;

            var queue = new Queue<string>();
            queue.Enqueue(searchFolderPath);
            while (queue.Count > 0)
            {
                var path = queue.Dequeue();

                if (File.Exists(Path.Combine(path, projectFileName)))
                    return path;

                foreach (var p in Directory.GetDirectories(path))
                    queue.Enqueue(p);

            }

            return null;
        }
    }
}
