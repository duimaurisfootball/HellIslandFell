﻿using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Passives;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Enemies
{
    public class VanishingHands
    {
        public static void Add()
        {
            Enemy vanishingHands = new Enemy("Vanishing Hands", "VanishingHands_EN")
            {
                Health = 30,
                HealthColor = Pigments.Red,
                Size = 1,
                CombatSprite = ResourceLoader.LoadSprite("TimelineLegion", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("DeadLegion", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("TimelineLegion", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("TaMaGoa_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("TaMaGoa_EN").damageSound,
                UnitTypes =
                [
                    "HellishID"
                ],
            };
            vanishingHands.PrepareEnemyPrefab("Assets/LegionAssetBundle/Legion.prefab", Hell_Island_Fell.assetBundle, null);
            vanishingHands.AddPassives([CustomPassives.InvincibilityGenerator(10), Passives.Constricting, Passives.Withering, Passives.AbominationGenerator(2)]);

            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Disappearing_ID", out StatusEffect_SO Disappearing);
            StatusEffect_Apply_Effect DisappearingApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            DisappearingApply._Status = Disappearing;

            PercentageEffectCondition Chance0 = ScriptableObject.CreateInstance<PercentageEffectCondition>();
            Chance0.percentage = 25;

            Ability drag = new Ability("Drag", "Drag_A")
            {
                Description = "\"What a nightmare...\"\nApply 1 Disappearing to all party members.",
                Cost = [Pigments.RedPurple],
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(DisappearingApply, 1, Targeting.Unit_AllOpponents),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<CasterSideWitheringEffect>(), 1, null, Chance0),
                ],
                Rarity = CustomAbilityRarity.Weight(1000, true),
                Priority = Priority.ExtremelySlow,
            };
            drag.AddIntentsToTarget(Targeting.Unit_AllOpponents, ["Status_Disappearing"]);

            vanishingHands.AddEnemyAbilities(
                [
                    drag,
                ]);
            vanishingHands.AddEnemy(true, true, true);
        }
    }
}
