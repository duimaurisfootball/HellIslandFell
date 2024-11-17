using BrutalAPI.Items;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class MultiCustomTriggerEffectItem : BaseItem
    {
        public MultiCustomTriggerEffectWearable item;

        public override BaseWearableSO Item => item;

        public EffectsAndTriggerBase[] EffectsAndTrigger
        {
            get => item.triggerEffects;

            set => item.triggerEffects = value;
        }

        public MultiCustomTriggerEffectItem(string itemID = "DefaultID_Item", EffectsAndTriggerBase[] effectsAndTriggers = null)
        {
            item = ScriptableObject.CreateInstance<MultiCustomTriggerEffectWearable>();
            item.triggerEffects = effectsAndTriggers;
            InitializeItemData(itemID);
        }
    }
}
