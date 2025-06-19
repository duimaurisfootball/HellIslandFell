using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Enemies
{
    public class Vus
    {
        public static void Add()
        {
            ChangeMusicParameterEffect InFluorescence = ScriptableObject.CreateInstance<ChangeMusicParameterEffect>();
            InFluorescence._parameter = (MusicParameter)888833;
            InFluorescence._addition = true;

            ChangeMusicParameterEffect ProteinEvolution = ScriptableObject.CreateInstance<ChangeMusicParameterEffect>();
            ProteinEvolution._parameter = (MusicParameter)888833;
            ProteinEvolution._addition = false;

            ExtraShopLootByExactCostEffect EightCost = ScriptableObject.CreateInstance<ExtraShopLootByExactCostEffect>();
            EightCost._cost = 8;

            Enemy vus = new Enemy("Vus", "Vus_EN")
            {
                Health = 174,
                HealthColor = Pigments.Red,
                Size = 2,
                CombatSprite = ResourceLoader.LoadSprite("TimelineVus", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("DeadVus", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineVus", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("LongLiver_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("LongLiver_CH").deathSound,
                UnitTypes =
                [
                    "HellishID"
                ],
                CombatExitEffects =
                [
                    Effects.GenerateEffect(ProteinEvolution),
                    Effects.GenerateEffect(EightCost, 2),
                ],
            };
            vus.PrepareEnemyPrefab("Assets/VusAssetBundle/Vus.prefab", Hell_Island_Fell.assetBundle, Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/VusAssetBundle/VusGibs.prefab").GetComponent<ParticleSystem>());
            vus.AddPassives([Passives.Forgetful]);

            PerformRandomAbilityFromEnemyListEffect MunglingAbility = ScriptableObject.CreateInstance<PerformRandomAbilityFromEnemyListEffect>();
            MunglingAbility.enemies = ["MunglingMudLung_EN"];

            PerformRandomAbilityFromEnemyListEffect GoaAbility = ScriptableObject.CreateInstance<PerformRandomAbilityFromEnemyListEffect>();
            GoaAbility.enemies = ["FlaMinGoa_EN"];

            PerformRandomAbilityFromEnemyListEffect FlarbletAbility = ScriptableObject.CreateInstance<PerformRandomAbilityFromEnemyListEffect>();
            FlarbletAbility.enemies = ["Flarblet_EN"];

            PerformRandomAbilityFromEnemyListEffect VoboolaAbility = ScriptableObject.CreateInstance<PerformRandomAbilityFromEnemyListEffect>();
            VoboolaAbility.enemies = ["Voboola_EN"];

            CasterStoreValueSetterEffect Unabominate = ScriptableObject.CreateInstance<CasterStoreValueSetterEffect>();
            Unabominate.m_unitStoredDataID = UnitStoredValueNames_GameIDs.AbominationPA.ToString();

            SetCasterAnimationParameterEffect OpenPhaseAnimation = ScriptableObject.CreateInstance<SetCasterAnimationParameterEffect>();
            OpenPhaseAnimation._parameterName = "IsOpen";
            OpenPhaseAnimation._parameterValue = 1;

            SetCasterAnimationParameterEffect ClosedPhaseAnimation = ScriptableObject.CreateInstance<SetCasterAnimationParameterEffect>();
            ClosedPhaseAnimation._parameterName = "IsOpen";
            ClosedPhaseAnimation._parameterValue = 0;

            SwapCasterPassivesEffect OpenPhasePassives = ScriptableObject.CreateInstance<SwapCasterPassivesEffect>();
            OpenPhasePassives._passivesToSwap =
            [
                Passives.Abomination1,
                Passives.Skittish,
            ];

            SwapCasterPassivesEffect ClosedPhasePassives = ScriptableObject.CreateInstance<SwapCasterPassivesEffect>();
            ClosedPhasePassives._passivesToSwap =
            [
                Passives.Forgetful
            ];

            SwapCasterAbilitiesEffect ClosedAbilities = ScriptableObject.CreateInstance<SwapCasterAbilitiesEffect>();

            Ability pollenation = new Ability("Pollenation", "HIF_Pollenation_A")
            {
                Description = "Perform 1 random ability from the Opposing party members.",
                Cost = [Pigments.Grey, Pigments.Grey, Pigments.Grey, Pigments.Grey],
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<PerformRandomAbilityFromTargetsEffect>(), 1, Targeting.Slot_Front),
                ],
                Rarity = CustomAbilityRarity.Weight(10, true),
                Priority = Priority.Fast,
            };
            pollenation.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Misc)]);
            pollenation.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Misc_Hidden)]);

            Ability germinate = new Ability("Germinate", "HIF_Germinate_A")
            {
                Description = "\"The fruiting body shrivels away from the light.\"",
                Cost = [Pigments.Grey, Pigments.Grey, Pigments.Grey, Pigments.Grey],
                Effects =
                [
                    Effects.GenerateEffect(ProteinEvolution),
                    Effects.GenerateEffect(ClosedPhaseAnimation),
                    Effects.GenerateEffect(ClosedPhasePassives),
                    Effects.GenerateEffect(ClosedAbilities),
                    Effects.GenerateEffect(Unabominate, 0),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.Normal,
            };
            germinate.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Misc_State_Stand)]);

            ExtraAbilityInfo pollen = new()
            {
                ability = pollenation.GenerateEnemyAbility().ability,
                rarity = CustomAbilityRarity.Weight(19, true),
            };

            ExtraAbilityInfo germin = new()
            {
                ability = germinate.GenerateEnemyAbility().ability,
                rarity = CustomAbilityRarity.Weight(1, true),
            };

            SwapCasterAbilitiesEffect OpenAbilities = ScriptableObject.CreateInstance<SwapCasterAbilitiesEffect>();
            OpenAbilities._abilitiesToSwap =
                [
                    pollen,
                    germin,
                ];

            Ability runningCastle = new Ability("Running Castle", "RunningCastle_A")
            {
                Description = "Perform a random Mungling Mud Lung ability.",
                Cost = [Pigments.Red, Pigments.Red],
                Effects =
                [
                    Effects.GenerateEffect(MunglingAbility, 1),
                ],
                Rarity = CustomAbilityRarity.Weight(25, true),
                Priority = Priority.Normal,
            };
            runningCastle.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            runningCastle.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Mana_Consume), nameof(IntentType_GameIDs.Swap_Sides), nameof(IntentType_GameIDs.Field_Shield), nameof(IntentType_GameIDs.Damage_3_6), nameof(IntentType_GameIDs.Other_Spawn)]);

            Ability barometer = new Ability("Barometer", "Barometer_A")
            {
                Description = "Perform a random Fla Ming Goa ability.",
                Cost = [Pigments.Blue, Pigments.Blue],
                Effects =
                [
                    Effects.GenerateEffect(GoaAbility, 1),
                ],
                Rarity = CustomAbilityRarity.Weight(25, true),
                Priority = Priority.Normal,
            };
            barometer.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Mana_Randomize)]);
            barometer.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Field_Shield), nameof(IntentType_GameIDs.Swap_Mass)]);
            barometer.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);

            Ability treeRings = new Ability("Tree Rings", "TreeRings_A")
            {
                Description = "Perform a random Flarblet ability.",
                Cost = [Pigments.Yellow, Pigments.Yellow],
                Effects =
                [
                    Effects.GenerateEffect(FlarbletAbility, 1),
                ],
                Rarity = CustomAbilityRarity.Weight(25, true),
                Priority = Priority.Normal,
            };
            treeRings.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_1_2)]);
            treeRings.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Mana_Generate), nameof(IntentType_GameIDs.Other_Spawn)]);

            Ability licksOfNectar = new Ability("Licks of Nectar", "LicksofNectar_A")
            {
                Description = "Perform a random Voboola ability.",
                Cost = [Pigments.Purple, Pigments.Purple],
                Effects =
                [
                    Effects.GenerateEffect(VoboolaAbility, 1),
                ],
                Rarity = CustomAbilityRarity.Weight(25, true),
                Priority = Priority.Normal,
            };
            licksOfNectar.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6), nameof(IntentType_GameIDs.Status_Ruptured), nameof(IntentType_GameIDs.Damage_1_2)]);
            licksOfNectar.AddIntentsToTarget(Targeting.Slot_OpponentAllLefts, [nameof(IntentType_GameIDs.Swap_Right)]);
            licksOfNectar.AddIntentsToTarget(Targeting.Slot_OpponentAllRights, [nameof(IntentType_GameIDs.Swap_Left)]);

            Ability bloom = new Ability("Bloom", "HIF_Bloom_A")
            {
                Description = "\"Open up to the world.\"",
                Cost = [Pigments.Grey, Pigments.Grey],
                Effects =
                [
                    Effects.GenerateEffect(InFluorescence),
                    Effects.GenerateEffect(OpenPhaseAnimation),
                    Effects.GenerateEffect(OpenPhasePassives),
                    Effects.GenerateEffect(OpenAbilities),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.Normal,
            };
            bloom.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Misc_State_Sit)]);

            ExtraAbilityInfo imCastling = new()
            {
                ability = runningCastle.GenerateEnemyAbility().ability,
                rarity = CustomAbilityRarity.Weight(10, true),
            };

            ExtraAbilityInfo pressure = new()
            {
                ability = barometer.GenerateEnemyAbility().ability,
                rarity = CustomAbilityRarity.Weight(10, true),
            };

            ExtraAbilityInfo aging = new()
            {
                ability = treeRings.GenerateEnemyAbility().ability,
                rarity = CustomAbilityRarity.Weight(10, true),
            };

            ExtraAbilityInfo honey = new()
            {
                ability = licksOfNectar.GenerateEnemyAbility().ability,
                rarity = CustomAbilityRarity.Weight(10, true),
            };

            ExtraAbilityInfo boomer = new()
            {
                ability = bloom.GenerateEnemyAbility().ability,
                rarity = CustomAbilityRarity.Weight(10, true),
            };

            ClosedAbilities._abilitiesToSwap =
                [
                    imCastling,
                    pressure,
                    aging,
                    honey,
                    boomer,
                ];

            vus.AddEnemyAbilities(
                [
                    runningCastle,
                    barometer,
                    treeRings,
                    licksOfNectar,
                    bloom,
                ]);
            vus.AddEnemy(false, false, false);
        }
    }
}
