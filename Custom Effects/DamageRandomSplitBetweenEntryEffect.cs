using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class DamageRandomSplitBetweenEntryEffect : EffectSO
    {
        [DeathTypeEnumRef]
        public string _DeathTypeID = "Basic";

        public bool _ignoreShield;

        public bool _indirect;

        public bool _returnKillAsSuccess;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            bool flag = false;
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
                if (targets[i].HasUnit)
                {
                    int targetSlotOffset = areTargetSlots ? (targets[i].SlotID - targets[i].Unit.SlotID) : (-1);
                    int amount = amounts[i];
                    DamageInfo damageInfo;
                    if (_indirect)
                    {
                        damageInfo = targets[i].Unit.Damage(amount, null, _DeathTypeID, targetSlotOffset, addHealthMana: false, directDamage: false, ignoresShield: true);
                    }
                    else
                    {
                        amount = caster.WillApplyDamage(amount, targets[i].Unit);
                        damageInfo = targets[i].Unit.Damage(amount, caster, _DeathTypeID, targetSlotOffset, addHealthMana: true, directDamage: true, _ignoreShield);
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
