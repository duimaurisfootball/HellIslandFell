using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    [HarmonyPatch]
    public class TurnEndAfterItemsTriggerPatch
    {
        public const string OnTurnFinishedAfterItems = "Dui_Mauris_Football.HIF_TurnEndAfterItemsTrigger";

        [HarmonyPatch(typeof(PlayerTurnEndSecondPartAction), nameof(PlayerTurnEndSecondPartAction.Execute))]
        [HarmonyPostfix]
        public static IEnumerator TriggerPostItemTrigger(IEnumerator enumerator)
        {
            foreach (KeyValuePair<int, CharacterCombat> u in CombatManager.Instance._stats.Characters)
            {
                CombatManager.Instance.PostNotification(OnTurnFinishedAfterItems, u.Value, null);
            }

            yield return enumerator;
        }

        [HarmonyPatch(typeof(EnemyCombat), nameof(EnemyCombat.EnemyTurnEnd))]
        [HarmonyPostfix]
        public static void TriggerCustomTurnEnd_Enemy(EnemyCombat __instance)
        {
            CombatManager.Instance.PostNotification(OnTurnFinishedAfterItems, __instance, null);
        }
    }
}
