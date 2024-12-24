using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class CheckCasterNotHealthColorsEffect : EffectSO
    {
        public ManaColorSO[] _colors;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            for (var i = 0; i < _colors.Length; i++)
            {
                if (caster.HealthColor != _colors[i])
                {
                    exitAmount++;
                }
            }
            return exitAmount >= _colors.Length;
        }
    }
}
