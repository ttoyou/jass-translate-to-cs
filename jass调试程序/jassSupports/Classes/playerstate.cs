using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class playerstate:handle
    {
        private playerstate() : base() { }

        public static Dictionary<int, playerstate> _playerstate = new Dictionary<int, playerstate>();

        public static playerstate get(int i)
        {
            if (!_playerstate.ContainsKey(i)) _playerstate[i] = new playerstate();
            return _playerstate[i];
        }
    }
}
