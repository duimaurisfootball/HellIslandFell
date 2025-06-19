using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class GreenGlass
    {
        public static void Add()
        {
            ChangePigmentGeneratorPool_Effect TearsGenerator = ScriptableObject.CreateInstance<ChangePigmentGeneratorPool_Effect>();
            TearsGenerator._newPool = [Pigments.Blue];

            RandomizeCostsToColorsEffect BlueCosts = ScriptableObject.CreateInstance<RandomizeCostsToColorsEffect>();
            BlueCosts._mana = [Pigments.Blue];

            PerformEffect_Item greenGlass = new PerformEffect_Item("GreenGlass_ID", null)
            {
                Item_ID = "GreenGlass_SW",
                Name = "Green Glass",
                Flavour = "\"Push me further, further from the sun.\"",
                Description = "The yellow pigment generator now generates blue pigment. Increase lucky pigment chance to 99%. Change this party member's costs to blue on combat start.",
                IsShopItem = true,
                ShopPrice = 5,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanStareyed"),
                TriggerOn = TriggerCalls.OnCombatStart,
                Effects =
                [
                    Effects.GenerateEffect(TearsGenerator, 1),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<LuckyBluePercentageSetEffect>(), 99),
                    Effects.GenerateEffect(BlueCosts, 1, Targeting.Slot_SelfSlot),
                ],
            };

            greenGlass.item._ItemTypeIDs =
                [
                    ItemType_GameIDs.Magic.ToString(),
                ];

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(greenGlass.Item, new ItemModdedUnlockInfo("GreenGlass_SW", ResourceLoader.LoadSprite("UnlockOsmanStareyedLocked", null, 32, null), "HIF_Stareyed_Witness_ACH"));
        }
    }
}
