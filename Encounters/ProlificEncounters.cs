using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Encounters
{
    public class ProlificEncounters
    {
        public static void Add()
        {
            Portals.AddPortalSign("ProlificNosestone_Sign", ResourceLoader.LoadSprite("TimelineProlificNosestone", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);
            EnemyEncounter_API prolificMedium = new EnemyEncounter_API(0, "H_Zone03_ProlificNosestone_Medium_EnemyBundle", "ProlificNosestone_Sign")
            {
                MusicEvent = "event:/SniffStep",
                RoarEvent = "event:/ProlificRoar",
            };
            prolificMedium.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "ProlificNosestone_EN",
                ], null);
            prolificMedium.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "ChoirBoy_EN",
                    "ChoirBoy_EN",
                ], null);
            prolificMedium.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "GigglingMinister_EN",
                ], null);
            prolificMedium.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "InHisImage_EN",
                    "InHisImage_EN",
                    "InHisImage_EN",
                ], null);
            prolificMedium.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "NextOfKin_EN",
                    "NextOfKin_EN",
                    "NextOfKin_EN",
                    "NextOfKin_EN",
                ], null);
            prolificMedium.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "Maneater_EN",
                ], null);
            prolificMedium.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "StickingHomunculus_EN",
                    "StickingHomunculus_EN",
                ], null);
            prolificMedium.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "StickingHomunculus_EN",
                    "ShiveringHomunculus_EN",
                    "ShiveringHomunculus_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                prolificMedium.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "Unterling_EN",
                        "Unterling_EN",
                        "Unterling_EN",
                    ], null);
                prolificMedium.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "StickingHomunculus_EN",
                        "Unterling_EN",
                    ], null);
                prolificMedium.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "StickingHomunculus_EN",
                        "ScreamingHomunculus_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.EggKeeper)
            {
                prolificMedium.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "ProlificNosestone_EN",
                        "EggKeeper_EN",
                    ], null);
                prolificMedium.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "NextOfKin_EN",
                        "NextOfKin_EN",
                        "EggKeeper_EN",
                    ], null);
                prolificMedium.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "ShiveringHomunculus_EN",
                        "ShiveringHomunculus_EN",
                        "EggKeeper_EN",
                    ], null);
                prolificMedium.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "Inequity_EN",
                        "EggKeeper_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.EnemyPack && Hell_Island_Fell.CrossMod.EggKeeper)
            {
                prolificMedium.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "Unterling_EN",
                        "EggKeeper_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                prolificMedium.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "MarbleMaw_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                prolificMedium.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "ProlificNosestone_EN",
                        "Attrition_EN",
                    ], null);
                prolificMedium.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "Surrogate_EN",
                        "Surrogate_EN",
                    ], null);
                prolificMedium.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "Romantic_EN",
                        "Romantic_EN",
                    ], null);
            }
            prolificMedium.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_ProlificNosestone_Medium_EnemyBundle", 3, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Medium);

            EnemyEncounter_API prolificHard = new EnemyEncounter_API(0, "H_Zone03_ProlificNosestone_Hard_EnemyBundle", "ProlificNosestone_Sign")
            {
                MusicEvent = "event:/SniffStep",
                RoarEvent = "event:/ProlificRoar",
            };
            prolificHard.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "ProlificNosestone_EN",
                    "ProlificNosestone_EN",
                ], null);
            prolificHard.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "SkinningHomunculus_EN",
                    "SkinningHomunculus_EN",
                ], null);
            prolificHard.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "NextOfKin_EN",
                    "NextOfKin_EN",
                    "Inequity_EN",
                    "Inequity_EN",
                ], null);
            prolificHard.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "Maneater_EN",
                    "Inequity_EN",
                ], null);
            prolificHard.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "Inequity_EN",
                    "SkinningHomunculus_EN",
                ], null);
            prolificHard.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "Maneater_EN",
                    "StickingHomunculus_EN",
                ], null);
            prolificHard.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "SkinningHomunculus_EN",
                    "StickingHomunculus_EN",
                ], null);
            prolificHard.CreateNewEnemyEncounterData(
                [
                    "ProlificNosestone_EN",
                    "SkinningHomunculus_EN",
                    "ShiveringHomunculus_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "SkinningHomunculus_EN",
                        "ShiveringHomunculus_EN",
                        "ScreamingHomunculus_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "ProlificNosestone_EN",
                        "ShiveringHomunculus_EN",
                        "ScreamingHomunculus_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "Unterling_EN",
                        "ScreamingHomunculus_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "Unterling_EN",
                        "Unterling_EN",
                        "Unterling_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "ProlificNosestone_EN",
                        "ImpenetrableAngler_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.EggKeeper)
            {
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "StickingHomunculus_EN",
                        "ShiveringHomunculus_EN",
                        "EggKeeper_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "Maneater_EN",
                        "EggKeeper_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "ProlificNosestone_EN",
                        "ProlificNosestone_EN",
                        "EggKeeper_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "Inequity_EN",
                        "EggKeeper_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.EnemyPack && Hell_Island_Fell.CrossMod.EggKeeper)
            {
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "ImpenetrableAngler_EN",
                        "EggKeeper_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "ScreamingHomunculus_EN",
                        "SkinningHomunculus_EN",
                        "EggKeeper_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "ScreamingHomunculus_EN",
                        "ShiveringHomunculus_EN",
                        "EggKeeper_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "ScreamingHomunculus_EN",
                        "StickingHomunculus_EN",
                        "EggKeeper_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "Unterling_EN",
                        "Unterling_EN",
                        "EggKeeper_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "Unterling_EN",
                        "SterileBud_EN",
                        "EggKeeper_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "Vagabond_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "ProlificNosestone_EN",
                        "Vagabond_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "ProlificNosestone_EN",
                        "FrowningChancellor_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "Maneater_EN",
                        "Vagabond_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "StickingHomunculus_EN",
                        "Vagabond_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "SkinningHomunculus_EN",
                        "Vagabond_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "ProlificNosestone_EN",
                        "Git_EN",
                        "Git_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "ProlificNosestone_EN",
                        "Attrition_EN",
                        "Attrition_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "ProlificNosestone_EN",
                        "Romantic_EN",
                        "Romantic_EN",
                    ], null);
                prolificHard.CreateNewEnemyEncounterData(
                    [
                        "ProlificNosestone_EN",
                        "Surrogate_EN",
                        "Maneater_EN",
                    ], null);
            }
            prolificHard.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_ProlificNosestone_Hard_EnemyBundle", 3, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Hard);

        }
    }
}
