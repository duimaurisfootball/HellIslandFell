using BrutalAPI.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class EntryVariableItem : BaseItem
    {
        public EntryVariableWearable item;

        public override BaseWearableSO Item => item;

        public EntryVariableItem(string itemID = "DefaultID_Item")
        {
            item = ScriptableObject.CreateInstance<EntryVariableWearable>();
            InitializeItemData(itemID);
        }
    }
}
