using BrutalAPI.Items;
using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class CursedLeg
    {
        public static void Add()
        {
            StatusEffect_Apply_Effect CursedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            CursedApply._Status = StatusField.Cursed;

            PercentageEffectCondition FingerChance = ScriptableObject.CreateInstance<PercentageEffectCondition>();
            FingerChance.percentage = 50;

            PercentageEffectCondition OthersChance = ScriptableObject.CreateInstance<PercentageEffectCondition>();
            OthersChance.percentage = 1;

            RestoreSwapUseByStatusEffectEffect RestoreCursed = ScriptableObject.CreateInstance<RestoreSwapUseByStatusEffectEffect>();
            RestoreCursed._chance = 75;
            RestoreCursed._status = StatusField.Cursed;

            ExtraLootOptionsEffect Fingered = ScriptableObject.CreateInstance<ExtraLootOptionsEffect>();
            Fingered._changeOption = true;
            Fingered._itemName = "CurlingFinger_OW";

            ExtraLootOptionsEffect Caged = ScriptableObject.CreateInstance<ExtraLootOptionsEffect>();
            Caged._changeOption = true;
            Caged._itemName = "AccursedRibcage_TW";

            ExtraLootOptionsEffect Legged = ScriptableObject.CreateInstance<ExtraLootOptionsEffect>();
            Legged._changeOption = true;
            Legged._itemName = "CursedLeg_TW";

            DoublePerformEffect_Item cursedLeg = new DoublePerformEffect_Item("AccursedRibcage_ID", null, false)
            {
                Item_ID = "CursedLeg_TW",
                Name = "Cursed Leg",
                Flavour = "\"Run, coward!!!\"",
                Description = "Curse this party member on combat start. Upon this party member moving themself, 75% chance to restore each cursed party member's movement.\n\nThe skeleton this leg belongs to will find you, sort of.",
                IsShopItem = false,
                ShopPrice = -10,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockHeavenRodney"),
                TriggerOn = TriggerCalls.OnCombatStart,
                Effects =
                [
                    Effects.GenerateEffect(CursedApply, 1, Targeting.Slot_SelfSlot),
                ],
                SecondaryTriggerOn = [TriggerCalls.OnSwapTo],
                SecondaryEffects =
                [
                    Effects.GenerateEffect(RestoreCursed, 1, Targeting.Slot_AllyAllSlots),
                    Effects.GenerateEffect(Fingered, 1, Targeting.Slot_SelfSlot, FingerChance),
                    Effects.GenerateEffect(Caged, 1, Targeting.Slot_SelfSlot, OthersChance),
                    Effects.GenerateEffect(Legged, 1, Targeting.Slot_SelfSlot, OthersChance),
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(cursedLeg.Item, new ItemModdedUnlockInfo("CursedLeg_TW", ResourceLoader.LoadSprite("UnlockHeavenRodneyLocked", null, 32, null), "HIF_Rodney_Divine_ACH"));
        }
    }
}
