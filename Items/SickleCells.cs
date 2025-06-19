using BrutalAPI.Items;
using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class SickleCells
    {
        public static void Add()
        {
            HealthColorChange_Wearable_SMS RedHealth = ScriptableObject.CreateInstance<HealthColorChange_Wearable_SMS>();
            RedHealth._healthColor = Pigments.Red;

            ExtraPassiveAbility_Wearable_SMS LeakyAdd = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            LeakyAdd._extraPassiveAbility = Passives.Leaky1;

            ChangeMaxHealthEffect DoubleHealth = ScriptableObject.CreateInstance<ChangeMaxHealthEffect>();
            DoubleHealth._increase = true;
            DoubleHealth._entryAsPercentage = true;

            PerformEffect_Item sickleCells = new PerformEffect_Item("SickleCells_ID", null, false)
            {
                Item_ID = "SickleCells_TW",
                Name = "Sickle Cells",
                Flavour = "\"At least you won't get malaria.\"",
                Description = "Double this party member's max health on combat start. Change this party member's health to red. This party member now has Leaky as a passive.",
                IsShopItem = false,
                ShopPrice = 5,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanVat"),
                TriggerOn = TriggerCalls.OnCombatStart,
                Effects =
                [
                    Effects.GenerateEffect(DoubleHealth, 100, Targeting.Slot_SelfSlot),
                ],
                EquippedModifiers =
                [
                    RedHealth,
                    LeakyAdd,
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(sickleCells.Item, new ItemModdedUnlockInfo("SickleCells_TW", ResourceLoader.LoadSprite("UnlockOsmanVatLocked", null, 32, null), "HIF_Vat_Witness_ACH"));
        }
    }
}
