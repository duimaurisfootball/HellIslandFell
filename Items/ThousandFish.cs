using BrutalAPI.Items;
using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class ThousandFish
    {
        public static void Add()
        {
            ChangePigmentGeneratorPool_Effect BloodGenerator = ScriptableObject.CreateInstance<ChangePigmentGeneratorPool_Effect>();
            BloodGenerator._newPool = [Pigments.Red];

            DoublePerformEffect_Item thousandFish = new DoublePerformEffect_Item("ThousandFish_ID", null, false)
            {
                Item_ID = "ThousandFish_TW",
                Name = "Thousand Fish",
                Flavour = "\"Where did all this blood come from?\"",
                Description = "The yellow pigment generator now generates red pigment. Gain 2 coins on combat end.",
                IsShopItem = false,
                ShopPrice = 9,
                DoesPopUpInfo = true,
                StartsLocked = true,
                TriggerOn = TriggerCalls.OnCombatStart,
                SecondaryTriggerOn = 
                [
                    TriggerCalls.OnCombatEnd
                ],
                Icon = ResourceLoader.LoadSprite("UnlockHeavenVandander"),
                Effects =
                [
                    Effects.GenerateEffect(BloodGenerator, 1, Targeting.Slot_SelfSlot),
                ],
                SecondaryEffects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<GainPlayerCurrencyEffect>(), 2, Targeting.Slot_SelfSlot),
                ],
            };

            thousandFish.item._ItemTypeIDs =
                [
                    "FoodID",
                ];

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(thousandFish.Item, new ItemModdedUnlockInfo("ThousandFish_TW", ResourceLoader.LoadSprite("UnlockHeavenVandanderLocked", null, 32, null), "HIF_Vandander_Divine_ACH"));
        }
    }
}
