using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class ChangeMaxHealthByPreviousEffect : EffectSO
    {
        public bool _increase = true;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            for (int i = 0; i < targets.Length; i++)
            {
                if (targets[i].HasUnit)
                {
                    int num = entryVariable * PreviousExitValue;

                    int newMaxHealth = targets[i].Unit.MaximumHealth + (_increase ? num : (-num));
                    if (targets[i].Unit.MaximizeHealth(newMaxHealth))
                    {
                        exitAmount += num;
                    }
                }
            }

            return exitAmount > 0;
        }
    }
}
