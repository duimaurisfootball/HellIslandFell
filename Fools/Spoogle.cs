using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Fools
{
    public class Spoogle
    {
        public static void Add()
        {
            Character spoogle = new Character("Spoogle", "Spoogle_CH")
            {
                HealthColor = Pigments.Yellow,
                UsesBasicAbility = true,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("SpoogleFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("SpoogleBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("SpoogleOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("Kleiver_CH").deathSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("TaintedYolk_EN").deathSound,
                DialogueSound = LoadedAssetsHandler.GetCharacter("Kleiver_CH").deathSound,
                UnitTypes =
                [
                    "Sandwich_Pigment",
                ],
            };
            spoogle.GenerateMenuCharacter(ResourceLoader.LoadSprite("SpoogleMenu"), ResourceLoader.LoadSprite("SpoogleLocked"));
            spoogle.AddPassives([Passives.Leaky3]);
            spoogle.SetMenuCharacterAsFullDPS();

            DamageEffect Damage = ScriptableObject.CreateInstance<DamageEffect>();

            HealEffect Heal = ScriptableObject.CreateInstance<HealEffect>();

            RefreshAbilityUseEffect Refresh = ScriptableObject.CreateInstance<RefreshAbilityUseEffect>();

            ConsumeColorManaEffect YellowEater1 = ScriptableObject.CreateInstance<ConsumeColorManaEffect>();
            YellowEater1.mana = Pigments.Yellow;

            ConsumeAllColorManaEffect YellowEater2 = ScriptableObject.CreateInstance<ConsumeAllColorManaEffect>();
            YellowEater2._consumeMana = Pigments.Yellow;

            DamageEffect AblateDamage = ScriptableObject.CreateInstance<DamageEffect>();
            AblateDamage._usePreviousExitValue = true;

            HealEffect ConcatHeal = ScriptableObject.CreateInstance<HealEffect>();
            ConcatHeal.usePreviousExitValue = true;

            RerollNumberPigmentEffect RerollYellow = ScriptableObject.CreateInstance<RerollNumberPigmentEffect>();
            RerollYellow._mana = Pigments.Yellow;

            DamageEffect IndirectDamage = ScriptableObject.CreateInstance<DamageEffect>();
            IndirectDamage._indirect = true;

            //ablate
            Ability ablate0 = new Ability("Feebly Ablate", "HIF_Ablate_1_A")
            {
                Description = "Heal this party member 2 health.\nConsume up to 4 yellow pigment from the pigment bar.\nDeal 2 damage to the Opposing enemy for every pigment consumed.",
                AbilitySprite = ResourceLoader.LoadSprite("SpoogleAblate"),
                Cost = [Pigments.Yellow, Pigments.Yellow],
                Visuals = Visuals.Bosch,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(Heal, 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(YellowEater1, 4, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(AblateDamage, 2, Targeting.Slot_Front),
                ]
            };
            ablate0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_1_4)]);
            ablate0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);
            ablate0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);

            Ability ablate1 = new Ability("Fiercely Ablate", "HIF_Ablate_2_A")
            {
                Description = "Heal this party member 2 health.\nConsume up to 6 yellow pigment from the pigment bar.\nDeal 2 damage to the Opposing enemy for every pigment consumed.",
                AbilitySprite = ResourceLoader.LoadSprite("SpoogleAblate"),
                Cost = [Pigments.Yellow, Pigments.Yellow],
                Visuals = Visuals.Bosch,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(Heal, 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(YellowEater1, 6, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(AblateDamage, 2, Targeting.Slot_Front),
                ]
            };
            ablate1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_1_4)]);
            ablate1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);
            ablate1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_11_15)]);

            Ability ablate2 = new Ability("Frightfully Ablate", "HIF_Ablate_3_A")
            {
                Description = "Heal this party member 3 health.\nConsume up to 8 yellow pigment from the pigment bar.\nDeal 2 damage to the Opposing enemy for every pigment consumed.",
                AbilitySprite = ResourceLoader.LoadSprite("SpoogleAblate"),
                Cost = [Pigments.Yellow, Pigments.Yellow],
                Visuals = Visuals.Bosch,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(Heal, 3, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(YellowEater1, 8, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(AblateDamage, 2, Targeting.Slot_Front),
                ]
            };
            ablate2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_1_4)]);
            ablate2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);
            ablate2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_16_20)]);

            Ability ablate3 = new Ability("Fantasmagorically Ablate", "HIF_Ablate_4_A")
            {
                Description = "Heal this party member 3 health.\nConsume up to 10 yellow pigment from the pigment bar.\nDeal 2 damage to the Opposing enemy for every pigment consumed.",
                AbilitySprite = ResourceLoader.LoadSprite("SpoogleAblate"),
                Cost = [Pigments.Yellow, Pigments.Yellow],
                Visuals = Visuals.Bosch,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(Heal, 3, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(YellowEater1, 10, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(AblateDamage, 2, Targeting.Slot_Front),
                ]
            };
            ablate3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_1_4)]);
            ablate3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);
            ablate3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_16_20)]);


            //concatenate
            Ability concatenate0 = new Ability("Reduction Concatenation", "HIF_Concatenation_1_A")
            {
                Description = "Consume all yellow pigment from the pigment bar.\nHeal this party member 2 health for every pigment consumed.\nTransform 2 stored pigment to yellow.",
                AbilitySprite = ResourceLoader.LoadSprite("SpoogleConcatenate"),
                Cost = [Pigments.Yellow, Pigments.Yellow, Pigments.Yellow],
                Visuals = Visuals.Melt,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(YellowEater2, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ConcatHeal, 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(RerollYellow, 2, Targeting.Slot_SelfSlot),
                ]
            };
            concatenate0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume), nameof(IntentType_GameIDs.Heal_11_20), nameof(IntentType_GameIDs.Mana_Modify)]);

            Ability concatenate1 = new Ability("Oxidation Concatenation", "HIF_Concatenation_2_A")
            {
                Description = "Consume all yellow pigment from the pigment bar.\nHeal this party member 2 health for every pigment consumed.\nTransform 3 stored pigment to yellow.",
                AbilitySprite = ResourceLoader.LoadSprite("SpoogleConcatenate"),
                Cost = [Pigments.Yellow, Pigments.Yellow, Pigments.Yellow],
                Visuals = Visuals.Melt,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(YellowEater2, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ConcatHeal, 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(RerollYellow, 3, Targeting.Slot_SelfSlot),
                ]
            };
            concatenate1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume), nameof(IntentType_GameIDs.Heal_11_20), nameof(IntentType_GameIDs.Mana_Modify)]);

            Ability concatenate2 = new Ability("Coagulation Concatenation", "HIF_Concatenation_3_A")
            {
                Description = "Consume all yellow pigment from the pigment bar.\nHeal this party member 2 health for every pigment consumed.\nTransform 4 stored pigment to yellow.",
                AbilitySprite = ResourceLoader.LoadSprite("SpoogleConcatenate"),
                Cost = [Pigments.Yellow, Pigments.Yellow, Pigments.Yellow],
                Visuals = Visuals.Melt,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(YellowEater2, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ConcatHeal, 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(RerollYellow, 4, Targeting.Slot_SelfSlot),
                ]
            };
            concatenate2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume), nameof(IntentType_GameIDs.Heal_11_20), nameof(IntentType_GameIDs.Mana_Modify)]);

            Ability concatenate3 = new Ability("Imagination Concatenation", "HIF_Concatenation_4_A")
            {
                Description = "Consume all yellow pigment from the pigment bar.\nHeal this party member 2 health for every pigment consumed.\nTransform 5 stored pigment to yellow.",
                AbilitySprite = ResourceLoader.LoadSprite("SpoogleConcatenate"),
                Cost = [Pigments.Yellow, Pigments.Yellow, Pigments.Yellow],
                Visuals = Visuals.Melt,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(YellowEater2, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ConcatHeal, 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(RerollYellow, 5, Targeting.Slot_SelfSlot),
                ]
            };
            concatenate3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume), nameof(IntentType_GameIDs.Heal_11_20), nameof(IntentType_GameIDs.Mana_Modify)]);


            //vomit
            Ability vomit0 = new Ability("Vomit up Dinner", "HIF_Vomit_1_A")
            {
                Description = "Deal 3 indirect damage to the Opposing enemy.\nDeal 1 damage to this party member.\n75% chance to refresh this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("SpoogleVomit"),
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Puke,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(IndirectDamage, 3, Targeting.Slot_Front),
                    Effects.GenerateEffect(Damage, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(Refresh, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(75))
                ]
            };
            vomit0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            vomit0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Damage_1_2)]);
            vomit0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability vomit1 = new Ability("Vomit up Lunch", "HIF_Vomit_2_A")
            {
                Description = "Deal 5 indirect damage to the Opposing enemy.\nDeal 1 damage to this party member.\n75% chance to refresh this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("SpoogleVomit"),
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Puke,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(IndirectDamage, 5, Targeting.Slot_Front),
                    Effects.GenerateEffect(Damage, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(Refresh, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(75))
                ]
            };
            vomit1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            vomit1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Damage_1_2)]);
            vomit1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability vomit2 = new Ability("Vomit up Breakfast", "HIF_Vomit_3_A")
            {
                Description = "Deal 6 indirect damage to the Opposing enemy.\nDeal 1 damage to this party member.\n75% chance to refresh this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("SpoogleVomit"),
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Puke,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(IndirectDamage, 6, Targeting.Slot_Front),
                    Effects.GenerateEffect(Damage, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(Refresh, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(75))
                ]
            };
            vomit2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            vomit2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Damage_1_2)]);
            vomit2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Refresh)]);

            Ability vomit3 = new Ability("Vomit up Yesterday's Dinner", "HIF_Vomit_4_A")
            {
                Description = "Deal 7 indirect damage to the Opposing enemy.\nDeal 1 damage to this party member.\n75% chance to refresh this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("SpoogleVomit"),
                Cost = [Pigments.Yellow],
                Visuals = Visuals.Puke,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(IndirectDamage, 7, Targeting.Slot_Front),
                    Effects.GenerateEffect(Damage, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(Refresh, 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(75))
                ]
            };
            vomit3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);
            vomit3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Damage_1_2)]);
            vomit3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Other_Refresh)]);

            spoogle.AddLevelData(12, [concatenate0, ablate0, vomit0]);
            spoogle.AddLevelData(15, [concatenate1, ablate1, vomit1]);
            spoogle.AddLevelData(17, [concatenate2, ablate2, vomit2]);
            spoogle.AddLevelData(18, [concatenate3, ablate3, vomit3]);

            spoogle.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Spoogle_Witness_ACH");
            spoogle.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Spoogle_Divine_ACH");
            spoogle.AddCharacter(true, false);
        }
    }
}
