using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Status_Effects
{
    public class Disappearing : StatusEffect_SO
    {
        public override bool IsPositive => false;

        public override void OnTriggerAttached(StatusEffect_Holder holder, IStatusEffector caller)
        {
            holder.m_ObjectData = caller;

            CombatManager.Instance.AddObserver(holder.OnEventTriggered_01, TriggerCalls.OnTurnFinished.ToString(), caller);
        }

        public override void OnTriggerDettached(StatusEffect_Holder holder, IStatusEffector caller)
        {
            CombatManager.Instance.RemoveObserver(holder.OnEventTriggered_01, TriggerCalls.OnTurnFinished.ToString(), caller);
        }

        public override void OnEventCall_01(StatusEffect_Holder holder, object sender, object args)
        {
            // Check if the event sender is actually a unit (should always be true but its nice to be safe)
            if (sender is IUnit u)
            {
                var isConstricted = false;

                // Iterate through all unit slots
                for (int i = 0; i < u.Size; i++)
                {
                    // If slot is not constricted, ignore this 
                    if (!CombatManager.Instance._stats.combatSlots.UnitInSlotContainsFieldEffect(u.SlotID + i, u.IsUnitCharacter, StatusField.Constricted.FieldID))
                    {
                        continue;
                    }

                    // Otherwise, register the unit as constricted and skip the rest of the slots (its already known that the unit is constricted)
                    isConstricted = true;
                    break;
                }
                var dmg = 0;
                // Dont do damage if constricted
                if (!isConstricted)
                {
                    // Calculate the damage that will be dealt
                    dmg = Mathf.CeilToInt(holder.m_ContentMain / 2f);
                }
                // Damage the unit
                u.Damage(dmg, null, DeathType_GameIDs.Basic.ToString(), -1, true, true, false, "Disappearing_Damage");
            }
            ReduceDuration(holder, sender as IStatusEffector);
        }

        public override void ReduceDuration(StatusEffect_Holder holder, IStatusEffector effector)
        {
            if (!CanReduceDuration)
            {
                return;
            }

            int contentMain = holder.m_ContentMain;
            holder.m_ContentMain /= 2;
            if (!TryRemoveStatusEffect(holder, effector) && contentMain != holder.m_ContentMain)
            {
                effector.StatusEffectValuesChanged(_StatusID, holder.m_ContentMain - contentMain, true);
            }
        }
    }
}
