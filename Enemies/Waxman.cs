using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Enemies
{
    public class Waxman
    {
        public static void Add()
        {
            WaxmanCheckEffect WaxCheck = ScriptableObject.CreateInstance<WaxmanCheckEffect>();
            WaxCheck.m_Threshold = 0;
            WaxCheck.m_unitStoredDataID = "WaxmanStoredValue";

            CasterStoreValueSetterEffect WaxSet = ScriptableObject.CreateInstance<CasterStoreValueSetterEffect>();
            WaxSet.m_unitStoredDataID = "WaxmanStoredValue";

            Enemy waxman = new Enemy("Waxman", "Waxman_BOSS")
            {
                Health = 44,
                HealthColor = Pigments.Red,
                Size = 1,
                CombatSprite = ResourceLoader.LoadSprite("BossWaxmanIcon", new Vector2(0.5f, 0f), 32),
                OverworldDeadSprite = ResourceLoader.LoadSprite("BossWaxmanIcon", new Vector2(0.5f, 0f), 32),
                OverworldAliveSprite = ResourceLoader.LoadSprite("BossWaxmanIcon", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("OsmanRight_BOSS").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("OsmanRight_BOSS").deathSound,
                CombatEnterEffects =
                [
                    Effects.GenerateEffect(WaxCheck, 0, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<AddTurnCasterToTimelineEffect>(), 1, null, Effects.CheckPreviousEffectCondition(true, 1)),
                    Effects.GenerateEffect(WaxSet, 1),
                ],
            };
            waxman.AddPassives([Passives.Skittish, Passives.GetCustomPassive("Otherworldly_PA")]);

            SpecificEnemiesTargeting OpposingWaxman = ScriptableObject.CreateInstance<SpecificEnemiesTargeting>();
            OpposingWaxman._enemies = ["Waxman_BOSS"];
            OpposingWaxman.targetUnitAllySlots = false;
            OpposingWaxman.slotOffsets = [0];

            DamageEffect Damage = ScriptableObject.CreateInstance<DamageEffect>();

            HealEffect Heal = ScriptableObject.CreateInstance<HealEffect>();

            StatusEffect_Apply_Effect RupturedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            RupturedApply._Status = StatusField.Ruptured;

            GenerateRandomManaBetweenEffect DustPigment = ScriptableObject.CreateInstance<GenerateRandomManaBetweenEffect>();
            DustPigment.possibleMana = [Pigments.Red, Pigments.Blue, Pigments.Yellow, Pigments.Purple];

            FieldEffect_Apply_Effect FireApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            FireApply._Field = StatusField.OnFire;

            ConsumeRandomManaEffect LightPigment = ScriptableObject.CreateInstance<ConsumeRandomManaEffect>();

            ChangeMaxHealthEffect MaxHealthIncrease = ScriptableObject.CreateInstance<ChangeMaxHealthEffect>();
            MaxHealthIncrease._increase = true;

            Ability oneTwoFour = new Ability("One-Two-Four", "HIF_OneTwoFour_A")
            {
                Description = "Deal a Painful amount of damage to all party members Opposing Waxman.",
                Cost = [Pigments.Red],
                Visuals = Visuals.Parry,
                AnimationTarget = OpposingWaxman,
                Effects =
                [
                    Effects.GenerateEffect(Damage, 3, OpposingWaxman),
                ],
                Rarity = CustomAbilityRarity.Weight(10, true),
                Priority = Priority.Normal,
            };
            oneTwoFour.AddIntentsToTarget(OpposingWaxman, [nameof(IntentType_GameIDs.Damage_3_6)]);

            Ability spaceDust = new Ability("Space Dust", "HIF_SpaceDust_A")
            {
                Description = "Apply 2 Ruptured to the Opposing party member.\nProduce 3 random pigment.",
                Cost = [Pigments.Blue],
                Visuals = Visuals.Exsanguinate,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(RupturedApply, 2, Targeting.Slot_Front),
                    Effects.GenerateEffect(DustPigment, 3),
                ],
                Rarity = CustomAbilityRarity.Weight(10, true),
                Priority = Priority.Normal,
            };
            spaceDust.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Ruptured)]);
            spaceDust.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Generate)]);

            Ability redLight = new Ability("Red Light", "HIF_RedLight_A")
            {
                Description = "Apply 1 Fire to the Left and Right party member positions.\nConsume 3 random pigment.",
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.Slot_OpponentSides,
                Effects =
                [
                    Effects.GenerateEffect(FireApply, 1, Targeting.Slot_OpponentSides),
                    Effects.GenerateEffect(LightPigment, 3),
                ],
                Rarity = CustomAbilityRarity.Weight(10, true),
                Priority = Priority.Normal,
            };
            redLight.AddIntentsToTarget(Targeting.Slot_OpponentSides, [nameof(IntentType_GameIDs.Field_Fire)]);
            redLight.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);

            Ability brainKillerBeam = new Ability("Brain Killer Beam", "HIF_BrainKillerBeam_A")
            {
                Description = "Increase all enemies' max health.\nHeals all enemies.",
                Cost = [Pigments.Purple],
                Visuals = Visuals.BurningPassion,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(MaxHealthIncrease, 5, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(Heal, 5, Targeting.Unit_AllAllies),
                ],
                Rarity = CustomAbilityRarity.Weight(10, true),
                Priority = Priority.Normal,
            };
            brainKillerBeam.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Heal_5_10), nameof(IntentType_GameIDs.Heal_5_10)]);

            waxman.AddEnemyAbilities(
                [
                    oneTwoFour,
                    spaceDust,
                    redLight,
                    brainKillerBeam,
                ]);
            waxman.AddEnemy(false, false, false);
            LoadedAssetsHandler.GetEnemy("Waxman_BOSS").enemyTemplate = LoadedAssetsHandler.GetEnemy("MusicMan_EN").enemyTemplate;
            string[] waxmanTips =
                [
                    "Waxman might seem weak, but he'll really start soaking up your attacks if you can't take one out in a single blow.",
                    "Watch out for Waxman's brain beam. If they get the chance to use it and there's a lot of them, they'll reverse a serious amount of your progress.",
                    "Even when she's split into a dozen people, Waxman's one-two-four punch is purely reaction. If one uses it, the rest will follow.",
                ];
            LoadedDBsHandler.GameOverDialogueDB.AddBossLinesData("Waxman", waxmanTips);
        }
    }
}
