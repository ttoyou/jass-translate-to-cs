using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class weapontype:handle
    {
        private weapontype() : base() { }

        public static Dictionary<int, weapontype> _weapontype = new Dictionary<int, weapontype>();

        public static weapontype get(int i)
        {
            if (!_weapontype.ContainsKey(i)) _weapontype[i] = new weapontype();
            return _weapontype[i];
        }
    }
}