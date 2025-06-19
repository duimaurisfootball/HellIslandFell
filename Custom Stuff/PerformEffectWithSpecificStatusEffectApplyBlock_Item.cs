using BrutalAPI.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class PerformEffectWithSpecificStatusEffectApplyBlock_Item : BaseItem
    {
        public PerformEffectWithSpecificStatusEffectApplicationFalseSetterWearable item;

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

        public string[] StatusEffects
        {
            set => item._statusEffects = value;
        }

        public PerformEffectWithSpecificStatusEffectApplyBlock_Item(string itemID = "DefaultID_Item", EffectInfo[] effects = null, bool immediate = false, string[] statusEffects = null)
        {
            item = ScriptableObject.CreateInstance<PerformEffectWithSpecificStatusEffectApplicationFalseSetterWearable>();
            item.triggerOn = TriggerCalls.CanApplyStatusEffect;
            item._immediateEffect = immediate;
            item._effects = effects;
            item._statusEffects = statusEffects;
            InitializeItemData(itemID);

        }
    }
}
