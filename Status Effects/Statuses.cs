using BrutalAPI;
using Hell_Island_Fell;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Status_Effects
{
    public class Statuses
    {
        public static void Add()
        {
            if (!LoadedDBsHandler.StatusFieldDB.StatusEffects.ContainsKey("Disappearing_ID"))
            {
                StatusEffectInfoSO DisappearingInfo = ScriptableObject.CreateInstance<StatusEffectInfoSO>();
                DisappearingInfo._statusName = "Disappearing";
                DisappearingInfo._description = "Receive half of Disappearing as damage on turn end.\nHalf of Disappearing is removed at the end of each turn.\nDisappearing damage will be prevented if this party member/enemy is Constricted.";
                DisappearingInfo.icon = ResourceLoader.LoadSprite("Disappearing");

                LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Linked_ID", out StatusEffect_SO linked);
                StatusEffectInfoSO baseinfo = linked.EffectInfo;

                DisappearingInfo._applied_SE_Event = baseinfo._applied_SE_Event;
                DisappearingInfo._removed_SE_Event = baseinfo._removed_SE_Event;
                DisappearingInfo._updated_SE_Event = baseinfo._updated_SE_Event;

                Disappearing disappearing = ScriptableObject.CreateInstance<Disappearing>();
                disappearing._StatusID = "Disappearing_ID";
                disappearing._EffectInfo = DisappearingInfo;

                LoadedDBsHandler.StatusFieldDB.AddNewStatusEffect(disappearing, true);

                IntentInfoBasic DisappearingIntent = new()
                {
                    _color = Color.white,
                    _sprite = ResourceLoader.LoadSprite("Disappearing")
                };
                LoadedDBsHandler.IntentDB.AddNewBasicIntent("Status_Disappearing", DisappearingIntent);

                IntentInfoBasic DisappearingRemIntent = new()
                {
                    _color = Color.gray,
                    _sprite = ResourceLoader.LoadSprite("Disappearing")
                };
                LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Status_Disappearing", DisappearingRemIntent);
            }

            if (!LoadedDBsHandler.StatusFieldDB.StatusEffects.ContainsKey("Salted_ID"))
            {
                StatusEffectInfoSO SaltedInfo = ScriptableObject.CreateInstance<StatusEffectInfoSO>();
                SaltedInfo._statusName = "Salted";
                SaltedInfo._description = "Increase all other status effects on this party member/enemy by 2 on turn end.\n3 Salted is lost at the end of each turn.";
                SaltedInfo.icon = ResourceLoader.LoadSprite("Salted");

                LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Frail_ID", out StatusEffect_SO frail);
                StatusEffectInfoSO baseinfo = frail.EffectInfo;

                SaltedInfo._applied_SE_Event = baseinfo._applied_SE_Event;
                SaltedInfo._removed_SE_Event = baseinfo._removed_SE_Event;
                SaltedInfo._updated_SE_Event = baseinfo._updated_SE_Event;

                Salted salted = ScriptableObject.CreateInstance<Salted>();
                salted._StatusID = "Salted_ID";
                salted._EffectInfo = SaltedInfo;

                LoadedDBsHandler.StatusFieldDB.AddNewStatusEffect(salted, true);

                IntentInfoBasic SaltedIntent = new()
                {
                    _color = Color.white,
                    _sprite = ResourceLoader.LoadSprite("Salted")
                };
                LoadedDBsHandler.IntentDB.AddNewBasicIntent("Status_Salted", SaltedIntent);

                IntentInfoBasic SaltedRemIntent = new()
                {
                    _color = Color.gray,
                    _sprite = ResourceLoader.LoadSprite("Salted")
                };
                LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Status_Salted", SaltedRemIntent);
            }
        }
    }
}
