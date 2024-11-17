using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class HealByHealthColorExtraEffect : EffectSO
    {
        public bool _usePreviousExitValue;

        public bool _entryAsPercentage;

        public bool _directHeal = true;

        public ManaColorSO _matchingHealthColor;

        public int _extra = 0;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            if (_usePreviousExitValue)
            {
                entryVariable *= PreviousExitValue;
            }

            exitAmount = 0;
            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit && _matchingHealthColor.SharesPigmentColor(targetSlotInfo.Unit.HealthColor))
                {
                    int num = entryVariable + _extra;
                    if (_entryAsPercentage)
                    {
                        num = targetSlotInfo.Unit.CalculatePercentualAmount(num);
                    }

                    if (_directHeal)
                    {
                        num = caster.WillApplyHeal(num, targetSlotInfo.Unit);
                    }

                    exitAmount += targetSlotInfo.Unit.Heal(num, caster, _directHeal);
                }
            }

            return exitAmount > 0;
        }
    }
}
