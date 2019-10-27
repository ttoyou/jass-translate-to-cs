using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    using integer = System.Int32;
    using real = System.Single;
    using boolean = System.Boolean;
    using @string = System.String;
    using code = System.Delegate;

    partial class MapScript
    {
        /// <summary>
        /// 创建对话框
        /// </summary>
        /// <returns>返回创建的对话框</returns>
        public static dialog DialogCreate()
        {
            dialog d = new dialog();
            
            return d;
        }
        /// <summary>
        /// 摧毁对话框
        /// </summary>
        /// <param name="whichDialog"></param>
        public static void DialogDestroy(dialog whichDialog)
        {
            RuntimeRecorder.Recorder.Dialogs.Remove(whichDialog);
            whichDialog.destroyed = true;
        }
        /// <summary>
        /// 清空对话框
        /// </summary>
        /// <param name="whichDialog"></param>
        public static void DialogClear(dialog whichDialog)
        {
            whichDialog.items.Clear();
        }

        public static void DialogSetMessage(dialog whichDialog, @string messageText)
        {
            whichDialog.message = messageText;
        }
        /// <summary>
        /// 对话框添加按钮
        /// </summary>
        /// <param name="whichDialog">对话框</param>
        /// <param name="buttonText">按钮文本</param>
        /// <param name="hotkey">快捷键</param>
        /// <returns>返回添加的按钮</returns>
        public static button DialogAddButton(dialog whichDialog, @string buttonText, integer hotkey)
        {
            button btn = new button { text = buttonText, hotkey = hotkey };
            whichDialog.items.Add(btn);
            return btn;
        }

        public static button DialogAddQuitButton(dialog whichDialog, boolean doScoreScreen, @string buttonText, integer hotkey)
        {
            throw new NotImplementedException();
        }

        public static void DialogDisplay(player whichPlayer, dialog whichDialog, boolean flag)
        {
            whichDialog.displayed[whichPlayer] = flag;
        }

        public static void DisplayLoadDialog()
        {
        }
    }
}
