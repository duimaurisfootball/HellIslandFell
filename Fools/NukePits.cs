using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Fools
{
    public class NukePits
    {
        public static void Add()
        {
            Character nukePits = new Character("Nuke Pits", "NukePits_CH")
            {
                HealthColor = Pigments.Purple,
                UsesBasicAbility = true,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("NukePitsFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("NukePitsBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("NukePitsOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("Thype_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("Thype_CH").deathSound,
                DialogueSound = LoadedAssetsHandler.GetCharacter("Thype_CH").dxSound,
                UnitTypes =
                [
                    "FemaleID",
                ],
            };
            nukePits.GenerateMenuCharacter(ResourceLoader.LoadSprite("NukePitsMenu"), ResourceLoader.LoadSprite("NukePitsLocked"));
            nukePits.AddPassives([Passives.GetCustomPassive("Grinding_PA")]);
            nukePits.SetMenuCharacterAsFullSupport();

            UnboundedDamageEffect UnboundedDamage0 = ScriptableObject.CreateInstance<UnboundedDamageEffect>();
            UnboundedDamage0._repeatChance = 60;
            UnboundedDamage0._cycles = 1;

            UnboundedDamageEffect UnboundedDamage1 = ScriptableObject.CreateInstance<UnboundedDamageEffect>();
            UnboundedDamage1._repeatChance = 60;
            UnboundedDamage1._cycles = 2;

            UnboundedDamageEffect UnboundedDamage2 = ScriptableObject.CreateInstance<UnboundedDamageEffect>();
            UnboundedDamage2._repeatChance = 60;
            UnboundedDamage2._cycles = 4;

            UnboundedDamageEffect UnboundedDamage3 = ScriptableObject.CreateInstance<UnboundedDamageEffect>();
            UnboundedDamage3._repeatChance = 60;
            UnboundedDamage3._cycles = 6;

            AddCostListEffect AddCostSplits = ScriptableObject.CreateInstance<AddCostListEffect>();
            AddCostSplits.IgnoreSlap = false;
            AddCostSplits.AddOverSix = false;
            AddCostSplits._colors =
                [
                    Pigments.Red,
                    Pigments.Red,
                    Pigments.Red,
                    Pigments.Blue,
                    Pigments.Blue,
                    Pigments.Blue,
                    Pigments.Yellow,
                    Pigments.Yellow,
                    Pigments.Yellow,
                    Pigments.Purple,
                    Pigments.Purple,
                    Pigments.Purple,
                    Pigments.RedBlue,
                    Pigments.RedYellow,
                    Pigments.RedPurple,
                    Pigments.BlueRed,
                    Pigments.BlueYellow,
                    Pigments.BluePurple,
                    Pigments.YellowRed,
                    Pigments.YellowBlue,
                    Pigments.YellowPurple,
                    Pigments.PurpleRed,
                    Pigments.PurpleBlue,
                    Pigments.PurpleYellow,
                    Pigments.Grey,
                ];

            RemoveRandomCostEffect RemoveCost = ScriptableObject.CreateInstance<RemoveRandomCostEffect>();
            RemoveCost.removeSingleCost = false;

            CountCostByColorsEffect CountCost0 = ScriptableObject.CreateInstance<CountCostByColorsEffect>();
            CountCost0.specialColors = [Pigments.Purple];

            CountCostByColorsEffect CountCost1 = ScriptableObject.CreateInstance<CountCostByColorsEffect>();
            CountCost1.specialColors = [Pigments.Purple, Pigments.Yellow];

            CountCostByColorsEffect CountCost2 = ScriptableObject.CreateInstance<CountCostByColorsEffect>();
            CountCost2.specialColors = [Pigments.Purple, Pigments.Yellow, Pigments.Blue];

            CountCostByColorsEffect CountCost3 = ScriptableObject.CreateInstance<CountCostByColorsEffect>();
            CountCost3.specialColors = [Pigments.Purple, Pigments.Yellow, Pigments.Blue, Pigments.Red];

            HealEffect PrevHeal = ScriptableObject.CreateInstance<HealEffect>();
            PrevHeal.usePreviousExitValue = true;

            //beam
            Ability beam0 = new Ability("Photon Beam", "HIF_Beam_1_A")
            {
                Description = "Deal at least 1 damage to the Opposing enemy.\nAdd 1 random cost to each of this party member's abilities, except abilities with costs greater than or equal to 6.",
                AbilitySprite = ResourceLoader.LoadSprite("NukePitsBeam"),
                Cost = [Pigments.Red],
                Visuals = Visuals.Exsanguinate,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(UnboundedDamage0, 0, Targeting.Slot_Front),
                    Effects.GenerateEffect(AddCostSplits, 1, Targeting.Slot_SelfSlot),
                ]
            };
            beam0.AddIntentsToTarget(Targeting.Slot_Front, ["Damage_Unbounded"]);
            beam0.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Modify_Cost"]);

            Ability beam1 = new Ability("Electron Beam", "HIF_Beam_2_A")
            {
                Description = "Deal at least 2 damage to the Opposing enemy.\nAdd 1 random cost to each of this party member's abilities, except abilities with costs greater than or equal to 6.",
                AbilitySprite = ResourceLoader.LoadSprite("NukePitsBeam"),
                Cost = [Pigments.Red],
                Visuals = Visuals.Exsanguinate,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(UnboundedDamage1, 0, Targeting.Slot_Front),
                    Effects.GenerateEffect(AddCostSplits, 1, Targeting.Slot_SelfSlot),
                ]
            };
            beam1.AddIntentsToTarget(Targeting.Slot_Front, ["Damage_Unbounded"]);
            beam1.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Modify_Cost"]);

            Ability beam2 = new Ability("Quark Beam", "HIF_Beam_3_A")
            {
                Description = "Deal at least 4 damage to the Opposing enemy.\nAdd 1 random cost to each of this party member's abilities, except abilities with costs greater than or equal to 6.",
                AbilitySprite = ResourceLoader.LoadSprite("NukePitsBeam"),
                Cost = [Pigments.Red],
                Visuals = Visuals.Exsanguinate,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(UnboundedDamage2, 0, Targeting.Slot_Front),
                    Effects.GenerateEffect(AddCostSplits, 1, Targeting.Slot_SelfSlot),
                ]
            };
            beam2.AddIntentsToTarget(Targeting.Slot_Front, ["Damage_Unbounded"]);
            beam2.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Modify_Cost"]);

            Ability beam3 = new Ability("String Beam", "HIF_Beam_4_A")
            {
                Description = "Deal at least 6 damage to the Opposing enemy.\nAdd 1 random cost to each of this party member's abilities, except abilities with costs greater than or equal to 6.",
                AbilitySprite = ResourceLoader.LoadSprite("NukePitsBeam"),
                Cost = [Pigments.Red],
                Visuals = Visuals.Exsanguinate,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(UnboundedDamage3, 0, Targeting.Slot_Front),
                    Effects.GenerateEffect(AddCostSplits, 1, Targeting.Slot_SelfSlot),
                ]
            };
            beam3.AddIntentsToTarget(Targeting.Slot_Front, ["Damage_Unbounded"]);
            beam3.AddIntentsToTarget(Targeting.Slot_SelfSlot, ["Modify_Cost"]);


            //salt
            Ability salt0 = new Ability("Dry Salt", "HIF_Salt_1_A")
            {
                Description = "Heal this and the Right ally 1 health for each Purple cost they have.\nAdd 1 random cost to each of this and the Right ally's abilities, except abilities with costs greater than or equal to 6.",
                AbilitySprite = ResourceLoader.LoadSprite("NukePitsSalt"),
                Cost = [Pigments.Blue],
                Visuals = Visuals.Exsanguinate,
                AnimationTarget = Targeting.Slot_SelfAndRight,
                Effects =
                [
                    Effects.GenerateEffect(CountCost0, 1, Targeting.Slot_SelfAndRight),
                    Effects.GenerateEffect(PrevHeal, 1, Targeting.Slot_SelfAndRight),
                    Effects.GenerateEffect(AddCostSplits, 1, Targeting.Slot_SelfAndRight),
                ]
            };
            salt0.AddIntentsToTarget(Targeting.Slot_SelfAndRight, [nameof(IntentType_GameIDs.Heal_5_10), "Modify_Cost"]);

            Ability salt1 = new Ability("Sea Salt", "HIF_Salt_2_A")
            {
                Description = "Heal this and the Right ally 1 health for each Purple and Yellow cost they have.\nAdd 1 random cost to each of this and the Right ally's abilitie, except abilities with costs greater than or equal to 6.",
                AbilitySprite = ResourceLoader.LoadSprite("NukePitsSalt"),
                Cost = [Pigments.Blue],
                Visuals = Visuals.Exsanguinate,
                AnimationTarget = Targeting.Slot_SelfAndRight,
                Effects =
                [
                    Effects.GenerateEffect(CountCost1, 1, Targeting.Slot_SelfAndRight),
                    Effects.GenerateEffect(PrevHeal, 1, Targeting.Slot_SelfAndRight),
                    Effects.GenerateEffect(AddCostSplits, 1, Targeting.Slot_SelfAndRight),
                ]
            };
            salt1.AddIntentsToTarget(Targeting.Slot_SelfAndRight, [nameof(IntentType_GameIDs.Heal_5_10), "Modify_Cost"]);

            Ability salt2 = new Ability("Cave Salt", "HIF_Salt_3_A")
            {
                Description = "Heal this and the Right ally 1 health for each Purple, Yellow, and Blue cost they have.\nAdd 1 random cost to each of this and the Right ally's abilitie, except abilities with costs greater than or equal to 6.",
                AbilitySprite = ResourceLoader.LoadSprite("NukePitsSalt"),
                Cost = [Pigments.Blue],
                Visuals = Visuals.Exsanguinate,
                AnimationTarget = Targeting.Slot_SelfAndRight,
                Effects =
                [
                    Effects.GenerateEffect(CountCost2, 1, Targeting.Slot_SelfAndRight),
                    Effects.GenerateEffect(PrevHeal, 1, Targeting.Slot_SelfAndRight),
                    Effects.GenerateEffect(AddCostSplits, 1, Targeting.Slot_SelfAndRight),
                ]
            };
            salt2.AddIntentsToTarget(Targeting.Slot_SelfAndRight, [nameof(IntentType_GameIDs.Heal_5_10), "Modify_Cost"]);

            Ability salt3 = new Ability("Molten Salt", "HIF_Salt_4_A")
            {
                Description = "Heal this and the Right ally 1 health for each Purple, Yellow, Blue, and Red cost they have.\nAdd 1 random cost to each of this and the Right ally's abilitie, except abilities with costs greater than or equal to 6.",
                AbilitySprite = ResourceLoader.LoadSprite("NukePitsSalt"),
                Cost = [Pigments.Blue],
                Visuals = Visuals.Exsanguinate,
                AnimationTarget = Targeting.Slot_SelfAndRight,
                Effects =
                [
                    Effects.GenerateEffect(CountCost3, 1, Targeting.Slot_SelfAndRight),
                    Effects.GenerateEffect(PrevHeal, 1, Targeting.Slot_SelfAndRight),
                    Effects.GenerateEffect(AddCostSplits, 1, Targeting.Slot_SelfAndRight),
                ]
            };
            salt3.AddIntentsToTarget(Targeting.Slot_SelfAndRight, [nameof(IntentType_GameIDs.Heal_5_10), "Modify_Cost"]);


            //fuel
            Ability fuel0 = new Ability("Fuel Drum", "HIF_Fuel_1_A")
            {
                Description = "Remove 1 cost from each of this and the Left ally's abilities that cost more than 1 pigment.",
                AbilitySprite = ResourceLoader.LoadSprite("NukePitsFuel"),
                Cost = [Pigments.Blue],
                Visuals = Visuals.OilSlicked,
                AnimationTarget = Targeting.Slot_SelfAndLeft,
                Effects =
                [
                    Effects.GenerateEffect(RemoveCost, 1, Targeting.Slot_SelfAndLeft),
                ]
            };
            fuel0.AddIntentsToTarget(Targeting.Slot_SelfAndLeft, ["Modify_Cost"]);

            Ability fuel1 = new Ability("Fuel Delivery", "HIF_Fuel_2_A")
            {
                Description = "Remove 1 cost from each of this and the Left ally's abilities that cost more than 1 pigment.\nHeal this and the Left ally 1 health per cost removed.",
                AbilitySprite = ResourceLoader.LoadSprite("NukePitsFuel"),
                Cost = [Pigments.Blue],
                Visuals = Visuals.OilSlicked,
                AnimationTarget = Targeting.Slot_SelfAndLeft,
                Effects =
                [
                    Effects.GenerateEffect(RemoveCost, 1, Targeting.Slot_SelfAndLeft),
                    Effects.GenerateEffect(PrevHeal, 1, Targeting.Slot_SelfAndLeft),
                ]
            };
            fuel1.AddIntentsToTarget(Targeting.Slot_SelfAndLeft, ["Modify_Cost", nameof(IntentType_GameIDs.Heal_1_4)]);

            Ability fuel2 = new Ability("Fuel Rods", "HIF_Fuel_3_A")
            {
                Description = "Remove 1 cost from each of this and the Left ally's abilities that cost more than 1 pigment.\nHeal this and the Left ally 2 health per cost removed.",
                AbilitySprite = ResourceLoader.LoadSprite("NukePitsFuel"),
                Cost = [Pigments.Blue],
                Visuals = Visuals.OilSlicked,
                AnimationTarget = Targeting.Slot_SelfAndLeft,
                Effects =
                [
                    Effects.GenerateEffect(RemoveCost, 1, Targeting.Slot_SelfAndLeft),
                    Effects.GenerateEffect(PrevHeal, 2, Targeting.Slot_SelfAndLeft),
                ]
            };
            fuel2.AddIntentsToTarget(Targeting.Slot_SelfAndLeft, ["Modify_Cost", nameof(IntentType_GameIDs.Heal_5_10)]);

            Ability fuel3 = new Ability("Fuel Depletion", "HIF_Fuel_4_A")
            {
                Description = "Remove 1 cost from each of this and the Left ally's abilities that cost more than 1 pigment.\nHeal this and the Left ally 3 health per cost removed.",
                AbilitySprite = ResourceLoader.LoadSprite("NukePitsFuel"),
                Cost = [Pigments.Blue],
                Visuals = Visuals.OilSlicked,
                AnimationTarget = Targeting.Slot_SelfAndLeft,
                Effects =
                [
                    Effects.GenerateEffect(RemoveCost, 1, Targeting.Slot_SelfAndLeft),
                    Effects.GenerateEffect(PrevHeal, 3, Targeting.Slot_SelfAndLeft),
                ]
            };
            fuel3.AddIntentsToTarget(Targeting.Slot_SelfAndLeft, ["Modify_Cost", nameof(IntentType_GameIDs.Heal_5_10)]);

            nukePits.AddLevelData(20, [beam0, salt0, fuel0]);
            nukePits.AddLevelData(22, [beam1, salt1, fuel1]);
            nukePits.AddLevelData(24, [beam2, salt2, fuel2]);
            nukePits.AddLevelData(26, [beam3, salt3, fuel3]);

            nukePits.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_NukePits_Witness_ACH");
            nukePits.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_NukePits_Divine_ACH");
            nukePits.AddCharacter(true, false);
        }
    }
}
