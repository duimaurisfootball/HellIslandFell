using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class HornAndHandle
    {
        public static void Add()
        {
            UnboundedExtraLootEffect UnlimitedTreasure = ScriptableObject.CreateInstance<UnboundedExtraLootEffect>();
            UnlimitedTreasure._repeatChance = 90;
            UnlimitedTreasure._cycles = 5;
            UnlimitedTreasure._getLocked = true;
            UnlimitedTreasure._isTreasure = true;

            UnboundedExtraLootEffect UnlimitedGoods = ScriptableObject.CreateInstance<UnboundedExtraLootEffect>();
            UnlimitedGoods._repeatChance = 90;
            UnlimitedGoods._cycles = 5;
            UnlimitedGoods._getLocked = true;
            UnlimitedGoods._isTreasure = false;

            UnboundedExtraCurrencyEffect UnlimitedGold = ScriptableObject.CreateInstance<UnboundedExtraCurrencyEffect>();
            UnlimitedGold._repeatChance = 99;
            UnlimitedGold._cycles = 10;

            PerformEffect_Item hornAndHandle = new PerformEffect_Item("HornAndHandle_ID", null, false)
            {
                Item_ID = "HornAndHandle_EW",
                Name = "Horn And Handle",
                Flavour = "\"Some people never change.\"",
                Description = "Consume this item on combat end.\nProduces the material spoils of reality.",
                IsShopItem = false,
                ShopPrice = 99999999,
                DoesPopUpInfo = false,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("ExtraHornAndHandle"),
                TriggerOn = TriggerCalls.OnCombatEnd,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ConsumeItemEffect>(), 0, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(UnlimitedGold, -5, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(UnlimitedTreasure, -2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(UnlimitedGoods, -2, Targeting.Slot_SelfSlot),
                ],
            };

            ItemUtils.JustAddItemSoItCanBeLoaded(hornAndHandle.item);
        }
    }
}
