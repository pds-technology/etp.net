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
using System.Collections.Generic;

namespace Energistics.Etp.Common.Datatypes
{
    /// <summary>
    /// A read-only interface to a data value dictionary.
    /// </summary>
    public interface IReadOnlyDataValueDictionary : IReadOnlyDictionary<string, IDataValue>
    {
        /// <summary>
        /// Tries to get the specified value from the dictionary as the specified type.
        /// </summary>
        /// <typeparam name="T">The type of the return value.</typeparam>
        /// <param name="key">The name of the value to retrieve.</param>
        /// <returns>The value if present or the default value if it is not present or there is an error retrieving it.</returns>
        T? TryGetValue<T>(string key) where T : struct;

        /// <summary>
        /// Tries to get the specified value from the dictionary as the specified type.
        /// </summary>
        /// <param name="key">The name of the value to retrieve.</param>
        /// <param name="valueType">The type of the value.</param>
        /// <returns>The value if present or the default value if it is not present or there is an error retrieving it.</returns>
        object TryGetValue(string key, Type valueType);
    }
}
