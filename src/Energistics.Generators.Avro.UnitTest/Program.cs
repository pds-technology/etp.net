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
using Energistics.CodeGen.Avro;
using Energistics.CodeGen.Avro.Code;
using System.Collections.Generic;
using System.IO;

namespace Energistics.Generators.Avro.UnitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var namingOptions = new NamingOptions
            {
                NamespaceNamingStyle = NamingStyle.AvroName,
                ClassNamingStyle = NamingStyle.PascalCase,
                FieldNamingStyle = NamingStyle.PascalCase,
                NamespaceSubstitutions = new Dictionary<string, string>(),
            };

            var avpr = "unittest.avpr";
            var typeCollection = new TypeCollection();
            typeCollection.ParseProtocolTypes(File.ReadAllText(avpr));

            var typeInfoCollection = new TypeInfoCollection(namingOptions);

            typeInfoCollection.AddTypeCollection(typeCollection);

            var generator = new EnergisticsAvroTypeInfoCollectionGenerator("ETP.Messages.sln", "Energistics.Avro.UnitTest.csproj", "Energistics.Avro", "Energistics.Avro.Encoding.TestObjects", typeInfoCollection);
            generator.InternalTypeInfoCollectionTypeConverters = true;
            generator.GenerateAll();
        }
    }
}
