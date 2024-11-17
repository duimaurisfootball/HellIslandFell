using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class SpawnEnemyAnywhereRandomBetweenPreviousEffect : EffectSO
    {
        public EnemySO enemy;

        public bool givesExperience;

        [CombatIDsEnumRef]
        public string _spawnTypeID = "";

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            int rand = UnityEngine.Random.Range(PreviousExitValue, entryVariable + 1);
            for (int i = 0; i < rand; i++)
            {
                CombatManager.Instance.AddSubAction(new SpawnEnemyAction(enemy, -1, givesExperience, trySpawnAnyways: false, _spawnTypeID));
            }

            exitAmount = entryVariable;
            return true;
        }
    }
}
