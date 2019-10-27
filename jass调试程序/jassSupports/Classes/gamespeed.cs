using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class gamespeed:handle
    {
        private gamespeed() : base() { }

        public static Dictionary<int, gamespeed> _gamespeed = new Dictionary<int, gamespeed>();

        public static gamespeed get(int i)
        {
            if (!_gamespeed.ContainsKey(i)) _gamespeed[i] = new gamespeed();
            return _gamespeed[i];
        }
    }
}
