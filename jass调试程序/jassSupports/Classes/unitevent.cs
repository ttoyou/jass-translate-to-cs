using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class unitevent:eventid
    {
        private unitevent() : base() { }

        public static Dictionary<int, unitevent> _unitevent = new Dictionary<int, unitevent>();

        public static unitevent get(int i)
        {
            if (!_unitevent.ContainsKey(i)) _unitevent[i] = new unitevent();
            return _unitevent[i];
        }
    }
}