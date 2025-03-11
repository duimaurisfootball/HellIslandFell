using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Enemies
{
    public class OneShooter
    {
        public static void Add()
        {
            Enemy oneShooter = new Enemy("One Shooter", "OneShooter_EN")
            {
                Health = 17,
                HealthColor = Pigments.Red,
                Size = 1,
                CombatSprite = ResourceLoader.LoadSprite("TimelineOneShooter", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("DeadOneShooter", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineOneShooter", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("LongLiver_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("LongLiver_CH").deathSound,
            };
            oneShooter.PrepareEnemyPrefab("Assets/OneShooterAssetBundle/OneShooter.prefab", Hell_Island_Fell.assetBundle, Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/OneShooterAssetBundle/OneShooterGibs.prefab").GetComponent<ParticleSystem>());
            oneShooter.AddPassives([Passives.Dying, Passives.Obscure, Passives.Anchored]);

            Ability filterFeed = new Ability("Filter Feed", "FilterFeed_A")
            {
                Description = "Apply 3 Salted to all party members.",
                Cost = [Pigments.Purple],
                Visuals = Visuals.Devour,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                ],
                Rarity = CustomAbilityRarity.Weight(3, true),
                Priority = Priority.Fast,
            };
            filterFeed.AddIntentsToTarget(Targeting.Unit_AllOpponents, ["Status_Salted"]);

            oneShooter.AddEnemyAbilities(
                [
                    filterFeed,
                ]);
            oneShooter.AddEnemy(true, true, false);
        }
    }
}
