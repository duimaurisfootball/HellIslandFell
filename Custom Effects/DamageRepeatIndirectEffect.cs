using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class DamageRepeatIndirectEffect : EffectSO
    {
        [DeathTypeEnumRef]
        public string _DeathTypeID = "Basic";

        public bool _usePreviousExitValue;

        public bool _ignoreShield;

        public bool _returnKillAsSuccess;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            if (_usePreviousExitValue)
            {
                entryVariable *= PreviousExitValue;
            }

            exitAmount = 0;
            bool flag = false;
            Dictionary<TargetSlotInfo, int> damageList = [];
            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit)
                {
                    int targetSlotOffset = areTargetSlots ? (targetSlotInfo.SlotID - targetSlotInfo.Unit.SlotID) : (-1);
                    int amount = entryVariable;
                    DamageInfo damageInfo;
                    amount = caster.WillApplyDamage(amount, targetSlotInfo.Unit);
                    damageInfo = targetSlotInfo.Unit.Damage(amount, caster, _DeathTypeID, targetSlotOffset, true, true, _ignoreShield);
                    flag |= damageInfo.beenKilled;
                    exitAmount += damageInfo.damageAmount;
                    damageList.Add(targetSlotInfo, amount);
                }
            }

            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit)
                {
                    int targetSlotOffset = areTargetSlots ? (targetSlotInfo.SlotID - targetSlotInfo.Unit.SlotID) : (-1);
                    int amount = damageList[targetSlotInfo];
                    DamageInfo damageInfo;
                    amount = caster.WillApplyDamage(amount, targetSlotInfo.Unit);
                    damageInfo = targetSlotInfo.Unit.Damage(amount, null, _DeathTypeID, targetSlotOffset, false, false, true);
                    flag |= damageInfo.beenKilled;
                    exitAmount += damageInfo.damageAmount;
                }
            }

            if (exitAmount > 0)
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
