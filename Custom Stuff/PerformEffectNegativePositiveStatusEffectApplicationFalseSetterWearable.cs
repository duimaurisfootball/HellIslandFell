using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class PerformEffectNegativePositiveStatusEffectApplicationFalseSetterWearable : BaseWearableSO
    {
        [Header("Wearable Effects")]
        public bool _immediateEffect;

        public EffectInfo[] _effects;

        public bool _positive;

        public override bool IsItemImmediate => true;

        public override bool DoesItemTrigger => true;

        public override void TriggerPassive(object sender, object args)
        {
            if (args is StatusFieldApplication statusFieldApplication && !statusFieldApplication.Equals(null) && statusFieldApplication.isStatusPositive == _positive)
            {
                statusFieldApplication.canBeApplied = false;

                IUnit caster = sender as IUnit;
                if (_immediateEffect)
                {
                    CombatManager.Instance.ProcessImmediateAction(new ImmediateEffectAction(_effects, caster));
                }
                else
                {
                    CombatManager.Instance.AddSubAction(new EffectAction(_effects, caster));
                }
            }
        }
    }
}
