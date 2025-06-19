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
            Ability poke = new Ability("Evil Poke", "HIF_EvilPoke_A")
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
                HealthColor = Pigments.Blue,
                UsesBasicAbility = true,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("RodneyFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("RodneyBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("RodneyOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = "event:/RodneyDamage",
                DeathSound = "event:/RodneyDeath",
                DialogueSound = "event:/RodneyDx",
                BasicAbility = poke,
                UnitTypes =
                [
                    "Sandwich_NULL",
                ],
            };
            rodney.GenerateMenuCharacter(ResourceLoader.LoadSprite("RodneyMenu"), ResourceLoader.LoadSprite("RodneyLocked"));
            rodney.AddPassives([Passives.GetCustomPassive("Sacrilege_PA")]);
            rodney.SetMenuCharacterAsFullSupport();

            StatusEffectCheckerEffect CursedCheck = ScriptableObject.CreateInstance<StatusEffectCheckerEffect>();
            CursedCheck._status = StatusField.Cursed;

            RemoveStatusEffectEffect CursedRemove = ScriptableObject.CreateInstance<RemoveStatusEffectEffect>();
            CursedRemove._status = StatusField.Cursed;

            RefreshAbilityUsageByStatusEffectEffect RotationRefresh0 = ScriptableObject.CreateInstance<RefreshAbilityUsageByStatusEffectEffect>();
            RotationRefresh0._chance = 40;
            RotationRefresh0._status = StatusField.Cursed;

            RefreshAbilityUsageByStatusEffectEffect RotationRefresh1 = ScriptableObject.CreateInstance<RefreshAbilityUsageByStatusEffectEffect>();
            RotationRefresh1._chance = 50;
            RotationRefresh1._status = StatusField.Cursed;

            RefreshAbilityUsageByStatusEffectEffect RotationRefresh2 = ScriptableObject.CreateInstance<RefreshAbilityUsageByStatusEffectEffect>();
            RotationRefresh2._chance = 60;
            RotationRefresh2._status = StatusField.Cursed;

            RefreshAbilityUsageByStatusEffectEffect RotationRefresh3 = ScriptableObject.CreateInstance<RefreshAbilityUsageByStatusEffectEffect>();
            RotationRefresh3._chance = 70;
            RotationRefresh3._status = StatusField.Cursed;

            RestoreSwapUseByStatusEffectEffect RotationRestore = ScriptableObject.CreateInstance<RestoreSwapUseByStatusEffectEffect>();
            RotationRestore._chance = 100;
            RotationRestore._status = StatusField.Cursed;

            StatusEffect_ApplyToOneWithout_Effect CursedApplyAlt = ScriptableObject.CreateInstance<StatusEffect_ApplyToOneWithout_Effect>();
            CursedApplyAlt._Status = StatusField.Cursed;

            //veneration
            Ability veneration0 = new Ability("Distant Veneration", "HIF_Veneration_1_A")
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
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RestoreSwapUseEffect>(), 1, Targeting.Slot_AllyRight, Effects.CheckPreviousEffectCondition(true, 2)),
                ]
            };
            veneration0.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Heal_1_4)]);
            veneration0.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability veneration1 = new Ability("Guiding Veneration", "HIF_Veneration_2_A")
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
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RestoreSwapUseEffect>(), 1, Targeting.Slot_AllyRight, Effects.CheckPreviousEffectCondition(true, 2)),
                ]
            };
            veneration1.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Heal_1_4)]);
            veneration1.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability veneration2 = new Ability("Pointing Veneration", "HIF_Veneration_3_A")
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
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RestoreSwapUseEffect>(), 1, Targeting.Slot_AllyRight, Effects.CheckPreviousEffectCondition(true, 2)),
                ]
            };
            veneration2.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Heal_1_4)]);
            veneration2.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability veneration3 = new Ability("Feeling Veneration", "HIF_Veneration_4_A")
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
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RestoreSwapUseEffect>(), 1, Targeting.Slot_AllyRight, Effects.CheckPreviousEffectCondition(true, 2)),
                ]
            };
            veneration3.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Heal_5_10)]);
            veneration3.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Other_Refresh)]);


            //tribulation
            Ability tribulation0 = new Ability("Little Tribulation", "HIF_Tribulation_1_A")
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

            Ability tribulation1 = new Ability("Ring Tribulation", "HIF_Tribulation_2_A")
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

            Ability tribulation2 = new Ability("Middle Tribulation", "HIF_Tribulation_3_A")
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

            Ability tribulation3 = new Ability("Index Tribulation", "HIF_Tribulation_4_A")
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
            Ability rotation0 = new Ability("Sick Rotation", "HIF_Rotation_1_A")
            {
                Description = "Inflict Curse to a random ally.\n40% chance to refresh each Cursed party member's ability use.\nRestore each Cursed party member's movement.",
                AbilitySprite = ResourceLoader.LoadSprite("RodneyRotation"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Connection,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(CursedApplyAlt, 1, Targeting.Unit_OtherAllies),
                    Effects.GenerateEffect(RotationRefresh0, 1, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(RotationRestore, 1, Targeting.Unit_AllAllies),
                ]
            };
            rotation0.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Status_Cursed)]);
            rotation0.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability rotation1 = new Ability("Blight Rotation", "HIF_Rotation_2_A")
            {
                Description = "Inflict Curse to a random ally.\n50% chance to refresh each Cursed party member's ability use.\nRestore each Cursed party member's movement.",
                AbilitySprite = ResourceLoader.LoadSprite("RodneyRotation"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Connection,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(CursedApplyAlt, 1, Targeting.Unit_OtherAllies),
                    Effects.GenerateEffect(RotationRefresh1, 1, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(RotationRestore, 1, Targeting.Unit_AllAllies),
                ]
            };
            rotation1.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Status_Cursed)]);
            rotation1.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability rotation2 = new Ability("Dead Rotation", "HIF_Rotation_3_A")
            {
                Description = "Inflict Curse to a random ally.\n60% chance to refresh each Cursed party member's ability use.\nRestore each Cursed party member's movement.",
                AbilitySprite = ResourceLoader.LoadSprite("RodneyRotation"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Connection,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(CursedApplyAlt, 1, Targeting.Unit_OtherAllies),
                    Effects.GenerateEffect(RotationRefresh2, 1, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(RotationRestore, 1, Targeting.Unit_AllAllies),
                ]
            };
            rotation2.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Status_Cursed)]);
            rotation2.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability rotation3 = new Ability("Skeletal Rotation", "HIF_Rotation_4_A")
            {
                Description = "Inflict Curse to a random ally.\n70% chance to refresh each Cursed party member's ability use.\nRestore each Cursed party member's movement.",
                AbilitySprite = ResourceLoader.LoadSprite("RodneyRotation"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Connection,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(CursedApplyAlt, 1, Targeting.Unit_OtherAllies),
                    Effects.GenerateEffect(RotationRefresh3, 1, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(RotationRestore, 1, Targeting.Unit_AllAllies),
                ]
            };
            rotation3.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Status_Cursed)]);
            rotation3.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Other_Refresh)]);


            rodney.AddLevelData(30, [rotation0, veneration0, tribulation0]);
            rodney.AddLevelData(35, [rotation1, veneration1, tribulation1]);
            rodney.AddLevelData(40, [rotation2, veneration2, tribulation2]);
            rodney.AddLevelData(45, [rotation3, veneration3, tribulation3]);

            rodney.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Rodney_Witness_ACH");
            rodney.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Rodney_Divine_ACH");
            rodney.AddCharacter(true, false);
        }
    }
}
