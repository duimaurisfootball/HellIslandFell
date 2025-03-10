using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;

namespace Hell_Island_Fell.Enemies
{
    public class Thunderdome
    {
        public static void Add()
        {
            Enemy thunderdome = new Enemy("Thunderdome", "Thunderdome_EN")
            {
                Health = 25,
                HealthColor = Pigments.Blue,
                Size = 1,
                CombatSprite = ResourceLoader.LoadSprite("TimelineThunderdome", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("DeadThunderdome", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineThunderdome", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("WrigglingSacrifice_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("WrigglingSacrifice_EN").deathSound,
            };
            thunderdome.PrepareEnemyPrefab("Assets/ThunderdomeAssetBundles/Thunderdome.prefab", Hell_Island_Fell.assetBundle, Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/ThunderdomeAssetBundles/ThunderdomeGibs.prefab").GetComponent<ParticleSystem>());
            thunderdome.AddPassives([Passives.Skittish, Passives.Forgetful]);

            LoadedDBsHandler.StatusFieldDB.TryGetFieldEffect("Thunderstorm_ID", out FieldEffect_SO Thunderstorm);
            FieldEffect_Apply_Effect ThunderstormApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ThunderstormApply._Field = Thunderstorm;

            DamageOnDoubleCascadeEffect MagnetDamage = ScriptableObject.CreateInstance<DamageOnDoubleCascadeEffect>();
            MagnetDamage._consistentCascade = true;
            MagnetDamage._decreaseAsPercentage = true;
            MagnetDamage._cascadeIsIndirect = true;
            MagnetDamage._cascadeDecrease = 50;

            Ability cyclogenesis = new Ability("Cyclogenesis", "Cyclogenesis_A")
            {
                Description = "Apply 5 Thunderstorm to this position.",
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Connection,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ThunderstormApply, 5, Targeting.Slot_SelfSlot),
                ],
                Rarity = CustomAbilityRarity.Weight(3, true),
                Priority = Priority.VeryFast,
            };
            cyclogenesis.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Field_Thunderstorm"]);

            Ability magnetism = new Ability("Magnetism", "Magnetism_A")
            {
                Description = "Move to the left or right.\nDeal a Painful amount of damage to the Opposing party member.\nDamage spreads indirectly to the Left and Right, even across empty spaces.",
                Cost = [Pigments.Yellow, Pigments.Purple],
                Visuals = Visuals.Contusion,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<SwapToSidesEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(MagnetDamage, 4, ScriptableObject.CreateInstance<AllUnitsAndOpposing>()),
                ],
                Rarity = CustomAbilityRarity.Weight(3, true),
                Priority = Priority.VeryFast,
            };
            magnetism.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Swap_Sides)]);
            magnetism.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            magnetism.AddIntentsToTarget(ScriptableObject.CreateInstance<AllOpponentsButFront>(), [nameof(IntentType_GameIDs.Damage_1_2)]);

            Ability electrons = new Ability("Electrons", "Electrons_A")
            {
                Description = "Apply 1 Thunderstorm to this position.\nDeal a Painful amount of damage to the Far Left and Far Right party members.",
                Cost = [Pigments.Purple, Pigments.Blue],
                Visuals = Visuals.Scream,
                AnimationTarget = Targeting.Slot_OpponentFarSides,
                Effects =
                [
                    Effects.GenerateEffect(ThunderstormApply, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 6, Targeting.Slot_OpponentFarSides),
                ],
                Rarity = CustomAbilityRarity.Weight(3, true),
                Priority = Priority.VeryFast,
            };
            electrons.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Field_Thunderstorm"]);
            electrons.AddIntentsToTarget(Targeting.Slot_OpponentFarSides, [nameof(IntentType_GameIDs.Damage_3_6)]);

            thunderdome.AddEnemyAbilities(
                [
                    cyclogenesis,
                    magnetism,
                    electrons,
                ]);
            thunderdome.AddEnemy(true, true, false);
        }
    }
}
