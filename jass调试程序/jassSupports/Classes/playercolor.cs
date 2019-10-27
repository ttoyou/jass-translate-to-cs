using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    /// <summary>
    /// Íæ¼ÒÑÕÉ«
    /// </summary>
    public class playercolor : handle
    {
        private playercolor() : base() { }
        static playercolor[] _color = new playercolor[12];

        static public playercolor get(int i)
        {
            if (_color[i] == null)
            {
                _color[i] = new playercolor();
            }
            return _color[i];
        }
    }
}
