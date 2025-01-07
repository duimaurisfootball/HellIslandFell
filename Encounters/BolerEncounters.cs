using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Encounters
{
    public class BolerEncounters
    {
        public static void Add()
        {
            Portals.AddPortalSign("Boler_Sign", ResourceLoader.LoadSprite("TimelineBoler", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);

            EnemyEncounter_API BolerMedium = new EnemyEncounter_API(0, "H_Zone02_Boler_Medium_EnemyBundle", "Boler_Sign")
            {
                MusicEvent = "event:/Leaning300",
                RoarEvent = "event:/Characters/Enemies/DLC_01/ChoirBoy/CHR_ENM_ChoirBoy_Roar",
            };
            BolerMedium.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "MusicMan_EN",
                    "MusicMan_EN",
                ], null);
            BolerMedium.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Moone_EN",
                    "MusicMan_EN",
                ], null);
            BolerMedium.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "MusicMan_EN",
                    "MusicMan_EN",
                    "SingingStone_EN",
                ], null);
            BolerMedium.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "MusicMan_EN",
                    "SingingStone_EN",
                    "SingingStone_EN",
                ], null);
            BolerMedium.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "MusicMan_EN",
                    "SilverSuckle_EN",
                ], null);
            BolerMedium.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Moone_EN",
                    "Moone_EN",
                ], null);
            BolerMedium.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Moone_EN",
                    "Moone_EN",
                    "SingingStone_EN",
                ], null);
            BolerMedium.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Scrungie_EN",
                    "Scrungie_EN",
                ], null);
            BolerMedium.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Scrungie_EN",
                    "Scrungie_EN",
                    "SingingStone_EN",
                ], null);
            BolerMedium.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
                    "SingingStone_EN",
                    "SingingStone_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Neoplasm_EN",
                        "Neoplasm_EN",
                        "Neoplasm_EN",
                        "SingingStone_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Scrungie_EN",
                        "Scrungie_EN",
                        "Neoplasm_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Chapman_EN",
                        "Chapman_EN",
                        "Chapman_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Chapman_EN",
                        "SingingStone_EN",
                        "SingingStone_EN",
                        "SingingStone_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Seraphim_EN",
                        "Seraphim_EN",
                        "SingingStone_EN",
                        "SingingStone_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "ManicMan_EN",
                        "ManicMan_EN",
                        "DesiccatingJumbleguts_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Neoplasm_EN",
                        "Neoplasm_EN",
                        "DesiccatingJumbleguts_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "ManicMan_EN",
                        "ManicMan_EN",
                        "Neoplasm_EN",
                        "Neoplasm_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Footshroom_EN",
                        "ManicMan_EN",
                        "ManicMan_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Footshroom_EN",
                        "VanishingHands_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Footshroom_EN",
                        "Moone_EN",
                        "Moone_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Footshroom_EN",
                        "SilverSuckle_EN",
                        "SilverSuckle_EN",
                        "SilverSuckle_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Frostbite_EN",
                        "Frostbite_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Frostbite_EN",
                        "Frostbite_EN",
                        "Frostbite_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "BipedalFrostbite_EN",
                        "Frostbite_EN",
                        "Frostbite_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Jansuli_EN",
                        "Jansuli_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "BackupDancer_EN",
                        "MusicMan_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Gizard_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "BackupDancer_EN",
                        "BackupDancer_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "PrimitiveGizo_EN",
                    ], null);
            }
            BolerMedium.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone02_Boler_Medium_EnemyBundle", 6, ZoneType_GameIDs.Orpheum_Hard, BundleDifficulty.Medium);

            EnemyEncounter_API BolerHard = new EnemyEncounter_API(0, "H_Zone02_Boler_Hard_EnemyBundle", "Boler_Sign")
            {
                MusicEvent = "event:/Leaning300",
                RoarEvent = "event:/Characters/Enemies/DLC_01/ChoirBoy/CHR_ENM_ChoirBoy_Roar",
            };
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
                    "SingingStone_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
                    "Moone_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "MusicMan_EN",
                    "MusicMan_EN",
                    "MusicMan_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "MusicMan_EN",
                    "MusicMan_EN",
                    "Moone_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "MusicMan_EN",
                    "MusicMan_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "MusicMan_EN",
                    "MusicMan_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "MusicMan_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Conductor_EN",
                    "SilverSuckle_EN",
                    "SilverSuckle_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Conductor_EN",
                    "Moone_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Conductor_EN",
                    "MusicMan_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Conductor_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Scrungie_EN",
                    "Scrungie_EN",
                    "Scrungie_EN",
                    "MusicMan_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Revola_EN",
                    "MusicMan_EN",
                    "MusicMan_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Revola_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Revola_EN",
                    "SilverSuckle_EN",
                    "SilverSuckle_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Revola_EN",
                    "Moone_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "JumbleGuts_Clotted_EN",
                    "JumbleGuts_Waning_EN",
                    "JumbleGuts_Hollowing_EN",
                    "JumbleGuts_Flummoxing_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Spoggle_Writhing_EN",
                    "Spoggle_Spitfire_EN",
                    "Spoggle_Ruminating_EN",
                    "Spoggle_Resonant_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "SilverSuckle_EN",
                    "VanishingHands_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.Colophons)
            {
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "ColophonDefeated_EN",
                        "ColophonMaladjusted_EN",
                        "ColophonComposed_EN",
                        "ColophonDelighted_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "ColophonDefeated_EN",
                        "JumbleGuts_Clotted_EN",
                        "Spoggle_Writhing_EN",
                        "SilverSuckle_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "ColophonMaladjusted_EN",
                        "JumbleGuts_Waning_EN",
                        "Spoggle_Spitfire_EN",
                        "SilverSuckle_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "ColophonComposed_EN",
                        "JumbleGuts_Hollowing_EN",
                        "Spoggle_Ruminating_EN",
                        "SilverSuckle_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "ColophonDelighted_EN",
                        "JumbleGuts_Flummoxing_EN",
                        "Spoggle_Resonant_EN",
                        "SilverSuckle_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "NeoplasmLake_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Chapbull_EN",
                        "Chapman_EN",
                        "SilverSuckle_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Chapbull_EN",
                        "ManicMan_EN",
                        "ManicMan_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "NeoplasmHeap_EN",
                        "ManicMan_EN",
                        "ManicMan_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "RevoltingRevola_EN",
                        "SilverSuckle_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Seraphim_EN",
                        "Revola_EN",
                    ], null);
            }
            if(Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Footshroom_EN",
                        "Frostbite_EN",
                        "Frostbite_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Footshroom_EN",
                        "Gizard_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Gizard_EN",
                        "Moone_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Gizard_EN",
                        "VanishingHands_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Jansuli_EN",
                        "Jansuli_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Jansuli_EN",
                        "VanishingHands_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Frostbite_EN",
                        "Frostbite_EN",
                        "Frostbite_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "BipedalFrostbite_EN",
                        "BipedalFrostbite_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "BackupDancer_EN",
                        "MusicMan_EN",
                        "MusicMan_EN",
                        "MusicMan_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "BackupDancer_EN",
                        "MusicMan_EN",
                        "MusicMan_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "BackupDancer_EN",
                        "BackupDancer_EN",
                        "MusicMan_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "BackupDancer_EN",
                        "BackupDancer_EN",
                        "BackupDancer_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "BackupDancer_EN",
                        "BackupDancer_EN",
                        "ManicMan_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "BackupDancer_EN",
                        "ManicMan_EN",
                        "ManicMan_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "BackupDancer_EN",
                        "ManicMan_EN",
                        "ManicMan_EN",
                        "ManicMan_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "BackupDancer_EN",
                        "Scrungie_EN",
                        "Scrungie_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "BackupDancer_EN",
                        "BackupDancer_EN",
                        "Moone_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "BackupDancer_EN",
                        "MusicMan_EN",
                        "Moone_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "BackupDancer_EN",
                        "ManicMan_EN",
                        "Moone_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Footshroom_EN",
                        "Scrungie_EN",
                        "Scrungie_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "PrimitiveGizo_EN",
                        "SingingStone_EN",
                        "SingingStone_EN",
                        "SingingStone_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Gizard_EN",
                        "Revola_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Footshroom_EN",
                        "Revola_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "BackupDancer_EN",
                        "Revola_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Frostbite_EN",
                        "Frostbite_EN",
                        "Revola_EN",
                    ], null);
            }
            BolerHard.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone02_Boler_Hard_EnemyBundle", 10, ZoneType_GameIDs.Orpheum_Hard, BundleDifficulty.Hard);

            EnemyEncounter_API Boler2 = new EnemyEncounter_API(0, "H_Zone02_DoubleBoler_EnemyBundle", "Boler_Sign")
            {
                MusicEvent = "event:/Leaning300",
                RoarEvent = "event:/Characters/Enemies/DLC_01/ChoirBoy/CHR_ENM_ChoirBoy_Roar",
            };
            Boler2.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Boler_EN",
                    "Boler_EN",
                ], null);
            Boler2.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Boler_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
                ], null);
            Boler2.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Boler_EN",
                    "Revola_EN",
                ], null);
            Boler2.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Boler_EN",
                    "SilverSuckle_EN",
                    "SilverSuckle_EN",
                    "SilverSuckle_EN",
                ], null);
            Boler2.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Boler_EN",
                    "Conductor_EN",
                ], null);
            Boler2.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Boler_EN",
                    "MusicMan_EN",
                    "MusicMan_EN",
                ], null);
            Boler2.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Boler_EN",
                    "SingingStone_EN",
                    "SingingStone_EN",
                    "SingingStone_EN",
                ], null);
            Boler2.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Boler_EN",
                    "WrigglingSacrifice_EN",
                ], null);
            Boler2.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Boler_EN",
                    "Moone_EN",
                ], null);
            Boler2.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Boler_EN",
                    "VanishingHands_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                Boler2.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Boler_EN",
                        "Ophanim_EN",
                    ], null);
                Boler2.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Boler_EN",
                        "RevoltingRevola_EN",
                    ], null);
                Boler2.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Boler_EN",
                        "Chapbull_EN",
                        "Chapman_EN",
                    ], null);
                Boler2.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Boler_EN",
                        "Gizo_EN",
                        "NakedGizo_EN",
                    ], null);
                Boler2.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Boler_EN",
                        "Seraphim_EN",
                        "Seraphim_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                Boler2.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Boler_EN",
                        "Gizard_EN",
                    ], null);
                Boler2.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Boler_EN",
                        "Footshroom_EN",
                    ], null);
                Boler2.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Boler_EN",
                        "Jansuli_EN",
                        "Jansuli_EN",
                    ], null);
                Boler2.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Boler_EN",
                        "BackupDancer_EN",
                        "BackupDancer_EN",
                    ], null);
                Boler2.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Boler_EN",
                        "Frostbite_EN",
                        "Frostbite_EN",
                        "Frostbite_EN",
                    ], null);
                Boler2.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Boler_EN",
                        "BipedalFrostbite_EN",
                        "BipedalFrostbite_EN",
                    ], null);
                Boler2.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Boler_EN",
                        "PrimitiveGizo_EN",
                    ], null);
            }
            Boler2.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone02_DoubleBoler_EnemyBundle", 2, ZoneType_GameIDs.Orpheum_Hard, BundleDifficulty.Hard);
        }
    }
}
