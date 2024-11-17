using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Custom_Effects
{
    public class DamageFieldEffectBlockedGibsEffect : EffectSO
    {
        [Header("Field")]
        public FieldEffect_SO _Field;

        [DeathTypeEnumRef]
        public string _DeathTypeID = "Basic";

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit)
                {
                    int targetSlotOffset = areTargetSlots ? (targetSlotInfo.SlotID - targetSlotInfo.Unit.SlotID) : (-1);
                    int amount = (!stats.combatSlots.UnitInSlotContainsFieldEffect(targetSlotInfo.SlotID, targetSlotInfo.IsTargetCharacterSlot, _Field.FieldID)) ? entryVariable : 0;
                    amount = caster.WillApplyDamage(amount, targetSlotInfo.Unit);
                    if (amount != 0)
                    {
                        CombatManager.Instance.AddUIAction(new SpawnEnemyGibsUIAction(targetSlotInfo.Unit.ID));
                    }
                    exitAmount += targetSlotInfo.Unit.Damage(amount, caster, _DeathTypeID, targetSlotOffset).damageAmount;
                }
            }

            if (exitAmount > 0)
            {
                caster.DidApplyDamage(exitAmount);
            }

            return exitAmount > 0;
        }
    }
}
