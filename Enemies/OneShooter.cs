using Hell_Island_Fell.Custom_Effects;
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
                Health = 23,
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

            RandomizeAllColorPigmentEffect YellowToRed = ScriptableObject.CreateInstance<RandomizeAllColorPigmentEffect>();
            YellowToRed._colorToRandomize = Pigments.Yellow;
            YellowToRed._manaRandomOptions = [Pigments.Red];

            RandomizeAllColorPigmentEffect PurpleToBlue = ScriptableObject.CreateInstance<RandomizeAllColorPigmentEffect>();
            PurpleToBlue._colorToRandomize = Pigments.Purple;
            PurpleToBlue._manaRandomOptions = [Pigments.Blue];

            Ability filterFeed = new Ability("Filter Feed", "FilterFeed_A")
            {
                Description = "Consume all stored pigment.\nSet all Inanimate enemies' health color to whatever the most consumed pigment was.",
                Cost = [Pigments.Purple],
                Visuals = Visuals.Devour,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ConsumePigmentChangeHealthColorByGreatestEffect>(), 1, ScriptableObject.CreateInstance<AlliesWithInanimate>()),
                ],
                Rarity = CustomAbilityRarity.Weight(5, true),
                Priority = Priority.VeryFast,
            };
            filterFeed.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);
            filterFeed.AddIntentsToTarget(ScriptableObject.CreateInstance<AlliesWithInanimate>(), [nameof(IntentType_GameIDs.Mana_Randomize)]);

            Ability hyphaticSystem = new Ability("Hyphatic System", "HyphaticSystem_A")
            {
                Description = "Deal a Painful amount of damage to the Opposing party member.\nSet all Inanimate enemies' health to equal the health of the Inanimate enemy with the highest health.",
                Cost = [Pigments.Grey],
                Visuals = Visuals.Innocence,
                AnimationTarget = ScriptableObject.CreateInstance<AlliesWithInanimate>(),
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 4, Targeting.Slot_Front),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<EqualizeHealthUpEffect>(), 4, ScriptableObject.CreateInstance<AlliesWithInanimate>()),
                ],
                Rarity = CustomAbilityRarity.Weight(5, true),
                Priority = Priority.VeryFast,
            };
            hyphaticSystem.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            hyphaticSystem.AddIntentsToTarget(ScriptableObject.CreateInstance<AlliesWithInanimate>(), [nameof(IntentType_GameIDs.Heal_21)]);

            Ability cyanoglobin = new Ability("Cyanoglobin", "Cyanoglobin_A")
            {
                Description = "Turn all stored yellow pigment red and all stored purple pigment blue.\nDeal a little damage to the Left and Right party members.",
                Cost = [Pigments.YellowPurple, Pigments.RedBlue],
                Visuals = Visuals.Leech,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(YellowToRed),
                    Effects.GenerateEffect(PurpleToBlue),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 2, Targeting.Slot_OpponentSides),
                ],
                Rarity = CustomAbilityRarity.Weight(2, true),
                Priority = Priority.Slow,
            };
            cyanoglobin.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Modify)]);
            cyanoglobin.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Modify)]);
            cyanoglobin.AddIntentsToTarget(Targeting.Slot_OpponentSides, [nameof(IntentType_GameIDs.Damage_1_2)]);

            oneShooter.AddEnemyAbilities(
                [
                    filterFeed,
                    hyphaticSystem,
                    cyanoglobin,
                ]);
            oneShooter.AddEnemy(true, true, false);
        }
    }
}
