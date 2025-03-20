using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class ElectrumOre
    {
        public static void Add()
        {
            LoadedDBsHandler.StatusFieldDB.TryGetFieldEffect("Thunderstorm_ID", out FieldEffect_SO Thunderstorm);
            FieldEffect_Apply_Effect ThunderstormApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ThunderstormApply._Field = Thunderstorm;

            PerformEffect_Item electrumOre = new PerformEffect_Item("ElectrumOre_ID", null, false)
            {
                Item_ID = "ElectrumOre_SW",
                Name = "Electrum Ore",
                Flavour = "\"Storm's a comin'.\"",
                Description = "Apply 5 Thunderstorm to this party member's position on combat start.",
                IsShopItem = true,
                ShopPrice = 6,
                DoesPopUpInfo = true,
                StartsLocked = false,
                TriggerOn = TriggerCalls.OnCombatStart,
                Icon = ResourceLoader.LoadSprite("TreasureElectrumOre"),
                Effects =
                [
                    Effects.GenerateEffect(ThunderstormApply, 5, Targeting.Slot_SelfSlot),
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(electrumOre.Item);
        }
    }
}
