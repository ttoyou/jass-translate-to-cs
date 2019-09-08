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
    public class trackable:agent
    {
        public real x;
        public real y;
        public real facing;
        public @string modelPath;
    }
}