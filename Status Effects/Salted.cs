using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Status_Effects
{
    public class Salted : StatusEffect_SO
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
            if (sender is IUnit u)
            {
                u.IncreaseStatusEffects(2, true);
                u.IncreaseStatusEffects(2, false);
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
            holder.m_ContentMain -= 3;
            if(!TryRemoveStatusEffect(holder, effector) && contentMain != holder.m_ContentMain)
            {
                effector.StatusEffectValuesChanged(_StatusID, holder.m_ContentMain, true);
            }
        }
    }
}
