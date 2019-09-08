using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class placement:handle
    {
        private placement() : base() { }

        public static Dictionary<int, placement> _placement = new Dictionary<int, placement>();

        public static placement get(int i)
        {
            if (!_placement.ContainsKey(i)) _placement[i] = new placement();
            return _placement[i];
        }
    }
}