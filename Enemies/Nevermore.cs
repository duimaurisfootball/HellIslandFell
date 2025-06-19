using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Enemies
{
    public class Nevermore
    {
        public static void Add()
        {
            Enemy smallNevermore = new Enemy("Nevermore", "Nevermore_Small_EN")
            {
                Health = 80,
                HealthColor = Pigments.Purple,
                Size = 1,
                CombatSprite = ResourceLoader.LoadSprite("TimelineNevermoreSmall", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("TimelineNevermoreSmall", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineNevermoreSmall", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("Xiphactinus_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("Xiphactinus_EN").damageSound,
                CombatExitEffects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<GainLootRandomCharacterEffect>(), 2),
                ],
            };
            smallNevermore.PrepareEnemyPrefab("Assets/NevermoreSmallAssetBundles/NevermoreSmall.prefab", Hell_Island_Fell.assetBundle, null);
            smallNevermore.AddPassives([Passives.InfantileGenerator(12), Passives.CatalystGenerator(12), Passives.Forgetful]);

            Enemy mediumNevermore = new Enemy("Nevermore", "Nevermore_Medium_EN")
            {
                Health = 100,
                HealthColor = Pigments.Purple,
                Size = 2,
                CombatSprite = ResourceLoader.LoadSprite("TimelineNevermoreMedium", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("TimelineNevermoreMedium", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineNevermoreMedium", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("Xiphactinus_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("Xiphactinus_EN").damageSound,
                CombatExitEffects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<GainLootRandomCharacterEffect>(), 2),
                ],
            };
            mediumNevermore.PrepareEnemyPrefab("Assets/NevermoreMediumAssetBundles/NevermoreMedium.prefab", Hell_Island_Fell.assetBundle, null);
            mediumNevermore.AddPassives([Passives.InfantileGenerator(12), Passives.CatalystGenerator(12), Passives.Forgetful]);

            Enemy hugeNevermore = new Enemy("Nevermore", "Nevermore_Huge_EN")
            {
                Health = 120,
                HealthColor = Pigments.Purple,
                Size = 3,
                CombatSprite = ResourceLoader.LoadSprite("TimelineNevermoreHuge", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("TimelineNevermoreHuge", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineNevermoreHuge", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("Xiphactinus_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("Xiphactinus_EN").damageSound,
                CombatExitEffects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<GainLootRandomCharacterEffect>(), 2),
                ],
            };
            hugeNevermore.PrepareEnemyPrefab("Assets/NevermoreHugeAssetBundles/NevermoreHuge.prefab", Hell_Island_Fell.assetBundle, null);
            hugeNevermore.AddPassives([Passives.InfantileGenerator(12), Passives.CatalystGenerator(12), Passives.Forgetful, Passives.GetCustomPassive("TwoFacedPR_PA")]);

            DamageEffect Damage = ScriptableObject.CreateInstance<DamageEffect>();

            FieldEffect_Apply_Effect ConstrictedApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ConstrictedApply._Field = StatusField.Constricted;

            StatusEffect_Apply_Effect DivineProtectionApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            DivineProtectionApply._Status = StatusField.DivineProtection;

            ReturnEnemiesEffect ReturnEffect = ScriptableObject.CreateInstance<ReturnEnemiesEffect>();

            Ability future = new Ability("Future", "HIF_Future_A")
            {
                Description = "Apply 2 Constricted to all allies.\nApply 1 Divine Protection to this enemy.",
                Cost = [Pigments.Purple],
                Visuals = Visuals.Puke,
                AnimationTarget = Targeting.Unit_OtherAllies,
                Effects =
                [
                    Effects.GenerateEffect(ConstrictedApply, 2, Targeting.Unit_OtherAllies),
                    Effects.GenerateEffect(DivineProtectionApply, 1, Targeting.Slot_SelfSlot),
                ],
                Rarity = CustomAbilityRarity.Weight(10, true),
                Priority = Priority.ExtremelyFast,
            };
            future.AddIntentsToTarget(Targeting.Unit_OtherAllies, [nameof(IntentType_GameIDs.Field_Constricted)]);
            future.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Status_DivineProtection)]);

            Ability presence = new Ability("Presence", "HIF_Presence_A")
            {
                Description = "Deal a Deadly amount of damage to the Opposing party member(s).",
                Cost = [Pigments.Purple],
                Visuals = Visuals.Crush,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(Damage, 11, Targeting.Slot_Front),
                ],
                Rarity = CustomAbilityRarity.Weight(10, true),
                Priority = Priority.Normal,
            };
            presence.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_11_15)]);

            Ability history = new Ability("History", "HIF_History_A")
            {
                Description = "Recreate as many enemies that have died this combat and retrieve as many enemies that have fled this combat as possible.",
                Cost = [Pigments.Purple],
                Visuals = Visuals.Exsanguinate,
                AnimationTarget = Targeting.Slot_SelfAll,
                Effects =
                [
                    Effects.GenerateEffect(ReturnEffect, 5, Targeting.Slot_SelfSlot),
                ],
                Rarity = CustomAbilityRarity.Weight(10, true),
                Priority = Priority.ExtremelySlow,
            };
            history.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Other_Resurrect)]);

            smallNevermore.AddEnemyAbilities(
                [
                    future,
                    presence,
                    history,
                ]);
            smallNevermore.AddEnemy(true, false, false);

            mediumNevermore.AddEnemyAbilities(
                [
                    future,
                    presence,
                    history,
                ]);
            mediumNevermore.AddEnemy(true, false, false);

            hugeNevermore.AddEnemyAbilities(
                [
                    future,
                    presence,
                    history,
                ]);
            hugeNevermore.AddEnemy(true, false, false);
        }
    }
}
