using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class MyNemesis
    {
        public static void Add()
        {
            ExtraPassiveAbility_Wearable_SMS skitty = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            skitty._extraPassiveAbility = Passives.Skittish2;

            ExtraPassiveAbility_Wearable_SMS slippy = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            slippy._extraPassiveAbility = Passives.Slippery;

            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Nemesis_ID", out StatusEffect_SO Nemesis);
            StatusEffect_Apply_Effect NemesisApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            NemesisApply._Status = Nemesis;
            NemesisApply._JustOneRandomTarget = true;

            ExtraLootOptionsEffect NextNemesis = ScriptableObject.CreateInstance<ExtraLootOptionsEffect>();
            NextNemesis._itemName = "BloodyNemesis_NW";

            Nemesis_Item myNemesis = new Nemesis_Item("MyNemesisItem_ID", null)
            {
                Item_ID = "MyNemesis_NW",
                Name = "My Nemesis",
                Flavour = "\"You didn't kill her. Try again.\"",
                Description = "One random enemy each combat will be this party member's mortal enemy. If this party member kills them, consume this item.",
                IsShopItem = false,
                ShopPrice = 6,
                DoesPopUpInfo = true,
                StartsLocked = false,
                Icon = ResourceLoader.LoadSprite("ExtraMyNemesis"),
                TriggerOn = TriggerCalls.OnCombatStart,
                NormalEffects =
                [
                    Effects.GenerateEffect(NemesisApply, 1, Targeting.Unit_AllOpponents),
                ],
                MurderEffects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ConsumeItemEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(NextNemesis),
                ],
                EquippedModifiers =
                [
                    skitty,
                    slippy,
                ],
            };

            ItemUtils.JustAddItemSoItCanBeLoaded(myNemesis.item);
        }
    }
}
