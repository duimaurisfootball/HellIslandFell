using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Custom_Passives
{
    public class ConnoisseurPassiveAbility : BasePassiveAbilitySO
    {
        public override bool IsPassiveImmediate => true;
        public override bool DoesPassiveTrigger => true;

        public override void OnPassiveConnected(IUnit unit)
        {
            
        }

        public override void OnPassiveDisconnected(IUnit unit)
        {

        }

        public override void TriggerPassive(object sender, object args)
        {
            if (args is DamageDealtValueChangeException context && context.damagedUnit is IStatusEffector effector && effector.StatusEffects.Count > 0)
            {
                context.AddModifier(new BasicPercentageValueModifier(true, Mathf.CeilToInt((context.damagedUnit as IStatusEffector).StatusEffects.Count * (100f / 3)), true));
            }
        }
    }
    public class BasicPercentageValueModifier(bool dmgDealt, int percent, bool increase) : IntValueModifier(dmgDealt ? 4 : 62)
    {
        public float percentage = Mathf.Max(percent, 0);
        public bool doesIncrease = increase;

        public override int Modify(int value)
        {
            float f = percentage * value / 100f;
            int num = Mathf.Max(0, Mathf.CeilToInt(f));
            if (!doesIncrease)
            {
                return Mathf.Max(0, value - num);
            }
            return value + num;
        }
    }
}
