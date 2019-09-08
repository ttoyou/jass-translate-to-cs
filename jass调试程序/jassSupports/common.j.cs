using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using RuntimeRecorder;

namespace Map
{
    using integer = System.Int32;
    using real = System.Single;
    using boolean = System.Boolean;
    using @string = System.String;
    using code = System.Delegate;

    partial class MapScript
    {
        public static integer OrderId(@string orderIdString)
        {
            byte[] ss = new byte[4];
            Encoding.UTF8.GetBytes(orderIdString).CopyTo(ss, 0);
            return BitConverter.ToInt32(ss, 0);
        }

        public static @string OrderId2String(integer orderId)
        {
            byte[] ss = BitConverter.GetBytes(orderId);
            return Encoding.ASCII.GetString(ss);
        }

        public static integer UnitId(@string unitIdString)
        {
            byte[] ss = new byte[4];
            Encoding.UTF8.GetBytes(unitIdString).CopyTo(ss, 0);
            return BitConverter.ToInt32(ss, 0);
        }

        public static @string UnitId2String(integer unitId)
        {
            byte[] ss = BitConverter.GetBytes(unitId);
            return Encoding.ASCII.GetString(ss);
        }

        public static integer AbilityId(@string abilityIdString)
        {
            byte[] ss = new byte[4];
            Encoding.UTF8.GetBytes(abilityIdString).CopyTo(ss, 0);
            return BitConverter.ToInt32(ss, 0);
        }

        public static @string AbilityId2String(integer abilityId)
        {
            byte[] ss = BitConverter.GetBytes(abilityId);
            return Encoding.ASCII.GetString(ss);
        }

        public static @string GetObjectName(integer objectId)
        {
            byte[] ss = BitConverter.GetBytes(objectId);
            return Encoding.ASCII.GetString(ss);
        }


        public static integer GetHandleId(handle h)
        {
            return h.id;
        }

        public static @string SubString(@string source, integer start, integer end)
        {
            return source.Substring(start, end - start);
        }

        public static integer StringLength(@string s)
        {
            if (s == null) return 0;
            return Encoding.UTF8.GetBytes(s).Length;
        }

        public static @string StringCase(@string source, boolean upper)
        {
            if (upper)
                return source.ToUpper();
            else
                return source.ToLower();
        }

        public static integer StringHash(@string s)
        {
            if (s == null) s = @string.Empty;
            s.Replace('/', '\\');
            s = s.ToUpperInvariant();
            byte[] s_ = Encoding.UTF8.GetBytes(s);
            int n = 0;
            int len = s_.Length;
            int sizt_t = len;
            uint A = (uint)2654435769;
            uint B = (uint)2654435769;
            uint C = 0;

            while (len >= 12)
            {
                A += (uint)((s_[n + 3] << 24) | (s_[n + 2] << 16) | (s_[n + 1] << 8) | s_[n]);
                B += (uint)((s_[n + 7] << 24) | (s_[n + 6] << 16) | (s_[n + 5] << 8) | s_[n + 4]);
                C += (uint)((s_[n + 11] << 24) | (s_[n + 10] << 16) | (s_[n + 9] << 8) | s_[n + 8]);

                A = (C >> 13) ^ (A - B - C);
                B = (A << 8) ^ (B - C - A);
                C = (B >> 13) ^ (C - A - B);
                A = (C >> 12) ^ (A - B - C);
                B = (A << 16) ^ (B - C - A);
                C = (B >> 5) ^ (C - A - B);
                A = (C >> 3) ^ (A - B - C);
                B = (A << 10) ^ (B - C - A);
                C = (B >> 15) ^ (C - A - B);

                n += 12;
                len -= 12;
            }
            C += (uint)sizt_t;
            if (len == 11) { C += (uint)(s_[n + 10] * 0x1000000u); len -= 1; }
            if (len == 10) { C += (uint)(s_[n + 9] * 0x10000u); len -= 1; }
            if (len == 9) { C += (uint)(s_[n + 8] * 0x100u); len -= 1; }
            if (len == 8) { B += (uint)(s_[n + 7] * 0x1000000u); len -= 1; }
            if (len == 7) { B += (uint)(s_[n + 6] * 0x10000u); len -= 1; }
            if (len == 6) { B += (uint)(s_[n + 5] * 0x100u); len -= 1; }
            if (len == 5) { B += (uint)(s_[n + 4]); len -= 1; }
            if (len == 4) { A += (uint)(s_[n + 3] * 0x1000000u); len -= 1; }
            if (len == 3) { A += (uint)(s_[n + 2] * 0x10000u); len -= 1; }
            if (len == 2) { A += (uint)(s_[n + 1] * 0x100u); len -= 1; }
            if (len == 1) { A += (uint)(s_[n]); len -= 1; }


            A = (C >> 13) ^ (A - B - C);
            B = (A << 8) ^ (B - C - A);
            C = (B >> 13) ^ (C - A - B);
            A = (C >> 12) ^ (A - B - C);
            B = (A << 16) ^ (B - C - A);
            C = (B >> 5) ^ (C - A - B);
            A = (C >> 3) ^ (A - B - C);
            B = (A << 10) ^ (B - C - A);
            C = (B >> 15) ^ (C - A - B);

            return (int)C;
        }

        public static @string GetLocalizedString(@string source)
        {
            return source;
        }

        public static integer GetLocalizedHotkey(@string source)
        {
            return 1;
        }

        public static void SetMapName(@string name)
        {
            MapSetting.MapName = name;
        }

        public static void SetMapDescription(@string description)
        {
            MapSetting.MapDescription = description;
        }

        public static void SetTeams(integer teamcount)
        {
            MapSetting.Teams = teamcount;
        }

        public static void SetPlayers(integer playercount)
        {
            MapSetting.PlayerCount = playercount;
        }

        public static void DefineStartLocation(integer whichStartLoc, real x, real y)
        {
        }

        public static void DefineStartLocationLoc(integer whichStartLoc, location whichLocation)
        {
        }

        public static void SetStartLocPrioCount(integer whichStartLoc, integer prioSlotCount)
        {
        }

        public static void SetStartLocPrio(integer whichStartLoc, integer prioSlotIndex, integer otherStartLocIndex, startlocprio priority)
        {
        }

        public static integer GetStartLocPrioSlot(integer whichStartLoc, integer prioSlotIndex)
        {
            throw new NotImplementedException();
        }

        public static startlocprio GetStartLocPrio(integer whichStartLoc, integer prioSlotIndex)
        {
            throw new NotImplementedException();
        }

        public static void SetGameTypeSupported(gametype whichGameType, boolean value)
        {
        }

        public static void SetMapFlag(mapflag whichMapFlag, boolean value)
        {
        }

        public static void SetGamePlacement(placement whichPlacementType)
        {
        }

        public static void SetGameSpeed(gamespeed whichspeed)
        {
            Recorder.GameSpeed = whichspeed;
        }

        public static void SetGameDifficulty(gamedifficulty whichdifficulty)
        {
            Recorder.GameDifficulty = whichdifficulty;
        }

        public static void SetResourceDensity(mapdensity whichdensity)
        {
        }

        public static void SetCreatureDensity(mapdensity whichdensity)
        {
        }

        public static integer GetTeams()
        {
            return MapSetting.Teams;
        }

        public static integer GetPlayers()
        {
            return MapSetting.PlayerCount;
        }

        public static boolean IsGameTypeSupported(gametype whichGameType)
        {
            throw new NotImplementedException();
        }

        public static gametype GetGameTypeSelected()
        {
            throw new NotImplementedException();
        }

        public static boolean IsMapFlagSet(mapflag whichMapFlag)
        {
            throw new NotImplementedException();
        }

        public static placement GetGamePlacement()
        {
            throw new NotImplementedException();
        }

        public static gamespeed GetGameSpeed()
        {
            return Recorder.GameSpeed;
        }

        public static gamedifficulty GetGameDifficulty()
        {
            return Recorder.GameDifficulty;
        }

        public static mapdensity GetResourceDensity()
        {
            throw new NotImplementedException();
        }

        public static mapdensity GetCreatureDensity()
        {
            throw new NotImplementedException();
        }

        public static real GetStartLocationX(integer whichStartLocation)
        {
            throw new NotImplementedException();
        }

        public static real GetStartLocationY(integer whichStartLocation)
        {
            throw new NotImplementedException();
        }

        public static location GetStartLocationLoc(integer whichStartLocation)
        {
            throw new NotImplementedException();
        }

        public static void SetPlayerTeam(player whichPlayer, integer whichTeam)
        {
        }

        public static void SetPlayerStartLocation(player whichPlayer, integer startLocIndex)
        {
        }

        public static void ForcePlayerStartLocation(player whichPlayer, integer startLocIndex)
        {
        }

        public static void SetPlayerColor(player whichPlayer, playercolor color)
        {
            whichPlayer.color = color;
        }

        public static void SetPlayerAlliance(player sourcePlayer, player otherPlayer, alliancetype whichAllianceSetting, boolean value)
        {
        }

        public static void SetPlayerTaxRate(player sourcePlayer, player otherPlayer, playerstate whichResource, integer rate)
        {
        }

