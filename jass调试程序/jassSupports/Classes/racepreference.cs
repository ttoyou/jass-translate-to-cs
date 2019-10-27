using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class racepreference:handle
    {
        private racepreference() : base() { }

        public static Dictionary<int, racepreference> _racepreference = new Dictionary<int, racepreference>();

        public static racepreference get(int i)
        {
            if (!_racepreference.ContainsKey(i)) _racepreference[i] = new racepreference();
            return _racepreference[i];
        }
    }
}
