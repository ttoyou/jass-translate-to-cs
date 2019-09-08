using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class blendmode:handle
    {
        private blendmode() : base() { }

        public static Dictionary<int, blendmode> _blendmode = new Dictionary<int, blendmode>();

        public static blendmode get(int i)
        {
            if (!_blendmode.ContainsKey(i)) _blendmode[i] = new blendmode();
            return _blendmode[i];
        }
    }
}