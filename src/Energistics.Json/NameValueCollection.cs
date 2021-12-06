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

namespace Energistics.Json
{
    public sealed class NameValueCollection<T> : IDictionary<string, List<T>>
    {
        private Dictionary<string, List<T>> Dictionary { get; } = new Dictionary<string, List<T>>();

        public void Add(string key, T value)
        {
            if (!Dictionary.TryGetValue(key, out var list))
            {
                list = new List<T>();
                Dictionary.Add(key, list);
            }

            list.Add(value);
        }

        #region IDictionary<string, List<T>>

        public List<T> this[string key] { get => Dictionary[key]; set => Dictionary[key] = value; }

        public ICollection<string> Keys => Dictionary.Keys;

        public ICollection<List<T>> Values => Dictionary.Values;

        public int Count => Dictionary.Count;

        bool ICollection<KeyValuePair<string, List<T>>>.IsReadOnly => ((ICollection<KeyValuePair<string, List<T>>>)Dictionary).IsReadOnly;

        void IDictionary<string, List<T>>.Add(string key, List<T> value) => Dictionary.Add(key, value);

        void ICollection<KeyValuePair<string, List<T>>>.Add(KeyValuePair<string, List<T>> item) => ((ICollection<KeyValuePair<string, List<T>>>)Dictionary).Add(item);

        public void Clear() => Dictionary.Clear();

        bool ICollection<KeyValuePair<string, List<T>>>.Contains(KeyValuePair<string, List<T>> item) => ((ICollection<KeyValuePair<string, List<T>>>)Dictionary).Contains(item);

        public bool ContainsKey(string key) => Dictionary.ContainsKey(key);

        void ICollection<KeyValuePair<string, List<T>>>.CopyTo(KeyValuePair<string, List<T>>[] array, int arrayIndex) => ((ICollection<KeyValuePair<string, List<T>>>)Dictionary).CopyTo(array, arrayIndex);

        IEnumerator<KeyValuePair<string, List<T>>> IEnumerable<KeyValuePair<string, List<T>>>.GetEnumerator() => ((IEnumerable<KeyValuePair<string, List<T>>>)Dictionary).GetEnumerator();

        public bool Remove(string key) => Dictionary.Remove(key);

        bool ICollection<KeyValuePair<string, List<T>>>.Remove(KeyValuePair<string, List<T>> item) => ((ICollection<KeyValuePair<string, List<T>>>)Dictionary).Remove(item);

        public bool TryGetValue(string key, out List<T> value) => Dictionary.TryGetValue(key, out value);

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Dictionary).GetEnumerator();

        #endregion
    }
}
