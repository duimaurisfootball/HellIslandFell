using BrutalAPI.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class AnyoneMoved_Item : BaseItem
    {
        public AnyoneMovedWearable item;

        public override BaseWearableSO Item => item;

        public EffectInfo[] Effects
        {
            get => item.effects;
            set => item.effects = value;
        }

        public EffectInfo[] MoveTargetEffects
        {
            get => item.moveTargetEffects;
            set => item.moveTargetEffects = value;
        }

        public EffectorConditionSO[] MoveConditions
        {
            get => item.movePerformConditions;
            set => item.movePerformConditions = value;
        }

        public bool IsEffectImmediate
        {
            set => item._immediateEffect = value;
        }

        public AnyoneMoved_Item(string itemID = "DefaultID_Item", EffectInfo[] effects = null, EffectInfo[] moveTargetsEffect = null, bool immediate = false, EffectorConditionSO[] movePerformConditions = null)
        {
            item = ScriptableObject.CreateInstance<AnyoneMovedWearable>();
            item._immediateEffect = immediate;
            item.effects = effects;
            item.moveTargetEffects = moveTargetsEffect;
            item.movePerformConditions = movePerformConditions;
            InitializeItemData(itemID);
        }
    }
}
