using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Encounters
{
    public class VusEncounter
    {
        public static void Add()
        {
            Portals.AddPortalSign("Vus_Sign", ResourceLoader.LoadSprite("TimelineVus", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);
            EnemyEncounter_API vusHard = new EnemyEncounter_API(0, "H_Zone01_Vus_Hard_EnemyBundle", "Vus_Sign")
            {
                MusicEvent = "event:/ProteinEvolution",
                RoarEvent = "event:/Characters/Enemies/DLC_01/ChoirBoy/CHR_ENM_ChoirBoy_Roar",
            };
            vusHard.CreateNewEnemyEncounterData(
                [
                    "Vus_EN",
                ]);
            vusHard.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone01_Vus_Hard_EnemyBundle", 8, ZoneType_GameIDs.FarShore_Hard, BundleDifficulty.Hard);
        }
    }
}
