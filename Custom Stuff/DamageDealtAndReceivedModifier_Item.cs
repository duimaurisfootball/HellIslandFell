using BrutalAPI.Items;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class DamageDealtAndReceivedModifier_Item : BaseItem
    {
        public AdditionDamageDealReceiveModifierSetterWearable item;

        public override BaseWearableSO Item => item;

        public int DamageDealtAddition
        {
            set => item._dealtToAdd = value;
        }

        public int DamageReveivedAddition
        {
            set => item._receivedToAdd = value;
        }

        public DamageDealtAndReceivedModifier_Item(string itemID = "DefaultID_Item", int dealtAdd = 1, int receivedAdd = 1)
        {
            item = ScriptableObject.CreateInstance<AdditionDamageDealReceiveModifierSetterWearable>();
            item._dealtToAdd = dealtAdd;
            item._receivedToAdd = receivedAdd;
            InitializeItemData(itemID);
        }
    }
}
