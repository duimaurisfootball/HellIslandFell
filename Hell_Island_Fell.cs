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
using BepInEx.Configuration;
using System.IO;

namespace Hell_Island_Fell
{
    [BepInPlugin("Dui_Mauris_Football.Hell_Island_Fell", "Hell Island Fell", "2.2.0")]
    [BepInDependency("Tairbaz.ColophonConundrum", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency("Tairbaz.EnemyPack", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency("minichibis.eggkeeper", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency("AnimatedGlitch.GlitchsFreaks", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency("Marmo.MarmoEnemies", BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency("AnimatedGlitch.Siren", BepInDependency.DependencyFlags.SoftDependency)]
    public class Hell_Island_Fell : BaseUnityPlugin
    {
        public static AssetBundle assetBundle;
        public static ConfigEntry<bool> arachnophobiaMode;
        public static class CrossMod
        {
            public static bool Colophons = false;
            public static bool EnemyPack = false;
            public static bool EggKeeper = false;
            public static bool GlitchFreaks = false;
            public static bool BoxOfBeasts = false;
            public static bool TheSiren = false;
            public static void Check()
            {
                foreach (var plugin in Chainloader.PluginInfos)
                {
                    var metadata = plugin.Value.Metadata;

                    if (metadata.GUID == "Tairbaz.ColophonConundrum") { Colophons = true; }
                    if (metadata.GUID == "TairbazPeep.EnemyPack") { EnemyPack = true; }
                    if (metadata.GUID == "minichibis.eggkeeper") { EggKeeper = true; }
                    if (metadata.GUID == "AnimatedGlitch.GlitchsFreaks") { GlitchFreaks = true; }
                    if (metadata.GUID == "Marmo.MarmoEnemies") { BoxOfBeasts = true; }
                    if (metadata.GUID == "AnimatedGlitch.Siren") { TheSiren = true; }
                }
            }
        }
        public void Awake()
        {
            Debug.Log("Hell Island Fell.");

            new Harmony("Dui_Mauris_Football.Hell_Island_Fell").PatchAll();

            ConfigFile config = new ConfigFile(Path.Combine(Paths.ConfigPath, "HellIslandFell.cfg"), true);
            arachnophobiaMode = config.Bind("Phobia", "Arachnophobia", true, "Changes the visuals of the following enemies: Flatback, Kekingdom");

            //Add AssetBundles
            assetBundle = AssetBundle.LoadFromMemory(ResourceLoader.ResourceBinary("hif_assetbundle"));
            CustomMusicParameters.Add();

            //Add First Stuff
            DisappearingDamage.Add();
            CustomIntents.Add();

            //Add Field Effects
            Fields.Add();

            //Add Status Effects
            Statuses.Add();

            //Add Whatever else
            LoadedAssetsHandler.GetCharacter("Hans_CH").unitTypes.Add("FemaleID");
            LoadedAssetsHandler.GetCharacter("Pearl_CH").unitTypes.Add("FemaleID");
            LoadedAssetsHandler.GetCharacter("Rags_CH").unitTypes.Add("FemaleID");
            LoadedAssetsHandler.GetCharacter("Bimini_CH").unitTypes.Add("FemaleID");
            LoadedAssetsHandler.GetWearable("BalticBrine_SW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("CanOfWorms_SW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("MysteryRation_SW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("VyacheslavsLastSip_SW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("BloodBottle_SW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("MedicalLeeches_SW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("LilHomunculus_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("FunnyMushrooms_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("LumpOfLamb_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("MommaNooty_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("RuntyRotter_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("TaintedApple_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("AGift_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("AsceticEgg_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("Bananas_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("DivineMud_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("EggOfIncubus_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("GamifiedSquid_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("HarvestandPlenty_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("HolyChalice_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("LustPudding_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("MeatreWorm_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("OpulentEgg_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("SeedsOfTheConsumed_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("SkinnedSkate_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("StarvingApples_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("StrangeFruit_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("TheApple_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("TheFirstBorn_TW").AddItemType("FoodID");
            LoadedAssetsHandler.GetWearable("LilOrro_TW").AddItemType("FoodID");
            CrossMod.Check();
            DivineGlass.Add();
            Lookatme.Add();
            NosestoneAbilities.Add();

            //Add Passives
            CustomPassives.Add();

            //Add Treasure Items
            VanishingJar.Add();
            UngroundedElectrode.Add();
            Groanbroad.Add();
            FormidableDinners.Add();
            ElectrumOre.Add();
            NeptunesCrown.Add();
            LilDraugr.Add();
            WakingScream.Add();
            BundleOfFingers.Add();
            CatastropheStick.Add();
            GunGun.Add();
            OrbOfFreedom.Add();
            //TheDrawOfPower.Add();
            //FriendlyFace.Add();
            //AngryBox.Add();
            //IceFlies.Add();
            //DeadSeatedHead.Add();
            //BlueBook.Add();
            AFlower.Add();
            //LabyrinthDevice.Add();
            //AlienChunk.Add();
            //PhlegmSuckingWorm.Add();
            //IdeaOfRot.Add();
            //DeathHex.Add();
            //CancerCancer.Add();
            //PhoenixForest.Add();
            //Erosion.Add();
            //TheEntireMoon.Add();
            //Warmth.Add();
            //PeoplePower.Add();
            //RealizationOfMortality.Add();
            //PatternMass.Add();
            //CrackedDirt.Add();
            //FecalInnoculation.Add();
            //ShockingMachine.Add();
            //301.Add();

            //Add Shop Items
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
            //Airhorn.Add();
            //BubbleShield.Add();
            //CursedDoll.Add();
            //PlatinumDisc.Add();
            //FissureTelescope.Add();
            //VomitBrick.Add();
            Deflation.Add();
            //ThingsFinder.Add();
            Sundial.Add();
            //IronChair.Add();
            SurrealMannequinHead.Add();

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
            BlankPointBlankPoint.Add();
            Heartworm.Add();
            ElusiveTrinket.Add();

            //Heaven Unlocks
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
            EnamelSandpaper.Add();
            Blastocyst.Add();
            FingernailOfGlory.Add();

            //Bemagel Unlocks

            //Other Unlocks
            CurlingFinger.Add();
            NumberMagnet.Add();
            SparklingFork.Add();
            FractionAbacus.Add();
            AmbulantMonolith.Add();
            MyNemesis.Add();
            BloodyNemesis.Add();
            BatteredNemesis.Add();
            InvincibleNemesis.Add();
            FatesBoundByNemesis.Add();
            HornAndHandle.Add();

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
            Nick.Add();
            Eras.Add();
            NukePits.Add();
            Mudball.Add();
            HolesOfVandander.Add();

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
            Nevermore.Add();
            if (CrossMod.TheSiren)
            {
                OneShooter.Add();
            }
            Waxman.Add();
            Kagla.Add();
            //Wellenoch.Add();
            GreaterTobana.Add();
            VanishingPillar.Add();
            //Nyctohatze.Add();
            //BemagelRoyches.Add();
            //LostPotential.Add();

            //Add Encounters
            CustomFarShoreEncounters.Add();
            FlatbackEncounters.Add();
            KekingdomEncounters.Add();
            KeklungEncounters.Add();
            DraugrEncounters.Add();
            VusEncounter.Add();

            CustomOrpheumEncounters.Add();
            MooneEncounters.Add();
            HeehooEncounters.Add();
            ThunderdomeEncounters.Add();
            BolerEncounters.Add();

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
            NevermoreEncounters.Add();

            TestEncounters.Add();

            CrossoverEncounters.Add();
            if (CrossMod.TheSiren)
            {
                OneShooterEncounters.Add();
                CustomSirenEncounters.Add();
            }

            //Add Achievements
            CustomAchievements.Add();
        }
    }
    public static class AddItemTypes
    {
        public static void AddItemType(this BaseWearableSO wearable, string itemType)
        {
            wearable._ItemTypeIDs = wearable._ItemTypeIDs.AddToArray(itemType);
        }
    }
}
