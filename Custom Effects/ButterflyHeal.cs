using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Custom_Effects
{
    public class ButterflyHeal : EffectSO
    {
        public bool _directHeal = true;

        public string _valueNameTop = "";

        public string _valueNameBottom = "";

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;

            caster.TryGetStoredData(_valueNameTop, out var Top);
            caster.TryGetStoredData(_valueNameBottom, out var Bottom);

            int topHeal = entryVariable + Top.m_MainData;
            int bottomHeal = PreviousExitValue - Bottom.m_MainData;

            if (bottomHeal < 0)
            {
                bottomHeal = 0;
            }

            for (int i = 0; i < targets.Length; i++)
            {
                if (targets[i].HasUnit)
                {
                    int amount = UnityEngine.Random.Range(bottomHeal, topHeal + 1);
                    exitAmount += targets[i].Unit.Heal(amount, caster, _directHeal);
                }
            }

            return exitAmount > 0;
        }
    }
}

