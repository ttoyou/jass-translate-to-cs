using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class playerscore:handle
    {
        private playerscore() : base() { }

        public static Dictionary<int, playerscore> _playerscore = new Dictionary<int, playerscore>();

        public static playerscore get(int i)
        {
            if (!_playerscore.ContainsKey(i)) _playerscore[i] = new playerscore();
            return _playerscore[i];
        }
    }
}