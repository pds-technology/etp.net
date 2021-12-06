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
    public sealed class Object : Container, IEnumerable<KeyValuePair<string, Token>>
    {
        public int Count => Values.Count;

        public NameValueCollection<Token> Values { get; } = new NameValueCollection<Token>();

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();
            sb.Append('{');
            var appendComma = false;
            foreach (var kvp in Values)
            {
                if (appendComma)
                    sb.Append(',');
                sb.Append('"');
                sb.Append(StringEncoding.Encode(kvp.Key));
                sb.Append("\":");
                sb.Append(kvp.Value.ToString());
                appendComma = true;
            }
            sb.Append('}');

            return sb.ToString();
        }

        public IEnumerator<KeyValuePair<string, Token>> GetEnumerator()
        {
            foreach (var kvp in Values)
            {
                foreach (var token in kvp.Value)
                    yield return new KeyValuePair<string, Token>(kvp.Key, token);
            }    
        }

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable<KeyValuePair<string, Token>>)this).GetEnumerator();

        #region Equality and Inequality

        public override bool Equals(Token other)
        {
            var otherObject = other as Object;
            if (otherObject == null)
                return false;

            if (Values.Count != otherObject.Values.Count)
                return false;

            foreach (var kvp in Values)
            {
                if (!otherObject.Values.TryGetValue(kvp.Key, out var otherValue))
                    return false;

                if (kvp.Value.Count != otherValue.Count)
                    return false;

                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    if (kvp.Value[i] != otherValue[i])
                        return false;
                }
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
