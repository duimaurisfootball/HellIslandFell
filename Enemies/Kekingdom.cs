using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Enemies
{
    public class Kekingdom
    {
        public static void Add()
        {
            Enemy kekingdom = new Enemy("Kekingdom", "Kekingdom_EN")
            {
                Health = 83,
                HealthColor = Pigments.Purple,
                Size = 3,
                CombatSprite = ResourceLoader.LoadSprite("TimelineKekingdom", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("DeadKekingdom", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineKekingdom", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("Kekastle_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("Kekastle_EN").deathSound,
                UnitTypes =
                [
                    UnitType_GameIDs.Fish.ToString(),
                ],
            };
            kekingdom.PrepareEnemyPrefab("Assets/KekingdomAssetBundle/Kekingdom.prefab", Hell_Island_Fell.assetBundle, Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/KekingdomAssetBundle/KekingdomGibs.prefab").GetComponent<ParticleSystem>());
            if (Hell_Island_Fell.arachnophobiaMode.Value)
            {
                kekingdom.CombatSprite = ResourceLoader.LoadSprite("ARCTimelineKekingdom", new Vector2(0.5f, 0f), 32);
                kekingdom.OverworldDeadSprite = ResourceLoader.LoadSprite("DeadKekingdom", new Vector2(0.5f, 0f), 32);
                kekingdom.OverworldAliveSprite = ResourceLoader.LoadSprite("ARCTimelineKekingdom", new Vector2(0.5f, 0f), 32);
                kekingdom.PrepareEnemyPrefab("Assets/ARC_KekingdomAssetBundle/ARC_Kekingdom.prefab", Hell_Island_Fell.assetBundle, Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/ARC_FlatbackAssetBundle/ARC_FlatbackGibs.prefab").GetComponent<ParticleSystem>());
            }
            kekingdom.AddPassives([Passives.InfestationGenerator(3), Passives.Dying, Passives.Forgetful, Passives.GetCustomPassive("DecayKekingdom_PA")]);

            Targetting_ByUnit_Index CenterTarget = ScriptableObject.CreateInstance<Targetting_ByUnit_Index>();
            CenterTarget.getAllies = true;
            CenterTarget.slotPointerDirections = [0];
            CenterTarget.allSelfSlots = false;

            StatusEffect_Apply_Effect FrailApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            FrailApply._Status = StatusField.Frail;

            DamageRandomBetweenTargetsEffect PuppetAttack = ScriptableObject.CreateInstance<DamageRandomBetweenTargetsEffect>();
            PuppetAttack._numberTargets = 2;

            StatusEffect_Apply_Effect ScarsApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            ScarsApply._Status = StatusField.Scars;

            AnimationVisualsEffect Nibble = ScriptableObject.CreateInstance<AnimationVisualsEffect>();
            Nibble._visuals = Visuals.Nibble;
            Nibble._animationTarget = Targeting.GenerateBigUnitSlotTarget([0, 1, 2]);

            CasterStoredValueChangeEffect InfestationIncrease = ScriptableObject.CreateInstance<CasterStoredValueChangeEffect>();
            InfestationIncrease.m_unitStoredDataID = UnitStoredValueNames_GameIDs.InfestationPA.ToString();
            InfestationIncrease._increase = true;
            InfestationIncrease._minimumValue = 0;

            StatusEffect_Apply_Effect OilApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            OilApply._Status = StatusField.OilSlicked;

            ConsumeAllColorManaEffect EatPurple = ScriptableObject.CreateInstance<ConsumeAllColorManaEffect>();
            EatPurple._consumeMana = Pigments.Purple;

            SpawnMassivelyEverywhereUsingHealthEffect KekoSpawn = ScriptableObject.CreateInstance<SpawnMassivelyEverywhereUsingHealthEffect>();
            KekoSpawn._possibleEnemies =
                [
                    LoadedAssetsHandler.GetEnemy("Keko_EN"),
                    LoadedAssetsHandler.GetEnemy("Keko_EN"),
                    LoadedAssetsHandler.GetEnemy("Keko_EN"),
                    LoadedAssetsHandler.GetEnemy("Keko_EN"),
                    LoadedAssetsHandler.GetEnemy("Keko_EN"),
                ];
            KekoSpawn._givesExperience = false;

            Ability direDistension = new Ability("Dire Distension", "DireDistension_A")
            {
                Description = "Spawn as many Kekos as possible at the cost of this enemy's health.\nApply 3 Frail to this enemy.",
                Cost = [Pigments.Yellow, Pigments.YellowBlue],
                Visuals = Visuals.WrigglingWrath,
                AnimationTarget = CenterTarget,
                Effects =
                [
                    Effects.GenerateEffect(KekoSpawn, 5, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(FrailApply, 3, Targeting.Slot_SelfSlot),
                ],
                Rarity = CustomAbilityRarity.Weight(2, true),
                Priority = Priority.Normal,
            };
            direDistension.AddIntentsToTarget(CenterTarget, [nameof(IntentType_GameIDs.Other_Spawn)]);
            direDistension.AddIntentsToTarget(CenterTarget, [nameof(IntentType_GameIDs.Other_Spawn)]);
            direDistension.AddIntentsToTarget(CenterTarget, [nameof(IntentType_GameIDs.Status_Frail)]);

            Ability macabrePuppet = new Ability("Macabre Puppet", "MacabrePuppet_A")
            {
                Description = "Deal almost no damage to two random Opposing party members 3 times.\nApply 1 Scar to this enemy.",
                Cost = [Pigments.Red, Pigments.Red, Pigments.Red],
                Effects =
                [
                    Effects.GenerateEffect(Nibble, 1),
                    Effects.GenerateEffect(PuppetAttack, 1, Targeting.GenerateBigUnitSlotTarget([0, 1, 2])),
                    Effects.GenerateEffect(Nibble, 1),
                    Effects.GenerateEffect(PuppetAttack, 1, Targeting.GenerateBigUnitSlotTarget([0, 1, 2])),
                    Effects.GenerateEffect(Nibble, 1),
                    Effects.GenerateEffect(PuppetAttack, 1, Targeting.GenerateBigUnitSlotTarget([0, 1, 2])),
                    Effects.GenerateEffect(ScarsApply, 1, Targeting.Slot_SelfSlot),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.Normal,
            };
            macabrePuppet.AddIntentsToTarget(Targeting.GenerateBigUnitSlotTarget([0, 1, 2]), [nameof(IntentType_GameIDs.Damage_1_2)]);
            macabrePuppet.AddIntentsToTarget(Targeting.GenerateBigUnitSlotTarget([0, 1, 2]), [nameof(IntentType_GameIDs.Damage_1_2)]);
            macabrePuppet.AddIntentsToTarget(Targeting.GenerateBigUnitSlotTarget([0, 1, 2]), [nameof(IntentType_GameIDs.Damage_1_2)]);
            macabrePuppet.AddIntentsToTarget(CenterTarget, [nameof(IntentType_GameIDs.Status_Scars)]);

            Ability wavingWorms = new Ability("Waving Worms", "WavingWorms_A")
            {
                Description = "Increase this enemy's Infestation by 2.\nInflict 2 Oil Slicked to all party members.\nConsume all purple pigment.",
                Cost = [Pigments.Purple, Pigments.Purple, Pigments.Purple, Pigments.Purple, Pigments.Purple],
                Visuals = Visuals.WrigglingWrath,
                AnimationTarget = CenterTarget,
                Effects =
                [
                    Effects.GenerateEffect(InfestationIncrease, 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(OilApply, 2, Targeting.Unit_AllOpponents),
                    Effects.GenerateEffect(EatPurple, 1),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.Normal,
            };
            wavingWorms.AddIntentsToTarget(CenterTarget, [nameof(IntentType_GameIDs.Misc)]);
            wavingWorms.AddIntentsToTarget(Targeting.Unit_AllOpponents, [nameof(IntentType_GameIDs.Status_OilSlicked)]);
            wavingWorms.AddIntentsToTarget(CenterTarget, [nameof(IntentType_GameIDs.Mana_Consume)]);

            kekingdom.AddEnemyAbilities(
                [
                    direDistension,
                    macabrePuppet,
                    wavingWorms,
                ]);
            kekingdom.AddEnemy(true, true, false);
        }
    }
}

