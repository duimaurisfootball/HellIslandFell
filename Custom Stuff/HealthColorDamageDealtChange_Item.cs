using BrutalAPI.Items;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class HealthColorDamageDealtChange_Item : BaseItem
    {
        public SandyDamageWearable item;

        public override BaseWearableSO Item => item;

        public int BlueMultiplier
        {
            set => item._toMultiply0 = value;
        }

        public int YellowMultiplier
        {
            set => item._toMultiply1 = value;
        }

        public bool AffectDamageDealtInsteadOfReceived
        {
            set => item._useDealt = value;
        }

        public bool UseSimpleIntegerInsteadOfDamage
        {
            set => item._useSimpleInt = value;
        }

        public HealthColorDamageDealtChange_Item(string itemID = "DefaultID_Item", int multiplier0 = 1, int multiplier1 = 1, bool useDealt = false, bool useInt = false)
        {
            item = ScriptableObject.CreateInstance<SandyDamageWearable>();
            item._toMultiply0 = multiplier0;
            item._toMultiply1 = multiplier1;
            item._useDealt = useDealt;
            item._useSimpleInt = useInt;
            InitializeItemData(itemID);
        }
    }
}
