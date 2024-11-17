using BrutalAPI.Items;
using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class FesterFlesh
    {
        public static void Add()
        {
            MaxHealthChange_Wearable_SMS DoubleHealth = ScriptableObject.CreateInstance<MaxHealthChange_Wearable_SMS>();
            DoubleHealth.isChangePercentage = true;
            DoubleHealth.maxHealthChange = -50;

            HealthColorChange_Wearable_SMS RedHealth = ScriptableObject.CreateInstance<HealthColorChange_Wearable_SMS>();
            RedHealth._healthColor = Pigments.Blue;

            ExtraPassiveAbility_Wearable_SMS LeakyAdd = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            LeakyAdd._extraPassiveAbility = Passives.Leaky1;

            FieldEffect_Apply_Effect ShieldApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ShieldApply._Field = StatusField.Shield;

            PerformEffect_Item festerFlesh = new PerformEffect_Item("FesterFlesh_ID", null, false)
            {
                Item_ID = "FesterFlesh_TW",
                Name = "Fester Flesh",
                Flavour = "\"The flesh that needs.\"",
                Description = "Halve this party member's max health. Change this party member's health to blue. Apply 6 Shield to this party member's position on turn start.",
                IsShopItem = false,
                ShopPrice = 5,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockHeavenVat"),
                TriggerOn = TriggerCalls.OnTurnStart,
                Effects =
                [
                    Effects.GenerateEffect(ShieldApply, 6, Targeting.Slot_SelfSlot),
                ],
                EquippedModifiers =
                [
                    DoubleHealth,
                    RedHealth,
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(festerFlesh.Item, new ItemModdedUnlockInfo("FesterFlesh_TW", ResourceLoader.LoadSprite("UnlockHeavenVatLocked", null, 32, null), "HIF_Vat_Divine_ACH"));
        }
    }
}

