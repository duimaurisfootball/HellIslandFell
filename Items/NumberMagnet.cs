using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class NumberMagnet
    {
        public static void Add()
        {
            AbilitiesUsageChange_Wearable_SMS soulSlap = ScriptableObject.CreateInstance<AbilitiesUsageChange_Wearable_SMS>();
            soulSlap._usesAllAbilities = true;
            soulSlap._usesBasicAbility = false;

            EntryVariableItem numberMagnet = new EntryVariableItem("NumberMagnet_SW")
            {
                Item_ID = "NumberMagnet_SW",
                Name = "Number Magnet",
                Flavour = "\"Three.\"",
                Description = "\"Slap\" is replaced with this party member's missing ability. This party member's ability effects are all set to 3.",
                IsShopItem = true,
                ShopPrice = 3,
                DoesPopUpInfo = false,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("ItemNumberMagnet"),
                EquippedModifiers =
                [
                    soulSlap,
                ],
            };

            numberMagnet.item._ItemTypeIDs =
                [
                    ItemType_GameIDs.Heart.ToString(),
                ];

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(numberMagnet.Item, new ItemModdedUnlockInfo("NumberMagnet_SW", ResourceLoader.LoadSprite("ItemNumberMagnetLocked", null, 32, null), "HIF_Boler_Comedy_ACH"));
        }
    }
}
