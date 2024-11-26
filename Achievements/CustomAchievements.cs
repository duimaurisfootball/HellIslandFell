using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Achievements
{
    public class CustomAchievements
    {
        public static void Add()
        {
            //Osman Unlocks
            ModdedAchievements AchievementWitnessVandander = new ModdedAchievements("Symbol of Peace", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementOsmanVandander", null, 32, null), "HIF_Vandander_Witness_ACH");
            AchievementWitnessVandander.AddNewAchievementToInGameCategory((AchievementCategoryIDs)4);
            FinalBossCharUnlockCheck UnlockWitnessVandander = Unlocks.GetUnlock_OsmanFinalBoss();
            UnlockWitnessVandander.AddUnlockData("Vandander_CH", Unlocks.GenerateUnlockData("HIF_Vandander_Witness_Unlock", "HIF_Vandander_Witness_ACH", "", "", ["SymbolOfPeace_TW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Vandander_Witness_ACH", "SymbolOfPeace_TW");

            ModdedAchievements AchievementWitnessSpoogle = new ModdedAchievements("Bismuth Subsalicylate", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementOsmanSpoogle", null, 32, null), "HIF_Spoogle_Witness_ACH");
            AchievementWitnessSpoogle.AddNewAchievementToInGameCategory((AchievementCategoryIDs)4);
            FinalBossCharUnlockCheck UnlockWitnessSpoogle = Unlocks.GetUnlock_OsmanFinalBoss();
            UnlockWitnessSpoogle.AddUnlockData("Spoogle_CH", Unlocks.GenerateUnlockData("HIF_Spoogle_Witness_Unlock", "HIF_Spoogle_Witness_ACH", "", "", ["BismuthSubsalicylate_SW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Spoogle_Witness_ACH", "BismuthSubsalicylate_SW");

            ModdedAchievements AchievementWitnessFarah = new ModdedAchievements("Dover's Powder", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementOsmanFarah", null, 32, null), "HIF_Farah_Witness_ACH");
            AchievementWitnessFarah.AddNewAchievementToInGameCategory((AchievementCategoryIDs)4);
            FinalBossCharUnlockCheck UnlockWitnessFarah = Unlocks.GetUnlock_OsmanFinalBoss();
            UnlockWitnessFarah.AddUnlockData("Farah_CH", Unlocks.GenerateUnlockData("HIF_Farah_Witness_Unlock", "HIF_Farah_Witness_ACH", "", "", ["DoversPowder_SW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Farah_Witness_ACH", "DoversPowder_SW");

            ModdedAchievements AchievementWitnessSalad = new ModdedAchievements("Element 83", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementOsmanSalad", null, 32, null), "HIF_Salad_Witness_ACH");
            AchievementWitnessSalad.AddNewAchievementToInGameCategory((AchievementCategoryIDs)4);
            FinalBossCharUnlockCheck UnlockWitnessSalad = Unlocks.GetUnlock_OsmanFinalBoss();
            UnlockWitnessSalad.AddUnlockData("Salad_CH", Unlocks.GenerateUnlockData("HIF_Salad_Witness_Unlock", "HIF_Salad_Witness_ACH", "", "", ["Element83_TW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Salad_Witness_ACH", "Element83_TW");

            ModdedAchievements AchievementWitnessRodney = new ModdedAchievements("Accursed Ribcage", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementOsmanRodney", null, 32, null), "HIF_Rodney_Witness_ACH");
            AchievementWitnessRodney.AddNewAchievementToInGameCategory((AchievementCategoryIDs)4);
            FinalBossCharUnlockCheck UnlockWitnessRodney = Unlocks.GetUnlock_OsmanFinalBoss();
            UnlockWitnessRodney.AddUnlockData("Rodney_CH", Unlocks.GenerateUnlockData("HIF_Rodney_Witness_Unlock", "HIF_Rodney_Witness_ACH", "", "", ["AccursedRibcage_TW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Rodney_Witness_ACH", "AccursedRibcage_TW");

            ModdedAchievements AchievementWitnessVat = new ModdedAchievements("Sickle Cells", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementOsmanVat", null, 32, null), "HIF_Vat_Witness_ACH");
            AchievementWitnessVat.AddNewAchievementToInGameCategory((AchievementCategoryIDs)4);
            FinalBossCharUnlockCheck UnlockWitnessVat = Unlocks.GetUnlock_OsmanFinalBoss();
            UnlockWitnessVat.AddUnlockData("Vat_CH", Unlocks.GenerateUnlockData("HIF_Vat_Witness_Unlock", "HIF_Vat_Witness_ACH", "", "", ["SickleCells_TW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Vat_Witness_ACH", "SickleCells_TW");

            ModdedAchievements AchievementWitnessMalebolge = new ModdedAchievements("Carver's Tools", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementOsmanMalebolge", null, 32, null), "HIF_Malebolge_Witness_ACH");
            AchievementWitnessMalebolge.AddNewAchievementToInGameCategory((AchievementCategoryIDs)4);
            FinalBossCharUnlockCheck UnlockWitnessMalebolge = Unlocks.GetUnlock_OsmanFinalBoss();
            UnlockWitnessMalebolge.AddUnlockData("Malebolge_CH", Unlocks.GenerateUnlockData("HIF_Malebolge_Witness_Unlock", "HIF_Malebolge_Witness_ACH", "", "", ["CarversTools_SW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Malebolge_Witness_ACH", "CarversTools_SW");

            ModdedAchievements AchievementWitnessFelix = new ModdedAchievements("Bowling Ball", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementOsmanFelix", null, 32, null), "HIF_Felix_Witness_ACH");
            AchievementWitnessFelix.AddNewAchievementToInGameCategory((AchievementCategoryIDs)4);
            FinalBossCharUnlockCheck UnlockWitnessFelix = Unlocks.GetUnlock_OsmanFinalBoss();
            UnlockWitnessFelix.AddUnlockData("Felix_CH", Unlocks.GenerateUnlockData("HIF_Felix_Witness_Unlock", "HIF_Felix_Witness_ACH", "", "", ["BowlingBall_SW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Felix_Witness_ACH", "BowlingBall_SW");

            ModdedAchievements AchievementWitnessAlvinar = new ModdedAchievements("Cheese Plate", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementOsmanAlvinar", null, 32, null), "HIF_Alvinar_Witness_ACH");
            AchievementWitnessAlvinar.AddNewAchievementToInGameCategory((AchievementCategoryIDs)4);
            FinalBossCharUnlockCheck UnlockWitnessAlvinar = Unlocks.GetUnlock_OsmanFinalBoss();
            UnlockWitnessAlvinar.AddUnlockData("Alvinar_CH", Unlocks.GenerateUnlockData("HIF_Alvinar_Witness_Unlock", "HIF_Alvinar_Witness_ACH", "", "", ["CheesePlate_SW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Alvinar_Witness_ACH", "CheesePlate_SW");

            ModdedAchievements AchievementWitnessAelie = new ModdedAchievements("Parched Scroll", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementOsmanAelie", null, 32, null), "HIF_Aelie_Witness_ACH");
            AchievementWitnessAelie.AddNewAchievementToInGameCategory((AchievementCategoryIDs)4);
            FinalBossCharUnlockCheck UnlockWitnessAelie = Unlocks.GetUnlock_OsmanFinalBoss();
            UnlockWitnessAelie.AddUnlockData("Aelie_CH", Unlocks.GenerateUnlockData("HIF_Aelie_Witness_Unlock", "HIF_Aelie_Witness_ACH", "", "", ["ParchedScroll_TW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Aelie_Witness_ACH", "ParchedScroll_TW");

            ModdedAchievements AchievementWitnessHills = new ModdedAchievements("Hox Jar", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementOsmanHills", null, 32, null), "HIF_Hills_Witness_ACH");
            AchievementWitnessHills.AddNewAchievementToInGameCategory((AchievementCategoryIDs)4);
            FinalBossCharUnlockCheck UnlockWitnessHills = Unlocks.GetUnlock_OsmanFinalBoss();
            UnlockWitnessHills.AddUnlockData("Hills_CH", Unlocks.GenerateUnlockData("HIF_Hills_Witness_Unlock", "HIF_Hills_Witness_ACH", "", "", ["HoxJar_TW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Hills_Witness_ACH", "HoxJar_TW");

            ModdedAchievements AchievementWitnessExambry = new ModdedAchievements("Fetid Tooth", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementOsmanExambry", null, 32, null), "HIF_Exambry_Witness_ACH");
            AchievementWitnessExambry.AddNewAchievementToInGameCategory((AchievementCategoryIDs)4);
            FinalBossCharUnlockCheck UnlockWitnessExambry = Unlocks.GetUnlock_OsmanFinalBoss();
            UnlockWitnessExambry.AddUnlockData("Exambry_CH", Unlocks.GenerateUnlockData("HIF_Exambry_Witness_Unlock", "HIF_Exambry_Witness_ACH", "", "", ["FetidTooth_TW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Exambry_Witness_ACH", "FetidTooth_TW");


            //Heaven Unlocks
            ModdedAchievements AchievementDivineVandander = new ModdedAchievements("Thousand Fish", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementHeavenVandander", null, 32, null), "HIF_Vandander_Divine_ACH");
            AchievementDivineVandander.AddNewAchievementToInGameCategory((AchievementCategoryIDs)5);
            FinalBossCharUnlockCheck UnlockDivineVandander = Unlocks.GetUnlock_HeavenFinalBoss();
            UnlockDivineVandander.AddUnlockData("Vandander_CH", Unlocks.GenerateUnlockData("HIF_Vandander_Divine_Unlock", "HIF_Vandander_Divine_ACH", "", "", ["ThousandFish_TW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Vandander_Divine_ACH", "ThousandFish_TW");

            ModdedAchievements AchievementDivineSpoogle = new ModdedAchievements("Iridescent Crystal", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementHeavenSpoogle", null, 32, null), "HIF_Spoogle_Divine_ACH");
            AchievementDivineSpoogle.AddNewAchievementToInGameCategory((AchievementCategoryIDs)5);
            FinalBossCharUnlockCheck UnlockDivineSpoogle = Unlocks.GetUnlock_HeavenFinalBoss();
            UnlockDivineSpoogle.AddUnlockData("Spoogle_CH", Unlocks.GenerateUnlockData("HIF_Spoogle_Divine_Unlock", "HIF_Spoogle_Divine_ACH", "", "", ["Iridescent Crystal_TW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Spoogle_Divine_ACH", "Iridescent Crystal_TW");

            ModdedAchievements AchievementDivineFarah = new ModdedAchievements("Syrup of Ipecac", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementHeavenFarah", null, 32, null), "HIF_Farah_Divine_ACH");
            AchievementDivineFarah.AddNewAchievementToInGameCategory((AchievementCategoryIDs)5);
            FinalBossCharUnlockCheck UnlockDivineFarah = Unlocks.GetUnlock_HeavenFinalBoss();
            UnlockDivineFarah.AddUnlockData("Farah_CH", Unlocks.GenerateUnlockData("HIF_Farah_Divine_Unlock", "HIF_Farah_Divine_ACH", "", "", ["SyrupOfIpecac_SW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Farah_Divine_ACH", "SyrupOfIpecac_SW");

            ModdedAchievements AchievementDivineSalad = new ModdedAchievements("Hyperfixation", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementHeavenSalad", null, 32, null), "HIF_Salad_Divine_ACH");
            AchievementDivineSalad.AddNewAchievementToInGameCategory((AchievementCategoryIDs)5);
            FinalBossCharUnlockCheck UnlockDivineSalad = Unlocks.GetUnlock_HeavenFinalBoss();
            UnlockDivineSalad.AddUnlockData("Salad_CH", Unlocks.GenerateUnlockData("HIF_Salad_Divine_Unlock", "HIF_Salad_Divine_ACH", "", "", ["Hyperfixation_TW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Salad_Divine_ACH", "Hyperfixation_TW");

            ModdedAchievements AchievementDivineRodney = new ModdedAchievements("Cursed Leg", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementHeavenRodney", null, 32, null), "HIF_Rodney_Divine_ACH");
            AchievementDivineRodney.AddNewAchievementToInGameCategory((AchievementCategoryIDs)5);
            FinalBossCharUnlockCheck UnlockDivineRodney = Unlocks.GetUnlock_HeavenFinalBoss();
            UnlockDivineRodney.AddUnlockData("Rodney_CH", Unlocks.GenerateUnlockData("HIF_Rodney_Divine_Unlock", "HIF_Rodney_Divine_ACH", "", "", ["CursedLeg_TW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Rodney_Divine_ACH", "CursedLeg_TW");

            ModdedAchievements AchievementDivineVat = new ModdedAchievements("Fester Flesh", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementHeavenVat", null, 32, null), "HIF_Vat_Divine_ACH");
            AchievementDivineVat.AddNewAchievementToInGameCategory((AchievementCategoryIDs)5);
            FinalBossCharUnlockCheck UnlockDivineVat = Unlocks.GetUnlock_HeavenFinalBoss();
            UnlockDivineVat.AddUnlockData("Vat_CH", Unlocks.GenerateUnlockData("HIF_Vat_Divine_Unlock", "HIF_Vat_Divine_ACH", "", "", ["FesterFlesh_TW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Vat_Divine_ACH", "FesterFlesh_TW");

            ModdedAchievements AchievementDivineMalebolge = new ModdedAchievements("Malebolge's Severed Head", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementHeavenMalebolge", null, 32, null), "HIF_Malebolge_Divine_ACH");
            AchievementDivineMalebolge.AddNewAchievementToInGameCategory((AchievementCategoryIDs)5);
            FinalBossCharUnlockCheck UnlockDivineMalebolge = Unlocks.GetUnlock_HeavenFinalBoss();
            UnlockDivineMalebolge.AddUnlockData("Malebolge_CH", Unlocks.GenerateUnlockData("HIF_Malebolge_Divine_Unlock", "HIF_Malebolge_Divine_ACH", "", "", ["MalebolgesSeveredHead_TW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Malebolge_Divine_ACH", "MalebolgesSeveredHead_TW");

            ModdedAchievements AchievementDivineFelix = new ModdedAchievements("Toll Bell", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementHeavenFelix", null, 32, null), "HIF_Felix_Divine_ACH");
            AchievementDivineFelix.AddNewAchievementToInGameCategory((AchievementCategoryIDs)5);
            FinalBossCharUnlockCheck UnlockDivineFelix = Unlocks.GetUnlock_HeavenFinalBoss();
            UnlockDivineFelix.AddUnlockData("Felix_CH", Unlocks.GenerateUnlockData("HIF_Felix_Divine_Unlock", "HIF_Felix_Divine_ACH", "", "", ["TollBell_SW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Felix_Divine_ACH", "TollBell_SW");

            ModdedAchievements AchievementDivineAlvinar = new ModdedAchievements("Bavarian Pretzel", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementHeavenAlvinar", null, 32, null), "HIF_Alvinar_Divine_ACH");
            AchievementDivineAlvinar.AddNewAchievementToInGameCategory((AchievementCategoryIDs)5);
            FinalBossCharUnlockCheck UnlockDivineAlvinar = Unlocks.GetUnlock_HeavenFinalBoss();
            UnlockDivineAlvinar.AddUnlockData("Alvinar_CH", Unlocks.GenerateUnlockData("HIF_Alvinar_Divine_Unlock", "HIF_Alvinar_Divine_ACH", "", "", ["BavarianPretzel_SW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Alvinar_Divine_ACH", "BavarianPretzel_SW");

            ModdedAchievements AchievementDivineAelie = new ModdedAchievements("Liquid Dust", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementHeavenAelie", null, 32, null), "HIF_Aelie_Divine_ACH");
            AchievementDivineAelie.AddNewAchievementToInGameCategory((AchievementCategoryIDs)5);
            FinalBossCharUnlockCheck UnlockDivineAelie = Unlocks.GetUnlock_HeavenFinalBoss();
            UnlockDivineAelie.AddUnlockData("Aelie_CH", Unlocks.GenerateUnlockData("HIF_Aelie_Divine_Unlock", "HIF_Aelie_Divine_ACH", "", "", ["LiquidDust_TW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Aelie_Divine_ACH", "LiquidDust_TW");

            ModdedAchievements AchievementDivineHills = new ModdedAchievements("Infinite Mirror", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementHeavenHills", null, 32, null), "HIF_Hills_Divine_ACH");
            AchievementDivineHills.AddNewAchievementToInGameCategory((AchievementCategoryIDs)5);
            FinalBossCharUnlockCheck UnlockDivineHills = Unlocks.GetUnlock_HeavenFinalBoss();
            UnlockDivineHills.AddUnlockData("Hills_CH", Unlocks.GenerateUnlockData("HIF_Hills_Divine_Unlock", "HIF_Hills_Divine_ACH", "", "", ["InfiniteMirror_TW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Hills_Divine_ACH", "InfiniteMirror_TW");

            ModdedAchievements AchievementDivineExambry = new ModdedAchievements("Infenal Stone", "Unlocked a new item.", ResourceLoader.LoadSprite("AchievementHeavenExambry", null, 32, null), "HIF_Exambry_Divine_ACH");
            AchievementDivineExambry.AddNewAchievementToInGameCategory((AchievementCategoryIDs)5);
            FinalBossCharUnlockCheck UnlockDivineExambry = Unlocks.GetUnlock_HeavenFinalBoss();
            UnlockDivineExambry.AddUnlockData("Exambry_CH", Unlocks.GenerateUnlockData("HIF_Exambry_Divine_Unlock", "HIF_Exambry_Divine_ACH", "", "", ["InfernalStone_TW"]));
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Exambry_Divine_ACH", "InfernalStone_TW");

            //Doula Unlocks

            //March Unlocks

            //Bemagel Unlocks

            //Comedy Unlocks

            ModdedAchievements AchievementBolerDefeat = new ModdedAchievements("Signals through the Noise", "Disrupt a Boler.", ResourceLoader.LoadSprite("AchievementComedyBoler", null, 32, null), "HIF_Boler_Comedy_ACH");
            AchievementBolerDefeat.AddNewAchievementToInGameCategory((AchievementCategoryIDs)8);
            UnlockableModData BolerDefeatAchievement = new UnlockableModData("Boler_EN")
            {
                hasModdedAchievementUnlock = true,
                moddedAchievementID = "HIF_Boler_Comedy_ACH",
                hasItemUnlock = true,
                items = ["NumberMagnet_SW"]
            };
            EnemyDeathUnlockCheck BolerDeath = ScriptableObject.CreateInstance<EnemyDeathUnlockCheck>();
            BolerDeath.usesSimpleDeathData = true;
            BolerDeath.enemyID = "Boler_EN";
            BolerDeath.simpleDeathData = BolerDefeatAchievement;
            BolerDeath.specialDeathData = [];
            Unlocks.AddUnlock_EnemyDeath(BolerDeath);
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Boler_Comedy_ACH", "NumberMagnet_SW");

            ModdedAchievements AchievementBoojumDefeat = new ModdedAchievements("Softly and Suddenly Vanished Away", "Hunt a Boojum.", ResourceLoader.LoadSprite("AchievementComedyBoojum", null, 32, null), "HIF_Boojum_Comedy_ACH");
            AchievementBoojumDefeat.AddNewAchievementToInGameCategory((AchievementCategoryIDs)8);
            UnlockableModData BoojumDefeatAchievement = new UnlockableModData("Boojum_EN")
            {
                hasModdedAchievementUnlock = true,
                moddedAchievementID = "HIF_Boojum_Comedy_ACH",
                hasItemUnlock = true,
                items = ["SparklingFork_SW"]
            };
            EnemyDeathUnlockCheck BoojumDeath = ScriptableObject.CreateInstance<EnemyDeathUnlockCheck>();
            BoojumDeath.usesSimpleDeathData = true;
            BoojumDeath.enemyID = "Boojum_EN";
            BoojumDeath.simpleDeathData = BoojumDefeatAchievement;
            BoojumDeath.specialDeathData = [];
            Unlocks.AddUnlock_EnemyDeath(BoojumDeath);
            BackwardsUnlockCompatibility.TryLockItemBehindAchievement("HIF_Boojum_Comedy_ACH", "SparklingFork_SW");

            //Tragedy Unlocks

        }
    }
}
