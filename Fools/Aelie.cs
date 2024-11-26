using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Fools
{
    public class Aelie
    {
        public static void Add()
        {
            Character aelie = new Character("Aelie", "Aelie_CH")
            {
                HealthColor = Pigments.Yellow,
                UsesBasicAbility = true,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("AelieFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("AelieBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("AelieOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("Rags_CH").dxSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("Dimitri_CH").deathSound,
                DialogueSound = LoadedAssetsHandler.GetCharacter("Rags_CH").dxSound,
                IgnoredAbilitiesForDPSBuilds = [0, 1],
                IgnoredAbilitiesForSupportBuilds = [2],
                UnitTypes =
                [
                    "FemaleID",
                ],
            };
            aelie.GenerateMenuCharacter(ResourceLoader.LoadSprite("AelieMenu"), ResourceLoader.LoadSprite("AelieLocked"));
            aelie.AddPassives([Passives.GetCustomPassive("Sweeping_PA")]);


            ConsumeAllColorManaEffect BlueDry = ScriptableObject.CreateInstance<ConsumeAllColorManaEffect>();
            BlueDry._consumeMana = Pigments.Blue;

            HealByHealthColorEffect Dry0 = ScriptableObject.CreateInstance<HealByHealthColorEffect>();
            Dry0._usePreviousExitValue = true;
            Dry0._matchingHealthColor = Pigments.Yellow;

            HealByHealthColorExtraEffect Dry1 = ScriptableObject.CreateInstance<HealByHealthColorExtraEffect>();
            Dry1._usePreviousExitValue = true;
            Dry1._extra = 1;
            Dry1._matchingHealthColor = Pigments.Yellow;

            HealByHealthColorExtraEffect Dry2 = ScriptableObject.CreateInstance<HealByHealthColorExtraEffect>();
            Dry2._usePreviousExitValue = true;
            Dry2._extra = 2;
            Dry2._matchingHealthColor = Pigments.Yellow;

            HealByHealthColorExtraEffect Dry3 = ScriptableObject.CreateInstance<HealByHealthColorExtraEffect>();
            Dry3._usePreviousExitValue = true;
            Dry3._extra = 3;
            Dry3._matchingHealthColor = Pigments.Yellow;

            DamageEffect IndirectDamage = ScriptableObject.CreateInstance<DamageEffect>();
            IndirectDamage._indirect = true;

            StatusEffect_Apply_Effect RuptureApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            RuptureApply._Status = StatusField.Ruptured;

            ChangeToRandomHealthColorEffect YellowHealth = ScriptableObject.CreateInstance<ChangeToRandomHealthColorEffect>();
            YellowHealth._healthColors = [Pigments.Yellow];

            //dessicate
            Ability desiccate0 = new Ability("Desiccate Quietly", "Desiccate_1_A")
            {
                Description = "Consume all stored blue pigment.\nHeal All party members and enemies with yellow health an equivalent amount.",
                AbilitySprite = ResourceLoader.LoadSprite("AelieDesiccate"),
                Cost = [Pigments.YellowPurple, Pigments.YellowPurple],
                Visuals = Visuals.Exsanguinate,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(BlueDry, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(Dry0, 1, Targeting.AllUnits),
                ]
            };
            desiccate0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);
            desiccate0.AddIntentsToTarget(Targeting.Unit_AllOpponents, [nameof(IntentType_GameIDs.Heal_5_10)]);
            desiccate0.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Heal_5_10)]);

            Ability desiccate1 = new Ability("Desiccate Slyly", "Desiccate_2_A")
            {
                Description = "Consume all stored blue pigment.\nHeal All party members and enemies with yellow health an equivalent amount + 1.",
                AbilitySprite = ResourceLoader.LoadSprite("AelieDesiccate"),
                Cost = [Pigments.YellowPurple, Pigments.YellowPurple],
                Visuals = Visuals.Exsanguinate,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(BlueDry, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(Dry1, 1, Targeting.AllUnits),
                ]
            };
            desiccate1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);
            desiccate1.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Heal_11_20)]);
            desiccate1.AddIntentsToTarget(Targeting.Unit_AllOpponents, [nameof(IntentType_GameIDs.Heal_11_20)]);

            Ability desiccate2 = new Ability("Desiccate Carefully", "Desiccate_3_A")
            {
                Description = "Consume all stored blue pigment.\nHeal All party members and enemies with yellow health an equivalent amount + 2.",
                AbilitySprite = ResourceLoader.LoadSprite("AelieDesiccate"),
                Cost = [Pigments.YellowPurple, Pigments.YellowPurple],
                Visuals = Visuals.Exsanguinate,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(BlueDry, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(Dry2, 1, Targeting.AllUnits),
                ]
            };
            desiccate2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);
            desiccate2.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Heal_11_20)]);
            desiccate2.AddIntentsToTarget(Targeting.Unit_AllOpponents, [nameof(IntentType_GameIDs.Heal_11_20)]);

            Ability desiccate3 = new Ability("Desiccate Instantly", "Desiccate_4_A")
            {
                Description = "Consume all stored blue pigment.\nHeal All party members and enemies with yellow health an equivalent amount + 3.",
                AbilitySprite = ResourceLoader.LoadSprite("AelieDesiccate"),
                Cost = [Pigments.YellowPurple, Pigments.YellowPurple],
                Visuals = Visuals.Exsanguinate,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(BlueDry, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(Dry3, 1, Targeting.AllUnits),
                ]
            };
            desiccate3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);
            desiccate3.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Heal_11_20)]);
            desiccate3.AddIntentsToTarget(Targeting.Unit_AllOpponents, [nameof(IntentType_GameIDs.Heal_11_20)]);


            //singing
            Ability singing0 = new Ability("Singing Wind", "Singing_1_A")
            {
                Description = "Apply 3 Ruptured to the Opposing enemy.\nChange the Left ally's health color to yellow.",
                AbilitySprite = ResourceLoader.LoadSprite("AelieSinging"),
                Cost = [Pigments.YellowBlue, Pigments.YellowBlue],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(RuptureApply, 3, Targeting.Slot_Front),
                    Effects.GenerateEffect(YellowHealth, 1, Targeting.Slot_AllyLeft),
                ]
            };
            singing0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Ruptured)]);
            singing0.AddIntentsToTarget(Targeting.Slot_AllyLeft, [nameof(IntentType_GameIDs.Mana_Randomize)]);

            Ability singing1 = new Ability("Singing Sand", "Singing_2_A")
            {
                Description = "Apply 5 Ruptured to the Opposing enemy.\nChange the Left ally's health color to yellow.",
                AbilitySprite = ResourceLoader.LoadSprite("AelieSinging"),
                Cost = [Pigments.YellowBlue, Pigments.YellowBlue],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(RuptureApply, 5, Targeting.Slot_Front),
                    Effects.GenerateEffect(YellowHealth, 1, Targeting.Slot_AllyLeft),
                ]
            };
            singing1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Ruptured)]);
            singing1.AddIntentsToTarget(Targeting.Slot_AllyLeft, [nameof(IntentType_GameIDs.Mana_Randomize)]);

            Ability singing2 = new Ability("Singing Night", "Singing_3_A")
            {
                Description = "Apply 6 Ruptured to the Left and Opposing enemies.\nChange the Left ally's health color to yellow.",
                AbilitySprite = ResourceLoader.LoadSprite("AelieSinging"),
                Cost = [Pigments.YellowBlue, Pigments.YellowBlue],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(RuptureApply, 6, Targeting.GenerateSlotTarget([0, 1], false, false)),
                    Effects.GenerateEffect(YellowHealth, 1, Targeting.Slot_AllyLeft),
                ]
            };
            singing2.AddIntentsToTarget(Targeting.GenerateSlotTarget([0, 1], false, false), [nameof(IntentType_GameIDs.Status_Ruptured)]);
            singing2.AddIntentsToTarget(Targeting.Slot_AllyLeft, [nameof(IntentType_GameIDs.Mana_Randomize)]);

            Ability singing3 = new Ability("Singing Sun", "Singing_4_A")
            {
                Description = "Apply 6 Ruptured to the Left, Right, and Opposing enemies.\nChange the Left ally's health color to yellow.",
                AbilitySprite = ResourceLoader.LoadSprite("AelieSinging"),
                Cost = [Pigments.YellowBlue, Pigments.YellowBlue],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(RuptureApply, 6, Targeting.Slot_FrontAndSides),
                    Effects.GenerateEffect(YellowHealth, 1, Targeting.Slot_AllyLeft),
                ]
            };
            singing3.AddIntentsToTarget(Targeting.Slot_FrontAndSides, [nameof(IntentType_GameIDs.Status_Ruptured)]);
            singing3.AddIntentsToTarget(Targeting.Slot_AllyLeft, [nameof(IntentType_GameIDs.Mana_Randomize)]);


            //sand
            Ability sand0 = new Ability("Sand Throw", "Sand_1_A")
            {
                Description = "Deal 5 indirect damage to the Opposing enemy.\nRandomly move the Left, Right, and Opposing enemies.\nDeal 5 indirect damage to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("AelieSands"),
                Cost = [Pigments.YellowRed, Pigments.YellowRed],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(IndirectDamage, 5, Targeting.Slot_Front),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<MassSwapZoneEffect>(), 1, Targeting.Slot_FrontAndSides),
                    Effects.GenerateEffect(IndirectDamage, 5, Targeting.Slot_Front),
                ]
            };
            sand0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            sand0.AddIntentsToTarget(Targeting.Slot_FrontAndSides, [nameof(IntentType_GameIDs.Swap_Mass)]);
            sand0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);

            Ability sand1 = new Ability("Sand Dunes", "Sand_2_A")
            {
                Description = "Deal 7 indirect damage to the Opposing enemy.\nRandomly move the Left, Right, and Opposing enemies.\nDeal 7 indirect damage to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("AelieSands"),
                Cost = [Pigments.YellowRed, Pigments.YellowRed],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(IndirectDamage, 7, Targeting.Slot_Front),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<MassSwapZoneEffect>(), 1, Targeting.Slot_FrontAndSides),
                    Effects.GenerateEffect(IndirectDamage, 7, Targeting.Slot_Front),
                ]
            };
            sand1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);
            sand1.AddIntentsToTarget(Targeting.Slot_FrontAndSides, [nameof(IntentType_GameIDs.Swap_Mass)]);
            sand1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);

            Ability sand2 = new Ability("Sand Storm", "Sand_3_A")
            {
                Description = "Deal 9 indirect damage to the Opposing enemy.\nRandomly move the Left, Right, and Opposing enemies.\nDeal 9 indirect damage to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("AelieSands"),
                Cost = [Pigments.YellowRed, Pigments.YellowRed],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(IndirectDamage, 9, Targeting.Slot_Front),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<MassSwapZoneEffect>(), 1, Targeting.Slot_FrontAndSides),
                    Effects.GenerateEffect(IndirectDamage, 9, Targeting.Slot_Front),
                ]
            };
            sand2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);
            sand2.AddIntentsToTarget(Targeting.Slot_FrontAndSides, [nameof(IntentType_GameIDs.Swap_Mass)]);
            sand2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);

            Ability sand3 = new Ability("Sand of Time", "Sand_4_A")
            {
                Description = "Deal 11 indirect damage to the Opposing enemy.\nRandomly move the Left, Right, and Opposing enemies.\nDeal 11 indirect damage to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("AelieSands"),
                Cost = [Pigments.YellowRed, Pigments.YellowRed],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(IndirectDamage, 11, Targeting.Slot_Front),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<MassSwapZoneEffect>(), 1, Targeting.Slot_FrontAndSides),
                    Effects.GenerateEffect(IndirectDamage, 11, Targeting.Slot_Front),
                ]
            };
            sand3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_11_15)]);
            sand3.AddIntentsToTarget(Targeting.Slot_FrontAndSides, [nameof(IntentType_GameIDs.Swap_Mass)]);
            sand3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_11_15)]);

            aelie.AddLevelData(8, new Ability[] { desiccate0, singing0, sand0 });
            aelie.AddLevelData(11, new Ability[] { desiccate1, singing1, sand1 });
            aelie.AddLevelData(14, new Ability[] { desiccate2, singing2, sand2 });
            aelie.AddLevelData(17, new Ability[] { desiccate3, singing3, sand3 });

            aelie.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Aelie_Witness_ACH");
            aelie.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Aelie_Divine_ACH");
            aelie.AddCharacter(true, false);
        }
    }
}
