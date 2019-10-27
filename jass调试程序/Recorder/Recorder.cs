using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Map;

namespace RuntimeRecorder
{
    static class Recorder
    {
        public static void RecorderInit()
        {
            for (int i=0; i<16; i++)
            {
                PlayerHandicap[i] = 100f;
            }
        }

        public static player LocalPlayer { get; set; } = player.get(1);

        public static float[] PlayerHandicap = new float[16];

        public static gamespeed GameSpeed { get; set; }

        public static gamedifficulty GameDifficulty { get; set; }

        public static string SkyModel { get; set; }

        public static List<unit> Units { get; } = new List<unit>();

        public static List<item> GameItems { get; } = new List<item>();

        public static List<trigger> Triggers { get; } = new List<trigger>();

        public static List<filterfunc> Filters = new List<filterfunc>();

        public static List<multiboard> Multiboards { get; } = new List<multiboard>();

        public static List<dialog> Dialogs { get; } = new List<dialog>();

        public static List<string> MessageList { get; } = new List<string>();

        public static List<timer> Timers { get; } = new List<timer>();

        public delegate void messageSending();

        public static event messageSending MessageSending;
    }

    static class MapSetting
    {
        public static string MapName { get; set; }

        public static string MapDescription { get; set; }

        public static int Teams { get; set; }

        public static int PlayerCount { get; set; }

        public static gamedifficulty DefaultDifficulty { get; set; }
    }
}
