using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class FatesBoundByNemesis
    {
        public static void Add()
        {
            ExtraPassiveAbility_Wearable_SMS confusine = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            confusine._extraPassiveAbility = Passives.Confusion;

            ExtraPassiveAbility_Wearable_SMS rocky = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            rocky._extraPassiveAbility = Passives.Inanimate;

            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Nemesis_ID", out StatusEffect_SO Nemesis);
            StatusEffect_Apply_Effect NemesisApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            NemesisApply._Status = Nemesis;
            NemesisApply._JustOneRandomTarget = true;

            ExtraLootOptionsEffect NextNemesis = ScriptableObject.CreateInstance<ExtraLootOptionsEffect>();
            NextNemesis._itemName = "HornAndHandle_EW";

            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Disappearing_ID", out StatusEffect_SO Disappearing);
            StatusEffect_Apply_Effect DisappearingApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            DisappearingApply._Status = Disappearing;

            Nemesis_Item fatesNemesis = new Nemesis_Item("FatesBoundByNemesisItem_ID", null)
            {
                Item_ID = "FatesBoundByNemesis_NW",
                Name = "Fates Bound By Nemesis",
                Flavour = "\"...\"",
                Description = "...",
                IsShopItem = false,
                ShopPrice = 10,
                DoesPopUpInfo = true,
                StartsLocked = false,
                Icon = ResourceLoader.LoadSprite("ExtraFatesBoundByNemesis"),
                TriggerOn = TriggerCalls.OnCombatStart,
                NormalEffects =
                [
                    Effects.GenerateEffect(NemesisApply, 1, Targeting.Unit_AllOpponents),
                    Effects.GenerateEffect(DisappearingApply, 10, Targeting.Slot_SelfSlot),
                ],
                MurderEffects =
                [
                    Effects.GenerateEffect(DisappearingApply, 10, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ConsumeItemEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(NextNemesis),
                ],
                EquippedModifiers =
                [
                    confusine,
                    rocky,
                ],
            };

            fatesNemesis.item._ItemTypeIDs =
                [
                    ItemType_GameIDs.Magic.ToString(),
                ];

            ItemUtils.JustAddItemSoItCanBeLoaded(fatesNemesis.item);
        }
    }
}
