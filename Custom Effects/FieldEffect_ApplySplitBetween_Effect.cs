using Hell_Island_Fell.Field_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class FieldEffect_ApplySplitBetween_Effect : EffectSO
    {
        public FieldEffect_SO _Field;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            List<int> amounts = [];

            for (int i = 0; i < targets.Length; i++)
            {
                amounts.Add(0);
            }

            for (int i = 0; i < entryVariable; i++)
            {
                amounts[UnityEngine.Random.Range(0, amounts.Count)]++;
            }

            for (int i = 0; i < targets.Length; i++)
            {
                exitAmount += ApplyFieldEffect(stats, targets[i], amounts[i]);
            }
            return exitAmount > 0;
        }
        public int ApplyFieldEffect(CombatStats stats, TargetSlotInfo target, int entryVariable)
        {
            int num = entryVariable;
            if (num < _Field.MinimumRequiredToApply)
            {
                return 0;
            }

            if (!stats.combatSlots.ApplyFieldEffect(target.SlotID, target.IsTargetCharacterSlot, _Field, num))
            {
                return 0;
            }

            return num;
        }
    }
}
