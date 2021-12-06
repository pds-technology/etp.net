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

using Energistics.Avro.Schemas;
using Energistics.CodeGen.Avro.Code;
using Energistics.CodeGen.Etp;
using Energistics.CodeGen.Etp.Code;
using System.Collections.Generic;
using System.IO;

namespace Energistics.Generators.Etp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
                return;

            var avpr = args[0];
            var etpVersion = args[1];
            var originalNamespace = args.Length > 2 ? args[2] : null;
            var replacementNamespace = args.Length > 3 ? args[3] : null;

            var namespaceSubstitutions = new Dictionary<string, string>();
            if (originalNamespace != null && replacementNamespace != null)
                namespaceSubstitutions[originalNamespace] = replacementNamespace;

            var namingOptions = new NamingOptions
            {
                NamespaceNamingStyle = NamingStyle.AvroName,
                ClassNamingStyle = NamingStyle.PascalCase,
                FieldNamingStyle = NamingStyle.PascalCase,
                NamespaceSubstitutions = namespaceSubstitutions,
            };

            var typeCollection = new TypeCollection();
            typeCollection.ParseProtocolTypes(File.ReadAllText(avpr));

            var typeInfoCollection = new TypeInfoCollection(namingOptions);
            typeInfoCollection.AddTypeResolver(new Fixed16GuidResolver());
            typeInfoCollection.AddTypeResolver(new Etp11StringGuidResolver());
            typeInfoCollection.AddTypeResolver(new TimestampMicrosDateTimeResolver());

            typeInfoCollection.AddTypeCollection(typeCollection);

            var generator = new EnergisticsEtpGenerator(etpVersion, typeInfoCollection);
            generator.GenerateAll();
        }
    }
}
