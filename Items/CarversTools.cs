using BrutalAPI.Items;
using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class CarversTools
    {
        public static void Add()
        {
            ChangeToRandomHealthColorEffect GrayHealth = ScriptableObject.CreateInstance<ChangeToRandomHealthColorEffect>();
            GrayHealth._healthColors = [Pigments.Grey];

            DamageReceivedPercentageModifierEffect_Item carversTools = new DamageReceivedPercentageModifierEffect_Item("CarversTools_ID", null)
            {
                Item_ID = "CarversTools_SW",
                Name = "Carver's Tools",
                Flavour = "\"It will never be perfect.\"",
                Description = "Reduce all incoming damage by 25%. Upon taking any damage, change the Opposing enemy's health to gray",
                IsShopItem = true,
                ShopPrice = 8,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanMalebolge"),
                EffectsTrigger = TriggerCalls.OnDamaged,
                Effects =
                [
                    Effects.GenerateEffect(GrayHealth, 1, Targeting.Slot_Front),
                ],
                TriggerOn = TriggerCalls.OnBeingDamaged,
                DirectDmgPercentageToModify = 25,
                DoesIncreaseDirectDamage = false,
                IndirectDmgPercentageToModify = 25,
                DoesIncreaseIndirectDamage = false,
            };
            ItemUtils.AddItemToShopStatsCategoryAndGamePool(carversTools.Item, new ItemModdedUnlockInfo("CarversTools_SW", ResourceLoader.LoadSprite("UnlockOsmanMalebolgeLocked", null, 32, null), "HIF_Malebolge_Witness_ACH"));
        }
    }
}
