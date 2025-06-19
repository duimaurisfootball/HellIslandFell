using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class BloodThinners
    {
        public static void Add()
        {
            AddCostEffect AddRed = ScriptableObject.CreateInstance<AddCostEffect>();
            AddRed._color = Pigments.Red;
            AddRed.AddOverSix = true;
            AddRed.IgnoreSlap = false;

            PerformEffect_Item bloodThinners = new PerformEffect_Item("BloodThinners_ID", null, false)
            {
                Item_ID = "BloodThinners_SW",
                Name = "Blood Thinners",
                Flavour = "\"Don't get cut.\"",
                Description = "Add 1 red cost to this party member's abilities.",
                IsShopItem = true,
                ShopPrice = 3,
                DoesPopUpInfo = true,
                StartsLocked = false,
                TriggerOn = TriggerCalls.OnCombatStart,
                Icon = ResourceLoader.LoadSprite("ShopBloodThinners"),
                Effects =
                [
                    Effects.GenerateEffect(AddRed, 1, Targeting.Slot_SelfSlot),
                ],
            };

            bloodThinners.item._ItemTypeIDs =
                [
                    "FoodID",
                ];

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(bloodThinners.Item, new ItemModdedUnlockInfo(bloodThinners.Item_ID, ResourceLoader.LoadSprite("ShopBloodThinners")));
        }
    }
}
