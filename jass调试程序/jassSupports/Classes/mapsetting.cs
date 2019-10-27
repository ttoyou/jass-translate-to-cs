using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class mapsetting:handle
    {
        private mapsetting() : base() { }

        public static Dictionary<int, mapsetting> _mapsetting = new Dictionary<int, mapsetting>();

        public static mapsetting get(int i)
        {
            if (!_mapsetting.ContainsKey(i)) _mapsetting[i] = new mapsetting();
            return _mapsetting[i];
        }
    }
}
