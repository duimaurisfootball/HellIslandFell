using System;
using System.Collections.Generic;
using System.Text;
using BrutalAPI;
using UnityEngine;
using Hell_Island_Fell.Abilities;
using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using Hell_Island_Fell.Custom_Passives;

namespace Hell_Island_Fell.Enemies
{
    public class SweatingNosestone
    {
        public static void Add()
        {
            Enemy sweatingNosestone = new Enemy("Sweating Nosestone", "SweatingNosestone_EN")
            {
                Health = 25,
                HealthColor = Pigments.Yellow,
                Size = 1,
                CombatSprite = ResourceLoader.LoadSprite("TimelineSweatingNosestone", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("DeadSweatingNosestone", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineSweatingNosestone", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("Spoggle_Spitfire_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("Spoggle_Spitfire_EN").deathSound,
            };
            sweatingNosestone.PrepareEnemyPrefab("Assets/SweatingNosestoneAssetBundle/SweatingNosestone.prefab", Hell_Island_Fell.assetBundle, Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/SweatingNosestoneAssetBundle/SweatingGibs.prefab").GetComponent<ParticleSystem>());
            sweatingNosestone.AddPassives([Passives.Pure, Passives.GetCustomPassive("Grinding_PA"), CustomPassives.WartsGenerator(9)]);

            FieldEffect_Apply_Effect FireApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            FireApply._Field = StatusField.OnFire;

            Ability bloodtears = new Ability("Blood Tears", "BloodTears_A")
            {
                Description = "Apply 7 Fire to the Opposing position.\nDeal an agonizing amount of damage to this enemy.",
                Cost = [Pigments.Yellow, Pigments.Yellow, Pigments.Yellow],
                Visuals = Visuals.Quills,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(FireApply, 7, Targeting.Slot_Front),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 9, Targeting.Slot_SelfSlot),
                ],
                Rarity = CustomAbilityRarity.Weight(4, true),
                Priority = Priority.ExtremelyFast,
            };
            bloodtears.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Field_Fire)]);
            bloodtears.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Damage_7_10)]);

            sweatingNosestone.AddEnemyAbilities(
                [
                    NosestoneAbilities.Nosing,
                    NosestoneAbilities.Stoning,
                    bloodtears,
                ]);
            sweatingNosestone.AddEnemy(true, false, false);
        }
    }
}
