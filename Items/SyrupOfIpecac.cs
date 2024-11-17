using BrutalAPI.Items;
using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class SyrupOfIpecac
    {
        public static void Add()
        {
            RerollNumberPigmentEffect SumpGray = ScriptableObject.CreateInstance<RerollNumberPigmentEffect>();
            SumpGray._mana = Pigments.Grey;

            PerformEffect_Item syrupOfIpecac = new PerformEffect_Item("SyrupOfIpecac_ID", null, false)
            {
                Item_ID = "SyrupOfIpecac_SW",
                Name = "Syrup of Ipecac",
                Flavour = "\"Tired of being swallowed all the time? It's shocking how often it happens.\"",
                Description = "Reroll one stored pigment to gray on turn end.",
                IsShopItem = true,
                ShopPrice = 5,
                DoesPopUpInfo = false,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockHeavenFarah"),
                TriggerOn = TriggerCalls.OnTurnFinished,
                Effects =
                [
                    Effects.GenerateEffect(SumpGray, 1, Targeting.Slot_SelfSlot),
                ],
            };

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(syrupOfIpecac.Item, new ItemModdedUnlockInfo("SyrupOfIpecac_SW", ResourceLoader.LoadSprite("UnlockHeavenFarahLocked", null, 32, null), "HIF_Farah_Divine_ACH"));
        }
    }
}
