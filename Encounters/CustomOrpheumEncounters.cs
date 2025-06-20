﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Encounters
{
    public class CustomOrpheumEncounters
    {
        public static void Add()
        {
            List<RandomEnemyGroup> musicManEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_MusicMan_Easy_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "MusicMan_EN",
                "Moone_EN",
            ]),
                new(
            [
                "MusicMan_EN",
                "Moone_EN",
                "SingingStone_EN",
            ]),
                new(
            [
                "MusicMan_EN",
                "MusicMan_EN",
                "Thunderdome_EN",
            ]),
            };
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_MusicMan_Easy_EnemyBundle"))._enemyBundles = musicManEasy;

            List<RandomEnemyGroup> jumbleGutsPurpleMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_JumbleGuts_Flummoxing_Medium_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "JumbleGuts_Flummoxing_EN",
                "JumbleGuts_Hollowing_EN",
                "Moone_EN",
            ]),
                new(
            [
                "JumbleGuts_Flummoxing_EN",
                "JumbleGuts_Hollowing_EN",
                "Thunderdome_EN",
            ]),
            };
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_JumbleGuts_Flummoxing_Medium_EnemyBundle"))._enemyBundles = jumbleGutsPurpleMedium;

            List<RandomEnemyGroup> jumbleGutsBlueMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_JumbleGuts_Hollowing_Medium_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "JumbleGuts_Hollowing_EN",
                "JumbleGuts_Flummoxing_EN",
                "Moone_EN",
            ]),
                new(
            [
                "JumbleGuts_Hollowing_EN",
                "JumbleGuts_Flummoxing_EN",
                "Thunderdome_EN",
            ]),
            };
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_JumbleGuts_Hollowing_Medium_EnemyBundle"))._enemyBundles = jumbleGutsBlueMedium;

            List<RandomEnemyGroup> musicManMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_MusicMan_Medium_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "MusicMan_EN",
                "MusicMan_EN",
                "Moone_EN",
            ]),
                new(
            [
                "MusicMan_EN",
                "MusicMan_EN",
                "Moone_EN",
                "SingingStone_EN",
            ]),
                new(
            [
                "MusicMan_EN",
                "MusicMan_EN",
                "MusicMan_EN",
                "Moone_EN",
            ]),
                new(
            [
                "MusicMan_EN",
                "MusicMan_EN",
                "Moone_EN",
                "JumbleGuts_Flummoxing_EN",
            ]),
                new(
            [
                "MusicMan_EN",
                "MusicMan_EN",
                "Moone_EN",
                "Spoggle_Resonant_EN",
            ]),
                new(
            [
                "MusicMan_EN",
                "MusicMan_EN",
                "Moone_EN",
                "JumbleGuts_Hollowing_EN",
            ]),
                new(
            [
                "MusicMan_EN",
                "MusicMan_EN",
                "Moone_EN",
                "JumbleGuts_Flummoxing_EN",
            ]),
                new(
            [
                "MusicMan_EN",
                "MusicMan_EN",
                "Thunderdome_EN",
                "Thunderdome_EN",
            ]),
                new(
            [
                "MusicMan_EN",
                "MusicMan_EN",
                "MusicMan_EN",
                "Thunderdome_EN",
            ]),
                new(
            [
                "MusicMan_EN",
                "MusicMan_EN",
                "Moone_EN",
                "Thunderdome_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                musicManMedium.Add(new(
                    [
                        "MusicMan_EN",
                        "MusicMan_EN",
                        "Moone_EN",
                        "Seraphim_EN",
                    ]));
                musicManMedium.Add(new(
                    [
                        "MusicMan_EN",
                        "MusicMan_EN",
                        "Moone_EN",
                        "Gizo_EN",
                    ]));
                musicManMedium.Add(new(
                    [
                        "MusicMan_EN",
                        "MusicMan_EN",
                        "Thunderdome_EN",
                        "Gizo_EN",
                    ]));
                musicManMedium.Add(new(
                    [
                        "MusicMan_EN",
                        "MusicMan_EN",
                        "Heehoo_EN",
                        "Gizo_EN",
                    ]));
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                musicManMedium.Add(new(
                    [
                        "MusicMan_EN",
                        "BackupDancer_EN",
                        "Moone_EN",
                    ]));
                musicManMedium.Add(new(
                    [
                        "MusicMan_EN",
                        "Jansuli_EN",
                        "Moone_EN",
                    ]));
                musicManMedium.Add(new(
                    [
                        "MusicMan_EN",
                        "Jansuli_EN",
                        "Thunderdome_EN",
                    ]));
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                musicManMedium.Add(new(
                    [
                        "MusicMan_EN",
                        "Gungrot_EN",
                        "Thunderdome_EN",
                    ]));
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_MusicMan_Medium_EnemyBundle"))._enemyBundles = musicManMedium;

            List<RandomEnemyGroup> spoggleRedMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_Spoggle_Writhing_Medium_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "Spoggle_Writhing_EN",
                "Spoggle_Writhing_EN",
                "Moone_EN",
            ]),
                new(
            [
                "Spoggle_Writhing_EN",
                "Heehoo_EN",
            ]),
                new(
            [
                "Spoggle_Writhing_EN",
                "Thunderdome_EN",
            ]),
            };
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_Spoggle_Writhing_Medium_EnemyBundle"))._enemyBundles = spoggleRedMedium;

            List<RandomEnemyGroup> spogglePurpleMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_Spoggle_Resonant_Medium_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "Spoggle_Resonant_EN",
                "Spoggle_Resonant_EN",
                "Moone_EN",
            ]),
                new(
            [
                "Spoggle_Resonant_EN",
                "Heehoo_EN",
            ]),
                new(
            [
                "Spoggle_Resonant_EN",
                "Thunderdome_EN",
            ]),
            };
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_Spoggle_Resonant_Medium_EnemyBundle"))._enemyBundles = spogglePurpleMedium;

            List<RandomEnemyGroup> scrungieMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_Scrungie_Medium_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "Scrungie_EN",
                "Moone_EN",
                "Moone_EN",
            ]),
                new(
            [
                "Scrungie_EN",
                "SingingStone_EN",
                "Moone_EN",
            ]),
                new(
            [
                "Scrungie_EN",
                "Scrungie_EN",
                "Thunderdome_EN",
            ]),
                new(
            [
                "Scrungie_EN",
                "Scrungie_EN",
                "Heehoo_EN",
            ]),
            };
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_Scrungie_Medium_EnemyBundle"))._enemyBundles = scrungieMedium;

            List<RandomEnemyGroup> conductorMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_Conductor_Medium_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "Conductor_EN",
                "Moone_EN",
                "Moone_EN",
            ]),
                new(
            [
                "Conductor_EN",
                "Moone_EN",
            ]),
                new(
            [
                "Conductor_EN",
                "Moone_EN",
                "JumbleGuts_Waning_EN",
            ]),
                new(
            [
                "Conductor_EN",
                "Moone_EN",
                "SingingStone_EN",
            ]),
                new(
            [
                "Conductor_EN",
                "Moone_EN",
                "MusicMan_EN",
            ]),
                new(
            [
                "Conductor_EN",
                "Heehoo_EN",
            ]),
                new(
            [
                "Conductor_EN",
                "Thunderdome_EN",
                "Thunderdome_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                conductorMedium.Add(new(
                    [
                        "Conductor_EN",
                        "Moone_EN",
                        "Seraphim_EN",
                    ]));
                conductorMedium.Add(new(
                    [
                        "Conductor_EN",
                        "Moone_EN",
                        "Neoplasm_EN",
                        "Neoplasm_EN",
                    ]));
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                conductorMedium.Add(new(
                    [
                        "Conductor_EN",
                        "Moone_EN",
                        "Frostbite_EN",
                        "Frostbite_EN",
                    ]));
                conductorMedium.Add(new(
                    [
                        "Conductor_EN",
                        "Moone_EN",
                        "BackupDancer_EN",
                    ]));
                conductorMedium.Add(new(
                    [
                        "Conductor_EN",
                        "Moone_EN",
                        "Jansuli_EN",
                    ]));
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                conductorMedium.Add(new(
                    [
                        "Conductor_EN",
                        "Moone_EN",
                        "Gungrot_EN",
                    ]));
                conductorMedium.Add(new(
                    [
                        "Conductor_EN",
                        "Heehoo_EN",
                        "Surrogate_EN",
                    ]));
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_Conductor_Medium_EnemyBundle"))._enemyBundles = conductorMedium;

            List<RandomEnemyGroup> revolaHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_Revola_Hard_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "Revola_EN",
                "Moone_EN",
                "Moone_EN",
            ]),
                new(
            [
                "Revola_EN",
                "Moone_EN",
                "MusicMan_EN",
            ]),
                new(
            [
                "Revola_EN",
                "Moone_EN",
                "JumbleGuts_Waning_EN",
            ]),
                new(
            [
                "Revola_EN",
                "Moone_EN",
                "JumbleGuts_Hollowing_EN",
                "JumbleGuts_Flummoxing_EN",
            ]),
                new(
            [
                "Revola_EN",
                "Moone_EN",
                "Spoggle_Writhing_EN",
                "Spoggle_Resonant_EN",
            ]),
                new(
            [
                "Revola_EN",
                "Moone_EN",
                "ManicMan_EN",
                "ManicMan_EN",
            ]),
                new(
            [
                "Revola_EN",
                "SingingStone_EN",
                "SingingStone_EN",
                "Heehoo_EN",
            ]),
                new(
            [
                "Revola_EN",
                "MusicMan_EN",
                "VanishingHands_EN",
            ]),
                new(
            [
                "Revola_EN",
                "Thunderdome_EN",
                "Thunderdome_EN",
            ]),
                new(
            [
                "Revola_EN",
                "Thunderdome_EN",
                "MusicMan_EN",
            ]),
                new(
            [
                "Revola_EN",
                "Thunderdome_EN",
                "Moone_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                revolaHard.Add(new(
                    [
                        "Revola_EN",
                        "Moone_EN",
                        "Seraphim_EN",
                    ]));
                revolaHard.Add(new(
                    [
                        "Revola_EN",
                        "Moone_EN",
                        "Gizo_EN",
                    ]));
                revolaHard.Add(new(
                    [
                        "Revola_EN",
                        "Thunderdome_EN",
                        "Gizo_EN",
                    ]));
                revolaHard.Add(new(
                    [
                        "Revola_EN",
                        "Moone_EN",
                        "DesiccatingJumbleguts_EN",
                    ]));
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                revolaHard.Add(new(
                    [
                        "Revola_EN",
                        "Moone_EN",
                        "BackupDancer_EN",
                    ]));
                revolaHard.Add(new(
                    [
                        "Revola_EN",
                        "Moone_EN",
                        "Footshroom_EN",
                    ]));
                revolaHard.Add(new(
                    [
                        "Revola_EN",
                        "Thunderdome_EN",
                        "BackupDancer_EN",
                    ]));
                revolaHard.Add(new(
                    [
                        "Revola_EN",
                        "Thunderdome_EN",
                        "Footshroom_EN",
                    ]));
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                revolaHard.Add(new(
                    [
                        "Revola_EN",
                        "Thunderdome_EN",
                        "Surrogate_EN",
                    ]));
                revolaHard.Add(new(
                    [
                        "Revola_EN",
                        "Heehoo_EN",
                        "Gungrot_EN",
                    ]));
                revolaHard.Add(new(
                    [
                        "Revola_EN",
                        "Moone_EN",
                        "Moone_EN",
                        "Gungrot_EN",
                    ]));
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_Revola_Hard_EnemyBundle"))._enemyBundles = revolaHard;

            List<RandomEnemyGroup> wrigglingSacrificeHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_WrigglingSacrifice_Hard_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "WrigglingSacrifice_EN",
                "WrigglingSacrifice_EN",
                "Boler_EN",
            ]),
                new(
            [
                "WrigglingSacrifice_EN",
                "Boler_EN",
                "SingingStone_EN",
                "SingingStone_EN",
                "SingingStone_EN",
            ]),
                new(
            [
                "WrigglingSacrifice_EN",
                "Moone_EN",
                "Moone_EN",
            ]),
                new(
            [
                "WrigglingSacrifice_EN",
                "SingingStone_EN",
                "SingingStone_EN",
                "VanishingHands_EN",
            ]),
                new(
            [
                "WrigglingSacrifice_EN",
                "Heehoo_EN",
                "Heehoo_EN",
            ]),
                new(
            [
                "WrigglingSacrifice_EN",
                "Thunderdome_EN",
                "Thunderdome_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                wrigglingSacrificeHard.Add(new(
                    [
                        "WrigglingSacrifice_EN",
                        "Boler_EN",
                        "Footshroom_EN",
                    ]));
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_WrigglingSacrifice_Hard_EnemyBundle"))._enemyBundles = wrigglingSacrificeHard;

            List<RandomEnemyGroup> innerChildHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_InnerChild_Hard_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "Moone_EN",
                "ManicMan_EN",
                "ManicMan_EN",
                "ManicMan_EN",
            ]),
                new(
            [
                "Heehoo_EN",
                "ManicMan_EN",
                "ManicMan_EN",
                "ManicMan_EN",
            ]),
                new(
            [
                "Thunderdome_EN",
                "ManicMan_EN",
                "ManicMan_EN",
                "ManicMan_EN",
                "ManicMan_EN",
            ]),
                new(
            [
                "VanishingHands_EN",
                "ManicMan_EN",
                "ManicMan_EN",
                "SingingStone_EN",
                "SingingStone_EN",
            ]),
            };
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_InnerChild_Hard_EnemyBundle"))._enemyBundles = innerChildHard;

            List<RandomEnemyGroup> conductorHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_Conductor_Hard_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "Conductor_EN",
                "Conductor_EN",
                "Moone_EN",
            ]),
                new(
            [
                "Conductor_EN",
                "Moone_EN",
                "Moone_EN",
            ]),
                new(
            [
                "Conductor_EN",
                "Moone_EN",
                "Moone_EN",
                "Moone_EN",
            ]),
                new(
            [
                "Conductor_EN",
                "Moone_EN",
                "Moone_EN",
                "MusicMan_EN",
            ]),
                new(
            [
                "Conductor_EN",
                "Moone_EN",
                "MusicMan_EN",
                "MusicMan_EN",
            ]),
                new(
            [
                "Conductor_EN",
                "Heehoo_EN",
                "Scrungie_EN",
            ]),
                new(
            [
                "Conductor_EN",
                "Heehoo_EN",
                "MusicMan_EN",
            ]),
                new(
            [
                "Conductor_EN",
                "Heehoo_EN",
                "Heehoo_EN",
            ]),
                new(
            [
                "Conductor_EN",
                "Thunderdome_EN",
                "Thunderdome_EN",
            ]),
                new(
            [
                "Conductor_EN",
                "Thunderdome_EN",
                "Heehoo_EN",
            ]),
                new(
            [
                "Conductor_EN",
                "SingingStone_EN",
                "SingingStone_EN",
                "SingingStone_EN",
                "VanishingHands_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                conductorHard.Add(new(
                    [
                        "Conductor_EN",
                        "Moone_EN",
                        "Moone_EN",
                        "Seraphim_EN",
                    ]));
                conductorHard.Add(new(
                    [
                        "Conductor_EN",
                        "Moone_EN",
                        "MusicMan_EN",
                        "Seraphim_EN",
                    ]));
                conductorHard.Add(new(
                    [
                        "Conductor_EN",
                        "Moone_EN",
                        "Chapman_EN",
                        "Chapman_EN",
                    ]));
                conductorHard.Add(new(
                    [
                        "Conductor_EN",
                        "Moone_EN",
                        "Gizo_EN",
                    ]));
                conductorHard.Add(new(
                    [
                        "Conductor_EN",
                        "Moone_EN",
                        "NeoplasmHeap_EN",
                    ]));
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                conductorHard.Add(new(
                    [
                        "Conductor_EN",
                        "Moone_EN",
                        "BipedalFrostbite_EN",
                    ]));
                conductorHard.Add(new(
                    [
                        "Conductor_EN",
                        "Moone_EN",
                        "PrimitiveGizo_Calm_EN",
                    ]));
                conductorHard.Add(new(
                    [
                        "Conductor_EN",
                        "Moone_EN",
                        "Jansuli_EN",
                    ]));
                conductorHard.Add(new(
                    [
                        "Conductor_EN",
                        "Heehoo_EN",
                        "Jansuli_EN",
                    ]));
            }
            if (Hell_Island_Fell.CrossMod.BoxOfBeasts)
            {
                conductorHard.Add(new(
                    [
                        "Conductor_EN",
                        "Heehoo_EN",
                        "Gungrot_EN",
                        "Gungrot_EN",
                    ]));
                conductorHard.Add(new(
                    [
                        "Conductor_EN",
                        "Thunderdome_EN",
                        "Thunderdome_EN",
                        "Gungrot_EN",
                        "Gungrot_EN",
                    ]));
                conductorHard.Add(new(
                    [
                        "Conductor_EN",
                        "Moone_EN",
                        "Moone_EN",
                        "Romantic_EN",
                    ]));
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone02_Conductor_Hard_EnemyBundle"))._enemyBundles = conductorHard;
        }
    }
}
