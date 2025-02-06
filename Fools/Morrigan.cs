using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Fools
{
    public class Morrigan
    {
        public static void Add()
        {
            Character morrigan = new Character("Morrigan", "Morrigan_CH")
            {
                HealthColor = Pigments.Grey,
                UsesBasicAbility = true,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("MorriganFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("MorriganBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("MorriganOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("SilverSuckle_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("SilverSuckle_EN").deathSound,
                DialogueSound = LoadedAssetsHandler.GetEnemy("SilverSuckle_EN").damageSound,
            };
            morrigan.GenerateMenuCharacter(ResourceLoader.LoadSprite("MorriganMenu"), ResourceLoader.LoadSprite("MorriganLocked"));
            morrigan.AddPassives([Passives.Withering, Passives.Immortal]);
            morrigan.SetMenuCharacterAsFullSupport();

            CopyAndSpawnCustomCharacterAnywhereAltEffect MudballSpawn = ScriptableObject.CreateInstance<CopyAndSpawnCustomCharacterAnywhereAltEffect>();
            MudballSpawn._characterCopy = "Mudball_CH";
            MudballSpawn._rank = 0;
            MudballSpawn._nameAddition = NameAdditionLocID.NameAdditionNone;
            MudballSpawn._permanentSpawn = false;
            MudballSpawn._extraModifiers = [];

            StatusEffect_Apply_Effect DivineProtectionApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            DivineProtectionApply._Status = StatusField.DivineProtection;

            //mud
            Ability mud0 = new Ability("Spatters of Mud", "Mud_1_A")
            {
                Description = "Apply 3 Divine Protection to the Right ally.\nSpawn a Mudball with 5-15 health.",
                AbilitySprite = ResourceLoader.LoadSprite("MorriganMud"),
                Cost = [Pigments.Blue, Pigments.Blue, Pigments.Yellow],
                Visuals = Visuals.Chomp,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(DivineProtectionApply, 3, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 5),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RandomBetweenPreviousForNextEffect>(), 15),
                    Effects.GenerateEffect(MudballSpawn, 1),
                ]
            };
            mud0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            mud0.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Status_DivineProtection)]);

            Ability mud1 = new Ability("Mud Puddle", "Mud_2_A")
            {
                Description = "Apply 3 Divine Protection to the Right ally.\nSpawn a Mudball with 6-18 health.",
                AbilitySprite = ResourceLoader.LoadSprite("MorriganMud"),
                Cost = [Pigments.Blue, Pigments.Blue, Pigments.Yellow],
                Visuals = Visuals.Chomp,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(DivineProtectionApply, 3, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 6),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RandomBetweenPreviousForNextEffect>(), 18),
                    Effects.GenerateEffect(MudballSpawn, 1),
                ]
            };
            mud1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            mud1.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Status_DivineProtection)]);

            Ability mud2 = new Ability("Smothered by Mud", "Mud_3_A")
            {
                Description = "Apply 3 Divine Protection to the Right ally.\nSpawn a Mudball with 7-21 health.",
                AbilitySprite = ResourceLoader.LoadSprite("MorriganMud"),
                Cost = [Pigments.Blue, Pigments.Blue, Pigments.Yellow],
                Visuals = Visuals.Chomp,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(DivineProtectionApply, 3, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 7),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RandomBetweenPreviousForNextEffect>(), 21),
                    Effects.GenerateEffect(MudballSpawn, 1),
                ]
            };
            mud2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            mud2.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Status_DivineProtection)]);

            Ability mud3 = new Ability("Caked in Mud", "Mud_4_A")
            {
                Description = "Apply 3 Divine Protection to the Right ally.\nSpawn a Mudball with 8-24 health.",
                AbilitySprite = ResourceLoader.LoadSprite("MorriganMud"),
                Cost = [Pigments.Blue, Pigments.Blue, Pigments.Yellow],
                Visuals = Visuals.Chomp,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(DivineProtectionApply, 3, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 8),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RandomBetweenPreviousForNextEffect>(), 24),
                    Effects.GenerateEffect(MudballSpawn, 1),
                ]
            };
            mud3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            mud3.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Status_DivineProtection)]);

            //glass
            Ability glass0 = new Ability("Volcanic Glass", "Glass_1_A")
            {
                Description = "Apply 2 Divine Protection to the Left and Right allies.\nHeal the Left and Right allies 2 health.",
                AbilitySprite = ResourceLoader.LoadSprite("MorriganGlass"),
                Cost = [Pigments.Blue, Pigments.Blue, Pigments.Red],
                Visuals = Visuals.Decimate,
                AnimationTarget = Targeting.Slot_AllySides,
                Effects =
                [
                    Effects.GenerateEffect(DivineProtectionApply, 2, Targeting.Slot_AllySides),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 2, Targeting.Slot_AllySides),
                ]
            };
            glass0.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Status_DivineProtection)]);
            glass0.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Heal_1_4)]);

            Ability glass1 = new Ability("Stained Glass", "Glass_2_A")
            {
                Description = "Apply 2 Divine Protection to the Left and Right allies.\nHeal the Left and Right allies 4 health.",
                AbilitySprite = ResourceLoader.LoadSprite("MorriganGlass"),
                Cost = [Pigments.Blue, Pigments.Blue, Pigments.Red],
                Visuals = Visuals.Decimate,
                AnimationTarget = Targeting.Slot_AllySides,
                Effects =
                [
                    Effects.GenerateEffect(DivineProtectionApply, 2, Targeting.Slot_AllySides),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 4, Targeting.Slot_AllySides),
                ]
            };
            glass1.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Status_DivineProtection)]);
            glass1.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Heal_1_4)]);

            Ability glass2 = new Ability("Fibre Glass", "Glass_3_A")
            {
                Description = "Apply 2 Divine Protection to the Left and Right allies.\nHeal the Left and Right allies 6 health.",
                AbilitySprite = ResourceLoader.LoadSprite("MorriganGlass"),
                Cost = [Pigments.Blue, Pigments.Blue, Pigments.Red],
                Visuals = Visuals.Decimate,
                AnimationTarget = Targeting.Slot_AllySides,
                Effects =
                [
                    Effects.GenerateEffect(DivineProtectionApply, 2, Targeting.Slot_AllySides),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 6, Targeting.Slot_AllySides),
                ]
            };
            glass2.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Status_DivineProtection)]);
            glass2.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Heal_5_10)]);

            Ability glass3 = new Ability("Trinity Glass", "Glass_4_A")
            {
                Description = "Apply 2 Divine Protection to the Left and Right allies.\nHeal the Left and Right allies 7 health.",
                AbilitySprite = ResourceLoader.LoadSprite("MorriganGlass"),
                Cost = [Pigments.Blue, Pigments.Blue, Pigments.Red],
                Visuals = Visuals.Decimate,
                AnimationTarget = Targeting.Slot_AllySides,
                Effects =
                [
                    Effects.GenerateEffect(DivineProtectionApply, 2, Targeting.Slot_AllySides),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 7, Targeting.Slot_AllySides),
                ]
            };
            glass3.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Status_DivineProtection)]);
            glass3.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Heal_5_10)]);

            //pearls
            Ability pearls0 = new Ability("Marrow Pearls", "Pearls_1_A")
            {
                Description = "Spawn as many Mudballs with 7 health as possible.\nHeal all party members 1 health.",
                AbilitySprite = ResourceLoader.LoadSprite("MorriganPearls"),
                Cost = [Pigments.Blue, Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.UglyOnTheInside,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 7),
                    Effects.GenerateEffect(MudballSpawn, 4),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 1, Targeting.Unit_AllAllies),
                ]
            };
            pearls0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            pearls0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            pearls0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            pearls0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            pearls0.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Heal_1_4)]);

            Ability pearls1 = new Ability("Living Pearls", "Pearls_2_A")
            {
                Description = "Spawn as many Mudballs with 8 health as possible.\nHeal all party members 1 health.",
                AbilitySprite = ResourceLoader.LoadSprite("MorriganPearls"),
                Cost = [Pigments.Blue, Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.UglyOnTheInside,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 8),
                    Effects.GenerateEffect(MudballSpawn, 4),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 1, Targeting.Unit_AllAllies),
                ]
            };
            pearls1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            pearls1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            pearls1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            pearls1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            pearls1.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Heal_1_4)]);

            Ability pearls2 = new Ability("Parasitic Pearls", "Pearls_3_A")
            {
                Description = "Spawn as many Mudballs with 9 health as possible.\nHeal all party members 2 health.",
                AbilitySprite = ResourceLoader.LoadSprite("MorriganPearls"),
                Cost = [Pigments.Blue, Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.UglyOnTheInside,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 9),
                    Effects.GenerateEffect(MudballSpawn, 4),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 2, Targeting.Unit_AllAllies),
                ]
            };
            pearls2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            pearls2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            pearls2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            pearls2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            pearls2.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Heal_1_4)]);

            Ability pearls3 = new Ability("Opulent Pearls", "Pearls_4_A")
            {
                Description = "Spawn as many Mudballs with 10 health as possible.\nHeal all party members 2 health.",
                AbilitySprite = ResourceLoader.LoadSprite("MorriganPearls"),
                Cost = [Pigments.Blue, Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.UglyOnTheInside,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 10),
                    Effects.GenerateEffect(MudballSpawn, 4),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 2, Targeting.Unit_AllAllies),
                ]
            };
            pearls3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            pearls3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            pearls3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            pearls3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            pearls3.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Heal_1_4)]);

            morrigan.AddLevelData(20, new Ability[] { mud0, glass0, pearls0 });
            morrigan.AddLevelData(20, new Ability[] { mud1, glass1, pearls1 });
            morrigan.AddLevelData(20, new Ability[] { mud2, glass2, pearls2 });
            morrigan.AddLevelData(20, new Ability[] { mud3, glass3, pearls3 });

            morrigan.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Morrigan_Witness_ACH");
            morrigan.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Morrigan_Divine_ACH");
            morrigan.AddCharacter(true, false);
        }
    }
}
