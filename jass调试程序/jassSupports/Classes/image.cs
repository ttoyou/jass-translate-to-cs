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
    public class image : handle
    {
        public boolean rendering = true;
        public integer type;
        public boolean destroyed = false;
        public boolean showed = true;
        public @string imageFilePath;

        public integer R;
        public integer G;
        public integer B;
        public integer A;

        public real x;
        public real y;
        public real z;
    }
}