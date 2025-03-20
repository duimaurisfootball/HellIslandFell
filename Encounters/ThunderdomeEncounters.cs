using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Encounters
{
    public class ThunderdomeEncounters
    {
        public static void Add()
        {
            Portals.AddPortalSign("Thunderdome_Sign", ResourceLoader.LoadSprite("TimelineThunderdome", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);

            EnemyEncounter_API ThunderdomeMedium = new EnemyEncounter_API(0, "H_Zone02_Thunderdome_Medium_EnemyBundle", "Thunderdome_Sign")
            {
                MusicEvent = "event:/Music/Mx_Hickory",
                RoarEvent = "event:/Characters/Enemies/WrigglingSacrifice/CHR_ENM_WrigglingSacrifice_Roar",
            };
            ThunderdomeMedium.CreateNewEnemyEncounterData(
                [
                    "Thunderdome_EN",
                    "MusicMan_EN",
                    "MusicMan_EN",
                ], null);
            ThunderdomeMedium.CreateNewEnemyEncounterData(
                [
                    "Thunderdome_EN",
                    "MusicMan_EN",
                    "SingingStone_EN",
                    "SingingStone_EN",
                ], null);
            ThunderdomeMedium.CreateNewEnemyEncounterData(
                [
                    "Thunderdome_EN",
                    "Moone_EN",
                    "Moone_EN",
                ], null);
            ThunderdomeMedium.CreateNewEnemyEncounterData(
                [
                    "Thunderdome_EN",
                    "Thunderdome_EN",
                    "JumbleGuts_Clotted_EN",
                    "SilverSuckle_EN",
                ], null);
            ThunderdomeMedium.CreateNewEnemyEncounterData(
                [
                    "Thunderdome_EN",
                    "Scrungie_EN",
                    "Scrungie_EN",
                ], null);
            ThunderdomeMedium.CreateNewEnemyEncounterData(
                [
                    "Thunderdome_EN",
                    "Thunderdome_EN",
                    "Heehoo_EN",
                    "SilverSuckle_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                ThunderdomeMedium.CreateNewEnemyEncounterData(
                    [
                        "Thunderdome_EN",
                        "Gizo_EN",
                        "NakedGizo_EN",
                        "SilverSuckle_EN",
                    ], null);
                ThunderdomeMedium.CreateNewEnemyEncounterData(
                    [
                        "Thunderdome_EN",
                        "Chapman_EN",
                        "Chapman_EN",
                        "Moone_EN",
                    ], null);
                ThunderdomeMedium.CreateNewEnemyEncounterData(
                    [
                        "Thunderdome_EN",
                        "Seraphim_EN",
                        "Heehoo_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                ThunderdomeMedium.CreateNewEnemyEncounterData(
                    [
                        "Thunderdome_EN",
                        "Frostbite_EN",
                        "Frostbite_EN",
                        "Frostbite_EN",
                    ], null);
                ThunderdomeMedium.CreateNewEnemyEncounterData(
                    [
                        "Thunderdome_EN",
                        "BipedalFrostbite_EN",
                        "Frostbite_EN",
                        "SilverSuckle_EN",
                    ], null);
                ThunderdomeMedium.CreateNewEnemyEncounterData(
                    [
                        "Thunderdome_EN",
                        "BackupDancer_EN",
                        "BackupDancer_EN",
                    ], null);
                ThunderdomeMedium.CreateNewEnemyEncounterData(
                    [
                        "Thunderdome_EN",
                        "Thunderdome_EN",
                        "Jansuli_EN",
                        "PrimitiveGizo_Calm_EN",
                    ], null);
            }
            ThunderdomeMedium.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone02_Thunderdome_Medium_EnemyBundle", 15, ZoneType_GameIDs.Orpheum_Hard, BundleDifficulty.Medium);

            EnemyEncounter_API ThunderdomeHard = new EnemyEncounter_API(0, "H_Zone02_Thunderdome_Hard_EnemyBundle", "Thunderdome_Sign")
            {
                MusicEvent = "event:/Music/Mx_Hickory",
                RoarEvent = "event:/Characters/Enemies/WrigglingSacrifice/CHR_ENM_WrigglingSacrifice_Roar",
            };
            ThunderdomeHard.CreateNewEnemyEncounterData(
                [
                    "Thunderdome_EN",
                    "Thunderdome_EN",
                    "MusicMan_EN",
                    "MusicMan_EN",
                    "MusicMan_EN",
                ], null);
            ThunderdomeHard.CreateNewEnemyEncounterData(
                [
                    "Thunderdome_EN",
                    "Thunderdome_EN",
                    "Thunderdome_EN",
                    "MusicMan_EN",
                    "MusicMan_EN",
                ], null);
            ThunderdomeHard.CreateNewEnemyEncounterData(
                [
                    "Thunderdome_EN",
                    "Thunderdome_EN",
                    "Thunderdome_EN",
                    "JumbleGuts_Clotted_EN",
                ], null);
            ThunderdomeHard.CreateNewEnemyEncounterData(
                [
                    "Thunderdome_EN",
                    "Thunderdome_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
                ], null);
            ThunderdomeHard.CreateNewEnemyEncounterData(
                [
                    "Thunderdome_EN",
                    "Thunderdome_EN",
                    "Scrungie_EN",
                    "Scrungie_EN",
                ], null);
            ThunderdomeHard.CreateNewEnemyEncounterData(
                [
                    "Thunderdome_EN",
                    "Thunderdome_EN",
                    "Moone_EN",
                    "Heehoo_EN",
                ], null);
            ThunderdomeHard.CreateNewEnemyEncounterData(
                [
                    "Thunderdome_EN",
                    "Thunderdome_EN",
                    "SingingStone_EN",
                    "SingingStone_EN",
                    "VanishingHands_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                ThunderdomeHard.CreateNewEnemyEncounterData(
                    [
                        "Thunderdome_EN",
                        "Thunderdome_EN",
                        "Gizo_EN",
                        "NakedGizo_EN",
                    ], null);
                ThunderdomeHard.CreateNewEnemyEncounterData(
                    [
                        "Thunderdome_EN",
                        "Chapman_EN",
                        "Chapman_EN",
                        "Chapman_EN",
                    ], null);
                ThunderdomeHard.CreateNewEnemyEncounterData(
                    [
                        "Thunderdome_EN",
                        "Thunderdome_EN",
                        "NeoplasmHeap_EN",
                    ], null);
                ThunderdomeHard.CreateNewEnemyEncounterData(
                    [
                        "Thunderdome_EN",
                        "Neoplasm_EN",
                        "Neoplasm_EN",
                        "Neoplasm_EN",
                        "Neoplasm_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                ThunderdomeHard.CreateNewEnemyEncounterData(
                    [
                        "Thunderdome_EN",
                        "Thunderdome_EN",
                        "ExternalIncubator_EN",
                    ], null);
                ThunderdomeHard.CreateNewEnemyEncounterData(
                    [
                        "Thunderdome_EN",
                        "Thunderdome_EN",
                        "BipedalFrostbite_EN",
                        "SilverSuckle_EN",
                    ], null);
                ThunderdomeHard.CreateNewEnemyEncounterData(
                    [
                        "Thunderdome_EN",
                        "Thunderdome_EN",
                        "Footshroom_EN",
                    ], null);
                ThunderdomeHard.CreateNewEnemyEncounterData(
                    [
                        "Thunderdome_EN",
                        "Thunderdome_EN",
                        "PrimitiveGizo_Calm_EN",
                        "Jansuli_EN",
                    ], null);
            }
            ThunderdomeHard.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone02_Thunderdome_Hard_EnemyBundle", 17, ZoneType_GameIDs.Orpheum_Hard, BundleDifficulty.Hard);
        }
    }
}
