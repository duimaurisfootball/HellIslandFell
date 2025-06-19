using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class SurrealMannequinHead
    {
        public static void Add()
        {
            ExtraLootIDsEffect faceList = ScriptableObject.CreateInstance<ExtraLootIDsEffect>();
            faceList._getLocked = false;
            faceList._itemID = ItemType_GameIDs.Face.ToString();

            PerformEffect_Item surrealMannequinHead = new PerformEffect_Item("SurrealMannequinHead_ID", null)
            {
                Item_ID = "SurrealMannequinHead_SW",
                Name = "Surreal Mannequin Head",
                Flavour = "\"Cool and good.\"",
                Description = "Creates a \"Face\" item on combat end.",
                IsShopItem = true,
                ShopPrice = 5,
                DoesPopUpInfo = true,
                StartsLocked = false,
                Icon = ResourceLoader.LoadSprite("ShopSurrealMannequinHead"),
                TriggerOn = TriggerCalls.OnCombatEnd,
                Effects =
                [
                    Effects.GenerateEffect(faceList, 1, Targeting.Slot_SelfSlot),
                ],
            };

            surrealMannequinHead.item._ItemTypeIDs =
                [
                    ItemType_GameIDs.Face.ToString(),
                ];

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(surrealMannequinHead.Item, new ItemModdedUnlockInfo(surrealMannequinHead.Item_ID, ResourceLoader.LoadSprite("ShopSurrealMannequinHead")));
        }
    }
}
