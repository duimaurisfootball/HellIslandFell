﻿using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Encounters
{
    public class KekingdomEncounters
    {
        public static void Add()
        {
            Portals.AddPortalSign("Kekingdom_Sign", ResourceLoader.LoadSprite("TimelineKekingdom", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);
            EnemyEncounter_API kekingdomHard = new EnemyEncounter_API(0, "H_Zone01_Kekingdom_Hard_EnemyBundle", "Kekingdom_Sign")
            {
                MusicEvent = "event:/Music/DLC_01/Mx_Kekastle_125",
                RoarEvent = "event:/Characters/Enemies/DLC_01/Kekastle/CHR_ENM_Kekastle_Roar",
            };
            kekingdomHard.CreateNewEnemyEncounterData(
                [
                    "Kekingdom_EN",
                ], null);
            kekingdomHard.CreateNewEnemyEncounterData(
                [
                    "Kekingdom_EN",
                    "Keko_EN",
                ], null);
            kekingdomHard.CreateNewEnemyEncounterData(
                [
                    "Kekingdom_EN",
                    "Mung_EN",
                ], null);
            kekingdomHard.CreateNewEnemyEncounterData(
                [
                    "Kekingdom_EN",
                    "Flarb_EN",
                ], null);
            kekingdomHard.CreateNewEnemyEncounterData(
                [
                    "Kekingdom_EN",
                    "Voboola_EN",
                ], null);
            kekingdomHard.CreateNewEnemyEncounterData(
                [
                    "Kekingdom_EN",
                    "VanishingHands_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                kekingdomHard.CreateNewEnemyEncounterData(
                    [
                        "Kekingdom_EN",
                        "Unflarb_EN",
                    ], null);
            }
            kekingdomHard.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone01_Kekingdom_Hard_EnemyBundle", 16, ZoneType_GameIDs.FarShore_Hard, BundleDifficulty.Hard);
        }
    }
}