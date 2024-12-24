using BrutalAPI.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class Nemesis
    {
        public static void Add()
        {
            StatusEffect_Apply_Effect RupturedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            RupturedApply._Status = StatusField.Ruptured;

            PerformEffect_Item nemesis = new PerformEffect_Item("Nemesis_ID", null)
            {
                Item_ID = "Nemesis_TW",
                Name = "Nemesis",
                Flavour = "\"I need to hurt you, disgrace your existence.\"",
                Description = "Apply 2 Ruptured to every enemy on turn start.",
                IsShopItem = false,
                ShopPrice = 5,
                DoesPopUpInfo = false,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanPinec"),
                TriggerOn = TriggerCalls.OnTurnStart,
                Effects =
                [
                    Effects.GenerateEffect(RupturedApply, 2, Targeting.Unit_AllOpponents)
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(nemesis.Item, new ItemModdedUnlockInfo("Nemesis_TW", ResourceLoader.LoadSprite("UnlockOsmanPinecLocked", null, 32, null), "HIF_Pinec_Witness_ACH"));
        }
    }
}
