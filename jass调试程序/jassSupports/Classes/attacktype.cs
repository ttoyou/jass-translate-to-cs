using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class attacktype:handle
    {
        private attacktype() : base() { }

        public static Dictionary<int, attacktype> _attacktype = new Dictionary<int, attacktype>();

        public static attacktype get(int i)
        {
            if (!_attacktype.ContainsKey(i)) _attacktype[i] = new attacktype();
            return _attacktype[i];
        }
    }
}