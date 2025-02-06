using BrutalAPI;
using Hell_Island_Fell.Custom_Passives;
using Hell_Island_Fell.Custom_Stuff;
using Hell_Island_Fell.Status_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Enemies
{
    public class Maneater
    {
        public static void Add()
        {
            Enemy maneater = new Enemy("Maneater", "Maneater_EN")
            {
                Health = 65,
                HealthColor = Pigments.Red,
                Size = 2,
                CombatSprite = ResourceLoader.LoadSprite("TimelineManeater", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("DeadManeater", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineManeater", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("Flarb_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("Flarb_EN").deathSound,
                UnitTypes =
                [
                    UnitType_GameIDs.Fish.ToString(),
                ],
            };
            maneater.PrepareEnemyPrefab("Assets/ManeaterAssetBundle/Maneater.prefab", Hell_Island_Fell.assetBundle, Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/ManeaterAssetBundle/ManeaterGibs.prefab").GetComponent<ParticleSystem>());
            
            //intents
            IntentInfoBasic AnchoredIntent = new()
            {
                _color = Color.white,
                _sprite = Passives.Anchored.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Passive_Anchored", AnchoredIntent);

            IntentInfoBasic InfantileIntent = new()
            {
                _color = Color.white,
                _sprite = Passives.Infantile.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Passive_Infantile", InfantileIntent);

            IntentInfoBasic ObscureIntent = new()
            {
                _color = Color.white,
                _sprite = Passives.Obscure.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Passive_Obscure", ObscureIntent);

            IntentInfoBasic ImmortalIntent = new()
            {
                _color = Color.white,
                _sprite = Passives.Immortal.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Passive_Immortal", ImmortalIntent);

            IntentInfoBasic CatalystIntent = new()
            {
                _color = Color.white,
                _sprite = Passives.Catalyst.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Passive_Catalyst", CatalystIntent);

            IntentInfoBasic LeakyIntent = new()
            {
                _color = Color.white,
                _sprite = Passives.Leaky1.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Passive_Leaky", LeakyIntent);

            IntentInfoBasic RemAnchoredIntent = new()
            {
                _color = Color.grey,
                _sprite = Passives.Anchored.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Passive_Anchored", RemAnchoredIntent);

            IntentInfoBasic RemInfantileIntent = new()
            {
                _color = Color.grey,
                _sprite = Passives.Infantile.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Passive_Infantile", RemInfantileIntent);

            IntentInfoBasic RemObscureIntent = new()
            {
                _color = Color.grey,
                _sprite = Passives.Obscure.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Passive_Obscure", RemObscureIntent);

            IntentInfoBasic RemImmortalIntent = new()
            {
                _color = Color.grey,
                _sprite = Passives.Immortal.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Passive_Immortal", RemImmortalIntent);

            IntentInfoBasic RemCatalystIntent = new()
            {
                _color = Color.grey,
                _sprite = Passives.Catalyst.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Passive_Catalyst", RemCatalystIntent);

            IntentInfoBasic RemLeakyIntent = new()
            {
                _color = Color.grey,
                _sprite = Passives.Leaky1.passiveIcon,
            };
            LoadedDBsHandler.IntentDB.AddNewBasicIntent("Rem_Passive_Leaky", RemLeakyIntent);

            //checks
            CheckPassiveAbilityEffect AnchoredCheck = ScriptableObject.CreateInstance<CheckPassiveAbilityEffect>();
            AnchoredCheck.m_PassiveID = Passives.Anchored.m_PassiveID;

            CheckPassiveAbilityEffect InfantileCheck = ScriptableObject.CreateInstance<CheckPassiveAbilityEffect>();
            InfantileCheck.m_PassiveID = Passives.Infantile.m_PassiveID;

            CheckPassiveAbilityEffect ObscureCheck = ScriptableObject.CreateInstance<CheckPassiveAbilityEffect>();
            ObscureCheck.m_PassiveID = Passives.Obscure.m_PassiveID;

            CheckPassiveAbilityEffect ImmortalCheck = ScriptableObject.CreateInstance<CheckPassiveAbilityEffect>();
            ImmortalCheck.m_PassiveID = Passives.Immortal.m_PassiveID;

            CheckPassiveAbilityEffect CatalystCheck = ScriptableObject.CreateInstance<CheckPassiveAbilityEffect>();
            CatalystCheck.m_PassiveID = Passives.Catalyst.m_PassiveID;

            CheckPassiveAbilityEffect LeakyCheck = ScriptableObject.CreateInstance<CheckPassiveAbilityEffect>();
            LeakyCheck.m_PassiveID = Passives.Leaky1.m_PassiveID;

            //removes
            RemovePassiveEffect AnchoredRemove = ScriptableObject.CreateInstance<RemovePassiveEffect>();
            AnchoredRemove.m_PassiveID = Passives.Anchored.m_PassiveID;

            RemovePassiveEffect InfantileRemove = ScriptableObject.CreateInstance<RemovePassiveEffect>();
            InfantileRemove.m_PassiveID = Passives.Infantile.m_PassiveID;

            RemovePassiveEffect ObscureRemove = ScriptableObject.CreateInstance<RemovePassiveEffect>();
            ObscureRemove.m_PassiveID = Passives.Obscure.m_PassiveID;

            RemovePassiveEffect ImmortalRemove = ScriptableObject.CreateInstance<RemovePassiveEffect>();
            ImmortalRemove.m_PassiveID = Passives.Immortal.m_PassiveID;

            RemovePassiveEffect CatalystRemove = ScriptableObject.CreateInstance<RemovePassiveEffect>();
            CatalystRemove.m_PassiveID = Passives.Catalyst.m_PassiveID;

            RemovePassiveEffect LeakyRemove = ScriptableObject.CreateInstance<RemovePassiveEffect>();
            LeakyRemove.m_PassiveID = Passives.Leaky1.m_PassiveID;

            //adds
            AddPassiveEffect AnchoredAdd = ScriptableObject.CreateInstance<AddPassiveEffect>();
            AnchoredAdd._passiveToAdd = Passives.Anchored;

            AddPassiveEffect InfantileAdd = ScriptableObject.CreateInstance<AddPassiveEffect>();
            InfantileAdd._passiveToAdd = Passives.Infantile;

            AddPassiveEffect ObscureAdd = ScriptableObject.CreateInstance<AddPassiveEffect>();
            ObscureAdd._passiveToAdd = Passives.Obscure;

            AddPassiveEffect ImmortalAdd = ScriptableObject.CreateInstance<AddPassiveEffect>();
            ImmortalAdd._passiveToAdd = Passives.Immortal;

            AddPassiveEffect CatalystAdd = ScriptableObject.CreateInstance<AddPassiveEffect>();
            CatalystAdd._passiveToAdd = Passives.Catalyst;

            AddPassiveEffect LeakyAdd = ScriptableObject.CreateInstance<AddPassiveEffect>();
            LeakyAdd._passiveToAdd = Passives.Leaky1;

            PreviousEffectCondition Has = ScriptableObject.CreateInstance<PreviousEffectCondition>();
            Has.wasSuccessful = true;
            Has.previousAmount = 2;

            PreviousEffectCondition Has2 = ScriptableObject.CreateInstance<PreviousEffectCondition>();
            Has2.wasSuccessful = true;
            Has2.previousAmount = 3;

            PreviousEffectCondition Has3 = ScriptableObject.CreateInstance<PreviousEffectCondition>();
            Has3.wasSuccessful = true;
            Has3.previousAmount = 4;

            PreviousEffectCondition Has4 = ScriptableObject.CreateInstance<PreviousEffectCondition>();
            Has4.wasSuccessful = true;
            Has4.previousAmount = 5;

            PreviousEffectCondition HasNot = ScriptableObject.CreateInstance<PreviousEffectCondition>();
            HasNot.wasSuccessful = false;
            HasNot.previousAmount = 2;

            PreviousEffectCondition HasNot2 = ScriptableObject.CreateInstance<PreviousEffectCondition>();
            HasNot2.wasSuccessful = false;
            HasNot2.previousAmount = 3;

            FieldEffect_Apply_Effect ShieldApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ShieldApply._Field = StatusField.Shield;

            GenerateColorManaEffect BlueGenerate = ScriptableObject.CreateInstance<GenerateColorManaEffect>();
            BlueGenerate.mana = Pigments.Blue;

            StatusEffect_Apply_Effect FrailApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            FrailApply._Status = StatusField.Frail;

            Targetting_ByUnit_Index CenterTarget = ScriptableObject.CreateInstance<Targetting_ByUnit_Index>();
            CenterTarget.getAllies = true;
            CenterTarget.slotPointerDirections = [0];
            CenterTarget.allSelfSlots = false;

            Ability diamondDancer = new Ability("Diamond Dancer", "DiamondDancer_A")
            {
                Description = "If this enemy is Anchored, un-anchor it.\nOtherwise, Anchor this enemy and apply 20 Shield to this enemy's positions.",
                Cost = [Pigments.BlueRed, Pigments.Red],
                Visuals = Visuals.StompRight,
                AnimationTarget = CenterTarget,
                Effects =
                [
                    Effects.GenerateEffect(AnchoredCheck, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(AnchoredRemove, 1, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(AnchoredAdd, 1, Targeting.Slot_SelfSlot, HasNot),
                    Effects.GenerateEffect(ShieldApply, 20, Targeting.Slot_SelfAll, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.Fast,
            };
            diamondDancer.AddIntentsToTarget(Targeting.Slot_SelfAll, ["Rem_Passive_Anchored"]);
            diamondDancer.AddIntentsToTarget(Targeting.Slot_SelfAll, ["Passive_Anchored"]);
            diamondDancer.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Field_Shield)]);

            Ability behavioralBiology = new Ability("Behavioral Biology", "BehavioralBiology_A")
            {
                Description = "If this enemy is Infantile, make 'em act their age.\nOtherwise, make this enemy Infantile and produce 4 blue pigment.",
                Cost = [Pigments.Blue],
                Visuals = Visuals.Cry,
                AnimationTarget = CenterTarget,
                Effects =
                [
                    Effects.GenerateEffect(InfantileCheck, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(InfantileRemove, 1, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(InfantileAdd, 1, Targeting.Slot_SelfSlot, HasNot),
                    Effects.GenerateEffect(BlueGenerate, 4, Targeting.Slot_SelfAll, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.Fast,
            };
            behavioralBiology.AddIntentsToTarget(Targeting.Slot_SelfAll, ["Rem_Passive_Infantile"]);
            behavioralBiology.AddIntentsToTarget(Targeting.Slot_SelfAll, ["Passive_Infantile"]);
            behavioralBiology.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Mana_Generate)]);

            Ability multidimensionalMateriality = new Ability("Multidimensional Materiality", "MultidimensionalMateriality_A")
            {
                Description = "If this enemy is Obscured, reveal it and deal an agonizing amount of damage to the Opposing party members.\nOtherwise, Obscure this enemy.",
                Cost = [Pigments.Red, Pigments.Purple],
                Visuals = Visuals.Poke,
                AnimationTarget = Targeting.GenerateBigUnitSlotTarget([0, 1]),
                Effects =
                [
                    Effects.GenerateEffect(ObscureCheck, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ObscureRemove, 1, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 9, Targeting.GenerateBigUnitSlotTarget([0, 1]), Has),
                    Effects.GenerateEffect(ObscureAdd, 1, Targeting.Slot_SelfSlot, HasNot2),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.Fast,
            };
            multidimensionalMateriality.AddIntentsToTarget(Targeting.Slot_SelfAll, ["Rem_Passive_Obscure"]);
            multidimensionalMateriality.AddIntentsToTarget(Targeting.GenerateBigUnitSlotTarget([0, 1]), [nameof(IntentType_GameIDs.Damage_7_10)]);
            multidimensionalMateriality.AddIntentsToTarget(Targeting.Slot_SelfAll, ["Passive_Obscure"]);

            Ability squinchedStrengths = new Ability("Squinched Strengths", "SquinchedStrengths_A")
            {
                Description = "If this enemy is Immortal, make it mortal.\nOtherwise, apply Immortal to this enemy and move this enemy to the Left or Right 5 times.",
                Cost = [Pigments.Yellow, Pigments.BlueYellow],
                Visuals = Visuals.Mitosis,
                AnimationTarget = CenterTarget,
                Effects =
                [
                    Effects.GenerateEffect(ImmortalCheck, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ImmortalRemove, 1, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(ImmortalAdd, 1, Targeting.Slot_SelfSlot, HasNot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<SwapToSidesEffect>(), 1, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<SwapToSidesEffect>(), 1, Targeting.Slot_SelfSlot, Has),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<SwapToSidesEffect>(), 1, Targeting.Slot_SelfSlot, Has2),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<SwapToSidesEffect>(), 1, Targeting.Slot_SelfSlot, Has3),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<SwapToSidesEffect>(), 1, Targeting.Slot_SelfSlot, Has4),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.Fast,
            };
            squinchedStrengths.AddIntentsToTarget(Targeting.Slot_SelfAll, ["Rem_Passive_Immortal"]);
            squinchedStrengths.AddIntentsToTarget(Targeting.Slot_SelfAll, ["Passive_Immortal"]);
            squinchedStrengths.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Swap_Sides)]);
            squinchedStrengths.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Swap_Sides)]);
            squinchedStrengths.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Swap_Sides)]);
            squinchedStrengths.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Swap_Sides)]);
            squinchedStrengths.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Swap_Sides)]);

            Ability flummoxingFilaments = new Ability("Flummoxing Filaments", "FlummoxingFilaments_A")
            {
                Description = "If this enemy is a Catalyst, remove it and deal a lethal amount of damage to this enemy.\nOtherwise, apply Catalyst to this enemy.",
                Cost = [Pigments.Yellow, Pigments.BlueYellow],
                Visuals = Visuals.Mitosis,
                AnimationTarget = CenterTarget,
                Effects =
                [
                    Effects.GenerateEffect(CatalystCheck, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(CatalystRemove, 1, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 17, Targeting.Slot_SelfSlot, Has),
                    Effects.GenerateEffect(CatalystAdd, 1, Targeting.Slot_SelfSlot, HasNot2),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.Fast,
            };
            flummoxingFilaments.AddIntentsToTarget(Targeting.Slot_SelfAll, ["Rem_Passive_Catalyst"]);
            flummoxingFilaments.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Damage_16_20)]);
            flummoxingFilaments.AddIntentsToTarget(Targeting.Slot_SelfAll, ["Passive_Catalyst"]);

            Ability ontologicalOxygenation = new Ability("Ontological Oxygenation", "OntologicalOxygenation_A")
            {
                Description = "If this enemy is Leaky, remove it and apply 3 Frail to the Opposing party members.\nOtherwise, apply Leaky to this enemy.",
                Cost = [Pigments.Yellow, Pigments.BlueYellow],
                Visuals = Visuals.UglyOnTheInside,
                AnimationTarget = Targeting.GenerateBigUnitSlotTarget([0, 1]),
                Effects =
                [
                    Effects.GenerateEffect(LeakyCheck, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(LeakyRemove, 1, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(FrailApply, 3, Targeting.GenerateBigUnitSlotTarget([0, 1]), Has),
                    Effects.GenerateEffect(LeakyAdd, 1, Targeting.Slot_SelfSlot, HasNot2),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.Fast,
            };
            ontologicalOxygenation.AddIntentsToTarget(Targeting.Slot_SelfAll, ["Rem_Passive_Leaky"]);
            ontologicalOxygenation.AddIntentsToTarget(Targeting.GenerateBigUnitSlotTarget([0, 1]), [nameof(IntentType_GameIDs.Status_Frail)]);
            ontologicalOxygenation.AddIntentsToTarget(Targeting.Slot_SelfAll, ["Passive_Leaky"]);

            ExtraAbilityInfo dances = new()
            {
                ability = diamondDancer.GenerateEnemyAbility().ability,
                rarity = CustomAbilityRarity.Weight(0, true),
            };

            ExtraAbilityInfo bio = new()
            {
                ability = behavioralBiology.GenerateEnemyAbility().ability,
                rarity = CustomAbilityRarity.Weight(0, true),
            };
            
            ExtraAbilityInfo multi = new()
            {
                ability = multidimensionalMateriality.GenerateEnemyAbility().ability,
                rarity = CustomAbilityRarity.Weight(0, true),
            };

            maneater.AddEnemyAbilities(
                [
                    squinchedStrengths,
                    flummoxingFilaments,
                    ontologicalOxygenation,
                ]);
            maneater.AddPassives([CustomPassives.AltAttacksGenerator([dances, bio, multi])]);
            maneater.AddEnemy(true, false, false);
        }
    }
}