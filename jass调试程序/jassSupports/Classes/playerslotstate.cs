using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class playerslotstate:handle
    {
        private playerslotstate() : base() { }

        public static Dictionary<int, playerslotstate> _playerslotstate = new Dictionary<int, playerslotstate>();

        public static playerslotstate get(int i)
        {
            if (!_playerslotstate.ContainsKey(i)) _playerslotstate[i] = new playerslotstate();
            return _playerslotstate[i];
        }
    }
}
