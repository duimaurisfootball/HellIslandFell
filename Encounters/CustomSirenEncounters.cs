using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Encounters
{
    public class CustomSirenEncounters
    {
        public static void Add()
        {
            List<RandomEnemyGroup> boilerEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BoilerEasy"))._enemyBundles)
            {
                new(
            [
                "Boiler_EN",
                "Boiler_EN",
                "OneShooter_EN",
            ]),
            };
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BoilerEasy"))._enemyBundles = boilerEasy;

            List<RandomEnemyGroup> boilerMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BoilerMed"))._enemyBundles)
            {
                new(
            [
                "Boiler_EN",
                "Boiler_EN",
                "BirdBath_EN",
                "OneShooter_EN",
            ]),
            };
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("BoilerMed"))._enemyBundles = boilerMedium;

            List<RandomEnemyGroup> tassnnEasy = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("TassnnEasy"))._enemyBundles)
            {
                new(
            [
                "Tassnn_EN",
                "OneShooter_EN",
            ]),
            };
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("TassnnEasy"))._enemyBundles = tassnnEasy;

            List<RandomEnemyGroup> tassnnMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("TassnnMed"))._enemyBundles)
            {
                new(
            [
                "Tassnn_EN",
                "Tassnn_EN",
                "OneShooter_EN",
            ]),
                new(
            [
                "Tassnn_EN",
                "Tassnn_EN",
                "BirdBath_EN",
                "OneShooter_EN",
            ]),
            };
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("TassnnMed"))._enemyBundles = tassnnMedium;

            List<RandomEnemyGroup> olmicMedium = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("OlmicMed"))._enemyBundles)
            {
                new(
            [
                "Olmic_EN",
                "BirdBath_EN",
                "OneShooter_EN",
            ]),
            };
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("OlmicMed"))._enemyBundles = olmicMedium;

            List<RandomEnemyGroup> olmicHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("OlmicHard"))._enemyBundles)
            {
                new(
            [
                "Olmic_EN",
                "Olmic_EN",
                "OneShooter_EN",
            ]),
                new(
            [
                "Olmic_EN",
                "Tassnn_EN",
                "Tassnn_EN",
                "OneShooter_EN",
            ]),
                new(
            [
                "Olmic_EN",
                "Boiler_EN",
                "Boiler_EN",
                "OneShooter_EN",
            ]),
            };
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("OlmicHard"))._enemyBundles = olmicHard;

            List<RandomEnemyGroup> piscinaHard = new List<RandomEnemyGroup>(((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PiscinaHard"))._enemyBundles)
            {
                new(
            [
                "LivingPiscina_EN",
                "Boiler_EN",
                "OneShooter_EN",
            ]),
                new(
            [
                "LivingPiscina_EN",
                "Olmic_EN",
                "OneShooter_EN",
            ]),
                new(
            [
                "LivingPiscina_EN",
                "Tassnn_EN",
                "OneShooter_EN",
            ]),
            };
            ((RandomEnemyBundleSO)LoadedAssetsHandler.GetEnemyBundle("PiscinaHard"))._enemyBundles = piscinaHard;
        }
    }
}
