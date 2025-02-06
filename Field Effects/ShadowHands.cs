using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Field_Effects
{
    public class ShadowHands : FieldEffect_SO
    {
        public override bool IsPositive => false;

        public override bool CanBeRemoved(FieldEffect_Holder holder)
        {
            return true;
        }

        public override void OnTriggerAttached(FieldEffect_Holder holder, IUnit caller)
        {
            CombatManager.Instance.AddObserver(holder.OnEventTriggered_01, TriggerCalls.OnAbilityUsed.ToString(), caller);
            CombatManager.Instance.AddObserver(holder.OnEventTriggered_02, TriggerCalls.OnDamaged.ToString(), caller);
        }

        public override void OnTriggerDettached(FieldEffect_Holder holder, IUnit caller)
        {
            CombatManager.Instance.RemoveObserver(holder.OnEventTriggered_01, TriggerCalls.OnAbilityUsed.ToString(), caller);
            CombatManager.Instance.RemoveObserver(holder.OnEventTriggered_02, TriggerCalls.OnDamaged.ToString(), caller);
        }

        public override void OnSubActionTrigger(FieldEffect_Holder holder, object sender, object args, bool stateCheck)
        {
            CombatManager.Instance.ProcessImmediateAction(new ShadowHandsSwap(sender as IUnit, CombatType_GameIDs.Swap_Mass.ToString()));
        }

        public override void OnSlotEffectorTriggerAttached(FieldEffect_Holder holder)
        {

        }

        public override void OnSlotEffectorTriggerDettached(FieldEffect_Holder holder)
        {

        }

        public override void OnEventCall_01(FieldEffect_Holder holder, object sender, object args)
        {
            CombatManager.Instance.AddSubAction(new PerformSlotStatusEffectAction(holder, sender, args, false));
        }

        public override void OnEventCall_02(FieldEffect_Holder holder, object sender, object args)
        {
            CombatManager.Instance.AddSubAction(new PerformSlotStatusEffectAction(holder, sender, args, false));
            ReduceDuration(holder);
        }
    }
}
