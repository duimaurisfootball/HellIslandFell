using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class SparklingFork
    {
        public static void Add()
        {
            SwapToOneSideEffect MoveLeft = ScriptableObject.CreateInstance<SwapToOneSideEffect>();
            MoveLeft._swapRight = false;

            SwapToOneSideEffect MoveRight = ScriptableObject.CreateInstance<SwapToOneSideEffect>();
            MoveRight._swapRight = true;

            DoublePerformEffect_Item sparklingFork = new DoublePerformEffect_Item("SparklingFork_SW", null, false)
            {
                Item_ID = "SparklingFork_SW",
                Name = "Sparkling Fork",
                Flavour = "\"Polished firestarter and utensil.\"",
                Description = "Upon receiving direct damage, move this party member to the left.\nUpon performing an ability, move this party member to the right.",
                IsShopItem = true,
                ShopPrice = 3,
                DoesPopUpInfo = false,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("ShopSparklingFork"),
                Effects =
                [
                    Effects.GenerateEffect(MoveLeft, 1, Targeting.Slot_SelfSlot),
                ],
                TriggerOn = TriggerCalls.OnDirectDamaged,
                SecondaryEffects =
                [
                    Effects.GenerateEffect(MoveRight, 1, Targeting.Slot_SelfSlot),
                ],
                SecondaryTriggerOn =
                [
                    TriggerCalls.OnAbilityUsed,
                ],
            };

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(sparklingFork.Item, new ItemModdedUnlockInfo("SparklingFork_SW", ResourceLoader.LoadSprite("ShopSparklingForkLocked", null, 32, null), "HIF_Boojum_Comedy_ACH"));
        }
    }
}
