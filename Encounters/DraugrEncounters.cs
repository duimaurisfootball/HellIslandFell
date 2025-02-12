using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Encounters
{
    public class DraugrEncounters
    {
        public static void Add()
        {
            Portals.AddPortalSign("Draugr_Sign", ResourceLoader.LoadSprite("TimelineDraugr", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);
            EnemyEncounter_API draugrEasy = new EnemyEncounter_API(0, "H_Zone01_Draugr_Hard_EnemyBundle", "Draugr_Sign")
            {
                MusicEvent = "event:/Music/Mx_Spoggle",
                RoarEvent = "event:/Characters/Player/LongLiver/CHR_PLR_LongLiver_Dx",
            };
            draugrEasy.CreateNewEnemyEncounterData(
                [
                    "Draugr_EN",
                    "Mung_EN",
                    "Mung_EN",
                ], null);
            draugrEasy.CreateNewEnemyEncounterData(
                [
                    "Draugr_EN",
                    "MudLung_EN",
                ], null);
            draugrEasy.CreateNewEnemyEncounterData(
                [
                    "Draugr_EN",
                    "Keko_EN",
                    "Keko_EN",
                ], null);
            draugrEasy.CreateNewEnemyEncounterData(
                [
                    "Draugr_EN",
                    "Jumble_Guts_Clotted_EN",
                ], null);
            draugrEasy.CreateNewEnemyEncounterData(
                [
                    "Draugr_EN",
                    "Jumble_Guts_Waning_EN",
                ], null);
            draugrEasy.CreateNewEnemyEncounterData(
                [
                    "Draugr_EN",
                    "Spoggle_Spitfire_EN",
                ], null);
            draugrEasy.CreateNewEnemyEncounterData(
                [
                    "Draugr_EN",
                    "Spoggle_Ruminating_EN",
                ], null);
            draugrEasy.CreateNewEnemyEncounterData(
                [
                    "Draugr_EN",
                    "Wringle_EN",
                    "Wringle_EN",
                ], null);
            draugrEasy.CreateNewEnemyEncounterData(
                [
                    "Draugr_EN",
                    "Flarblet_EN",
                    "Flarblet_EN",
                ], null);
            draugrEasy.CreateNewEnemyEncounterData(
                [
                    "Draugr_EN",
                    "Keklung_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                draugrEasy.CreateNewEnemyEncounterData(
                    [
                        "Draugr_EN",
                        "Flarbleft_EN",
                        "Flarbleft_EN",
                    ], null);
                draugrEasy.CreateNewEnemyEncounterData(
                    [
                        "Draugr_EN",
                        "LipBug_EN",
                        "MudLung_EN",
                    ], null);
                draugrEasy.CreateNewEnemyEncounterData(
                    [
                        "Draugr_EN",
                        "Draugr_EN",
                        "DrySimian_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.Colophons)
            {
                draugrEasy.CreateNewEnemyEncounterData(
                    [
                        "Draugr_EN",
                        "ColophonComposed_EN",
                    ], null);
                draugrEasy.CreateNewEnemyEncounterData(
                    [
                        "Draugr_EN",
                        "ColophonDefeated_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                draugrEasy.CreateNewEnemyEncounterData(
                    [
                        "Draugr_EN",
                        "Flakkid_EN",
                    ], null);
                draugrEasy.CreateNewEnemyEncounterData(
                    [
                        "Draugr_EN",
                        "Enno_EN",
                        "Enno_EN",
                    ], null);
                draugrEasy.CreateNewEnemyEncounterData(
                    [
                        "Draugr_EN",
                        "Draugr_EN",
                        "UnculturedSwine_EN",
                    ], null);
                draugrEasy.CreateNewEnemyEncounterData(
                    [
                        "Draugr_EN",
                        "DryBait_EN",
                        "UnculturedSwine_EN",
                    ], null);
            }
            draugrEasy.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone01_Draugr_Hard_EnemyBundle", 5, ZoneType_GameIDs.FarShore_Hard, BundleDifficulty.Easy);
        }
    }
}
