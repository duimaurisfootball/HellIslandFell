using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using MonoMod.RuntimeDetour;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Fools
{
    public class Alvinar
    {
        public static void Add()
        {
            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Salted_ID", out StatusEffect_SO Salted);
            StatusEffect_Apply_Effect SaltedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            SaltedApply._Status = Salted;

            //prepare
            Ability prepare = new Ability("Prepare", "Prepare_A")
            {
                Description = "Deal 1 damage to the Opposing enemy.\nApply 2 Salted to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("AlvinarPrepare"),
                Cost = [Pigments.Yellow],
                Visuals = Visuals.OilSlicked,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 1, Targeting.Slot_Front),
                    Effects.GenerateEffect(SaltedApply, 2, Targeting.Slot_Front),
                ],
            };
            prepare.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_1_2)]);
            prepare.AddIntentsToTarget(Targeting.Slot_Front, ["Status_Salted"]);

            Character alvinar = new Character("Alvinar", "Alvinar_CH")
            {
                HealthColor = Pigments.Purple,
                UsesBasicAbility = true,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("AlvinarFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("AlvinarBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("AlvinarOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("Boyle_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("Boyle_CH").deathSound,
                DialogueSound = LoadedAssetsHandler.GetCharacter("Boyle_CH").dxSound,
                BasicAbility = prepare,
            };
            alvinar.GenerateMenuCharacter(ResourceLoader.LoadSprite("AlvinarMenu"), ResourceLoader.LoadSprite("AlvinarLocked"));
            alvinar.AddPassives([Passives.GetCustomPassive("Connoisseur_PA")]);
            alvinar.SetMenuCharacterAsFullDPS();

            DamageFieldEffectBlockedGibsEffect BlockedDamage = ScriptableObject.CreateInstance<DamageFieldEffectBlockedGibsEffect>();
            BlockedDamage._Field = StatusField.Shield;

            StatusEffect_Apply_FieldEffectBlocked_Effect FrailApply = ScriptableObject.CreateInstance<StatusEffect_Apply_FieldEffectBlocked_Effect>();
            FrailApply._Status = StatusField.Frail;
            FrailApply._Field = StatusField.Shield;

            StatusEffect_Apply_FieldEffectBlocked_Effect RupturedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_FieldEffectBlocked_Effect>();
            RupturedApply._Status = StatusField.Ruptured;
            RupturedApply._Field = StatusField.Shield;

            StatusEffect_Apply_Effect OilSlickedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            OilSlickedApply._Status = StatusField.OilSlicked;

            //frenzied
            Ability frenzied0 = new Ability("Frenzied Chewing", "Frenzied_1_A")
            {
                Description = "Deal 3 damage to the Opposing enemy twice.\nApply 1 Frail to the Opposing enemy.\nThis ability is blocked by shield.",
                AbilitySprite = ResourceLoader.LoadSprite("AlvinarFrenzy"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Purple],
                Visuals = Visuals.Gnaw,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(BlockedDamage, 3, Targeting.Slot_Front),
                    Effects.GenerateEffect(BlockedDamage, 3, Targeting.Slot_Front),
                    Effects.GenerateEffect(FrailApply, 1, Targeting.Slot_Front),
                ],
            };
            frenzied0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            frenzied0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            frenzied0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Frail)]);

            Ability frenzied1 = new Ability("Frenzied Gnawing", "Frenzied_2_A")
            {
                Description = "Deal 5 damage to the Opposing enemy twice.\nApply 1 Frail to the Opposing enemy.\nThis ability is blocked by shield.",
                AbilitySprite = ResourceLoader.LoadSprite("AlvinarFrenzy"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Purple],
                Visuals = Visuals.Gnaw,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(BlockedDamage, 5, Targeting.Slot_Front),
                    Effects.GenerateEffect(BlockedDamage, 5, Targeting.Slot_Front),
                    Effects.GenerateEffect(FrailApply, 1, Targeting.Slot_Front),
                ],
            };
            frenzied1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            frenzied1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            frenzied1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Frail)]);

            Ability frenzied2 = new Ability("Frenzied Wounding", "Frenzied_3_A")
            {
                Description = "Deal 6 damage to the Opposing enemy twice.\nApply 1 Frail to the Opposing enemy.\nThis ability is blocked by shield.",
                AbilitySprite = ResourceLoader.LoadSprite("AlvinarFrenzy"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Purple],
                Visuals = Visuals.Gnaw,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(BlockedDamage, 6, Targeting.Slot_Front),
                    Effects.GenerateEffect(BlockedDamage, 6, Targeting.Slot_Front),
                    Effects.GenerateEffect(FrailApply, 1, Targeting.Slot_Front),
                ],
            };
            frenzied2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            frenzied2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            frenzied2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Frail)]);

            Ability frenzied3 = new Ability("Frenzied Mastication", "Frenzied_4_A")
            {
                Description = "Deal 7 damage to the Opposing enemy twice.\nApply 1 Frail to the Opposing enemy.\nThis ability is blocked by shield.",
                AbilitySprite = ResourceLoader.LoadSprite("AlvinarFrenzy"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Purple],
                Visuals = Visuals.Gnaw,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(BlockedDamage, 7, Targeting.Slot_Front),
                    Effects.GenerateEffect(BlockedDamage, 7, Targeting.Slot_Front),
                    Effects.GenerateEffect(FrailApply, 1, Targeting.Slot_Front),
                ],
            };
            frenzied3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);
            frenzied3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);
            frenzied3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Frail)]);


            //feast
            Ability feast0 = new Ability("Small Feast", "aFeast_1_A")
            {
                Description = "Deal 4 damage to the Left and Right enemies.\nApply 3 Oil Slicked to the Left and Right enemies.\nThis ability is blocked by shield.",
                AbilitySprite = ResourceLoader.LoadSprite("AlvinarFeast"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Blue],
                Visuals = Visuals.Chomp,
                AnimationTarget = Targeting.Slot_OpponentSides,
                Effects =
                [
                    Effects.GenerateEffect(BlockedDamage, 4, Targeting.Slot_OpponentSides),
                    Effects.GenerateEffect(OilSlickedApply, 3, Targeting.Slot_OpponentSides),
                ],
            };
            feast0.AddIntentsToTarget(Targeting.Slot_OpponentSides, [nameof(IntentType_GameIDs.Damage_3_6)]);
            feast0.AddIntentsToTarget(Targeting.Slot_OpponentSides, [nameof(IntentType_GameIDs.Status_OilSlicked)]);

            Ability feast1 = new Ability("Hearty Feast", "aFeast_2_A")
            {
                Description = "Deal 6 damage to the Left and Right enemies.\nApply 3 Oil Slicked to the Left and Right enemies.\nThis ability is blocked by shield.",
                AbilitySprite = ResourceLoader.LoadSprite("AlvinarFeast"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Blue],
                Visuals = Visuals.Chomp,
                AnimationTarget = Targeting.Slot_OpponentSides,
                Effects =
                [
                    Effects.GenerateEffect(BlockedDamage, 6, Targeting.Slot_OpponentSides),
                    Effects.GenerateEffect(OilSlickedApply, 3, Targeting.Slot_OpponentSides),
                ],
            };
            feast1.AddIntentsToTarget(Targeting.Slot_OpponentSides, [nameof(IntentType_GameIDs.Damage_3_6)]);
            feast1.AddIntentsToTarget(Targeting.Slot_OpponentSides, [nameof(IntentType_GameIDs.Status_OilSlicked)]);

            Ability feast2 = new Ability("Stuffing Feast", "aFeast_3_A")
            {
                Description = "Deal 8 damage to the Left and Right enemies.\nApply 3 Oil Slicked to the Left and Right enemies.\nThis ability is blocked by shield.",
                AbilitySprite = ResourceLoader.LoadSprite("AlvinarFeast"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Blue],
                Visuals = Visuals.Chomp,
                AnimationTarget = Targeting.Slot_OpponentSides,
                Effects =
                [
                    Effects.GenerateEffect(BlockedDamage, 8, Targeting.Slot_OpponentSides),
                    Effects.GenerateEffect(OilSlickedApply, 3, Targeting.Slot_OpponentSides),
                ],
            };
            feast2.AddIntentsToTarget(Targeting.Slot_OpponentSides, [nameof(IntentType_GameIDs.Damage_7_10)]);
            feast2.AddIntentsToTarget(Targeting.Slot_OpponentSides, [nameof(IntentType_GameIDs.Status_OilSlicked)]);

            Ability feast3 = new Ability("Family Feast", "aFeast_4_A")
            {
                Description = "Deal 9 damage to the Left and Right enemies.\nApply 3 Oil Slicked to the Left and Right enemies.\nThis ability is blocked by shield.",
                AbilitySprite = ResourceLoader.LoadSprite("AlvinarFeast"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Blue],
                Visuals = Visuals.Chomp,
                AnimationTarget = Targeting.Slot_OpponentSides,
                Effects =
                [
                    Effects.GenerateEffect(BlockedDamage, 9, Targeting.Slot_OpponentSides),
                    Effects.GenerateEffect(OilSlickedApply, 3, Targeting.Slot_OpponentSides),
                ],
            };
            feast3.AddIntentsToTarget(Targeting.Slot_OpponentSides, [nameof(IntentType_GameIDs.Damage_7_10)]);
            feast3.AddIntentsToTarget(Targeting.Slot_OpponentSides, [nameof(IntentType_GameIDs.Status_OilSlicked)]);


            //breaker
            Ability breaker0 = new Ability("Face Breaker", "Breaker_1_A")
            {
                Description = "Deal 5 damage to the Opposing enemy.\nApply 4 Ruptured to the Opposing enemy.\nThis ability is blocked by shield.",
                AbilitySprite = ResourceLoader.LoadSprite("AlvinarBreaker"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Yellow],
                Visuals = Visuals.Decimate,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(BlockedDamage, 5, Targeting.Slot_Front),
                    Effects.GenerateEffect(RupturedApply, 4, Targeting.Slot_Front),
                ],
            };
            breaker0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            breaker0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Ruptured)]);

            Ability breaker1 = new Ability("Skull Breaker", "Breaker_2_A")
            {
                Description = "Deal 7 damage to the Opposing enemy.\nApply 4 Ruptured to the Opposing enemy.\nThis ability is blocked by shield.",
                AbilitySprite = ResourceLoader.LoadSprite("AlvinarBreaker"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Yellow],
                Visuals = Visuals.Decimate,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(BlockedDamage, 7, Targeting.Slot_Front),
                    Effects.GenerateEffect(RupturedApply, 4, Targeting.Slot_Front),
                ],
            };
            breaker1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);
            breaker1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Ruptured)]);

            Ability breaker2 = new Ability("Chest Breaker", "Breaker_3_A")
            {
                Description = "Deal 9 damage to the Opposing enemy.\nApply 4 Ruptured to the Opposing enemy.\nThis ability is blocked by shield.",
                AbilitySprite = ResourceLoader.LoadSprite("AlvinarBreaker"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Yellow],
                Visuals = Visuals.Decimate,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(BlockedDamage, 9, Targeting.Slot_Front),
                    Effects.GenerateEffect(RupturedApply, 4, Targeting.Slot_Front),
                ],
            };
            breaker2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);
            breaker2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Ruptured)]);
            
            Ability breaker3 = new Ability("Body Breaker", "Breaker_4_A")
            {
                Description = "Deal 11 damage to the Opposing enemy.\nApply 4 Ruptured to the Opposing enemy.\nThis ability is blocked by shield.",
                AbilitySprite = ResourceLoader.LoadSprite("AlvinarBreaker"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Yellow],
                Visuals = Visuals.Decimate,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(BlockedDamage, 11, Targeting.Slot_Front),
                    Effects.GenerateEffect(RupturedApply, 4, Targeting.Slot_Front),
                ],
            };
            breaker3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_11_15)]);
            breaker3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Ruptured)]);



            alvinar.AddLevelData(12, new Ability[] { frenzied0, feast0, breaker0 });
            alvinar.AddLevelData(13, new Ability[] { frenzied1, feast1, breaker1 });
            alvinar.AddLevelData(14, new Ability[] { frenzied2, feast2, breaker2 });
            alvinar.AddLevelData(16, new Ability[] { frenzied3, feast3, breaker3 });

            alvinar.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Alvinar_Witness_ACH");
            alvinar.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Alvinar_Divine_ACH");
            alvinar.AddCharacter(true, false);
        }
    }
}
