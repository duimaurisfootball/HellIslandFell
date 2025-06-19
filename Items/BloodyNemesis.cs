using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class BloodyNemesis
    {
        public static void Add()
        {
            ExtraPassiveAbility_Wearable_SMS withery = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            withery._extraPassiveAbility = Passives.Withering;

            ExtraPassiveAbility_Wearable_SMS flowery = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            flowery._extraPassiveAbility = Passives.Delicate;

            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Nemesis_ID", out StatusEffect_SO Nemesis);
            StatusEffect_Apply_Effect NemesisApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            NemesisApply._Status = Nemesis;
            NemesisApply._JustOneRandomTarget = true;

            ExtraLootOptionsEffect NextNemesis = ScriptableObject.CreateInstance<ExtraLootOptionsEffect>();
            NextNemesis._itemName = "BatteredNemesis_NW";

            StatusEffect_Apply_Effect RupturedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            RupturedApply._Status = StatusField.Ruptured;

            Nemesis_Item bloodyNemesis = new Nemesis_Item("BloodyNemesisItem_ID", null)
            {
                Item_ID = "BloodyNemesis_NW",
                Name = "Bloody Nemesis",
                Flavour = "\"She's still out there. Try again.\"",
                Description = "One random enemy each combat will be this your mortal enemy. When this party member kills them, consume this item.",
                IsShopItem = false,
                ShopPrice = 7,
                DoesPopUpInfo = true,
                StartsLocked = false,
                Icon = ResourceLoader.LoadSprite("ExtraBloodyNemesis"),
                TriggerOn = TriggerCalls.OnCombatStart,
                NormalEffects =
                [
                    Effects.GenerateEffect(NemesisApply, 1, Targeting.Unit_AllOpponents),
                    Effects.GenerateEffect(RupturedApply, 10, Targeting.Slot_SelfSlot),
                ],
                MurderEffects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ConsumeItemEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(NextNemesis),
                ],
                EquippedModifiers =
                [
                    withery,
                    flowery,
                ],
            };

            bloodyNemesis.item._ItemTypeIDs =
                [
                    ItemType_GameIDs.Magic.ToString(),
                ];

            ItemUtils.JustAddItemSoItCanBeLoaded(bloodyNemesis.item);
        }
    }
}
