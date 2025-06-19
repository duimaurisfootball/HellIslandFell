using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class InvincibleNemesis
    {
        public static void Add()
        {
            ExtraPassiveAbility_Wearable_SMS diey = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            diey._extraPassiveAbility = Passives.Dying;

            ExtraPassiveAbility_Wearable_SMS handy = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            handy._extraPassiveAbility = Passives.GetCustomPassive("Mirage_PA");

            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Nemesis_ID", out StatusEffect_SO Nemesis);
            StatusEffect_Apply_Effect NemesisApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            NemesisApply._Status = Nemesis;
            NemesisApply._JustOneRandomTarget = true;

            ExtraLootOptionsEffect NextNemesis = ScriptableObject.CreateInstance<ExtraLootOptionsEffect>();
            NextNemesis._itemName = "FatesBoundByNemesis_NW";

            DamageEffect Damage = ScriptableObject.CreateInstance<DamageEffect>();

            Nemesis_Item invincibleNemesis = new Nemesis_Item("InvincibleNemesisItem_ID", null)
            {
                Item_ID = "InvincibleNemesis_NW",
                Name = "Invincible Nemesis",
                Flavour = "\"I can't escape her, even down here?\"",
                Description = "You know how this goes.",
                IsShopItem = false,
                ShopPrice = 9,
                DoesPopUpInfo = true,
                StartsLocked = false,
                Icon = ResourceLoader.LoadSprite("ExtraInvincibleNemesis"),
                TriggerOn = TriggerCalls.OnCombatStart,
                NormalEffects =
                [
                    Effects.GenerateEffect(NemesisApply, 1, Targeting.Unit_AllOpponents),
                    Effects.GenerateEffect(Damage, 3, Targeting.Slot_SelfSlot),
                ],
                MurderEffects =
                [
                    Effects.GenerateEffect(Damage, 3, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ConsumeItemEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(NextNemesis),
                ],
                EquippedModifiers =
                [
                    diey,
                    handy,
                ],
            };

            invincibleNemesis.item._ItemTypeIDs =
                [
                    ItemType_GameIDs.Magic.ToString(),
                ];

            ItemUtils.JustAddItemSoItCanBeLoaded(invincibleNemesis.item);
        }
    }
}
