using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    /// <summary>
    /// 玩家事件类型
    /// </summary>
    public class playerevent : eventid
    {
        private playerevent() : base() { }

        public static Dictionary<int, playerevent> _playerevent = new Dictionary<int, playerevent>();

        public static playerevent get(int i)
        {
            if (!_playerevent.ContainsKey(i)) _playerevent[i] = new playerevent();
            return _playerevent[i];
        }
    }
}
