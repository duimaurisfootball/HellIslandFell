using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Hell_Island_Fell.Fools
{
    public class Nick
    {
        public static void Add()
        {
            ExtraCCSprites_ArraySO HammerSprites = ScriptableObject.CreateInstance<ExtraCCSprites_ArraySO>();
            HammerSprites._doesLoop = true;
            HammerSprites._DefaultID = "NickSpritesLowered";
            HammerSprites._SpecialID = "NickSpritesRaised";
            HammerSprites._frontSprite =
                [
                    ResourceLoader.LoadSprite("NickFrontRaised", new Vector2(0.5f, 0f), 32),
                ];
            HammerSprites._backSprite =
                [
                    ResourceLoader.LoadSprite("NickBackRaised", new Vector2(0.5f, 0f), 32),
                ];

            Character nick = new Character("Nick", "Nick_CH")
            {
                HealthColor = Pigments.Purple,
                UsesBasicAbility = true,
                MovesOnOverworld = true,
                UsesAllAbilities = false,
                FrontSprite = ResourceLoader.LoadSprite("NickFrontLowered", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("NickBackLowered", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("NickOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("Boyle_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("Boyle_CH").deathSound,
                DialogueSound = LoadedAssetsHandler.GetCharacter("Boyle_CH").damageSound,
                ExtraSprites = HammerSprites,
            };
            nick.GenerateMenuCharacter(ResourceLoader.LoadSprite("NickMenu"), ResourceLoader.LoadSprite("NickLocked"));
            nick.AddPassives([Passives.GetCustomPassive("Armed_PA")]);

            CasterStoreValueCheckOverEntryVariableEffect HammerCheck = ScriptableObject.CreateInstance<CasterStoreValueCheckOverEntryVariableEffect>();
            HammerCheck.m_unitStoredDataID = "HammerStoredValue";

            CasterStoreValueSetterEffect HammerSet = ScriptableObject.CreateInstance<CasterStoreValueSetterEffect>();
            HammerSet.m_unitStoredDataID = "HammerStoredValue";

            SetCasterExtraSpritesEffect HammerUp = ScriptableObject.CreateInstance<SetCasterExtraSpritesEffect>();
            HammerUp._ExtraSpriteID = "NickSpritesRaised";

            SetCasterExtraSpritesEffect HammerDown = ScriptableObject.CreateInstance<SetCasterExtraSpritesEffect>();
            HammerDown._ExtraSpriteID = "NickSpritesLowered";

            StatusEffect_Apply_Effect FocusedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            FocusedApply._Status = StatusField.Focused;

            //stance
            Ability stance0 = new Ability("Worrying Stance", "HIFStance_1_A")
            {
                Description = "If the hammer is raised, lower it and apply Focused to this party member.\nIf the hammer is lowered, raise it and reroll one of the Opposing enemy's abilities.",
                AbilitySprite = ResourceLoader.LoadSprite("NickStance"),
                Cost = [Pigments.Yellow, Pigments.Yellow, Pigments.Yellow],
                AnimationTarget = Targeting.Slot_SelfSlot,
                Visuals = Visuals.Parry,
                Effects =
                [
                    Effects.GenerateEffect(HammerCheck, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(HammerUp, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 1)),
                    Effects.GenerateEffect(HammerSet, 2, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 2)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ReRollTargetTimelineAbilityEffect>(), 1, Targeting.Slot_Front, Effects.CheckPreviousEffectCondition(false, 3)),
                    Effects.GenerateEffect(HammerDown, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 4)),
                    Effects.GenerateEffect(HammerSet, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 5)),
                    Effects.GenerateEffect(FocusedApply, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 6)),
                ]
            };
            stance0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Sit)]);
            stance0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Focused)]);
            stance0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Stand)]);
            stance0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Misc)]);

            Ability stance1 = new Ability("Threatening Stance", "HIFStance_2_A")
            {
                Description = "If the hammer is raised, lower it and apply Focused to this party member.\nIf the hammer is lowered, raise it and reroll one of the Opposing enemy's abilities.",
                AbilitySprite = ResourceLoader.LoadSprite("NickStance"),
                Cost = [Pigments.Yellow, Pigments.Yellow],
                AnimationTarget = Targeting.Slot_SelfSlot,
                Visuals = Visuals.Parry,
                Effects =
                [
                    Effects.GenerateEffect(HammerCheck, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(HammerUp, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 1)),
                    Effects.GenerateEffect(HammerSet, 2, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 2)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ReRollTargetTimelineAbilityEffect>(), 1, Targeting.Slot_Front, Effects.CheckPreviousEffectCondition(false, 3)),
                    Effects.GenerateEffect(HammerDown, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 4)),
                    Effects.GenerateEffect(HammerSet, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 5)),
                    Effects.GenerateEffect(FocusedApply, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 6)),
                ],
            };
            stance1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Sit)]);
            stance1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Focused)]);
            stance1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Stand)]);
            stance1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Misc)]);

            Ability stance2 = new Ability("Frightening Stance", "HIFStance_3_A")
            {
                Description = "If the hammer is raised, lower it and apply Focused to this party member.\nIf the hammer is lowered, raise it and reroll one of the Opposing enemy's abilities.",
                AbilitySprite = ResourceLoader.LoadSprite("NickStance"),
                Cost = [Pigments.YellowPurple, Pigments.Yellow],
                AnimationTarget = Targeting.Slot_SelfSlot,
                Visuals = Visuals.Parry,
                Effects =
                [
                    Effects.GenerateEffect(HammerCheck, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(HammerUp, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 1)),
                    Effects.GenerateEffect(HammerSet, 2, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 2)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ReRollTargetTimelineAbilityEffect>(), 1, Targeting.Slot_Front, Effects.CheckPreviousEffectCondition(false, 3)),
                    Effects.GenerateEffect(HammerDown, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 4)),
                    Effects.GenerateEffect(HammerSet, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 5)),
                    Effects.GenerateEffect(FocusedApply, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 6)),
                ]
            };
            stance2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Sit)]);
            stance2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Focused)]);
            stance2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Stand)]);
            stance2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Misc)]);

            Ability stance3 = new Ability("Intimidating Stance", "HIFStance_4_A")
            {
                Description = "If the hammer is raised, lower it and apply Focused to this party member.\nIf the hammer is lowered, raise it and reroll one of the Opposing enemy's abilities.",
                AbilitySprite = ResourceLoader.LoadSprite("NickStance"),
                Cost = [Pigments.YellowPurple, Pigments.YellowPurple],
                AnimationTarget = Targeting.Slot_SelfSlot,
                Visuals = Visuals.Parry,
                Effects =
                [
                    Effects.GenerateEffect(HammerCheck, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(HammerUp, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 1)),
                    Effects.GenerateEffect(HammerSet, 2, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 2)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ReRollTargetTimelineAbilityEffect>(), 1, Targeting.Slot_Front, Effects.CheckPreviousEffectCondition(false, 3)),
                    Effects.GenerateEffect(HammerDown, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 4)),
                    Effects.GenerateEffect(HammerSet, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 5)),
                    Effects.GenerateEffect(FocusedApply, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 6)),
                ]
            };
            stance3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Sit)]);
            stance3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Focused)]);
            stance3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Stand)]);
            stance3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Misc)]);

            //flex
            Ability flex0 = new Ability("Shaky Flex", "HIFFlex_1_A")
            {
                Description = "If the hammer is raised, lower it and deal 4 damage to the Opposing enemy.\nIf the hammer is lowered, raise it and heal this party member and the Left ally 5 health.",
                AbilitySprite = ResourceLoader.LoadSprite("NickFlex"),
                Cost = [Pigments.Blue, Pigments.Blue],
                AnimationTarget = Targeting.Slot_SelfSlot,
                Visuals = Visuals.Flex,
                Effects =
                [
                    Effects.GenerateEffect(HammerCheck, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(HammerUp, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 1)),
                    Effects.GenerateEffect(HammerSet, 2, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 2)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 5, Targeting.Slot_SelfAll_AndLeft, Effects.CheckPreviousEffectCondition(false, 3)),
                    Effects.GenerateEffect(HammerDown, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 4)),
                    Effects.GenerateEffect(HammerSet, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 5)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 4, Targeting.Slot_Front, Effects.CheckPreviousEffectCondition(true, 6)),
                ]
            };
            flex0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Sit)]);
            flex0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            flex0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Stand)]);
            flex0.AddIntentsToTarget(Targeting.Slot_SelfAll_AndLeft, [nameof(IntentType_GameIDs.Heal_5_10)]);

            Ability flex1 = new Ability("Weak Flex", "HIFFlex_2_A")
            {
                Description = "If the hammer is raised, lower it and deal 4 damage to the Opposing enemy.\nIf the hammer is lowered, raise it and heal this party member and the Left ally 7 health.",
                AbilitySprite = ResourceLoader.LoadSprite("NickFlex"),
                Cost = [Pigments.Blue, Pigments.Blue],
                AnimationTarget = Targeting.Slot_SelfSlot,
                Visuals = Visuals.Flex,
                Effects =
                [
                    Effects.GenerateEffect(HammerCheck, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(HammerUp, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 1)),
                    Effects.GenerateEffect(HammerSet, 2, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 2)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 7, Targeting.Slot_SelfAll_AndLeft, Effects.CheckPreviousEffectCondition(false, 3)),
                    Effects.GenerateEffect(HammerDown, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 4)),
                    Effects.GenerateEffect(HammerSet, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 5)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 4, Targeting.Slot_Front, Effects.CheckPreviousEffectCondition(true, 6)),
                ]
            };
            flex1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Sit)]);
            flex1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            flex1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Stand)]);
            flex1.AddIntentsToTarget(Targeting.Slot_SelfAll_AndLeft, [nameof(IntentType_GameIDs.Heal_5_10)]);

            Ability flex2 = new Ability("Powerful Flex", "HIFFlex_3_A")
            {
                Description = "If the hammer is raised, lower it and deal 4 damage to the Opposing enemy.\nIf the hammer is lowered, raise it and heal this party member and the Left ally 9 health.",
                AbilitySprite = ResourceLoader.LoadSprite("NickFlex"),
                Cost = [Pigments.Blue, Pigments.Blue],
                AnimationTarget = Targeting.Slot_SelfSlot,
                Visuals = Visuals.Flex,
                Effects =
                [
                    Effects.GenerateEffect(HammerCheck, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(HammerUp, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 1)),
                    Effects.GenerateEffect(HammerSet, 2, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 2)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 9, Targeting.Slot_SelfAll_AndLeft, Effects.CheckPreviousEffectCondition(false, 3)),
                    Effects.GenerateEffect(HammerDown, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 4)),
                    Effects.GenerateEffect(HammerSet, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 5)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 4, Targeting.Slot_Front, Effects.CheckPreviousEffectCondition(true, 6)),
                ]
            };
            flex2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Sit)]);
            flex2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            flex2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Stand)]);
            flex2.AddIntentsToTarget(Targeting.Slot_SelfAll_AndLeft, [nameof(IntentType_GameIDs.Heal_5_10)]);

            Ability flex3 = new Ability("Rippling Flex", "HIFFlex_4_A")
            {
                Description = "If the hammer is raised, lower it and deal 4 damage to the Opposing enemy.\nIf the hammer is lowered, raise it and heal this party member and the Left ally 11 health.",
                AbilitySprite = ResourceLoader.LoadSprite("NickFlex"),
                Cost = [Pigments.Blue, Pigments.Blue],
                AnimationTarget = Targeting.Slot_SelfSlot,
                Visuals = Visuals.Flex,
                Effects =
                [
                    Effects.GenerateEffect(HammerCheck, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(HammerUp, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 1)),
                    Effects.GenerateEffect(HammerSet, 2, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 2)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 11, Targeting.Slot_SelfAll_AndLeft, Effects.CheckPreviousEffectCondition(false, 3)),
                    Effects.GenerateEffect(HammerDown, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 4)),
                    Effects.GenerateEffect(HammerSet, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 5)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 4, Targeting.Slot_Front, Effects.CheckPreviousEffectCondition(true, 6)),
                ]
            };
            flex3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Sit)]);
            flex3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            flex3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Stand)]);
            flex3.AddIntentsToTarget(Targeting.Slot_SelfAll_AndLeft, [nameof(IntentType_GameIDs.Heal_11_20)]);

            //slam
            Ability slam0 = new Ability("Soft Slam", "HIFSlam_1_A")
            {
                Description = "If the hammer is raised, lower it and deal 8 damage to the Opposing enemy.\nIf the hammer is lowered, raise it and heal this party member and the Left ally 2 health.",
                AbilitySprite = ResourceLoader.LoadSprite("NickSlam"),
                Cost = [Pigments.Red, Pigments.Red],
                AnimationTarget = Targeting.Slot_Front,
                Visuals = Visuals.Crush,
                Effects =
                [
                    Effects.GenerateEffect(HammerCheck, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(HammerUp, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 1)),
                    Effects.GenerateEffect(HammerSet, 2, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 2)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 2, Targeting.Slot_SelfAll_AndLeft, Effects.CheckPreviousEffectCondition(false, 3)),
                    Effects.GenerateEffect(HammerDown, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 4)),
                    Effects.GenerateEffect(HammerSet, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 5)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 8, Targeting.Slot_Front, Effects.CheckPreviousEffectCondition(true, 6)),
                ]
            };
            slam0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Sit)]);
            slam0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);
            slam0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Stand)]);
            slam0.AddIntentsToTarget(Targeting.Slot_SelfAll_AndLeft, [nameof(IntentType_GameIDs.Heal_1_4)]);

            Ability slam1 = new Ability("Iron Slam", "HIFSlam_2_A")
            {
                Description = "If the hammer is raised, lower it and deal 12 damage to the Opposing enemy.\nIf the hammer is lowered, raise it and heal this party member and the Left ally 2 health.",
                AbilitySprite = ResourceLoader.LoadSprite("NickSlam"),
                Cost = [Pigments.Red, Pigments.Red],
                AnimationTarget = Targeting.Slot_Front,
                Visuals = Visuals.Crush,
                Effects =
                [
                    Effects.GenerateEffect(HammerCheck, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(HammerUp, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 1)),
                    Effects.GenerateEffect(HammerSet, 2, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 2)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 2, Targeting.Slot_SelfAll_AndLeft, Effects.CheckPreviousEffectCondition(false, 3)),
                    Effects.GenerateEffect(HammerDown, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 4)),
                    Effects.GenerateEffect(HammerSet, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 5)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 12, Targeting.Slot_Front, Effects.CheckPreviousEffectCondition(true, 6)),
                ]
            };
            slam1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Sit)]);
            slam1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_11_15)]);
            slam1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Stand)]);
            slam1.AddIntentsToTarget(Targeting.Slot_SelfAll_AndLeft, [nameof(IntentType_GameIDs.Heal_1_4)]);

            Ability slam2 = new Ability("Heavy Slam", "HIFSlam_3_A")
            {
                Description = "If the hammer is raised, lower it and deal 16 damage to the Opposing enemy.\nIf the hammer is lowered, raise it and heal this party member and the Left ally 2 health.",
                AbilitySprite = ResourceLoader.LoadSprite("NickSlam"),
                Cost = [Pigments.Red, Pigments.Red],
                AnimationTarget = Targeting.Slot_Front,
                Visuals = Visuals.Crush,
                Effects =
                [
                    Effects.GenerateEffect(HammerCheck, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(HammerUp, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 1)),
                    Effects.GenerateEffect(HammerSet, 2, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 2)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 2, Targeting.Slot_SelfAll_AndLeft, Effects.CheckPreviousEffectCondition(false, 3)),
                    Effects.GenerateEffect(HammerDown, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 4)),
                    Effects.GenerateEffect(HammerSet, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 5)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 16, Targeting.Slot_Front, Effects.CheckPreviousEffectCondition(true, 6)),
                ]
            };
            slam2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Sit)]);
            slam2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_16_20)]);
            slam2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Stand)]);
            slam2.AddIntentsToTarget(Targeting.Slot_SelfAll_AndLeft, [nameof(IntentType_GameIDs.Heal_1_4)]);

            Ability slam3 = new Ability("Heavy Slam", "HIFSlam_4_A")
            {
                Description = "If the hammer is raised, lower it and deal 20 damage to the Opposing enemy.\nIf the hammer is lowered, raise it and heal this party member and the Left ally 2 health.",
                AbilitySprite = ResourceLoader.LoadSprite("NickSlam"),
                Cost = [Pigments.Red, Pigments.Red],
                AnimationTarget = Targeting.Slot_Front,
                Visuals = Visuals.Crush,
                Effects =
                [
                    Effects.GenerateEffect(HammerCheck, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(HammerUp, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 1)),
                    Effects.GenerateEffect(HammerSet, 2, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(false, 2)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 2, Targeting.Slot_SelfAll_AndLeft, Effects.CheckPreviousEffectCondition(false, 3)),
                    Effects.GenerateEffect(HammerDown, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 4)),
                    Effects.GenerateEffect(HammerSet, 1, Targeting.Slot_SelfSlot, Effects.CheckPreviousEffectCondition(true, 5)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 20, Targeting.Slot_Front, Effects.CheckPreviousEffectCondition(true, 6)),
                ]
            };
            slam3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Sit)]);
            slam3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_16_20)]);
            slam3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Misc_State_Stand)]);
            slam3.AddIntentsToTarget(Targeting.Slot_SelfAll_AndLeft, [nameof(IntentType_GameIDs.Heal_1_4)]);

            nick.AddLevelData(13, new Ability[] { stance0, flex0, slam0 });
            nick.AddLevelData(17, new Ability[] { stance1, flex1, slam1 });
            nick.AddLevelData(20, new Ability[] { stance2, flex2, slam2 });
            nick.AddLevelData(23, new Ability[] { stance3, flex3, slam3 });

            nick.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Nick_Witness_ACH");
            nick.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Nick_Divine_ACH");
            nick.AddCharacter(true, false);
        }
    }
}
