using BrutalAPI.Items;
using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class IridescentCrystal
    {
        public static void Add()
        {
            ChangePigmentGeneratorPool_Effect TripleSplits = ScriptableObject.CreateInstance<ChangePigmentGeneratorPool_Effect>();
            TripleSplits._newPool =
                [
                    Pigments.SplitPigment(Pigments.Red, Pigments.Blue, Pigments.Purple),
                    Pigments.SplitPigment(Pigments.Blue, Pigments.Purple, Pigments.Yellow),
                    Pigments.SplitPigment(Pigments.Purple, Pigments.Yellow, Pigments.Red),
                    Pigments.SplitPigment(Pigments.Yellow, Pigments.Red, Pigments.Blue),
                ];

            DoublePerformEffect_Item iridescentCrystal = new DoublePerformEffect_Item("IridescentCrystal_ID", null, false)
            {
                Item_ID = "IridescentCrystal_TW",
                Name = "Iridescent Crystal",
                Flavour = "\"Nature's most angular rainbow.\"",
                Description = "The yellow pigment generator now generates random triple split pigment. Upon this party member using an ability, refill the pigment generator.",
                IsShopItem = false,
                ShopPrice = 6,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockHeavenSpoogle"),
                TriggerOn = TriggerCalls.OnCombatStart,
                Effects =
                [
                    Effects.GenerateEffect(TripleSplits, 1, Targeting.Slot_SelfSlot),
                ],
                SecondaryTriggerOn = [TriggerCalls.OnAbilityUsed],
                SecondaryEffects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<FillYellowManaBar_Effect>(), 1, Targeting.Slot_SelfSlot),
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(iridescentCrystal.Item, new ItemModdedUnlockInfo("IridescentCrystal_TW", ResourceLoader.LoadSprite("UnlockHeavenSpoogleLocked", null, 32, null), "HIF_Spoogle_Divine_ACH"));
        }
    }
}
