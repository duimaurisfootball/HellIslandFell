using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class FieldEffect_ApplyByChance_Effect : EffectSO
    {
        [Header("Field")]
        public FieldEffect_SO _Field;

        [Header("Previous Random Option Data")]
        public bool _UseRandomBetweenPrevious;

        [Header("Previous Multiplier Option Data")]
        public bool _UsePreviousExitValueAsMultiplier;

        public int _PreviousExtraAddition;

        public int _Chance = 50;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            if (_Field == null)
            {
                return false;
            }

            if (_UsePreviousExitValueAsMultiplier)
            {
                entryVariable = _PreviousExtraAddition + (entryVariable * PreviousExitValue);
            }

            for (int i = 0; i < targets.Length; i++)
            {
                if (UnityEngine.Random.Range(0, 101) <= _Chance)
                {
                    exitAmount += ApplyFieldEffect(stats, targets[i], entryVariable);
                }
            }

            return exitAmount > 0;
        }

        public int ApplyFieldEffect(CombatStats stats, TargetSlotInfo target, int entryVariable)
        {
            int num = _UseRandomBetweenPrevious ? UnityEngine.Random.Range(PreviousExitValue, entryVariable + 1) : entryVariable;
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
