using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Stuff;
using System.Collections.Generic;

namespace Hell_Island_Fell.Items
{
    public class Nemesis
    {
        public static void Add()
        {
            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Nemesis_ID", out StatusEffect_SO Nemesis);
            StatusEffect_Apply_Effect NemesisApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            NemesisApply._Status = Nemesis;
            NemesisApply._JustOneRandomTarget = true;

            ExtraLootOptionsEffect NextNemesis = ScriptableObject.CreateInstance<ExtraLootOptionsEffect>();
            NextNemesis._itemName = "MyNemesis_NW";

            Nemesis_Item nemesis = new Nemesis_Item("NemesisItem_ID", null)
            {
                Item_ID = "Nemesis_TW",
                Name = "Nemesis",
                Flavour = "\"I need to hurt you, disgrace your existence.\"",
                Description = "One enemy each combat will be this party member's mortal enemy. Upon this party member killing their nemesis, consume this item.",
                IsShopItem = false,
                ShopPrice = 5,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanPinec"),
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
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(nemesis.Item, new ItemModdedUnlockInfo("Nemesis_TW", ResourceLoader.LoadSprite("UnlockOsmanPinecLocked", null, 32, null), "HIF_Pinec_Witness_ACH"));
        }
    }
}
