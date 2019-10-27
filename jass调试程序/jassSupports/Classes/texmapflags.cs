using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class texmapflags:handle
    {
        private texmapflags() : base() { }

        public static Dictionary<int, texmapflags> _texmapflags = new Dictionary<int, texmapflags>();

        public static texmapflags get(int i)
        {
            if (!_texmapflags.ContainsKey(i)) _texmapflags[i] = new texmapflags();
            return _texmapflags[i];
        }
    }
}
