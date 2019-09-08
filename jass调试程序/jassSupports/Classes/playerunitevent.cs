using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class playerunitevent:eventid
    {
        private playerunitevent() : base() { }

        public static Dictionary<int, playerunitevent> _playerunitevent = new Dictionary<int, playerunitevent>();

        public static playerunitevent get(int i)
        {
            if (!_playerunitevent.ContainsKey(i)) _playerunitevent[i] = new playerunitevent();
            return _playerunitevent[i];
        }
    }
}