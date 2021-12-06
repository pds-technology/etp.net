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
    /// Properties for floating point handling in JSON Avro encoding
    /// </summary>
    internal class JsonFloatingPointEncodingProperties
    {
        private static ConcurrentDictionary<JsonFloatingPointSettings, ConcurrentDictionary<System.Text.Encoding, JsonFloatingPointEncodingProperties>> AllFloatingPointEncodingProperties { get; } = new ConcurrentDictionary<JsonFloatingPointSettings, ConcurrentDictionary<System.Text.Encoding, JsonFloatingPointEncodingProperties>>();

        public static JsonFloatingPointEncodingProperties ForEncodingAndSettings(System.Text.Encoding encoding, JsonFloatingPointSettings settings)
        {
            var dictionary = AllFloatingPointEncodingProperties.GetOrAdd(settings, (_) => new ConcurrentDictionary<System.Text.Encoding, JsonFloatingPointEncodingProperties>());
            return dictionary.GetOrAdd(encoding, (_) => new JsonFloatingPointEncodingProperties(encoding, settings));
        }

        private JsonFloatingPointEncodingProperties(System.Text.Encoding encoding, JsonFloatingPointSettings settings)
        {
            PositiveInfinitySize = encoding.GetByteCount(settings.PositiveInfinity);
            NegativeInfinitySize = encoding.GetByteCount(settings.NegativeInfinity);
            NaNSize = encoding.GetByteCount(settings.NaN);
            using (var reader = new JsonReader(settings.PositiveInfinity))
                PositiveInfinityToken = reader.Read();
            using (var reader = new JsonReader(settings.NegativeInfinity))
                NegativeInfinityToken = reader.Read();
            using (var reader = new JsonReader(settings.NaN))
                NaNToken = reader.Read();
        }

        public long PositiveInfinitySize { get; }

        public long NegativeInfinitySize { get; }

        public long NaNSize { get; }

        public Token PositiveInfinityToken { get; }

        public Token NegativeInfinityToken { get; }

        public Token NaNToken { get; }

    }
}
