using BrutalAPI;
using Hell_Island_Fell.Custom_Stuff;
using UnityEngine;

namespace Hell_Island_Fell.Enemies
{
    public class Flatback
    {
        public static void Add()
        {
            Enemy flatback = new Enemy("Flatback", "Flatback_EN")
            {
                Health = 32,
                HealthColor = Pigments.Red,
                Size = 3,
                CombatSprite = ResourceLoader.LoadSprite("TimelineFlatback", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("DeadFlatback", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineFlatback", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("Flarblet_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("Flarblet_EN").deathSound,
                UnitTypes =
                [
                    UnitType_GameIDs.Fish.ToString(),
                ],
            };
            flatback.PrepareEnemyPrefab("Assets/FlatbackAssetBundle/Flatback.prefab", Hell_Island_Fell.assetBundle, Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/FlatbackAssetBundle/FlatbackGibs.prefab").GetComponent<ParticleSystem>());
            flatback.AddPassives([Passives.MultiAttack2]);

            StatusEffect_Apply_Effect RuptureApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            RuptureApply._Status = StatusField.Ruptured;

            SwapToOneSideEffect SwapRight = ScriptableObject.CreateInstance<SwapToOneSideEffect>();
            SwapRight._swapRight = true;

            SwapToOneSideEffect SwapLeft = ScriptableObject.CreateInstance<SwapToOneSideEffect>();
            SwapLeft._swapRight = false;

            Ability sting = new Ability("Sting", "Sting_A")
            {
                Description = "Apply 2 Ruptured to the Center Opposing enemy.\nMove the Center Opposing party member to the Left or Right.",
                Cost = [Pigments.RedPurple],
                Visuals = Visuals.Exsanguinate,
                AnimationTarget = Targeting.GenerateBigUnitSlotTarget([1]),
                Effects =
                [
                    Effects.GenerateEffect(RuptureApply, 2, Targeting.GenerateBigUnitSlotTarget([1])),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<SwapToSidesEffect>(), 1, Targeting.GenerateBigUnitSlotTarget([1])),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.Normal,
            };
            sting.AddIntentsToTarget(Targeting.GenerateBigUnitSlotTarget([1]), [nameof(IntentType_GameIDs.Status_Ruptured)]);
            sting.AddIntentsToTarget(Targeting.GenerateBigUnitSlotTarget([1]), [nameof(IntentType_GameIDs.Swap_Sides)]);

            Ability claw = new Ability("Claw", "Claw_A")
            {
                Description = "Deal a Painful amount of damage to the Left Opposing party member.\nMove the Left Opposing party member to the right.",
                Cost = [Pigments.Red, Pigments.Red],
                Visuals = Visuals.Crush,
                AnimationTarget = Targeting.GenerateBigUnitSlotTarget([0]),
                Effects =
                [
                    Effects.GenerateEffect(RuptureApply, 2, Targeting.GenerateBigUnitSlotTarget([0])),
                    Effects.GenerateEffect(SwapRight, 1, Targeting.GenerateBigUnitSlotTarget([0])),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.Normal,
            };
            claw.AddIntentsToTarget(Targeting.GenerateBigUnitSlotTarget([0]), [nameof(IntentType_GameIDs.Damage_3_6)]);
            claw.AddIntentsToTarget(Targeting.GenerateBigUnitSlotTarget([0]), [nameof(IntentType_GameIDs.Swap_Right)]);

            Ability pinch = new Ability("Pinch", "Pinch_A")
            {
                Description = "Deal a Painful amount of damage to the Right Opposing party member.\nMove the Right Opposing party member to the left.",
                Cost = [Pigments.Red, Pigments.Red],
                Visuals = Visuals.Crush,
                AnimationTarget = Targeting.GenerateBigUnitSlotTarget([2]),
                Effects =
                [
                    Effects.GenerateEffect(RuptureApply, 2, Targeting.GenerateBigUnitSlotTarget([2])),
                    Effects.GenerateEffect(SwapLeft, 1, Targeting.GenerateBigUnitSlotTarget([2])),
                ],
                Rarity = CustomAbilityRarity.Weight(1, true),
                Priority = Priority.Normal,
            };
            pinch.AddIntentsToTarget(Targeting.GenerateBigUnitSlotTarget([2]), [nameof(IntentType_GameIDs.Damage_3_6)]);
            pinch.AddIntentsToTarget(Targeting.GenerateBigUnitSlotTarget([2]), [nameof(IntentType_GameIDs.Swap_Left)]);

            flatback.AddEnemyAbilities(
                [
                    sting,
                    claw,
                    pinch,
                ]);
            flatback.AddEnemy(true, true, false);
        }
    }
}
