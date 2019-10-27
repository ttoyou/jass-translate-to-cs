using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    public class camerafield:handle
    {
        private camerafield() : base() { }

        public static Dictionary<int, camerafield> _camerafield = new Dictionary<int, camerafield>();

        public static camerafield get(int i)
        {
            if (!_camerafield.ContainsKey(i)) _camerafield[i] = new camerafield();
            return _camerafield[i];
        }
    }
}
