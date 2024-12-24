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
            toHeaven._extraPassiveAbility = CustomPassives.InvincibilityGenerator(5);

            PerformEffect_Item magicAccelerator = new PerformEffect_Item("MagicAccelerator_ID", null)
            {
                Item_ID = "MagicAccelerator_TW",
                Name = "Magic Accelerator",
                Flavour = "\"We dragged god out of heaven to shake his hand.\"",
                Description = "This party member now has Invincible (5) as a passive.",
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
                    toHeaven
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(magicAccelerator.Item, new ItemModdedUnlockInfo("MagicAccelerator_TW", ResourceLoader.LoadSprite("UnlockHeavenPinecLocked", null, 32, null), "HIF_Pinec_Divine_ACH"));
        }
    }
}
