using BrutalAPI.Items;
using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class TollBell
    {
        public static void Add()
        {
            UnitStoreData_ModIntSO DamageUp = ScriptableObject.CreateInstance<UnitStoreData_ModIntSO>();
            DamageUp.m_Text = "Dead Ring Max: +{0}";
            DamageUp._UnitStoreDataID = "BellUpStoredValue";
            DamageUp.m_TextColor = Color.yellow;
            DamageUp.m_CompareDataToThis = 0;
            DamageUp.m_ShowIfDataIsOver = true;
            LoadedDBsHandler.MiscDB.AddNewUnitStoreData("BellUpStoredValue", DamageUp);

            CasterStoredValueChangeEffect DmgUpChange = ScriptableObject.CreateInstance<CasterStoredValueChangeEffect>();
            DmgUpChange.m_unitStoredDataID = "BellUpStoredValue";

            UnitStoreData_ModIntSO DamageDown = ScriptableObject.CreateInstance<UnitStoreData_ModIntSO>();
            DamageDown.m_Text = "Dead Ring Min: -{0}";
            DamageDown._UnitStoreDataID = "BellDownStoredValue";
            DamageDown.m_TextColor = Color.yellow;
            DamageDown.m_CompareDataToThis = 0;
            DamageDown.m_ShowIfDataIsOver = true;
            LoadedDBsHandler.MiscDB.AddNewUnitStoreData("BellDownStoredValue", DamageDown);

            CasterStoredValueChangeEffect DmgDownChange = ScriptableObject.CreateInstance<CasterStoredValueChangeEffect>();
            DmgDownChange.m_unitStoredDataID = "BellDownStoredValue";

            PendulumDamage bellDamage = ScriptableObject.CreateInstance<PendulumDamage>();
            bellDamage._valueNameTop = "BellUpStoredValue";
            bellDamage._valueNameBottom = "BellDownStoredValue";


            Ability deadRing = new Ability("Dead Ring", "DeadRing_A")
            {
                Description = "Deal 6-7 damage to the Opposing enemy.\nDecrease this move's minimum damage by 1.\nIncrease this move's maximum damage by 2.",
                AbilitySprite = ResourceLoader.LoadSprite("ItemDeadRing"),
                Cost = [Pigments.YellowBlue, Pigments.RedYellow],
                Visuals = Visuals.RingABell,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 6, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(bellDamage, 7, Targeting.Slot_Front),
                    Effects.GenerateEffect(DmgDownChange, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(DmgUpChange, 2, Targeting.Slot_SelfSlot),
                ]
            };
            deadRing.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);
            deadRing.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);
            deadRing.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            ExtraAbility_Wearable_SMS theBell = ScriptableObject.CreateInstance<ExtraAbility_Wearable_SMS>();
            theBell._extraAbility = deadRing.GenerateCharacterAbility();

            PerformEffect_Item tollBell = new PerformEffect_Item("TollBell_ID", null)
            {
                Item_ID = "TollBell_SW",
                Name = "Toll Bell",
                Flavour = "\"I wonder for whom?\"",
                Description = "Adds \"Dead Ring\" as an additional ability, an attack that becomes more inconsistent the more it is used.",
                IsShopItem = true,
                ShopPrice = 4,
                DoesPopUpInfo = false,
                StartsLocked = true,
                Icon = ResourceLoader.LoadSprite("UnlockHeavenFelix"),
                TriggerOn = TriggerCalls.Count,
                Effects =
                [

                ],
                EquippedModifiers =
                [
                    theBell
                ],
            };
            Connection_PerformEffectPassiveAbility connection_PerformEffectPassiveAbility = LoadedAssetsHandler.GetCharacter("Doll_CH").passiveAbilities[0] as Connection_PerformEffectPassiveAbility;
            CasterAddRandomExtraAbilityEffect casterAddRandomExtraAbilityEffect = connection_PerformEffectPassiveAbility.connectionEffects[1].effect as CasterAddRandomExtraAbilityEffect;
            casterAddRandomExtraAbilityEffect._extraData = new List<ExtraAbility_Wearable_SMS>(casterAddRandomExtraAbilityEffect._extraData)
            {
                theBell
            };

            ItemUtils.AddItemToShopStatsCategoryAndGamePool(tollBell.Item, new ItemModdedUnlockInfo("TollBell_SW", ResourceLoader.LoadSprite("UnlockHeavenFelixLocked", null, 32, null), "HIF_Felix_Divine_ACH"));
        }
    }
}
