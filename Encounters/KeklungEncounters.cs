using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Encounters
{
    public class KeklungEncounters
    {
        public static void Add()
        {
            Portals.AddPortalSign("Keklung_Sign", ResourceLoader.LoadSprite("TimelineKeklung", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);
            EnemyEncounter_API keklungMedium = new EnemyEncounter_API(0, "H_Zone01_Keklung_Medium_EnemyBundle", "Keklung_Sign")
            {
                MusicEvent = "event:/Music/Mx_Mudlung",
                RoarEvent = "event:/Characters/Enemies/MudLung_Mungling/CHR_ENM_MudLung_Mungling_Roar",
            };
            keklungMedium.CreateNewEnemyEncounterData(
                [
                    "Keklung_EN",
                    "Keklung_EN",
                    "Keklung_EN",
                ], null);
            keklungMedium.CreateNewEnemyEncounterData(
                [
                    "Keklung_EN",
                    "MudLung_EN",
                    "MudLung_EN",
                ], null);
            keklungMedium.CreateNewEnemyEncounterData(
                [
                    "Keklung_EN",
                    "MudLung_EN",
                    "MunglingMudLung_EN",
                ], null);
            keklungMedium.CreateNewEnemyEncounterData(
                [
                    "Keklung_EN",
                    "Keko_EN",
                    "Keko_EN",
                    "Keko_EN",
                ], null);
            keklungMedium.CreateNewEnemyEncounterData(
                [
                    "Keklung_EN",
                    "Keklung_EN",
                    "Keko_EN",
                ], null);
            keklungMedium.CreateNewEnemyEncounterData(
                [
                    "Keklung_EN",
                    "Wringle_EN",
                    "Keko_EN",
                ], null);
            keklungMedium.CreateNewEnemyEncounterData(
                [
                    "Keklung_EN",
                    "Keklung_EN",
                    "Draugr_EN",
                ], null);
            keklungMedium.CreateNewEnemyEncounterData(
                [
                    "Keklung_EN",
                    "MudLung_EN",
                    "Draugr_EN",
                ], null);
            keklungMedium.CreateNewEnemyEncounterData(
                [
                    "Keklung_EN",
                    "Wringle_EN",
                    "Draugr_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                keklungMedium.CreateNewEnemyEncounterData(
                    [
                        "Keklung_EN",
                        "LipBug_EN",
                        "LipBug_EN",
                        "LipBug_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.Colophons)
            {
                keklungMedium.CreateNewEnemyEncounterData(
                    [
                        "Keklung_EN",
                        "Keko_EN",
                        "ColophonComposed_EN",
                    ], null);
                keklungMedium.CreateNewEnemyEncounterData(
                    [
                        "Keklung_EN",
                        "Keko_EN",
                        "ColophonDefeated_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                keklungMedium.CreateNewEnemyEncounterData(
                    [
                        "Keklung_EN",
                        "Keklung_EN",
                        "Flakkid_EN",
                        "Flakkid_EN",
                    ], null);
                keklungMedium.CreateNewEnemyEncounterData(
                    [
                        "Keklung_EN",
                        "MudLung_EN",
                        "Flakkid_EN",
                    ], null);
                keklungMedium.CreateNewEnemyEncounterData(
                    [
                        "Keklung_EN",
                        "FlaMingGoa_EN",
                        "Enno_EN",
                    ], null);
            }
            keklungMedium.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone01_Keklung_Medium_EnemyBundle", 12, ZoneType_GameIDs.FarShore_Hard, BundleDifficulty.Medium);
        }
    }
}
