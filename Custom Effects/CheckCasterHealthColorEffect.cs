using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class CheckCasterHealthColorEffect : EffectSO
    {
        public ManaColorSO _color;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            if (caster.HealthColor == _color)
            {
                exitAmount++;
            }
            return exitAmount > 0;
        }
    }
}
