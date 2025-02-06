using BrutalAPI.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class HellishDamageDealtChange_Item : BaseItem
    {
        public HellishDamageWearable item;

        public override BaseWearableSO Item => item;

        public int NormalAddition
        {
            set => item._toAdd1 = value;
        }

        public int HellishAddition
        {
            set => item._toAdd0 = value;
        }

        public bool AffectDamageDealtInsteadOfReceived
        {
            set => item._useDealt = value;
        }

        public bool UseSimpleIntegerInsteadOfDamage
        {
            set => item._useSimpleInt = value;
        }

        public HellishDamageDealtChange_Item(string itemID = "DefaultID_Item", int additionNormal = 1, int additionHellish = 1, bool useDealt = false, bool useInt = false)
        {
            item = ScriptableObject.CreateInstance<HellishDamageWearable>();
            item._toAdd0 = additionHellish;
            item._toAdd1 = additionNormal;
            item._useDealt = useDealt;
            item._useSimpleInt = useInt;
            InitializeItemData(itemID);
        }
    }
}
