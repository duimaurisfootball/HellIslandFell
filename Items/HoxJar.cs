using BrutalAPI.Items;
using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class HoxJar
    {
        public static void Add()
        {
            FieldEffect_Apply_Effect FireApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            FireApply._Field = StatusField.OnFire;

            PerformEffect_Item hoxJar = new PerformEffect_Item("HoxJar_ID", null)
            {
                Item_ID = "HoxJar_TW",
                Name = "Hox Jar",
                Flavour = "\"Unbearbly hot air pours from it's mouth.\"",
                Description = "Upon this party member killing anything, refresh them and apply 4 Fire to this position.",
                IsShopItem = false,
                ShopPrice = 2,
                DoesPopUpInfo = false,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanHills"),
                TriggerOn = TriggerCalls.OnKill,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(FireApply, 4, Targeting.Slot_SelfSlot),
                ],
            };
            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(hoxJar.Item, new ItemModdedUnlockInfo("HoxJar_TW", ResourceLoader.LoadSprite("UnlockOsmanHillsLocked", null, 32, null), "HIF_Hills_Witness_ACH"));
        }
    }
}
