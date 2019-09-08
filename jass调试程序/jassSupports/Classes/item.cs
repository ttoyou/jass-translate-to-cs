using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    using integer = System.Int32;
    using boolean = System.Boolean;
    using real = System.Single;
    /// <summary>
    /// 物品实体
    /// </summary>
    public class item : widget
    {
        public itemtype itemtype;
        public integer itemlevel;
        public boolean isInvulnerable = false;
        public boolean dropable = true;
        public boolean dropOndeath = false;
        public boolean visiable = true;
        public boolean pawnable = false;

        public integer charge=0;

        public player owner;
        public integer userData = 0;
    }
}