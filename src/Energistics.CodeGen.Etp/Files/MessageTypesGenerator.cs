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
    public class MessageTypesGenerator : FileCodeGenerator<TypeInfoCollectionGenerationContext>
    {
        public MessageTypesGenerator(string @namespace)
            : base(@namespace, "MessageTypes.cs")
        {
        }

        public override void Generate(TypeInfoCollectionGenerationContext context, CodeWriter writer)
        {
            writer.ApacheHeader("ETP DevKit", "1.2", "2021");
            writer.WithNamespace(Namespace, () =>
            {
                writer.XmlSummary($"Provides enumerations of protocol message types.");
                writer.WithPublicStaticClass("MessageTypes", () =>
                {
                    var groups = context.TypeInfoCollection
                        .RecordInfoMessageBodies()
                        .GroupedByProtocol();

                    var firstProtocol = true;
                    foreach (var group in groups)
                    {
                        if (firstProtocol)
                            firstProtocol = false;
                        else
                            writer.WriteLine();

                        var protocol = group.First().ProtocolName();
                        writer.XmlSummary($"An enumeration of {protocol} protocol message types.");
                        writer.WithPublicEnum(protocol, () =>
                        {
                            var groups = context.TypeInfoCollection
                                .RecordInfoMessageBodies()
                                .GroupedByProtocol();

                            foreach (var type in group)
                            {
                                writer.EnumValue(type.Name, type.MessageType().ToString(CultureInfo.InvariantCulture));
                            }

                        });
                    }
                });
            });
        }
    }
}
