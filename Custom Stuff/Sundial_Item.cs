using BrutalAPI.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class Sundial_Item : BaseItem
    {
        public SundialWearable item;

        public override BaseWearableSO Item => item;

        public Sundial_Item(string itemID = "DefaultID_Item")
        {
            item = ScriptableObject.CreateInstance<SundialWearable>();
            InitializeItemData(itemID);
        }
    }
}
