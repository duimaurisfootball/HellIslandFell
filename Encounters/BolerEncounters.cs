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
                    "SilverSuckle_EN",
                ], null);
            BolerMedium.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "SilverSuckle_EN",
                    "SilverSuckle_EN",
                    "SilverSuckle_EN",
                    "SilverSuckle_EN",
                ], null);
            BolerMedium.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "SingingStone_EN",
                    "SingingStone_EN",
                    "SingingStone_EN",
                    "SingingStone_EN",
                ], null);
            BolerMedium.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
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
                    "Heehoo_EN",
                ], null);
            BolerMedium.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Thunderdome_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "NakedGizo_EN",
                        "NakedGizo_EN",
                        "SilverSuckle_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Seraphim_EN",
                        "SilverSuckle_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Chapman_EN",
                        "Chapman_EN",
                        "SilverSuckle_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "BackupDancer_EN",
                        "BackupDancer_EN",
                        "SilverSuckle_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Frostbite_EN",
                        "Frostbite_EN",
                        "SilverSuckle_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Jansuli_EN",
                        "SilverSuckle_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Romantic_EN",
                        "Romantic_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Surrogate_EN",
                        "Surrogate_EN",
                    ], null);
                BolerMedium.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Gungrot_EN",
                        "Gungrot_EN",
                    ], null);
            }
            BolerMedium.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone02_Boler_Medium_EnemyBundle", 2, ZoneType_GameIDs.Orpheum_Hard, BundleDifficulty.Medium);

            EnemyEncounter_API BolerHard = new EnemyEncounter_API(0, "H_Zone02_Boler_Hard_EnemyBundle", "Boler_Sign")
            {
                MusicEvent = "event:/Leaning300",
                RoarEvent = "event:/Characters/Enemies/DLC_01/ChoirBoy/CHR_ENM_ChoirBoy_Roar",
            };
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "MusicMan_EN",
                    "MusicMan_EN",
                    "MusicMan_EN",
                    "SilverSuckle_EN",
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
                    "Revola_EN",
                    "SingingStone_EN",
                    "SilverSuckle_EN",
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
                    "Scrungie_EN",
                    "Scrungie_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Conductor_EN",
                    "SilverSuckle_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "MusicMan_EN",
                    "Scrungie_EN",
                    "ManicMan_EN",
                    "SilverSuckle_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Moone_EN",
                    "Moone_EN",
                    "Moone_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "SingingStone_EN",
                    "SingingStone_EN",
                    "SingingStone_EN",
                    "VanishingHands_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Heehoo_EN",
                    "Heehoo_EN",
                ], null);
            BolerHard.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Thunderdome_EN",
                    "Thunderdome_EN",
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
                        "Chapbull_EN",
                        "Chapman_EN",
                        "SilverSuckle_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Gizo_EN",
                        "Gizo_EN",
                        "SilverSuckle_EN",
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
                        "SingingMountain_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Seraphim_EN",
                        "Gizo_EN",
                        "Chapman_EN",
                        "Chapman_EN",
                    ], null);
            }
            if(Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "BackupDancer_EN",
                        "BackupDancer_EN",
                        "BackupDancer_EN",
                        "SilverSuckle_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Frostbite_EN",
                        "Frostbite_EN",
                        "Frostbite_EN",
                        "SilverSuckle_EN",
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
                        "Jansuli_EN",
                        "Jansuli_EN",
                        "SilverSuckle_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "PrimitiveGizo_Calm_EN",
                        "PrimitiveGizo_Calm_EN",
                        "SilverSuckle_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Gizard_EN",
                        "SilverSuckle_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Footshroom_EN",
                        "BackupDancer_EN",
                        "BipedalFrostbite_EN",
                        "Jansuli_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Surrogate_EN",
                        "Gungrot_EN",
                        "Romantic_EN",
                    ], null);
                BolerHard.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Errant_EN",
                        "SilverSuckle_EN",
                        "SilverSuckle_EN",
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
                    "Heehoo_EN",
                ], null);
            Boler2.CreateNewEnemyEncounterData(
                [
                    "Boler_EN",
                    "Boler_EN",
                    "Thunderdome_EN",
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
                    ], null);
                Boler2.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Boler_EN",
                        "BipedalFrostbite_EN",
                    ], null);
                Boler2.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Boler_EN",
                        "PrimitiveGizo_Calm_EN",
                    ], null);
                Boler2.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Boler_EN",
                        "ExternalIncubator_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                Boler2.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Boler_EN",
                        "Gungrot_EN",
                        "Gungrot_EN",
                    ], null);
                Boler2.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Boler_EN",
                        "Romantic_EN",
                        "Romantic_EN",
                        "Romantic_EN",
                    ], null);
                Boler2.CreateNewEnemyEncounterData(
                    [
                        "Boler_EN",
                        "Boler_EN",
                        "Errant_EN",
                    ], null);
            }
            Boler2.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone02_DoubleBoler_EnemyBundle", 3, ZoneType_GameIDs.Orpheum_Hard, BundleDifficulty.Hard);
        }
    }
}
