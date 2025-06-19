using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class AnyoneMovedWearable : BaseWearableSO
    {
        [Header("Wearable Effects")]
        public bool _immediateEffect;

        public EffectInfo[] effects;

        public EffectInfo[] moveTargetEffects;

        public EffectorConditionSO[] movePerformConditions;

        public override bool IsItemImmediate => _immediateEffect;

        public override bool DoesItemTrigger => true;

        public override void TriggerPassive(object sender, object args)
        {
            IUnit caster = sender as IUnit;
            if (_immediateEffect)
            {
                CombatManager.Instance.ProcessImmediateAction(new ImmediateEffectAction(effects, caster));
            }
            else
            {
                CombatManager.Instance.AddSubAction(new EffectAction(effects, caster));
            }
        }

        public override void CustomOnTriggerAttached(IWearableEffector caller)
        {
            CombatManager.Instance.AddObserver(TryPerformWearable, "Dui_Mauris_Football.HIF_AnyoneMoved", caller);
        }

        public override void CustomOnTriggerDettached(IWearableEffector caller)
        {
            CombatManager.Instance.RemoveObserver(TryPerformWearable, "Dui_Mauris_Football.HIF_AnyoneMoved", caller);
        }

        public override void FinalizeCustomTriggerItem(object sender, object args, int triggerID)
        {
            if (sender is IWearableEffector wearableEffector && !wearableEffector.Equals(null) && !wearableEffector.IsWearableConsumed)
            {
                if (sender is not IUnit caster || args is not AnyoneMovedNotificationInfo notifinfo || notifinfo.unit == null)
                {
                    return;
                }
                CombatManager.Instance.AddUIAction(new ShowItemInformationUIAction(wearableEffector.ID, GetItemLocData().text, false, wearableImage));
                EffectInfo[] moveTargetEffectsIn = moveTargetEffects;
                foreach (EffectInfo effect in moveTargetEffectsIn)
                {
                    effect.targets = Targeting.GenerateGenericTarget([notifinfo.unit.SlotID], notifinfo.unit.IsUnitCharacter);
                }
                CombatManager.Instance.AddSubAction(new EffectAction(moveTargetEffectsIn, caster));
            }
        }

        public void TryPerformWearable(object sender, object args)
        {
            if (!(sender is IWearableEffector wearableEffector) || wearableEffector.Equals(null) || !wearableEffector.CanWearableTrigger)
            {
                return;
            }

            if (movePerformConditions != null && !movePerformConditions.Equals(null))
            {
                EffectorConditionSO[] secondPerformConditions = movePerformConditions;
                for (int i = 0; i < secondPerformConditions.Length; i++)
                {
                    if (!secondPerformConditions[i].MeetCondition(wearableEffector, args))
                    {
                        return;
                    }
                }
            }

            CombatManager.Instance.AddSubAction(new PerformItemCustomAction(this, sender, args, 0));
        }
    }
}
