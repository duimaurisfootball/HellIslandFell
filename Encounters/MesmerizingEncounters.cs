using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Encounters
{
    public class MesmerizingEncounters
    {
        public static void Add()
        {
            Portals.AddPortalSign("MesmerizingNosestone_Sign", ResourceLoader.LoadSprite("TimelineMesmerizingNosestone", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);
            EnemyEncounter_API mesmerizingMedium = new EnemyEncounter_API(0, "H_Zone03_MesmerizingNosestone_Medium_EnemyBundle", "MesmerizingNosestone_Sign")
            {
                MusicEvent = "event:/SniffStep",
                RoarEvent = "event:/MesmerizingRoar",
            };
            mesmerizingMedium.CreateNewEnemyEncounterData(
                [
                    "MesmerizingNosestone_EN",
                    "InHisImage_EN",
                    "InHerImage_EN",
                    "NextOfKin_EN",
                ], null);
            mesmerizingMedium.CreateNewEnemyEncounterData(
                [
                    "MesmerizingNosestone_EN",
                    "ChoirBoy_EN",
                    "ChoirBoy_EN",
                ], null);
            mesmerizingMedium.CreateNewEnemyEncounterData(
                [
                    "MesmerizingNosestone_EN",
                    "Maneater_EN",
                ], null);
            mesmerizingMedium.CreateNewEnemyEncounterData(
                [
                    "MesmerizingNosestone_EN",
                    "StickingHomunculus_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                mesmerizingMedium.CreateNewEnemyEncounterData(
                    [
                        "MesmerizingNosestone_EN",
                        "Unterling_EN",
                    ], null);
                mesmerizingMedium.CreateNewEnemyEncounterData(
                    [
                        "MesmerizingNosestone_EN",
                        "TitteringPeon_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.EggKeeper)
            {
                mesmerizingMedium.CreateNewEnemyEncounterData(
                    [
                        "MesmerizingNosestone_EN",
                        "EggKeeper_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                mesmerizingMedium.CreateNewEnemyEncounterData(
                    [
                        "MesmerizingNosestone_EN",
                        "FrowningChancellor_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                mesmerizingMedium.CreateNewEnemyEncounterData(
                    [
                        "MesmerizingNosestone_EN",
                        "Attrition_EN",
                    ], null);
            }
            mesmerizingMedium.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_MesmerizingNosestone_Medium_EnemyBundle", 2, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Medium);

            EnemyEncounter_API mesmerizingHard = new EnemyEncounter_API(0, "H_Zone03_MesmerizingNosestone_Hard_EnemyBundle", "MesmerizingNosestone_Sign")
            {
                MusicEvent = "event:/SniffStep",
                RoarEvent = "event:/MesmerizingRoar",
            };
            mesmerizingHard.CreateNewEnemyEncounterData(
                [
                    "MesmerizingNosestone_EN",
                    "MesmerizingNosestone_EN",
                    "InHisImage_EN",
                    "InHisImage_EN",
                ], null);
            mesmerizingHard.CreateNewEnemyEncounterData(
                [
                    "MesmerizingNosestone_EN",
                    "MesmerizingNosestone_EN",
                    "SkinningHomunculus_EN",
                ], null);
            mesmerizingHard.CreateNewEnemyEncounterData(
                [
                    "MesmerizingNosestone_EN",
                    "SweatingNosestone_EN",
                    "GigglingMinister_EN",
                ], null);
            mesmerizingHard.CreateNewEnemyEncounterData(
                [
                    "MesmerizingNosestone_EN",
                    "ProlificNosestone_EN",
                    "Maneater_EN",
                ], null);
            mesmerizingHard.CreateNewEnemyEncounterData(
                [
                    "MesmerizingNosestone_EN",
                    "Inequity_EN",
                    "GigglingMinister_EN",
                ], null);
            mesmerizingHard.CreateNewEnemyEncounterData(
                [
                    "MesmerizingNosestone_EN",
                    "StickingHomunculus_EN",
                    "GigglingMinister_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                mesmerizingHard.CreateNewEnemyEncounterData(
                    [
                        "MesmerizingNosestone_EN",
                        "TitteringPeon_EN",
                        "TitteringPeon_EN",
                    ], null);
                mesmerizingHard.CreateNewEnemyEncounterData(
                    [
                        "MesmerizingNosestone_EN",
                        "TitteringPeon_EN",
                        "GigglingMinister_EN",
                    ], null);
                mesmerizingHard.CreateNewEnemyEncounterData(
                    [
                        "MesmerizingNosestone_EN",
                        "TitteringPeon_EN",
                        "Inequity_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.EggKeeper)
            {
                mesmerizingHard.CreateNewEnemyEncounterData(
                    [
                        "MesmerizingNosestone_EN",
                        "GigglingMinister_EN",
                        "EggKeeper_EN",
                    ], null);
                mesmerizingHard.CreateNewEnemyEncounterData(
                    [
                        "MesmerizingNosestone_EN",
                        "InHisImage_EN",
                        "InHisImage_EN",
                        "EggKeeper_EN",
                    ], null);
                mesmerizingHard.CreateNewEnemyEncounterData(
                    [
                        "MesmerizingNosestone_EN",
                        "StickingHomunculus_EN",
                        "EggKeeper_EN",
                    ], null);
                mesmerizingHard.CreateNewEnemyEncounterData(
                    [
                        "MesmerizingNosestone_EN",
                        "Inequity_EN",
                        "EggKeeper_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.EnemyPack && Hell_Island_Fell.CrossMod.EggKeeper)
            {
                mesmerizingHard.CreateNewEnemyEncounterData(
                    [
                        "MesmerizingNosestone_EN",
                        "TitteringPeon_EN",
                        "EggKeeper_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                mesmerizingHard.CreateNewEnemyEncounterData(
                    [
                        "MesmerizingNosestone_EN",
                        "MarbleMaw_EN",
                        "SkinningHomunculus_EN",
                    ], null);
                mesmerizingHard.CreateNewEnemyEncounterData(
                    [
                        "MesmerizingNosestone_EN",
                        "FrowningChancellor_EN",
                        "InHisImage_EN",
                        "InHisImage_EN",
                    ], null);
                mesmerizingHard.CreateNewEnemyEncounterData(
                    [
                        "MesmerizingNosestone_EN",
                        "Vagabond_EN",
                        "Maneater_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                mesmerizingHard.CreateNewEnemyEncounterData(
                    [
                        "MesmerizingNosestone_EN",
                        "Romantic_EN",
                        "Maneater_EN",
                    ], null);
                mesmerizingHard.CreateNewEnemyEncounterData(
                    [
                        "MesmerizingNosestone_EN",
                        "Surrogate_EN",
                        "Surrogate_EN",
                    ], null);
                mesmerizingHard.CreateNewEnemyEncounterData(
                    [
                        "MesmerizingNosestone_EN",
                        "Surrogate_EN",
                        "Attrition_EN",
                    ], null);
            }
            mesmerizingHard.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_MesmerizingNosestone_Hard_EnemyBundle", 2, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Hard);

        }
    }
}
