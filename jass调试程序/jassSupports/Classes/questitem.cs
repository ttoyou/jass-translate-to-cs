using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    using boolean = System.Boolean;
    using @string = System.String;
    /// <summary>
    /// ����ϸ��
    /// </summary>
    public class questitem:agent
    {
        public @string description = "";
        public boolean completed = false;
        public quest owner;
    }
}
