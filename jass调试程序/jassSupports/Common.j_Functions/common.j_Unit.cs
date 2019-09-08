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

        public static integer GetUnitUserData(unit whichUnit)
        {
            return whichUnit.userData;
        }

        public static void SetUnitUserData(unit whichUnit, integer data)
        {
            whichUnit.userData = data;
        }

        public static unit CreateUnit(player id, integer unitid, real x, real y, real face)
        {
            return new unit() { owner = id, unitid = unitid, x = x, y = y, facing = face };
        }

        public static unit CreateUnitByName(player whichPlayer, @string unitname, real x, real y, real face)
        {
            throw new NotImplementedException();
        }

        public static unit CreateUnitAtLoc(player id, integer unitid, location whichLocation, real face)
        {
            return new unit() { owner = id, unitid = unitid, x = whichLocation.x, y = whichLocation.y, facing = face };
        }

        public static unit CreateUnitAtLocByName(player id, @string unitname, location whichLocation, real face)
        {
            throw new NotImplementedException();
        }

        public static unit CreateCorpse(player whichPlayer, integer unitid, real x, real y, real face)
        {
            throw new NotImplementedException();
        }

        public static void KillUnit(unit whichUnit)
        {
            whichUnit.life = 0;
        }

        public static void RemoveUnit(unit whichUnit)
        {
            whichUnit.destroyed = true;
        }

        public static void ShowUnit(unit whichUnit, boolean show)
        {
            whichUnit.showed = show;
        }

        public static void SetUnitState(unit whichUnit, unitstate whichUnitState, real newVal)
        {
        }

        public static void SetUnitX(unit whichUnit, real newX)
        {
            whichUnit.x = newX;
        }

        public static void SetUnitY(unit whichUnit, real newY)
        {
            whichUnit.y = newY;
        }

        public static void SetUnitPosition(unit whichUnit, real newX, real newY)
        {
            whichUnit.x = newX;
            whichUnit.y = newY;
        }

        public static void SetUnitPositionLoc(unit whichUnit, location whichLocation)
        {
            whichUnit.x = whichLocation.x;
            whichUnit.y = whichLocation.y;
        }

        public static void SetUnitFacing(unit whichUnit, real facingAngle)
        {
            whichUnit.facing = (real)(facingAngle / 180 * Math.PI);
        }

        public static void SetUnitFacingTimed(unit whichUnit, real facingAngle, real duration)
        {
        }

        public static void SetUnitMoveSpeed(unit whichUnit, real newSpeed)
        {
            whichUnit.speed = newSpeed;
        }

        public static void SetUnitFlyHeight(unit whichUnit, real newHeight, real rate)
        {
            whichUnit.FlyHeight = newHeight;
        }

        public static void SetUnitTurnSpeed(unit whichUnit, real newTurnSpeed)
        {
        }

        public static void SetUnitPropWindow(unit whichUnit, real newPropWindowAngle)
        {
        }

        public static void SetUnitAcquireRange(unit whichUnit, real newAcquireRange)
        {
        }

        public static void SetUnitCreepGuard(unit whichUnit, boolean creepGuard)
        {
        }

        public static real GetUnitAcquireRange(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static real GetUnitTurnSpeed(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static real GetUnitPropWindow(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static real GetUnitFlyHeight(unit whichUnit)
        {
            return whichUnit.FlyHeight;
        }

        public static real GetUnitDefaultAcquireRange(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static real GetUnitDefaultTurnSpeed(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static real GetUnitDefaultPropWindow(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static real GetUnitDefaultFlyHeight(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static void SetUnitOwner(unit whichUnit, player whichPlayer, boolean changeColor)
        {
            whichUnit.owner = whichPlayer;
        }

        public static void SetUnitColor(unit whichUnit, playercolor whichColor)
        {
            whichUnit.color = whichColor;
        }

        public static void SetUnitScale(unit whichUnit, real scaleX, real scaleY, real scaleZ)
        {
            whichUnit.scaleX = scaleX;
            whichUnit.scaleY = scaleY;
            whichUnit.scaleZ = scaleZ;
        }

        public static void SetUnitTimeScale(unit whichUnit, real timeScale)
        {
        }

        public static void SetUnitBlendTime(unit whichUnit, real blendTime)
        {
        }

        public static void SetUnitVertexColor(unit whichUnit, integer red, integer green, integer blue, integer alpha)
        {
        }

        public static void QueueUnitAnimation(unit whichUnit, @string whichAnimation)
        {
        }

        public static void SetUnitAnimation(unit whichUnit, @string whichAnimation)
        {
        }

        public static void SetUnitAnimationByIndex(unit whichUnit, integer whichAnimation)
        {
        }

        public static void SetUnitAnimationWithRarity(unit whichUnit, @string whichAnimation, raritycontrol rarity)
        {
        }

        public static void AddUnitAnimationProperties(unit whichUnit, @string animProperties, boolean add)
        {
        }

        public static void SetUnitLookAt(unit whichUnit, @string whichBone, unit lookAtTarget, real offsetX, real offsetY, real offsetZ)
        {
        }

        public static void ResetUnitLookAt(unit whichUnit)
        {
            whichUnit.facing = 0;
        }

        public static void SetUnitRescuable(unit whichUnit, player byWhichPlayer, boolean flag)
        {
        }

        public static void SetUnitRescueRange(unit whichUnit, real range)
        {
        }

        public static void SetHeroStr(unit whichHero, integer newStr, boolean permanent)
        {
            whichHero.strength = newStr;
        }

        public static void SetHeroAgi(unit whichHero, integer newAgi, boolean permanent)
        {
            whichHero.agility = newAgi;
        }

        public static void SetHeroInt(unit whichHero, integer newInt, boolean permanent)
        {
            whichHero.intelligence = newInt;
        }

        public static integer GetHeroStr(unit whichHero, boolean includeBonuses)
        {
            return whichHero.strength;
        }

        public static integer GetHeroAgi(unit whichHero, boolean includeBonuses)
        {
            return whichHero.agility;
        }

        public static integer GetHeroInt(unit whichHero, boolean includeBonuses)
        {
            return whichHero.intelligence;
        }

        public static boolean UnitStripHeroLevel(unit whichHero, integer howManyLevels)
        {
            throw new NotImplementedException();
        }

        public static integer GetHeroXP(unit whichHero)
        {
            return whichHero.XP;
        }

        public static void SetHeroXP(unit whichHero, integer newXpVal, boolean showEyeCandy)
        {
        }

        public static integer GetHeroSkillPoints(unit whichHero)
        {
            throw new NotImplementedException();
        }

        public static boolean UnitModifySkillPoints(unit whichHero, integer skillPointDelta)
        {
            throw new NotImplementedException();
        }

        public static void AddHeroXP(unit whichHero, integer xpToAdd, boolean showEyeCandy)
        {
        }

        public static void SetHeroLevel(unit whichHero, integer level, boolean showEyeCandy)
        {
        }

        public static integer GetHeroLevel(unit whichHero)
        {
            return whichHero.level;
        }

        public static integer GetUnitLevel(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static @string GetHeroProperName(unit whichHero)
        {
            throw new NotImplementedException();
        }

        public static void SuspendHeroXP(unit whichHero, boolean flag)
        {
        }

        public static boolean IsSuspendedXP(unit whichHero)
        {
            throw new NotImplementedException();
        }

        public static void SelectHeroSkill(unit whichHero, integer abilcode)
        {
        }

        public static integer GetUnitAbilityLevel(unit whichUnit, integer abilcode)
        {
            throw new NotImplementedException();
        }

        public static integer DecUnitAbilityLevel(unit whichUnit, integer abilcode)
        {
            throw new NotImplementedException();
        }

        public static integer IncUnitAbilityLevel(unit whichUnit, integer abilcode)
        {
            throw new NotImplementedException();
        }

        public static integer SetUnitAbilityLevel(unit whichUnit, integer abilcode, integer level)
        {
            throw new NotImplementedException();
        }

        public static boolean ReviveHero(unit whichHero, real x, real y, boolean doEyecandy)
        {
            throw new NotImplementedException();
        }

        public static boolean ReviveHeroLoc(unit whichHero, location loc, boolean doEyecandy)
        {
            throw new NotImplementedException();
        }

        public static void SetUnitExploded(unit whichUnit, boolean exploded)
        {
        }

        public static void SetUnitInvulnerable(unit whichUnit, boolean flag)
        {
            whichUnit.isInvulnerable = flag;
        }

        public static void PauseUnit(unit whichUnit, boolean flag)
        {
            whichUnit.isPaused = flag;
        }

        public static boolean IsUnitPaused(unit whichHero)
        {
            return whichHero.isPaused;
        }

        public static void SetUnitPathing(unit whichUnit, boolean flag)
        {
        }

        public static void SelectUnit(unit whichUnit, boolean flag)
        {
        }

        public static integer GetUnitPointValue(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static integer GetUnitPointValueByType(integer unitType)
        {
            throw new NotImplementedException();
        }

        public static boolean UnitAddItem(unit whichUnit, item whichItem)
        {
            throw new NotImplementedException();
        }

        public static item UnitAddItemById(unit whichUnit, integer itemId)
        {
            throw new NotImplementedException();
        }

        public static boolean UnitAddItemToSlotById(unit whichUnit, integer itemId, integer itemSlot)
        {
            throw new NotImplementedException();
        }

        public static void UnitRemoveItem(unit whichUnit, item whichItem)
        {
            throw new NotImplementedException();
        }

        public static item UnitRemoveItemFromSlot(unit whichUnit, integer itemSlot)
        {
            throw new NotImplementedException();
        }

        public static boolean UnitHasItem(unit whichUnit, item whichItem)
        {
            if (whichUnit.slots.Contains(whichItem)) return true;
            else return false;
        }

        public static item UnitItemInSlot(unit whichUnit, integer itemSlot)
        {
            return whichUnit.slots[itemSlot];
        }

        public static integer UnitInventorySize(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static boolean UnitDropItemPoint(unit whichUnit, item whichItem, real x, real y)
        {
            throw new NotImplementedException();
        }

        public static boolean UnitDropItemSlot(unit whichUnit, item whichItem, integer slot)
        {
            throw new NotImplementedException();
        }

        public static boolean UnitDropItemTarget(unit whichUnit, item whichItem, widget target)
        {
            throw new NotImplementedException();
        }

        public static boolean UnitUseItem(unit whichUnit, item whichItem)
        {
            throw new NotImplementedException();
        }

        public static boolean UnitUseItemPoint(unit whichUnit, item whichItem, real x, real y)
        {
            throw new NotImplementedException();
        }

        public static boolean UnitUseItemTarget(unit whichUnit, item whichItem, widget target)
        {
            throw new NotImplementedException();
        }

        public static real GetUnitX(unit whichUnit)
        {
            return whichUnit.x;
        }

        public static real GetUnitY(unit whichUnit)
        {
            return whichUnit.y;
        }

        public static location GetUnitLoc(unit whichUnit)
        {
            return new location() { x = whichUnit.x, y = whichUnit.y };
        }

        public static real GetUnitFacing(unit whichUnit)
        {
            return whichUnit.facing;
        }

        public static real GetUnitMoveSpeed(unit whichUnit)
        {
            return whichUnit.speed;
        }

        public static real GetUnitDefaultMoveSpeed(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static real GetUnitState(unit whichUnit, unitstate whichUnitState)
        {
            throw new NotImplementedException();
        }

        public static player GetOwningPlayer(unit whichUnit)
        {
            return whichUnit.owner;
        }

        public static integer GetUnitTypeId(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static race GetUnitRace(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static @string GetUnitName(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static integer GetUnitFoodUsed(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static integer GetUnitFoodMade(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static integer GetFoodMade(integer unitId)
        {
            throw new NotImplementedException();
        }

        public static integer GetFoodUsed(integer unitId)
        {
            throw new NotImplementedException();
        }

        public static void SetUnitUseFood(unit whichUnit, boolean useFood)
        {
            whichUnit.useFood = useFood;
        }

        public static location GetUnitRallyPoint(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static unit GetUnitRallyUnit(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static destructable GetUnitRallyDestructable(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static boolean IsUnitInGroup(unit whichUnit, group whichGroup)
        {
            if (whichGroup.Contains(whichUnit)) return true;
            else return false;
        }

        public static boolean IsUnitInForce(unit whichUnit, force whichForce)
        {
            throw new NotImplementedException();
        }

        public static boolean IsUnitOwnedByPlayer(unit whichUnit, player whichPlayer)
        {
            if (whichUnit.owner == whichPlayer) return true;
            else return false;
        }

        public static boolean IsUnitAlly(unit whichUnit, player whichPlayer)
        {
            throw new NotImplementedException();
        }

        public static boolean IsUnitEnemy(unit whichUnit, player whichPlayer)
        {
            throw new NotImplementedException();
        }

        public static boolean IsUnitVisible(unit whichUnit, player whichPlayer)
        {
            throw new NotImplementedException();
        }

        public static boolean IsUnitDetected(unit whichUnit, player whichPlayer)
        {
            throw new NotImplementedException();
        }

        public static boolean IsUnitInvisible(unit whichUnit, player whichPlayer)
        {
            throw new NotImplementedException();
        }

        public static boolean IsUnitFogged(unit whichUnit, player whichPlayer)
        {
            throw new NotImplementedException();
        }

        public static boolean IsUnitMasked(unit whichUnit, player whichPlayer)
        {
            throw new NotImplementedException();
        }

        public static boolean IsUnitSelected(unit whichUnit, player whichPlayer)
        {
            throw new NotImplementedException();
        }

        public static boolean IsUnitRace(unit whichUnit, race whichRace)
        {
            throw new NotImplementedException();
        }

        public static boolean IsUnitType(unit whichUnit, unittype whichUnitType)
        {
            throw new NotImplementedException();
        }

        public static boolean IsUnit(unit whichUnit, unit whichSpecifiedUnit)
        {
            if (whichUnit == whichSpecifiedUnit) return true;
            else return false;
        }

        public static boolean IsUnitInRange(unit whichUnit, unit otherUnit, real distance)
        {
            real xs = whichUnit.x - otherUnit.x;
            real ys = whichUnit.y - otherUnit.y;
            real d = (real)Math.Sqrt(xs * xs + ys * ys);
            if (distance >= d) return true;
            else return false;
        }

        public static boolean IsUnitInRangeXY(unit whichUnit, real x, real y, real distance)
        {
            real xs = whichUnit.x - x;
            real ys = whichUnit.y - y;
            real d = (real)Math.Sqrt(xs * xs + ys * ys);
            if (distance >= d) return true;
            else return false;
        }

        public static boolean IsUnitInRangeLoc(unit whichUnit, location whichLocation, real distance)
        {
            real xs = whichUnit.x - whichLocation.x;
            real ys = whichUnit.y - whichLocation.y;
            real d = (real)Math.Sqrt(xs * xs + ys * ys);
            if (distance >= d) return true;
            else return false;
        }

        public static boolean IsUnitHidden(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static boolean IsUnitIllusion(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static boolean IsUnitInTransport(unit whichUnit, unit whichTransport)
        {
            throw new NotImplementedException();
        }

        public static boolean IsUnitLoaded(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static boolean IsHeroUnitId(integer unitId)
        {
            throw new NotImplementedException();
        }

        public static boolean IsUnitIdType(integer unitId, unittype whichUnitType)
        {
            throw new NotImplementedException();
        }

        public static void UnitShareVision(unit whichUnit, player whichPlayer, boolean share)
        {
        }

        public static void UnitSuspendDecay(unit whichUnit, boolean suspend)
        {
        }

        public static boolean UnitAddType(unit whichUnit, unittype whichUnitType)
        {
            throw new NotImplementedException();
        }

        public static boolean UnitRemoveType(unit whichUnit, unittype whichUnitType)
        {
            throw new NotImplementedException();
        }

        public static boolean UnitAddAbility(unit whichUnit, integer abilityId)
        {
            throw new NotImplementedException();
        }

        public static boolean UnitRemoveAbility(unit whichUnit, integer abilityId)
        {
            throw new NotImplementedException();
        }

        public static boolean UnitMakeAbilityPermanent(unit whichUnit, boolean permanent, integer abilityId)
        {
            throw new NotImplementedException();
        }

        public static void UnitRemoveBuffs(unit whichUnit, boolean removePositive, boolean removeNegative)
        {
        }

        public static void UnitRemoveBuffsEx(unit whichUnit, boolean removePositive, boolean removeNegative, boolean magic, boolean physical, boolean timedLife, boolean aura, boolean autoDispel)
        {
        }

        public static boolean UnitHasBuffsEx(unit whichUnit, boolean removePositive, boolean removeNegative, boolean magic, boolean physical, boolean timedLife, boolean aura, boolean autoDispel)
        {
            throw new NotImplementedException();
        }

        public static integer UnitCountBuffsEx(unit whichUnit, boolean removePositive, boolean removeNegative, boolean magic, boolean physical, boolean timedLife, boolean aura, boolean autoDispel)
        {
            throw new NotImplementedException();
        }

        public static void UnitAddSleep(unit whichUnit, boolean add)
        {
            whichUnit.canSleep = add;
        }

        public static boolean UnitCanSleep(unit whichUnit)
        {
            return whichUnit.canSleep;
        }

        public static void UnitAddSleepPerm(unit whichUnit, boolean add)
        {
        }

        public static boolean UnitCanSleepPerm(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static boolean UnitIsSleeping(unit whichUnit)
        {
            return whichUnit.isSleeping;
        }

        public static void UnitWakeUp(unit whichUnit)
        {
            whichUnit.isSleeping = false;
        }

        public static void UnitApplyTimedLife(unit whichUnit, integer buffId, real duration)
        {
        }

        public static boolean UnitIgnoreAlarm(unit whichUnit, boolean flag)
        {
            whichUnit.ignoreAlarm = flag;
            return flag;
        }

        public static boolean UnitIgnoreAlarmToggled(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static void UnitResetCooldown(unit whichUnit)
        {
        }

        public static void UnitSetConstructionProgress(unit whichUnit, integer constructionPercentage)
        {
        }

        public static void UnitSetUpgradeProgress(unit whichUnit, integer upgradePercentage)
        {
        }

        public static void UnitPauseTimedLife(unit whichUnit, boolean flag)
        {
        }

        public static void UnitSetUsesAltIcon(unit whichUnit, boolean flag)
        {
        }

        public static boolean UnitDamagePoint(unit whichUnit, real delay, real radius, real x, real y, real amount, boolean attack, boolean ranged, attacktype attackType, damagetype damageType, weapontype weaponType)
        {
            throw new NotImplementedException();
        }

        public static boolean UnitDamageTarget(unit whichUnit, widget target, real amount, boolean attack, boolean ranged, attacktype attackType, damagetype damageType, weapontype weaponType)
        {
            throw new NotImplementedException();
        }

        public static boolean IssueImmediateOrder(unit whichUnit, @string order)
        {
            throw new NotImplementedException();
        }

        public static boolean IssueImmediateOrderById(unit whichUnit, integer order)
        {
            throw new NotImplementedException();
        }

        public static boolean IssuePointOrder(unit whichUnit, @string order, real x, real y)
        {
            throw new NotImplementedException();
        }

        public static boolean IssuePointOrderLoc(unit whichUnit, @string order, location whichLocation)
        {
            throw new NotImplementedException();
        }

        public static boolean IssuePointOrderById(unit whichUnit, integer order, real x, real y)
        {
            throw new NotImplementedException();
        }

        public static boolean IssuePointOrderByIdLoc(unit whichUnit, integer order, location whichLocation)
        {
            throw new NotImplementedException();
        }

        public static boolean IssueTargetOrder(unit whichUnit, @string order, widget targetWidget)
        {
            throw new NotImplementedException();
        }

        public static boolean IssueTargetOrderById(unit whichUnit, integer order, widget targetWidget)
        {
            throw new NotImplementedException();
        }

        public static boolean IssueInstantPointOrder(unit whichUnit, @string order, real x, real y, widget instantTargetWidget)
        {
            throw new NotImplementedException();
        }

        public static boolean IssueInstantPointOrderById(unit whichUnit, integer order, real x, real y, widget instantTargetWidget)
        {
            throw new NotImplementedException();
        }

        public static boolean IssueInstantTargetOrder(unit whichUnit, @string order, widget targetWidget, widget instantTargetWidget)
        {
            throw new NotImplementedException();
        }

        public static boolean IssueInstantTargetOrderById(unit whichUnit, integer order, widget targetWidget, widget instantTargetWidget)
        {
            throw new NotImplementedException();
        }

        public static boolean IssueBuildOrder(unit whichPeon, @string unitToBuild, real x, real y)
        {
            throw new NotImplementedException();
        }

        public static boolean IssueBuildOrderById(unit whichPeon, integer unitId, real x, real y)
        {
            throw new NotImplementedException();
        }

        public static boolean IssueNeutralImmediateOrder(player forWhichPlayer, unit neutralStructure, @string unitToBuild)
        {
            throw new NotImplementedException();
        }

        public static boolean IssueNeutralImmediateOrderById(player forWhichPlayer, unit neutralStructure, integer unitId)
        {
            throw new NotImplementedException();
        }

        public static boolean IssueNeutralPointOrder(player forWhichPlayer, unit neutralStructure, @string unitToBuild, real x, real y)
        {
            throw new NotImplementedException();
        }

        public static boolean IssueNeutralPointOrderById(player forWhichPlayer, unit neutralStructure, integer unitId, real x, real y)
        {
            throw new NotImplementedException();
        }

        public static boolean IssueNeutralTargetOrder(player forWhichPlayer, unit neutralStructure, @string unitToBuild, widget target)
        {
            throw new NotImplementedException();
        }

        public static boolean IssueNeutralTargetOrderById(player forWhichPlayer, unit neutralStructure, integer unitId, widget target)
        {
            throw new NotImplementedException();
        }

        public static integer GetUnitCurrentOrder(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static void SetResourceAmount(unit whichUnit, integer amount)
        {
        }

        public static void AddResourceAmount(unit whichUnit, integer amount)
        {
        }

        public static integer GetResourceAmount(unit whichUnit)
        {
            throw new NotImplementedException();
        }

        public static real WaygateGetDestinationX(unit waygate)
        {
            throw new NotImplementedException();
        }

        public static real WaygateGetDestinationY(unit waygate)
        {
            throw new NotImplementedException();
        }

        public static void WaygateSetDestination(unit waygate, real x, real y)
        {
        }

        public static void WaygateActivate(unit waygate, boolean activate)
        {
        }

        public static boolean WaygateIsActive(unit waygate)
        {
            throw new NotImplementedException();
        }

        public static void AddItemToAllStock(integer itemId, integer currentStock, integer stockMax)
        {
        }

        public static void AddItemToStock(unit whichUnit, integer itemId, integer currentStock, integer stockMax)
        {
        }

        public static void AddUnitToAllStock(integer unitId, integer currentStock, integer stockMax)
        {
        }

        public static void AddUnitToStock(unit whichUnit, integer unitId, integer currentStock, integer stockMax)
        {
        }

        public static void RemoveItemFromAllStock(integer itemId)
        {
        }

        public static void RemoveItemFromStock(unit whichUnit, integer itemId)
        {
        }

        public static void RemoveUnitFromAllStock(integer unitId)
        {
        }

        public static void RemoveUnitFromStock(unit whichUnit, integer unitId)
        {
        }

        public static void SetAllItemTypeSlots(integer slots)
        {
        }

        public static void SetAllUnitTypeSlots(integer slots)
        {
        }

        public static void SetItemTypeSlots(unit whichUnit, integer slots)
        {
        }

        public static void SetUnitTypeSlots(unit whichUnit, integer slots)
        {
        }

    }
}
