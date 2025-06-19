using BrutalAPI.Items;
using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class StabbingHomunculus
    {
        public static void Add()
        {
            SpawnEnemyAnywhereEffect Scatter = ScriptableObject.CreateInstance<SpawnEnemyAnywhereEffect>();
            Scatter.enemy = LoadedAssetsHandler.GetEnemy("ScatteringHomunculus_EN");
            Scatter._spawnTypeID = CombatType_GameIDs.Spawn_Basic.ToString();

            HealthColorChange_Wearable_SMS RedHealth = ScriptableObject.CreateInstance<HealthColorChange_Wearable_SMS>();
            RedHealth._healthColor = Pigments.Red;

            PerformEffect_Item stabbingHomunculus = new PerformEffect_Item("StabbingHomunculus_ID", null, false)
            {
                Item_ID = "StabbingHomunculus_TW",
                Name = "Stabbing Homunculus",
                Flavour = "\"Ouch!\"",
                Description = "This party member now has red health. Spawn as many Scattering Homunculi as possible on combat start.",
                IsShopItem = false,
                ShopPrice = 8,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanHoftstoldt"),
                TriggerOn = TriggerCalls.OnCombatStart,
                Effects =
                [
                    Effects.GenerateEffect(Scatter, 5, Targeting.Slot_SelfSlot),
                ],
                EquippedModifiers =
                [
                    RedHealth,
                ],
            };

            stabbingHomunculus.item._ItemTypeIDs =
                [
                    ItemType_GameIDs.Knife.ToString(),
                    ItemType_GameIDs.Heart.ToString(),
                ];

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(stabbingHomunculus.Item, new ItemModdedUnlockInfo("StabbingHomunculus_TW", ResourceLoader.LoadSprite("UnlockOsmanHoftstoldtLocked", null, 32, null), "HIF_Hoftstoldt_Witness_ACH"));        }
    }
}
