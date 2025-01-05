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

            PercentageEffectCondition ChangeChance = ScriptableObject.CreateInstance<PercentageEffectCondition>();
            ChangeChance.percentage = 17;

            PercentageEffectCondition RichChance = ScriptableObject.CreateInstance<PercentageEffectCondition>();
            RichChance.percentage = 50;

            PreviousEffectCondition Fail = ScriptableObject.CreateInstance<PreviousEffectCondition>();
            Fail.wasSuccessful = false;
            Fail.previousAmount = 2;

            Enemy boler = new Enemy("Boler", "Boler_EN")
            {
                Health = 50,
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
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1, Targeting.Slot_SelfSlot, RichChance),
                    Effects.GenerateEffect(CheapLoot, 3, Targeting.Slot_Front, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(ExpensiveLoot, 1, Targeting.Slot_Front, Fail),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ChaosLootReplaceEffect>(), 5, Targeting.Slot_Front, ChangeChance),
                ],
            };
            boler.PrepareEnemyPrefab("Assets/BolerAssetBundle/Boler.prefab", Hell_Island_Fell.assetBundle, Hell_Island_Fell.assetBundle.LoadAsset<GameObject>("Assets/BolerAssetBundle/BolerGibs.prefab").GetComponent<ParticleSystem>());
            boler.AddPassives([Passives.EssenceUntethered, Passives.MultiAttack3, Passives.Masochism1, Passives.GetCustomPassive("Disruption_PA")]);

            StatusEffect_Apply_Effect CursedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            CursedApply._Status = StatusField.Cursed;

            SetStoredManaToColorEffect RandomSet = ScriptableObject.CreateInstance<SetStoredManaToColorEffect>();
            RandomSet.manaRandomOptions = [Pigments.Red, Pigments.Blue, Pigments.Yellow, Pigments.Purple];

            GenerateColorManaEffect YellowSpit = ScriptableObject.CreateInstance<GenerateColorManaEffect>();
            YellowSpit.mana = Pigments.Yellow;

            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Disappearing_ID", out StatusEffect_SO Disappearing);
            StatusEffect_Apply_Effect DisappearingApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            DisappearingApply._Status = Disappearing;

            SwapToOneSideEffect SwapLeft = ScriptableObject.CreateInstance<SwapToOneSideEffect>();
            SwapLeft._swapRight = false;

            SwapToOneSideEffect SwapRight = ScriptableObject.CreateInstance<SwapToOneSideEffect>();
            SwapRight._swapRight = true;

            ChangeToRandomHealthColorEffect RandomHealth = ScriptableObject.CreateInstance<ChangeToRandomHealthColorEffect>();
            RandomHealth._healthColors = [Pigments.Red, Pigments.Blue, Pigments.Yellow, Pigments.Purple, Pigments.Grey];

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
                Description = "Produce 1 yellow pigment.\nApply 4 Disappearing to the Opposing party member.\nMove this enemy to the Left.\nRandomize the Right enemy's health color.",
                Cost = [Pigments.Red, Pigments.Blue],
                Visuals = Visuals.StompLeft,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(YellowSpit, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(DisappearingApply, 4, Targeting.Slot_Front),
                    Effects.GenerateEffect(SwapLeft, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(RandomHealth, 1, Targeting.Slot_AllyRight),
                ],
                Rarity = CustomAbilityRarity.Weight(7, true),
                Priority = Priority.Fast,
            };
            nocturnalCrawl.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Mana_Generate)]);
            nocturnalCrawl.AddIntentsToTarget(Targeting.Slot_Front, ["Status_Disappearing"]);
            nocturnalCrawl.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Swap_Left)]);
            nocturnalCrawl.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Mana_Modify)]);

            Ability diurnalCreep = new Ability("Diurnal Creep", "DiurnalCreep_A")
            {
                Description = "Produce 1 yellow pigment.\nApply 4 Disappearing to the Opposing party member.\nMove this enemy to the Right.\nRandomize the Left enemy's health color.",
                Cost = [Pigments.Red, Pigments.Blue],
                Visuals = Visuals.StompRight,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(YellowSpit, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(DisappearingApply, 4, Targeting.Slot_Front),
                    Effects.GenerateEffect(SwapRight, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(RandomHealth, 1, Targeting.Slot_AllyLeft),
                ],
                Rarity = CustomAbilityRarity.Weight(7, true),
                Priority = Priority.Fast,
            };
            diurnalCreep.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Mana_Generate)]);
            diurnalCreep.AddIntentsToTarget(Targeting.Slot_Front, ["Status_Disappearing"]);
            diurnalCreep.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Swap_Right)]);
            diurnalCreep.AddIntentsToTarget(Targeting.Slot_AllyLeft, [nameof(IntentType_GameIDs.Mana_Modify)]);

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
