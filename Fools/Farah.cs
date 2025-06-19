using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

namespace Hell_Island_Fell.Fools
{
    public class Farah
    {
        public static void Add()
        {
            Character farah = new Character("Farah", "Farah_CH")
            {
                HealthColor = Pigments.Purple,
                UsesBasicAbility = true,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("FarahFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("FarahBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("FarahOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("Kleiver_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("Kleiver_CH").deathSound,
                DialogueSound = LoadedAssetsHandler.GetEnemy("SilverSuckle_EN").damageSound,
                UnitTypes =
                [
                    "FemaleID",
                    "Sandwich_Pigment",
                ],
            };
            farah.GenerateMenuCharacter(ResourceLoader.LoadSprite("FarahMenu"), ResourceLoader.LoadSprite("FarahLocked"));
            farah.AddPassives([Passives.Slippery, Passives.GetCustomPassive("Impunity_PA")]);
            farah.SetMenuCharacterAsFullSupport();


            FieldEffect_Apply_Effect ConstrictedApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ConstrictedApply._Field = StatusField.Constricted;

            AddPassiveEffect MutualismAdd = ScriptableObject.CreateInstance<AddPassiveEffect>();
            MutualismAdd._passiveToAdd = Passives.ParasiteMutualismTapeWormPills;

            CasterStoredValueChangeEffect MutualismEffect = ScriptableObject.CreateInstance<CasterStoredValueChangeEffect>();
            MutualismEffect.m_unitStoredDataID = UnitStoredValueNames_GameIDs.ParasiteCurrentHealthPA.ToString();
            MutualismEffect._increase = true;
            MutualismEffect._minimumValue = 0;

            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Salted_ID", out StatusEffect_SO Salted);
            StatusEffect_Apply_Effect SaltedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            SaltedApply._Status = Salted;

            FieldEffect_Apply_Effect ShieldApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ShieldApply._Field = StatusField.Shield;

            PercentageEffectCondition Chance0 = ScriptableObject.CreateInstance<PercentageEffectCondition>();
            Chance0.percentage = 30;

            RerollNumberPigmentEffect SumpGray = ScriptableObject.CreateInstance<RerollNumberPigmentEffect>();
            SumpGray._mana = Pigments.Grey;

            //bilge
            Ability bilge0 = new Ability("Nasty Bilge", "HIF_Bilge_1_A")
            {
                Description = "Add 2 empty Mutualism to this party member.\nApply 2 Salted to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("FarahBilge"),
                Cost = [Pigments.Yellow, Pigments.Blue],
                Visuals = Visuals.OilSlicked,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(MutualismAdd, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(MutualismEffect, 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(SaltedApply, 2, Targeting.Slot_Front),
                ]
            };
            bilge0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.PA_Mutualism)]);
            bilge0.AddIntentsToTarget(Targeting.Slot_Front, ["Status_Salted"]);

            Ability bilge1 = new Ability("Infectious Bilge", "HIF_Bilge_2_A")
            {
                Description = "Add 4 empty Mutualism to this party member.\nApply 2 Salted to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("FarahBilge"),
                Cost = [Pigments.Yellow, Pigments.Blue],
                Visuals = Visuals.OilSlicked,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(MutualismAdd, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(MutualismEffect, 4, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(SaltedApply, 2, Targeting.Slot_Front),
                ]
            };
            bilge1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.PA_Mutualism)]);
            bilge1.AddIntentsToTarget(Targeting.Slot_Front, ["Status_Salted"]);

