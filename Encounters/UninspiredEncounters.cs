using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Encounters
{
    public class UninspiredEncounters
    {
        public static void Add()
        {
            Portals.AddPortalSign("UninspiredNosestone_Sign", ResourceLoader.LoadSprite("TimelineUninspiredNosestone", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);
            EnemyEncounter_API uninspiredMedium = new EnemyEncounter_API(0, "H_Zone03_UninspiredNosestone_Medium_EnemyBundle", "UninspiredNosestone_Sign")
            {
                MusicEvent = "event:/SniffStep",
                RoarEvent = "event:/Characters/Enemies/Mung/CHR_ENM_Mung_Roar",
            };
            uninspiredMedium.CreateNewEnemyEncounterData(
                [
                    "UninspiredNosestone_EN",
                    "UninspiredNosestone_EN",
                    "ChoirBoy_EN",
                    "ChoirBoy_EN",
                ], null);
            uninspiredMedium.CreateNewEnemyEncounterData(
                [
                    "UninspiredNosestone_EN",
                    "ChoirBoy_EN",
                    "Inequity_EN",
                ], null);
            uninspiredMedium.CreateNewEnemyEncounterData(
                [
                    "UninspiredNosestone_EN",
                    "Inequity_EN",
                ], null);
            uninspiredMedium.CreateNewEnemyEncounterData(
                [
                    "UninspiredNosestone_EN",
                    "ShiveringHomunculus_EN",
                    "ShiveringHomunculus_EN",
                ], null);
            uninspiredMedium.CreateNewEnemyEncounterData(
                [
                    "UninspiredNosestone_EN",
                    "NextOfKin_EN",
                    "NextOfKin_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                uninspiredMedium.CreateNewEnemyEncounterData(
                    [
                        "UninspiredNosestone_EN",
                        "Unterling_EN",
                        "Unterling_EN",
                    ], null);
                uninspiredMedium.CreateNewEnemyEncounterData(
                    [
                        "UninspiredNosestone_EN",
                        "TitteringPeon_EN",
                        "TitteringPeon_EN",
                    ], null);
                uninspiredMedium.CreateNewEnemyEncounterData(
                    [
                        "UninspiredNosestone_EN",
                        "SterileBud_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.EggKeeper)
            {
                uninspiredMedium.CreateNewEnemyEncounterData(
                    [
                        "UninspiredNosestone_EN",
                        "EggKeeper_EN",
                    ], null);
            }
            uninspiredMedium.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_UninspiredNosestone_Medium_EnemyBundle", 3, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Medium);

            EnemyEncounter_API uninspiredHard = new EnemyEncounter_API(0, "H_Zone03_UninspiredNosestone_Hard_EnemyBundle", "UninspiredNosestone_Sign")
            {
                MusicEvent = "event:/SniffStep",
                RoarEvent = "event:/Characters/Enemies/Mung/CHR_ENM_Mung_Roar",
            };
            uninspiredHard.CreateNewEnemyEncounterData(
                [
                    "UninspiredNosestone_EN",
                    "SweatingNosestone_EN",
                    "SweatingNosestone_EN",
                ], null);
            uninspiredHard.CreateNewEnemyEncounterData(
                [
                    "UninspiredNosestone_EN",
                    "MesmerizingNosestone_EN",
                    "MesmerizingNosestone_EN",
                ], null);
            uninspiredHard.CreateNewEnemyEncounterData(
                [
                    "UninspiredNosestone_EN",
                    "ProlificNosestone_EN",
                    "ProlificNosestone_EN",
                    "ProlificNosestone_EN",
                ], null);
            uninspiredHard.CreateNewEnemyEncounterData(
                [
                    "UninspiredNosestone_EN",
                    "ScatterbrainedNosestone_EN",
                    "ScatterbrainedNosestone_EN",
                ], null);
            uninspiredHard.CreateNewEnemyEncounterData(
                [
                    "UninspiredNosestone_EN",
                    "UninspiredNosestone_EN",
                    "Maneater_EN",
                ], null);
            uninspiredHard.CreateNewEnemyEncounterData(
                [
                    "UninspiredNosestone_EN",
                    "UninspiredNosestone_EN",
                    "Inequity_EN",
                    "Inequity_EN",
                ], null);
            uninspiredHard.CreateNewEnemyEncounterData(
                [
                    "UninspiredNosestone_EN",
                    "UninspiredNosestone_EN",
                    "ChoirBoy_EN",
                    "Inequity_EN",
                ], null);
            uninspiredHard.CreateNewEnemyEncounterData(
                [
                    "UninspiredNosestone_EN",
                    "SweatingNosestone_EN",
                    "StickingHomunculus_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                uninspiredHard.CreateNewEnemyEncounterData(
                    [
                        "UninspiredNosestone_EN",
                        "UninspiredNosestone_EN",
                        "SterileBud_EN",
                        "Inequity_EN",
                    ], null);
                uninspiredHard.CreateNewEnemyEncounterData(
                    [
                        "UninspiredNosestone_EN",
                        "UninspiredNosestone_EN",
                        "TitteringPeon_EN",
                        "ChoirBoy_EN",
                    ], null);
                uninspiredHard.CreateNewEnemyEncounterData(
                    [
                        "UninspiredNosestone_EN",
                        "UninspiredNosestone_EN",
                        "ImpenetrableAngler_EN",
                    ], null);
                uninspiredHard.CreateNewEnemyEncounterData(
                    [
                        "UninspiredNosestone_EN",
                        "MesmerizingNosestone_EN",
                        "TitteringPeon_EN",
                    ], null);
                uninspiredHard.CreateNewEnemyEncounterData(
                    [
                        "UninspiredNosestone_EN",
                        "ScatterbrainedNosestone_EN",
                        "Unterling_EN",
                        "Unterling_EN",
                    ], null);
                uninspiredHard.CreateNewEnemyEncounterData(
                    [
                        "UninspiredNosestone_EN",
                        "ProlificNosestone_EN",
                        "Unterling_EN",
                        "Unterling_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.EggKeeper)
            {
                uninspiredHard.CreateNewEnemyEncounterData(
                    [
                        "UninspiredNosestone_EN",
                        "UninspiredNosestone_EN",
                        "EggKeeper_EN",
                    ], null);
                uninspiredHard.CreateNewEnemyEncounterData(
                    [
                        "UninspiredNosestone_EN",
                        "Maneater_EN",
                        "EggKeeper_EN",
                    ], null);
                uninspiredHard.CreateNewEnemyEncounterData(
                    [
                        "UninspiredNosestone_EN",
                        "ChoirBoy_EN",
                        "EggKeeper_EN",
                    ], null);
            }
            uninspiredHard.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_UninspiredNosestone_Hard_EnemyBundle", 3, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Hard);

            EnemyEncounter_API fiveNosestones = new EnemyEncounter_API((EncounterType)1, "H_Zone03_FiveNosestones_Hard_EnemyBundle", "UninspiredNosestone_Sign")
            {
                MusicEvent = "event:/SniffStep",
                RoarEvent = "event:/Characters/Enemies/Mung/CHR_ENM_Mung_Roar",
            };
            fiveNosestones.CreateNewEnemyEncounterData(
                [
                    "SweatingNosestone_EN",
                    "ProlificNosestone_EN",
                    "ScatterbrainedNosestone_EN",
                    "MesmerizingNosestone_EN",
                    "UninspiredNosestone_EN",
                ], null);
            fiveNosestones.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_FiveNosestones_Hard_EnemyBundle", 1, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Hard);
        }
    }
}
