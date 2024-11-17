using BrutalAPI.Items;
using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class FormidableDinners
    {
        public static void Add()
        {
            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Salted_ID", out StatusEffect_SO Salted);
            StatusEffect_Apply_Effect SaltedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            SaltedApply._Status = Salted;

            PerformEffect_Item dinners = new PerformEffect_Item("FormidableDinners_ID", null, false)
            {
                Item_ID = "FormidableDinners_TW",
                Name = "Formidable Dinners",
                Flavour = "\"Absolutely and completely stuffing! Ough...\"",
                Description = "Inflict 4 Salted to every enemy and party member on combat start.",
                IsShopItem = false,
                ShopPrice = 3,
                DoesPopUpInfo = true,
                StartsLocked = false,
                TriggerOn = TriggerCalls.OnCombatStart,
                Icon = ResourceLoader.LoadSprite("TreasureFormidableDinners"),
                Effects =
                [
                    Effects.GenerateEffect(SaltedApply, 4, Targeting.AllUnits)
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(dinners.Item);
        }
    }
}
