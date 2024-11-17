using System;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

namespace Hell_Island_Fell.Custom_Effects
{
    public class EntryToExitPercentageEffect : EffectSO
    {
        public int _Denominator = 100;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = Mathf.FloorToInt(PreviousExitValue * entryVariable / _Denominator);
            return true;
        }
    }
}
