using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Custom_Effects
{
    public class UnboundedDamageEffect : EffectSO
    {
        public string _DeathTypeID = "Basic";

        public bool _ignoreShield;

        public bool _indirect;

        public bool _returnKillAsSuccess;

        public int _cycles = 1;

        public int _repeatChance = 50;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            int ball = entryVariable;
            for (int i = 0; i < _cycles; i++)
            {
                ball += (int)Math.Ceiling(Math.Log(UnityEngine.Random.value) / Math.Log(_repeatChance / 100.0));
            }

            exitAmount = 0;
            bool flag = false;
            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit)
                {
                    int targetSlotOffset = areTargetSlots ? (targetSlotInfo.SlotID - targetSlotInfo.Unit.SlotID) : (-1);
                    int amount = ball;
                    DamageInfo damageInfo;
                    if (_indirect)
                    {
                        damageInfo = targetSlotInfo.Unit.Damage(amount, null, _DeathTypeID, targetSlotOffset, false, false, true);
                    }
                    else
                    {
                        amount = caster.WillApplyDamage(amount, targetSlotInfo.Unit);
                        damageInfo = targetSlotInfo.Unit.Damage(amount, caster, _DeathTypeID, targetSlotOffset, true, true, _ignoreShield);
                    }

                    flag |= damageInfo.beenKilled;
                    exitAmount += damageInfo.damageAmount;
                }
            }

            if (!_indirect && exitAmount > 0)
            {
                caster.DidApplyDamage(exitAmount);
            }

            if (!_returnKillAsSuccess)
            {
                return exitAmount > 0;
            }

            return flag;
        }
    }
}
