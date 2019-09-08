using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    using integer = System.Int32;
    using real = System.Single;
    using boolean = System.Boolean;
    using @string = System.String;
    using code = System.Delegate;
    using System.Collections;

    public class force:agent, ISet<player>
    {
        public SortedSet<player> players = new SortedSet<player>();

        public int Count => ((ISet<player>)players).Count;

        public bool IsReadOnly => ((ISet<player>)players).IsReadOnly;

        public bool Add(player item)
        {
            return ((ISet<player>)players).Add(item);
        }

        public void Clear()
        {
            ((ISet<player>)players).Clear();
        }

        public bool Contains(player item)
        {
            return ((ISet<player>)players).Contains(item);
        }

        public void CopyTo(player[] array, int arrayIndex)
        {
            ((ISet<player>)players).CopyTo(array, arrayIndex);
        }

        public void ExceptWith(IEnumerable<player> other)
        {
            ((ISet<player>)players).ExceptWith(other);
        }

        public IEnumerator<player> GetEnumerator()
        {
            return ((ISet<player>)players).GetEnumerator();
        }

        public void IntersectWith(IEnumerable<player> other)
        {
            ((ISet<player>)players).IntersectWith(other);
        }

        public bool IsProperSubsetOf(IEnumerable<player> other)
        {
            return ((ISet<player>)players).IsProperSubsetOf(other);
        }

        public bool IsProperSupersetOf(IEnumerable<player> other)
        {
            return ((ISet<player>)players).IsProperSupersetOf(other);
        }

        public bool IsSubsetOf(IEnumerable<player> other)
        {
            return ((ISet<player>)players).IsSubsetOf(other);
        }

        public bool IsSupersetOf(IEnumerable<player> other)
        {
            return ((ISet<player>)players).IsSupersetOf(other);
        }

        public bool Overlaps(IEnumerable<player> other)
        {
            return ((ISet<player>)players).Overlaps(other);
        }

        public bool Remove(player item)
        {
            return ((ISet<player>)players).Remove(item);
        }

        public bool SetEquals(IEnumerable<player> other)
        {
            return ((ISet<player>)players).SetEquals(other);
        }

        public void SymmetricExceptWith(IEnumerable<player> other)
        {
            ((ISet<player>)players).SymmetricExceptWith(other);
        }

        public void UnionWith(IEnumerable<player> other)
        {
            ((ISet<player>)players).UnionWith(other);
        }

        void ICollection<player>.Add(player item)
        {
            ((ISet<player>)players).Add(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((ISet<player>)players).GetEnumerator();
        }
    }
}