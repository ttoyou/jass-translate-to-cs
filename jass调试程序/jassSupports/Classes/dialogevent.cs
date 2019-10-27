using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    /// <summary>
    /// 对话框事件
    /// </summary>
    public class dialogevent:eventid
    {
        private dialogevent() : base() { }

        public static Dictionary<int, dialogevent> _dialogevent = new Dictionary<int, dialogevent>();

        public static dialogevent get(int i)
        {
            if (!_dialogevent.ContainsKey(i)) _dialogevent[i] = new dialogevent();
            return _dialogevent[i];
        }
    }
}
