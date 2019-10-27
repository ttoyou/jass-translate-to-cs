using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map.Extra
{
    using integer = System.Int32;
    using real = System.Single;
    using boolean = System.Boolean;
    using @string = System.String;
    using code = System.Delegate;
    public class TEvent
    {
        public region TriggeringRegion { get; }

        public unit EnteringUnit { get; }

        public unit LeavingUnit { get; }

        public trackable TriggeringTrackable { get; }

        public trigger TriggeringTrigger { get; }

        public eventid TriggerEventId { get; }

        public player TriggerPlayer { get; }

        public playerstate EventPlayerState { get; }

        public player WinningPlayer { get; }

        public unit TriggerUnit { get; }

        public real EventDamage { get; }

        public unit EventDamageSource { get; }

        public player EventDetectingPlayer { get; }

        public unit EventTargetUnit { get; }

        public destructable TriggerDestructable { get; }

        public widget TriggerWidget { get; }

        public widget OrderTarget { get; }

        public destructable OrderTargetDestructable { get; }

        public item OrderTargetItem { get; }

        public unit OrderTargetUnit { get; }

        public unit SpellAbilityUnit { get; }

        public integer SpellAbilityId { get; }

        public ability SpellAbility { get; }

        public location SpellTargetLoc { get; }

        public real SpellTargetX { get; }

        public real SpellTargetY { get; }

        public destructable SpellTargetDestructable { get; }

        public item SpellTargetItem { get; }

        public unit SpellTargetUnit { get; }

        public unit LevelingUnit { get; }

        public unit LearningUnit { get; }

        public integer LearnedSkill { get; }

        public integer LearnedSkillLevel { get; }

        public unit RevivableUnit { get; }

        public unit RevivingUnit { get; }

        public unit Attacker { get; }

        public unit Rescuer { get; }

        public unit DyingUnit { get; }

        public unit KillingUnit { get; }

        public unit DecayingUnit { get; }

        public unit ConstructingStructure { get; }

        public unit CancelledStructure { get; }

        public unit ConstructedStructure { get; }

        public unit ResearchingUnit { get; }

        public integer Researched { get; }

        public integer TrainedUnitType { get; }

        public unit TrainedUnit { get; }

        public unit DetectedUnit { get; }

        public unit SummoningUnit { get; }

        public unit SummonedUnit { get; }

        public unit TransportUnit { get; }

        public unit LoadedUnit { get; }

        public unit SellingUnit { get; }

        public unit SoldUnit { get; }

        public unit BuyingUnit { get; }

        public item SoldItem { get; }

        public unit ChangingUnit { get; }

        public player ChangingUnitPrevOwner { get; }

        public unit ManipulatingUnit { get; }

        public item ManipulatedItem { get; }

        public unit OrderedUnit { get; }

        public integer IssuedOrderId { get; }

        public real OrderPointX { get; }

        public real OrderPointY { get; }

        public location OrderPointLoc { get; }

        public @string EventPlayerChatString { get; }

        public @string EventPlayerChatStringMatched { get; }

        public unitstate EventUnitState { get; }

        public gamestate EventGameState { get; }

        public button ClickedButton { get; }

        public dialog ClickedDialog { get; }

        public timer ExpiredTimer { get; }

        public string SaveBasicFilename { get; }
    }
}
