using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class LilDraugr
    {
        public static void Add()
        {
            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Salted_ID", out StatusEffect_SO Salted);
            StatusEffect_ApplyByHealth_Effect SaltedApply = ScriptableObject.CreateInstance<StatusEffect_ApplyByHealth_Effect>();
            SaltedApply._Status = Salted;
            SaltedApply._ApplyWeakest = false;

            PerformEffect_Item lilDraugr = new PerformEffect_Item("LilDraugr_ID", null, false)
            {
                Item_ID = "LilDraugr_TW",
                Name = "Lil' Draugr",
                Flavour = "\"Her name is Katie. Say hi to Katie!\"",
                Description = "On turn start, apply 1 Salted to the enemy(ies) with the highest health and 2 Salted to the party member(s) with the highest health.",
                IsShopItem = false,
                ShopPrice = 3,
                DoesPopUpInfo = true,
                StartsLocked = false,
                TriggerOn = TriggerCalls.OnTurnStart,
                Icon = ResourceLoader.LoadSprite("TreasureLilDraugr"),
                Effects =
                [
                    Effects.GenerateEffect(SaltedApply, 1, Targeting.Unit_AllOpponents),
                    Effects.GenerateEffect(SaltedApply, 2, Targeting.Unit_AllAllies),
                ],
            };

            lilDraugr.item._ItemTypeIDs =
                [
                    ItemType_GameIDs.Face.ToString(),
                ];

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(lilDraugr.Item, new ItemModdedUnlockInfo(lilDraugr.Item_ID, ResourceLoader.LoadSprite("TreasureLilDraugr")));
        }
    }
}
