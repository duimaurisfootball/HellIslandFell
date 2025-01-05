using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class LuckyBluePercentageChangeEffect : EffectSO
    {
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = entryVariable;
            stats.SetLuckyBluePercentage(stats.LuckyManaPercentage + entryVariable);
            return exitAmount > 0;
        }
    }
}
