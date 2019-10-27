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
    public class sound:agent
    {
        public @string fileName;
        public boolean looping = false;
        public boolean is3D = false;
        public boolean stopWhenOutOfRange = false;
        public integer fadeInRate;
        public integer fadeOutRate;
        public @string eaxSetting;
        public @string SLKEntryName;
        public @string soundLabel;

        public boolean playing;

        public real x;
        public real y;
        public real z;
    }
}
