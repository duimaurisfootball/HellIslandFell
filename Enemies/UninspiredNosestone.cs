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
    public class UninspiredNosestone
    {
        public static void Add()
        {
            Enemy uninspiredNosestone = new Enemy("Uninspired Nosestone", "UninspiredNosestone_EN")
            {
                Health = 25,
                HealthColor = Pigments.Grey,
                Size = 1,
                CombatSprite = ResourceLoader.LoadSprite("TimelineUninspiredNosestone", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("DeadUninspiredNosestone", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineUninspiredNosestone", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("Zeitgeist_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("Zeitgeist_EN").deathSound,
            };
            uninspiredNosestone.PrepareEnemyPrefab("Assets/UninspiredNosestoneAssetBundle/UninspiredNosestone.prefab", Hell_Island_Fell.assetBundle, Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/UninspiredNosestoneAssetBundle/UninspiredGibs.prefab").GetComponent<ParticleSystem>());
            uninspiredNosestone.AddPassives([Passives.Pure, Passives.GetCustomPassive("Grinding_PA"), CustomPassives.WartsGenerator(9), Passives.Forgetful]);

            Ability waxandWater = new Ability("Wax and Water", "WaxAndWater_A")
            {
                Description = "Fill the pigment bar with random pigment.",
                Cost = [Pigments.Grey, Pigments.Grey, Pigments.Grey],
                Visuals = Visuals.OilSlicked,
                AnimationTarget = Targeting.Unit_AllOpponentSlots,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<FillPigmentBarRandomManaEffect>(), 1, Targeting.Slot_SelfSlot),
                ],
                Rarity = CustomAbilityRarity.Weight(6, true),
                Priority = Priority.ExtremelyFast,
            };
            waxandWater.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Generate)]);

            uninspiredNosestone.AddEnemyAbilities(
                [
                    NosestoneAbilities.Nosing,
                    NosestoneAbilities.Stoning,
                    waxandWater,
                ]);
            uninspiredNosestone.AddEnemy(true, false, false);
        }
    }
}
