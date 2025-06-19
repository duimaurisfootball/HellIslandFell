namespace Hell_Island_Fell.Encounters
{
    public class MooneEncounters
    {
        public static void Add()
        {
            Portals.AddPortalSign("Moone_Sign", ResourceLoader.LoadSprite("TimelineMoone", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);

            EnemyEncounter_API MooneEasyOrpheum = new EnemyEncounter_API(0, "H_Zone02_Moone_Easy_EnemyBundle", "Moone_Sign")
            {
                MusicEvent = "event:/AperiodicRecognitionOfPatterns",
                RoarEvent = "event:/Characters/Enemies/GigglingMinister/CHR_ENM_GigglingMinister_Roar",
            };
            MooneEasyOrpheum.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                ], null);
            MooneEasyOrpheum.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "MusicMan_EN",
                ], null);
            MooneEasyOrpheum.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
                ], null);
            MooneEasyOrpheum.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "SingingStone_EN",
                    "SingingStone_EN",
                ], null);
            MooneEasyOrpheum.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "JumbleGuts_Waning_EN",
                ], null);
            MooneEasyOrpheum.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "JumbleGuts_Clotted_EN",
                ], null);
            MooneEasyOrpheum.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "Spoggle_Ruminating_EN",
                ], null);
            MooneEasyOrpheum.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "Spoggle_Spitfire_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.Colophons)
            {
                MooneEasyOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "ColophonDefeated_EN",
                    ], null);
                MooneEasyOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "ColophonComposed_EN",
                        "SingingStone_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                MooneEasyOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "NakedGizo_EN",
                    ], null);
                MooneEasyOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Chapman_EN",
                        "Chapman_EN",
                    ], null);
                MooneEasyOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "DesiccatingJumbleguts_EN",
                        "SingingStone_EN",
                    ], null);
                MooneEasyOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "MusicMan_EN",
                        "NakedGizo_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                MooneEasyOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Surrogate_EN",
                    ], null);
                MooneEasyOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Romantic_EN",
                    ], null);
                MooneEasyOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Gungrot_EN",
                    ], null);
            }
            MooneEasyOrpheum.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone02_Moone_Easy_EnemyBundle", 8, ZoneType_GameIDs.Orpheum_Hard, BundleDifficulty.Easy);

            EnemyEncounter_API MooneMediumOrpheum = new EnemyEncounter_API(0, "H_Zone02_Moone_Medium_EnemyBundle", "Moone_Sign")
            {
                MusicEvent = "event:/AperiodicRecognitionOfPatterns",
                RoarEvent = "event:/Characters/Enemies/GigglingMinister/CHR_ENM_GigglingMinister_Roar",
            };
            MooneMediumOrpheum.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "Moone_EN",
                    "Moone_EN",
                ], null);
            MooneMediumOrpheum.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "MusicMan_EN",
                    "MusicMan_EN",
                ], null);
            MooneMediumOrpheum.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "Moone_EN",
                    "MusicMan_EN",
                ], null);
            MooneMediumOrpheum.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "Moone_EN",
                    "SingingStone_EN",
                ], null);
            MooneMediumOrpheum.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "JumbleGuts_Flummoxing_EN",
                ], null);
            MooneMediumOrpheum.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "JumbleGuts_Hollowing_EN",
                ], null);
            MooneMediumOrpheum.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "Spoggle_Resonant_EN",
                ], null);
            MooneMediumOrpheum.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "Spoggle_Writhing_EN",
                ], null);
            MooneMediumOrpheum.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "JumbleGuts_Waning_EN",
                    "JumbleGuts_Clotted_EN",
                ], null);
            MooneMediumOrpheum.CreateNewEnemyEncounterData(
                [
                    "Moone_EN",
                    "Moone_EN",
                    "VanishingHands_EN",
                ], null);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                MooneMediumOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Chapman_EN",
                        "Chapman_EN",
                    ], null);
                MooneMediumOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Seraphim_EN",
                    ], null);
                MooneMediumOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Moone_EN",
                        "Gizo_EN",
                    ], null);
                MooneMediumOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Neoplasm_EN",
                        "Neoplasm_EN",
                    ], null);
                MooneMediumOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Seraphim_EN",
                        "Neoplasm_EN",
                        "Neoplasm_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.Colophons)
            {
                MooneMediumOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Moone_EN",
                        "ColophonComposed_EN",
                    ], null);
                MooneMediumOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Moone_EN",
                        "ColophonDefeated_EN",
                    ], null);
                MooneMediumOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "ColophonDefeated_EN",
                        "ColophonComposed_EN",
                    ], null);
                MooneMediumOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "ColophonMaladjusted_EN",
                    ], null);
                MooneMediumOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "ColophonDelighted_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                MooneMediumOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Frostbite_EN",
                        "Frostbite_EN",
                    ], null);
                MooneMediumOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Jansuli_EN",
                        "Jansuli_EN",
                    ], null);
                MooneMediumOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "BackupDancer_EN",
                        "MusicMan_EN",
                    ], null);
                MooneMediumOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Moone_EN",
                        "Footshroom_EN",
                    ], null);
                MooneMediumOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "PrimitiveGizo_EN",
                    ], null);
                MooneMediumOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Moone_EN",
                        "Jansuli_EN",
                    ], null);
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                MooneMediumOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Moone_EN",
                        "Romantic_EN",
                    ], null);
                MooneMediumOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Heehoo_EN",
                        "Surrogate_EN",
                    ], null);
                MooneMediumOrpheum.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Gungrot_EN",
                        "Gungrot_EN",
                    ], null);
            }
            MooneMediumOrpheum.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone02_Moone_Medium_EnemyBundle", 24, ZoneType_GameIDs.Orpheum_Hard, BundleDifficulty.Medium);

            if (Hell_Island_Fell.CrossMod.TheSiren)
            {
                EnemyEncounter_API MooneEasySiren = new EnemyEncounter_API(0, "H_ZoneSiren_Moone_Easy_EnemyBundle", "Moone_Sign")
                {
                    MusicEvent = "event:/AperiodicRecognitionOfPatterns",
                    RoarEvent = "event:/Characters/Enemies/GigglingMinister/CHR_ENM_GigglingMinister_Roar",
                };
                MooneEasySiren.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                    ], null);
                MooneEasySiren.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Boiler_EN",
                    ], null);
                MooneEasySiren.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Tassnn_EN",
                    ], null);
                MooneEasySiren.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "BirdBath_EN",
                        "BirdBath_EN",
                    ], null);
                MooneEasySiren.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "TumultShell_EN",
                        "TumultShell_EN",
                    ], null);
                MooneEasySiren.AddEncounterToDataBases();
                EnemyEncounterUtils.AddEncounterToCustomZoneSelector("H_ZoneSiren_Moone_Easy_EnemyBundle", 6, "TheSiren_Zone1", BundleDifficulty.Easy);

                EnemyEncounter_API MooneMediumSiren = new EnemyEncounter_API(0, "H_ZoneSiren_Moone_Medium_EnemyBundle", "Moone_Sign")
                {
                    MusicEvent = "event:/AperiodicRecognitionOfPatterns",
                    RoarEvent = "event:/Characters/Enemies/GigglingMinister/CHR_ENM_GigglingMinister_Roar",
                };
                MooneMediumSiren.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Moone_EN",
                    ], null);
                MooneMediumSiren.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Boiler_EN",
                        "Boiler_EN",
                    ], null);
                MooneMediumSiren.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Tassnn_EN",
                        "Tassnn_EN",
                    ], null);
                MooneMediumSiren.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Tassnn_EN",
                        "OneShooter_EN",
                    ], null);
                MooneMediumSiren.CreateNewEnemyEncounterData(
                    [
                        "Moone_EN",
                        "Moone_EN",
                        "Tumult_EN",
                        "Tumult_EN",
                    ], null);
                MooneMediumSiren.AddEncounterToDataBases();
                EnemyEncounterUtils.AddEncounterToCustomZoneSelector("H_ZoneSiren_Moone_Medium_EnemyBundle", 6, "TheSiren_Zone1", BundleDifficulty.Easy);
            }
        }
    }
}
