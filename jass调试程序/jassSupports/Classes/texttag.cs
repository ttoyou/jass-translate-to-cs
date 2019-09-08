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
    public class texttag:handle
    {
        public boolean destroyed = false;
        public boolean showed=true;

        public real life;
        public real age;
        public real height;
        public @string text;
        public real x;
        public real y;
    }
}