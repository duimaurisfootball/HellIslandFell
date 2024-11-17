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
            LootItemProbability food0;
            food0.itemName = "BalticBrine_SW";
            food0.probability = 20;
            LootItemProbability food1;
            food1.itemName = "Cano'Worms_SW";
            food1.probability = 20;
            LootItemProbability food2;
            food2.itemName = "MysteryRation_SW";
            food2.probability = 20;
            LootItemProbability food3;
            food3.itemName = "Vyacheslav'sLastsip_SW";
            food3.probability = 10;
            LootItemProbability food4;
            food4.itemName = "FunnyMushrooms_TW";
            food4.probability = 14;
            LootItemProbability food5;
            food5.itemName = "LumpofLamb_TW";
            food5.probability = 2;
            LootItemProbability food6;
            food6.itemName = "MommaNooty_TW";
            food6.probability = 15;
            LootItemProbability food7;
            food7.itemName = "RuntyRotter_TW";
            food7.probability = 5;
            LootItemProbability food8;
            food8.itemName = "TaintedApple_TW";
            food8.probability = 20;
            LootItemProbability food9;
            food9.itemName = "AGift?_TW";
            food9.probability = 20;
            LootItemProbability food10;
            food10.itemName = "AsceticEgg_TW";
            food10.probability = 5;
            LootItemProbability food11;
            food11.itemName = "Bananas_TW";
            food11.probability = 20;
            LootItemProbability food12;
            food12.itemName = "DivineMud_TW";
            food12.probability = 10;
            LootItemProbability food13;
            food13.itemName = "EggofIncubus_TW";
            food13.probability = 2;
            LootItemProbability food14;
            food14.itemName = "GamifiedCephalopod_TW";
            food14.probability = 20;
            LootItemProbability food15;
            food15.itemName = "HarvestandPlenty_TW";
            food15.probability = 10;
            LootItemProbability food16;
            food16.itemName = "HolyChalice_TW";
            food16.probability = 10;
            LootItemProbability food17;
            food17.itemName = "LustPudding_TW";
            food17.probability = 10;
            LootItemProbability food18;
            food18.itemName = "MeatreWorm_TW";
            food18.probability = 10;
            LootItemProbability food19;
            food19.itemName = "OpulentEgg_TW";
            food19.probability = 2;
            LootItemProbability food20;
            food20.itemName = "SeedsoftheConsumed_TW";
            food20.probability = 20;
            LootItemProbability food21;
            food21.itemName = "SkinnedSkate_TW";
            food21.probability = 20;
            LootItemProbability food22;
            food22.itemName = "StarvingApples_TW";
            food22.probability = 18;
            LootItemProbability food23;
            food23.itemName = "StrangeFruit_TW";
            food23.probability = 20;
            LootItemProbability food24;
            food24.itemName = "TheApple_TW";
            food24.probability = 14;
            LootItemProbability food25;
            food25.itemName = "TheFirstBorn_TW";
            food25.probability = 5;
            LootItemProbability food26;
            food26.itemName = "BavarianPretzel_TW";
            food26.probability = 3;
            LootItemProbability food27;
            food27.itemName = "CheesePlate_TW";
            food27.probability = 2;
            LootItemProbability food28;
            food28.itemName = "FesterFlesh_TW";
            food28.probability = 5;
            LootItemProbability food29;
            food29.itemName = "OneThousandFish_TW";
            food29.probability = 2;
            LootItemProbability food30;
            food30.itemName = "LilOrro_TW";
            food30.probability = 5;
            LootItemProbability food31;
            food31.itemName = "BloodBottle_SW";
            food31.probability = 20;
            LootItemProbability food32;
            food32.itemName = "MedicalLeeches_SW";
            food32.probability = 10;
            LootItemProbability food33;
            food33.itemName = "LilHomunculus_TW";
            food33.probability = 5;

            ExtraLootListEffect foodList = ScriptableObject.CreateInstance<ExtraLootListEffect>();
            foodList._treasurePercentage = 0;
            foodList._nothingPercentage = 0;
            foodList._shopPercentage = 0;
            foodList._lootableItems =
                [
                    food0,
                    food1,
                    food2,
                    food3,
                    food4,
                    food5,
                    food6,
                    food7,
                    food8,
                    food9,
                    food10,
                    food11,
                    food12,
                    food13,
                    food14,
                    food15,
                    food16,
                    food17,
                    food18,
                    food19,
                    food20,
                    food21,
                    food22,
                    food23,
                    food24,
                    food25,
                    food26,
                    food27,
                    food28,
                    food29,
                    food30,
                    food31,
                    food32,
                    food33,
                ];
            foodList._lockedLootableItems =
                [

                ];

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
