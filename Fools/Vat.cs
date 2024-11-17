using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Fools
{
    public class Vat
    {
        public static void Add()
        {

            PercentageEffectCondition Chance0 = ScriptableObject.CreateInstance<PercentageEffectCondition>();
            Chance0.percentage = 50;

            PreviousEffectCondition Failure = ScriptableObject.CreateInstance<PreviousEffectCondition>();
            Failure.previousAmount = 2;
            Failure.wasSuccessful = false;

            Ability apoptosis = new Ability("Microapoptosis", "Apoptosis_A")
            {
                Description = "Deal 4 or 9 damage to this party member.\nHeal all other allies 5 health.",
                AbilitySprite = ResourceLoader.LoadSprite("VatVesicle"),
                Cost = [Pigments.Yellow],
                Visuals = Visuals.HeartBreaker,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<ExtraVariableForNextEffect>(), 1, Targeting.Slot_SelfSlot, Chance0),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 4, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<DamageEffect>(), 9, Targeting.Slot_SelfSlot, Failure),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 5, Targeting.Unit_OtherAlliesSlots),
                ]
            };
            apoptosis.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Damage_3_6)]);
            apoptosis.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Damage_7_10)]);
            apoptosis.AddIntentsToTarget(Targeting.Unit_OtherAlliesSlots, [nameof(IntentType_GameIDs.Heal_5_10)]);

            ExtraCCSprites_ArraySO ColorsShifting = ScriptableObject.CreateInstance<ExtraCCSprites_ArraySO>();
            ColorsShifting._doesLoop = true;
            ColorsShifting._DefaultID = "VatSpritesDefault";
            ColorsShifting._SpecialID = "VatSpritesSpecial";
            ColorsShifting._frontSprite =
                [
                    ResourceLoader.LoadSprite("VatFrontSanguine", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("VatFrontCholeric", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("VatFrontMelancholy", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("VatFrontPhlegma", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("VatFrontAbysmal", new Vector2(0.5f, 0f), 32),
                ];
            ColorsShifting._backSprite =
                [
                    ResourceLoader.LoadSprite("VatBackSanguine", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("VatBackCholeric", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("VatBackMelancholy", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("VatBackPhlegma", new Vector2(0.5f, 0f), 32),
                    ResourceLoader.LoadSprite("VatBackAbysmal", new Vector2(0.5f, 0f), 32),
                ];

            Character vat = new Character("Vat", "Vat_CH")
            {
                HealthColor = Pigments.Red,
                UsesBasicAbility = true,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("VatFrontSanguine", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("VatBackSanguine", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("VatOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetEnemy("SilverSuckle_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetEnemy("SilverSuckle_EN").deathSound,
                DialogueSound = LoadedAssetsHandler.GetEnemy("SilverSuckle_EN").damageSound,
                BasicAbility = apoptosis,
                ExtraSprites = ColorsShifting,
                UnitTypes =
                [
                    "HellishID"
                ],
            };
            vat.GenerateMenuCharacter(ResourceLoader.LoadSprite("VatMenu"), ResourceLoader.LoadSprite("VatLocked"));
            vat.AddPassives([Passives.LeakyGenerator(2), Passives.GetCustomPassive("Humorous_PA")]);
            vat.SetMenuCharacterAsFullSupport();

            ChangeToRandomHealthColorEffect BlueHealth = ScriptableObject.CreateInstance<ChangeToRandomHealthColorEffect>();
            BlueHealth._healthColors = [Pigments.Blue];

            ChangeToRandomHealthColorEffect PurpleHealth = ScriptableObject.CreateInstance<ChangeToRandomHealthColorEffect>();
            PurpleHealth._healthColors = [Pigments.Purple];

            ChangeToRandomHealthColorEffect YellowHealth = ScriptableObject.CreateInstance<ChangeToRandomHealthColorEffect>();
            YellowHealth._healthColors = [Pigments.Yellow];

            //golgi
            Ability golgi = new Ability("Golgi Body", "GolgiBody_A")
            {
                Description = "Change this party member's health to blue.\nIf successful, heal 7.",
                AbilitySprite = ResourceLoader.LoadSprite("VatGolgi"),
                Cost = [Pigments.Red],
                Visuals = Visuals.UglyOnTheInside,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(BlueHealth, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 7, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                ]
            };
            golgi.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Modify)]);
            golgi.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_5_10)]);

            //nucleolus
            Ability nucleolus = new Ability("Nucleolus", "Nucleolus_A")
            {
                Description = "Change this party member's health to purple.\nIf successful, heal 7.",
                AbilitySprite = ResourceLoader.LoadSprite("VatNucleolus"),
                Cost = [Pigments.Red],
                Visuals = Visuals.UglyOnTheInside,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(PurpleHealth, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 7, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                ]
            };
            nucleolus.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Modify)]);
            nucleolus.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_5_10)]);

            //DNA
            Ability DNA = new Ability("Deoxyribonucleic Acid", "DNA_A")
            {
                Description = "Change this party member's health to yellow.\nIf successful, heal 7.",
                AbilitySprite = ResourceLoader.LoadSprite("VatDNA"),
                Cost = [Pigments.Red],
                Visuals = Visuals.UglyOnTheInside,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [
                    Effects.GenerateEffect(YellowHealth, 1, Targeting.Slot_SelfSlot),
                    Effects.GenerateEffect(ScriptableObject.CreateInstance<HealEffect>(), 7, Targeting.Slot_SelfSlot, ScriptableObject.CreateInstance<PreviousEffectCondition>()),
                ]
            };
            DNA.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Modify)]);
            DNA.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_5_10)]);

            vat.AddLevelData(40, new Ability[] { golgi, nucleolus, DNA });

            vat.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Vat_Witness_ACH");
            vat.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Vat_Divine_ACH");
            vat.AddCharacter(true, false);
        }
    }
}
