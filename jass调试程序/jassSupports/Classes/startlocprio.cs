using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class startlocprio:handle
    {
        private startlocprio() : base() { }

        public static Dictionary<int, startlocprio> _startlocprio = new Dictionary<int, startlocprio>();

        public static startlocprio get(int i)
        {
            if (!_startlocprio.ContainsKey(i)) _startlocprio[i] = new startlocprio();
            return _startlocprio[i];
        }
    }
}