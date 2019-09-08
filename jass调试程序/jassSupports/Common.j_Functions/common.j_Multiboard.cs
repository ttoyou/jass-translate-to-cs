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
        public static multiboard CreateMultiboard()
        {
            multiboard m = new multiboard();
            RuntimeRecorder.Recorder.Multiboards.Add(m);
            return new multiboard();
        }

        public static void DestroyMultiboard(multiboard lb)
        {
            lb.destroyed = true;
            RuntimeRecorder.Recorder.Multiboards.Remove(lb);
        }

        public static void MultiboardDisplay(multiboard lb, boolean show)
        {
            lb.displayed = show;
        }

        public static boolean IsMultiboardDisplayed(multiboard lb)
        {
            return lb.displayed;
        }

        public static void MultiboardMinimize(multiboard lb, boolean minimize)
        {
            lb.minimize = minimize;
        }

        public static boolean IsMultiboardMinimized(multiboard lb)
        {
            return lb.minimize;
        }

        public static void MultiboardClear(multiboard lb)
        {
        }

        public static void MultiboardSetTitleText(multiboard lb, @string label)
        {
            lb.title = label;
        }

        public static @string MultiboardGetTitleText(multiboard lb)
        {
            return lb.title;
        }

        public static void MultiboardSetTitleTextColor(multiboard lb, integer red, integer green, integer blue, integer alpha)
        {
        }

        public static integer MultiboardGetRowCount(multiboard lb)
        {
            throw new NotImplementedException();
        }

        public static integer MultiboardGetColumnCount(multiboard lb)
        {
            throw new NotImplementedException();
        }

        public static void MultiboardSetColumnCount(multiboard lb, integer count)
        {
        }

        public static void MultiboardSetRowCount(multiboard lb, integer count)
        {
        }

        public static void MultiboardSetItemsStyle(multiboard lb, boolean showValues, boolean showIcons)
        {
        }

        public static void MultiboardSetItemsValue(multiboard lb, @string value)
        {
        }

        public static void MultiboardSetItemsValueColor(multiboard lb, integer red, integer green, integer blue, integer alpha)
        {
        }

        public static void MultiboardSetItemsWidth(multiboard lb, real width)
        {
        }

        public static void MultiboardSetItemsIcon(multiboard lb, @string iconPath)
        {
        }

        public static multiboarditem MultiboardGetItem(multiboard lb, integer row, integer column)
        {
            throw new NotImplementedException();
        }

        public static void MultiboardReleaseItem(multiboarditem mbi)
        {
        }

        public static void MultiboardSetItemStyle(multiboarditem mbi, boolean showValue, boolean showIcon)
        {
        }

        public static void MultiboardSetItemValue(multiboarditem mbi, @string val)
        {
        }

        public static void MultiboardSetItemValueColor(multiboarditem mbi, integer red, integer green, integer blue, integer alpha)
        {
        }

        public static void MultiboardSetItemWidth(multiboarditem mbi, real width)
        {
        }

        public static void MultiboardSetItemIcon(multiboarditem mbi, @string iconFileName)
        {
        }

        public static void MultiboardSuppressDisplay(boolean flag)
        {
        }
    }
}
