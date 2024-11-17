using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Field_Effects
{
    public class Thunderstorm : FieldEffect_SO
    {
        public override bool IsPositive => true;

        public override void OnTriggerAttached(FieldEffect_Holder holder, IUnit caller)
        {
            holder.m_ContentMain = caller.SlotID;

            CombatManager.Instance.AddObserver(holder.OnEventTriggered_01, TriggerCalls.OnAbilityUsed.ToString(), caller);
            CombatManager.Instance.AddObserver(holder.OnEventTriggered_02, TriggerCalls.OnDamaged.ToString(), caller);
        }

        public override void OnTriggerDettached(FieldEffect_Holder holder, IUnit caller)
        {
            CombatManager.Instance.AddObserver(holder.OnEventTriggered_01, TriggerCalls.OnAbilityUsed.ToString(), caller);
            CombatManager.Instance.AddObserver(holder.OnEventTriggered_02, TriggerCalls.OnDamaged.ToString(), caller);
        }

        public override void OnSlotEffectorTriggerAttached(FieldEffect_Holder holder)
        {
            
        }

        public override void OnSlotEffectorTriggerDettached(FieldEffect_Holder holder)
        {
            
        }

        public override void OnEventCall_01(FieldEffect_Holder holder, object sender, object args)
        {

        }
    }
}
