using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class Retinol
    {
        public static void Add()
        {
            AddCostEffect AddYellow = ScriptableObject.CreateInstance<AddCostEffect>();
            AddYellow._color = Pigments.Yellow;
            AddYellow.AddOverSix = true;
            AddYellow.IgnoreSlap = false;

            PerformEffect_Item retinol = new PerformEffect_Item("Retinol_ID", null, false)
            {
                Item_ID = "Retinol_SW",
                Name = "Retinol",
                Flavour = "\"Stop aging!\"",
                Description = "Add 1 yellow cost to this party member's abilities.",
                IsShopItem = true,
                ShopPrice = 1,
                DoesPopUpInfo = true,
                StartsLocked = false,
                TriggerOn = TriggerCalls.OnCombatStart,
                Icon = ResourceLoader.LoadSprite("ShopRetinol"),
                Effects =
                [
                    Effects.GenerateEffect(AddYellow, 1, Targeting.Slot_SelfSlot),
                ],
            };

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(retinol.Item);
        }
    }
}
