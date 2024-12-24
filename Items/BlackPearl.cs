using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class BlackPearl
    {
        public static void Add()
        {
            StatusEffect_Apply_Effect ScarsApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            ScarsApply._Status = StatusField.Scars;

            PerformEffect_Item blackPearl = new PerformEffect_Item("BlackPearl_ID")
            {
                Item_ID = "BlackPearl_TW",
                Name = "Black Pearl",
                Flavour = "\"Subsume...\"",
                Description = "Apply 1 Scar to all enemies upon killing anything.",
                IsShopItem = false,
                ShopPrice = 15,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanMorrigan"),
                TriggerOn = TriggerCalls.OnKill,
                Effects =
                [
                    Effects.GenerateEffect(ScarsApply, 1, Targeting.Unit_AllOpponents),
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(blackPearl.Item, new ItemModdedUnlockInfo("BlackPearl_TW", ResourceLoader.LoadSprite("UnlockOsmanMorriganLocked", null, 32, null), "HIF_Morrigan_Witness_ACH"));
        }
    }
}
