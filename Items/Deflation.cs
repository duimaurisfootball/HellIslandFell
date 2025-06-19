using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class Deflation
    {
        public static void Add()
        {
            SpawnEnemyAnywhereEffect Goldboy = ScriptableObject.CreateInstance<SpawnEnemyAnywhereEffect>();
            Goldboy._spawnTypeID = CombatType_GameIDs.Spawn_Basic.ToString();
            Goldboy.enemy = LoadedAssetsHandler.GetEnemy("GildedGulper_EN");

            PerformEffect_Item deflation = new PerformEffect_Item("Deflation_ID", null)
            {
                Item_ID = "Deflation_SW",
                Name = "Deflation",
                Flavour = "\"No more hoarding.\"",
                Description = "Spawn a Gilded Gulper on combat start.",
                IsShopItem = true,
                ShopPrice = 2,
                DoesPopUpInfo = true,
                StartsLocked = false,
                Icon = ResourceLoader.LoadSprite("ShopDeflation"),
                TriggerOn = TriggerCalls.OnCombatStart,
                Effects =
                [
                    Effects.GenerateEffect(Goldboy, 1),
                ],
            };

            deflation.item._ItemTypeIDs =
                [
                ];

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(deflation.Item, new ItemModdedUnlockInfo(deflation.Item_ID, ResourceLoader.LoadSprite("ShopDeflation")));
        }
    }
}