        public static void SetPlayerRacePreference(player whichPlayer, racepreference whichRacePreference)
        {
        }

        public static void SetPlayerRaceSelectable(player whichPlayer, boolean value)
        {
        }

        public static void SetPlayerController(player whichPlayer, mapcontrol controlType)
        {
        }

        public static void SetPlayerName(player whichPlayer, @string name)
        {
            whichPlayer.Name = name;
        }

        public static void SetPlayerOnScoreScreen(player whichPlayer, boolean flag)
        {
        }

        public static integer GetPlayerTeam(player whichPlayer)
        {
            throw new NotImplementedException();
        }

        public static integer GetPlayerStartLocation(player whichPlayer)
        {
            throw new NotImplementedException();
        }

        public static playercolor GetPlayerColor(player whichPlayer)
        {
            return whichPlayer.color;
        }

        public static boolean GetPlayerSelectable(player whichPlayer)
        {
            throw new NotImplementedException();
        }

        public static mapcontrol GetPlayerController(player whichPlayer)
        {
            throw new NotImplementedException();
        }

        public static playerslotstate GetPlayerSlotState(player whichPlayer)
        {
            throw new NotImplementedException();
        }

        public static integer GetPlayerTaxRate(player sourcePlayer, player otherPlayer, playerstate whichResource)
        {
            throw new NotImplementedException();
        }

        public static boolean IsPlayerRacePrefSet(player whichPlayer, racepreference pref)
        {
            throw new NotImplementedException();
        }

        public static @string GetPlayerName(player whichPlayer)
        {
            return whichPlayer.Name;
        }

        public static timer CreateTimer()
        {
            return new timer();
        }

        public static void DestroyTimer(timer whichTimer)
        {
            whichTimer.destroyed = true;
        }

        public static void TimerStart(timer whichTimer, real timeout, boolean periodic, code handlerFunc)
        {
            whichTimer.running = true;
        }
        public static void TimerStart(timer whichTimer, real timeout, boolean periodic, Action handlerFunc)
        {
            whichTimer.running = true;
        }

        public static real TimerGetElapsed(timer whichTimer)
        {
            throw new NotImplementedException();
        }

        public static real TimerGetRemaining(timer whichTimer)
        {
            throw new NotImplementedException();
        }

        public static real TimerGetTimeout(timer whichTimer)
        {
            throw new NotImplementedException();
        }

        public static void PauseTimer(timer whichTimer)
        {
            whichTimer.paused = true;
        }

        public static void ResumeTimer(timer whichTimer)
        {
            whichTimer.paused = false;
        }

        public static timer GetExpiredTimer()
        {
            throw new NotImplementedException();
        }

        public static group CreateGroup()
        {
            return new group();
        }

        public static void DestroyGroup(group whichGroup)
        {
            whichGroup.destroyed = true;
        }

        public static void GroupAddUnit(group whichGroup, unit whichUnit)
        {
            whichGroup.Add(whichUnit);
        }

        public static void GroupRemoveUnit(group whichGroup, unit whichUnit)
        {
            whichGroup.Remove(whichUnit);
        }

        public static void GroupClear(group whichGroup)
        {
            whichGroup.Clear();
        }

        public static void GroupEnumUnitsOfType(group whichGroup, @string unitname, boolexpr filter)
        {
        }

        public static void GroupEnumUnitsOfPlayer(group whichGroup, player whichPlayer, boolexpr filter)
        {
        }

        public static void GroupEnumUnitsOfTypeCounted(group whichGroup, @string unitname, boolexpr filter, integer countLimit)
        {
        }

        public static void GroupEnumUnitsInRect(group whichGroup, rect r, boolexpr filter)
        {
        }

        public static void GroupEnumUnitsInRectCounted(group whichGroup, rect r, boolexpr filter, integer countLimit)
        {
        }

        public static void GroupEnumUnitsInRange(group whichGroup, real x, real y, real radius, boolexpr filter)
        {
        }

        public static void GroupEnumUnitsInRangeOfLoc(group whichGroup, location whichLocation, real radius, boolexpr filter)
        {
        }

        public static void GroupEnumUnitsInRangeCounted(group whichGroup, real x, real y, real radius, boolexpr filter, integer countLimit)
        {
        }

        public static void GroupEnumUnitsInRangeOfLocCounted(group whichGroup, location whichLocation, real radius, boolexpr filter, integer countLimit)
        {
        }

        public static void GroupEnumUnitsSelected(group whichGroup, player whichPlayer, boolexpr filter)
        {
        }

        public static boolean GroupImmediateOrder(group whichGroup, @string order)
        {
            throw new NotImplementedException();
        }

        public static boolean GroupImmediateOrderById(group whichGroup, integer order)
        {
            throw new NotImplementedException();
        }

        public static boolean GroupPointOrder(group whichGroup, @string order, real x, real y)
        {
            throw new NotImplementedException();
        }

        public static boolean GroupPointOrderLoc(group whichGroup, @string order, location whichLocation)
        {
            throw new NotImplementedException();
        }

        public static boolean GroupPointOrderById(group whichGroup, integer order, real x, real y)
        {
            throw new NotImplementedException();
        }

        public static boolean GroupPointOrderByIdLoc(group whichGroup, integer order, location whichLocation)
        {
            throw new NotImplementedException();
        }

        public static boolean GroupTargetOrder(group whichGroup, @string order, widget targetWidget)
        {
            throw new NotImplementedException();
        }

        public static boolean GroupTargetOrderById(group whichGroup, integer order, widget targetWidget)
        {
            throw new NotImplementedException();
        }

        public static void ForGroup(group whichGroup, code callback)
        {
            foreach (unit u in whichGroup)
            {
                Extra.Iteration.EnumUnit = u;
                callback.DynamicInvoke();
            }
            Extra.Iteration.EnumUnit = null;
        }
        public static void ForGroup(group whichGroup, Action callback) => ForGroup(whichGroup, (code)callback);

        public static unit FirstOfGroup(group whichGroup)
        {
            if (whichGroup.Count > 0)
                return whichGroup.First();
            else return null;
        }

        public static force CreateForce()
        {
            return new force();
        }

        public static void DestroyForce(force whichForce)
        {
            whichForce.destroyed = true;
        }

        public static void ForceAddPlayer(force whichForce, player whichPlayer)
        {
            whichForce.players.Add(whichPlayer);
        }

        public static void ForceRemovePlayer(force whichForce, player whichPlayer)
        {
            whichForce.players.Remove(whichPlayer);
        }

        public static void ForceClear(force whichForce)
        {
            whichForce.players.Clear();
        }

        public static void ForceEnumPlayers(force whichForce, boolexpr filter)
        {
            foreach (player p in whichForce)
            {
                Extra.Iteration.EnumPlayer = p;
            }
            throw new NotImplementedException();
        }

        public static void ForceEnumPlayersCounted(force whichForce, boolexpr filter, integer countLimit)
        {
        }

        public static void ForceEnumAllies(force whichForce, player whichPlayer, boolexpr filter)
        {
        }

        public static void ForceEnumEnemies(force whichForce, player whichPlayer, boolexpr filter)
        {
        }

        public static void ForForce(force whichForce, code callback)
        {
            foreach (player p in whichForce)
            {
                Extra.Iteration.EnumPlayer = p;
                callback.DynamicInvoke();
            }
            Extra.Iteration.EnumPlayer = null;
        }

        public static void ForForce(force whichForce, Action callback) => ForForce(whichForce, (code)callback);

        public static rect Rect(real minx, real miny, real maxx, real maxy)
        {
            return new rect() { maxx = maxx, maxy = maxy, minx = minx, miny = miny };
        }

        public static rect RectFromLoc(location min, location max)
        {
            return new rect() { maxx = max.x, maxy = max.y, minx = min.x, miny = min.y };
        }

        public static void RemoveRect(rect whichRect)
        {
            whichRect.destroyed = true;
        }

        public static void SetRect(rect whichRect, real minx, real miny, real maxx, real maxy)
        {
            whichRect.minx = minx;
            whichRect.miny = miny;
            whichRect.maxx = maxx;
            whichRect.maxy = maxy;
        }

        public static void SetRectFromLoc(rect whichRect, location min, location max)
        {
            whichRect.minx = min.x;
            whichRect.miny = min.y;
            whichRect.maxx = max.x;
            whichRect.maxy = max.y;
        }

        public static void MoveRectTo(rect whichRect, real newCenterX, real newCenterY)
        {
        }

        public static void MoveRectToLoc(rect whichRect, location newCenterLoc)
        {
        }

        public static real GetRectCenterX(rect whichRect)
        {
            return (whichRect.maxx + whichRect.minx) / 2;
        }

        public static real GetRectCenterY(rect whichRect)
        {
            return (whichRect.maxy + whichRect.miny) / 2;
        }

        public static real GetRectMinX(rect whichRect)
        {
            return whichRect.minx;
        }

        public static real GetRectMinY(rect whichRect)
        {
            return whichRect.miny;
        }

        public static real GetRectMaxX(rect whichRect)
        {
            return whichRect.maxx;
        }

        public static real GetRectMaxY(rect whichRect)
        {
            return whichRect.maxy;
        }

