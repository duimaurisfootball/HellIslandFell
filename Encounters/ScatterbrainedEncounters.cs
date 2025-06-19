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
                RoarEvent = "event:/ScatterbrainedRoar",
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
                    "InHerImage_EN",
                    "InHerImage_EN",
                    "Maneater_EN",
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
            if (Hell_Island_Fell.CrossMod.EggKeeper)
            {
                scatterbrainedMedium.CreateNewEnemyEncounterData(
                    [
                        "ScatterbrainedNosestone_EN",
                        "InHerImage_EN",
                        "EggKeeper_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                scatterbrainedMedium.CreateNewEnemyEncounterData(
                    [
                        "ScatterbrainedNosestone_EN",
                        "InHerImage_EN",
                        "MarbleMaw_EN",
                    ], null);
                scatterbrainedMedium.CreateNewEnemyEncounterData(
                    [
                        "ScatterbrainedNosestone_EN",
                        "InHerImage_EN",
                        "FrowningChancellor_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                scatterbrainedMedium.CreateNewEnemyEncounterData(
                    [
                        "ScatterbrainedNosestone_EN",
                        "InHerImage_EN",
                        "Attrition_EN",
                    ], null);
            }
            scatterbrainedMedium.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_ScatterbrainedNosestone_Medium_EnemyBundle", 3, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Medium);

            EnemyEncounter_API scatterbrainedHard = new EnemyEncounter_API(0, "H_Zone03_ScatterbrainedNosestone_Hard_EnemyBundle", "ScatterbrainedNosestone_Sign")
            {
                MusicEvent = "event:/SniffStep",
                RoarEvent = "event:/ScatterbrainedRoar",
            };
            scatterbrainedHard.CreateNewEnemyEncounterData(
                [
                    "ScatterbrainedNosestone_EN",
                    "ScatterbrainedNosestone_EN",
                    "ScatterbrainedNosestone_EN",
                    "InHerImage_EN",
                ], null);
            scatterbrainedHard.CreateNewEnemyEncounterData(
                [
                    "ScatterbrainedNosestone_EN",
                    "ScatterbrainedNosestone_EN",
                    "InHerImage_EN",
                    "InHerImage_EN",
                ], null);
            scatterbrainedHard.CreateNewEnemyEncounterData(
                [
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
                ], null);
            scatterbrainedHard.CreateNewEnemyEncounterData(
                [
                    "ScatterbrainedNosestone_EN",
                    "Inequity_EN",
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
                    ], null);
                scatterbrainedHard.CreateNewEnemyEncounterData(
                    [
                        "ScatterbrainedNosestone_EN",
                        "TitteringPeon_EN",
                        "InHerImage_EN",
                        "InHerImage_EN",
                    ], null);
                scatterbrainedHard.CreateNewEnemyEncounterData(
                    [
                        "ScatterbrainedNosestone_EN",
                        "Unterling_EN",
                        "InHerImage_EN",
                        "InHerImage_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.EggKeeper)
            {
                scatterbrainedHard.CreateNewEnemyEncounterData(
                    [
                        "ScatterbrainedNosestone_EN",
                        "InHerImage_EN",
                        "InHerImage_EN",
                        "EggKeeper_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                scatterbrainedHard.CreateNewEnemyEncounterData(
                    [
                        "ScatterbrainedNosestone_EN",
                        "InHerImage_EN",
                        "InHerImage_EN",
                        "MarbleMaw_EN",
                    ], null);
                scatterbrainedHard.CreateNewEnemyEncounterData(
                    [
                        "ScatterbrainedNosestone_EN",
                        "InHerImage_EN",
                        "InHerImage_EN",
                        "Vagabond_EN",
                    ], null);
                scatterbrainedHard.CreateNewEnemyEncounterData(
                    [
                        "ScatterbrainedNosestone_EN",
                        "InHerImage_EN",
                        "InHerImage_EN",
                        "FrowningChancellor_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                scatterbrainedHard.CreateNewEnemyEncounterData(
                    [
                        "ScatterbrainedNosestone_EN",
                        "InHerImage_EN",
                        "Attrition_EN",
                        "GigglingMinister_EN",
                    ], null);
                scatterbrainedHard.CreateNewEnemyEncounterData(
                    [
                        "ScatterbrainedNosestone_EN",
                        "Git_EN",
                        "Git_EN",
                    ], null);
                scatterbrainedHard.CreateNewEnemyEncounterData(
                    [
                        "ScatterbrainedNosestone_EN",
                        "InHerImage_EN",
                        "InHerImage_EN",
                        "Romantic_EN",
                    ], null);
            }
            scatterbrainedHard.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_ScatterbrainedNosestone_Hard_EnemyBundle", 3, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Hard);
        }
    }
}
