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
        public static hashtable InitHashtable()
        {
            return new hashtable();
        }
        #region SaveValue
        public static void SaveInteger(hashtable table, integer parentKey, integer childKey, integer value)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), value);
        }

        public static void SaveReal(hashtable table, integer parentKey, integer childKey, real value)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), value);
        }

        public static void SaveBoolean(hashtable table, integer parentKey, integer childKey, boolean value)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), value);
        }

        public static boolean SaveStr(hashtable table, integer parentKey, integer childKey, @string value)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), value);
            return true;
        }

        public static boolean SavePlayerHandle(hashtable table, integer parentKey, integer childKey, player whichPlayer)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichPlayer);
            return true;
        }

        public static boolean SaveWidgetHandle(hashtable table, integer parentKey, integer childKey, widget whichWidget)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichWidget);
            return true;
        }

        public static boolean SaveDestructableHandle(hashtable table, integer parentKey, integer childKey, destructable whichDestructable)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichDestructable);
            return true;
        }

        public static boolean SaveItemHandle(hashtable table, integer parentKey, integer childKey, item whichItem)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichItem);
            return true;
        }

        public static boolean SaveUnitHandle(hashtable table, integer parentKey, integer childKey, unit whichUnit)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichUnit);
            return true;
        }

        public static boolean SaveAbilityHandle(hashtable table, integer parentKey, integer childKey, ability whichAbility)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichAbility);
            return true;
        }

        public static boolean SaveTimerHandle(hashtable table, integer parentKey, integer childKey, timer whichTimer)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichTimer);
            return true;
        }

        public static boolean SaveTriggerHandle(hashtable table, integer parentKey, integer childKey, trigger whichTrigger)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichTrigger);
            return true;
        }

        public static boolean SaveTriggerConditionHandle(hashtable table, integer parentKey, integer childKey, triggercondition whichTriggercondition)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichTriggercondition);
            return true;
        }

        public static boolean SaveTriggerActionHandle(hashtable table, integer parentKey, integer childKey, triggeraction whichTriggeraction)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichTriggeraction);
            return true;
        }

        public static boolean SaveTriggerEventHandle(hashtable table, integer parentKey, integer childKey, @event whichEvent)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichEvent);
            return true;
        }

        public static boolean SaveForceHandle(hashtable table, integer parentKey, integer childKey, force whichForce)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichForce);
            return true;
        }

        public static boolean SaveGroupHandle(hashtable table, integer parentKey, integer childKey, group whichGroup)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichGroup);
            return true;
        }

        public static boolean SaveLocationHandle(hashtable table, integer parentKey, integer childKey, location whichLocation)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichLocation);
            return true;
        }

        public static boolean SaveRectHandle(hashtable table, integer parentKey, integer childKey, rect whichRect)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichRect);
            return true;
        }

        public static boolean SaveBooleanExprHandle(hashtable table, integer parentKey, integer childKey, boolexpr whichBoolexpr)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichBoolexpr);
            return true;
        }

        public static boolean SaveSoundHandle(hashtable table, integer parentKey, integer childKey, sound whichSound)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichSound);
            return true;
        }

        public static boolean SaveEffectHandle(hashtable table, integer parentKey, integer childKey, effect whichEffect)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichEffect);
            return true;
        }

        public static boolean SaveUnitPoolHandle(hashtable table, integer parentKey, integer childKey, unitpool whichUnitpool)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichUnitpool);
            return true;
        }

        public static boolean SaveItemPoolHandle(hashtable table, integer parentKey, integer childKey, itempool whichItempool)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichItempool);
            return true;
        }

        public static boolean SaveQuestHandle(hashtable table, integer parentKey, integer childKey, quest whichQuest)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichQuest);
            return true;
        }

        public static boolean SaveQuestItemHandle(hashtable table, integer parentKey, integer childKey, questitem whichQuestitem)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichQuestitem);
            return true;
        }

        public static boolean SaveDefeatConditionHandle(hashtable table, integer parentKey, integer childKey, defeatcondition whichDefeatcondition)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichDefeatcondition);
            return true;
        }

        public static boolean SaveTimerDialogHandle(hashtable table, integer parentKey, integer childKey, timerdialog whichTimerdialog)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichTimerdialog);
            return true;
        }

        public static boolean SaveLeaderboardHandle(hashtable table, integer parentKey, integer childKey, leaderboard whichLeaderboard)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichLeaderboard);
            return true;
        }

        public static boolean SaveMultiboardHandle(hashtable table, integer parentKey, integer childKey, multiboard whichMultiboard)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichMultiboard);
            return true;
        }

        public static boolean SaveMultiboardItemHandle(hashtable table, integer parentKey, integer childKey, multiboarditem whichMultiboarditem)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichMultiboarditem);
            return true;
        }

        public static boolean SaveTrackableHandle(hashtable table, integer parentKey, integer childKey, trackable whichTrackable)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichTrackable);
            return true;
        }

        public static boolean SaveDialogHandle(hashtable table, integer parentKey, integer childKey, dialog whichDialog)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichDialog);
            return true;
        }

        public static boolean SaveButtonHandle(hashtable table, integer parentKey, integer childKey, button whichButton)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichButton);
            return true;
        }

        public static boolean SaveTextTagHandle(hashtable table, integer parentKey, integer childKey, texttag whichTexttag)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichTexttag);
            return true;
        }

        public static boolean SaveLightningHandle(hashtable table, integer parentKey, integer childKey, lightning whichLightning)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichLightning);
            return true;
        }

        public static boolean SaveImageHandle(hashtable table, integer parentKey, integer childKey, image whichImage)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichImage);
            return true;
        }

        public static boolean SaveUbersplatHandle(hashtable table, integer parentKey, integer childKey, ubersplat whichUbersplat)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichUbersplat);
            return true;
        }

        public static boolean SaveRegionHandle(hashtable table, integer parentKey, integer childKey, region whichRegion)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichRegion);
            return true;
        }

        public static boolean SaveFogStateHandle(hashtable table, integer parentKey, integer childKey, fogstate whichFogState)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichFogState);
            return true;
        }

        public static boolean SaveFogModifierHandle(hashtable table, integer parentKey, integer childKey, fogmodifier whichFogModifier)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichFogModifier);
            return true;
        }

        public static boolean SaveAgentHandle(hashtable table, integer parentKey, integer childKey, agent whichAgent)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichAgent);
            return true;
        }

        public static boolean SaveHashtableHandle(hashtable table, integer parentKey, integer childKey, hashtable whichHashtable)
        {
            table.Add(parentKey.ToString("x8") + childKey.ToString("x8"), whichHashtable);
            return true;
        }

        #endregion

        #region LoadValue
        public static integer LoadInteger(hashtable table, integer parentKey, integer childKey)
        {
            return (int)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static real LoadReal(hashtable table, integer parentKey, integer childKey)
        {
            return (real)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static boolean LoadBoolean(hashtable table, integer parentKey, integer childKey)
        {
            return (boolean)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static @string LoadStr(hashtable table, integer parentKey, integer childKey)
        {
            return (@string)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static player LoadPlayerHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (player)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static widget LoadWidgetHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (widget)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static destructable LoadDestructableHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (destructable)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static item LoadItemHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (item)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static unit LoadUnitHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (unit)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static ability LoadAbilityHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (ability)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static timer LoadTimerHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (timer)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static trigger LoadTriggerHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (trigger)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static triggercondition LoadTriggerConditionHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (triggercondition)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static triggeraction LoadTriggerActionHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (triggeraction)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static @event LoadTriggerEventHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (@event)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static force LoadForceHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (force)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static group LoadGroupHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (group)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static location LoadLocationHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (location)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static rect LoadRectHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (rect)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static boolexpr LoadBooleanExprHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (boolexpr)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static sound LoadSoundHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (sound)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static effect LoadEffectHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (effect)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static unitpool LoadUnitPoolHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (unitpool)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static itempool LoadItemPoolHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (itempool)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static quest LoadQuestHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (quest)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static questitem LoadQuestItemHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (questitem)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static defeatcondition LoadDefeatConditionHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (defeatcondition)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static timerdialog LoadTimerDialogHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (timerdialog)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static leaderboard LoadLeaderboardHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (leaderboard)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static multiboard LoadMultiboardHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (multiboard)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static multiboarditem LoadMultiboardItemHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (multiboarditem)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static trackable LoadTrackableHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (trackable)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static dialog LoadDialogHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (dialog)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static button LoadButtonHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (button)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static texttag LoadTextTagHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (texttag)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static lightning LoadLightningHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (lightning)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static image LoadImageHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (image)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static ubersplat LoadUbersplatHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (ubersplat)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static region LoadRegionHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (region)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static fogstate LoadFogStateHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (fogstate)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static fogmodifier LoadFogModifierHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (fogmodifier)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        public static hashtable LoadHashtableHandle(hashtable table, integer parentKey, integer childKey)
        {
            return (hashtable)table[parentKey.ToString("x8") + childKey.ToString("x8")];
        }

        #endregion

        public static boolean HaveSavedInteger(hashtable table, integer parentKey, integer childKey)
        {
            if (table.Contains(parentKey.ToString("x8") + childKey.ToString("x8"))) return true;
            else return false;
        }

        public static boolean HaveSavedReal(hashtable table, integer parentKey, integer childKey)
        {
            if (table.Contains(parentKey.ToString("x8") + childKey.ToString("x8"))) return true;
            else return false;
        }

        public static boolean HaveSavedBoolean(hashtable table, integer parentKey, integer childKey)
        {
            if (table.Contains(parentKey.ToString("x8") + childKey.ToString("x8"))) return true;
            else return false;
        }

        public static boolean HaveSavedString(hashtable table, integer parentKey, integer childKey)
        {
            if (table.Contains(parentKey.ToString("x8") + childKey.ToString("x8"))) return true;
            else return false;
        }

        public static boolean HaveSavedHandle(hashtable table, integer parentKey, integer childKey)
        {
            if (table.Contains(parentKey.ToString("x8") + childKey.ToString("x8"))) return true;
            else return false;
        }

        public static void RemoveSavedInteger(hashtable table, integer parentKey, integer childKey)
        {
            table.Remove(parentKey.ToString("x8") + childKey.ToString("x8"));
        }

        public static void RemoveSavedReal(hashtable table, integer parentKey, integer childKey)
        {
            table.Remove(parentKey.ToString("x8") + childKey.ToString("x8"));
        }

        public static void RemoveSavedBoolean(hashtable table, integer parentKey, integer childKey)
        {
            table.Remove(parentKey.ToString("x8") + childKey.ToString("x8"));
        }

        public static void RemoveSavedString(hashtable table, integer parentKey, integer childKey)
        {
            table.Remove(parentKey.ToString("x8") + childKey.ToString("x8"));
        }

        public static void RemoveSavedHandle(hashtable table, integer parentKey, integer childKey)
        {
            table.Remove(parentKey.ToString("x8") + childKey.ToString("x8"));
        }

        public static void FlushParentHashtable(hashtable table)
        {
            table.Clear();
        }

        public static void FlushChildHashtable(hashtable table, integer parentKey)
        {
        }

    }
}
