using BrutalAPI.Items;
using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class BavarianPretzel
    {
        public static void Add()
        {
            ExtraPassiveAbility_Wearable_SMS foodie = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            foodie._extraPassiveAbility = Passives.GetCustomPassive("Connoisseur_PA");

            PerformEffect_Item bavarianPretzel = new PerformEffect_Item("BavarianPretzel_ID", null)
            {
                Item_ID = "BavarianPretzel_SW",
                Name = "Bavarian Pretzel",
                Flavour = "\"Pairs great with beer cheese.\"",
                Description = "This party member now has Connoisseur as a passive.",
                IsShopItem = true,
                ShopPrice = 9,
                DoesPopUpInfo = false,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockHeavenAlvinar"),
                TriggerOn = TriggerCalls.Count,
                Effects =
                [

                ],
                EquippedModifiers =
                [
                    foodie
                ],
            };

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(bavarianPretzel.Item, new ItemModdedUnlockInfo("BavarianPretzel_SW", ResourceLoader.LoadSprite("UnlockHeavenAlvinarLocked", null, 32, null), "HIF_Alvinar_Divine_ACH"));
        }
    }
}
