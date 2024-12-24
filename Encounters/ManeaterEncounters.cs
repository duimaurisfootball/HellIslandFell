using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Encounters
{
    public class ManeaterEncounters
    {
        public static void Add()
        {
            Portals.AddPortalSign("Maneater_Sign", ResourceLoader.LoadSprite("TimelineManeater", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);
            EnemyEncounter_API ManeaterEasy = new EnemyEncounter_API(0, "H_Zone03_Maneater_Easy_EnemyBundle", "Maneater_Sign")
            {
                MusicEvent = "event:/MarbledPearls",
                RoarEvent = "event:/Characters/Enemies/Flarb/CHR_ENM_Flarb_Roar",
            };
            ManeaterEasy.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "NextOfKin_EN",
                    "NextOfKin_EN",
                ], null);
            ManeaterEasy.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "InHisImage",
                ], null);
            ManeaterEasy.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "ShiveringHomunculus_EN",
                    "ShiveringHomunculus_EN",
                ], null);
            ManeaterEasy.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "ChoirBoy_EN",
                ], null);
            ManeaterEasy.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "ProlificNosestone_EN",
                ], null);
            ManeaterEasy.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "UninspiredNosestone_EN",
                ], null);
            ManeaterEasy.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "Inequity_EN",
                ], null);
            ManeaterEasy.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "StickingHomunculus_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                ManeaterEasy.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "Unterling_EN",
                    ], null);
                ManeaterEasy.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "TitteringPeon_EN",
                    ], null);
                ManeaterEasy.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "ScreamingHomunculus_EN",
                    ], null);
            }
            ManeaterEasy.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_Maneater_Easy_EnemyBundle", 5, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Medium);

            EnemyEncounter_API ManeaterMedium = new EnemyEncounter_API(0, "H_Zone03_Maneater_Medium_EnemyBundle", "Maneater_Sign")
            {
                MusicEvent = "event:/MarbledPearls",
                RoarEvent = "event:/Characters/Enemies/Flarb/CHR_ENM_Flarb_Roar",
            };
            ManeaterMedium.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "Maneater_EN",
                ], null);
            ManeaterMedium.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "SkinningHomunculus_EN",
                ], null);
            ManeaterMedium.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "SkinningHomunculus_EN",
                    "ShiveringHomunculus_EN",
                ], null);
            ManeaterMedium.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "SkinningHomunculus_EN",
                    "InHisImage_EN",
                    "InHerImage_EN",
                ], null);
            ManeaterMedium.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "SkinningHomunculus_EN",
                    "ChoirBoy_EN",
                ], null);
            ManeaterMedium.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "Maneater_EN",
                    "ChoirBoy_EN",
                ], null);
            ManeaterMedium.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "ChoirBoy_EN",
                    "InHisImage_EN",
                    "InHerImage_EN",
                ], null);
            ManeaterMedium.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "GigglingMinister_EN",
                ], null);
            ManeaterMedium.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "GigglingMinister_EN",
                    "SweatingNosestone_EN",
                ], null);
            ManeaterMedium.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "SkinningHomunculus_EN",
                    "SweatingNosestone_EN",
                ], null);
            ManeaterMedium.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "SkinningHomunculus_EN",
                    "ProlificNosestone_EN",
                ], null);
            ManeaterMedium.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "UninspiredNosestone_EN",
                    "UninspiredNosestone_EN",
                ], null);
            ManeaterMedium.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "Inequity_EN",
                    "ChoirBoy_EN",
                ], null);
            ManeaterMedium.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "Inequity_EN",
                    "SkinningHomunculus_EN",
                ], null);
            ManeaterMedium.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "Inequity_EN",
                    "ProlificNosestone_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                ManeaterMedium.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "Unterling_EN",
                        "Unterling_EN",
                    ], null);
                ManeaterMedium.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "Unterling_EN",
                        "Inequity_EN",
                    ], null);
                ManeaterMedium.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "SterileBud_EN",
                        "ChoirBoy_EN",
                    ], null);
                ManeaterMedium.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "SterileBud_EN",
                        "Inequity_EN",
                    ], null);
                ManeaterMedium.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "StickingHomunculus_EN",
                        "ScreamingHomunculus_EN",
                    ], null);
                ManeaterMedium.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "ScreamingHomunculus_EN",
                        "MesmerizingNosestone_EN",
                    ], null);
                ManeaterMedium.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "TitteringPeon_EN",
                        "TitteringPeon_EN",
                        "UninspiredNosestone_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.EggKeeper)
            {
                ManeaterMedium.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "EggKeeper_EN",
                    ], null);
            }
            ManeaterMedium.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_Maneater_Medium_EnemyBundle", 4, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Medium);

            EnemyEncounter_API ManeaterHard = new EnemyEncounter_API(0, "H_Zone03_Maneater_Hard_EnemyBundle", "Maneater_Sign")
            {
                MusicEvent = "event:/MarbledPearls",
                RoarEvent = "event:/Characters/Enemies/Flarb/CHR_ENM_Flarb_Roar",
            };
            ManeaterHard.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "SkinningHomunculus_EN",
                    "ShiveringHomunculus_EN",
                ], null);
            ManeaterHard.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "Maneater_EN",
                    "SkinningHomunculus_EN",
                ], null);
            ManeaterHard.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "Maneater_EN",
                    "StickingHomunculus_EN",
                ], null);
            ManeaterHard.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "GigglingMinister_EN",
                    "GigglingMinister_EN",
                ], null);
            ManeaterHard.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "GigglingMinister_EN",
                    "SkinningHomunculus_EN",
                ], null);
            ManeaterHard.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "Maneater_EN",
                    "GigglingMinister_EN",
                ], null);
            ManeaterHard.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "ProlificNosestone_EN",
                    "SweatingNosestone_EN",
                ], null);
            ManeaterHard.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "Inequity_EN",
                    "SweatingNosestone_EN",
                ], null);
            ManeaterHard.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "Inequity_EN",
                    "SkinningHomunculus_EN",
                ], null);
            ManeaterHard.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "Inequity_EN",
                    "Maneater_EN",
                ], null);
            ManeaterHard.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "StickingHomunculus_EN",
                    "Maneater_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                ManeaterHard.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "Unterling_EN",
                        "Unterling_EN",
                        "Unterling_EN",
                    ], null);
                ManeaterHard.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "ImpenetrableAngler_EN",
                    ], null);
                ManeaterHard.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "ScreamingHomunculus_EN",
                        "ScreamingHomunculus_EN",
                        "ScreamingHomunculus_EN",
                    ], null);
                ManeaterHard.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "StickingHomunculus_EN",
                        "StickingHomunculus_EN",
                        "ScreamingHomunculus_EN",
                    ], null);
                ManeaterHard.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "SterileBud_EN",
                        "SterileBud_EN",
                        "SweatingNosestone_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.EggKeeper)
            {
                ManeaterHard.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "EggKeeper_EN",
                        "NextOfKin_EN",
                    ], null);
                ManeaterHard.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "EggKeeper_EN",
                        "ChoirBoy_EN",
                    ], null);
                ManeaterHard.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "EggKeeper_EN",
                        "SkinningHomunculus_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.EnemyPack && Hell_Island_Fell.CrossMod.EggKeeper)
            {
                ManeaterHard.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "EggKeeper_EN",
                        "SterileBud_EN",
                    ], null);
                ManeaterHard.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "EggKeeper_EN",
                        "Unterling_EN",
                    ], null);
            }
            ManeaterHard.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_Maneater_Hard_EnemyBundle", 10, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Hard);
        }
    }
}
