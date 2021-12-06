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

using Energistics.CodeGen.Avro.Code;
using Energistics.CodeGen.Avro.Files;

namespace Energistics.CodeGen.Avro
{
    public class EnergisticsAvroTypeInfoCollectionGenerator : ProjectCodeGenerator
    {
        public EnergisticsAvroTypeInfoCollectionGenerator(string solutionFileName, string projectFileName, string projectRootNamespace, string typeInfoCollectionNamespace, TypeInfoCollection typeInfoCollection)
            : base(solutionFileName, projectFileName, projectRootNamespace)
        {
            TypeInfoCollectionNamespace = typeInfoCollectionNamespace;
            TypeInfoCollection = typeInfoCollection;
        }

        public string TypeInfoCollectionNamespace { get; }

        public TypeInfoCollection TypeInfoCollection { get; }

        public bool InternalTypeInfoCollectionTypeConverters { get; set; }

        protected override void RegisterAdditionalContexts()
        {
            RegisterContext(new TypeInfoCollectionGenerationContext(ProjectFolderPath, ProjectRootNamespace, false, TypeInfoCollection));
        }

        protected override void RegisterAllGenerators()
        {
            RegisterSingleFileGenerator(new AvroFixedImplementationGenerator(TypeInfoCollectionNamespace));
            RegisterSingleFileGenerator(new AvroRecordImplementationGenerator(TypeInfoCollectionNamespace));
            RegisterSingleFileGenerator(new TypeInfoCollectionEncodingExtensionsGenerator(TypeInfoCollectionNamespace) { InternalTypeConverters  = InternalTypeInfoCollectionTypeConverters });
            RegisterGenerator(new EnergisticsAvroTypeCodeGenerator());
        }
    }
}
