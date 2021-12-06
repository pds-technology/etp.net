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

using System.Globalization;

namespace Energistics.Json.Tokens
{
    public sealed class Number : Scalar
    {
        public Number(string value)
        {
            InternalValue = value;
        }

        private string InternalValue { get; }

        public override string Value => InternalValue;

        public override string ToString() => InternalValue;

        public int GetIntValue() => int.Parse(InternalValue, NumberStyles.Integer, CultureInfo.InvariantCulture);
        public long GetLongValue() => long.Parse(InternalValue, NumberStyles.Integer, CultureInfo.InvariantCulture);
        public float GetFloatValue() => float.Parse(InternalValue, NumberStyles.Float, CultureInfo.InvariantCulture);
        public double GetDoubleValue() => double.Parse(InternalValue, NumberStyles.Float, CultureInfo.InvariantCulture);

        #region Equality and Inequality

        public override bool Equals(Token other)
        {
            var otherLiteral = other as Number;
            if (otherLiteral == null)
                return false;

            return InternalValue == otherLiteral.InternalValue;
        }

        protected override int GetHashCodeCore()
        {
            return InternalValue.GetHashCode();
        }

        #endregion
    }
}
