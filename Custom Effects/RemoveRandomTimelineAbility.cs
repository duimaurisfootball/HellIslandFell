using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class RemoveRandomTimelineAbility : EffectSO
    {
        public static int TryRemoveRandomAnyTurns (Timeline_Base self, int turnsToRemove)
        {
            if (self.Round.Count == 0)
            {
                return 0;
            }

            List<int> list = [];
            for (int i = self.CurrentTurn + 1; i < self.Round.Count; i++)
            {
                list.Add(i);
            }

            List<int> list2 = [];
            int num = 0;
            while (turnsToRemove > 0 && list.Count > 0)
            {
                int index = UnityEngine.Random.Range(0, list.Count);
                list2.Add(list[index]);
                list.RemoveAt(index);
                num++;
                turnsToRemove--;
            }

            list2.Sort();
            list2.Reverse();
            foreach (int item in list2)
            {
                self.Round.RemoveAt(item);
            }

            if (list2.Count > 0)
            {
                CombatManager.Instance.AddUIAction(new RemoveSlotTimelineUIAction([.. list2]));
                CombatManager.Instance.AddUIAction(new UpdateTimelinePointerUIAction(self.CurrentTurn));
            }

            return num;
        }
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = TryRemoveRandomAnyTurns(stats.timeline, entryVariable);
            return exitAmount > 0;
        }
    }
}
