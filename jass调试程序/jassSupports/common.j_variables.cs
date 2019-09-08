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

    partial class MapScript
    {
        public static boolean FALSE = false;

        public static boolean TRUE = true;

        public static integer JASS_MAX_ARRAY_SIZE = 8192;

        public static integer PLAYER_NEUTRAL_PASSIVE = 15;

        public static integer PLAYER_NEUTRAL_AGGRESSIVE = 12;

        public static playercolor PLAYER_COLOR_RED = ConvertPlayerColor(0);

        public static playercolor PLAYER_COLOR_BLUE = ConvertPlayerColor(1);

        public static playercolor PLAYER_COLOR_CYAN = ConvertPlayerColor(2);

        public static playercolor PLAYER_COLOR_PURPLE = ConvertPlayerColor(3);

        public static playercolor PLAYER_COLOR_YELLOW = ConvertPlayerColor(4);

        public static playercolor PLAYER_COLOR_ORANGE = ConvertPlayerColor(5);

        public static playercolor PLAYER_COLOR_GREEN = ConvertPlayerColor(6);

        public static playercolor PLAYER_COLOR_PINK = ConvertPlayerColor(7);

        public static playercolor PLAYER_COLOR_LIGHT_GRAY = ConvertPlayerColor(8);

        public static playercolor PLAYER_COLOR_LIGHT_BLUE = ConvertPlayerColor(9);

        public static playercolor PLAYER_COLOR_AQUA = ConvertPlayerColor(10);

        public static playercolor PLAYER_COLOR_BROWN = ConvertPlayerColor(11);

        public static race RACE_HUMAN = ConvertRace(1);

        public static race RACE_ORC = ConvertRace(2);

        public static race RACE_UNDEAD = ConvertRace(3);

        public static race RACE_NIGHTELF = ConvertRace(4);

        public static race RACE_DEMON = ConvertRace(5);

        public static race RACE_OTHER = ConvertRace(7);

        public static playergameresult PLAYER_GAME_RESULT_VICTORY = ConvertPlayerGameResult(0);

        public static playergameresult PLAYER_GAME_RESULT_DEFEAT = ConvertPlayerGameResult(1);

        public static playergameresult PLAYER_GAME_RESULT_TIE = ConvertPlayerGameResult(2);

        public static playergameresult PLAYER_GAME_RESULT_NEUTRAL = ConvertPlayerGameResult(3);

        public static alliancetype ALLIANCE_PASSIVE = ConvertAllianceType(0);

        public static alliancetype ALLIANCE_HELP_REQUEST = ConvertAllianceType(1);

        public static alliancetype ALLIANCE_HELP_RESPONSE = ConvertAllianceType(2);

        public static alliancetype ALLIANCE_SHARED_XP = ConvertAllianceType(3);

        public static alliancetype ALLIANCE_SHARED_SPELLS = ConvertAllianceType(4);

        public static alliancetype ALLIANCE_SHARED_VISION = ConvertAllianceType(5);

        public static alliancetype ALLIANCE_SHARED_CONTROL = ConvertAllianceType(6);

        public static alliancetype ALLIANCE_SHARED_ADVANCED_CONTROL = ConvertAllianceType(7);

        public static alliancetype ALLIANCE_RESCUABLE = ConvertAllianceType(8);

        public static alliancetype ALLIANCE_SHARED_VISION_FORCED = ConvertAllianceType(9);

        public static version VERSION_REIGN_OF_CHAOS = ConvertVersion(0);

        public static version VERSION_FROZEN_THRONE = ConvertVersion(1);

        public static attacktype ATTACK_TYPE_NORMAL = ConvertAttackType(0);

        public static attacktype ATTACK_TYPE_MELEE = ConvertAttackType(1);

        public static attacktype ATTACK_TYPE_PIERCE = ConvertAttackType(2);

        public static attacktype ATTACK_TYPE_SIEGE = ConvertAttackType(3);

        public static attacktype ATTACK_TYPE_MAGIC = ConvertAttackType(4);

        public static attacktype ATTACK_TYPE_CHAOS = ConvertAttackType(5);

        public static attacktype ATTACK_TYPE_HERO = ConvertAttackType(6);

        public static damagetype DAMAGE_TYPE_UNKNOWN = ConvertDamageType(0);

        public static damagetype DAMAGE_TYPE_NORMAL = ConvertDamageType(4);

        public static damagetype DAMAGE_TYPE_ENHANCED = ConvertDamageType(5);

        public static damagetype DAMAGE_TYPE_FIRE = ConvertDamageType(8);

        public static damagetype DAMAGE_TYPE_COLD = ConvertDamageType(9);

        public static damagetype DAMAGE_TYPE_LIGHTNING = ConvertDamageType(10);

        public static damagetype DAMAGE_TYPE_POISON = ConvertDamageType(11);

        public static damagetype DAMAGE_TYPE_DISEASE = ConvertDamageType(12);

        public static damagetype DAMAGE_TYPE_DIVINE = ConvertDamageType(13);

        public static damagetype DAMAGE_TYPE_MAGIC = ConvertDamageType(14);

        public static damagetype DAMAGE_TYPE_SONIC = ConvertDamageType(15);

        public static damagetype DAMAGE_TYPE_ACID = ConvertDamageType(16);

        public static damagetype DAMAGE_TYPE_FORCE = ConvertDamageType(17);

        public static damagetype DAMAGE_TYPE_DEATH = ConvertDamageType(18);

        public static damagetype DAMAGE_TYPE_MIND = ConvertDamageType(19);

        public static damagetype DAMAGE_TYPE_PLANT = ConvertDamageType(20);

        public static damagetype DAMAGE_TYPE_DEFENSIVE = ConvertDamageType(21);

        public static damagetype DAMAGE_TYPE_DEMOLITION = ConvertDamageType(22);

        public static damagetype DAMAGE_TYPE_SLOW_POISON = ConvertDamageType(23);

        public static damagetype DAMAGE_TYPE_SPIRIT_LINK = ConvertDamageType(24);

        public static damagetype DAMAGE_TYPE_SHADOW_STRIKE = ConvertDamageType(25);

        public static damagetype DAMAGE_TYPE_UNIVERSAL = ConvertDamageType(26);

        public static weapontype WEAPON_TYPE_WHOKNOWS = ConvertWeaponType(0);

        public static weapontype WEAPON_TYPE_METAL_LIGHT_CHOP = ConvertWeaponType(1);

        public static weapontype WEAPON_TYPE_METAL_MEDIUM_CHOP = ConvertWeaponType(2);

        public static weapontype WEAPON_TYPE_METAL_HEAVY_CHOP = ConvertWeaponType(3);

        public static weapontype WEAPON_TYPE_METAL_LIGHT_SLICE = ConvertWeaponType(4);

        public static weapontype WEAPON_TYPE_METAL_MEDIUM_SLICE = ConvertWeaponType(5);

        public static weapontype WEAPON_TYPE_METAL_HEAVY_SLICE = ConvertWeaponType(6);

        public static weapontype WEAPON_TYPE_METAL_MEDIUM_BASH = ConvertWeaponType(7);

        public static weapontype WEAPON_TYPE_METAL_HEAVY_BASH = ConvertWeaponType(8);

        public static weapontype WEAPON_TYPE_METAL_MEDIUM_STAB = ConvertWeaponType(9);

        public static weapontype WEAPON_TYPE_METAL_HEAVY_STAB = ConvertWeaponType(10);

        public static weapontype WEAPON_TYPE_WOOD_LIGHT_SLICE = ConvertWeaponType(11);

        public static weapontype WEAPON_TYPE_WOOD_MEDIUM_SLICE = ConvertWeaponType(12);

        public static weapontype WEAPON_TYPE_WOOD_HEAVY_SLICE = ConvertWeaponType(13);

        public static weapontype WEAPON_TYPE_WOOD_LIGHT_BASH = ConvertWeaponType(14);

        public static weapontype WEAPON_TYPE_WOOD_MEDIUM_BASH = ConvertWeaponType(15);

        public static weapontype WEAPON_TYPE_WOOD_HEAVY_BASH = ConvertWeaponType(16);

        public static weapontype WEAPON_TYPE_WOOD_LIGHT_STAB = ConvertWeaponType(17);

        public static weapontype WEAPON_TYPE_WOOD_MEDIUM_STAB = ConvertWeaponType(18);

        public static weapontype WEAPON_TYPE_CLAW_LIGHT_SLICE = ConvertWeaponType(19);

        public static weapontype WEAPON_TYPE_CLAW_MEDIUM_SLICE = ConvertWeaponType(20);

        public static weapontype WEAPON_TYPE_CLAW_HEAVY_SLICE = ConvertWeaponType(21);

        public static weapontype WEAPON_TYPE_AXE_MEDIUM_CHOP = ConvertWeaponType(22);

        public static weapontype WEAPON_TYPE_ROCK_HEAVY_BASH = ConvertWeaponType(23);

        public static pathingtype PATHING_TYPE_ANY = ConvertPathingType(0);

        public static pathingtype PATHING_TYPE_WALKABILITY = ConvertPathingType(1);

        public static pathingtype PATHING_TYPE_FLYABILITY = ConvertPathingType(2);

        public static pathingtype PATHING_TYPE_BUILDABILITY = ConvertPathingType(3);

        public static pathingtype PATHING_TYPE_PEONHARVESTPATHING = ConvertPathingType(4);

        public static pathingtype PATHING_TYPE_BLIGHTPATHING = ConvertPathingType(5);

        public static pathingtype PATHING_TYPE_FLOATABILITY = ConvertPathingType(6);

        public static pathingtype PATHING_TYPE_AMPHIBIOUSPATHING = ConvertPathingType(7);

        public static racepreference RACE_PREF_HUMAN = ConvertRacePref(1);

        public static racepreference RACE_PREF_ORC = ConvertRacePref(2);

        public static racepreference RACE_PREF_NIGHTELF = ConvertRacePref(4);

        public static racepreference RACE_PREF_UNDEAD = ConvertRacePref(8);

        public static racepreference RACE_PREF_DEMON = ConvertRacePref(16);

        public static racepreference RACE_PREF_RANDOM = ConvertRacePref(32);

        public static racepreference RACE_PREF_USER_SELECTABLE = ConvertRacePref(64);

        public static mapcontrol MAP_CONTROL_USER = ConvertMapControl(0);

        public static mapcontrol MAP_CONTROL_COMPUTER = ConvertMapControl(1);

        public static mapcontrol MAP_CONTROL_RESCUABLE = ConvertMapControl(2);

        public static mapcontrol MAP_CONTROL_NEUTRAL = ConvertMapControl(3);

        public static mapcontrol MAP_CONTROL_CREEP = ConvertMapControl(4);

        public static mapcontrol MAP_CONTROL_NONE = ConvertMapControl(5);

        public static gametype GAME_TYPE_MELEE = ConvertGameType(1);

        public static gametype GAME_TYPE_FFA = ConvertGameType(2);

        public static gametype GAME_TYPE_USE_MAP_SETTINGS = ConvertGameType(4);

        public static gametype GAME_TYPE_BLIZ = ConvertGameType(8);

        public static gametype GAME_TYPE_ONE_ON_ONE = ConvertGameType(16);

        public static gametype GAME_TYPE_TWO_TEAM_PLAY = ConvertGameType(32);

        public static gametype GAME_TYPE_THREE_TEAM_PLAY = ConvertGameType(64);

        public static gametype GAME_TYPE_FOUR_TEAM_PLAY = ConvertGameType(128);

        public static mapflag MAP_FOG_HIDE_TERRAIN = ConvertMapFlag(1);

        public static mapflag MAP_FOG_MAP_EXPLORED = ConvertMapFlag(2);

        public static mapflag MAP_FOG_ALWAYS_VISIBLE = ConvertMapFlag(4);

        public static mapflag MAP_USE_HANDICAPS = ConvertMapFlag(8);

        public static mapflag MAP_OBSERVERS = ConvertMapFlag(16);

        public static mapflag MAP_OBSERVERS_ON_DEATH = ConvertMapFlag(32);

        public static mapflag MAP_FIXED_COLORS = ConvertMapFlag(128);

        public static mapflag MAP_LOCK_RESOURCE_TRADING = ConvertMapFlag(256);

        public static mapflag MAP_RESOURCE_TRADING_ALLIES_ONLY = ConvertMapFlag(512);

        public static mapflag MAP_LOCK_ALLIANCE_CHANGES = ConvertMapFlag(1024);

        public static mapflag MAP_ALLIANCE_CHANGES_HIDDEN = ConvertMapFlag(2048);

        public static mapflag MAP_CHEATS = ConvertMapFlag(4096);

        public static mapflag MAP_CHEATS_HIDDEN = ConvertMapFlag(8192);

        public static mapflag MAP_LOCK_SPEED = ConvertMapFlag(8192 * 2);

        public static mapflag MAP_LOCK_RANDOM_SEED = ConvertMapFlag(8192 * 4);

        public static mapflag MAP_SHARED_ADVANCED_CONTROL = ConvertMapFlag(8192 * 8);

        public static mapflag MAP_RANDOM_HERO = ConvertMapFlag(8192 * 16);

        public static mapflag MAP_RANDOM_RACES = ConvertMapFlag(8192 * 32);

        public static mapflag MAP_RELOADED = ConvertMapFlag(8192 * 64);

        public static placement MAP_PLACEMENT_RANDOM = ConvertPlacement(0);

        public static placement MAP_PLACEMENT_FIXED = ConvertPlacement(1);

        public static placement MAP_PLACEMENT_USE_MAP_SETTINGS = ConvertPlacement(2);

        public static placement MAP_PLACEMENT_TEAMS_TOGETHER = ConvertPlacement(3);

        public static startlocprio MAP_LOC_PRIO_LOW = ConvertStartLocPrio(0);

        public static startlocprio MAP_LOC_PRIO_HIGH = ConvertStartLocPrio(1);

        public static startlocprio MAP_LOC_PRIO_NOT = ConvertStartLocPrio(2);

        public static mapdensity MAP_DENSITY_NONE = ConvertMapDensity(0);

        public static mapdensity MAP_DENSITY_LIGHT = ConvertMapDensity(1);

        public static mapdensity MAP_DENSITY_MEDIUM = ConvertMapDensity(2);

        public static mapdensity MAP_DENSITY_HEAVY = ConvertMapDensity(3);

        public static gamedifficulty MAP_DIFFICULTY_EASY = ConvertGameDifficulty(0);

        public static gamedifficulty MAP_DIFFICULTY_NORMAL = ConvertGameDifficulty(1);

        public static gamedifficulty MAP_DIFFICULTY_HARD = ConvertGameDifficulty(2);

        public static gamedifficulty MAP_DIFFICULTY_INSANE = ConvertGameDifficulty(3);

        public static gamespeed MAP_SPEED_SLOWEST = ConvertGameSpeed(0);

        public static gamespeed MAP_SPEED_SLOW = ConvertGameSpeed(1);

        public static gamespeed MAP_SPEED_NORMAL = ConvertGameSpeed(2);

        public static gamespeed MAP_SPEED_FAST = ConvertGameSpeed(3);

        public static gamespeed MAP_SPEED_FASTEST = ConvertGameSpeed(4);

        public static playerslotstate PLAYER_SLOT_STATE_EMPTY = ConvertPlayerSlotState(0);

        public static playerslotstate PLAYER_SLOT_STATE_PLAYING = ConvertPlayerSlotState(1);

        public static playerslotstate PLAYER_SLOT_STATE_LEFT = ConvertPlayerSlotState(2);

        public static volumegroup SOUND_VOLUMEGROUP_UNITMOVEMENT = ConvertVolumeGroup(0);

        public static volumegroup SOUND_VOLUMEGROUP_UNITSOUNDS = ConvertVolumeGroup(1);

        public static volumegroup SOUND_VOLUMEGROUP_COMBAT = ConvertVolumeGroup(2);

        public static volumegroup SOUND_VOLUMEGROUP_SPELLS = ConvertVolumeGroup(3);

        public static volumegroup SOUND_VOLUMEGROUP_UI = ConvertVolumeGroup(4);

        public static volumegroup SOUND_VOLUMEGROUP_MUSIC = ConvertVolumeGroup(5);

        public static volumegroup SOUND_VOLUMEGROUP_AMBIENTSOUNDS = ConvertVolumeGroup(6);

        public static volumegroup SOUND_VOLUMEGROUP_FIRE = ConvertVolumeGroup(7);

        public static igamestate GAME_STATE_DIVINE_INTERVENTION = ConvertIGameState(0);

        public static igamestate GAME_STATE_DISCONNECTED = ConvertIGameState(1);

        public static fgamestate GAME_STATE_TIME_OF_DAY = ConvertFGameState(2);

        public static playerstate PLAYER_STATE_GAME_RESULT = ConvertPlayerState(0);

        public static playerstate PLAYER_STATE_RESOURCE_GOLD = ConvertPlayerState(1);

        public static playerstate PLAYER_STATE_RESOURCE_LUMBER = ConvertPlayerState(2);

        public static playerstate PLAYER_STATE_RESOURCE_HERO_TOKENS = ConvertPlayerState(3);

        public static playerstate PLAYER_STATE_RESOURCE_FOOD_CAP = ConvertPlayerState(4);

        public static playerstate PLAYER_STATE_RESOURCE_FOOD_USED = ConvertPlayerState(5);

        public static playerstate PLAYER_STATE_FOOD_CAP_CEILING = ConvertPlayerState(6);

        public static playerstate PLAYER_STATE_GIVES_BOUNTY = ConvertPlayerState(7);

        public static playerstate PLAYER_STATE_ALLIED_VICTORY = ConvertPlayerState(8);

        public static playerstate PLAYER_STATE_PLACED = ConvertPlayerState(9);

        public static playerstate PLAYER_STATE_OBSERVER_ON_DEATH = ConvertPlayerState(10);

        public static playerstate PLAYER_STATE_OBSERVER = ConvertPlayerState(11);

        public static playerstate PLAYER_STATE_UNFOLLOWABLE = ConvertPlayerState(12);

        public static playerstate PLAYER_STATE_GOLD_UPKEEP_RATE = ConvertPlayerState(13);

        public static playerstate PLAYER_STATE_LUMBER_UPKEEP_RATE = ConvertPlayerState(14);

        public static playerstate PLAYER_STATE_GOLD_GATHERED = ConvertPlayerState(15);

        public static playerstate PLAYER_STATE_LUMBER_GATHERED = ConvertPlayerState(16);

        public static playerstate PLAYER_STATE_NO_CREEP_SLEEP = ConvertPlayerState(25);

        public static unitstate UNIT_STATE_LIFE = ConvertUnitState(0);

        public static unitstate UNIT_STATE_MAX_LIFE = ConvertUnitState(1);

        public static unitstate UNIT_STATE_MANA = ConvertUnitState(2);

        public static unitstate UNIT_STATE_MAX_MANA = ConvertUnitState(3);

        public static aidifficulty AI_DIFFICULTY_NEWBIE = ConvertAIDifficulty(0);

        public static aidifficulty AI_DIFFICULTY_NORMAL = ConvertAIDifficulty(1);

        public static aidifficulty AI_DIFFICULTY_INSANE = ConvertAIDifficulty(2);

        public static playerscore PLAYER_SCORE_UNITS_TRAINED = ConvertPlayerScore(0);

        public static playerscore PLAYER_SCORE_UNITS_KILLED = ConvertPlayerScore(1);

        public static playerscore PLAYER_SCORE_STRUCT_BUILT = ConvertPlayerScore(2);

        public static playerscore PLAYER_SCORE_STRUCT_RAZED = ConvertPlayerScore(3);

        public static playerscore PLAYER_SCORE_TECH_PERCENT = ConvertPlayerScore(4);

        public static playerscore PLAYER_SCORE_FOOD_MAXPROD = ConvertPlayerScore(5);

        public static playerscore PLAYER_SCORE_FOOD_MAXUSED = ConvertPlayerScore(6);

        public static playerscore PLAYER_SCORE_HEROES_KILLED = ConvertPlayerScore(7);

        public static playerscore PLAYER_SCORE_ITEMS_GAINED = ConvertPlayerScore(8);

        public static playerscore PLAYER_SCORE_MERCS_HIRED = ConvertPlayerScore(9);

        public static playerscore PLAYER_SCORE_GOLD_MINED_TOTAL = ConvertPlayerScore(10);

        public static playerscore PLAYER_SCORE_GOLD_MINED_UPKEEP = ConvertPlayerScore(11);

        public static playerscore PLAYER_SCORE_GOLD_LOST_UPKEEP = ConvertPlayerScore(12);

        public static playerscore PLAYER_SCORE_GOLD_LOST_TAX = ConvertPlayerScore(13);

        public static playerscore PLAYER_SCORE_GOLD_GIVEN = ConvertPlayerScore(14);

        public static playerscore PLAYER_SCORE_GOLD_RECEIVED = ConvertPlayerScore(15);

        public static playerscore PLAYER_SCORE_LUMBER_TOTAL = ConvertPlayerScore(16);

        public static playerscore PLAYER_SCORE_LUMBER_LOST_UPKEEP = ConvertPlayerScore(17);

        public static playerscore PLAYER_SCORE_LUMBER_LOST_TAX = ConvertPlayerScore(18);

        public static playerscore PLAYER_SCORE_LUMBER_GIVEN = ConvertPlayerScore(19);

        public static playerscore PLAYER_SCORE_LUMBER_RECEIVED = ConvertPlayerScore(20);

        public static playerscore PLAYER_SCORE_UNIT_TOTAL = ConvertPlayerScore(21);

        public static playerscore PLAYER_SCORE_HERO_TOTAL = ConvertPlayerScore(22);

        public static playerscore PLAYER_SCORE_RESOURCE_TOTAL = ConvertPlayerScore(23);

        public static playerscore PLAYER_SCORE_TOTAL = ConvertPlayerScore(24);

        public static gameevent EVENT_GAME_VICTORY = ConvertGameEvent(0);

        public static gameevent EVENT_GAME_END_LEVEL = ConvertGameEvent(1);

        public static gameevent EVENT_GAME_VARIABLE_LIMIT = ConvertGameEvent(2);

        public static gameevent EVENT_GAME_STATE_LIMIT = ConvertGameEvent(3);

        public static gameevent EVENT_GAME_TIMER_EXPIRED = ConvertGameEvent(4);

        public static gameevent EVENT_GAME_ENTER_REGION = ConvertGameEvent(5);

        public static gameevent EVENT_GAME_LEAVE_REGION = ConvertGameEvent(6);

        public static gameevent EVENT_GAME_TRACKABLE_HIT = ConvertGameEvent(7);

        public static gameevent EVENT_GAME_TRACKABLE_TRACK = ConvertGameEvent(8);

        public static gameevent EVENT_GAME_SHOW_SKILL = ConvertGameEvent(9);

        public static gameevent EVENT_GAME_BUILD_SUBMENU = ConvertGameEvent(10);

        public static playerevent EVENT_PLAYER_STATE_LIMIT = ConvertPlayerEvent(11);

        public static playerevent EVENT_PLAYER_ALLIANCE_CHANGED = ConvertPlayerEvent(12);

        public static playerevent EVENT_PLAYER_DEFEAT = ConvertPlayerEvent(13);

        public static playerevent EVENT_PLAYER_VICTORY = ConvertPlayerEvent(14);

        public static playerevent EVENT_PLAYER_LEAVE = ConvertPlayerEvent(15);

        public static playerevent EVENT_PLAYER_CHAT = ConvertPlayerEvent(16);

        public static playerevent EVENT_PLAYER_END_CINEMATIC = ConvertPlayerEvent(17);

        public static playerunitevent EVENT_PLAYER_UNIT_ATTACKED = ConvertPlayerUnitEvent(18);

        public static playerunitevent EVENT_PLAYER_UNIT_RESCUED = ConvertPlayerUnitEvent(19);

        public static playerunitevent EVENT_PLAYER_UNIT_DEATH = ConvertPlayerUnitEvent(20);

        public static playerunitevent EVENT_PLAYER_UNIT_DECAY = ConvertPlayerUnitEvent(21);

        public static playerunitevent EVENT_PLAYER_UNIT_DETECTED = ConvertPlayerUnitEvent(22);

        public static playerunitevent EVENT_PLAYER_UNIT_HIDDEN = ConvertPlayerUnitEvent(23);

        public static playerunitevent EVENT_PLAYER_UNIT_SELECTED = ConvertPlayerUnitEvent(24);

        public static playerunitevent EVENT_PLAYER_UNIT_DESELECTED = ConvertPlayerUnitEvent(25);

        public static playerunitevent EVENT_PLAYER_UNIT_CONSTRUCT_START = ConvertPlayerUnitEvent(26);

        public static playerunitevent EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL = ConvertPlayerUnitEvent(27);

        public static playerunitevent EVENT_PLAYER_UNIT_CONSTRUCT_FINISH = ConvertPlayerUnitEvent(28);

        public static playerunitevent EVENT_PLAYER_UNIT_UPGRADE_START = ConvertPlayerUnitEvent(29);

        public static playerunitevent EVENT_PLAYER_UNIT_UPGRADE_CANCEL = ConvertPlayerUnitEvent(30);

        public static playerunitevent EVENT_PLAYER_UNIT_UPGRADE_FINISH = ConvertPlayerUnitEvent(31);

        public static playerunitevent EVENT_PLAYER_UNIT_TRAIN_START = ConvertPlayerUnitEvent(32);

        public static playerunitevent EVENT_PLAYER_UNIT_TRAIN_CANCEL = ConvertPlayerUnitEvent(33);

        public static playerunitevent EVENT_PLAYER_UNIT_TRAIN_FINISH = ConvertPlayerUnitEvent(34);

        public static playerunitevent EVENT_PLAYER_UNIT_RESEARCH_START = ConvertPlayerUnitEvent(35);

        public static playerunitevent EVENT_PLAYER_UNIT_RESEARCH_CANCEL = ConvertPlayerUnitEvent(36);

        public static playerunitevent EVENT_PLAYER_UNIT_RESEARCH_FINISH = ConvertPlayerUnitEvent(37);

        public static playerunitevent EVENT_PLAYER_UNIT_ISSUED_ORDER = ConvertPlayerUnitEvent(38);

        public static playerunitevent EVENT_PLAYER_UNIT_ISSUED_POINT_ORDER = ConvertPlayerUnitEvent(39);

        public static playerunitevent EVENT_PLAYER_UNIT_ISSUED_TARGET_ORDER = ConvertPlayerUnitEvent(40);

        public static playerunitevent EVENT_PLAYER_UNIT_ISSUED_UNIT_ORDER = ConvertPlayerUnitEvent(40);

        public static playerunitevent EVENT_PLAYER_HERO_LEVEL = ConvertPlayerUnitEvent(41);

        public static playerunitevent EVENT_PLAYER_HERO_SKILL = ConvertPlayerUnitEvent(42);

        public static playerunitevent EVENT_PLAYER_HERO_REVIVABLE = ConvertPlayerUnitEvent(43);

        public static playerunitevent EVENT_PLAYER_HERO_REVIVE_START = ConvertPlayerUnitEvent(44);

        public static playerunitevent EVENT_PLAYER_HERO_REVIVE_CANCEL = ConvertPlayerUnitEvent(45);

        public static playerunitevent EVENT_PLAYER_HERO_REVIVE_FINISH = ConvertPlayerUnitEvent(46);

        public static playerunitevent EVENT_PLAYER_UNIT_SUMMON = ConvertPlayerUnitEvent(47);

        public static playerunitevent EVENT_PLAYER_UNIT_DROP_ITEM = ConvertPlayerUnitEvent(48);

        public static playerunitevent EVENT_PLAYER_UNIT_PICKUP_ITEM = ConvertPlayerUnitEvent(49);

        public static playerunitevent EVENT_PLAYER_UNIT_USE_ITEM = ConvertPlayerUnitEvent(50);

        public static playerunitevent EVENT_PLAYER_UNIT_LOADED = ConvertPlayerUnitEvent(51);

        public static unitevent EVENT_UNIT_DAMAGED = ConvertUnitEvent(52);

        public static unitevent EVENT_UNIT_DEATH = ConvertUnitEvent(53);

        public static unitevent EVENT_UNIT_DECAY = ConvertUnitEvent(54);

        public static unitevent EVENT_UNIT_DETECTED = ConvertUnitEvent(55);

        public static unitevent EVENT_UNIT_HIDDEN = ConvertUnitEvent(56);

        public static unitevent EVENT_UNIT_SELECTED = ConvertUnitEvent(57);

        public static unitevent EVENT_UNIT_DESELECTED = ConvertUnitEvent(58);

        public static unitevent EVENT_UNIT_STATE_LIMIT = ConvertUnitEvent(59);

        public static unitevent EVENT_UNIT_ACQUIRED_TARGET = ConvertUnitEvent(60);

        public static unitevent EVENT_UNIT_TARGET_IN_RANGE = ConvertUnitEvent(61);

        public static unitevent EVENT_UNIT_ATTACKED = ConvertUnitEvent(62);

        public static unitevent EVENT_UNIT_RESCUED = ConvertUnitEvent(63);

        public static unitevent EVENT_UNIT_CONSTRUCT_CANCEL = ConvertUnitEvent(64);

        public static unitevent EVENT_UNIT_CONSTRUCT_FINISH = ConvertUnitEvent(65);

        public static unitevent EVENT_UNIT_UPGRADE_START = ConvertUnitEvent(66);

        public static unitevent EVENT_UNIT_UPGRADE_CANCEL = ConvertUnitEvent(67);

        public static unitevent EVENT_UNIT_UPGRADE_FINISH = ConvertUnitEvent(68);

        public static unitevent EVENT_UNIT_TRAIN_START = ConvertUnitEvent(69);

        public static unitevent EVENT_UNIT_TRAIN_CANCEL = ConvertUnitEvent(70);

        public static unitevent EVENT_UNIT_TRAIN_FINISH = ConvertUnitEvent(71);

        public static unitevent EVENT_UNIT_RESEARCH_START = ConvertUnitEvent(72);

        public static unitevent EVENT_UNIT_RESEARCH_CANCEL = ConvertUnitEvent(73);

        public static unitevent EVENT_UNIT_RESEARCH_FINISH = ConvertUnitEvent(74);

        public static unitevent EVENT_UNIT_ISSUED_ORDER = ConvertUnitEvent(75);

        public static unitevent EVENT_UNIT_ISSUED_POINT_ORDER = ConvertUnitEvent(76);

        public static unitevent EVENT_UNIT_ISSUED_TARGET_ORDER = ConvertUnitEvent(77);

        public static unitevent EVENT_UNIT_HERO_LEVEL = ConvertUnitEvent(78);

        public static unitevent EVENT_UNIT_HERO_SKILL = ConvertUnitEvent(79);

        public static unitevent EVENT_UNIT_HERO_REVIVABLE = ConvertUnitEvent(80);

        public static unitevent EVENT_UNIT_HERO_REVIVE_START = ConvertUnitEvent(81);

        public static unitevent EVENT_UNIT_HERO_REVIVE_CANCEL = ConvertUnitEvent(82);

        public static unitevent EVENT_UNIT_HERO_REVIVE_FINISH = ConvertUnitEvent(83);

        public static unitevent EVENT_UNIT_SUMMON = ConvertUnitEvent(84);

        public static unitevent EVENT_UNIT_DROP_ITEM = ConvertUnitEvent(85);

        public static unitevent EVENT_UNIT_PICKUP_ITEM = ConvertUnitEvent(86);

        public static unitevent EVENT_UNIT_USE_ITEM = ConvertUnitEvent(87);

        public static unitevent EVENT_UNIT_LOADED = ConvertUnitEvent(88);

        public static widgetevent EVENT_WIDGET_DEATH = ConvertWidgetEvent(89);

        public static dialogevent EVENT_DIALOG_BUTTON_CLICK = ConvertDialogEvent(90);

        public static dialogevent EVENT_DIALOG_CLICK = ConvertDialogEvent(91);

        public static gameevent EVENT_GAME_LOADED = ConvertGameEvent(256);

        public static gameevent EVENT_GAME_TOURNAMENT_FINISH_SOON = ConvertGameEvent(257);

        public static gameevent EVENT_GAME_TOURNAMENT_FINISH_NOW = ConvertGameEvent(258);

        public static gameevent EVENT_GAME_SAVE = ConvertGameEvent(259);

        public static playerevent EVENT_PLAYER_ARROW_LEFT_DOWN = ConvertPlayerEvent(261);

        public static playerevent EVENT_PLAYER_ARROW_LEFT_UP = ConvertPlayerEvent(262);

        public static playerevent EVENT_PLAYER_ARROW_RIGHT_DOWN = ConvertPlayerEvent(263);

        public static playerevent EVENT_PLAYER_ARROW_RIGHT_UP = ConvertPlayerEvent(264);

        public static playerevent EVENT_PLAYER_ARROW_DOWN_DOWN = ConvertPlayerEvent(265);

        public static playerevent EVENT_PLAYER_ARROW_DOWN_UP = ConvertPlayerEvent(266);

        public static playerevent EVENT_PLAYER_ARROW_UP_DOWN = ConvertPlayerEvent(267);

        public static playerevent EVENT_PLAYER_ARROW_UP_UP = ConvertPlayerEvent(268);

        public static playerunitevent EVENT_PLAYER_UNIT_SELL = ConvertPlayerUnitEvent(269);

        public static playerunitevent EVENT_PLAYER_UNIT_CHANGE_OWNER = ConvertPlayerUnitEvent(270);

        public static playerunitevent EVENT_PLAYER_UNIT_SELL_ITEM = ConvertPlayerUnitEvent(271);

        public static playerunitevent EVENT_PLAYER_UNIT_SPELL_CHANNEL = ConvertPlayerUnitEvent(272);

        public static playerunitevent EVENT_PLAYER_UNIT_SPELL_CAST = ConvertPlayerUnitEvent(273);

        public static playerunitevent EVENT_PLAYER_UNIT_SPELL_EFFECT = ConvertPlayerUnitEvent(274);

        public static playerunitevent EVENT_PLAYER_UNIT_SPELL_FINISH = ConvertPlayerUnitEvent(275);

        public static playerunitevent EVENT_PLAYER_UNIT_SPELL_ENDCAST = ConvertPlayerUnitEvent(276);

        public static playerunitevent EVENT_PLAYER_UNIT_PAWN_ITEM = ConvertPlayerUnitEvent(277);

        public static unitevent EVENT_UNIT_SELL = ConvertUnitEvent(286);

        public static unitevent EVENT_UNIT_CHANGE_OWNER = ConvertUnitEvent(287);

        public static unitevent EVENT_UNIT_SELL_ITEM = ConvertUnitEvent(288);

        public static unitevent EVENT_UNIT_SPELL_CHANNEL = ConvertUnitEvent(289);

        public static unitevent EVENT_UNIT_SPELL_CAST = ConvertUnitEvent(290);

        public static unitevent EVENT_UNIT_SPELL_EFFECT = ConvertUnitEvent(291);

        public static unitevent EVENT_UNIT_SPELL_FINISH = ConvertUnitEvent(292);

        public static unitevent EVENT_UNIT_SPELL_ENDCAST = ConvertUnitEvent(293);

        public static unitevent EVENT_UNIT_PAWN_ITEM = ConvertUnitEvent(294);

        public static limitop LESS_THAN = ConvertLimitOp(0);

        public static limitop LESS_THAN_OR_EQUAL = ConvertLimitOp(1);

        public static limitop EQUAL = ConvertLimitOp(2);

        public static limitop GREATER_THAN_OR_EQUAL = ConvertLimitOp(3);

        public static limitop GREATER_THAN = ConvertLimitOp(4);

        public static limitop NOT_EQUAL = ConvertLimitOp(5);

        public static unittype UNIT_TYPE_HERO = ConvertUnitType(0);

        public static unittype UNIT_TYPE_DEAD = ConvertUnitType(1);

        public static unittype UNIT_TYPE_STRUCTURE = ConvertUnitType(2);

        public static unittype UNIT_TYPE_FLYING = ConvertUnitType(3);

        public static unittype UNIT_TYPE_GROUND = ConvertUnitType(4);

        public static unittype UNIT_TYPE_ATTACKS_FLYING = ConvertUnitType(5);

        public static unittype UNIT_TYPE_ATTACKS_GROUND = ConvertUnitType(6);

        public static unittype UNIT_TYPE_MELEE_ATTACKER = ConvertUnitType(7);

        public static unittype UNIT_TYPE_RANGED_ATTACKER = ConvertUnitType(8);

        public static unittype UNIT_TYPE_GIANT = ConvertUnitType(9);

        public static unittype UNIT_TYPE_SUMMONED = ConvertUnitType(10);

        public static unittype UNIT_TYPE_STUNNED = ConvertUnitType(11);

        public static unittype UNIT_TYPE_PLAGUED = ConvertUnitType(12);

        public static unittype UNIT_TYPE_SNARED = ConvertUnitType(13);

        public static unittype UNIT_TYPE_UNDEAD = ConvertUnitType(14);

        public static unittype UNIT_TYPE_MECHANICAL = ConvertUnitType(15);

        public static unittype UNIT_TYPE_PEON = ConvertUnitType(16);

        public static unittype UNIT_TYPE_SAPPER = ConvertUnitType(17);

        public static unittype UNIT_TYPE_TOWNHALL = ConvertUnitType(18);

        public static unittype UNIT_TYPE_ANCIENT = ConvertUnitType(19);

        public static unittype UNIT_TYPE_TAUREN = ConvertUnitType(20);

        public static unittype UNIT_TYPE_POISONED = ConvertUnitType(21);

        public static unittype UNIT_TYPE_POLYMORPHED = ConvertUnitType(22);

        public static unittype UNIT_TYPE_SLEEPING = ConvertUnitType(23);

        public static unittype UNIT_TYPE_RESISTANT = ConvertUnitType(24);

        public static unittype UNIT_TYPE_ETHEREAL = ConvertUnitType(25);

        public static unittype UNIT_TYPE_MAGIC_IMMUNE = ConvertUnitType(26);

        public static itemtype ITEM_TYPE_PERMANENT = ConvertItemType(0);

        public static itemtype ITEM_TYPE_CHARGED = ConvertItemType(1);

        public static itemtype ITEM_TYPE_POWERUP = ConvertItemType(2);

        public static itemtype ITEM_TYPE_ARTIFACT = ConvertItemType(3);

        public static itemtype ITEM_TYPE_PURCHASABLE = ConvertItemType(4);

        public static itemtype ITEM_TYPE_CAMPAIGN = ConvertItemType(5);

        public static itemtype ITEM_TYPE_MISCELLANEOUS = ConvertItemType(6);

        public static itemtype ITEM_TYPE_UNKNOWN = ConvertItemType(7);

        public static itemtype ITEM_TYPE_ANY = ConvertItemType(8);

        public static itemtype ITEM_TYPE_TOME = ConvertItemType(2);

        public static camerafield CAMERA_FIELD_TARGET_DISTANCE = ConvertCameraField(0);

        public static camerafield CAMERA_FIELD_FARZ = ConvertCameraField(1);

        public static camerafield CAMERA_FIELD_ANGLE_OF_ATTACK = ConvertCameraField(2);

        public static camerafield CAMERA_FIELD_FIELD_OF_VIEW = ConvertCameraField(3);

        public static camerafield CAMERA_FIELD_ROLL = ConvertCameraField(4);

        public static camerafield CAMERA_FIELD_ROTATION = ConvertCameraField(5);

        public static camerafield CAMERA_FIELD_ZOFFSET = ConvertCameraField(6);

        public static blendmode BLEND_MODE_NONE = ConvertBlendMode(0);

        public static blendmode BLEND_MODE_DONT_CARE = ConvertBlendMode(0);

        public static blendmode BLEND_MODE_KEYALPHA = ConvertBlendMode(1);

        public static blendmode BLEND_MODE_BLEND = ConvertBlendMode(2);

        public static blendmode BLEND_MODE_ADDITIVE = ConvertBlendMode(3);

        public static blendmode BLEND_MODE_MODULATE = ConvertBlendMode(4);

        public static blendmode BLEND_MODE_MODULATE_2X = ConvertBlendMode(5);

        public static raritycontrol RARITY_FREQUENT = ConvertRarityControl(0);

        public static raritycontrol RARITY_RARE = ConvertRarityControl(1);

        public static texmapflags TEXMAP_FLAG_NONE = ConvertTexMapFlags(0);

        public static texmapflags TEXMAP_FLAG_WRAP_U = ConvertTexMapFlags(1);

        public static texmapflags TEXMAP_FLAG_WRAP_V = ConvertTexMapFlags(2);

        public static texmapflags TEXMAP_FLAG_WRAP_UV = ConvertTexMapFlags(3);

        public static fogstate FOG_OF_WAR_MASKED = ConvertFogState(1);

        public static fogstate FOG_OF_WAR_FOGGED = ConvertFogState(2);

        public static fogstate FOG_OF_WAR_VISIBLE = ConvertFogState(4);

        public static integer CAMERA_MARGIN_LEFT = 0;

        public static integer CAMERA_MARGIN_RIGHT = 1;

        public static integer CAMERA_MARGIN_TOP = 2;

        public static integer CAMERA_MARGIN_BOTTOM = 3;

        public static effecttype EFFECT_TYPE_EFFECT = ConvertEffectType(0);

        public static effecttype EFFECT_TYPE_TARGET = ConvertEffectType(1);

        public static effecttype EFFECT_TYPE_CASTER = ConvertEffectType(2);

        public static effecttype EFFECT_TYPE_SPECIAL = ConvertEffectType(3);

        public static effecttype EFFECT_TYPE_AREA_EFFECT = ConvertEffectType(4);

        public static effecttype EFFECT_TYPE_MISSILE = ConvertEffectType(5);

        public static effecttype EFFECT_TYPE_LIGHTNING = ConvertEffectType(6);

        public static soundtype SOUND_TYPE_EFFECT = ConvertSoundType(0);

        public static soundtype SOUND_TYPE_EFFECT_LOOPED = ConvertSoundType(1);
    }
}
