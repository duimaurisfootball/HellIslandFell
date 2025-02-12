using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class UnboundedVariableForNextPreviousAsCyclesEffect : EffectSO
    {
        public int _cycleMultiplier = 1;

        public int _repeatChance = 50;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            int ball = entryVariable;
            for (int i = 0; i < _cycleMultiplier * PreviousExitValue; i++)
            {
                ball += (int)Math.Ceiling(Math.Log(UnityEngine.Random.value) / Math.Log(_repeatChance / 100.0));
            }
            exitAmount = ball;
            return exitAmount > PreviousExitValue;
        }
    }
}
