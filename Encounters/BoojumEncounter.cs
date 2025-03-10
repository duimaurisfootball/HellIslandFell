using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Encounters
{
    public class BoojumEncounter
    {
        public static void Add()
        {
            Portals.AddPortalSign("Boojum_Sign", ResourceLoader.LoadSprite("TimelineBoojum", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);
            EnemyEncounter_API boojumHard = new EnemyEncounter_API((EncounterType)1, "H_Zone03_Boojum_Hard_EnemyBundle", "Boojum_Sign")
            {
                MusicEvent = "event:/FitTheEighth",
                RoarEvent = "event:/Characters/Enemies/DLC_01/ChoirBoy/CHR_ENM_ChoirBoy_Roar",
            };
            boojumHard.CreateNewEnemyEncounterData(
                [
                    "Boojum_EN",
                ], [4]);
            boojumHard.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_Boojum_Hard_EnemyBundle", 5, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Hard);
        }
    }
}
