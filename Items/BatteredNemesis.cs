using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class BatteredNemesis
    {
        public static void Add()
        {
            ExtraPassiveAbility_Wearable_SMS firey = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            firey._extraPassiveAbility = Passives.Inferno;

            ExtraPassiveAbility_Wearable_SMS feebly = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            feebly._extraPassiveAbility = Passives.Enfeebled;

            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Nemesis_ID", out StatusEffect_SO Nemesis);
            StatusEffect_Apply_Effect NemesisApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            NemesisApply._Status = Nemesis;
            NemesisApply._JustOneRandomTarget = true;

            ExtraLootOptionsEffect NextNemesis = ScriptableObject.CreateInstance<ExtraLootOptionsEffect>();
            NextNemesis._itemName = "InvincibleNemesis_NW";

            Nemesis_Item batteredNemesis = new Nemesis_Item("BatteredNemesisItem_ID", null)
            {
                Item_ID = "BatteredNemesis_NW",
                Name = "Battered Nemesis",
                Flavour = "\"She's... Just try again.\"",
                Description = "One random enemy each combat will be your mortal enemy. When this party member murders them...",
                IsShopItem = false,
                ShopPrice = 8,
                DoesPopUpInfo = true,
                StartsLocked = false,
                Icon = ResourceLoader.LoadSprite("ExtraBatteredNemesis"),
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
                    firey,
                    feebly,
                ],
            };

            ItemUtils.JustAddItemSoItCanBeLoaded(batteredNemesis.item);
        }
    }
}
