using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class pathingtype:handle
    {
        private pathingtype() : base() { }

        public static Dictionary<int, pathingtype> _pathingtype = new Dictionary<int, pathingtype>();

        public static pathingtype get(int i)
        {
            if (!_pathingtype.ContainsKey(i)) _pathingtype[i] = new pathingtype();
            return _pathingtype[i];
        }
    }
}
