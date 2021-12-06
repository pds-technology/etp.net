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
using System.Globalization;

namespace Energistics.CodeGen.Etp.Files
{
    public class MessageReflectionGenerator : FileCodeGenerator<TypeInfoCollectionGenerationContext>
    {
        public MessageReflectionGenerator(string @namespace)
            : base(@namespace, "MessageReflection.Definitions.cs")
        {
        }

        public override void Generate(TypeInfoCollectionGenerationContext context, CodeWriter writer)
        {
            writer.ApacheHeader("ETP DevKit", "1.2", "2021");
            writer.UsingNamespaces("System", "System.Collections.Generic");
            writer.WithNamespace(Namespace, () =>
            {
                writer.XmlSummary($"Provides ETP message information by message type.");
                writer.WithPublicStaticPartialClass("MessageReflection", () =>
                {
                    var messages = context.TypeInfoCollection
                        .RecordInfoMessageBodies();

                    writer.XmlSummary($"The dictionary of ETP protocols by message type.");
                    writer.PublicStaticReadonlyAutoImplementedProperty("Dictionary<Type, int>", "ProtocolByMessage", "new Dictionary<Type, int>()", () =>
                    {
                        foreach (var message in messages)
                        {
                            writer.DictionaryInitializer($"typeof({message.FullName})", message.ProtocolNumber().ToString(CultureInfo.InvariantCulture));
                        }
                    });

                    writer.XmlSummary($"The dictionary of ETP message types by message type.");
                    writer.PublicStaticReadonlyAutoImplementedProperty("Dictionary<Type, int>", "MessageTypeByMessage", "new Dictionary<Type, int>()", () =>
                    {
                        foreach (var message in messages)
                        {
                            writer.DictionaryInitializer($"typeof({message.FullName})", message.MessageType().ToString(CultureInfo.InvariantCulture));
                        }
                    });
                });
            });
        }
    }
}
