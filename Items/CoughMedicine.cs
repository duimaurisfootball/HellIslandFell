using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class CoughMedicine
    {
        public static void Add()
        {
            AddCostEffect AddBlue = ScriptableObject.CreateInstance<AddCostEffect>();
            AddBlue._color = Pigments.Blue;
            AddBlue.AddOverSix = true;
            AddBlue.IgnoreSlap = false;

            PerformEffect_Item coughMedicine = new PerformEffect_Item("CoughMedicine_ID", null, false)
            {
                Item_ID = "CoughMedicine_SW",
                Name = "Cough Medicine",
                Flavour = "\"Soothes the throat and dissolves the pleghm.\"",
                Description = "Add 1 blue cost to this party member's abilities.",
                IsShopItem = true,
                ShopPrice = 2,
                DoesPopUpInfo = true,
                StartsLocked = false,
                TriggerOn = TriggerCalls.OnCombatStart,
                Icon = ResourceLoader.LoadSprite("ShopCoughMedicine"),
                Effects =
                [
                    Effects.GenerateEffect(AddBlue, 1, Targeting.Slot_SelfSlot),
                ],
            };

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(coughMedicine.Item);
        }
    }
}
