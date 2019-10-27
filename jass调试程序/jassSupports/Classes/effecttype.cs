using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class effecttype:handle
    {
        private effecttype() : base() { }

        public static Dictionary<int, effecttype> _effecttype = new Dictionary<int, effecttype>();

        public static effecttype get(int i)
        {
            if (!_effecttype.ContainsKey(i)) _effecttype[i] = new effecttype();
            return _effecttype[i];
        }
    }
}
