using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    using boolean = System.Boolean;
    /// <summary>
    /// ¶Ô»°¿ò
    /// </summary>
    public class dialog:agent
    {
        public dialog():base()
        {

        }
        public boolean[] displayed = new boolean[16];
        public List<button> items = new List<button>();
    }
}