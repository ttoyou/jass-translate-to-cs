using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class unitstate:handle
    {
        private unitstate() : base() { }

        public static Dictionary<int, unitstate> _unitstate = new Dictionary<int, unitstate>();

        public static unitstate get(int i)
        {
            if (!_unitstate.ContainsKey(i)) _unitstate[i] = new unitstate();
            return _unitstate[i];
        }
    }
}
