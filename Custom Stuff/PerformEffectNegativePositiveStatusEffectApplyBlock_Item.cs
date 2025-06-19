using BrutalAPI.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class PerformEffectNegativePositiveStatusEffectApplyBlock_Item : BaseItem
    {
        public PerformEffectNegativePositiveStatusEffectApplicationFalseSetterWearable item;

        public override BaseWearableSO Item => item;

        public EffectInfo[] Effects
        {
            get => item._effects;
            set => item._effects = value;
        }

        public bool IsEffectImmediate
        {
            set => item._immediateEffect = value;
        }

        public bool IsStatusPositive
        {
            set => item._positive = value;
        }

        public PerformEffectNegativePositiveStatusEffectApplyBlock_Item(string itemID = "DefaultID_Item", EffectInfo[] effects = null, bool immediate = false, bool positive = true)
        {
            item = ScriptableObject.CreateInstance<PerformEffectNegativePositiveStatusEffectApplicationFalseSetterWearable>();
            item.triggerOn = TriggerCalls.CanApplyStatusEffect;
            item._immediateEffect = immediate;
            item._effects = effects;
            item._positive = positive;
            InitializeItemData(itemID);

        }
    }
}
