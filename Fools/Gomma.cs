using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Passives;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Fools
{
    public class Gomma
    {
        public static void Add()
        {
            Character gomma = new Character("Gomma", "Gomma_CH")
            {
                HealthColor = Pigments.Yellow,
                UsesBasicAbility = true,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("GommaFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("GommaBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("GommaOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("Pearl_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("Pearl_CH").deathSound,
                DialogueSound = LoadedAssetsHandler.GetCharacter("Pearl_CH").dxSound,
                UnitTypes =
                [
                    "FemaleID",
                ],
            };
            gomma.GenerateMenuCharacter(ResourceLoader.LoadSprite("GommaMenu"), ResourceLoader.LoadSprite("GommaLocked"));
            gomma.AddPassives([CustomPassives.WartsGenerator(2)]);
            gomma.SetMenuCharacterAsFullSupport();

            CasterStoredValueChangeEffect WartsUp = ScriptableObject.CreateInstance<CasterStoredValueChangeEffect>();
            WartsUp.m_unitStoredDataID = "WartsStoredValue";

            FieldEffect_ApplyToWeakest_Effect ForestShield = ScriptableObject.CreateInstance<FieldEffect_ApplyToWeakest_Effect>();
            ForestShield._Field = StatusField.Shield;

            FieldEffect_Apply_Effect ScalesShield = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ScalesShield._Field = StatusField.Shield;
            ScalesShield._UseRandomBetweenPrevious = true;

            PercentageEffectCondition SmokeChance0 = ScriptableObject.CreateInstance<PercentageEffectCondition>();
            SmokeChance0.percentage = 40;

            PercentageEffectCondition SmokeChance1 = ScriptableObject.CreateInstance<PercentageEffectCondition>();
            SmokeChance1.percentage = 50;

            PercentageEffectCondition SmokeChance2 = ScriptableObject.CreateInstance<PercentageEffectCondition>();
            SmokeChance2.percentage = 60;

            //forest
            Ability forest0 = new Ability("Tiny Forest", "Forest_1_A")
            {
                Description = "Apply 8 Shield to the positon(s) of the lowest health party member(s).\nIncrease this party member's Warts strength by 1.",
                AbilitySprite = ResourceLoader.LoadSprite("GommaForest"),
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Thorns,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ForestShield, 8, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(WartsUp, 1, Targeting.Slot_SelfSlot),
                ],
            };
            forest0.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Field_Shield)]);
            forest0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability forest1 = new Ability("Black Forest", "Forest_2_A")
            {
                Description = "Apply 10 Shield to the positon(s) of the lowest health party member(s).\nIncrease this party member's Warts strength by 2.",
                AbilitySprite = ResourceLoader.LoadSprite("GommaForest"),
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Thorns,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ForestShield, 10, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(WartsUp, 2, Targeting.Slot_SelfSlot),
                ],
            };
            forest1.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Field_Shield)]);
            forest1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability forest2 = new Ability("Burning Forest", "Forest_3_A")
            {
                Description = "Apply 13 Shield to the positon(s) of the lowest health party member(s).\nIncrease this party member's Warts strength by 2.",
                AbilitySprite = ResourceLoader.LoadSprite("GommaForest"),
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Thorns,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ForestShield, 13, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(WartsUp, 2, Targeting.Slot_SelfSlot),
                ],
            };
            forest2.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Field_Shield)]);
            forest2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability forest3 = new Ability("Burning Forest", "Forest_4_A")
            {
                Description = "Apply 17 Shield to the positon(s) of the lowest health party member(s).\nIncrease this party member's Warts strength by 3.",
                AbilitySprite = ResourceLoader.LoadSprite("GommaForest"),
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Thorns,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ForestShield, 17, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(WartsUp, 3, Targeting.Slot_SelfSlot),
                ],
            };
            forest3.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Field_Shield)]);
            forest3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            //scales
            Ability scales0 = new Ability("Budding Scales", "Scales_1_A")
            {
                Description = "Apply 0-8 Shield to the Left and Right positions.\nIncrease this party member's Warts strength by 1.",
                AbilitySprite = ResourceLoader.LoadSprite("GommaScales"),
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Shield,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 0, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScalesShield, 8, Targeting.Slot_AllySides),
                    Effects.GenerateEffect(WartsUp, 1, Targeting.Slot_SelfSlot),
                ],
            };
            scales0.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Field_Shield)]);
            scales0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability scales1 = new Ability("Propagating Scales", "Scales_2_A")
            {
                Description = "Apply 1-11 Shield to the Left and Right positions.\nIncrease this party member's Warts strength by 2.",
                AbilitySprite = ResourceLoader.LoadSprite("GommaScales"),
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Shield,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScalesShield, 11, Targeting.Slot_AllySides),
                    Effects.GenerateEffect(WartsUp, 2, Targeting.Slot_SelfSlot),
                ],
            };
            scales1.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Field_Shield)]);
            scales1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability scales2 = new Ability("Human Scales", "Scales_3_A")
            {
                Description = "Apply 1-17 Shield to the Left and Right positions.\nIncrease this party member's Warts strength by 2.",
                AbilitySprite = ResourceLoader.LoadSprite("GommaScales"),
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Shield,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScalesShield, 17, Targeting.Slot_AllySides),
                    Effects.GenerateEffect(WartsUp, 2, Targeting.Slot_SelfSlot),
                ],
            };
            scales2.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Field_Shield)]);
            scales2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability scales3 = new Ability("Nacre Scales", "Scales_4_A")
            {
                Description = "Apply 1-21 Shield to the Left and Right positions.\nIncrease this party member's Warts strength by 3.",
                AbilitySprite = ResourceLoader.LoadSprite("GommaScales"),
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Shield,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScalesShield, 21, Targeting.Slot_AllySides),
                    Effects.GenerateEffect(WartsUp, 3, Targeting.Slot_SelfSlot),
                ],
            };
            scales3.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Field_Shield)]);
            scales3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            //smoke
            Ability smoke0 = new Ability("White Smoke", "Smoke_1_A")
            {
                Description = "Increase this party member's Warts strength by 2.\nHeal this party member 1 health.\n40% chance to refresh this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("GommaSmoke"),
                Cost = [Pigments.Red],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(WartsUp, 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 1, Targeting.Slot_SelfSlot, SmokeChance0),
                ],
            };
            smoke0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);
            smoke0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability smoke1 = new Ability("Gray Smoke", "Smoke_2_A")
            {
                Description = "Increase this party member's Warts strength by 2.\nHeal this party member 1 health.\n50% chance to refresh this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("GommaSmoke"),
                Cost = [Pigments.Red],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(WartsUp, 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 1, Targeting.Slot_SelfSlot, SmokeChance1),
                ],
            };
            smoke1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);
            smoke1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability smoke2 = new Ability("Brown Smoke", "Smoke_3_A")
            {
                Description = "Increase this party member's Warts strength by 3.\nHeal this party member 1 health.\n50% chance to refresh this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("GommaSmoke"),
                Cost = [Pigments.Red],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(WartsUp, 3, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 1, Targeting.Slot_SelfSlot, SmokeChance1),
                ],
            };
            smoke2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);
            smoke2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability smoke3 = new Ability("Black Smoke", "Smoke_4_A")
            {
                Description = "Increase this party member's Warts strength by 3.\nHeal this party member 1 health.\n60% chance to refresh this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("GommaSmoke"),
                Cost = [Pigments.Red],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(WartsUp, 3, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 1, Targeting.Slot_SelfSlot, SmokeChance2),
                ],
            };
            smoke3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);
            smoke3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Refresh)]);


            gomma.AddLevelData(13, new Ability[] { forest0, scales0, smoke0 });
            gomma.AddLevelData(15, new Ability[] { forest1, scales1, smoke1 });
            gomma.AddLevelData(18, new Ability[] { forest2, scales2, smoke2 });
            gomma.AddLevelData(21, new Ability[] { forest3, scales3, smoke3 });

            //gomma.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Gomma_Witness_ACH");
            //gomma.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Gomma_Divine_ACH");
            gomma.AddCharacter(true, false);
        }
    }
}
