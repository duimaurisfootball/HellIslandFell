using BrutalAPI.Items;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Items
{
    public class ElusiveTrinket
    {
        public static void Add()
        {
            UnitStoreData_ModIntSO trinketValue_Damaged = ScriptableObject.CreateInstance<UnitStoreData_ModIntSO>();
            trinketValue_Damaged.m_Text = "elusive trinket error (damage) {0}";
            trinketValue_Damaged._UnitStoreDataID = "TrinketStoredValue_Damaged";
            trinketValue_Damaged.m_TextColor = Color.red;
            trinketValue_Damaged.m_CompareDataToThis = 0;
            trinketValue_Damaged.m_ShowIfDataIsOver = false;
            LoadedDBsHandler.MiscDB.AddNewUnitStoreData("TrinketStoredValue_Damaged", trinketValue_Damaged);

            UnitStoreData_ModIntSO trinketValue_Moved = ScriptableObject.CreateInstance<UnitStoreData_ModIntSO>();
            trinketValue_Moved.m_Text = "elusive trinket error (move) {0}";
            trinketValue_Moved._UnitStoreDataID = "TrinketStoredValue_Moved";
            trinketValue_Moved.m_TextColor = Color.red;
            trinketValue_Moved.m_CompareDataToThis = 0;
            trinketValue_Moved.m_ShowIfDataIsOver = false;
            LoadedDBsHandler.MiscDB.AddNewUnitStoreData("TrinketStoredValue_Moved", trinketValue_Moved);

            CasterStoreValueSetterEffect DamagedSet = ScriptableObject.CreateInstance<CasterStoreValueSetterEffect>();
            DamagedSet.m_unitStoredDataID = "TrinketStoredValue_Damaged";
            DamagedSet._ignoreIfContains = false;

            CasterStoredValueChangeEffect MovedChange = ScriptableObject.CreateInstance<CasterStoredValueChangeEffect>();
            MovedChange.m_unitStoredDataID = "TrinketStoredValue_Moved";
            MovedChange._increase = true;
            MovedChange._minimumValue = 0;

            CasterStoreValueCheckOverThresholdEffect DamageCheck = ScriptableObject.CreateInstance<CasterStoreValueCheckOverThresholdEffect>();
            DamageCheck.m_unitStoredDataID = "TrinketStoredValue_Damaged";
            DamageCheck.m_Threshold = 0;

            CasterStoreValueCheckOverThresholdEffect MoveCheck = ScriptableObject.CreateInstance<CasterStoreValueCheckOverThresholdEffect>();
            MoveCheck.m_unitStoredDataID = "TrinketStoredValue_Moved";
            MoveCheck.m_Threshold = 4;

            ExtraCurrencyEffect Currency = ScriptableObject.CreateInstance<ExtraCurrencyEffect>();
            Currency._isMultiplier = false;

            MultiCustomTriggerEffectItem elusiveTrinket = new MultiCustomTriggerEffectItem("ElusiveTrinket_ID")
            {
                Item_ID = "ElusiveTrinket_TW",
                Name = "Elusive Trinket",
                Flavour = "\"Getting here is half the fun!\"",
                Description = "If this party member takes no damage and moves themself 5 times this combat, produce 3 coins on combat end.",
                IsShopItem = false,
                ShopPrice = 4,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockOsmanNukePits"),
                EffectsAndTrigger =
                [
                    new EffectsAndTriggerPair()
                    {
                        trigger = TriggerCalls.OnDamaged,
                        effects =
                        [
                            Effects.GenerateEffect(DamagedSet, 1, Targeting.Slot_SelfSlot),
                        ],
                        doesPopup = false,
                    },
                    new EffectsAndTriggerPair()
                    {
                        trigger = TriggerCalls.OnSwapTo,
                        effects =
                        [
                            Effects.GenerateEffect(MovedChange, 1, Targeting.Slot_SelfSlot),
                        ],
                        doesPopup = true,
                    },
                    new EffectsAndTriggerPair()
                    {
                        trigger = TriggerCalls.OnCombatEnd,
                        effects =
                        [
                            Effects.GenerateEffect(DamageCheck, 0, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(MoveCheck, 0, Targeting.Slot_SelfSlot),
                            Effects.GenerateEffect(Currency, 3, Targeting.Slot_SelfSlot, Effects.CheckMultiplePreviousEffectsCondition([false, true], [2, 1])),
                        ],
                        doesPopup = true,
                    },
                ]
            };

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(elusiveTrinket.Item, new ItemModdedUnlockInfo(elusiveTrinket.Item_ID, ResourceLoader.LoadSprite("UnlockOsmanNukePitsLocked"), "HIF_NukePits_Witness_ACH"));
        }
    }
}