            Ability bilge2 = new Ability("Mutating Bilge", "HIF_Bilge_3_A")
            {
                Description = "Add 5 empty Mutualism to this party member.\nApply 2 Salted to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("FarahBilge"),
                Cost = [Pigments.Yellow, Pigments.Blue],
                Visuals = Visuals.OilSlicked,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(MutualismAdd, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(MutualismEffect, 5, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(SaltedApply, 2, Targeting.Slot_Front),
                ]
            };
            bilge2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.PA_Mutualism)]);
            bilge2.AddIntentsToTarget(Targeting.Slot_Front, ["Status_Salted"]);

            Ability bilge3 = new Ability("Unimaginable Bilge", "HIF_Bilge_4_A")
            {
                Description = "Add 6 empty Mutualism to this party member.\nApply 2 Salted to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("FarahBilge"),
                Cost = [Pigments.Yellow, Pigments.Blue],
                Visuals = Visuals.OilSlicked,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(MutualismAdd, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(MutualismEffect, 6, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(SaltedApply, 2, Targeting.Slot_Front),
                ]
            };
            bilge3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.PA_Mutualism)]);
            bilge3.AddIntentsToTarget(Targeting.Slot_Front, ["Status_Salted"]);


            //film
            Ability film0 = new Ability("Horrid Film", "HIF_Film_1_A")
            {
                Description = "Apply 5 Shield to this position.\n30% chance to remove an ability from the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("FarahFilm"),
                Cost = [Pigments.Yellow, Pigments.Red],
                Visuals = Visuals.MotherlyLove,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ShieldApply, 5, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RemoveTargetTimelineAbilityEffect>(), 1, Targeting.Slot_Front, Chance0),
                ]
            };
            film0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Field_Shield)]);
            film0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Other_Exhaust)]);


            Ability film1 = new Ability("Loathsome Film", "HIF_Film_2_A")
            {
                Description = "Apply 7 Shield to this position.\n30% chance to remove an ability from the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("FarahFilm"),
                Cost = [Pigments.Yellow, Pigments.Red],
                Visuals = Visuals.MotherlyLove,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ShieldApply, 7, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RemoveTargetTimelineAbilityEffect>(), 1, Targeting.Slot_Front, Chance0),
                ]
            };
            film1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Field_Shield)]);
            film1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Other_Exhaust)]);


            Ability film2 = new Ability("Verminous Film", "HIF_Film_3_A")
            {
                Description = "Apply 9 Shield to this position.\n30% chance to remove an ability from the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("FarahFilm"),
                Cost = [Pigments.Yellow, Pigments.Red],
                Visuals = Visuals.MotherlyLove,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ShieldApply, 9, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RemoveTargetTimelineAbilityEffect>(), 1, Targeting.Slot_Front, Chance0),
                ]
            };
            film2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Field_Shield)]);
            film2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Other_Exhaust)]);


            Ability film3 = new Ability("Revolting Film", "HIF_Film_4_A")
            {
                Description = "Apply 11 Shield to this position.\n30% chance to remove an ability from the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("FarahFilm"),
                Cost = [Pigments.Yellow, Pigments.Red],
                Visuals = Visuals.MotherlyLove,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ShieldApply, 11, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RemoveTargetTimelineAbilityEffect>(), 1, Targeting.Slot_Front, Chance0),
                ]
            };
            film3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Field_Shield)]);
            film3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Other_Exhaust)]);


            //sump
            Ability sump0 = new Ability("Dizzying Sump", "HIF_Sump_1_A")
            {
                Description = "Heal this party member 3 health.\nChange 1 stored pigment to gray.",
                AbilitySprite = ResourceLoader.LoadSprite("FarahSump"),
                Cost = [Pigments.Yellow, Pigments.Purple],
                Visuals = Visuals.WrigglingWrath,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 3, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(SumpGray, 1, Targeting.Slot_SelfSlot),
                ]
            };
            sump0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_1_4)]);
            sump0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Modify)]);

            Ability sump1 = new Ability("Cloying Sump", "HIF_Sump_2_A")
            {
                Description = "Heal this party member 4 health.\nChange 1 stored pigment to gray.",
                AbilitySprite = ResourceLoader.LoadSprite("FarahSump"),
                Cost = [Pigments.Yellow, Pigments.Purple],
                Visuals = Visuals.WrigglingWrath,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 4, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(SumpGray, 1, Targeting.Slot_SelfSlot),
                ]
            };
            sump1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_1_4)]);
            sump1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Modify)]);

            Ability sump2 = new Ability("Noxious Sump", "HIF_Sump_3_A")
            {
                Description = "Heal this party member 5 health.\nChange 1 stored pigment to gray.",
                AbilitySprite = ResourceLoader.LoadSprite("FarahSump"),
                Cost = [Pigments.Yellow, Pigments.Purple],
                Visuals = Visuals.WrigglingWrath,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 5, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(SumpGray, 1, Targeting.Slot_SelfSlot),
                ]
            };
            sump2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_5_10)]);
            sump2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Modify)]);

            Ability sump3 = new Ability("Morbid Sump", "HIF_Sump_4_A")
            {
                Description = "Heal this party member 6 health.\nChange 2 stored pigment to gray.",
                AbilitySprite = ResourceLoader.LoadSprite("FarahSump"),
                Cost = [Pigments.Yellow, Pigments.Purple],
                Visuals = Visuals.WrigglingWrath,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 6, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(SumpGray, 2, Targeting.Slot_SelfSlot),
                ]
            };
            sump3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_5_10)]);
            sump3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Modify)]);

            farah.AddLevelData(11, [bilge0, film0, sump0]);
            farah.AddLevelData(12, [bilge1, film1, sump1]);
            farah.AddLevelData(13, [bilge2, film2, sump2]);
            farah.AddLevelData(14, [bilge3, film3, sump3]);

            farah.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Farah_Witness_ACH");
            farah.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Farah_Divine_ACH");
            farah.AddCharacter(true, false);
        }
    }
}
