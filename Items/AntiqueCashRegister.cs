using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class AntiqueCashRegister
    {
        public static void Add()
        {
            PercentageEffectCondition breakChance = ScriptableObject.CreateInstance<PercentageEffectCondition>();
            breakChance.percentage = 3;

            MultiCustomTriggerEffectItem antiqueCashRegister = new MultiCustomTriggerEffectItem("AntiqueCashRegister_ID")
            {
                Item_ID = "AntiqueCashRegister_SW",
                Name = "Antique Cash Register",
                Flavour = "\"Kaching!\"",
                Description = "Upon lucky pigment triggering, produce 1 coin and reduce the lucky pigment chance by 1%. Reduce the lucky pigment chance by 1% on turn start. 3% chance to be destroyed upon activation.",
                IsShopItem = true,
                ShopPrice = 8,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockHeavenChim"),
                EffectsAndTrigger =
                [
                    new EffectsAndCustomTriggerPair()
                    {
                        customTrigger = LuckyPigmentTriggerPatch.OnLuckyPigmentSuccess,
                        effects =
                        [
                            Effects.GenerateEffect(ScriptableObject.CreateInstance<GainPlayerCurrencyEffect>(), 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(ScriptableObject.CreateInstance<LuckyBluePercentageChangeEffect>(), -1),
                            Effects.GenerateEffect(ScriptableObject.CreateInstance<ConsumeItemEffect>(), 1, Targeting.Slot_SelfSlot, breakChance),
                        ],
                        doesPopup = true,
                    },
                    new EffectsAndTriggerPair()
                    {
                        trigger = TriggerCalls.OnTurnStart,
                        effects =
                        [
                            Effects.GenerateEffect(ScriptableObject.CreateInstance<LuckyBluePercentageChangeEffect>(), -1),
                            Effects.GenerateEffect(ScriptableObject.CreateInstance<ConsumeItemEffect>(), 1, Targeting.Slot_SelfSlot, breakChance),
                        ],
                        doesPopup = true,
                    },
                ]
            };

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(antiqueCashRegister.Item, new ItemModdedUnlockInfo("AntiqueCashRegister_SW", ResourceLoader.LoadSprite("UnlockHeavenChimLocked", null, 32, null), "HIF_Chim_Divine_ACH"));
        }
    }
}
