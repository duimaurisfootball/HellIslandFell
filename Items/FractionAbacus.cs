using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class FractionAbacus
    {
        public static void Add()
        {
            HellishDamageDealtChange_Item fractionAbacus = new HellishDamageDealtChange_Item("FractionAbacus_ID")
            {
                Item_ID = "FractionAbacus_SW",
                Name = "Fraction Abacus",
                Flavour = "\"Nine and nine sevenths.\"",
                Description = "This party member deals 2 more damage than they otherwise would. Deals 9 additional damage instead if the target is from Hell Island.",
                IsShopItem = true,
                ShopPrice = 6,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("ShopFractionAbacus"),
                TriggerOn = TriggerCalls.OnWillApplyDamage,
                HellishAddition = 9,
                NormalAddition = 2,
                AffectDamageDealtInsteadOfReceived = true,
                UseSimpleIntegerInsteadOfDamage = false,
            };

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(fractionAbacus.Item, new ItemModdedUnlockInfo("FractionAbacus_SW", ResourceLoader.LoadSprite("ItemFractionAbacusLocked", null, 32, null), "HIF_Vus_Comedy_ACH"));
        }
    }
}
