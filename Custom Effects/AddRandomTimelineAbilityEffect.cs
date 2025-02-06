using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class AddRandomTimelineAbilityEffect : EffectSO
    {
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            List<TargetSlotInfo> list = [];
            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit && targetSlotInfo.Unit.AbilityCount != 0)
                {
                    list.Add(targetSlotInfo);
                }
            }

            if (list.Count <= 0)
            {
                return false;
            }

            for (int i = 0; i < entryVariable; i++)
            {
                int index = UnityEngine.Random.Range(0, list.Count);
                TargetSlotInfo targetSlotInfo2 = list[index];
                int targetSlotOffset = areTargetSlots ? (targetSlotInfo2.SlotID - targetSlotInfo2.Unit.SlotID) : (-1);

                if (targetSlotInfo2.HasUnit && !targetSlotInfo2.IsTargetCharacterSlot)
                {
                    EnemyCombat unit = stats.TryGetEnemyOnField(targetSlotInfo2.Unit.ID);
                    stats.timeline.TryAddNewExtraEnemyTurns(unit, 1);
                    exitAmount++;
                }
            }

            return exitAmount > 0;
        }
    }
}
