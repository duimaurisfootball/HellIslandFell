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
    public class Boler
    {
        public static void Add()
        {
            ExtraShopLootByCostEffect CheapLoot = ScriptableObject.CreateInstance<ExtraShopLootByCostEffect>();
            CheapLoot._cost = 3;
            CheapLoot._costsLess = true;

            ExtraShopLootByCostEffect ExpensiveLoot = ScriptableObject.CreateInstance<ExtraShopLootByCostEffect>();
            ExpensiveLoot._cost = 7;
            ExpensiveLoot._costsLess = false;

            Enemy boler = new Enemy("Boler", "Boler_EN")
            {
                Health = 40,
                HealthColor = Pigments.Purple,
                Size = 1,
                CombatSprite = ResourceLoader.LoadSprite("TimelineBoler", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("DeadBoler", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineBoler", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("MiniMordrake_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("MiniMordrake_CH").deathSound,
                UnitTypes =
                [
                    "HellishID"
                ],
                CombatExitEffects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                    Effects.GenerateEffect(CheapLoot, 3, Targeting.Slot_Front, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(ExpensiveLoot, 1, Targeting.Slot_Front, Effects.CheckPreviousEffectCondition(false, 2)),
                ],
            };
            boler.PrepareEnemyPrefab("Assets/BolerAssetBundle/Boler.prefab", Hell_Island_Fell.assetBundle, Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/BolerAssetBundle/BolerGibs.prefab").GetComponent<ParticleSystem>());
            boler.AddPassives([Passives.EssenceUntethered, Passives.Masochism1]);

            StatusEffect_Apply_Effect CursedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            CursedApply._Status = StatusField.Cursed;

            SetStoredManaToColorEffect RandomSet = ScriptableObject.CreateInstance<SetStoredManaToColorEffect>();
            RandomSet.manaRandomOptions = [Pigments.Red, Pigments.Blue, Pigments.Yellow, Pigments.Purple];

            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Disappearing_ID", out StatusEffect_SO Disappearing);
            StatusEffect_Apply_Effect DisappearingApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            DisappearingApply._Status = Disappearing;

            SwapToOneSideEffect SwapLeft = ScriptableObject.CreateInstance<SwapToOneSideEffect>();
            SwapLeft._swapRight = false;

            SwapToOneSideEffect SwapRight = ScriptableObject.CreateInstance<SwapToOneSideEffect>();
            SwapRight._swapRight = true;

            BolerRandomizeEffect CostReduce = ScriptableObject.CreateInstance<BolerRandomizeEffect>();

            Ability stellarGlare = new Ability("Stellar Glare", "StellarGlare_A")
            {
                Description = "Apply Cursed to the Opposing party member.\nTurn all stored pigment into a single random color.\nMove this enemy to the Left or Right.",
                Cost = [Pigments.Purple, Pigments.Purple, Pigments.Yellow],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(CursedApply, 1, Targeting.Slot_Front),
                    Effects.GenerateEffect(RandomSet, 1, Targeting.Slot_Front),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<SwapToSidesEffect>(), 1, Targeting.Slot_SelfSlot),
                ],
                Rarity = CustomAbilityRarity.Weight(4, true),
                Priority = Priority.Fast,
            };
            stellarGlare.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Cursed)]);
            stellarGlare.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Modify)]);
            stellarGlare.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Swap_Sides)]);

            Ability nocturnalCrawl = new Ability("Nocturnal Crawl", "NocturnalCrawl_A")
            {
                Description = "Apply 4 Disappearing to the Opposing party member.\nMove this enemy to the Left.\nRandomize and reduce the Opposing party members' ability costs.",
                Cost = [Pigments.Red, Pigments.Blue],
                Visuals = Visuals.StompLeft,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(DisappearingApply, 4, Targeting.Slot_Front),
                    Effects.GenerateEffect(SwapLeft, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(CostReduce, 1, Targeting.Slot_Front),
                ],
                Rarity = CustomAbilityRarity.Weight(7, true),
                Priority = Priority.Fast,
            };
            nocturnalCrawl.AddIntentsToTarget(Targeting.Slot_Front, ["Status_Disappearing"]);
            nocturnalCrawl.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Swap_Left)]);
            nocturnalCrawl.AddIntentsToTarget(Targeting.Slot_Front, ["Reroll_Cost"]);

            Ability diurnalCreep = new Ability("Diurnal Creep", "DiurnalCreep_A")
            {
                Description = "Apply 4 Disappearing to the Opposing party member.\nMove this enemy to the Right.\nRandomize and reduce the Opposing party members' ability costs.",
                Cost = [Pigments.Red, Pigments.Blue],
                Visuals = Visuals.StompRight,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(DisappearingApply, 4, Targeting.Slot_Front),
                    Effects.GenerateEffect(SwapRight, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(CostReduce, 1, Targeting.Slot_Front),
                ],
                Rarity = CustomAbilityRarity.Weight(7, true),
                Priority = Priority.Fast,
            };
            diurnalCreep.AddIntentsToTarget(Targeting.Slot_Front, ["Status_Disappearing"]);
            diurnalCreep.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Swap_Right)]);
            diurnalCreep.AddIntentsToTarget(Targeting.Slot_Front, ["Reroll_Cost"]);

            boler.AddEnemyAbilities(
                [
                    stellarGlare,
                    nocturnalCrawl,
                    diurnalCreep,
                ]);
            boler.AddEnemy(true, false, false);
        }
    }
}
