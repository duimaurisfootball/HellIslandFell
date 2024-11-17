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
                    "MusicMan_EN",
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
                    "MesmerizingNosestone_EN",
                    "SweatingNosestone_EN",
                ]),
                    new(
                [
                    "ImpenetrableAngler_EN",
                    "UninspiredNosestone_EN",
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
                    "VanishingHands_EN",
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
                    new(
                [
                    "DrySimian_EN",
                    "Mung_EN",
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
                    new(
                [
                    "DrySimian_EN",
                    "MudLung_EN",
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "DrySimian_EN",
                    "LipBug_EN",
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
                    new(
                [
                    "Gizo_EN",
                    "NakedGizo_EN",
                    "VanishingHands_EN",
                    "Moone_EN",
                ]),
                    new(
                [
                    "Gizo_EN",
                    "NakedGizo_EN",
                    "VanishingHands_EN",
                    "MusicMan_EN",
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
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "NeoplasmHeap_EN",
                    "Neoplasm_EN",
                    "VanishingHands_EN",
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
                    new(
                [
                    "NeoplasmLake_EN",
                    "VanishingHands_EN",
                ]),
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
                    "VanishingHands_EN",
                ]),
                    new(
                [
                    "Ophanim_EN",
                    "Seraphim_EN",
                    "VanishingHands_EN",
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
                    new(
                [
                    "Opisthotonus_EN",
                    "VanishingHands_EN",
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
