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
    public class EnergisticsAvroTypeCodeGenerator : CodeGenerator<TypeInfoCollectionGenerationContext>
    {
        /// <summary>
        /// The name of the generator.
        /// </summary>
        public override string Name => nameof(EnergisticsAvroTypeCodeGenerator);

        /// <summary>
        /// Abstract method that must be overridden in derived classes to provide the code generators for the project.
        /// </summary>
        /// <param name="context">The generation context.</param>
        protected override void RegisterAllGenerators(TypeInfoCollectionGenerationContext context)
        {
            foreach (var enumInfo in context.TypeInfoCollection.EnumInfos())
                RegisterGenerator(new EnumGenerator(enumInfo.Namespace, $"{enumInfo.Name}.cs", enumInfo));
            foreach (var fixedInfo in context.TypeInfoCollection.FixedInfos())
                RegisterGenerator(new FixedGenerator(fixedInfo.Namespace, $"{fixedInfo.Name}.cs", fixedInfo));
            foreach (var recordInfo in context.TypeInfoCollection.RecordInfos())
                RegisterGenerator(new RecordGenerator(recordInfo.Namespace, $"{recordInfo.Name}.cs", recordInfo));
        }
    }
}
