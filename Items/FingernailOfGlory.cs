using BrutalAPI.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class FingernailOfGlory
    {
        public static void Add()
        {
            FieldEffect_Apply_Effect ConstrictedApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ConstrictedApply._Field = StatusField.Constricted;

            RandomDamageBetweenPreviousAndEntryEffect Damage = ScriptableObject.CreateInstance<RandomDamageBetweenPreviousAndEntryEffect>();
            Damage._indirect = true;

            PerformEffect_Item fingernailOfGlory = new PerformEffect_Item("FingernailOfGlory_ID", null)
            {
                Item_ID = "FingernailOfGlory_TW",
                Name = "Fingernail Of Glory",
                Flavour = "\"...This baneful instrument...\"",
                Description = "Apply 2 Constricted to every enemy on combat start.\nDeal 0-7 indirect damage to every enemy on combat start.",
                IsShopItem = false,
                ShopPrice = 5,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockHeavenNukePits"),
                TriggerOn = TriggerCalls.OnCombatStart,
                Effects =
                [
                    Effects.GenerateEffect(ConstrictedApply, 2, Targeting.Unit_AllOpponentSlots),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 0),
                    Effects.GenerateEffect(Damage, 7, Targeting.Unit_AllOpponents),
                ],
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(fingernailOfGlory.Item, new ItemModdedUnlockInfo(fingernailOfGlory.Item_ID, ResourceLoader.LoadSprite("UnlockHeavenNukePitsLocked"), "HIF_NukePits_Divine_ACH"));
        }
    }
}
