using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class fgamestate:gamestate
    {
        private fgamestate() : base() { }

        public static Dictionary<int, fgamestate> _fgamestate = new Dictionary<int, fgamestate>();

        public static fgamestate get(int i)
        {
            if (!_fgamestate.ContainsKey(i)) _fgamestate[i] = new fgamestate();
            return _fgamestate[i];
        }
    }
}
