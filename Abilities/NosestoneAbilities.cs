using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Hell_Island_Fell.Custom_Stuff;
using Hell_Island_Fell.Custom_Effects;

namespace Hell_Island_Fell.Abilities
{
    public class NosestoneAbilities
    {
        public static void Add()
        {
            AddCostByHealthColorEffect NosingAdd = ScriptableObject.CreateInstance<AddCostByHealthColorEffect>();
            NosingAdd.AddOverSix = false;

            Ability nosing = new Ability("Nosing", "Nosing_A")
            {
                Description = "Add 1 cost of this enemy's health color to the Opposing and Left or Right party member's abilities.\nWill not add to \"Slap\", and will not add to costs greater than or equal to 6.",
                Cost = [Pigments.SplitPigment(Pigments.Red, Pigments.Blue, Pigments.Yellow, Pigments.Purple)],
                Visuals = Visuals.StompRight,
                AnimationTarget = Targeting.Slot_Front,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                    Effects.GenerateEffect(NosingAdd, 1, Targeting.GenerateSlotTarget([-1, 0], false, false), Effects.CheckPreviousEffectCondition(false, 1)),
                    Effects.GenerateEffect(NosingAdd, 1, Targeting.GenerateSlotTarget([0, 1], false, false), Effects.CheckPreviousEffectCondition(true, 2)),
                ],
                Rarity = CustomAbilityRarity.Weight(5, true),
                Priority = Priority.Slow,
            };
            nosing.AddIntentsToTarget(Targeting.GenerateSlotTarget([-1, 0], false, false), ["Modify_Cost"]);
            nosing.AddIntentsToTarget(Targeting.GenerateSlotTarget([0, 1], false, false), ["Modify_Cost"]);

            Ability stoning = new Ability("Stoning", "Stoning_A")
            {
                Description = "Deal an Agonizing amount of damage to the Left or Right party member.\nReroll the costs not of this enemy's health color in the Opposing party member's abilities.",
                Cost = [Pigments.SplitPigment(Pigments.Red, Pigments.Blue, Pigments.Yellow, Pigments.Purple)],
                Visuals = Visuals.StompLeft,
                AnimationTarget = Targeting.Slot_OpponentSides,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1, Targeting.Slot_SelfSlot, Effects.ChanceCondition(50)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 8, Targeting.Slot_OpponentLeft, Effects.CheckPreviousEffectCondition(false, 1)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 8, Targeting.Slot_OpponentRight, Effects.CheckPreviousEffectCondition(true, 2)),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<NoseReroll>(), 1, Targeting.Slot_Front)
                ],
                Rarity = CustomAbilityRarity.Weight(5, true),
                Priority = Priority.Slow,
            };
            stoning.AddIntentsToTarget(Targeting.Slot_OpponentSides, [nameof(IntentType_GameIDs.Damage_7_10)]);
            stoning.AddIntentsToTarget(Targeting.Slot_Front, ["Reroll_Cost"]);

            Nosing = nosing;
            Stoning = stoning;
        }
        public static Ability Nosing;

        public static Ability Stoning;
    }
}
