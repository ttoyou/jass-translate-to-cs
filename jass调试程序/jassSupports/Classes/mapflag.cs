using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class mapflag:handle
    {
        private mapflag() : base() { }

        public static Dictionary<int, mapflag> _mapflag = new Dictionary<int, mapflag>();

        public static mapflag get(int i)
        {
            if (!_mapflag.ContainsKey(i)) _mapflag[i] = new mapflag();
            return _mapflag[i];
        }
    }
}