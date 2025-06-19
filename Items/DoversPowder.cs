using BrutalAPI.Items;
using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class DoversPowder
    {
        public static void Add()
        {
            PercentageEffectCondition RemoveChance = ScriptableObject.CreateInstance<PercentageEffectCondition>();
            RemoveChance.percentage = 40;

            DoublePerformEffect_Item doversPowder = new DoublePerformEffect_Item("DoversPowder_ID", null, false)
            {
                Item_ID = "DoversPowder_SW",
                Name = "Dover's Powder",
                Flavour = "\"The sweat of anticipation! There's so much of it!\"",
                Description = "40% chance to remove a random timeline ability on turn start. Reroll a random timeline ability on turn end.",
                IsShopItem = true,
                ShopPrice = 4,
                DoesPopUpInfo = false,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanFarah"),
                TriggerOn = TriggerCalls.OnTurnStart,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<PopUpCasterItemInfoEffect>(), 1, Targeting.Slot_SelfSlot, RemoveChance),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RemoveRandomTimelineAbility>(), 1, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                ],
                SecondaryTriggerOn = [TriggerCalls.OnTurnFinished],
                SecondaryEffects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ReRollRandomTimelineAbilityEffect>(), 1, Targeting.Slot_SelfSlot),
                ]
            };

            doversPowder.item._ItemTypeIDs =
                [
                    "FoodID",
                ];

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(doversPowder.Item, new ItemModdedUnlockInfo("DoversPowder_SW", ResourceLoader.LoadSprite("UnlockOsmanFarahLocked", null, 32, null), "HIF_Farah_Witness_ACH"));
        }
    }
}
