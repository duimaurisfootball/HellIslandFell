using BrutalAPI.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class Trinitite
    {
        public static void Add()
        {
            SpawnEnemyAnywhereEffect Divinity = ScriptableObject.CreateInstance<SpawnEnemyAnywhereEffect>();
            Divinity.enemy = LoadedAssetsHandler.GetEnemy("DivineGlass_EN");
            Divinity._spawnTypeID = CombatType_GameIDs.Spawn_Basic.ToString();

            PerformEffect_Item trinitite = new PerformEffect_Item("Trinitite_ID")
            {
                Item_ID = "Trinitite_TW",
                Name = "Trinitite",
                Flavour = "\"Chimes when it shatters.\"",
                Description = "Summon Divine Glass on the enemy side on turn start.",
                IsShopItem = false,
                ShopPrice = 10,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockHeavenMorrigan"),
                TriggerOn = TriggerCalls.OnTurnStart,
                Effects =
                [
                    Effects.GenerateEffect(Divinity, 1),
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(trinitite.Item, new ItemModdedUnlockInfo("Trinitite_TW", ResourceLoader.LoadSprite("UnlockHeavenMorriganLocked", null, 32, null), "HIF_Morrigan_Divine_ACH"));
        }
    }
}
