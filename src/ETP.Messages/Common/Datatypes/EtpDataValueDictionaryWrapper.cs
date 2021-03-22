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
using System.Linq;

namespace Energistics.Etp.Common.Datatypes
{
    /// <summary>
    /// Provides an abstraction around data value dictionaries of concrete type.
    /// </summary>
    /// <typeparam name="TDataValue">The concrete data value type.</typeparam>
    public class EtpDataValueDictionaryWrapper<TDataValue> : EtpDataValueDictionary
        where TDataValue : class, IDataValue, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EtpDataValueDictionaryWrapper{TDataValue}"/> class.
        /// </summary>
        public EtpDataValueDictionaryWrapper()
        {
            Dictionary = new Dictionary<string, TDataValue>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EtpDataValueDictionaryWrapper{TDataValue}"/> class.
        /// </summary>
        /// <param name="dictionary">The dictionary to wrap.</param>
        public EtpDataValueDictionaryWrapper(IDictionary<string, TDataValue> dictionary)
        {
            Dictionary = dictionary;
        }

        /// <summary>
        /// The wrapped dictionary.
        /// </summary>
        public IDictionary<string, TDataValue> Dictionary { get; }

        /// <summary>
        /// Creates an <see cref="IDataValue"/> instance.
        /// </summary>
        /// <param name="value">The instance's value.</param>
        /// <returns>The created instance.</returns>
        protected override IDataValue CreateDataValue(object value) => new TDataValue { Item = value };

        /// <summary>
        /// Creates an <see cref="IDataValueDictionary"/> instance compatible with this one.
        /// </summary>
        /// <returns>The created instance.</returns>
        protected override IDataValueDictionary CreateInstance() => new EtpDataValueDictionaryWrapper<TDataValue>();

        #region IDictionary<string, IDataValue> methods

        public override void Add(string key, IDataValue value) => Dictionary.Add(key, value.ToDataValue<TDataValue>());

        public override bool ContainsKey(string key) => Dictionary.ContainsKey(key);

        public override bool Remove(string key) => Dictionary.Remove(key);

        public override bool TryGetValue(string key, out IDataValue value)
        {
            TDataValue v;
            var ret = Dictionary.TryGetValue(key, out v);
            value = v;
            return ret;
        }

        public override void Add(KeyValuePair<string, IDataValue> item) => Dictionary.Add(new KeyValuePair<string, TDataValue>(item.Key, item.Value.ToDataValue<TDataValue>()));

        public override void Clear() => Dictionary.Clear();

        public override bool Contains(KeyValuePair<string, IDataValue> item) => Dictionary.Contains(new KeyValuePair<string, TDataValue>(item.Key, item.Value.ToDataValue<TDataValue>()));

        public override void CopyTo(KeyValuePair<string, IDataValue>[] array, int arrayIndex)
        {
            if (array == null) return;

            var a = new KeyValuePair<string, TDataValue>[array.Length];
            Dictionary.CopyTo(a, arrayIndex);

            for (int i = arrayIndex; i < array.Length; i++)
                array[i] = new KeyValuePair<string, IDataValue>(a[i].Key, a[i].Value);
        }

        public override bool Remove(KeyValuePair<string, IDataValue> item) => Dictionary.Remove(new KeyValuePair<string, TDataValue>(item.Key, item.Value.ToDataValue<TDataValue>()));

        public override IEnumerator<KeyValuePair<string, IDataValue>> GetEnumerator()
        {
            foreach (var kvp in Dictionary)
                yield return new KeyValuePair<string, IDataValue>(kvp.Key, kvp.Value);
        }

        public override ICollection<string> Keys => Dictionary.Keys;

        public override ICollection<IDataValue> Values => Dictionary.Values.Cast<IDataValue>().ToList();

        public override int Count => Dictionary.Count;

        public override bool IsReadOnly => Dictionary.IsReadOnly;

        public override IDataValue this[string key]
        {
            get { return Dictionary[key]; }
            set { Dictionary[key] = value.ToDataValue<TDataValue>(); }
        }

        #endregion
    }
}
