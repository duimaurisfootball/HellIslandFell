using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class RemovePercentageStatusEffectEffect : EffectSO
    {
        public StatusEffect_SO _status;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            if (_status == null)
            {
                return false;
            }

            for (int i = 0; i < targets.Length; i++)
            {
                if (targets[i].HasUnit)
                {
                    exitAmount += targets[i].Unit.TryRemoveStatusEffect(_status.StatusID);
                }
            }

            return exitAmount > 0;
        }
    }
}
