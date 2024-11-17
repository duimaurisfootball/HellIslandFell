using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class RefreshAbilityUsageByStatusEffectEffect : EffectSO
    {
        public StatusEffect_SO _status;

        public int _chance;

        public bool _doesExhaustInstead = false;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            if (_status == null)
            {
                return false;
            }

            for (int i = 0; i < targets.Length; i++)
            {
                if (targets[i].HasUnit && targets[i].Unit.ContainsStatusEffect(_status.StatusID, entryVariable) && UnityEngine.Random.Range(0, 101) <= _chance)
                {
                    if (_doesExhaustInstead ? targets[i].Unit.ExhaustAbilityUse() : targets[i].Unit.RefreshAbilityUse())
                    {
                        exitAmount++;
                    }
                }
            }

            return exitAmount > 0;
        }
    }
}
