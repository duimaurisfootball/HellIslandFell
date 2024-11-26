using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using UnityEngine;

namespace Hell_Island_Fell.Fools
{
    public class Vandander
    {
        public static void Add()
        {
            ExtraCCSprites_ArraySO HoleSprites = ScriptableObject.CreateInstance<ExtraCCSprites_ArraySO>();
            HoleSprites._doesLoop = true;
            HoleSprites._DefaultID = "VandanderSpritesDefault";
            HoleSprites._SpecialID = "VandanderSpritesSpecial";
            HoleSprites._frontSprite =
                [
                    ResourceLoader.LoadSprite("VandanderFrontChunk", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("VandanderFrontFew", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("VandanderFrontVoid", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("VandanderFrontBasic", new Vector2(0.5f, 0f), 32),
                ];
            HoleSprites._backSprite =
                [
                    ResourceLoader.LoadSprite("VandanderBackChunk", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("VandanderBackFew", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("VandanderBackVoid", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("VandanderBackBasic", new Vector2(0.5f, 0f), 32),
                ];

            Character vandander = new Character("Vandander", "Vandander_CH")
            {
                HealthColor = Pigments.Purple,
                UsesBasicAbility = true,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("VandanderFrontBasic", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("VandanderBackBasic", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("VandanderOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("TaMaGoa_EN").deathSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("TaintedYolk_EN").deathSound,
                DialogueSound = LoadedAssetsHandler.GetEnemy("TaMaGoa_EN").damageSound,
                ExtraSprites = HoleSprites,
                UnitTypes =
                [
                    UnitType_GameIDs.Fish.ToString(),
                ],
            };
            vandander.GenerateMenuCharacter(ResourceLoader.LoadSprite("VandanderMenu"), ResourceLoader.LoadSprite("VandanderLocked"));
            vandander.SetMenuCharacterAsFullSupport();
            vandander.AddPassives([Passives.Delicate, Passives.Enfeebled]);

            CheckTargetMissingHealthEffect HalfCheck = ScriptableObject.CreateInstance<CheckTargetMissingHealthEffect>();

            SetCasterExtraSpritesEffect BoilEffect = ScriptableObject.CreateInstance<SetCasterExtraSpritesEffect>();
            BoilEffect._ExtraSpriteID = "VandanderSpritesSpecial";

            StatusEffect_Apply_Effect LinkedApply1 = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            LinkedApply1._Status = StatusField.Linked;

            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Disappearing_ID", out StatusEffect_SO Disappearing);
            StatusEffect_Apply_Effect DisappearingApply1 = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            DisappearingApply1._Status = Disappearing;

            StatusEffect_Apply_PreviousExit_Effect DisappearingApply2 = ScriptableObject.CreateInstance<StatusEffect_Apply_PreviousExit_Effect>();
            DisappearingApply2._Status = Disappearing;

            StatusEffect_Apply_Effect FrailApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            FrailApply._Status = StatusField.Frail;

            HealEffect HealMax = ScriptableObject.CreateInstance<HealEffect>();
            HealMax.entryAsPercentage = true;

            PercentageEffectCondition Chance0 = ScriptableObject.CreateInstance<PercentageEffectCondition>();
            Chance0.percentage = 50;

            //vow
            Ability vow0 = new Ability("Vaguely Vow", "Vow_1_A")
            {
                Description = "Apply 2 Linked to the Opposing enemy.\nApply 8 Disappearing to the Opposing enemy.\nIf the Left ally is below half health, apply an additional 8 Disappearing to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("VandanderVow"),
                Cost = [Pigments.Red, Pigments.Red],
                Visuals = Visuals.Genesis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(LinkedApply1, 2, Targeting.Slot_Front),
                    Effects.GenerateEffect(DisappearingApply1, 8, Targeting.Slot_Front),
                    Effects.GenerateEffect(HalfCheck, 50, Targeting.Slot_AllyLeft),
                    Effects.GenerateEffect(DisappearingApply1, 8, Targeting.Slot_Front, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot, Chance0),
                ]
            };
            vow0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Linked)]);
            vow0.AddIntentsToTarget(Targeting.Slot_AllyLeft, [nameof(IntentType_GameIDs.Misc)]);
            vow0.AddIntentsToTarget(Targeting.Slot_Front, ["Status_Disappearing"]);

            Ability vow1 = new Ability("Vicvariously Vow", "Vow_2_A")
            {
                Description = "Apply 2 Linked to the Opposing enemy.\nApply 12 Disappearing to the Opposing enemy.\nIf the Left ally is below half health, apply an additional 12 Disappearing to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("VandanderVow"),
                Cost = [Pigments.Red, Pigments.Red],
                Visuals = Visuals.Genesis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(LinkedApply1, 2, Targeting.Slot_Front),
                    Effects.GenerateEffect(DisappearingApply1, 12, Targeting.Slot_Front),
                    Effects.GenerateEffect(HalfCheck, 50, Targeting.Slot_AllyLeft),
                    Effects.GenerateEffect(DisappearingApply1, 12, Targeting.Slot_Front, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot, Chance0),
                ]
            };
            vow1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Linked)]);
            vow1.AddIntentsToTarget(Targeting.Slot_AllyLeft, [nameof(IntentType_GameIDs.Misc)]);
            vow1.AddIntentsToTarget(Targeting.Slot_Front, ["Status_Disappearing"]);

            Ability vow2 = new Ability("Voraciously Vow", "Vow_3_A")
            {
                Description = "Apply 2 Linked to the Opposing enemy.\nApply 14 Disappearing to the Opposing enemy.\nIf the Left ally is below half health, apply an additional 14 Disappearing to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("VandanderVow"),
                Cost = [Pigments.SplitPigment(Pigments.Red, Pigments.Purple), Pigments.Red],
                Visuals = Visuals.Genesis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(LinkedApply1, 2, Targeting.Slot_Front),
                    Effects.GenerateEffect(DisappearingApply1, 14, Targeting.Slot_Front),
                    Effects.GenerateEffect(HalfCheck, 50, Targeting.Slot_AllyLeft),
                    Effects.GenerateEffect(DisappearingApply1, 14, Targeting.Slot_Front, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot, Chance0),
                ]
            };
            vow2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Linked)]);
            vow2.AddIntentsToTarget(Targeting.Slot_AllyLeft, [nameof(IntentType_GameIDs.Misc)]);
            vow2.AddIntentsToTarget(Targeting.Slot_Front, ["Status_Disappearing"]);

            Ability vow3 = new Ability("Vicariously Vow", "Vow_4_A")
            {
                Description = "Apply 2 Linked to the Opposing enemy.\nApply 16 Disappearing to the Opposing enemy.\nIf the Left ally is below half health, apply an additional 16 Disappearing to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("VandanderVow"),
                Cost = [Pigments.SplitPigment(Pigments.Red, Pigments.Purple), Pigments.SplitPigment(Pigments.Red, Pigments.Purple)],
                Visuals = Visuals.Genesis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(LinkedApply1, 2, Targeting.Slot_Front),
                    Effects.GenerateEffect(DisappearingApply1, 16, Targeting.Slot_Front),
                    Effects.GenerateEffect(HalfCheck, 50, Targeting.Slot_AllyLeft),
                    Effects.GenerateEffect(DisappearingApply1, 16, Targeting.Slot_Front, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot, Chance0),
                ]
            };
            vow3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Linked)]);
            vow3.AddIntentsToTarget(Targeting.Slot_AllyLeft, [nameof(IntentType_GameIDs.Misc)]);
            vow3.AddIntentsToTarget(Targeting.Slot_Front, ["Status_Disappearing"]);


            //vent
            Ability vent0 = new Ability("Viewing Ventilations", "Vent_1_A")
            {
                Description = "Apply 1 Frail to the Opposing enemy.\nIf the Left ally is below half health, apply an additional 1 Frail to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("VandanderVent"),
                Cost = [Pigments.Red, Pigments.Yellow, Pigments.Blue],
                Visuals = Visuals.Equal,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(FrailApply, 1, Targeting.Slot_Front),
                    Effects.GenerateEffect(HalfCheck, 50, Targeting.Slot_AllyLeft),
                    Effects.GenerateEffect(FrailApply, 1, Targeting.Slot_Front, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot, Chance0),
                ]
            };
            vent0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Frail)]);
            vent0.AddIntentsToTarget(Targeting.Slot_AllyLeft, [nameof(IntentType_GameIDs.Misc)]);

            Ability vent1 = new Ability("Vigilant Ventilations", "Vent_2_A")
            {
                Description = "Apply 1 Frail to the Opposing enemy.\nIf the Left ally is below half health, apply an additional 1 Frail to the Opposing enemy.\nHeal this party member 1 health.",
                AbilitySprite = ResourceLoader.LoadSprite("VandanderVent"),
                Cost = [Pigments.Red, Pigments.Yellow, Pigments.Blue],
                Visuals = Visuals.Equal,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(FrailApply, 1, Targeting.Slot_Front),
                    Effects.GenerateEffect(HalfCheck, 50, Targeting.Slot_AllyLeft),
                    Effects.GenerateEffect(FrailApply, 1, Targeting.Slot_Front, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot, Chance0),
                ]
            };
            vent1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Frail)]);
            vent1.AddIntentsToTarget(Targeting.Slot_AllyLeft, [nameof(IntentType_GameIDs.Misc)]);
            vent1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_1_4)]);

            Ability vent2 = new Ability("Virulent Ventilations", "Vent_3_A")
            {
                Description = "Apply 2 Frail to the Opposing enemy.\nIf the Left ally is below half health, apply an additional 1 Frail to the Opposing enemy.\nHeal this party member 1 health.",
                AbilitySprite = ResourceLoader.LoadSprite("VandanderVent"),
                Cost = [Pigments.Red, Pigments.Yellow, Pigments.Blue],
                Visuals = Visuals.Equal,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(FrailApply, 2, Targeting.Slot_Front),
                    Effects.GenerateEffect(HalfCheck, 50, Targeting.Slot_AllyLeft),
                    Effects.GenerateEffect(FrailApply, 1, Targeting.Slot_Front, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot, Chance0),
                ]
            };
            vent2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Frail)]);
            vent2.AddIntentsToTarget(Targeting.Slot_AllyLeft, [nameof(IntentType_GameIDs.Misc)]);
            vent2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_1_4)]);

            Ability vent3 = new Ability("Vivid Ventilations", "Vent_4_A")
            {
                Description = "Apply 2 Frail to the Opposing enemy.\nIf the Left ally is below half health, apply an additional 1 Frail to the Opposing enemy.\nHeal this party member 2 health.",
                AbilitySprite = ResourceLoader.LoadSprite("VandanderVent"),
                Cost = [Pigments.Red, Pigments.Yellow, Pigments.Blue],
                Visuals = Visuals.Equal,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(FrailApply, 2, Targeting.Slot_Front),
                    Effects.GenerateEffect(HalfCheck, 50, Targeting.Slot_AllyLeft),
                    Effects.GenerateEffect(FrailApply, 1, Targeting.Slot_Front, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot, Chance0),
                ]
            };
            vent3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Frail)]);
            vent3.AddIntentsToTarget(Targeting.Slot_AllyLeft, [nameof(IntentType_GameIDs.Misc)]);
            vent3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_1_4)]);

            //vandala
            Ability vandala0 = new Ability("Vandala Effect, Vacantly", "Vandala_1_A")
            {
                Description = "Randomize this party member's and the Right ally's health.\nAttempt to resurrect a party member in the Right ally position.\nHeal this party member and the Right ally 1/4 their individual max health.",
                AbilitySprite = ResourceLoader.LoadSprite("VandanderVandalaEffect"),
                Cost = [Pigments.Purple, Pigments.Blue],
                Visuals = Visuals.Miracle,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RandomizeHealthEffect>(), 1, Targeting.Slot_SelfAndRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ResurrectEffect>(), 1, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(HealMax, 25, Targeting.Slot_SelfAndRight),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot, Chance0),
                ]
            };
            vandala0.AddIntentsToTarget(Targeting.Slot_SelfAndRight, [nameof(IntentType_GameIDs.Other_MaxHealth)]);
            vandala0.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Other_Resurrect)]);
            vandala0.AddIntentsToTarget(Targeting.Slot_SelfAndRight, [nameof(IntentType_GameIDs.Heal_1_4)]);

            Ability vandala1 = new Ability("Vandala Effect, Variously", "Vandala_2_A")
            {
                Description = "Randomize this party member's and the Right ally's health.\nAttempt to resurrect a party member in the Right ally position.\nHeal this party member and the Right ally 1/3 their individual max health.",
                AbilitySprite = ResourceLoader.LoadSprite("VandanderVandalaEffect"),
                Cost = [Pigments.Purple, Pigments.Blue],
                Visuals = Visuals.Miracle,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RandomizeHealthEffect>(), 1, Targeting.Slot_SelfAndRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ResurrectEffect>(), 1, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(HealMax, 33, Targeting.Slot_SelfAndRight),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot, Chance0),
                ]
            };
            vandala1.AddIntentsToTarget(Targeting.Slot_SelfAndRight, [nameof(IntentType_GameIDs.Other_MaxHealth)]);
            vandala1.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Other_Resurrect)]);
            vandala1.AddIntentsToTarget(Targeting.Slot_SelfAndRight, [nameof(IntentType_GameIDs.Heal_5_10)]);

            Ability vandala2 = new Ability("Vandala Effect, Virtuously", "Vandala_3_A")
            {
                Description = "Randomize this party member's and the Right ally's health.\nAttempt to resurrect a party member in the Right ally position.\nHeal this party member and the Right ally 1/2 their individual max health.",
                AbilitySprite = ResourceLoader.LoadSprite("VandanderVandalaEffect"),
                Cost = [Pigments.Purple, Pigments.Blue],
                Visuals = Visuals.Miracle,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RandomizeHealthEffect>(), 1, Targeting.Slot_SelfAndRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ResurrectEffect>(), 1, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(HealMax, 50, Targeting.Slot_SelfAndRight),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot, Chance0),
                ]
            };
            vandala2.AddIntentsToTarget(Targeting.Slot_SelfAndRight, [nameof(IntentType_GameIDs.Other_MaxHealth)]);
            vandala2.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Other_Resurrect)]);
            vandala2.AddIntentsToTarget(Targeting.Slot_SelfAndRight, [nameof(IntentType_GameIDs.Heal_11_20)]);

            Ability vandala3 = new Ability("Vandala Effect, Visibly", "Vandala_4_A")
            {
                Description = "Randomize this party member's and the Right ally's health.\nAttempt to resurrect a party member in the Right ally position.\nHeal this party member and the Right ally 1/2 their individual max health.",
                AbilitySprite = ResourceLoader.LoadSprite("VandanderVandalaEffect"),
                Cost = [Pigments.Blue, Pigments.PurpleBlue],
                Visuals = Visuals.Miracle,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RandomizeHealthEffect>(), 1, Targeting.Slot_SelfAndRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ResurrectEffect>(), 1, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(HealMax, 50, Targeting.Slot_SelfAndRight),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(BoilEffect, 1, Targeting.Slot_SelfSlot, Chance0),
                ]
            };
            vandala3.AddIntentsToTarget(Targeting.Slot_SelfAndRight, [nameof(IntentType_GameIDs.Other_MaxHealth)]);
            vandala3.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Other_Resurrect)]);
            vandala3.AddIntentsToTarget(Targeting.Slot_SelfAndRight, [nameof(IntentType_GameIDs.Heal_11_20)]);

            vandander.AddLevelData(15, new Ability[] { vow0, vent0, vandala0 });
            vandander.AddLevelData(19, new Ability[] { vow1, vent1, vandala1 });
            vandander.AddLevelData(24, new Ability[] { vow2, vent2, vandala2 });
            vandander.AddLevelData(28, new Ability[] { vow3, vent3, vandala3 });

            vandander.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Vandander_Witness_ACH");
            vandander.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Vandander_Divine_ACH");
            vandander.AddCharacter(true, false);
        }
    }
}
