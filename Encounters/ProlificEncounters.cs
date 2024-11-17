using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Encounters
{
    public class ProlificEncounters
    {
        public static void Add()
        {
            Portals.AddPortalSign("ProlificNosestone_Sign", ResourceLoader.LoadSprite("TimelineProlificNosestone", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);
            EnemyEncounter_API prolificMedium = new EnemyEncounter_API(0, "H_Zone03_ProlificNosestone_Medium_EnemyBundle", "ProlificNosestone_Sign")
            {
                MusicEvent = "event:/SniffStep",
                RoarEvent = "event:/Characters/Enemies/WrithingSpoggle/CHR_ENM_WrithingSpoggle_Roar",
            };
            prolificMedium.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "ProlificNosestone_EN",
                ], null);
            prolificMedium.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "ShiveringHomunculus_EN",
                    "ShiveringHomunculus_EN",
                    "ShiveringHomunculus_EN",
                    "SkinningHomunculus_EN",
                ], null);
            prolificMedium.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "ShiveringHomunculus_EN",
                    "ShiveringHomunculus_EN",
                    "SkinningHomunculus_EN",
                ], null);
            prolificMedium.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "ChoirBoy_EN",
                    "ChoirBoy_EN",
                ], null);
            prolificMedium.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "GigglingMinister_EN",
                    "ChoirBoy_EN",
                ], null);
            prolificMedium.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "InHisImage_EN",
                    "InHisImage_EN",
                    "InHisImage_EN",
                ], null);
            prolificMedium.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "NextOfKin_EN",
                    "NextOfKin_EN",
                    "NextOfKin_EN",
                    "NextOfKin_EN",
                ], null);
            prolificMedium.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "NextOfKin_EN",
                    "NextOfKin_EN",
                    "NextOfKin_EN",
                    "Inequity_EN",
                ], null);
            prolificMedium.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "Maneater_EN",
                ], null);
            prolificMedium.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "StickingHomunculus_EN",
                    "StickingHomunculus_EN",
                ], null);
            prolificMedium.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "StickingHomunculus_EN",
                    "NextOfKin_EN",
                    "NextOfKin_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                prolificMedium.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "Unterling_EN",
                        "Unterling_EN",
                        "Unterling_EN",
                    ], null);
                prolificMedium.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "StickingHomunculus_EN",
                        "Unterling_EN",
                    ], null);
                prolificMedium.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "StickingHomunculus_EN",
                        "ScreamingHomunculus_EN",
                    ], null);
            }
            prolificMedium.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_ProlificNosestone_Medium_EnemyBundle", 3, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Medium);

            EnemyEncounter_API prolificHard = new EnemyEncounter_API(0, "H_Zone03_ProlificNosestone_Hard_EnemyBundle", "ProlificNosestone_Sign")
            {
                MusicEvent = "event:/SniffStep",
                RoarEvent = "event:/Characters/Enemies/WrithingSpoggle/CHR_ENM_WrithingSpoggle_Roar",
            };
            prolificHard.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "ProlificNosestone_EN",
                    "ProlificNosestone_EN",
                ], null);
            prolificHard.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "SkinningHomunculus_EN",
                    "SkinningHomunculus_EN",
                ], null);
            prolificHard.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "ProlificNosestone_EN",
                    "ShiveringHomunculus_EN",
                    "SkinningHomunculus_EN",
                    "SkinningHomunculus_EN",
                ], null);
            prolificHard.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "ProlificNosestone_EN",
                    "ShiveringHomunculus_EN",
                    "SkinningHomunculus_EN",
                    "SkinningHomunculus_EN",
                ], null);
            prolificHard.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "SweatingNosestone_EN",
                    "SkinningHomunculus_EN",
                    "SkinningHomunculus_EN",
                ], null);
            prolificHard.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "ScatterbrainedNosestone_EN",
                    "SkinningHomunculus_EN",
                    "SkinningHomunculus_EN",
                ], null);
            prolificHard.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "NextOfKin_EN",
                    "NextOfKin_EN",
                    "Inequity_EN",
                    "Inequity_EN",
                ], null);
            prolificHard.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "Maneater_EN",
                    "Inequity_EN",
                ], null);
            prolificHard.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "Inequity_EN",
                    "SkinningHomunculus_EN",
                    "SkinningHomunculus_EN",
                ], null);
            prolificHard.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "Maneater_EN",
                    "StickingHomunculus_EN",
                ], null);
            prolificHard.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "SkinningHomunculus_EN",
                    "StickingHomunculus_EN",
                ], null);
            prolificHard.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "SkinningHomunculus_EN",
                    "StickingHomunculus_EN",
                    "ShiveringHomunculus_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "SkinningHomunculus_EN",
                        "StickingHomunculus_EN",
                        "ScreamingHomunculus_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "SkinningHomunculus_EN",
                        "ShiveringHomunculus_EN",
                        "ScreamingHomunculus_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "ProlificNosestone_EN",
                        "ShiveringHomunculus_EN",
                        "ScreamingHomunculus_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "ProlificNosestone_EN",
                        "Unterling_EN",
                        "ScreamingHomunculus_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "ProlificNosestone_EN",
                        "ImpenetrableAngler_EN",
                    ], null);
            }
            prolificHard.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_ProlificNosestone_Hard_EnemyBundle", 3, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Hard);

        }
    }
}
