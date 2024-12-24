using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Enemies
{
    public class StickingHomunculus
    {
        public static void Add()
        {
            Enemy stickingHomunculus = new Enemy("Sticking Homunculus", "StickingHomunculus_EN")
            {
                Health = 40,
                HealthColor = Pigments.Red,
                Size = 1,
                CombatSprite = ResourceLoader.LoadSprite("TimelineStickingHomunculus", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("DeadStickingHomunculus", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineStickingHomunculus", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("SkinningHomunculus_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("SkinningHomunculus_EN").deathSound,
            };
            stickingHomunculus.PrepareEnemyPrefab("Assets/StickingHomunculusAssetBundle/StickingHomunculus.prefab", Hell_Island_Fell.assetBundle, Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/StickingHomunculusAssetBundle/StickingHomunculusGibs.prefab").GetComponent<ParticleSystem>());

            DamageEffect IndirectDamage = ScriptableObject.CreateInstance<DamageEffect>();
            IndirectDamage._indirect = true;

            FieldEffect_Apply_Effect ShieldApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ShieldApply._Field = StatusField.Shield;

            CheckCasterHealthColorEffect RedCheck = ScriptableObject.CreateInstance<CheckCasterHealthColorEffect>();
            RedCheck._color = Pigments.Red;

            PreviousEffectCondition Fail = ScriptableObject.CreateInstance<PreviousEffectCondition>();
            Fail.wasSuccessful = false;
            Fail.previousAmount = 2;

            SpawnEnemyAnywhereEffect Scatter = ScriptableObject.CreateInstance<SpawnEnemyAnywhereEffect>();
            Scatter.enemy = LoadedAssetsHandler.GetEnemy("ScatteringHomunculus_EN");
            Scatter._spawnTypeID = CombatType_GameIDs.Spawn_Basic.ToString();

            PercentageEffectCondition Chance0 = ScriptableObject.CreateInstance<PercentageEffectCondition>();
            Chance0.percentage = 50;


            Ability gruesomeExcrement = new Ability("Gruesome Excrement", "GruesomeExcrement_A")
            {
                Description = "Deal a Painful amount of damage to this enemy.\nIf this enemy's health color is red, Heal all other enemies.\nIf this enemy's health color is yellow, Greatly Heal this enemy.",
                Cost = [Pigments.Red, Pigments.Red],
                Visuals = Visuals.Puke,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 5, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(RedCheck, 1),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 6, Targeting.Unit_OtherAllies, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 11, Targeting.Slot_SelfSlot, Fail),
                ],
                Rarity = CustomAbilityRarity.Weight(9, true),
                Priority = Priority.VerySlow,
            };
            gruesomeExcrement.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Damage_3_6)]);
            gruesomeExcrement.AddIntentsToTarget(Targeting.Unit_OtherAllies, [nameof(IntentType_GameIDs.Heal_5_10)]);
            gruesomeExcrement.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_11_20)]);

            Ability bitterMiasma = new Ability("Bitter Miasma", "BitterMiasma_A")
            {
                Description = "Deal a Painful amount of damage to this enemy.\nIf this enemy's health color is red, apply 5 Shield to all enemy positions.\nIf this enemy's health color is yellow, deal a Little indirect damage to all party members.",
                Cost = [Pigments.Red, Pigments.Red],
                Visuals = Visuals.Melt,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 3, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(RedCheck, 1),
                    Effects.GenerateEffect(ShieldApply, 5, Targeting.Unit_AllAllySlots, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(IndirectDamage, 2, Targeting.Unit_AllOpponents, Fail),
                ],
                Rarity = CustomAbilityRarity.Weight(7, true),
                Priority = Priority.VerySlow,
            };
            bitterMiasma.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Damage_3_6)]);
            bitterMiasma.AddIntentsToTarget(Targeting.Unit_AllAllySlots, [nameof(IntentType_GameIDs.Field_Shield)]);
            bitterMiasma.AddIntentsToTarget(Targeting.Unit_AllOpponents, [nameof(IntentType_GameIDs.Damage_1_2)]);

            Ability eerieShed = new Ability("Eerie Shed", "EerieShed_A")
            {
                Description = "Summon as many Scattering Homunculi as possible.\n50% chance to Slightly heal this enemy.",
                Cost = [Pigments.Red, Pigments.Red],
                Visuals = Visuals.UglyOnTheInside,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(Scatter, 4),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 4, Targeting.Slot_SelfSlot, Chance0),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.Slow,
            };
            eerieShed.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            eerieShed.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            eerieShed.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            eerieShed.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);
            eerieShed.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_1_4)]);

            ExtraAbilityInfo shedder = new()
            {
                ability = eerieShed.GenerateEnemyAbility().ability,
                rarity = CustomAbilityRarity.Weight(0, true),
            };

            stickingHomunculus.AddPassives([Passives.Skittish, Passives.GetCustomPassive("TwoFacedRY_PA"), Passives.ParentalGenerator(shedder)]);
            stickingHomunculus.AddEnemyAbilities(
                [
                    gruesomeExcrement,
                    bitterMiasma,
                ]);
            stickingHomunculus.AddEnemy(true, true, false);
        }
    }
}
