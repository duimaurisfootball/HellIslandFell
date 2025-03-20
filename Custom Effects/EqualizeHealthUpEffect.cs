using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class EqualizeHealthUpEffect : EffectSO
    {
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            int num = 0;
            for (int i = 0; i < targets.Length; i++)
            {
                if (targets[i].HasUnit && targets[i].Unit.IsAlive)
                {
                    if (num == 0)
                    {
                        num = targets[i].Unit.CurrentHealth;
                    }
                    else if (num < targets[i].Unit.CurrentHealth)
                    {
                        num = targets[i].Unit.CurrentHealth;
                    }
                }
            }

            if (num <= 0)
            {
                return false;
            }

            for (int j = 0; j < targets.Length; j++)
            {
                if (targets[j].HasUnit && targets[j].Unit.IsAlive && num > targets[j].Unit.CurrentHealth && targets[j].Unit.SetHealthTo(Math.Min(num, targets[j].Unit.MaximumHealth)))
                {
                    exitAmount++;
                }
            }

            return exitAmount > 0;
        }
    }
}
