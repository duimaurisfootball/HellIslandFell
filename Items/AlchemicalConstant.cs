using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class AlchemicalConstant
    {
        public static void Add()
        {
            FieldEffect_ApplyPermanent_Effect EternalFireApply = ScriptableObject.CreateInstance<FieldEffect_ApplyPermanent_Effect>();
            EternalFireApply._Field = StatusField.OnFire;

            PerformEffect_Item alchemicalConstant = new PerformEffect_Item("AlchemicalConstant_ID", null, false)
            {
                Item_ID = "AlchemicalConstant_TW",
                Name = "Alchemical Constant",
                Flavour = "\"Hot! Hot hot hot!\"",
                Description = "Light an eternal fire in the Opposing enemy position on combat start.",
                IsShopItem = false,
                ShopPrice = 8,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockHeavenMaecenas"),
                TriggerOn = TriggerCalls.OnCombatStart,
                Effects =
                [
                    Effects.GenerateEffect(EternalFireApply, 1, Targeting.Slot_Front),
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(alchemicalConstant.Item, new ItemModdedUnlockInfo("AlchemicalConstant_TW", ResourceLoader.LoadSprite("UnlockHeavenMaecenasLocked", null, 32, null), "HIF_Maecenas_Divine_ACH"));
        }
    }
}
