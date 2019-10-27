using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class playergameresult:handle
    {
        private playergameresult() : base() { }

        public static Dictionary<int, playergameresult> _playergameresult = new Dictionary<int, playergameresult>();

        public static playergameresult get(int i)
        {
            if (!_playergameresult.ContainsKey(i)) _playergameresult[i] = new playergameresult();
            return _playergameresult[i];
        }
    }
}
