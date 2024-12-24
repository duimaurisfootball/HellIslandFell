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

            CombatManager.Instance.AddObserver(holder.OnEventTriggered_01, TriggerCalls.OnWillApplyDamage.ToString(), caller);
            CombatManager.Instance.AddObserver(holder.OnEventTriggered_02, TriggerCalls.OnBeingDamaged.ToString(), caller);
        }

        public override void OnTriggerDettached(FieldEffect_Holder holder, IUnit caller)
        {
            CombatManager.Instance.AddObserver(holder.OnEventTriggered_01, TriggerCalls.OnWillApplyDamage.ToString(), caller);
            CombatManager.Instance.AddObserver(holder.OnEventTriggered_02, TriggerCalls.OnBeingDamaged.ToString(), caller);
        }

        public override void OnSlotEffectorTriggerAttached(FieldEffect_Holder holder)
        {
            
        }

        public override void OnSlotEffectorTriggerDettached(FieldEffect_Holder holder)
        {
            
        }

        public override void OnEventCall_01(FieldEffect_Holder holder, object sender, object args)
        {
            if (args is DamageDealtValueChangeException context)
            {
                context.AddModifier(new StormValueModifierDealt(true, holder.m_ContentMain));
            }
        }

        public override void OnEventCall_02(FieldEffect_Holder holder, object sender, object args)
        {
            if (args is DamageReceivedValueChangeException context && context.directDamage)
            {
                context.AddModifier(new StormValueModifierReceived(holder.m_ContentMain));
            }
        }
    }
    public class StormValueModifierDealt(bool dmgDealt, int toStorm) : IntValueModifier(dmgDealt ? 19 : 71)
    {
        public readonly int toStorm = toStorm;

        public override int Modify(int value)
        {
            return value + toStorm;
        }
    }
    public class StormValueModifierReceived(int toStorm) : IntValueModifier(71)
    {
        public readonly int toStorm = toStorm;

        public override int Modify(int value)
        {
            return value > 0 ? value + toStorm : value;
        }
    }
}
