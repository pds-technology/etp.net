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

using System.Collections.Generic;

namespace Energistics.Etp.Common.Datatypes
{
    /// <summary>
    /// An interface for a data value dictionary.
    /// </summary>
    public interface IDataValueDictionary : IDictionary<string, IDataValue>, IReadOnlyDataValueDictionary
    {
        /// <summary>
        /// Sets the specified value in the dictionary.
        /// </summary>
        /// <typeparam name="T">The type of the item value.</typeparam>
        /// <param name="key">The name of the value.</param>
        /// <param name="value">The value to set.</param>
        void SetValue<T>(string key, T? value) where T : struct;

        /// <summary>
        /// Sets the specified value in the dictionary.
        /// </summary>
        /// <param name="key">The name of the value.</param>
        /// <param name="value">The value to set.</param>
        void SetValue(string key, object value);

        /// <summary>
        /// Creates a deep copy of this instance.
        /// </summary>
        /// <returns>A deep copy of this instance.</returns>
        IDataValueDictionary Clone();
    }
}
