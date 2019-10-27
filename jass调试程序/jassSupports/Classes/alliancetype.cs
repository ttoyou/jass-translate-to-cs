using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class alliancetype : handle
    {
        private alliancetype() : base() { }
        static alliancetype[] _alliancetype = new alliancetype[10];

        public static alliancetype get(int i)
        {
            if (_alliancetype[i] == null) _alliancetype[i] = new alliancetype();
            return _alliancetype[i];
        }
    }
}
