using BrutalAPI.Items;
using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Hell_Island_Fell.Custom_Effects;

namespace Hell_Island_Fell.Items
{
    public class BismuthSubsalicylate
    {
        public static void Add()
        {
            RemoveColorCostsEffect RemoveYellow = ScriptableObject.CreateInstance<RemoveColorCostsEffect>();
            RemoveYellow._color = Pigments.Yellow;

            PerformEffect_Item bismuthSubsalicylate = new PerformEffect_Item("BismuthSubsalicylate_ID", null, false)
            {
                Item_ID = "BismuthSubsalicylate_SW",
                Name = "Bismuth Subsalicylate",
                Flavour = "\"No more tummy aches.\"",
                Description = "Remove all yellow costs from this party member on combat start.",
                IsShopItem = true,
                ShopPrice = 4,
                DoesPopUpInfo = true,
                StartsLocked = true,
                TriggerOn = TriggerCalls.OnCombatStart,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanSpoogle"),
                Effects =
                [
                    Effects.GenerateEffect(RemoveYellow, 1, Targeting.Slot_SelfSlot),
                ],
            };

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(bismuthSubsalicylate.Item, new ItemModdedUnlockInfo("BismuthSubsalicylate_SW", ResourceLoader.LoadSprite("UnlockOsmanSpoogleLocked", null, 32, null), "HIF_Spoogle_Witness_ACH"));
        }
    }
}
