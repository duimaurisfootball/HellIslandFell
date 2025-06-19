using BrutalAPI.Items;
using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class CurlingFinger
    {
        public static void Add()
        {
            StatusEffect_Apply_Effect CursedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            CursedApply._Status = StatusField.Cursed;

            PerformEffect_Item curlingFinger = new PerformEffect_Item("CurlingFinger_ID", null, false)
            {
                Item_ID = "CurlingFinger_OW",
                Name = "Curling Finger",
                Flavour = "\"It's cursed.\"",
                Description = "This party member is Cursed.",
                IsShopItem = false,
                ShopPrice = -1,
                DoesPopUpInfo = true,
                StartsLocked = false,
                Icon = ResourceLoader.LoadSprite("ItemKaglasFinger"),
                TriggerOn = TriggerCalls.OnCombatStart,
                Effects =
                [
                    Effects.GenerateEffect(CursedApply, 1, Targeting.Slot_SelfSlot)
                ],
            };

            curlingFinger.item._ItemTypeIDs =
                [
                    ItemType_GameIDs.Magic.ToString(),
                ];

            ItemUtils.JustAddItemSoItCanBeLoaded(curlingFinger.item);
        }
    }
}
