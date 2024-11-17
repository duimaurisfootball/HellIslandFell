using BrutalAPI.Items;
using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class Hyperfixation
    {
        public static void Add()
        {
            PercentageEffectCondition DestructionChance = ScriptableObject.CreateInstance<PercentageEffectCondition>();
            DestructionChance.percentage = 4;

            PerformEffect_Item hyperfixation = new PerformEffect_Item("Hyperfixation_ID", null, false)
            {
                Item_ID = "Hyperfixation_TW",
                Name = "Hyperfixation",
                Flavour = "\"We're looking into it further.\"",
                Description = "Gain 2 coins every time an enemy dies. 4% chance to be destroyed on use.",
                IsShopItem = false,
                ShopPrice = 5,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockHeavenSalad"),
                TriggerOn = TriggerCalls.OnOpponentHasDied,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<GainPlayerCurrencyEffect>(), 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ConsumeItemEffect>(), 1, Targeting.Slot_SelfSlot, DestructionChance),
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(hyperfixation.Item, new ItemModdedUnlockInfo("Hyperfixation_TW", ResourceLoader.LoadSprite("UnlockHeavenSaladLocked", null, 32, null), "HIF_Salad_Divine_ACH"));
        }
    }
}
