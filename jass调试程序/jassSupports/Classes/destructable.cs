using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    using integer = System.Int32;
    using real = System.Single;
    using boolean = System.Boolean;
    public class destructable : widget
    {
        public boolean isInvulnerable = false;
        public boolean visible = true;
        public real occluderHeight = 0;

        public integer objectId;
        public integer variation;

        public real scale;
        public real facing;
        public real maxlife;

        public real z;
    }
}
