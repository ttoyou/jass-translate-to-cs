using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class mapcontrol:handle
    {
        private mapcontrol() : base() { }

        public static Dictionary<int, mapcontrol> _mapcontrol = new Dictionary<int, mapcontrol>();

        public static mapcontrol get(int i)
        {
            if (!_mapcontrol.ContainsKey(i)) _mapcontrol[i] = new mapcontrol();
            return _mapcontrol[i];
        }
    }
}
