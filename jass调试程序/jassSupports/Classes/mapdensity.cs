using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class mapdensity:handle
    {
        private mapdensity() : base() { }

        public static Dictionary<int, mapdensity> _mapdensity = new Dictionary<int, mapdensity>();

        public static mapdensity get(int i)
        {
            if (!_mapdensity.ContainsKey(i)) _mapdensity[i] = new mapdensity();
            return _mapdensity[i];
        }
    }
}
