using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Encounters
{
    public class FlatbackEncounters
    {
        public static void Add()
        {
            Portals.AddPortalSign("Flatback_Sign", ResourceLoader.LoadSprite("TimelineFlatback", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);
            EnemyEncounter_API flatbackHard = new EnemyEncounter_API(0, "H_Zone01_Flatback_Hard_EnemyBundle", "Flatback_Sign")
            {
                MusicEvent = "event:/Enormounclature",
                RoarEvent = "event:/Characters/Enemies/Mung/CHR_ENM_Mung_Roar",
            };
            flatbackHard.CreateNewEnemyEncounterData(
                [
                    "Flatback_EN",
                ], null);
            flatbackHard.CreateNewEnemyEncounterData(
                [
                    "Flatback_EN",
                    "MudLung_EN",
                ], null);
            flatbackHard.CreateNewEnemyEncounterData(
                [
                    "Flatback_EN",
                    "Wringle_EN",
                ], null);
            flatbackHard.CreateNewEnemyEncounterData(
                [
                    "Flatback_EN",
                    "FlaMinGoa_EN",
                ], null);
            flatbackHard.CreateNewEnemyEncounterData(
                [
                    "Flatback_EN",
                    "Flarblet_EN",
                    "Flarblet_EN",
                ], null);
            flatbackHard.CreateNewEnemyEncounterData(
                [
                    "Flatback_EN",
                    "Keko_EN",
                ], null);
            flatbackHard.CreateNewEnemyEncounterData(
                [
                    "Flatback_EN",
                    "Keko_EN",
                    "Keko_EN",
                ], null);
            flatbackHard.CreateNewEnemyEncounterData(
                [
                    "Flatback_EN",
                    "Flarb_EN",
                ], null);
            flatbackHard.CreateNewEnemyEncounterData(
                [
                    "Flatback_EN",
                    "Voboola_EN",
                ], null);
            flatbackHard.CreateNewEnemyEncounterData(
                [
                    "Flatback_EN",
                    "JumbleGuts_Waning_EN",
                    "JumbleGuts_Clotted_EN",
                ], null);
            flatbackHard.CreateNewEnemyEncounterData(
                [
                    "Flatback_EN",
                    "Spoggle_Spitfire_EN",
                ], null);
            flatbackHard.CreateNewEnemyEncounterData(
                [
                    "Flatback_EN",
                    "Spoggle_Ruminating_EN",
                ], null);
            flatbackHard.CreateNewEnemyEncounterData(
                [
                    "Flatback_EN",
                    "Keklung_EN",
                ], null);
            flatbackHard.CreateNewEnemyEncounterData(
                [
                    "Flatback_EN",
                    "VanishingHands_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "Flarbleft_EN",
                    ], null);
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "MudLung_EN",
                        "Flarbleft_EN",
                    ], null);
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "LipBug_EN",
                    ], null);
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "Spoggle_Spitfire_EN",
                        "LipBug_EN",
                    ], null);
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "Spoggle_Ruminating_EN",
                        "LipBug_EN",
                    ], null);
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "Nephilim_EN",
                    ], null);
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "Seraphim_EN",
                    ], null);
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "JumbleGuts_Clotted_EN",
                        "Seraphim_EN",
                    ], null);
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "Unflarb_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.Colophons)
            {
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "ColophonComposed_EN",
                    ], null);
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "ColophonDefeated_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "Flakkid_EN",
                    ], null);
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "JumbleGuts_Waning_EN",
                        "Flakkid_EN",
                    ], null);
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "FlaMinGoa_EN",
                        "Flakkid_EN",
                    ], null);
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "Flarblet_EN",
                        "Flakkid_EN",
                    ], null);
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "Enno_EN",
                    ], null);
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "JumbleGuts_Waning_EN",
                        "Enno_EN",
                    ], null);
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "JumbleGuts_Clotted_EN",
                        "Enno_EN",
                    ], null);
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "MudLung_EN",
                        "Enno_EN",
                    ], null);
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "Enno_EN",
                        "Enno_EN",
                    ], null);
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "MudLung_EN",
                        "DryBait_EN",
                    ], null);
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "DryBait_EN",
                    ], null);
                flatbackHard.CreateNewEnemyEncounterData(
                    [
                        "Flatback_EN",
                        "NotAn_EN",
                    ], null);
            }
            flatbackHard.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone01_Flatback_Hard_EnemyBundle", 30, ZoneType_GameIDs.FarShore_Hard, BundleDifficulty.Hard);
        }
    }
}
