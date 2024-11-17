using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class AdditionDamageDealReceiveModifierSetterWearable : BaseWearableSO
    {
        public int _dealtToAdd;

        public int _receivedToAdd;

        public override bool IsItemImmediate => true;

        public override bool DoesItemTrigger => true;

        public override void TriggerPassive(object sender, object args)
        {
            if (args is DamageDealtValueChangeException ex && !ex.Equals(null))
            {
                ex.AddModifier(new AdditionValueModifier(dmgDealt: true, _dealtToAdd));
            }
        }

        public override void CustomOnTriggerAttached(IWearableEffector caller)
        {
            CombatManager.Instance.AddObserver(TryPerformWearable, TriggerCalls.OnBeingDamaged.ToString(), caller);
        }

        public override void CustomOnTriggerDettached(IWearableEffector caller)
        {
            CombatManager.Instance.RemoveObserver(TryPerformWearable, TriggerCalls.OnBeingDamaged.ToString(), caller);
        }

        public override void FinalizeCustomTriggerItem(object sender, object args, int triggerID)
        {
            if (sender is IWearableEffector wearableEffector && !wearableEffector.Equals(null) && !wearableEffector.IsWearableConsumed)
            {
                CombatManager.Instance.AddUIAction(new ShowItemInformationUIAction(wearableEffector.ID, GetItemLocData().text, false, wearableImage));
            }
            if (args is DamageReceivedValueChangeException ex && !ex.Equals(null))
            {
                ex.AddModifier(new AdditionValueModifier(dmgDealt: false, _receivedToAdd));
            }
        }

        public void TryPerformWearable(object sender, object args)
        {
            if (!(sender is IWearableEffector wearableEffector) || wearableEffector.Equals(null) || !wearableEffector.CanWearableTrigger)
            {
                return;
            }
            CombatManager.Instance.ProcessImmediateAction(new PerformItemCustomImmediateAction(this, sender, args, 0));
        }
    }
}
