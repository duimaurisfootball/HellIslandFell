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
                Health = 124,
                HealthColor = Pigments.Grey,
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
            vus.AddPassives([Passives.Pure, Passives.OverexertGenerator(11), CustomPassives.RetortionGenerator(6)]);

            SpawnEnemyAnywhereEffect SpawnMunglingMudLung = ScriptableObject.CreateInstance<SpawnEnemyAnywhereEffect>();
            SpawnMunglingMudLung.enemy = LoadedAssetsHandler.GetEnemy("MunglingMudLung_EN");
            SpawnMunglingMudLung._spawnTypeID = CombatType_GameIDs.Spawn_Basic.ToString();

            SpawnEnemyAnywhereEffect SpawnFlaMinGoa = ScriptableObject.CreateInstance<SpawnEnemyAnywhereEffect>();
            SpawnFlaMinGoa.enemy = LoadedAssetsHandler.GetEnemy("FlaMinGoa_EN");
            SpawnFlaMinGoa._spawnTypeID = CombatType_GameIDs.Spawn_Basic.ToString();

            SpawnEnemyAnywhereEffect SpawnWringle = ScriptableObject.CreateInstance<SpawnEnemyAnywhereEffect>();
            SpawnWringle.enemy = LoadedAssetsHandler.GetEnemy("Wringle_EN");
            SpawnWringle._spawnTypeID = CombatType_GameIDs.Spawn_Basic.ToString();

            SpawnEnemyAnywhereEffect SpawnKeklung = ScriptableObject.CreateInstance<SpawnEnemyAnywhereEffect>();
            SpawnKeklung.enemy = LoadedAssetsHandler.GetEnemy("Keklung_EN");
            SpawnKeklung._spawnTypeID = CombatType_GameIDs.Spawn_Basic.ToString();

            RerollNumberPigmentEffect RedReroll = ScriptableObject.CreateInstance<RerollNumberPigmentEffect>();
            RedReroll._mana = Pigments.Red;
            RedReroll._fullRerollReturnsSuccess = true;

            RerollNumberPigmentEffect BlueReroll = ScriptableObject.CreateInstance<RerollNumberPigmentEffect>();
            BlueReroll._mana = Pigments.Blue;
            BlueReroll._fullRerollReturnsSuccess = true;

            RerollNumberPigmentEffect YellowReroll = ScriptableObject.CreateInstance<RerollNumberPigmentEffect>();
            YellowReroll._mana = Pigments.Yellow;
            YellowReroll._fullRerollReturnsSuccess = true;

            RerollNumberPigmentEffect PurpleReroll = ScriptableObject.CreateInstance<RerollNumberPigmentEffect>();
            PurpleReroll._mana = Pigments.Purple;
            PurpleReroll._fullRerollReturnsSuccess = true;

            SwapToOneSideEffect LeftSwap = ScriptableObject.CreateInstance<SwapToOneSideEffect>();
            LeftSwap._swapRight = false;

            SwapToOneSideEffect RightSwap = ScriptableObject.CreateInstance<SwapToOneSideEffect>();
            RightSwap._swapRight = true;

            StatusEffect_Apply_Effect RupturedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            RupturedApply._Status = StatusField.Ruptured;

            FieldEffect_ApplyIfEmpty_Effect ConstrictedApply = ScriptableObject.CreateInstance<FieldEffect_ApplyIfEmpty_Effect>();
            ConstrictedApply._Field = StatusField.Constricted;

            StatusEffect_Apply_Effect OilApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            OilApply._Status = StatusField.OilSlicked;

            ChangeMaxHealthEffect IncreaseMaxHealth = ScriptableObject.CreateInstance<ChangeMaxHealthEffect>();
            IncreaseMaxHealth._entryAsPercentage = true;

            HealEffect PercentageHeal = ScriptableObject.CreateInstance<HealEffect>();
            PercentageHeal.entryAsPercentage = true;

            CasterStoreValueSetterEffect Unabominate = ScriptableObject.CreateInstance<CasterStoreValueSetterEffect>();
            Unabominate.m_unitStoredDataID = UnitStoredValueNames_GameIDs.AbominationPA.ToString();

            SetCasterAnimationParameterEffect OpenUp = ScriptableObject.CreateInstance<SetCasterAnimationParameterEffect>();
            OpenUp._parameterName = "IsOpen";
            OpenUp._parameterValue = 1;

            SetCasterAnimationParameterEffect CloseUp = ScriptableObject.CreateInstance<SetCasterAnimationParameterEffect>();
            CloseUp._parameterName = "IsOpen";
            CloseUp._parameterValue = 0;

            SwapCasterPassivesEffect Abominate = ScriptableObject.CreateInstance<SwapCasterPassivesEffect>();
            Abominate._passivesToSwap =
            [
                Passives.Pure,
                Passives.Abomination1,
                Passives.Skittish,
            ];

            SwapCasterPassivesEffect Extertate = ScriptableObject.CreateInstance<SwapCasterPassivesEffect>();
            Extertate._passivesToSwap =
            [
                Passives.Pure,
                Passives.OverexertGenerator(11),
                CustomPassives.RetortionGenerator(6),
            ];

            SwapCasterAbilitiesEffect ClosedAbilities = ScriptableObject.CreateInstance<SwapCasterAbilitiesEffect>();

            Ability pollenation = new Ability("Pollenation", "HIF_Pollenation_A")
            {
                Description = "Heal all enemies.\nHealing is spread out between enemies.\nGive a random ally an additional ability on the timeline.",
                Cost = [Pigments.Grey, Pigments.Grey, Pigments.Grey, Pigments.Grey],
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealRandomSplitBetweenEntryEffect>(), 10, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<AddRandomTimelineAbilityEffect>(), 1, Targeting.Unit_OtherAllies),
                ],
                Rarity = CustomAbilityRarity.Weight(9, true),
                Priority = Priority.ExtremelyFast,
            };
            pollenation.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Heal_1_4)]);
            pollenation.AddIntentsToTarget(Targeting.Unit_OtherAllies, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability germinate = new Ability("Germinate", "HIF_Germinate_A")
            {
                Description = "\"The fruiting body shrivels away from the light.\"",
                Cost = [Pigments.Grey, Pigments.Grey, Pigments.Grey, Pigments.Grey],
                Effects =
                [
                    Effects.GenerateEffect(ProteinEvolution),
                    Effects.GenerateEffect(CloseUp),
                    Effects.GenerateEffect(Extertate),
                    Effects.GenerateEffect(ClosedAbilities),
                    Effects.GenerateEffect(Unabominate, 0),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.VeryFast,
            };
            germinate.AddIntentsToTarget(Targeting.Unit_OtherAllies, [nameof(IntentType_GameIDs.Misc_Hidden)]);

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
                Description = "Summon a Mungling Mud Lung.\nTransform 3 stored pigment to red.\nIf successful, move this enemy to the Left twice or Right twice.",
                Cost = [Pigments.Red, Pigments.Red],
                Effects =
                [
                    Effects.GenerateEffect(SpawnMunglingMudLung, 1, Targeting.Slot_SelfAll),
                    Effects.GenerateEffect(RedReroll, 3, Targeting.Slot_SelfAll),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1, null, Effects.ChanceCondition(50)),
                    Effects.GenerateEffect(LeftSwap, 1, Targeting.Slot_SelfAll, Effects.CheckMultiplePreviousEffectsCondition([true, true], [1, 2])),
                    Effects.GenerateEffect(LeftSwap, 1, Targeting.Slot_SelfAll, Effects.CheckMultiplePreviousEffectsCondition([true, true], [2, 3])),
                    Effects.GenerateEffect(RightSwap, 1, Targeting.Slot_SelfAll, Effects.CheckMultiplePreviousEffectsCondition([false, true], [3, 4])),
                    Effects.GenerateEffect(RightSwap, 1, Targeting.Slot_SelfAll, Effects.CheckMultiplePreviousEffectsCondition([false, true], [4, 5])),
                ],
                Rarity = CustomAbilityRarity.Weight(10, true),
                Priority = Priority.Normal,
            };
            runningCastle.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Other_Spawn)]);
            runningCastle.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Mana_Modify)]);
            runningCastle.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Swap_Sides)]);
            runningCastle.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Swap_Sides)]);

            Ability barometer = new Ability("Barometer", "Barometer_A")
            {
                Description = "Summon a Fla Ming Goa.\nTransform 3 stored pigment to blue.\nIf successful, apply 2 Ruptued to the Opposing party members.",
                Cost = [Pigments.Blue, Pigments.Blue],
                Effects =
                [
                    Effects.GenerateEffect(SpawnFlaMinGoa, 1, Targeting.Slot_SelfAll),
                    Effects.GenerateEffect(BlueReroll, 3, Targeting.Slot_SelfAll),
                    Effects.GenerateEffect(RupturedApply, 2, Targeting.GenerateBigUnitSlotTarget([0, 1]), Effects.CheckPreviousEffectCondition(true, 1)),
                ],
                Rarity = CustomAbilityRarity.Weight(10, true),
                Priority = Priority.Normal,
            };
            barometer.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Other_Spawn)]);
            barometer.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Mana_Modify)]);
            barometer.AddIntentsToTarget(Targeting.GenerateBigUnitSlotTarget([0, 1]), [nameof(IntentType_GameIDs.Status_Ruptured)]);

            Ability treeRings = new Ability("Tree Rings", "TreeRings_A")
            {
                Description = "Summon a Wringle.\nTransform 3 stored pigment to yellow.\nIf successful, apply 3 Constricted to the Opposing positions if they are empty.",
                Cost = [Pigments.Yellow, Pigments.Yellow],
                Effects =
                [
                    Effects.GenerateEffect(SpawnWringle, 1, Targeting.Slot_SelfAll),
                    Effects.GenerateEffect(YellowReroll, 3, Targeting.Slot_SelfAll),
                    Effects.GenerateEffect(ConstrictedApply, 3, Targeting.GenerateBigUnitSlotTarget([0, 1]), Effects.CheckPreviousEffectCondition(true, 1)),
                ],
                Rarity = CustomAbilityRarity.Weight(10, true),
                Priority = Priority.Normal,
            };
            treeRings.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Other_Spawn)]);
            treeRings.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Mana_Modify)]);
            treeRings.AddIntentsToTarget(Targeting.GenerateBigUnitSlotTarget([0, 1]), [nameof(IntentType_GameIDs.Field_Constricted)]);

            Ability licksOfNectar = new Ability("Licks of Nectar", "LicksofNectar_A")
            {
                Description = "Summon a Keklung.\nTransform 3 stored pigment to purple.\nIf successful, apply 3 Oil Slicked to the Opposing party members.",
                Cost = [Pigments.Yellow, Pigments.Yellow],
                Effects =
                [
                    Effects.GenerateEffect(SpawnKeklung, 1, Targeting.Slot_SelfAll),
                    Effects.GenerateEffect(PurpleReroll, 3, Targeting.Slot_SelfAll),
                    Effects.GenerateEffect(OilApply, 3, Targeting.GenerateBigUnitSlotTarget([0, 1]), Effects.CheckPreviousEffectCondition(true, 1)),
                ],
                Rarity = CustomAbilityRarity.Weight(10, true),
                Priority = Priority.Normal,
            };
            licksOfNectar.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Other_Spawn)]);
            licksOfNectar.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Mana_Modify)]);
            licksOfNectar.AddIntentsToTarget(Targeting.GenerateBigUnitSlotTarget([0, 1]), [nameof(IntentType_GameIDs.Status_OilSlicked)]);

            Ability bloom = new Ability("Bloom", "HIF_Bloom_A")
            {
                Description = "\"Open up to the world.\"",
                Cost = [Pigments.Grey, Pigments.Grey],
                Effects =
                [
                    Effects.GenerateEffect(InFluorescence),
                    Effects.GenerateEffect(OpenUp),
                    Effects.GenerateEffect(Abominate),
                    Effects.GenerateEffect(OpenAbilities),
                    Effects.GenerateEffect(IncreaseMaxHealth, 100, Targeting.Unit_OtherAllies),
                    Effects.GenerateEffect(PercentageHeal, 33, Targeting.Unit_OtherAllies),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ChangeMaxHealthByCurrentHealthEffect>(), 1, Targeting.Slot_SelfSlot),
                ],
                Rarity = CustomAbilityRarity.Weight(7, true),
                Priority = Priority.Normal,
            };
            bloom.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Misc_State_Sit)]);
            bloom.AddIntentsToTarget(Targeting.Unit_OtherAllies, [nameof(IntentType_GameIDs.Heal_21)]);
            bloom.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_MaxHealth_Alt)]);

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
            vus.AddEnemy(true, false, false);
        }
    }
}
