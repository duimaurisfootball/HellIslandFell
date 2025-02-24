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
using Hell_Island_Fell.Field_Effects;
using Hell_Island_Fell.Custom_Stuff;

namespace Hell_Island_Fell
{
    [BepInPlugin("Dui_Mauris_Football.Hell_Island_Fell", "Hell Island Fell", "1.5.7")]
    [BepInDependency("Tairbaz.ColophonConundrum", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency("Tairbaz.EnemyPack", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency("minichibis.eggkeeper", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency("AnimatedGlitch.GlitchsFreaks", BepInDependency.DependencyFlags.SoftDependency)]
    public class Hell_Island_Fell : BaseUnityPlugin
    {
        public static AssetBundle assetBundle;
        public static class CrossMod
        {
            public static bool Colophons = false;
            public static bool EnemyPack = false;
            public static bool EggKeeper = false;
            public static bool GlitchFreaks = false;
            public static void Check()
            {
                foreach (var plugin in Chainloader.PluginInfos)
                {
                    var metadata = plugin.Value.Metadata;

                    if (metadata.GUID == "Tairbaz.ColophonConundrum") { Colophons = true; }
                    if (metadata.GUID == "TairbazPeep.EnemyPack") { EnemyPack = true; }
                    if (metadata.GUID == "minichibis.eggkeeper") { EggKeeper = true; }
                    if (metadata.GUID == "AnimatedGlitch.GlitchsFreaks") { GlitchFreaks = true; }
                }
            }
        }
        public void Awake()
        {
            Debug.Log("Hell Island Fell.");

            new Harmony("Dui_Mauris_Football.Hell_Island_Fell").PatchAll();

            //Add AssetBundles
            assetBundle = AssetBundle.LoadFromMemory(ResourceLoader.ResourceBinary("hif_assetbundle"));
            CustomMusicParameters.Add();

            //Add Damage Types
            DisappearingDamage.Add();

            //Add Field Effects
            Fields.Add();

            //Add Status Effects
            Statuses.Add();

            //Add Whatever else
            NosestoneAbilities.Add();
            LoadedAssetsHandler.GetCharacter("Hans_CH").unitTypes.Add("FemaleID");
            LoadedAssetsHandler.GetCharacter("Pearl_CH").unitTypes.Add("FemaleID");
            LoadedAssetsHandler.GetCharacter("Rags_CH").unitTypes.Add("FemaleID");
            LoadedAssetsHandler.GetCharacter("Bimini_CH").unitTypes.Add("FemaleID");
            CrossMod.Check();
            DivineGlass.Add();
            Lookatme.Add();

            //Add Passives
            CustomPassives.Add();

            //Add Items
            VanishingJar.Add();
            UngroundedElectrode.Add();
            Groanbroad.Add();
            FormidableDinners.Add();
            CurlingFinger.Add();
            PickledBeets.Add();
            Sauerkraut.Add();
            AppleCiderVinegar.Add();
            AlumSalt.Add();
            BloodThinners.Add();
            CoughMedicine.Add();
            Retinol.Add();
            Melatonin.Add();
            Hotpot.Add();
            PaintedDie.Add();

            //Osman Unlocks
            SymbolOfPeace.Add();
            BismuthSubsalicylate.Add();
            DoversPowder.Add();
            Element83.Add();
            AccursedRibcage.Add();
            SickleCells.Add();
            CarversTools.Add();
            BowlingBall.Add();
            CheesePlate.Add();
            FresnelLens.Add();
            ParchedScroll.Add();
            ComplexComplexion.Add();
            HoxJar.Add();
            NightOil.Add();
            BrailleTypewriter.Add();
            StabbingHomunculus.Add();
            Nemesis.Add();
            GreenGlass.Add();
            FetidTooth.Add();
            BlackPearl.Add();
            //
            //

            //Heaven 
            ThousandFish.Add();
            IridescentCrystal.Add();
            SyrupOfIpecac.Add();
            Hyperfixation.Add();
            CursedLeg.Add();
            FesterFlesh.Add();
            MalebolgesSeveredHead.Add();
            TollBell.Add();
            BavarianPretzel.Add();
            Kraken.Add();
            LiquidDust.Add();
            AncientWine.Add();
            InfiniteMirror.Add();
            AlchemicalConstant.Add();
            AntiqueCashRegister.Add();
            Ripcord.Add();
            MagicAccelerator.Add();
            TheDeal.Add();
            InfernalStone.Add();
            Trinitite.Add();
            //
            //

            //Doula Unlocks
            //CatastropheStick.Add();
            //Airhorn.Add();
            //MosaLina.Add();
            //OrbOfFreedom.Add();
            //TheDrawOfPower.Add();
            //ShockingMachine.Add();
            //FriendlyFace.Add();
            //ElusiveTrinket.Add();
            //AngryBox.Add();
            //IceFlies.Add();
            //BubbleShield.Add();
            //CursedDoll.Add();
            //BrokenAltimeter.Add();
            //DeadSeatedHead.Add();
            //RedBook.Add();
            //AFlower.Add();
            //TerrifyingMortarRounds.Add();
            //LabyrinthDevice.Add();
            //PlatinumDisc.Add();
            //ReactorCell.Add();
            //AlienChunk.Add();
            //FissureTelescope.Add();

            //March Unlocks
            //PhlegmSuckingWorm.Add();
            //VomitBrick.Add();
            //IdeaOfRot.Add();
            //Deflation.Add();
            //DeathHex.Add();
            //CancerCancer.Add();
            //PhoenixForest.Add();
            //301.Add();
            //ThingsFinder.Add();
            //ShipOfTheseus.Add();
            //Erosion.Add();
            //FingernailOfGlory.Add();
            //TheEntireMoon.Add();
            //
            //PeoplePower.Add();
            //RealizationOfMortality.Add();
            //Sundial.Add();
            //PatternMass.Add();
            //CrackedDirt.Add();
            //
            //

            //Bemagel Unlocks

            //Other Unlocks
            NumberMagnet.Add();
            SparklingFork.Add();
            FractionAbacus.Add();

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
            Naba.Add();
            Aelie.Add();
            Gomma.Add();
            Hills.Add();
            Maecenas.Add();
            Chim.Add();
            Hoftstoldt.Add();
            Pinec.Add();
            Stareyed.Add();
            Exambry.Add();
            Morrigan.Add();
            //Nick.Add();
            //Eras.Add();
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
            Keklung.Add();
            Vus.Add();
            Draugr.Add();
            Heehoo.Add();
            Thunderdome.Add();
            //Tubert.Add();
            //Gotanga.Add();
            //Makado.Add();
            //Kreeber.Add();
            //FaceRipper.Add();

            //Add Encounters
            CustomFarShoreEncounters.Add();
            CustomOrpheumEncounters.Add();
            CustomGardenEncounters.Add();
            SweatingEncounters.Add();
            MesmerizingEncounters.Add();
            ProlificEncounters.Add();
            ScatterbrainedEncounters.Add();
            UninspiredEncounters.Add();
            InequityEncounters.Add();
            ManeaterEncounters.Add();
            StickingHomunculusEncounters.Add();
            BoojumEncounter.Add();
            BolerEncounters.Add();
            MooneEncounters.Add();
            FlatbackEncounters.Add();
            KekingdomEncounters.Add();
            KeklungEncounters.Add();
            VusEncounter.Add();
            DraugrEncounters.Add();
            HeehooEncounters.Add();
            ThunderdomeEncounters.Add();
            CrossoverEncounters.Add();

            //Add Achievements
            CustomAchievements.Add();
        }
    }
}
