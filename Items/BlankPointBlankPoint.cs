using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class BlankPointBlankPoint
    {
        public static void Add()
        {
            StatusEffectCheckerEffect IsFocused = ScriptableObject.CreateInstance<StatusEffectCheckerEffect>();
            IsFocused._status = StatusField.Focused;

            StatusEffect_Apply_Effect FocusedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            FocusedApply._Status = StatusField.Focused;

            SpecialDamageEffect CasterlessDamage = ScriptableObject.CreateInstance<SpecialDamageEffect>();
            CasterlessDamage._selfCast = false;
            CasterlessDamage._damageType = CombatType_GameIDs.Dmg_Normal.ToString();

            PerformEffect_Item blankPointBlankPoint = new PerformEffect_Item("BlankPointBlankPoint_ID", null, false)
            {
                Item_ID = "BlankPointBlankPoint_SW",
                Name = "Blank Point Blank Point",
                Flavour = "\"Probably still hurts from this distance.\"",
                Description = "On turn start, if this party member is Focused, deal 2 damage to them. Otherwise, Focus this party member.",
                IsShopItem = true,
                ShopPrice = 5,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanNick"),
                TriggerOn = TriggerCalls.OnTurnStart,
                Effects =
                [
                    Effects.GenerateEffect(IsFocused, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(CasterlessDamage, 2, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(FocusedApply, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 2)),
                ],
            };

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(blankPointBlankPoint.Item, new ItemModdedUnlockInfo("BlankPointBlankPoint_SW", ResourceLoader.LoadSprite("UnlockOsmanNickLocked", null, 32, null), "HIF_Nick_Witness_ACH"));
        }
    }
}
