using BrutalAPI.Items;
using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class CheesePlate
    {
        public static void Add()
        {
            List<LootItemProbability> Food =
                [
                    new("BalticBrine_SW", 20),
                    new("Cano'Worms_SW", 10),
                    new("MysteryRation_SW", 20),
                    new("Vyacheslav'sLastSip_SW", 20),
                    new("FunnyMushrooms_TW", 14),
                    new("LumpofLamb_TW", 2),
                    new("MommaNooty_TW", 5),
                    new("RuntyRotter_TW", 5),
                    new("TaintedApple_TW", 20),
                    new("AGift?_TW", 10),
                    new("AsceticEgg_TW", 5),
                    new("Bananas_TW", 20),
                    new("DivineMud_TW", 10),
                    new("EggofIncubus_TW", 5),
                    new("GamifiedCephalopod_TW", 10),
                    new("HarvestandPlenty_TW", 10),
                    new("HolyChalice_TW", 10),
                    new("LustPudding_TW", 10),
                    new("MeatreWorm_TW", 20),
                    new("OpulentEgg_TW", 2),
                    new("SeedsoftheConsumed_TW", 10),
                    new("SkinnedSkate_TW", 7),
                    new("StarvingApples_TW", 18),
                    new("StrangeFruit_TW", 9),
                    new("TheApple_TW", 14),
                    new("TheFirstBorn_TW", 5),
                    new("BavarianPretzel_TW", 3),
                    new("CheesePlate_TW", 1),
                    new("FesterFlesh_TW", 5),
                    new("OneThousandFish_TW", 5),
                    new("LilOrro_TW", 5),
                    new("BloodBottle_SW", 10),
                    new("MedicalLeeches_SW", 10),
                    new("LilHomunculus_TW", 5),
                    new("FormidableDinners_TW", 10),
                    new("FetidTooth_TW", 4),
                    new("BismuthSubsalicylate_SW", 5),
                    new("AncientWine_SW", 5),
                    new("Blastocyst_TW", 5),
                ];

            ExtraLootListEffect foodList = ScriptableObject.CreateInstance<ExtraLootListEffect>();
            foodList._treasurePercentage = 0;
            foodList._nothingPercentage = 0;
            foodList._shopPercentage = 0;
            foodList._lootableItems = Food;
            foodList._lockedLootableItems = [];

            PercentageEffectCondition foodChance = ScriptableObject.CreateInstance<PercentageEffectCondition>();
            foodChance.percentage = 50;

            PerformEffect_Item cheesePlate = new PerformEffect_Item("CheesePlate_ID", null)
            {
                Item_ID = "CheesePlate_SW",
                Name = "Cheese Plate",
                Flavour = "\"Also has olives and capers.\"",
                Description = "Cooks 0-3 \"Food\" items at the end of combat.",
                IsShopItem = true,
                ShopPrice = 9,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanAlvinar"),
                TriggerOn = TriggerCalls.OnCombatEnd,
                Effects =
                [
                    Effects.GenerateEffect(foodList, 1, Targeting.Slot_SelfSlot, foodChance),
                    Effects.GenerateEffect(foodList, 2, Targeting.Slot_SelfSlot, foodChance),
                ],
            };

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(cheesePlate.Item, new ItemModdedUnlockInfo("CheesePlate_SW", ResourceLoader.LoadSprite("UnlockOsmanAlvinarLocked", null, 32, null), "HIF_Alvinar_Witness_ACH"));
        }
    }
}
