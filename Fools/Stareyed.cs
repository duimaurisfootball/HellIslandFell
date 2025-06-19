using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Fools
{
    public class Stareyed
    {
        public static void Add()
        {
            Character stareyed = new Character("Stareyed", "Stareyed_CH")
            {
                HealthColor = Pigments.Purple,
                UsesBasicAbility = true,
                MovesOnOverworld = false,
                FrontSprite = ResourceLoader.LoadSprite("StareyedFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("StareyedBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("StareyedOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("Burnout_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("Burnout_CH").deathSound,
                DialogueSound = LoadedAssetsHandler.GetCharacter("Burnout_CH").dxSound,
                UnitTypes =
                [
                    "Sandwich_BDSM",
                ],
            };
            stareyed.GenerateMenuCharacter(ResourceLoader.LoadSprite("StareyedMenu"), ResourceLoader.LoadSprite("StareyedLocked"));
            stareyed.AddPassives([Passives.GetCustomPassive("Mirage_PA")]);
            stareyed.SetMenuCharacterAsFullDPS();

            LoadedDBsHandler.StatusFieldDB.TryGetFieldEffect("ShadowHands_ID", out FieldEffect_SO ShadowHands);
            FieldEffect_Apply_Effect ShadowHandsApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ShadowHandsApply._Field = ShadowHands;

            FieldEffect_ApplySplitBetween_Effect InvisibleApply = ScriptableObject.CreateInstance<FieldEffect_ApplySplitBetween_Effect>();
            InvisibleApply._Field = ShadowHands;

            StatusEffect_Apply_Effect RupturedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            RupturedApply._Status = StatusField.Ruptured;

            //blink
            Ability blink0 = new Ability("Blink Low", "HIF_Blink_1_A")
            {
                Description = "Deal 7 damage to the Opposing enemy.\nApply 3 Shadow Hands to the Opposing enemy position.",
                AbilitySprite = ResourceLoader.LoadSprite("StareyedBlink"),
                Cost = [Pigments.Red],
                Visuals = Visuals.Crush,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 7, Targeting.Slot_Front),
                    Effects.GenerateEffect(ShadowHandsApply, 3, Targeting.Slot_Front),
                ]
            };
            blink0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);
            blink0.AddIntentsToTarget(Targeting.Slot_Front, ["Field_ShadowHands"]);

            Ability blink1 = new Ability("Blink Terse", "HIF_Blink_2_A")
            {
                Description = "Deal 10 damage to the Opposing enemy.\nApply 3 Shadow Hands to the Opposing enemy position.",
                AbilitySprite = ResourceLoader.LoadSprite("StareyedBlink"),
                Cost = [Pigments.Red],
                Visuals = Visuals.Crush,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 10, Targeting.Slot_Front),
                    Effects.GenerateEffect(ShadowHandsApply, 3, Targeting.Slot_Front),
                ]
            };
            blink1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);
            blink1.AddIntentsToTarget(Targeting.Slot_Front, ["Field_ShadowHands"]);

            Ability blink2 = new Ability("Blink Sharp", "HIF_Blink_3_A")
            {
                Description = "Deal 13 damage to the Opposing enemy.\nApply 4 Shadow Hands to the Opposing enemy position.",
                AbilitySprite = ResourceLoader.LoadSprite("StareyedBlink"),
                Cost = [Pigments.Red],
                Visuals = Visuals.Crush,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 13, Targeting.Slot_Front),
                    Effects.GenerateEffect(ShadowHandsApply, 4, Targeting.Slot_Front),
                ]
            };
            blink2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_11_15)]);
            blink2.AddIntentsToTarget(Targeting.Slot_Front, ["Field_ShadowHands"]);

            Ability blink3 = new Ability("Blink Once", "HIF_Blink_4_A")
            {
                Description = "Deal 17 damage to the Opposing enemy.\nApply 4 Shadow Hands to the Opposing enemy position.",
                AbilitySprite = ResourceLoader.LoadSprite("StareyedBlink"),
                Cost = [Pigments.Red],
                Visuals = Visuals.Crush,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 17, Targeting.Slot_Front),
                    Effects.GenerateEffect(ShadowHandsApply, 4, Targeting.Slot_Front),
                ]
            };
            blink3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_16_20)]);
            blink3.AddIntentsToTarget(Targeting.Slot_Front, ["Field_ShadowHands"]);

            //invisible
            Ability invisible0 = new Ability("Wave Invisible", "HIF_Invisible_1_A")
            {
                Description = "Apply 4 Shadow Hands split randomly between the Left, Right, and Opposing enemy positions.\nApply 2 Ruptured to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("StareyedInvisible"),
                Cost = [Pigments.Red, Pigments.Yellow],
                Visuals = Visuals.Poke,
                AnimationTarget = Targeting.Slot_FrontAndSides,
                Effects =
                [
                    Effects.GenerateEffect(InvisibleApply, 4, Targeting.Slot_FrontAndSides),
                    Effects.GenerateEffect(RupturedApply, 2, Targeting.Slot_Front),
                ]
            };
            invisible0.AddIntentsToTarget(Targeting.Slot_FrontAndSides, ["Field_ShadowHands"]);
            invisible0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Ruptured)]);

            Ability invisible1 = new Ability("Vibrate Invisible", "HIF_Invisible_2_A")
            {
                Description = "Apply 6 Shadow Hands split randomly between the Left, Right, and Opposing enemy positions\nApply 2 Ruptured to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("StareyedInvisible"),
                Cost = [Pigments.Red, Pigments.Yellow],
                Visuals = Visuals.Poke,
                AnimationTarget = Targeting.Slot_FrontAndSides,
                Effects =
                [
                    Effects.GenerateEffect(InvisibleApply, 6, Targeting.Slot_FrontAndSides),
                    Effects.GenerateEffect(RupturedApply, 2, Targeting.Slot_Front),
                ]
            };
            invisible1.AddIntentsToTarget(Targeting.Slot_FrontAndSides, ["Field_ShadowHands"]);
            invisible1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Ruptured)]);

            Ability invisible2 = new Ability("Outline Invisible", "HIF_Invisible_3_A")
            {
                Description = "Apply 8 Shadow Hands split randomly between the Left, Right, and Opposing enemy positions\nApply 2 Ruptured to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("StareyedInvisible"),
                Cost = [Pigments.Red, Pigments.Yellow],
                Visuals = Visuals.Poke,
                AnimationTarget = Targeting.Slot_FrontAndSides,
                Effects =
                [
                    Effects.GenerateEffect(InvisibleApply, 8, Targeting.Slot_FrontAndSides),
                    Effects.GenerateEffect(RupturedApply, 2, Targeting.Slot_Front),
                ]
            };
            invisible2.AddIntentsToTarget(Targeting.Slot_FrontAndSides, ["Field_ShadowHands"]);
            invisible2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Ruptured)]);

            Ability invisible3 = new Ability("Touch Invisible", "HIF_Invisible_4_A")
            {
                Description = "Apply 10 Shadow Hands split randomly between the Left, Right, and Opposing enemy positions\nApply 2 Ruptured to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("StareyedInvisible"),
                Cost = [Pigments.Red, Pigments.Yellow],
                Visuals = Visuals.Poke,
                AnimationTarget = Targeting.Slot_FrontAndSides,
                Effects =
                [
                    Effects.GenerateEffect(InvisibleApply, 10, Targeting.Slot_FrontAndSides),
                    Effects.GenerateEffect(RupturedApply, 2, Targeting.Slot_Front),
                ]
            };
            invisible3.AddIntentsToTarget(Targeting.Slot_FrontAndSides, ["Field_ShadowHands"]);
            invisible3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Ruptured)]);

            //margins
            Ability margins0 = new Ability("Radiation Margins", "HIF_Margins_1_A")
            {
                Description = "Apply 2 Ruptured to all enemies.\nHeal this party member 3 health.",
                AbilitySprite = ResourceLoader.LoadSprite("StareyedMargins"),
                Cost = [Pigments.Purple],
                Visuals = Visuals.Genesis,
                AnimationTarget = Targeting.Unit_AllOpponents,
                Effects =
                [
                    Effects.GenerateEffect(RupturedApply, 2, Targeting.Unit_AllOpponents),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 3, Targeting.Slot_SelfSlot),
                ]
            };
            margins0.AddIntentsToTarget(Targeting.Unit_AllOpponents, [nameof(IntentType_GameIDs.Status_Ruptured)]);
            margins0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_1_4)]);

            Ability margins1 = new Ability("Background Margins", "HIF_Margins_2_A")
            {
                Description = "Apply 3 Ruptured to all enemies.\nHeal this party member 3 health.",
                AbilitySprite = ResourceLoader.LoadSprite("StareyedMargins"),
                Cost = [Pigments.Purple],
                Visuals = Visuals.Genesis,
                AnimationTarget = Targeting.Unit_AllOpponents,
                Effects =
                [
                    Effects.GenerateEffect(RupturedApply, 3, Targeting.Unit_AllOpponents),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 3, Targeting.Slot_SelfSlot),
                ]
            };
            margins1.AddIntentsToTarget(Targeting.Unit_AllOpponents, [nameof(IntentType_GameIDs.Status_Ruptured)]);
            margins1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_1_4)]);

            Ability margins2 = new Ability("Microwave Margins", "HIF_Margins_3_A")
            {
                Description = "Apply 4 Ruptured to all enemies.\nHeal this party member 3 health.",
                AbilitySprite = ResourceLoader.LoadSprite("StareyedMargins"),
                Cost = [Pigments.Purple],
                Visuals = Visuals.Genesis,
                AnimationTarget = Targeting.Unit_AllOpponents,
                Effects =
                [
                    Effects.GenerateEffect(RupturedApply, 4, Targeting.Unit_AllOpponents),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 3, Targeting.Slot_SelfSlot),
                ]
            };
            margins2.AddIntentsToTarget(Targeting.Unit_AllOpponents, [nameof(IntentType_GameIDs.Status_Ruptured)]);
            margins2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_1_4)]);

            Ability margins3 = new Ability("Cosmic Margins", "HIF_Margins_4_A")
            {
                Description = "Apply 4 Ruptured to all enemies.\nHeal this party member 3 health.",
                AbilitySprite = ResourceLoader.LoadSprite("StareyedMargins"),
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Genesis,
                AnimationTarget = Targeting.Unit_AllOpponents,
                Effects =
                [
                    Effects.GenerateEffect(RupturedApply, 4, Targeting.Unit_AllOpponents),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 3, Targeting.Slot_SelfSlot),
                ]
            };
            margins3.AddIntentsToTarget(Targeting.Unit_AllOpponents, [nameof(IntentType_GameIDs.Status_Ruptured)]);
            margins3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_1_4)]);

            stareyed.AddLevelData(20, [blink0, invisible0, margins0]);
            stareyed.AddLevelData(22, [blink1, invisible1, margins1]);
            stareyed.AddLevelData(25, [blink2, invisible2, margins2]);
            stareyed.AddLevelData(28, [blink3, invisible3, margins3]);

            stareyed.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Stareyed_Witness_ACH");
            stareyed.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Stareyed_Divine_ACH");
            stareyed.AddCharacter(true, false);
        }
    }
}
