using BrutalAPI.Items;
using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Hell_Island_Fell.Custom_Effects;

namespace Hell_Island_Fell.Items
{
    public class MalebolgesSeveredHead
    {
        public static void Add()
        {
            SpecialDamagePlusPreviousEffect FireHead = ScriptableObject.CreateInstance<SpecialDamagePlusPreviousEffect>();
            FireHead._addHealthMana = false;
            FireHead._selfCast = true;
            FireHead._ignoreShield = true;
            FireHead._direct = false;
            FireHead._willApplyDamage = true;
            FireHead._damageType = CombatType_GameIDs.Dmg_Fire.ToString();

            UnitStoreData_ModIntSO severedHead = ScriptableObject.CreateInstance<UnitStoreData_ModIntSO>();
            severedHead.m_Text = "Severed Head: +{0}";
            severedHead._UnitStoreDataID = "SeveredHeadStoredValue";
            severedHead.m_TextColor = Color.red;
            severedHead.m_CompareDataToThis = 0;
            severedHead.m_ShowIfDataIsOver = true;
            LoadedDBsHandler.MiscDB.AddNewUnitStoreData("SeveredHeadStoredValue", severedHead);

            CasterStoreValueCheckOverThresholdEffect HeadCheck = ScriptableObject.CreateInstance<CasterStoreValueCheckOverThresholdEffect>();
            HeadCheck.m_unitStoredDataID = "SeveredHeadStoredValue";

            CasterStoredValueChangeEffect HeadAdd = ScriptableObject.CreateInstance<CasterStoredValueChangeEffect>();
            HeadAdd.m_unitStoredDataID = "SeveredHeadStoredValue";

            PercentageEffectCondition HeadChance = ScriptableObject.CreateInstance<PercentageEffectCondition>();
            HeadChance.percentage = 50;

            PerformEffect_Item malebolgesSeveredHead = new PerformEffect_Item("MalebolgesSeveredHead_ID", null, false)
            {
                Item_ID = "MalebolgesSeveredHead_TW",
                Name = "Malebolge's Severed Head",
                Flavour = "\"You'll be asleep soon enough.\"",
                Description = "Deal 1 fire damage to All enemies on turn end. 50% chance to increase this damage by 1.\n\nThis item is affected by damage modifiers like Focus or Spotlight.",
                IsShopItem = false,
                ShopPrice = 5,
                DoesPopUpInfo = true,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockHeavenMalebolge"),
                TriggerOn = TriggerCalls.OnTurnFinished,
                Effects =
                [
                    Effects.GenerateEffect(HeadCheck, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(FireHead, 1, Targeting.Unit_AllOpponents),
                    Effects.GenerateEffect(HeadAdd, 1, Targeting.Slot_SelfSlot, HeadChance),
                ],
            };

            malebolgesSeveredHead.item._ItemTypeIDs =
                [
                    ItemType_GameIDs.Face.ToString(),
                ];

            ItemUtils.AddItemToTreasureStatsCategoryAndGamePool(malebolgesSeveredHead.Item, new ItemModdedUnlockInfo("MalebolgesSeveredHead_TW", ResourceLoader.LoadSprite("UnlockHeavenMalebolgeLocked", null, 32, null), "HIF_Malebolge_Divine_ACH"));
        }
    }
}
