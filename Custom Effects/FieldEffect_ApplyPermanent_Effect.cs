using Hell_Island_Fell.Field_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class FieldEffect_ApplyPermanent_Effect : EffectSO
    {
        public FieldEffect_SO _Field;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            if (_Field == null)
            {
                return false;
            }

            for (int i = 0; i < targets.Length; i++)
            {
                exitAmount += ApplyFieldEffect(stats, targets[i], entryVariable);
            }

            return exitAmount > 0;
        }

        public int ApplyFieldEffect(CombatStats stats, TargetSlotInfo target, int entryVariable)
        {
            if (entryVariable < _Field.MinimumRequiredToApply)
            {
                return 0;
            }

            for (int i = 0; i < entryVariable; i++)
            {
                if (!stats.combatSlots.ApplyFieldEffect(target.SlotID, target.IsTargetCharacterSlot, _Field, 0, 1))
                {
                    return 0;
                }
            }

            return entryVariable;
        }
    }
}
