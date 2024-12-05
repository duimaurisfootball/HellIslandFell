using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Fools
{
    public class HolesOfVandander
    {
        public static void Add()
        {
            Character vandanderHoles = new Character("Holes of Vandander", "VandanderHoles_CH")
            {
                HealthColor = Pigments.Purple,
                UsesBasicAbility = true,
                MovesOnOverworld = false,
                FrontSprite = ResourceLoader.LoadSprite("VandanderHolesFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("VandanderHolesBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("VandanderHolesOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("TaMaGoa_EN").deathSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("TaintedYolk_EN").deathSound,
                DialogueSound = LoadedAssetsHandler.GetEnemy("TaMaGoa_EN").damageSound,
                UsesAllAbilities = true,
            };
            vandanderHoles.AddPassives([Passives.Enfeebled]);

            StatusEffect_Apply_Effect LinkedApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            LinkedApply._Status = StatusField.Linked;

            StatusEffect_Apply_Effect FrailApply = ScriptableObject.CreateInstance<StatusEffect_Apply_Effect>();
            FrailApply._Status = StatusField.Frail;

            LoadedDBsHandler.StatusFieldDB.TryGetFieldEffect("Thunderstorm_ID", out FieldEffect_SO Thunderstorm);
            FieldEffect_Apply_Effect ThunderstormApply = ScriptableObject.CreateInstance<FieldEffect_Apply_Effect>();
            ThunderstormApply._Field = Thunderstorm;

            Ability vandalize = new Ability("Vandalize", "Vandalize_A")
            {
                Description = "Apply 2 Linked and 1 Frail to the Opposing enemy.\nHeal the Left ally 2 health.",
                AbilitySprite = ResourceLoader.LoadSprite("VandanderHolesVandalize"),
                Cost = [Pigments.Purple, Pigments.RedPurple, Pigments.Red],
                Visuals = Visuals.Genesis,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(LinkedApply, 2, Targeting.Slot_Front),
                    Effects.GenerateEffect(FrailApply, 1, Targeting.Slot_Front),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 2, Targeting.Slot_AllyLeft),
                    //Effects.GenerateEffect(ThunderstormApply, 2, Targeting.Slot_Front),
                    //Effects.GenerateEffect(ThunderstormApply, 2, Targeting.Slot_AllyLeft),
                ]
            };
            vandalize.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Linked)]);
            vandalize.AddIntentsToTarget(Targeting.Slot_Front, [nameof(IntentType_GameIDs.Status_Frail)]);
            vandalize.AddIntentsToTarget(Targeting.Slot_AllyLeft, [nameof(IntentType_GameIDs.Heal_1_4)]);
            //vandalize.AddIntentsToTarget(Targeting.Slot_Front, ["Field_Thunderstorm"]);
            //vandalize.AddIntentsToTarget(Targeting.Slot_AllyLeft, ["Field_Thunderstorm"]);

            vandanderHoles.AddLevelData(9, new Ability[] { vandalize });
            vandanderHoles.AddCharacter(true, true);
        }
    }
}
