using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class Melatonin
    {
        public static void Add()
        {
            AddCostEffect AddPurple = ScriptableObject.CreateInstance<AddCostEffect>();
            AddPurple._color = Pigments.Purple;
            AddPurple.AddOverSix = true;
            AddPurple.IgnoreSlap = false;

            PerformEffect_Item melatonin = new PerformEffect_Item("Melatonin_ID", null, false)
            {
                Item_ID = "Melatonin_SW",
                Name = "Melatonin",
                Flavour = "\"Night night...\"",
                Description = "Add 1 purple cost to this party member's abilities.",
                IsShopItem = true,
                ShopPrice = 0,
                DoesPopUpInfo = true,
                StartsLocked = false,
                TriggerOn = TriggerCalls.OnCombatStart,
                Icon = ResourceLoader.LoadSprite("ShopMelatonin"),
                Effects =
                [
                    Effects.GenerateEffect(AddPurple, 1, Targeting.Slot_SelfSlot),
                ],
            };

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(melatonin.Item);
        }
    }
}
