using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class version:handle
    {
        private version() : base() { }

        public static Dictionary<int, version> _version = new Dictionary<int, version>();

        public static version get(int i)
        {
            if (!_version.ContainsKey(i)) _version[i] = new version();
            return _version[i];
        }
    }
}
