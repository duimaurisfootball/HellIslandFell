using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Encounters
{
    public class NevermoreEncounters
    {
        public static void Add()
        {
            Portals.AddPortalSign("NevermoreSmall_Sign", ResourceLoader.LoadSprite("TimelineNevermoreSmall", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);
            EnemyEncounter_API nevermoreSmallHard = new EnemyEncounter_API(0, "H_Zone03_Nevermore_Small_Hard_EnemyBundle", "NevermoreSmall_Sign")
            {
                MusicEvent = "event:/ModernSunbeam",
                RoarEvent = "event:/Characters/Enemies/DLC_01/ChoirBoy/CHR_ENM_ChoirBoy_Roar",
            };
            nevermoreSmallHard.CreateNewEnemyEncounterData(
                [
                    "Nevermore_Small_EN",
                    "InHisImage_EN",
                    "InHerImage_EN",
                ]);
            nevermoreSmallHard.CreateNewEnemyEncounterData(
                [
                    "Nevermore_Small_EN",
                    "SkinningHomunculus_EN",
                    "ShiveringHomunculus_EN",
                ]);
            nevermoreSmallHard.CreateNewEnemyEncounterData(
                [
                    "Nevermore_Small_EN",
                    "ChoirBoy_EN",
                    "GigglingMinister_EN",
                ]);
            nevermoreSmallHard.CreateNewEnemyEncounterData(
                [
                    "Nevermore_Small_EN",
                    "ProlificNosestone_EN",
                    "MesmerizingNosestone_EN",
                ]);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                nevermoreSmallHard.CreateNewEnemyEncounterData(
                    [
                        "Nevermore_Small_EN",
                        "SterileBud_EN",
                        "ScreamingHomunculus_EN",
                    ]);
                nevermoreSmallHard.CreateNewEnemyEncounterData(
                    [
                        "Nevermore_Small_EN",
                        "Psychopomp_EN",
                        "Unterling_EN",
                    ]);
                nevermoreSmallHard.CreateNewEnemyEncounterData(
                    [
                        "Nevermore_Small_EN",
                        "ImpenetrableAngler_EN",
                    ]);
                nevermoreSmallHard.CreateNewEnemyEncounterData(
                    [
                        "Nevermore_Small_EN",
                        "Metatron_EN",
                        "SterileBud_EN",
                    ]);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                nevermoreSmallHard.CreateNewEnemyEncounterData(
                    [
                        "Nevermore_Small_EN",
                        "GodsChalice_EN",
                        "Maneater_EN",
                    ]);
                nevermoreSmallHard.CreateNewEnemyEncounterData(
                    [
                        "Nevermore_Small_EN",
                        "FrowningChancellor_EN",
                        "GigglingMinister_EN",
                    ]);
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                nevermoreSmallHard.CreateNewEnemyEncounterData(
                    [
                        "Nevermore_Small_EN",
                        "Surrogate_EN",
                    ]);
                nevermoreSmallHard.CreateNewEnemyEncounterData(
                    [
                        "Nevermore_Small_EN",
                        "Git_EN",
                        "Git_EN",
                    ]);
                nevermoreSmallHard.CreateNewEnemyEncounterData(
                    [
                        "Nevermore_Small_EN",
                        "Attrition_EN",
                    ]);
            }
            nevermoreSmallHard.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_Nevermore_Small_Hard_EnemyBundle", 2, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Hard);

            Portals.AddPortalSign("NevermoreMedium_Sign", ResourceLoader.LoadSprite("TimelineNevermoreMedium", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);
            EnemyEncounter_API nevermoreMediumHard = new EnemyEncounter_API(0, "H_Zone03_Nevermore_Medium_Hard_EnemyBundle", "NevermoreMedium_Sign")
            {
                MusicEvent = "event:/ModernSunbeam",
                RoarEvent = "event:/Characters/Enemies/DLC_01/ChoirBoy/CHR_ENM_ChoirBoy_Roar",
            };
            nevermoreMediumHard.CreateNewEnemyEncounterData(
                [
                    "Nevermore_Medium_EN",
                    "InHisImage_EN",
                    "InHerImage_EN",
                ]);
            nevermoreMediumHard.CreateNewEnemyEncounterData(
                [
                    "Nevermore_Medium_EN",
                    "SkinningHomunculus_EN",
                ]);
            nevermoreMediumHard.CreateNewEnemyEncounterData(
                [
                    "Nevermore_Medium_EN",
                    "GigglingMinister_EN",
                ]);
            nevermoreMediumHard.CreateNewEnemyEncounterData(
                [
                    "Nevermore_Medium_EN",
                    "ProlificNosestone_EN",
                ]);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                nevermoreMediumHard.CreateNewEnemyEncounterData(
                    [
                        "Nevermore_Medium_EN",
                        "SterileBud_EN",
                        "SterileBud_EN",
                    ]);
                nevermoreMediumHard.CreateNewEnemyEncounterData(
                    [
                        "Nevermore_Medium_EN",
                        "ImpenetrableAngler_EN",
                    ]);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                nevermoreMediumHard.CreateNewEnemyEncounterData(
                    [
                        "Nevermore_Medium_EN",
                        "GodsChalice_EN",
                    ]);
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                nevermoreMediumHard.CreateNewEnemyEncounterData(
                    [
                        "Nevermore_Medium_EN",
                        "Surrogate_EN",
                    ]);
                nevermoreMediumHard.CreateNewEnemyEncounterData(
                    [
                        "Nevermore_Medium_EN",
                        "Attrition_EN",
                    ]);
            }
            nevermoreMediumHard.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_Nevermore_Medium_Hard_EnemyBundle", 2, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Hard);

            Portals.AddPortalSign("NevermoreHuge_Sign", ResourceLoader.LoadSprite("TimelineNevermoreHuge", new Vector2(0.5f, 0f), 32), Portals.EnemyIDColor);
            EnemyEncounter_API nevermoreHugeHard = new EnemyEncounter_API(0, "H_Zone03_Nevermore_Huge_Hard_EnemyBundle", "NevermoreHuge_Sign")
            {
                MusicEvent = "event:/ModernSunbeam",
                RoarEvent = "event:/Characters/Enemies/DLC_01/ChoirBoy/CHR_ENM_ChoirBoy_Roar",
            };
            nevermoreHugeHard.CreateNewEnemyEncounterData(
                [
                    "Nevermore_Huge_EN",
                    "SkinningHomunculus_EN",
                ]);
            nevermoreHugeHard.CreateNewEnemyEncounterData(
                [
                    "Nevermore_Huge_EN",
                    "ChoirBoy_EN",
                ]);
            nevermoreHugeHard.CreateNewEnemyEncounterData(
                [
                    "Nevermore_Huge_EN",
                    "ProlificNosestone_EN",
                ]);
            nevermoreHugeHard.CreateNewEnemyEncounterData(
                [
                    "Nevermore_Huge_EN",
                    "StickingHomunculus_EN",
                ]);
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                nevermoreHugeHard.CreateNewEnemyEncounterData(
                    [
                        "Nevermore_Huge_EN",
                        "Unterling_EN",
                        "TitteringPeon_EN",
                    ]);
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                nevermoreHugeHard.CreateNewEnemyEncounterData(
                    [
                        "Nevermore_Huge_EN",
                        "GodsChalice_EN",
                    ]);
                nevermoreHugeHard.CreateNewEnemyEncounterData(
                    [
                        "Nevermore_Huge_EN",
                        "FrowningChancellor_EN",
                    ]);
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                nevermoreHugeHard.CreateNewEnemyEncounterData(
                    [
                        "Nevermore_Huge_EN",
                        "Attrition_EN",
                    ]);
            }
            nevermoreHugeHard.AddEncounterToDataBases();
            EnemyEncounterUtils.AddEncounterToZoneSelector("H_Zone03_Nevermore_Huge_Hard_EnemyBundle", 1, ZoneType_GameIDs.Garden_Hard, BundleDifficulty.Hard);
        }
    }
}
