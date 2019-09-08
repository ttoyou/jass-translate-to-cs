using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    /// <summary>
    /// ÖÖ×å
    /// </summary>
    public class race : handle
    {
        private race() { }
        public static race get(int a)
        {
            if (_c[a] == null) _c[a] = new race() { index = a };
            return _c[a];
        }
        public int index;
        private static race[] _c = new race[8];
    }
}