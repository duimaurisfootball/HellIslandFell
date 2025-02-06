using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Enemies
{
    public class Keklung
    {
        public static void Add()
        {
            AbilitySO mandibles = LoadedAssetsHandler.GetEnemy("Keko_EN").abilities[0].ability;
            mandibles.priority = Priority.Slow;
            AbilitySO wormyNibble = LoadedAssetsHandler.GetEnemy("Keko_EN").abilities[1].ability;
            wormyNibble.priority = Priority.Slow;

            ExtraAbilityInfo mandiblesExtra = new()
            {
                ability = mandibles,
                rarity = CustomAbilityRarity.Weight(0, true),
            };

            ExtraAbilityInfo wormyNibbleExtra = new()
            {
                ability = wormyNibble,
                rarity = CustomAbilityRarity.Weight(0, true),
            };

            Enemy keklung = new Enemy("Keklung", "Keklung_EN")
            {
                Health = 13,
                HealthColor = Pigments.Red,
                Size = 1,
                CombatSprite = ResourceLoader.LoadSprite("TimelineKeklung", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("DeadKeklung", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineKeklung", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("MudLung_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("MudLung_EN").deathSound,
                UnitTypes =
                [
                    UnitType_GameIDs.Fish.ToString(),
                ],
            };
            keklung.PrepareEnemyPrefab("Assets/KeklungAssetBundle/Keklung.prefab", Hell_Island_Fell.assetBundle, Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/KeklungAssetBundle/KeklungGibs.prefab").GetComponent<ParticleSystem>());
            keklung.AddPassives([CustomPassives.AltAttacksGenerator([mandiblesExtra, wormyNibbleExtra]), Passives.DecayGenerator(LoadedAssetsHandler.GetEnemy("Keko_EN"), 43), Passives.Infestation1]);

            keklung.AddEnemyAbilities(
                [
                    LoadedAssetsHandler.GetEnemy("MudLung_EN").abilities[0],
                    LoadedAssetsHandler.GetEnemy("MudLung_EN").abilities[1],
                ]);
            keklung.AddEnemy(true, true, false);
        }

    }
}
