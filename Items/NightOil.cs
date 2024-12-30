using BrutalAPI.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class NightOil
    {
        public static void Add()
        {
            ChangePigmentGeneratorPool_Effect StarGenerator = ScriptableObject.CreateInstance<ChangePigmentGeneratorPool_Effect>();
            StarGenerator._newPool = [Pigments.Purple];

            DoublePerformEffect_Item nightOil = new DoublePerformEffect_Item("NightOil_ID", null, false)
            {
                Item_ID = "NightOil_SW",
                Name = "Night Oil",
                Flavour = "\"Little stars dance in the blackness.\"",
                Description = "The yellow pigment generator now generates purple pigment. Attempt to revive one party member on combat end.",
                IsShopItem = true,
                ShopPrice = 3,
                DoesPopUpInfo = true,
                StartsLocked = true,
                TriggerOn = TriggerCalls.OnCombatStart,
                SecondaryTriggerOn =
                [
                    TriggerCalls.OnCombatEnd
                ],
                Icon = ResourceLoader.LoadSprite("UnlockOsmanMaecenas"),
                Effects =
                [
                    Effects.GenerateEffect(StarGenerator, 1, Targeting.Slot_SelfSlot),
                ],
                SecondaryEffects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ResurrectEffect>(), 1, Targeting.Slot_AllyAllSlots),
                ],
            };

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(nightOil.Item, new ItemModdedUnlockInfo("NightOil_SW", ResourceLoader.LoadSprite("UnlockOsmanMaecenasLocked", null, 32, null), "HIF_Maecenas_Witness_ACH"));
        }
    }
}
