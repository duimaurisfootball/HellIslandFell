using BrutalAPI.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class EnamelSandpaper
    {
        public static void Add()
        {
            RandomDamageBetweenPreviousAndEntryEffect IndirectDamage = ScriptableObject.CreateInstance<RandomDamageBetweenPreviousAndEntryEffect>();
            IndirectDamage._indirect = true;

            PerformEffect_Item enamelSandpaper = new PerformEffect_Item("EnamelSandpaper_ID", null, false)
            {
                Item_ID = "EnamelSandpaper_SW",
                Name = "Enamel Sandpaper",
                Flavour = "\"For very very white teeth.\"",
                Description = "Upon performing an ability, deal 2-4 indirect damage to this party member and refresh their ability usage.",
                IsShopItem = true,
                ShopPrice = 5,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockHeavenNick"),
                TriggerOn = TriggerCalls.OnAbilityUsed,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(IndirectDamage, 4, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 1, Targeting.Slot_SelfSlot),
                ],
            };

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(enamelSandpaper.Item, new ItemModdedUnlockInfo("EnamelSandpaper_SW", ResourceLoader.LoadSprite("UnlockHeavenNickLocked", null, 32, null), "HIF_Nick_Divine_ACH"));
        }
    }
}
