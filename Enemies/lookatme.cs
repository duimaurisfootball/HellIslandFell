using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Enemies
{
    public class Lookatme
    {
        public static void Add()
        {
            Enemy aaa111aaa111 = new Enemy("8./", "hellislandfell_EN")
            {
                Health = 2000,
                HealthColor = Pigments.Grey,
                Size = 1,
                CombatSprite = ResourceLoader.LoadSprite("aaa111aaa111aaa111__lookatme_lookatme", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("aaa111aaa111aaa111__lookatme_lookatme", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("aaa111aaa111aaa111__lookatme_lookatme", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("Nowak_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("Nowak_CH").damageSound,
            };
            aaa111aaa111.PrepareEnemyPrefab("Assets/aaa111aaa111_lookatme_lookatme.prefab", Hell_Island_Fell.assetBundle, null);
            aaa111aaa111.AddPassives([]);

            CombatEndEffect finish = ScriptableObject.CreateInstance<CombatEndEffect>();
            finish._ignoreAchievements = true;
            finish._ignoreLoot = true;

            Ability ability = new Ability("", "hifability_A")
            {
                Description = "",
                Cost = [],
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<PerformRandomEffectsEffect>(), 138, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(finish, 1, Targeting.Slot_SelfSlot),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.Normal,
            };

            aaa111aaa111.AddEnemyAbilities(
                [
                    ability,
                ]);
            aaa111aaa111.AddEnemy(false, false, false);
        }
    }
}
