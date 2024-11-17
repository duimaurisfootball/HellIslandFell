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
    public class ScatterbrainedNosestone
    {
        public static void Add()
        {
            Enemy scatterbrainedNosestone = new Enemy("Scatterbrained Nosestone", "ScatterbrainedNosestone_EN")
            {
                Health = 25,
                HealthColor = Pigments.Blue,
                Size = 1,
                CombatSprite = ResourceLoader.LoadSprite("TimelineScatterbrainedNosestone", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("DeadScatterbrainedNosestone", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineScatterbrainedNosestone", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("Spoggle_Ruminating_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("Spoggle_Ruminating_EN").deathSound,
            };
            scatterbrainedNosestone.PrepareEnemyPrefab("Assets/ScatterbrainedNosestoneAssetBundle/ScatterbrainedNosestone.prefab", Hell_Island_Fell.assetBundle, Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/ScatterbrainedNosestoneAssetBundle/ScatterbrainedGibs.prefab").GetComponent<ParticleSystem>());
            scatterbrainedNosestone.AddPassives([Passives.Pure, Passives.GetCustomPassive("Grinding_PA"), CustomPassives.WartsGenerator(9)]);

            Ability printCut = new Ability("Print Cut", "PrintCut_A")
            {
                Description = "Increase the amount of pigment lucky pigment produces by 1.",
                Cost = [Pigments.Blue, Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Cry,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<LuckyBlueAmountSetEffect>(), 1, Targeting.Unit_AllAllies),
                ],
                Rarity = CustomAbilityRarity.Weight(4, true),
                Priority = Priority.VerySlow,
            };
            printCut.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc)]);

            scatterbrainedNosestone.AddEnemyAbilities(
                [
                    NosestoneAbilities.Nosing,
                    NosestoneAbilities.Stoning,
                    printCut,
                ]);
            scatterbrainedNosestone.AddEnemy(true, false, false);
        }
    }
}
