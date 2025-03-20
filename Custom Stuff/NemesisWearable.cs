using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class NemesisWearable : BaseWearableSO
    {
        public EffectInfo[] _normalEffects;

        public EffectInfo[] _murderEffects;

        public override bool IsItemImmediate => false;

        public override bool DoesItemTrigger => true;

        public override void TriggerPassive(object sender, object args)
        {
            IUnit caster = sender as IUnit;
            CombatManager.Instance.AddSubAction(new EffectAction(_normalEffects, caster));
        }

        public override void CustomOnTriggerAttached(IWearableEffector caller)
        {
            CombatManager.Instance.AddObserver(TryPerformWearable, TriggerCalls.OnKill.ToString(), caller);
        }

        public override void CustomOnTriggerDettached(IWearableEffector caller)
        {
            CombatManager.Instance.RemoveObserver(TryPerformWearable, TriggerCalls.OnKill.ToString(), caller);
        }

        public override void FinalizeCustomTriggerItem(object sender, object args, int triggerID)
        {
            if (sender is IWearableEffector wearableEffector && !wearableEffector.Equals(null) && !wearableEffector.IsWearableConsumed)
            {
                if (args is not IUnit killedUnit)
                {
                    return;
                }
                if (!killedUnit.ContainsStatusEffect("Nemesis_ID"))
                {
                    return;
                }
                IUnit caster = sender as IUnit;
                CombatManager.Instance.AddSubAction(new EffectAction(_murderEffects, caster));
            }
        }

        public void TryPerformWearable(object sender, object args)
        {
            if (!(sender is IWearableEffector wearableEffector) || wearableEffector.Equals(null) || !wearableEffector.CanWearableTrigger)
            {
                return;
            }
            if (args is not IUnit killedUnit)
            {
                return;
            }
            if (!killedUnit.ContainsStatusEffect("Nemesis_ID"))
            {
                return;
            }

            CombatManager.Instance.AddSubAction(new PerformItemCustomAction(this, sender, args, 0));
        }
    }
}
