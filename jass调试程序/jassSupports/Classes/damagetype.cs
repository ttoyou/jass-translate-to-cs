using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class damagetype:handle
    {
        private damagetype() : base() { }

        public static Dictionary<int, damagetype> _damagetype = new Dictionary<int, damagetype>();

        public static damagetype get(int i)
        {
            if (!_damagetype.ContainsKey(i)) _damagetype[i] = new damagetype();
            return _damagetype[i];
        }
    }
}