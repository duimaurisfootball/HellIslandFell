using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Custom_Effects
{
    public class SetStoredManaToColorEffect : EffectSO
    {
        public ManaColorSO[] manaRandomOptions;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            ManaColorSO[] ManaSetRandom = [manaRandomOptions[UnityEngine.Random.Range(0, manaRandomOptions.Length)]];
            exitAmount = stats.MainManaBar.RandomizeAllMana(ManaSetRandom);
            return exitAmount > 0;
        }
    }
}
