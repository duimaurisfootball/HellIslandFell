using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    internal class TimeTriggers
    {
        public class CombatTimeManager : MonoBehaviour
        {
            public int prevHour = -1;
            public int prevMinute = -1;
            public int prevSecond = -1;

            public void Update()
            {
                DateTime time = DateTime.Now;
                int hour = time.Hour;
                int minute = time.Minute;
                int second = time.Second;

                if (hour == 22 && minute == 38 && prevMinute != 38 && prevMinute != -1)
                {
                    CombatManager.Instance.AddRootAction(new Trigger1038PMAction());
                }

                if (second != prevSecond && prevSecond != -1 && (UnityEngine.Random.Range(0, 8000) < 3))
                {
                    CombatManager.Instance.AddRootAction(new TriggerEverySecondDealAction());
                }

                prevHour = hour;
                prevMinute = minute;
                prevSecond = second;
            }
        }

        public class Trigger1038PMAction : CombatAction
        {
            public const string On1038PM = "Dui_Mauris_Football.HIF_On1038PM";

            public override IEnumerator Execute(CombatStats stats)
            {
                foreach (var ch in stats.CharactersOnField.Values)
                {
                    CombatManager.Instance.PostNotification(On1038PM, ch, null);
                }

                foreach (var en in stats.EnemiesOnField.Values)
                {
                    CombatManager.Instance.PostNotification(On1038PM, en, null);
                }

                yield break;
            }
        }

        public class TriggerEverySecondDealAction : CombatAction
        {
            public const string EverySecondDealChance = "Dui_Mauris_Football.HIF_EverySecondDeal";

            public override IEnumerator Execute(CombatStats stats)
            {
                foreach (var ch in stats.CharactersOnField.Values)
                {
                    CombatManager.Instance.PostNotification(EverySecondDealChance, ch, null);
                }

                foreach (var en in stats.EnemiesOnField.Values)
                {
                    CombatManager.Instance.PostNotification(EverySecondDealChance, en, null);
                }

                yield break;
            }
        }

        public class AddTimeTrackerEffect : EffectSO
        {
            public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
            {
                exitAmount = 0;
                CombatManager.Instance.AddUIAction(new AddTimeTrackerUIAction());

                return true;
            }
        }

        public class AddTimeTrackerUIAction : CombatAction
        {
            public override IEnumerator Execute(CombatStats stats)
            {
                if (CombatManager.Instance.GetComponent<CombatTimeManager>() != null)
                {
                    yield break;
                }

                CombatManager.Instance.gameObject.AddComponent<CombatTimeManager>();
            }
        }
    }
}
