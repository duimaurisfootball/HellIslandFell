using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Encounters
{
    public class OneShooterEncounters
    {
        public static void Add()
        {
            Portals.AddPortalSign("OneShooter_Sign", ResourceLoader.LoadSprite("TimelineOneShooter", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);
            EnemyEncounter_API oneShooterMedium = new EnemyEncounter_API(0, "H_ZoneSiren_OneShooter_Medium_EnemyBundle", "OneShooter_Sign")
            {
                MusicEvent = "event:/YoureNotSupposedToBeHere",
                RoarEvent = "event:/Characters/Player/LongLiver/CHR_PLR_LongLiver_Dx",
            };
            oneShooterMedium.CreateNewEnemyEncounterData(
                [
                    "OneShooter_EN",
                    "Boiler_EN",
                    "Boiler_EN",
                ]);
            oneShooterMedium.CreateNewEnemyEncounterData(
                [
                    "OneShooter_EN",
                    "OneShooter_EN",
                    "Tassnn_EN",
                ]);
            oneShooterMedium.CreateNewEnemyEncounterData(
                [
                    "OneShooter_EN",
                    "Tassnn_EN",
                    "BirdBath_EN",
                    "BirdBath_EN",
                ]);
            oneShooterMedium.CreateNewEnemyEncounterData(
                [
                    "OneShooter_EN",
                    "Boiler_EN",
                    "BirdBath_EN",
                    "BirdBath_EN",
                ]);
            oneShooterMedium.CreateNewEnemyEncounterData(
                [
                    "OneShooter_EN",
                    "Moone_EN",
                    "BirdBath_EN",
                    "BirdBath_EN",
                ]);
            oneShooterMedium.CreateNewEnemyEncounterData(
                [
                    "OneShooter_EN",
                    "Boiler_EN",
                    "JumbleGuts_Hollowing_EN",
                ]);
            oneShooterMedium.CreateNewEnemyEncounterData(
                [
                    "OneShooter_EN",
                    "Boiler_EN",
                    "JumbleGuts_Clotted_EN",
                    "JumbleGuts_Waning_EN",
                ]);
            oneShooterMedium.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToCustomZoneSelector("H_ZoneSiren_OneShooter_Medium_EnemyBundle", 8, "TheSiren_Zone1", BundleDifficulty.Medium);
        }
    }
}
