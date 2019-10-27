using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class gamedifficulty:handle
    {
        private gamedifficulty() : base() { }

        public static Dictionary<int, gamedifficulty> _gamedifficulty = new Dictionary<int, gamedifficulty>();

        public static gamedifficulty get(int i)
        {
            if (!_gamedifficulty.ContainsKey(i)) _gamedifficulty[i] = new gamedifficulty();
            return _gamedifficulty[i];
        }
    }
}
