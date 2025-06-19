using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class HealOnColorCascadeEffect : EffectSO
    {
        public int _cascadeDecrease = 1;

        public bool _usePreviousExitValue;

        public bool _directHeal = true;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            if (_usePreviousExitValue)
            {
                entryVariable *= PreviousExitValue;
            }

            exitAmount = 0;
            int num = entryVariable;
            List<ManaColorSO> touchedColors = [];
            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (!targetSlotInfo.HasUnit)
                {
                    break;
                }

                if (touchedColors.Contains(targetSlotInfo.Unit.HealthColor))
                {
                    break;
                }

                touchedColors.Add(targetSlotInfo.Unit.HealthColor);

                if (_directHeal)
                {
                    num = caster.WillApplyHeal(num, targetSlotInfo.Unit);
                }

                exitAmount += targetSlotInfo.Unit.Heal(num, caster, _directHeal);
                num -= _cascadeDecrease;
                if (num <= 0)
                {
                    break;
                }
            }

            return exitAmount > 0;
        }
    }
}
