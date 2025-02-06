using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Encounters
{
    public class CustomFarShoreEncounters
    {
        public static void Add()
        {
            List<RandomEnemyGroup> mungEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("Zone01_Mung_Easy_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "Mung_EN",
                "Mung_EN",
                "Mung_EN",
                "VanishingHands_EN",
            ]),
            };
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("Zone01_Mung_Easy_EnemyBundle"))._enemyBundles = mungEasy;

            List<RandomEnemyGroup> mudLungEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_MudLung_Easy_EnemyBundle"))._enemyBundles)
            {
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_MudLung_Easy_EnemyBundle"))._enemyBundles = mudLungEasy;

            List<RandomEnemyGroup> munglingEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_MunglingMudLung_Easy_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "MunglingMudLung_EN",
                "Keklung_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_MunglingMudLung_Easy_EnemyBundle"))._enemyBundles = munglingEasy;

            List<RandomEnemyGroup> redJumbleEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("Zone01_JumbleGuts_Clotted_Easy_EnemyBundle"))._enemyBundles)
            {
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("Zone01_JumbleGuts_Clotted_Easy_EnemyBundle"))._enemyBundles = redJumbleEasy;

            List<RandomEnemyGroup> yellowJumbleEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("Zone01_JumbleGuts_Waning_Easy_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "JumbleGuts_Waning_EN",
                "JumbleGuts_Clotted_EN",
                "VanishingHands_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("Zone01_JumbleGuts_Waning_Easy_EnemyBundle"))._enemyBundles = yellowJumbleEasy;

            List<RandomEnemyGroup> kekoEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_Keko_Easy_EnemyBundle"))._enemyBundles)
            {
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_Keko_Easy_EnemyBundle"))._enemyBundles = kekoEasy;

            List<RandomEnemyGroup> goaMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_FlaMingGoa_Medium_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "FlaMinGoa_EN",
                "Keklung_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                goaMedium.Add(new(
                    [
                        "LipBug_EN",
                        "FlaMinGoa_EN",
                        "VanishingHands_EN",
                    ]));
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_FlaMingGoa_Medium_EnemyBundle"))._enemyBundles = goaMedium;

            List<RandomEnemyGroup> redJumbleMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_JumbleGuts_Clotted_Medium_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "JumbleGuts_Clotted_EN",
                "Wringle_EN",
                "VanishingHands_EN",
            ]),
                new(
            [
                "JumbleGuts_Clotted_EN",
                "Keko_EN",
                "Keklung_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                redJumbleMedium.Add(new(
                    [
                        "JumbleGuts_Clotted_EN",
                        "LipBug_EN",
                        "VanishingHands_EN",
                    ]));
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_JumbleGuts_Clotted_Medium_EnemyBundle"))._enemyBundles = redJumbleMedium;

            List<RandomEnemyGroup> yellowJumbleMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_JumbleGuts_Waning_Medium_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "JumbleGuts_Waning_EN",
                "Wringle_EN",
                "VanishingHands_EN",
            ]),
                new(
            [
                "JumbleGuts_Waning_EN",
                "Keko_EN",
                "Keklung_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                yellowJumbleMedium.Add(new(
                    [
                        "JumbleGuts_Waning_EN",
                        "LipBug_EN",
                        "VanishingHands_EN",
                    ]));
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                yellowJumbleMedium.Add(new(
                    [
                        "JumbleGuts_Waning_EN",
                        "Enno_EN",
                        "VanishingHands_EN",
                    ]));
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_JumbleGuts_Waning_Medium_EnemyBundle"))._enemyBundles = yellowJumbleMedium;

            List<RandomEnemyGroup> mudLungMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_MudLung_Medium_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "MudLung_EN",
                "MudLung_EN",
                "VanishingHands_EN",
            ]),
                new(
            [
                "MudLung_EN",
                "MudLung_EN",
                "Keklung_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                mudLungMedium.Add(new(
                    [
                        "MudLung_EN",
                        "LipBug_EN",
                        "VanishingHands_EN",
                    ]));
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                mudLungMedium.Add(new(
                    [
                        "MudLung_EN",
                        "Enno_EN",
                        "VanishingHands_EN",
                    ]));
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_MudLung_Medium_EnemyBundle"))._enemyBundles = mudLungMedium;

            List<RandomEnemyGroup> blueSpoggleMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_Spoggle_Ruminating_Medium_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "Spoggle_Ruminating_EN",
                "VanishingHands_EN",
            ]),
                new(
            [
                "Spoggle_Ruminating_EN",
                "Keklung_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_Spoggle_Ruminating_Medium_EnemyBundle"))._enemyBundles = blueSpoggleMedium;

            List<RandomEnemyGroup> yellowSpoggleMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_Spoggle_Spitfire_Medium_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "Spoggle_Spitfire_EN",
                "VanishingHands_EN",
            ]),
                new(
            [
                "Spoggle_Spitfire_EN",
                "Keklung_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_Spoggle_Spitfire_Medium_EnemyBundle"))._enemyBundles = yellowSpoggleMedium;

            List<RandomEnemyGroup> kekoMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_Keko_Medium_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "Keko_EN",
                "Keko_EN",
                "Keko_EN",
                "Keko_EN",
                "VanishingHands_EN",
            ]),
                new(
            [
                "Keko_EN",
                "Keko_EN",
                "Keklung_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                kekoMedium.Add(new(
                    [
                        "Keko_EN",
                        "Keko_EN",
                        "LipBug_EN",
                        "VanishingHands_EN",
                    ]));
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                kekoMedium.Add(new(
                    [
                        "Keko_EN",
                        "Keko_EN",
                        "Flakkid_EN",
                        "VanishingHands_EN",
                    ]));
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_Keko_Medium_EnemyBundle"))._enemyBundles = kekoMedium;

            List<RandomEnemyGroup> munglingMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_MunglingMudLung_Medium_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "MunglingMudLung_EN",
                "MudLung_EN",
                "VanishingHands_EN",
            ]),
                new(
            [
                "MunglingMudLung_EN",
                "MudLung_EN",
                "Keklung_EN",
            ]),
                new(
            [
                "MunglingMudLung_EN",
                "Keklung_EN",
                "Keklung_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                munglingMedium.Add(new(
                    [
                        "MunglingMudLung_EN",
                        "LipBug_EN",
                        "VanishingHands_EN",
                    ]));
                munglingMedium.Add(new(
                    [
                        "MunglingMudLung_EN",
                        "LipBug_EN",
                        "Keklung_EN",
                    ]));
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                munglingMedium.Add(new(
                    [
                        "MunglingMudLung_EN",
                        "Enno_EN",
                        "Keklung_EN",
                    ]));
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_MunglingMudLung_Medium_EnemyBundle"))._enemyBundles = munglingMedium;

            List<RandomEnemyGroup> goaHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_FlaMingGoa_Hard_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "FlaMinGoa_EN",
                "Wringle_EN",
                "VanishingHands_EN",
            ]),
                new(
            [
                "FlaMinGoa_EN",
                "Keklung_EN",
                "Keklung_EN",
            ]),
                new(
            [
                "FlaMinGoa_EN",
                "Keklung_EN",
                "MunglingMudLung_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                goaHard.Add(new(
                    [
                        "FlaMinGoa_EN",
                        "LipBug_EN",
                        "VanishingHands_EN",
                    ]));
                goaHard.Add(new(
                    [
                        "FlaMinGoa_EN",
                        "LipBug_EN",
                        "Keklung_EN",
                    ]));
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                goaHard.Add(new(
                    [
                        "FlaMinGoa_EN",
                        "Flakkid_EN",
                        "VanishingHands_EN",
                    ]));
                goaHard.Add(new(
                    [
                        "FlaMinGoa_EN",
                        "Flakkid_EN",
                        "Keklung_EN",
                    ]));
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_FlaMingGoa_Hard_EnemyBundle"))._enemyBundles = goaHard;

            List<RandomEnemyGroup> flarbHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_Flarb_Hard_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "Flarb_EN",
                "Flarblet_EN",
                "VanishingHands_EN",
            ]),
                new(
            [
                "Flarb_EN",
                "Keklung_EN",
                "Keklung_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                flarbHard.Add(new(
                    [
                        "Flarb_EN",
                        "Flarbleft_EN",
                        "VanishingHands_EN",
                    ]));
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_Flarb_Hard_EnemyBundle"))._enemyBundles = flarbHard;

            List<RandomEnemyGroup> voboolaHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_Voboola_Hard_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "Voboola_EN",
                "VanishingHands_EN",
            ]),
                new(
            [
                "Voboola_EN",
                "FlaMinGoa_EN",
                "VanishingHands_EN",
            ]),
                new(
            [
                "Voboola_EN",
                "MunglingMudLung_EN",
                "VanishingHands_EN",
            ]),
                new(
            [
                "Voboola_EN",
                "Keklung_EN",
                "Keklung_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                voboolaHard.Add(new(
                    [
                        "Voboola_EN",
                        "VanishingHands_EN",
                        "LipBug_EN",
                    ]));
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                voboolaHard.Add(new(
                    [
                        "Voboola_EN",
                        "VanishingHands_EN",
                        "DryBait_EN",
                    ]));
                voboolaHard.Add(new(
                    [
                        "Voboola_EN",
                        "VanishingHands_EN",
                        "Flakkid_EN",
                    ]));
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_Voboola_Hard_EnemyBundle"))._enemyBundles = voboolaHard;

            List<RandomEnemyGroup> kekastleHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_Kekastle_Hard_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "Kekastle_EN",
                "VanishingHands_EN",
            ]),
                new(
            [
                "Kekastle_EN",
                "Keklung_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_Kekastle_Hard_EnemyBundle"))._enemyBundles = kekastleHard;

            List<RandomEnemyGroup> purpleJumbleHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_JumbleGuts_Flummoxing_Hard_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "JumbleGuts_Flummoxing_EN",
                "FlaMinGoa_EN",
                "VanishingHands_EN",
            ]),
                new(
            [
                "JumbleGuts_Flummoxing_EN",
                "Keklung_EN",
                "Keklung_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_JumbleGuts_Flummoxing_Hard_EnemyBundle"))._enemyBundles = purpleJumbleHard;

            List<RandomEnemyGroup> blueJumbleHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_JumbleGuts_Hollowing_Hard_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "JumbleGuts_Hollowing_EN",
                "FlaMinGoa_EN",
                "VanishingHands_EN",
            ]),
                new(
            [
                "JumbleGuts_Hollowing_EN",
                "Keklung_EN",
                "Keklung_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_JumbleGuts_Hollowing_Hard_EnemyBundle"))._enemyBundles = blueJumbleHard;

            List<RandomEnemyGroup> purpleSpoggleHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_Spoggle_Resonant_Hard_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "Spoggle_Resonant_EN",
                "VanishingHands_EN",
            ]),
                new(
            [
                "Spoggle_Resonant_EN",
                "Keklung_EN",
                "Wringle_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_Spoggle_Resonant_Hard_EnemyBundle"))._enemyBundles = purpleSpoggleHard;

            List<RandomEnemyGroup> redSpoggleHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_Spoggle_Writhing_Hard_EnemyBundle"))._enemyBundles)
            {
                new(
            [
                "Spoggle_Writhing_EN",
                "VanishingHands_EN",
            ]),
                new(
            [
                "Spoggle_Writhing_EN",
                "Keklung_EN",
                "Wringle_EN",
            ]),
            };
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
            }
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
            }
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("H_Zone01_Spoggle_Writhing_Hard_EnemyBundle"))._enemyBundles = redSpoggleHard;
        }
    }
}
