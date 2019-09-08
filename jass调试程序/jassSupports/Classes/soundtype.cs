using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class soundtype:handle
    {
        private soundtype() : base() { }

        public static Dictionary<int, soundtype> _soundtype = new Dictionary<int, soundtype>();

        public static soundtype get(int i)
        {
            if (!_soundtype.ContainsKey(i)) _soundtype[i] = new soundtype();
            return _soundtype[i];
        }
    }
}