using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Custom_Effects
{
    public class PendulumDamage : EffectSO
    {
        public string _valueNameTop = "";

        public string _valueNameBottom = "";

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit)
                {
                    int targetSlotOffset = areTargetSlots ? (targetSlotInfo.SlotID - targetSlotInfo.Unit.SlotID) : (-1);

                    caster.TryGetStoredData(_valueNameTop, out var Top);
                    caster.TryGetStoredData(_valueNameBottom, out var Bottom);

                    int topDamage = entryVariable + Top.m_MainData;
                    int bottomDamage = PreviousExitValue - Bottom.m_MainData;

                    if (bottomDamage < 0)
                    {
                        bottomDamage = 0;
                    }

                    int amount = UnityEngine.Random.Range(bottomDamage, topDamage + 1);
                    DamageInfo damageInfo;
                    {
                        amount = caster.WillApplyDamage(amount, targetSlotInfo.Unit);
                        damageInfo = targetSlotInfo.Unit.Damage(amount, caster, "Basic", targetSlotOffset, addHealthMana: true, directDamage: true);
                    }

                    exitAmount += damageInfo.damageAmount;
                }
            }
            return exitAmount > 0;
        }
    }
}
