using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    internal class SpecialDamageEffect : EffectSO
    {
        [DeathTypeEnumRef]
        public string _DeathTypeID = "Basic";

        public bool _selfCast = true;

        public bool _usePreviousExitValue;

        public bool _randomBetweenPreviousExitValue;

        public bool _ignoreShield;

        public bool _addHealthMana;

        public bool _direct;

        public bool _returnKillAsSuccess;

        public string _damageType;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            if (_usePreviousExitValue)
            {
                entryVariable *= PreviousExitValue;
            }
            
            exitAmount = 0;
            bool flag = false;
            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit)
                {
                    int targetSlotOffset = areTargetSlots ? (targetSlotInfo.SlotID - targetSlotInfo.Unit.SlotID) : (-1);
                    if (targetSlotInfo.Unit.ContainsStatusEffect(StatusField.OilSlicked.StatusID, 0) && _damageType == CombatType_GameIDs.Dmg_Fire.ToString())
                    {
                        targetSlotInfo.Unit.TryRemoveStatusEffect(StatusField.OilSlicked.StatusID);
                        entryVariable *= 3;
                    }
                    if (targetSlotInfo.Unit.ContainsFieldEffect(StatusField.Constricted.FieldID) && _damageType == "Disappearing_Damage")
                    {
                        continue;
                    }
                    int amount = entryVariable;
                    if (_randomBetweenPreviousExitValue)
                    {
                        amount = UnityEngine.Random.Range(PreviousExitValue, entryVariable);
                    }
                    DamageInfo damageInfo;
                    if (_selfCast)
                    {
                        amount = caster.WillApplyDamage(amount, targetSlotInfo.Unit);
                        damageInfo = targetSlotInfo.Unit.Damage(amount, caster, _DeathTypeID, targetSlotOffset, _addHealthMana, _direct, _ignoreShield, _damageType);
                    }
                    else
                    {
                        damageInfo = targetSlotInfo.Unit.Damage(amount, null, _DeathTypeID, targetSlotOffset, _addHealthMana, _direct, _ignoreShield, _damageType);
                    }
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
