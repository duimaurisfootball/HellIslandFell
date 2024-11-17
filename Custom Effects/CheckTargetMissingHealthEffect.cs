using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Custom_Effects
{
    public class CheckTargetMissingHealthEffect : EffectSO
    {
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;

            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit)
                {
                    exitAmount = targetSlotInfo.Unit.MaximumHealth - targetSlotInfo.Unit.CurrentHealth;

                    return targetSlotInfo.Unit.CurrentHealth / (float)targetSlotInfo.Unit.MaximumHealth <= entryVariable / 100f;
                }
            }
            
            return false;
        }
    }
}