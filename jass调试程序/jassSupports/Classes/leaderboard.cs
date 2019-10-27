using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using leaderboarditem = Map.Extra.leaderboarditem;

namespace Map
{
    using integer = System.Int32;
    using real = System.Single;
    using boolean = System.Boolean;
    using @string = System.String;
    using code = System.Delegate;
    /// <summary>
    /// 游戏中的排行榜
    /// </summary>
    public class leaderboard : agent
    {
        public boolean isDisplayed = true;
        public integer titleR;
        public integer titleG;
        public integer titleB;
        public integer titleA;

        private List<leaderboarditem> items = new List<leaderboarditem>();
    }
}
