using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class FillPigmentBarRandomManaEffect : EffectSO
    {
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = stats.MainManaBar.FillAllPigmentBar([Pigments.Yellow, Pigments.Red, Pigments.Blue, Pigments.Purple]);
            return true;
        }
    }
}
