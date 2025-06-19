using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Encounters
{
    public class HeehooEncounters
    {
        public static void Add()
        {
            Portals.AddPortalSign("Heehoo_Sign", ResourceLoader.LoadSprite("TimelineHeehoo", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);

            EnemyEncounter_API HeehooMedium = new EnemyEncounter_API(0, "H_Zone02_Heehoo_Medium_EnemyBundle", "Heehoo_Sign")
            {
                MusicEvent = "event:/HaHaHaHa",
                RoarEvent = "event:/Characters/Enemies/Revola/CHR_ENM_Revola_Roar",
            };
            HeehooMedium.CreateNewEnemyEncounterData(
                [
                    "Heehoo_EN",
                    "MusicMan_EN",
                    "MusicMan_EN",
                ], null);
            HeehooMedium.CreateNewEnemyEncounterData(
                [
                    "Heehoo_EN",
                    "SingingStone_EN",
                    "SingingStone_EN",
                    "SingingStone_EN",
                    "MusicMan_EN",
                ], null);
            HeehooMedium.CreateNewEnemyEncounterData(
                [
                    "Heehoo_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
                ], null);
            HeehooMedium.CreateNewEnemyEncounterData(
                [
                    "Heehoo_EN",
                    "Scrungie_EN",
                    "Scrungie_EN",
                ], null);
            HeehooMedium.CreateNewEnemyEncounterData(
                [
                    "Heehoo_EN",
                    "Scrungie_EN",
                    "MusicMan_EN",
                    "SilverSuckle_EN",
                ], null);
            HeehooMedium.CreateNewEnemyEncounterData(
                [
                    "Heehoo_EN",
                    "JumbleGuts_Clotted_EN",
                    "JumbleGuts_Waning_EN",
                ], null);
            HeehooMedium.CreateNewEnemyEncounterData(
                [
                    "Heehoo_EN",
                    "Moone_EN",
                    "Moone_EN",
                ], null);
            HeehooMedium.CreateNewEnemyEncounterData(
                [
                    "Heehoo_EN",
                    "Thunderdome_EN",
                    "Thunderdome_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.Colophons)
            {
                HeehooMedium.CreateNewEnemyEncounterData(
                    [
                        "Heehoo_EN",
                        "ColophonDefeated_EN",
                        "ColophonMaladjusted_EN",
                    ], null);
                HeehooMedium.CreateNewEnemyEncounterData(
                    [
                        "Heehoo_EN",
                        "ColophonComposed_EN",
                        "ColophonMaladjusted_EN",
                    ], null);
                HeehooMedium.CreateNewEnemyEncounterData(
                    [
                        "Heehoo_EN",
                        "ColophonDelighted_EN",
                        "ColophonMaladjusted_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                HeehooMedium.CreateNewEnemyEncounterData(
                    [
                        "Heehoo_EN",
                        "Chapman_EN",
                        "Chapman_EN",
                    ], null);
                HeehooMedium.CreateNewEnemyEncounterData(
                    [
                        "Heehoo_EN",
                        "NakedGizo_EN",
                        "MusicMan_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                HeehooMedium.CreateNewEnemyEncounterData(
                    [
                        "Heehoo_EN",
                        "Frostbite_EN",
                        "BackupDancer_EN",
                    ], null);
                HeehooMedium.CreateNewEnemyEncounterData(
                    [
                        "Heehoo_EN",
                        "Jansuli_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                HeehooMedium.CreateNewEnemyEncounterData(
                    [
                        "Heehoo_EN",
                        "Gungrot_EN",
                    ], null);
                HeehooMedium.CreateNewEnemyEncounterData(
                    [
                        "Heehoo_EN",
                        "Thunderdome_EN",
                        "Surrogate_EN",
                    ], null);
            }
            HeehooMedium.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone02_Heehoo_Medium_EnemyBundle", 8, ZoneType_GameIDs.Orpheum_Hard, BundleDifficulty.Medium);

            EnemyEncounter_API HeehooHard = new EnemyEncounter_API(0, "H_Zone02_Heehoo_Hard_EnemyBundle", "Heehoo_Sign")
            {
                MusicEvent = "event:/HaHaHaHa",
                RoarEvent = "event:/Characters/Enemies/Revola/CHR_ENM_Revola_Roar",
            };
            HeehooHard.CreateNewEnemyEncounterData(
                [
                    "Heehoo_EN",
                    "MusicMan_EN",
                    "MusicMan_EN",
                    "MusicMan_EN",
                ], null);
            HeehooHard.CreateNewEnemyEncounterData(
                [
                    "Heehoo_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
                    "MusicMan_EN",
                ], null);
            HeehooHard.CreateNewEnemyEncounterData(
                [
                    "Heehoo_EN",
                    "Heehoo_EN",
                    "Scrungie_EN",
                    "Scrungie_EN",
                ], null);
            HeehooHard.CreateNewEnemyEncounterData(
                [
                    "Heehoo_EN",
                    "JumbleGuts_Hollowing_EN",
                    "JumbleGuts_Flummoxing_EN",
                ], null);
            HeehooHard.CreateNewEnemyEncounterData(
                [
                    "Heehoo_EN",
                    "Spoggle_Resonant_EN",
                    "Spoggle_Ruminating_EN",
                ], null);
            HeehooHard.CreateNewEnemyEncounterData(
                [
                    "Heehoo_EN",
                    "Spoggle_Resonant_EN",
                    "Spoggle_Writhing_EN",
                ], null);
            HeehooHard.CreateNewEnemyEncounterData(
                [
                    "Heehoo_EN",
                    "Heehoo_EN",
                    "Thunderdome_EN",
                    "Thunderdome_EN",
                ], null);
            HeehooHard.CreateNewEnemyEncounterData(
                [
                    "Heehoo_EN",
                    "Heehoo_EN",
                    "Thunderdome_EN",
                    "MusicMan_EN",
                ], null);
            HeehooHard.CreateNewEnemyEncounterData(
                [
                    "Heehoo_EN",
                    "SingingStone_EN",
                    "SingingStone_EN",
                    "SingingStone_EN",
                    "VanishingHands_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                HeehooHard.CreateNewEnemyEncounterData(
                    [
                        "Heehoo_EN",
                        "Chapman_EN",
                        "Chapman_EN",
                        "Chapman_EN",
                    ], null);
                HeehooHard.CreateNewEnemyEncounterData(
                    [
                        "Heehoo_EN",
                        "Gizo_EN",
                        "MusicMan_EN",
                        "MusicMan_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                HeehooHard.CreateNewEnemyEncounterData(
                    [
                        "Heehoo_EN",
                        "Frostbite_EN",
                        "Frostbite_EN",
                        "Frostbite_EN",
                    ], null);
                HeehooHard.CreateNewEnemyEncounterData(
                    [
                        "Heehoo_EN",
                        "BackupDancer_EN",
                        "BackupDancer_EN",
                        "BackupDancer_EN",
                    ], null);
                HeehooHard.CreateNewEnemyEncounterData(
                    [
                        "Heehoo_EN",
                        "Jansuli_EN",
                        "BackupDancer_EN",
                        "MusicMan_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                HeehooHard.CreateNewEnemyEncounterData(
                    [
                        "Heehoo_EN",
                        "Gungrot_EN",
                        "Gungrot_EN",
                        "Gungrot_EN",
                    ], null);
                HeehooHard.CreateNewEnemyEncounterData(
                    [
                        "Heehoo_EN",
                        "Heehoo_EN",
                        "Surrogate_EN",
                        "Surrogate_EN",
                    ], null);
                HeehooHard.CreateNewEnemyEncounterData(
                    [
                        "Heehoo_EN",
                        "Heehoo_EN",
                        "Romantic_EN",
                        "Moone_EN",
                    ], null);
                HeehooHard.CreateNewEnemyEncounterData(
                    [
                        "Heehoo_EN",
                        "Heehoo_EN",
                        "Romantic_EN",
                        "Thunderdome_EN",
                    ], null);
            }
            HeehooHard.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone02_Heehoo_Hard_EnemyBundle", 9, ZoneType_GameIDs.Orpheum_Hard, BundleDifficulty.Hard);
        }
    }
}
