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
    /// Context for generated code.
    /// </summary>
    public class GenerationContext
    {
        /// <summary>
        /// Initializes a new <see cref="GenerationContext"/> instance.
        /// </summary>
        /// <param name="outputRootFolderPath">The path to the root folder to generate code in.</param>
        /// <param name="rootNamespace">The namespace corresponding to the root folder.</param>
        /// <param name="outputToConsole">If <c>true</c>, generated code should be written to the console. Otherwise, generated code should be written to a file underneath the root folder.</param>
        public GenerationContext(string outputRootFolderPath, string rootNamespace, bool outputToConsole)
        {
            OutputRootFolderPath = outputRootFolderPath;
            RootNamespace = rootNamespace;
            OutputToConsole = outputToConsole;
        }

        /// <summary>
        /// The path to the root folder to generate code in.
        /// </summary>
        public string OutputRootFolderPath { get; }

        /// <summary>
        /// The namespace corresponding to the root folder.
        /// </summary>
        public string RootNamespace { get; }

        /// <summary>
        /// If <c>true</c>, generated code should be written to the console. Otherwise, generated code should be written to a file underneath the root folder.
        /// </summary>
        public bool OutputToConsole { get; }
    }
}
