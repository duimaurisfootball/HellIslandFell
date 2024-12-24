using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Enemies
{
    public class DivineGlass
    {
        public static void Add()
        {
            Enemy divineGlass = new Enemy("Divine Glass", "DivineGlass_EN")
            {
                Health = 5,
                HealthColor = Pigments.Blue,
                Size = 1,
                CombatSprite = ResourceLoader.LoadSprite("TimelineDivineGlass", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("DeadDivineGlass", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineDivineGlass", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("Gospel_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("Gospel_CH").deathSound,
            };
            divineGlass.PrepareEnemyPrefab("Assets/DivineGlassAssetBundle/DivineGlass.prefab", Hell_Island_Fell.assetBundle, null);
            divineGlass.AddPassives([Passives.Immortal, Passives.Withering]);

            divineGlass.AddEnemyAbilities(new EnemyAbilityInfo[0]);
            divineGlass.AddEnemy(true, false, true);
        }
    }
}
