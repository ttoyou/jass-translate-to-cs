using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    using integer = System.Int32;
    using real = System.Single;
    using boolean = System.Boolean;
    using @string = System.String;
    using code = System.Delegate;
    /// <summary>
    /// 点 表示点
    /// </summary>
    public class location : agent
    {
        public real x = 0;
        public real y = 0;
        public real z = 0;
    }
}
