using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Fools
{
    public class Eras
    {
        public static void Add()
        {
            Character eras = new Character("Eras", "Eras_CH")
            {
                HealthColor = Pigments.Purple,
                UsesBasicAbility = true,
                UsesAllAbilities = false,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("ErasFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("ErasBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("ErasOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("Hans_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("Hans_CH").deathSound,
                DialogueSound = LoadedAssetsHandler.GetCharacter("Hans_CH").dxSound,
                UnitTypes =
                [
                    "Sandwich_SuperOrganism",
                ],
            };
            eras.GenerateMenuCharacter(ResourceLoader.LoadSprite("ErasMenu"), ResourceLoader.LoadSprite("ErasLocked"));
            eras.SetMenuCharacterAsFullSupport();
            eras.AddPassives([]);

            TradeHealthColorsEffect TradeColors = ScriptableObject.CreateInstance<TradeHealthColorsEffect>();

            ChangeToRandomHealthColorEffect RandomColor = ScriptableObject.CreateInstance<ChangeToRandomHealthColorEffect>();
            RandomColor._healthColors = [Pigments.Red, Pigments.Blue, Pigments.Yellow, Pigments.Purple, Pigments.Grey];

            FieldEffect_Apply_Effect ShieldApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ShieldApply._Field = StatusField.Shield;

            HealOnColorCascadeEffect ColorCascade = ScriptableObject.CreateInstance<HealOnColorCascadeEffect>();
            ColorCascade._cascadeDecrease = 0;

            HealSharedHealthColorsEffect SlotsHeal = ScriptableObject.CreateInstance<HealSharedHealthColorsEffect>();

            //electricity
            Ability electricity0 = new Ability("Weak Electricity", "HIF_Electricity_1_A")
            {
                Description = "Swap health colors with the Left ally.\nIf health color was not swapped, randomize the Left ally's health color and apply 3 Shield to this and the Left positions.",
                AbilitySprite = ResourceLoader.LoadSprite("ErasElectricity"),
                Cost = [Pigments.Blue],
                Visuals = Visuals.Innocence,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(TradeColors, 0, Targeting.Slot_AllyLeft),
                    Effects.GenerateEffect(RandomColor, 0, Targeting.Slot_AllyLeft, Effects.CheckPreviousEffectCondition(false, 1)),
                    Effects.GenerateEffect(ShieldApply, 3, Targeting.Slot_SelfAndLeft, Effects.CheckPreviousEffectCondition(false, 2)),
                ],
            };
            electricity0.AddIntentsToTarget(Targeting.Slot_SelfAndLeft, [nameof(IntentType_GameIDs.Mana_Modify), nameof(IntentType_GameIDs.Field_Shield)]);

            Ability electricity1 = new Ability("Short Electricity", "HIF_Electricity_2_A")
            {
                Description = "Swap health colors with the Left ally.\nIf health color was not swapped, randomize the Left ally's health color and apply 5 Shield to this and the Left positions.",
                AbilitySprite = ResourceLoader.LoadSprite("ErasElectricity"),
                Cost = [Pigments.Blue],
                Visuals = Visuals.Innocence,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(TradeColors, 0, Targeting.Slot_AllyLeft),
                    Effects.GenerateEffect(RandomColor, 0, Targeting.Slot_AllyLeft, Effects.CheckPreviousEffectCondition(false, 1)),
                    Effects.GenerateEffect(ShieldApply, 5, Targeting.Slot_SelfAndLeft, Effects.CheckPreviousEffectCondition(false, 2)),
                ],
            };
            electricity1.AddIntentsToTarget(Targeting.Slot_SelfAndLeft, [nameof(IntentType_GameIDs.Mana_Modify), nameof(IntentType_GameIDs.Field_Shield)]);

            Ability electricity2 = new Ability("Polar Electricity", "HIF_Electricity_3_A")
            {
                Description = "Swap health colors with the Left ally.\nIf health color was not swapped, randomize the Left ally's health color and apply 7 Shield to this and the Left positions.",
                AbilitySprite = ResourceLoader.LoadSprite("ErasElectricity"),
                Cost = [Pigments.Blue],
                Visuals = Visuals.Innocence,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(TradeColors, 0, Targeting.Slot_AllyLeft),
                    Effects.GenerateEffect(RandomColor, 0, Targeting.Slot_AllyLeft, Effects.CheckPreviousEffectCondition(false, 1)),
                    Effects.GenerateEffect(ShieldApply, 7, Targeting.Slot_SelfAndLeft, Effects.CheckPreviousEffectCondition(false, 2)),
                ],
            };
            electricity2.AddIntentsToTarget(Targeting.Slot_SelfAndLeft, [nameof(IntentType_GameIDs.Mana_Modify), nameof(IntentType_GameIDs.Field_Shield)]);

            Ability electricity3 = new Ability("Direct Electricity", "HIF_Electricity_4_A")
            {
                Description = "Swap health colors with the Left ally.\nIf health color was not swapped, randomize the Left ally's health color and apply 9 Shield to this and the Left positions.",
                AbilitySprite = ResourceLoader.LoadSprite("ErasElectricity"),
                Cost = [Pigments.Blue],
                Visuals = Visuals.Innocence,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(TradeColors, 0, Targeting.Slot_AllyLeft),
                    Effects.GenerateEffect(RandomColor, 0, Targeting.Slot_AllyLeft, Effects.CheckPreviousEffectCondition(false, 1)),
                    Effects.GenerateEffect(ShieldApply, 7, Targeting.Slot_SelfAndLeft, Effects.CheckPreviousEffectCondition(false, 2)),
                ],
            };
            electricity3.AddIntentsToTarget(Targeting.Slot_SelfAndLeft, [nameof(IntentType_GameIDs.Mana_Modify), nameof(IntentType_GameIDs.Field_Shield)]);

            //pulse
            Ability pulse0 = new Ability("Arrhythmic Pulse", "HIF_Pulse_1_A")
            {
                Description = "Heal this party member 4 health.\nHealing spreads to the Right as long as the next party member has a different health color than all previously healed party members.",
                AbilitySprite = ResourceLoader.LoadSprite("ErasPulse"),
                Cost = [Pigments.BlueRed, Pigments.BlueRed],
                Visuals = Visuals.Genesis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ColorCascade, 4, Targeting.GenerateSlotTarget([0, 1, 2, 3, 4], true))
                ],
            };
            pulse0.AddIntentsToTarget(Targeting.GenerateSlotTarget([0, 1, 2, 3, 4], true), [nameof(IntentType_GameIDs.Heal_1_4)]);

            Ability pulse1 = new Ability("Fast Pulse", "HIF_Pulse_2_A")
            {
                Description = "Heal this party member 6 health.\nHealing spreads to the Right as long as the next party member has a different health color than all previously healed party members.",
                AbilitySprite = ResourceLoader.LoadSprite("ErasPulse"),
                Cost = [Pigments.BlueRed, Pigments.BlueRed],
                Visuals = Visuals.Genesis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ColorCascade, 6, Targeting.GenerateSlotTarget([0, 1, 2, 3, 4], true))
                ],
            };
            pulse1.AddIntentsToTarget(Targeting.GenerateSlotTarget([0, 1, 2, 3, 4], true), [nameof(IntentType_GameIDs.Heal_5_10)]);

            Ability pulse2 = new Ability("Calm Pulse", "HIF_Pulse_3_A")
            {
                Description = "Heal this party member 8 health.\nHealing spreads to the Right as long as the next party member has a different health color than all previously healed party members.",
                AbilitySprite = ResourceLoader.LoadSprite("ErasPulse"),
                Cost = [Pigments.BlueRed, Pigments.BlueRed],
                Visuals = Visuals.Genesis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ColorCascade, 8, Targeting.GenerateSlotTarget([0, 1, 2, 3, 4], true))
                ],
            };
            pulse2.AddIntentsToTarget(Targeting.GenerateSlotTarget([0, 1, 2, 3, 4], true), [nameof(IntentType_GameIDs.Heal_5_10)]);

            Ability pulse3 = new Ability("Athletic Pulse", "HIF_Pulse_4_A")
            {
                Description = "Heal this party member 10 health.\nHealing spreads to the Right as long as the next party member has a different health color than all previously healed party members.",
                AbilitySprite = ResourceLoader.LoadSprite("ErasPulse"),
                Cost = [Pigments.BlueRed, Pigments.BlueRed],
                Visuals = Visuals.Genesis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ColorCascade, 10, Targeting.GenerateSlotTarget([0, 1, 2, 3, 4], true))
                ],
            };
            pulse3.AddIntentsToTarget(Targeting.GenerateSlotTarget([0, 1, 2, 3, 4], true), [nameof(IntentType_GameIDs.Heal_5_10)]);

            //beat
            Ability beat0 = new Ability("Beat Up", "HIF_Beat_1_A")
            {
                Description = "Randomize this and the Left and Right party members' health colors.\nHeal all allies who got matching health colors 6 health.",
                AbilitySprite = ResourceLoader.LoadSprite("ErasBeat"),
                Cost = [Pigments.Red],
                Visuals = Visuals.HeartBreaker,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(RandomColor, 0, Targeting.Slot_SelfAndSides),
                    Effects.GenerateEffect(SlotsHeal, 6, Targeting.Slot_SelfAndSides)
                ],
            };
            beat0.AddIntentsToTarget(Targeting.Slot_SelfAndSides, [nameof(IntentType_GameIDs.Mana_Randomize), nameof(IntentType_GameIDs.Heal_5_10)]);

            Ability beat1 = new Ability("Beat Hard", "HIF_Beat_2_A")
            {
                Description = "Randomize this and the Left and Right party members' health colors.\nHeal all allies who got matching health colors 8 health.",
                AbilitySprite = ResourceLoader.LoadSprite("ErasBeat"),
                Cost = [Pigments.Red],
                Visuals = Visuals.HeartBreaker,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(RandomColor, 0, Targeting.Slot_SelfAndSides),
                    Effects.GenerateEffect(SlotsHeal, 8, Targeting.Slot_SelfAndSides)
                ],
            };
            beat1.AddIntentsToTarget(Targeting.Slot_SelfAndSides, [nameof(IntentType_GameIDs.Mana_Randomize), nameof(IntentType_GameIDs.Heal_5_10)]);

            Ability beat2 = new Ability("Beat Loud", "HIF_Beat_3_A")
            {
                Description = "Randomize this and the Left and Right party members' health colors.\nHeal all allies who got matching health colors 11 health.",
                AbilitySprite = ResourceLoader.LoadSprite("ErasBeat"),
                Cost = [Pigments.Red],
                Visuals = Visuals.HeartBreaker,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(RandomColor, 0, Targeting.Slot_SelfAndSides),
                    Effects.GenerateEffect(SlotsHeal, 11, Targeting.Slot_SelfAndSides)
                ],
            };
            beat2.AddIntentsToTarget(Targeting.Slot_SelfAndSides, [nameof(IntentType_GameIDs.Mana_Randomize), nameof(IntentType_GameIDs.Heal_11_20)]);

            Ability beat3 = new Ability("Beat Bloody", "HIF_Beat_4_A")
            {
                Description = "Randomize this and the Left and Right party members' health colors.\nHeal all allies who got matching health colors 13 health.",
                AbilitySprite = ResourceLoader.LoadSprite("ErasBeat"),
                Cost = [Pigments.Red],
                Visuals = Visuals.HeartBreaker,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(RandomColor, 0, Targeting.Slot_SelfAndSides),
                    Effects.GenerateEffect(SlotsHeal, 13, Targeting.Slot_SelfAndSides)
                ],
            };
            beat3.AddIntentsToTarget(Targeting.Slot_SelfAndSides, [nameof(IntentType_GameIDs.Mana_Randomize), nameof(IntentType_GameIDs.Heal_11_20)]);

            eras.AddLevelData(8, [electricity0, pulse0, beat0]);
            eras.AddLevelData(11, [electricity1, pulse1, beat1]);
            eras.AddLevelData(14, [electricity2, pulse2, beat2]);
            eras.AddLevelData(17, [electricity3, pulse3, beat3]);

            eras.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Eras_Witness_ACH");
            eras.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Eras_Divine_ACH");
            eras.AddCharacter(true, false);
        }
    }
}
