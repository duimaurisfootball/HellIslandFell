using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Fools
{
    public class Exambry
    {
        public static void Add()
        {
            Character exambry = new Character("Exambry", "Exambry_CH")
            {
                HealthColor = Pigments.Red,
                UsesBasicAbility = true,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("ExambryFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("ExambryBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("ExambryOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("MiniMordrake_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("MiniMordrake_CH").deathSound,
                DialogueSound = LoadedAssetsHandler.GetCharacter("Mordrake_CH").dxSound,
                IgnoredAbilitiesForDPSBuilds = [2],
                IgnoredAbilitiesForSupportBuilds = [0],
                UnitTypes =
                [
                    "HellishID",
                    "FemaleID",
                ],
            };
            exambry.GenerateMenuCharacter(ResourceLoader.LoadSprite("ExambryMenu"), ResourceLoader.LoadSprite("ExambryLocked"));
            exambry.AddPassives([Passives.GetCustomPassive("Interpolated_PA")]);

            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Disappearing_ID", out StatusEffect_SO Disappearing);
            StatusEffect_Apply_Effect DisappearingApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            DisappearingApply._Status = Disappearing;

            FieldEffect_Apply_Effect ShieldApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ShieldApply._Field = StatusField.Shield;

            StatusEffect_Apply_Effect FrailApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            FrailApply._Status = StatusField.Frail;

            RemoveAmountStatusEffectEffect DisappearingRemove = ScriptableObject.CreateInstance<RemoveAmountStatusEffectEffect>();
            DisappearingRemove.entryAsPercentage = true;
            DisappearingRemove.statusId = "Disappearing_ID";

            DamageEffect PreviousDamage0 = ScriptableObject.CreateInstance<DamageEffect>();
            PreviousDamage0._usePreviousExitValue = true;

            DamageFromBasePlusPreviousEffect PreviousDamage1 = ScriptableObject.CreateInstance<DamageFromBasePlusPreviousEffect>();
            PreviousDamage1._baseDamage = 3;

            DamageFromBasePlusPreviousEffect PreviousDamage2 = ScriptableObject.CreateInstance<DamageFromBasePlusPreviousEffect>();
            PreviousDamage2._baseDamage = 6;

            DamageFromBasePlusPreviousEffect PreviousDamage3 = ScriptableObject.CreateInstance<DamageFromBasePlusPreviousEffect>();
            PreviousDamage3._baseDamage = 8;

            //melter
            Ability melter0 = new Ability("Hand Melter", "Melter_1_A")
            {
                Description = "Apply 18 Disappearing to the Opposing enemy.\nApply 1 Shield to this position.\nApply 2 Frail to this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("ExambryMelter"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Melt,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(DisappearingApply, 18, Targeting.Slot_Front),
                    Effects.GenerateEffect(ShieldApply, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(FrailApply, 2, Targeting.Slot_SelfSlot),
                ],
            };
            melter0.AddIntentsToTarget(Targeting.Slot_Front, ["Status_Disappearing"]);
            melter0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Field_Shield)]);

            Ability melter1 = new Ability("Heart Melter", "Melter_2_A")
            {
                Description = "Apply 22 Disappearing to the Opposing enemy.\nApply 2 Shield to this position.\nApply 2 Frail to this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("ExambryMelter"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Melt,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(DisappearingApply, 22, Targeting.Slot_Front),
                    Effects.GenerateEffect(ShieldApply, 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(FrailApply, 2, Targeting.Slot_SelfSlot),
                ],
            };
            melter1.AddIntentsToTarget(Targeting.Slot_Front, ["Status_Disappearing"]);
            melter1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Field_Shield)]);

            Ability melter2 = new Ability("Mind Melter", "Melter_3_A")
            {
                Description = "Apply 26 Disappearing to the Opposing enemy.\nApply 2 Shield to this position.\nApply 2 Frail to this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("ExambryMelter"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Melt,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(DisappearingApply, 26, Targeting.Slot_Front),
                    Effects.GenerateEffect(ShieldApply, 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(FrailApply, 2, Targeting.Slot_SelfSlot),
                ],
            };
            melter2.AddIntentsToTarget(Targeting.Slot_Front, ["Status_Disappearing"]);
            melter2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Field_Shield)]);

            Ability melter3 = new Ability("Life Melter", "Melter_4_A")
            {
                Description = "Apply 30 Disappearing to the Opposing enemy.\nApply 3 Shield to this position.\nApply 2 Frail to this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("ExambryMelter"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Melt,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(DisappearingApply, 30, Targeting.Slot_Front),
                    Effects.GenerateEffect(ShieldApply, 3, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(FrailApply, 2, Targeting.Slot_SelfSlot),
                ],
            };
            melter3.AddIntentsToTarget(Targeting.Slot_Front, ["Status_Disappearing"]);
            melter3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Field_Shield)]);


            //resolution
            Ability resolution0 = new Ability("Minimum Resolution", "Resolution_1_A")
            {
                Description = "Remove 1/2 of Disappearing from this party member.\nDeal an equivalent amount of damage to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("ExambryResolution"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Yellow],
                Visuals = Visuals.Slash,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(DisappearingRemove, 50, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(PreviousDamage0, 1, Targeting.Slot_Front),
                ],
            };
            resolution0.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Rem_Status_Disappearing"]);
            resolution0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_1_2)]);

            Ability resolution1 = new Ability("Average Resolution", "Resolution_2_A")
            {
                Description = "Remove 1/2 of Disappearing from this party member.\nDeal an equivalent amount of damage + 3 to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("ExambryResolution"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Yellow],
                Visuals = Visuals.Slash,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(DisappearingRemove, 50, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(PreviousDamage1, 1, Targeting.Slot_Front),
                ],
            };
            resolution1.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Rem_Status_Disappearing"]);
            resolution1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);

            Ability resolution2 = new Ability("Superb Resolution", "Resolution_3_A")
            {
                Description = "Remove 1/2 of Disappearing from this party member.\nDeal an equivalent amount of damage + 6 to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("ExambryResolution"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Yellow],
                Visuals = Visuals.Slash,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(DisappearingRemove, 50, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(PreviousDamage2, 1, Targeting.Slot_Front),
                ],
            };
            resolution2.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Rem_Status_Disappearing"]);
            resolution2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);

            Ability resolution3 = new Ability("Immaculate Resolution", "Resolution_4_A")
            {
                Description = "Remove 1/2 of Disappearing from this party member.\nDeal an equivalent amount of damage + 8 to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("ExambryResolution"),
                Cost = [Pigments.Red, Pigments.Red, Pigments.Yellow],
                Visuals = Visuals.Slash,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(DisappearingRemove, 50, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(PreviousDamage3, 1, Targeting.Slot_Front),
                ],
            };
            resolution3.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Rem_Status_Disappearing"]);
            resolution3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);


            //material
            Ability material0 = new Ability("Dusty Material", "Material_1_A")
            {
                Description = "Heal the Left and Far Left allies 4 health.\nApply 2 Disappearing to the Left and Far Left allies.\nHeal this party member 2 health.",
                AbilitySprite = ResourceLoader.LoadSprite("ExambryMaterial"),
                Cost = [Pigments.Red, Pigments.Red],
                Visuals = Visuals.Pyre,
                AnimationTarget = Targeting.GenerateSlotTarget([-1, -2], true),
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 4, Targeting.GenerateSlotTarget([-1, -2], true)),
                    Effects.GenerateEffect(DisappearingApply, 2, Targeting.GenerateSlotTarget([-1, -2], true)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 2, Targeting.Slot_SelfSlot),
                ],
            };
            material0.AddIntentsToTarget(Targeting.GenerateSlotTarget([-1, -2], true), [nameof(IntentType_GameIDs.Heal_1_4)]);
            material0.AddIntentsToTarget(Targeting.GenerateSlotTarget([-1, -2], true), ["Status_Disappearing"]);
            material0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_1_4)]);
            Ability material1 = new Ability("Dusty Material", "Material_2_A")
            {
                Description = "Heal the Left and Far Left allies 6 health.\nApply 2 Disappearing to the Left and Far Left allies.\nHeal this party member 2 health.",
                AbilitySprite = ResourceLoader.LoadSprite("ExambryMaterial"),
                Cost = [Pigments.Red, Pigments.Red],
                Visuals = Visuals.Pyre,
                AnimationTarget = Targeting.GenerateSlotTarget([-1, -2], true),
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 6, Targeting.GenerateSlotTarget([-1, -2], true)),
                    Effects.GenerateEffect(DisappearingApply, 2, Targeting.GenerateSlotTarget([-1, -2], true)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 2, Targeting.Slot_SelfSlot),
                ],
            };
            material1.AddIntentsToTarget(Targeting.GenerateSlotTarget([-1, -2], true), [nameof(IntentType_GameIDs.Heal_5_10)]);
            material1.AddIntentsToTarget(Targeting.GenerateSlotTarget([-1, -2], true), ["Status_Disappearing"]);
            material1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_1_4)]);

            Ability material2 = new Ability("Bony Material", "Material_3_A")
            {
                Description = "Heal the Left and Far Left allies 8 health.\nApply 3 Disappearing to the Left and Far Left allies.\nHeal this party member 3 health.",
                AbilitySprite = ResourceLoader.LoadSprite("ExambryMaterial"),
                Cost = [Pigments.Red, Pigments.Red],
                Visuals = Visuals.Pyre,
                AnimationTarget = Targeting.GenerateSlotTarget([-1, -2], true),
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 8, Targeting.GenerateSlotTarget([-1, -2], true)),
                    Effects.GenerateEffect(DisappearingApply, 3, Targeting.GenerateSlotTarget([-1, -2], true)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 3, Targeting.Slot_SelfSlot),
                ],
            };
            material2.AddIntentsToTarget(Targeting.GenerateSlotTarget([-1, -2], true), [nameof(IntentType_GameIDs.Heal_5_10)]);
            material2.AddIntentsToTarget(Targeting.GenerateSlotTarget([-1, -2], true), ["Status_Disappearing"]);
            material2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_1_4)]);

            Ability material3 = new Ability("Fleshy Material", "Material_4_A")
            {
                Description = "Heal the Left and Far Left allies 10 health.\nApply 3 Disappearing to the Left and Far Left allies.\nHeal this party member 3 health.",
                AbilitySprite = ResourceLoader.LoadSprite("ExambryMaterial"),
                Cost = [Pigments.Red, Pigments.Red],
                Visuals = Visuals.Pyre,
                AnimationTarget = Targeting.GenerateSlotTarget([-1, -2], true),
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 10, Targeting.GenerateSlotTarget([-1, -2], true)),
                    Effects.GenerateEffect(DisappearingApply, 3, Targeting.GenerateSlotTarget([-1, -2], true)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 3, Targeting.Slot_SelfSlot),
                ],
            };
            material3.AddIntentsToTarget(Targeting.GenerateSlotTarget([-1, -2], true), [nameof(IntentType_GameIDs.Heal_5_10)]);
            material3.AddIntentsToTarget(Targeting.GenerateSlotTarget([-1, -2], true), ["Status_Disappearing"]);
            material3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_1_4)]);

            exambry.AddLevelData(22, new Ability[] { melter0, resolution0, material0 });
            exambry.AddLevelData(23, new Ability[] { melter1, resolution1, material1 });
            exambry.AddLevelData(25, new Ability[] { melter2, resolution2, material2 });
            exambry.AddLevelData(28, new Ability[] { melter3, resolution3, material3 });

            exambry.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Exambry_Witness_ACH");
            exambry.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Exambry_Divine_ACH");
            exambry.AddCharacter(true, false);
        }
    }
}
