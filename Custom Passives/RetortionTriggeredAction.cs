using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Passives
{
    public class RetortionTriggeredAction(int unitID, bool isUnitCharacter) : IImmediateAction
    {
        public int _unitID = unitID;

        public bool _isUnitCharacter = isUnitCharacter;

        public void Execute(CombatStats stats)
        {
            if (_isUnitCharacter)
            {
                Debug.LogError("Character has Retortion");
                return;
            }

            EnemyCombat enemyCombat = stats.TryGetEnemyOnField(_unitID);
            if (enemyCombat != null && enemyCombat.AbilityCount != 0)
            {
                stats.timeline.TryAddNewExtraEnemyTurns(enemyCombat, 1);
            }
        }
    }
}
