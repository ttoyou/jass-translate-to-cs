using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    using real = System.Single;
    using @string = System.String;
    using integer = System.Int32;
    using boolean = System.Boolean;
    /// <summary>
    /// 多媒体面板 仅能展示图片和文字
    /// </summary>
    public class multiboard:agent
    {
        public boolean displayed = true;
        public boolean minimize = false;
        public @string title = "";
    }
}
