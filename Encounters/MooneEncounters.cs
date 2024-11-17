using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Encounters
{
    public class MooneEncounters
    {
        public static void Add()
        {
            Portals.AddPortalSign("Moone_Sign", ResourceLoader.LoadSprite("TimelineMoone", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);

            EnemyEncounter_API MooneEasy = new EnemyEncounter_API(0, "H_Zone02_Moone_Easy_EnemyBundle", "Moone_Sign")
            {
                MusicEvent = "event:/Music/Mx_InTheirImage",
                RoarEvent = "event:/Characters/Enemies/GigglingMinister/CHR_ENM_GigglingMinister_Roar",
            };
            MooneEasy.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                ], null);
            MooneEasy.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "MusicMan_EN",
                ], null);
            MooneEasy.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
                ], null);
            MooneEasy.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "SingingStone_EN",
                    "SingingStone_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.Colophons)
            {
                MooneEasy.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "ColophonDefeated_EN",
                    ], null);
                MooneEasy.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "ColophonComposed_EN",
                        "SingingStone_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                MooneEasy.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "NakedGizo_EN",
                    ], null);
                MooneEasy.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Chapman_EN",
                        "Chapman_EN",
                    ], null);
                MooneEasy.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "DesiccatingJumbleguts_EN",
                        "SingingStone_EN",
                    ], null);
                MooneEasy.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "MusicMan_EN",
                        "NakedGizo_EN",
                    ], null);
                MooneEasy.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "VanishingHands_EN",
                    ], null);
            }
            MooneEasy.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone02_Moone_Easy_EnemyBundle", 8, ZoneType_GameIDs.Orpheum_Hard, BundleDifficulty.Easy);

            EnemyEncounter_API MooneMedium = new EnemyEncounter_API(0, "H_Zone02_Moone_Medium_EnemyBundle", "Moone_Sign")
            {
                MusicEvent = "event:/Music/Mx_InTheirImage",
                RoarEvent = "event:/Characters/Enemies/GigglingMinister/CHR_ENM_GigglingMinister_Roar",
            };
            MooneMedium.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "Moone_EN",
                    "Moone_EN",
                ], null);
            MooneMedium.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "MusicMan_EN",
                    "MusicMan_EN",
                ], null);
            MooneMedium.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "MusicMan_EN",
                ], null);
            MooneMedium.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "Moone_EN",
                    "MusicMan_EN",
                ], null);
            MooneMedium.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "Moone_EN",
                    "SingingStone_EN",
                ], null);
            MooneMedium.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "JumbleGuts_Flummoxing_EN",
                ], null);
            MooneMedium.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "JumbleGuts_Hollowing_EN",
                ], null);
            MooneMedium.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "Spoggle_Resonant_EN",
                    "Spoggle_Writhing_EN",
                ], null);
            MooneMedium.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "JumbleGuts_Waning_EN",
                    "JumbleGuts_Clotted_EN",
                ], null);
            MooneMedium.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "Moone_EN",
                    "VanishingHands_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                MooneMedium.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Moone_EN",
                        "Chapman_EN",
                    ], null);
                MooneMedium.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Seraphim_EN",
                    ], null);
                MooneMedium.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Moone_EN",
                        "Gizo_EN",
                    ], null);
                MooneMedium.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Neoplasm_EN",
                        "Neoplasm_EN",
                    ], null);
                MooneMedium.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Seraphim_EN",
                        "Neoplasm_EN",
                        "Neoplasm_EN",
                    ], null);
            }
            MooneMedium.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone02_Moone_Medium_EnemyBundle", 24, ZoneType_GameIDs.Orpheum_Hard, BundleDifficulty.Medium);
        }
    }
}
