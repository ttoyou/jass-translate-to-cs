using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Map
{
    public struct array<T1, T2> : IDictionary<T1, T2>
    {
        public T2 this[T1 key]
        {
            get
            {
                if (packed == null) packed = new Dictionary<T1, T2>();

                if (packed.ContainsKey(key))
                    return packed[key];
                else
                    return default(T2);
            }
            set
            {
                if (packed == null) packed = new Dictionary<T1, T2>();
                packed[key] = value;
            }
        }

        public ICollection<T1> Keys
        {
            get
            {
                if (packed == null) packed = new Dictionary<T1, T2>();
                return packed.Keys;
            }
        }

        public ICollection<T2> Values
        {
            get
            {
                if (packed == null) packed = new Dictionary<T1, T2>();
                return packed.Values;
            }
        }

        public int Count => packed.Count;


        public bool IsReadOnly => false;

        public void Add(T1 key, T2 value)
        {
            if (packed == null) packed = new Dictionary<T1, T2>();
            packed.Add(key, value);
        }

        public void Add(KeyValuePair<T1, T2> item)
        {
            packed.Add(item.Key, item.Value);
        }

        public void Clear()
        {
            if (packed != null) packed.Clear();
        }

        public bool Contains(KeyValuePair<T1, T2> item)
        {
            return true;
        }

        public bool ContainsKey(T1 key)
        {
            return packed.ContainsKey(key);
        }

        public void CopyTo(KeyValuePair<T1, T2>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<T1, T2>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T1 key)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<T1, T2> item)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(T1 key, out T2 value)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private Dictionary<T1, T2> packed;
    }
}
