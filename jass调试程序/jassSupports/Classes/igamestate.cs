using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class igamestate:gamestate
    {
        private igamestate() : base() { }

        public static Dictionary<int, igamestate> _igamestate = new Dictionary<int, igamestate>();

        public static igamestate get(int i)
        {
            if (!_igamestate.ContainsKey(i)) _igamestate[i] = new igamestate();
            return _igamestate[i];
        }
    }
}
