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
using System.Collections;
using System.Collections.Generic;

namespace Energistics.Etp.Common.Datatypes
{
    /// <summary>
    /// Provides an abstraction around data value dictionaries.
    /// </summary>
    public abstract class EtpDataValueDictionary
        : IDataValueDictionary
    {
        /// <summary>
        /// Tries to get the specified value from the dictionary as the specified type.
        /// </summary>
        /// <typeparam name="T">The type of the return value.</typeparam>
        /// <param name="key">The name of the value to retrieve.</param>
        /// <returns>The value if present or the default value if it is not present or there is an error retrieving it.</returns>
        public T? TryGetValue<T>(string key)
            where T : struct
        {
            var value = TryGetValue(key, typeof(T));
            if (value == null)
                return null;

            return (T)value;
        }

        /// <summary>
        /// Tries to get the specified value from the dictionary as the specified type.
        /// </summary>
        /// <param name="key">The name of the value to retrieve.</param>
        /// <param name="valueType">The type of the value.</param>
        /// <returns>The value if present or the default value if it is not present or there is an error retrieving it.</returns>
        public object TryGetValue(string key, Type valueType)
        {
            IDataValue value;
            if (!TryGetValue(key, out value))
                return null;

            if (value.Item == null)
                return null;

            try
            {
                var underlyingType = Nullable.GetUnderlyingType(valueType);
                if (underlyingType != null)
                {
                    if (underlyingType == value.Item.GetType())
                        return value.Item;
                    else
                        return Convert.ChangeType(value.Item, underlyingType);
                }

                return Convert.ChangeType(value.Item, valueType);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Sets the specified value in the dictionary.
        /// </summary>
        /// <typeparam name="T">The type of the item value.</typeparam>
        /// <param name="key">The name of the value.</param>
        /// <param name="value">The value to set.</param>
        public void SetValue<T>(string key, T? value)
            where T : struct
        {
            if (value == null)
                Remove(key);
            else
                this[key] = CreateDataValue(value);
        }

        /// <summary>
        /// Sets the specified value in the dictionary.
        /// </summary>
        /// <param name="key">The name of the value.</param>
        /// <param name="value">The value to set.</param>
        public void SetValue(string key, object value)
        {
            if (value == null)
                Remove(key);
            else
                this[key] = CreateDataValue(value);
        }

        /// <summary>
        /// Creates a deep copy of this instance.
        /// </summary>
        /// <returns>A deep copy of this instance.</returns>
        public IDataValueDictionary Clone()
        {
            var clone = CreateInstance();
            foreach (var key in Keys)
            {
                ((IDictionary<string, IDataValue>)clone)[key] = CreateDataValue(this[key].Item);
            }

            return clone;
        }

        /// <summary>
        /// Creates an <see cref="IDataValue"/> instance.
        /// </summary>
        /// <param name="value">The instance's value.</param>
        /// <returns>The created instance.</returns>
        protected abstract IDataValue CreateDataValue(object value);

        /// <summary>
        /// Creates an <see cref="IDataValueDictionary"/> instance compatible with this one.
        /// </summary>
        /// <returns>The created instance.</returns>
        protected abstract IDataValueDictionary CreateInstance();

        #region IDictionary<string, IDataValue> members

        public abstract IDataValue this[string key] { get; set; }

        public abstract ICollection<string> Keys { get; }

        public abstract ICollection<IDataValue> Values { get; }

        public abstract int Count { get; }

        public abstract bool IsReadOnly { get; }

        public abstract void Add(string key, IDataValue value);

        public abstract void Add(KeyValuePair<string, IDataValue> item);

        public abstract void Clear();

        public abstract bool Contains(KeyValuePair<string, IDataValue> item);

        public abstract bool ContainsKey(string key);

        public abstract void CopyTo(KeyValuePair<string, IDataValue>[] array, int arrayIndex);

        public abstract IEnumerator<KeyValuePair<string, IDataValue>> GetEnumerator();

        public abstract bool Remove(string key);

        public abstract bool Remove(KeyValuePair<string, IDataValue> item);

        public abstract bool TryGetValue(string key, out IDataValue value);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion

        #region IReadOnlyDictionary<string, IDataValue>

        IEnumerable<string> IReadOnlyDictionary<string, IDataValue>.Keys => Keys;

        IEnumerable<IDataValue> IReadOnlyDictionary<string, IDataValue>.Values => Values;

        #endregion
    }
}
