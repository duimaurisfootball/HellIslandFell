using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Encounters
{
    public class SweatingEncounters
    {
        public static void Add()
        {
            Portals.AddPortalSign("SweatingNosestone_Sign", ResourceLoader.LoadSprite("TimelineSweatingNosestone", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);
            EnemyEncounter_API sweatingMedium = new EnemyEncounter_API(0, "H_Zone03_SweatingNosestone_Medium_EnemyBundle", "SweatingNosestone_Sign")
            {
                MusicEvent = "event:/SniffStep",
                RoarEvent = "event:/SweatingRoar",
            };
            sweatingMedium.CreateNewEnemyEncounterData(
                [
                    "SweatingNosestone_EN",
                    "InHisImage_EN",
                    "InHisImage_EN",
                ], null);
            sweatingMedium.CreateNewEnemyEncounterData(
                [
                    "SweatingNosestone_EN",
                    "ChoirBoy_EN",
                    "ChoirBoy_EN",
                ], null);
            sweatingMedium.CreateNewEnemyEncounterData(
                [
                    "SweatingNosestone_EN",
                    "NextOfKin_EN",
                    "NextOfKin_EN",
                    "NextOfKin_EN",
                ], null);
            sweatingMedium.CreateNewEnemyEncounterData(
                [
                    "SweatingNosestone_EN",
                    "GigglingMinister_EN",
                ], null);
            sweatingMedium.CreateNewEnemyEncounterData(
                [
                    "SweatingNosestone_EN",
                    "Maneater_EN",
                ], null);
            sweatingMedium.CreateNewEnemyEncounterData(
                [
                    "SweatingNosestone_EN",
                    "Maneater_EN",
                    "ChoirBoy_EN",
                ], null);
            sweatingMedium.CreateNewEnemyEncounterData(
                [
                    "SweatingNosestone_EN",
                    "Inequity_EN",
                    "NextOfKin_EN",
                    "NextOfKin_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EggKeeper)
            {
                sweatingMedium.CreateNewEnemyEncounterData(
                    [
                        "SweatingNosestone_EN",
                        "EggKeeper_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                sweatingMedium.CreateNewEnemyEncounterData(
                    [
                        "SweatingNosestone_EN",
                        "Vagabond_EN",
                    ], null);
            }
            sweatingMedium.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_SweatingNosestone_Medium_EnemyBundle", 3, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Medium);

            EnemyEncounter_API sweatingHard = new EnemyEncounter_API(0, "H_Zone03_SweatingNosestone_Hard_EnemyBundle", "SweatingNosestone_Sign")
            {
                MusicEvent = "event:/SniffStep",
                RoarEvent = "event:/SweatingRoar",
            };
            sweatingHard.CreateNewEnemyEncounterData(
                [
                    "SweatingNosestone_EN",
                    "ProlificNosestone_EN",
                    "ChoirBoy_EN",
                ], null);
            sweatingHard.CreateNewEnemyEncounterData(
                [
                    "SweatingNosestone_EN",
                    "UninspiredNosestone_EN",
                    "ChoirBoy_EN",
                ], null);
            sweatingHard.CreateNewEnemyEncounterData(
                [
                    "SweatingNosestone_EN",
                    "Maneater_EN",
                    "SkinningHomunculus_EN",
                ], null);
            sweatingHard.CreateNewEnemyEncounterData(
                [
                    "SweatingNosestone_EN",
                    "Inequity_EN",
                    "SkinningHomunculus_EN",
                ], null);
            sweatingHard.CreateNewEnemyEncounterData(
                [
                    "SweatingNosestone_EN",
                    "Maneater_EN",
                    "StickingHomunculus_EN",
                ], null);
            sweatingHard.CreateNewEnemyEncounterData(
                [
                    "SweatingNosestone_EN",
                    "Inequity_EN",
                    "StickingHomunculus_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                sweatingHard.CreateNewEnemyEncounterData(
                    [
                        "SweatingNosestone_EN",
                        "Maneater_EN",
                        "ScreamingHomunculus_EN",
                    ], null);
                sweatingHard.CreateNewEnemyEncounterData(
                    [
                        "SweatingNosestone_EN",
                        "Maneater_EN",
                        "ScreamingHomunculus_EN",
                        "StickingHomunculus_EN",
                    ], null);
                sweatingHard.CreateNewEnemyEncounterData(
                    [
                        "SweatingNosestone_EN",
                        "ScreamingHomunculus_EN",
                        "StickingHomunculus_EN",
                        "SkinningHomunculus_EN",
                    ], null);
                sweatingHard.CreateNewEnemyEncounterData(
                    [
                        "SweatingNosestone_EN",
                        "SweatingNosestone_EN",
                        "Unterling_EN",
                        "Unterling_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.EggKeeper)
            {
                sweatingHard.CreateNewEnemyEncounterData(
                    [
                        "SweatingNosestone_EN",
                        "StickingHomunculus_EN",
                        "EggKeeper_EN",
                    ], null);
                sweatingHard.CreateNewEnemyEncounterData(
                    [
                        "SweatingNosestone_EN",
                        "SkinningHomunculus_EN",
                        "EggKeeper_EN",
                    ], null);
                sweatingHard.CreateNewEnemyEncounterData(
                    [
                        "SweatingNosestone_EN",
                        "Maneater_EN",
                        "EggKeeper_EN",
                    ], null);
                sweatingHard.CreateNewEnemyEncounterData(
                    [
                        "SweatingNosestone_EN",
                        "SweatingNosestone_EN",
                        "EggKeeper_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.EnemyPack && Hell_Island_Fell.CrossMod.EggKeeper)
            {
                sweatingHard.CreateNewEnemyEncounterData(
                    [
                        "SweatingNosestone_EN",
                        "ScreamingHomunculus_EN",
                        "EggKeeper_EN",
                    ], null);
                sweatingHard.CreateNewEnemyEncounterData(
                    [
                        "SweatingNosestone_EN",
                        "SweatingNosestone_EN",
                        "Unterling_EN",
                        "EggKeeper_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                sweatingHard.CreateNewEnemyEncounterData(
                    [
                        "SweatingNosestone_EN",
                        "SweatingNosestone_EN",
                        "MarbleMaw_EN",
                    ], null);
                sweatingHard.CreateNewEnemyEncounterData(
                    [
                        "SweatingNosestone_EN",
                        "ChoirBoy_EN",
                        "FrowningChancellor_EN",
                    ], null);
                sweatingHard.CreateNewEnemyEncounterData(
                    [
                        "SweatingNosestone_EN",
                        "SweatingNosestone_EN",
                        "Vagabond_EN",
                    ], null);
            }
            sweatingHard.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_SweatingNosestone_Hard_EnemyBundle", 3, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Hard);

        }
    }
}
