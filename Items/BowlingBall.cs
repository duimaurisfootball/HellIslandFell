using BrutalAPI;
using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class BowlingBall
    {
        public static void Add()
        {
            PercentageEffectCondition lootChance = ScriptableObject.CreateInstance<PercentageEffectCondition>();
            lootChance.percentage = 25;

            DoublePerformEffect_Item bowlingBall = new DoublePerformEffect_Item("BowlingBall_ID", null)
            {
                Item_ID = "BowlingBall_SW",
                Name = "Bowling Ball",
                Flavour = "\"Knock 'em down.\"",
                Description = "Upon this party member killing anything, there is a 25% chance to produce a random item. Messes with future shops and treasure chests.",
                IsShopItem = true,
                ShopPrice = 4,
                DoesPopUpInfo = false,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanFelix"),
                TriggerOn = TriggerCalls.OnKill,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraLootRandomEffect>(), 1, Targeting.Slot_SelfSlot, lootChance),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<PopUpCasterItemInfoEffect>(), 1, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                ],
                SecondaryDoesPopUpInfo = false,
                SecondaryTriggerOn = [TriggerCalls.OnCombatEnd],
                SecondaryEffects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ChaosLootReplaceEffect>(), 83, Targeting.Slot_SelfSlot),
                ],
            };
            ItemUtils.AddItemToShopStatsCategoryAndGamePool(bowlingBall.Item, new ItemModdedUnlockInfo("BowlingBall_SW", ResourceLoader.LoadSprite("UnlockOsmanFelixLocked", null, 32, null), "HIF_Felix_Witness_ACH"));
        }
    }
}
