using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Custom_Effects
{
    public class DamageRandomBetweenTargetsEffect : EffectSO
    {
        public int _numberTargets = 1;

        public string _DeathTypeID = "Basic";

        public bool _usePreviousExitValue;

        public bool _ignoreShield;

        public bool _indirect;

        public bool _returnKillAsSuccess;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;

            List<TargetSlotInfo> ofTargets = [];
            List<TargetSlotInfo> toTargets = [];
            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                ofTargets.Add(targetSlotInfo);
            }

            for (int i = 0; i < _numberTargets; i++)
            {
                if (ofTargets.Count > 0)
                {
                    int index = UnityEngine.Random.Range(0, ofTargets.Count);
                    toTargets.Add(ofTargets[index]);
                    ofTargets.RemoveAt(index);
                }
            }

            bool flag = false;
            foreach (TargetSlotInfo targetSlotInfo in toTargets)
            {
                if (targetSlotInfo.HasUnit)
                {
                    int targetSlotOffset = areTargetSlots ? (targetSlotInfo.SlotID - targetSlotInfo.Unit.SlotID) : (-1);
                    int amount = entryVariable;
                    DamageInfo damageInfo;
                    if (_indirect)
                    {
                        damageInfo = targetSlotInfo.Unit.Damage(amount, null, _DeathTypeID, targetSlotOffset, addHealthMana: false, directDamage: false, ignoresShield: true);
                    }
                    else
                    {
                        amount = caster.WillApplyDamage(amount, targetSlotInfo.Unit);
                        damageInfo = targetSlotInfo.Unit.Damage(amount, caster, _DeathTypeID, targetSlotOffset, addHealthMana: true, directDamage: true, _ignoreShield);
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

            return exitAmount > 0;
        }
    }
}
