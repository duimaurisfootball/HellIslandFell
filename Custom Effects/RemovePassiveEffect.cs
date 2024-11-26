using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class RemovePassiveEffect : EffectSO
    {
        public BasePassiveAbilitySO _passiveToRemove;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit && targetSlotInfo.Unit.TryRemovePassiveAbility(_passiveToRemove.m_PassiveID))
                {
                    exitAmount++;
                }
            }
            return exitAmount > 0;
        }
    }
}
