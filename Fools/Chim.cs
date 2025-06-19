using Hell_Island_Fell.Custom_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Fools
{
    public class Chim
    {
        public static void Add()
        {
            Character chim = new Character("Chim", "Chim_CH")
            {
                HealthColor = Pigments.Red,
                UsesBasicAbility = false,
                UsesAllAbilities = true,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("ChimFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("ChimBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("ChimOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("MusicMan_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("MusicMan_EN").deathSound,
                DialogueSound = LoadedAssetsHandler.GetEnemy("MusicMan_EN").damageSound,
                UnitTypes =
                [
                    "Sandwich_SuperOrganism",
                ],
            };
            chim.GenerateMenuCharacter(ResourceLoader.LoadSprite("ChimMenu"), ResourceLoader.LoadSprite("ChimLocked"));
            chim.AddPassives([Passives.Withering]);
            chim.SetMenuCharacterAsFullSupport();

            ConsumeAllColorManaEffect YellowConsume = ScriptableObject.CreateInstance<ConsumeAllColorManaEffect>();
            YellowConsume._consumeMana = Pigments.Yellow;

            ConsumeAllColorManaEffect BlueConsume = ScriptableObject.CreateInstance<ConsumeAllColorManaEffect>();
            BlueConsume._consumeMana = Pigments.Blue;

            ConsumeAllColorManaEffect PurpleConsume = ScriptableObject.CreateInstance<ConsumeAllColorManaEffect>();
            PurpleConsume._consumeMana = Pigments.Purple;

            FieldEffect_Apply_Effect ShieldApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ShieldApply._Field = StatusField.Shield;
            ShieldApply._UsePreviousExitValueAsMultiplier = true;
            ShieldApply._PreviousExtraAddition = 0;

            HealEffect BlueHeal = ScriptableObject.CreateInstance<HealEffect>();
            BlueHeal.usePreviousExitValue = true;

            ChangeMaxHealthByPreviousEffect PurpleMax = ScriptableObject.CreateInstance<ChangeMaxHealthByPreviousEffect>();
            PurpleMax._increase = true;

            //stones
            Ability stones0 = new Ability("Stones of Protein", "HIF_Stones_1_A")
            {
                Description = "Consume all stored yellow pigment.\nApply 2 Shield to Self for each pigment consumed.",
                AbilitySprite = ResourceLoader.LoadSprite("ChimStones"),
                Cost = [],
                Visuals = Visuals.Shield,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(YellowConsume),
                    Effects.GenerateEffect(ShieldApply, 2, Targeting.Slot_SelfSlot),
                ]
            };
            stones0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);
            stones0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Field_Shield)]);

            Ability stones1 = new Ability("Stones of Milk", "HIF_Stones_2_A")
            {
                Description = "Consume all stored yellow pigment.\nApply 2 Shield to the Left and Right allies and Self for each pigment consumed.",
                AbilitySprite = ResourceLoader.LoadSprite("ChimStones"),
                Cost = [],
                Visuals = Visuals.Shield,
                AnimationTarget = Targeting.Slot_SelfAll_AndSides,
                Effects =
                [
                    Effects.GenerateEffect(YellowConsume),
                    Effects.GenerateEffect(ShieldApply, 2, Targeting.Slot_SelfAll_AndSides),
                ]
            };
            stones1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);
            stones1.AddIntentsToTarget(Targeting.Slot_SelfAll_AndSides, [nameof(IntentType_GameIDs.Field_Shield)]);

            Ability stones2 = new Ability("Stones of Fear", "HIF_Stones_3_A")
            {
                Description = "Consume all stored yellow pigment.\nApply 2 Shield to the Far Left, Left, Right, and Far Right allies and Self for each pigment consumed.",
                AbilitySprite = ResourceLoader.LoadSprite("ChimStones"),
                Cost = [],
                Visuals = Visuals.Shield,
                AnimationTarget = Targeting.Slot_SelfAll_AndSidesAndFarSides,
                Effects =
                [
                    Effects.GenerateEffect(YellowConsume),
                    Effects.GenerateEffect(ShieldApply, 2, Targeting.Slot_SelfAll_AndSidesAndFarSides),
                ]
            };
            stones2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);
            stones2.AddIntentsToTarget(Targeting.Slot_SelfAll_AndSidesAndFarSides, [nameof(IntentType_GameIDs.Field_Shield)]);

            Ability stones3 = new Ability("Stones of Bile", "HIF_Stones_4_A")
            {
                Description = "Consume all stored yellow pigment.\nApply 2 Shield to the Very Far Left, Far Left, Left, Right, Far Right, and Very Far Right allies and Self for each pigment consumed.",
                AbilitySprite = ResourceLoader.LoadSprite("ChimStones"),
                Cost = [],
                Visuals = Visuals.Shield,
                AnimationTarget = Targeting.GenerateSlotTarget([-3, -2, -1, 0, 1, 2, 3], true, true),
                Effects =
                [
                    Effects.GenerateEffect(YellowConsume),
                    Effects.GenerateEffect(ShieldApply, 2, Targeting.GenerateSlotTarget([-3, -2, -1, 0, 1, 2, 3], true, true)),
                ]
            };
            stones3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);
            stones3.AddIntentsToTarget(Targeting.GenerateSlotTarget([-3, -2, -1, 0, 1, 2, 3], true, true), [nameof(IntentType_GameIDs.Field_Shield)]);


            //water
            Ability water0 = new Ability("Bloody Water", "HIF_Water_1_A")
            {
                Description = "Consume all stored blue pigment.\nHeal the Right ally and Self an equivalent amount.",
                AbilitySprite = ResourceLoader.LoadSprite("ChimWater"),
                Cost = [],
                Visuals = Visuals.Cry,
                AnimationTarget = Targeting.Slot_SelfAndRight,
                Effects =
                [
                    Effects.GenerateEffect(BlueConsume),
                    Effects.GenerateEffect(BlueHeal, 1, Targeting.Slot_SelfAndRight),
                ]
            };
            water0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);
            water0.AddIntentsToTarget(Targeting.Slot_SelfAndRight, [nameof(IntentType_GameIDs.Heal_5_10)]);

            Ability water1 = new Ability("Sickly Water", "HIF_Water_2_A")
            {
                Description = "Consume all stored blue pigment.\nHeal the Right and Left allies and Self an equivalent amount.",
                AbilitySprite = ResourceLoader.LoadSprite("ChimWater"),
                Cost = [],
                Visuals = Visuals.Cry,
                AnimationTarget = Targeting.Slot_SelfAndSides,
                Effects =
                [
                    Effects.GenerateEffect(BlueConsume),
                    Effects.GenerateEffect(BlueHeal, 1, Targeting.Slot_SelfAndSides),
                ]
            };
            water1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);
            water1.AddIntentsToTarget(Targeting.Slot_SelfAndSides, [nameof(IntentType_GameIDs.Heal_5_10)]);

            Ability water2 = new Ability("Recycled Water", "HIF_Water_3_A")
            {
                Description = "Consume all stored blue pigment.\nHeal the Far Right, Right, and Left allies and Self an equivalent amount.",
                AbilitySprite = ResourceLoader.LoadSprite("ChimWater"),
                Cost = [],
                Visuals = Visuals.Cry,
                AnimationTarget = Targeting.GenerateSlotTarget([-1, 0, 1, 2], true, true),
                Effects =
                [
                    Effects.GenerateEffect(BlueConsume),
                    Effects.GenerateEffect(BlueHeal, 1, Targeting.GenerateSlotTarget([-1, 0, 1, 2], true, true)),
                ]
            };
            water2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);
            water2.AddIntentsToTarget(Targeting.GenerateSlotTarget([-1, 0, 1, 2], true, true), [nameof(IntentType_GameIDs.Heal_5_10)]);

            Ability water3 = new Ability("Fresh Water", "HIF_Water_4_A")
            {
                Description = "Consume all stored blue pigment.\nHeal the Far Right, Right, Left, and Far Left allies and Self an equivalent amount.",
                AbilitySprite = ResourceLoader.LoadSprite("ChimWater"),
                Cost = [],
                Visuals = Visuals.Cry,
                AnimationTarget = Targeting.Slot_SelfAll_AndSidesAndFarSides,
                Effects =
                [
                    Effects.GenerateEffect(BlueConsume),
                    Effects.GenerateEffect(BlueHeal, 1, Targeting.Slot_SelfAll_AndSidesAndFarSides),
                ]
            };
            water3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);
            water3.AddIntentsToTarget(Targeting.Slot_SelfAll_AndSidesAndFarSides, [nameof(IntentType_GameIDs.Heal_5_10)]);


            //metabolism
            Ability metabolism0 = new Ability("Raging Metabolism", "HIF_Metabolism_1_A")
            {
                Description = "Consume all stored purple pigment.\nIncrease the Right ally's max health by 2 times the amount consumed.",
                AbilitySprite = ResourceLoader.LoadSprite("ChimMetabolism"),
                Cost = [],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.Slot_AllyRight,
                Effects =
                [
                    Effects.GenerateEffect(PurpleConsume),
                    Effects.GenerateEffect(PurpleMax, 2, Targeting.Slot_AllyRight),
                ]
            };
            metabolism0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);
            metabolism0.AddIntentsToTarget(Targeting.Slot_AllyRight, [nameof(IntentType_GameIDs.Other_MaxHealth_Alt)]);

            Ability metabolism1 = new Ability("Stinking Metabolism", "HIF_Metabolism_2_A")
            {
                Description = "Consume all stored purple pigment.\nIncrease the Right and Left allies' max health by 2 times the amount consumed.",
                AbilitySprite = ResourceLoader.LoadSprite("ChimMetabolism"),
                Cost = [],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.Slot_AllySides,
                Effects =
                [
                    Effects.GenerateEffect(PurpleConsume),
                    Effects.GenerateEffect(PurpleMax, 2, Targeting.Slot_AllySides),
                ]
            };
            metabolism1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);
            metabolism1.AddIntentsToTarget(Targeting.Slot_AllySides, [nameof(IntentType_GameIDs.Other_MaxHealth_Alt)]);

            Ability metabolism2 = new Ability("Resting Metabolism", "HIF_Metabolism_3_A")
            {
                Description = "Consume all stored purple pigment.\nIncrease the Right, Left, and Far Left allies' max health by 2 times the amount consumed.",
                AbilitySprite = ResourceLoader.LoadSprite("ChimMetabolism"),
                Cost = [],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.GenerateSlotTarget([-2, -1, 1], true, true),
                Effects =
                [
                    Effects.GenerateEffect(PurpleConsume),
                    Effects.GenerateEffect(PurpleMax, 2, Targeting.GenerateSlotTarget([-2, -1, 1], true, true)),
                ]
            };
            metabolism2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);
            metabolism2.AddIntentsToTarget(Targeting.GenerateSlotTarget([-2, -1, 1], true, true), [nameof(IntentType_GameIDs.Other_MaxHealth_Alt)]);

            Ability metabolism3 = new Ability("Laughing Metabolism", "HIF_Metabolism_4_A")
            {
                Description = "Consume all stored purple pigment.\nIncrease the Far Right, Right, Left, and Far Left allies' max health by 2 times the amount consumed.",
                AbilitySprite = ResourceLoader.LoadSprite("ChimMetabolism"),
                Cost = [],
                Visuals = Visuals.Torched,
                AnimationTarget = Targeting.Slot_AllySidesAndFarSides,
                Effects =
                [
                    Effects.GenerateEffect(PurpleConsume),
                    Effects.GenerateEffect(PurpleMax, 2, Targeting.Slot_AllySidesAndFarSides),
                ]
            };
            metabolism3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Consume)]);
            metabolism3.AddIntentsToTarget(Targeting.Slot_AllySidesAndFarSides, [nameof(IntentType_GameIDs.Other_MaxHealth_Alt)]);

            chim.AddLevelData(6, [stones0, water0, metabolism0]);
            chim.AddLevelData(7, [stones1, water1, metabolism1]);
            chim.AddLevelData(8, [stones2, water2, metabolism2]);
            chim.AddLevelData(9, [stones3, water3, metabolism3]);

            chim.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Chim_Witness_ACH");
            chim.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Chim_Divine_ACH");
            chim.AddCharacter(true, false);
        }
    }
}
