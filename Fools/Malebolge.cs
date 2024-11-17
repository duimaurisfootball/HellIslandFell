using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using static UnityEngine.UI.GridLayoutGroup;

namespace Hell_Island_Fell.Fools
{
    public class Malebolge
    {
        public static void Add()
        {
            Character malebolge = new Character("Malebolge", "Malebolge_CH")
            {
                HealthColor = Pigments.Grey,
                UsesBasicAbility = false,
                MovesOnOverworld = false,
                FrontSprite = ResourceLoader.LoadSprite("MalebolgeFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("MalebolgeBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("MalebolgeOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("Gospel_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("Gospel_CH").deathSound,
                DialogueSound = LoadedAssetsHandler.GetCharacter("Gospel_CH").dxSound,
                UsesAllAbilities = true,
                UnitTypes =
                [
                    "FemaleID",
                ],
            };
            malebolge.GenerateMenuCharacter(ResourceLoader.LoadSprite("MalebolgeMenu"), ResourceLoader.LoadSprite("MalebolgeLocked"));
            malebolge.AddPassives([Passives.Inanimate]);
            malebolge.SetMenuCharacterAsFullDPS();

            UnitStoreData_ModIntSO acceleration = ScriptableObject.CreateInstance<UnitStoreData_ModIntSO>();
            acceleration.m_Text = "Acceleration: +{0}";
            acceleration._UnitStoreDataID = "TimeStoredValue";
            acceleration.m_TextColor = Color.red;
            acceleration.m_CompareDataToThis = 0;
            acceleration.m_ShowIfDataIsOver = true;
            LoadedDBsHandler.MiscDB.AddNewUnitStoreData("TimeStoredValue", acceleration);

            CasterStoreValueCheckOverThresholdEffect TimeCheck = ScriptableObject.CreateInstance<CasterStoreValueCheckOverThresholdEffect>();
            TimeCheck.m_unitStoredDataID = "TimeStoredValue";

            CasterStoredValueChangeEffect TimeAdd = ScriptableObject.CreateInstance<CasterStoredValueChangeEffect>();
            TimeAdd._randomBetweenPrevious = true;
            TimeAdd.m_unitStoredDataID = "TimeStoredValue";

            DamageFromBasePlusPreviousEffect TimeDamage = ScriptableObject.CreateInstance<DamageFromBasePlusPreviousEffect>();
            TimeDamage._baseDamage = 1;
            TimeDamage._indirect = true;

            SpecialDamageEffect FireDamage = ScriptableObject.CreateInstance<SpecialDamageEffect>();
            FireDamage._ignoreShield = true;
            FireDamage._addHealthMana = false;
            FireDamage._direct = false;
            FireDamage._selfCast = false;
            FireDamage._damageType = CombatType_GameIDs.Dmg_Fire.ToString();

            StatusEffect_Apply_Effect ScarsApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            ScarsApply._Status = StatusField.Scars;

            StatusEffect_Apply_Effect RupturedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            RupturedApply._Status = StatusField.Ruptured;

            StatusEffect_Apply_Effect FrailApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            FrailApply._Status = StatusField.Frail;

            StatusEffect_Apply_Effect OilApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            OilApply._Status = StatusField.OilSlicked;

            StatusEffect_Apply_Effect LinkedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            LinkedApply._Status = StatusField.Linked;

            //glorify
            Ability glorify = new Ability("Glorify", "Glorify_1_A")
            {
                Description = "Apply 2 Scars, Ruptured, Frail, Oil Slicked, and Linked to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("MalebolgeGlorify"),
                Cost = [Pigments.Red, Pigments.Purple, Pigments.Purple],
                Visuals = null,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScarsApply, 2, Targeting.Slot_Front),
                    Effects.GenerateEffect(RupturedApply, 2, Targeting.Slot_Front),
                    Effects.GenerateEffect(FrailApply, 2, Targeting.Slot_Front),
                    Effects.GenerateEffect(OilApply, 2, Targeting.Slot_Front),
                    Effects.GenerateEffect(LinkedApply, 2, Targeting.Slot_Front),
                ]
            };
            glorify.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Scars)]);
            glorify.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Ruptured)]);
            glorify.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Frail)]);
            glorify.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_OilSlicked)]);
            glorify.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Linked)]);

            //combust
            Ability combust = new Ability("Combust", "Combust_1_A")
            {
                Description = "Deal 8 fire damage to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("MalebolgeCombust"),
                Cost = [Pigments.Red, Pigments.Yellow],
                Visuals = null,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(FireDamage, 8, Targeting.Slot_Front),
                ]
            };
            combust.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);

            //accelerate
            Ability accelerate = new Ability("Accelerate Time", "AccelerateTime_1_A")
            {
                Description = "Deal 1 indirect damage to all enemies.\nIncrease the damage dealt by this attack by 1-2.",
                AbilitySprite = ResourceLoader.LoadSprite("MalebolgeAccelerate"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Clobber_Left,
                AnimationTarget = Targeting.Unit_AllOpponents,
                Effects =
                [
                    Effects.GenerateEffect(TimeCheck, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(TimeDamage, 1, Targeting.Unit_AllOpponents),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(TimeAdd, 2, Targeting.Slot_SelfSlot),
                ],
                UnitStoreData = acceleration,
            };
            accelerate.AddIntentsToTarget(Targeting.Unit_AllOpponents, [nameof(IntentType_GameIDs.Damage_1_2)]);
            accelerate.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            malebolge.AddLevelData(100, new Ability[] { glorify, combust, accelerate });

            malebolge.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Malebolge_Witness_ACH");
            malebolge.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Malebolge_Divine_ACH");
            malebolge.AddCharacter(true, false);
        }
    }
}
