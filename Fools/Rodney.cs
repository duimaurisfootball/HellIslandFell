using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Status_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Fools
{
    public class Rodney
    {
        public static void Add()
        {
            DamageEffect SlapDamage = ScriptableObject.CreateInstance<DamageEffect>();
            SlapDamage._DeathTypeID = DeathType_GameIDs.Slap.ToString();

            StatusEffect_Apply_Effect CursedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            CursedApply._Status = StatusField.Cursed;

            //evil poke
            Ability poke = new Ability("Evil Poke", "EvilPoke_A")
            {
                Description = "Deal 1 damage to the opposing enemy.\nInflict Cursed to the opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("RodneyPoke"),
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Slap,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(SlapDamage, 1, Targeting.Slot_Front),
                    Effects.GenerateEffect(CursedApply, 1, Targeting.Slot_Front),
                ]
            };
            poke.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_1_2)]);
            poke.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Cursed)]);

            Character rodney = new Character("Rodney", "Rodney_CH")
            {
                HealthColor = Pigments.Purple,
                UsesBasicAbility = true,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("RodneyFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("RodneyBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("RodneyOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("Clive_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("Clive_CH").deathSound,
                DialogueSound = LoadedAssetsHandler.GetCharacter("Clive_CH").dxSound,
                BasicAbility = poke
            };
            rodney.GenerateMenuCharacter(ResourceLoader.LoadSprite("RodneyMenu"), ResourceLoader.LoadSprite("RodneyLocked"));
            rodney.AddPassives([Passives.GetCustomPassive("Sacrilege_PA")]);
            rodney.SetMenuCharacterAsFullSupport();

            StatusEffectCheckerEffect CursedCheck = ScriptableObject.CreateInstance<StatusEffectCheckerEffect>();
            CursedCheck._status = StatusField.Cursed;

            RemoveStatusEffectEffect CursedRemove = ScriptableObject.CreateInstance<RemoveStatusEffectEffect>();
            CursedRemove._status = StatusField.Cursed;

            PreviousEffectCondition Fail = ScriptableObject.CreateInstance<PreviousEffectCondition>();
            Fail.wasSuccessful = false;
            Fail.previousAmount = 2;

            PreviousEffectCondition RestoreCondition = ScriptableObject.CreateInstance<PreviousEffectCondition>();
            RestoreCondition.previousAmount = 2;

            RefreshAbilityUsageByStatusEffectEffect RotationRefresh0 = ScriptableObject.CreateInstance<RefreshAbilityUsageByStatusEffectEffect>();
            RotationRefresh0._chance = 20;
            RotationRefresh0._status = StatusField.Cursed;

            RefreshAbilityUsageByStatusEffectEffect RotationRefresh1 = ScriptableObject.CreateInstance<RefreshAbilityUsageByStatusEffectEffect>();
            RotationRefresh1._chance = 30;
            RotationRefresh1._status = StatusField.Cursed;

            RefreshAbilityUsageByStatusEffectEffect RotationRefresh2 = ScriptableObject.CreateInstance<RefreshAbilityUsageByStatusEffectEffect>();
            RotationRefresh2._chance = 40;
            RotationRefresh2._status = StatusField.Cursed;

            RefreshAbilityUsageByStatusEffectEffect RotationRefresh3 = ScriptableObject.CreateInstance<RefreshAbilityUsageByStatusEffectEffect>();
            RotationRefresh3._chance = 50;
            RotationRefresh3._status = StatusField.Cursed;

            RestoreSwapUseByStatusEffectEffect RotationRestore0 = ScriptableObject.CreateInstance<RestoreSwapUseByStatusEffectEffect>();
            RotationRestore0._chance = 50;
            RotationRestore0._status = StatusField.Cursed;

            RestoreSwapUseByStatusEffectEffect RotationRestore1 = ScriptableObject.CreateInstance<RestoreSwapUseByStatusEffectEffect>();
            RotationRestore1._chance = 60;
            RotationRestore1._status = StatusField.Cursed;

            RestoreSwapUseByStatusEffectEffect RotationRestore2 = ScriptableObject.CreateInstance<RestoreSwapUseByStatusEffectEffect>();
            RotationRestore2._chance = 70;
            RotationRestore2._status = StatusField.Cursed;

            RestoreSwapUseByStatusEffectEffect RotationRestore3 = ScriptableObject.CreateInstance<RestoreSwapUseByStatusEffectEffect>();
            RotationRestore3._chance = 80;
            RotationRestore3._status = StatusField.Cursed;

            StatusEffect_Apply_Effect CursedApplyAlt = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            CursedApplyAlt._Status = StatusField.Cursed;
            CursedApplyAlt._JustOneRandomTarget = true;

            //veneration
            Ability veneration0 = new Ability("Distant Veneration", "Veneration_1_A")
            {
                Description = "Heal the Right ally 2 health.\nIf the Right ally is Cursed, refresh them and restore their movement.",
                AbilitySprite = ResourceLoader.LoadSprite("RodneyVeneration"),
                Cost = [Pigments.Red, Pigments.Red],
                Visuals = Visuals.FingerGuns,
                AnimationTarget = Targeting.Slot_AllyRight,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 2, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(CursedCheck, 1, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 1, Targeting.Slot_AllyRight, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RestoreSwapUseEffect>(), 1, Targeting.Slot_AllyRight, RestoreCondition),
                ]
            };
            veneration0.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Heal_1_4)]);
            veneration0.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability veneration1 = new Ability("Guiding Veneration", "Veneration_2_A")
            {
                Description = "Heal the Right ally 3 health.\nIf the Right ally is Cursed, refresh them and restore their movement.",
                AbilitySprite = ResourceLoader.LoadSprite("RodneyVeneration"),
                Cost = [Pigments.Red, Pigments.Red],
                Visuals = Visuals.FingerGuns,
                AnimationTarget = Targeting.Slot_AllyRight,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 3, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(CursedCheck, 1, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 1, Targeting.Slot_AllyRight, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RestoreSwapUseEffect>(), 1, Targeting.Slot_AllyRight, RestoreCondition),
                ]
            };
            veneration1.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Heal_1_4)]);
            veneration1.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability veneration2 = new Ability("Pointing Veneration", "Veneration_3_A")
            {
                Description = "Heal the Right ally 4 health.\nIf the Right ally is Cursed, refresh them and restore their movement.",
                AbilitySprite = ResourceLoader.LoadSprite("RodneyVeneration"),
                Cost = [Pigments.Red, Pigments.Red],
                Visuals = Visuals.FingerGuns,
                AnimationTarget = Targeting.Slot_AllyRight,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 4, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(CursedCheck, 1, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 1, Targeting.Slot_AllyRight, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RestoreSwapUseEffect>(), 1, Targeting.Slot_AllyRight, RestoreCondition),
                ]
            };
            veneration2.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Heal_1_4)]);
            veneration2.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability veneration3 = new Ability("Feeling Veneration", "Veneration_4_A")
            {
                Description = "Heal the Right ally 6 health.\nIf the Right ally is Cursed, refresh them and restore their movement.",
                AbilitySprite = ResourceLoader.LoadSprite("RodneyVeneration"),
                Cost = [Pigments.Red, Pigments.Red],
                Visuals = Visuals.FingerGuns,
                AnimationTarget = Targeting.Slot_AllyRight,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 6, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(CursedCheck, 1, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 1, Targeting.Slot_AllyRight, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RestoreSwapUseEffect>(), 1, Targeting.Slot_AllyRight, RestoreCondition),
                ]
            };
            veneration3.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Heal_5_10)]);
            veneration3.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Other_Refresh)]);


            //tribulation
            Ability tribulation0 = new Ability("Little Tribulation", "Tribulation_1_A")
            {
                Description = "Heal the Right ally 7 health.\nInflict Curse to the Right ally.",
                AbilitySprite = ResourceLoader.LoadSprite("RodneyTribulation"),
                Cost = [Pigments.Red, Pigments.Blue],
                Visuals = Visuals.Poke,
                AnimationTarget = Targeting.Slot_AllyRight,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 7, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(CursedApply, 1, Targeting.Slot_AllyRight),
                ]
            };
            tribulation0.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Heal_5_10)]);
            tribulation0.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Status_Cursed)]);

            Ability tribulation1 = new Ability("Ring Tribulation", "Tribulation_2_A")
            {
                Description = "Heal the Right ally 10 health.\nInflict Curse to the Right ally.",
                AbilitySprite = ResourceLoader.LoadSprite("RodneyTribulation"),
                Cost = [Pigments.Red, Pigments.Blue],
                Visuals = Visuals.Poke,
                AnimationTarget = Targeting.Slot_AllyRight,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 10, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(CursedApply, 1, Targeting.Slot_AllyRight),
                ]
            };
            tribulation1.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Heal_5_10)]);
            tribulation1.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Status_Cursed)]);

            Ability tribulation2 = new Ability("Middle Tribulation", "Tribulation_3_A")
            {
                Description = "Heal the Right ally 14 health.\nInflict Curse to the Right ally.",
                AbilitySprite = ResourceLoader.LoadSprite("RodneyTribulation"),
                Cost = [Pigments.Red, Pigments.Blue],
                Visuals = Visuals.Poke,
                AnimationTarget = Targeting.Slot_AllyRight,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 14, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(CursedApply, 1, Targeting.Slot_AllyRight),
                ]
            };
            tribulation2.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Heal_5_10)]);
            tribulation2.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Status_Cursed)]);

            Ability tribulation3 = new Ability("Index Tribulation", "Tribulation_4_A")
            {
                Description = "Heal the Right ally 18 health.\nInflict Curse to the Right ally.",
                AbilitySprite = ResourceLoader.LoadSprite("RodneyTribulation"),
                Cost = [Pigments.Red, Pigments.Blue],
                Visuals = Visuals.Poke,
                AnimationTarget = Targeting.Slot_AllyRight,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 18, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(CursedApply, 1, Targeting.Slot_AllyRight),
                ]
            };
            tribulation3.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Heal_5_10)]);
            tribulation3.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Status_Cursed)]);


            //rotation
            Ability rotation0 = new Ability("Sick Rotation", "Rotation_1_A")
            {
                Description = "Inflict Curse to a random ally.\n20% chance to refresh each Cursed ally's ability use.\n50% chance to restore each Cursed ally's movement.",
                AbilitySprite = ResourceLoader.LoadSprite("RodneyRotation"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Connection,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(CursedApplyAlt, 1, Targeting.Unit_OtherAllies),
                    Effects.GenerateEffect(RotationRefresh0, 1, Targeting.Unit_OtherAllies),
                    Effects.GenerateEffect(RotationRestore0, 1, Targeting.Unit_OtherAllies),
                ]
            };
            rotation0.AddIntentsToTarget(Targeting.Unit_OtherAllies, [nameof(IntentType_GameIDs.Status_Cursed)]);
            rotation0.AddIntentsToTarget(Targeting.Unit_OtherAllies, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability rotation1 = new Ability("Blight Rotation", "Rotation_2_A")
            {
                Description = "Inflict Curse to a random ally.\n30% chance to refresh each Cursed ally's ability use.\n60% chance to restore each Cursed ally's movement.",
                AbilitySprite = ResourceLoader.LoadSprite("RodneyRotation"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Connection,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(CursedApplyAlt, 1, Targeting.Unit_OtherAllies),
                    Effects.GenerateEffect(RotationRefresh1, 1, Targeting.Unit_OtherAllies),
                    Effects.GenerateEffect(RotationRestore1, 1, Targeting.Unit_OtherAllies),
                ]
            };
            rotation1.AddIntentsToTarget(Targeting.Unit_OtherAllies, [nameof(IntentType_GameIDs.Status_Cursed)]);
            rotation1.AddIntentsToTarget(Targeting.Unit_OtherAllies, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability rotation2 = new Ability("Dead Rotation", "Rotation_3_A")
            {
                Description = "Inflict Curse to a random ally.\n40% chance to refresh each Cursed ally's ability use.\n70% chance to restore each Cursed ally's movement.",
                AbilitySprite = ResourceLoader.LoadSprite("RodneyRotation"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Connection,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(CursedApplyAlt, 1, Targeting.Unit_OtherAllies),
                    Effects.GenerateEffect(RotationRefresh2, 1, Targeting.Unit_OtherAllies),
                    Effects.GenerateEffect(RotationRestore2, 1, Targeting.Unit_OtherAllies),
                ]
            };
            rotation2.AddIntentsToTarget(Targeting.Unit_OtherAllies, [nameof(IntentType_GameIDs.Status_Cursed)]);
            rotation2.AddIntentsToTarget(Targeting.Unit_OtherAllies, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability rotation3 = new Ability("Skeletal Rotation", "Rotation_4_A")
            {
                Description = "Inflict Curse to a random ally.\n50% chance to refresh each Cursed ally's ability use.\n80% chance to restore each Cursed ally's movement.",
                AbilitySprite = ResourceLoader.LoadSprite("RodneyRotation"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Connection,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(CursedApplyAlt, 1, Targeting.Unit_OtherAllies),
                    Effects.GenerateEffect(RotationRefresh3, 1, Targeting.Unit_OtherAllies),
                    Effects.GenerateEffect(RotationRestore3, 1, Targeting.Unit_OtherAllies),
                ]
            };
            rotation3.AddIntentsToTarget(Targeting.Unit_OtherAllies, [nameof(IntentType_GameIDs.Status_Cursed)]);
            rotation3.AddIntentsToTarget(Targeting.Unit_OtherAllies, [nameof(IntentType_GameIDs.Other_Refresh)]);


            rodney.AddLevelData(30, new Ability[] { veneration0, tribulation0, rotation0 });
            rodney.AddLevelData(35, new Ability[] { veneration1, tribulation1, rotation1 });
            rodney.AddLevelData(40, new Ability[] { veneration2, tribulation2, rotation2 });
            rodney.AddLevelData(45, new Ability[] { veneration3, tribulation3, rotation3 });

            rodney.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Rodney_Witness_ACH");
            rodney.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Rodney_Divine_ACH");
            rodney.AddCharacter(true, false);
        }
    }
}
