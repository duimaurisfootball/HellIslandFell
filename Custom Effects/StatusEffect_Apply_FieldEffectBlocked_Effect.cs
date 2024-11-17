using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Custom_Effects
{
    public class StatusEffect_Apply_FieldEffectBlocked_Effect : EffectSO
    {
        public StatusEffect_SO _Status;

        public FieldEffect_SO _Field;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            if (_Status == null)
            {
                return false;
            }

            for (int j = 0; j < targets.Length; j++)
            {
                if (targets[j].HasUnit && !stats.combatSlots.UnitInSlotContainsFieldEffect(targets[j].SlotID, targets[j].IsTargetCharacterSlot, _Field.FieldID))
                {
                    exitAmount += ApplyStatusEffect(targets[j].Unit, entryVariable);
                }
            }

            return exitAmount > 0;
        }
        public int ApplyStatusEffect(IUnit unit, int entryVariable)
        {
            int num = entryVariable;
            if (num < _Status.MinimumRequiredToApply)
            {
                return 0;
            }

            if (!unit.ApplyStatusEffect(_Status, num))
            {
                return 0;
            }

            return Mathf.Max(1, num);
        }
    }
}
