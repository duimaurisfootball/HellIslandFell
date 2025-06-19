using BrutalAPI.Items;
using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Hell_Island_Fell.Custom_Effects;

namespace Hell_Island_Fell.Items
{
    public class CheesePlate
    {
        public static void Add()
        {
            ExtraLootIDsEffect foodList = ScriptableObject.CreateInstance<ExtraLootIDsEffect>();
            foodList._getLocked = false;
            foodList._itemID = "FoodID";

            PerformEffect_Item cheesePlate = new PerformEffect_Item("CheesePlate_ID", null)
            {
                Item_ID = "CheesePlate_SW",
                Name = "Cheese Plate",
                Flavour = "\"Also has olives and capers.\"",
                Description = "Cooks 0-3 \"Food\" items at the end of combat.",
                IsShopItem = true,
                ShopPrice = 9,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanAlvinar"),
                TriggerOn = TriggerCalls.OnCombatEnd,
                Effects =
                [
                    Effects.GenerateEffect(foodList, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                    Effects.GenerateEffect(foodList, 2, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                ],
            };

            cheesePlate.item._ItemTypeIDs =
                [
                    "FoodID",
                ];

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(cheesePlate.Item, new ItemModdedUnlockInfo("CheesePlate_SW", ResourceLoader.LoadSprite("UnlockOsmanAlvinarLocked", null, 32, null), "HIF_Alvinar_Witness_ACH"));
        }
    }
}
