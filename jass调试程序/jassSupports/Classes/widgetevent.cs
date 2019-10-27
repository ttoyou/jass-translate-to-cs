using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class widgetevent:eventid
    {
        private widgetevent() : base() { }

        public static Dictionary<int, widgetevent> _widgetevent = new Dictionary<int, widgetevent>();

        public static widgetevent get(int i)
        {
            if (!_widgetevent.ContainsKey(i)) _widgetevent[i] = new widgetevent();
            return _widgetevent[i];
        }
    }
}
