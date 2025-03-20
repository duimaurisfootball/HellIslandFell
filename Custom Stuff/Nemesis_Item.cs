using BrutalAPI.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class Nemesis_Item : BaseItem
    {
        public NemesisWearable item;

        public override BaseWearableSO Item => item;

        public EffectInfo[] NormalEffects
        {
            get => item._normalEffects;
            set => item._normalEffects = value;
        }

        public EffectInfo[] MurderEffects
        {
            get => item._murderEffects;
            set => item._murderEffects = value;
        }

        public Nemesis_Item(string itemID = "DefaultID_Item", EffectInfo[] effects = null, EffectInfo[] murderEffects = null)
        {
            item = ScriptableObject.CreateInstance<NemesisWearable>();
            item._normalEffects = effects;
            item._murderEffects = murderEffects;
            InitializeItemData(itemID);
        }
    }
}
