using BrutalAPI.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class ComplexComplexion
    {
        public static void Add()
        {
            DamageEffect IndirectDamage = ScriptableObject.CreateInstance<DamageEffect>();
            IndirectDamage._indirect = true;

            FieldEffect_Apply_Effect ApplyShield = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ApplyShield._Field = StatusField.Shield;

            PerformEffect_Item complexComplexion = new PerformEffect_Item("ComplexComplexion_ID", null, false)
            {
                Item_ID = "ComplexComplexion_TW",
                Name = "Complex Complexion",
                Flavour = "\"No part of you wants to be smooth.\"",
                Description = "Upon taking direct damage, deal 5 indirect damage to the Opposing enemy, apply 4 Shield to this party member's position, and heal the Left and Right allies 4 health.",
                IsShopItem = false,
                ShopPrice = 7,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanGomma"),
                TriggerOn = TriggerCalls.OnDirectDamaged,
                Effects =
                [
                    Effects.GenerateEffect(IndirectDamage, 5, Targeting.Slot_Front),
                    Effects.GenerateEffect(ApplyShield, 4, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 4, Targeting.Slot_AllySides),
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(complexComplexion.Item, new ItemModdedUnlockInfo("ComplexComplexion_TW", ResourceLoader.LoadSprite("UnlockOsmanGommaLocked", null, 32, null), "HIF_Gomma_Witness_ACH"));
        }
    }
}
