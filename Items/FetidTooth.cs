using BrutalAPI.Items;
using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Hell_Island_Fell.Custom_Stuff;

namespace Hell_Island_Fell.Items
{
    public class FetidTooth
    {
        public static void Add()
        {
            DamageDealtAndReceivedModifier_Item fetidTooth = new DamageDealtAndReceivedModifier_Item("FetidTooth_ID")
            {
                Item_ID = "FetidTooth_TW",
                Name = "Fetid Tooth",
                Flavour = "\"Plucked right from the mouth of a Tobana.\"",
                Description = "This party member deals 10 more damage than they otherwise would. This party member receives 15 more damage than they otherwise would.",
                IsShopItem = false,
                ShopPrice = 15,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanExambry"),
                TriggerOn = TriggerCalls.OnWillApplyDamage,
                DamageDealtAddition = 10,
                DamageReveivedAddition = 15,
            };

            fetidTooth.item._ItemTypeIDs =
                [
                    "FoodID",
                ];

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(fetidTooth.Item, new ItemModdedUnlockInfo("FetidTooth_TW", ResourceLoader.LoadSprite("UnlockOsmanExambryLocked", null, 32, null), "HIF_Exambry_Witness_ACH"));
        }
    }
}
