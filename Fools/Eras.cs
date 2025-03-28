﻿using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Fools
{
    public class Eras
    {
        public static void Add()
        {
            Character eras = new Character("Eras", "Eras_CH")
            {
                HealthColor = Pigments.Purple,
                UsesBasicAbility = false,
                UsesAllAbilities = true,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("ErasFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("ErasBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("ErasOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("Hans_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("Hans_CH").deathSound,
                DialogueSound = LoadedAssetsHandler.GetCharacter("Hans_CH").dxSound,
            };
            eras.GenerateMenuCharacter(ResourceLoader.LoadSprite("ErasMenu"), ResourceLoader.LoadSprite("ErasLocked"));
            eras.SetMenuCharacterAsFullSupport();
            eras.AddPassives([]);

            UnitStoreData_ModIntSO charge = ScriptableObject.CreateInstance<UnitStoreData_ModIntSO>();
            charge.m_Text = "Charge: {0}";
            charge._UnitStoreDataID = "ErasChargeStoredValue";
            charge.m_TextColor = Color.yellow;
            charge.m_CompareDataToThis = 0;
            charge.m_ShowIfDataIsOver = true;
            LoadedDBsHandler.MiscDB.AddNewUnitStoreData("ErasChargeStoredValue", charge);

            CasterStoreValueCheckOverThresholdEffect ChargeCheck = ScriptableObject.CreateInstance<CasterStoreValueCheckOverThresholdEffect>();
            ChargeCheck.m_unitStoredDataID = "ErasChargeStoredValue";

            CasterStoreValuedPercentageChangeEffect ChargeChange = ScriptableObject.CreateInstance<CasterStoreValuedPercentageChangeEffect>();
            ChargeChange.m_unitStoredDataID = "ErasChargeStoredValue";

            CasterStoredValueDecreaseRandomlyEffect ChargeReduce = ScriptableObject.CreateInstance<CasterStoredValueDecreaseRandomlyEffect>();
            ChargeReduce.m_unitStoredDataID = "ErasChargeStoredValue";

            CasterStoreValueSetRandomBetweenExitEffect ChargePercentageChange = ScriptableObject.CreateInstance<CasterStoreValueSetRandomBetweenExitEffect>();
            ChargePercentageChange.m_unitStoredDataID = "ErasChargeStoredValue";

            HealEffect PrevHeal = ScriptableObject.CreateInstance<HealEffect>();
            PrevHeal.usePreviousExitValue = true;

            UnboundedHealEffect PumpHeal = ScriptableObject.CreateInstance<UnboundedHealEffect>();
            PumpHeal._repeatChance = 25;
            PumpHeal._cycles = 1;
            PumpHeal.usePreviousExitValue = true;

            UnboundedDamageEffect BeatDamage = ScriptableObject.CreateInstance<UnboundedDamageEffect>();
            BeatDamage._repeatChance = 20;
            BeatDamage._cycles = 1;
            BeatDamage.usePreviousExitValue = true;
            
            //pulse
            Ability pulse = new Ability("Pulse", "HIFPulse_A")
            {
                Description = "Reduce Charge by 50%.\nHeal this and the Left ally an amount equal to at least the amount of Charge.",
                AbilitySprite = ResourceLoader.LoadSprite("ErasPulse"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Genesis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ChargeChange, 50),
                    Effects.GenerateEffect(ChargeCheck, 1),
                    Effects.GenerateEffect(PumpHeal, 1, Targeting.Slot_AllySides),
                ],
                UnitStoreData = charge,
            };
            pulse.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);
            pulse.AddIntentsToTarget(Targeting.Slot_AllySides, ["Heal_Unbounded"]);

            //beat
            Ability beat = new Ability("Beat", "HIFBeat_A")
            {
                Description = "Reduce Charge by 50%.\nDeal an amount of damage to the Opposing equal to at least the amount of Charge.",
                AbilitySprite = ResourceLoader.LoadSprite("ErasBeat"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Red],
                Visuals = Visuals.HeartBreaker,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ChargeChange, 50),
                    Effects.GenerateEffect(ChargeCheck, 1),
                    Effects.GenerateEffect(BeatDamage, 1, Targeting.Slot_Front),
                ],
                UnitStoreData = charge,
            };
            beat.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);
            beat.AddIntentsToTarget(Targeting.Slot_Front, ["Damage_Unbounded"]);

            //electricity
            Ability electricity0 = new Ability("Weak Electricity", "Electricity_1_A")
            {
                Description = "Deal 1 damage to the Opposing enemy.\nSet this party member's Charge to a random number between 1-5.",
                AbilitySprite = ResourceLoader.LoadSprite("ErasElectricity"),
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Slap,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 1, Targeting.Slot_Front),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1),
                    Effects.GenerateEffect(ChargePercentageChange, 5),
                ],
                UnitStoreData = charge,
            };
            electricity0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_1_2)]);
            electricity0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability electricity1 = new Ability("Short Electricity", "Electricity_2_A")
            {
                Description = "Deal 1 damage to the Opposing enemy.\nSet this party member's Charge to a random number between 1-8.",
                AbilitySprite = ResourceLoader.LoadSprite("ErasElectricity"),
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Slap,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 1, Targeting.Slot_Front),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1),
                    Effects.GenerateEffect(ChargePercentageChange, 8),
                ],
                UnitStoreData = charge,
            };
            electricity1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_1_2)]);
            electricity1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability electricity2 = new Ability("Polar Electricity", "Electricity_3_A")
            {
                Description = "Deal 1 damage to the Opposing enemy.\nSet this party member's Charge to a random number between 1-13.",
                AbilitySprite = ResourceLoader.LoadSprite("ErasElectricity"),
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Slap,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 1, Targeting.Slot_Front),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1),
                    Effects.GenerateEffect(ChargePercentageChange, 13),
                ],
                UnitStoreData = charge,
            };
            electricity2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_1_2)]);
            electricity2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability electricity3 = new Ability("Direct Electricity", "Electricity_4_A")
            {
                Description = "Deal 1 damage to the Opposing enemy.\nSet this party member's Charge to a random number between 1-17.",
                AbilitySprite = ResourceLoader.LoadSprite("ErasElectricity"),
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Slap,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 1, Targeting.Slot_Front),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1),
                    Effects.GenerateEffect(ChargePercentageChange, 17),
                ],
                UnitStoreData = charge,
            };
            electricity3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_1_2)]);
            electricity3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            eras.AddLevelData(8, new Ability[] { electricity0, pulse, beat });
            eras.AddLevelData(11, new Ability[] { electricity1, pulse, beat });
            eras.AddLevelData(14, new Ability[] { electricity2, pulse, beat });
            eras.AddLevelData(17, new Ability[] { electricity3, pulse, beat });

            eras.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Eras_Witness_ACH");
            eras.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Eras_Divine_ACH");
            eras.AddCharacter(true, false);
        }
    }
}
