using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Encounters
{
    public class InequityEncounters
    {
        public static void Add()
        {
            Portals.AddPortalSign("Inequity_Sign", ResourceLoader.LoadSprite("TimelineInequity", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);
            EnemyEncounter_API inequityEasy = new EnemyEncounter_API(0, "H_Zone03_Inequity_Easy_EnemyBundle", "Inequity_Sign")
            {
                MusicEvent = "event:/AnothersGriefAtTheHangmansHandWasOurRelief",
                RoarEvent = "event:/Characters/Enemies/DLC_01/ChoirBoy/CHR_ENM_ChoirBoy_Roar",
            };
            inequityEasy.CreateNewEnemyEncounterData(
                [
                    "Inequity_EN",
                    "Inequity_EN",
                    "Inequity_EN",
                    "NextOfKin_EN",
                ]);
            inequityEasy.CreateNewEnemyEncounterData(
                [
                    "Inequity_EN",
                    "Inequity_EN",
                    "Inequity_EN",
                    "ShiveringHomunculus_EN",
                ]);
            inequityEasy.CreateNewEnemyEncounterData(
                [
                    "Inequity_EN",
                    "Inequity_EN",
                    "ChoirBoy_EN",
                ]);
            inequityEasy.CreateNewEnemyEncounterData(
                [
                    "Inequity_EN",
                    "ShiveringHomunculus_EN",
                    "ShiveringHomunculus_EN",
                ]);
            inequityEasy.CreateNewEnemyEncounterData(
                [
                    "Inequity_EN",
                    "NextOfKin_EN",
                    "NextOfKin_EN",
                    "NextOfKin_EN",
                ]);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                inequityEasy.CreateNewEnemyEncounterData(
                    [
                        "Inequity_EN",
                        "Inequity_EN",
                        "Inequity_EN",
                        "Unterling_EN",
                    ]);
                inequityEasy.CreateNewEnemyEncounterData(
                    [
                        "Inequity_EN",
                        "Inequity_EN",
                        "Inequity_EN",
                        "TitteringPeon_EN",
                    ]);
            }
            if (Hell_Island_Fell.CrossMod.EggKeeper)
            {
                inequityEasy.CreateNewEnemyEncounterData(
                    [
                        "Inequity_EN",
                        "Inequity_EN",
                        "Inequity_EN",
                        "EggKeeper_EN",
                    ]);
            }
            inequityEasy.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_Inequity_Easy_EnemyBundle", 5, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Easy);
            EnemyEncounter_API inequityHard = new EnemyEncounter_API(0, "H_Zone03_Inequity_Hard_EnemyBundle", "Inequity_Sign")
            {
                MusicEvent = "event:/AnothersGriefAtTheHangmansHandWasOurRelief",
                RoarEvent = "event:/Characters/Enemies/DLC_01/ChoirBoy/CHR_ENM_ChoirBoy_Roar",
            };
            inequityHard.CreateNewEnemyEncounterData(
                [
                    "Inequity_EN",
                    "Inequity_EN",
                    "Inequity_EN",
                    "InHerImage_EN",
                ]);
            inequityHard.CreateNewEnemyEncounterData(
                [
                    "Inequity_EN",
                    "Inequity_EN",
                    "Inequity_EN",
                    "InHerImage_EN",
                    "InHerImage_EN",
                ]);
            inequityHard.CreateNewEnemyEncounterData(
                [
                    "Inequity_EN",
                    "Inequity_EN",
                    "Inequity_EN",
                    "ChoirBoy_EN",
                ]);
            inequityHard.CreateNewEnemyEncounterData(
                [
                    "Inequity_EN",
                    "Inequity_EN",
                    "Inequity_EN",
                    "SkinningHomunculus_EN",
                ]);
            inequityHard.CreateNewEnemyEncounterData(
                [
                    "Inequity_EN",
                    "Inequity_EN",
                    "Inequity_EN",
                    "ProlificNosestone_EN",
                ]);
            inequityHard.CreateNewEnemyEncounterData(
                [
                    "Inequity_EN",
                    "Inequity_EN",
                    "Inequity_EN",
                    "UninspiredNosestone_EN",
                ]);
            inequityHard.CreateNewEnemyEncounterData(
                [
                    "Inequity_EN",
                    "Inequity_EN",
                    "Inequity_EN",
                    "ScatterbrainedNosestone_EN",
                ]);
            inequityHard.CreateNewEnemyEncounterData(
                [
                    "Inequity_EN",
                    "Inequity_EN",
                    "Inequity_EN",
                    "StickingHomunculus_EN",
                ]);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                inequityHard.CreateNewEnemyEncounterData(
                    [
                        "Inequity_EN",
                        "Inequity_EN",
                        "Inequity_EN",
                        "SterileBud_EN",
                    ]);
                inequityHard.CreateNewEnemyEncounterData(
                    [
                        "Inequity_EN",
                        "Inequity_EN",
                        "ImpenetrableAngler_EN",
                    ]);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                inequityHard.CreateNewEnemyEncounterData(
                    [
                        "Inequity_EN",
                        "GodsChalice_EN",
                    ]);
                inequityHard.CreateNewEnemyEncounterData(
                    [
                        "Inequity_EN",
                        "Inequity_EN",
                        "MarbleMaw_EN",
                    ]);
            }
            inequityHard.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_Inequity_Hard_EnemyBundle", 3, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Hard);
        }
    }
}
