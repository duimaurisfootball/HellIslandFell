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
            HealthColorChange_Wearable_SMS BlueHealth = ScriptableObject.CreateInstance<HealthColorChange_Wearable_SMS>();
            BlueHealth._healthColor = Pigments.Blue;

            ExtraPassiveAbility_Wearable_SMS LeakyAdd = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            LeakyAdd._extraPassiveAbility = Passives.Leaky1;

            FieldEffect_Apply_Effect ShieldApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ShieldApply._Field = StatusField.Shield;

            ChangeMaxHealthEffect HalveHealth = ScriptableObject.CreateInstance<ChangeMaxHealthEffect>();
            HalveHealth._increase = false;
            HalveHealth._entryAsPercentage = true;

            DoublePerformEffect_Item festerFlesh = new DoublePerformEffect_Item("FesterFlesh_ID", null, false)
            {
                Item_ID = "FesterFlesh_TW",
                Name = "Fester Flesh",
                Flavour = "\"The flesh that needs.\"",
                Description = "Halve this party member's max health on combat start. Change this party member's health to blue. Apply 6 Shield to this party member's position on turn start.",
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
                SecondaryTriggerOn = 
                [
                    TriggerCalls.OnCombatStart,
                ],
                SecondaryEffects =
                [
                    Effects.GenerateEffect(HalveHealth, 50, Targeting.Slot_SelfSlot),
                ],
                EquippedModifiers =
                [
                    BlueHealth,
                ],
            };

            festerFlesh.item._ItemTypeIDs =
                [
                    ItemType_GameIDs.Magic.ToString(),
                    "FoodID",
                ];

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(festerFlesh.Item, new ItemModdedUnlockInfo("FesterFlesh_TW", ResourceLoader.LoadSprite("UnlockHeavenVatLocked", null, 32, null), "HIF_Vat_Divine_ACH"));
        }
    }
}

