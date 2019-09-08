using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class itemtype:handle
    {
        private itemtype() : base() { }

        public static Dictionary<int, itemtype> _itemtype = new Dictionary<int, itemtype>();

        public static itemtype get(int i)
        {
            if (!_itemtype.ContainsKey(i)) _itemtype[i] = new itemtype();
            return _itemtype[i];
        }
    }
}