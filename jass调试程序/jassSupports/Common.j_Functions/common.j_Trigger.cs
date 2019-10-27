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

        #region TriggerSettings
        /// <summary>
        /// 创建触发器
        /// </summary>
        /// <returns>创建的触发器</returns>
        public static trigger CreateTrigger()
        {
            trigger nt = new trigger();
            RuntimeRecorder.Recorder.Triggers.Add(nt);
            return nt;
        }
        /// <summary>
        /// 摧毁触发器
        /// </summary>
        /// <param name="whichTrigger"></param>
        public static void DestroyTrigger(trigger whichTrigger)
        {
            whichTrigger.destroyed = true;
            RuntimeRecorder.Recorder.Triggers.Remove(whichTrigger);
        }
        /// <summary>
        /// 重设触发器
        /// </summary>
        /// <param name="whichTrigger"></param>
        public static void ResetTrigger(trigger whichTrigger)
        {
        }
        /// <summary>
        /// 开启触发器
        /// </summary>
        /// <param name="whichTrigger"></param>
        public static void EnableTrigger(trigger whichTrigger)
        {
            whichTrigger.isEnabled = true;
        }
        /// <summary>
        /// 关闭触发器
        /// </summary>
        /// <param name="whichTrigger"></param>
        public static void DisableTrigger(trigger whichTrigger)
        {
            whichTrigger.isEnabled = false;
        }
        #endregion

        #region GetTriggerStates
        public static boolean IsTriggerEnabled(trigger whichTrigger)
        {
            return whichTrigger.isEnabled;
        }

        public static boolean IsTriggerWaitOnSleeps(trigger whichTrigger)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GetEventData

        public static region GetTriggeringRegion()
        {
            return TriggerEventSystem.CurrentEvent.TriggeringRegion;
        }
        /// <summary>
        /// （触发事件）进入的单位
        /// </summary>
        /// <returns></returns>
        public static unit GetEnteringUnit()
        {
            return TriggerEventSystem.CurrentEvent.EnteringUnit;
        }
        /// <summary>
        /// （触发事件）离开的单位
        /// </summary>
        /// <returns></returns>
        public static unit GetLeavingUnit()
        {
            return TriggerEventSystem.CurrentEvent.LeavingUnit;
        }

        public static trackable GetTriggeringTrackable()
        {
            return TriggerEventSystem.CurrentEvent.TriggeringTrackable;
        }

        public static trigger GetTriggeringTrigger()
        {
            return TriggerEventSystem.CurrentEvent.TriggeringTrigger;
        }

        public static eventid GetTriggerEventId()
        {
            return TriggerEventSystem.CurrentEvent.TriggerEventId;
        }

        public static integer GetTriggerEvalCount(trigger whichTrigger)
        {
            throw new NotImplementedException();
        }

        public static integer GetTriggerExecCount(trigger whichTrigger)
        {
            throw new NotImplementedException();
        }

        public static player GetTriggerPlayer()
        {
            return TriggerEventSystem.CurrentEvent.TriggerPlayer;
        }

        public static playerstate GetEventPlayerState()
        {
            return TriggerEventSystem.CurrentEvent.EventPlayerState;
        }

        public static player GetWinningPlayer()
        {
            return TriggerEventSystem.CurrentEvent.WinningPlayer;
        }
        /// <summary>
        /// （触发事件）触发单位
        /// </summary>
        /// <returns></returns>
        public static unit GetTriggerUnit()
        {
            return TriggerEventSystem.CurrentEvent.TriggerUnit;
        }
        /// <summary>
        /// （触发事件）事件伤害值
        /// </summary>
        /// <returns></returns>
        public static real GetEventDamage()
        {
            return TriggerEventSystem.CurrentEvent.EventDamage;
        }

        public static unit GetEventDamageSource()
        {
            return TriggerEventSystem.CurrentEvent.EventDamageSource;
        }

        public static player GetEventDetectingPlayer()
        {
            return TriggerEventSystem.CurrentEvent.EventDetectingPlayer;
        }

        public static unit GetEventTargetUnit()
        {
            return TriggerEventSystem.CurrentEvent.EventTargetUnit;
        }


        public static destructable GetTriggerDestructable()
        {
            return TriggerEventSystem.CurrentEvent.OrderTargetDestructable;
        }

        public static widget GetTriggerWidget()
        {
            return TriggerEventSystem.CurrentEvent.TriggerWidget;
        }

        public static widget GetOrderTarget()
        {
            return TriggerEventSystem.CurrentEvent.OrderTarget;
        }

        public static destructable GetOrderTargetDestructable()
        {
            return TriggerEventSystem.CurrentEvent.OrderTargetDestructable;
        }

        public static item GetOrderTargetItem()
        {
            return TriggerEventSystem.CurrentEvent.OrderTargetItem;
        }

        public static unit GetOrderTargetUnit()
        {
            return TriggerEventSystem.CurrentEvent.OrderTargetUnit;
        }

        public static unit GetSpellAbilityUnit()
        {
            return TriggerEventSystem.CurrentEvent.SpellAbilityUnit;
        }

        public static integer GetSpellAbilityId()
        {
            return TriggerEventSystem.CurrentEvent.SpellAbilityId;
        }

        public static ability GetSpellAbility()
        {
            return TriggerEventSystem.CurrentEvent.SpellAbility;
        }

        public static location GetSpellTargetLoc()
        {
            return TriggerEventSystem.CurrentEvent.SpellTargetLoc;
        }

        public static real GetSpellTargetX()
        {
            return TriggerEventSystem.CurrentEvent.SpellTargetX;
        }

        public static real GetSpellTargetY()
        {
            return TriggerEventSystem.CurrentEvent.SpellTargetY;
        }

        public static destructable GetSpellTargetDestructable()
        {
            return TriggerEventSystem.CurrentEvent.SpellTargetDestructable;
        }

        public static item GetSpellTargetItem()
        {
            return TriggerEventSystem.CurrentEvent.SpellTargetItem;
        }

        public static unit GetSpellTargetUnit()
        {
            return TriggerEventSystem.CurrentEvent.SpellTargetUnit;
        }

        public static unit GetLevelingUnit()
        {
            return TriggerEventSystem.CurrentEvent.LevelingUnit;
        }

        public static unit GetLearningUnit()
        {
            return TriggerEventSystem.CurrentEvent.LearningUnit;
        }

        public static integer GetLearnedSkill()
        {
            return TriggerEventSystem.CurrentEvent.LearnedSkill;
        }

        public static integer GetLearnedSkillLevel()
        {
            return TriggerEventSystem.CurrentEvent.LearnedSkillLevel;
        }

        public static unit GetRevivableUnit()
        {
            return TriggerEventSystem.CurrentEvent.RevivableUnit;
        }

        public static unit GetRevivingUnit()
        {
            return TriggerEventSystem.CurrentEvent.RevivingUnit;
        }

        public static unit GetAttacker()
        {
            return TriggerEventSystem.CurrentEvent.Attacker;
        }

        public static unit GetRescuer()
        {
            return TriggerEventSystem.CurrentEvent.Rescuer;
        }

        public static unit GetDyingUnit()
        {
            return TriggerEventSystem.CurrentEvent.DyingUnit;
        }

        public static unit GetKillingUnit()
        {
            return TriggerEventSystem.CurrentEvent.KillingUnit;
        }

        public static unit GetDecayingUnit()
        {
            return TriggerEventSystem.CurrentEvent.DecayingUnit;
        }

        public static unit GetConstructingStructure()
        {
            return TriggerEventSystem.CurrentEvent.ConstructingStructure;
        }

        public static unit GetCancelledStructure()
        {
            return TriggerEventSystem.CurrentEvent.CancelledStructure;
        }

        public static unit GetConstructedStructure()
        {
            return TriggerEventSystem.CurrentEvent.ConstructedStructure;
        }

        public static unit GetResearchingUnit()
        {
            return TriggerEventSystem.CurrentEvent.ResearchingUnit;
        }

        public static integer GetResearched()
        {
            return TriggerEventSystem.CurrentEvent.Researched;
        }

        public static integer GetTrainedUnitType()
        {
            return TriggerEventSystem.CurrentEvent.TrainedUnitType;
        }

        public static unit GetTrainedUnit()
        {
            return TriggerEventSystem.CurrentEvent.TrainedUnit;
        }

        public static unit GetDetectedUnit()
        {
            return TriggerEventSystem.CurrentEvent.DetectedUnit;
        }

        public static unit GetSummoningUnit()
        {
            return TriggerEventSystem.CurrentEvent.SummoningUnit;
        }

        public static unit GetSummonedUnit()
        {
            return TriggerEventSystem.CurrentEvent.SummonedUnit;
        }

        public static unit GetTransportUnit()
        {
            return TriggerEventSystem.CurrentEvent.TransportUnit;
        }

        public static unit GetLoadedUnit()
        {
            return TriggerEventSystem.CurrentEvent.LoadedUnit;
        }

        public static unit GetSellingUnit()
        {
            return TriggerEventSystem.CurrentEvent.SellingUnit;
        }

        public static unit GetSoldUnit()
        {
            return TriggerEventSystem.CurrentEvent.SoldUnit;
        }

        public static unit GetBuyingUnit()
        {
            return TriggerEventSystem.CurrentEvent.BuyingUnit;
        }

        public static item GetSoldItem()
        {
            return TriggerEventSystem.CurrentEvent.SoldItem;
        }

        public static unit GetChangingUnit()
        {
            return TriggerEventSystem.CurrentEvent.ChangingUnit;
        }

        public static player GetChangingUnitPrevOwner()
        {
            return TriggerEventSystem.CurrentEvent.ChangingUnitPrevOwner;
        }

        public static unit GetManipulatingUnit()
        {
            return TriggerEventSystem.CurrentEvent.ManipulatingUnit;
        }

        public static item GetManipulatedItem()
        {
            return TriggerEventSystem.CurrentEvent.ManipulatedItem;
        }

        public static unit GetOrderedUnit()
        {
            return TriggerEventSystem.CurrentEvent.OrderedUnit;
        }

        public static integer GetIssuedOrderId()
        {
            return TriggerEventSystem.CurrentEvent.IssuedOrderId;
        }

        public static real GetOrderPointX()
        {
            return TriggerEventSystem.CurrentEvent.OrderPointX;
        }

        public static real GetOrderPointY()
        {
            return TriggerEventSystem.CurrentEvent.OrderPointY;
        }

        public static location GetOrderPointLoc()
        {
            return TriggerEventSystem.CurrentEvent.OrderPointLoc;
        }


        public static @string GetEventPlayerChatString()
        {
            if (TriggerEventSystem.CurrentEvent.EventPlayerChatString != null)
                return TriggerEventSystem.CurrentEvent.EventPlayerChatString;
            else return @string.Empty;
        }

        public static @string GetEventPlayerChatStringMatched()
        {
            if (TriggerEventSystem.CurrentEvent.EventPlayerChatStringMatched != null)
                return TriggerEventSystem.CurrentEvent.EventPlayerChatStringMatched;
            else return @string.Empty;
        }

        public static unitstate GetEventUnitState()
        {
            return TriggerEventSystem.CurrentEvent.EventUnitState;
        }

        public static gamestate GetEventGameState()
        {
            return TriggerEventSystem.CurrentEvent.EventGameState;
        }
        /// <summary>
        /// （触发事件）被点击的按钮
        /// </summary>
        /// <returns></returns>
        public static button GetClickedButton()
        {
            return TriggerEventSystem.CurrentEvent.ClickedButton;
        }
        /// <summary>
        /// （触发事件）被点击的对话框
        /// </summary>
        /// <returns></returns>
        public static dialog GetClickedDialog()
        {
            return TriggerEventSystem.CurrentEvent.ClickedDialog;
        }

        public static timer GetExpiredTimer()
        {
            return TriggerEventSystem.CurrentEvent.ExpiredTimer;
        }

        public static @string GetSaveBasicFilename()
        {
            return TriggerEventSystem.CurrentEvent.SaveBasicFilename;
        }

        #endregion

        public static void TriggerWaitOnSleeps(trigger whichTrigger, boolean flag)
        {
        }


        public static @event TriggerRegisterVariableEvent(trigger whichTrigger, @string varName, limitop opcode, real limitval)
        {
            throw new NotImplementedException();
        }

        public static @event TriggerRegisterTimerEvent(trigger whichTrigger, real timeout, boolean periodic)
        {
            @event triEvent = new @event() { timerEventTime = timeout, timerEventPeriodic = periodic };
            whichTrigger.events.Add(triEvent);
            return triEvent;
        }

        public static @event TriggerRegisterTimerExpireEvent(trigger whichTrigger, timer t)
        {
            @event triEvent = new @event() { sourceTimer = t };
            whichTrigger.events.Add(triEvent);
            return triEvent;
        }

        public static @event TriggerRegisterGameStateEvent(trigger whichTrigger, gamestate whichState, limitop opcode, real limitval)
        {
            @event triEvent = new @event() { gamestateEvent = whichState };
            whichTrigger.events.Add(triEvent);
            return triEvent;
        }

        public static @event TriggerRegisterDialogEvent(trigger whichTrigger, dialog whichDialog)
        {
            @event triEvent = new @event() { sourceDialog = whichDialog };
            whichTrigger.events.Add(triEvent);
            return triEvent;
        }

        public static @event TriggerRegisterDialogButtonEvent(trigger whichTrigger, button whichButton)
        {
            @event triEvent = new @event() { sourceDialogButton = whichButton };
            whichTrigger.events.Add(triEvent);
            return triEvent;
        }

        public static @event TriggerRegisterGameEvent(trigger whichTrigger, gameevent whichGameEvent)
        {
            throw new NotImplementedException();
        }


        public static @event TriggerRegisterEnterRegion(trigger whichTrigger, region whichRegion, boolexpr filter)
        {
            throw new NotImplementedException();
        }

        public static @event TriggerRegisterLeaveRegion(trigger whichTrigger, region whichRegion, boolexpr filter)
        {
            throw new NotImplementedException();
        }



        public static @event TriggerRegisterTrackableHitEvent(trigger whichTrigger, trackable t)
        {
            @event triEvent = new @event() { sourceTrackable = t };
            whichTrigger.events.Add(triEvent);
            return triEvent;
        }

        public static @event TriggerRegisterTrackableTrackEvent(trigger whichTrigger, trackable t)
        {
            @event triEvent = new @event() { sourceTrackable = t };
            whichTrigger.events.Add(triEvent);
            return triEvent;
        }



        public static @event TriggerRegisterPlayerEvent(trigger whichTrigger, player whichPlayer, playerevent whichPlayerEvent)
        {
            @event triEvent = new @event() { sourcePlayer = whichPlayer, playerEvent = whichPlayerEvent };
            whichTrigger.events.Add(triEvent);
            return triEvent;
        }


        public static @event TriggerRegisterPlayerUnitEvent(trigger whichTrigger, player whichPlayer, playerunitevent whichPlayerUnitEvent, boolexpr filter)
        {
            @event triEvent = new @event() { sourcePlayer = whichPlayer, playerUnitEvent = whichPlayerUnitEvent };
            whichTrigger.events.Add(triEvent);
            return triEvent;
        }

        public static @event TriggerRegisterPlayerStateEvent(trigger whichTrigger, player whichPlayer, playerstate whichState, limitop opcode, real limitval)
        {
            @event triEvent = new @event() { sourcePlayer = whichPlayer, playerStateEvent = whichState };
            whichTrigger.events.Add(triEvent);
            return triEvent;
        }


        public static @event TriggerRegisterPlayerChatEvent(trigger whichTrigger, player whichPlayer, @string chatMessageToDetect, boolean exactMatchOnly)
        {
            @event triEvent = new @event() { sourcePlayer = whichPlayer, chatMatchMessage = chatMessageToDetect, playerEvent = EVENT_PLAYER_CHAT };
            whichTrigger.events.Add(triEvent);
            return triEvent;
        }

        public static @event TriggerRegisterUnitInRange(trigger whichTrigger, unit whichUnit, real range, boolexpr filter)
        {
            throw new NotImplementedException();
        }

        public static @event TriggerRegisterFilterUnitEvent(trigger whichTrigger, unit whichUnit, unitevent whichEvent, boolexpr filter)
        {
            throw new NotImplementedException();
        }

        public static @event TriggerRegisterUnitEvent(trigger whichTrigger, unit whichUnit, unitevent whichEvent)
        {
            @event triEvent = new @event() { unitevent = whichEvent, sourceUnit = whichUnit };
            whichTrigger.events.Add(triEvent);
            return triEvent;
        }

        public static @event TriggerRegisterUnitStateEvent(trigger whichTrigger, unit whichUnit, unitstate whichState, limitop opcode, real limitval)
        {
            @event triEvent = new @event() { sourceUnit = whichUnit, unitStateEvent = opcode };
            whichTrigger.events.Add(triEvent);
            return triEvent;
        }

        public static @event TriggerRegisterDeathEvent(trigger whichTrigger, widget whichWidget)
        {
            @event triEvent = new @event() { unitevent = EVENT_UNIT_DEATH };
            whichTrigger.events.Add(triEvent);
            return triEvent;
        }

        public static @event TriggerRegisterPlayerAllianceChange(trigger whichTrigger, player whichPlayer, alliancetype whichAlliance)
        {
            throw new NotImplementedException();
        }

        public static triggercondition TriggerAddCondition(trigger whichTrigger, boolexpr condition)
        {
            triggercondition addCondition = new triggercondition();
            whichTrigger.conditions.Add(addCondition);
            return addCondition;
        }

        public static void TriggerRemoveCondition(trigger whichTrigger, triggercondition whichCondition)
        {
            whichTrigger.conditions.Remove(whichCondition);
        }

        public static void TriggerClearConditions(trigger whichTrigger)
        {
            whichTrigger.conditions.Clear();
        }
        /// <summary>
        /// 触发器添加动作
        /// </summary>
        /// <param name="whichTrigger"></param>
        /// <param name="actionFunc"></param>
        /// <returns></returns>
        public static triggeraction TriggerAddAction(trigger whichTrigger, code actionFunc)
        {
            triggeraction addAction = new triggeraction() { action = (Action)actionFunc };
            whichTrigger.actions.Add(addAction);
            return addAction;
        }
        public static triggeraction TriggerAddAction(trigger whichTrigger, Action actionFunc)
        {
            triggeraction addAction = new triggeraction() { action = actionFunc };
            whichTrigger.actions.Add(addAction);
            return addAction;
        }

        public static void TriggerRemoveAction(trigger whichTrigger, triggeraction whichAction)
        {
            whichTrigger.actions.Remove(whichAction);
        }

        public static void TriggerClearActions(trigger whichTrigger)
        {
            whichTrigger.actions.Clear();
        }

        public static void TriggerSleepAction(real timeout)
        {
        }

        public static void TriggerWaitForSound(sound s, real offset)
        {
        }

        public static boolean TriggerEvaluate(trigger whichTrigger)
        {
            if (whichTrigger != null) return true;
            else return false;
        }

        public static void TriggerExecute(trigger whichTrigger)
        {
            for (int i = 0; i < whichTrigger.actions.Count; i++)
            {
                whichTrigger.actions[i].Invoke();
            }
        }

        public static void TriggerExecuteWait(trigger whichTrigger)
        {
        }

        public static void TriggerSyncStart()
        {
        }

        public static void TriggerSyncReady()
        {
        }

    }
}
