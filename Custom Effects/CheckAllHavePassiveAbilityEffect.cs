using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class CheckAllHavePassiveAbilityEffect : EffectSO
    {
        [PassiveIDsEnumRef]
        public string m_PassiveID = "Decay";

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit && !targetSlotInfo.Unit.ContainsPassiveAbility(m_PassiveID))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
