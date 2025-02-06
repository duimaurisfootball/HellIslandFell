using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Fools
{
    public class Naba
    {
        public static void Add()
        {
            StatusEffect_Apply_Effect DivineApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            DivineApply._Status = StatusField.DivineProtection;

            Ability contrition = new Ability("Contrition", "Contrition_A")
            {
                Description = "Deal 1 damage to the Opposing enemy.\nApply 2 Divine Protection to the Opposing enemy.",
                AbilitySprite = ResourceLoader.LoadSprite("NabaContrition"),
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Slap,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 1, Targeting.Slot_Front),
                    Effects.GenerateEffect(DivineApply, 2, Targeting.Slot_Front),
                ]
            };
            contrition.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_1_2)]);
            contrition.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_DivineProtection)]);

            Character naba = new Character("Naba", "Naba_CH")
            {
                HealthColor = Pigments.Purple,
                UsesBasicAbility = true,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("NabaFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("NabaBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("NabaOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("Rags_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("Rags_CH").deathSound,
                DialogueSound = LoadedAssetsHandler.GetCharacter("Rags_CH").dxSound,
                BasicAbility = contrition,
                UnitTypes =
                [
                    "FemaleID",
                ],
            };
            naba.GenerateMenuCharacter(ResourceLoader.LoadSprite("NabaMenu"), ResourceLoader.LoadSprite("NabaLocked"));
            naba.AddPassives([Passives.GetCustomPassive("Conviction_PA")]);
            naba.SetMenuCharacterAsFullSupport();

            StatusEffect_Apply_Effect FocusedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            FocusedApply._Status = StatusField.Focused;

            //crown
            Ability crown0 = new Ability("Crown of Pins", "Crown_1_A")
            {
                Description = "Heal 10 health split randomly between all party members.\nDeal 8 damage split randomly between the Left and Right allies.",
                AbilitySprite = ResourceLoader.LoadSprite("NabaCrown"),
                Cost = [Pigments.Yellow, Pigments.Blue],
                Visuals = Visuals.Thorns,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealRandomSplitBetweenEntryEffect>(), 10, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageRandomSplitBetweenEntryEffect>(), 8, Targeting.Slot_AllySides),
                ]
            };
            crown0.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Heal_11_20)]);
            crown0.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Damage_7_10)]);

            Ability crown1 = new Ability("Crown of Stakes", "Crown_2_A")
            {
                Description = "Heal 15 health split randomly between all party members.\nDeal 8 damage split randomly between the Left and Right allies.",
                AbilitySprite = ResourceLoader.LoadSprite("NabaCrown"),
                Cost = [Pigments.Yellow, Pigments.Blue],
                Visuals = Visuals.Thorns,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealRandomSplitBetweenEntryEffect>(), 15, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageRandomSplitBetweenEntryEffect>(), 8, Targeting.Slot_AllySides),
                ]
            };
            crown1.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Heal_11_20)]);
            crown1.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Damage_7_10)]);

            Ability crown2 = new Ability("Crown of Thorns", "Crown_3_A")
            {
                Description = "Heal 20 health split randomly between all party members.\nDeal 8 damage split randomly between the Left and Right allies.",
                AbilitySprite = ResourceLoader.LoadSprite("NabaCrown"),
                Cost = [Pigments.Yellow, Pigments.Blue],
                Visuals = Visuals.Thorns,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealRandomSplitBetweenEntryEffect>(), 20, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageRandomSplitBetweenEntryEffect>(), 8, Targeting.Slot_AllySides),
                ]
            };
            crown2.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Heal_11_20)]);
            crown2.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Damage_7_10)]);

            Ability crown3 = new Ability("Crown of Crowns", "Crown_4_A")
            {
                Description = "Heal 30 health split randomly between all party members.\nDeal 8 damage split randomly between the Left and Right allies.",
                AbilitySprite = ResourceLoader.LoadSprite("NabaCrown"),
                Cost = [Pigments.Yellow, Pigments.Blue],
                Visuals = Visuals.Thorns,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealRandomSplitBetweenEntryEffect>(), 30, Targeting.Unit_AllAllies),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageRandomSplitBetweenEntryEffect>(), 8, Targeting.Slot_AllySides),
                ]
            };
            crown3.AddIntentsToTarget(Targeting.Unit_AllAllies, [nameof(IntentType_GameIDs.Heal_21)]);
            crown3.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Damage_7_10)]);

            //revelation
            Ability revelation0 = new Ability("A Revelation", "Revelation_1_A")
            {
                Description = "Deal 8 damage to the Right ally.\nHeal the Right ally 4 health.\nRefresh the Left and Right allies and restore their movement.",
                AbilitySprite = ResourceLoader.LoadSprite("NabaRevelation"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Burn,
                AnimationTarget = Targeting.Slot_AllySides,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 8, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 4, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 1, Targeting.Slot_AllySides),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RestoreSwapUseEffect>(), 1, Targeting.Slot_AllySides),
                ]
            };
            revelation0.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Damage_7_10)]);
            revelation0.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Heal_1_4)]);
            revelation0.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability revelation1 = new Ability("The Revelation", "Revelation_2_A")
            {
                Description = "Deal 7 damage to the Right ally.\nHeal the Right ally 4 health.\nRefresh the Left and Right allies and restore their movement.",
                AbilitySprite = ResourceLoader.LoadSprite("NabaRevelation"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Burn,
                AnimationTarget = Targeting.Slot_AllySides,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 7, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 4, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 1, Targeting.Slot_AllySides),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RestoreSwapUseEffect>(), 1, Targeting.Slot_AllySides),
                ]
            };
            revelation1.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Damage_7_10)]);
            revelation1.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Heal_1_4)]);
            revelation1.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability revelation2 = new Ability("And Revelation", "Revelation_3_A")
            {
                Description = "Deal 6 damage to the Right ally.\nHeal the Right ally 4 health.\nRefresh the Left and Right allies and restore their movement.",
                AbilitySprite = ResourceLoader.LoadSprite("NabaRevelation"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Burn,
                AnimationTarget = Targeting.Slot_AllySides,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 6, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 4, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 1, Targeting.Slot_AllySides),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RestoreSwapUseEffect>(), 1, Targeting.Slot_AllySides),
                ]
            };
            revelation2.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Damage_3_6)]);
            revelation2.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Heal_1_4)]);
            revelation2.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability revelation3 = new Ability("Revelations", "Revelation_4_A")
            {
                Description = "Deal 5 damage to the Right ally.\nHeal the Right ally 4 health.\nRefresh the Left and Right allies and restore their movement.",
                AbilitySprite = ResourceLoader.LoadSprite("NabaRevelation"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Burn,
                AnimationTarget = Targeting.Slot_AllySides,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 5, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 4, Targeting.Slot_AllyRight),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RefreshAbilityUseEffect>(), 1, Targeting.Slot_AllySides),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<RestoreSwapUseEffect>(), 1, Targeting.Slot_AllySides),
                ]
            };
            revelation3.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Damage_3_6)]);
            revelation3.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Heal_1_4)]);
            revelation3.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Other_Refresh)]);

            //two prayers
            Ability twoPrayers0 = new Ability("Two Prayers for the Ill", "TwoPrayers_1_A")
            {
                Description = "Deal 8 damage to the Left ally.\nHeal the Left ally 4 health.\nApply Focused to the Left and Right allies.",
                AbilitySprite = ResourceLoader.LoadSprite("NabaTwoPrayers"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.MotherlyLove,
                AnimationTarget = Targeting.Slot_AllySides,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 8, Targeting.Slot_AllyLeft),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 4, Targeting.Slot_AllyLeft),
                    Effects.GenerateEffect(FocusedApply, 1, Targeting.Slot_AllySides),
                ]
            };
            twoPrayers0.AddIntentsToTarget(Targeting.Slot_AllyLeft, [nameof(IntentType_GameIDs.Damage_7_10)]);
            twoPrayers0.AddIntentsToTarget(Targeting.Slot_AllyLeft, [nameof(IntentType_GameIDs.Heal_1_4)]);
            twoPrayers0.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Status_Focused)]);

            Ability twoPrayers1 = new Ability("Two Prayers for the Poor", "TwoPrayers_2_A")
            {
                Description = "Deal 7 damage to the Left ally.\nHeal the Left ally 4 health.\nApply Focused to the Left and Right allies.",
                AbilitySprite = ResourceLoader.LoadSprite("NabaTwoPrayers"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.MotherlyLove,
                AnimationTarget = Targeting.Slot_AllySides,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 7, Targeting.Slot_AllyLeft),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 4, Targeting.Slot_AllyLeft),
                    Effects.GenerateEffect(FocusedApply, 1, Targeting.Slot_AllySides),
                ]
            };
            twoPrayers1.AddIntentsToTarget(Targeting.Slot_AllyLeft, [nameof(IntentType_GameIDs.Damage_7_10)]);
            twoPrayers1.AddIntentsToTarget(Targeting.Slot_AllyLeft, [nameof(IntentType_GameIDs.Heal_1_4)]);
            twoPrayers1.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Status_Focused)]);

            Ability twoPrayers2 = new Ability("Two Prayers for the Wicked", "TwoPrayers_3_A")
            {
                Description = "Deal 6 damage to the Left ally.\nHeal the Left ally 4 health.\nApply Focused to the Left and Right allies.",
                AbilitySprite = ResourceLoader.LoadSprite("NabaTwoPrayers"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.MotherlyLove,
                AnimationTarget = Targeting.Slot_AllySides,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 6, Targeting.Slot_AllyLeft),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 4, Targeting.Slot_AllyLeft),
                    Effects.GenerateEffect(FocusedApply, 1, Targeting.Slot_AllySides),
                ]
            };
            twoPrayers2.AddIntentsToTarget(Targeting.Slot_AllyLeft, [nameof(IntentType_GameIDs.Damage_3_6)]);
            twoPrayers2.AddIntentsToTarget(Targeting.Slot_AllyLeft, [nameof(IntentType_GameIDs.Heal_1_4)]);
            twoPrayers2.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Status_Focused)]);

            Ability twoPrayers3 = new Ability("Two Prayers for the Wicked", "TwoPrayers_4_A")
            {
                Description = "Deal 5 damage to the Left ally.\nHeal the Left ally 4 health.\nApply Focused to the Left and Right allies.",
                AbilitySprite = ResourceLoader.LoadSprite("NabaTwoPrayers"),
                Cost = [Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.MotherlyLove,
                AnimationTarget = Targeting.Slot_AllySides,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 5, Targeting.Slot_AllyLeft),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 4, Targeting.Slot_AllyLeft),
                    Effects.GenerateEffect(FocusedApply, 1, Targeting.Slot_AllySides),
                ]
            };
            twoPrayers3.AddIntentsToTarget(Targeting.Slot_AllyLeft, [nameof(IntentType_GameIDs.Damage_3_6)]);
            twoPrayers3.AddIntentsToTarget(Targeting.Slot_AllyLeft, [nameof(IntentType_GameIDs.Heal_1_4)]);
            twoPrayers3.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Status_Focused)]);


            naba.AddLevelData(19, [crown0, revelation0, twoPrayers0]);
            naba.AddLevelData(21, [crown1, revelation1, twoPrayers1]);
            naba.AddLevelData(25, [crown2, revelation2, twoPrayers2]);
            naba.AddLevelData(27, [crown3, revelation3, twoPrayers3]);

            naba.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Naba_Witness_ACH");
            naba.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Naba_Divine_ACH");
            naba.AddCharacter(false, false);
        }
    }
}
