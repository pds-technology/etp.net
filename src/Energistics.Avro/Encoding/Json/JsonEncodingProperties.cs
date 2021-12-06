//----------------------------------------------------------------------- 
// ETP DevKit, 1.2
//
// Copyright 2019 Energistics
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

using Energistics.Json;
using System.Collections.Concurrent;

namespace Energistics.Avro.Encoding.Json
{
    /// <summary>
    /// Properties for JSON text encoding
    /// </summary>
    internal sealed class JsonEncodingProperties
    {
        private static ConcurrentDictionary<System.Text.Encoding, JsonEncodingProperties> AllProperties { get; } = new ConcurrentDictionary<System.Text.Encoding, JsonEncodingProperties>();

        public static JsonEncodingProperties ForEncoding(System.Text.Encoding encoding)
        {
            return AllProperties.GetOrAdd(encoding, (_) => new JsonEncodingProperties(encoding));
        }

        private JsonEncodingProperties(System.Text.Encoding encoding)
        {
            NullSize = encoding.GetByteCount("null");
            TrueSize = encoding.GetByteCount("true");
            FalseSize = encoding.GetByteCount("false");

            IntegerSizes = new long[20];
            var integer = 1L;
            for (int i = 0; i < 20; i++)
            {
                IntegerSizes[i] = encoding.GetByteCount($"{integer}");
                integer *= 10;
            }

            EncodedCharSizes = new long[256];
            CharSizeDeltas = new long[256];
            for (int i = 0; i < 256; i++)
            {
                EncodedCharSizes[i] = encoding.GetByteCount(StringEncoding.CharStrings[i]);
                CharSizeDeltas[i] = EncodedCharSizes[i] - encoding.GetByteCount(new char[] { (char)i });
            }
            StartEndQuoteSize = encoding.GetByteCount("\"") * 2;
        }

        public long NullSize { get; }

        public long TrueSize { get; }

        public long FalseSize { get; }

        public long[] IntegerSizes { get; }

        public long[] EncodedCharSizes { get; }

        public long[] CharSizeDeltas { get; }

        public long StartEndQuoteSize { get; }

        public long CommaSize { get; }

        public long SemiColonSize { get; }

        public long ArrayStartSize { get; }

        public long ArrayEndSize { get; }

        public long ObjectStartSize { get; }

        public long ObjectEndSize { get; }
    }
}
