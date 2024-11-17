using BrutalAPI.Items;
using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Hell_Island_Fell.Custom_Effects;

namespace Hell_Island_Fell.Items
{
    public class AccursedRibcage
    {
        public static void Add()
        {
            StatusEffect_Apply_Effect CursedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            CursedApply._Status = StatusField.Cursed;

            PercentageEffectCondition FingerChance = ScriptableObject.CreateInstance<PercentageEffectCondition>();
            FingerChance.percentage = 50;

            PercentageEffectCondition OthersChance = ScriptableObject.CreateInstance<PercentageEffectCondition>();
            OthersChance.percentage = 1;

            RefreshAbilityUsageByStatusEffectEffect RefreshCursed = ScriptableObject.CreateInstance<RefreshAbilityUsageByStatusEffectEffect>();
            RefreshCursed._chance = 60;
            RefreshCursed._status = StatusField.Cursed;

            ExtraLootOptionsEffect Fingered = ScriptableObject.CreateInstance<ExtraLootOptionsEffect>();
            Fingered._changeOption = true;
            Fingered._itemName = "CurlingFinger_OW";

            ExtraLootOptionsEffect Caged = ScriptableObject.CreateInstance<ExtraLootOptionsEffect>();
            Caged._changeOption = true;
            Caged._itemName = "AccursedRibcage_TW";

            ExtraLootOptionsEffect Legged = ScriptableObject.CreateInstance<ExtraLootOptionsEffect>();
            Legged._changeOption = true;
            Legged._itemName = "CursedLeg_TW";

            DoublePerformEffect_Item accursedRibcage = new DoublePerformEffect_Item("AccursedRibcage_ID", null, false)
            {
                Item_ID = "AccursedRibcage_TW",
                Name = "Accursed Ribcage",
                Flavour = "\"aa-HOOOOOOOGHH!!!\"",
                Description = "Curse this party member on combat start. Upon this party member performing an ability, 60% chance to refresh each Cursed party member.\n\nThe skeleton this ribcage belongs to will find you, sort of.",
                IsShopItem = false,
                ShopPrice = -10,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanRodney"),
                TriggerOn = TriggerCalls.OnCombatStart,
                Effects =
                [
                    Effects.GenerateEffect(CursedApply, 1, Targeting.Slot_SelfSlot),
                ],
                SecondaryTriggerOn = [TriggerCalls.OnAbilityUsed],
                SecondaryEffects =
                [
                    Effects.GenerateEffect(RefreshCursed, 1, Targeting.Slot_AllyAllSlots),
                    Effects.GenerateEffect(Fingered, 1, Targeting.Slot_SelfSlot, FingerChance),
                    Effects.GenerateEffect(Caged, 1, Targeting.Slot_SelfSlot, OthersChance),
                    Effects.GenerateEffect(Legged, 1, Targeting.Slot_SelfSlot, OthersChance),
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(accursedRibcage.Item, new ItemModdedUnlockInfo("AccursedRibcage_TW", ResourceLoader.LoadSprite("UnlockOsmanRodneyLocked", null, 32, null), "HIF_Rodney_Witness_ACH"));
        }
    }
}
