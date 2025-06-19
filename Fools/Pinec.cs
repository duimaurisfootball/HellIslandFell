using BrutalAPI;
using Hell_Island_Fell.Custom_Effects;
using Hell_Island_Fell.Custom_Passives;
using UnityEngine;

namespace Hell_Island_Fell.Fools
{
    public class Pinec
    {
        public static void Add()
        {
            Character pinec = new Character("Pinec", "Pinec_CH")
            {
                HealthColor = Pigments.Purple,
                UsesBasicAbility = true,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("PinecFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("PinecBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("PinecOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("Clive_CH").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("Clive_CH").deathSound,
                DialogueSound = LoadedAssetsHandler.GetCharacter("Clive_CH").dxSound,
                UnitTypes =
                [
                    "Sandwich_BDSM",
                ],
            };
            pinec.GenerateMenuCharacter(ResourceLoader.LoadSprite("PinecMenu"), ResourceLoader.LoadSprite("PinecLocked"));
            pinec.AddPassives([CustomPassives.InvincibilityGenerator(9), Passives.GetCustomPassive("Thorny_PA")]);
            pinec.SetMenuCharacterAsFullDPS();

            StatusEffect_Apply_Effect ScarsApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            ScarsApply._Status = StatusField.Scars;

            DamageOnDoubleCascadeEffect ChainDamage = ScriptableObject.CreateInstance<DamageOnDoubleCascadeEffect>();
            ChainDamage._cascadeIsIndirect = true;
            ChainDamage._decreaseAsPercentage = true;
            ChainDamage._cascadeDecrease = 75;

            StatusEffect_Apply_Effect RupturedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            RupturedApply._Status = StatusField.Ruptured;

            DamageOnDoubleCascadeEffect SpikesDamage = ScriptableObject.CreateInstance<DamageOnDoubleCascadeEffect>();
            SpikesDamage._cascadeIsIndirect = true;
            SpikesDamage._decreaseAsPercentage = true;
            SpikesDamage._cascadeDecrease = 25;

            RemoveAmountStatusEffectEffect ScarsRemove = ScriptableObject.CreateInstance<RemoveAmountStatusEffectEffect>();
            ScarsRemove.statusId = StatusField.Scars.StatusID;
            ScarsRemove.randomBetweenPrevious = true;

            StatusEffect_Apply_PreviousExit_Effect FrailApply = ScriptableObject.CreateInstance<StatusEffect_Apply_PreviousExit_Effect>();
            FrailApply._Status = StatusField.Frail;
            FrailApply.entryAsAddition = true;

            //chain
            Ability chain0 = new Ability("Chain Lash", "HIF_Chain_1_A")
            {
                Description = "Deal 6 damage to the Opposing enemy.\nThis damage spreads indirectly to the Left and Right with a 25% dropoff.\nApply 1 Scar and 2 Ruptured to this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("PinecChain"),
                Cost = [Pigments.Purple, Pigments.Red],
                Visuals = Visuals.Slash,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ChainDamage, 6, Targeting.GenerateSlotTarget([0, 1, -1, 2, -2, 3, -3, 4, -4])),
                    Effects.GenerateEffect(ScarsApply, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(RupturedApply, 2, Targeting.Slot_SelfSlot),
                ]
            };
            chain0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_3_6)]);
            chain0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Scars)]);
            chain0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Ruptured)]);

            Ability chain1 = new Ability("Chain Swing", "HIF_Chain_2_A")
            {
                Description = "Deal 8 damage to the Opposing enemy.\nThis damage spreads indirectly to the Left and Right with a 25% dropoff.\nApply 1 Scar and 2 Ruptured to this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("PinecChain"),
                Cost = [Pigments.Purple, Pigments.Red],
                Visuals = Visuals.Slash,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ChainDamage, 8, Targeting.GenerateSlotTarget([0, 1, -1, 2, -2, 3, -3, 4, -4])),
                    Effects.GenerateEffect(ScarsApply, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(RupturedApply, 2, Targeting.Slot_SelfSlot),
                ]
            };
            chain1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);
            chain1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Scars)]);
            chain1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Ruptured)]);

            Ability chain2 = new Ability("Chain Knives", "HIF_Chain_3_A")
            {
                Description = "Deal 10 damage to the Opposing enemy.\nThis damage spreads indirectly to the Left and Right with a 25% dropoff.\nApply 1 Scars and 2 Ruptured to this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("PinecChain"),
                Cost = [Pigments.Purple, Pigments.Red],
                Visuals = Visuals.Slash,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ChainDamage, 10, Targeting.GenerateSlotTarget([0, 1, -1, 2, -2, 3, -3, 4, -4])),
                    Effects.GenerateEffect(ScarsApply, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(RupturedApply, 2, Targeting.Slot_SelfSlot),
                ]
            };
            chain2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);
            chain2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Scars)]);
            chain2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Ruptured)]);

            Ability chain3 = new Ability("Chain Ring", "HIF_Chain_4_A")
            {
                Description = "Deal 12 damage to the Opposing enemy.\nThis damage spreads indirectly to the Left and Right with a 25% dropoff.\nApply 1 Scars and 2 Ruptured to this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("PinecChain"),
                Cost = [Pigments.Purple, Pigments.Red],
                Visuals = Visuals.Slash,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ChainDamage, 12, Targeting.GenerateSlotTarget([0, 1, -1, 2, -2, 3, -3, 4, -4])),
                    Effects.GenerateEffect(ScarsApply, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(RupturedApply, 2, Targeting.Slot_SelfSlot),
                ]
            };
            chain3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_11_15)]);
            chain3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Scars)]);
            chain3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Ruptured)]);

            //spikes
            Ability spikes0 = new Ability("Tough Spikes", "HIF_Spikes_1_A")
            {
                Description = "Deal 7 damage to the Opposing enemy.\nThis damage spreads indirectly to the Left and Right with a 75% dropoff.\nApply 1 Scar and 2 Ruptured to this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("PinecSpikes"),
                Cost = [Pigments.Purple, Pigments.Red],
                Visuals = Visuals.Thorns,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(SpikesDamage, 7, Targeting.GenerateSlotTarget([0, 1, -1, 2, -2, 3, -3, 4, -4])),
                    Effects.GenerateEffect(ScarsApply, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(RupturedApply, 2, Targeting.Slot_SelfSlot),
                ]
            };
            spikes0.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_7_10)]);
            spikes0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Scars)]);
            spikes0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Ruptured)]);

            Ability spikes1 = new Ability("Iron Spikes", "HIF_Spikes_2_A")
            {
                Description = "Deal 11 damage to the Opposing enemy.\nThis damage spreads indirectly to the Left and Right with a 75% dropoff.\nApply 1 Scar and 2 Ruptured to this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("PinecSpikes"),
                Cost = [Pigments.Purple, Pigments.Red],
                Visuals = Visuals.Thorns,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(SpikesDamage, 11, Targeting.GenerateSlotTarget([0, 1, -1, 2, -2, 3, -3, 4, -4])),
                    Effects.GenerateEffect(ScarsApply, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(RupturedApply, 2, Targeting.Slot_SelfSlot),
                ]
            };
            spikes1.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_11_15)]);
            spikes1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Scars)]);
            spikes1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Ruptured)]);

            Ability spikes2 = new Ability("Razor Sharp Spikes", "HIF_Spikes_3_A")
            {
                Description = "Deal 14 damage to the Opposing enemy.\nThis damage spreads indirectly to the Left and Right with a 75% dropoff.\nApply 1 Scars and 2 Ruptured to this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("PinecSpikes"),
                Cost = [Pigments.Purple, Pigments.Red],
                Visuals = Visuals.Thorns,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(SpikesDamage, 14, Targeting.GenerateSlotTarget([0, 1, -1, 2, -2, 3, -3, 4, -4])),
                    Effects.GenerateEffect(ScarsApply, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(RupturedApply, 2, Targeting.Slot_SelfSlot),
                ]
            };
            spikes2.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_11_15)]);
            spikes2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Scars)]);
            spikes2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Ruptured)]);

            Ability spikes3 = new Ability("Head Full of Spikes", "HIF_Spikes_4_A")
            {
                Description = "Deal 17 damage to the Opposing enemy.\nThis damage spreads indirectly to the Left and Right with a 75% dropoff.\nApply 1 Scars and 2 Ruptured to this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("PinecSpikes"),
                Cost = [Pigments.Purple, Pigments.Red],
                Visuals = Visuals.Thorns,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(SpikesDamage, 17, Targeting.GenerateSlotTarget([0, 1, -1, 2, -2, 3, -3, 4, -4])),
                    Effects.GenerateEffect(ScarsApply, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(RupturedApply, 2, Targeting.Slot_SelfSlot),
                ]
            };
            spikes3.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Damage_16_20)]);
            spikes3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Scars)]);
            spikes3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Ruptured)]);

            //meat
            Ability meat0 = new Ability("Rotten Meat", "HIF_Meat_1_A")
            {
                Description = "Remove 1-2 Scars from this party member.\nApply an equivalent amount of Frail + 1 to this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("PinecMeat"),
                Cost = [Pigments.Blue, Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Absolve,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScarsRemove, 2, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(FrailApply, 1, Targeting.Slot_SelfSlot),
                ]
            };
            meat0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Rem_Status_Scars)]);
            meat0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Frail)]);

            Ability meat1 = new Ability("Raw Meat", "HIF_Meat_2_A")
            {
                Description = "Remove 1-3 Scars from this party member.\nApply an equivalent amount of Frail + 1 to this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("PinecMeat"),
                Cost = [Pigments.Blue, Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Absolve,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScarsRemove, 3, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(FrailApply, 1, Targeting.Slot_SelfSlot),
                ]
            };
            meat1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Rem_Status_Scars)]);
            meat1.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Frail)]);

            Ability meat2 = new Ability("Fresh Meat", "HIF_Meat_3_A")
            {
                Description = "Remove 1-4 Scars from this party member.\nApply an equivalent amount of Frail + 1 to this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("PinecMeat"),
                Cost = [Pigments.Blue, Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Absolve,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScarsRemove, 4, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(FrailApply, 1, Targeting.Slot_SelfSlot),
                ]
            };
            meat2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Rem_Status_Scars)]);
            meat2.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Frail)]);

            Ability meat3 = new Ability("Pristine Meat", "HIF_Meat_4_A")
            {
                Description = "Remove 1-5 Scars from this party member.\nApply an equivalent amount of Frail + 1 to this party member.",
                AbilitySprite = ResourceLoader.LoadSprite("PinecMeat"),
                Cost = [Pigments.Blue, Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Absolve,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScarsRemove, 5, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(FrailApply, 1, Targeting.Slot_SelfSlot),
                ]
            };
            meat3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Rem_Status_Scars)]);
            meat3.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Status_Frail)]);


            pinec.AddLevelData(10, [chain0, spikes0, meat0]);
            pinec.AddLevelData(11, [chain1, spikes1, meat1]);
            pinec.AddLevelData(12, [chain2, spikes2, meat2]);
            pinec.AddLevelData(13, [chain3, spikes3, meat3]);

            pinec.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Pinec_Witness_ACH");
            pinec.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Pinec_Divine_ACH");
            pinec.AddCharacter(true, false);
        }
    }
}
