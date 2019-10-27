using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class limitop:eventid
    {
        private limitop() : base() { }

        public static Dictionary<int, limitop> _limitop = new Dictionary<int, limitop>();

        public static limitop get(int i)
        {
            if (!_limitop.ContainsKey(i)) _limitop[i] = new limitop();
            return _limitop[i];
        }
    }
}
