global using BrutalAPI;
global using UnityEngine;
global using System;
global using BepInEx;
global using Hell_Island_Fell.Fools;
global using Hell_Island_Fell.Status_Effects;
global using Hell_Island_Fell.Damage_Types;
global using Hell_Island_Fell.Custom_Passives;
global using Hell_Island_Fell.Items;
global using Hell_Island_Fell.Achievements;
global using Hell_Island_Fell.Enemies;
global using Hell_Island_Fell.Abilities;
global using Hell_Island_Fell.Encounters;
global using BepInEx.Bootstrap;
using HarmonyLib;

namespace Hell_Island_Fell
{
    [BepInPlugin("Dui_Mauris_Football.Hell_Island_Fell", "Hell Island Fell", "1.3.1")]
    [BepInDependency("Tairbaz.ColophonConundrum", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency("Tairbaz.EnemyPack", BepInDependency.DependencyFlags.SoftDependency)]
    public class Hell_Island_Fell : BaseUnityPlugin
    {
        public static AssetBundle assetBundle;
        public static class CrossMod
        {
            public static bool Colophons = false;
            public static bool EnemyPack = false;
            public static void Check()
            {
                foreach (var plugin in Chainloader.PluginInfos)
                {
                    var metadata = plugin.Value.Metadata;

                    if (metadata.GUID == "Tairbaz.ColophonConundrum") { Colophons = true; }
                    if (metadata.GUID == "TairbazPeep.EnemyPack") { EnemyPack = true; }
                }
            }
        }
        public void Awake()
        {
            Debug.Log("Hell Island Fell.");

            new Harmony("Dui_Mauris_Football.Hell_Island_Fell").PatchAll();

            //Add AssetBundles
            assetBundle = AssetBundle.LoadFromMemory(ResourceLoader.ResourceBinary("hif_assetbundle"));

            //Add Damage Types
            DisappearingDamage.Add();

            //Add Field Effects


            //Add Status Effects
            Statuses.Add();

            //Add Whatever else
            NosestoneAbilities.Add();
            LoadedAssetsHandler.GetCharacter("Hans_CH").unitTypes.Add("FemaleID");
            LoadedAssetsHandler.GetCharacter("Pearl_CH").unitTypes.Add("FemaleID");
            LoadedAssetsHandler.GetCharacter("Rags_CH").unitTypes.Add("FemaleID");
            LoadedAssetsHandler.GetCharacter("Bimini_CH").unitTypes.Add("FemaleID");
            CrossMod.Check();

            //Add Passives
            CustomPassives.Add();

            //Add Items
            VanishingJar.Add();
            UngroundedElectrode.Add();
            Groanbroad.Add();
            FormidableDinners.Add();
            CurlingFinger.Add();

            //Unlock Items
            SymbolOfPeace.Add();
            ThousandFish.Add();
            BismuthSubsalicylate.Add();
            IridescentCrystal.Add();
            DoversPowder.Add();
            SyrupOfIpecac.Add();
            Element83.Add();
            Hyperfixation.Add();
            AccursedRibcage.Add();
            CursedLeg.Add();
            SickleCells.Add();
            FesterFlesh.Add();
            CarversTools.Add();
            MalebolgesSeveredHead.Add();
            BowlingBall.Add();
            TollBell.Add();
            BavarianPretzel.Add();
            CheesePlate.Add();
            ParchedScroll.Add();
            LiquidDust.Add();
            HoxJar.Add();
            InfiniteMirror.Add();
            FetidTooth.Add();
            InfernalStone.Add();
            //StabbingHomunculus.Add();

            NumberMagnet.Add();
            SparklingFork.Add();

            //Add Characters
            Vandander.Add();
            Spoogle.Add();
            Farah.Add();
            Salad.Add();
            Rodney.Add();
            Vat.Add();
            Malebolge.Add();
            Felix.Add();
            Alvinar.Add();
            //Naba.Add();
            Aelie.Add();
            Gomma.Add();
            Hills.Add();
            //Maecenas.Add();
            Hoftstoldt.Add();
            Pinec.Add();
            //Stareyed.Add();
            //Chim.Add();
            Exambry.Add();
            Morrigan.Add();
            //Nick.Add();
            //Maellard.Add();
            HolesOfVandander.Add();
            Mudball.Add();

            //Add Enemies
            SweatingNosestone.Add();
            ProlificNosestone.Add();
            ScatterbrainedNosestone.Add();
            MesmerizingNosestone.Add();
            UninspiredNosestone.Add();
            Maneater.Add();
            Inequity.Add();
            Boojum.Add();
            StickingHomunculus.Add();
            Boler.Add();
            Moone.Add();
            VanishingHands.Add();
            Flatback.Add();
            Kekingdom.Add();
            //Tubert.Add();
            //Gotanga.Add();
            //Makado.Add();
            //Kreeber.Add();
            //FaceRipper.Add();
            //Keklung.Add();

            //Add Encounters
            CustomOrpheumEncounters.Add();
            CustomGardenEncounters.Add();
            SweatingEncounters.Add();
            MesmerizingEncounters.Add();
            ProlificEncounters.Add();
            ScatterbrainedEncounters.Add();
            UninspiredEncounters.Add();
            ManeaterEncounters.Add();
            StickingHomunculusEncounters.Add();
            BoojumEncounter.Add();
            BolerEncounters.Add();
            MooneEncounters.Add();
            FlatbackEncounters.Add();
            KekingdomEncounters.Add();
            CrossoverEncounters.Add();

            //Add Achievements
            CustomAchievements.Add();
        }
    }
}
