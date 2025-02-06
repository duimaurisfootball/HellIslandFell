using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class BrailleTypewriter
    {
        public static void Add()
        {
            ExtraPassiveAbility_Wearable_SMS essencie = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            essencie._extraPassiveAbility = Passives.EssenceUntethered;

            ChangeToRandomHealthColorEffect randomizeColor = ScriptableObject.CreateInstance<ChangeToRandomHealthColorEffect>();
            randomizeColor._healthColors = [Pigments.Red, Pigments.Yellow, Pigments.Blue, Pigments.Purple, Pigments.Grey];

            TypewriterRedHealthEffect redHealth = ScriptableObject.CreateInstance<TypewriterRedHealthEffect>();

            PerformEffect_Item brailleTypewriter = new PerformEffect_Item("BrailleTypewriter_ID", null)
            {
                Item_ID = "BrailleTypewriter_SW",
                Name = "Braille Typewriter",
                Flavour = "\"Tap tap tap, click click click.\"",
                Description = "This party member now has Untethered Essence as a passive. Randomize the health of every enemy on combat start. One enemy will always be red.",
                IsShopItem = true,
                ShopPrice = 5,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanChim"),
                TriggerOn = TriggerCalls.OnCombatStart,
                Effects =
                [
                    Effects.GenerateEffect(randomizeColor, 1, Targeting.Unit_AllOpponents),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<TypewriterRedHealthEffect>(), 1, Targeting.Unit_AllOpponents),
                ],
                EquippedModifiers =
                [
                    essencie
                ],
            };

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(brailleTypewriter.Item, new ItemModdedUnlockInfo("BrailleTypewriter_SW", ResourceLoader.LoadSprite("UnlockOsmanChimLocked", null, 32, null), "HIF_Chim_Witness_ACH"));
        }
    }
}
