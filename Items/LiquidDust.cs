using BrutalAPI;
using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class LiquidDust
    {
        public static void Add()
        {
            UnitStoreData_ModIntSO watering = ScriptableObject.CreateInstance<UnitStoreData_ModIntSO>();
            watering.m_Text = "Lucky Pigment Amount {0}";
            watering._UnitStoreDataID = "WaterStoredValue";
            watering.m_TextColor = Color.yellow;
            watering.m_CompareDataToThis = 0;
            watering.m_ShowIfDataIsOver = true;
            LoadedDBsHandler.MiscDB.AddNewUnitStoreData("WaterStoredValue", watering);

            CasterStoredValueChangeEffect WaterAdd = ScriptableObject.CreateInstance<CasterStoredValueChangeEffect>();
            WaterAdd.m_unitStoredDataID = "WaterStoredValue";

            CasterStoreValueSetterEffect WaterSet = ScriptableObject.CreateInstance<CasterStoreValueSetterEffect>();
            WaterSet.m_unitStoredDataID = "WaterStoredValue";


            MultiCustomTriggerEffectItem liquidDust = new MultiCustomTriggerEffectItem("LiquidDust_ID")
            {
                Item_ID = "LiquidDust_TW",
                Name = "Liquid Dust",
                Flavour = "\"Rubbish for sandcastles.\"",
                Description = "Upon lucky pigment not triggering, increase the amount of pigment it creates by 1. Upon lucky pigment triggering, set the amount of pigment it creates to 1.",
                IsShopItem = false,
                ShopPrice = 1,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockHeavenAelie"),
                EffectsAndTrigger =
                [
                    new EffectsAndCustomTriggerPair()
                    {
                        customTrigger = LuckyPigmentTriggerPatch.OnLuckyPigmentFailure,
                        effects =
                        [
                            Effects.GenerateEffect(ScriptableObject.CreateInstance<LuckyBlueAmountSetEffect>(), 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(WaterAdd, 1, Targeting.Slot_SelfSlot),
                        ],
                        doesPopup = true,
                    },
                    new EffectsAndCustomTriggerPair()
                    {
                        customTrigger = LuckyPigmentTriggerPatch.OnLuckyPigmentSuccess,
                        effects =
                        [
                            Effects.GenerateEffect(ScriptableObject.CreateInstance<LuckyBlueAmountActuallySetEffect>(), 1, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(WaterSet, 1, Targeting.Slot_SelfSlot),
                        ],
                        doesPopup = true,
                    },
                    new EffectsAndCustomTriggerPair()
                    {
                        customTrigger = TriggerCalls.OnCombatStart.ToString(),
                        effects =
                        [
                            Effects.GenerateEffect(WaterSet, 1, Targeting.Slot_SelfSlot),
                        ],
                        doesPopup = false,
                    },
                ]
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(liquidDust.Item, new ItemModdedUnlockInfo("LiquidDust_TW", ResourceLoader.LoadSprite("UnlockHeavenAelieLocked", null, 32, null), "HIF_Aelie_Divine_ACH"));
        }
    }
}
