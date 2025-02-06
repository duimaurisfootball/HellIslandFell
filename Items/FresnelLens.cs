using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class FresnelLens
    {
        public static void Add()
        {
            GenerateRandomManaBetweenEffect RainbowGenerate = ScriptableObject.CreateInstance<GenerateRandomManaBetweenEffect>();
            RainbowGenerate.possibleMana = [Pigments.Red, Pigments.Blue, Pigments.Yellow, Pigments.Purple];

            ExtraPassiveAbility_Wearable_SMS rainbow = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            rainbow._extraPassiveAbility = Passives.EssenceUntethered;

            MultiCustomTriggerEffectItem fresnelLens = new MultiCustomTriggerEffectItem("FresnelLens_ID")
            {
                Item_ID = "FresnelLens_SW",
                Name = "Fresnel Lens",
                Flavour = "\"The invention that saved a million ships.\"",
                Description = "This party member has Untethered Essence as a passive. Produce a random pigment upon lucky pigment triggering.",
                IsShopItem = true,
                ShopPrice = 1,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanNaba"),
                EffectsAndTrigger =
                [
                    new EffectsAndCustomTriggerPair()
                    {
                        customTrigger = LuckyPigmentTriggerPatch.OnLuckyPigmentSuccess,
                        effects =
                        [
                            Effects.GenerateEffect(RainbowGenerate, 1, Targeting.Slot_SelfSlot),
                        ],
                        doesPopup = true,
                    },
                ],
                EquippedModifiers =
                [
                    rainbow,
                ],
            };

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(fresnelLens.Item, new ItemModdedUnlockInfo("FresnelLens_SW", ResourceLoader.LoadSprite("UnlockOsmanNabaLocked", null, 32, null), "HIF_Naba_Osman_ACH"));
        }
    }
}
