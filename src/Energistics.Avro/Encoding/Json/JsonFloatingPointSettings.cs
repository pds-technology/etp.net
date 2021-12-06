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

namespace Energistics.Avro.Encoding.Json
{
    /// <summary>
    /// Settings for floating point handling in JSON Avro encoding
    /// </summary>
    public class JsonFloatingPointSettings
    {
        public static JsonFloatingPointSettings Default { get; } = new JsonFloatingPointSettings { SingleFormat = "G9", DoubleFormat = "G17", NaN = "null", PositiveInfinity = "1.7976931348623157E308", NegativeInfinity = "-1.7976931348623157E308" };
        public string SingleFormat { get; set; }
        public string DoubleFormat { get; set; }
        public string PositiveInfinity { get; set; }
        public string NegativeInfinity { get; set; }
        public string NaN { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as JsonFloatingPointSettings;
            if (other == null)
                return false;

            return SingleFormat == other.SingleFormat && DoubleFormat == other.DoubleFormat && PositiveInfinity == other.PositiveInfinity && NegativeInfinity == other.NegativeInfinity && NaN == other.NaN;
        }
        public override int GetHashCode()
        {
            return new System.Tuple<string, string, string, string, string>(SingleFormat, DoubleFormat, PositiveInfinity, NegativeInfinity, NaN).GetHashCode();
        }
    }
}
