﻿using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Custom_Effects
{
    public class FieldEffect_Apply_AddPrevious_Effect : EffectSO
    {
        [Header("Field")]
        public FieldEffect_SO _Field;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            if (_Field == null)
            {
                return false;
            }

            entryVariable += PreviousExitValue;
            

            for (int i = 0; i < targets.Length; i++)
            {
                exitAmount += ApplyFieldEffect(stats, targets[i], entryVariable);
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
