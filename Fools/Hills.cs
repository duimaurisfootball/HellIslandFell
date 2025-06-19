using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Fools
{
    public class Hills
    {
        public static void Add()
        {
            Character hills = new Character("Hills", "Hills_CH")
            {
                HealthColor = Pigments.Yellow,
                UsesBasicAbility = true,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("HillsFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("HillsBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("HillsOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("Visage_Siblings_EN").deathSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("Visage_Siblings_EN").deathSound,
                DialogueSound = LoadedAssetsHandler.GetEnemy("Visage_Siblings_EN").deathSound,
                UnitTypes =
                [
                    "Sandwich_War",
                ],
            };
            hills.GenerateMenuCharacter(ResourceLoader.LoadSprite("HillsMenu"), ResourceLoader.LoadSprite("HillsLocked"));
            hills.SetMenuCharacterAsFullDPS();

            DamageEffect IndirectDamage = ScriptableObject.CreateInstance<DamageEffect>();
            IndirectDamage._indirect = true;

            ManiaEffect maniaEffect = ScriptableObject.CreateInstance<ManiaEffect>();
            maniaEffect._repeatChance = 80;

            //mania
            Ability mania0 = new Ability("Rolling Mania", "HIF_Mania_1_A")
            {
                Description = "Deal 3 damage to the Opposing enemy.\nMove this party member to the Left or Right.\n80% chance to repeat this ability.",
                AbilitySprite = ResourceLoader.LoadSprite("HillsMania"),
                Cost = [Pigments.Yellow, Pigments.Yellow, Pigments.Red],
                Visuals = Visuals.Mitosis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(maniaEffect, 3, Targeting.Slot_Front),
                ]
            };
            mania0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            mania0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Swap_Sides)]);
            mania0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability mania1 = new Ability("Twisting Mania", "HIF_Mania_2_A")
            {
                Description = "Deal 4 damage to the Opposing enemy.\nMove this party member to the Left or Right.\n80% chance to repeat this ability.",
                AbilitySprite = ResourceLoader.LoadSprite("HillsMania"),
                Cost = [Pigments.Yellow, Pigments.Yellow, Pigments.Red],
                Visuals = Visuals.Mitosis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(maniaEffect, 4, Targeting.Slot_Front),
                ]
            };
            mania1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            mania1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Swap_Sides)]);
            mania1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability mania2 = new Ability("Spiraling Mania", "HIF_Mania_3_A")
            {
                Description = "Deal 5 damage to the Opposing enemy.\nMove this party member to the Left or Right.\n80% chance to repeat this ability.",
                AbilitySprite = ResourceLoader.LoadSprite("HillsMania"),
                Cost = [Pigments.Yellow, Pigments.Yellow, Pigments.Red],
                Visuals = Visuals.Mitosis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(maniaEffect, 5, Targeting.Slot_Front),
                ]
            };
            mania2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            mania2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Swap_Sides)]);
            mania2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability mania3 = new Ability("Endless Mania", "HIF_Mania_4_A")
            {
                Description = "Deal 6 damage to the Opposing enemy.\nMove this party member to the Left or Right.\n80% chance to repeat this ability.",
                AbilitySprite = ResourceLoader.LoadSprite("HillsMania"),
                Cost = [Pigments.Yellow, Pigments.Yellow, Pigments.Red],
                Visuals = Visuals.Mitosis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(maniaEffect, 6, Targeting.Slot_Front),
                ]
            };
            mania3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            mania3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Swap_Sides)]);
            mania3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);


            //bellow
            Ability bellow0 = new Ability("Clay Bellow", "HIF_Bellow_1_A")
            {
                Description = "Deal 2 indirect damage to the Left, Right, and Opposing enemies.\nDeal 3 damage to this party member.\nRefresh this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("HillsBellow"),
                Cost = [Pigments.Yellow, Pigments.Red],
                Visuals = Visuals.Bellow,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(IndirectDamage, 2, Targeting.Slot_FrontAndSides),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 3, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 1, Targeting.Slot_SelfSlot),
                ]
            };
            bellow0.AddIntentsToTarget(Targeting.Slot_FrontAndSides, [nameof(IntentType_GameIDs.Damage_1_2)]);
            bellow0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Damage_3_6)]);
            bellow0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability bellow1 = new Ability("Painted Bellow", "HIF_Bellow_2_A")
            {
                Description = "Deal 4 indirect damage to the Left, Right, and Opposing enemies.\nDeal 3 damage to this party member.\nRefresh this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("HillsBellow"),
                Cost = [Pigments.Yellow, Pigments.Red],
                Visuals = Visuals.Bellow,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(IndirectDamage, 4, Targeting.Slot_FrontAndSides),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 3, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 1, Targeting.Slot_SelfSlot),
                ]
            };
            bellow1.AddIntentsToTarget(Targeting.Slot_FrontAndSides, [nameof(IntentType_GameIDs.Damage_3_6)]);
            bellow1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Damage_3_6)]);
            bellow1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability bellow2 = new Ability("Ancient Bellow", "HIF_Bellow_3_A")
            {
                Description = "Deal 5 indirect damage to the Left, Right, and Opposing enemies.\nDeal 3 damage to this party member.\nRefresh this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("HillsBellow"),
                Cost = [Pigments.Yellow, Pigments.Red],
                Visuals = Visuals.Bellow,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(IndirectDamage, 5, Targeting.Slot_FrontAndSides),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 3, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 1, Targeting.Slot_SelfSlot),
                ]
            };
            bellow2.AddIntentsToTarget(Targeting.Slot_FrontAndSides, [nameof(IntentType_GameIDs.Damage_3_6)]);
            bellow2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Damage_3_6)]);
            bellow2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability bellow3 = new Ability("Cursed Bellow", "HIF_Bellow_4_A")
            {
                Description = "Deal 6 indirect damage to the Left, Right, and Opposing enemies.\nDeal 3 damage to this party member.\nRefresh this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("HillsBellow"),
                Cost = [Pigments.Yellow, Pigments.Red],
                Visuals = Visuals.Bellow,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(IndirectDamage, 6, Targeting.Slot_FrontAndSides),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 3, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 1, Targeting.Slot_SelfSlot),
                ]
            };
            bellow3.AddIntentsToTarget(Targeting.Slot_FrontAndSides, [nameof(IntentType_GameIDs.Damage_3_6)]);
            bellow3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Damage_3_6)]);
            bellow3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Refresh)]);


            //a shatter
            Ability shatter0 = new Ability("A Stupid Shatter", "HIF_AShatter_1_A")
            {
                Description = "Deal 1-10 damage to the Opposing enemy.\nIf this attack hits shield, repeat it.",
                AbilitySprite = ResourceLoader.LoadSprite("HillsShatter"),
                Cost = [Pigments.Yellow, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Crush,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HillsShatterEffect>(), 10, Targeting.Slot_Front),
                ]
            };
            shatter0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);
            shatter0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability shatter1 = new Ability("A Loud Shatter", "HIF_AShatter_2_A")
            {
                Description = "Deal 3-12 damage to the Opposing enemy.\nIf this attack hits shield, repeat it.",
                AbilitySprite = ResourceLoader.LoadSprite("HillsShatter"),
                Cost = [Pigments.Yellow, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Crush,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 3, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HillsShatterEffect>(), 12, Targeting.Slot_Front),
                ]
            };
            shatter1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_11_15)]);
            shatter1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            Ability shatter2 = new Ability("A Resounding Shatter", "HIF_AShatter_3_A")
            {
                Description = "Deal 5-14 damage to the Opposing enemy.\nIf this attack hits shield, repeat it.",
                AbilitySprite = ResourceLoader.LoadSprite("HillsShatter"),
                Cost = [Pigments.Yellow, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Crush,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 5, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HillsShatterEffect>(), 14, Targeting.Slot_Front),
                ]
            };
            shatter2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_11_15)]);
            shatter2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);
            
            Ability shatter3 = new Ability("A Thunderous Shatter", "HIF_AShatter_4_A")
            {
                Description = "Deal 7-16 damage to the Opposing enemy.\nIf this attack hits shield, repeat it.",
                AbilitySprite = ResourceLoader.LoadSprite("HillsShatter"),
                Cost = [Pigments.Yellow, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Crush,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 7, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HillsShatterEffect>(), 16, Targeting.Slot_Front),
                ]
            };
            shatter3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_16_20)]);
            shatter3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            hills.AddLevelData(12, [bellow0, mania0, shatter0]);
            hills.AddLevelData(17, [bellow1, mania1, shatter1]);
            hills.AddLevelData(22, [bellow2, mania2, shatter2]);
            hills.AddLevelData(27, [bellow3, mania3, shatter3]);

            hills.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Hills_Witness_ACH");
            hills.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Hills_Divine_ACH");
            hills.AddCharacter(true, false);
        }
    }
}
