using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class ReturnEnemiesEffect : EffectSO
    {
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            List<EnemySO> enemies = [];
            for (int i = 0; i < stats.Enemies.Count; i++)
            {
                EnemyCombat enemyCombat = stats.Enemies[i];
                if (!enemyCombat.IsAlive || enemyCombat.HasFled)
                {
                    enemies.Add(enemyCombat.Enemy);
                }
            }

            for (int i = 0; i < entryVariable; i++)
            {
                if (enemies.Count <= 0)
                {
                    return false;
                }
                int index = UnityEngine.Random.Range(0, enemies.Count);
                CombatManager.Instance.AddSubAction(new SpawnEnemyAction(enemies[index], -1, false, false, CombatType_GameIDs.Spawn_Whoosh.ToString()));
                enemies.RemoveAt(index);
            }

            return exitAmount > 0;
        }
    }
}
