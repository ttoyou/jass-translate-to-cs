using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class unittype:handle
    {
        private unittype() : base() { }

        public static Dictionary<int, unittype> _unittype = new Dictionary<int, unittype>();

        public static unittype get(int i)
        {
            if (!_unittype.ContainsKey(i)) _unittype[i] = new unittype();
            return _unittype[i];
        }
    }
}
