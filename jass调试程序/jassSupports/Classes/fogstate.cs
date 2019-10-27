using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class fogstate:handle
    {
        private fogstate() : base() { }

        public static Dictionary<int, fogstate> _fogstate = new Dictionary<int, fogstate>();

        public static fogstate get(int i)
        {
            if (!_fogstate.ContainsKey(i)) _fogstate[i] = new fogstate();
            return _fogstate[i];
        }
    }
}
