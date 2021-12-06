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

namespace Energistics.Json.Tokens
{
    public sealed class String : Scalar
    {
        public static String FromEncodedValue(string encodedValue) => new String(encodedValue, true);
        public static String FromDecodedValue(string decodedValue) => new String(decodedValue, false);

        private String(string value, bool encoded)
        {
            EncodedValue = encoded ? value : StringEncoding.Decode(value);
            if (!encoded)
                DecodedValue = value;
        }

        public string EncodedValue { get; }

        private string DecodedValue { get; set; }

        public override string Value
        {
            get
            {
                if (DecodedValue == null)
                    DecodedValue = StringEncoding.Decode(EncodedValue);

                return DecodedValue;
            }
        }

        public override string ToString() => EncodedValue;

        #region Equality and Inequality

        public override bool Equals(Token other)
        {
            var otherString = other as String;
            if (otherString == null)
                return false;

            return EncodedValue == otherString.EncodedValue && DecodedValue == otherString.DecodedValue;
        }

        protected override int GetHashCodeCore()
        {
            return new System.Tuple<string, string>(EncodedValue, DecodedValue).GetHashCode();
        }

        #endregion
    }
}