        public static region CreateRegion()
        {
            return new region();
        }

        public static void RemoveRegion(region whichRegion)
        {
            whichRegion.destroyed = true;
        }

        public static void RegionAddRect(region whichRegion, rect r)
        {
        }

        public static void RegionClearRect(region whichRegion, rect r)
        {
        }

        public static void RegionAddCell(region whichRegion, real x, real y)
        {
        }

        public static void RegionAddCellAtLoc(region whichRegion, location whichLocation)
        {
        }

        public static void RegionClearCell(region whichRegion, real x, real y)
        {
        }

        public static void RegionClearCellAtLoc(region whichRegion, location whichLocation)
        {
        }

        public static location Location(real x, real y)
        {
            return new location() { x = x, y = y };
        }

        public static void RemoveLocation(location whichLocation)
        {
            whichLocation.destroyed = true;
        }

        public static void MoveLocation(location whichLocation, real newX, real newY)
        {
            whichLocation.x = newX;
            whichLocation.y = newY;
        }

        public static real GetLocationX(location whichLocation)
        {
            return whichLocation.x;
        }

        public static real GetLocationY(location whichLocation)
        {
            return whichLocation.y;
        }

        public static real GetLocationZ(location whichLocation)
        {
            return whichLocation.z;
        }

        public static boolean IsUnitInRegion(region whichRegion, unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static boolean IsPointInRegion(region whichRegion, real x, real y)
        {
            throw new NotImplementedException();
        }

        public static boolean IsLocationInRegion(region whichRegion, location whichLocation)
        {
            throw new NotImplementedException();
        }

        public static rect GetWorldBounds()
        {
            throw new NotImplementedException();
        }

        public static unit GetFilterUnit()
        {
            return Extra.Iteration.FilterUnit;
        }

        public static unit GetEnumUnit()
        {
            return Extra.Iteration.EnumUnit;
        }

        public static destructable GetFilterDestructable()
        {
            return Extra.Iteration.FilterDestructable;
        }

        public static destructable GetEnumDestructable()
        {
            return Extra.Iteration.EnumDestructable;
        }

        public static item GetFilterItem()
        {
            return Extra.Iteration.FilterItem;
        }

        public static item GetEnumItem()
        {
            return Extra.Iteration.EnumItem;
        }

        public static player GetFilterPlayer()
        {
            return Extra.Iteration.FilterPlayer;
        }

        public static player GetEnumPlayer()
        {
            return Extra.Iteration.EnumPlayer;
        }

        public void ExecuteFunc(@string funcName)
        {
            var a = RuntimeReflectionExtensions.GetRuntimeMethod(typeof(MapScript), funcName, new Type[0]);
            a.Invoke(this, null);
        }

        public static boolexpr And(boolexpr operandA, boolexpr operandB)
        {
            throw new NotImplementedException();
        }

        public static boolexpr Or(boolexpr operandA, boolexpr operandB)
        {
            throw new NotImplementedException();
        }

        public static boolexpr Not(boolexpr operand)
        {
            throw new NotImplementedException();
        }

        public static conditionfunc Condition(code func)
        {
            return new conditionfunc() { func = (Func<boolean>)func };
        }
        public static conditionfunc Condition(Func<boolean> func)
        {
            return new conditionfunc() { func = (Func<boolean>)func };
        }

        public static void DestroyCondition(conditionfunc c)
        {
            c.destroyed = true;
        }

        public static filterfunc Filter(code func)
        {
            filterfunc filter = new filterfunc() { func = (Func<boolean>)func };
            RuntimeRecorder.Recorder.Filters.Add(filter);
            return filter;
        }
        public static filterfunc Filter(Func<boolean> func)
        {
            filterfunc filter = new filterfunc() { func = func };
            RuntimeRecorder.Recorder.Filters.Add(filter);
            return filter;
        }

        public static void DestroyFilter(filterfunc f)
        {
            RuntimeRecorder.Recorder.Filters.Remove(f);
            f.destroyed = true;
        }

        public static void DestroyBoolExpr(boolexpr e)
        {
            e.destroyed = true;
        }



        public static real GetTournamentFinishSoonTimeRemaining()
        {
            throw new NotImplementedException();
        }

        public static integer GetTournamentFinishNowRule()
        {
            throw new NotImplementedException();
        }

        public static player GetTournamentFinishNowPlayer()
        {
            throw new NotImplementedException();
        }

        public static integer GetTournamentScore(player whichPlayer)
        {
            throw new NotImplementedException();
        }

        public static @string GetSaveBasicFilename()
        {
            throw new NotImplementedException();
        }


        public static real GetWidgetLife(widget whichWidget)
        {
            return whichWidget.life;
        }

        public static void SetWidgetLife(widget whichWidget, real newLife)
        {
            whichWidget.life = newLife;
        }

        public static real GetWidgetX(widget whichWidget)
        {
            return whichWidget.x;
        }

        public static real GetWidgetY(widget whichWidget)
        {
            return whichWidget.y;
        }


        public static destructable CreateDestructable(integer objectid, real x, real y, real face, real scale, integer variation)
        {
            return new destructable() { objectId = objectid, x = x, y = y, facing = face, scale = scale, variation = variation };
        }

        public static destructable CreateDestructableZ(integer objectid, real x, real y, real z, real face, real scale, integer variation)
        {
            return new destructable() { objectId = objectid, x = x, y = y, z = z, facing = face, scale = scale, variation = variation };
        }

        public static destructable CreateDeadDestructable(integer objectid, real x, real y, real face, real scale, integer variation)
        {
            return new destructable() { objectId = objectid, x = x, y = y, life = 0, facing = face, scale = scale, variation = variation };
        }

        public static destructable CreateDeadDestructableZ(integer objectid, real x, real y, real z, real face, real scale, integer variation)
        {
            return new destructable() { objectId = objectid, x = x, y = y, z = z, life = 0, facing = face, scale = scale, variation = variation };
        }

        public static void RemoveDestructable(destructable d)
        {
            d.destroyed = true;
        }

        public static void KillDestructable(destructable d)
        {
            d.life = 0;
        }

        public static void SetDestructableInvulnerable(destructable d, boolean flag)
        {
            d.isInvulnerable = flag;
        }

        public static boolean IsDestructableInvulnerable(destructable d)
        {
            return d.isInvulnerable;
        }

        public static void EnumDestructablesInRect(rect r, boolexpr filter, code actionFunc)
        {
        }
        public static void EnumDestructablesInRect(rect r, boolexpr filter, Action actionFunc)
        {
        }

        public static integer GetDestructableTypeId(destructable d)
        {
            return d.id;
        }

        public static real GetDestructableX(destructable d)
        {
            return d.x;
        }

        public static real GetDestructableY(destructable d)
        {
            return d.y;
        }

        public static void SetDestructableLife(destructable d, real life)
        {
            d.life = life;
        }

        public static real GetDestructableLife(destructable d)
        {
            return d.life;
        }

        public static void SetDestructableMaxLife(destructable d, real max)
        {
            d.maxlife = max;
        }

        public static real GetDestructableMaxLife(destructable d)
        {
            return d.maxlife;
        }

        public static void DestructableRestoreLife(destructable d, real life, boolean birth)
        {
            d.life = life;
        }

        public static void QueueDestructableAnimation(destructable d, @string whichAnimation)
        {
        }

        public static void SetDestructableAnimation(destructable d, @string whichAnimation)
        {
        }

        public static void SetDestructableAnimationSpeed(destructable d, real speedFactor)
        {
        }

        public static void ShowDestructable(destructable d, boolean flag)
        {
            d.visible = flag;
        }

        public static real GetDestructableOccluderHeight(destructable d)
        {
            return d.occluderHeight;
        }

        public static void SetDestructableOccluderHeight(destructable d, real height)
        {
            d.occluderHeight = height;
        }

        public static @string GetDestructableName(destructable d)
        {
            throw new NotImplementedException();
        }

        public static item CreateItem(integer itemid, real x, real y)
        {
            item i = new item() { x = x, y = y };
            Recorder.GameItems.Add(i);
            return i;
        }

        public static void RemoveItem(item whichItem)
        {
            Recorder.GameItems.Remove(whichItem);
            whichItem.destroyed = true;
        }

        public static player GetItemPlayer(item whichItem)
        {
            return whichItem.owner;
        }

        public static integer GetItemTypeId(item i)
        {
            throw new NotImplementedException();
        }

        public static real GetItemX(item i)
        {
            return i.x;
        }

        public static real GetItemY(item i)
        {
            return i.y;
        }

        public static void SetItemPosition(item i, real x, real y)
        {
            i.x = x;
            i.y = y;
        }

        public static void SetItemDropOnDeath(item whichItem, boolean flag)
        {
            whichItem.dropOndeath = flag;
        }

        public static void SetItemDroppable(item i, boolean flag)
        {
            i.dropable = flag;
        }

        public static void SetItemPawnable(item i, boolean flag)
        {
            i.pawnable = flag;
        }

        public static void SetItemPlayer(item whichItem, player whichPlayer, boolean changeColor)
        {
            whichItem.owner = whichPlayer;
        }

        public static void SetItemInvulnerable(item whichItem, boolean flag)
        {
            whichItem.isInvulnerable = flag;
        }

        public static boolean IsItemInvulnerable(item whichItem)
        {
            return whichItem.isInvulnerable;
        }

        public static void SetItemVisible(item whichItem, boolean show)
        {
            whichItem.visiable = show;
        }

        public static boolean IsItemVisible(item whichItem)
        {
            return whichItem.visiable;
        }

        public static boolean IsItemOwned(item whichItem)
        {
            throw new NotImplementedException();
        }

        public static boolean IsItemPowerup(item whichItem)
        {
            throw new NotImplementedException();
        }

        public static boolean IsItemSellable(item whichItem)
        {
            throw new NotImplementedException();
        }

        public static boolean IsItemPawnable(item whichItem)
        {
            return whichItem.pawnable;
        }

        public static boolean IsItemIdPowerup(integer itemId)
        {
            throw new NotImplementedException();
        }

        public static boolean IsItemIdSellable(integer itemId)
        {
            throw new NotImplementedException();
        }

        public static boolean IsItemIdPawnable(integer itemId)
        {
            throw new NotImplementedException();
        }

        public static void EnumItemsInRect(rect r, boolexpr filter, code actionFunc)
        {
        }
        public static void EnumItemsInRect(rect r, boolexpr filter, Action actionFunc)
        {
        }

        public static integer GetItemLevel(item whichItem)
        {
            return whichItem.itemlevel;
        }

        public static itemtype GetItemType(item whichItem)
        {
            return whichItem.itemtype;
        }

        public static void SetItemDropID(item whichItem, integer unitId)
        {
        }

        public static @string GetItemName(item whichItem)
        {
            throw new NotImplementedException();
        }

        public static integer GetItemCharges(item whichItem)
        {
            return whichItem.charge;
        }

        public static void SetItemCharges(item whichItem, integer charges)
        {
            whichItem.charge = charges;
        }

        public static integer GetItemUserData(item whichItem)
        {
            return whichItem.userData;
        }

        public static void SetItemUserData(item whichItem, integer data)
        {
            whichItem.userData = data;
        }

       

        public static void ClearSelection()
        {
        }

        
        

        public static player Player(integer number)
        {
            return player.get(number);
        }

        public static player GetLocalPlayer()
        {
            throw new NotImplementedException();
        }

        public static boolean IsPlayerAlly(player whichPlayer, player otherPlayer)
        {
            throw new NotImplementedException();
        }

        public static boolean IsPlayerEnemy(player whichPlayer, player otherPlayer)
        {
            throw new NotImplementedException();
        }

        public static boolean IsPlayerInForce(player whichPlayer, force whichForce)
        {
            if (whichForce.players.Contains(whichPlayer)) return true;
            else return false;
        }

        public static boolean IsPlayerObserver(player whichPlayer)
        {
            throw new NotImplementedException();
        }

        public static boolean IsVisibleToPlayer(real x, real y, player whichPlayer)
        {
            throw new NotImplementedException();
        }

        public static boolean IsLocationVisibleToPlayer(location whichLocation, player whichPlayer)
        {
            throw new NotImplementedException();
        }

        public static boolean IsFoggedToPlayer(real x, real y, player whichPlayer)
        {
            throw new NotImplementedException();
        }

        public static boolean IsLocationFoggedToPlayer(location whichLocation, player whichPlayer)
        {
            throw new NotImplementedException();
        }

        public static boolean IsMaskedToPlayer(real x, real y, player whichPlayer)
        {
            throw new NotImplementedException();
        }

        public static boolean IsLocationMaskedToPlayer(location whichLocation, player whichPlayer)
        {
            throw new NotImplementedException();
        }

        public static race GetPlayerRace(player whichPlayer)
        {
            return whichPlayer.race;
        }

        public static integer GetPlayerId(player whichPlayer)
        {
            return whichPlayer.id;
        }

        public static integer GetPlayerUnitCount(player whichPlayer, boolean includeIncomplete)
        {
            throw new NotImplementedException();
        }

        public static integer GetPlayerTypedUnitCount(player whichPlayer, @string unitName, boolean includeIncomplete, boolean includeUpgrades)
        {
            throw new NotImplementedException();
        }

        public static integer GetPlayerStructureCount(player whichPlayer, boolean includeIncomplete)
        {
            throw new NotImplementedException();
        }

        public static integer GetPlayerState(player whichPlayer, playerstate whichPlayerState)
        {
            throw new NotImplementedException();
        }

        public static integer GetPlayerScore(player whichPlayer, playerscore whichPlayerScore)
        {
            throw new NotImplementedException();
        }

        public static boolean GetPlayerAlliance(player sourcePlayer, player otherPlayer, alliancetype whichAllianceSetting)
        {
            throw new NotImplementedException();
        }

        public static real GetPlayerHandicap(player whichPlayer)
        {
            return RuntimeRecorder.Recorder.PlayerHandicap[whichPlayer];
        }

        public static real GetPlayerHandicapXP(player whichPlayer)
        {
            throw new NotImplementedException();
        }

        public static void SetPlayerHandicap(player whichPlayer, real handicap)
        {
        }

        public static void SetPlayerHandicapXP(player whichPlayer, real handicap)
        {
        }

        public static void SetPlayerTechMaxAllowed(player whichPlayer, integer techid, integer maximum)
        {
        }

        public static integer GetPlayerTechMaxAllowed(player whichPlayer, integer techid)
        {
            throw new NotImplementedException();
        }

        public static void AddPlayerTechResearched(player whichPlayer, integer techid, integer levels)
        {
        }

        public static void SetPlayerTechResearched(player whichPlayer, integer techid, integer setToLevel)
        {
        }

        public static boolean GetPlayerTechResearched(player whichPlayer, integer techid, boolean specificonly)
        {
            throw new NotImplementedException();
        }

        public static integer GetPlayerTechCount(player whichPlayer, integer techid, boolean specificonly)
        {
            throw new NotImplementedException();
        }

        public static void SetPlayerUnitsOwner(player whichPlayer, integer newOwner)
        {
        }

        public static void CripplePlayer(player whichPlayer, force toWhichPlayers, boolean flag)
        {
        }

        public static void SetPlayerAbilityAvailable(player whichPlayer, integer abilid, boolean avail)
        {
        }

        public static void SetPlayerState(player whichPlayer, playerstate whichPlayerState, integer value)
        {
        }

        public static void RemovePlayer(player whichPlayer, playergameresult gameResult)
        {
            whichPlayer.isRemoved = true;
        }

        public static void CachePlayerHeroData(player whichPlayer)
        {
        }

        public static void SetFogStateRect(player forWhichPlayer, fogstate whichState, rect where, boolean useSharedVision)
        {
        }

        public static void SetFogStateRadius(player forWhichPlayer, fogstate whichState, real centerx, real centerY, real radius, boolean useSharedVision)
        {
        }

        public static void SetFogStateRadiusLoc(player forWhichPlayer, fogstate whichState, location center, real radius, boolean useSharedVision)
        {
        }

        public static void FogMaskEnable(boolean enable)
        {
            throw new NotImplementedException();
        }

        public static boolean IsFogMaskEnabled()
        {
            throw new NotImplementedException();
        }

        public static void FogEnable(boolean enable)
        {
            throw new NotImplementedException();
        }

        public static boolean IsFogEnabled()
        {
            //return true;
            throw new NotImplementedException();
        }

        public static fogmodifier CreateFogModifierRect(player forWhichPlayer, fogstate whichState, rect where, boolean useSharedVision, boolean afterUnits)
        {
            throw new NotImplementedException();
        }

        public static fogmodifier CreateFogModifierRadius(player forWhichPlayer, fogstate whichState, real centerx, real centerY, real radius, boolean useSharedVision, boolean afterUnits)
        {
            throw new NotImplementedException();
        }

        public static fogmodifier CreateFogModifierRadiusLoc(player forWhichPlayer, fogstate whichState, location center, real radius, boolean useSharedVision, boolean afterUnits)
        {
            throw new NotImplementedException();
        }

        public static void DestroyFogModifier(fogmodifier whichFogModifier)
        {
        }

        public static void FogModifierStart(fogmodifier whichFogModifier)
        {
        }

        public static void FogModifierStop(fogmodifier whichFogModifier)
        {
        }

        public static version VersionGet()
        {
            throw new NotImplementedException();
        }

        public static boolean VersionCompatible(version whichVersion)
        {
            throw new NotImplementedException();
        }

        public static boolean VersionSupported(version whichVersion)
        {
            throw new NotImplementedException();
        }

        public static void EndGame(boolean doScoreScreen)
        {
            throw new NotImplementedException();
        }

        public static void ChangeLevel(@string newLevel, boolean doScoreScreen)
        {
        }

        public static void RestartGame(boolean doScoreScreen)
        {
            throw new NotImplementedException();
        }

        public static void ReloadGame()
        {
            throw new NotImplementedException();
        }

        public static void SetCampaignMenuRace(race r)
        {
        }

        public static void SetCampaignMenuRaceEx(integer campaignIndex)
        {
        }

        public static void ForceCampaignSelectScreen()
        {
        }

        public static void LoadGame(@string saveFileName, boolean doScoreScreen)
        {
            throw new NotImplementedException();
        }

        public static void SaveGame(@string saveFileName)
        {
        }

        public static boolean RenameSaveDirectory(@string sourceDirName, @string destDirName)
        {
            throw new NotImplementedException();
        }

        public static boolean RemoveSaveDirectory(@string sourceDirName)
        {
            throw new NotImplementedException();
        }

        public static boolean CopySaveGame(@string sourceSaveName, @string destSaveName)
        {
            throw new NotImplementedException();
        }

        public static boolean SaveGameExists(@string saveName)
        {
            //return false;
            throw new NotImplementedException();
        }

        public static void SyncSelections()
        {
        }

        public static void SetFloatGameState(fgamestate whichFloatGameState, real value)
        {
        }

        public static real GetFloatGameState(fgamestate whichFloatGameState)
        {
            throw new NotImplementedException();
        }

        public static void SetIntegerGameState(igamestate whichIntegerGameState, integer value)
        {
        }

        public static integer GetIntegerGameState(igamestate whichIntegerGameState)
        {
            throw new NotImplementedException();
        }

        public static void SetTutorialCleared(boolean cleared)
        {
        }

        public static void SetMissionAvailable(integer campaignNumber, integer missionNumber, boolean available)
        {
        }

        public static void SetCampaignAvailable(integer campaignNumber, boolean available)
        {
        }

        public static void SetOpCinematicAvailable(integer campaignNumber, boolean available)
        {
        }

        public static void SetEdCinematicAvailable(integer campaignNumber, boolean available)
        {
        }

        public static gamedifficulty GetDefaultDifficulty()
        {
            throw new NotImplementedException();
        }

        public static void SetDefaultDifficulty(gamedifficulty g)
        {
        }

        public static void SetCustomCampaignButtonVisible(integer whichButton, boolean visible)
        {
        }

        public static boolean GetCustomCampaignButtonVisible(integer whichButton)
        {
            throw new NotImplementedException();
        }

        public static void DoNotSaveReplay()
        {
            throw new NotImplementedException();
        }

        public static dialog DialogCreate()
        {
            return new dialog();
        }

        public static void DialogDestroy(dialog whichDialog)
        {
        }

        public static void DialogClear(dialog whichDialog)
        {
            whichDialog.items.Clear();
        }

        public static void DialogSetMessage(dialog whichDialog, @string messageText)
        {
        }

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

        public static boolean ReloadGameCachesFromDisk()
        {
            throw new NotImplementedException();
        }

        public static gamecache InitGameCache(@string campaignFile)
        {
            throw new NotImplementedException();
        }

        public static boolean SaveGameCache(gamecache whichCache)
        {
            throw new NotImplementedException();
        }

        public static void StoreInteger(gamecache cache, @string missionKey, @string key, integer value)
        {
        }

        public static void StoreReal(gamecache cache, @string missionKey, @string key, real value)
        {
        }

        public static void StoreBoolean(gamecache cache, @string missionKey, @string key, boolean value)
        {
        }

        public static boolean StoreUnit(gamecache cache, @string missionKey, @string key, unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static boolean StoreString(gamecache cache, @string missionKey, @string key, @string value)
        {
            throw new NotImplementedException();
        }

        public static void SyncStoredInteger(gamecache cache, @string missionKey, @string key)
        {
        }

        public static void SyncStoredReal(gamecache cache, @string missionKey, @string key)
        {
        }

        public static void SyncStoredBoolean(gamecache cache, @string missionKey, @string key)
        {
        }

        public static void SyncStoredUnit(gamecache cache, @string missionKey, @string key)
        {
        }

        public static void SyncStoredString(gamecache cache, @string missionKey, @string key)
        {
        }

        public static boolean HaveStoredInteger(gamecache cache, @string missionKey, @string key)
        {
            throw new NotImplementedException();
        }

        public static boolean HaveStoredReal(gamecache cache, @string missionKey, @string key)
        {
            throw new NotImplementedException();
        }

        public static boolean HaveStoredBoolean(gamecache cache, @string missionKey, @string key)
        {
            throw new NotImplementedException();
        }

        public static boolean HaveStoredUnit(gamecache cache, @string missionKey, @string key)
        {
            throw new NotImplementedException();
        }

        public static boolean HaveStoredString(gamecache cache, @string missionKey, @string key)
        {
            throw new NotImplementedException();
        }

        public static void FlushGameCache(gamecache cache)
        {
        }

        public static void FlushStoredMission(gamecache cache, @string missionKey)
        {
        }

        public static void FlushStoredInteger(gamecache cache, @string missionKey, @string key)
        {
        }

        public static void FlushStoredReal(gamecache cache, @string missionKey, @string key)
        {
        }

        public static void FlushStoredBoolean(gamecache cache, @string missionKey, @string key)
        {
        }

        public static void FlushStoredUnit(gamecache cache, @string missionKey, @string key)
        {
        }

        public static void FlushStoredString(gamecache cache, @string missionKey, @string key)
        {
        }

        public static integer GetStoredInteger(gamecache cache, @string missionKey, @string key)
        {
            throw new NotImplementedException();
        }

        public static real GetStoredReal(gamecache cache, @string missionKey, @string key)
        {
            throw new NotImplementedException();
        }

        public static boolean GetStoredBoolean(gamecache cache, @string missionKey, @string key)
        {
            throw new NotImplementedException();
        }

        public static @string GetStoredString(gamecache cache, @string missionKey, @string key)
        {
            throw new NotImplementedException();
        }

        public static unit RestoreUnit(gamecache cache, @string missionKey, @string key, player forWhichPlayer, real x, real y, real facing)
        {
            throw new NotImplementedException();
        }


        public static integer GetRandomInt(integer lowBound, integer highBound)
        {
            return randomProvider.Next(lowBound, highBound);
        }

        public static real GetRandomReal(real lowBound, real highBound)
        {
            byte[] cc = new byte[sizeof(real)];
            randomProvider.random.NextBytes(cc);
            return BitConverter.ToSingle(cc, 0);

        }

        public static unitpool CreateUnitPool()
        {
            return new unitpool();
        }

        public static void DestroyUnitPool(unitpool whichPool)
        {
        }

        public static void UnitPoolAddUnitType(unitpool whichPool, integer unitId, real weight)
        {
        }

        public static void UnitPoolRemoveUnitType(unitpool whichPool, integer unitId)
        {
        }

        public static unit PlaceRandomUnit(unitpool whichPool, player forWhichPlayer, real x, real y, real facing)
        {
            throw new NotImplementedException();
        }

        public static itempool CreateItemPool()
        {
            return new itempool();
        }

        public static void DestroyItemPool(itempool whichItemPool)
        {
            whichItemPool.destroyed = true;
        }

        public static void ItemPoolAddItemType(itempool whichItemPool, integer itemId, real weight)
        {
        }

        public static void ItemPoolRemoveItemType(itempool whichItemPool, integer itemId)
        {
        }

        public static item PlaceRandomItem(itempool whichItemPool, real x, real y)
        {
            throw new NotImplementedException();
        }

        public static integer ChooseRandomCreep(integer level)
        {
            throw new NotImplementedException();
        }

        public static integer ChooseRandomNPBuilding()
        {
            throw new NotImplementedException();
        }

        public static integer ChooseRandomItem(integer level)
        {
            throw new NotImplementedException();
        }

        public static integer ChooseRandomItemEx(itemtype whichType, integer level)
        {
            throw new NotImplementedException();
        }

        public static void SetRandomSeed(integer seed)
        {
            randomProvider.random = new Random(seed);
        }

        public static void SetTerrainFog(real a, real b, real c, real d, real e)
        {
        }

        public static void ResetTerrainFog()
        {
        }

        public static void SetUnitFog(real a, real b, real c, real d, real e)
        {
        }

        public static void SetTerrainFogEx(integer style, real zstart, real zend, real density, real red, real green, real blue)
        {
        }

        public static void DisplayTextToPlayer(player toPlayer, real x, real y, @string message)
        {
        }

        public static void DisplayTimedTextToPlayer(player toPlayer, real x, real y, real duration, @string message)
        {
        }

        public static void DisplayTimedTextFromPlayer(player toPlayer, real x, real y, real duration, @string message)
        {
        }

        public static void ClearTextMessages()
        {
        }

        public static void SetDayNightModels(@string terrainDNCFile, @string unitDNCFile)
        {
        }

        public static void SetSkyModel(@string skyModelFile)
        {
            Recorder.SkyModel = skyModelFile;
        }

        public static void EnableUserControl(boolean b)
        {
        }

        public static void EnableUserUI(boolean b)
        {
        }

        public static void SuspendTimeOfDay(boolean b)
        {
        }

        public static void SetTimeOfDayScale(real r)
        {
        }

        public static real GetTimeOfDayScale()
        {
            throw new NotImplementedException();
        }

        public static void ShowInterface(boolean flag, real fadeDuration)
        {
        }

        public static void PauseGame(boolean flag)
        {
            throw new NotImplementedException();
        }

        public static void UnitAddIndicator(unit whichUnit, integer red, integer green, integer blue, integer alpha)
        {
        }

        public static void AddIndicator(widget whichWidget, integer red, integer green, integer blue, integer alpha)
        {
        }

        public static void PingMinimap(real x, real y, real duration)
        {
        }

        public static void PingMinimapEx(real x, real y, real duration, integer red, integer green, integer blue, boolean extraEffects)
        {
        }

        public static void EnableOcclusion(boolean flag)
        {
        }

        public static void SetIntroShotText(@string introText)
        {
        }

        public static void SetIntroShotModel(@string introModelPath)
        {
        }

        public static void EnableWorldFogBoundary(boolean b)
        {
        }

        public static void PlayModelCinematic(@string modelName)
        {
        }

        public static void PlayCinematic(@string movieName)
        {
        }

        public static void ForceUIKey(@string key)
        {
        }

        public static void ForceUICancel()
        {
        }

        public static void DisplayLoadDialog()
        {
        }

        public static void SetAltMinimapIcon(@string iconPath)
        {
        }

        public static void DisableRestartMission(boolean flag)
        {
        }

        public static texttag CreateTextTag()
        {
            return new texttag();
        }

        public static void DestroyTextTag(texttag t)
        {
            t.destroyed = true;
        }

        public static void SetTextTagText(texttag t, @string s, real height)
        {
            t.text = s;
            t.height = height;
        }

        public static void SetTextTagPos(texttag t, real x, real y, real heightOffset)
        {
            t.x = x;
            t.y = y;
            t.height = heightOffset;
        }

        public static void SetTextTagPosUnit(texttag t, unit whichUnit, real heightOffset)
        {
        }

        public static void SetTextTagColor(texttag t, integer red, integer green, integer blue, integer alpha)
        {
        }

        public static void SetTextTagVelocity(texttag t, real xvel, real yvel)
        {
        }

        public static void SetTextTagVisibility(texttag t, boolean flag)
        {
            t.showed = flag;
        }

        public static void SetTextTagSuspended(texttag t, boolean flag)
        {
        }

        public static void SetTextTagPermanent(texttag t, boolean flag)
        {
        }

        public static void SetTextTagAge(texttag t, real age)
        {
            t.life = age;
        }

        public static void SetTextTagLifespan(texttag t, real lifespan)
        {
        }

        public static void SetTextTagFadepoint(texttag t, real fadepoint)
        {
        }

        public static void SetReservedLocalHeroButtons(integer reserved)
        {
        }

        public static integer GetAllyColorFilterState()
        {
            throw new NotImplementedException();
        }

        public static void SetAllyColorFilterState(integer state)
        {
        }

        public static boolean GetCreepCampFilterState()
        {
            throw new NotImplementedException();
        }

        public static void SetCreepCampFilterState(boolean state)
        {
        }

        public static void EnableMinimapFilterButtons(boolean enableAlly, boolean enableCreep)
        {
        }

        public static void EnableDragSelect(boolean state, boolean ui)
        {
            throw new NotImplementedException();
        }

        public static void EnablePreSelect(boolean state, boolean ui)
        {
        }

        public static void EnableSelect(boolean state, boolean ui)
        {
            throw new NotImplementedException();
        }

        public static trackable CreateTrackable(@string trackableModelPath, real x, real y, real facing)
        {
            return new trackable() { modelPath = trackableModelPath, x = x, y = y, facing = facing };
        }

        public static quest CreateQuest()
        {
            return new quest();
        }

        public static void DestroyQuest(quest whichQuest)
        {
            whichQuest.destroyed = true;
        }

        public static void QuestSetTitle(quest whichQuest, @string title)
        {
            whichQuest.title = title;
        }

        public static void QuestSetDescription(quest whichQuest, @string description)
        {
            whichQuest.description = description;
        }

        public static void QuestSetIconPath(quest whichQuest, @string iconPath)
        {
        }

        public static void QuestSetRequired(quest whichQuest, boolean required)
        {
            whichQuest.required = required;
        }

        public static void QuestSetCompleted(quest whichQuest, boolean completed)
        {
            whichQuest.completed = completed;
        }

        public static void QuestSetDiscovered(quest whichQuest, boolean discovered)
        {
            whichQuest.isDiscoverd = discovered;
        }

        public static void QuestSetFailed(quest whichQuest, boolean failed)
        {
            whichQuest.isFailed = failed;
        }

        public static void QuestSetEnabled(quest whichQuest, boolean enabled)
        {
            whichQuest.isEnabled = enabled;
        }

        public static boolean IsQuestRequired(quest whichQuest)
        {
            return whichQuest.required;
        }

        public static boolean IsQuestCompleted(quest whichQuest)
        {
            return whichQuest.completed;
        }

        public static boolean IsQuestDiscovered(quest whichQuest)
        {
            return whichQuest.required;
        }

        public static boolean IsQuestFailed(quest whichQuest)
        {
            return whichQuest.isFailed;
        }

        public static boolean IsQuestEnabled(quest whichQuest)
        {
            return whichQuest.isEnabled;
        }

        public static questitem QuestCreateItem(quest whichQuest)
        {
            questitem it = new questitem() { owner = whichQuest };
            whichQuest.items.Add(it);
            return it;
        }

        public static void QuestItemSetDescription(questitem whichQuestItem, @string description)
        {
            whichQuestItem.description = description;
        }

        public static void QuestItemSetCompleted(questitem whichQuestItem, boolean completed)
        {
            whichQuestItem.completed = completed;
        }

        public static boolean IsQuestItemCompleted(questitem whichQuestItem)
        {
            return whichQuestItem.completed;
        }

        public static defeatcondition CreateDefeatCondition()
        {
            throw new NotImplementedException();
        }

        public static void DestroyDefeatCondition(defeatcondition whichCondition)
        {
        }

        public static void DefeatConditionSetDescription(defeatcondition whichCondition, @string description)
        {
        }

        public static void FlashQuestDialogButton()
        {
        }

        public static void ForceQuestDialogUpdate()
        {
        }

        public static timerdialog CreateTimerDialog(timer t)
        {
            return new timerdialog() { hookedtimer = t };
        }

        public static void DestroyTimerDialog(timerdialog whichDialog)
        {
            whichDialog.destroyed = true;
        }

        public static void TimerDialogSetTitle(timerdialog whichDialog, @string title)
        {
            whichDialog.title = title;
        }

        public static void TimerDialogSetTitleColor(timerdialog whichDialog, integer red, integer green, integer blue, integer alpha)
        {
        }

        public static void TimerDialogSetTimeColor(timerdialog whichDialog, integer red, integer green, integer blue, integer alpha)
        {
        }

        public static void TimerDialogSetSpeed(timerdialog whichDialog, real speedMultFactor)
        {
        }

        public static void TimerDialogDisplay(timerdialog whichDialog, boolean display)
        {
            whichDialog.isDisplayed = display;
        }

        public static boolean IsTimerDialogDisplayed(timerdialog whichDialog)
        {
            return whichDialog.isDisplayed;
        }

        public static void TimerDialogSetRealTimeRemaining(timerdialog whichDialog, real timeRemaining)
        {
        }

        public static leaderboard CreateLeaderboard()
        {
            return new leaderboard();
        }

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


        public static void SetCameraPosition(real x, real y)
        {
        }

        public static void SetCameraQuickPosition(real x, real y)
        {
        }

        public static void SetCameraBounds(real x1, real y1, real x2, real y2, real x3, real y3, real x4, real y4)
        {
        }

        public static void StopCamera()
        {
        }

        public static void ResetToGameCamera(real duration)
        {
        }

        public static void PanCameraTo(real x, real y)
        {
        }

        public static void PanCameraToTimed(real x, real y, real duration)
        {
        }

        public static void PanCameraToWithZ(real x, real y, real zOffsetDest)
        {
        }

        public static void PanCameraToTimedWithZ(real x, real y, real zOffsetDest, real duration)
        {
        }

        public static void SetCinematicCamera(@string cameraModelFile)
        {
        }

        public static void SetCameraRotateMode(real x, real y, real radiansToSweep, real duration)
        {
        }

        public static void SetCameraField(camerafield whichField, real value, real duration)
        {
        }

        public static void AdjustCameraField(camerafield whichField, real offset, real duration)
        {
        }

        public static void SetCameraTargetController(unit whichUnit, real xoffset, real yoffset, boolean inheritOrientation)
        {
        }

        public static void SetCameraOrientController(unit whichUnit, real xoffset, real yoffset)
        {
        }

        public static camerasetup CreateCameraSetup()
        {
            return new camerasetup();
        }

        public static void CameraSetupSetField(camerasetup whichSetup, camerafield whichField, real value, real duration)
        {
        }

        public static real CameraSetupGetField(camerasetup whichSetup, camerafield whichField)
        {
            throw new NotImplementedException();
        }

        public static void CameraSetupSetDestPosition(camerasetup whichSetup, real x, real y, real duration)
        {
        }

        public static location CameraSetupGetDestPositionLoc(camerasetup whichSetup)
        {
            throw new NotImplementedException();
        }

        public static real CameraSetupGetDestPositionX(camerasetup whichSetup)
        {
            throw new NotImplementedException();
        }

        public static real CameraSetupGetDestPositionY(camerasetup whichSetup)
        {
            throw new NotImplementedException();
        }

        public static void CameraSetupApply(camerasetup whichSetup, boolean doPan, boolean panTimed)
        {
        }

        public static void CameraSetupApplyWithZ(camerasetup whichSetup, real zDestOffset)
        {
        }

        public static void CameraSetupApplyForceDuration(camerasetup whichSetup, boolean doPan, real forceDuration)
        {
        }

        public static void CameraSetupApplyForceDurationWithZ(camerasetup whichSetup, real zDestOffset, real forceDuration)
        {
        }

        public static void CameraSetTargetNoise(real mag, real velocity)
        {
        }

        public static void CameraSetSourceNoise(real mag, real velocity)
        {
        }

        public static void CameraSetTargetNoiseEx(real mag, real velocity, boolean vertOnly)
        {
        }

        public static void CameraSetSourceNoiseEx(real mag, real velocity, boolean vertOnly)
        {
        }

        public static void CameraSetSmoothingFactor(real factor)
        {
        }

        public static void SetCineFilterTexture(@string filename)
        {
        }

        public static void SetCineFilterBlendMode(blendmode whichMode)
        {
        }

        public static void SetCineFilterTexMapFlags(texmapflags whichFlags)
        {
        }

        public static void SetCineFilterStartUV(real minu, real minv, real maxu, real maxv)
        {
        }

        public static void SetCineFilterEndUV(real minu, real minv, real maxu, real maxv)
        {
        }

        public static void SetCineFilterStartColor(integer red, integer green, integer blue, integer alpha)
        {
        }

        public static void SetCineFilterEndColor(integer red, integer green, integer blue, integer alpha)
        {
        }

        public static void SetCineFilterDuration(real duration)
        {
        }

        public static void DisplayCineFilter(boolean flag)
        {
        }

        public static boolean IsCineFilterDisplayed()
        {
            throw new NotImplementedException();
        }

        public static void SetCinematicScene(integer portraitUnitId, playercolor color, @string speakerTitle, @string text, real sceneDuration, real voiceoverDuration)
        {
        }

        public static void EndCinematicScene()
        {
        }

        public static void ForceCinematicSubtitles(boolean flag)
        {
        }

        public static real GetCameraMargin(integer whichMargin)
        {
            throw new NotImplementedException();
        }

        public static real GetCameraBoundMinX()
        {
            throw new NotImplementedException();
        }

        public static real GetCameraBoundMinY()
        {
            throw new NotImplementedException();
        }

        public static real GetCameraBoundMaxX()
        {
            throw new NotImplementedException();
        }

        public static real GetCameraBoundMaxY()
        {
            throw new NotImplementedException();
        }

        public static real GetCameraField(camerafield whichField)
        {
            throw new NotImplementedException();
        }

        public static real GetCameraTargetPositionX()
        {
            throw new NotImplementedException();
        }

        public static real GetCameraTargetPositionY()
        {
            throw new NotImplementedException();
        }

        public static real GetCameraTargetPositionZ()
        {
            throw new NotImplementedException();
        }

        public static location GetCameraTargetPositionLoc()
        {
            throw new NotImplementedException();
        }

        public static real GetCameraEyePositionX()
        {
            throw new NotImplementedException();
        }

        public static real GetCameraEyePositionY()
        {
            throw new NotImplementedException();
        }

        public static real GetCameraEyePositionZ()
        {
            throw new NotImplementedException();
        }

        public static location GetCameraEyePositionLoc()
        {
            throw new NotImplementedException();
        }

        public static void NewSoundEnvironment(@string environmentName)
        {
        }

        public static sound CreateSound(@string fileName, boolean looping, boolean is3D, boolean stopwhenoutofrange, integer fadeInRate, integer fadeOutRate, @string eaxSetting)
        {
            return new sound() { fileName = fileName, looping = looping, is3D = is3D, stopWhenOutOfRange = stopwhenoutofrange, fadeInRate = fadeInRate, fadeOutRate = fadeOutRate, eaxSetting = eaxSetting };
        }

        public static sound CreateSoundFilenameWithLabel(@string fileName, boolean looping, boolean is3D, boolean stopwhenoutofrange, integer fadeInRate, integer fadeOutRate, @string SLKEntryName)
        {
            return new sound() { fileName = fileName, looping = looping, is3D = is3D, stopWhenOutOfRange = stopwhenoutofrange, fadeInRate = fadeInRate, fadeOutRate = fadeOutRate, SLKEntryName = SLKEntryName };
        }

        public static sound CreateSoundFromLabel(@string soundLabel, boolean looping, boolean is3D, boolean stopwhenoutofrange, integer fadeInRate, integer fadeOutRate)
        {
            return new sound() { soundLabel = soundLabel, looping = looping, is3D = is3D, stopWhenOutOfRange = stopwhenoutofrange, fadeInRate = fadeInRate, fadeOutRate = fadeOutRate };
        }

        public static sound CreateMIDISound(@string soundLabel, integer fadeInRate, integer fadeOutRate)
        {
            return new sound() { soundLabel = soundLabel, fadeInRate = fadeInRate, fadeOutRate = fadeOutRate };
        }

        public static void SetSoundParamsFromLabel(sound soundHandle, @string soundLabel)
        {
            soundHandle.soundLabel = soundLabel;
        }

        public static void SetSoundDistanceCutoff(sound soundHandle, real cutoff)
        {
        }

        public static void SetSoundChannel(sound soundHandle, integer channel)
        {
        }

        public static void SetSoundVolume(sound soundHandle, integer volume)
        {
        }

        public static void SetSoundPitch(sound soundHandle, real pitch)
        {
        }

        public static void SetSoundPlayPosition(sound soundHandle, integer millisecs)
        {
        }

        public static void SetSoundDistances(sound soundHandle, real minDist, real maxDist)
        {
        }

        public static void SetSoundConeAngles(sound soundHandle, real inside, real outside, integer outsideVolume)
        {
        }

        public static void SetSoundConeOrientation(sound soundHandle, real x, real y, real z)
        {
        }

        public static void SetSoundPosition(sound soundHandle, real x, real y, real z)
        {
            soundHandle.x = x;
            soundHandle.y = y;
            soundHandle.z = z;
        }

        public static void SetSoundVelocity(sound soundHandle, real x, real y, real z)
        {
        }

        public static void AttachSoundToUnit(sound soundHandle, unit whichUnit)
        {
        }

        public static void StartSound(sound soundHandle)
        {
            soundHandle.playing = true;
        }

        public static void StopSound(sound soundHandle, boolean killWhenDone, boolean fadeOut)
        {
            soundHandle.playing = false;
        }

        public static void KillSoundWhenDone(sound soundHandle)
        {
        }

        public static void SetMapMusic(@string musicName, boolean random, integer index)
        {
        }

        public static void ClearMapMusic()
        {
        }

        public static void PlayMusic(@string musicName)
        {
        }

        public static void PlayMusicEx(@string musicName, integer frommsecs, integer fadeinmsecs)
        {
        }

        public static void StopMusic(boolean fadeOut)
        {
        }

        public static void ResumeMusic()
        {
        }

        public static void PlayThematicMusic(@string musicFileName)
        {
        }

        public static void PlayThematicMusicEx(@string musicFileName, integer frommsecs)
        {
        }

        public static void EndThematicMusic()
        {
        }

        public static void SetMusicVolume(integer volume)
        {
        }

        public static void SetMusicPlayPosition(integer millisecs)
        {
        }

        public static void SetThematicMusicPlayPosition(integer millisecs)
        {
        }

        public static void SetSoundDuration(sound soundHandle, integer duration)
        {
        }

        public static integer GetSoundDuration(sound soundHandle)
        {
            throw new NotImplementedException();
        }

        public static integer GetSoundFileDuration(@string musicFileName)
        {
            throw new NotImplementedException();
        }

        public static void VolumeGroupSetVolume(volumegroup vgroup, real scale)
        {
        }

        public static void VolumeGroupReset()
        {
        }

        public static boolean GetSoundIsPlaying(sound soundHandle)
        {
            return soundHandle.playing;
        }

        public static boolean GetSoundIsLoading(sound soundHandle)
        {
            throw new NotImplementedException();
        }

        public static void RegisterStackedSound(sound soundHandle, boolean byPosition, real rectwidth, real rectheight)
        {
        }

        public static void UnregisterStackedSound(sound soundHandle, boolean byPosition, real rectwidth, real rectheight)
        {
        }

        public static weathereffect AddWeatherEffect(rect where, integer effectID)
        {
            throw new NotImplementedException();
        }

        public static void RemoveWeatherEffect(weathereffect whichEffect)
        {
        }

        public static void EnableWeatherEffect(weathereffect whichEffect, boolean enable)
        {
        }

        public static terraindeformation TerrainDeformCrater(real x, real y, real radius, real depth, integer duration, boolean permanent)
        {
            throw new NotImplementedException();
        }

        public static terraindeformation TerrainDeformRipple(real x, real y, real radius, real depth, integer duration, integer count, real spaceWaves, real timeWaves, real radiusStartPct, boolean limitNeg)
        {
            throw new NotImplementedException();
        }

        public static terraindeformation TerrainDeformWave(real x, real y, real dirX, real dirY, real distance, real speed, real radius, real depth, integer trailTime, integer count)
        {
            throw new NotImplementedException();
        }

        public static terraindeformation TerrainDeformRandom(real x, real y, real radius, real minDelta, real maxDelta, integer duration, integer updateInterval)
        {
            throw new NotImplementedException();
        }

        public static void TerrainDeformStop(terraindeformation deformation, integer duration)
        {
        }

        public static void TerrainDeformStopAll()
        {
        }

        public static effect AddSpecialEffect(@string modelName, real x, real y)
        {
            return new effect() { modelFilePath = modelName, x = x, y = y };
        }

        public static effect AddSpecialEffectLoc(@string modelName, location where)
        {
            return new effect() { modelFilePath = modelName, x = where.x, y = where.y };
        }

        public static effect AddSpecialEffectTarget(@string modelName, widget targetWidget, @string attachPointName)
        {
            throw new NotImplementedException();
        }

        public static void DestroyEffect(effect whichEffect)
        {
            whichEffect.destroyed = true;
        }

        public static effect AddSpellEffect(@string abilityString, effecttype t, real x, real y)
        {
            throw new NotImplementedException();
        }

        public static effect AddSpellEffectLoc(@string abilityString, effecttype t, location where)
        {
            throw new NotImplementedException();
        }

        public static effect AddSpellEffectById(integer abilityId, effecttype t, real x, real y)
        {
            throw new NotImplementedException();
        }

        public static effect AddSpellEffectByIdLoc(integer abilityId, effecttype t, location where)
        {
            throw new NotImplementedException();
        }

        public static effect AddSpellEffectTarget(@string modelName, effecttype t, widget targetWidget, @string attachPoint)
        {
            throw new NotImplementedException();
        }

        public static effect AddSpellEffectTargetById(integer abilityId, effecttype t, widget targetWidget, @string attachPoint)
        {
            throw new NotImplementedException();
        }

        public static lightning AddLightning(@string codeName, boolean checkVisibility, real x1, real y1, real x2, real y2)
        {
            throw new NotImplementedException();
        }

        public static lightning AddLightningEx(@string codeName, boolean checkVisibility, real x1, real y1, real z1, real x2, real y2, real z2)
        {
            throw new NotImplementedException();
        }

        public static boolean DestroyLightning(lightning whichBolt)
        {
            throw new NotImplementedException();
        }

        public static boolean MoveLightning(lightning whichBolt, boolean checkVisibility, real x1, real y1, real x2, real y2)
        {
            throw new NotImplementedException();
        }

        public static boolean MoveLightningEx(lightning whichBolt, boolean checkVisibility, real x1, real y1, real z1, real x2, real y2, real z2)
        {
            throw new NotImplementedException();
        }

        public static real GetLightningColorA(lightning whichBolt)
        {
            throw new NotImplementedException();
        }

        public static real GetLightningColorR(lightning whichBolt)
        {
            throw new NotImplementedException();
        }

        public static real GetLightningColorG(lightning whichBolt)
        {
            throw new NotImplementedException();
        }

        public static real GetLightningColorB(lightning whichBolt)
        {
            throw new NotImplementedException();
        }

        public static boolean SetLightningColor(lightning whichBolt, real r, real g, real b, real a)
        {
            throw new NotImplementedException();
        }

        public static @string GetAbilityEffect(@string abilityString, effecttype t, integer index)
        {
            throw new NotImplementedException();
        }

        public static @string GetAbilityEffectById(integer abilityId, effecttype t, integer index)
        {
            throw new NotImplementedException();
        }

        public static @string GetAbilitySound(@string abilityString, soundtype t)
        {
            throw new NotImplementedException();
        }

        public static @string GetAbilitySoundById(integer abilityId, soundtype t)
        {
            throw new NotImplementedException();
        }

        public static integer GetTerrainCliffLevel(real x, real y)
        {
            throw new NotImplementedException();
        }

        public static void SetWaterBaseColor(integer red, integer green, integer blue, integer alpha)
        {
        }

        public static void SetWaterDeforms(boolean val)
        {
        }

        public static integer GetTerrainType(real x, real y)
        {
            throw new NotImplementedException();
        }

        public static integer GetTerrainVariance(real x, real y)
        {
            throw new NotImplementedException();
        }

        public static void SetTerrainType(real x, real y, integer terrainType, integer variation, integer area, integer shape)
        {
        }

        public static boolean IsTerrainPathable(real x, real y, pathingtype t)
        {
            throw new NotImplementedException();
        }

        public static void SetTerrainPathable(real x, real y, pathingtype t, boolean flag)
        {
        }

        public static image CreateImage(@string file, real sizeX, real sizeY, real sizeZ, real posX, real posY, real posZ, real originX, real originY, real originZ, integer imageType)
        {
            throw new NotImplementedException();
        }

        public static void DestroyImage(image whichImage)
        {
            whichImage.destroyed = true;
        }

        public static void ShowImage(image whichImage, boolean flag)
        {
            whichImage.showed = flag;
        }

        public static void SetImageConstantHeight(image whichImage, boolean flag, real height)
        {
        }

        public static void SetImagePosition(image whichImage, real x, real y, real z)
        {
            whichImage.x = x;
            whichImage.y = y;
            whichImage.z = z;
        }

        public static void SetImageColor(image whichImage, integer red, integer green, integer blue, integer alpha)
        {
            whichImage.R = red;
            whichImage.G = green;
            whichImage.B = blue;
            whichImage.A = alpha;
        }

        public static void SetImageRender(image whichImage, boolean flag)
        {
            whichImage.rendering = flag;
        }

        public static void SetImageRenderAlways(image whichImage, boolean flag)
        {
        }

        public static void SetImageAboveWater(image whichImage, boolean flag, boolean useWaterAlpha)
        {
        }

        public static void SetImageType(image whichImage, integer imageType)
        {
            whichImage.type = imageType;
        }

        public static ubersplat CreateUbersplat(real x, real y, @string name, integer red, integer green, integer blue, integer alpha, boolean forcePaused, boolean noBirthTime)
        {
            throw new NotImplementedException();
        }

        public static void DestroyUbersplat(ubersplat whichSplat)
        {
            whichSplat.destroyed = true;
        }

        public static void ResetUbersplat(ubersplat whichSplat)
        {
        }

        public static void FinishUbersplat(ubersplat whichSplat)
        {
        }

        public static void ShowUbersplat(ubersplat whichSplat, boolean flag)
        {
        }

        public static void SetUbersplatRender(ubersplat whichSplat, boolean flag)
        {
        }

        public static void SetUbersplatRenderAlways(ubersplat whichSplat, boolean flag)
        {
        }

        public static void SetBlight(player whichPlayer, real x, real y, real radius, boolean addBlight)
        {
        }

        public static void SetBlightRect(player whichPlayer, rect r, boolean addBlight)
        {
        }

        public static void SetBlightPoint(player whichPlayer, real x, real y, boolean addBlight)
        {
        }

        public static void SetBlightLoc(player whichPlayer, location whichLocation, real radius, boolean addBlight)
        {
        }

        public static unit CreateBlightedGoldmine(player id, real x, real y, real face)
        {
            throw new NotImplementedException();
        }

        public static boolean IsPointBlighted(real x, real y)
        {
            throw new NotImplementedException();
        }

        public static void SetDoodadAnimation(real x, real y, real radius, integer doodadID, boolean nearestOnly, @string animName, boolean animRandom)
        {
        }

        public static void SetDoodadAnimationRect(rect r, integer doodadID, @string animName, boolean animRandom)
        {
        }

        public static void StartMeleeAI(player num, @string script)
        {
            throw new NotImplementedException();
        }

        public static void StartCampaignAI(player num, @string script)
        {
            throw new NotImplementedException();
        }

        public static void CommandAI(player num, integer command, integer data)
        {
        }

        public static void PauseCompAI(player p, boolean pause)
        {
        }

        public static aidifficulty GetAIDifficulty(player num)
        {
            throw new NotImplementedException();
        }

        public static void RemoveGuardPosition(unit hUnit)
        {
        }

        public static void RecycleGuardPosition(unit hUnit)
        {
        }

        public static void RemoveAllGuardPositions(player num)
        {
        }

        public static void Cheat(@string cheatStr)
        {
        }

        public static boolean IsNoVictoryCheat()
        {
            throw new NotImplementedException();
        }

        public static boolean IsNoDefeatCheat()
        {
            throw new NotImplementedException();
        }

        public static void Preload(@string filename)
        {
        }

        public static void PreloadEnd(real timeout)
        {
        }

        public static void PreloadStart()
        {
        }

        public static void PreloadRefresh()
        {
        }

        public static void PreloadEndEx()
        {
        }

        public static void PreloadGenClear()
        {
        }

        public static void PreloadGenStart()
        {
        }

        public static void PreloadGenEnd(@string filename)
        {
        }

        public static void Preloader(@string filename)
        {
        }
    }
}
