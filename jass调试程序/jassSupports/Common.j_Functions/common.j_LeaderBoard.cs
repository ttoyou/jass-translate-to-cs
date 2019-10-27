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
        /// 创建排行榜
        /// </summary>
        /// <returns>返回创建的排行榜</returns>
        public static leaderboard CreateLeaderboard()
        {
            return new leaderboard();
        }
        /// <summary>
        /// 摧毁排行榜
        /// </summary>
        /// <param name="lb"></param>
        public static void DestroyLeaderboard(leaderboard lb)
        {
            lb.destroyed = true;
        }

        public static void LeaderboardDisplay(leaderboard lb, boolean show)
        {
            lb.isDisplayed = show;
        }

        public static boolean IsLeaderboardDisplayed(leaderboard lb)
        {
            return lb.isDisplayed;
        }

        public static integer LeaderboardGetItemCount(leaderboard lb)
        {
            throw new NotImplementedException();
        }

        public static void LeaderboardSetSizeByItemCount(leaderboard lb, integer count)
        {
        }

        public static void LeaderboardAddItem(leaderboard lb, @string label, integer value, player p)
        {
        }

        public static void LeaderboardRemoveItem(leaderboard lb, integer index)
        {
        }

        public static void LeaderboardRemovePlayerItem(leaderboard lb, player p)
        {
        }

        public static void LeaderboardClear(leaderboard lb)
        {
        }

        public static void LeaderboardSortItemsByValue(leaderboard lb, boolean ascending)
        {
        }

        public static void LeaderboardSortItemsByPlayer(leaderboard lb, boolean ascending)
        {
        }

        public static void LeaderboardSortItemsByLabel(leaderboard lb, boolean ascending)
        {
        }

        public static boolean LeaderboardHasPlayerItem(leaderboard lb, player p)
        {
            throw new NotImplementedException();
        }

        public static integer LeaderboardGetPlayerIndex(leaderboard lb, player p)
        {
            throw new NotImplementedException();
        }

        public static void LeaderboardSetLabel(leaderboard lb, @string label)
        {
        }

        public static @string LeaderboardGetLabelText(leaderboard lb)
        {
            throw new NotImplementedException();
        }

        public static void PlayerSetLeaderboard(player toPlayer, leaderboard lb)
        {
        }

        public static leaderboard PlayerGetLeaderboard(player toPlayer)
        {
            throw new NotImplementedException();
        }

        public static void LeaderboardSetLabelColor(leaderboard lb, integer red, integer green, integer blue, integer alpha)
        {
            lb.titleR = red;
            lb.titleG = green;
            lb.titleB = blue;
            lb.titleA = alpha;
        }

        public static void LeaderboardSetValueColor(leaderboard lb, integer red, integer green, integer blue, integer alpha)
        {
        }

        public static void LeaderboardSetStyle(leaderboard lb, boolean showLabel, boolean showNames, boolean showValues, boolean showIcons)
        {
        }

        public static void LeaderboardSetItemValue(leaderboard lb, integer whichItem, integer val)
        {
        }

        public static void LeaderboardSetItemLabel(leaderboard lb, integer whichItem, @string val)
        {
        }

        public static void LeaderboardSetItemStyle(leaderboard lb, integer whichItem, boolean showLabel, boolean showValue, boolean showIcon)
        {
        }

        public static void LeaderboardSetItemLabelColor(leaderboard lb, integer whichItem, integer red, integer green, integer blue, integer alpha)
        {
        }

        public static void LeaderboardSetItemValueColor(leaderboard lb, integer whichItem, integer red, integer green, integer blue, integer alpha)
        {
        }
    }
}
