using BrutalAPI.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class MagicAccelerator
    {
        public static void Add()
        {
            ExtraPassiveAbility_Wearable_SMS toHeaven = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            toHeaven._extraPassiveAbility = CustomPassives.InvincibilityGenerator(6);

            ExtraPassiveAbility_Wearable_SMS fromHell = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            fromHell._extraPassiveAbility = Passives.GetCustomPassive("Thorny_PA");

            PerformEffect_Item magicAccelerator = new PerformEffect_Item("MagicAccelerator_ID", null)
            {
                Item_ID = "MagicAccelerator_TW",
                Name = "Magic Accelerator",
                Flavour = "\"We dragged god out of heaven to shake his hand.\"",
                Description = "This party member now has Invincible (6) and Thorny as passives.",
                IsShopItem = false,
                ShopPrice = 7,
                DoesPopUpInfo = false,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockHeavenPinec"),
                TriggerOn = TriggerCalls.Count,
                Effects =
                [

                ],
                EquippedModifiers =
                [
                    toHeaven,
                    fromHell,
                ],
            };

            magicAccelerator.item._ItemTypeIDs =
                [
                    ItemType_GameIDs.Magic.ToString(),
                    ItemType_GameIDs.Heart.ToString(),
                ];

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(magicAccelerator.Item, new ItemModdedUnlockInfo("MagicAccelerator_TW", ResourceLoader.LoadSprite("UnlockHeavenPinecLocked", null, 32, null), "HIF_Pinec_Divine_ACH"));
        }
    }
}
