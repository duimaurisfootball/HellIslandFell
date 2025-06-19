using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class HealSharedHealthColorsEffect : EffectSO
    {
        public int minShared = 1;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            Dictionary<ManaColorSO, List<TargetSlotInfo>> matchingColors = [];

            foreach (TargetSlotInfo targetSlot in targets)
            {
                if (targetSlot.HasUnit)
                {
                    if (!matchingColors.ContainsKey(targetSlot.Unit.HealthColor))
                    {
                        matchingColors.Add(targetSlot.Unit.HealthColor, [targetSlot]);
                    }
                    else
                    {
                        matchingColors[targetSlot.Unit.HealthColor].Add(targetSlot);
                    }
                }
            }

            int num = entryVariable;
            foreach (List<TargetSlotInfo> targetList in matchingColors.Values)
            {
                if (targetList.Count > minShared)
                {
                    foreach (TargetSlotInfo targetSlot in targetList)
                    {
                        num = caster.WillApplyHeal(num, targetSlot.Unit);
                        exitAmount += targetSlot.Unit.Heal(num, caster, true);
                    }
                }
            }

            return exitAmount > 0;
        }
    }
}
