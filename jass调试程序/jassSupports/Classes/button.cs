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
    /// 按钮 对话框的按钮
    /// </summary>
    public class button:agent
    {
        public @string text = "";
        public integer hotkey;
    }
}