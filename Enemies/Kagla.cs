using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Enemies
{
    public class Kagla
    {
        public static void Add()
        {
            Enemy kagla = new Enemy("Kagla", "Kagla_BOSS")
            {
                Health = 66,
                HealthColor = Pigments.Red,
                Size = 1,
                CombatSprite = ResourceLoader.LoadSprite("BossKaglaIcon", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("BossKaglaIcon", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("BossKaglaIcon", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("Clive_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("Clive_CH").damageSound,
            };

            DamageEffect Damage = ScriptableObject.CreateInstance<DamageEffect>();

            HealEffect Heal = ScriptableObject.CreateInstance<HealEffect>();

            StatusEffect_Apply_Effect RupturedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            RupturedApply._Status = StatusField.Ruptured;

            StatusEffect_Apply_Effect ScarsApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            ScarsApply._Status = StatusField.Scars;

            RemoveStatusEffectEffect CursedRemove = ScriptableObject.CreateInstance<RemoveStatusEffectEffect>();
            CursedRemove._status = StatusField.Cursed;

            StatusEffectCheckerEffect CursedCheck = ScriptableObject.CreateInstance<StatusEffectCheckerEffect>();
            CursedCheck._allTargetsHaveStatusEffect = true;
            CursedCheck._status = StatusField.Cursed;

            StatusEffect_ApplyToOneWithout_Effect CursedApply = ScriptableObject.CreateInstance<StatusEffect_ApplyToOneWithout_Effect>();
            CursedApply._Status = StatusField.Cursed;

            FieldEffect_Apply_Effect ShieldApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ShieldApply._Field = StatusField.Shield;

            Ability evilPunch = new Ability("Evil Punch", "HIF_EvilPunch_A")
            {
                Description = "Deal a Painful amount of damage to the Opposing party member.\nRemove Curse from the Opposing party member.",
                Cost = [Pigments.Purple, Pigments.Purple, Pigments.Purple],
                Visuals = Visuals.Clobber_Right,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(Damage, 6, Targeting.Slot_Front),
                    Effects.GenerateEffect(CursedRemove, 1, Targeting.Slot_Front),
                ],
                Rarity = CustomAbilityRarity.Weight(15, true),
                Priority = Priority.Normal,
            };
            evilPunch.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6), nameof(IntentType_GameIDs.Rem_Status_Cursed)]);

            Ability deadlyVirtue = new Ability("Deadly Virtue", "HIF_DeadlyVirtue_A")
            {
                Description = "Apply 3 Ruptured and 1 Scar to the Opposing party member.\nRemove Curse from the Opposing party member.\nApply 4 Shield to this and the Left and Right enemy positions.",
                Cost = [Pigments.Purple, Pigments.Purple, Pigments.Purple],
                Visuals = Visuals.RendRight,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(RupturedApply, 3, Targeting.Slot_Front),
                    Effects.GenerateEffect(ScarsApply, 1, Targeting.Slot_Front),
                    Effects.GenerateEffect(CursedRemove, 1, Targeting.Slot_Front),
                    Effects.GenerateEffect(ShieldApply, 4, Targeting.Slot_SelfAll_AndSides),
                ],
                Rarity = CustomAbilityRarity.Weight(10, true),
                Priority = Priority.Normal,
            };
            deadlyVirtue.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Ruptured), nameof(IntentType_GameIDs.Status_Scars), nameof(IntentType_GameIDs.Rem_Status_Cursed)]);
            deadlyVirtue.AddIntentsToTarget(Targeting.Slot_SelfAll_AndSides, [nameof(IntentType_GameIDs.Field_Shield)]);

            Ability temptation = new Ability("Temptation", "HIF_Temptation_A")
            {
                Description = "Heal the Opposing party member.\nRemove Curse from the Opposing party member.\nApply 4 Shield to this and the Left and Right enemy positions.",
                Cost = [Pigments.Purple, Pigments.Purple, Pigments.Purple],
                Visuals = Visuals.MotherlyLove,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(Heal, 10, Targeting.Slot_Front),
                    Effects.GenerateEffect(CursedRemove, 1, Targeting.Slot_Front),
                    Effects.GenerateEffect(ShieldApply, 4, Targeting.Slot_SelfAll_AndSides),
                ],
                Rarity = CustomAbilityRarity.Weight(5, true),
                Priority = Priority.Normal,
            };
            temptation.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Heal_5_10), nameof(IntentType_GameIDs.Rem_Status_Cursed)]);
            temptation.AddIntentsToTarget(Targeting.Slot_SelfAll_AndSides, [nameof(IntentType_GameIDs.Field_Shield)]);

            Ability inThePresenceOfSin = new Ability("In The Presence Of Sin", "HIF_InThePresenceOfSin_A")
            {
                Description = "If all party members are Cursed, deal a Deadly amount of damage to all party members.\nCurse a random party member.",
                Cost = [Pigments.Purple, Pigments.Purple, Pigments.Purple, Pigments.Purple, Pigments.Purple, Pigments.Purple],
                Visuals = Visuals.Clobber_Right,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(CursedCheck, 1, Targeting.Unit_AllOpponents),
                    Effects.GenerateEffect(Damage, 15, Targeting.Unit_AllOpponents, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(CursedApply, 1, Targeting.Unit_AllOpponents),
                ],
                Rarity = CustomAbilityRarity.Weight(5, true),
                Priority = Priority.Normal,
            };
            inThePresenceOfSin.AddIntentsToTarget(Targeting.Unit_AllOpponents, [nameof(IntentType_GameIDs.Damage_11_15), nameof(IntentType_GameIDs.Status_Cursed)]);

            ExtraAbilityInfo sins = new()
            {
                ability = inThePresenceOfSin.GenerateEnemyAbility().ability,
                rarity = CustomAbilityRarity.Weight(0, true),
            };

            kagla.AddEnemyAbilities(
                [
                    evilPunch,
                    deadlyVirtue,
                    temptation,
                ]);

            kagla.AddPassives([Passives.GetCustomPassive("Sacrilege_PA"), CustomPassives.InvincibilityGenerator(5), Passives.BonusAttackGenerator(sins)]);
            kagla.AddEnemy(false, false, false);
            LoadedAssetsHandler.GetEnemy("Kagla_BOSS").enemyTemplate = LoadedAssetsHandler.GetEnemy("Thunderdome_EN").enemyTemplate;
            string[] kaglaTips =
                [
                    "If you're running low on pigment, you can't rely on slapping Kagla. His Invincible passive makes him immune to very weak attacks.",
                    "Sometimes you gotta take a hit to get rid of the Curse. Otherwise, you're gonna be in way over your head.",
                    "If all of your party members get Cursed, you're screwed. So, don't do that.",
                ];
            LoadedDBsHandler.GameOverDialogueDB.AddBossLinesData("Kagla", kaglaTips);
        }
    }
}
