using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class volumegroup:handle
    {
        private volumegroup() : base() { }

        public static Dictionary<int, volumegroup> _volumegroup = new Dictionary<int, volumegroup>();

        public static volumegroup get(int i)
        {
            if (!_volumegroup.ContainsKey(i)) _volumegroup[i] = new volumegroup();
            return _volumegroup[i];
        }
    }
}
