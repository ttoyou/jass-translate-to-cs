using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class gameevent:eventid
    {
        private gameevent() : base() { }

        public static Dictionary<int, gameevent> _gameevent = new Dictionary<int, gameevent>();

        public static gameevent get(int i)
        {
            if (!_gameevent.ContainsKey(i)) _gameevent[i] = new gameevent();
            return _gameevent[i];
        }
    }
}
