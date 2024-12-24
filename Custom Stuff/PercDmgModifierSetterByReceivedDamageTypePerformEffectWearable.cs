using Hell_Island_Fell.Custom_Passives;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class PercDmgModifierSetterByReceivedDamageTypePerformEffectWearable : BaseWearableSO
    {

        [Header("Percentage Multiplier Data")]
        public bool _doesIncreaseDirect = true;

        public EffectInfo[] _effects;

        public TriggerCalls _effectsTrigger;

        [Min(1f)]
        public int _percentageToModifyDirect = 50;

        public bool _doesIncreaseIndirect = true;

        [Min(1f)]
        public int _percentageToModifyIndirect = 50;

        public override bool IsItemImmediate => true;

        public override bool DoesItemTrigger => true;

        public override void TriggerPassive(object sender, object args)
        {
            if (args is DamageReceivedValueChangeException ex && !ex.Equals(null))
            {
                bool doesIncrease = _doesIncreaseIndirect;
                int percentage = _percentageToModifyIndirect;
                if (ex.directDamage)
                {
                    doesIncrease = _doesIncreaseDirect;
                    percentage = _percentageToModifyDirect;
                }

                ex.AddModifier(new MinOnePercentageValueModifier(dmgDealt: false, percentage, doesIncrease));
            }
        }
        public class MinOnePercentageValueModifier(bool dmgDealt, int percent, bool increase) : IntValueModifier(dmgDealt ? 4 : 62)
        {
            public float percentage = Mathf.Max(percent, 0);
            public bool doesIncrease = increase;

            public override int Modify(int value)
            {
                if (value <= 0)
                {
                    return value;
                }
                float f = percentage * value / 100f;
                int num = Mathf.Max(1, Mathf.CeilToInt(f));
                if (!doesIncrease)
                {
                    return Mathf.Max(1, value - num);
                }
                return value + num;
            }

        }

        public override void CustomOnTriggerAttached(IWearableEffector caller)
        {
            TriggerCalls performEffectsTriggerOn = _effectsTrigger;
            if (performEffectsTriggerOn != TriggerCalls.Count)
            {
                CombatManager.Instance.AddObserver(TryPerformWearable, performEffectsTriggerOn.ToString(), caller);
            }
        }

        public override void CustomOnTriggerDettached(IWearableEffector caller)
        {
            TriggerCalls performEffectsTriggerOn = _effectsTrigger;
            if (performEffectsTriggerOn != TriggerCalls.Count)
            {
                CombatManager.Instance.RemoveObserver(TryPerformWearable, performEffectsTriggerOn.ToString(), caller);
            }
        }

        public override void FinalizeCustomTriggerItem(object sender, object args, int triggerID)
        {
            if (sender is IWearableEffector wearableEffector && !wearableEffector.Equals(null) && !wearableEffector.IsWearableConsumed)
            {
                IUnit caster = sender as IUnit;
                CombatManager.Instance.AddSubAction(new EffectAction(_effects, caster));
            }
        }

        public void TryPerformWearable(object sender, object args)
        {
            if (!(sender is IWearableEffector wearableEffector) || wearableEffector.Equals(null) || !wearableEffector.CanWearableTrigger)
            {
                return;
            }

            CombatManager.Instance.AddSubAction(new PerformItemCustomAction(this, sender, args, 0));
        }
    }
}
