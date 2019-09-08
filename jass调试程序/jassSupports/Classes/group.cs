using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    using System.Collections;
    using boolean = System.Boolean;
    using @string = System.String;
    /// <summary>
    /// 单位组 存储单位的容器
    /// </summary>
    public class group:agent,ISet<unit>
    {

        private SortedSet<unit> units = new SortedSet<unit>();

        public int Count => ((ISet<unit>)units).Count;

        public bool IsReadOnly => ((ISet<unit>)units).IsReadOnly;

        public bool Add(unit item)
        {
            return ((ISet<unit>)units).Add(item);
        }

        public void Clear()
        {
            ((ISet<unit>)units).Clear();
        }

        public bool Contains(unit item)
        {
            return ((ISet<unit>)units).Contains(item);
        }

        public void CopyTo(unit[] array, int arrayIndex)
        {
            ((ISet<unit>)units).CopyTo(array, arrayIndex);
        }

        public void ExceptWith(IEnumerable<unit> other)
        {
            ((ISet<unit>)units).ExceptWith(other);
        }

        public IEnumerator<unit> GetEnumerator()
        {
            return ((ISet<unit>)units).GetEnumerator();
        }

        public void IntersectWith(IEnumerable<unit> other)
        {
            ((ISet<unit>)units).IntersectWith(other);
        }

        public bool IsProperSubsetOf(IEnumerable<unit> other)
        {
            return ((ISet<unit>)units).IsProperSubsetOf(other);
        }

        public bool IsProperSupersetOf(IEnumerable<unit> other)
        {
            return ((ISet<unit>)units).IsProperSupersetOf(other);
        }

        public bool IsSubsetOf(IEnumerable<unit> other)
        {
            return ((ISet<unit>)units).IsSubsetOf(other);
        }

        public bool IsSupersetOf(IEnumerable<unit> other)
        {
            return ((ISet<unit>)units).IsSupersetOf(other);
        }

        public bool Overlaps(IEnumerable<unit> other)
        {
            return ((ISet<unit>)units).Overlaps(other);
        }

        public bool Remove(unit item)
        {
            return ((ISet<unit>)units).Remove(item);
        }

        public bool SetEquals(IEnumerable<unit> other)
        {
            return ((ISet<unit>)units).SetEquals(other);
        }

        public void SymmetricExceptWith(IEnumerable<unit> other)
        {
            ((ISet<unit>)units).SymmetricExceptWith(other);
        }

        public void UnionWith(IEnumerable<unit> other)
        {
            ((ISet<unit>)units).UnionWith(other);
        }

        void ICollection<unit>.Add(unit item)
        {
            ((ISet<unit>)units).Add(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((ISet<unit>)units).GetEnumerator();
        }
    }
}