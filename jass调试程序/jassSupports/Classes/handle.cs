using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    public class handle : IComparable<handle>
    {
        public int id { get; } = handleProvider.Next;

        public int CompareTo(handle other) => id.CompareTo(other.id);

    }
    static class handleProvider
    {
        public static int Next { get { _index++; return _index; } }
        private static int _index = 65536;
    }
    static class randomProvider
    {
        public static Random random = new Random();
        public static int Next(int min, int max)
        {
            return random.Next(min, max);
        }

    }
}
