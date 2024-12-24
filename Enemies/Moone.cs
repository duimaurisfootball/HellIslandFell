using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using Hell_Island_Fell.Custom_Passives;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Enemies
{
    public class Moone
    {
        public static void Add()
        {
            Enemy moone = new Enemy("Moone", "Moone_EN")
            {
                Health = 20,
                HealthColor = Pigments.Red,
                Size = 1,
                CombatSprite = ResourceLoader.LoadSprite("TimelineMoone", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("DeadMoone", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineMoone", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("GigglingMinister_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("GigglingMinister_EN").deathSound,
                UnitTypes =
                [
                    "HellishID"
                ],
            };
            moone.PrepareEnemyPrefab("Assets/MooneAssetBundles/Moone.prefab", Hell_Island_Fell.assetBundle, Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/MooneAssetBundles/MooneGibs.prefab").GetComponent<ParticleSystem>());
            moone.AddPassives([Passives.Forgetful, Passives.Skittish2, Passives.Slippery, CustomPassives.ConsistentFleetingGenerator(3)]);

            SpawnEnemyAnywhereEffect Demon = ScriptableObject.CreateInstance<SpawnEnemyAnywhereEffect>();
            Demon._spawnTypeID = CombatType_GameIDs.Spawn_Basic.ToString();

            DamageEffect IndirectDamage = ScriptableObject.CreateInstance<DamageEffect>();
            IndirectDamage._indirect = true;

            StatusEffect_Apply_Effect OilApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            OilApply._Status = StatusField.OilSlicked;

            FieldEffect_Apply_Effect FireApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            FireApply._Field = StatusField.OnFire;

            Ability brimstone = new Ability("Brimstone", "Brimstone_A")
            {
                Description = "Apply 1 Fire to the Left, Right, and Opposing party member positions.\nHeal this enemy.",
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Pyre,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(FireApply, 1, Targeting.Slot_FrontAndSides),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 5, Targeting.Slot_SelfSlot),
                ],
                Rarity = CustomAbilityRarity.Weight(3, true),
                Priority = Priority.Normal,
            };
            brimstone.AddIntentsToTarget(Targeting.Slot_FrontAndSides, [nameof(IntentType_GameIDs.Field_Fire)]);
            brimstone.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_5_10)]);

            Ability nightVomit = new Ability("Night Vomit", "NightVomit_A")
            {
                Description = "Apply 2 Oil Slicked to every party member.\nDeal almost no damage to the Opposing party member.",
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Puke,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(OilApply, 2, Targeting.Unit_AllOpponents),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 2, Targeting.Slot_Front),
                ],
                Rarity = CustomAbilityRarity.Weight(2, true),
                Priority = Priority.Normal,
            };
            nightVomit.AddIntentsToTarget(Targeting.Unit_AllOpponents, [nameof(IntentType_GameIDs.Status_OilSlicked)]);
            nightVomit.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_1_2)]);

            Ability hellsClaxon = new Ability("Hell's Claxon", "HellsClaxon_A")
            {
                Description = "Deal almost no indirect damage to the Left and Right party members.\nAttract another Moone.",
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Scream,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(IndirectDamage, 2, Targeting.Slot_OpponentSides),
                    Effects.GenerateEffect(Demon, 1, Targeting.Slot_SelfSlot),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.Normal,
            };
            hellsClaxon.AddIntentsToTarget(Targeting.Slot_OpponentSides, [nameof(IntentType_GameIDs.Damage_1_2)]);
            hellsClaxon.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Spawn)]);

            moone.AddEnemyAbilities(
                [
                    brimstone,
                    nightVomit,
                    hellsClaxon,
                ]);
            moone.AddEnemy(true, true, true);
            Demon.enemy = LoadedAssetsHandler.GetEnemy("Moone_EN");
        }
    }
}
