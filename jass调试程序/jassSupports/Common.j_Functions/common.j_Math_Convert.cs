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

        #region Math&TypeConvert
        public static real Deg2Rad(real degrees)
        {
            return (real)(degrees / 180 * Math.PI);
        }

        public static real Rad2Deg(real radians)
        {
            return (real)(radians / Math.PI * 180);
        }

        public static real Sin(real radians) => (real)Math.Sin(radians);

        public static real Cos(real radians) => (real)Math.Cos(radians);

        public static real Tan(real radians)
        {
            return (real)Math.Tan(radians);
        }

        public static real Asin(real y)
        {
            return (real)Math.Asin(y);
        }

        public static real Acos(real x)
        {
            return (real)Math.Acos(x);
        }

        public static real Atan(real x)
        {
            return (real)Math.Atan(x);
        }

        public static real Atan2(real y, real x)
        {
            return (real)Math.Atan2(y, x);
        }
        /// <summary>
        /// 平方根
        /// </summary>
        /// <param name="x"></param>
        /// <returns>返回平方根</returns>
        public static real SquareRoot(real x)
        {
            return (real)Math.Sqrt(x);
        }

        public static real Pow(real x, real power)
        {
            return (real)Math.Pow(x, power);
        }
        /// <summary>
        /// 转换整数为实数
        /// </summary>
        /// <param name="i"></param>
        /// <returns>返回转换的实数</returns>
        public static real I2R(integer i)
        {
            return i;
        }
        /// <summary>
        /// 转换实数为整数
        /// </summary>
        /// <param name="r"></param>
        /// <returns>返回转换的整数</returns>
        public static integer R2I(real r)
        {
            return (integer)r;
        }

        public static @string I2S(integer i)
        {
            return i.ToString();
        }

        public static @string R2S(real r)
        {
            return r.ToString();
        }

        public static @string R2SW(real r, integer width, integer precision)
        {
            return r.ToString("");
        }

        public static integer S2I(@string s)
        {
            integer.TryParse(s, out integer i);
            return i;
        }

        public static real S2R(@string s)
        {
            real.TryParse(s, out real r);
            return r;
        }
        #endregion

        #region Convert?
        public static race ConvertRace(integer i)
        {
            return race.get(i);
        }

        public static alliancetype ConvertAllianceType(integer i)
        {
            return alliancetype.get(i);
        }

        public static racepreference ConvertRacePref(integer i)
        {
            return racepreference.get(i);
        }

        public static igamestate ConvertIGameState(integer i)
        {
            return igamestate.get(i);
        }

        public static fgamestate ConvertFGameState(integer i)
        {
            return fgamestate.get(i);
        }

        public static playerstate ConvertPlayerState(integer i)
        {
            return playerstate.get(i);
        }

        public static playerscore ConvertPlayerScore(integer i)
        {
            return playerscore.get(i);
        }

        public static playergameresult ConvertPlayerGameResult(integer i)
        {
            return playergameresult.get(i);
        }

        public static unitstate ConvertUnitState(integer i)
        {
            return unitstate.get(i);
        }

        public static aidifficulty ConvertAIDifficulty(integer i)
        {
            return aidifficulty.get(i);
        }

        public static gameevent ConvertGameEvent(integer i)
        {
            return gameevent.get(i);
        }

        public static playerevent ConvertPlayerEvent(integer i)
        {
            return playerevent.get(i);
        }

        public static playerunitevent ConvertPlayerUnitEvent(integer i)
        {
            return playerunitevent.get(i);
        }

        public static widgetevent ConvertWidgetEvent(integer i)
        {
            return widgetevent.get(i);
        }

        public static dialogevent ConvertDialogEvent(integer i)
        {
            return dialogevent.get(i);
        }

        public static unitevent ConvertUnitEvent(integer i)
        {
            return unitevent.get(i);
        }

        public static limitop ConvertLimitOp(integer i)
        {
            return limitop.get(i);
        }

        public static unittype ConvertUnitType(integer i)
        {
            return unittype.get(i);
        }

        public static gamespeed ConvertGameSpeed(integer i)
        {
            return gamespeed.get(i);
        }

        public static placement ConvertPlacement(integer i)
        {
            return placement.get(i);
        }

        public static startlocprio ConvertStartLocPrio(integer i)
        {
            return startlocprio.get(i);
        }

        public static gamedifficulty ConvertGameDifficulty(integer i)
        {
            return gamedifficulty.get(i);
        }

        public static gametype ConvertGameType(integer i)
        {
            return gametype.get(i);
        }

        public static mapflag ConvertMapFlag(integer i)
        {
            return mapflag.get(i);
        }

        public static mapvisibility ConvertMapVisibility(integer i)
        {
            return mapvisibility.get(i);
        }

        public static mapsetting ConvertMapSetting(integer i)
        {
            return mapsetting.get(i);
        }

        public static mapdensity ConvertMapDensity(integer i)
        {
            return mapdensity.get(i);
        }

        public static mapcontrol ConvertMapControl(integer i)
        {
            return mapcontrol.get(i);
        }

        public static playercolor ConvertPlayerColor(integer i)
        {
            return playercolor.get(i);
        }

        public static playerslotstate ConvertPlayerSlotState(integer i)
        {
            return playerslotstate.get(i);
        }

        public static volumegroup ConvertVolumeGroup(integer i)
        {
            return volumegroup.get(i);
        }

        public static camerafield ConvertCameraField(integer i)
        {
            return camerafield.get(i);
        }

        public static blendmode ConvertBlendMode(integer i)
        {
            return blendmode.get(i);
        }

        public static raritycontrol ConvertRarityControl(integer i)
        {
            return raritycontrol.get(i);
        }

        public static texmapflags ConvertTexMapFlags(integer i)
        {
            return texmapflags.get(i);
        }

        public static fogstate ConvertFogState(integer i)
        {
            return fogstate.get(i);
        }

        public static effecttype ConvertEffectType(integer i)
        {
            return effecttype.get(i);
        }

        public static version ConvertVersion(integer i)
        {
            return version.get(i);
        }

        public static itemtype ConvertItemType(integer i)
        {
            return itemtype.get(i);
        }

        public static attacktype ConvertAttackType(integer i)
        {
            return attacktype.get(i);
        }

        public static damagetype ConvertDamageType(integer i)
        {
            return damagetype.get(i);
        }

        public static weapontype ConvertWeaponType(integer i)
        {
            return weapontype.get(i);
        }

        public static soundtype ConvertSoundType(integer i)
        {
            return soundtype.get(i);
        }

        public static pathingtype ConvertPathingType(integer i)
        {
            return pathingtype.get(i);
        }
        #endregion

    }
}
