using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

namespace Hell_Island_Fell.Custom_Effects
{
    public class HoftstoldtDamageEffect : EffectSO
    {
        [DeathTypeEnumRef]
        public string _DeathTypeID = "Basic";

        public bool _usePreviousExitValue;

        public bool _ignoreShield;

        public bool _indirect;

        public bool _returnKillAsSuccess;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            if (_usePreviousExitValue)
            {
                entryVariable *= PreviousExitValue;
            }

            TargetSlotInfo[] enemies = Targeting.GenerateSlotTarget([-4, -3, -2, -1, 0, 1, 2, 3, 4], false).GetTargets(stats.combatSlots, caster.SlotID, caster.IsUnitCharacter);
            TargetSlotInfo[] allies = Targeting.GenerateSlotTarget([-4, -3, -2, -1, 0, 1, 2, 3, 4], true).GetTargets(stats.combatSlots, caster.SlotID, caster.IsUnitCharacter);

            exitAmount = 0;
            bool flag = false;
            for (int i = 0; i < enemies.Length; i++)
            {
                if (allies[i].HasUnit && allies[i].Unit.ContainsPassiveAbility(Passives.Construct.m_PassiveID) && enemies[i].HasUnit)
                {
                    int targetSlotOffset = areTargetSlots ? (enemies[i].SlotID - enemies[i].Unit.SlotID) : (-1);
                    int amount = entryVariable;
                    DamageInfo damageInfo;
                    if (_indirect)
                    {
                        damageInfo = enemies[i].Unit.Damage(amount, null, _DeathTypeID, targetSlotOffset, addHealthMana: false, directDamage: false, ignoresShield: true);
                    }
                    else
                    {
                        amount = caster.WillApplyDamage(amount, enemies[i].Unit);
                        damageInfo = enemies[i].Unit.Damage(amount, caster, _DeathTypeID, targetSlotOffset, addHealthMana: true, directDamage: true, _ignoreShield);
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


            return true;
        }
    }
}