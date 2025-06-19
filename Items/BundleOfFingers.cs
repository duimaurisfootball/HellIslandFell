using BrutalAPI.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class BundleOfFingers
    {
        public static void Add()
        {
            RankChange_Wearable_SMS rankUp = ScriptableObject.CreateInstance<RankChange_Wearable_SMS>();
            rankUp._rankAdditive = 1;

            LosePlayerCurrencyEffect LoseMoney = ScriptableObject.CreateInstance<LosePlayerCurrencyEffect>();
            LoseMoney._loseFromPlayer = true;

            PerformEffect_Item bundleOfFingers = new PerformEffect_Item("BundleOfFingers_ID", null)
            {
                Item_ID = "BundleOfFingers_TW",
                Name = "Bundle Of Fingers",
                Flavour = "\"Why is this a thing?\"",
                Description = "This party member is 1 level higher than they otherwise would be. Lose 4 coins upon taking any damage.",
                IsShopItem = false,
                ShopPrice = 8,
                DoesPopUpInfo = true,
                StartsLocked = false,
                Icon = ResourceLoader.LoadSprite("TreasureBundleOfFingers"),
                TriggerOn = TriggerCalls.OnDamaged,
                Effects =
                [
                    Effects.GenerateEffect(LoseMoney, 4, Targeting.Slot_SelfSlot),
                ],
                EquippedModifiers =
                [
                    rankUp,
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(bundleOfFingers.Item, new ItemModdedUnlockInfo(bundleOfFingers.Item_ID, ResourceLoader.LoadSprite("TreasureBundleOfFingers")));
        }
    }
}
