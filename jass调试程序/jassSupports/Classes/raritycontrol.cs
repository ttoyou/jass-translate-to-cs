using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class raritycontrol:handle
    {
        private raritycontrol() : base() { }

        public static Dictionary<int, raritycontrol> _raritycontrol = new Dictionary<int, raritycontrol>();

        public static raritycontrol get(int i)
        {
            if (!_raritycontrol.ContainsKey(i)) _raritycontrol[i] = new raritycontrol();
            return _raritycontrol[i];
        }
    }
}
