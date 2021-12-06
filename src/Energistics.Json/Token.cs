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

using System;

namespace Energistics.Json
{
    public abstract class Token : IEquatable<Token>
    {
        protected Token()
        {
        }

        #region Equality and Inequality

        public override bool Equals(object obj) => Equals(obj as Token);

        public abstract bool Equals(Token other);

        public static bool operator ==(Token lhs, Token rhs) => Equals(lhs, rhs);

        public static bool operator !=(Token lhs, Token rhs) => !Equals(lhs, rhs);

        public override int GetHashCode() => GetHashCodeCore();

        protected abstract int GetHashCodeCore();
        #endregion
    }
}
