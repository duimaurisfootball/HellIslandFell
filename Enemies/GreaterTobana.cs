using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Enemies
{
    public class GreaterTobana
    {
        public static void Add()
        {
            Enemy greaterTobana = new Enemy("Greater Tobana", "GreaterTobana_BOSS")
            {
                Health = 130,
                HealthColor = Pigments.Red,
                Size = 4,
                CombatSprite = ResourceLoader.LoadSprite("BossTobanaIcon", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("BossTobanaIcon", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("BossTobanaIcon", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("Xiphactinus_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("Xiphactinus_EN").damageSound,
                UnitTypes =
                [
                    "HellishID"
                ],
            };

            DamageEffect Damage = ScriptableObject.CreateInstance<DamageEffect>();

            SwapToSidesEffect SwapSides = ScriptableObject.CreateInstance<SwapToSidesEffect>();

            HugeCenterTargeting HugeTarget = ScriptableObject.CreateInstance<HugeCenterTargeting>();

            GenerateColorManaEffect GeneratePurple = ScriptableObject.CreateInstance<GenerateColorManaEffect>();
            GeneratePurple.mana = Pigments.Purple;

            FieldEffect_Apply_Effect FireApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            FireApply._Field = StatusField.OnFire;

            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Salted_ID", out StatusEffect_SO Salted);
            StatusEffect_Apply_Effect SaltedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            SaltedApply._Status = Salted;

            StatusEffect_Apply_Effect RupturedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            RupturedApply._Status = StatusField.Ruptured;

            StatusEffect_Apply_Effect FrailApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            FrailApply._Status = StatusField.Frail;

            FieldEffect_Apply_Effect ShieldApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ShieldApply._Field = StatusField.Shield;

            DamageByHealthEffect HighDamage = ScriptableObject.CreateInstance<DamageByHealthEffect>();
            HighDamage._damageWeakest = false;
            HighDamage._indirect = true;

            Ability circles = new Ability("Circles", "HIF_Circles_A")
            {
                Description = "Apply 3 Shield to this enemy's positions.\nProduce 3 purple pigment.",
                Cost = [Pigments.Red, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Crush,
                AnimationTarget = Targeting.Slot_SelfAll,
                Effects =
                [
                    Effects.GenerateEffect(ShieldApply, 3, Targeting.Slot_SelfAll),
                    Effects.GenerateEffect(GeneratePurple, 3, Targeting.Slot_SelfAll),
                ],
                Rarity = CustomAbilityRarity.Weight(3, true),
                Priority = Priority.Normal,
            };
            circles.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Field_Shield), nameof(IntentType_GameIDs.Mana_Generate)]);

            Ability elliptical = new Ability("Elliptical", "HIF_Elliptical_A")
            {
                Description = "Deal a Painful amount of damage to the Opposing Center Left and Opposing Center Right party members.",
                Cost = [Pigments.Red, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Clobber_Left,
                AnimationTarget = Targeting.GenerateBigUnitSlotTarget([1, 2]),
                Effects =
                [
                    Effects.GenerateEffect(Damage, 4, Targeting.GenerateBigUnitSlotTarget([1, 2])),
                ],
                Rarity = CustomAbilityRarity.Weight(4, true),
                Priority = Priority.Normal,
            };
            elliptical.AddIntentsToTarget(Targeting.GenerateBigUnitSlotTarget([1, 2]), [nameof(IntentType_GameIDs.Damage_3_6)]);

            Ability parabola = new Ability("Parabola", "HIF_Parabola_A")
            {
                Description = "Apply 1 Fire to all Opposing positions.",
                Cost = [Pigments.Red, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Burn,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(FireApply, 1, Targeting.Slot_Front),
                ],
                Rarity = CustomAbilityRarity.Weight(4, true),
                Priority = Priority.Normal,
            };
            parabola.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Field_Fire)]);

            Ability hyperbole = new Ability("Hyperbole", "HIF_Hyperbole_A")
            {
                Description = "Apply 10 Salted, 1 Ruptured, and 1 Frail to the Left and Right party members.",
                Cost = [Pigments.Red, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Thorns,
                AnimationTarget = Targeting.Slot_SelfAll,
                Effects =
                [
                    Effects.GenerateEffect(SaltedApply, 10, Targeting.Slot_OpponentSides),
                    Effects.GenerateEffect(RupturedApply, 1, Targeting.Slot_OpponentSides),
                    Effects.GenerateEffect(FrailApply, 1, Targeting.Slot_OpponentSides),
                ],
                Rarity = CustomAbilityRarity.Weight(2, true),
                Priority = Priority.Normal,
            };
            hyperbole.AddIntentsToTarget(Targeting.Slot_OpponentSides, ["Status_Salted", nameof(IntentType_GameIDs.Status_Ruptured), nameof(IntentType_GameIDs.Status_Frail)]);

            Ability singularity = new Ability("Singularity", "HIF_Singularity_A")
            {
                Description = "Apply 8 Shield to this enemy's Center Left and Center Right positions.\nDeal a Painful amount of indirect damage to the highest health party member or enemy.",
                Cost = [Pigments.Red, Pigments.Red, Pigments.Red],
                Visuals = Visuals.Shield,
                AnimationTarget = HugeTarget,
                Effects =
                [
                    Effects.GenerateEffect(ShieldApply, 8, HugeTarget),
                    Effects.GenerateEffect(HighDamage, 5, Targeting.AllUnits),
                ],
                Rarity = CustomAbilityRarity.Weight(10, true),
                Priority = Priority.Normal,
            };
            singularity.AddIntentsToTarget(HugeTarget, [nameof(IntentType_GameIDs.Field_Shield)]);
            singularity.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Damage_3_6)]);
            singularity.AddIntentsToTarget(Targeting.Unit_AllOpponents, [nameof(IntentType_GameIDs.Damage_3_6)]);

            Ability perpendicular = new Ability("Perpendicular", "HIF_Perpendicular_A")
            {
                Description = "Move this enemy to the Left or Right.\nDeal a Painful amount of indirect damage to the highest health party member or enemy.",
                Cost = [Pigments.Red, Pigments.Red, Pigments.Red],
                Visuals = Visuals.DemonCore,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(SwapSides, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(HighDamage, 5, Targeting.AllUnits),
                ],
                Rarity = CustomAbilityRarity.Weight(5, true),
                Priority = Priority.Normal,
            };
            perpendicular.AddIntentsToTarget(Targeting.Slot_SelfAll, [nameof(IntentType_GameIDs.Swap_Sides)]);
            perpendicular.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Damage_3_6)]);
            perpendicular.AddIntentsToTarget(Targeting.Unit_AllOpponents, [nameof(IntentType_GameIDs.Damage_3_6)]);

            ExtraAbilityInfo points = new()
            {
                ability = singularity.GenerateEnemyAbility().ability,
                rarity = CustomAbilityRarity.Weight(10, true),
            };

            ExtraAbilityInfo cross = new()
            {
                ability = perpendicular.GenerateEnemyAbility().ability,
                rarity = CustomAbilityRarity.Weight(5, true),
            };

            greaterTobana.AddEnemyAbilities(
                [
                    circles,
                    elliptical,
                    parabola,
                    hyperbole,
                ]);
            greaterTobana.AddPassives([Passives.Constricting, CustomPassives.AltAttacksGenerator([points, cross])]);
            greaterTobana.AddEnemy(false, false, false);
            LoadedAssetsHandler.GetEnemy("GreaterTobana_BOSS").enemyTemplate = LoadedAssetsHandler.GetEnemy("Flatback_EN").enemyTemplate;
            string[] greaterTobanaTips =
                [
                    "The Tobana is absolutely enormous, and locks your party members in place. Dodging it is just wasted effort.",
                    "Be very careful how you arrange your party members before the fight. You don't get many opportunities to move them around during the fight.",
                    "Careful when the Tobana is almost dead. It'll start whittling down your strongest party members quick if it has less health than them.",
                ];
            LoadedDBsHandler.GameOverDialogueDB.AddBossLinesData("GreaterTobana", greaterTobanaTips);
        }
    }
}
