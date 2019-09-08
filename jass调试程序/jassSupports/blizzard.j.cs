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
    public partial class MapScript
    {

        public static real bj_PI = 3.14159f;

        public static real bj_E = 2.71828f;

        public static real bj_CELLWIDTH = 128f;

        public static real bj_CLIFFHEIGHT = 128f;

        public static real bj_UNIT_FACING = 270f;

        public static real bj_RADTODEG = 180f / bj_PI;

        public static real bj_DEGTORAD = bj_PI / 180f;

        public static real bj_TEXT_DELAY_QUEST = 20f;

        public static real bj_TEXT_DELAY_QUESTUPDATE = 20f;

        public static real bj_TEXT_DELAY_QUESTDONE = 20f;

        public static real bj_TEXT_DELAY_QUESTFAILED = 20f;

        public static real bj_TEXT_DELAY_QUESTREQUIREMENT = 20f;

        public static real bj_TEXT_DELAY_MISSIONFAILED = 20f;

        public static real bj_TEXT_DELAY_ALWAYSHINT = 12f;

        public static real bj_TEXT_DELAY_HINT = 12f;

        public static real bj_TEXT_DELAY_SECRET = 10f;

        public static real bj_TEXT_DELAY_UNITACQUIRED = 15f;

        public static real bj_TEXT_DELAY_UNITAVAILABLE = 10f;

        public static real bj_TEXT_DELAY_ITEMACQUIRED = 10f;

        public static real bj_TEXT_DELAY_WARNING = 12f;

        public static real bj_QUEUE_DELAY_QUEST = 5f;

        public static real bj_QUEUE_DELAY_HINT = 5f;

        public static real bj_QUEUE_DELAY_SECRET = 3f;

        public static real bj_HANDICAP_EASY = 60f;

        public static real bj_GAME_STARTED_THRESHOLD = 0.01f;

        public static real bj_WAIT_FOR_COND_MIN_INTERVAL = 0.1f;

        public static real bj_POLLED_WAIT_INTERVAL = 0.1f;

        public static real bj_POLLED_WAIT_SKIP_THRESHOLD = 2f;

        public static integer bj_MAX_INVENTORY = 6;

        public static integer bj_MAX_PLAYERS = 12;

        public static integer bj_PLAYER_NEUTRAL_VICTIM = 13;

        public static integer bj_PLAYER_NEUTRAL_EXTRA = 14;

        public static integer bj_MAX_PLAYER_SLOTS = 16;

        public static integer bj_MAX_SKELETONS = 25;

        public static integer bj_MAX_STOCK_ITEM_SLOTS = 11;

        public static integer bj_MAX_STOCK_UNIT_SLOTS = 11;

        public static integer bj_MAX_ITEM_LEVEL = 10;

        public static real bj_TOD_DAWN = 6f;

        public static real bj_TOD_DUSK = 18f;

        public static real bj_MELEE_STARTING_TOD = 8f;

        public static integer bj_MELEE_STARTING_GOLD_V0 = 750;

        public static integer bj_MELEE_STARTING_GOLD_V1 = 500;

        public static integer bj_MELEE_STARTING_LUMBER_V0 = 200;

        public static integer bj_MELEE_STARTING_LUMBER_V1 = 150;

        public static integer bj_MELEE_STARTING_HERO_TOKENS = 1;

        public static integer bj_MELEE_HERO_LIMIT = 3;

        public static integer bj_MELEE_HERO_TYPE_LIMIT = 1;

        public static real bj_MELEE_MINE_SEARCH_RADIUS = 2000;

        public static real bj_MELEE_CLEAR_UNITS_RADIUS = 1500;

        public static real bj_MELEE_CRIPPLE_TIMEOUT = 120f;

        public static real bj_MELEE_CRIPPLE_MSG_DURATION = 20f;

        public static integer bj_MELEE_MAX_TWINKED_HEROES_V0 = 3;

        public static integer bj_MELEE_MAX_TWINKED_HEROES_V1 = 1;

        public static real bj_CREEP_ITEM_DELAY = 0.5f;

        public static real bj_STOCK_RESTOCK_INITIAL_DELAY = 120;

        public static real bj_STOCK_RESTOCK_INTERVAL = 30;

        public static integer bj_STOCK_MAX_ITERATIONS = 20;

        public static integer bj_MAX_DEST_IN_REGION_EVENTS = 64;

        public static integer bj_CAMERA_MIN_FARZ = 100;

        public static integer bj_CAMERA_DEFAULT_DISTANCE = 1650;

        public static integer bj_CAMERA_DEFAULT_FARZ = 5000;

        public static integer bj_CAMERA_DEFAULT_AOA = 304;

        public static integer bj_CAMERA_DEFAULT_FOV = 70;

        public static integer bj_CAMERA_DEFAULT_ROLL = 0;

        public static integer bj_CAMERA_DEFAULT_ROTATION = 90;

        public static real bj_RESCUE_PING_TIME = 2f;

        public static real bj_NOTHING_SOUND_DURATION = 5f;

        public static real bj_TRANSMISSION_PING_TIME = 1f;

        public static integer bj_TRANSMISSION_IND_RED = 255;

        public static integer bj_TRANSMISSION_IND_BLUE = 255;

        public static integer bj_TRANSMISSION_IND_GREEN = 255;

        public static integer bj_TRANSMISSION_IND_ALPHA = 255;

        public static real bj_TRANSMISSION_PORT_HANGTIME = 1.5f;

        public static real bj_CINEMODE_INTERFACEFADE = 0.5f;

        public static gamespeed bj_CINEMODE_GAMESPEED = MAP_SPEED_NORMAL;

        public static real bj_CINEMODE_VOLUME_UNITMOVEMENT = 0.4f;

        public static real bj_CINEMODE_VOLUME_UNITSOUNDS = 0f;

        public static real bj_CINEMODE_VOLUME_COMBAT = 0.4f;

        public static real bj_CINEMODE_VOLUME_SPELLS = 0.4f;

        public static real bj_CINEMODE_VOLUME_UI = 0f;

        public static real bj_CINEMODE_VOLUME_MUSIC = 0.55f;

        public static real bj_CINEMODE_VOLUME_AMBIENTSOUNDS = 1f;

        public static real bj_CINEMODE_VOLUME_FIRE = 0.6f;

        public static real bj_SPEECH_VOLUME_UNITMOVEMENT = 0.25f;

        public static real bj_SPEECH_VOLUME_UNITSOUNDS = 0f;

        public static real bj_SPEECH_VOLUME_COMBAT = 0.25f;

        public static real bj_SPEECH_VOLUME_SPELLS = 0.25f;

        public static real bj_SPEECH_VOLUME_UI = 0f;

        public static real bj_SPEECH_VOLUME_MUSIC = 0.55f;

        public static real bj_SPEECH_VOLUME_AMBIENTSOUNDS = 1f;

        public static real bj_SPEECH_VOLUME_FIRE = 0.6f;

        public static real bj_SMARTPAN_TRESHOLD_PAN = 500;

        public static real bj_SMARTPAN_TRESHOLD_SNAP = 3500;

        public static integer bj_MAX_QUEUED_TRIGGERS = 100;

        public static real bj_QUEUED_TRIGGER_TIMEOUT = 180f;

        public static integer bj_CAMPAIGN_INDEX_T = 0;

        public static integer bj_CAMPAIGN_INDEX_H = 1;

        public static integer bj_CAMPAIGN_INDEX_U = 2;

        public static integer bj_CAMPAIGN_INDEX_O = 3;

        public static integer bj_CAMPAIGN_INDEX_N = 4;

        public static integer bj_CAMPAIGN_INDEX_XN = 5;

        public static integer bj_CAMPAIGN_INDEX_XH = 6;

        public static integer bj_CAMPAIGN_INDEX_XU = 7;

        public static integer bj_CAMPAIGN_INDEX_XO = 8;

        public static integer bj_CAMPAIGN_OFFSET_T = 0;

        public static integer bj_CAMPAIGN_OFFSET_H = 1;

        public static integer bj_CAMPAIGN_OFFSET_U = 2;

        public static integer bj_CAMPAIGN_OFFSET_O = 3;

        public static integer bj_CAMPAIGN_OFFSET_N = 4;

        public static integer bj_CAMPAIGN_OFFSET_XN = 0;

        public static integer bj_CAMPAIGN_OFFSET_XH = 1;

        public static integer bj_CAMPAIGN_OFFSET_XU = 2;

        public static integer bj_CAMPAIGN_OFFSET_XO = 3;

        public static integer bj_MISSION_INDEX_T00 = bj_CAMPAIGN_OFFSET_T * 1000 + 0;

        public static integer bj_MISSION_INDEX_T01 = bj_CAMPAIGN_OFFSET_T * 1000 + 1;

        public static integer bj_MISSION_INDEX_H00 = bj_CAMPAIGN_OFFSET_H * 1000 + 0;

        public static integer bj_MISSION_INDEX_H01 = bj_CAMPAIGN_OFFSET_H * 1000 + 1;

        public static integer bj_MISSION_INDEX_H02 = bj_CAMPAIGN_OFFSET_H * 1000 + 2;

        public static integer bj_MISSION_INDEX_H03 = bj_CAMPAIGN_OFFSET_H * 1000 + 3;

        public static integer bj_MISSION_INDEX_H04 = bj_CAMPAIGN_OFFSET_H * 1000 + 4;

        public static integer bj_MISSION_INDEX_H05 = bj_CAMPAIGN_OFFSET_H * 1000 + 5;

        public static integer bj_MISSION_INDEX_H06 = bj_CAMPAIGN_OFFSET_H * 1000 + 6;

        public static integer bj_MISSION_INDEX_H07 = bj_CAMPAIGN_OFFSET_H * 1000 + 7;

        public static integer bj_MISSION_INDEX_H08 = bj_CAMPAIGN_OFFSET_H * 1000 + 8;

        public static integer bj_MISSION_INDEX_H09 = bj_CAMPAIGN_OFFSET_H * 1000 + 9;

        public static integer bj_MISSION_INDEX_H10 = bj_CAMPAIGN_OFFSET_H * 1000 + 10;

        public static integer bj_MISSION_INDEX_H11 = bj_CAMPAIGN_OFFSET_H * 1000 + 11;

        public static integer bj_MISSION_INDEX_U00 = bj_CAMPAIGN_OFFSET_U * 1000 + 0;

        public static integer bj_MISSION_INDEX_U01 = bj_CAMPAIGN_OFFSET_U * 1000 + 1;

        public static integer bj_MISSION_INDEX_U02 = bj_CAMPAIGN_OFFSET_U * 1000 + 2;

        public static integer bj_MISSION_INDEX_U03 = bj_CAMPAIGN_OFFSET_U * 1000 + 3;

        public static integer bj_MISSION_INDEX_U05 = bj_CAMPAIGN_OFFSET_U * 1000 + 4;

        public static integer bj_MISSION_INDEX_U07 = bj_CAMPAIGN_OFFSET_U * 1000 + 5;

        public static integer bj_MISSION_INDEX_U08 = bj_CAMPAIGN_OFFSET_U * 1000 + 6;

        public static integer bj_MISSION_INDEX_U09 = bj_CAMPAIGN_OFFSET_U * 1000 + 7;

        public static integer bj_MISSION_INDEX_U10 = bj_CAMPAIGN_OFFSET_U * 1000 + 8;

        public static integer bj_MISSION_INDEX_U11 = bj_CAMPAIGN_OFFSET_U * 1000 + 9;

        public static integer bj_MISSION_INDEX_O00 = bj_CAMPAIGN_OFFSET_O * 1000 + 0;

        public static integer bj_MISSION_INDEX_O01 = bj_CAMPAIGN_OFFSET_O * 1000 + 1;

        public static integer bj_MISSION_INDEX_O02 = bj_CAMPAIGN_OFFSET_O * 1000 + 2;

        public static integer bj_MISSION_INDEX_O03 = bj_CAMPAIGN_OFFSET_O * 1000 + 3;

        public static integer bj_MISSION_INDEX_O04 = bj_CAMPAIGN_OFFSET_O * 1000 + 4;

        public static integer bj_MISSION_INDEX_O05 = bj_CAMPAIGN_OFFSET_O * 1000 + 5;

        public static integer bj_MISSION_INDEX_O06 = bj_CAMPAIGN_OFFSET_O * 1000 + 6;

        public static integer bj_MISSION_INDEX_O07 = bj_CAMPAIGN_OFFSET_O * 1000 + 7;

        public static integer bj_MISSION_INDEX_O08 = bj_CAMPAIGN_OFFSET_O * 1000 + 8;

        public static integer bj_MISSION_INDEX_O09 = bj_CAMPAIGN_OFFSET_O * 1000 + 9;

        public static integer bj_MISSION_INDEX_O10 = bj_CAMPAIGN_OFFSET_O * 1000 + 10;

        public static integer bj_MISSION_INDEX_N00 = bj_CAMPAIGN_OFFSET_N * 1000 + 0;

        public static integer bj_MISSION_INDEX_N01 = bj_CAMPAIGN_OFFSET_N * 1000 + 1;

        public static integer bj_MISSION_INDEX_N02 = bj_CAMPAIGN_OFFSET_N * 1000 + 2;

        public static integer bj_MISSION_INDEX_N03 = bj_CAMPAIGN_OFFSET_N * 1000 + 3;

        public static integer bj_MISSION_INDEX_N04 = bj_CAMPAIGN_OFFSET_N * 1000 + 4;

        public static integer bj_MISSION_INDEX_N05 = bj_CAMPAIGN_OFFSET_N * 1000 + 5;

        public static integer bj_MISSION_INDEX_N06 = bj_CAMPAIGN_OFFSET_N * 1000 + 6;

        public static integer bj_MISSION_INDEX_N07 = bj_CAMPAIGN_OFFSET_N * 1000 + 7;

        public static integer bj_MISSION_INDEX_N08 = bj_CAMPAIGN_OFFSET_N * 1000 + 8;

        public static integer bj_MISSION_INDEX_N09 = bj_CAMPAIGN_OFFSET_N * 1000 + 9;

        public static integer bj_MISSION_INDEX_XN00 = bj_CAMPAIGN_OFFSET_XN * 1000 + 0;

        public static integer bj_MISSION_INDEX_XN01 = bj_CAMPAIGN_OFFSET_XN * 1000 + 1;

        public static integer bj_MISSION_INDEX_XN02 = bj_CAMPAIGN_OFFSET_XN * 1000 + 2;

        public static integer bj_MISSION_INDEX_XN03 = bj_CAMPAIGN_OFFSET_XN * 1000 + 3;

        public static integer bj_MISSION_INDEX_XN04 = bj_CAMPAIGN_OFFSET_XN * 1000 + 4;

        public static integer bj_MISSION_INDEX_XN05 = bj_CAMPAIGN_OFFSET_XN * 1000 + 5;

        public static integer bj_MISSION_INDEX_XN06 = bj_CAMPAIGN_OFFSET_XN * 1000 + 6;

        public static integer bj_MISSION_INDEX_XN07 = bj_CAMPAIGN_OFFSET_XN * 1000 + 7;

        public static integer bj_MISSION_INDEX_XN08 = bj_CAMPAIGN_OFFSET_XN * 1000 + 8;

        public static integer bj_MISSION_INDEX_XN09 = bj_CAMPAIGN_OFFSET_XN * 1000 + 9;

        public static integer bj_MISSION_INDEX_XN10 = bj_CAMPAIGN_OFFSET_XN * 1000 + 10;

        public static integer bj_MISSION_INDEX_XH00 = bj_CAMPAIGN_OFFSET_XH * 1000 + 0;

        public static integer bj_MISSION_INDEX_XH01 = bj_CAMPAIGN_OFFSET_XH * 1000 + 1;

        public static integer bj_MISSION_INDEX_XH02 = bj_CAMPAIGN_OFFSET_XH * 1000 + 2;

        public static integer bj_MISSION_INDEX_XH03 = bj_CAMPAIGN_OFFSET_XH * 1000 + 3;

        public static integer bj_MISSION_INDEX_XH04 = bj_CAMPAIGN_OFFSET_XH * 1000 + 4;

        public static integer bj_MISSION_INDEX_XH05 = bj_CAMPAIGN_OFFSET_XH * 1000 + 5;

        public static integer bj_MISSION_INDEX_XH06 = bj_CAMPAIGN_OFFSET_XH * 1000 + 6;

        public static integer bj_MISSION_INDEX_XH07 = bj_CAMPAIGN_OFFSET_XH * 1000 + 7;

        public static integer bj_MISSION_INDEX_XH08 = bj_CAMPAIGN_OFFSET_XH * 1000 + 8;

        public static integer bj_MISSION_INDEX_XH09 = bj_CAMPAIGN_OFFSET_XH * 1000 + 9;

        public static integer bj_MISSION_INDEX_XU00 = bj_CAMPAIGN_OFFSET_XU * 1000 + 0;

        public static integer bj_MISSION_INDEX_XU01 = bj_CAMPAIGN_OFFSET_XU * 1000 + 1;

        public static integer bj_MISSION_INDEX_XU02 = bj_CAMPAIGN_OFFSET_XU * 1000 + 2;

        public static integer bj_MISSION_INDEX_XU03 = bj_CAMPAIGN_OFFSET_XU * 1000 + 3;

        public static integer bj_MISSION_INDEX_XU04 = bj_CAMPAIGN_OFFSET_XU * 1000 + 4;

        public static integer bj_MISSION_INDEX_XU05 = bj_CAMPAIGN_OFFSET_XU * 1000 + 5;

        public static integer bj_MISSION_INDEX_XU06 = bj_CAMPAIGN_OFFSET_XU * 1000 + 6;

        public static integer bj_MISSION_INDEX_XU07 = bj_CAMPAIGN_OFFSET_XU * 1000 + 7;

        public static integer bj_MISSION_INDEX_XU08 = bj_CAMPAIGN_OFFSET_XU * 1000 + 8;

        public static integer bj_MISSION_INDEX_XU09 = bj_CAMPAIGN_OFFSET_XU * 1000 + 9;

        public static integer bj_MISSION_INDEX_XU10 = bj_CAMPAIGN_OFFSET_XU * 1000 + 10;

        public static integer bj_MISSION_INDEX_XU11 = bj_CAMPAIGN_OFFSET_XU * 1000 + 11;

        public static integer bj_MISSION_INDEX_XU12 = bj_CAMPAIGN_OFFSET_XU * 1000 + 12;

        public static integer bj_MISSION_INDEX_XU13 = bj_CAMPAIGN_OFFSET_XU * 1000 + 13;

        public static integer bj_MISSION_INDEX_XO00 = bj_CAMPAIGN_OFFSET_XO * 1000 + 0;

        public static integer bj_CINEMATICINDEX_TOP = 0;

        public static integer bj_CINEMATICINDEX_HOP = 1;

        public static integer bj_CINEMATICINDEX_HED = 2;

        public static integer bj_CINEMATICINDEX_OOP = 3;

        public static integer bj_CINEMATICINDEX_OED = 4;

        public static integer bj_CINEMATICINDEX_UOP = 5;

        public static integer bj_CINEMATICINDEX_UED = 6;

        public static integer bj_CINEMATICINDEX_NOP = 7;

        public static integer bj_CINEMATICINDEX_NED = 8;

        public static integer bj_CINEMATICINDEX_XOP = 9;

        public static integer bj_CINEMATICINDEX_XED = 10;

        public static integer bj_ALLIANCE_UNALLIED = 0;

        public static integer bj_ALLIANCE_UNALLIED_VISION = 1;

        public static integer bj_ALLIANCE_ALLIED = 2;

        public static integer bj_ALLIANCE_ALLIED_VISION = 3;

        public static integer bj_ALLIANCE_ALLIED_UNITS = 4;

        public static integer bj_ALLIANCE_ALLIED_ADVUNITS = 5;

        public static integer bj_ALLIANCE_NEUTRAL = 6;

        public static integer bj_ALLIANCE_NEUTRAL_VISION = 7;

        public static integer bj_KEYEVENTTYPE_DEPRESS = 0;

        public static integer bj_KEYEVENTTYPE_RELEASE = 1;

        public static integer bj_KEYEVENTKEY_LEFT = 0;

        public static integer bj_KEYEVENTKEY_RIGHT = 1;

        public static integer bj_KEYEVENTKEY_DOWN = 2;

        public static integer bj_KEYEVENTKEY_UP = 3;

        public static integer bj_TIMETYPE_ADD = 0;

        public static integer bj_TIMETYPE_SET = 1;

        public static integer bj_TIMETYPE_SUB = 2;

        public static integer bj_CAMERABOUNDS_ADJUST_ADD = 0;

        public static integer bj_CAMERABOUNDS_ADJUST_SUB = 1;

        public static integer bj_QUESTTYPE_REQ_DISCOVERED = 0;

        public static integer bj_QUESTTYPE_REQ_UNDISCOVERED = 1;

        public static integer bj_QUESTTYPE_OPT_DISCOVERED = 2;

        public static integer bj_QUESTTYPE_OPT_UNDISCOVERED = 3;

        public static integer bj_QUESTMESSAGE_DISCOVERED = 0;

        public static integer bj_QUESTMESSAGE_UPDATED = 1;

        public static integer bj_QUESTMESSAGE_COMPLETED = 2;

        public static integer bj_QUESTMESSAGE_FAILED = 3;

        public static integer bj_QUESTMESSAGE_REQUIREMENT = 4;

        public static integer bj_QUESTMESSAGE_MISSIONFAILED = 5;

        public static integer bj_QUESTMESSAGE_ALWAYSHINT = 6;

        public static integer bj_QUESTMESSAGE_HINT = 7;

        public static integer bj_QUESTMESSAGE_SECRET = 8;

        public static integer bj_QUESTMESSAGE_UNITACQUIRED = 9;

        public static integer bj_QUESTMESSAGE_UNITAVAILABLE = 10;

        public static integer bj_QUESTMESSAGE_ITEMACQUIRED = 11;

        public static integer bj_QUESTMESSAGE_WARNING = 12;

        public static integer bj_SORTTYPE_SORTBYVALUE = 0;

        public static integer bj_SORTTYPE_SORTBYPLAYER = 1;

        public static integer bj_SORTTYPE_SORTBYLABEL = 2;

        public static integer bj_CINEFADETYPE_FADEIN = 0;

        public static integer bj_CINEFADETYPE_FADEOUT = 1;

        public static integer bj_CINEFADETYPE_FADEOUTIN = 2;

        public static integer bj_REMOVEBUFFS_POSITIVE = 0;

        public static integer bj_REMOVEBUFFS_NEGATIVE = 1;

        public static integer bj_REMOVEBUFFS_ALL = 2;

        public static integer bj_REMOVEBUFFS_NONTLIFE = 3;

        public static integer bj_BUFF_POLARITY_POSITIVE = 0;

        public static integer bj_BUFF_POLARITY_NEGATIVE = 1;

        public static integer bj_BUFF_POLARITY_EITHER = 2;

        public static integer bj_BUFF_RESIST_MAGIC = 0;

        public static integer bj_BUFF_RESIST_PHYSICAL = 1;

        public static integer bj_BUFF_RESIST_EITHER = 2;

        public static integer bj_BUFF_RESIST_BOTH = 3;

        public static integer bj_HEROSTAT_STR = 0;

        public static integer bj_HEROSTAT_AGI = 1;

        public static integer bj_HEROSTAT_INT = 2;

        public static integer bj_MODIFYMETHOD_ADD = 0;

        public static integer bj_MODIFYMETHOD_SUB = 1;

        public static integer bj_MODIFYMETHOD_SET = 2;

        public static integer bj_UNIT_STATE_METHOD_ABSOLUTE = 0;

        public static integer bj_UNIT_STATE_METHOD_RELATIVE = 1;

        public static integer bj_UNIT_STATE_METHOD_DEFAULTS = 2;

        public static integer bj_UNIT_STATE_METHOD_MAXIMUM = 3;

        public static integer bj_GATEOPERATION_CLOSE = 0;

        public static integer bj_GATEOPERATION_OPEN = 1;

        public static integer bj_GATEOPERATION_DESTROY = 2;

        public static integer bj_GAMECACHE_BOOLEAN = 0;

        public static integer bj_GAMECACHE_INTEGER = 1;

        public static integer bj_GAMECACHE_REAL = 2;

        public static integer bj_GAMECACHE_UNIT = 3;

        public static integer bj_GAMECACHE_STRING = 4;

        public static integer bj_HASHTABLE_BOOLEAN = 0;

        public static integer bj_HASHTABLE_INTEGER = 1;

        public static integer bj_HASHTABLE_REAL = 2;

        public static integer bj_HASHTABLE_STRING = 3;

        public static integer bj_HASHTABLE_HANDLE = 4;

        public static integer bj_ITEM_STATUS_HIDDEN = 0;

        public static integer bj_ITEM_STATUS_OWNED = 1;

        public static integer bj_ITEM_STATUS_INVULNERABLE = 2;

        public static integer bj_ITEM_STATUS_POWERUP = 3;

        public static integer bj_ITEM_STATUS_SELLABLE = 4;

        public static integer bj_ITEM_STATUS_PAWNABLE = 5;

        public static integer bj_ITEMCODE_STATUS_POWERUP = 0;

        public static integer bj_ITEMCODE_STATUS_SELLABLE = 1;

        public static integer bj_ITEMCODE_STATUS_PAWNABLE = 2;

        public static integer bj_MINIMAPPINGSTYLE_SIMPLE = 0;

        public static integer bj_MINIMAPPINGSTYLE_FLASHY = 1;

        public static integer bj_MINIMAPPINGSTYLE_ATTACK = 2;

        public static real bj_CORPSE_MAX_DEATH_TIME = 8f;

        public static integer bj_CORPSETYPE_FLESH = 0;

        public static integer bj_CORPSETYPE_BONE = 1;

        public static integer bj_ELEVATOR_BLOCKER_CODE = 1885688900;

        public static integer bj_ELEVATOR_CODE01 = 1718768708;

        public static integer bj_ELEVATOR_CODE02 = 2020758596;

        public static integer bj_ELEVATOR_WALL_TYPE_ALL = 0;

        public static integer bj_ELEVATOR_WALL_TYPE_EAST = 1;

        public static integer bj_ELEVATOR_WALL_TYPE_NORTH = 2;

        public static integer bj_ELEVATOR_WALL_TYPE_SOUTH = 3;

        public static integer bj_ELEVATOR_WALL_TYPE_WEST = 4;

        public force bj_FORCE_ALL_PLAYERS = null;

        public array<int, force> bj_FORCE_PLAYER = new array<int, force>();

        public integer bj_MELEE_MAX_TWINKED_HEROES = 0;

        public rect bj_mapInitialPlayableArea = null;

        public rect bj_mapInitialCameraBounds = null;

        public integer bj_forLoopAIndex = 0;

        public integer bj_forLoopBIndex = 0;

        public integer bj_forLoopAIndexEnd = 0;

        public integer bj_forLoopBIndexEnd = 0;

        public boolean bj_slotControlReady = false;

        public array<int, boolean> bj_slotControlUsed = new array<int, boolean>();

        public array<int, mapcontrol> bj_slotControl = new array<int, mapcontrol>();

        public timer bj_gameStartedTimer = null;

        public boolean bj_gameStarted = false;

        public timer bj_volumeGroupsTimer = CreateTimer();

        public boolean bj_isSinglePlayer = false;

        public trigger bj_dncSoundsDay = null;

        public trigger bj_dncSoundsNight = null;

        public sound bj_dayAmbientSound = null;

        public sound bj_nightAmbientSound = null;

        public trigger bj_dncSoundsDawn = null;

        public trigger bj_dncSoundsDusk = null;

        public sound bj_dawnSound = null;

        public sound bj_duskSound = null;

        public boolean bj_useDawnDuskSounds = true;

        public boolean bj_dncIsDaytime = false;

        public sound bj_rescueSound = null;

        public sound bj_questDiscoveredSound = null;

        public sound bj_questUpdatedSound = null;

        public sound bj_questCompletedSound = null;

        public sound bj_questFailedSound = null;

        public sound bj_questHintSound = null;

        public sound bj_questSecretSound = null;

        public sound bj_questItemAcquiredSound = null;

        public sound bj_questWarningSound = null;

        public sound bj_victoryDialogSound = null;

        public sound bj_defeatDialogSound = null;

        public trigger bj_stockItemPurchased = null;

        public timer bj_stockUpdateTimer = null;

        public array<int, boolean> bj_stockAllowedPermanent = new array<int, boolean>();

        public array<int, boolean> bj_stockAllowedCharged = new array<int, boolean>();

        public array<int, boolean> bj_stockAllowedArtifact = new array<int, boolean>();

        public integer bj_stockPickedItemLevel = 0;

        public itemtype bj_stockPickedItemType;

        public trigger bj_meleeVisibilityTrained = null;

        public boolean bj_meleeVisibilityIsDay = true;

        public boolean bj_meleeGrantHeroItems = false;

        public location bj_meleeNearestMineToLoc = null;

        public unit bj_meleeNearestMine = null;

        public real bj_meleeNearestMineDist = 0f;

        public boolean bj_meleeGameOver = false;

        public array<int, boolean> bj_meleeDefeated = new array<int, boolean>();

        public array<int, boolean> bj_meleeVictoried = new array<int, boolean>();

        public array<int, unit> bj_ghoul = new array<int, unit>();

        public array<int, timer> bj_crippledTimer = new array<int, timer>();

        public array<int, timerdialog> bj_crippledTimerWindows = new array<int, timerdialog>();

        public array<int, boolean> bj_playerIsCrippled = new array<int, boolean>();

        public array<int, boolean> bj_playerIsExposed = new array<int, boolean>();

        public boolean bj_finishSoonAllExposed = false;

        public timerdialog bj_finishSoonTimerDialog = null;

        public array<int, integer> bj_meleeTwinkedHeroes = new array<int, integer>();

        public trigger bj_rescueUnitBehavior = null;

        public boolean bj_rescueChangeColorUnit = true;

        public boolean bj_rescueChangeColorBldg = true;

        public timer bj_cineSceneEndingTimer = null;

        public sound bj_cineSceneLastSound = null;

        public trigger bj_cineSceneBeingSkipped = null;

        public gamespeed bj_cineModePriorSpeed = MAP_SPEED_NORMAL;

        public boolean bj_cineModePriorFogSetting = false;

        public boolean bj_cineModePriorMaskSetting = false;

        public boolean bj_cineModeAlreadyIn = false;

        public boolean bj_cineModePriorDawnDusk = false;

        public integer bj_cineModeSavedSeed = 0;

        public timer bj_cineFadeFinishTimer = null;

        public timer bj_cineFadeContinueTimer = null;

        public real bj_cineFadeContinueRed = 0;

        public real bj_cineFadeContinueGreen = 0;

        public real bj_cineFadeContinueBlue = 0;

        public real bj_cineFadeContinueTrans = 0;

        public real bj_cineFadeContinueDuration = 0;

        public @string bj_cineFadeContinueTex = "";

        public integer bj_queuedExecTotal = 0;

        public array<int, trigger> bj_queuedExecTriggers = new array<int, trigger>();

        public array<int, boolean> bj_queuedExecUseConds = new array<int, boolean>();

        public timer bj_queuedExecTimeoutTimer = CreateTimer();

        public trigger bj_queuedExecTimeout = null;

        public integer bj_destInRegionDiesCount = 0;

        public trigger bj_destInRegionDiesTrig = null;

        public integer bj_groupCountUnits = 0;

        public integer bj_forceCountPlayers = 0;

        public integer bj_groupEnumTypeId = 0;

        public player bj_groupEnumOwningPlayer = null;

        public group bj_groupAddGroupDest = null;

        public group bj_groupRemoveGroupDest = null;

        public integer bj_groupRandomConsidered = 0;

        public unit bj_groupRandomCurrentPick = null;

        public group bj_groupLastCreatedDest = null;

        public group bj_randomSubGroupGroup = null;

        public integer bj_randomSubGroupWant = 0;

        public integer bj_randomSubGroupTotal = 0;

        public real bj_randomSubGroupChance = 0;

        public integer bj_destRandomConsidered = 0;

        public destructable bj_destRandomCurrentPick = null;

        public destructable bj_elevatorWallBlocker = null;

        public destructable bj_elevatorNeighbor = null;

        public integer bj_itemRandomConsidered = 0;

        public item bj_itemRandomCurrentPick = null;

        public integer bj_forceRandomConsidered = 0;

        public player bj_forceRandomCurrentPick = null;

        public unit bj_makeUnitRescuableUnit = null;

        public boolean bj_makeUnitRescuableFlag = true;

        public boolean bj_pauseAllUnitsFlag = true;

        public location bj_enumDestructableCenter = null;

        public real bj_enumDestructableRadius = 0;

        public playercolor bj_setPlayerTargetColor = null;

        public boolean bj_isUnitGroupDeadResult = true;

        public boolean bj_isUnitGroupEmptyResult = true;

        public boolean bj_isUnitGroupInRectResult = true;

        public rect bj_isUnitGroupInRectRect = null;

        public boolean bj_changeLevelShowScores = false;

        public @string bj_changeLevelMapName = null;

        public group bj_suspendDecayFleshGroup = CreateGroup();

        public group bj_suspendDecayBoneGroup = CreateGroup();

        public timer bj_delayedSuspendDecayTimer = CreateTimer();

        public trigger bj_delayedSuspendDecayTrig = null;

        public integer bj_livingPlayerUnitsTypeId = 0;

        public widget bj_lastDyingWidget = null;

        public integer bj_randDistCount = 0;

        public array<int, integer> bj_randDistID = new array<int, integer>();

        public array<int, integer> bj_randDistChance = new array<int, integer>();

        public unit bj_lastCreatedUnit = null;

        public item bj_lastCreatedItem = null;

        public item bj_lastRemovedItem = null;

        public unit bj_lastHauntedGoldMine = null;

        public destructable bj_lastCreatedDestructable = null;

        public group bj_lastCreatedGroup = CreateGroup();

        public fogmodifier bj_lastCreatedFogModifier = null;

        public effect bj_lastCreatedEffect = null;

        public weathereffect bj_lastCreatedWeatherEffect = null;

        public terraindeformation bj_lastCreatedTerrainDeformation = null;

        public quest bj_lastCreatedQuest = null;

        public questitem bj_lastCreatedQuestItem = null;

        public defeatcondition bj_lastCreatedDefeatCondition = null;

        public timer bj_lastStartedTimer = CreateTimer();

        public timerdialog bj_lastCreatedTimerDialog = null;

        public leaderboard bj_lastCreatedLeaderboard = null;

        public multiboard bj_lastCreatedMultiboard = null;

        public sound bj_lastPlayedSound = null;

        public @string bj_lastPlayedMusic = "";

        public real bj_lastTransmissionDuration = 0;

        public gamecache bj_lastCreatedGameCache = null;

        public hashtable bj_lastCreatedHashtable = null;

        public unit bj_lastLoadedUnit = null;

        public button bj_lastCreatedButton = null;

        public unit bj_lastReplacedUnit = null;

        public texttag bj_lastCreatedTextTag = null;

        public lightning bj_lastCreatedLightning = null;

        public image bj_lastCreatedImage = null;

        public ubersplat bj_lastCreatedUbersplat = null;

        public boolexpr filterIssueHauntOrderAtLocBJ = null;

        public boolexpr filterEnumDestructablesInCircleBJ = null;

        public boolexpr filterGetUnitsInRectOfPlayer = null;

        public boolexpr filterGetUnitsOfTypeIdAll = null;

        public boolexpr filterGetUnitsOfPlayerAndTypeId = null;

        public boolexpr filterMeleeTrainedUnitIsHeroBJ = null;

        public boolexpr filterLivingPlayerUnitsOfTypeId = null;

        public boolean bj_wantDestroyGroup = false;

        public virtual void BJDebugMsg(@string msg)
        {
            integer i = 0;
            for (
            ; true;
            )
            {
                DisplayTimedTextToPlayer(Player(i), 0, 0, 60, msg);
                i = i + 1;
                if (i == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
        }

        public virtual real RMinBJ(real a, real b)
        {
            if ((a < b))
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public virtual real RMaxBJ(real a, real b)
        {
            if ((a < b))
            {
                return b;
            }
            else
            {
                return a;
            }
        }

        public virtual real RAbsBJ(real a)
        {
            if ((a >= 0))
            {
                return a;
            }
            else
            {
                return -a;
            }
        }

        public virtual real RSignBJ(real a)
        {
            if ((a >= 0f))
            {
                return 1f;
            }
            else
            {
                return -1f;
            }
        }

        public virtual integer IMinBJ(integer a, integer b)
        {
            if ((a < b))
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public virtual integer IMaxBJ(integer a, integer b)
        {
            if ((a < b))
            {
                return b;
            }
            else
            {
                return a;
            }
        }

        public virtual integer IAbsBJ(integer a)
        {
            if ((a >= 0))
            {
                return a;
            }
            else
            {
                return -a;
            }
        }

        public virtual integer ISignBJ(integer a)
        {
            if ((a >= 0))
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public virtual real SinBJ(real degrees)
        {
            return Sin(degrees * bj_DEGTORAD);
        }

        public virtual real CosBJ(real degrees)
        {
            return Cos(degrees * bj_DEGTORAD);
        }

        public virtual real TanBJ(real degrees)
        {
            return Tan(degrees * bj_DEGTORAD);
        }

        public virtual real AsinBJ(real degrees)
        {
            return Asin(degrees) * bj_RADTODEG;
        }

        public virtual real AcosBJ(real degrees)
        {
            return Acos(degrees) * bj_RADTODEG;
        }

        public virtual real AtanBJ(real degrees)
        {
            return Atan(degrees) * bj_RADTODEG;
        }

        public virtual real Atan2BJ(real y, real x)
        {
            return Atan2(y, x) * bj_RADTODEG;
        }

        public virtual real AngleBetweenPoints(location locA, location locB)
        {
            return bj_RADTODEG * Atan2(GetLocationY(locB) - GetLocationY(locA), GetLocationX(locB) - GetLocationX(locA));
        }

        public virtual real DistanceBetweenPoints(location locA, location locB)
        {
            real dx = GetLocationX(locB) - GetLocationX(locA);
            real dy = GetLocationY(locB) - GetLocationY(locA);
            return SquareRoot(dx * dx + dy * dy);
        }

        public virtual location PolarProjectionBJ(location source, real dist, real angle)
        {
            real x = GetLocationX(source) + dist * Cos(angle * bj_DEGTORAD);
            real y = GetLocationY(source) + dist * Sin(angle * bj_DEGTORAD);
            return Location(x, y);
        }

        public virtual real GetRandomDirectionDeg()
        {
            return GetRandomReal(0, 360);
        }

        public virtual real GetRandomPercentageBJ()
        {
            return GetRandomReal(0, 100);
        }

        public virtual location GetRandomLocInRect(rect whichRect)
        {
            return Location(GetRandomReal(GetRectMinX(whichRect), GetRectMaxX(whichRect)), GetRandomReal(GetRectMinY(whichRect), GetRectMaxY(whichRect)));
        }

        public virtual integer ModuloInteger(integer dividend, integer divisor)
        {
            integer modulus = dividend - (dividend / divisor) * divisor;
            if ((modulus < 0))
            {
                modulus = modulus + divisor;
            }
            return modulus;
        }

        public virtual real ModuloReal(real dividend, real divisor)
        {
            real modulus = dividend - I2R(R2I(dividend / divisor)) * divisor;
            if ((modulus < 0))
            {
                modulus = modulus + divisor;
            }
            return modulus;
        }

        public virtual location OffsetLocation(location loc, real dx, real dy)
        {
            return Location(GetLocationX(loc) + dx, GetLocationY(loc) + dy);
        }

        public virtual rect OffsetRectBJ(rect r, real dx, real dy)
        {
            return Rect(GetRectMinX(r) + dx, GetRectMinY(r) + dy, GetRectMaxX(r) + dx, GetRectMaxY(r) + dy);
        }

        public virtual rect RectFromCenterSizeBJ(location center, real width, real height)
        {
            real x = GetLocationX(center);
            real y = GetLocationY(center);
            return Rect(x - width * 0.5f, y - height * 0.5f, x + width * 0.5f, y + height * 0.5f);
        }

        public virtual boolean RectContainsCoords(rect r, real x, real y)
        {
            return (GetRectMinX(r) <= x) && (x <= GetRectMaxX(r)) && (GetRectMinY(r) <= y) && (y <= GetRectMaxY(r));
        }

        public virtual boolean RectContainsLoc(rect r, location loc)
        {
            return RectContainsCoords(r, GetLocationX(loc), GetLocationY(loc));
        }

        public virtual boolean RectContainsUnit(rect r, unit whichUnit)
        {
            return RectContainsCoords(r, GetUnitX(whichUnit), GetUnitY(whichUnit));
        }

        public virtual boolean RectContainsItem(item whichItem, rect r)
        {
            if ((whichItem == null))
            {
                return false;
            }
            if ((IsItemOwned(whichItem)))
            {
                return false;
            }
            return RectContainsCoords(r, GetItemX(whichItem), GetItemY(whichItem));
        }

        public virtual void ConditionalTriggerExecute(trigger trig)
        {
            if (TriggerEvaluate(trig))
            {
                TriggerExecute(trig);
            }
        }

        public virtual boolean TriggerExecuteBJ(trigger trig, boolean checkConditions)
        {
            if (checkConditions)
            {
                if (!(TriggerEvaluate(trig)))
                {
                    return false;
                }
            }
            TriggerExecute(trig);
            return true;
        }

        public virtual boolean PostTriggerExecuteBJ(trigger trig, boolean checkConditions)
        {
            if (checkConditions)
            {
                if (!(TriggerEvaluate(trig)))
                {
                    return false;
                }
            }
            TriggerRegisterTimerEvent(trig, 0, false);
            return true;
        }

        public virtual void QueuedTriggerCheck()
        {
            @string s = "TrigQueue Check ";
            integer i = 0;
            i = 0;
            for (
            ; true;
            )
            {
                if (i >= bj_queuedExecTotal)
                {
                    break;
                }
                s = s + "q[" + I2S(i) + "]=";
                if ((bj_queuedExecTriggers[i] == null))
                {
                    s = s + "null ";
                }
                else
                {
                    s = s + "x ";
                }
                i = i + 1;
            }
            s = s + "(" + I2S(bj_queuedExecTotal) + " total)";
            DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, 600, s);
        }

        public virtual integer QueuedTriggerGetIndex(trigger trig)
        {
            integer index = 0;
            for (
            ; true;
            )
            {
                if (index >= bj_queuedExecTotal)
                {
                    break;
                }
                if ((bj_queuedExecTriggers[index] == trig))
                {
                    return index;
                }
                index = index + 1;
            }
            return -1;
        }

        public virtual boolean QueuedTriggerRemoveByIndex(integer trigIndex)
        {
            integer index = 0;
            if ((trigIndex >= bj_queuedExecTotal))
            {
                return false;
            }
            bj_queuedExecTotal = bj_queuedExecTotal - 1;
            index = trigIndex;
            for (
            ; true;
            )
            {
                if (index >= bj_queuedExecTotal)
                {
                    break;
                }
                bj_queuedExecTriggers[index] = bj_queuedExecTriggers[index + 1];
                bj_queuedExecUseConds[index] = bj_queuedExecUseConds[index + 1];
                index = index + 1;
            }
            return true;
        }

        public virtual boolean QueuedTriggerAttemptExec()
        {
            for (
            ; true;
            )
            {
                if (bj_queuedExecTotal == 0)
                {
                    break;
                }
                if (TriggerExecuteBJ(bj_queuedExecTriggers[0], bj_queuedExecUseConds[0]))
                {
                    TimerStart(bj_queuedExecTimeoutTimer, bj_QUEUED_TRIGGER_TIMEOUT, false, null);
                    return true;
                }
                QueuedTriggerRemoveByIndex(0);
            }
            return false;
        }

        public virtual boolean QueuedTriggerAddBJ(trigger trig, boolean checkConditions)
        {
            if ((bj_queuedExecTotal >= bj_MAX_QUEUED_TRIGGERS))
            {
                return false;
            }
            bj_queuedExecTriggers[bj_queuedExecTotal] = trig;
            bj_queuedExecUseConds[bj_queuedExecTotal] = checkConditions;
            bj_queuedExecTotal = bj_queuedExecTotal + 1;
            if ((bj_queuedExecTotal == 1))
            {
                QueuedTriggerAttemptExec();
            }
            return true;
        }

        public virtual void QueuedTriggerRemoveBJ(trigger trig)
        {
            integer index = 0;
            integer trigIndex = 0;
            boolean trigExecuted = false;
            trigIndex = QueuedTriggerGetIndex(trig);
            if ((trigIndex == -1))
            {
                return;
            }
            QueuedTriggerRemoveByIndex(trigIndex);
            if ((trigIndex == 0))
            {
                PauseTimer(bj_queuedExecTimeoutTimer);
                QueuedTriggerAttemptExec();
            }
        }

        public virtual void QueuedTriggerDoneBJ()
        {
            integer index = 0;
            if ((bj_queuedExecTotal <= 0))
            {
                return;
            }
            QueuedTriggerRemoveByIndex(0);
            PauseTimer(bj_queuedExecTimeoutTimer);
            QueuedTriggerAttemptExec();
        }

        public virtual void QueuedTriggerClearBJ()
        {
            PauseTimer(bj_queuedExecTimeoutTimer);
            bj_queuedExecTotal = 0;
        }

        public virtual void QueuedTriggerClearInactiveBJ()
        {
            bj_queuedExecTotal = IMinBJ(bj_queuedExecTotal, 1);
        }

        public virtual integer QueuedTriggerCountBJ()
        {
            return bj_queuedExecTotal;
        }

        public virtual boolean IsTriggerQueueEmptyBJ()
        {
            return bj_queuedExecTotal <= 0;
        }

        public virtual boolean IsTriggerQueuedBJ(trigger trig)
        {
            return QueuedTriggerGetIndex(trig) != -1;
        }

        public virtual integer GetForLoopIndexA()
        {
            return bj_forLoopAIndex;
        }

        public virtual void SetForLoopIndexA(integer newIndex)
        {
            bj_forLoopAIndex = newIndex;
        }

        public virtual integer GetForLoopIndexB()
        {
            return bj_forLoopBIndex;
        }

        public virtual void SetForLoopIndexB(integer newIndex)
        {
            bj_forLoopBIndex = newIndex;
        }

        public virtual void PolledWait(real duration)
        {
            timer t;
            real timeRemaining = 0;
            if ((duration > 0))
            {
                t = CreateTimer();
                TimerStart(t, duration, false, null);
                for (
                ; true;
                )
                {
                    timeRemaining = TimerGetRemaining(t);
                    if (timeRemaining <= 0)
                    {
                        break;
                    }
                    if ((timeRemaining > bj_POLLED_WAIT_SKIP_THRESHOLD))
                    {
                        TriggerSleepAction(0.1f * timeRemaining);
                    }
                    else
                    {
                        TriggerSleepAction(bj_POLLED_WAIT_INTERVAL);
                    }
                }
                DestroyTimer(t);
            }
        }

        public virtual integer IntegerTertiaryOp(boolean flag, integer valueA, integer valueB)
        {
            if (flag)
            {
                return valueA;
            }
            else
            {
                return valueB;
            }
        }

        public virtual void DoNothing()
        {
        }

        public virtual void CommentString(@string commentString)
        {
        }

        public virtual @string StringIdentity(@string theString)
        {
            return GetLocalizedString(theString);
        }

        public virtual boolean GetBooleanAnd(boolean valueA, boolean valueB)
        {
            return valueA && valueB;
        }

        public virtual boolean GetBooleanOr(boolean valueA, boolean valueB)
        {
            return valueA || valueB;
        }

        public virtual integer PercentToInt(real percentage, integer max)
        {
            integer result = R2I(percentage * I2R(max) * 0.01f);
            if ((result < 0))
            {
                result = 0;
            }
            else
            {
                if ((result > max))
                {
                    result = max;
                }
            }
            return result;
        }

        public virtual integer PercentTo255(real percentage)
        {
            return PercentToInt(percentage, 255);
        }

        public virtual real GetTimeOfDay()
        {
            return GetFloatGameState(GAME_STATE_TIME_OF_DAY);
        }

        public virtual void SetTimeOfDay(real whatTime)
        {
            SetFloatGameState(GAME_STATE_TIME_OF_DAY, whatTime);
        }

        public virtual void SetTimeOfDayScalePercentBJ(real scalePercent)
        {
            SetTimeOfDayScale(scalePercent * 0.01f);
        }

        public virtual real GetTimeOfDayScalePercentBJ()
        {
            return GetTimeOfDayScale() * 100;
        }

        public virtual void PlaySound(@string soundName)
        {
            sound soundHandle = CreateSound(soundName, false, false, true, 12700, 12700, "");
            StartSound(soundHandle);
            KillSoundWhenDone(soundHandle);
        }

        public virtual boolean CompareLocationsBJ(location A, location B)
        {
            return GetLocationX(A) == GetLocationX(B) && GetLocationY(A) == GetLocationY(B);
        }

        public virtual boolean CompareRectsBJ(rect A, rect B)
        {
            return GetRectMinX(A) == GetRectMinX(B) && GetRectMinY(A) == GetRectMinY(B) && GetRectMaxX(A) == GetRectMaxX(B) && GetRectMaxY(A) == GetRectMaxY(B);
        }

        public virtual rect GetRectFromCircleBJ(location center, real radius)
        {
            real centerX = GetLocationX(center);
            real centerY = GetLocationY(center);
            return Rect(centerX - radius, centerY - radius, centerX + radius, centerY + radius);
        }

        public virtual camerasetup GetCurrentCameraSetup()
        {
            camerasetup theCam = CreateCameraSetup();
            real duration = 0;
            CameraSetupSetField(theCam, CAMERA_FIELD_TARGET_DISTANCE, GetCameraField(CAMERA_FIELD_TARGET_DISTANCE), duration);
            CameraSetupSetField(theCam, CAMERA_FIELD_FARZ, GetCameraField(CAMERA_FIELD_FARZ), duration);
            CameraSetupSetField(theCam, CAMERA_FIELD_ZOFFSET, GetCameraField(CAMERA_FIELD_ZOFFSET), duration);
            CameraSetupSetField(theCam, CAMERA_FIELD_ANGLE_OF_ATTACK, bj_RADTODEG * GetCameraField(CAMERA_FIELD_ANGLE_OF_ATTACK), duration);
            CameraSetupSetField(theCam, CAMERA_FIELD_FIELD_OF_VIEW, bj_RADTODEG * GetCameraField(CAMERA_FIELD_FIELD_OF_VIEW), duration);
            CameraSetupSetField(theCam, CAMERA_FIELD_ROLL, bj_RADTODEG * GetCameraField(CAMERA_FIELD_ROLL), duration);
            CameraSetupSetField(theCam, CAMERA_FIELD_ROTATION, bj_RADTODEG * GetCameraField(CAMERA_FIELD_ROTATION), duration);
            CameraSetupSetDestPosition(theCam, GetCameraTargetPositionX(), GetCameraTargetPositionY(), duration);
            return theCam;
        }

        public virtual void CameraSetupApplyForPlayer(boolean doPan, camerasetup whichSetup, player whichPlayer, real duration)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                CameraSetupApplyForceDuration(whichSetup, doPan, duration);
            }
        }

        public virtual real CameraSetupGetFieldSwap(camerafield whichField, camerasetup whichSetup)
        {
            return CameraSetupGetField(whichSetup, whichField);
        }

        public virtual void SetCameraFieldForPlayer(player whichPlayer, camerafield whichField, real value, real duration)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                SetCameraField(whichField, value, duration);
            }
        }

        public virtual void SetCameraTargetControllerNoZForPlayer(player whichPlayer, unit whichUnit, real xoffset, real yoffset, boolean inheritOrientation)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                SetCameraTargetController(whichUnit, xoffset, yoffset, inheritOrientation);
            }
        }

        public virtual void SetCameraPositionForPlayer(player whichPlayer, real x, real y)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                SetCameraPosition(x, y);
            }
        }

        public virtual void SetCameraPositionLocForPlayer(player whichPlayer, location loc)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                SetCameraPosition(GetLocationX(loc), GetLocationY(loc));
            }
        }

        public virtual void RotateCameraAroundLocBJ(real degrees, location loc, player whichPlayer, real duration)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                SetCameraRotateMode(GetLocationX(loc), GetLocationY(loc), bj_DEGTORAD * degrees, duration);
            }
        }

        public virtual void PanCameraToForPlayer(player whichPlayer, real x, real y)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                PanCameraTo(x, y);
            }
        }

        public virtual void PanCameraToLocForPlayer(player whichPlayer, location loc)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                PanCameraTo(GetLocationX(loc), GetLocationY(loc));
            }
        }

        public virtual void PanCameraToTimedForPlayer(player whichPlayer, real x, real y, real duration)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                PanCameraToTimed(x, y, duration);
            }
        }

        public virtual void PanCameraToTimedLocForPlayer(player whichPlayer, location loc, real duration)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                PanCameraToTimed(GetLocationX(loc), GetLocationY(loc), duration);
            }
        }

        public virtual void PanCameraToTimedLocWithZForPlayer(player whichPlayer, location loc, real zOffset, real duration)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                PanCameraToTimedWithZ(GetLocationX(loc), GetLocationY(loc), zOffset, duration);
            }
        }

        public virtual void SmartCameraPanBJ(player whichPlayer, location loc, real duration)
        {
            real dist = 0;
            if ((GetLocalPlayer() == whichPlayer))
            {
                dist = DistanceBetweenPoints(loc, GetCameraTargetPositionLoc());
                if ((dist >= bj_SMARTPAN_TRESHOLD_SNAP))
                {
                    PanCameraToTimed(GetLocationX(loc), GetLocationY(loc), 0);
                }
                else
                {
                    if ((dist >= bj_SMARTPAN_TRESHOLD_PAN))
                    {
                        PanCameraToTimed(GetLocationX(loc), GetLocationY(loc), duration);
                    }
                }
            }
        }

        public virtual void SetCinematicCameraForPlayer(player whichPlayer, @string cameraModelFile)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                SetCinematicCamera(cameraModelFile);
            }
        }

        public virtual void ResetToGameCameraForPlayer(player whichPlayer, real duration)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                ResetToGameCamera(duration);
            }
        }

        public virtual void CameraSetSourceNoiseForPlayer(player whichPlayer, real magnitude, real velocity)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                CameraSetSourceNoise(magnitude, velocity);
            }
        }

        public virtual void CameraSetTargetNoiseForPlayer(player whichPlayer, real magnitude, real velocity)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                CameraSetTargetNoise(magnitude, velocity);
            }
        }

        public virtual void CameraSetEQNoiseForPlayer(player whichPlayer, real magnitude)
        {
            real richter = magnitude;
            if ((richter > 5f))
            {
                richter = 5f;
            }
            if ((richter < 2f))
            {
                richter = 2f;
            }
            if ((GetLocalPlayer() == whichPlayer))
            {
                CameraSetTargetNoiseEx(magnitude * 2f, magnitude * Pow(10, richter), true);
                CameraSetSourceNoiseEx(magnitude * 2f, magnitude * Pow(10, richter), true);
            }
        }

        public virtual void CameraClearNoiseForPlayer(player whichPlayer)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                CameraSetSourceNoise(0, 0);
                CameraSetTargetNoise(0, 0);
            }
        }

        public virtual rect GetCurrentCameraBoundsMapRectBJ()
        {
            return Rect(GetCameraBoundMinX(), GetCameraBoundMinY(), GetCameraBoundMaxX(), GetCameraBoundMaxY());
        }

        public virtual rect GetCameraBoundsMapRect()
        {
            return bj_mapInitialCameraBounds;
        }

        public virtual rect GetPlayableMapRect()
        {
            return bj_mapInitialPlayableArea;
        }

        public virtual rect GetEntireMapRect()
        {
            return GetWorldBounds();
        }

        public virtual void SetCameraBoundsToRect(rect r)
        {
            real minX = GetRectMinX(r);
            real minY = GetRectMinY(r);
            real maxX = GetRectMaxX(r);
            real maxY = GetRectMaxY(r);
            SetCameraBounds(minX, minY, minX, maxY, maxX, maxY, maxX, minY);
        }

        public virtual void SetCameraBoundsToRectForPlayerBJ(player whichPlayer, rect r)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                SetCameraBoundsToRect(r);
            }
        }

        public virtual void AdjustCameraBoundsBJ(integer adjustMethod, real dxWest, real dxEast, real dyNorth, real dySouth)
        {
            real minX = 0;
            real minY = 0;
            real maxX = 0;
            real maxY = 0;
            real scale = 0;
            if ((adjustMethod == bj_CAMERABOUNDS_ADJUST_ADD))
            {
                scale = 1;
            }
            else
            {
                if ((adjustMethod == bj_CAMERABOUNDS_ADJUST_SUB))
                {
                    scale = -1;
                }
                else
                {
                    return;
                }
            }
            minX = GetCameraBoundMinX() - scale * dxWest;
            maxX = GetCameraBoundMaxX() + scale * dxEast;
            minY = GetCameraBoundMinY() - scale * dySouth;
            maxY = GetCameraBoundMaxY() + scale * dyNorth;
            if ((maxX < minX))
            {
                minX = (minX + maxX) * 0.5f;
                maxX = minX;
            }
            if ((maxY < minY))
            {
                minY = (minY + maxY) * 0.5f;
                maxY = minY;
            }
            SetCameraBounds(minX, minY, minX, maxY, maxX, maxY, maxX, minY);
        }

        public virtual void AdjustCameraBoundsForPlayerBJ(integer adjustMethod, player whichPlayer, real dxWest, real dxEast, real dyNorth, real dySouth)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                AdjustCameraBoundsBJ(adjustMethod, dxWest, dxEast, dyNorth, dySouth);
            }
        }

        public virtual void SetCameraQuickPositionForPlayer(player whichPlayer, real x, real y)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                SetCameraQuickPosition(x, y);
            }
        }

        public virtual void SetCameraQuickPositionLocForPlayer(player whichPlayer, location loc)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                SetCameraQuickPosition(GetLocationX(loc), GetLocationY(loc));
            }
        }

        public virtual void SetCameraQuickPositionLoc(location loc)
        {
            SetCameraQuickPosition(GetLocationX(loc), GetLocationY(loc));
        }

        public virtual void StopCameraForPlayerBJ(player whichPlayer)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                StopCamera();
            }
        }

        public virtual void SetCameraOrientControllerForPlayerBJ(player whichPlayer, unit whichUnit, real xoffset, real yoffset)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                SetCameraOrientController(whichUnit, xoffset, yoffset);
            }
        }

        public virtual void CameraSetSmoothingFactorBJ(real factor)
        {
            CameraSetSmoothingFactor(factor);
        }

        public virtual void CameraResetSmoothingFactorBJ()
        {
            CameraSetSmoothingFactor(0);
        }

        public virtual void DisplayTextToForce(force toForce, @string message)
        {
            if ((IsPlayerInForce(GetLocalPlayer(), toForce)))
            {
                DisplayTextToPlayer(GetLocalPlayer(), 0, 0, message);
            }
        }

        public virtual void DisplayTimedTextToForce(force toForce, real duration, @string message)
        {
            if ((IsPlayerInForce(GetLocalPlayer(), toForce)))
            {
                DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, duration, message);
            }
        }

        public virtual void ClearTextMessagesBJ(force toForce)
        {
            if ((IsPlayerInForce(GetLocalPlayer(), toForce)))
            {
                ClearTextMessages();
            }
        }

        public virtual @string SubStringBJ(@string source, integer start, integer end)
        {
            return SubString(source, start - 1, end);
        }

        public virtual integer GetHandleIdBJ(handle h)
        {
            return GetHandleId(h);
        }

        public virtual integer StringHashBJ(@string s)
        {
            return StringHash(s);
        }

        public virtual @event TriggerRegisterTimerEventPeriodic(trigger trig, real timeout)
        {
            return TriggerRegisterTimerEvent(trig, timeout, true);
        }

        public virtual @event TriggerRegisterTimerEventSingle(trigger trig, real timeout)
        {
            return TriggerRegisterTimerEvent(trig, timeout, false);
        }

        public virtual @event TriggerRegisterTimerExpireEventBJ(trigger trig, timer t)
        {
            return TriggerRegisterTimerExpireEvent(trig, t);
        }

        public virtual @event TriggerRegisterPlayerUnitEventSimple(trigger trig, player whichPlayer, playerunitevent whichEvent)
        {
            return TriggerRegisterPlayerUnitEvent(trig, whichPlayer, whichEvent, null);
        }

        public virtual void TriggerRegisterAnyUnitEventBJ(trigger trig, playerunitevent whichEvent)
        {
            integer index = 0;
            index = 0;
            for (
            ; true;
            )
            {
                TriggerRegisterPlayerUnitEvent(trig, Player(index), whichEvent, null);
                index = index + 1;
                if (index == bj_MAX_PLAYER_SLOTS)
                {
                    break;
                }
            }
        }

        public virtual @event TriggerRegisterPlayerSelectionEventBJ(trigger trig, player whichPlayer, boolean selected)
        {
            if (selected)
            {
                return TriggerRegisterPlayerUnitEvent(trig, whichPlayer, EVENT_PLAYER_UNIT_SELECTED, null);
            }
            else
            {
                return TriggerRegisterPlayerUnitEvent(trig, whichPlayer, EVENT_PLAYER_UNIT_DESELECTED, null);
            }
        }

        public virtual @event TriggerRegisterPlayerKeyEventBJ(trigger trig, player whichPlayer, integer keType, integer keKey)
        {
            if ((keType == bj_KEYEVENTTYPE_DEPRESS))
            {
                if ((keKey == bj_KEYEVENTKEY_LEFT))
                {
                    return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_LEFT_DOWN);
                }
                else
                {
                    if ((keKey == bj_KEYEVENTKEY_RIGHT))
                    {
                        return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_RIGHT_DOWN);
                    }
                    else
                    {
                        if ((keKey == bj_KEYEVENTKEY_DOWN))
                        {
                            return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_DOWN_DOWN);
                        }
                        else
                        {
                            if ((keKey == bj_KEYEVENTKEY_UP))
                            {
                                return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_UP_DOWN);
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
            }
            else
            {
                if ((keType == bj_KEYEVENTTYPE_RELEASE))
                {
                    if ((keKey == bj_KEYEVENTKEY_LEFT))
                    {
                        return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_LEFT_UP);
                    }
                    else
                    {
                        if ((keKey == bj_KEYEVENTKEY_RIGHT))
                        {
                            return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_RIGHT_UP);
                        }
                        else
                        {
                            if ((keKey == bj_KEYEVENTKEY_DOWN))
                            {
                                return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_DOWN_UP);
                            }
                            else
                            {
                                if ((keKey == bj_KEYEVENTKEY_UP))
                                {
                                    return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_UP_UP);
                                }
                                else
                                {
                                    return null;
                                }
                            }
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public virtual @event TriggerRegisterPlayerEventVictory(trigger trig, player whichPlayer)
        {
            return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_VICTORY);
        }

        public virtual @event TriggerRegisterPlayerEventDefeat(trigger trig, player whichPlayer)
        {
            return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_DEFEAT);
        }

        public virtual @event TriggerRegisterPlayerEventLeave(trigger trig, player whichPlayer)
        {
            return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_LEAVE);
        }

        public virtual @event TriggerRegisterPlayerEventAllianceChanged(trigger trig, player whichPlayer)
        {
            return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ALLIANCE_CHANGED);
        }

        public virtual @event TriggerRegisterPlayerEventEndCinematic(trigger trig, player whichPlayer)
        {
            return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_END_CINEMATIC);
        }

        public virtual @event TriggerRegisterGameStateEventTimeOfDay(trigger trig, limitop opcode, real limitval)
        {
            return TriggerRegisterGameStateEvent(trig, GAME_STATE_TIME_OF_DAY, opcode, limitval);
        }

        public virtual @event TriggerRegisterEnterRegionSimple(trigger trig, region whichRegion)
        {
            return TriggerRegisterEnterRegion(trig, whichRegion, null);
        }

        public virtual @event TriggerRegisterLeaveRegionSimple(trigger trig, region whichRegion)
        {
            return TriggerRegisterLeaveRegion(trig, whichRegion, null);
        }

        public virtual @event TriggerRegisterEnterRectSimple(trigger trig, rect r)
        {
            region rectRegion = CreateRegion();
            RegionAddRect(rectRegion, r);
            return TriggerRegisterEnterRegion(trig, rectRegion, null);
        }

        public virtual @event TriggerRegisterLeaveRectSimple(trigger trig, rect r)
        {
            region rectRegion = CreateRegion();
            RegionAddRect(rectRegion, r);
            return TriggerRegisterLeaveRegion(trig, rectRegion, null);
        }

        public virtual @event TriggerRegisterDistanceBetweenUnits(trigger trig, unit whichUnit, boolexpr condition, real range)
        {
            return TriggerRegisterUnitInRange(trig, whichUnit, range, condition);
        }

        public virtual @event TriggerRegisterUnitInRangeSimple(trigger trig, real range, unit whichUnit)
        {
            return TriggerRegisterUnitInRange(trig, whichUnit, range, null);
        }

        public virtual @event TriggerRegisterUnitLifeEvent(trigger trig, unit whichUnit, limitop opcode, real limitval)
        {
            return TriggerRegisterUnitStateEvent(trig, whichUnit, UNIT_STATE_LIFE, opcode, limitval);
        }

        public virtual @event TriggerRegisterUnitManaEvent(trigger trig, unit whichUnit, limitop opcode, real limitval)
        {
            return TriggerRegisterUnitStateEvent(trig, whichUnit, UNIT_STATE_MANA, opcode, limitval);
        }

        public virtual @event TriggerRegisterDialogEventBJ(trigger trig, dialog whichDialog)
        {
            return TriggerRegisterDialogEvent(trig, whichDialog);
        }

        public virtual @event TriggerRegisterShowSkillEventBJ(trigger trig)
        {
            return TriggerRegisterGameEvent(trig, EVENT_GAME_SHOW_SKILL);
        }

        public virtual @event TriggerRegisterBuildSubmenuEventBJ(trigger trig)
        {
            return TriggerRegisterGameEvent(trig, EVENT_GAME_BUILD_SUBMENU);
        }

        public virtual @event TriggerRegisterGameLoadedEventBJ(trigger trig)
        {
            return TriggerRegisterGameEvent(trig, EVENT_GAME_LOADED);
        }

        public virtual @event TriggerRegisterGameSavedEventBJ(trigger trig)
        {
            return TriggerRegisterGameEvent(trig, EVENT_GAME_SAVE);
        }

        public virtual void RegisterDestDeathInRegionEnum()
        {
            bj_destInRegionDiesCount = bj_destInRegionDiesCount + 1;
            if ((bj_destInRegionDiesCount <= bj_MAX_DEST_IN_REGION_EVENTS))
            {
                TriggerRegisterDeathEvent(bj_destInRegionDiesTrig, GetEnumDestructable());
            }
        }

        public virtual void TriggerRegisterDestDeathInRegionEvent(trigger trig, rect r)
        {
            bj_destInRegionDiesTrig = trig;
            bj_destInRegionDiesCount = 0;
            EnumDestructablesInRect(r, null, RegisterDestDeathInRegionEnum);
        }

        public virtual weathereffect AddWeatherEffectSaveLast(rect where, integer effectID)
        {
            bj_lastCreatedWeatherEffect = AddWeatherEffect(where, effectID);
            return bj_lastCreatedWeatherEffect;
        }

        public virtual weathereffect GetLastCreatedWeatherEffect()
        {
            return bj_lastCreatedWeatherEffect;
        }

        public virtual void RemoveWeatherEffectBJ(weathereffect whichWeatherEffect)
        {
            RemoveWeatherEffect(whichWeatherEffect);
        }

        public virtual terraindeformation TerrainDeformationCraterBJ(real duration, boolean permanent, location where, real radius, real depth)
        {
            bj_lastCreatedTerrainDeformation = TerrainDeformCrater(GetLocationX(where), GetLocationY(where), radius, depth, R2I(duration * 1000), permanent);
            return bj_lastCreatedTerrainDeformation;
        }

        public virtual terraindeformation TerrainDeformationRippleBJ(real duration, boolean limitNeg, location where, real startRadius, real endRadius, real depth, real wavePeriod, real waveWidth)
        {
            real spaceWave = 0;
            real timeWave = 0;
            real radiusRatio = 0;
            if ((endRadius <= 0 || waveWidth <= 0 || wavePeriod <= 0))
            {
                return null;
            }
            timeWave = 2f * duration / wavePeriod;
            spaceWave = 2f * endRadius / waveWidth;
            radiusRatio = startRadius / endRadius;
            bj_lastCreatedTerrainDeformation = TerrainDeformRipple(GetLocationX(where), GetLocationY(where), endRadius, depth, R2I(duration * 1000), 1, spaceWave, timeWave, radiusRatio, limitNeg);
            return bj_lastCreatedTerrainDeformation;
        }

        public virtual terraindeformation TerrainDeformationWaveBJ(real duration, location source, location target, real radius, real depth, real trailDelay)
        {
            real distance = 0;
            real dirX = 0;
            real dirY = 0;
            real speed = 0;
            distance = DistanceBetweenPoints(source, target);
            if ((distance == 0 || duration <= 0))
            {
                return null;
            }
            dirX = (GetLocationX(target) - GetLocationX(source)) / distance;
            dirY = (GetLocationY(target) - GetLocationY(source)) / distance;
            speed = distance / duration;
            bj_lastCreatedTerrainDeformation = TerrainDeformWave(GetLocationX(source), GetLocationY(source), dirX, dirY, distance, speed, radius, depth, R2I(trailDelay * 1000), 1);
            return bj_lastCreatedTerrainDeformation;
        }

        public virtual terraindeformation TerrainDeformationRandomBJ(real duration, location where, real radius, real minDelta, real maxDelta, real updateInterval)
        {
            bj_lastCreatedTerrainDeformation = TerrainDeformRandom(GetLocationX(where), GetLocationY(where), radius, minDelta, maxDelta, R2I(duration * 1000), R2I(updateInterval * 1000));
            return bj_lastCreatedTerrainDeformation;
        }

        public virtual void TerrainDeformationStopBJ(terraindeformation deformation, real duration)
        {
            TerrainDeformStop(deformation, R2I(duration * 1000));
        }

        public virtual terraindeformation GetLastCreatedTerrainDeformation()
        {
            return bj_lastCreatedTerrainDeformation;
        }

        public virtual lightning AddLightningLoc(@string codeName, location where1, location where2)
        {
            bj_lastCreatedLightning = AddLightningEx(codeName, true, GetLocationX(where1), GetLocationY(where1), GetLocationZ(where1), GetLocationX(where2), GetLocationY(where2), GetLocationZ(where2));
            return bj_lastCreatedLightning;
        }

        public virtual boolean DestroyLightningBJ(lightning whichBolt)
        {
            return DestroyLightning(whichBolt);
        }

        public virtual boolean MoveLightningLoc(lightning whichBolt, location where1, location where2)
        {
            return MoveLightningEx(whichBolt, true, GetLocationX(where1), GetLocationY(where1), GetLocationZ(where1), GetLocationX(where2), GetLocationY(where2), GetLocationZ(where2));
        }

        public virtual real GetLightningColorABJ(lightning whichBolt)
        {
            return GetLightningColorA(whichBolt);
        }

        public virtual real GetLightningColorRBJ(lightning whichBolt)
        {
            return GetLightningColorR(whichBolt);
        }

        public virtual real GetLightningColorGBJ(lightning whichBolt)
        {
            return GetLightningColorG(whichBolt);
        }

        public virtual real GetLightningColorBBJ(lightning whichBolt)
        {
            return GetLightningColorB(whichBolt);
        }

        public virtual boolean SetLightningColorBJ(lightning whichBolt, real r, real g, real b, real a)
        {
            return SetLightningColor(whichBolt, r, g, b, a);
        }

        public virtual lightning GetLastCreatedLightningBJ()
        {
            return bj_lastCreatedLightning;
        }

        public virtual @string GetAbilityEffectBJ(integer abilcode, effecttype t, integer index)
        {
            return GetAbilityEffectById(abilcode, t, index);
        }

        public virtual @string GetAbilitySoundBJ(integer abilcode, soundtype t)
        {
            return GetAbilitySoundById(abilcode, t);
        }

        public virtual integer GetTerrainCliffLevelBJ(location where)
        {
            return GetTerrainCliffLevel(GetLocationX(where), GetLocationY(where));
        }

        public virtual integer GetTerrainTypeBJ(location where)
        {
            return GetTerrainType(GetLocationX(where), GetLocationY(where));
        }

        public virtual integer GetTerrainVarianceBJ(location where)
        {
            return GetTerrainVariance(GetLocationX(where), GetLocationY(where));
        }

        public virtual void SetTerrainTypeBJ(location where, integer terrainType, integer variation, integer area, integer shape)
        {
            SetTerrainType(GetLocationX(where), GetLocationY(where), terrainType, variation, area, shape);
        }

        public virtual boolean IsTerrainPathableBJ(location where, pathingtype t)
        {
            return IsTerrainPathable(GetLocationX(where), GetLocationY(where), t);
        }

        public virtual void SetTerrainPathableBJ(location where, pathingtype t, boolean flag)
        {
            SetTerrainPathable(GetLocationX(where), GetLocationY(where), t, flag);
        }

        public virtual void SetWaterBaseColorBJ(real red, real green, real blue, real transparency)
        {
            SetWaterBaseColor(PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100f - transparency));
        }

        public virtual fogmodifier CreateFogModifierRectSimple(player whichPlayer, fogstate whichFogState, rect r, boolean afterUnits)
        {
            bj_lastCreatedFogModifier = CreateFogModifierRect(whichPlayer, whichFogState, r, true, afterUnits);
            return bj_lastCreatedFogModifier;
        }

        public virtual fogmodifier CreateFogModifierRadiusLocSimple(player whichPlayer, fogstate whichFogState, location center, real radius, boolean afterUnits)
        {
            bj_lastCreatedFogModifier = CreateFogModifierRadiusLoc(whichPlayer, whichFogState, center, radius, true, afterUnits);
            return bj_lastCreatedFogModifier;
        }

        public virtual fogmodifier CreateFogModifierRectBJ(boolean enabled, player whichPlayer, fogstate whichFogState, rect r)
        {
            bj_lastCreatedFogModifier = CreateFogModifierRect(whichPlayer, whichFogState, r, true, false);
            if (enabled)
            {
                FogModifierStart(bj_lastCreatedFogModifier);
            }
            return bj_lastCreatedFogModifier;
        }

        public virtual fogmodifier CreateFogModifierRadiusLocBJ(boolean enabled, player whichPlayer, fogstate whichFogState, location center, real radius)
        {
            bj_lastCreatedFogModifier = CreateFogModifierRadiusLoc(whichPlayer, whichFogState, center, radius, true, false);
            if (enabled)
            {
                FogModifierStart(bj_lastCreatedFogModifier);
            }
            return bj_lastCreatedFogModifier;
        }

        public virtual fogmodifier GetLastCreatedFogModifier()
        {
            return bj_lastCreatedFogModifier;
        }

        public virtual void FogEnableOn()
        {
            FogEnable(true);
        }

        public virtual void FogEnableOff()
        {
            FogEnable(false);
        }

        public virtual void FogMaskEnableOn()
        {
            FogMaskEnable(true);
        }

        public virtual void FogMaskEnableOff()
        {
            FogMaskEnable(false);
        }

        public virtual void UseTimeOfDayBJ(boolean flag)
        {
            SuspendTimeOfDay(!flag);
        }

        public virtual void SetTerrainFogExBJ(integer style, real zstart, real zend, real density, real red, real green, real blue)
        {
            SetTerrainFogEx(style, zstart, zend, density, red * 0.01f, green * 0.01f, blue * 0.01f);
        }

        public virtual void ResetTerrainFogBJ()
        {
            ResetTerrainFog();
        }

        public virtual void SetDoodadAnimationBJ(@string animName, integer doodadID, real radius, location center)
        {
            SetDoodadAnimation(GetLocationX(center), GetLocationY(center), radius, doodadID, false, animName, false);
        }

        public virtual void SetDoodadAnimationRectBJ(@string animName, integer doodadID, rect r)
        {
            SetDoodadAnimationRect(r, doodadID, animName, false);
        }

        public virtual void AddUnitAnimationPropertiesBJ(boolean add, @string animProperties, unit whichUnit)
        {
            AddUnitAnimationProperties(whichUnit, animProperties, add);
        }

        public virtual image CreateImageBJ(@string file, real size, location where, real zOffset, integer imageType)
        {
            bj_lastCreatedImage = CreateImage(file, size, size, size, GetLocationX(where), GetLocationY(where), zOffset, 0, 0, 0, imageType);
            return bj_lastCreatedImage;
        }

        public virtual void ShowImageBJ(boolean flag, image whichImage)
        {
            ShowImage(whichImage, flag);
        }

        public virtual void SetImagePositionBJ(image whichImage, location where, real zOffset)
        {
            SetImagePosition(whichImage, GetLocationX(where), GetLocationY(where), zOffset);
        }

        public virtual void SetImageColorBJ(image whichImage, real red, real green, real blue, real alpha)
        {
            SetImageColor(whichImage, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100f - alpha));
        }

        public virtual image GetLastCreatedImage()
        {
            return bj_lastCreatedImage;
        }

        public virtual ubersplat CreateUbersplatBJ(location where, @string name, real red, real green, real blue, real alpha, boolean forcePaused, boolean noBirthTime)
        {
            bj_lastCreatedUbersplat = CreateUbersplat(GetLocationX(where), GetLocationY(where), name, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100f - alpha), forcePaused, noBirthTime);
            return bj_lastCreatedUbersplat;
        }

        public virtual void ShowUbersplatBJ(boolean flag, ubersplat whichSplat)
        {
            ShowUbersplat(whichSplat, flag);
        }

        public virtual ubersplat GetLastCreatedUbersplat()
        {
            return bj_lastCreatedUbersplat;
        }

        public virtual void PlaySoundBJ(sound soundHandle)
        {
            bj_lastPlayedSound = soundHandle;
            if ((soundHandle != null))
            {
                StartSound(soundHandle);
            }
        }

        public virtual void StopSoundBJ(sound soundHandle, boolean fadeOut)
        {
            StopSound(soundHandle, false, fadeOut);
        }

        public virtual void SetSoundVolumeBJ(sound soundHandle, real volumePercent)
        {
            SetSoundVolume(soundHandle, PercentToInt(volumePercent, 127));
        }

        public virtual void SetSoundOffsetBJ(real newOffset, sound soundHandle)
        {
            SetSoundPlayPosition(soundHandle, R2I(newOffset * 1000));
        }

        public virtual void SetSoundDistanceCutoffBJ(sound soundHandle, real cutoff)
        {
            SetSoundDistanceCutoff(soundHandle, cutoff);
        }

        public virtual void SetSoundPitchBJ(sound soundHandle, real pitch)
        {
            SetSoundPitch(soundHandle, pitch);
        }

        public virtual void SetSoundPositionLocBJ(sound soundHandle, location loc, real z)
        {
            SetSoundPosition(soundHandle, GetLocationX(loc), GetLocationY(loc), z);
        }

        public virtual void AttachSoundToUnitBJ(sound soundHandle, unit whichUnit)
        {
            AttachSoundToUnit(soundHandle, whichUnit);
        }

        public virtual void SetSoundConeAnglesBJ(sound soundHandle, real inside, real outside, real outsideVolumePercent)
        {
            SetSoundConeAngles(soundHandle, inside, outside, PercentToInt(outsideVolumePercent, 127));
        }

        public virtual void KillSoundWhenDoneBJ(sound soundHandle)
        {
            KillSoundWhenDone(soundHandle);
        }

        public virtual void PlaySoundAtPointBJ(sound soundHandle, real volumePercent, location loc, real z)
        {
            SetSoundPositionLocBJ(soundHandle, loc, z);
            SetSoundVolumeBJ(soundHandle, volumePercent);
            PlaySoundBJ(soundHandle);
        }

        public virtual void PlaySoundOnUnitBJ(sound soundHandle, real volumePercent, unit whichUnit)
        {
            AttachSoundToUnitBJ(soundHandle, whichUnit);
            SetSoundVolumeBJ(soundHandle, volumePercent);
            PlaySoundBJ(soundHandle);
        }

        public virtual void PlaySoundFromOffsetBJ(sound soundHandle, real volumePercent, real startingOffset)
        {
            SetSoundVolumeBJ(soundHandle, volumePercent);
            PlaySoundBJ(soundHandle);
            SetSoundOffsetBJ(startingOffset, soundHandle);
        }

        public virtual void PlayMusicBJ(@string musicFileName)
        {
            bj_lastPlayedMusic = musicFileName;
            PlayMusic(musicFileName);
        }

        public virtual void PlayMusicExBJ(@string musicFileName, real startingOffset, real fadeInTime)
        {
            bj_lastPlayedMusic = musicFileName;
            PlayMusicEx(musicFileName, R2I(startingOffset * 1000), R2I(fadeInTime * 1000));
        }

        public virtual void SetMusicOffsetBJ(real newOffset)
        {
            SetMusicPlayPosition(R2I(newOffset * 1000));
        }

        public virtual void PlayThematicMusicBJ(@string musicName)
        {
            PlayThematicMusic(musicName);
        }

        public virtual void PlayThematicMusicExBJ(@string musicName, real startingOffset)
        {
            PlayThematicMusicEx(musicName, R2I(startingOffset * 1000));
        }

        public virtual void SetThematicMusicOffsetBJ(real newOffset)
        {
            SetThematicMusicPlayPosition(R2I(newOffset * 1000));
        }

        public virtual void EndThematicMusicBJ()
        {
            EndThematicMusic();
        }

        public virtual void StopMusicBJ(boolean fadeOut)
        {
            StopMusic(fadeOut);
        }

        public virtual void ResumeMusicBJ()
        {
            ResumeMusic();
        }

        public virtual void SetMusicVolumeBJ(real volumePercent)
        {
            SetMusicVolume(PercentToInt(volumePercent, 127));
        }

        public virtual real GetSoundDurationBJ(sound soundHandle)
        {
            if ((soundHandle == null))
            {
                return bj_NOTHING_SOUND_DURATION;
            }
            else
            {
                return I2R(GetSoundDuration(soundHandle)) * 0.001f;
            }
        }

        public virtual real GetSoundFileDurationBJ(@string musicFileName)
        {
            return I2R(GetSoundFileDuration(musicFileName)) * 0.001f;
        }

        public virtual sound GetLastPlayedSound()
        {
            return bj_lastPlayedSound;
        }

        public virtual @string GetLastPlayedMusic()
        {
            return bj_lastPlayedMusic;
        }

        public virtual void VolumeGroupSetVolumeBJ(volumegroup vgroup, real percent)
        {
            VolumeGroupSetVolume(vgroup, percent * 0.01f);
        }

        public virtual void SetCineModeVolumeGroupsImmediateBJ()
        {
            VolumeGroupSetVolume(SOUND_VOLUMEGROUP_UNITMOVEMENT, bj_CINEMODE_VOLUME_UNITMOVEMENT);
            VolumeGroupSetVolume(SOUND_VOLUMEGROUP_UNITSOUNDS, bj_CINEMODE_VOLUME_UNITSOUNDS);
            VolumeGroupSetVolume(SOUND_VOLUMEGROUP_COMBAT, bj_CINEMODE_VOLUME_COMBAT);
            VolumeGroupSetVolume(SOUND_VOLUMEGROUP_SPELLS, bj_CINEMODE_VOLUME_SPELLS);
            VolumeGroupSetVolume(SOUND_VOLUMEGROUP_UI, bj_CINEMODE_VOLUME_UI);
            VolumeGroupSetVolume(SOUND_VOLUMEGROUP_MUSIC, bj_CINEMODE_VOLUME_MUSIC);
            VolumeGroupSetVolume(SOUND_VOLUMEGROUP_AMBIENTSOUNDS, bj_CINEMODE_VOLUME_AMBIENTSOUNDS);
            VolumeGroupSetVolume(SOUND_VOLUMEGROUP_FIRE, bj_CINEMODE_VOLUME_FIRE);
        }

        public virtual void SetCineModeVolumeGroupsBJ()
        {
            if (bj_gameStarted)
            {
                SetCineModeVolumeGroupsImmediateBJ();
            }
            else
            {
                TimerStart(bj_volumeGroupsTimer, bj_GAME_STARTED_THRESHOLD, false, SetCineModeVolumeGroupsImmediateBJ);
            }
        }

        public virtual void SetSpeechVolumeGroupsImmediateBJ()
        {
            VolumeGroupSetVolume(SOUND_VOLUMEGROUP_UNITMOVEMENT, bj_SPEECH_VOLUME_UNITMOVEMENT);
            VolumeGroupSetVolume(SOUND_VOLUMEGROUP_UNITSOUNDS, bj_SPEECH_VOLUME_UNITSOUNDS);
            VolumeGroupSetVolume(SOUND_VOLUMEGROUP_COMBAT, bj_SPEECH_VOLUME_COMBAT);
            VolumeGroupSetVolume(SOUND_VOLUMEGROUP_SPELLS, bj_SPEECH_VOLUME_SPELLS);
            VolumeGroupSetVolume(SOUND_VOLUMEGROUP_UI, bj_SPEECH_VOLUME_UI);
            VolumeGroupSetVolume(SOUND_VOLUMEGROUP_MUSIC, bj_SPEECH_VOLUME_MUSIC);
            VolumeGroupSetVolume(SOUND_VOLUMEGROUP_AMBIENTSOUNDS, bj_SPEECH_VOLUME_AMBIENTSOUNDS);
            VolumeGroupSetVolume(SOUND_VOLUMEGROUP_FIRE, bj_SPEECH_VOLUME_FIRE);
        }

        public virtual void SetSpeechVolumeGroupsBJ()
        {
            if (bj_gameStarted)
            {
                SetSpeechVolumeGroupsImmediateBJ();
            }
            else
            {
                TimerStart(bj_volumeGroupsTimer, bj_GAME_STARTED_THRESHOLD, false, SetSpeechVolumeGroupsImmediateBJ);
            }
        }

        public virtual void VolumeGroupResetImmediateBJ()
        {
            VolumeGroupReset();
        }

        public virtual void VolumeGroupResetBJ()
        {
            if (bj_gameStarted)
            {
                VolumeGroupResetImmediateBJ();
            }
            else
            {
                TimerStart(bj_volumeGroupsTimer, bj_GAME_STARTED_THRESHOLD, false, VolumeGroupResetImmediateBJ);
            }
        }

        public virtual boolean GetSoundIsPlayingBJ(sound soundHandle)
        {
            return GetSoundIsLoading(soundHandle) || GetSoundIsPlaying(soundHandle);
        }

        public virtual void WaitForSoundBJ(sound soundHandle, real offset)
        {
            TriggerWaitForSound(soundHandle, offset);
        }

        public virtual void SetMapMusicIndexedBJ(@string musicName, integer index)
        {
            SetMapMusic(musicName, false, index);
        }

        public virtual void SetMapMusicRandomBJ(@string musicName)
        {
            SetMapMusic(musicName, true, 0);
        }

        public virtual void ClearMapMusicBJ()
        {
            ClearMapMusic();
        }

        public virtual void SetStackedSoundBJ(boolean add, sound soundHandle, rect r)
        {
            real width = GetRectMaxX(r) - GetRectMinX(r);
            real height = GetRectMaxY(r) - GetRectMinY(r);
            SetSoundPosition(soundHandle, GetRectCenterX(r), GetRectCenterY(r), 0);
            if (add)
            {
                RegisterStackedSound(soundHandle, true, width, height);
            }
            else
            {
                UnregisterStackedSound(soundHandle, true, width, height);
            }
        }

        public virtual void StartSoundForPlayerBJ(player whichPlayer, sound soundHandle)
        {
            if ((whichPlayer == GetLocalPlayer()))
            {
                StartSound(soundHandle);
            }
        }

        public virtual void VolumeGroupSetVolumeForPlayerBJ(player whichPlayer, volumegroup vgroup, real scale)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                VolumeGroupSetVolume(vgroup, scale);
            }
        }

        public virtual void EnableDawnDusk(boolean flag)
        {
            bj_useDawnDuskSounds = flag;
        }

        public virtual boolean IsDawnDuskEnabled()
        {
            return bj_useDawnDuskSounds;
        }

        public virtual void SetAmbientDaySound(@string inLabel)
        {
            real ToD = 0;
            if ((bj_dayAmbientSound != null))
            {
                StopSound(bj_dayAmbientSound, true, true);
            }
            bj_dayAmbientSound = CreateMIDISound(inLabel, 20, 20);
            ToD = GetTimeOfDay();
            if ((ToD >= bj_TOD_DAWN && ToD < bj_TOD_DUSK))
            {
                StartSound(bj_dayAmbientSound);
            }
        }

        public virtual void SetAmbientNightSound(@string inLabel)
        {
            real ToD = 0;
            if ((bj_nightAmbientSound != null))
            {
                StopSound(bj_nightAmbientSound, true, true);
            }
            bj_nightAmbientSound = CreateMIDISound(inLabel, 20, 20);
            ToD = GetTimeOfDay();
            if ((ToD < bj_TOD_DAWN || ToD >= bj_TOD_DUSK))
            {
                StartSound(bj_nightAmbientSound);
            }
        }

        public virtual effect AddSpecialEffectLocBJ(location where, @string modelName)
        {
            bj_lastCreatedEffect = AddSpecialEffectLoc(modelName, where);
            return bj_lastCreatedEffect;
        }

        public virtual effect AddSpecialEffectTargetUnitBJ(@string attachPointName, widget targetWidget, @string modelName)
        {
            bj_lastCreatedEffect = AddSpecialEffectTarget(modelName, targetWidget, attachPointName);
            return bj_lastCreatedEffect;
        }

        public virtual void DestroyEffectBJ(effect whichEffect)
        {
            DestroyEffect(whichEffect);
        }

        public virtual effect GetLastCreatedEffectBJ()
        {
            return bj_lastCreatedEffect;
        }

        public virtual location GetItemLoc(item whichItem)
        {
            return Location(GetItemX(whichItem), GetItemY(whichItem));
        }

        public virtual real GetItemLifeBJ(widget whichWidget)
        {
            return GetWidgetLife(whichWidget);
        }

        public virtual void SetItemLifeBJ(widget whichWidget, real life)
        {
            SetWidgetLife(whichWidget, life);
        }

        public virtual void AddHeroXPSwapped(integer xpToAdd, unit whichHero, boolean showEyeCandy)
        {
            AddHeroXP(whichHero, xpToAdd, showEyeCandy);
        }

        public virtual void SetHeroLevelBJ(unit whichHero, integer newLevel, boolean showEyeCandy)
        {
            integer oldLevel = GetHeroLevel(whichHero);
            if ((newLevel > oldLevel))
            {
                SetHeroLevel(whichHero, newLevel, showEyeCandy);
            }
            else
            {
                if ((newLevel < oldLevel))
                {
                    UnitStripHeroLevel(whichHero, oldLevel - newLevel);
                }
            }
        }

        public virtual integer DecUnitAbilityLevelSwapped(integer abilcode, unit whichUnit)
        {
            return DecUnitAbilityLevel(whichUnit, abilcode);
        }

        public virtual integer IncUnitAbilityLevelSwapped(integer abilcode, unit whichUnit)
        {
            return IncUnitAbilityLevel(whichUnit, abilcode);
        }

        public virtual integer SetUnitAbilityLevelSwapped(integer abilcode, unit whichUnit, integer level)
        {
            return SetUnitAbilityLevel(whichUnit, abilcode, level);
        }

        public virtual integer GetUnitAbilityLevelSwapped(integer abilcode, unit whichUnit)
        {
            return GetUnitAbilityLevel(whichUnit, abilcode);
        }

        public virtual boolean UnitHasBuffBJ(unit whichUnit, integer buffcode)
        {
            return (GetUnitAbilityLevel(whichUnit, buffcode) > 0);
        }

        public virtual boolean UnitRemoveBuffBJ(integer buffcode, unit whichUnit)
        {
            return UnitRemoveAbility(whichUnit, buffcode);
        }

        public virtual boolean UnitAddItemSwapped(item whichItem, unit whichHero)
        {
            return UnitAddItem(whichHero, whichItem);
        }

        public virtual item UnitAddItemByIdSwapped(integer itemId, unit whichHero)
        {
            bj_lastCreatedItem = CreateItem(itemId, GetUnitX(whichHero), GetUnitY(whichHero));
            UnitAddItem(whichHero, bj_lastCreatedItem);
            return bj_lastCreatedItem;
        }

        public virtual void UnitRemoveItemSwapped(item whichItem, unit whichHero)
        {
            bj_lastRemovedItem = whichItem;
            UnitRemoveItem(whichHero, whichItem);
        }

        public virtual item UnitRemoveItemFromSlotSwapped(integer itemSlot, unit whichHero)
        {
            bj_lastRemovedItem = UnitRemoveItemFromSlot(whichHero, itemSlot - 1);
            return bj_lastRemovedItem;
        }

        public virtual item CreateItemLoc(integer itemId, location loc)
        {
            bj_lastCreatedItem = CreateItem(itemId, GetLocationX(loc), GetLocationY(loc));
            return bj_lastCreatedItem;
        }

        public virtual item GetLastCreatedItem()
        {
            return bj_lastCreatedItem;
        }

        public virtual item GetLastRemovedItem()
        {
            return bj_lastRemovedItem;
        }

        public virtual void SetItemPositionLoc(item whichItem, location loc)
        {
            SetItemPosition(whichItem, GetLocationX(loc), GetLocationY(loc));
        }

        public virtual integer GetLearnedSkillBJ()
        {
            return GetLearnedSkill();
        }

        public virtual void SuspendHeroXPBJ(boolean flag, unit whichHero)
        {
            SuspendHeroXP(whichHero, !flag);
        }

        public virtual void SetPlayerHandicapXPBJ(player whichPlayer, real handicapPercent)
        {
            SetPlayerHandicapXP(whichPlayer, handicapPercent * 0.01f);
        }

        public virtual real GetPlayerHandicapXPBJ(player whichPlayer)
        {
            return GetPlayerHandicapXP(whichPlayer) * 100;
        }

        public virtual void SetPlayerHandicapBJ(player whichPlayer, real handicapPercent)
        {
            SetPlayerHandicap(whichPlayer, handicapPercent * 0.01f);
        }

        public virtual real GetPlayerHandicapBJ(player whichPlayer)
        {
            return GetPlayerHandicap(whichPlayer) * 100;
        }

        public virtual integer GetHeroStatBJ(integer whichStat, unit whichHero, boolean includeBonuses)
        {
            if ((whichStat == bj_HEROSTAT_STR))
            {
                return GetHeroStr(whichHero, includeBonuses);
            }
            else
            {
                if ((whichStat == bj_HEROSTAT_AGI))
                {
                    return GetHeroAgi(whichHero, includeBonuses);
                }
                else
                {
                    if ((whichStat == bj_HEROSTAT_INT))
                    {
                        return GetHeroInt(whichHero, includeBonuses);
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        public virtual void SetHeroStat(unit whichHero, integer whichStat, integer value)
        {
            if ((value <= 0))
            {
                return;
            }
            if ((whichStat == bj_HEROSTAT_STR))
            {
                SetHeroStr(whichHero, value, true);
            }
            else
            {
                if ((whichStat == bj_HEROSTAT_AGI))
                {
                    SetHeroAgi(whichHero, value, true);
                }
                else
                {
                    if ((whichStat == bj_HEROSTAT_INT))
                    {
                        SetHeroInt(whichHero, value, true);
                    }
                }
            }
        }

        public virtual void ModifyHeroStat(integer whichStat, unit whichHero, integer modifyMethod, integer value)
        {
            if ((modifyMethod == bj_MODIFYMETHOD_ADD))
            {
                SetHeroStat(whichHero, whichStat, GetHeroStatBJ(whichStat, whichHero, false) + value);
            }
            else
            {
                if ((modifyMethod == bj_MODIFYMETHOD_SUB))
                {
                    SetHeroStat(whichHero, whichStat, GetHeroStatBJ(whichStat, whichHero, false) - value);
                }
                else
                {
                    if ((modifyMethod == bj_MODIFYMETHOD_SET))
                    {
                        SetHeroStat(whichHero, whichStat, value);
                    }
                }
            }
        }

        public virtual boolean ModifyHeroSkillPoints(unit whichHero, integer modifyMethod, integer value)
        {
            if ((modifyMethod == bj_MODIFYMETHOD_ADD))
            {
                return UnitModifySkillPoints(whichHero, value);
            }
            else
            {
                if ((modifyMethod == bj_MODIFYMETHOD_SUB))
                {
                    return UnitModifySkillPoints(whichHero, -value);
                }
                else
                {
                    if ((modifyMethod == bj_MODIFYMETHOD_SET))
                    {
                        return UnitModifySkillPoints(whichHero, value - GetHeroSkillPoints(whichHero));
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public virtual boolean UnitDropItemPointBJ(unit whichUnit, item whichItem, real x, real y)
        {
            return UnitDropItemPoint(whichUnit, whichItem, x, y);
        }

        public virtual boolean UnitDropItemPointLoc(unit whichUnit, item whichItem, location loc)
        {
            return UnitDropItemPoint(whichUnit, whichItem, GetLocationX(loc), GetLocationY(loc));
        }

        public virtual boolean UnitDropItemSlotBJ(unit whichUnit, item whichItem, integer slot)
        {
            return UnitDropItemSlot(whichUnit, whichItem, slot - 1);
        }

        public virtual boolean UnitDropItemTargetBJ(unit whichUnit, item whichItem, widget target)
        {
            return UnitDropItemTarget(whichUnit, whichItem, target);
        }

        public virtual boolean UnitUseItemDestructable(unit whichUnit, item whichItem, widget target)
        {
            return UnitUseItemTarget(whichUnit, whichItem, target);
        }

        public virtual boolean UnitUseItemPointLoc(unit whichUnit, item whichItem, location loc)
        {
            return UnitUseItemPoint(whichUnit, whichItem, GetLocationX(loc), GetLocationY(loc));
        }

        public virtual item UnitItemInSlotBJ(unit whichUnit, integer itemSlot)
        {
            return UnitItemInSlot(whichUnit, itemSlot - 1);
        }

        public virtual integer GetInventoryIndexOfItemTypeBJ(unit whichUnit, integer itemId)
        {
            integer index = 0;
            item indexItem;
            index = 0;
            for (
            ; true;
            )
            {
                indexItem = UnitItemInSlot(whichUnit, index);
                if ((indexItem != null) && (GetItemTypeId(indexItem) == itemId))
                {
                    return index + 1;
                }
                index = index + 1;
                if (index >= bj_MAX_INVENTORY)
                {
                    break;
                }
            }
            return 0;
        }

        public virtual item GetItemOfTypeFromUnitBJ(unit whichUnit, integer itemId)
        {
            integer index = GetInventoryIndexOfItemTypeBJ(whichUnit, itemId);
            if ((index == 0))
            {
                return null;
            }
            else
            {
                return UnitItemInSlot(whichUnit, index - 1);
            }
        }

        public virtual boolean UnitHasItemOfTypeBJ(unit whichUnit, integer itemId)
        {
            return GetInventoryIndexOfItemTypeBJ(whichUnit, itemId) > 0;
        }

        public virtual integer UnitInventoryCount(unit whichUnit)
        {
            integer index = 0;
            integer count = 0;
            for (
            ; true;
            )
            {
                if ((UnitItemInSlot(whichUnit, index) != null))
                {
                    count = count + 1;
                }
                index = index + 1;
                if (index >= bj_MAX_INVENTORY)
                {
                    break;
                }
            }
            return count;
        }

        public virtual integer UnitInventorySizeBJ(unit whichUnit)
        {
            return UnitInventorySize(whichUnit);
        }

        public virtual void SetItemInvulnerableBJ(item whichItem, boolean flag)
        {
            SetItemInvulnerable(whichItem, flag);
        }

        public virtual void SetItemDropOnDeathBJ(item whichItem, boolean flag)
        {
            SetItemDropOnDeath(whichItem, flag);
        }

        public virtual void SetItemDroppableBJ(item whichItem, boolean flag)
        {
            SetItemDroppable(whichItem, flag);
        }

        public virtual void SetItemPlayerBJ(item whichItem, player whichPlayer, boolean changeColor)
        {
            SetItemPlayer(whichItem, whichPlayer, changeColor);
        }

        public virtual void SetItemVisibleBJ(boolean show, item whichItem)
        {
            SetItemVisible(whichItem, show);
        }

        public virtual boolean IsItemHiddenBJ(item whichItem)
        {
            return !IsItemVisible(whichItem);
        }

        public virtual integer ChooseRandomItemBJ(integer level)
        {
            return ChooseRandomItem(level);
        }

        public virtual integer ChooseRandomItemExBJ(integer level, itemtype whichType)
        {
            return ChooseRandomItemEx(whichType, level);
        }

        public virtual integer ChooseRandomNPBuildingBJ()
        {
            return ChooseRandomNPBuilding();
        }

        public virtual integer ChooseRandomCreepBJ(integer level)
        {
            return ChooseRandomCreep(level);
        }

        public virtual void EnumItemsInRectBJ(rect r, Action actionFunc)
        {
            EnumItemsInRect(r, null, actionFunc);
        }

        public virtual void RandomItemInRectBJEnum()
        {
            bj_itemRandomConsidered = bj_itemRandomConsidered + 1;
            if ((GetRandomInt(1, bj_itemRandomConsidered) == 1))
            {
                bj_itemRandomCurrentPick = GetEnumItem();
            }
        }

        public virtual item RandomItemInRectBJ(rect r, boolexpr filter)
        {
            bj_itemRandomConsidered = 0;
            bj_itemRandomCurrentPick = null;
            EnumItemsInRect(r, filter, RandomItemInRectBJEnum);
            DestroyBoolExpr(filter);
            return bj_itemRandomCurrentPick;
        }

        public virtual item RandomItemInRectSimpleBJ(rect r)
        {
            return RandomItemInRectBJ(r, null);
        }

        public virtual boolean CheckItemStatus(item whichItem, integer status)
        {
            if ((status == bj_ITEM_STATUS_HIDDEN))
            {
                return !IsItemVisible(whichItem);
            }
            else
            {
                if ((status == bj_ITEM_STATUS_OWNED))
                {
                    return IsItemOwned(whichItem);
                }
                else
                {
                    if ((status == bj_ITEM_STATUS_INVULNERABLE))
                    {
                        return IsItemInvulnerable(whichItem);
                    }
                    else
                    {
                        if ((status == bj_ITEM_STATUS_POWERUP))
                        {
                            return IsItemPowerup(whichItem);
                        }
                        else
                        {
                            if ((status == bj_ITEM_STATUS_SELLABLE))
                            {
                                return IsItemSellable(whichItem);
                            }
                            else
                            {
                                if ((status == bj_ITEM_STATUS_PAWNABLE))
                                {
                                    return IsItemPawnable(whichItem);
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
        }

        public virtual boolean CheckItemcodeStatus(integer itemId, integer status)
        {
            if ((status == bj_ITEMCODE_STATUS_POWERUP))
            {
                return IsItemIdPowerup(itemId);
            }
            else
            {
                if ((status == bj_ITEMCODE_STATUS_SELLABLE))
                {
                    return IsItemIdSellable(itemId);
                }
                else
                {
                    if ((status == bj_ITEMCODE_STATUS_PAWNABLE))
                    {
                        return IsItemIdPawnable(itemId);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public virtual integer UnitId2OrderIdBJ(integer unitId)
        {
            return unitId;
        }

        public virtual integer String2UnitIdBJ(@string unitIdString)
        {
            return UnitId(unitIdString);
        }

        public virtual @string UnitId2StringBJ(integer unitId)
        {
            @string unitString = UnitId2String(unitId);
            if ((unitString != null))
            {
                return unitString;
            }
            return "";
        }

        public virtual integer String2OrderIdBJ(@string orderIdString)
        {
            integer orderId = 0;
            orderId = OrderId(orderIdString);
            if ((orderId != 0))
            {
                return orderId;
            }
            orderId = UnitId(orderIdString);
            if ((orderId != 0))
            {
                return orderId;
            }
            return 0;
        }

        public virtual @string OrderId2StringBJ(integer orderId)
        {
            @string orderString;
            orderString = OrderId2String(orderId);
            if ((orderString != null))
            {
                return orderString;
            }
            orderString = UnitId2String(orderId);
            if ((orderString != null))
            {
                return orderString;
            }
            return "";
        }

        public virtual integer GetIssuedOrderIdBJ()
        {
            return GetIssuedOrderId();
        }

        public virtual unit GetKillingUnitBJ()
        {
            return GetKillingUnit();
        }

        public virtual unit CreateUnitAtLocSaveLast(player id, integer unitid, location loc, real face)
        {
            if ((unitid == 1819240309))
            {
                bj_lastCreatedUnit = CreateBlightedGoldmine(id, GetLocationX(loc), GetLocationY(loc), face);
            }
            else
            {
                bj_lastCreatedUnit = CreateUnitAtLoc(id, unitid, loc, face);
            }
            return bj_lastCreatedUnit;
        }

        public virtual unit GetLastCreatedUnit()
        {
            return bj_lastCreatedUnit;
        }

        public virtual group CreateNUnitsAtLoc(integer count, integer unitId, player whichPlayer, location loc, real face)
        {
            GroupClear(bj_lastCreatedGroup);
            for (
            ; true;
            )
            {
                count = count - 1;
                if (count < 0)
                {
                    break;
                }
                CreateUnitAtLocSaveLast(whichPlayer, unitId, loc, face);
                GroupAddUnit(bj_lastCreatedGroup, bj_lastCreatedUnit);
            }
            return bj_lastCreatedGroup;
        }

        public virtual group CreateNUnitsAtLocFacingLocBJ(integer count, integer unitId, player whichPlayer, location loc, location lookAt)
        {
            return CreateNUnitsAtLoc(count, unitId, whichPlayer, loc, AngleBetweenPoints(loc, lookAt));
        }

        public virtual void GetLastCreatedGroupEnum()
        {
            GroupAddUnit(bj_groupLastCreatedDest, GetEnumUnit());
        }

        public virtual group GetLastCreatedGroup()
        {
            bj_groupLastCreatedDest = CreateGroup();
            ForGroup(bj_lastCreatedGroup, GetLastCreatedGroupEnum);
            return bj_groupLastCreatedDest;
        }

        public virtual unit CreateCorpseLocBJ(integer unitid, player whichPlayer, location loc)
        {
            bj_lastCreatedUnit = CreateCorpse(whichPlayer, unitid, GetLocationX(loc), GetLocationY(loc), GetRandomReal(0, 360));
            return bj_lastCreatedUnit;
        }

        public virtual void UnitSuspendDecayBJ(boolean suspend, unit whichUnit)
        {
            UnitSuspendDecay(whichUnit, suspend);
        }

        public virtual void DelayedSuspendDecayStopAnimEnum()
        {
            unit enumUnit = GetEnumUnit();
            if ((GetUnitState(enumUnit, UNIT_STATE_LIFE) <= 0))
            {
                SetUnitTimeScale(enumUnit, 0.0001f);
            }
        }

        public virtual void DelayedSuspendDecayBoneEnum()
        {
            unit enumUnit = GetEnumUnit();
            if ((GetUnitState(enumUnit, UNIT_STATE_LIFE) <= 0))
            {
                UnitSuspendDecay(enumUnit, true);
                SetUnitTimeScale(enumUnit, 0.0001f);
            }
        }

        public virtual void DelayedSuspendDecayFleshEnum()
        {
            unit enumUnit = GetEnumUnit();
            if ((GetUnitState(enumUnit, UNIT_STATE_LIFE) <= 0))
            {
                UnitSuspendDecay(enumUnit, true);
                SetUnitTimeScale(enumUnit, 10f);
                SetUnitAnimation(enumUnit, "decay flesh");
            }
        }

        public virtual void DelayedSuspendDecay()
        {
            group boneGroup;
            group fleshGroup;
            boneGroup = bj_suspendDecayBoneGroup;
            fleshGroup = bj_suspendDecayFleshGroup;
            bj_suspendDecayBoneGroup = CreateGroup();
            bj_suspendDecayFleshGroup = CreateGroup();
            ForGroup(fleshGroup, DelayedSuspendDecayStopAnimEnum);
            ForGroup(boneGroup, DelayedSuspendDecayStopAnimEnum);
            TriggerSleepAction(bj_CORPSE_MAX_DEATH_TIME);
            ForGroup(fleshGroup, DelayedSuspendDecayFleshEnum);
            ForGroup(boneGroup, DelayedSuspendDecayBoneEnum);
            TriggerSleepAction(0.05f);
            ForGroup(fleshGroup, DelayedSuspendDecayStopAnimEnum);
            DestroyGroup(boneGroup);
            DestroyGroup(fleshGroup);
        }

        public virtual void DelayedSuspendDecayCreate()
        {
            bj_delayedSuspendDecayTrig = CreateTrigger();
            TriggerRegisterTimerExpireEvent(bj_delayedSuspendDecayTrig, bj_delayedSuspendDecayTimer);
            TriggerAddAction(bj_delayedSuspendDecayTrig, DelayedSuspendDecay);
        }

        public virtual unit CreatePermanentCorpseLocBJ(integer style, integer unitid, player whichPlayer, location loc, real facing)
        {
            bj_lastCreatedUnit = CreateCorpse(whichPlayer, unitid, GetLocationX(loc), GetLocationY(loc), facing);
            SetUnitBlendTime(bj_lastCreatedUnit, 0);
            if ((style == bj_CORPSETYPE_FLESH))
            {
                SetUnitAnimation(bj_lastCreatedUnit, "decay flesh");
                GroupAddUnit(bj_suspendDecayFleshGroup, bj_lastCreatedUnit);
            }
            else
            {
                if ((style == bj_CORPSETYPE_BONE))
                {
                    SetUnitAnimation(bj_lastCreatedUnit, "decay bone");
                    GroupAddUnit(bj_suspendDecayBoneGroup, bj_lastCreatedUnit);
                }
                else
                {
                    SetUnitAnimation(bj_lastCreatedUnit, "decay bone");
                    GroupAddUnit(bj_suspendDecayBoneGroup, bj_lastCreatedUnit);
                }
            }
            TimerStart(bj_delayedSuspendDecayTimer, 0.05f, false, null);
            return bj_lastCreatedUnit;
        }

        public virtual real GetUnitStateSwap(unitstate whichState, unit whichUnit)
        {
            return GetUnitState(whichUnit, whichState);
        }

        public virtual real GetUnitStatePercent(unit whichUnit, unitstate whichState, unitstate whichMaxState)
        {
            real value = GetUnitState(whichUnit, whichState);
            real maxValue = GetUnitState(whichUnit, whichMaxState);
            if ((whichUnit == null) || (maxValue == 0))
            {
                return 0f;
            }
            return value / maxValue * 100f;
        }

        public virtual real GetUnitLifePercent(unit whichUnit)
        {
            return GetUnitStatePercent(whichUnit, UNIT_STATE_LIFE, UNIT_STATE_MAX_LIFE);
        }

        public virtual real GetUnitManaPercent(unit whichUnit)
        {
            return GetUnitStatePercent(whichUnit, UNIT_STATE_MANA, UNIT_STATE_MAX_MANA);
        }

        public virtual void SelectUnitSingle(unit whichUnit)
        {
            ClearSelection();
            SelectUnit(whichUnit, true);
        }

        public virtual void SelectGroupBJEnum()
        {
            SelectUnit(GetEnumUnit(), true);
        }

        public virtual void SelectGroupBJ(group g)
        {
            ClearSelection();
            ForGroup(g, SelectGroupBJEnum);
        }

        public virtual void SelectUnitAdd(unit whichUnit)
        {
            SelectUnit(whichUnit, true);
        }

        public virtual void SelectUnitRemove(unit whichUnit)
        {
            SelectUnit(whichUnit, false);
        }

        public virtual void ClearSelectionForPlayer(player whichPlayer)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                ClearSelection();
            }
        }

        public virtual void SelectUnitForPlayerSingle(unit whichUnit, player whichPlayer)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                ClearSelection();
                SelectUnit(whichUnit, true);
            }
        }

        public virtual void SelectGroupForPlayerBJ(group g, player whichPlayer)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                ClearSelection();
                ForGroup(g, SelectGroupBJEnum);
            }
        }

        public virtual void SelectUnitAddForPlayer(unit whichUnit, player whichPlayer)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                SelectUnit(whichUnit, true);
            }
        }

        public virtual void SelectUnitRemoveForPlayer(unit whichUnit, player whichPlayer)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                SelectUnit(whichUnit, false);
            }
        }

        public virtual void SetUnitLifeBJ(unit whichUnit, real newValue)
        {
            SetUnitState(whichUnit, UNIT_STATE_LIFE, RMaxBJ(0, newValue));
        }

        public virtual void SetUnitManaBJ(unit whichUnit, real newValue)
        {
            SetUnitState(whichUnit, UNIT_STATE_MANA, RMaxBJ(0, newValue));
        }

        public virtual void SetUnitLifePercentBJ(unit whichUnit, real percent)
        {
            SetUnitState(whichUnit, UNIT_STATE_LIFE, GetUnitState(whichUnit, UNIT_STATE_MAX_LIFE) * RMaxBJ(0, percent) * 0.01f);
        }

        public virtual void SetUnitManaPercentBJ(unit whichUnit, real percent)
        {
            SetUnitState(whichUnit, UNIT_STATE_MANA, GetUnitState(whichUnit, UNIT_STATE_MAX_MANA) * RMaxBJ(0, percent) * 0.01f);
        }

        public virtual boolean IsUnitDeadBJ(unit whichUnit)
        {
            return GetUnitState(whichUnit, UNIT_STATE_LIFE) <= 0;
        }

        public virtual boolean IsUnitAliveBJ(unit whichUnit)
        {
            return !IsUnitDeadBJ(whichUnit);
        }

        public virtual void IsUnitGroupDeadBJEnum()
        {
            if (!IsUnitDeadBJ(GetEnumUnit()))
            {
                bj_isUnitGroupDeadResult = false;
            }
        }

        public virtual boolean IsUnitGroupDeadBJ(group g)
        {
            boolean wantDestroy = bj_wantDestroyGroup;
            bj_wantDestroyGroup = false;
            bj_isUnitGroupDeadResult = true;
            ForGroup(g, IsUnitGroupDeadBJEnum);
            if ((wantDestroy))
            {
                DestroyGroup(g);
            }
            return bj_isUnitGroupDeadResult;
        }

        public virtual void IsUnitGroupEmptyBJEnum()
        {
            bj_isUnitGroupEmptyResult = false;
        }

        public virtual boolean IsUnitGroupEmptyBJ(group g)
        {
            boolean wantDestroy = bj_wantDestroyGroup;
            bj_wantDestroyGroup = false;
            bj_isUnitGroupEmptyResult = true;
            ForGroup(g, IsUnitGroupEmptyBJEnum);
            if ((wantDestroy))
            {
                DestroyGroup(g);
            }
            return bj_isUnitGroupEmptyResult;
        }

        public virtual void IsUnitGroupInRectBJEnum()
        {
            if (!RectContainsUnit(bj_isUnitGroupInRectRect, GetEnumUnit()))
            {
                bj_isUnitGroupInRectResult = false;
            }
        }

        public virtual boolean IsUnitGroupInRectBJ(group g, rect r)
        {
            bj_isUnitGroupInRectResult = true;
            bj_isUnitGroupInRectRect = r;
            ForGroup(g, IsUnitGroupInRectBJEnum);
            return bj_isUnitGroupInRectResult;
        }

        public virtual boolean IsUnitHiddenBJ(unit whichUnit)
        {
            return IsUnitHidden(whichUnit);
        }

        public virtual void ShowUnitHide(unit whichUnit)
        {
            ShowUnit(whichUnit, false);
        }

        public virtual void ShowUnitShow(unit whichUnit)
        {
            if ((IsUnitType(whichUnit, UNIT_TYPE_HERO) && IsUnitDeadBJ(whichUnit)))
            {
                return;
            }
            ShowUnit(whichUnit, true);
        }

        public virtual boolean IssueHauntOrderAtLocBJFilter()
        {
            return GetUnitTypeId(GetFilterUnit()) == 1819240302;
        }

        public virtual boolean IssueHauntOrderAtLocBJ(unit whichPeon, location loc)
        {
            group g = null;
            unit goldMine = null;
            g = CreateGroup();
            GroupEnumUnitsInRangeOfLoc(g, loc, 2 * bj_CELLWIDTH, filterIssueHauntOrderAtLocBJ);
            goldMine = FirstOfGroup(g);
            DestroyGroup(g);
            if ((goldMine == null))
            {
                return false;
            }
            return IssueTargetOrderById(whichPeon, 1819240309, goldMine);
        }

        public virtual boolean IssueBuildOrderByIdLocBJ(unit whichPeon, integer unitId, location loc)
        {
            if ((unitId == 1819240309))
            {
                return IssueHauntOrderAtLocBJ(whichPeon, loc);
            }
            else
            {
                return IssueBuildOrderById(whichPeon, unitId, GetLocationX(loc), GetLocationY(loc));
            }
        }

        public virtual boolean IssueTrainOrderByIdBJ(unit whichUnit, integer unitId)
        {
            return IssueImmediateOrderById(whichUnit, unitId);
        }

        public virtual boolean GroupTrainOrderByIdBJ(group g, integer unitId)
        {
            return GroupImmediateOrderById(g, unitId);
        }

        public virtual boolean IssueUpgradeOrderByIdBJ(unit whichUnit, integer techId)
        {
            return IssueImmediateOrderById(whichUnit, techId);
        }

        public virtual unit GetAttackedUnitBJ()
        {
            return GetTriggerUnit();
        }

        public virtual void SetUnitFlyHeightBJ(unit whichUnit, real newHeight, real rate)
        {
            SetUnitFlyHeight(whichUnit, newHeight, rate);
        }

        public virtual void SetUnitTurnSpeedBJ(unit whichUnit, real turnSpeed)
        {
            SetUnitTurnSpeed(whichUnit, turnSpeed);
        }

        public virtual void SetUnitPropWindowBJ(unit whichUnit, real propWindow)
        {
            real angle = propWindow;
            if ((angle <= 0))
            {
                angle = 1;
            }
            else
            {
                if ((angle >= 360))
                {
                    angle = 359;
                }
            }
            angle = angle * bj_DEGTORAD;
            SetUnitPropWindow(whichUnit, angle);
        }

        public virtual real GetUnitPropWindowBJ(unit whichUnit)
        {
            return GetUnitPropWindow(whichUnit) * bj_RADTODEG;
        }

        public virtual real GetUnitDefaultPropWindowBJ(unit whichUnit)
        {
            return GetUnitDefaultPropWindow(whichUnit);
        }

        public virtual void SetUnitBlendTimeBJ(unit whichUnit, real blendTime)
        {
            SetUnitBlendTime(whichUnit, blendTime);
        }

        public virtual void SetUnitAcquireRangeBJ(unit whichUnit, real acquireRange)
        {
            SetUnitAcquireRange(whichUnit, acquireRange);
        }

        public virtual void UnitSetCanSleepBJ(unit whichUnit, boolean canSleep)
        {
            UnitAddSleep(whichUnit, canSleep);
        }

        public virtual boolean UnitCanSleepBJ(unit whichUnit)
        {
            return UnitCanSleep(whichUnit);
        }

        public virtual void UnitWakeUpBJ(unit whichUnit)
        {
            UnitWakeUp(whichUnit);
        }

        public virtual boolean UnitIsSleepingBJ(unit whichUnit)
        {
            return UnitIsSleeping(whichUnit);
        }

        public virtual void WakePlayerUnitsEnum()
        {
            UnitWakeUp(GetEnumUnit());
        }

        public virtual void WakePlayerUnits(player whichPlayer)
        {
            group g = CreateGroup();
            GroupEnumUnitsOfPlayer(g, whichPlayer, null);
            ForGroup(g, WakePlayerUnitsEnum);
            DestroyGroup(g);
        }

        public virtual void EnableCreepSleepBJ(boolean enable)
        {
            SetPlayerState(Player(PLAYER_NEUTRAL_AGGRESSIVE), PLAYER_STATE_NO_CREEP_SLEEP, IntegerTertiaryOp(enable, 0, 1));
            if ((!enable))
            {
                WakePlayerUnits(Player(PLAYER_NEUTRAL_AGGRESSIVE));
            }
        }

        public virtual boolean UnitGenerateAlarms(unit whichUnit, boolean generate)
        {
            return UnitIgnoreAlarm(whichUnit, !generate);
        }

        public virtual boolean DoesUnitGenerateAlarms(unit whichUnit)
        {
            return !UnitIgnoreAlarmToggled(whichUnit);
        }

        public virtual void PauseAllUnitsBJEnum()
        {
            PauseUnit(GetEnumUnit(), bj_pauseAllUnitsFlag);
        }

        public virtual void PauseAllUnitsBJ(boolean pause)
        {
            integer index = 0;
            player indexPlayer;
            group g;
            bj_pauseAllUnitsFlag = pause;
            g = CreateGroup();
            index = 0;
            for (
            ; true;
            )
            {
                indexPlayer = Player(index);
                if ((GetPlayerController(indexPlayer) == MAP_CONTROL_COMPUTER))
                {
                    PauseCompAI(indexPlayer, pause);
                }
                GroupEnumUnitsOfPlayer(g, indexPlayer, null);
                ForGroup(g, PauseAllUnitsBJEnum);
                GroupClear(g);
                index = index + 1;
                if (index == bj_MAX_PLAYER_SLOTS)
                {
                    break;
                }
            }
            DestroyGroup(g);
        }

        public virtual void PauseUnitBJ(boolean pause, unit whichUnit)
        {
            PauseUnit(whichUnit, pause);
        }

        public virtual boolean IsUnitPausedBJ(unit whichUnit)
        {
            return IsUnitPaused(whichUnit);
        }

        public virtual void UnitPauseTimedLifeBJ(boolean flag, unit whichUnit)
        {
            UnitPauseTimedLife(whichUnit, flag);
        }

        public virtual void UnitApplyTimedLifeBJ(real duration, integer buffId, unit whichUnit)
        {
            UnitApplyTimedLife(whichUnit, buffId, duration);
        }

        public virtual void UnitShareVisionBJ(boolean share, unit whichUnit, player whichPlayer)
        {
            UnitShareVision(whichUnit, whichPlayer, share);
        }

        public virtual void UnitRemoveBuffsBJ(integer buffType, unit whichUnit)
        {
            if ((buffType == bj_REMOVEBUFFS_POSITIVE))
            {
                UnitRemoveBuffs(whichUnit, true, false);
            }
            else
            {
                if ((buffType == bj_REMOVEBUFFS_NEGATIVE))
                {
                    UnitRemoveBuffs(whichUnit, false, true);
                }
                else
                {
                    if ((buffType == bj_REMOVEBUFFS_ALL))
                    {
                        UnitRemoveBuffs(whichUnit, true, true);
                    }
                    else
                    {
                        if ((buffType == bj_REMOVEBUFFS_NONTLIFE))
                        {
                            UnitRemoveBuffsEx(whichUnit, true, true, false, false, false, true, false);
                        }
                    }
                }
            }
        }

        public virtual void UnitRemoveBuffsExBJ(integer polarity, integer resist, unit whichUnit, boolean bTLife, boolean bAura)
        {
            boolean bPos = (polarity == bj_BUFF_POLARITY_EITHER) || (polarity == bj_BUFF_POLARITY_POSITIVE);
            boolean bNeg = (polarity == bj_BUFF_POLARITY_EITHER) || (polarity == bj_BUFF_POLARITY_NEGATIVE);
            boolean bMagic = (resist == bj_BUFF_RESIST_BOTH) || (resist == bj_BUFF_RESIST_MAGIC);
            boolean bPhys = (resist == bj_BUFF_RESIST_BOTH) || (resist == bj_BUFF_RESIST_PHYSICAL);
            UnitRemoveBuffsEx(whichUnit, bPos, bNeg, bMagic, bPhys, bTLife, bAura, false);
        }

        public virtual integer UnitCountBuffsExBJ(integer polarity, integer resist, unit whichUnit, boolean bTLife, boolean bAura)
        {
            boolean bPos = (polarity == bj_BUFF_POLARITY_EITHER) || (polarity == bj_BUFF_POLARITY_POSITIVE);
            boolean bNeg = (polarity == bj_BUFF_POLARITY_EITHER) || (polarity == bj_BUFF_POLARITY_NEGATIVE);
            boolean bMagic = (resist == bj_BUFF_RESIST_BOTH) || (resist == bj_BUFF_RESIST_MAGIC);
            boolean bPhys = (resist == bj_BUFF_RESIST_BOTH) || (resist == bj_BUFF_RESIST_PHYSICAL);
            return UnitCountBuffsEx(whichUnit, bPos, bNeg, bMagic, bPhys, bTLife, bAura, false);
        }

        public virtual boolean UnitRemoveAbilityBJ(integer abilityId, unit whichUnit)
        {
            return UnitRemoveAbility(whichUnit, abilityId);
        }

        public virtual boolean UnitAddAbilityBJ(integer abilityId, unit whichUnit)
        {
            return UnitAddAbility(whichUnit, abilityId);
        }

        public virtual boolean UnitRemoveTypeBJ(unittype whichType, unit whichUnit)
        {
            return UnitRemoveType(whichUnit, whichType);
        }

        public virtual boolean UnitAddTypeBJ(unittype whichType, unit whichUnit)
        {
            return UnitAddType(whichUnit, whichType);
        }

        public virtual boolean UnitMakeAbilityPermanentBJ(boolean permanent, integer abilityId, unit whichUnit)
        {
            return UnitMakeAbilityPermanent(whichUnit, permanent, abilityId);
        }

        public virtual void SetUnitExplodedBJ(unit whichUnit, boolean exploded)
        {
            SetUnitExploded(whichUnit, exploded);
        }

        public virtual void ExplodeUnitBJ(unit whichUnit)
        {
            SetUnitExploded(whichUnit, true);
            KillUnit(whichUnit);
        }

        public virtual unit GetTransportUnitBJ()
        {
            return GetTransportUnit();
        }

        public virtual unit GetLoadedUnitBJ()
        {
            return GetLoadedUnit();
        }

        public virtual boolean IsUnitInTransportBJ(unit whichUnit, unit whichTransport)
        {
            return IsUnitInTransport(whichUnit, whichTransport);
        }

        public virtual boolean IsUnitLoadedBJ(unit whichUnit)
        {
            return IsUnitLoaded(whichUnit);
        }

        public virtual boolean IsUnitIllusionBJ(unit whichUnit)
        {
            return IsUnitIllusion(whichUnit);
        }

        public virtual unit ReplaceUnitBJ(unit whichUnit, integer newUnitId, integer unitStateMethod)
        {
            unit oldUnit = whichUnit;
            unit newUnit;
            boolean wasHidden = false;
            integer index = 0;
            item indexItem;
            real oldRatio = 0;
            if ((oldUnit == null))
            {
                bj_lastReplacedUnit = oldUnit;
                return oldUnit;
            }
            wasHidden = IsUnitHidden(oldUnit);
            ShowUnit(oldUnit, false);
            if ((newUnitId == 1819240309))
            {
                newUnit = CreateBlightedGoldmine(GetOwningPlayer(oldUnit), GetUnitX(oldUnit), GetUnitY(oldUnit), GetUnitFacing(oldUnit));
            }
            else
            {
                newUnit = CreateUnit(GetOwningPlayer(oldUnit), newUnitId, GetUnitX(oldUnit), GetUnitY(oldUnit), GetUnitFacing(oldUnit));
            }
            if ((unitStateMethod == bj_UNIT_STATE_METHOD_RELATIVE))
            {
                if ((GetUnitState(oldUnit, UNIT_STATE_MAX_LIFE) > 0))
                {
                    oldRatio = GetUnitState(oldUnit, UNIT_STATE_LIFE) / GetUnitState(oldUnit, UNIT_STATE_MAX_LIFE);
                    SetUnitState(newUnit, UNIT_STATE_LIFE, oldRatio * GetUnitState(newUnit, UNIT_STATE_MAX_LIFE));
                }
                if ((GetUnitState(oldUnit, UNIT_STATE_MAX_MANA) > 0) && (GetUnitState(newUnit, UNIT_STATE_MAX_MANA) > 0))
                {
                    oldRatio = GetUnitState(oldUnit, UNIT_STATE_MANA) / GetUnitState(oldUnit, UNIT_STATE_MAX_MANA);
                    SetUnitState(newUnit, UNIT_STATE_MANA, oldRatio * GetUnitState(newUnit, UNIT_STATE_MAX_MANA));
                }
            }
            else
            {
                if ((unitStateMethod == bj_UNIT_STATE_METHOD_ABSOLUTE))
                {
                    SetUnitState(newUnit, UNIT_STATE_LIFE, GetUnitState(oldUnit, UNIT_STATE_LIFE));
                    if ((GetUnitState(newUnit, UNIT_STATE_MAX_MANA) > 0))
                    {
                        SetUnitState(newUnit, UNIT_STATE_MANA, GetUnitState(oldUnit, UNIT_STATE_MANA));
                    }
                }
                else
                {
                    if ((unitStateMethod == bj_UNIT_STATE_METHOD_DEFAULTS))
                    {
                    }
                    else
                    {
                        if ((unitStateMethod == bj_UNIT_STATE_METHOD_MAXIMUM))
                        {
                            SetUnitState(newUnit, UNIT_STATE_LIFE, GetUnitState(newUnit, UNIT_STATE_MAX_LIFE));
                            SetUnitState(newUnit, UNIT_STATE_MANA, GetUnitState(newUnit, UNIT_STATE_MAX_MANA));
                        }
                    }
                }
            }
            SetResourceAmount(newUnit, GetResourceAmount(oldUnit));
            if ((IsUnitType(oldUnit, UNIT_TYPE_HERO) && IsUnitType(newUnit, UNIT_TYPE_HERO)))
            {
                SetHeroXP(newUnit, GetHeroXP(oldUnit), false);
                index = 0;
                for (
                ; true;
                )
                {
                    indexItem = UnitItemInSlot(oldUnit, index);
                    if ((indexItem != null))
                    {
                        UnitRemoveItem(oldUnit, indexItem);
                        UnitAddItem(newUnit, indexItem);
                    }
                    index = index + 1;
                    if (index >= bj_MAX_INVENTORY)
                    {
                        break;
                    }
                }
            }
            if (wasHidden)
            {
                KillUnit(oldUnit);
                RemoveUnit(oldUnit);
            }
            else
            {
                RemoveUnit(oldUnit);
            }
            bj_lastReplacedUnit = newUnit;
            return newUnit;
        }

        public virtual unit GetLastReplacedUnitBJ()
        {
            return bj_lastReplacedUnit;
        }

        public virtual void SetUnitPositionLocFacingBJ(unit whichUnit, location loc, real facing)
        {
            SetUnitPositionLoc(whichUnit, loc);
            SetUnitFacing(whichUnit, facing);
        }

        public virtual void SetUnitPositionLocFacingLocBJ(unit whichUnit, location loc, location lookAt)
        {
            SetUnitPositionLoc(whichUnit, loc);
            SetUnitFacing(whichUnit, AngleBetweenPoints(loc, lookAt));
        }

        public virtual void AddItemToStockBJ(integer itemId, unit whichUnit, integer currentStock, integer stockMax)
        {
            AddItemToStock(whichUnit, itemId, currentStock, stockMax);
        }

        public virtual void AddUnitToStockBJ(integer unitId, unit whichUnit, integer currentStock, integer stockMax)
        {
            AddUnitToStock(whichUnit, unitId, currentStock, stockMax);
        }

        public virtual void RemoveItemFromStockBJ(integer itemId, unit whichUnit)
        {
            RemoveItemFromStock(whichUnit, itemId);
        }

        public virtual void RemoveUnitFromStockBJ(integer unitId, unit whichUnit)
        {
            RemoveUnitFromStock(whichUnit, unitId);
        }

        public virtual void SetUnitUseFoodBJ(boolean enable, unit whichUnit)
        {
            SetUnitUseFood(whichUnit, enable);
        }

        public virtual boolean UnitDamagePointLoc(unit whichUnit, real delay, real radius, location loc, real amount, attacktype whichAttack, damagetype whichDamage)
        {
            return UnitDamagePoint(whichUnit, delay, radius, GetLocationX(loc), GetLocationY(loc), amount, true, false, whichAttack, whichDamage, WEAPON_TYPE_WHOKNOWS);
        }

        public virtual boolean UnitDamageTargetBJ(unit whichUnit, unit target, real amount, attacktype whichAttack, damagetype whichDamage)
        {
            return UnitDamageTarget(whichUnit, target, amount, true, false, whichAttack, whichDamage, WEAPON_TYPE_WHOKNOWS);
        }

        public virtual destructable CreateDestructableLoc(integer objectid, location loc, real facing, real scale, integer variation)
        {
            bj_lastCreatedDestructable = CreateDestructable(objectid, GetLocationX(loc), GetLocationY(loc), facing, scale, variation);
            return bj_lastCreatedDestructable;
        }

        public virtual destructable CreateDeadDestructableLocBJ(integer objectid, location loc, real facing, real scale, integer variation)
        {
            bj_lastCreatedDestructable = CreateDeadDestructable(objectid, GetLocationX(loc), GetLocationY(loc), facing, scale, variation);
            return bj_lastCreatedDestructable;
        }

        public virtual destructable GetLastCreatedDestructable()
        {
            return bj_lastCreatedDestructable;
        }

        public virtual void ShowDestructableBJ(boolean flag, destructable d)
        {
            ShowDestructable(d, flag);
        }

        public virtual void SetDestructableInvulnerableBJ(destructable d, boolean flag)
        {
            SetDestructableInvulnerable(d, flag);
        }

        public virtual boolean IsDestructableInvulnerableBJ(destructable d)
        {
            return IsDestructableInvulnerable(d);
        }

        public virtual location GetDestructableLoc(destructable whichDestructable)
        {
            return Location(GetDestructableX(whichDestructable), GetDestructableY(whichDestructable));
        }

        public virtual void EnumDestructablesInRectAll(rect r, Action actionFunc)
        {
            EnumDestructablesInRect(r, null, actionFunc);
        }

        public virtual boolean EnumDestructablesInCircleBJFilter()
        {
            location destLoc = GetDestructableLoc(GetFilterDestructable());
            boolean result = false;
            result = DistanceBetweenPoints(destLoc, bj_enumDestructableCenter) <= bj_enumDestructableRadius;
            RemoveLocation(destLoc);
            return result;
        }

        public virtual boolean IsDestructableDeadBJ(destructable d)
        {
            return GetDestructableLife(d) <= 0;
        }

        public virtual boolean IsDestructableAliveBJ(destructable d)
        {
            return !IsDestructableDeadBJ(d);
        }

        public virtual void RandomDestructableInRectBJEnum()
        {
            bj_destRandomConsidered = bj_destRandomConsidered + 1;
            if ((GetRandomInt(1, bj_destRandomConsidered) == 1))
            {
                bj_destRandomCurrentPick = GetEnumDestructable();
            }
        }

        public virtual destructable RandomDestructableInRectBJ(rect r, boolexpr filter)
        {
            bj_destRandomConsidered = 0;
            bj_destRandomCurrentPick = null;
            EnumDestructablesInRect(r, filter, RandomDestructableInRectBJEnum);
            DestroyBoolExpr(filter);
            return bj_destRandomCurrentPick;
        }

        public virtual destructable RandomDestructableInRectSimpleBJ(rect r)
        {
            return RandomDestructableInRectBJ(r, null);
        }

        public virtual void EnumDestructablesInCircleBJ(real radius, location loc, Action actionFunc)
        {
            rect r;
            if ((radius >= 0))
            {
                bj_enumDestructableCenter = loc;
                bj_enumDestructableRadius = radius;
                r = GetRectFromCircleBJ(loc, radius);
                EnumDestructablesInRect(r, filterEnumDestructablesInCircleBJ, actionFunc);
                RemoveRect(r);
            }
        }

        public virtual void SetDestructableLifePercentBJ(destructable d, real percent)
        {
            SetDestructableLife(d, GetDestructableMaxLife(d) * percent * 0.01f);
        }

        public virtual void SetDestructableMaxLifeBJ(destructable d, real max)
        {
            SetDestructableMaxLife(d, max);
        }

        public virtual void ModifyGateBJ(integer gateOperation, destructable d)
        {
            if ((gateOperation == bj_GATEOPERATION_CLOSE))
            {
                if ((GetDestructableLife(d) <= 0))
                {
                    DestructableRestoreLife(d, GetDestructableMaxLife(d), true);
                }
                SetDestructableAnimation(d, "stand");
            }
            else
            {
                if ((gateOperation == bj_GATEOPERATION_OPEN))
                {
                    if ((GetDestructableLife(d) > 0))
                    {
                        KillDestructable(d);
                    }
                    SetDestructableAnimation(d, "death alternate");
                }
                else
                {
                    if ((gateOperation == bj_GATEOPERATION_DESTROY))
                    {
                        if ((GetDestructableLife(d) > 0))
                        {
                            KillDestructable(d);
                        }
                        SetDestructableAnimation(d, "death");
                    }
                }
            }
        }

        public virtual integer GetElevatorHeight(destructable d)
        {
            integer height = 0;
            height = 1 + R2I(GetDestructableOccluderHeight(d) / bj_CLIFFHEIGHT);
            if ((height < 1) || (height > 3))
            {
                height = 1;
            }
            return height;
        }

        public virtual void ChangeElevatorHeight(destructable d, integer newHeight)
        {
            integer oldHeight = 0;
            newHeight = IMaxBJ(1, newHeight);
            newHeight = IMinBJ(3, newHeight);
            oldHeight = GetElevatorHeight(d);
            SetDestructableOccluderHeight(d, bj_CLIFFHEIGHT * (newHeight - 1));
            if ((newHeight == 1))
            {
                if ((oldHeight == 2))
                {
                    SetDestructableAnimation(d, "birth");
                    QueueDestructableAnimation(d, "stand");
                }
                else
                {
                    if ((oldHeight == 3))
                    {
                        SetDestructableAnimation(d, "birth third");
                        QueueDestructableAnimation(d, "stand");
                    }
                    else
                    {
                        SetDestructableAnimation(d, "stand");
                    }
                }
            }
            else
            {
                if ((newHeight == 2))
                {
                    if ((oldHeight == 1))
                    {
                        SetDestructableAnimation(d, "death");
                        QueueDestructableAnimation(d, "stand second");
                    }
                    else
                    {
                        if ((oldHeight == 3))
                        {
                            SetDestructableAnimation(d, "birth second");
                            QueueDestructableAnimation(d, "stand second");
                        }
                        else
                        {
                            SetDestructableAnimation(d, "stand second");
                        }
                    }
                }
                else
                {
                    if ((newHeight == 3))
                    {
                        if ((oldHeight == 1))
                        {
                            SetDestructableAnimation(d, "death third");
                            QueueDestructableAnimation(d, "stand third");
                        }
                        else
                        {
                            if ((oldHeight == 2))
                            {
                                SetDestructableAnimation(d, "death second");
                                QueueDestructableAnimation(d, "stand third");
                            }
                            else
                            {
                                SetDestructableAnimation(d, "stand third");
                            }
                        }
                    }
                }
            }
        }

        public virtual void NudgeUnitsInRectEnum()
        {
            unit nudgee = GetEnumUnit();
            SetUnitPosition(nudgee, GetUnitX(nudgee), GetUnitY(nudgee));
        }

        public virtual void NudgeItemsInRectEnum()
        {
            item nudgee = GetEnumItem();
            SetItemPosition(nudgee, GetItemX(nudgee), GetItemY(nudgee));
        }

        public virtual void NudgeObjectsInRect(rect nudgeArea)
        {
            group g;
            g = CreateGroup();
            GroupEnumUnitsInRect(g, nudgeArea, null);
            ForGroup(g, NudgeUnitsInRectEnum);
            DestroyGroup(g);
            EnumItemsInRect(nudgeArea, null, NudgeItemsInRectEnum);
        }

        public virtual void NearbyElevatorExistsEnum()
        {
            destructable d = GetEnumDestructable();
            integer dType = GetDestructableTypeId(d);
            if ((dType == bj_ELEVATOR_CODE01) || (dType == bj_ELEVATOR_CODE02))
            {
                bj_elevatorNeighbor = d;
            }
        }

        public virtual boolean NearbyElevatorExists(real x, real y)
        {
            real findThreshold = 32;
            rect r;
            r = Rect(x - findThreshold, y - findThreshold, x + findThreshold, y + findThreshold);
            bj_elevatorNeighbor = null;
            EnumDestructablesInRect(r, null, NearbyElevatorExistsEnum);
            RemoveRect(r);
            return bj_elevatorNeighbor != null;
        }

        public virtual void FindElevatorWallBlockerEnum()
        {
            bj_elevatorWallBlocker = GetEnumDestructable();
        }

        public virtual void ChangeElevatorWallBlocker(real x, real y, real facing, boolean open)
        {
            destructable blocker = null;
            real findThreshold = 32;
            real nudgeLength = 4.25f * bj_CELLWIDTH;
            real nudgeWidth = 1.25f * bj_CELLWIDTH;
            rect r;
            r = Rect(x - findThreshold, y - findThreshold, x + findThreshold, y + findThreshold);
            bj_elevatorWallBlocker = null;
            EnumDestructablesInRect(r, null, FindElevatorWallBlockerEnum);
            RemoveRect(r);
            blocker = bj_elevatorWallBlocker;
            if ((blocker == null))
            {
                blocker = CreateDeadDestructable(bj_ELEVATOR_BLOCKER_CODE, x, y, facing, 1, 0);
            }
            else
            {
                if ((GetDestructableTypeId(blocker) != bj_ELEVATOR_BLOCKER_CODE))
                {
                    return;
                }
            }
            if ((open))
            {
                if ((GetDestructableLife(blocker) > 0))
                {
                    KillDestructable(blocker);
                }
            }
            else
            {
                if ((GetDestructableLife(blocker) <= 0))
                {
                    DestructableRestoreLife(blocker, GetDestructableMaxLife(blocker), false);
                }
                if ((facing == 0))
                {
                    r = Rect(x - nudgeWidth / 2, y - nudgeLength / 2, x + nudgeWidth / 2, y + nudgeLength / 2);
                    NudgeObjectsInRect(r);
                    RemoveRect(r);
                }
                else
                {
                    if ((facing == 90))
                    {
                        r = Rect(x - nudgeLength / 2, y - nudgeWidth / 2, x + nudgeLength / 2, y + nudgeWidth / 2);
                        NudgeObjectsInRect(r);
                        RemoveRect(r);
                    }
                }
            }
        }

        public virtual void ChangeElevatorWalls(boolean open, integer walls, destructable d)
        {
            real x = GetDestructableX(d);
            real y = GetDestructableY(d);
            real distToBlocker = 192;
            real distToNeighbor = 256;
            if ((walls == bj_ELEVATOR_WALL_TYPE_ALL) || (walls == bj_ELEVATOR_WALL_TYPE_EAST))
            {
                if ((!NearbyElevatorExists(x + distToNeighbor, y)))
                {
                    ChangeElevatorWallBlocker(x + distToBlocker, y, 0, open);
                }
            }
            if ((walls == bj_ELEVATOR_WALL_TYPE_ALL) || (walls == bj_ELEVATOR_WALL_TYPE_NORTH))
            {
                if ((!NearbyElevatorExists(x, y + distToNeighbor)))
                {
                    ChangeElevatorWallBlocker(x, y + distToBlocker, 90, open);
                }
            }
            if ((walls == bj_ELEVATOR_WALL_TYPE_ALL) || (walls == bj_ELEVATOR_WALL_TYPE_SOUTH))
            {
                if ((!NearbyElevatorExists(x, y - distToNeighbor)))
                {
                    ChangeElevatorWallBlocker(x, y - distToBlocker, 90, open);
                }
            }
            if ((walls == bj_ELEVATOR_WALL_TYPE_ALL) || (walls == bj_ELEVATOR_WALL_TYPE_WEST))
            {
                if ((!NearbyElevatorExists(x - distToNeighbor, y)))
                {
                    ChangeElevatorWallBlocker(x - distToBlocker, y, 0, open);
                }
            }
        }

        public virtual void WaygateActivateBJ(boolean activate, unit waygate)
        {
            WaygateActivate(waygate, activate);
        }

        public virtual boolean WaygateIsActiveBJ(unit waygate)
        {
            return WaygateIsActive(waygate);
        }

        public virtual void WaygateSetDestinationLocBJ(unit waygate, location loc)
        {
            WaygateSetDestination(waygate, GetLocationX(loc), GetLocationY(loc));
        }

        public virtual location WaygateGetDestinationLocBJ(unit waygate)
        {
            return Location(WaygateGetDestinationX(waygate), WaygateGetDestinationY(waygate));
        }

        public virtual void UnitSetUsesAltIconBJ(boolean flag, unit whichUnit)
        {
            UnitSetUsesAltIcon(whichUnit, flag);
        }

        public virtual void ForceUIKeyBJ(player whichPlayer, @string key)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                ForceUIKey(key);
            }
        }

        public virtual void ForceUICancelBJ(player whichPlayer)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                ForceUICancel();
            }
        }

        public virtual void ForGroupBJ(group whichGroup, Action callback)
        {
            boolean wantDestroy = bj_wantDestroyGroup;
            bj_wantDestroyGroup = false;
            ForGroup(whichGroup, callback);
            if ((wantDestroy))
            {
                DestroyGroup(whichGroup);
            }
        }

        public virtual void GroupAddUnitSimple(unit whichUnit, group whichGroup)
        {
            GroupAddUnit(whichGroup, whichUnit);
        }

        public virtual void GroupRemoveUnitSimple(unit whichUnit, group whichGroup)
        {
            GroupRemoveUnit(whichGroup, whichUnit);
        }

        public virtual void GroupAddGroupEnum()
        {
            GroupAddUnit(bj_groupAddGroupDest, GetEnumUnit());
        }

        public virtual void GroupAddGroup(group sourceGroup, group destGroup)
        {
            boolean wantDestroy = bj_wantDestroyGroup;
            bj_wantDestroyGroup = false;
            bj_groupAddGroupDest = destGroup;
            ForGroup(sourceGroup, GroupAddGroupEnum);
            if ((wantDestroy))
            {
                DestroyGroup(sourceGroup);
            }
        }

        public virtual void GroupRemoveGroupEnum()
        {
            GroupRemoveUnit(bj_groupRemoveGroupDest, GetEnumUnit());
        }

        public virtual void GroupRemoveGroup(group sourceGroup, group destGroup)
        {
            boolean wantDestroy = bj_wantDestroyGroup;
            bj_wantDestroyGroup = false;
            bj_groupRemoveGroupDest = destGroup;
            ForGroup(sourceGroup, GroupRemoveGroupEnum);
            if ((wantDestroy))
            {
                DestroyGroup(sourceGroup);
            }
        }

        public virtual void ForceAddPlayerSimple(player whichPlayer, force whichForce)
        {
            ForceAddPlayer(whichForce, whichPlayer);
        }

        public virtual void ForceRemovePlayerSimple(player whichPlayer, force whichForce)
        {
            ForceRemovePlayer(whichForce, whichPlayer);
        }

        public virtual void GroupPickRandomUnitEnum()
        {
            bj_groupRandomConsidered = bj_groupRandomConsidered + 1;
            if ((GetRandomInt(1, bj_groupRandomConsidered) == 1))
            {
                bj_groupRandomCurrentPick = GetEnumUnit();
            }
        }

        public virtual unit GroupPickRandomUnit(group whichGroup)
        {
            boolean wantDestroy = bj_wantDestroyGroup;
            bj_wantDestroyGroup = false;
            bj_groupRandomConsidered = 0;
            bj_groupRandomCurrentPick = null;
            ForGroup(whichGroup, GroupPickRandomUnitEnum);
            if ((wantDestroy))
            {
                DestroyGroup(whichGroup);
            }
            return bj_groupRandomCurrentPick;
        }

        public virtual void ForcePickRandomPlayerEnum()
        {
            bj_forceRandomConsidered = bj_forceRandomConsidered + 1;
            if ((GetRandomInt(1, bj_forceRandomConsidered) == 1))
            {
                bj_forceRandomCurrentPick = GetEnumPlayer();
            }
        }

        public virtual player ForcePickRandomPlayer(force whichForce)
        {
            bj_forceRandomConsidered = 0;
            bj_forceRandomCurrentPick = null;
            ForForce(whichForce, ForcePickRandomPlayerEnum);
            return bj_forceRandomCurrentPick;
        }

        public virtual void EnumUnitsSelected(player whichPlayer, boolexpr enumFilter, Action enumAction)
        {
            group g = CreateGroup();
            SyncSelections();
            GroupEnumUnitsSelected(g, whichPlayer, enumFilter);
            DestroyBoolExpr(enumFilter);
            ForGroup(g, enumAction);
            DestroyGroup(g);
        }

        public virtual group GetUnitsInRectMatching(rect r, boolexpr filter)
        {
            group g = CreateGroup();
            GroupEnumUnitsInRect(g, r, filter);
            DestroyBoolExpr(filter);
            return g;
        }

        public virtual group GetUnitsInRectAll(rect r)
        {
            return GetUnitsInRectMatching(r, null);
        }

        public virtual boolean GetUnitsInRectOfPlayerFilter()
        {
            return GetOwningPlayer(GetFilterUnit()) == bj_groupEnumOwningPlayer;
        }

        public virtual group GetUnitsInRectOfPlayer(rect r, player whichPlayer)
        {
            group g = CreateGroup();
            bj_groupEnumOwningPlayer = whichPlayer;
            GroupEnumUnitsInRect(g, r, filterGetUnitsInRectOfPlayer);
            return g;
        }

        public virtual group GetUnitsInRangeOfLocMatching(real radius, location whichLocation, boolexpr filter)
        {
            group g = CreateGroup();
            GroupEnumUnitsInRangeOfLoc(g, whichLocation, radius, filter);
            DestroyBoolExpr(filter);
            return g;
        }

        public virtual group GetUnitsInRangeOfLocAll(real radius, location whichLocation)
        {
            return GetUnitsInRangeOfLocMatching(radius, whichLocation, null);
        }

        public virtual boolean GetUnitsOfTypeIdAllFilter()
        {
            return GetUnitTypeId(GetFilterUnit()) == bj_groupEnumTypeId;
        }

        public virtual group GetUnitsOfTypeIdAll(integer unitid)
        {
            group result = CreateGroup();
            group g = CreateGroup();
            integer index = 0;
            index = 0;
            for (
            ; true;
            )
            {
                bj_groupEnumTypeId = unitid;
                GroupClear(g);
                GroupEnumUnitsOfPlayer(g, Player(index), filterGetUnitsOfTypeIdAll);
                GroupAddGroup(g, result);
                index = index + 1;
                if (index == bj_MAX_PLAYER_SLOTS)
                {
                    break;
                }
            }
            DestroyGroup(g);
            return result;
        }

        public virtual group GetUnitsOfPlayerMatching(player whichPlayer, boolexpr filter)
        {
            group g = CreateGroup();
            GroupEnumUnitsOfPlayer(g, whichPlayer, filter);
            DestroyBoolExpr(filter);
            return g;
        }

        public virtual group GetUnitsOfPlayerAll(player whichPlayer)
        {
            return GetUnitsOfPlayerMatching(whichPlayer, null);
        }

        public virtual boolean GetUnitsOfPlayerAndTypeIdFilter()
        {
            return GetUnitTypeId(GetFilterUnit()) == bj_groupEnumTypeId;
        }

        public virtual group GetUnitsOfPlayerAndTypeId(player whichPlayer, integer unitid)
        {
            group g = CreateGroup();
            bj_groupEnumTypeId = unitid;
            GroupEnumUnitsOfPlayer(g, whichPlayer, filterGetUnitsOfPlayerAndTypeId);
            return g;
        }

        public virtual group GetUnitsSelectedAll(player whichPlayer)
        {
            group g = CreateGroup();
            SyncSelections();
            GroupEnumUnitsSelected(g, whichPlayer, null);
            return g;
        }

        public virtual force GetForceOfPlayer(player whichPlayer)
        {
            force f = CreateForce();
            ForceAddPlayer(f, whichPlayer);
            return f;
        }

        public virtual force GetPlayersAll()
        {
            return bj_FORCE_ALL_PLAYERS;
        }

        public virtual force GetPlayersByMapControl(mapcontrol whichControl)
        {
            force f = CreateForce();
            integer playerIndex = 0;
            player indexPlayer;
            playerIndex = 0;
            for (
            ; true;
            )
            {
                indexPlayer = Player(playerIndex);
                if (GetPlayerController(indexPlayer) == whichControl)
                {
                    ForceAddPlayer(f, indexPlayer);
                }
                playerIndex = playerIndex + 1;
                if (playerIndex == bj_MAX_PLAYER_SLOTS)
                {
                    break;
                }
            }
            return f;
        }

        public virtual force GetPlayersAllies(player whichPlayer)
        {
            force f = CreateForce();
            ForceEnumAllies(f, whichPlayer, null);
            return f;
        }

        public virtual force GetPlayersEnemies(player whichPlayer)
        {
            force f = CreateForce();
            ForceEnumEnemies(f, whichPlayer, null);
            return f;
        }

        public virtual force GetPlayersMatching(boolexpr filter)
        {
            force f = CreateForce();
            ForceEnumPlayers(f, filter);
            DestroyBoolExpr(filter);
            return f;
        }

        public virtual void CountUnitsInGroupEnum()
        {
            bj_groupCountUnits = bj_groupCountUnits + 1;
        }

        public virtual integer CountUnitsInGroup(group g)
        {
            boolean wantDestroy = bj_wantDestroyGroup;
            bj_wantDestroyGroup = false;
            bj_groupCountUnits = 0;
            ForGroup(g, CountUnitsInGroupEnum);
            if ((wantDestroy))
            {
                DestroyGroup(g);
            }
            return bj_groupCountUnits;
        }

        public virtual void CountPlayersInForceEnum()
        {
            bj_forceCountPlayers = bj_forceCountPlayers + 1;
        }

        public virtual integer CountPlayersInForceBJ(force f)
        {
            bj_forceCountPlayers = 0;
            ForForce(f, CountPlayersInForceEnum);
            return bj_forceCountPlayers;
        }

        public virtual void GetRandomSubGroupEnum()
        {
            if ((bj_randomSubGroupWant > 0))
            {
                if ((bj_randomSubGroupWant >= bj_randomSubGroupTotal) || (GetRandomReal(0, 1) < bj_randomSubGroupChance))
                {
                    GroupAddUnit(bj_randomSubGroupGroup, GetEnumUnit());
                    bj_randomSubGroupWant = bj_randomSubGroupWant - 1;
                }
            }
            bj_randomSubGroupTotal = bj_randomSubGroupTotal - 1;
        }

        public virtual group GetRandomSubGroup(integer count, group sourceGroup)
        {
            group g = CreateGroup();
            bj_randomSubGroupGroup = g;
            bj_randomSubGroupWant = count;
            bj_randomSubGroupTotal = CountUnitsInGroup(sourceGroup);
            if ((bj_randomSubGroupWant <= 0 || bj_randomSubGroupTotal <= 0))
            {
                return g;
            }
            bj_randomSubGroupChance = I2R(bj_randomSubGroupWant) / I2R(bj_randomSubGroupTotal);
            ForGroup(sourceGroup, GetRandomSubGroupEnum);
            return g;
        }

        public virtual boolean LivingPlayerUnitsOfTypeIdFilter()
        {
            unit filterUnit = GetFilterUnit();
            return IsUnitAliveBJ(filterUnit) && GetUnitTypeId(filterUnit) == bj_livingPlayerUnitsTypeId;
        }

        public virtual integer CountLivingPlayerUnitsOfTypeId(integer unitId, player whichPlayer)
        {
            group g;
            integer matchedCount = 0;
            g = CreateGroup();
            bj_livingPlayerUnitsTypeId = unitId;
            GroupEnumUnitsOfPlayer(g, whichPlayer, filterLivingPlayerUnitsOfTypeId);
            matchedCount = CountUnitsInGroup(g);
            DestroyGroup(g);
            return matchedCount;
        }

        public virtual void ResetUnitAnimation(unit whichUnit)
        {
            SetUnitAnimation(whichUnit, "stand");
        }

        public virtual void SetUnitTimeScalePercent(unit whichUnit, real percentScale)
        {
            SetUnitTimeScale(whichUnit, percentScale * 0.01f);
        }

        public virtual void SetUnitScalePercent(unit whichUnit, real percentScaleX, real percentScaleY, real percentScaleZ)
        {
            SetUnitScale(whichUnit, percentScaleX * 0.01f, percentScaleY * 0.01f, percentScaleZ * 0.01f);
        }

        public virtual void SetUnitVertexColorBJ(unit whichUnit, real red, real green, real blue, real transparency)
        {
            SetUnitVertexColor(whichUnit, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100f - transparency));
        }

        public virtual void UnitAddIndicatorBJ(unit whichUnit, real red, real green, real blue, real transparency)
        {
            AddIndicator(whichUnit, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100f - transparency));
        }

        public virtual void DestructableAddIndicatorBJ(destructable whichDestructable, real red, real green, real blue, real transparency)
        {
            AddIndicator(whichDestructable, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100f - transparency));
        }

        public virtual void ItemAddIndicatorBJ(item whichItem, real red, real green, real blue, real transparency)
        {
            AddIndicator(whichItem, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100f - transparency));
        }

        public virtual void SetUnitFacingToFaceLocTimed(unit whichUnit, location target, real duration)
        {
            location unitLoc = GetUnitLoc(whichUnit);
            SetUnitFacingTimed(whichUnit, AngleBetweenPoints(unitLoc, target), duration);
            RemoveLocation(unitLoc);
        }

        public virtual void SetUnitFacingToFaceUnitTimed(unit whichUnit, unit target, real duration)
        {
            location unitLoc = GetUnitLoc(target);
            SetUnitFacingToFaceLocTimed(whichUnit, unitLoc, duration);
            RemoveLocation(unitLoc);
        }

        public virtual void QueueUnitAnimationBJ(unit whichUnit, @string whichAnimation)
        {
            QueueUnitAnimation(whichUnit, whichAnimation);
        }

        public virtual void SetDestructableAnimationBJ(destructable d, @string whichAnimation)
        {
            SetDestructableAnimation(d, whichAnimation);
        }

        public virtual void QueueDestructableAnimationBJ(destructable d, @string whichAnimation)
        {
            QueueDestructableAnimation(d, whichAnimation);
        }

        public virtual void SetDestAnimationSpeedPercent(destructable d, real percentScale)
        {
            SetDestructableAnimationSpeed(d, percentScale * 0.01f);
        }

        public virtual void DialogDisplayBJ(boolean flag, dialog whichDialog, player whichPlayer)
        {
            DialogDisplay(whichPlayer, whichDialog, flag);
        }

        public virtual void DialogSetMessageBJ(dialog whichDialog, @string message)
        {
            DialogSetMessage(whichDialog, message);
        }

        public virtual button DialogAddButtonBJ(dialog whichDialog, @string buttonText)
        {
            bj_lastCreatedButton = DialogAddButton(whichDialog, buttonText, 0);
            return bj_lastCreatedButton;
        }

        public virtual button DialogAddButtonWithHotkeyBJ(dialog whichDialog, @string buttonText, integer hotkey)
        {
            bj_lastCreatedButton = DialogAddButton(whichDialog, buttonText, hotkey);
            return bj_lastCreatedButton;
        }

        public virtual void DialogClearBJ(dialog whichDialog)
        {
            DialogClear(whichDialog);
        }

        public virtual button GetLastCreatedButtonBJ()
        {
            return bj_lastCreatedButton;
        }

        public virtual button GetClickedButtonBJ()
        {
            return GetClickedButton();
        }

        public virtual dialog GetClickedDialogBJ()
        {
            return GetClickedDialog();
        }

        public virtual void SetPlayerAllianceBJ(player sourcePlayer, alliancetype whichAllianceSetting, boolean value, player otherPlayer)
        {
            if ((sourcePlayer == otherPlayer))
            {
                return;
            }
            SetPlayerAlliance(sourcePlayer, otherPlayer, whichAllianceSetting, value);
        }

        public virtual void SetPlayerAllianceStateAllyBJ(player sourcePlayer, player otherPlayer, boolean flag)
        {
            SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_PASSIVE, flag);
            SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_HELP_REQUEST, flag);
            SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_HELP_RESPONSE, flag);
            SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_SHARED_XP, flag);
            SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_SHARED_SPELLS, flag);
        }

        public virtual void SetPlayerAllianceStateVisionBJ(player sourcePlayer, player otherPlayer, boolean flag)
        {
            SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_SHARED_VISION, flag);
        }

        public virtual void SetPlayerAllianceStateControlBJ(player sourcePlayer, player otherPlayer, boolean flag)
        {
            SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_SHARED_CONTROL, flag);
        }

        public virtual void SetPlayerAllianceStateFullControlBJ(player sourcePlayer, player otherPlayer, boolean flag)
        {
            SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_SHARED_ADVANCED_CONTROL, flag);
        }

        public virtual void SetPlayerAllianceStateBJ(player sourcePlayer, player otherPlayer, integer allianceState)
        {
            if ((sourcePlayer == otherPlayer))
            {
                return;
            }
            if (allianceState == bj_ALLIANCE_UNALLIED)
            {
                SetPlayerAllianceStateAllyBJ(sourcePlayer, otherPlayer, false);
                SetPlayerAllianceStateVisionBJ(sourcePlayer, otherPlayer, false);
                SetPlayerAllianceStateControlBJ(sourcePlayer, otherPlayer, false);
                SetPlayerAllianceStateFullControlBJ(sourcePlayer, otherPlayer, false);
            }
            else
            {
                if (allianceState == bj_ALLIANCE_UNALLIED_VISION)
                {
                    SetPlayerAllianceStateAllyBJ(sourcePlayer, otherPlayer, false);
                    SetPlayerAllianceStateVisionBJ(sourcePlayer, otherPlayer, true);
                    SetPlayerAllianceStateControlBJ(sourcePlayer, otherPlayer, false);
                    SetPlayerAllianceStateFullControlBJ(sourcePlayer, otherPlayer, false);
                }
                else
                {
                    if (allianceState == bj_ALLIANCE_ALLIED)
                    {
                        SetPlayerAllianceStateAllyBJ(sourcePlayer, otherPlayer, true);
                        SetPlayerAllianceStateVisionBJ(sourcePlayer, otherPlayer, false);
                        SetPlayerAllianceStateControlBJ(sourcePlayer, otherPlayer, false);
                        SetPlayerAllianceStateFullControlBJ(sourcePlayer, otherPlayer, false);
                    }
                    else
                    {
                        if (allianceState == bj_ALLIANCE_ALLIED_VISION)
                        {
                            SetPlayerAllianceStateAllyBJ(sourcePlayer, otherPlayer, true);
                            SetPlayerAllianceStateVisionBJ(sourcePlayer, otherPlayer, true);
                            SetPlayerAllianceStateControlBJ(sourcePlayer, otherPlayer, false);
                            SetPlayerAllianceStateFullControlBJ(sourcePlayer, otherPlayer, false);
                        }
                        else
                        {
                            if (allianceState == bj_ALLIANCE_ALLIED_UNITS)
                            {
                                SetPlayerAllianceStateAllyBJ(sourcePlayer, otherPlayer, true);
                                SetPlayerAllianceStateVisionBJ(sourcePlayer, otherPlayer, true);
                                SetPlayerAllianceStateControlBJ(sourcePlayer, otherPlayer, true);
                                SetPlayerAllianceStateFullControlBJ(sourcePlayer, otherPlayer, false);
                            }
                            else
                            {
                                if (allianceState == bj_ALLIANCE_ALLIED_ADVUNITS)
                                {
                                    SetPlayerAllianceStateAllyBJ(sourcePlayer, otherPlayer, true);
                                    SetPlayerAllianceStateVisionBJ(sourcePlayer, otherPlayer, true);
                                    SetPlayerAllianceStateControlBJ(sourcePlayer, otherPlayer, true);
                                    SetPlayerAllianceStateFullControlBJ(sourcePlayer, otherPlayer, true);
                                }
                                else
                                {
                                    if (allianceState == bj_ALLIANCE_NEUTRAL)
                                    {
                                        SetPlayerAllianceStateAllyBJ(sourcePlayer, otherPlayer, false);
                                        SetPlayerAllianceStateVisionBJ(sourcePlayer, otherPlayer, false);
                                        SetPlayerAllianceStateControlBJ(sourcePlayer, otherPlayer, false);
                                        SetPlayerAllianceStateFullControlBJ(sourcePlayer, otherPlayer, false);
                                        SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_PASSIVE, true);
                                    }
                                    else
                                    {
                                        if (allianceState == bj_ALLIANCE_NEUTRAL_VISION)
                                        {
                                            SetPlayerAllianceStateAllyBJ(sourcePlayer, otherPlayer, false);
                                            SetPlayerAllianceStateVisionBJ(sourcePlayer, otherPlayer, true);
                                            SetPlayerAllianceStateControlBJ(sourcePlayer, otherPlayer, false);
                                            SetPlayerAllianceStateFullControlBJ(sourcePlayer, otherPlayer, false);
                                            SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_PASSIVE, true);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public virtual void SetForceAllianceStateBJ(force sourceForce, force targetForce, integer allianceState)
        {
            integer sourceIndex = 0;
            integer targetIndex = 0;
            sourceIndex = 0;
            for (
            ; true;
            )
            {
                if ((sourceForce == bj_FORCE_ALL_PLAYERS || IsPlayerInForce(Player(sourceIndex), sourceForce)))
                {
                    targetIndex = 0;
                    for (
                    ; true;
                    )
                    {
                        if ((targetForce == bj_FORCE_ALL_PLAYERS || IsPlayerInForce(Player(targetIndex), targetForce)))
                        {
                            SetPlayerAllianceStateBJ(Player(sourceIndex), Player(targetIndex), allianceState);
                        }
                        targetIndex = targetIndex + 1;
                        if (targetIndex == bj_MAX_PLAYER_SLOTS)
                        {
                            break;
                        }
                    }
                }
                sourceIndex = sourceIndex + 1;
                if (sourceIndex == bj_MAX_PLAYER_SLOTS)
                {
                    break;
                }
            }
        }

        public virtual boolean PlayersAreCoAllied(player playerA, player playerB)
        {
            if ((playerA == playerB))
            {
                return true;
            }
            if (GetPlayerAlliance(playerA, playerB, ALLIANCE_PASSIVE))
            {
                if (GetPlayerAlliance(playerB, playerA, ALLIANCE_PASSIVE))
                {
                    return true;
                }
            }
            return false;
        }

        public virtual void ShareEverythingWithTeamAI(player whichPlayer)
        {
            integer playerIndex = 0;
            player indexPlayer;
            playerIndex = 0;
            for (
            ; true;
            )
            {
                indexPlayer = Player(playerIndex);
                if ((PlayersAreCoAllied(whichPlayer, indexPlayer) && whichPlayer != indexPlayer))
                {
                    if ((GetPlayerController(indexPlayer) == MAP_CONTROL_COMPUTER))
                    {
                        SetPlayerAlliance(whichPlayer, indexPlayer, ALLIANCE_SHARED_VISION, true);
                        SetPlayerAlliance(whichPlayer, indexPlayer, ALLIANCE_SHARED_CONTROL, true);
                        SetPlayerAlliance(whichPlayer, indexPlayer, ALLIANCE_SHARED_ADVANCED_CONTROL, true);
                    }
                }
                playerIndex = playerIndex + 1;
                if (playerIndex == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
        }

        public virtual void ShareEverythingWithTeam(player whichPlayer)
        {
            integer playerIndex = 0;
            player indexPlayer;
            playerIndex = 0;
            for (
            ; true;
            )
            {
                indexPlayer = Player(playerIndex);
                if ((PlayersAreCoAllied(whichPlayer, indexPlayer) && whichPlayer != indexPlayer))
                {
                    SetPlayerAlliance(whichPlayer, indexPlayer, ALLIANCE_SHARED_VISION, true);
                    SetPlayerAlliance(whichPlayer, indexPlayer, ALLIANCE_SHARED_CONTROL, true);
                    SetPlayerAlliance(indexPlayer, whichPlayer, ALLIANCE_SHARED_CONTROL, true);
                    SetPlayerAlliance(whichPlayer, indexPlayer, ALLIANCE_SHARED_ADVANCED_CONTROL, true);
                }
                playerIndex = playerIndex + 1;
                if (playerIndex == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
        }

        public virtual void ConfigureNeutralVictim()
        {
            integer index = 0;
            player indexPlayer;
            player neutralVictim = Player(bj_PLAYER_NEUTRAL_VICTIM);
            index = 0;
            for (
            ; true;
            )
            {
                indexPlayer = Player(index);
                SetPlayerAlliance(neutralVictim, indexPlayer, ALLIANCE_PASSIVE, true);
                SetPlayerAlliance(indexPlayer, neutralVictim, ALLIANCE_PASSIVE, false);
                index = index + 1;
                if (index == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
            indexPlayer = Player(PLAYER_NEUTRAL_AGGRESSIVE);
            SetPlayerAlliance(neutralVictim, indexPlayer, ALLIANCE_PASSIVE, true);
            SetPlayerAlliance(indexPlayer, neutralVictim, ALLIANCE_PASSIVE, true);
            SetPlayerState(neutralVictim, PLAYER_STATE_GIVES_BOUNTY, 0);
        }

        public virtual void MakeUnitsPassiveForPlayerEnum()
        {
            SetUnitOwner(GetEnumUnit(), Player(bj_PLAYER_NEUTRAL_VICTIM), false);
        }

        public virtual void MakeUnitsPassiveForPlayer(player whichPlayer)
        {
            group playerUnits = CreateGroup();
            CachePlayerHeroData(whichPlayer);
            GroupEnumUnitsOfPlayer(playerUnits, whichPlayer, null);
            ForGroup(playerUnits, MakeUnitsPassiveForPlayerEnum);
            DestroyGroup(playerUnits);
        }

        public virtual void MakeUnitsPassiveForTeam(player whichPlayer)
        {
            integer playerIndex = 0;
            player indexPlayer;
            playerIndex = 0;
            for (
            ; true;
            )
            {
                indexPlayer = Player(playerIndex);
                if (PlayersAreCoAllied(whichPlayer, indexPlayer))
                {
                    MakeUnitsPassiveForPlayer(indexPlayer);
                }
                playerIndex = playerIndex + 1;
                if (playerIndex == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
        }

        public virtual boolean AllowVictoryDefeat(playergameresult gameResult)
        {
            if ((gameResult == PLAYER_GAME_RESULT_VICTORY))
            {
                return !IsNoVictoryCheat();
            }
            if ((gameResult == PLAYER_GAME_RESULT_DEFEAT))
            {
                return !IsNoDefeatCheat();
            }
            if ((gameResult == PLAYER_GAME_RESULT_NEUTRAL))
            {
                return (!IsNoVictoryCheat()) && (!IsNoDefeatCheat());
            }
            return true;
        }

        public virtual void EndGameBJ()
        {
            EndGame(true);
        }

        public virtual void MeleeVictoryDialogBJ(player whichPlayer, boolean leftGame)
        {
            trigger t = CreateTrigger();
            dialog d = DialogCreate();
            @string formatString;
            if ((leftGame))
            {
                formatString = GetLocalizedString("PLAYER_LEFT_GAME");
            }
            else
            {
                formatString = GetLocalizedString("PLAYER_VICTORIOUS");
            }
            DisplayTimedTextFromPlayer(whichPlayer, 0, 0, 60, formatString);
            DialogSetMessage(d, GetLocalizedString("GAMEOVER_VICTORY_MSG"));
            DialogAddButton(d, GetLocalizedString("GAMEOVER_CONTINUE_GAME"), GetLocalizedHotkey("GAMEOVER_CONTINUE_GAME"));
            t = CreateTrigger();
            TriggerRegisterDialogButtonEvent(t, DialogAddQuitButton(d, true, GetLocalizedString("GAMEOVER_QUIT_GAME"), GetLocalizedHotkey("GAMEOVER_QUIT_GAME")));
            DialogDisplay(whichPlayer, d, true);
            StartSoundForPlayerBJ(whichPlayer, bj_victoryDialogSound);
        }

        public virtual void MeleeDefeatDialogBJ(player whichPlayer, boolean leftGame)
        {
            trigger t = CreateTrigger();
            dialog d = DialogCreate();
            @string formatString;
            if ((leftGame))
            {
                formatString = GetLocalizedString("PLAYER_LEFT_GAME");
            }
            else
            {
                formatString = GetLocalizedString("PLAYER_DEFEATED");
            }
            DisplayTimedTextFromPlayer(whichPlayer, 0, 0, 60, formatString);
            DialogSetMessage(d, GetLocalizedString("GAMEOVER_DEFEAT_MSG"));
            if ((!bj_meleeGameOver && IsMapFlagSet(MAP_OBSERVERS_ON_DEATH)))
            {
                DialogAddButton(d, GetLocalizedString("GAMEOVER_CONTINUE_OBSERVING"), GetLocalizedHotkey("GAMEOVER_CONTINUE_OBSERVING"));
            }
            t = CreateTrigger();
            TriggerRegisterDialogButtonEvent(t, DialogAddQuitButton(d, true, GetLocalizedString("GAMEOVER_QUIT_GAME"), GetLocalizedHotkey("GAMEOVER_QUIT_GAME")));
            DialogDisplay(whichPlayer, d, true);
            StartSoundForPlayerBJ(whichPlayer, bj_defeatDialogSound);
        }

        public virtual void GameOverDialogBJ(player whichPlayer, boolean leftGame)
        {
            trigger t = CreateTrigger();
            dialog d = DialogCreate();
            @string s;
            DisplayTimedTextFromPlayer(whichPlayer, 0, 0, 60, GetLocalizedString("PLAYER_LEFT_GAME"));
            if ((GetIntegerGameState(GAME_STATE_DISCONNECTED) != 0))
            {
                s = GetLocalizedString("GAMEOVER_DISCONNECTED");
            }
            else
            {
                s = GetLocalizedString("GAMEOVER_GAME_OVER");
            }
            DialogSetMessage(d, s);
            t = CreateTrigger();
            TriggerRegisterDialogButtonEvent(t, DialogAddQuitButton(d, true, GetLocalizedString("GAMEOVER_OK"), GetLocalizedHotkey("GAMEOVER_OK")));
            DialogDisplay(whichPlayer, d, true);
            StartSoundForPlayerBJ(whichPlayer, bj_defeatDialogSound);
        }

        public virtual void RemovePlayerPreserveUnitsBJ(player whichPlayer, playergameresult gameResult, boolean leftGame)
        {
            if (AllowVictoryDefeat(gameResult))
            {
                RemovePlayer(whichPlayer, gameResult);
                if ((gameResult == PLAYER_GAME_RESULT_VICTORY))
                {
                    MeleeVictoryDialogBJ(whichPlayer, leftGame);
                    return;
                }
                else
                {
                    if ((gameResult == PLAYER_GAME_RESULT_DEFEAT))
                    {
                        MeleeDefeatDialogBJ(whichPlayer, leftGame);
                    }
                    else
                    {
                        GameOverDialogBJ(whichPlayer, leftGame);
                    }
                }
            }
        }

        public virtual void CustomVictoryOkBJ()
        {
            if (bj_isSinglePlayer)
            {
                PauseGame(false);
                SetGameDifficulty(GetDefaultDifficulty());
            }
            if ((bj_changeLevelMapName == null))
            {
                EndGame(bj_changeLevelShowScores);
            }
            else
            {
                ChangeLevel(bj_changeLevelMapName, bj_changeLevelShowScores);
            }
        }

        public virtual void CustomVictoryQuitBJ()
        {
            if (bj_isSinglePlayer)
            {
                PauseGame(false);
                SetGameDifficulty(GetDefaultDifficulty());
            }
            EndGame(bj_changeLevelShowScores);
        }

        public virtual void CustomVictoryDialogBJ(player whichPlayer)
        {
            trigger t = CreateTrigger();
            dialog d = DialogCreate();
            DialogSetMessage(d, GetLocalizedString("GAMEOVER_VICTORY_MSG"));
            t = CreateTrigger();
            TriggerRegisterDialogButtonEvent(t, DialogAddButton(d, GetLocalizedString("GAMEOVER_CONTINUE"), GetLocalizedHotkey("GAMEOVER_CONTINUE")));
            TriggerAddAction(t, CustomVictoryOkBJ);
            t = CreateTrigger();
            TriggerRegisterDialogButtonEvent(t, DialogAddButton(d, GetLocalizedString("GAMEOVER_QUIT_MISSION"), GetLocalizedHotkey("GAMEOVER_QUIT_MISSION")));
            TriggerAddAction(t, CustomVictoryQuitBJ);
            if ((GetLocalPlayer() == whichPlayer))
            {
                EnableUserControl(true);
                if (bj_isSinglePlayer)
                {
                    PauseGame(true);
                }
                EnableUserUI(false);
            }
            DialogDisplay(whichPlayer, d, true);
            VolumeGroupSetVolumeForPlayerBJ(whichPlayer, SOUND_VOLUMEGROUP_UI, 1f);
            StartSoundForPlayerBJ(whichPlayer, bj_victoryDialogSound);
        }

        public virtual void CustomVictorySkipBJ(player whichPlayer)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                if (bj_isSinglePlayer)
                {
                    SetGameDifficulty(GetDefaultDifficulty());
                }
                if ((bj_changeLevelMapName == null))
                {
                    EndGame(bj_changeLevelShowScores);
                }
                else
                {
                    ChangeLevel(bj_changeLevelMapName, bj_changeLevelShowScores);
                }
            }
        }

        public virtual void CustomVictoryBJ(player whichPlayer, boolean showDialog, boolean showScores)
        {
            if (AllowVictoryDefeat(PLAYER_GAME_RESULT_VICTORY))
            {
                RemovePlayer(whichPlayer, PLAYER_GAME_RESULT_VICTORY);
                if (!bj_isSinglePlayer)
                {
                    DisplayTimedTextFromPlayer(whichPlayer, 0, 0, 60, GetLocalizedString("PLAYER_VICTORIOUS"));
                }
                if ((GetPlayerController(whichPlayer) == MAP_CONTROL_USER))
                {
                    bj_changeLevelShowScores = showScores;
                    if (showDialog)
                    {
                        CustomVictoryDialogBJ(whichPlayer);
                    }
                    else
                    {
                        CustomVictorySkipBJ(whichPlayer);
                    }
                }
            }
        }

        public virtual void CustomDefeatRestartBJ()
        {
            PauseGame(false);
            RestartGame(true);
        }

        public virtual void CustomDefeatReduceDifficultyBJ()
        {
            gamedifficulty diff = GetGameDifficulty();
            PauseGame(false);
            if ((diff == MAP_DIFFICULTY_EASY))
            {
            }
            else
            {
                if ((diff == MAP_DIFFICULTY_NORMAL))
                {
                    SetGameDifficulty(MAP_DIFFICULTY_EASY);
                }
                else
                {
                    if ((diff == MAP_DIFFICULTY_HARD))
                    {
                        SetGameDifficulty(MAP_DIFFICULTY_NORMAL);
                    }
                }
            }
            RestartGame(true);
        }

        public virtual void CustomDefeatLoadBJ()
        {
            PauseGame(false);
            DisplayLoadDialog();
        }

        public virtual void CustomDefeatQuitBJ()
        {
            if (bj_isSinglePlayer)
            {
                PauseGame(false);
            }
            SetGameDifficulty(GetDefaultDifficulty());
            EndGame(true);
        }

        public virtual void CustomDefeatDialogBJ(player whichPlayer, @string message)
        {
            trigger t = CreateTrigger();
            dialog d = DialogCreate();
            DialogSetMessage(d, message);
            if (bj_isSinglePlayer)
            {
                t = CreateTrigger();
                TriggerRegisterDialogButtonEvent(t, DialogAddButton(d, GetLocalizedString("GAMEOVER_RESTART"), GetLocalizedHotkey("GAMEOVER_RESTART")));
                TriggerAddAction(t, CustomDefeatRestartBJ);
                if ((GetGameDifficulty() != MAP_DIFFICULTY_EASY))
                {
                    t = CreateTrigger();
                    TriggerRegisterDialogButtonEvent(t, DialogAddButton(d, GetLocalizedString("GAMEOVER_REDUCE_DIFFICULTY"), GetLocalizedHotkey("GAMEOVER_REDUCE_DIFFICULTY")));
                    TriggerAddAction(t, CustomDefeatReduceDifficultyBJ);
                }
                t = CreateTrigger();
                TriggerRegisterDialogButtonEvent(t, DialogAddButton(d, GetLocalizedString("GAMEOVER_LOAD"), GetLocalizedHotkey("GAMEOVER_LOAD")));
                TriggerAddAction(t, CustomDefeatLoadBJ);
            }
            t = CreateTrigger();
            TriggerRegisterDialogButtonEvent(t, DialogAddButton(d, GetLocalizedString("GAMEOVER_QUIT_MISSION"), GetLocalizedHotkey("GAMEOVER_QUIT_MISSION")));
            TriggerAddAction(t, CustomDefeatQuitBJ);
            if ((GetLocalPlayer() == whichPlayer))
            {
                EnableUserControl(true);
                if (bj_isSinglePlayer)
                {
                    PauseGame(true);
                }
                EnableUserUI(false);
            }
            DialogDisplay(whichPlayer, d, true);
            VolumeGroupSetVolumeForPlayerBJ(whichPlayer, SOUND_VOLUMEGROUP_UI, 1f);
            StartSoundForPlayerBJ(whichPlayer, bj_defeatDialogSound);
        }

        public virtual void CustomDefeatBJ(player whichPlayer, @string message)
        {
            if (AllowVictoryDefeat(PLAYER_GAME_RESULT_DEFEAT))
            {
                RemovePlayer(whichPlayer, PLAYER_GAME_RESULT_DEFEAT);
                if (!bj_isSinglePlayer)
                {
                    DisplayTimedTextFromPlayer(whichPlayer, 0, 0, 60, GetLocalizedString("PLAYER_DEFEATED"));
                }
                if ((GetPlayerController(whichPlayer) == MAP_CONTROL_USER))
                {
                    CustomDefeatDialogBJ(whichPlayer, message);
                }
            }
        }

        public virtual void SetNextLevelBJ(@string nextLevel)
        {
            if ((nextLevel == ""))
            {
                bj_changeLevelMapName = null;
            }
            else
            {
                bj_changeLevelMapName = nextLevel;
            }
        }

        public virtual void SetPlayerOnScoreScreenBJ(boolean flag, player whichPlayer)
        {
            SetPlayerOnScoreScreen(whichPlayer, flag);
        }

        public virtual quest CreateQuestBJ(integer questType, @string title, @string description, @string iconPath)
        {
            boolean required = (questType == bj_QUESTTYPE_REQ_DISCOVERED) || (questType == bj_QUESTTYPE_REQ_UNDISCOVERED);
            boolean discovered = (questType == bj_QUESTTYPE_REQ_DISCOVERED) || (questType == bj_QUESTTYPE_OPT_DISCOVERED);
            bj_lastCreatedQuest = CreateQuest();
            QuestSetTitle(bj_lastCreatedQuest, title);
            QuestSetDescription(bj_lastCreatedQuest, description);
            QuestSetIconPath(bj_lastCreatedQuest, iconPath);
            QuestSetRequired(bj_lastCreatedQuest, required);
            QuestSetDiscovered(bj_lastCreatedQuest, discovered);
            QuestSetCompleted(bj_lastCreatedQuest, false);
            return bj_lastCreatedQuest;
        }

        public virtual void DestroyQuestBJ(quest whichQuest)
        {
            DestroyQuest(whichQuest);
        }

        public virtual void QuestSetEnabledBJ(boolean enabled, quest whichQuest)
        {
            QuestSetEnabled(whichQuest, enabled);
        }

        public virtual void QuestSetTitleBJ(quest whichQuest, @string title)
        {
            QuestSetTitle(whichQuest, title);
        }

        public virtual void QuestSetDescriptionBJ(quest whichQuest, @string description)
        {
            QuestSetDescription(whichQuest, description);
        }

        public virtual void QuestSetCompletedBJ(quest whichQuest, boolean completed)
        {
            QuestSetCompleted(whichQuest, completed);
        }

        public virtual void QuestSetFailedBJ(quest whichQuest, boolean failed)
        {
            QuestSetFailed(whichQuest, failed);
        }

        public virtual void QuestSetDiscoveredBJ(quest whichQuest, boolean discovered)
        {
            QuestSetDiscovered(whichQuest, discovered);
        }

        public virtual quest GetLastCreatedQuestBJ()
        {
            return bj_lastCreatedQuest;
        }

        public virtual questitem CreateQuestItemBJ(quest whichQuest, @string description)
        {
            bj_lastCreatedQuestItem = QuestCreateItem(whichQuest);
            QuestItemSetDescription(bj_lastCreatedQuestItem, description);
            QuestItemSetCompleted(bj_lastCreatedQuestItem, false);
            return bj_lastCreatedQuestItem;
        }

        public virtual void QuestItemSetDescriptionBJ(questitem whichQuestItem, @string description)
        {
            QuestItemSetDescription(whichQuestItem, description);
        }

        public virtual void QuestItemSetCompletedBJ(questitem whichQuestItem, boolean completed)
        {
            QuestItemSetCompleted(whichQuestItem, completed);
        }

        public virtual questitem GetLastCreatedQuestItemBJ()
        {
            return bj_lastCreatedQuestItem;
        }

        public virtual defeatcondition CreateDefeatConditionBJ(@string description)
        {
            bj_lastCreatedDefeatCondition = CreateDefeatCondition();
            DefeatConditionSetDescription(bj_lastCreatedDefeatCondition, description);
            return bj_lastCreatedDefeatCondition;
        }

        public virtual void DestroyDefeatConditionBJ(defeatcondition whichCondition)
        {
            DestroyDefeatCondition(whichCondition);
        }

        public virtual void DefeatConditionSetDescriptionBJ(defeatcondition whichCondition, @string description)
        {
            DefeatConditionSetDescription(whichCondition, description);
        }

        public virtual defeatcondition GetLastCreatedDefeatConditionBJ()
        {
            return bj_lastCreatedDefeatCondition;
        }

        public virtual void FlashQuestDialogButtonBJ()
        {
            FlashQuestDialogButton();
        }

        public virtual void QuestMessageBJ(force f, integer messageType, @string message)
        {
            if ((IsPlayerInForce(GetLocalPlayer(), f)))
            {
                if ((messageType == bj_QUESTMESSAGE_DISCOVERED))
                {
                    DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUEST, " ");
                    DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUEST, message);
                    StartSound(bj_questDiscoveredSound);
                    FlashQuestDialogButton();
                }
                else
                {
                    if ((messageType == bj_QUESTMESSAGE_UPDATED))
                    {
                        DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUESTUPDATE, " ");
                        DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUESTUPDATE, message);
                        StartSound(bj_questUpdatedSound);
                        FlashQuestDialogButton();
                    }
                    else
                    {
                        if ((messageType == bj_QUESTMESSAGE_COMPLETED))
                        {
                            DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUESTDONE, " ");
                            DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUESTDONE, message);
                            StartSound(bj_questCompletedSound);
                            FlashQuestDialogButton();
                        }
                        else
                        {
                            if ((messageType == bj_QUESTMESSAGE_FAILED))
                            {
                                DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUESTFAILED, " ");
                                DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUESTFAILED, message);
                                StartSound(bj_questFailedSound);
                                FlashQuestDialogButton();
                            }
                            else
                            {
                                if ((messageType == bj_QUESTMESSAGE_REQUIREMENT))
                                {
                                    DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUESTREQUIREMENT, message);
                                }
                                else
                                {
                                    if ((messageType == bj_QUESTMESSAGE_MISSIONFAILED))
                                    {
                                        DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_MISSIONFAILED, " ");
                                        DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_MISSIONFAILED, message);
                                        StartSound(bj_questFailedSound);
                                    }
                                    else
                                    {
                                        if ((messageType == bj_QUESTMESSAGE_HINT))
                                        {
                                            DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_HINT, " ");
                                            DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_HINT, message);
                                            StartSound(bj_questHintSound);
                                        }
                                        else
                                        {
                                            if ((messageType == bj_QUESTMESSAGE_ALWAYSHINT))
                                            {
                                                DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_ALWAYSHINT, " ");
                                                DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_ALWAYSHINT, message);
                                                StartSound(bj_questHintSound);
                                            }
                                            else
                                            {
                                                if ((messageType == bj_QUESTMESSAGE_SECRET))
                                                {
                                                    DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_SECRET, " ");
                                                    DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_SECRET, message);
                                                    StartSound(bj_questSecretSound);
                                                }
                                                else
                                                {
                                                    if ((messageType == bj_QUESTMESSAGE_UNITACQUIRED))
                                                    {
                                                        DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_UNITACQUIRED, " ");
                                                        DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_UNITACQUIRED, message);
                                                        StartSound(bj_questHintSound);
                                                    }
                                                    else
                                                    {
                                                        if ((messageType == bj_QUESTMESSAGE_UNITAVAILABLE))
                                                        {
                                                            DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_UNITAVAILABLE, " ");
                                                            DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_UNITAVAILABLE, message);
                                                            StartSound(bj_questHintSound);
                                                        }
                                                        else
                                                        {
                                                            if ((messageType == bj_QUESTMESSAGE_ITEMACQUIRED))
                                                            {
                                                                DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_ITEMACQUIRED, " ");
                                                                DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_ITEMACQUIRED, message);
                                                                StartSound(bj_questItemAcquiredSound);
                                                            }
                                                            else
                                                            {
                                                                if ((messageType == bj_QUESTMESSAGE_WARNING))
                                                                {
                                                                    DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_WARNING, " ");
                                                                    DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_WARNING, message);
                                                                    StartSound(bj_questWarningSound);
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public virtual timer StartTimerBJ(timer t, boolean periodic, real timeout)
        {
            bj_lastStartedTimer = t;
            TimerStart(t, timeout, periodic, null);
            return bj_lastStartedTimer;
        }

        public virtual timer CreateTimerBJ(boolean periodic, real timeout)
        {
            bj_lastStartedTimer = CreateTimer();
            TimerStart(bj_lastStartedTimer, timeout, periodic, null);
            return bj_lastStartedTimer;
        }

        public virtual void DestroyTimerBJ(timer whichTimer)
        {
            DestroyTimer(whichTimer);
        }

        public virtual void PauseTimerBJ(boolean pause, timer whichTimer)
        {
            if (pause)
            {
                PauseTimer(whichTimer);
            }
            else
            {
                ResumeTimer(whichTimer);
            }
        }

        public virtual timer GetLastCreatedTimerBJ()
        {
            return bj_lastStartedTimer;
        }

        public virtual timerdialog CreateTimerDialogBJ(timer t, @string title)
        {
            bj_lastCreatedTimerDialog = CreateTimerDialog(t);
            TimerDialogSetTitle(bj_lastCreatedTimerDialog, title);
            TimerDialogDisplay(bj_lastCreatedTimerDialog, true);
            return bj_lastCreatedTimerDialog;
        }

        public virtual void DestroyTimerDialogBJ(timerdialog td)
        {
            DestroyTimerDialog(td);
        }

        public virtual void TimerDialogSetTitleBJ(timerdialog td, @string title)
        {
            TimerDialogSetTitle(td, title);
        }

        public virtual void TimerDialogSetTitleColorBJ(timerdialog td, real red, real green, real blue, real transparency)
        {
            TimerDialogSetTitleColor(td, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100f - transparency));
        }

        public virtual void TimerDialogSetTimeColorBJ(timerdialog td, real red, real green, real blue, real transparency)
        {
            TimerDialogSetTimeColor(td, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100f - transparency));
        }

        public virtual void TimerDialogSetSpeedBJ(timerdialog td, real speedMultFactor)
        {
            TimerDialogSetSpeed(td, speedMultFactor);
        }

        public virtual void TimerDialogDisplayForPlayerBJ(boolean show, timerdialog td, player whichPlayer)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                TimerDialogDisplay(td, show);
            }
        }

        public virtual void TimerDialogDisplayBJ(boolean show, timerdialog td)
        {
            TimerDialogDisplay(td, show);
        }

        public virtual timerdialog GetLastCreatedTimerDialogBJ()
        {
            return bj_lastCreatedTimerDialog;
        }

        public virtual void LeaderboardResizeBJ(leaderboard lb)
        {
            integer size = LeaderboardGetItemCount(lb);
            if ((LeaderboardGetLabelText(lb) == ""))
            {
                size = size - 1;
            }
            LeaderboardSetSizeByItemCount(lb, size);
        }

        public virtual void LeaderboardSetPlayerItemValueBJ(player whichPlayer, leaderboard lb, integer val)
        {
            LeaderboardSetItemValue(lb, LeaderboardGetPlayerIndex(lb, whichPlayer), val);
        }

        public virtual void LeaderboardSetPlayerItemLabelBJ(player whichPlayer, leaderboard lb, @string val)
        {
            LeaderboardSetItemLabel(lb, LeaderboardGetPlayerIndex(lb, whichPlayer), val);
        }

        public virtual void LeaderboardSetPlayerItemStyleBJ(player whichPlayer, leaderboard lb, boolean showLabel, boolean showValue, boolean showIcon)
        {
            LeaderboardSetItemStyle(lb, LeaderboardGetPlayerIndex(lb, whichPlayer), showLabel, showValue, showIcon);
        }

        public virtual void LeaderboardSetPlayerItemLabelColorBJ(player whichPlayer, leaderboard lb, real red, real green, real blue, real transparency)
        {
            LeaderboardSetItemLabelColor(lb, LeaderboardGetPlayerIndex(lb, whichPlayer), PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100f - transparency));
        }

        public virtual void LeaderboardSetPlayerItemValueColorBJ(player whichPlayer, leaderboard lb, real red, real green, real blue, real transparency)
        {
            LeaderboardSetItemValueColor(lb, LeaderboardGetPlayerIndex(lb, whichPlayer), PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100f - transparency));
        }

        public virtual void LeaderboardSetLabelColorBJ(leaderboard lb, real red, real green, real blue, real transparency)
        {
            LeaderboardSetLabelColor(lb, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100f - transparency));
        }

        public virtual void LeaderboardSetValueColorBJ(leaderboard lb, real red, real green, real blue, real transparency)
        {
            LeaderboardSetValueColor(lb, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100f - transparency));
        }

        public virtual void LeaderboardSetLabelBJ(leaderboard lb, @string label)
        {
            LeaderboardSetLabel(lb, label);
            LeaderboardResizeBJ(lb);
        }

        public virtual void LeaderboardSetStyleBJ(leaderboard lb, boolean showLabel, boolean showNames, boolean showValues, boolean showIcons)
        {
            LeaderboardSetStyle(lb, showLabel, showNames, showValues, showIcons);
        }

        public virtual integer LeaderboardGetItemCountBJ(leaderboard lb)
        {
            return LeaderboardGetItemCount(lb);
        }

        public virtual boolean LeaderboardHasPlayerItemBJ(leaderboard lb, player whichPlayer)
        {
            return LeaderboardHasPlayerItem(lb, whichPlayer);
        }

        public virtual void ForceSetLeaderboardBJ(leaderboard lb, force toForce)
        {
            integer index = 0;
            player indexPlayer;
            index = 0;
            for (
            ; true;
            )
            {
                indexPlayer = Player(index);
                if (IsPlayerInForce(indexPlayer, toForce))
                {
                    PlayerSetLeaderboard(indexPlayer, lb);
                }
                index = index + 1;
                if (index == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
        }

        public virtual leaderboard CreateLeaderboardBJ(force toForce, @string label)
        {
            bj_lastCreatedLeaderboard = CreateLeaderboard();
            LeaderboardSetLabel(bj_lastCreatedLeaderboard, label);
            ForceSetLeaderboardBJ(bj_lastCreatedLeaderboard, toForce);
            LeaderboardDisplay(bj_lastCreatedLeaderboard, true);
            return bj_lastCreatedLeaderboard;
        }

        public virtual void DestroyLeaderboardBJ(leaderboard lb)
        {
            DestroyLeaderboard(lb);
        }

        public virtual void LeaderboardDisplayBJ(boolean show, leaderboard lb)
        {
            LeaderboardDisplay(lb, show);
        }

        public virtual void LeaderboardAddItemBJ(player whichPlayer, leaderboard lb, @string label, integer value)
        {
            if ((LeaderboardHasPlayerItem(lb, whichPlayer)))
            {
                LeaderboardRemovePlayerItem(lb, whichPlayer);
            }
            LeaderboardAddItem(lb, label, value, whichPlayer);
            LeaderboardResizeBJ(lb);
        }

        public virtual void LeaderboardRemovePlayerItemBJ(player whichPlayer, leaderboard lb)
        {
            LeaderboardRemovePlayerItem(lb, whichPlayer);
            LeaderboardResizeBJ(lb);
        }

        public virtual void LeaderboardSortItemsBJ(leaderboard lb, integer sortType, boolean ascending)
        {
            if ((sortType == bj_SORTTYPE_SORTBYVALUE))
            {
                LeaderboardSortItemsByValue(lb, ascending);
            }
            else
            {
                if ((sortType == bj_SORTTYPE_SORTBYPLAYER))
                {
                    LeaderboardSortItemsByPlayer(lb, ascending);
                }
                else
                {
                    if ((sortType == bj_SORTTYPE_SORTBYLABEL))
                    {
                        LeaderboardSortItemsByLabel(lb, ascending);
                    }
                }
            }
        }

        public virtual void LeaderboardSortItemsByPlayerBJ(leaderboard lb, boolean ascending)
        {
            LeaderboardSortItemsByPlayer(lb, ascending);
        }

        public virtual void LeaderboardSortItemsByLabelBJ(leaderboard lb, boolean ascending)
        {
            LeaderboardSortItemsByLabel(lb, ascending);
        }

        public virtual integer LeaderboardGetPlayerIndexBJ(player whichPlayer, leaderboard lb)
        {
            return LeaderboardGetPlayerIndex(lb, whichPlayer) + 1;
        }

        public virtual player LeaderboardGetIndexedPlayerBJ(integer position, leaderboard lb)
        {
            integer index = 0;
            player indexPlayer;
            index = 0;
            for (
            ; true;
            )
            {
                indexPlayer = Player(index);
                if ((LeaderboardGetPlayerIndex(lb, indexPlayer) == position - 1))
                {
                    return indexPlayer;
                }
                index = index + 1;
                if (index == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
            return Player(PLAYER_NEUTRAL_PASSIVE);
        }

        public virtual leaderboard PlayerGetLeaderboardBJ(player whichPlayer)
        {
            return PlayerGetLeaderboard(whichPlayer);
        }

        public virtual leaderboard GetLastCreatedLeaderboard()
        {
            return bj_lastCreatedLeaderboard;
        }

        public virtual multiboard CreateMultiboardBJ(integer cols, integer rows, @string title)
        {
            bj_lastCreatedMultiboard = CreateMultiboard();
            MultiboardSetRowCount(bj_lastCreatedMultiboard, rows);
            MultiboardSetColumnCount(bj_lastCreatedMultiboard, cols);
            MultiboardSetTitleText(bj_lastCreatedMultiboard, title);
            MultiboardDisplay(bj_lastCreatedMultiboard, true);
            return bj_lastCreatedMultiboard;
        }

        public virtual void DestroyMultiboardBJ(multiboard mb)
        {
            DestroyMultiboard(mb);
        }

        public virtual multiboard GetLastCreatedMultiboard()
        {
            return bj_lastCreatedMultiboard;
        }

        public virtual void MultiboardDisplayBJ(boolean show, multiboard mb)
        {
            MultiboardDisplay(mb, show);
        }

        public virtual void MultiboardMinimizeBJ(boolean minimize, multiboard mb)
        {
            MultiboardMinimize(mb, minimize);
        }

        public virtual void MultiboardSetTitleTextColorBJ(multiboard mb, real red, real green, real blue, real transparency)
        {
            MultiboardSetTitleTextColor(mb, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100f - transparency));
        }

        public virtual void MultiboardAllowDisplayBJ(boolean flag)
        {
            MultiboardSuppressDisplay(!flag);
        }

        public virtual void MultiboardSetItemStyleBJ(multiboard mb, integer col, integer row, boolean showValue, boolean showIcon)
        {
            integer curRow = 0;
            integer curCol = 0;
            integer numRows = MultiboardGetRowCount(mb);
            integer numCols = MultiboardGetColumnCount(mb);
            multiboarditem mbitem = null;
            for (
            ; true;
            )
            {
                curRow = curRow + 1;
                if (curRow > numRows)
                {
                    break;
                }
                if ((row == 0 || row == curRow))
                {
                    curCol = 0;
                    for (
                    ; true;
                    )
                    {
                        curCol = curCol + 1;
                        if (curCol > numCols)
                        {
                            break;
                        }
                        if ((col == 0 || col == curCol))
                        {
                            mbitem = MultiboardGetItem(mb, curRow - 1, curCol - 1);
                            MultiboardSetItemStyle(mbitem, showValue, showIcon);
                            MultiboardReleaseItem(mbitem);
                        }
                    }
                }
            }
        }

        public virtual void MultiboardSetItemValueBJ(multiboard mb, integer col, integer row, @string val)
        {
            integer curRow = 0;
            integer curCol = 0;
            integer numRows = MultiboardGetRowCount(mb);
            integer numCols = MultiboardGetColumnCount(mb);
            multiboarditem mbitem = null;
            for (
            ; true;
            )
            {
                curRow = curRow + 1;
                if (curRow > numRows)
                {
                    break;
                }
                if ((row == 0 || row == curRow))
                {
                    curCol = 0;
                    for (
                    ; true;
                    )
                    {
                        curCol = curCol + 1;
                        if (curCol > numCols)
                        {
                            break;
                        }
                        if ((col == 0 || col == curCol))
                        {
                            mbitem = MultiboardGetItem(mb, curRow - 1, curCol - 1);
                            MultiboardSetItemValue(mbitem, val);
                            MultiboardReleaseItem(mbitem);
                        }
                    }
                }
            }
        }

        public virtual void MultiboardSetItemColorBJ(multiboard mb, integer col, integer row, real red, real green, real blue, real transparency)
        {
            integer curRow = 0;
            integer curCol = 0;
            integer numRows = MultiboardGetRowCount(mb);
            integer numCols = MultiboardGetColumnCount(mb);
            multiboarditem mbitem = null;
            for (
            ; true;
            )
            {
                curRow = curRow + 1;
                if (curRow > numRows)
                {
                    break;
                }
                if ((row == 0 || row == curRow))
                {
                    curCol = 0;
                    for (
                    ; true;
                    )
                    {
                        curCol = curCol + 1;
                        if (curCol > numCols)
                        {
                            break;
                        }
                        if ((col == 0 || col == curCol))
                        {
                            mbitem = MultiboardGetItem(mb, curRow - 1, curCol - 1);
                            MultiboardSetItemValueColor(mbitem, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100f - transparency));
                            MultiboardReleaseItem(mbitem);
                        }
                    }
                }
            }
        }

        public virtual void MultiboardSetItemWidthBJ(multiboard mb, integer col, integer row, real width)
        {
            integer curRow = 0;
            integer curCol = 0;
            integer numRows = MultiboardGetRowCount(mb);
            integer numCols = MultiboardGetColumnCount(mb);
            multiboarditem mbitem = null;
            for (
            ; true;
            )
            {
                curRow = curRow + 1;
                if (curRow > numRows)
                {
                    break;
                }
                if ((row == 0 || row == curRow))
                {
                    curCol = 0;
                    for (
                    ; true;
                    )
                    {
                        curCol = curCol + 1;
                        if (curCol > numCols)
                        {
                            break;
                        }
                        if ((col == 0 || col == curCol))
                        {
                            mbitem = MultiboardGetItem(mb, curRow - 1, curCol - 1);
                            MultiboardSetItemWidth(mbitem, width / 100f);
                            MultiboardReleaseItem(mbitem);
                        }
                    }
                }
            }
        }

        public virtual void MultiboardSetItemIconBJ(multiboard mb, integer col, integer row, @string iconFileName)
        {
            integer curRow = 0;
            integer curCol = 0;
            integer numRows = MultiboardGetRowCount(mb);
            integer numCols = MultiboardGetColumnCount(mb);
            multiboarditem mbitem = null;
            for (
            ; true;
            )
            {
                curRow = curRow + 1;
                if (curRow > numRows)
                {
                    break;
                }
                if ((row == 0 || row == curRow))
                {
                    curCol = 0;
                    for (
                    ; true;
                    )
                    {
                        curCol = curCol + 1;
                        if (curCol > numCols)
                        {
                            break;
                        }
                        if ((col == 0 || col == curCol))
                        {
                            mbitem = MultiboardGetItem(mb, curRow - 1, curCol - 1);
                            MultiboardSetItemIcon(mbitem, iconFileName);
                            MultiboardReleaseItem(mbitem);
                        }
                    }
                }
            }
        }

        public virtual real TextTagSize2Height(real size)
        {
            return size * 0.023f / 10;
        }

        public virtual real TextTagSpeed2Velocity(real speed)
        {
            return speed * 0.071f / 128;
        }

        public virtual void SetTextTagColorBJ(texttag tt, real red, real green, real blue, real transparency)
        {
            SetTextTagColor(tt, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100f - transparency));
        }

        public virtual void SetTextTagVelocityBJ(texttag tt, real speed, real angle)
        {
            real vel = TextTagSpeed2Velocity(speed);
            real xvel = vel * Cos(angle * bj_DEGTORAD);
            real yvel = vel * Sin(angle * bj_DEGTORAD);
            SetTextTagVelocity(tt, xvel, yvel);
        }

        public virtual void SetTextTagTextBJ(texttag tt, @string s, real size)
        {
            real textHeight = TextTagSize2Height(size);
            SetTextTagText(tt, s, textHeight);
        }

        public virtual void SetTextTagPosBJ(texttag tt, location loc, real zOffset)
        {
            SetTextTagPos(tt, GetLocationX(loc), GetLocationY(loc), zOffset);
        }

        public virtual void SetTextTagPosUnitBJ(texttag tt, unit whichUnit, real zOffset)
        {
            SetTextTagPosUnit(tt, whichUnit, zOffset);
        }

        public virtual void SetTextTagSuspendedBJ(texttag tt, boolean flag)
        {
            SetTextTagSuspended(tt, flag);
        }

        public virtual void SetTextTagPermanentBJ(texttag tt, boolean flag)
        {
            SetTextTagPermanent(tt, flag);
        }

        public virtual void SetTextTagAgeBJ(texttag tt, real age)
        {
            SetTextTagAge(tt, age);
        }

        public virtual void SetTextTagLifespanBJ(texttag tt, real lifespan)
        {
            SetTextTagLifespan(tt, lifespan);
        }

        public virtual void SetTextTagFadepointBJ(texttag tt, real fadepoint)
        {
            SetTextTagFadepoint(tt, fadepoint);
        }

        public virtual texttag CreateTextTagLocBJ(@string s, location loc, real zOffset, real size, real red, real green, real blue, real transparency)
        {
            bj_lastCreatedTextTag = CreateTextTag();
            SetTextTagTextBJ(bj_lastCreatedTextTag, s, size);
            SetTextTagPosBJ(bj_lastCreatedTextTag, loc, zOffset);
            SetTextTagColorBJ(bj_lastCreatedTextTag, red, green, blue, transparency);
            return bj_lastCreatedTextTag;
        }

        public virtual texttag CreateTextTagUnitBJ(@string s, unit whichUnit, real zOffset, real size, real red, real green, real blue, real transparency)
        {
            bj_lastCreatedTextTag = CreateTextTag();
            SetTextTagTextBJ(bj_lastCreatedTextTag, s, size);
            SetTextTagPosUnitBJ(bj_lastCreatedTextTag, whichUnit, zOffset);
            SetTextTagColorBJ(bj_lastCreatedTextTag, red, green, blue, transparency);
            return bj_lastCreatedTextTag;
        }

        public virtual void DestroyTextTagBJ(texttag tt)
        {
            DestroyTextTag(tt);
        }

        public virtual void ShowTextTagForceBJ(boolean show, texttag tt, force whichForce)
        {
            if ((IsPlayerInForce(GetLocalPlayer(), whichForce)))
            {
                SetTextTagVisibility(tt, show);
            }
        }

        public virtual texttag GetLastCreatedTextTag()
        {
            return bj_lastCreatedTextTag;
        }

        public virtual void PauseGameOn()
        {
            PauseGame(true);
        }

        public virtual void PauseGameOff()
        {
            PauseGame(false);
        }

        public virtual void SetUserControlForceOn(force whichForce)
        {
            if ((IsPlayerInForce(GetLocalPlayer(), whichForce)))
            {
                EnableUserControl(true);
            }
        }

        public virtual void SetUserControlForceOff(force whichForce)
        {
            if ((IsPlayerInForce(GetLocalPlayer(), whichForce)))
            {
                EnableUserControl(false);
            }
        }

        public virtual void ShowInterfaceForceOn(force whichForce, real fadeDuration)
        {
            if ((IsPlayerInForce(GetLocalPlayer(), whichForce)))
            {
                ShowInterface(true, fadeDuration);
            }
        }

        public virtual void ShowInterfaceForceOff(force whichForce, real fadeDuration)
        {
            if ((IsPlayerInForce(GetLocalPlayer(), whichForce)))
            {
                ShowInterface(false, fadeDuration);
            }
        }

        public virtual void PingMinimapForForce(force whichForce, real x, real y, real duration)
        {
            if ((IsPlayerInForce(GetLocalPlayer(), whichForce)))
            {
                PingMinimap(x, y, duration);
            }
        }

        public virtual void PingMinimapLocForForce(force whichForce, location loc, real duration)
        {
            PingMinimapForForce(whichForce, GetLocationX(loc), GetLocationY(loc), duration);
        }

        public virtual void PingMinimapForPlayer(player whichPlayer, real x, real y, real duration)
        {
            if ((GetLocalPlayer() == whichPlayer))
            {
                PingMinimap(x, y, duration);
            }
        }

        public virtual void PingMinimapLocForPlayer(player whichPlayer, location loc, real duration)
        {
            PingMinimapForPlayer(whichPlayer, GetLocationX(loc), GetLocationY(loc), duration);
        }

        public virtual void PingMinimapForForceEx(force whichForce, real x, real y, real duration, integer style, real red, real green, real blue)
        {
            integer red255 = PercentTo255(red);
            integer green255 = PercentTo255(green);
            integer blue255 = PercentTo255(blue);
            if ((IsPlayerInForce(GetLocalPlayer(), whichForce)))
            {
                if ((red255 == 255) && (green255 == 0) && (blue255 == 0))
                {
                    red255 = 254;
                }
                if ((style == bj_MINIMAPPINGSTYLE_SIMPLE))
                {
                    PingMinimapEx(x, y, duration, red255, green255, blue255, false);
                }
                else
                {
                    if ((style == bj_MINIMAPPINGSTYLE_FLASHY))
                    {
                        PingMinimapEx(x, y, duration, red255, green255, blue255, true);
                    }
                    else
                    {
                        if ((style == bj_MINIMAPPINGSTYLE_ATTACK))
                        {
                            PingMinimapEx(x, y, duration, 255, 0, 0, false);
                        }
                    }
                }
            }
        }

        public virtual void PingMinimapLocForForceEx(force whichForce, location loc, real duration, integer style, real red, real green, real blue)
        {
            PingMinimapForForceEx(whichForce, GetLocationX(loc), GetLocationY(loc), duration, style, red, green, blue);
        }

        public virtual void EnableWorldFogBoundaryBJ(boolean enable, force f)
        {
            if ((IsPlayerInForce(GetLocalPlayer(), f)))
            {
                EnableWorldFogBoundary(enable);
            }
        }

        public virtual void EnableOcclusionBJ(boolean enable, force f)
        {
            if ((IsPlayerInForce(GetLocalPlayer(), f)))
            {
                EnableOcclusion(enable);
            }
        }

        public virtual void CancelCineSceneBJ()
        {
            StopSoundBJ(bj_cineSceneLastSound, true);
            EndCinematicScene();
        }

        public virtual void TryInitCinematicBehaviorBJ()
        {
            integer index = 0;
            if ((bj_cineSceneBeingSkipped == null))
            {
                bj_cineSceneBeingSkipped = CreateTrigger();
                index = 0;
                for (
                ; true;
                )
                {
                    TriggerRegisterPlayerEvent(bj_cineSceneBeingSkipped, Player(index), EVENT_PLAYER_END_CINEMATIC);
                    index = index + 1;
                    if (index == bj_MAX_PLAYERS)
                    {
                        break;
                    }
                }
                TriggerAddAction(bj_cineSceneBeingSkipped, CancelCineSceneBJ);
            }
        }

        public virtual void SetCinematicSceneBJ(sound soundHandle, integer portraitUnitId, playercolor color, @string speakerTitle, @string text, real sceneDuration, real voiceoverDuration)
        {
            bj_cineSceneLastSound = soundHandle;
            PlaySoundBJ(soundHandle);
            SetCinematicScene(portraitUnitId, color, speakerTitle, text, sceneDuration, voiceoverDuration);
        }

        public virtual real GetTransmissionDuration(sound soundHandle, integer timeType, real timeVal)
        {
            real duration = 0;
            if ((timeType == bj_TIMETYPE_ADD))
            {
                duration = GetSoundDurationBJ(soundHandle) + timeVal;
            }
            else
            {
                if ((timeType == bj_TIMETYPE_SET))
                {
                    duration = timeVal;
                }
                else
                {
                    if ((timeType == bj_TIMETYPE_SUB))
                    {
                        duration = GetSoundDurationBJ(soundHandle) - timeVal;
                    }
                    else
                    {
                        duration = GetSoundDurationBJ(soundHandle);
                    }
                }
            }
            if ((duration < 0))
            {
                duration = 0;
            }
            return duration;
        }

        public virtual void WaitTransmissionDuration(sound soundHandle, integer timeType, real timeVal)
        {
            if ((timeType == bj_TIMETYPE_SET))
            {
                TriggerSleepAction(timeVal);
            }
            else
            {
                if ((soundHandle == null))
                {
                    TriggerSleepAction(bj_NOTHING_SOUND_DURATION);
                }
                else
                {
                    if ((timeType == bj_TIMETYPE_SUB))
                    {
                        WaitForSoundBJ(soundHandle, timeVal);
                    }
                    else
                    {
                        if ((timeType == bj_TIMETYPE_ADD))
                        {
                            WaitForSoundBJ(soundHandle, 0);
                            TriggerSleepAction(timeVal);
                        }
                    }
                }
            }
        }

        public virtual void DoTransmissionBasicsXYBJ(integer unitId, playercolor color, real x, real y, sound soundHandle, @string unitName, @string message, real duration)
        {
            SetCinematicSceneBJ(soundHandle, unitId, color, unitName, message, duration + bj_TRANSMISSION_PORT_HANGTIME, duration);
            if ((unitId != 0))
            {
                PingMinimap(x, y, bj_TRANSMISSION_PING_TIME);
            }
        }

        public virtual void TransmissionFromUnitWithNameBJ(force toForce, unit whichUnit, @string unitName, sound soundHandle, @string message, integer timeType, real timeVal, boolean wait)
        {
            TryInitCinematicBehaviorBJ();
            timeVal = RMaxBJ(timeVal, 0);
            bj_lastTransmissionDuration = GetTransmissionDuration(soundHandle, timeType, timeVal);
            bj_lastPlayedSound = soundHandle;
            if ((IsPlayerInForce(GetLocalPlayer(), toForce)))
            {
                if ((whichUnit == null))
                {
                    DoTransmissionBasicsXYBJ(0, PLAYER_COLOR_RED, 0, 0, soundHandle, unitName, message, bj_lastTransmissionDuration);
                }
                else
                {
                    DoTransmissionBasicsXYBJ(GetUnitTypeId(whichUnit), GetPlayerColor(GetOwningPlayer(whichUnit)), GetUnitX(whichUnit), GetUnitY(whichUnit), soundHandle, unitName, message, bj_lastTransmissionDuration);
                    if ((!IsUnitHidden(whichUnit)))
                    {
                        UnitAddIndicator(whichUnit, bj_TRANSMISSION_IND_RED, bj_TRANSMISSION_IND_BLUE, bj_TRANSMISSION_IND_GREEN, bj_TRANSMISSION_IND_ALPHA);
                    }
                }
            }
            if (wait && (bj_lastTransmissionDuration > 0))
            {
                WaitTransmissionDuration(soundHandle, timeType, timeVal);
            }
        }

        public virtual void TransmissionFromUnitTypeWithNameBJ(force toForce, player fromPlayer, integer unitId, @string unitName, location loc, sound soundHandle, @string message, integer timeType, real timeVal, boolean wait)
        {
            TryInitCinematicBehaviorBJ();
            timeVal = RMaxBJ(timeVal, 0);
            bj_lastTransmissionDuration = GetTransmissionDuration(soundHandle, timeType, timeVal);
            bj_lastPlayedSound = soundHandle;
            if ((IsPlayerInForce(GetLocalPlayer(), toForce)))
            {
                DoTransmissionBasicsXYBJ(unitId, GetPlayerColor(fromPlayer), GetLocationX(loc), GetLocationY(loc), soundHandle, unitName, message, bj_lastTransmissionDuration);
            }
            if (wait && (bj_lastTransmissionDuration > 0))
            {
                WaitTransmissionDuration(soundHandle, timeType, timeVal);
            }
        }

        public virtual real GetLastTransmissionDurationBJ()
        {
            return bj_lastTransmissionDuration;
        }

        public virtual void ForceCinematicSubtitlesBJ(boolean flag)
        {
            ForceCinematicSubtitles(flag);
        }

        public virtual void CinematicModeExBJ(boolean cineMode, force forForce, real interfaceFadeTime)
        {
            if ((!bj_gameStarted))
            {
                interfaceFadeTime = 0;
            }
            if ((cineMode))
            {
                if ((!bj_cineModeAlreadyIn))
                {
                    bj_cineModeAlreadyIn = true;
                    bj_cineModePriorSpeed = GetGameSpeed();
                    bj_cineModePriorFogSetting = IsFogEnabled();
                    bj_cineModePriorMaskSetting = IsFogMaskEnabled();
                    bj_cineModePriorDawnDusk = IsDawnDuskEnabled();
                    bj_cineModeSavedSeed = GetRandomInt(0, 1000000);
                }
                if ((IsPlayerInForce(GetLocalPlayer(), forForce)))
                {
                    ClearTextMessages();
                    ShowInterface(false, interfaceFadeTime);
                    EnableUserControl(false);
                    EnableOcclusion(false);
                    SetCineModeVolumeGroupsBJ();
                }
                SetGameSpeed(bj_CINEMODE_GAMESPEED);
                SetMapFlag(MAP_LOCK_SPEED, true);
                FogMaskEnable(false);
                FogEnable(false);
                EnableWorldFogBoundary(false);
                EnableDawnDusk(false);
                SetRandomSeed(0);
            }
            else
            {
                bj_cineModeAlreadyIn = false;
                if ((IsPlayerInForce(GetLocalPlayer(), forForce)))
                {
                    ShowInterface(true, interfaceFadeTime);
                    EnableUserControl(true);
                    EnableOcclusion(true);
                    VolumeGroupReset();
                    EndThematicMusic();
                    CameraResetSmoothingFactorBJ();
                }
                SetMapFlag(MAP_LOCK_SPEED, false);
                SetGameSpeed(bj_cineModePriorSpeed);
                FogMaskEnable(bj_cineModePriorMaskSetting);
                FogEnable(bj_cineModePriorFogSetting);
                EnableWorldFogBoundary(true);
                EnableDawnDusk(bj_cineModePriorDawnDusk);
                SetRandomSeed(bj_cineModeSavedSeed);
            }
        }

        public virtual void CinematicModeBJ(boolean cineMode, force forForce)
        {
            CinematicModeExBJ(cineMode, forForce, bj_CINEMODE_INTERFACEFADE);
        }

        public virtual void DisplayCineFilterBJ(boolean flag)
        {
            DisplayCineFilter(flag);
        }

        public virtual void CinematicFadeCommonBJ(real red, real green, real blue, real duration, @string tex, real startTrans, real endTrans)
        {
            if ((duration == 0))
            {
                startTrans = endTrans;
            }
            EnableUserUI(false);
            SetCineFilterTexture(tex);
            SetCineFilterBlendMode(BLEND_MODE_BLEND);
            SetCineFilterTexMapFlags(TEXMAP_FLAG_NONE);
            SetCineFilterStartUV(0, 0, 1, 1);
            SetCineFilterEndUV(0, 0, 1, 1);
            SetCineFilterStartColor(PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100 - startTrans));
            SetCineFilterEndColor(PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100 - endTrans));
            SetCineFilterDuration(duration);
            DisplayCineFilter(true);
        }

        public virtual void FinishCinematicFadeBJ()
        {
            DestroyTimer(bj_cineFadeFinishTimer);
            bj_cineFadeFinishTimer = null;
            DisplayCineFilter(false);
            EnableUserUI(true);
        }

        public virtual void FinishCinematicFadeAfterBJ(real duration)
        {
            bj_cineFadeFinishTimer = CreateTimer();
            TimerStart(bj_cineFadeFinishTimer, duration, false, FinishCinematicFadeBJ);
        }

        public virtual void ContinueCinematicFadeBJ()
        {
            DestroyTimer(bj_cineFadeContinueTimer);
            bj_cineFadeContinueTimer = null;
            CinematicFadeCommonBJ(bj_cineFadeContinueRed, bj_cineFadeContinueGreen, bj_cineFadeContinueBlue, bj_cineFadeContinueDuration, bj_cineFadeContinueTex, bj_cineFadeContinueTrans, 100);
        }

        public virtual void ContinueCinematicFadeAfterBJ(real duration, real red, real green, real blue, real trans, @string tex)
        {
            bj_cineFadeContinueRed = red;
            bj_cineFadeContinueGreen = green;
            bj_cineFadeContinueBlue = blue;
            bj_cineFadeContinueTrans = trans;
            bj_cineFadeContinueDuration = duration;
            bj_cineFadeContinueTex = tex;
            bj_cineFadeContinueTimer = CreateTimer();
            TimerStart(bj_cineFadeContinueTimer, duration, false, ContinueCinematicFadeBJ);
        }

        public virtual void AbortCinematicFadeBJ()
        {
            if ((bj_cineFadeContinueTimer != null))
            {
                DestroyTimer(bj_cineFadeContinueTimer);
            }
            if ((bj_cineFadeFinishTimer != null))
            {
                DestroyTimer(bj_cineFadeFinishTimer);
            }
        }

        public virtual void CinematicFadeBJ(integer fadetype, real duration, @string tex, real red, real green, real blue, real trans)
        {
            if ((fadetype == bj_CINEFADETYPE_FADEOUT))
            {
                AbortCinematicFadeBJ();
                CinematicFadeCommonBJ(red, green, blue, duration, tex, 100, trans);
            }
            else
            {
                if ((fadetype == bj_CINEFADETYPE_FADEIN))
                {
                    AbortCinematicFadeBJ();
                    CinematicFadeCommonBJ(red, green, blue, duration, tex, trans, 100);
                    FinishCinematicFadeAfterBJ(duration);
                }
                else
                {
                    if ((fadetype == bj_CINEFADETYPE_FADEOUTIN))
                    {
                        if ((duration > 0))
                        {
                            AbortCinematicFadeBJ();
                            CinematicFadeCommonBJ(red, green, blue, duration * 0.5f, tex, 100, trans);
                            ContinueCinematicFadeAfterBJ(duration * 0.5f, red, green, blue, trans, tex);
                            FinishCinematicFadeAfterBJ(duration);
                        }
                    }
                }
            }
        }

        public virtual void CinematicFilterGenericBJ(real duration, blendmode bmode, @string tex, real red0, real green0, real blue0, real trans0, real red1, real green1, real blue1, real trans1)
        {
            AbortCinematicFadeBJ();
            SetCineFilterTexture(tex);
            SetCineFilterBlendMode(bmode);
            SetCineFilterTexMapFlags(TEXMAP_FLAG_NONE);
            SetCineFilterStartUV(0, 0, 1, 1);
            SetCineFilterEndUV(0, 0, 1, 1);
            SetCineFilterStartColor(PercentTo255(red0), PercentTo255(green0), PercentTo255(blue0), PercentTo255(100 - trans0));
            SetCineFilterEndColor(PercentTo255(red1), PercentTo255(green1), PercentTo255(blue1), PercentTo255(100 - trans1));
            SetCineFilterDuration(duration);
            DisplayCineFilter(true);
        }

        public virtual void RescueUnitBJ(unit whichUnit, player rescuer, boolean changeColor)
        {
            if (IsUnitDeadBJ(whichUnit) || (GetOwningPlayer(whichUnit) == rescuer))
            {
                return;
            }
            StartSound(bj_rescueSound);
            SetUnitOwner(whichUnit, rescuer, changeColor);
            UnitAddIndicator(whichUnit, 0, 255, 0, 255);
            PingMinimapForPlayer(rescuer, GetUnitX(whichUnit), GetUnitY(whichUnit), bj_RESCUE_PING_TIME);
        }

        public virtual void TriggerActionUnitRescuedBJ()
        {
            unit theUnit = GetTriggerUnit();
            if (IsUnitType(theUnit, UNIT_TYPE_STRUCTURE))
            {
                RescueUnitBJ(theUnit, GetOwningPlayer(GetRescuer()), bj_rescueChangeColorBldg);
            }
            else
            {
                RescueUnitBJ(theUnit, GetOwningPlayer(GetRescuer()), bj_rescueChangeColorUnit);
            }
        }

        public virtual void TryInitRescuableTriggersBJ()
        {
            integer index = 0;
            if ((bj_rescueUnitBehavior == null))
            {
                bj_rescueUnitBehavior = CreateTrigger();
                index = 0;
                for (
                ; true;
                )
                {
                    TriggerRegisterPlayerUnitEvent(bj_rescueUnitBehavior, Player(index), EVENT_PLAYER_UNIT_RESCUED, null);
                    index = index + 1;
                    if (index == bj_MAX_PLAYER_SLOTS)
                    {
                        break;
                    }
                }
                TriggerAddAction(bj_rescueUnitBehavior, TriggerActionUnitRescuedBJ);
            }
        }

        public virtual void SetRescueUnitColorChangeBJ(boolean changeColor)
        {
            bj_rescueChangeColorUnit = changeColor;
        }

        public virtual void SetRescueBuildingColorChangeBJ(boolean changeColor)
        {
            bj_rescueChangeColorBldg = changeColor;
        }

        public virtual void MakeUnitRescuableToForceBJEnum()
        {
            TryInitRescuableTriggersBJ();
            SetUnitRescuable(bj_makeUnitRescuableUnit, GetEnumPlayer(), bj_makeUnitRescuableFlag);
        }

        public virtual void MakeUnitRescuableToForceBJ(unit whichUnit, boolean isRescuable, force whichForce)
        {
            bj_makeUnitRescuableUnit = whichUnit;
            bj_makeUnitRescuableFlag = isRescuable;
            ForForce(whichForce, MakeUnitRescuableToForceBJEnum);
        }

        public virtual void InitRescuableBehaviorBJ()
        {
            integer index = 0;
            index = 0;
            for (
            ; true;
            )
            {
                if ((GetPlayerController(Player(index)) == MAP_CONTROL_RESCUABLE))
                {
                    TryInitRescuableTriggersBJ();
                    return;
                }
                index = index + 1;
                if (index == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
        }

        public virtual void SetPlayerTechResearchedSwap(integer techid, integer levels, player whichPlayer)
        {
            SetPlayerTechResearched(whichPlayer, techid, levels);
        }

        public virtual void SetPlayerTechMaxAllowedSwap(integer techid, integer maximum, player whichPlayer)
        {
            SetPlayerTechMaxAllowed(whichPlayer, techid, maximum);
        }

        public virtual void SetPlayerMaxHeroesAllowed(integer maximum, player whichPlayer)
        {
            SetPlayerTechMaxAllowed(whichPlayer, 1330791752, maximum);
        }

        public virtual integer GetPlayerTechCountSimple(integer techid, player whichPlayer)
        {
            return GetPlayerTechCount(whichPlayer, techid, true);
        }

        public virtual integer GetPlayerTechMaxAllowedSwap(integer techid, player whichPlayer)
        {
            return GetPlayerTechMaxAllowed(whichPlayer, techid);
        }

        public virtual void SetPlayerAbilityAvailableBJ(boolean avail, integer abilid, player whichPlayer)
        {
            SetPlayerAbilityAvailable(whichPlayer, abilid, avail);
        }

        public virtual void SetCampaignMenuRaceBJ(integer campaignNumber)
        {
            if ((campaignNumber == bj_CAMPAIGN_INDEX_T))
            {
                SetCampaignMenuRace(RACE_OTHER);
            }
            else
            {
                if ((campaignNumber == bj_CAMPAIGN_INDEX_H))
                {
                    SetCampaignMenuRace(RACE_HUMAN);
                }
                else
                {
                    if ((campaignNumber == bj_CAMPAIGN_INDEX_U))
                    {
                        SetCampaignMenuRace(RACE_UNDEAD);
                    }
                    else
                    {
                        if ((campaignNumber == bj_CAMPAIGN_INDEX_O))
                        {
                            SetCampaignMenuRace(RACE_ORC);
                        }
                        else
                        {
                            if ((campaignNumber == bj_CAMPAIGN_INDEX_N))
                            {
                                SetCampaignMenuRace(RACE_NIGHTELF);
                            }
                            else
                            {
                                if ((campaignNumber == bj_CAMPAIGN_INDEX_XN))
                                {
                                    SetCampaignMenuRaceEx(bj_CAMPAIGN_OFFSET_XN);
                                }
                                else
                                {
                                    if ((campaignNumber == bj_CAMPAIGN_INDEX_XH))
                                    {
                                        SetCampaignMenuRaceEx(bj_CAMPAIGN_OFFSET_XH);
                                    }
                                    else
                                    {
                                        if ((campaignNumber == bj_CAMPAIGN_INDEX_XU))
                                        {
                                            SetCampaignMenuRaceEx(bj_CAMPAIGN_OFFSET_XU);
                                        }
                                        else
                                        {
                                            if ((campaignNumber == bj_CAMPAIGN_INDEX_XO))
                                            {
                                                SetCampaignMenuRaceEx(bj_CAMPAIGN_OFFSET_XO);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public virtual void SetMissionAvailableBJ(boolean available, integer missionIndex)
        {
            integer campaignNumber = missionIndex / 1000;
            integer missionNumber = missionIndex - campaignNumber * 1000;
            SetMissionAvailable(campaignNumber, missionNumber, available);
        }

        public virtual void SetCampaignAvailableBJ(boolean available, integer campaignNumber)
        {
            integer campaignOffset = 0;
            if ((campaignNumber == bj_CAMPAIGN_INDEX_H))
            {
                SetTutorialCleared(true);
            }
            if ((campaignNumber == bj_CAMPAIGN_INDEX_XN))
            {
                campaignOffset = bj_CAMPAIGN_OFFSET_XN;
            }
            else
            {
                if ((campaignNumber == bj_CAMPAIGN_INDEX_XH))
                {
                    campaignOffset = bj_CAMPAIGN_OFFSET_XH;
                }
                else
                {
                    if ((campaignNumber == bj_CAMPAIGN_INDEX_XU))
                    {
                        campaignOffset = bj_CAMPAIGN_OFFSET_XU;
                    }
                    else
                    {
                        if ((campaignNumber == bj_CAMPAIGN_INDEX_XO))
                        {
                            campaignOffset = bj_CAMPAIGN_OFFSET_XO;
                        }
                        else
                        {
                            campaignOffset = campaignNumber;
                        }
                    }
                }
            }
            SetCampaignAvailable(campaignOffset, available);
            SetCampaignMenuRaceBJ(campaignNumber);
            ForceCampaignSelectScreen();
        }

        public virtual void SetCinematicAvailableBJ(boolean available, integer cinematicIndex)
        {
            if ((cinematicIndex == bj_CINEMATICINDEX_TOP))
            {
                SetOpCinematicAvailable(bj_CAMPAIGN_INDEX_T, available);
                PlayCinematic("TutorialOp");
            }
            else
            {
                if ((cinematicIndex == bj_CINEMATICINDEX_HOP))
                {
                    SetOpCinematicAvailable(bj_CAMPAIGN_INDEX_H, available);
                    PlayCinematic("HumanOp");
                }
                else
                {
                    if ((cinematicIndex == bj_CINEMATICINDEX_HED))
                    {
                        SetEdCinematicAvailable(bj_CAMPAIGN_INDEX_H, available);
                        PlayCinematic("HumanEd");
                    }
                    else
                    {
                        if ((cinematicIndex == bj_CINEMATICINDEX_OOP))
                        {
                            SetOpCinematicAvailable(bj_CAMPAIGN_INDEX_O, available);
                            PlayCinematic("OrcOp");
                        }
                        else
                        {
                            if ((cinematicIndex == bj_CINEMATICINDEX_OED))
                            {
                                SetEdCinematicAvailable(bj_CAMPAIGN_INDEX_O, available);
                                PlayCinematic("OrcEd");
                            }
                            else
                            {
                                if ((cinematicIndex == bj_CINEMATICINDEX_UOP))
                                {
                                    SetEdCinematicAvailable(bj_CAMPAIGN_INDEX_U, available);
                                    PlayCinematic("UndeadOp");
                                }
                                else
                                {
                                    if ((cinematicIndex == bj_CINEMATICINDEX_UED))
                                    {
                                        SetEdCinematicAvailable(bj_CAMPAIGN_INDEX_U, available);
                                        PlayCinematic("UndeadEd");
                                    }
                                    else
                                    {
                                        if ((cinematicIndex == bj_CINEMATICINDEX_NOP))
                                        {
                                            SetEdCinematicAvailable(bj_CAMPAIGN_INDEX_N, available);
                                            PlayCinematic("NightElfOp");
                                        }
                                        else
                                        {
                                            if ((cinematicIndex == bj_CINEMATICINDEX_NED))
                                            {
                                                SetEdCinematicAvailable(bj_CAMPAIGN_INDEX_N, available);
                                                PlayCinematic("NightElfEd");
                                            }
                                            else
                                            {
                                                if ((cinematicIndex == bj_CINEMATICINDEX_XOP))
                                                {
                                                    SetOpCinematicAvailable(bj_CAMPAIGN_OFFSET_XN, available);
                                                    PlayCinematic("IntroX");
                                                }
                                                else
                                                {
                                                    if ((cinematicIndex == bj_CINEMATICINDEX_XED))
                                                    {
                                                        SetEdCinematicAvailable(bj_CAMPAIGN_OFFSET_XU, available);
                                                        PlayCinematic("OutroX");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public virtual gamecache InitGameCacheBJ(@string campaignFile)
        {
            bj_lastCreatedGameCache = InitGameCache(campaignFile);
            return bj_lastCreatedGameCache;
        }

        public virtual boolean SaveGameCacheBJ(gamecache cache)
        {
            return SaveGameCache(cache);
        }

        public virtual gamecache GetLastCreatedGameCacheBJ()
        {
            return bj_lastCreatedGameCache;
        }

        public virtual hashtable InitHashtableBJ()
        {
            bj_lastCreatedHashtable = InitHashtable();
            return bj_lastCreatedHashtable;
        }

        public virtual hashtable GetLastCreatedHashtableBJ()
        {
            return bj_lastCreatedHashtable;
        }

        public virtual void StoreRealBJ(real value, @string key, @string missionKey, gamecache cache)
        {
            StoreReal(cache, missionKey, key, value);
        }

        public virtual void StoreIntegerBJ(integer value, @string key, @string missionKey, gamecache cache)
        {
            StoreInteger(cache, missionKey, key, value);
        }

        public virtual void StoreBooleanBJ(boolean value, @string key, @string missionKey, gamecache cache)
        {
            StoreBoolean(cache, missionKey, key, value);
        }

        public virtual boolean StoreStringBJ(@string value, @string key, @string missionKey, gamecache cache)
        {
            return StoreString(cache, missionKey, key, value);
        }

        public virtual boolean StoreUnitBJ(unit whichUnit, @string key, @string missionKey, gamecache cache)
        {
            return StoreUnit(cache, missionKey, key, whichUnit);
        }

        public virtual void SaveRealBJ(real value, integer key, integer missionKey, hashtable table)
        {
            SaveReal(table, missionKey, key, value);
        }

        public virtual void SaveIntegerBJ(integer value, integer key, integer missionKey, hashtable table)
        {
            SaveInteger(table, missionKey, key, value);
        }

        public virtual void SaveBooleanBJ(boolean value, integer key, integer missionKey, hashtable table)
        {
            SaveBoolean(table, missionKey, key, value);
        }

        public virtual boolean SaveStringBJ(@string value, integer key, integer missionKey, hashtable table)
        {
            return SaveStr(table, missionKey, key, value);
        }

        public virtual boolean SavePlayerHandleBJ(player whichPlayer, integer key, integer missionKey, hashtable table)
        {
            return SavePlayerHandle(table, missionKey, key, whichPlayer);
        }

        public virtual boolean SaveWidgetHandleBJ(widget whichWidget, integer key, integer missionKey, hashtable table)
        {
            return SaveWidgetHandle(table, missionKey, key, whichWidget);
        }

        public virtual boolean SaveDestructableHandleBJ(destructable whichDestructable, integer key, integer missionKey, hashtable table)
        {
            return SaveDestructableHandle(table, missionKey, key, whichDestructable);
        }

        public virtual boolean SaveItemHandleBJ(item whichItem, integer key, integer missionKey, hashtable table)
        {
            return SaveItemHandle(table, missionKey, key, whichItem);
        }

        public virtual boolean SaveUnitHandleBJ(unit whichUnit, integer key, integer missionKey, hashtable table)
        {
            return SaveUnitHandle(table, missionKey, key, whichUnit);
        }

        public virtual boolean SaveAbilityHandleBJ(ability whichAbility, integer key, integer missionKey, hashtable table)
        {
            return SaveAbilityHandle(table, missionKey, key, whichAbility);
        }

        public virtual boolean SaveTimerHandleBJ(timer whichTimer, integer key, integer missionKey, hashtable table)
        {
            return SaveTimerHandle(table, missionKey, key, whichTimer);
        }

        public virtual boolean SaveTriggerHandleBJ(trigger whichTrigger, integer key, integer missionKey, hashtable table)
        {
            return SaveTriggerHandle(table, missionKey, key, whichTrigger);
        }

        public virtual boolean SaveTriggerConditionHandleBJ(triggercondition whichTriggercondition, integer key, integer missionKey, hashtable table)
        {
            return SaveTriggerConditionHandle(table, missionKey, key, whichTriggercondition);
        }

        public virtual boolean SaveTriggerActionHandleBJ(triggeraction whichTriggeraction, integer key, integer missionKey, hashtable table)
        {
            return SaveTriggerActionHandle(table, missionKey, key, whichTriggeraction);
        }

        public virtual boolean SaveTriggerEventHandleBJ(@event whichEvent, integer key, integer missionKey, hashtable table)
        {
            return SaveTriggerEventHandle(table, missionKey, key, whichEvent);
        }

        public virtual boolean SaveForceHandleBJ(force whichForce, integer key, integer missionKey, hashtable table)
        {
            return SaveForceHandle(table, missionKey, key, whichForce);
        }

        public virtual boolean SaveGroupHandleBJ(group whichGroup, integer key, integer missionKey, hashtable table)
        {
            return SaveGroupHandle(table, missionKey, key, whichGroup);
        }

        public virtual boolean SaveLocationHandleBJ(location whichLocation, integer key, integer missionKey, hashtable table)
        {
            return SaveLocationHandle(table, missionKey, key, whichLocation);
        }

        public virtual boolean SaveRectHandleBJ(rect whichRect, integer key, integer missionKey, hashtable table)
        {
            return SaveRectHandle(table, missionKey, key, whichRect);
        }

        public virtual boolean SaveBooleanExprHandleBJ(boolexpr whichBoolexpr, integer key, integer missionKey, hashtable table)
        {
            return SaveBooleanExprHandle(table, missionKey, key, whichBoolexpr);
        }

        public virtual boolean SaveSoundHandleBJ(sound whichSound, integer key, integer missionKey, hashtable table)
        {
            return SaveSoundHandle(table, missionKey, key, whichSound);
        }

        public virtual boolean SaveEffectHandleBJ(effect whichEffect, integer key, integer missionKey, hashtable table)
        {
            return SaveEffectHandle(table, missionKey, key, whichEffect);
        }

        public virtual boolean SaveUnitPoolHandleBJ(unitpool whichUnitpool, integer key, integer missionKey, hashtable table)
        {
            return SaveUnitPoolHandle(table, missionKey, key, whichUnitpool);
        }

        public virtual boolean SaveItemPoolHandleBJ(itempool whichItempool, integer key, integer missionKey, hashtable table)
        {
            return SaveItemPoolHandle(table, missionKey, key, whichItempool);
        }

        public virtual boolean SaveQuestHandleBJ(quest whichQuest, integer key, integer missionKey, hashtable table)
        {
            return SaveQuestHandle(table, missionKey, key, whichQuest);
        }

        public virtual boolean SaveQuestItemHandleBJ(questitem whichQuestitem, integer key, integer missionKey, hashtable table)
        {
            return SaveQuestItemHandle(table, missionKey, key, whichQuestitem);
        }

        public virtual boolean SaveDefeatConditionHandleBJ(defeatcondition whichDefeatcondition, integer key, integer missionKey, hashtable table)
        {
            return SaveDefeatConditionHandle(table, missionKey, key, whichDefeatcondition);
        }

        public virtual boolean SaveTimerDialogHandleBJ(timerdialog whichTimerdialog, integer key, integer missionKey, hashtable table)
        {
            return SaveTimerDialogHandle(table, missionKey, key, whichTimerdialog);
        }

        public virtual boolean SaveLeaderboardHandleBJ(leaderboard whichLeaderboard, integer key, integer missionKey, hashtable table)
        {
            return SaveLeaderboardHandle(table, missionKey, key, whichLeaderboard);
        }

        public virtual boolean SaveMultiboardHandleBJ(multiboard whichMultiboard, integer key, integer missionKey, hashtable table)
        {
            return SaveMultiboardHandle(table, missionKey, key, whichMultiboard);
        }

        public virtual boolean SaveMultiboardItemHandleBJ(multiboarditem whichMultiboarditem, integer key, integer missionKey, hashtable table)
        {
            return SaveMultiboardItemHandle(table, missionKey, key, whichMultiboarditem);
        }

        public virtual boolean SaveTrackableHandleBJ(trackable whichTrackable, integer key, integer missionKey, hashtable table)
        {
            return SaveTrackableHandle(table, missionKey, key, whichTrackable);
        }

        public virtual boolean SaveDialogHandleBJ(dialog whichDialog, integer key, integer missionKey, hashtable table)
        {
            return SaveDialogHandle(table, missionKey, key, whichDialog);
        }

        public virtual boolean SaveButtonHandleBJ(button whichButton, integer key, integer missionKey, hashtable table)
        {
            return SaveButtonHandle(table, missionKey, key, whichButton);
        }

        public virtual boolean SaveTextTagHandleBJ(texttag whichTexttag, integer key, integer missionKey, hashtable table)
        {
            return SaveTextTagHandle(table, missionKey, key, whichTexttag);
        }

        public virtual boolean SaveLightningHandleBJ(lightning whichLightning, integer key, integer missionKey, hashtable table)
        {
            return SaveLightningHandle(table, missionKey, key, whichLightning);
        }

        public virtual boolean SaveImageHandleBJ(image whichImage, integer key, integer missionKey, hashtable table)
        {
            return SaveImageHandle(table, missionKey, key, whichImage);
        }

        public virtual boolean SaveUbersplatHandleBJ(ubersplat whichUbersplat, integer key, integer missionKey, hashtable table)
        {
            return SaveUbersplatHandle(table, missionKey, key, whichUbersplat);
        }

        public virtual boolean SaveRegionHandleBJ(region whichRegion, integer key, integer missionKey, hashtable table)
        {
            return SaveRegionHandle(table, missionKey, key, whichRegion);
        }

        public virtual boolean SaveFogStateHandleBJ(fogstate whichFogState, integer key, integer missionKey, hashtable table)
        {
            return SaveFogStateHandle(table, missionKey, key, whichFogState);
        }

        public virtual boolean SaveFogModifierHandleBJ(fogmodifier whichFogModifier, integer key, integer missionKey, hashtable table)
        {
            return SaveFogModifierHandle(table, missionKey, key, whichFogModifier);
        }

        public virtual boolean SaveAgentHandleBJ(agent whichAgent, integer key, integer missionKey, hashtable table)
        {
            return SaveAgentHandle(table, missionKey, key, whichAgent);
        }

        public virtual boolean SaveHashtableHandleBJ(hashtable whichHashtable, integer key, integer missionKey, hashtable table)
        {
            return SaveHashtableHandle(table, missionKey, key, whichHashtable);
        }

        public virtual real GetStoredRealBJ(@string key, @string missionKey, gamecache cache)
        {
            return GetStoredReal(cache, missionKey, key);
        }

        public virtual integer GetStoredIntegerBJ(@string key, @string missionKey, gamecache cache)
        {
            return GetStoredInteger(cache, missionKey, key);
        }

        public virtual boolean GetStoredBooleanBJ(@string key, @string missionKey, gamecache cache)
        {
            return GetStoredBoolean(cache, missionKey, key);
        }

        public virtual @string GetStoredStringBJ(@string key, @string missionKey, gamecache cache)
        {
            @string s;
            s = GetStoredString(cache, missionKey, key);
            if ((s == null))
            {
                return "";
            }
            else
            {
                return s;
            }
        }

        public virtual real LoadRealBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadReal(table, missionKey, key);
        }

        public virtual integer LoadIntegerBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadInteger(table, missionKey, key);
        }

        public virtual boolean LoadBooleanBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadBoolean(table, missionKey, key);
        }

        public virtual @string LoadStringBJ(integer key, integer missionKey, hashtable table)
        {
            @string s;
            s = LoadStr(table, missionKey, key);
            if ((s == null))
            {
                return "";
            }
            else
            {
                return s;
            }
        }

        public virtual player LoadPlayerHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadPlayerHandle(table, missionKey, key);
        }

        public virtual widget LoadWidgetHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadWidgetHandle(table, missionKey, key);
        }

        public virtual destructable LoadDestructableHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadDestructableHandle(table, missionKey, key);
        }

        public virtual item LoadItemHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadItemHandle(table, missionKey, key);
        }

        public virtual unit LoadUnitHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadUnitHandle(table, missionKey, key);
        }

        public virtual ability LoadAbilityHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadAbilityHandle(table, missionKey, key);
        }

        public virtual timer LoadTimerHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadTimerHandle(table, missionKey, key);
        }

        public virtual trigger LoadTriggerHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadTriggerHandle(table, missionKey, key);
        }

        public virtual triggercondition LoadTriggerConditionHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadTriggerConditionHandle(table, missionKey, key);
        }

        public virtual triggeraction LoadTriggerActionHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadTriggerActionHandle(table, missionKey, key);
        }

        public virtual @event LoadTriggerEventHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadTriggerEventHandle(table, missionKey, key);
        }

        public virtual force LoadForceHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadForceHandle(table, missionKey, key);
        }

        public virtual group LoadGroupHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadGroupHandle(table, missionKey, key);
        }

        public virtual location LoadLocationHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadLocationHandle(table, missionKey, key);
        }

        public virtual rect LoadRectHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadRectHandle(table, missionKey, key);
        }

        public virtual boolexpr LoadBooleanExprHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadBooleanExprHandle(table, missionKey, key);
        }

        public virtual sound LoadSoundHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadSoundHandle(table, missionKey, key);
        }

        public virtual effect LoadEffectHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadEffectHandle(table, missionKey, key);
        }

        public virtual unitpool LoadUnitPoolHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadUnitPoolHandle(table, missionKey, key);
        }

        public virtual itempool LoadItemPoolHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadItemPoolHandle(table, missionKey, key);
        }

        public virtual quest LoadQuestHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadQuestHandle(table, missionKey, key);
        }

        public virtual questitem LoadQuestItemHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadQuestItemHandle(table, missionKey, key);
        }

        public virtual defeatcondition LoadDefeatConditionHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadDefeatConditionHandle(table, missionKey, key);
        }

        public virtual timerdialog LoadTimerDialogHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadTimerDialogHandle(table, missionKey, key);
        }

        public virtual leaderboard LoadLeaderboardHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadLeaderboardHandle(table, missionKey, key);
        }

        public virtual multiboard LoadMultiboardHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadMultiboardHandle(table, missionKey, key);
        }

        public virtual multiboarditem LoadMultiboardItemHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadMultiboardItemHandle(table, missionKey, key);
        }

        public virtual trackable LoadTrackableHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadTrackableHandle(table, missionKey, key);
        }

        public virtual dialog LoadDialogHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadDialogHandle(table, missionKey, key);
        }

        public virtual button LoadButtonHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadButtonHandle(table, missionKey, key);
        }

        public virtual texttag LoadTextTagHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadTextTagHandle(table, missionKey, key);
        }

        public virtual lightning LoadLightningHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadLightningHandle(table, missionKey, key);
        }

        public virtual image LoadImageHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadImageHandle(table, missionKey, key);
        }

        public virtual ubersplat LoadUbersplatHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadUbersplatHandle(table, missionKey, key);
        }

        public virtual region LoadRegionHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadRegionHandle(table, missionKey, key);
        }

        public virtual fogstate LoadFogStateHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadFogStateHandle(table, missionKey, key);
        }

        public virtual fogmodifier LoadFogModifierHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadFogModifierHandle(table, missionKey, key);
        }

        public virtual hashtable LoadHashtableHandleBJ(integer key, integer missionKey, hashtable table)
        {
            return LoadHashtableHandle(table, missionKey, key);
        }

        public virtual unit RestoreUnitLocFacingAngleBJ(@string key, @string missionKey, gamecache cache, player forWhichPlayer, location loc, real facing)
        {
            bj_lastLoadedUnit = RestoreUnit(cache, missionKey, key, forWhichPlayer, GetLocationX(loc), GetLocationY(loc), facing);
            return bj_lastLoadedUnit;
        }

        public virtual unit RestoreUnitLocFacingPointBJ(@string key, @string missionKey, gamecache cache, player forWhichPlayer, location loc, location lookAt)
        {
            return RestoreUnitLocFacingAngleBJ(key, missionKey, cache, forWhichPlayer, loc, AngleBetweenPoints(loc, lookAt));
        }

        public virtual unit GetLastRestoredUnitBJ()
        {
            return bj_lastLoadedUnit;
        }

        public virtual void FlushGameCacheBJ(gamecache cache)
        {
            FlushGameCache(cache);
        }

        public virtual void FlushStoredMissionBJ(@string missionKey, gamecache cache)
        {
            FlushStoredMission(cache, missionKey);
        }

        public virtual void FlushParentHashtableBJ(hashtable table)
        {
            FlushParentHashtable(table);
        }

        public virtual void FlushChildHashtableBJ(integer missionKey, hashtable table)
        {
            FlushChildHashtable(table, missionKey);
        }

        public virtual boolean HaveStoredValue(@string key, integer valueType, @string missionKey, gamecache cache)
        {
            if ((valueType == bj_GAMECACHE_BOOLEAN))
            {
                return HaveStoredBoolean(cache, missionKey, key);
            }
            else
            {
                if ((valueType == bj_GAMECACHE_INTEGER))
                {
                    return HaveStoredInteger(cache, missionKey, key);
                }
                else
                {
                    if ((valueType == bj_GAMECACHE_REAL))
                    {
                        return HaveStoredReal(cache, missionKey, key);
                    }
                    else
                    {
                        if ((valueType == bj_GAMECACHE_UNIT))
                        {
                            return HaveStoredUnit(cache, missionKey, key);
                        }
                        else
                        {
                            if ((valueType == bj_GAMECACHE_STRING))
                            {
                                return HaveStoredString(cache, missionKey, key);
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
        }

        public virtual boolean HaveSavedValue(integer key, integer valueType, integer missionKey, hashtable table)
        {
            if ((valueType == bj_HASHTABLE_BOOLEAN))
            {
                return HaveSavedBoolean(table, missionKey, key);
            }
            else
            {
                if ((valueType == bj_HASHTABLE_INTEGER))
                {
                    return HaveSavedInteger(table, missionKey, key);
                }
                else
                {
                    if ((valueType == bj_HASHTABLE_REAL))
                    {
                        return HaveSavedReal(table, missionKey, key);
                    }
                    else
                    {
                        if ((valueType == bj_HASHTABLE_STRING))
                        {
                            return HaveSavedString(table, missionKey, key);
                        }
                        else
                        {
                            if ((valueType == bj_HASHTABLE_HANDLE))
                            {
                                return HaveSavedHandle(table, missionKey, key);
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
        }

        public virtual void ShowCustomCampaignButton(boolean show, integer whichButton)
        {
            SetCustomCampaignButtonVisible(whichButton - 1, show);
        }

        public virtual boolean IsCustomCampaignButtonVisibile(integer whichButton)
        {
            return GetCustomCampaignButtonVisible(whichButton - 1);
        }

        public virtual void LoadGameBJ(@string loadFileName, boolean doScoreScreen)
        {
            LoadGame(loadFileName, doScoreScreen);
        }

        public virtual void SaveAndChangeLevelBJ(@string saveFileName, @string newLevel, boolean doScoreScreen)
        {
            SaveGame(saveFileName);
            ChangeLevel(newLevel, doScoreScreen);
        }

        public virtual void SaveAndLoadGameBJ(@string saveFileName, @string loadFileName, boolean doScoreScreen)
        {
            SaveGame(saveFileName);
            LoadGame(loadFileName, doScoreScreen);
        }

        public virtual boolean RenameSaveDirectoryBJ(@string sourceDirName, @string destDirName)
        {
            return RenameSaveDirectory(sourceDirName, destDirName);
        }

        public virtual boolean RemoveSaveDirectoryBJ(@string sourceDirName)
        {
            return RemoveSaveDirectory(sourceDirName);
        }

        public virtual boolean CopySaveGameBJ(@string sourceSaveName, @string destSaveName)
        {
            return CopySaveGame(sourceSaveName, destSaveName);
        }

        public virtual real GetPlayerStartLocationX(player whichPlayer)
        {
            return GetStartLocationX(GetPlayerStartLocation(whichPlayer));
        }

        public virtual real GetPlayerStartLocationY(player whichPlayer)
        {
            return GetStartLocationY(GetPlayerStartLocation(whichPlayer));
        }

        public virtual location GetPlayerStartLocationLoc(player whichPlayer)
        {
            return GetStartLocationLoc(GetPlayerStartLocation(whichPlayer));
        }

        public virtual location GetRectCenter(rect whichRect)
        {
            return Location(GetRectCenterX(whichRect), GetRectCenterY(whichRect));
        }

        public virtual boolean IsPlayerSlotState(player whichPlayer, playerslotstate whichState)
        {
            return GetPlayerSlotState(whichPlayer) == whichState;
        }

        public virtual integer GetFadeFromSeconds(real seconds)
        {
            if ((seconds != 0))
            {
                return 128 / R2I(seconds);
            }
            return 10000;
        }

        public virtual real GetFadeFromSecondsAsReal(real seconds)
        {
            if ((seconds != 0))
            {
                return 128f / seconds;
            }
            return 10000f;
        }

        public virtual void AdjustPlayerStateSimpleBJ(player whichPlayer, playerstate whichPlayerState, integer delta)
        {
            SetPlayerState(whichPlayer, whichPlayerState, GetPlayerState(whichPlayer, whichPlayerState) + delta);
        }

        public virtual void AdjustPlayerStateBJ(integer delta, player whichPlayer, playerstate whichPlayerState)
        {
            if ((delta > 0))
            {
                if ((whichPlayerState == PLAYER_STATE_RESOURCE_GOLD))
                {
                    AdjustPlayerStateSimpleBJ(whichPlayer, PLAYER_STATE_GOLD_GATHERED, delta);
                }
                else
                {
                    if ((whichPlayerState == PLAYER_STATE_RESOURCE_LUMBER))
                    {
                        AdjustPlayerStateSimpleBJ(whichPlayer, PLAYER_STATE_LUMBER_GATHERED, delta);
                    }
                }
            }
            AdjustPlayerStateSimpleBJ(whichPlayer, whichPlayerState, delta);
        }

        public virtual void SetPlayerStateBJ(player whichPlayer, playerstate whichPlayerState, integer value)
        {
            integer oldValue = GetPlayerState(whichPlayer, whichPlayerState);
            AdjustPlayerStateBJ(value - oldValue, whichPlayer, whichPlayerState);
        }

        public virtual void SetPlayerFlagBJ(playerstate whichPlayerFlag, boolean flag, player whichPlayer)
        {
            SetPlayerState(whichPlayer, whichPlayerFlag, IntegerTertiaryOp(flag, 1, 0));
        }

        public virtual void SetPlayerTaxRateBJ(integer rate, playerstate whichResource, player sourcePlayer, player otherPlayer)
        {
            SetPlayerTaxRate(sourcePlayer, otherPlayer, whichResource, rate);
        }

        public virtual integer GetPlayerTaxRateBJ(playerstate whichResource, player sourcePlayer, player otherPlayer)
        {
            return GetPlayerTaxRate(sourcePlayer, otherPlayer, whichResource);
        }

        public virtual boolean IsPlayerFlagSetBJ(playerstate whichPlayerFlag, player whichPlayer)
        {
            return GetPlayerState(whichPlayer, whichPlayerFlag) == 1;
        }

        public virtual void AddResourceAmountBJ(integer delta, unit whichUnit)
        {
            AddResourceAmount(whichUnit, delta);
        }

        public virtual integer GetConvertedPlayerId(player whichPlayer)
        {
            return GetPlayerId(whichPlayer) + 1;
        }

        public virtual player ConvertedPlayer(integer convertedPlayerId)
        {
            return Player(convertedPlayerId - 1);
        }

        public virtual real GetRectWidthBJ(rect r)
        {
            return GetRectMaxX(r) - GetRectMinX(r);
        }

        public virtual real GetRectHeightBJ(rect r)
        {
            return GetRectMaxY(r) - GetRectMinY(r);
        }

        public virtual unit BlightGoldMineForPlayerBJ(unit goldMine, player whichPlayer)
        {
            real mineX = 0;
            real mineY = 0;
            integer mineGold = 0;
            unit newMine;
            if (GetUnitTypeId(goldMine) != 1819240302)
            {
                return null;
            }
            mineX = GetUnitX(goldMine);
            mineY = GetUnitY(goldMine);
            mineGold = GetResourceAmount(goldMine);
            RemoveUnit(goldMine);
            newMine = CreateBlightedGoldmine(whichPlayer, mineX, mineY, bj_UNIT_FACING);
            SetResourceAmount(newMine, mineGold);
            return newMine;
        }

        public virtual unit BlightGoldMineForPlayer(unit goldMine, player whichPlayer)
        {
            bj_lastHauntedGoldMine = BlightGoldMineForPlayerBJ(goldMine, whichPlayer);
            return bj_lastHauntedGoldMine;
        }

        public virtual unit GetLastHauntedGoldMine()
        {
            return bj_lastHauntedGoldMine;
        }

        public virtual boolean IsPointBlightedBJ(location where)
        {
            return IsPointBlighted(GetLocationX(where), GetLocationY(where));
        }

        public virtual void SetPlayerColorBJEnum()
        {
            SetUnitColor(GetEnumUnit(), bj_setPlayerTargetColor);
        }

        public virtual void SetPlayerColorBJ(player whichPlayer, playercolor color, boolean changeExisting)
        {
            group g;
            SetPlayerColor(whichPlayer, color);
            if (changeExisting)
            {
                bj_setPlayerTargetColor = color;
                g = CreateGroup();
                GroupEnumUnitsOfPlayer(g, whichPlayer, null);
                ForGroup(g, SetPlayerColorBJEnum);
                DestroyGroup(g);
            }
        }

        public virtual void SetPlayerUnitAvailableBJ(integer unitId, boolean allowed, player whichPlayer)
        {
            if (allowed)
            {
                SetPlayerTechMaxAllowed(whichPlayer, unitId, -1);
            }
            else
            {
                SetPlayerTechMaxAllowed(whichPlayer, unitId, 0);
            }
        }

        public virtual void LockGameSpeedBJ()
        {
            SetMapFlag(MAP_LOCK_SPEED, true);
        }

        public virtual void UnlockGameSpeedBJ()
        {
            SetMapFlag(MAP_LOCK_SPEED, false);
        }

        public virtual boolean IssueTargetOrderBJ(unit whichUnit, @string order, widget targetWidget)
        {
            return IssueTargetOrder(whichUnit, order, targetWidget);
        }

        public virtual boolean IssuePointOrderLocBJ(unit whichUnit, @string order, location whichLocation)
        {
            return IssuePointOrderLoc(whichUnit, order, whichLocation);
        }

        public virtual boolean IssueTargetDestructableOrder(unit whichUnit, @string order, widget targetWidget)
        {
            return IssueTargetOrder(whichUnit, order, targetWidget);
        }

        public virtual boolean IssueTargetItemOrder(unit whichUnit, @string order, widget targetWidget)
        {
            return IssueTargetOrder(whichUnit, order, targetWidget);
        }

        public virtual boolean IssueImmediateOrderBJ(unit whichUnit, @string order)
        {
            return IssueImmediateOrder(whichUnit, order);
        }

        public virtual boolean GroupTargetOrderBJ(group whichGroup, @string order, widget targetWidget)
        {
            return GroupTargetOrder(whichGroup, order, targetWidget);
        }

        public virtual boolean GroupPointOrderLocBJ(group whichGroup, @string order, location whichLocation)
        {
            return GroupPointOrderLoc(whichGroup, order, whichLocation);
        }

        public virtual boolean GroupImmediateOrderBJ(group whichGroup, @string order)
        {
            return GroupImmediateOrder(whichGroup, order);
        }

        public virtual boolean GroupTargetDestructableOrder(group whichGroup, @string order, widget targetWidget)
        {
            return GroupTargetOrder(whichGroup, order, targetWidget);
        }

        public virtual boolean GroupTargetItemOrder(group whichGroup, @string order, widget targetWidget)
        {
            return GroupTargetOrder(whichGroup, order, targetWidget);
        }

        public virtual destructable GetDyingDestructable()
        {
            return GetTriggerDestructable();
        }

        public virtual void SetUnitRallyPoint(unit whichUnit, location targPos)
        {
            IssuePointOrderLocBJ(whichUnit, "setrally", targPos);
        }

        public virtual void SetUnitRallyUnit(unit whichUnit, unit targUnit)
        {
            IssueTargetOrder(whichUnit, "setrally", targUnit);
        }

        public virtual void SetUnitRallyDestructable(unit whichUnit, destructable targDest)
        {
            IssueTargetOrder(whichUnit, "setrally", targDest);
        }

        public virtual void SaveDyingWidget()
        {
            bj_lastDyingWidget = GetTriggerWidget();
        }

        public virtual void SetBlightRectBJ(boolean addBlight, player whichPlayer, rect r)
        {
            SetBlightRect(whichPlayer, r, addBlight);
        }

        public virtual void SetBlightRadiusLocBJ(boolean addBlight, player whichPlayer, location loc, real radius)
        {
            SetBlightLoc(whichPlayer, loc, radius, addBlight);
        }

        public virtual @string GetAbilityName(integer abilcode)
        {
            return GetObjectName(abilcode);
        }

        public virtual void MeleeStartingVisibility()
        {
            SetFloatGameState(GAME_STATE_TIME_OF_DAY, bj_MELEE_STARTING_TOD);
        }

        public virtual void MeleeStartingResources()
        {
            integer index = 0;
            player indexPlayer;
            version v;
            integer startingGold = 0;
            integer startingLumber = 0;
            v = VersionGet();
            if ((v == VERSION_REIGN_OF_CHAOS))
            {
                startingGold = bj_MELEE_STARTING_GOLD_V0;
                startingLumber = bj_MELEE_STARTING_LUMBER_V0;
            }
            else
            {
                startingGold = bj_MELEE_STARTING_GOLD_V1;
                startingLumber = bj_MELEE_STARTING_LUMBER_V1;
            }
            index = 0;
            for (
            ; true;
            )
            {
                indexPlayer = Player(index);
                if ((GetPlayerSlotState(indexPlayer) == PLAYER_SLOT_STATE_PLAYING))
                {
                    SetPlayerState(indexPlayer, PLAYER_STATE_RESOURCE_GOLD, startingGold);
                    SetPlayerState(indexPlayer, PLAYER_STATE_RESOURCE_LUMBER, startingLumber);
                }
                index = index + 1;
                if (index == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
        }

        public virtual void ReducePlayerTechMaxAllowed(player whichPlayer, integer techId, integer limit)
        {
            integer oldMax = GetPlayerTechMaxAllowed(whichPlayer, techId);
            if ((oldMax < 0 || oldMax > limit))
            {
                SetPlayerTechMaxAllowed(whichPlayer, techId, limit);
            }
        }

        public virtual void MeleeStartingHeroLimit()
        {
            integer index = 0;
            index = 0;
            for (
            ; true;
            )
            {
                SetPlayerMaxHeroesAllowed(bj_MELEE_HERO_LIMIT, Player(index));
                ReducePlayerTechMaxAllowed(Player(index), 1735221576, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1735093576, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1818325064, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1835819592, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1634493007, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1918985807, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1751348303, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1684566863, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1835361349, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1701145413, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1869573445, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1918990149, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1634034773, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1701995605, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1667853397, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1819435861, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1835167822, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1852990030, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1936158286, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1751937102, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1953718862, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1668047182, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1852404814, bj_MELEE_HERO_TYPE_LIMIT);
                ReducePlayerTechMaxAllowed(Player(index), 1919510094, bj_MELEE_HERO_TYPE_LIMIT);
                index = index + 1;
                if (index == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
        }

        public virtual boolean MeleeTrainedUnitIsHeroBJFilter()
        {
            return IsUnitType(GetFilterUnit(), UNIT_TYPE_HERO);
        }

        public virtual void MeleeGrantItemsToHero(unit whichUnit)
        {
            integer owner = GetPlayerId(GetOwningPlayer(whichUnit));
            if ((bj_meleeTwinkedHeroes[owner] < bj_MELEE_MAX_TWINKED_HEROES))
            {
                UnitAddItemById(whichUnit, 1886876787);
                bj_meleeTwinkedHeroes[owner] = bj_meleeTwinkedHeroes[owner] + 1;
            }
        }

        public virtual void MeleeGrantItemsToTrainedHero()
        {
            MeleeGrantItemsToHero(GetTrainedUnit());
        }

        public virtual void MeleeGrantItemsToHiredHero()
        {
            MeleeGrantItemsToHero(GetSoldUnit());
        }

        public virtual void MeleeGrantHeroItems()
        {
            integer index = 0;
            trigger trig;
            index = 0;
            for (
            ; true;
            )
            {
                bj_meleeTwinkedHeroes[index] = 0;
                index = index + 1;
                if (index == bj_MAX_PLAYER_SLOTS)
                {
                    break;
                }
            }
            index = 0;
            for (
            ; true;
            )
            {
                trig = CreateTrigger();
                TriggerRegisterPlayerUnitEvent(trig, Player(index), EVENT_PLAYER_UNIT_TRAIN_FINISH, filterMeleeTrainedUnitIsHeroBJ);
                TriggerAddAction(trig, MeleeGrantItemsToTrainedHero);
                index = index + 1;
                if (index == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
            trig = CreateTrigger();
            TriggerRegisterPlayerUnitEvent(trig, Player(PLAYER_NEUTRAL_PASSIVE), EVENT_PLAYER_UNIT_SELL, filterMeleeTrainedUnitIsHeroBJ);
            TriggerAddAction(trig, MeleeGrantItemsToHiredHero);
            bj_meleeGrantHeroItems = true;
        }

        public virtual void MeleeClearExcessUnit()
        {
            unit theUnit = GetEnumUnit();
            integer owner = GetPlayerId(GetOwningPlayer(theUnit));
            if ((owner == PLAYER_NEUTRAL_AGGRESSIVE))
            {
                RemoveUnit(GetEnumUnit());
            }
            else
            {
                if ((owner == PLAYER_NEUTRAL_PASSIVE))
                {
                    if (!IsUnitType(theUnit, UNIT_TYPE_STRUCTURE))
                    {
                        RemoveUnit(GetEnumUnit());
                    }
                }
            }
        }

        public virtual void MeleeClearNearbyUnits(real x, real y, real range)
        {
            group nearbyUnits;
            nearbyUnits = CreateGroup();
            GroupEnumUnitsInRange(nearbyUnits, x, y, range, null);
            ForGroup(nearbyUnits, MeleeClearExcessUnit);
            DestroyGroup(nearbyUnits);
        }

        public virtual void MeleeClearExcessUnits()
        {
            integer index = 0;
            real locX = 0;
            real locY = 0;
            player indexPlayer;
            index = 0;
            for (
            ; true;
            )
            {
                indexPlayer = Player(index);
                if ((GetPlayerSlotState(indexPlayer) == PLAYER_SLOT_STATE_PLAYING))
                {
                    locX = GetStartLocationX(GetPlayerStartLocation(indexPlayer));
                    locY = GetStartLocationY(GetPlayerStartLocation(indexPlayer));
                    MeleeClearNearbyUnits(locX, locY, bj_MELEE_CLEAR_UNITS_RADIUS);
                }
                index = index + 1;
                if (index == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
        }

        public virtual void MeleeEnumFindNearestMine()
        {
            unit enumUnit = GetEnumUnit();
            real dist = 0;
            location unitLoc;
            if ((GetUnitTypeId(enumUnit) == 1819240302))
            {
                unitLoc = GetUnitLoc(enumUnit);
                dist = DistanceBetweenPoints(unitLoc, bj_meleeNearestMineToLoc);
                RemoveLocation(unitLoc);
                if ((bj_meleeNearestMineDist < 0) || (dist < bj_meleeNearestMineDist))
                {
                    bj_meleeNearestMine = enumUnit;
                    bj_meleeNearestMineDist = dist;
                }
            }
        }

        public virtual unit MeleeFindNearestMine(location src, real range)
        {
            group nearbyMines;
            bj_meleeNearestMine = null;
            bj_meleeNearestMineDist = -1;
            bj_meleeNearestMineToLoc = src;
            nearbyMines = CreateGroup();
            GroupEnumUnitsInRangeOfLoc(nearbyMines, src, range, null);
            ForGroup(nearbyMines, MeleeEnumFindNearestMine);
            DestroyGroup(nearbyMines);
            return bj_meleeNearestMine;
        }

        public virtual unit MeleeRandomHeroLoc(player p, integer id1, integer id2, integer id3, integer id4, location loc)
        {
            unit hero = null;
            integer roll = 0;
            integer pick = 0;
            version v;
            v = VersionGet();
            if ((v == VERSION_REIGN_OF_CHAOS))
            {
                roll = GetRandomInt(1, 3);
            }
            else
            {
                roll = GetRandomInt(1, 4);
            }
            if (roll == 1)
            {
                pick = id1;
            }
            else
            {
                if (roll == 2)
                {
                    pick = id2;
                }
                else
                {
                    if (roll == 3)
                    {
                        pick = id3;
                    }
                    else
                    {
                        if (roll == 4)
                        {
                            pick = id4;
                        }
                        else
                        {
                            pick = id1;
                        }
                    }
                }
            }
            hero = CreateUnitAtLoc(p, pick, loc, bj_UNIT_FACING);
            if (bj_meleeGrantHeroItems)
            {
                MeleeGrantItemsToHero(hero);
            }
            return hero;
        }

        public virtual location MeleeGetProjectedLoc(location src, location targ, real distance, real deltaAngle)
        {
            real srcX = GetLocationX(src);
            real srcY = GetLocationY(src);
            real direction = Atan2(GetLocationY(targ) - srcY, GetLocationX(targ) - srcX) + deltaAngle;
            return Location(srcX + distance * Cos(direction), srcY + distance * Sin(direction));
        }

        public virtual real MeleeGetNearestValueWithin(real val, real minVal, real maxVal)
        {
            if ((val < minVal))
            {
                return minVal;
            }
            else
            {
                if ((val > maxVal))
                {
                    return maxVal;
                }
                else
                {
                    return val;
                }
            }
        }

        public virtual location MeleeGetLocWithinRect(location src, rect r)
        {
            real withinX = MeleeGetNearestValueWithin(GetLocationX(src), GetRectMinX(r), GetRectMaxX(r));
            real withinY = MeleeGetNearestValueWithin(GetLocationY(src), GetRectMinY(r), GetRectMaxY(r));
            return Location(withinX, withinY);
        }

        public virtual void MeleeStartingUnitsHuman(player whichPlayer, location startLoc, boolean doHeroes, boolean doCamera, boolean doPreload)
        {
            boolean useRandomHero = IsMapFlagSet(MAP_RANDOM_HERO);
            real unitSpacing = 64f;
            unit nearestMine;
            location nearMineLoc;
            location heroLoc;
            real peonX = 0;
            real peonY = 0;
            unit townHall = null;
            if ((doPreload))
            {
                Preloader("scripts\\HumanMelee.pld");
            }
            nearestMine = MeleeFindNearestMine(startLoc, bj_MELEE_MINE_SEARCH_RADIUS);
            if ((nearestMine != null))
            {
                townHall = CreateUnitAtLoc(whichPlayer, 2003793000, startLoc, bj_UNIT_FACING);
                nearMineLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 320, 0);
                peonX = GetLocationX(nearMineLoc);
                peonY = GetLocationY(nearMineLoc);
                CreateUnit(whichPlayer, 1634037864, peonX + 0f * unitSpacing, peonY + 1f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1634037864, peonX + 1f * unitSpacing, peonY + 0.15f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1634037864, peonX - 1f * unitSpacing, peonY + 0.15f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1634037864, peonX + 0.6f * unitSpacing, peonY - 1f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1634037864, peonX - 0.6f * unitSpacing, peonY - 1f * unitSpacing, bj_UNIT_FACING);
                heroLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 384, 45);
            }
            else
            {
                townHall = CreateUnitAtLoc(whichPlayer, 2003793000, startLoc, bj_UNIT_FACING);
                peonX = GetLocationX(startLoc);
                peonY = GetLocationY(startLoc) - 224f;
                CreateUnit(whichPlayer, 1634037864, peonX + 2f * unitSpacing, peonY + 0f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1634037864, peonX + 1f * unitSpacing, peonY + 0f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1634037864, peonX + 0f * unitSpacing, peonY + 0f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1634037864, peonX - 1f * unitSpacing, peonY + 0f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1634037864, peonX - 2f * unitSpacing, peonY + 0f * unitSpacing, bj_UNIT_FACING);
                heroLoc = Location(peonX, peonY - 2f * unitSpacing);
            }
            if ((townHall != null))
            {
                UnitAddAbilityBJ(1667853633, townHall);
                UnitMakeAbilityPermanentBJ(true, 1667853633, townHall);
            }
            if ((doHeroes))
            {
                if (useRandomHero)
                {
                    MeleeRandomHeroLoc(whichPlayer, 1735221576, 1735093576, 1818325064, 1835819592, heroLoc);
                }
                else
                {
                    SetPlayerState(whichPlayer, PLAYER_STATE_RESOURCE_HERO_TOKENS, bj_MELEE_STARTING_HERO_TOKENS);
                }
            }
            if ((doCamera))
            {
                SetCameraPositionForPlayer(whichPlayer, peonX, peonY);
                SetCameraQuickPositionForPlayer(whichPlayer, peonX, peonY);
            }
        }

        public virtual void MeleeStartingUnitsOrc(player whichPlayer, location startLoc, boolean doHeroes, boolean doCamera, boolean doPreload)
        {
            boolean useRandomHero = IsMapFlagSet(MAP_RANDOM_HERO);
            real unitSpacing = 64f;
            unit nearestMine;
            location nearMineLoc;
            location heroLoc;
            real peonX = 0;
            real peonY = 0;
            if ((doPreload))
            {
                Preloader("scripts\\OrcMelee.pld");
            }
            nearestMine = MeleeFindNearestMine(startLoc, bj_MELEE_MINE_SEARCH_RADIUS);
            if ((nearestMine != null))
            {
                CreateUnitAtLoc(whichPlayer, 1701996399, startLoc, bj_UNIT_FACING);
                nearMineLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 320, 0);
                peonX = GetLocationX(nearMineLoc);
                peonY = GetLocationY(nearMineLoc);
                CreateUnit(whichPlayer, 1868918895, peonX + 0f * unitSpacing, peonY + 1f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1868918895, peonX + 1f * unitSpacing, peonY + 0.15f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1868918895, peonX - 1f * unitSpacing, peonY + 0.15f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1868918895, peonX + 0.6f * unitSpacing, peonY - 1f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1868918895, peonX - 0.6f * unitSpacing, peonY - 1f * unitSpacing, bj_UNIT_FACING);
                heroLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 384, 45);
            }
            else
            {
                CreateUnitAtLoc(whichPlayer, 1701996399, startLoc, bj_UNIT_FACING);
                peonX = GetLocationX(startLoc);
                peonY = GetLocationY(startLoc) - 224f;
                CreateUnit(whichPlayer, 1868918895, peonX + 2f * unitSpacing, peonY + 0f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1868918895, peonX + 1f * unitSpacing, peonY + 0f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1868918895, peonX + 0f * unitSpacing, peonY + 0f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1868918895, peonX - 1f * unitSpacing, peonY + 0f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1868918895, peonX - 2f * unitSpacing, peonY + 0f * unitSpacing, bj_UNIT_FACING);
                heroLoc = Location(peonX, peonY - 2f * unitSpacing);
            }
            if ((doHeroes))
            {
                if (useRandomHero)
                {
                    MeleeRandomHeroLoc(whichPlayer, 1634493007, 1918985807, 1751348303, 1684566863, heroLoc);
                }
                else
                {
                    SetPlayerState(whichPlayer, PLAYER_STATE_RESOURCE_HERO_TOKENS, bj_MELEE_STARTING_HERO_TOKENS);
                }
            }
            if ((doCamera))
            {
                SetCameraPositionForPlayer(whichPlayer, peonX, peonY);
                SetCameraQuickPositionForPlayer(whichPlayer, peonX, peonY);
            }
        }

        public virtual void MeleeStartingUnitsUndead(player whichPlayer, location startLoc, boolean doHeroes, boolean doCamera, boolean doPreload)
        {
            boolean useRandomHero = IsMapFlagSet(MAP_RANDOM_HERO);
            real unitSpacing = 64f;
            unit nearestMine;
            location nearMineLoc;
            location nearTownLoc;
            location heroLoc;
            real peonX = 0;
            real peonY = 0;
            real ghoulX = 0;
            real ghoulY = 0;
            if ((doPreload))
            {
                Preloader("scripts\\UndeadMelee.pld");
            }
            nearestMine = MeleeFindNearestMine(startLoc, bj_MELEE_MINE_SEARCH_RADIUS);
            if ((nearestMine != null))
            {
                CreateUnitAtLoc(whichPlayer, 1819307637, startLoc, bj_UNIT_FACING);
                nearestMine = BlightGoldMineForPlayerBJ(nearestMine, whichPlayer);
                nearTownLoc = MeleeGetProjectedLoc(startLoc, GetUnitLoc(nearestMine), 288, 0);
                ghoulX = GetLocationX(nearTownLoc);
                ghoulY = GetLocationY(nearTownLoc);
                bj_ghoul[GetPlayerId(whichPlayer)] = CreateUnit(whichPlayer, 1869113205, ghoulX + 0f * unitSpacing, ghoulY + 0f * unitSpacing, bj_UNIT_FACING);
                nearMineLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 320, 0);
                peonX = GetLocationX(nearMineLoc);
                peonY = GetLocationY(nearMineLoc);
                CreateUnit(whichPlayer, 1868783989, peonX + 0f * unitSpacing, peonY + 0.5f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1868783989, peonX + 0.65f * unitSpacing, peonY - 0.5f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1868783989, peonX - 0.65f * unitSpacing, peonY - 0.5f * unitSpacing, bj_UNIT_FACING);
                SetBlightLoc(whichPlayer, nearMineLoc, 768, true);
                heroLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 384, 45);
            }
            else
            {
                CreateUnitAtLoc(whichPlayer, 1819307637, startLoc, bj_UNIT_FACING);
                peonX = GetLocationX(startLoc);
                peonY = GetLocationY(startLoc) - 224f;
                CreateUnit(whichPlayer, 1868783989, peonX - 1.5f * unitSpacing, peonY + 0f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1868783989, peonX - 0.5f * unitSpacing, peonY + 0f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1868783989, peonX + 0.5f * unitSpacing, peonY + 0f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1869113205, peonX + 1.5f * unitSpacing, peonY + 0f * unitSpacing, bj_UNIT_FACING);
                SetBlightLoc(whichPlayer, startLoc, 768, true);
                heroLoc = Location(peonX, peonY - 2f * unitSpacing);
            }
            if ((doHeroes))
            {
                if (useRandomHero)
                {
                    MeleeRandomHeroLoc(whichPlayer, 1634034773, 1701995605, 1667853397, 1819435861, heroLoc);
                }
                else
                {
                    SetPlayerState(whichPlayer, PLAYER_STATE_RESOURCE_HERO_TOKENS, bj_MELEE_STARTING_HERO_TOKENS);
                }
            }
            if ((doCamera))
            {
                SetCameraPositionForPlayer(whichPlayer, peonX, peonY);
                SetCameraQuickPositionForPlayer(whichPlayer, peonX, peonY);
            }
        }

        public virtual void MeleeStartingUnitsNightElf(player whichPlayer, location startLoc, boolean doHeroes, boolean doCamera, boolean doPreload)
        {
            boolean useRandomHero = IsMapFlagSet(MAP_RANDOM_HERO);
            real unitSpacing = 64f;
            real minTreeDist = 3.5f * bj_CELLWIDTH;
            real minWispDist = 1.75f * bj_CELLWIDTH;
            unit nearestMine;
            location nearMineLoc;
            location wispLoc;
            location heroLoc;
            real peonX = 0;
            real peonY = 0;
            unit tree;
            if ((doPreload))
            {
                Preloader("scripts\\NightElfMelee.pld");
            }
            nearestMine = MeleeFindNearestMine(startLoc, bj_MELEE_MINE_SEARCH_RADIUS);
            if ((nearestMine != null))
            {
                nearMineLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 650, 0);
                nearMineLoc = MeleeGetLocWithinRect(nearMineLoc, GetRectFromCircleBJ(GetUnitLoc(nearestMine), minTreeDist));
                tree = CreateUnitAtLoc(whichPlayer, 1819243621, nearMineLoc, bj_UNIT_FACING);
                IssueTargetOrder(tree, "entangleinstant", nearestMine);
                wispLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 320, 0);
                wispLoc = MeleeGetLocWithinRect(wispLoc, GetRectFromCircleBJ(GetUnitLoc(nearestMine), minWispDist));
                peonX = GetLocationX(wispLoc);
                peonY = GetLocationY(wispLoc);
                CreateUnit(whichPlayer, 1886615397, peonX + 0f * unitSpacing, peonY + 1f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1886615397, peonX + 1f * unitSpacing, peonY + 0.15f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1886615397, peonX - 1f * unitSpacing, peonY + 0.15f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1886615397, peonX + 0.58f * unitSpacing, peonY - 1f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1886615397, peonX - 0.58f * unitSpacing, peonY - 1f * unitSpacing, bj_UNIT_FACING);
                heroLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 384, 45);
            }
            else
            {
                CreateUnitAtLoc(whichPlayer, 1819243621, startLoc, bj_UNIT_FACING);
                peonX = GetLocationX(startLoc);
                peonY = GetLocationY(startLoc) - 224f;
                CreateUnit(whichPlayer, 1886615397, peonX - 2f * unitSpacing, peonY + 0f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1886615397, peonX - 1f * unitSpacing, peonY + 0f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1886615397, peonX + 0f * unitSpacing, peonY + 0f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1886615397, peonX + 1f * unitSpacing, peonY + 0f * unitSpacing, bj_UNIT_FACING);
                CreateUnit(whichPlayer, 1886615397, peonX + 2f * unitSpacing, peonY + 0f * unitSpacing, bj_UNIT_FACING);
                heroLoc = Location(peonX, peonY - 2f * unitSpacing);
            }
            if ((doHeroes))
            {
                if (useRandomHero)
                {
                    MeleeRandomHeroLoc(whichPlayer, 1835361349, 1701145413, 1869573445, 1918990149, heroLoc);
                }
                else
                {
                    SetPlayerState(whichPlayer, PLAYER_STATE_RESOURCE_HERO_TOKENS, bj_MELEE_STARTING_HERO_TOKENS);
                }
            }
            if ((doCamera))
            {
                SetCameraPositionForPlayer(whichPlayer, peonX, peonY);
                SetCameraQuickPositionForPlayer(whichPlayer, peonX, peonY);
            }
        }

        public virtual void MeleeStartingUnitsUnknownRace(player whichPlayer, location startLoc, boolean doHeroes, boolean doCamera, boolean doPreload)
        {
            integer index = 0;
            if ((doPreload))
            {
            }
            index = 0;
            for (
            ; true;
            )
            {
                CreateUnit(whichPlayer, 1701344110, GetLocationX(startLoc) + GetRandomReal(-256, 256), GetLocationY(startLoc) + GetRandomReal(-256, 256), GetRandomReal(0, 360));
                index = index + 1;
                if (index == 12)
                {
                    break;
                }
            }
            if ((doHeroes))
            {
                SetPlayerState(whichPlayer, PLAYER_STATE_RESOURCE_HERO_TOKENS, bj_MELEE_STARTING_HERO_TOKENS);
            }
            if ((doCamera))
            {
                SetCameraPositionLocForPlayer(whichPlayer, startLoc);
                SetCameraQuickPositionLocForPlayer(whichPlayer, startLoc);
            }
        }

        public virtual void MeleeStartingUnits()
        {
            integer index = 0;
            player indexPlayer;
            location indexStartLoc;
            race indexRace;
            Preloader("scripts\\SharedMelee.pld");
            index = 0;
            for (
            ; true;
            )
            {
                indexPlayer = Player(index);
                if ((GetPlayerSlotState(indexPlayer) == PLAYER_SLOT_STATE_PLAYING))
                {
                    indexStartLoc = GetStartLocationLoc(GetPlayerStartLocation(indexPlayer));
                    indexRace = GetPlayerRace(indexPlayer);
                    if ((indexRace == RACE_HUMAN))
                    {
                        MeleeStartingUnitsHuman(indexPlayer, indexStartLoc, true, true, true);
                    }
                    else
                    {
                        if ((indexRace == RACE_ORC))
                        {
                            MeleeStartingUnitsOrc(indexPlayer, indexStartLoc, true, true, true);
                        }
                        else
                        {
                            if ((indexRace == RACE_UNDEAD))
                            {
                                MeleeStartingUnitsUndead(indexPlayer, indexStartLoc, true, true, true);
                            }
                            else
                            {
                                if ((indexRace == RACE_NIGHTELF))
                                {
                                    MeleeStartingUnitsNightElf(indexPlayer, indexStartLoc, true, true, true);
                                }
                                else
                                {
                                    MeleeStartingUnitsUnknownRace(indexPlayer, indexStartLoc, true, true, true);
                                }
                            }
                        }
                    }
                }
                index = index + 1;
                if (index == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
        }

        public virtual void MeleeStartingUnitsForPlayer(race whichRace, player whichPlayer, location loc, boolean doHeroes)
        {
            if ((whichRace == RACE_HUMAN))
            {
                MeleeStartingUnitsHuman(whichPlayer, loc, doHeroes, false, false);
            }
            else
            {
                if ((whichRace == RACE_ORC))
                {
                    MeleeStartingUnitsOrc(whichPlayer, loc, doHeroes, false, false);
                }
                else
                {
                    if ((whichRace == RACE_UNDEAD))
                    {
                        MeleeStartingUnitsUndead(whichPlayer, loc, doHeroes, false, false);
                    }
                    else
                    {
                        if ((whichRace == RACE_NIGHTELF))
                        {
                            MeleeStartingUnitsNightElf(whichPlayer, loc, doHeroes, false, false);
                        }
                    }
                }
            }
        }

        public virtual void PickMeleeAI(player num, @string s1, @string s2, @string s3)
        {
            integer pick = 0;
            if (GetAIDifficulty(num) == AI_DIFFICULTY_NEWBIE)
            {
                StartMeleeAI(num, s1);
                return;
            }
            if (s2 == null)
            {
                pick = 1;
            }
            else
            {
                if (s3 == null)
                {
                    pick = GetRandomInt(1, 2);
                }
                else
                {
                    pick = GetRandomInt(1, 3);
                }
            }
            if (pick == 1)
            {
                StartMeleeAI(num, s1);
            }
            else
            {
                if (pick == 2)
                {
                    StartMeleeAI(num, s2);
                }
                else
                {
                    StartMeleeAI(num, s3);
                }
            }
        }

        public virtual void MeleeStartingAI()
        {
            integer index = 0;
            player indexPlayer;
            race indexRace;
            index = 0;
            for (
            ; true;
            )
            {
                indexPlayer = Player(index);
                if ((GetPlayerSlotState(indexPlayer) == PLAYER_SLOT_STATE_PLAYING))
                {
                    indexRace = GetPlayerRace(indexPlayer);
                    if ((GetPlayerController(indexPlayer) == MAP_CONTROL_COMPUTER))
                    {
                        if ((indexRace == RACE_HUMAN))
                        {
                            PickMeleeAI(indexPlayer, "human.ai", null, null);
                        }
                        else
                        {
                            if ((indexRace == RACE_ORC))
                            {
                                PickMeleeAI(indexPlayer, "orc.ai", null, null);
                            }
                            else
                            {
                                if ((indexRace == RACE_UNDEAD))
                                {
                                    PickMeleeAI(indexPlayer, "undead.ai", null, null);
                                    RecycleGuardPosition(bj_ghoul[index]);
                                }
                                else
                                {
                                    if ((indexRace == RACE_NIGHTELF))
                                    {
                                        PickMeleeAI(indexPlayer, "elf.ai", null, null);
                                    }
                                }
                            }
                        }
                        ShareEverythingWithTeamAI(indexPlayer);
                    }
                }
                index = index + 1;
                if (index == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
        }

        public virtual void LockGuardPosition(unit targ)
        {
            SetUnitCreepGuard(targ, true);
        }

        public virtual boolean MeleePlayerIsOpponent(integer playerIndex, integer opponentIndex)
        {
            player thePlayer = Player(playerIndex);
            player theOpponent = Player(opponentIndex);
            if ((playerIndex == opponentIndex))
            {
                return false;
            }
            if ((GetPlayerSlotState(theOpponent) != PLAYER_SLOT_STATE_PLAYING))
            {
                return false;
            }
            if ((bj_meleeDefeated[opponentIndex]))
            {
                return false;
            }
            if (GetPlayerAlliance(thePlayer, theOpponent, ALLIANCE_PASSIVE))
            {
                if (GetPlayerAlliance(theOpponent, thePlayer, ALLIANCE_PASSIVE))
                {
                    if ((GetPlayerState(thePlayer, PLAYER_STATE_ALLIED_VICTORY) == 1))
                    {
                        if ((GetPlayerState(theOpponent, PLAYER_STATE_ALLIED_VICTORY) == 1))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public virtual integer MeleeGetAllyStructureCount(player whichPlayer)
        {
            integer playerIndex = 0;
            integer buildingCount = 0;
            player indexPlayer;
            buildingCount = 0;
            playerIndex = 0;
            for (
            ; true;
            )
            {
                indexPlayer = Player(playerIndex);
                if ((PlayersAreCoAllied(whichPlayer, indexPlayer)))
                {
                    buildingCount = buildingCount + GetPlayerStructureCount(indexPlayer, true);
                }
                playerIndex = playerIndex + 1;
                if (playerIndex == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
            return buildingCount;
        }

        public virtual integer MeleeGetAllyCount(player whichPlayer)
        {
            integer playerIndex = 0;
            integer playerCount = 0;
            player indexPlayer;
            playerCount = 0;
            playerIndex = 0;
            for (
            ; true;
            )
            {
                indexPlayer = Player(playerIndex);
                if (PlayersAreCoAllied(whichPlayer, indexPlayer) && !bj_meleeDefeated[playerIndex] && (whichPlayer != indexPlayer))
                {
                    playerCount = playerCount + 1;
                }
                playerIndex = playerIndex + 1;
                if (playerIndex == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
            return playerCount;
        }

        public virtual integer MeleeGetAllyKeyStructureCount(player whichPlayer)
        {
            integer playerIndex = 0;
            player indexPlayer;
            integer keyStructs = 0;
            keyStructs = 0;
            playerIndex = 0;
            for (
            ; true;
            )
            {
                indexPlayer = Player(playerIndex);
                if ((PlayersAreCoAllied(whichPlayer, indexPlayer)))
                {
                    keyStructs = keyStructs + GetPlayerTypedUnitCount(indexPlayer, "townhall", true, true);
                    keyStructs = keyStructs + GetPlayerTypedUnitCount(indexPlayer, "greathall", true, true);
                    keyStructs = keyStructs + GetPlayerTypedUnitCount(indexPlayer, "treeoflife", true, true);
                    keyStructs = keyStructs + GetPlayerTypedUnitCount(indexPlayer, "necropolis", true, true);
                }
                playerIndex = playerIndex + 1;
                if (playerIndex == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
            return keyStructs;
        }

        public virtual void MeleeDoDrawEnum()
        {
            player thePlayer = GetEnumPlayer();
            CachePlayerHeroData(thePlayer);
            RemovePlayerPreserveUnitsBJ(thePlayer, PLAYER_GAME_RESULT_TIE, false);
        }

        public virtual void MeleeDoVictoryEnum()
        {
            player thePlayer = GetEnumPlayer();
            integer playerIndex = GetPlayerId(thePlayer);
            if ((!bj_meleeVictoried[playerIndex]))
            {
                bj_meleeVictoried[playerIndex] = true;
                CachePlayerHeroData(thePlayer);
                RemovePlayerPreserveUnitsBJ(thePlayer, PLAYER_GAME_RESULT_VICTORY, false);
            }
        }

        public virtual void MeleeDoDefeat(player whichPlayer)
        {
            bj_meleeDefeated[GetPlayerId(whichPlayer)] = true;
            RemovePlayerPreserveUnitsBJ(whichPlayer, PLAYER_GAME_RESULT_DEFEAT, false);
        }

        public virtual void MeleeDoDefeatEnum()
        {
            player thePlayer = GetEnumPlayer();
            CachePlayerHeroData(thePlayer);
            MakeUnitsPassiveForTeam(thePlayer);
            MeleeDoDefeat(thePlayer);
        }

        public virtual void MeleeDoLeave(player whichPlayer)
        {
            if ((GetIntegerGameState(GAME_STATE_DISCONNECTED) != 0))
            {
                GameOverDialogBJ(whichPlayer, true);
            }
            else
            {
                bj_meleeDefeated[GetPlayerId(whichPlayer)] = true;
                RemovePlayerPreserveUnitsBJ(whichPlayer, PLAYER_GAME_RESULT_DEFEAT, true);
            }
        }

        public virtual void MeleeRemoveObservers()
        {
            integer playerIndex = 0;
            player indexPlayer;
            playerIndex = 0;
            for (
            ; true;
            )
            {
                indexPlayer = Player(playerIndex);
                if ((IsPlayerObserver(indexPlayer)))
                {
                    RemovePlayerPreserveUnitsBJ(indexPlayer, PLAYER_GAME_RESULT_NEUTRAL, false);
                }
                playerIndex = playerIndex + 1;
                if (playerIndex == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
        }

        public virtual force MeleeCheckForVictors()
        {
            integer playerIndex = 0;
            integer opponentIndex = 0;
            force opponentlessPlayers = CreateForce();
            boolean gameOver = false;
            playerIndex = 0;
            for (
            ; true;
            )
            {
                if ((!bj_meleeDefeated[playerIndex]))
                {
                    opponentIndex = 0;
                    for (
                    ; true;
                    )
                    {
                        if (MeleePlayerIsOpponent(playerIndex, opponentIndex))
                        {
                            return CreateForce();
                        }
                        opponentIndex = opponentIndex + 1;
                        if (opponentIndex == bj_MAX_PLAYERS)
                        {
                            break;
                        }
                    }
                    ForceAddPlayer(opponentlessPlayers, Player(playerIndex));
                    gameOver = true;
                }
                playerIndex = playerIndex + 1;
                if (playerIndex == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
            bj_meleeGameOver = gameOver;
            return opponentlessPlayers;
        }

        public virtual void MeleeCheckForLosersAndVictors()
        {
            integer playerIndex = 0;
            player indexPlayer;
            force defeatedPlayers = CreateForce();
            force victoriousPlayers;
            boolean gameOver = false;
            if ((bj_meleeGameOver))
            {
                return;
            }
            if ((GetIntegerGameState(GAME_STATE_DISCONNECTED) != 0))
            {
                bj_meleeGameOver = true;
                return;
            }
            playerIndex = 0;
            for (
            ; true;
            )
            {
                indexPlayer = Player(playerIndex);
                if ((!bj_meleeDefeated[playerIndex] && !bj_meleeVictoried[playerIndex]))
                {
                    if ((MeleeGetAllyStructureCount(indexPlayer) <= 0))
                    {
                        ForceAddPlayer(defeatedPlayers, Player(playerIndex));
                        bj_meleeDefeated[playerIndex] = true;
                    }
                }
                playerIndex = playerIndex + 1;
                if (playerIndex == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
            victoriousPlayers = MeleeCheckForVictors();
            ForForce(defeatedPlayers, MeleeDoDefeatEnum);
            ForForce(victoriousPlayers, MeleeDoVictoryEnum);
            if ((bj_meleeGameOver))
            {
                MeleeRemoveObservers();
            }
        }

        public virtual @string MeleeGetCrippledWarningMessage(player whichPlayer)
        {
            race r = GetPlayerRace(whichPlayer);
            if ((r == RACE_HUMAN))
            {
                return GetLocalizedString("CRIPPLE_WARNING_HUMAN");
            }
            else
            {
                if ((r == RACE_ORC))
                {
                    return GetLocalizedString("CRIPPLE_WARNING_ORC");
                }
                else
                {
                    if ((r == RACE_NIGHTELF))
                    {
                        return GetLocalizedString("CRIPPLE_WARNING_NIGHTELF");
                    }
                    else
                    {
                        if ((r == RACE_UNDEAD))
                        {
                            return GetLocalizedString("CRIPPLE_WARNING_UNDEAD");
                        }
                        else
                        {
                            return "";
                        }
                    }
                }
            }
        }

        public virtual @string MeleeGetCrippledTimerMessage(player whichPlayer)
        {
            race r = GetPlayerRace(whichPlayer);
            if ((r == RACE_HUMAN))
            {
                return GetLocalizedString("CRIPPLE_TIMER_HUMAN");
            }
            else
            {
                if ((r == RACE_ORC))
                {
                    return GetLocalizedString("CRIPPLE_TIMER_ORC");
                }
                else
                {
                    if ((r == RACE_NIGHTELF))
                    {
                        return GetLocalizedString("CRIPPLE_TIMER_NIGHTELF");
                    }
                    else
                    {
                        if ((r == RACE_UNDEAD))
                        {
                            return GetLocalizedString("CRIPPLE_TIMER_UNDEAD");
                        }
                        else
                        {
                            return "";
                        }
                    }
                }
            }
        }

        public virtual @string MeleeGetCrippledRevealedMessage(player whichPlayer)
        {
            return GetLocalizedString("CRIPPLE_REVEALING_PREFIX") + GetPlayerName(whichPlayer) + GetLocalizedString("CRIPPLE_REVEALING_POSTFIX");
        }

        public virtual void MeleeExposePlayer(player whichPlayer, boolean expose)
        {
            integer playerIndex = 0;
            player indexPlayer;
            force toExposeTo = CreateForce();
            CripplePlayer(whichPlayer, toExposeTo, false);
            bj_playerIsExposed[GetPlayerId(whichPlayer)] = expose;
            playerIndex = 0;
            for (
            ; true;
            )
            {
                indexPlayer = Player(playerIndex);
                if ((!PlayersAreCoAllied(whichPlayer, indexPlayer)))
                {
                    ForceAddPlayer(toExposeTo, indexPlayer);
                }
                playerIndex = playerIndex + 1;
                if (playerIndex == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
            CripplePlayer(whichPlayer, toExposeTo, expose);
            DestroyForce(toExposeTo);
        }

        public virtual void MeleeExposeAllPlayers()
        {
            integer playerIndex = 0;
            player indexPlayer;
            integer playerIndex2 = 0;
            player indexPlayer2;
            force toExposeTo = CreateForce();
            playerIndex = 0;
            for (
            ; true;
            )
            {
                indexPlayer = Player(playerIndex);
                ForceClear(toExposeTo);
                CripplePlayer(indexPlayer, toExposeTo, false);
                playerIndex2 = 0;
                for (
                ; true;
                )
                {
                    indexPlayer2 = Player(playerIndex2);
                    if (playerIndex != playerIndex2)
                    {
                        if ((!PlayersAreCoAllied(indexPlayer, indexPlayer2)))
                        {
                            ForceAddPlayer(toExposeTo, indexPlayer2);
                        }
                    }
                    playerIndex2 = playerIndex2 + 1;
                    if (playerIndex2 == bj_MAX_PLAYERS)
                    {
                        break;
                    }
                }
                CripplePlayer(indexPlayer, toExposeTo, true);
                playerIndex = playerIndex + 1;
                if (playerIndex == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
            DestroyForce(toExposeTo);
        }

        public virtual void MeleeCrippledPlayerTimeout()
        {
            timer expiredTimer = GetExpiredTimer();
            integer playerIndex = 0;
            player exposedPlayer;
            playerIndex = 0;
            for (
            ; true;
            )
            {
                if ((bj_crippledTimer[playerIndex] == expiredTimer))
                {
                    if (true)
                    {
                        break;
                    }
                }
                playerIndex = playerIndex + 1;
                if (playerIndex == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
            if ((playerIndex == bj_MAX_PLAYERS))
            {
                return;
            }
            exposedPlayer = Player(playerIndex);
            if ((GetLocalPlayer() == exposedPlayer))
            {
                TimerDialogDisplay(bj_crippledTimerWindows[playerIndex], false);
            }
            DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_MELEE_CRIPPLE_MSG_DURATION, MeleeGetCrippledRevealedMessage(exposedPlayer));
            MeleeExposePlayer(exposedPlayer, true);
        }

        public virtual boolean MeleePlayerIsCrippled(player whichPlayer)
        {
            integer allyStructures = MeleeGetAllyStructureCount(whichPlayer);
            integer allyKeyStructures = MeleeGetAllyKeyStructureCount(whichPlayer);
            return (allyStructures > 0) && (allyKeyStructures <= 0);
        }

        public virtual void MeleeCheckForCrippledPlayers()
        {
            integer playerIndex = 0;
            player indexPlayer;
            force crippledPlayers = CreateForce();
            boolean isNowCrippled = false;
            race indexRace;
            if (bj_finishSoonAllExposed)
            {
                return;
            }
            playerIndex = 0;
            for (
            ; true;
            )
            {
                indexPlayer = Player(playerIndex);
                isNowCrippled = MeleePlayerIsCrippled(indexPlayer);
                if ((!bj_playerIsCrippled[playerIndex] && isNowCrippled))
                {
                    bj_playerIsCrippled[playerIndex] = true;
                    TimerStart(bj_crippledTimer[playerIndex], bj_MELEE_CRIPPLE_TIMEOUT, false, MeleeCrippledPlayerTimeout);
                    if ((GetLocalPlayer() == indexPlayer))
                    {
                        TimerDialogDisplay(bj_crippledTimerWindows[playerIndex], true);
                        DisplayTimedTextToPlayer(indexPlayer, 0, 0, bj_MELEE_CRIPPLE_MSG_DURATION, MeleeGetCrippledWarningMessage(indexPlayer));
                    }
                }
                else
                {
                    if ((bj_playerIsCrippled[playerIndex] && !isNowCrippled))
                    {
                        bj_playerIsCrippled[playerIndex] = false;
                        PauseTimer(bj_crippledTimer[playerIndex]);
                        if ((GetLocalPlayer() == indexPlayer))
                        {
                            TimerDialogDisplay(bj_crippledTimerWindows[playerIndex], false);
                            if ((MeleeGetAllyStructureCount(indexPlayer) > 0))
                            {
                                if ((bj_playerIsExposed[playerIndex]))
                                {
                                    DisplayTimedTextToPlayer(indexPlayer, 0, 0, bj_MELEE_CRIPPLE_MSG_DURATION, GetLocalizedString("CRIPPLE_UNREVEALED"));
                                }
                                else
                                {
                                    DisplayTimedTextToPlayer(indexPlayer, 0, 0, bj_MELEE_CRIPPLE_MSG_DURATION, GetLocalizedString("CRIPPLE_UNCRIPPLED"));
                                }
                            }
                        }
                        MeleeExposePlayer(indexPlayer, false);
                    }
                }
                playerIndex = playerIndex + 1;
                if (playerIndex == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
        }

        public virtual void MeleeCheckLostUnit(unit lostUnit)
        {
            player lostUnitOwner = GetOwningPlayer(lostUnit);
            if ((GetPlayerStructureCount(lostUnitOwner, true) <= 0))
            {
                MeleeCheckForLosersAndVictors();
            }
            MeleeCheckForCrippledPlayers();
        }

        public virtual void MeleeCheckAddedUnit(unit addedUnit)
        {
            player addedUnitOwner = GetOwningPlayer(addedUnit);
            if ((bj_playerIsCrippled[GetPlayerId(addedUnitOwner)]))
            {
                MeleeCheckForCrippledPlayers();
            }
        }

        public virtual void MeleeTriggerActionstaticructCancel()
        {
            MeleeCheckLostUnit(GetCancelledStructure());
        }

        public virtual void MeleeTriggerActionUnitDeath()
        {
            if ((IsUnitType(GetDyingUnit(), UNIT_TYPE_STRUCTURE)))
            {
                MeleeCheckLostUnit(GetDyingUnit());
            }
        }

        public virtual void MeleeTriggerActionUnitstaticructionStart()
        {
            MeleeCheckAddedUnit(GetConstructingStructure());
        }

        public virtual void MeleeTriggerActionPlayerDefeated()
        {
            player thePlayer = GetTriggerPlayer();
            CachePlayerHeroData(thePlayer);
            if ((MeleeGetAllyCount(thePlayer) > 0))
            {
                ShareEverythingWithTeam(thePlayer);
                if ((!bj_meleeDefeated[GetPlayerId(thePlayer)]))
                {
                    MeleeDoDefeat(thePlayer);
                }
            }
            else
            {
                MakeUnitsPassiveForTeam(thePlayer);
                if ((!bj_meleeDefeated[GetPlayerId(thePlayer)]))
                {
                    MeleeDoDefeat(thePlayer);
                }
            }
            MeleeCheckForLosersAndVictors();
        }

        public virtual void MeleeTriggerActionPlayerLeft()
        {
            player thePlayer = GetTriggerPlayer();
            if ((IsPlayerObserver(thePlayer)))
            {
                RemovePlayerPreserveUnitsBJ(thePlayer, PLAYER_GAME_RESULT_NEUTRAL, false);
                return;
            }
            CachePlayerHeroData(thePlayer);
            if ((MeleeGetAllyCount(thePlayer) > 0))
            {
                ShareEverythingWithTeam(thePlayer);
                MeleeDoLeave(thePlayer);
            }
            else
            {
                MakeUnitsPassiveForTeam(thePlayer);
                MeleeDoLeave(thePlayer);
            }
            MeleeCheckForLosersAndVictors();
        }

        public virtual void MeleeTriggerActionAllianceChange()
        {
            MeleeCheckForLosersAndVictors();
            MeleeCheckForCrippledPlayers();
        }

        public virtual void MeleeTriggerTournamentFinishSoon()
        {
            integer playerIndex = 0;
            player indexPlayer;
            real timeRemaining = GetTournamentFinishSoonTimeRemaining();
            if (!bj_finishSoonAllExposed)
            {
                bj_finishSoonAllExposed = true;
                playerIndex = 0;
                for (
                ; true;
                )
                {
                    indexPlayer = Player(playerIndex);
                    if (bj_playerIsCrippled[playerIndex])
                    {
                        bj_playerIsCrippled[playerIndex] = false;
                        PauseTimer(bj_crippledTimer[playerIndex]);
                        if ((GetLocalPlayer() == indexPlayer))
                        {
                            TimerDialogDisplay(bj_crippledTimerWindows[playerIndex], false);
                        }
                    }
                    playerIndex = playerIndex + 1;
                    if (playerIndex == bj_MAX_PLAYERS)
                    {
                        break;
                    }
                }
                MeleeExposeAllPlayers();
            }
            TimerDialogDisplay(bj_finishSoonTimerDialog, true);
            TimerDialogSetRealTimeRemaining(bj_finishSoonTimerDialog, timeRemaining);
        }

        public virtual boolean MeleeWasUserPlayer(player whichPlayer)
        {
            playerslotstate slotState;
            if ((GetPlayerController(whichPlayer) != MAP_CONTROL_USER))
            {
                return false;
            }
            slotState = GetPlayerSlotState(whichPlayer);
            return (slotState == PLAYER_SLOT_STATE_PLAYING || slotState == PLAYER_SLOT_STATE_LEFT);
        }

        public virtual void MeleeTournamentFinishNowRuleA(integer multiplier)
        {
            array<int, integer> playerScore = new array<integer, integer>();
            array<int, integer> teamScore = new array<integer, integer>();
            array<int, force> teamForce = new array<integer, force>();
            integer teamCount = 0;
            integer index = 0;
            player indexPlayer;
            integer index2 = 0;
            player indexPlayer2;
            integer bestTeam = 0;
            integer bestScore = 0;
            boolean draw = false;
            index = 0;
            for (
            ; true;
            )
            {
                indexPlayer = Player(index);
                if (MeleeWasUserPlayer(indexPlayer))
                {
                    playerScore[index] = GetTournamentScore(indexPlayer);
                    if (playerScore[index] <= 0)
                    {
                        playerScore[index] = 1;
                    }
                }
                else
                {
                    playerScore[index] = 0;
                }
                index = index + 1;
                if (index == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
            teamCount = 0;
            index = 0;
            for (
            ; true;
            )
            {
                if (playerScore[index] != 0)
                {
                    indexPlayer = Player(index);
                    teamScore[teamCount] = 0;
                    teamForce[teamCount] = CreateForce();
                    index2 = index;
                    for (
                    ; true;
                    )
                    {
                        if (playerScore[index2] != 0)
                        {
                            indexPlayer2 = Player(index2);
                            if (PlayersAreCoAllied(indexPlayer, indexPlayer2))
                            {
                                teamScore[teamCount] = teamScore[teamCount] + playerScore[index2];
                                ForceAddPlayer(teamForce[teamCount], indexPlayer2);
                                playerScore[index2] = 0;
                            }
                        }
                        index2 = index2 + 1;
                        if (index2 == bj_MAX_PLAYERS)
                        {
                            break;
                        }
                    }
                    teamCount = teamCount + 1;
                }
                index = index + 1;
                if (index == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
            bj_meleeGameOver = true;
            if (teamCount != 0)
            {
                bestTeam = -1;
                bestScore = -1;
                index = 0;
                for (
                ; true;
                )
                {
                    if (teamScore[index] > bestScore)
                    {
                        bestTeam = index;
                        bestScore = teamScore[index];
                    }
                    index = index + 1;
                    if (index == teamCount)
                    {
                        break;
                    }
                }
                draw = false;
                index = 0;
                for (
                ; true;
                )
                {
                    if (index != bestTeam)
                    {
                        if (bestScore < (multiplier * teamScore[index]))
                        {
                            draw = true;
                        }
                    }
                    index = index + 1;
                    if (index == teamCount)
                    {
                        break;
                    }
                }
                if (draw)
                {
                    index = 0;
                    for (
                    ; true;
                    )
                    {
                        ForForce(teamForce[index], MeleeDoDrawEnum);
                        index = index + 1;
                        if (index == teamCount)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    index = 0;
                    for (
                    ; true;
                    )
                    {
                        if (index != bestTeam)
                        {
                            ForForce(teamForce[index], MeleeDoDefeatEnum);
                        }
                        index = index + 1;
                        if (index == teamCount)
                        {
                            break;
                        }
                    }
                    ForForce(teamForce[bestTeam], MeleeDoVictoryEnum);
                }
            }
        }

        public virtual void MeleeTriggerTournamentFinishNow()
        {
            integer rule = GetTournamentFinishNowRule();
            if (bj_meleeGameOver)
            {
                return;
            }
            if ((rule == 1))
            {
                MeleeTournamentFinishNowRuleA(1);
            }
            else
            {
                MeleeTournamentFinishNowRuleA(3);
            }
            MeleeRemoveObservers();
        }

        public virtual void MeleeInitVictoryDefeat()
        {
            trigger trig;
            integer index = 0;
            player indexPlayer;
            bj_finishSoonTimerDialog = CreateTimerDialog(null);
            trig = CreateTrigger();
            TriggerRegisterGameEvent(trig, EVENT_GAME_TOURNAMENT_FINISH_SOON);
            TriggerAddAction(trig, MeleeTriggerTournamentFinishSoon);
            trig = CreateTrigger();
            TriggerRegisterGameEvent(trig, EVENT_GAME_TOURNAMENT_FINISH_NOW);
            TriggerAddAction(trig, MeleeTriggerTournamentFinishNow);
            index = 0;
            for (
            ; true;
            )
            {
                indexPlayer = Player(index);
                if ((GetPlayerSlotState(indexPlayer) == PLAYER_SLOT_STATE_PLAYING))
                {
                    bj_meleeDefeated[index] = false;
                    bj_meleeVictoried[index] = false;
                    bj_playerIsCrippled[index] = false;
                    bj_playerIsExposed[index] = false;
                    bj_crippledTimer[index] = CreateTimer();
                    bj_crippledTimerWindows[index] = CreateTimerDialog(bj_crippledTimer[index]);
                    TimerDialogSetTitle(bj_crippledTimerWindows[index], MeleeGetCrippledTimerMessage(indexPlayer));
                    trig = CreateTrigger();
                    TriggerRegisterPlayerUnitEvent(trig, indexPlayer, EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL, null);
                    TriggerAddAction(trig, MeleeTriggerActionstaticructCancel);
                    trig = CreateTrigger();
                    TriggerRegisterPlayerUnitEvent(trig, indexPlayer, EVENT_PLAYER_UNIT_DEATH, null);
                    TriggerAddAction(trig, MeleeTriggerActionUnitDeath);
                    trig = CreateTrigger();
                    TriggerRegisterPlayerUnitEvent(trig, indexPlayer, EVENT_PLAYER_UNIT_CONSTRUCT_START, null);
                    TriggerAddAction(trig, MeleeTriggerActionUnitstaticructionStart);
                    trig = CreateTrigger();
                    TriggerRegisterPlayerEvent(trig, indexPlayer, EVENT_PLAYER_DEFEAT);
                    TriggerAddAction(trig, MeleeTriggerActionPlayerDefeated);
                    trig = CreateTrigger();
                    TriggerRegisterPlayerEvent(trig, indexPlayer, EVENT_PLAYER_LEAVE);
                    TriggerAddAction(trig, MeleeTriggerActionPlayerLeft);
                    trig = CreateTrigger();
                    TriggerRegisterPlayerAllianceChange(trig, indexPlayer, ALLIANCE_PASSIVE);
                    TriggerRegisterPlayerStateEvent(trig, indexPlayer, PLAYER_STATE_ALLIED_VICTORY, EQUAL, 1);
                    TriggerAddAction(trig, MeleeTriggerActionAllianceChange);
                }
                else
                {
                    bj_meleeDefeated[index] = true;
                    bj_meleeVictoried[index] = false;
                    if ((IsPlayerObserver(indexPlayer)))
                    {
                        trig = CreateTrigger();
                        TriggerRegisterPlayerEvent(trig, indexPlayer, EVENT_PLAYER_LEAVE);
                        TriggerAddAction(trig, MeleeTriggerActionPlayerLeft);
                    }
                }
                index = index + 1;
                if (index == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
            TimerStart(CreateTimer(), 2f, false, MeleeTriggerActionAllianceChange);
        }

        public virtual void CheckInitPlayerSlotAvailability()
        {
            integer index = 0;
            if ((!bj_slotControlReady))
            {
                index = 0;
                for (
                ; true;
                )
                {
                    bj_slotControlUsed[index] = false;
                    bj_slotControl[index] = MAP_CONTROL_USER;
                    index = index + 1;
                    if (index == bj_MAX_PLAYERS)
                    {
                        break;
                    }
                }
                bj_slotControlReady = true;
            }
        }

        public virtual void SetPlayerSlotAvailable(player whichPlayer, mapcontrol control)
        {
            integer playerIndex = GetPlayerId(whichPlayer);
            CheckInitPlayerSlotAvailability();
            bj_slotControlUsed[playerIndex] = true;
            bj_slotControl[playerIndex] = control;
        }

        public virtual void TeamInitPlayerSlots(integer teamCount)
        {
            integer index = 0;
            player indexPlayer;
            integer team = 0;
            SetTeams(teamCount);
            CheckInitPlayerSlotAvailability();
            index = 0;
            team = 0;
            for (
            ; true;
            )
            {
                if ((bj_slotControlUsed[index]))
                {
                    indexPlayer = Player(index);
                    SetPlayerTeam(indexPlayer, team);
                    team = team + 1;
                    if ((team >= teamCount))
                    {
                        team = 0;
                    }
                }
                index = index + 1;
                if (index == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
        }

        public virtual void MeleeInitPlayerSlots()
        {
            TeamInitPlayerSlots(bj_MAX_PLAYERS);
        }

        public virtual void FFAInitPlayerSlots()
        {
            TeamInitPlayerSlots(bj_MAX_PLAYERS);
        }

        public virtual void OneOnOneInitPlayerSlots()
        {
            SetTeams(2);
            SetPlayers(2);
            TeamInitPlayerSlots(2);
        }

        public virtual void InitGenericPlayerSlots()
        {
            gametype gType = GetGameTypeSelected();
            if ((gType == GAME_TYPE_MELEE))
            {
                MeleeInitPlayerSlots();
            }
            else
            {
                if ((gType == GAME_TYPE_FFA))
                {
                    FFAInitPlayerSlots();
                }
                else
                {
                    if ((gType == GAME_TYPE_USE_MAP_SETTINGS))
                    {
                    }
                    else
                    {
                        if ((gType == GAME_TYPE_ONE_ON_ONE))
                        {
                            OneOnOneInitPlayerSlots();
                        }
                        else
                        {
                            if ((gType == GAME_TYPE_TWO_TEAM_PLAY))
                            {
                                TeamInitPlayerSlots(2);
                            }
                            else
                            {
                                if ((gType == GAME_TYPE_THREE_TEAM_PLAY))
                                {
                                    TeamInitPlayerSlots(3);
                                }
                                else
                                {
                                    if ((gType == GAME_TYPE_FOUR_TEAM_PLAY))
                                    {
                                        TeamInitPlayerSlots(4);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public virtual void SetDNCSoundsDawn()
        {
            if (bj_useDawnDuskSounds)
            {
                StartSound(bj_dawnSound);
            }
        }

        public virtual void SetDNCSoundsDusk()
        {
            if (bj_useDawnDuskSounds)
            {
                StartSound(bj_duskSound);
            }
        }

        public virtual void SetDNCSoundsDay()
        {
            real ToD = GetTimeOfDay();
            if ((ToD >= bj_TOD_DAWN && ToD < bj_TOD_DUSK) && !bj_dncIsDaytime)
            {
                bj_dncIsDaytime = true;
                StopSound(bj_nightAmbientSound, false, true);
                StartSound(bj_dayAmbientSound);
            }
        }

        public virtual void SetDNCSoundsNight()
        {
            real ToD = GetTimeOfDay();
            if ((ToD < bj_TOD_DAWN || ToD >= bj_TOD_DUSK) && bj_dncIsDaytime)
            {
                bj_dncIsDaytime = false;
                StopSound(bj_dayAmbientSound, false, true);
                StartSound(bj_nightAmbientSound);
            }
        }

        public virtual void InitDNCSounds()
        {
            bj_dawnSound = CreateSoundFromLabel("RoosterSound", false, false, false, 10000, 10000);
            bj_duskSound = CreateSoundFromLabel("WolfSound", false, false, false, 10000, 10000);
            bj_dncSoundsDawn = CreateTrigger();
            TriggerRegisterGameStateEvent(bj_dncSoundsDawn, GAME_STATE_TIME_OF_DAY, EQUAL, bj_TOD_DAWN);
            TriggerAddAction(bj_dncSoundsDawn, SetDNCSoundsDawn);
            bj_dncSoundsDusk = CreateTrigger();
            TriggerRegisterGameStateEvent(bj_dncSoundsDusk, GAME_STATE_TIME_OF_DAY, EQUAL, bj_TOD_DUSK);
            TriggerAddAction(bj_dncSoundsDusk, SetDNCSoundsDusk);
            bj_dncSoundsDay = CreateTrigger();
            TriggerRegisterGameStateEvent(bj_dncSoundsDay, GAME_STATE_TIME_OF_DAY, GREATER_THAN_OR_EQUAL, bj_TOD_DAWN);
            TriggerRegisterGameStateEvent(bj_dncSoundsDay, GAME_STATE_TIME_OF_DAY, LESS_THAN, bj_TOD_DUSK);
            TriggerAddAction(bj_dncSoundsDay, SetDNCSoundsDay);
            bj_dncSoundsNight = CreateTrigger();
            TriggerRegisterGameStateEvent(bj_dncSoundsNight, GAME_STATE_TIME_OF_DAY, LESS_THAN, bj_TOD_DAWN);
            TriggerRegisterGameStateEvent(bj_dncSoundsNight, GAME_STATE_TIME_OF_DAY, GREATER_THAN_OR_EQUAL, bj_TOD_DUSK);
            TriggerAddAction(bj_dncSoundsNight, SetDNCSoundsNight);
        }

        public virtual void InitBlizzardGlobals()
        {
            integer index = 0;
            integer userControlledPlayers = 0;
            version v;
            filterIssueHauntOrderAtLocBJ = Filter(IssueHauntOrderAtLocBJFilter);
            filterEnumDestructablesInCircleBJ = Filter(EnumDestructablesInCircleBJFilter);
            filterGetUnitsInRectOfPlayer = Filter(GetUnitsInRectOfPlayerFilter);
            filterGetUnitsOfTypeIdAll = Filter(GetUnitsOfTypeIdAllFilter);
            filterGetUnitsOfPlayerAndTypeId = Filter(GetUnitsOfPlayerAndTypeIdFilter);
            filterMeleeTrainedUnitIsHeroBJ = Filter(MeleeTrainedUnitIsHeroBJFilter);
            filterLivingPlayerUnitsOfTypeId = Filter(LivingPlayerUnitsOfTypeIdFilter);
            index = 0;
            for (
            ; true;
            )
            {
                if (index == bj_MAX_PLAYER_SLOTS)
                {
                    break;
                }
                bj_FORCE_PLAYER[index] = CreateForce();
                ForceAddPlayer(bj_FORCE_PLAYER[index], Player(index));
                index = index + 1;
            }
            bj_FORCE_ALL_PLAYERS = CreateForce();
            ForceEnumPlayers(bj_FORCE_ALL_PLAYERS, null);
            bj_cineModePriorSpeed = GetGameSpeed();
            bj_cineModePriorFogSetting = IsFogEnabled();
            bj_cineModePriorMaskSetting = IsFogMaskEnabled();
            index = 0;
            for (
            ; true;
            )
            {
                if (index >= bj_MAX_QUEUED_TRIGGERS)
                {
                    break;
                }
                bj_queuedExecTriggers[index] = null;
                bj_queuedExecUseConds[index] = false;
                index = index + 1;
            }
            bj_isSinglePlayer = false;
            userControlledPlayers = 0;
            index = 0;
            for (
            ; true;
            )
            {
                if (index >= bj_MAX_PLAYERS)
                {
                    break;
                }
                if ((GetPlayerController(Player(index)) == MAP_CONTROL_USER && GetPlayerSlotState(Player(index)) == PLAYER_SLOT_STATE_PLAYING))
                {
                    userControlledPlayers = userControlledPlayers + 1;
                }
                index = index + 1;
            }
            bj_isSinglePlayer = (userControlledPlayers == 1);
            bj_rescueSound = CreateSoundFromLabel("Rescue", false, false, false, 10000, 10000);
            bj_questDiscoveredSound = CreateSoundFromLabel("QuestNew", false, false, false, 10000, 10000);
            bj_questUpdatedSound = CreateSoundFromLabel("QuestUpdate", false, false, false, 10000, 10000);
            bj_questCompletedSound = CreateSoundFromLabel("QuestCompleted", false, false, false, 10000, 10000);
            bj_questFailedSound = CreateSoundFromLabel("QuestFailed", false, false, false, 10000, 10000);
            bj_questHintSound = CreateSoundFromLabel("Hint", false, false, false, 10000, 10000);
            bj_questSecretSound = CreateSoundFromLabel("SecretFound", false, false, false, 10000, 10000);
            bj_questItemAcquiredSound = CreateSoundFromLabel("ItemReward", false, false, false, 10000, 10000);
            bj_questWarningSound = CreateSoundFromLabel("Warning", false, false, false, 10000, 10000);
            bj_victoryDialogSound = CreateSoundFromLabel("QuestCompleted", false, false, false, 10000, 10000);
            bj_defeatDialogSound = CreateSoundFromLabel("QuestFailed", false, false, false, 10000, 10000);
            DelayedSuspendDecayCreate();
            v = VersionGet();
            if ((v == VERSION_REIGN_OF_CHAOS))
            {
                bj_MELEE_MAX_TWINKED_HEROES = bj_MELEE_MAX_TWINKED_HEROES_V0;
            }
            else
            {
                bj_MELEE_MAX_TWINKED_HEROES = bj_MELEE_MAX_TWINKED_HEROES_V1;
            }
        }

        public virtual void InitQueuedTriggers()
        {
            bj_queuedExecTimeout = CreateTrigger();
            TriggerRegisterTimerExpireEvent(bj_queuedExecTimeout, bj_queuedExecTimeoutTimer);
            TriggerAddAction(bj_queuedExecTimeout, QueuedTriggerDoneBJ);
        }

        public virtual void InitMapRects()
        {
            bj_mapInitialPlayableArea = Rect(GetCameraBoundMinX() - GetCameraMargin(CAMERA_MARGIN_LEFT), GetCameraBoundMinY() - GetCameraMargin(CAMERA_MARGIN_BOTTOM), GetCameraBoundMaxX() + GetCameraMargin(CAMERA_MARGIN_RIGHT), GetCameraBoundMaxY() + GetCameraMargin(CAMERA_MARGIN_TOP));
            bj_mapInitialCameraBounds = GetCurrentCameraBoundsMapRectBJ();
        }

        public virtual void InitSummonableCaps()
        {
            integer index = 0;
            index = 0;
            for (
            ; true;
            )
            {
                if ((!GetPlayerTechResearched(Player(index), 1953654866, true)))
                {
                    SetPlayerTechMaxAllowed(Player(index), 1953788520, 0);
                }
                if ((!GetPlayerTechResearched(Player(index), 1801613138, true)))
                {
                    SetPlayerTechMaxAllowed(Player(index), 1801614447, 0);
                }
                SetPlayerTechMaxAllowed(Player(index), 1701540725, bj_MAX_SKELETONS);
                index = index + 1;
                if (index == bj_MAX_PLAYERS)
                {
                    break;
                }
            }
        }

        public virtual void UpdateStockAvailability(item whichItem)
        {
            itemtype iType = GetItemType(whichItem);
            integer iLevel = GetItemLevel(whichItem);
            if ((iType == ITEM_TYPE_PERMANENT))
            {
                bj_stockAllowedPermanent[iLevel] = true;
            }
            else
            {
                if ((iType == ITEM_TYPE_CHARGED))
                {
                    bj_stockAllowedCharged[iLevel] = true;
                }
                else
                {
                    if ((iType == ITEM_TYPE_ARTIFACT))
                    {
                        bj_stockAllowedArtifact[iLevel] = true;
                    }
                }
            }
        }

        public virtual void UpdateEachStockBuildingEnum()
        {
            integer iteration = 0;
            integer pickedItemId = 0;
            for (
            ; true;
            )
            {
                pickedItemId = ChooseRandomItemEx(bj_stockPickedItemType, bj_stockPickedItemLevel);
                if (IsItemIdSellable(pickedItemId))
                {
                    break;
                }
                iteration = iteration + 1;
                if ((iteration > bj_STOCK_MAX_ITERATIONS))
                {
                    return;
                }
            }
            AddItemToStock(GetEnumUnit(), pickedItemId, 1, 1);
        }

        public virtual void UpdateEachStockBuilding(itemtype iType, integer iLevel)
        {
            group g;
            bj_stockPickedItemType = iType;
            bj_stockPickedItemLevel = iLevel;
            g = CreateGroup();
            GroupEnumUnitsOfType(g, "marketplace", null);
            ForGroup(g, UpdateEachStockBuildingEnum);
            DestroyGroup(g);
        }

        public virtual void PerformStockUpdates()
        {
            integer pickedItemId = 0;
            itemtype pickedItemType = null;
            integer pickedItemLevel = 0;
            integer allowedCombinations = 0;
            integer iLevel = 0;
            iLevel = 1;
            for (
            ; true;
            )
            {
                if ((bj_stockAllowedPermanent[iLevel]))
                {
                    allowedCombinations = allowedCombinations + 1;
                    if ((GetRandomInt(1, allowedCombinations) == 1))
                    {
                        pickedItemType = ITEM_TYPE_PERMANENT;
                        pickedItemLevel = iLevel;
                    }
                }
                if ((bj_stockAllowedCharged[iLevel]))
                {
                    allowedCombinations = allowedCombinations + 1;
                    if ((GetRandomInt(1, allowedCombinations) == 1))
                    {
                        pickedItemType = ITEM_TYPE_CHARGED;
                        pickedItemLevel = iLevel;
                    }
                }
                if ((bj_stockAllowedArtifact[iLevel]))
                {
                    allowedCombinations = allowedCombinations + 1;
                    if ((GetRandomInt(1, allowedCombinations) == 1))
                    {
                        pickedItemType = ITEM_TYPE_ARTIFACT;
                        pickedItemLevel = iLevel;
                    }
                }
                iLevel = iLevel + 1;
                if (iLevel > bj_MAX_ITEM_LEVEL)
                {
                    break;
                }
            }
            if ((allowedCombinations == 0))
            {
                return;
            }
            UpdateEachStockBuilding(pickedItemType, pickedItemLevel);
        }

        public virtual void StartStockUpdates()
        {
            PerformStockUpdates();
            TimerStart(bj_stockUpdateTimer, bj_STOCK_RESTOCK_INTERVAL, true, PerformStockUpdates);
        }

        public virtual void RemovePurchasedItem()
        {
            RemoveItemFromStock(GetSellingUnit(), GetItemTypeId(GetSoldItem()));
        }

        public virtual void InitNeutralBuildings()
        {
            integer iLevel = 0;
            iLevel = 0;
            for (
            ; true;
            )
            {
                bj_stockAllowedPermanent[iLevel] = false;
                bj_stockAllowedCharged[iLevel] = false;
                bj_stockAllowedArtifact[iLevel] = false;
                iLevel = iLevel + 1;
                if (iLevel > bj_MAX_ITEM_LEVEL)
                {
                    break;
                }
            }
            SetAllItemTypeSlots(bj_MAX_STOCK_ITEM_SLOTS);
            SetAllUnitTypeSlots(bj_MAX_STOCK_UNIT_SLOTS);
            bj_stockUpdateTimer = CreateTimer();
            TimerStart(bj_stockUpdateTimer, bj_STOCK_RESTOCK_INITIAL_DELAY, false, StartStockUpdates);
            bj_stockItemPurchased = CreateTrigger();
            TriggerRegisterPlayerUnitEvent(bj_stockItemPurchased, Player(PLAYER_NEUTRAL_PASSIVE), EVENT_PLAYER_UNIT_SELL_ITEM, null);
            TriggerAddAction(bj_stockItemPurchased, RemovePurchasedItem);
        }

        public virtual void MarkGameStarted()
        {
            bj_gameStarted = true;
            DestroyTimer(bj_gameStartedTimer);
        }

        public virtual void DetectGameStarted()
        {
            bj_gameStartedTimer = CreateTimer();
            TimerStart(bj_gameStartedTimer, bj_GAME_STARTED_THRESHOLD, false, MarkGameStarted);
        }

        public virtual void InitBlizzard()
        {
            ConfigureNeutralVictim();
            InitBlizzardGlobals();
            InitQueuedTriggers();
            InitRescuableBehaviorBJ();
            InitDNCSounds();
            InitMapRects();
            InitSummonableCaps();
            InitNeutralBuildings();
            DetectGameStarted();
        }

        public virtual void RandomDistReset()
        {
            bj_randDistCount = 0;
        }

        public virtual void RandomDistAddItem(integer inID, integer inChance)
        {
            bj_randDistID[bj_randDistCount] = inID;
            bj_randDistChance[bj_randDistCount] = inChance;
            bj_randDistCount = bj_randDistCount + 1;
        }

        public virtual integer RandomDistChoose()
        {
            integer sum = 0;
            integer chance = 0;
            integer index = 0;
            integer foundID = -1;
            boolean done = false;
            if ((bj_randDistCount == 0))
            {
                return -1;
            }
            index = 0;
            for (
            ; true;
            )
            {
                sum = sum + bj_randDistChance[index];
                index = index + 1;
                if (index == bj_randDistCount)
                {
                    break;
                }
            }
            chance = GetRandomInt(1, sum);
            index = 0;
            sum = 0;
            done = false;
            for (
            ; true;
            )
            {
                sum = sum + bj_randDistChance[index];
                if ((chance <= sum))
                {
                    foundID = bj_randDistID[index];
                    done = true;
                }
                index = index + 1;
                if ((index == bj_randDistCount))
                {
                    done = true;
                }
                if (done == true)
                {
                    break;
                }
            }
            return foundID;
        }

        public virtual item UnitDropItem(unit inUnit, integer inItemID)
        {
            real x = 0;
            real y = 0;
            real radius = 32;
            real unitX = 0;
            real unitY = 0;
            item droppedItem;
            if ((inItemID == -1))
            {
                return null;
            }
            unitX = GetUnitX(inUnit);
            unitY = GetUnitY(inUnit);
            x = GetRandomReal(unitX - radius, unitX + radius);
            y = GetRandomReal(unitY - radius, unitY + radius);
            droppedItem = CreateItem(inItemID, x, y);
            SetItemDropID(droppedItem, GetUnitTypeId(inUnit));
            UpdateStockAvailability(droppedItem);
            return droppedItem;
        }

        public virtual item WidgetDropItem(widget inWidget, integer inItemID)
        {
            real x = 0;
            real y = 0;
            real radius = 32;
            real widgetX = 0;
            real widgetY = 0;
            if ((inItemID == -1))
            {
                return null;
            }
            widgetX = GetWidgetX(inWidget);
            widgetY = GetWidgetY(inWidget);
            x = GetRandomReal(widgetX - radius, widgetX + radius);
            y = GetRandomReal(widgetY - radius, widgetY + radius);
            return CreateItem(inItemID, x, y);
        }
    }
}
