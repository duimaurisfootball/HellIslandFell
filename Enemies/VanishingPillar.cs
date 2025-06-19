using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Enemies
{
    public class VanishingPillar
    {
        public static void Add()
        {
            Enemy vanishingPillar = new Enemy("Eighty-Third Vanishing Pillar, Atlas of a Black Flame", "VanishingPillar_BOSS")
            {
                Health = 100,
                HealthColor = Pigments.Red,
                Size = 1,
                CombatSprite = ResourceLoader.LoadSprite("BossVanishingPillarIcon", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("BossVanishingPillarIcon", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("BossVanishingPillarIcon", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("TaMaGoa_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("TaMaGoa_EN").damageSound,
                UnitTypes =
                [
                    "HellishID"
                ],
            };
            vanishingPillar.AddPassives([Passives.GetCustomPassive("Interpolated_PA"), Passives.Slippery, Passives.MultiAttack2]);

            LoadedDBsHandler.StatusFieldDB.TryGetStatusEffect("Disappearing_ID", out StatusEffect_SO Disappearing);
            StatusEffect_Apply_Effect DisappearingApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            DisappearingApply._Status = Disappearing;

            StatusEffect_Apply_Effect OilApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            OilApply._Status = StatusField.OilSlicked;

            StatusEffect_Apply_Effect RupturedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            RupturedApply._Status = StatusField.Ruptured;

            FieldEffect_Apply_Effect ConstrictedApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ConstrictedApply._Field = StatusField.Constricted;

            FieldEffect_Apply_Effect ShieldApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ShieldApply._Field = StatusField.Shield;

            Ability lift = new Ability("Lift", "HIF_Lift_A")
            {
                Description = "Apply 30 Disappearing to the Opposing party member.",
                Cost = [Pigments.Red, Pigments.Yellow, Pigments.Yellow, Pigments.Yellow, Pigments.Yellow, Pigments.Yellow],
                Visuals = Visuals.DemonCore,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(DisappearingApply, 30, Targeting.Slot_Front),
                ],
                Rarity = CustomAbilityRarity.Weight(2, true),
                Priority = Priority.ExtremelyFast,
            };
            lift.AddIntentsToTarget(Targeting.Slot_Front, ["Status_Disappearing"]);

            Ability swirl = new Ability("Swirl", "HIF_Swirl_A")
            {
                Description = "Apply 10 Disappearing to the Left and Right party members.\nApply 2 Oil Slicked to this enemy.",
                Cost = [Pigments.Yellow, Pigments.Yellow, Pigments.Yellow, Pigments.Yellow],
                Visuals = Visuals.Decimate,
                AnimationTarget = Targeting.Slot_OpponentSides,
                Effects =
                [
                    Effects.GenerateEffect(DisappearingApply, 10, Targeting.Slot_OpponentSides),
                    Effects.GenerateEffect(OilApply, 2, Targeting.Slot_SelfSlot),
                ],
                Rarity = CustomAbilityRarity.Weight(4, true),
                Priority = Priority.Normal,
            };
            swirl.AddIntentsToTarget(Targeting.Slot_OpponentSides, ["Status_Disappearing"]);
            swirl.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_OilSlicked)]);

            Ability draw = new Ability("Draw", "HIF_Draw_A")
            {
                Description = "Apply 10 Disappearing to the Far Left and Far Right party members.\nApply 2 Ruptured to this enemy.",
                Cost = [Pigments.Yellow, Pigments.Yellow, Pigments.Yellow, Pigments.Yellow],
                Visuals = Visuals.Decimate,
                AnimationTarget = Targeting.Slot_OpponentFarSides,
                Effects =
                [
                    Effects.GenerateEffect(DisappearingApply, 10, Targeting.Slot_OpponentFarSides),
                    Effects.GenerateEffect(RupturedApply, 2, Targeting.Slot_SelfSlot),
                ],
                Rarity = CustomAbilityRarity.Weight(4, true),
                Priority = Priority.Normal,
            };
            draw.AddIntentsToTarget(Targeting.Slot_OpponentFarSides, ["Status_Disappearing"]);
            draw.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Ruptured)]);

            Ability grip = new Ability("Grip", "HIF_Grip_A")
            {
                Description = "Apply 2 Constricted to the Left and Right party member positions.",
                Cost = [Pigments.Red, Pigments.Yellow, Pigments.Yellow],
                Visuals = Visuals.Resolve,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ConstrictedApply, 2, Targeting.Slot_OpponentSides),
                ],
                Rarity = CustomAbilityRarity.Weight(3, true),
                Priority = Priority.Slow,
            };
            grip.AddIntentsToTarget(Targeting.Slot_OpponentSides, [nameof(IntentType_GameIDs.Field_Constricted)]);

            Ability stay = new Ability("Stay", "HIF_Stay_A")
            {
                Description = "Apply 2 Constricted and 5 Shield to the Left and Right enemy positions.",
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Resolve,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ConstrictedApply, 2, Targeting.Slot_AllySides),
                    Effects.GenerateEffect(ShieldApply, 5, Targeting.Slot_AllySides),
                ],
                Rarity = CustomAbilityRarity.Weight(2, true),
                Priority = Priority.VerySlow,
            };
            stay.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Field_Constricted), nameof(IntentType_GameIDs.Field_Shield)]);

            vanishingPillar.AddEnemyAbilities(
                [
                    lift,
                    swirl,
                    draw,
                    grip,
                    stay
                ]);
            vanishingPillar.AddEnemy(false, false, false);
            LoadedAssetsHandler.GetEnemy("VanishingPillar_BOSS").enemyTemplate = LoadedAssetsHandler.GetEnemy("VanishingHands_EN").enemyTemplate;
            string[] vanishingPillarTips =
                [
                    "Take note that the Pillar is slippery, not skittish. It'll only move around if it's been attacked.",
                    "Remember that you can avoid some of the Disappearing damage if you intentionally constrict yourself. Unfortunately, so can the Pillar.",
                    "The Pillar's Interpolated passive technically prevents damage, anything that works 'if damage was dealt' might not work the way you expect.",
                ];
            LoadedDBsHandler.GameOverDialogueDB.AddBossLinesData("VanishingPillar", vanishingPillarTips);
        }
    }
}
