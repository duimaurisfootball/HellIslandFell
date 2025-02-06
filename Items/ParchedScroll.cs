using BrutalAPI.Items;
using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using static Hell_Island_Fell.Items.SandyDamageWearable;

namespace Hell_Island_Fell.Items
{
    public class ParchedScroll
    {
        public static void Add()
        {
            HealthColorChange_Wearable_SMS healthToYellow = ScriptableObject.CreateInstance<HealthColorChange_Wearable_SMS>();
            healthToYellow._healthColor = Pigments.Yellow;

            HealthColorDamageDealtChange_Item parchedScroll = new HealthColorDamageDealtChange_Item("ParchedScroll_ID")
            {
                Item_ID = "ParchedScroll_TW",
                Name = "Parched Scroll",
                Flavour = "\"Beyond the salt lies a great beast of nickel.\"",
                Description = "Deal double damage to targets with blue health. Deal half damage to targets with yellow health. Change this party member's health color to yellow.",
                IsShopItem = false,
                ShopPrice = 6,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanAelie"),
                TriggerOn = TriggerCalls.OnWillApplyDamage,
                BlueMultiplier = 100,
                YellowMultiplier = 50,
                AffectDamageDealtInsteadOfReceived = true,
                UseSimpleIntegerInsteadOfDamage = false,
                EquippedModifiers =
                [
                    healthToYellow,
                ],
                Conditions =
                [
                    ScriptableObject.CreateInstance<ScrollCondition>(),
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(parchedScroll.Item, new ItemModdedUnlockInfo("ParchedScroll_TW", ResourceLoader.LoadSprite("UnlockOsmanAelieLocked", null, 32, null), "HIF_Aelie_Witness_ACH"));
        }
    }
}
