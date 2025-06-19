using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Encounters
{
    public class TestEncounters
    {
        public static void Add()
        {
            int testingNumber = 0;

            Portals.AddPortalSign("Kagla_Sign", ResourceLoader.LoadSprite("BossKaglaIcon", new Vector2(0.5f, 0f), 32), Portals.BossIDColor);
            EnemyEncounter_API kaglaEncounter = new EnemyEncounter_API((EncounterType)1, "BOSS_Zone01_Kagla_EnemyBundle", "Kagla_Sign")
            {
                MusicEvent = "event:/Music/Mx_Roids",
                RoarEvent = "event:/Characters/Enemies/InHisImage/CHR_ENM_InHisImage_Dth",
            };
            kaglaEncounter.CreateNewEnemyEncounterData(
                [
                    "Kagla_BOSS",
                ], [1]);
            kaglaEncounter.AddEncounterToDataBases();
            kaglaEncounter.BossID = "Kagla";
            EnemyEncounterUtils.AddEncounterToZoneSelector("BOSS_Zone01_Kagla_EnemyBundle", testingNumber, ZoneType_GameIDs.FarShore_Hard, BundleDifficulty.Boss);

            Portals.AddPortalSign("Waxman_Sign", ResourceLoader.LoadSprite("BossWaxmanIcon", new Vector2(0.5f, 0f), 32), Portals.BossIDColor);
            EnemyEncounter_API waxmanEncounter = new EnemyEncounter_API((EncounterType)1, "BOSS_Zone01_Waxman_EnemyBundle", "Waxman_Sign")
            {
                MusicEvent = "event:/Music/DLC_01/Mx_ChoirBoy_106",
                RoarEvent = "event:/Characters/Bosses/Osman Sinnoks/Phase 2/CHR_BOSS_OsmanSinnoks_P2_Dth",
            };
            waxmanEncounter.CreateNewEnemyEncounterData(
                [
                    "Waxman_BOSS",
                ], [2]);
            waxmanEncounter.AddEncounterToDataBases();
            waxmanEncounter.BossID = "Waxman";
            EnemyEncounterUtils.AddEncounterToZoneSelector("BOSS_Zone01_Waxman_EnemyBundle", testingNumber, ZoneType_GameIDs.FarShore_Hard, BundleDifficulty.Boss);

            Portals.AddPortalSign("VanishingPillar_Sign", ResourceLoader.LoadSprite("BossVanishingPillarIcon", new Vector2(0.5f, 0f), 32), Portals.BossIDColor);
            EnemyEncounter_API vanishingPillarEncounter = new EnemyEncounter_API((EncounterType)1, "BOSS_Zone02_VanishingPillar_EnemyBundle", "VanishingPillar_Sign")
            {
                MusicEvent = "event:/Music/Mx_Ouroboros",
                RoarEvent = "event:/Characters/Enemies/DLC_01/ChoirBoy/CHR_ENM_ChoirBoy_Roar",
            };
            vanishingPillarEncounter.CreateNewEnemyEncounterData(
                [
                    "VanishingPillar_BOSS",
                ], [1]);
            vanishingPillarEncounter.AddEncounterToDataBases();
            vanishingPillarEncounter.BossID = "VanishingPillar";
            EnemyEncounterUtils.AddEncounterToZoneSelector("BOSS_Zone02_VanishingPillar_EnemyBundle", testingNumber, ZoneType_GameIDs.Orpheum_Hard, BundleDifficulty.Boss);

            Portals.AddPortalSign("GreaterTobana_Sign", ResourceLoader.LoadSprite("BossTobanaIcon", new Vector2(0.5f, 0f), 32), Portals.BossIDColor);
            EnemyEncounter_API tobanaEncounter = new EnemyEncounter_API((EncounterType)1, "BOSS_Zone02_GreaterTobana_EnemyBundle", "GreaterTobana_Sign")
            {
                MusicEvent = "event:/Music/DLC_01/Mx_Xiphactinus and Gillicus_75",
                RoarEvent = "event:/Characters/Enemies/DLC_01/Xiphactinus/CHR_ENM_Xiphactinus_Roar",
            };
            tobanaEncounter.CreateNewEnemyEncounterData(
                [
                    "GreaterTobana_BOSS",
                ], [0]);
            tobanaEncounter.AddEncounterToDataBases();
            tobanaEncounter.BossID = "GreaterTobana";
            EnemyEncounterUtils.AddEncounterToZoneSelector("BOSS_Zone02_GreaterTobana_EnemyBundle", testingNumber, ZoneType_GameIDs.Orpheum_Hard, BundleDifficulty.Boss);
        }
    }
}
