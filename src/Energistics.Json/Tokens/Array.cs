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

using System.Collections;
using System.Collections.Generic;

namespace Energistics.Json.Tokens
{
    public sealed class Array : Container, IEnumerable<Token>
    {
        public int Count => Values.Count;

        public List<Token> Values { get; } = new List<Token>();

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            sb.Append('[');
            var appendComma = false;
            foreach (var value in Values)
            {
                if (appendComma)
                    sb.Append(',');
                sb.Append(value.ToString());
                appendComma = true;
            }
            sb.Append(']');

            return sb.ToString();
        }

        public IEnumerator<Token> GetEnumerator() => Values.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => Values.GetEnumerator();

        #region Equality and Inequality

        public override bool Equals(Token other)
        {
            var otherArray = other as Array;
            if (otherArray == null)
                return false;

            if (Values.Count != otherArray.Values.Count)
                return false;

            for (int i = 0; i < Values.Count; i++)
            {
                if (Values[i] != otherArray.Values[i])
                    return false;
            }

            return true;
        }

        protected override int GetHashCodeCore()
        {
            return Values.GetHashCode();
        }

        #endregion
    }
}
