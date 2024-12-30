using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Encounters
{
    public class StickingHomunculusEncounters
    {
        public static void Add()
        {
            Portals.AddPortalSign("StickingHomunculus_Sign", ResourceLoader.LoadSprite("TimelineStickingHomunculus", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);
            EnemyEncounter_API StickingMedium = new EnemyEncounter_API(0, "H_Zone03_StickingHomunculus_Medium_EnemyBundle", "StickingHomunculus_Sign")
            {
                MusicEvent = "event:/Music/Mx_Hommunculus",
                RoarEvent = "event:/Characters/Enemies/Homunculus_Shivering/CHR_ENM_Homunculus_Shivering_Roar",
            };
            StickingMedium.CreateNewEnemyEncounterData(
                [
                    "StickingHomunculus_EN",
                    "StickingHomunculus_EN",
                    "ShiveringHomunculus_EN",
                ], null);
            StickingMedium.CreateNewEnemyEncounterData(
                [
                    "StickingHomunculus_EN",
                    "ShiveringHomunculus_EN",
                    "ShiveringHomunculus_EN",
                ], null);
            StickingMedium.CreateNewEnemyEncounterData(
                [
                    "StickingHomunculus_EN",
                    "StickingHomunculus_EN",
                    "ShiveringHomunculus_EN",
                    "ShiveringHomunculus_EN",
                ], null);
            StickingMedium.CreateNewEnemyEncounterData(
                [
                    "StickingHomunculus_EN",
                    "ShiveringHomunculus_EN",
                    "ShiveringHomunculus_EN",
                    "ShiveringHomunculus_EN",
                ], null);
            StickingMedium.CreateNewEnemyEncounterData(
                [
                    "StickingHomunculus_EN",
                    "SkinningHomunculus_EN",
                ], null);
            StickingMedium.CreateNewEnemyEncounterData(
                [
                    "StickingHomunculus_EN",
                    "InHisImage_EN",
                    "InHisImage_EN",
                    "InHerImage_EN",
                ], null);
            StickingMedium.CreateNewEnemyEncounterData(
                [
                    "StickingHomunculus_EN",
                    "SweatingNosestone_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EggKeeper)
            {
                StickingMedium.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "EggKeeper_EN",
                    ], null);
                StickingMedium.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "ChoirBoy_EN",
                        "EggKeeper_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                StickingMedium.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "ShiveringHomunculus_EN",
                        "MarbleMaw_EN",
                    ], null);
                StickingMedium.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "ShiveringHomunculus_EN",
                        "Vagabond_EN",
                    ], null);
            }
            StickingMedium.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_StickingHomunculus_Medium_EnemyBundle", 8, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Medium);
            EnemyEncounter_API StickingHard = new EnemyEncounter_API(0, "H_Zone03_StickingHomunculus_Hard_EnemyBundle", "StickingHomunculus_Sign")
            {
                MusicEvent = "event:/Music/Mx_Hommunculus",
                RoarEvent = "event:/Characters/Enemies/Homunculus_Shivering/CHR_ENM_Homunculus_Shivering_Roar",
            };
            StickingHard.CreateNewEnemyEncounterData(
                [
                    "StickingHomunculus_EN",
                    "StickingHomunculus_EN",
                    "StickingHomunculus_EN",
                ], null);
            StickingHard.CreateNewEnemyEncounterData(
                [
                    "StickingHomunculus_EN",
                    "StickingHomunculus_EN",
                    "SkinningHomunculus_EN",
                ], null);
            StickingHard.CreateNewEnemyEncounterData(
                [
                    "StickingHomunculus_EN",
                    "StickingHomunculus_EN",
                    "SkinningHomunculus_EN",
                    "ShiveringHomunculus_EN",
                ], null);
            StickingHard.CreateNewEnemyEncounterData(
                [
                    "StickingHomunculus_EN",
                    "ChoirBoy_EN",
                    "ChoirBoy_EN",
                ], null);
            StickingHard.CreateNewEnemyEncounterData(
                [
                    "StickingHomunculus_EN",
                    "ChoirBoy_EN",
                    "Inequity_EN",
                ], null);
            StickingHard.CreateNewEnemyEncounterData(
                [
                    "StickingHomunculus_EN",
                    "SkinningHomunculus_EN",
                    "GigglingMinister_EN",
                ], null);
            StickingHard.CreateNewEnemyEncounterData(
                [
                    "StickingHomunculus_EN",
                    "SkinningHomunculus_EN",
                    "ChoirBoy_EN",
                ], null);
            StickingHard.CreateNewEnemyEncounterData(
                [
                    "StickingHomunculus_EN",
                    "SkinningHomunculus_EN",
                    "Inequity_EN",
                ], null);
            StickingHard.CreateNewEnemyEncounterData(
                [
                    "StickingHomunculus_EN",
                    "StickingHomunculus_EN",
                    "InHisImage_EN",
                    "InHerImage_EN",
                ], null);
            StickingHard.CreateNewEnemyEncounterData(
                [
                    "StickingHomunculus_EN",
                    "StickingHomunculus_EN",
                    "Maneater_EN",
                ], null);
            StickingHard.CreateNewEnemyEncounterData(
                [
                    "StickingHomunculus_EN",
                    "ProlificNosestone_EN",
                    "SweatingNosestone_EN",
                ], null);
            StickingHard.CreateNewEnemyEncounterData(
                [
                    "StickingHomunculus_EN",
                    "StickingHomunculus_EN",
                    "ProlificNosestone_EN",
                ], null);
            StickingHard.CreateNewEnemyEncounterData(
                [
                    "StickingHomunculus_EN",
                    "StickingHomunculus_EN",
                    "SweatingNosestone_EN",
                ], null);
            StickingHard.CreateNewEnemyEncounterData(
                [
                    "StickingHomunculus_EN",
                    "SweatingNosestone_EN",
                    "ShiveringHomunculus_EN",
                    "ShiveringHomunculus_EN",
                    "ShiveringHomunculus_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                StickingHard.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "StickingHomunculus_EN",
                        "ScreamingHomunculus_EN",
                        "ShiveringHomunculus_EN",
                    ], null);
                StickingHard.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "StickingHomunculus_EN",
                        "ScreamingHomunculus_EN",
                        "SkinningHomunculus_EN",
                    ], null);
                StickingHard.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "StickingHomunculus_EN",
                        "ScreamingHomunculus_EN",
                        "ScreamingHomunculus_EN",
                    ], null);
                StickingHard.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "StickingHomunculus_EN",
                        "SterileBud_EN",
                        "SterileBud_EN",
                    ], null);
                StickingHard.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "StickingHomunculus_EN",
                        "Unterling_EN",
                        "Unterling_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.EggKeeper)
            {
                StickingHard.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "SkinningHomunculus_EN",
                        "EggKeeper_EN",
                    ], null);
                StickingHard.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "SweatingNosestone_EN",
                        "EggKeeper_EN",
                    ], null);
                StickingHard.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "ProlificNosestone_EN",
                        "EggKeeper_EN",
                    ], null);
                StickingHard.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "Inequity_EN",
                        "EggKeeper_EN",
                    ], null);
                StickingHard.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "ShiveringHomunculus_EN",
                        "EggKeeper_EN",
                    ], null);
                StickingHard.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "ChoirBoy_EN",
                        "EggKeeper_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.EnemyPack && Hell_Island_Fell.CrossMod.EggKeeper)
            {
                StickingHard.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "ScreamingHomunculus_EN",
                        "EggKeeper_EN",
                    ], null);
                StickingHard.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "SterileBud_EN",
                        "EggKeeper_EN",
                    ], null);
                StickingHard.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "Unterling_EN",
                        "EggKeeper_EN",
                    ], null);
                StickingHard.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "ShiveringHomunculus_EN",
                        "ScreamingHomunculus_EN",
                        "EggKeeper_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                StickingHard.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "StickingHomunculus_EN",
                        "ShiveringHomunculus_EN",
                        "FrowningChancellor_EN",
                    ], null);
                StickingHard.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "StickingHomunculus_EN",
                        "ShiveringHomunculus_EN",
                        "Vagabond_EN",
                    ], null);
                StickingHard.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "ShiveringHomunculus_EN",
                        "ShiveringHomunculus_EN",
                        "MarbleMaw_EN",
                    ], null);
                StickingHard.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "StickingHomunculus_EN",
                        "SweatingNosestone_EN",
                        "Vagabond_EN",
                    ], null);
                StickingHard.CreateNewEnemyEncounterData(
                    [
                        "StickingHomunculus_EN",
                        "StickingHomunculus_EN",
                        "MesmerizingNosestone_EN",
                        "Vagabond_EN",
                    ], null);
            }
            StickingHard.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_StickingHomunculus_Hard_EnemyBundle", 10, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Hard);
        }
    }
}
