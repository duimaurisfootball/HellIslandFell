using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class HealRandomSplitBetweenEntryEffect : EffectSO
    {
        public bool entryAsPercentage;

        public bool _directHeal = true;

        public bool _onlyIfHasHealthOver0;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            List<int> amounts = [];

            for (int i = 0; i < targets.Length; i++)
            {
                amounts.Add(0);
            }

            for (int i = 0; i < entryVariable; i++)
            {
                amounts[UnityEngine.Random.Range(0, amounts.Count)]++;
            }

            for (int i = 0; i < targets.Length; i++)
            {
                if (targets[i].HasUnit && (!_onlyIfHasHealthOver0 || targets[i].Unit.CurrentHealth > 0))
                {
                    int num = amounts[i];
                    if (entryAsPercentage)
                    {
                        num = targets[i].Unit.CalculatePercentualAmount(num);
                    }

                    if (_directHeal)
                    {
                        num = caster.WillApplyHeal(num, targets[i].Unit);
                    }

                    exitAmount += targets[i].Unit.Heal(num, caster, _directHeal);
                }
            }

            return exitAmount > 0;
        }
    }
}
