using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Encounters
{
    public class ScatterbrainedEncounters
    {
        public static void Add()
        {
            Portals.AddPortalSign("ScatterbrainedNosestone_Sign", ResourceLoader.LoadSprite("TimelineScatterbrainedNosestone", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);
            EnemyEncounter_API scatterbrainedMedium = new EnemyEncounter_API(0, "H_Zone03_ScatterbrainedNosestone_Medium_EnemyBundle", "ScatterbrainedNosestone_Sign")
            {
                MusicEvent = "event:/SniffStep",
                RoarEvent = "event:/Characters/Enemies/Spoggle_Blue/CHR_ENM_Spoggle_Blue_Roar",
            };
            scatterbrainedMedium.CreateNewEnemyEncounterData(
                [
                    "ScatterbrainedNosestone_EN",
                    "InHerImage_EN",
                    "InHerImage_EN",
                    "NextOfKin_EN",
                    "NextOfKin_EN",
                ], null);
            scatterbrainedMedium.CreateNewEnemyEncounterData(
                [
                    "ScatterbrainedNosestone_EN",
                    "ChoirBoy_EN",
                    "SkinningHomunculus_EN",
                ], null);
            scatterbrainedMedium.CreateNewEnemyEncounterData(
                [
                    "ScatterbrainedNosestone_EN",
                    "Inequity_EN",
                    "SkinningHomunculus_EN",
                ], null);
            scatterbrainedMedium.CreateNewEnemyEncounterData(
                [
                    "ScatterbrainedNosestone_EN",
                    "InHerImage_EN",
                    "InHerImage_EN",
                    "Maneater_EN",
                ], null);
            scatterbrainedMedium.CreateNewEnemyEncounterData(
                [
                    "ScatterbrainedNosestone_EN",
                    "Inequity_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                scatterbrainedMedium.CreateNewEnemyEncounterData(
                    [
                        "ScatterbrainedNosestone_EN",
                        "Unterling_EN",
                        "TitteringPeon_EN",
                    ], null);
                scatterbrainedMedium.CreateNewEnemyEncounterData(
                    [
                        "ScatterbrainedNosestone_EN",
                        "TitteringPeon_EN",
                        "ScreamingHomunculus_EN",
                    ], null);
            }
            scatterbrainedMedium.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_ScatterbrainedNosestone_Medium_EnemyBundle", 3, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Medium);

            EnemyEncounter_API scatterbrainedHard = new EnemyEncounter_API(0, "H_Zone03_ScatterbrainedNosestone_Hard_EnemyBundle", "ScatterbrainedNosestone_Sign")
            {
                MusicEvent = "event:/SniffStep",
                RoarEvent = "event:/Characters/Enemies/Spoggle_Blue/CHR_ENM_Spoggle_Blue_Roar",
            };
            scatterbrainedHard.CreateNewEnemyEncounterData(
                [
                    "ScatterbrainedNosestone_EN",
                    "ScatterbrainedNosestone_EN",
                    "InHerImage_EN",
                    "InHerImage_EN",
                    "InHerImage_EN",
                ], null);
            scatterbrainedHard.CreateNewEnemyEncounterData(
                [
                    "ScatterbrainedNosestone_EN",
                    "ScatterbrainedNosestone_EN",
                    "GigglingMinister_EN",
                ], null);
            scatterbrainedHard.CreateNewEnemyEncounterData(
                [
                    "ScatterbrainedNosestone_EN",
                    "ProlificNosestone_EN",
                    "InHerImage_EN",
                    "InHerImage_EN",
                    "InHerImage_EN",
                ], null);
            scatterbrainedHard.CreateNewEnemyEncounterData(
                [
                    "ScatterbrainedNosestone_EN",
                    "MesmerizingNosestone_EN",
                    "InHerImage_EN",
                    "InHerImage_EN",
                    "InHerImage_EN",
                ], null);
            scatterbrainedHard.CreateNewEnemyEncounterData(
                [
                    "ScatterbrainedNosestone_EN",
                    "Inequity_EN",
                    "InHerImage_EN",
                    "InHerImage_EN",
                    "InHerImage_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                scatterbrainedHard.CreateNewEnemyEncounterData(
                    [
                        "ScatterbrainedNosestone_EN",
                        "SterileBud_EN",
                        "InHerImage_EN",
                        "InHerImage_EN",
                        "InHerImage_EN",
                    ], null);
                scatterbrainedHard.CreateNewEnemyEncounterData(
                    [
                        "ScatterbrainedNosestone_EN",
                        "TitteringPeon_EN",
                        "InHerImage_EN",
                        "InHerImage_EN",
                        "InHerImage_EN",
                    ], null);
                scatterbrainedHard.CreateNewEnemyEncounterData(
                    [
                        "ScatterbrainedNosestone_EN",
                        "Unterling_EN",
                        "InHerImage_EN",
                        "InHerImage_EN",
                        "InHerImage_EN",
                    ], null);
            }
            scatterbrainedHard.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_ScatterbrainedNosestone_Hard_EnemyBundle", 3, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Hard);
        }
    }
}
