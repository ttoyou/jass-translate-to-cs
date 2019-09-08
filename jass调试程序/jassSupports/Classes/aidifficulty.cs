using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class aidifficulty:handle
    {
        private aidifficulty() : base() { }

        public static Dictionary<int, aidifficulty> _aidifficulty = new Dictionary<int, aidifficulty>();

        public static aidifficulty get(int i)
        {
            if (!_aidifficulty.ContainsKey(i)) _aidifficulty[i] = new aidifficulty();
            return _aidifficulty[i];
        }
    }
}