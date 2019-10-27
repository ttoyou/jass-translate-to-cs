using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    using integer = System.Int32;
    using boolean = System.Boolean;
    using real = System.Single;
    using @string = System.String;
    /// <summary>
    /// 游戏中的对话框
    /// </summary>
    public class dialog:agent
    {
        public dialog():base()
        {
            RuntimeRecorder.Recorder.Dialogs.Add(this);
        }
        public boolean[] displayed = new boolean[16];
        public List<button> items = new List<button>();
        public @string message = "";
    }
}
