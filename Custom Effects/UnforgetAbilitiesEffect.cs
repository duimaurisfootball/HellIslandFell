using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class UnforgetAbilitiesEffect : EffectSO
    {
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            foreach (var target in targets)
            {
                target.Unit.UnforgetAbilities();
                exitAmount++;
            }
            return exitAmount > 0;
        }
    }
}
