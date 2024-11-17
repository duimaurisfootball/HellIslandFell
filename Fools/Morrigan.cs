using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Fools
{
    public class Morrigan
    {
        public static void Add()
        {
            Character morrigan = new Character("Morrigan", "Morrigan_CH")
            {
                HealthColor = Pigments.Grey,
                UsesBasicAbility = true,
                MovesOnOverworld = true,
                FrontSprite = ResourceLoader.LoadSprite("MorriganFront", new Vector2(0.5f, 0f), 32),
                BackSprite = ResourceLoader.LoadSprite("MorriganBack", new Vector2(0.5f, 0f), 32),
                OverworldSprite = ResourceLoader.LoadSprite("MorriganOverworld", new Vector2(0.5f, 0f), 32),
                DamageSound = LoadedAssetsHandler.GetCharacter("SilverSuckle_EN").damageSound,
                DeathSound = LoadedAssetsHandler.GetCharacter("SilverSuckle_EN").deathSound,
                DialogueSound = LoadedAssetsHandler.GetCharacter("SilverSuckle_EN").damageSound,
            };
            morrigan.GenerateMenuCharacter(ResourceLoader.LoadSprite("MorriganMenu"), ResourceLoader.LoadSprite("MorriganLocked"));
            morrigan.AddPassives([Passives.Immortal]);
            morrigan.SetMenuCharacterAsFullSupport();

            //mud
            Ability mud0 = new Ability("Mud Puddle", "Mud_1_A")
            {
                Description = "",
                AbilitySprite = ResourceLoader.LoadSprite("VatGolgi"),
                Cost = [Pigments.Blue, Pigments.Blue, Pigments.Blue],
                Visuals = Visuals.Chomp,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [

                ]
            };
            mud0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Modify)]);
            mud0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_5_10)]);

            //glass
            Ability glass0 = new Ability("Volcanic Glass", "Glass_1_A")
            {
                Description = "",
                AbilitySprite = ResourceLoader.LoadSprite("VatNucleolus"),
                Cost = [Pigments.Blue, Pigments.Blue, Pigments.Red],
                Visuals = Visuals.Decimate,
                AnimationTarget = Targeting.Slot_AllyLeft,
                Effects =
                [

                ]
            };
            glass0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Modify)]);
            glass0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_5_10)]);

            //pearls
            Ability pearls0 = new Ability("Marrow Pearls", "Pearls_1_A")
            {
                Description = "",
                AbilitySprite = ResourceLoader.LoadSprite("VatDNA"),
                Cost = [Pigments.Blue, Pigments.Blue, Pigments.Yellow],
                Visuals = Visuals.UglyOnTheInside,
                AnimationTarget = Targeting.Slot_SelfSlot,
                Effects =
                [

                ]
            };
            pearls0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Mana_Modify)]);
            pearls0.AddIntentsToTarget(Targeting.Slot_SelfSlot, [nameof(IntentType_GameIDs.Heal_5_10)]);

            morrigan.AddLevelData(5, new Ability[] { mud0, glass0, pearls0 });

            //morrigan.AddFinalBossAchievementData(BossType_GameIDs.OsmanSinnoks.ToString(), "HIF_Morrigan_Witness_ACH");
            //morrigan.AddFinalBossAchievementData(BossType_GameIDs.Heaven.ToString(), "HIF_Morrigan_Divine_ACH");
            morrigan.AddCharacter(true, false);
        }
    }
}
