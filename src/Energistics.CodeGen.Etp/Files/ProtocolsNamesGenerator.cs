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
using Energistics.CodeGen.Code;
using Energistics.CodeGen.Etp.Code;
using System.Linq;
using System.Globalization;

namespace Energistics.CodeGen.Etp.Files
{
    public class ProtocolsNamesGenerator : FileCodeGenerator<TypeInfoCollectionGenerationContext>
    {
        public ProtocolsNamesGenerator(string @namespace)
            : base(@namespace, "ProtocolNames.Definitions.cs")
        {
        }

        public override void Generate(TypeInfoCollectionGenerationContext context, CodeWriter writer)
        {
            writer.ApacheHeader("ETP DevKit", "1.2", "2021");
            writer.UsingNamespaces("System.Collections.Generic");
            writer.WithNamespace(Namespace, () =>
            {
                writer.XmlSummary($"Provides string representations of ETP protocol names.");
                writer.WithPublicStaticPartialClass("ProtocolNames", () =>
                {
                    var groups = context.TypeInfoCollection
                        .RecordInfoMessageBodies()
                        .GroupedByProtocol();

                    writer.XmlSummary($"The dictionary of protocol names.");
                    writer.PublicStaticReadonlyAutoImplementedProperty("Dictionary<int, string>", "Names", "new Dictionary<int, string>()", () =>
                    {
                        foreach (var group in groups)
                        {
                            writer.DictionaryInitializer(group.Key.ToString(CultureInfo.InvariantCulture), $"\"{group.First().ProtocolName()}\"");
                        }
                    });
                });
            });
        }
    }
}
