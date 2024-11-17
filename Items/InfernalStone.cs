using BrutalAPI.Items;
using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class InfernalStone
    {
        public static void Add()
        {
            ExtraPassiveAbility_Wearable_SMS toHell = ScriptableObject.CreateInstance<ExtraPassiveAbility_Wearable_SMS>();
            toHell._extraPassiveAbility = Passives.GetCustomPassive("Interpolated_PA");

            PerformEffect_Item infernalStone = new PerformEffect_Item("InfernalStone_ID", null)
            {
                Item_ID = "InfernalStone_TW",
                Name = "Infernal Stone",
                Flavour = "\"Disappearing?\"",
                Description = "This party member now has Interpolated as a passive.",
                IsShopItem = false,
                ShopPrice = 15,
                DoesPopUpInfo = false,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockHeavenExambry"),
                TriggerOn = TriggerCalls.Count,
                Effects =
                [

                ],
                EquippedModifiers =
                [
                    toHell
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(infernalStone.Item, new ItemModdedUnlockInfo("InfernalStone_TW", ResourceLoader.LoadSprite("UnlockHeavenExambryLocked", null, 32, null), "HIF_Exambry_Divine_ACH"));
        }
    }
}
