using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class LeftmostEffect : EffectSO
    {
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            CombatSlot LeftSlot = CombatManager.Instance._stats.combatSlots.EnemySlots[0];
            if (LeftSlot.HasUnit && LeftSlot.Unit == caster)
            {
                exitAmount = 1;
                return true;
            }
            return false;
        }
    }
}
