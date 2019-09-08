using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class gametype:handle
    {
        private gametype() : base() { }

        public static Dictionary<int, gametype> _gametype = new Dictionary<int, gametype>();

        public static gametype get(int i)
        {
            if (!_gametype.ContainsKey(i)) _gametype[i] = new gametype();
            return _gametype[i];
        }
    }
}