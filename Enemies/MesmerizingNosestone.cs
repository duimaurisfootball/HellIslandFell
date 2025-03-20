using BrutalAPI;
using Hell_Island_Fell.Abilities;
using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Passives;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Enemies
{
    public class MesmerizingNosestone
    {
        public static void Add()
        {
            Enemy mesmerizingNosestone = new Enemy("Mesmerizing Nosestone", "MesmerizingNosestone_EN")
            {
                Health = 25,
                HealthColor = Pigments.Purple,
                Size = 1,
                CombatSprite = ResourceLoader.LoadSprite("TimelineMesmerizingNosestone", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("DeadMesmerizingNosestone", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineMesmerizingNosestone", new Vector2(0.5f, 0f), 32),
                DamageSound = "event:/MesmerizingDamage",
                DeathSound = "event:/MesmerizingDeath",
            };
            mesmerizingNosestone.PrepareEnemyPrefab("Assets/MesmerizingNosestoneAssetBundle/MesmerizingNosestone.prefab", Hell_Island_Fell.assetBundle, Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/MesmerizingNosestoneAssetBundle/MesmerizingGibs.prefab").GetComponent<ParticleSystem>());
            mesmerizingNosestone.AddPassives([Passives.Pure, Passives.GetCustomPassive("Grinding_PA")]);

            UnboundedDamageEffect enlightenedDamage = ScriptableObject.CreateInstance<UnboundedDamageEffect>();
            enlightenedDamage._repeatChance = 90;
            enlightenedDamage._cycles = 1;

            Ability eureka = new Ability("Eureka", "Eureka_A")
            {
                Description = "Deal an amount of damage to the Opposing party member.",
                Cost = [Pigments.Purple, Pigments.Purple, Pigments.Purple],
                Visuals = Visuals.Poke,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(enlightenedDamage, 1, Targeting.Slot_Front),
                ],
                Rarity = CustomAbilityRarity.Weight(4, true),
                Priority = Priority.VerySlow,
            };
            eureka.AddIntentsToTarget(Targeting.Slot_Front, ["Damage_Unbounded"]);

            mesmerizingNosestone.AddEnemyAbilities(
                [
                    NosestoneAbilities.Nosing,
                    NosestoneAbilities.Stoning,
                    eureka,
                ]);
            mesmerizingNosestone.AddEnemy(true, false, false);
        }
    }
}

