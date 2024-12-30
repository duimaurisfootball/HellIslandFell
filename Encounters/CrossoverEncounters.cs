using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Encounters
{
    public class CrossoverEncounters
    {
        public static void Add()
        {
            if (Hell_Island_Fell.CrossMod.Colophons)
            {
                List<RandomEnemyGroup> composedEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ComposedEasy"))._enemyBundles)
                {
                    new(
                [
                    "ColophonComposed_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ComposedEasy"))._enemyBundles = composedEasy;

                List<RandomEnemyGroup> composedMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ComposedMedium"))._enemyBundles)
                {
                    new(
                [
                    "ColophonComposed_EN",
                    "Wringle_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "ColophonComposed_EN",
                    "MudLung_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ComposedMedium"))._enemyBundles = composedMedium;

                List<RandomEnemyGroup> defeatedEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DefeatedEasy"))._enemyBundles)
                {
                    new(
                [
                    "ColophonDefeated_EN",
                    "ColophonDefeated_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "ColophonDefeated_EN",
                    "ColophonComposed_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DefeatedEasy"))._enemyBundles = defeatedEasy;

                List<RandomEnemyGroup> defeatedMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DefeatedMedium"))._enemyBundles)
                {
                    new(
                [
                    "ColophonDefeated_EN",
                    "Wringle_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "ColophonDefeated_EN",
                    "MudLung_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DefeatedMedium"))._enemyBundles = defeatedMedium;

                List<RandomEnemyGroup> delightedHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DelightedFarShoreHard"))._enemyBundles)
                {
                    new(
                [
                    "ColophonDelighted_EN",
                    "ColophonDefeated_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "ColophonDelighted_EN",
                    "ColophonComposed_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DelightedFarShoreHard"))._enemyBundles = delightedHard;

                List<RandomEnemyGroup> delightedMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DelightedMedium"))._enemyBundles)
                {
                    new(
                [
                    "ColophonDelighted_EN",
                    "Moone_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "ColophonDelighted_EN",
                    "Moone_EN",
                    "MusicMan_EN",
                ]),
                    new(
                [
                    "ColophonDelighted_EN",
                    "Moone_EN",
                    "Moone_EN",
                    "ColophonDefeated_EN",
                ]),
                    new(
                [
                    "ColophonDelighted_EN",
                    "Moone_EN",
                    "Moone_EN",
                    "ColophonComposed_EN",
                ]),
                    new(
                [
                    "ColophonDelighted_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "ColophonDelighted_EN",
                    "Moone_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DelightedMedium"))._enemyBundles = delightedMedium;

                List<RandomEnemyGroup> maladjustedHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MaladjustedFarShoreHard"))._enemyBundles)
                {
                    new(
                [
                    "ColophonMaladjusted_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MaladjustedFarShoreHard"))._enemyBundles = maladjustedHard;

                List<RandomEnemyGroup> maladjustedMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MaladjustedMedium"))._enemyBundles)
                {
                    new(
                [
                    "ColophonMaladjusted_EN",
                    "Moone_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "ColophonMaladjusted_EN",
                    "Moone_EN",
                    "MusicMan_EN",
                ]),
                    new(
                [
                    "ColophonMaladjusted_EN",
                    "Moone_EN",
                    "Moone_EN",
                    "ColophonDefeated_EN",
                ]),
                    new(
                [
                    "ColophonMaladjusted_EN",
                    "Moone_EN",
                    "Moone_EN",
                    "ColophonComposed_EN",
                ]),
                    new(
                [
                    "ColophonMaladjusted_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "ColophonMaladjusted_EN",
                    "Moone_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MaladjustedMedium"))._enemyBundles = maladjustedMedium;
            }
            if (Hell_Island_Fell.CrossMod.EnemyPack)
            {
                List<RandomEnemyGroup> anglerHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("AnglerHard"))._enemyBundles)
                {
                    new(
                [
                    "ImpenetrableAngler_EN",
                    "Maneater_EN",
                ]),
                    new(
                [
                    "ImpenetrableAngler_EN",
                    "ShiveringHomunculus_EN",
                    "StickingHomunculus_EN",
                    "SkinningHomunculus_EN",
                ]),
                    new(
                [
                    "ImpenetrableAngler_EN",
                    "ShiveringHomunculus_EN",
                    "StickingHomunculus_EN",
                    "ScreamingHomunculus_EN",
                ]),
                    new(
                [
                    "ImpenetrableAngler_EN",
                    "SkinningHomunculus_EN",
                    "StickingHomunculus_EN",
                    "ScreamingHomunculus_EN",
                ]),
                    new(
                [
                    "ImpenetrableAngler_EN",
                    "ProlificNosestone_EN",
                    "ProlificNosestone_EN",
                ]),
                    new(
                [
                    "ImpenetrableAngler_EN",
                    "SweatingNosestone_EN",
                ]),
                    new(
                [
                    "ImpenetrableAngler_EN",
                    "ScatterbrainedNosestone_EN",
                ]),
                    new(
                [
                    "ImpenetrableAngler_EN",
                    "MesmerizingNosestone_EN",
                ]),
                    new(
                [
                    "ImpenetrableAngler_EN",
                    "UninspiredNosestone_EN",
                ]),
                    new(
                [
                    "ImpenetrableAngler_EN",
                    "Inequity_EN",
                    "ChoirBoy_EN",
                ]),
                    new(
                [
                    "ImpenetrableAngler_EN",
                    "Inequity_EN",
                    "TitteringPeon_EN",
                ]),
                    new(
                [
                    "ImpenetrableAngler_EN",
                    "ScatterbrainedNosestone_EN",
                    "SweatingNosestone_EN",
                ]),
                    new(
                [
                    "ImpenetrableAngler_EN",
                    "Inequity_EN",
                    "InHisImage_EN",
                    "InHisImage_EN",
                ]),
                    new(
                [
                    "ImpenetrableAngler_EN",
                    "Inequity_EN",
                    "InHisImage_EN",
                    "InHerImage_EN",
                ]),
                    new(
                [
                    "ImpenetrableAngler_EN",
                    "SweatingNosestone_EN",
                    "InHisImage_EN",
                    "InHerImage_EN",
                ]),
                    new(
                [
                    "ImpenetrableAngler_EN",
                    "StickingHomunculus_EN",
                    "StickingHomunculus_EN",
                    "NextOfKin_EN",
                ]),
                    new(
                [
                    "GigglingMinister_EN",
                    "ProlificNosestone_EN",
                    "ImpenetrableAngler_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("AnglerHard"))._enemyBundles = anglerHard;

                List<RandomEnemyGroup> chapbullHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChapbullHard"))._enemyBundles)
                {
                    new(
                [
                    "Chapbull_EN",
                    "Chapman_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Chapbull_EN",
                    "Chapman_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChapbullHard"))._enemyBundles = chapbullHard;

                List<RandomEnemyGroup> chapmanMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChapmanMedium"))._enemyBundles)
                {
                    new(
                [
                    "Chapman_EN",
                    "Chapman_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Chapman_EN",
                    "Chapman_EN",
                    "Chapman_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Chapman_EN",
                    "Chapman_EN",
                    "Moone_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Chapman_EN",
                    "Chapman_EN",
                    "Seraphim_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Chapman_EN",
                    "Chapman_EN",
                    "Moone_EN",
                    "MusicMan_EN",
                ]),
                    new(
                [
                    "Chapman_EN",
                    "Chapman_EN",
                    "Moone_EN",
                    "JumbleGuts_Waning_EN",
                ]),
                    new(
                [
                    "Chapman_EN",
                    "Chapman_EN",
                    "Chapman_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "Chapman_EN",
                    "Chapman_EN",
                    "MusicMan_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "Chapman_EN",
                    "Chapman_EN",
                    "Moone_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChapmanMedium"))._enemyBundles = chapmanMedium;

                List<RandomEnemyGroup> cherubimHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("CherubimHard"))._enemyBundles)
                {
                    new(
                [
                    "Cherubim_EN",
                    "Moone_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Cherubim_EN",
                    "Moone_EN",
                    "MusicMan_EN",
                ]),
                    new(
                [
                    "Cherubim_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("CherubimHard"))._enemyBundles = cherubimHard;

                List<RandomEnemyGroup> drySimianMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DrySimianMedium"))._enemyBundles)
                {
                    new(
                [
                    "DrySimian_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DrySimianMedium"))._enemyBundles = drySimianMedium;

                List<RandomEnemyGroup> drySimianHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DrySimianHard"))._enemyBundles)
                {
                    new(
                [
                    "DrySimian_EN",
                    "Keko_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DrySimianHard"))._enemyBundles = drySimianHard;

                List<RandomEnemyGroup> gizoMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GizoMedium"))._enemyBundles)
                {
                    new(
                [
                    "Gizo_EN",
                    "Moone_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Gizo_EN",
                    "Moone_EN",
                    "Moone_EN",
                    "SingingStone_EN",
                ]),
                    new(
                [
                    "Gizo_EN",
                    "Moone_EN",
                    "MusicMan_EN",
                ]),
                    new(
                [
                    "Gizo_EN",
                    "Moone_EN",
                    "MusicMan_EN",
                    "SingingStone_EN",
                ]),
                    new(
                [
                    "Gizo_EN",
                    "Moone_EN",
                    "Neoplasm_EN",
                    "Neoplasm_EN",
                ]),
                    new(
                [
                    "Gizo_EN",
                    "Gizo_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Gizo_EN",
                    "NakedGizo_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Gizo_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GizoMedium"))._enemyBundles = gizoMedium;

                List<RandomEnemyGroup> gizoHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GizoHard"))._enemyBundles)
                {
                    new(
                [
                    "Gizo_EN",
                    "Gizo_EN",
                    "Moone_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Gizo_EN",
                    "NakedGizo_EN",
                    "Moone_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Gizo_EN",
                    "Gizo_EN",
                    "Moone_EN",
                    "MusicMan_EN",
                ]),
                    new(
                [
                    "Gizo_EN",
                    "NakedGizo_EN",
                    "Moone_EN",
                    "MusicMan_EN",
                ]),
                    new(
                [
                    "Gizo_EN",
                    "Moone_EN",
                    "JumbleGuts_Waning_EN",
                    "JumbleGuts_Clotted_EN",
                ]),
                    new(
                [
                    "Gizo_EN",
                    "NakedGizo_EN",
                    "Moone_EN",
                    "JumbleGuts_Hollowing_EN",
                ]),
                    new(
                [
                    "Gizo_EN",
                    "NakedGizo_EN",
                    "Moone_EN",
                    "JumbleGuts_Flummoxing_EN",
                ]),
                    new(
                [
                    "Gizo_EN",
                    "Gizo_EN",
                    "Moone_EN",
                    "JumbleGuts_Waning_EN",
                ]),
                    new(
                [
                    "Gizo_EN",
                    "Gizo_EN",
                    "Moone_EN",
                    "JumbleGuts_Clotted_EN",
                ]),
                    new(
                [
                    "Gizo_EN",
                    "NakedGizo_EN",
                    "Moone_EN",
                    "Spoggle_Writhing_EN",
                ]),
                    new(
                [
                    "Gizo_EN",
                    "NakedGizo_EN",
                    "Moone_EN",
                    "Spoggle_Resonant_EN",
                ]),
                    new(
                [
                    "Gizo_EN",
                    "Gizo_EN",
                    "Moone_EN",
                    "Spoggle_Spitfire_EN",
                ]),
                    new(
                [
                    "Gizo_EN",
                    "Gizo_EN",
                    "Moone_EN",
                    "Spoggle_Ruminating_EN",
                ]),
                    new(
                [
                    "Gizo_EN",
                    "Gizo_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "Gizo_EN",
                    "NakedGizo_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GizoHard"))._enemyBundles = gizoHard;

                List<RandomEnemyGroup> greyJumbleMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GreyJumbleMedium"))._enemyBundles)
                {
                    new(
                [
                    "DesiccatingJumbleguts_EN",
                    "Moone_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "DesiccatingJumbleguts_EN",
                    "Moone_EN",
                    "MusicMan_EN",
                ]),
                    new(
                [
                    "DesiccatingJumbleguts_EN",
                    "Moone_EN",
                    "Chapman_EN",
                    "Chapman_EN",
                ]),
                    new(
                [
                    "DesiccatingJumbleguts_EN",
                    "JumbleGuts_Flummoxing_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "DesiccatingJumbleguts_EN",
                    "JumbleGuts_Hollowing_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "DesiccatingJumbleguts_EN",
                    "JumbleGuts_Hollowing_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "DesiccatingJumbleguts_EN",
                    "JumbleGuts_Flummoxing_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GreyJumbleMedium"))._enemyBundles = greyJumbleMedium;

                List<RandomEnemyGroup> metatronHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MetatronHard"))._enemyBundles)
                {
                    new(
                [
                    "Metatron_EN",
                    "UninspiredNosestone_EN",
                    "SweatingNosestone_EN",
                ]),
                    new(
                [
                    "Metatron_EN",
                    "UninspiredNosestone_EN",
                    "ScatterbrainedNosestone_EN",
                ]),
                    new(
                [
                    "Metatron_EN",
                    "ProlificNosestone_EN",
                    "InHisImage_EN",
                    "InHisImage_EN",
                ]),
                    new(
                [
                    "Metatron_EN",
                    "MesmerizingNosestone_EN",
                ]),
                    new(
                [
                    "Metatron_EN",
                    "Maneater_EN",
                    "Unterling_EN",
                ]),
                    new(
                [
                    "Metatron_EN",
                    "Inequity_EN",
                    "Unterling_EN",
                    "Unterling_EN",
                ]),
                    new(
                [
                    "Metatron_EN",
                    "SkinningHomunculus_EN",
                    "StickingHomunculus_EN",
                    "ScreamingHomunculus_EN",
                ]),
                    new(
                [
                    "Metatron_EN",
                    "ShiveringHomunculus_EN",
                    "StickingHomunculus_EN",
                    "ScreamingHomunculus_EN",
                ]),
                    new(
                [
                    "Metatron_EN",
                    "SkinningHomunculus_EN",
                    "StickingHomunculus_EN",
                    "ShiveringHomunculus_EN",
                ]),
                    new(
                [
                    "Metatron_EN",
                    "GigglingMinister_EN",
                    "StickingHomunculus_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MetatronHard"))._enemyBundles = metatronHard;

                List<RandomEnemyGroup> neoplasmHeapMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("HeapMedium"))._enemyBundles)
                {
                    new(
                [
                    "NeoplasmHeap_EN",
                    "Moone_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "NeoplasmHeap_EN",
                    "Moone_EN",
                    "MusicMan_EN",
                ]),
                    new(
                [
                    "NeoplasmHeap_EN",
                    "Moone_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("HeapMedium"))._enemyBundles = neoplasmHeapMedium;

                List<RandomEnemyGroup> neoplasmHeapHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("HeapHard"))._enemyBundles)
                {
                    new(
                [
                    "NeoplasmHeap_EN",
                    "Seraphim_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "NeoplasmHeap_EN",
                    "Seraphim_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "NeoplasmHeap_EN",
                    "Gizo_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "NeoplasmHeap_EN",
                    "DesiccatingJumbleguts_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "NeoplasmHeap_EN",
                    "Moone_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "NeoplasmHeap_EN",
                    "MusicMan_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("HeapHard"))._enemyBundles = neoplasmHeapHard;

                List<RandomEnemyGroup> neoplasmLakeHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("LakeHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("LakeHard"))._enemyBundles = neoplasmLakeHard;

                List<RandomEnemyGroup> nephilimMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("NephilimMedium"))._enemyBundles)
                {
                    new(
                [
                    "Nephilim_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("NephilimMedium"))._enemyBundles = nephilimMedium;

                List<RandomEnemyGroup> nephilimHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("NephilimHard"))._enemyBundles)
                {
                    new(
                [
                    "Nephilim_EN",
                    "Keko_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "Nephilim_EN",
                    "MudLung_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("NephilimHard"))._enemyBundles = nephilimHard;

                List<RandomEnemyGroup> ophanimHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("OphanimHard"))._enemyBundles)
                {
                    new(
                [
                    "Ophanim_EN",
                    "Boler_EN",
                    "Seraphim_EN",
                ]),
                    new(
                [
                    "Ophanim_EN",
                    "Boler_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
                ]),
                    new(
                [
                    "Ophanim_EN",
                    "Boler_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Ophanim_EN",
                    "Moone_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Ophanim_EN",
                    "Moone_EN",
                    "MusicMan_EN",
                ]),
                    new(
                [
                    "Ophanim_EN",
                    "Moone_EN",
                    "Seraphim_EN",
                ]),
                    new(
                [
                    "Ophanim_EN",
                    "MusicMan_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "Ophanim_EN",
                    "Moone_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("OphanimHard"))._enemyBundles = ophanimHard;

                List<RandomEnemyGroup> opisthotonusHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("OpisthotonusHard"))._enemyBundles)
                {
                    new(
                [
                    "Opisthotonus_EN",
                    "Moone_EN",
                    "Moone_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("OpisthotonusHard"))._enemyBundles = opisthotonusHard;

                List<RandomEnemyGroup> peonEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PeonEasy"))._enemyBundles)
                {
                    new(
                [
                    "TitteringPeon_EN",
                    "TitteringPeon_EN",
                    "MesmerizingNosestone_EN",
                ]),
                    new(
                [
                    "TitteringPeon_EN",
                    "TitteringPeon_EN",
                    "Inequity_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PeonEasy"))._enemyBundles = peonEasy;

                List<RandomEnemyGroup> psychopompHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PsychopompHard"))._enemyBundles)
                {
                    new(
                [
                    "Psychopomp_EN",
                    "Inequity_EN",
                    "ProlificNosestone_EN",
                ]),
                    new(
                [
                    "Psychopomp_EN",
                    "Maneater_EN",
                ]),
                    new(
                [
                    "Psychopomp_EN",
                    "UninspiredNosestone_EN",
                    "UninspiredNosestone_EN",
                ]),
                    new(
                [
                    "Psychopomp_EN",
                    "SweatingNosestone_EN",
                    "InHisImage_EN",
                    "InHisImage_EN",
                ]),
                    new(
                [
                    "Psychopomp_EN",
                    "SkinningHomunculus_EN",
                    "StickingHomunculus_EN",
                    "ShiveringHomunculus_EN",
                ]),
                    new(
                [
                    "Psychopomp_EN",
                    "ShiveringHomunculus_EN",
                    "StickingHomunculus_EN",
                    "ScreamingHomunculus_EN",
                ]),
                    new(
                [
                    "Psychopomp_EN",
                    "SkinningHomunculus_EN",
                    "StickingHomunculus_EN",
                    "ScreamingHomunculus_EN",
                ]),
                    new(
                [
                    "Psychopomp_EN",
                    "Inequity_EN",
                    "ChoirBoy_EN",
                ]),
                    new(
                [
                    "Psychopomp_EN",
                    "SweatingNosestone_EN",
                    "StickingHomunculus_EN",
                ]),
                    new(
                [
                    "Psychopomp_EN",
                    "ProlificNosestone_EN",
                    "StickingHomunculus_EN",
                ]),
                    new(
                [
                    "Psychopomp_EN",
                    "ScatterbrainedNosestone_EN",
                    "InHerImage_EN",
                    "InHerImage_EN",
                ]),
                    new(
                [
                    "Psychopomp_EN",
                    "MesmerizingNosestone_EN",
                ]),
                    new(
                [
                    "Psychopomp_EN",
                    "UninspiredNosestone_EN",
                    "MesmerizingNosestone_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PsychopompHard"))._enemyBundles = psychopompHard;

                List<RandomEnemyGroup> psychopompMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PsychopompMedium"))._enemyBundles)
                {
                    new(
                [
                    "Psychopomp_EN",
                    "UninspiredNosestone_EN",
                ]),
                    new(
                [
                    "Psychopomp_EN",
                    "UninspiredNosestone_EN",
                    "StickingHomunculus_EN",
                ]),
                    new(
                [
                    "Psychopomp_EN",
                    "UninspiredNosestone_EN",
                    "ShiveringHomunculus_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PsychopompMedium"))._enemyBundles = psychopompMedium;

                List<RandomEnemyGroup> revoltingHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("RevoltingHard"))._enemyBundles)
                {
                    new(
                [
                    "RevoltingRevola_EN",
                    "Moone_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "RevoltingRevola_EN",
                    "Moone_EN",
                    "MusicMan_EN",
                ]),
                    new(
                [
                    "RevoltingRevola_EN",
                    "Moone_EN",
                    "SingingStone_EN",
                ]),
                    new(
                [
                    "RevoltingRevola_EN",
                    "Gizo_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "RevoltingRevola_EN",
                    "DesiccatingJumbleguts_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "RevoltingRevola_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "RevoltingRevola_EN",
                    "VanishingHands_EN",
                    "SingingStone_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("RevoltingHard"))._enemyBundles = revoltingHard;

                List<RandomEnemyGroup> seraphimHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SeraphimHard"))._enemyBundles)
                {
                    new(
                [
                    "Seraphim_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "Seraphim_EN",
                    "MudLung_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "Seraphim_EN",
                    "Flarbleft_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "Seraphim_EN",
                    "Flarblet_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SeraphimHard"))._enemyBundles = seraphimHard;

                List<RandomEnemyGroup> mountainHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MountainHard"))._enemyBundles)
                {
                    new(
                [
                    "SingingMountain_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "SingingMountain_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MountainHard"))._enemyBundles = mountainHard;

                List<RandomEnemyGroup> sterileBudMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SterileBudMedium"))._enemyBundles)
                {
                    new(
                [
                    "SterileBud_EN",
                    "ProlificNosestone_EN",
                    "Unterling_EN",
                ]),
                    new(
                [
                    "SterileBud_EN",
                    "SterileBud_EN",
                    "UninspiredNosestone_EN",
                ]),
                    new(
                [
                    "SterileBud_EN",
                    "SterileBud_EN",
                    "ScatterbrainedNosestone_EN",
                ]),
                    new(
                [
                    "SterileBud_EN",
                    "Inequity_EN",
                    "Unterling_EN",
                ]),
                    new(
                [
                    "SterileBud_EN",
                    "Inequity_EN",
                    "Unterling_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SterileBudMedium"))._enemyBundles = sterileBudMedium;

                List<RandomEnemyGroup> sterileBudHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SterileBudHard"))._enemyBundles)
                {
                    new(
                [
                    "SterileBud_EN",
                    "SterileBud_EN",
                    "Inequity_EN",
                ]),
                    new(
                [
                    "SterileBud_EN",
                    "SterileBud_EN",
                    "MesmerizingNosestone_EN",
                ]),
                    new(
                [
                    "SterileBud_EN",
                    "SterileBud_EN",
                    "SweatingNosestone_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SterileBudHard"))._enemyBundles = sterileBudHard;

                List<RandomEnemyGroup> unflarbHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("UnflarbHard"))._enemyBundles)
                {
                    new(
                [
                    "Unflarb_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "Unflarb_EN",
                    "MudLung_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "Unflarb_EN",
                    "Flarblet_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "Unflarb_EN",
                    "Flarbleft_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "Unflarb_EN",
                    "Flatback_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("UnflarbHard"))._enemyBundles = unflarbHard;

                List<RandomEnemyGroup> zygoteHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ZygoteHard"))._enemyBundles)
                {
                    new(
                [
                    "BastardZygote_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "BastardZygote_EN",
                    "Keko_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ZygoteHard"))._enemyBundles = zygoteHard;
            }
            
            if (Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                List<RandomEnemyGroup> swineEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SwineEasy"))._enemyBundles)
                {
                    new(
                [
                    "UnculturedSwine_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SwineEasy"))._enemyBundles = swineEasy;

                List<RandomEnemyGroup> swineMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SwineMed"))._enemyBundles)
                {
                    new(
                [
                    "UnculturedSwine_EN",
                    "MudLung_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SwineMed"))._enemyBundles = swineMedium;

                List<RandomEnemyGroup> swineHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SwineHard"))._enemyBundles)
                {
                    new(
                [
                    "UnculturedSwine_EN",
                    "FlaMinGoa_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "UnculturedSwine_EN",
                    "Wringle_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "UnculturedSwine_EN",
                    "MunglingMudLung_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SwineHard"))._enemyBundles = swineHard;

                List<RandomEnemyGroup> baitMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BaitMed"))._enemyBundles)
                {
                    new(
                [
                    "DryBait_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BaitMed"))._enemyBundles = baitMedium;

                List<RandomEnemyGroup> baitHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BaitHard"))._enemyBundles)
                {
                    new(
                [
                    "DryBait_EN",
                    "Wringle_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "DryBait_EN",
                    "MudLung_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "DryBait_EN",
                    "MunglingMudLung_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BaitHard"))._enemyBundles = baitHard;

                List<RandomEnemyGroup> ennoEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("EnnoEasy"))._enemyBundles)
                {
                    new(
                [
                    "Enno_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "Enno_EN",
                    "Mung_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("EnnoEasy"))._enemyBundles = ennoEasy;

                List<RandomEnemyGroup> ennoMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("EnnoMed"))._enemyBundles)
                {
                    new(
                [
                    "Enno_EN",
                    "Enno_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "Enno_EN",
                    "Wringle_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "Enno_EN",
                    "FlaMinGoa_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "Enno_EN",
                    "MudLung_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("EnnoMed"))._enemyBundles = ennoMedium;

                List<RandomEnemyGroup> pipeMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PipeMed"))._enemyBundles)
                {
                    new(
                [
                    "NotAn_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PipeMed"))._enemyBundles = pipeMedium;

                List<RandomEnemyGroup> flakkidEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FlakkidEasy"))._enemyBundles)
                {
                    new(
                [
                    "Flakkid_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FlakkidEasy"))._enemyBundles = flakkidEasy;

                List<RandomEnemyGroup> flakkidMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FlakkidMed"))._enemyBundles)
                {
                    new(
                [
                    "Flakkid_EN",
                    "Flakkid_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "Flakkid_EN",
                    "Wringle_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "Flakkid_EN",
                    "Flarblet_EN",
                    "Flarblet_EN",
                    "VanishingHands_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FlakkidMed"))._enemyBundles = flakkidMedium;

                List<RandomEnemyGroup> backupDancerEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BDancerEasy"))._enemyBundles)
                {
                    new(
                [
                    "BackupDancer_EN",
                    "Moone_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BDancerEasy"))._enemyBundles = backupDancerEasy;

                List<RandomEnemyGroup> backupDancerMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BDancerMed"))._enemyBundles)
                {
                    new(
                [
                    "BackupDancer_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "BackupDancer_EN",
                    "BackupDancer_EN",
                    "Moone_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BDancerMed"))._enemyBundles = backupDancerMedium;

                List<RandomEnemyGroup> backupDancerHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BDancerHard"))._enemyBundles)
                {
                    new(
                [
                    "BackupDancer_EN",
                    "BackupDancer_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "BackupDancer_EN",
                    "MusicMan_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "BackupDancer_EN",
                    "BackupDancer_EN",
                    "Scrungie_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "BackupDancer_EN",
                    "BackupDancer_EN",
                    "ManicMan_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "BackupDancer_EN",
                    "BackupDancer_EN",
                    "Jansuli_EN",
                    "Moone_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BDancerHard"))._enemyBundles = backupDancerHard;

                List<RandomEnemyGroup> frostbiteEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FrostbiteEasy"))._enemyBundles)
                {
                    new(
                [
                    "Frostbite_EN",
                    "Frostbite_EN",
                    "Moone_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FrostbiteEasy"))._enemyBundles = frostbiteEasy;

                List<RandomEnemyGroup> frostbiteMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FrostbiteMed"))._enemyBundles)
                {
                    new(
                [
                    "Frostbite_EN",
                    "Frostbite_EN",
                    "Moone_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Frostbite_EN",
                    "Frostbite_EN",
                    "Frostbite_EN",
                    "Moone_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FrostbiteMed"))._enemyBundles = frostbiteMedium;

                List<RandomEnemyGroup> frostbiteHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FrostbiteHard"))._enemyBundles)
                {
                    new(
                [
                    "Frostbite_EN",
                    "Frostbite_EN",
                    "ManicMan_EN",
                    "Moone_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FrostbiteHard"))._enemyBundles = frostbiteHard;

                List<RandomEnemyGroup> bipedalFrostbiteMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BFrostbiteMed"))._enemyBundles)
                {
                    new(
                [
                    "Frostbite_Bipedal_EN",
                    "Frostbite_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Frostbite_Bipedal_EN",
                    "MusicMan_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Frostbite_Bipedal_EN",
                    "BackupDancer_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Frostbite_Bipedal_EN",
                    "SingingStone_EN",
                    "SingingStone_EN",
                    "Moone_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BFrostbiteMed"))._enemyBundles = bipedalFrostbiteMedium;

                List<RandomEnemyGroup> bipedalFrostbiteHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BFrostbiteHard"))._enemyBundles)
                {
                    new(
                [
                    "Frostbite_Bipedal_EN",
                    "Frostbite_Bipedal_EN",
                    "Moone_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Frostbite_Bipedal_EN",
                    "Frostbite_Bipedal_EN",
                    "BackupDancer_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Frostbite_Bipedal_EN",
                    "Frostbite_Bipedal_EN",
                    "Jansuli_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Frostbite_Bipedal_EN",
                    "ManicMan_EN",
                    "ManicMan_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Frostbite_Bipedal_EN",
                    "Scrungie_EN",
                    "Scrungie_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Frostbite_Bipedal_EN",
                    "PrimitiveGizo_Calm_EN",
                    "Moone_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BFrostbiteHard"))._enemyBundles = bipedalFrostbiteHard;

                List<RandomEnemyGroup> jansuliEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("JansuliEasy"))._enemyBundles)
                {
                    new(
                [
                    "Jansuli_EN",
                    "Moone_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("JansuliEasy"))._enemyBundles = jansuliEasy;

                List<RandomEnemyGroup> jansuliMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("JansuliMed"))._enemyBundles)
                {
                    new(
                [
                    "Jansuli_EN",
                    "VanishingHands",
                ]),
                    new(
                [
                    "Jansuli_EN",
                    "Jansuli_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Jansuli_EN",
                    "Jansuli_EN",
                    "Moone_EN",
                    "Footshroom_EN",
                ]),
                    new(
                [
                    "Jansuli_EN",
                    "SilverSuckle_EN",
                    "VanishingHands",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("JansuliMed"))._enemyBundles = jansuliMedium;

                List<RandomEnemyGroup> jansuliHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("JansuliHard"))._enemyBundles)
                {
                    new(
                [
                    "Jansuli_EN",
                    "Jansuli_EN",
                    "Jansuli_EN",
                    "VanishingHands",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("JansuliHard"))._enemyBundles = jansuliHard;

                List<RandomEnemyGroup> primitiveGizoMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PGizoMed"))._enemyBundles)
                {
                    new(
                [
                    "PrimitiveGizo_Calm_EN",
                    "Moone_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PGizoMed"))._enemyBundles = primitiveGizoMedium;

                List<RandomEnemyGroup> primitiveGizoHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PGizoHard"))._enemyBundles)
                {
                    new(
                [
                    "PrimitiveGizo_Calm_EN",
                    "VanishingHands",
                ]),
                    new(
                [
                    "PrimitiveGizo_Calm_EN",
                    "Moone_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "PrimitiveGizo_Calm_EN",
                    "MusicMan_EN",
                    "Moone_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PGizoHard"))._enemyBundles = primitiveGizoHard;

                List<RandomEnemyGroup> gizardMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GizardMed"))._enemyBundles)
                {
                    new(
                [
                    "Gizard_EN",
                    "Moone_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GizardMed"))._enemyBundles = gizardMedium;

                List<RandomEnemyGroup> gizardHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GizardHard"))._enemyBundles)
                {
                    new(
                [
                    "Gizard_EN",
                    "VanishingHands",
                ]),
                    new(
                [
                    "Gizard_EN",
                    "PrimitiveGizo_Calm_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Gizard_EN",
                    "Frostbite_Bipedal_EN",
                    "Moone_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GizardHard"))._enemyBundles = gizardHard;

                List<RandomEnemyGroup> footshroomMed = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FootshroomMed"))._enemyBundles)
                {
                    new(
                [
                    "Footshroom_EN",
                    "VanishingHands",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FootshroomMed"))._enemyBundles = footshroomMed;

                List<RandomEnemyGroup> footshroomHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FootshroomHard"))._enemyBundles)
                {
                    new(
                [
                    "Footshroom_EN",
                    "ManicMan_EN",
                    "VanishingHands",
                ]),
                    new(
                [
                    "Footshroom_EN",
                    "JumbleGuts_Waning_EN",
                    "VanishingHands",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FootshroomHard"))._enemyBundles = footshroomHard;

                List<RandomEnemyGroup> incubatorHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("IncubatorHard"))._enemyBundles)
                {
                    new(
                [
                    "ExternalIncubator_EN",
                    "VanishingHands",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("IncubatorHard"))._enemyBundles = incubatorHard;

                List<RandomEnemyGroup> marbleMawEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MawEasy"))._enemyBundles)
                {
                    new(
                [
                    "MarbleMaw_EN",
                    "UninspiredNosestone_EN",
                ]),
                    new(
                [
                    "MarbleMaw_EN",
                    "UninspiredNosestone_EN",
                    "ChoirBoy_EN",
                ]),
                    new(
                [
                    "MarbleMaw_EN",
                    "Inequity_EN",
                    "ShiveringHomunculus_EN",
                    "ShiveringHomunculus_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MawEasy"))._enemyBundles = marbleMawEasy;

                List<RandomEnemyGroup> marbleMawMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MawMed"))._enemyBundles)
                {
                    new(
                [
                    "MarbleMaw_EN",
                    "UninspiredNosestone_EN",
                    "Inequity_EN",
                ]),
                    new(
                [
                    "MarbleMaw_EN",
                    "SweatingNosestone_EN",
                    "InHerImage_EN",
                    "InHisImage_EN",
                ]),
                    new(
                [
                    "MarbleMaw_EN",
                    "ScatterbrainedNosestone_EN",
                    "InHerImage_EN",
                    "InHisImage_EN",
                ]),
                    new(
                [
                    "MarbleMaw_EN",
                    "Inequity_EN",
                    "InHerImage_EN",
                    "InHisImage_EN",
                ]),
                    new(
                [
                    "MarbleMaw_EN",
                    "Inequity_EN",
                    "SkinningHomunculus_EN",
                ]),
                    new(
                [
                    "MarbleMaw_EN",
                    "Inequity_EN",
                    "Vagabond_EN",
                ]),
                    new(
                [
                    "MarbleMaw_EN",
                    "StickingHomunculus_EN",
                    "StickingHomunculus_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MawMed"))._enemyBundles = marbleMawMedium;

                List<RandomEnemyGroup> chancellorEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChancellorEasy"))._enemyBundles)
                {
                    new(
                [
                    "FrowningChancellor_EN",
                    "ProlificNosestone_EN",
                ]),
                    new(
                [
                    "FrowningChancellor_EN",
                    "ScatterbrainedNosestone_EN",
                ]),
                    new(
                [
                    "FrowningChancellor_EN",
                    "UninspiredNosestone_EN",
                ]),
                    new(
                [
                    "FrowningChancellor_EN",
                    "StickingHomunculus_EN",
                    "ShiveringHomunculus_EN",
                ]),
                    new(
                [
                    "FrowningChancellor_EN",
                    "StickingHomunculus_EN",
                    "SkinningHomunculus_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChancellorEasy"))._enemyBundles = chancellorEasy;

                List<RandomEnemyGroup> chancellorMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChancellorMed"))._enemyBundles)
                {
                    new(
                [
                    "FrowningChancellor_EN",
                    "Inequity_EN",
                ]),
                    new(
                [
                    "FrowningChancellor_EN",
                    "Inequity_EN",
                    "InHisImage_EN",
                    "InHisImage_EN",
                ]),
                    new(
                [
                    "FrowningChancellor_EN",
                    "Inequity_EN",
                    "StickingHomunculus_EN",
                ]),
                    new(
                [
                    "FrowningChancellor_EN",
                    "SweatingNosestone_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChancellorMed"))._enemyBundles = chancellorMedium;

                List<RandomEnemyGroup> chancellorHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChancellorHard"))._enemyBundles)
                {
                    new(
                [
                    "FrowningChancellor_EN",
                    "StickingHomunculus_EN",
                    "ShiveringHomunculus_EN",
                    "SkinningHomunculus_EN",
                ]),
                    new(
                [
                    "FrowningChancellor_EN",
                    "MesmerizingNosestone_EN",
                ]),
                    new(
                [
                    "FrowningChancellor_EN",
                    "Maneater_EN",
                ]),
                    new(
                [
                    "FrowningChancellor_EN",
                    "ScatterbrainedNosestone_EN",
                    "InHerImage_EN",
                    "InHerImage_EN",
                ]),
                    new(
                [
                    "FrowningChancellor_EN",
                    "FrowningChancellor_EN",
                    "ProlificNosestone_EN",
                    "UninspiredNosestone_EN",
                ]),
                    new(
                [
                    "FrowningChancellor_EN",
                    "FrowningChancellor_EN",
                    "MarbleMaw_EN",
                    "UninspiredNosestone_EN",
                ]),
                    new(
                [
                    "FrowningChancellor_EN",
                    "Vagabond_EN",
                    "Maneater_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChancellorHard"))._enemyBundles = chancellorHard;

                List<RandomEnemyGroup> chaliceMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChaliceMed"))._enemyBundles)
                {
                    new(
                [
                    "GodsChalice_EN",
                    "ProlificNosestone_EN",
                ]),
                    new(
                [
                    "GodsChalice_EN",
                    "UninspiredNosestone_EN",
                ]),
                    new(
                [
                    "GodsChalice_EN",
                    "StickingHomunculus_EN",
                    "SkinningHomunculus_EN",
                ]),
                    new(
                [
                    "GodsChalice_EN",
                    "Inequity_EN",
                ]),
                    new(
                [
                    "GodsChalice_EN",
                    "Maneater_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChaliceMed"))._enemyBundles = chaliceMedium;

                List<RandomEnemyGroup> chaliceHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChaliceHard"))._enemyBundles)
                {
                    new(
                [
                    "GodsChalice_EN",
                    "ProlificNosestone_EN",
                    "ProlificNosestone_EN",
                ]),
                    new(
                [
                    "GodsChalice_EN",
                    "StickingHomunculus_EN",
                    "SkinningHomunculus_EN",
                    "ShiveringHomunculus_EN",
                ]),
                    new(
                [
                    "GodsChalice_EN",
                    "MesmerizingNosestone_EN",
                    "ProlificNosestone_EN",
                ]),
                    new(
                [
                    "GodsChalice_EN",
                    "SweatingNosestone_EN",
                    "ScatterbrainedNosestone_EN",
                ]),
                    new(
                [
                    "GodsChalice_EN",
                    "SweatingNosestone_EN",
                    "ChoirBoy_EN",
                ]),
                    new(
                [
                    "GodsChalice_EN",
                    "SweatingNosestone_EN",
                    "Inequity_EN",
                ]),
                    new(
                [
                    "GodsChalice_EN",
                    "UninspiredNosestone_EN",
                    "GigglingMinister_EN",
                ]),
                    new(
                [
                    "GodsChalice_EN",
                    "ProlificNosestone_EN",
                    "SkinningHomunculus_EN",
                ]),
                    new(
                [
                    "GodsChalice_EN",
                    "ScatterbrainedNosestone_EN",
                    "NextOfKin_EN",
                    "NextOfKin_EN",
                ]),
                    new(
                [
                    "GodsChalice_EN",
                    "ScatterbrainedNosestone_EN",
                    "MarbleMaw_EN",
                ]),
                    new(
                [
                    "GodsChalice_EN",
                    "Maneater_EN",
                    "MarbleMaw_EN",
                ]),
                    new(
                [
                    "GodsChalice_EN",
                    "Maneater_EN",
                    "FrowningChancellor_EN",
                ]),
                    new(
                [
                    "GodsChalice_EN",
                    "Maneater_EN",
                    "SkinningHomunculus_EN",
                ]),
                    new(
                [
                    "GodsChalice_EN",
                    "Maneater_EN",
                    "Maneater_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChaliceHard"))._enemyBundles = chaliceHard;

                List<RandomEnemyGroup> vagabondMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("VagabondMed"))._enemyBundles)
                {
                    new(
                [
                    "Vagabond_EN",
                    "Maneater_EN",
                ]),
                    new(
                [
                    "Vagabond_EN",
                    "UninspiredNosestone_EN",
                ]),
                    new(
                [
                    "Vagabond_EN",
                    "StickingHomunculus_EN",
                    "StickingHomunculus_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("VagabondMed"))._enemyBundles = vagabondMedium;

                List<RandomEnemyGroup> vagabondHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("VagabondHard"))._enemyBundles)
                {
                    new(
                [
                    "Vagabond_EN",
                    "Maneater_EN",
                    "Maneater_EN",
                ]),
                    new(
                [
                    "Vagabond_EN",
                    "StickingHomunculus_EN",
                    "ShiveringHomunculus_EN",
                    "ShiveringHomunculus_EN",
                ]),
                    new(
                [
                    "Vagabond_EN",
                    "Inequity_EN",
                    "GigglingMinister_EN",
                ]),
                    new(
                [
                    "Vagabond_EN",
                    "Inequity_EN",
                    "Maneater_EN",
                ]),
                    new(
                [
                    "Vagabond_EN",
                    "MesmerizingNosestone_EN",
                    "Maneater_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("VagabondHard"))._enemyBundles = vagabondHard;
            }

            //multi crossovers
            if (Hell_Island_Fell.CrossMod.EnemyPack && Hell_Island_Fell.CrossMod.Colophons)
            {
                List<RandomEnemyGroup> composedEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ComposedEasy"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ComposedEasy"))._enemyBundles = composedEasy;

                List<RandomEnemyGroup> composedMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ComposedMedium"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ComposedMedium"))._enemyBundles = composedMedium;

                List<RandomEnemyGroup> defeatedEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DefeatedEasy"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DefeatedEasy"))._enemyBundles = defeatedEasy;

                List<RandomEnemyGroup> defeatedMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DefeatedMedium"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DefeatedMedium"))._enemyBundles = defeatedMedium;

                List<RandomEnemyGroup> delightedHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DelightedFarShoreHard"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DelightedFarShoreHard"))._enemyBundles = delightedHard;

                List<RandomEnemyGroup> delightedMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DelightedMedium"))._enemyBundles)
                {
                    new(
                [
                    "ColophonDelighted_EN",
                    "Chapman_EN",
                    "Chapman_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "ColophonDelighted_EN",
                    "Seraphim_EN",
                    "Moone_EN",
                    "Moone_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DelightedMedium"))._enemyBundles = delightedMedium;

                List<RandomEnemyGroup> maladjustedHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MaladjustedFarShoreHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MaladjustedFarShoreHard"))._enemyBundles = maladjustedHard;

                List<RandomEnemyGroup> maladjustedMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MaladjustedMedium"))._enemyBundles)
                {
                    new(
                [
                    "ColophonMaladjusted_EN",
                    "Moone_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "ColophonMaladjusted_EN",
                    "Chapman_EN",
                    "Chapman_EN",
                    "Moone_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MaladjustedMedium"))._enemyBundles = maladjustedMedium;

                List<RandomEnemyGroup> chapbullHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChapbullHard"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChapbullHard"))._enemyBundles = chapbullHard;

                List<RandomEnemyGroup> chapmanMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChapmanMedium"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChapmanMedium"))._enemyBundles = chapmanMedium;

                List<RandomEnemyGroup> cherubimHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("CherubimHard"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("CherubimHard"))._enemyBundles = cherubimHard;

                List<RandomEnemyGroup> drySimianMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DrySimianMedium"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DrySimianMedium"))._enemyBundles = drySimianMedium;

                List<RandomEnemyGroup> drySimianHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DrySimianHard"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DrySimianHard"))._enemyBundles = drySimianHard;

                List<RandomEnemyGroup> gizoMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GizoMedium"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GizoMedium"))._enemyBundles = gizoMedium;

                List<RandomEnemyGroup> gizoHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GizoHard"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GizoHard"))._enemyBundles = gizoHard;

                List<RandomEnemyGroup> greyJumbleMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GreyJumbleMedium"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GreyJumbleMedium"))._enemyBundles = greyJumbleMedium;

                List<RandomEnemyGroup> neoplasmHeapMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("HeapMedium"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("HeapMedium"))._enemyBundles = neoplasmHeapMedium;

                List<RandomEnemyGroup> neoplasmHeapHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("HeapHard"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("HeapHard"))._enemyBundles = neoplasmHeapHard;

                List<RandomEnemyGroup> neoplasmLakeHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("LakeHard"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("LakeHard"))._enemyBundles = neoplasmLakeHard;

                List<RandomEnemyGroup> nephilimMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("NephilimMedium"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("NephilimMedium"))._enemyBundles = nephilimMedium;

                List<RandomEnemyGroup> nephilimHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("NephilimHard"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("NephilimHard"))._enemyBundles = nephilimHard;

                List<RandomEnemyGroup> ophanimHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("OphanimHard"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("OphanimHard"))._enemyBundles = ophanimHard;

                List<RandomEnemyGroup> opisthotonusHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("OpisthotonusHard"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("OpisthotonusHard"))._enemyBundles = opisthotonusHard;

                List<RandomEnemyGroup> revoltingHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("RevoltingHard"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("RevoltingHard"))._enemyBundles = revoltingHard;

                List<RandomEnemyGroup> seraphimHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SeraphimHard"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SeraphimHard"))._enemyBundles = seraphimHard;

                List<RandomEnemyGroup> mountainHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MountainHard"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MountainHard"))._enemyBundles = mountainHard;

                List<RandomEnemyGroup> unflarbHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("UnflarbHard"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("UnflarbHard"))._enemyBundles = unflarbHard;

                List<RandomEnemyGroup> zygoteHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ZygoteHard"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ZygoteHard"))._enemyBundles = zygoteHard;
            }

            if (Hell_Island_Fell.CrossMod.EnemyPack && Hell_Island_Fell.CrossMod.EggKeeper)
            {
                List<RandomEnemyGroup> anglerHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("AnglerHard"))._enemyBundles)
                {
                    new(
                [
                    "ImpenetrableAngler_EN",
                    "StickingHomunculus_EN",
                    "EggKeeper_EN",
                ]),
                    new(
                [
                    "ImpenetrableAngler_EN",
                    "ProlificNosestone_EN",
                    "EggKeeper_EN",
                ]),
                    new(
                [
                    "ImpenetrableAngler_EN",
                    "SweatingNosestone_EN",
                    "EggKeeper_EN",
                ]),
                    new(
                [
                    "ImpenetrableAngler_EN",
                    "Inequity_EN",
                    "EggKeeper_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("AnglerHard"))._enemyBundles = anglerHard;

                List<RandomEnemyGroup> metatronHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MetatronHard"))._enemyBundles)
                {
                    new(
                [
                    "Metatron_EN",
                    "SweatingNosestone_EN",
                    "EggKeeper_EN",
                ]),
                    new(
                [
                    "Metatron_EN",
                    "UninspiredNosestone_EN",
                    "EggKeeper_EN",
                ]),
                    new(
                [
                    "Metatron_EN",
                    "ProlificNosestone_EN",
                    "EggKeeper_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MetatronHard"))._enemyBundles = metatronHard;

                List<RandomEnemyGroup> peonEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PeonEasy"))._enemyBundles)
                {

                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PeonEasy"))._enemyBundles = peonEasy;

                List<RandomEnemyGroup> psychopompHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PsychopompHard"))._enemyBundles)
                {
                    new(
                [
                    "Psychopomp_EN",
                    "ProlificNosestone_EN",
                    "EggKeeper_EN",
                ]),
                    new(
                [
                    "Psychopomp_EN",
                    "UninspiredNosestone_EN",
                    "EggKeeper_EN",
                ]),
                    new(
                [
                    "Psychopomp_EN",
                    "SweatingNosestone_EN",
                    "EggKeeper_EN",
                ]),
                    new(
                [
                    "Psychopomp_EN",
                    "MesmerizingNosestone_EN",
                    "EggKeeper_EN",
                ]),
                    new(
                [
                    "Psychopomp_EN",
                    "StickingHomunculus_EN",
                    "EggKeeper_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PsychopompHard"))._enemyBundles = psychopompHard;

                List<RandomEnemyGroup> psychopompMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PsychopompMedium"))._enemyBundles)
                {
                    new(
                [
                    "Psychopomp_EN",
                    "Inequity_EN",
                    "EggKeeper_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PsychopompMedium"))._enemyBundles = psychopompMedium;

                List<RandomEnemyGroup> sterileBudMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SterileBudMedium"))._enemyBundles)
                {
                    new(
                [
                    "SterileBud_EN",
                    "Inequity_EN",
                    "EggKeeper_EN",
                ]),
                    new(
                [
                    "SterileBud_EN",
                    "StickingHomunculus_EN",
                    "EggKeeper_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SterileBudMedium"))._enemyBundles = sterileBudMedium;

                List<RandomEnemyGroup> sterileBudHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SterileBudHard"))._enemyBundles)
                {
                    new(
                [
                    "SterileBud_EN",
                    "ProlificNosestone_EN",
                    "EggKeeper_EN",
                ]),
                    new(
                [
                    "SterileBud_EN",
                    "ScatterbrainedNosestone_EN",
                    "EggKeeper_EN",
                ]),
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SterileBudHard"))._enemyBundles = sterileBudHard;
            }
            if (Hell_Island_Fell.CrossMod.EnemyPack && Hell_Island_Fell.CrossMod.GlitchFreaks)
            {
                List<RandomEnemyGroup> swineEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SwineEasy"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SwineEasy"))._enemyBundles = swineEasy;

                List<RandomEnemyGroup> swineMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SwineMed"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SwineMed"))._enemyBundles = swineMedium;

                List<RandomEnemyGroup> swineHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SwineHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SwineHard"))._enemyBundles = swineHard;

                List<RandomEnemyGroup> baitMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BaitMed"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BaitMed"))._enemyBundles = baitMedium;

                List<RandomEnemyGroup> baitHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BaitHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("baitHard"))._enemyBundles = baitHard;

                List<RandomEnemyGroup> ennoEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("EnnoEasy"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("EnnoEasy"))._enemyBundles = ennoEasy;

                List<RandomEnemyGroup> ennoMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("EnnoMed"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("EnnoMed"))._enemyBundles = ennoMedium;

                List<RandomEnemyGroup> pipeMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PipeMed"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PipeMed"))._enemyBundles = pipeMedium;

                List<RandomEnemyGroup> flakkidEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FlakkidEasy"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FlakkidEasy"))._enemyBundles = flakkidEasy;

                List<RandomEnemyGroup> flakkidMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FlakkidMed"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FlakkidMed"))._enemyBundles = flakkidMedium;

                List<RandomEnemyGroup> backupDancerEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BDancerEasy"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BDancerEasy"))._enemyBundles = backupDancerEasy;

                List<RandomEnemyGroup> backupDancerMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BDancerMed"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BDancerMed"))._enemyBundles = backupDancerMedium;

                List<RandomEnemyGroup> backupDancerHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BDancerHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BDancerHard"))._enemyBundles = backupDancerHard;

                List<RandomEnemyGroup> frostbiteEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FrostbiteEasy"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FrostbiteEasy"))._enemyBundles = frostbiteEasy;

                List<RandomEnemyGroup> frostbiteMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FrostbiteMed"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FrostbiteMed"))._enemyBundles = frostbiteMedium;

                List<RandomEnemyGroup> frostbiteHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FrostbiteHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FrostbiteHard"))._enemyBundles = frostbiteHard;

                List<RandomEnemyGroup> bipedalFrostbiteMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BFrostbiteMed"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BFrostbiteMed"))._enemyBundles = bipedalFrostbiteMedium;

                List<RandomEnemyGroup> bipedalFrostbiteHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BFrostbiteHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BFrostbiteHard"))._enemyBundles = bipedalFrostbiteHard;

                List<RandomEnemyGroup> jansuliEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("JansuliEasy"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("JansuliEasy"))._enemyBundles = jansuliEasy;

                List<RandomEnemyGroup> jansuliMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("JansuliMed"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("JansuliMed"))._enemyBundles = jansuliMedium;

                List<RandomEnemyGroup> jansuliHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("JansuliHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("JansuliHard"))._enemyBundles = jansuliHard;

                List<RandomEnemyGroup> primitiveGizoMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PGizoMed"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PGizoMed"))._enemyBundles = primitiveGizoMedium;

                List<RandomEnemyGroup> primitiveGizoHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PGizoHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PGizoHard"))._enemyBundles = primitiveGizoHard;

                List<RandomEnemyGroup> gizardMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GizardMed"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GizardMed"))._enemyBundles = gizardMedium;

                List<RandomEnemyGroup> gizardHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GizardHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GizardHard"))._enemyBundles = gizardHard;

                List<RandomEnemyGroup> footshroomMed = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FootshroomMed"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FootshroomMed"))._enemyBundles = footshroomMed;

                List<RandomEnemyGroup> footshroomHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FootshroomHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("FootshroomHard"))._enemyBundles = footshroomHard;

                List<RandomEnemyGroup> incubatorHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("IncubatorHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("IncubatorHard"))._enemyBundles = incubatorHard;

                List<RandomEnemyGroup> marbleMawEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MawEasy"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MawEasy"))._enemyBundles = marbleMawEasy;

                List<RandomEnemyGroup> marbleMawMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MawMed"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MawMed"))._enemyBundles = marbleMawMedium;

                List<RandomEnemyGroup> chancellorEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChancellorEasy"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChancellorEasy"))._enemyBundles = chancellorEasy;

                List<RandomEnemyGroup> chancellorMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChancellorMed"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChancellorMed"))._enemyBundles = chancellorMedium;

                List<RandomEnemyGroup> chancellorHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChancellorHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChancellorHard"))._enemyBundles = chancellorHard;

                List<RandomEnemyGroup> chaliceMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChaliceMed"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChaliceMed"))._enemyBundles = chaliceMedium;

                List<RandomEnemyGroup> chaliceHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChaliceHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChaliceHard"))._enemyBundles = chaliceHard;

                List<RandomEnemyGroup> vagabondMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("VagabondMed"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("VagabondMed"))._enemyBundles = vagabondMedium;

                List<RandomEnemyGroup> vagabondHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("VagabondHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("VagabondHard"))._enemyBundles = vagabondHard;

                List<RandomEnemyGroup> anglerHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("AnglerHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("AnglerHard"))._enemyBundles = anglerHard;

                List<RandomEnemyGroup> chapbullHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChapbullHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChapbullHard"))._enemyBundles = chapbullHard;

                List<RandomEnemyGroup> chapmanMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChapmanMedium"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ChapmanMedium"))._enemyBundles = chapmanMedium;

                List<RandomEnemyGroup> cherubimHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("CherubimHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("CherubimHard"))._enemyBundles = cherubimHard;

                List<RandomEnemyGroup> drySimianMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DrySimianMedium"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DrySimianMedium"))._enemyBundles = drySimianMedium;

                List<RandomEnemyGroup> drySimianHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DrySimianHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("DrySimianHard"))._enemyBundles = drySimianHard;

                List<RandomEnemyGroup> gizoMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GizoMedium"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GizoMedium"))._enemyBundles = gizoMedium;

                List<RandomEnemyGroup> gizoHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GizoHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GizoHard"))._enemyBundles = gizoHard;

                List<RandomEnemyGroup> greyJumbleMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GreyJumbleMedium"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("GreyJumbleMedium"))._enemyBundles = greyJumbleMedium;

                List<RandomEnemyGroup> metatronHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MetatronHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MetatronHard"))._enemyBundles = metatronHard;

                List<RandomEnemyGroup> neoplasmHeapMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("HeapMedium"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("HeapMedium"))._enemyBundles = neoplasmHeapMedium;

                List<RandomEnemyGroup> neoplasmHeapHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("HeapHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("HeapHard"))._enemyBundles = neoplasmHeapHard;

                List<RandomEnemyGroup> nephilimMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("NephilimMedium"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("NephilimMedium"))._enemyBundles = nephilimMedium;

                List<RandomEnemyGroup> nephilimHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("NephilimHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("NephilimHard"))._enemyBundles = nephilimHard;

                List<RandomEnemyGroup> ophanimHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("OphanimHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("OphanimHard"))._enemyBundles = ophanimHard;

                List<RandomEnemyGroup> opisthotonusHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("OpisthotonusHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("OpisthotonusHard"))._enemyBundles = opisthotonusHard;

                List<RandomEnemyGroup> peonEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PeonEasy"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PeonEasy"))._enemyBundles = peonEasy;

                List<RandomEnemyGroup> psychopompHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PsychopompHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PsychopompHard"))._enemyBundles = psychopompHard;

                List<RandomEnemyGroup> psychopompMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PsychopompMedium"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PsychopompMedium"))._enemyBundles = psychopompMedium;

                List<RandomEnemyGroup> revoltingHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("RevoltingHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("RevoltingHard"))._enemyBundles = revoltingHard;

                List<RandomEnemyGroup> seraphimHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SeraphimHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SeraphimHard"))._enemyBundles = seraphimHard;

                List<RandomEnemyGroup> mountainHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MountainHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("MountainHard"))._enemyBundles = mountainHard;

                List<RandomEnemyGroup> sterileBudMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SterileBudMedium"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SterileBudMedium"))._enemyBundles = sterileBudMedium;

                List<RandomEnemyGroup> sterileBudHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SterileBudHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("SterileBudHard"))._enemyBundles = sterileBudHard;

                List<RandomEnemyGroup> unflarbHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("UnflarbHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("UnflarbHard"))._enemyBundles = unflarbHard;

                List<RandomEnemyGroup> zygoteHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ZygoteHard"))._enemyBundles)
                {
                };
                ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("ZygoteHard"))._enemyBundles = zygoteHard;
            }
        }
    }
}
