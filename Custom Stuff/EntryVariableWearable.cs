using BrutalAPI.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class EntryVariableWearable : BaseWearableSO
    {
        public override bool IsItemImmediate => true;

        public override bool DoesItemTrigger => true;

        public EffectInfo[] effects;

        public override void CustomOnTriggerAttached(IWearableEffector caller)
        {
            CombatManager.Instance.AddObserver(TryConsumeWearable, ModifyEntryVariablePatch.ModifyEntryVariable, caller);
        }
        public override void TriggerPassive(object sender, object args)
        {
            if (args is IntegerReference intref)
            {
                intref.value = 3;
            }
        }
        public override void CustomOnTriggerDettached(IWearableEffector caller)
        {
            CombatManager.Instance.RemoveObserver(TryConsumeWearable, ModifyEntryVariablePatch.ModifyEntryVariable, caller);
        }
    }
}
