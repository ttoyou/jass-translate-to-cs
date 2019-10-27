using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class mapvisibility:handle
    {
        private mapvisibility() : base() { }

        public static Dictionary<int, mapvisibility> _mapvisibility = new Dictionary<int, mapvisibility>();

        public static mapvisibility get(int i)
        {
            if (!_mapvisibility.ContainsKey(i)) _mapvisibility[i] = new mapvisibility();
            return _mapvisibility[i];
        }
    }
}
