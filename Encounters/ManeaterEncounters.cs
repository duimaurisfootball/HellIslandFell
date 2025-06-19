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
                    "InHisImage_EN",
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
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                ManeaterEasy.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "MarbleMaw_EN",
                    ], null);
                ManeaterEasy.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "FrowningChancellor_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                ManeaterEasy.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "Git_EN",
                    ], null);
                ManeaterEasy.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "Attrition_EN",
                    ], null);
                ManeaterEasy.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "InHerImage_EN",
                        "Romantic_EN",
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
                    "InHisImage_EN",
                    "InHisImage_EN",
                    "InHerImage_EN",
                ], null);
            ManeaterMedium.CreateNewEnemyEncounterData(
                [
                    "Maneater_EN",
                    "ChoirBoy_EN",
                    "ChoirBoy_EN",
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
                        "SterileBud_EN",
                        "SterileBud_EN",
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
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                ManeaterMedium.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "FrowningChancellor_EN",
                        "NextOfKin_EN",
                    ], null);
                ManeaterMedium.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "Vagabond_EN",
                    ], null);
                ManeaterMedium.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "FrowningChancellor_EN",
                        "SweatingNosestone_EN",
                    ], null);
                ManeaterMedium.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "FrowningChancellor_EN",
                        "ProlificNosestone_EN",
                    ], null);
                ManeaterMedium.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "FrowningChancellor_EN",
                        "StickingHomunculus_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                ManeaterMedium.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "StickingHomunculus_EN",
                        "Git_EN",
                    ], null);
                ManeaterMedium.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "Surrogate_EN",
                        "Surrogate_EN",
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
                    "SkinningHomunculus_EN",
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
                    "Maneater_EN",
                    "Inequity_EN",
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
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                ManeaterHard.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "Maneater_EN",
                        "FrowningChancellor_EN",
                    ], null);
                ManeaterHard.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "Maneater_EN",
                        "MarbleMaw_EN",
                    ], null);
                ManeaterHard.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "Maneater_EN",
                        "Vagabond_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                ManeaterHard.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "Maneater_EN",
                        "Attrition_EN",
                    ], null);
                ManeaterHard.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "Attrition_EN",
                        "Attrition_EN",
                        "Attrition_EN",
                    ], null);
                ManeaterHard.CreateNewEnemyEncounterData(
                    [
                        "Maneater_EN",
                        "SkinningHomunculus_EN",
                        "Git_EN",
                    ], null);
            }
            ManeaterHard.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_Maneater_Hard_EnemyBundle", 10, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Hard);
        }
    }
}
