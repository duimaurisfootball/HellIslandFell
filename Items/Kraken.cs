using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class Kraken
    {
        public static void Add()
        {
            UnboundedAddRandomTimelineAbilityEffect KrakenPower = ScriptableObject.CreateInstance<UnboundedAddRandomTimelineAbilityEffect>();
            KrakenPower._repeatChance = 50;
            KrakenPower._cycles = 6;

            ExtraCurrencyEffect KrakenRiches = ScriptableObject.CreateInstance<ExtraCurrencyEffect>();
            KrakenRiches._isMultiplier = true;

            DoublePerformEffect_Item kraken = new DoublePerformEffect_Item("Kraken_ID", null)
            {
                Item_ID = "Kraken_FW",
                Name = "Kraken",
                Flavour = "\"She brings the riches and terrors of the seven seas.\"",
                Description = "Add at least 3 additional attacks to the timeline on turn start. Gain 3x as many coins at the end of combat. 8% chance to be consumed on combat end.",
                IsShopItem = false,
                ShopPrice = 5,
                DoesPopUpInfo = true,
                StartsLocked = true,
                UsesSpecialUnlockText = true,
                SpecialUnlockID = UILocID.ItemFishLocationLabel,
                Icon = ResourceLoader.LoadSprite("UnlockHeavenNaba"),
                TriggerOn = TriggerCalls.OnTurnStart,
                Effects =
                [
                    Effects.GenerateEffect(KrakenPower, -3, Targeting.Unit_AllOpponents),
                ],
                SecondaryDoesPopUpInfo = true,
                SecondaryTriggerOn =
                [
                    TriggerCalls.OnCombatEnd,
                ],
                SecondaryEffects =
                [
                    Effects.GenerateEffect(KrakenRiches, 3, Targeting.Unit_AllOpponents),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ConsumeItemEffect>(), 1, Targeting.Unit_AllOpponents, Effects.ChanceCondition(8)),
                ],
            };

            ItemUtils.JustAddItemSoItCanBeLoaded(kraken.Item);
            ItemUtils.AddItemFishingRodPool(kraken.Item, 3, true);
            ItemUtils.AddItemCanOfWormsPool(kraken.Item, 8, true);
        }
    }
}
