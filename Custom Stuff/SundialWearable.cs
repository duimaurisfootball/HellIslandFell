using BrutalAPI;
using BrutalAPI.Items;
using System;
using System.Collections.Generic;
using System.Text;
using static Hell_Island_Fell.Custom_Stuff.SundialWearable;
using static Hell_Island_Fell.Items.PercDmgModifierSetterByReceivedDamageTypePerformEffectWearable;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class SundialWearable : BaseWearableSO
    {
        public override bool IsItemImmediate => true;

        public override bool DoesItemTrigger => true;

        public TriggerCalls[] _effectsTriggers;

        public override void TriggerPassive(object sender, object args)
        {
            if (sender is not IUnit unit)
            {
                return;
            }

            if (args is CanHealReference refH && !refH.Equals(null))
            {
                unit.TryGetStoredData("SundialStoredValue", out UnitStoreDataHolder holder);
                holder.m_MainData += refH.healAmount;
                refH.value = false;
            }

            if (args is DamageDealtValueChangeException exD && !exD.Equals(null))
            {
                unit.TryGetStoredData("SundialStoredValue", out UnitStoreDataHolder holder);
                exD.AddModifier(new SundialPercentageValueModifier(true, holder.m_MainData, true));
            }
        }

        public override void CustomOnTriggerAttached(IWearableEffector caller)
        {
            CombatManager.Instance.AddObserver(TryConsumeWearable, TriggerCalls.CanHeal.ToString(), caller);
            CombatManager.Instance.AddObserver(TryConsumeWearable, TriggerCalls.OnWillApplyDamage.ToString(), caller);
        }

        public override void CustomOnTriggerDettached(IWearableEffector caller)
        {
            CombatManager.Instance.RemoveObserver(TryConsumeWearable, TriggerCalls.CanHeal.ToString(), caller);
            CombatManager.Instance.RemoveObserver(TryConsumeWearable, TriggerCalls.OnWillApplyDamage.ToString(), caller);
        }
        public class SundialPercentageValueModifier(bool dmgDealt, int percent, bool increase) : IntValueModifier(dmgDealt ? 4 : 62)
        {
            public float percentage = Mathf.Max(percent, 0);
            public bool doesIncrease = increase;

            public override int Modify(int value)
            {
                if (value <= 0 || percentage <= 0)
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
    }
}
