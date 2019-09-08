using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class hashtable:agent, IDictionary, ICollection, IEnumerable
    {
        private Hashtable table = new Hashtable();

        public object this[object key] { get => ((IDictionary)table)[key]; set => ((IDictionary)table)[key] = value; }

        public int Count => ((ICollection)table).Count;

        public object SyncRoot => ((ICollection)table).SyncRoot;

        public bool IsSynchronized => ((ICollection)table).IsSynchronized;

        public ICollection Keys => ((IDictionary)table).Keys;

        public ICollection Values => ((IDictionary)table).Values;

        public bool IsReadOnly => ((IDictionary)table).IsReadOnly;

        public bool IsFixedSize => ((IDictionary)table).IsFixedSize;

        public void Add(object key, object value)
        {
            ((IDictionary)table).Add(key, value);
        }

        public void Clear()
        {
            ((IDictionary)table).Clear();
        }

        public bool Contains(object key)
        {
            return ((IDictionary)table).Contains(key);
        }

        public void CopyTo(Array array, int index)
        {
            ((ICollection)table).CopyTo(array, index);
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)table).GetEnumerator();
        }

        public void Remove(object key)
        {
            ((IDictionary)table).Remove(key);
        }

        IDictionaryEnumerator IDictionary.GetEnumerator()
        {
            return ((IDictionary)table).GetEnumerator();
        }
    }
}