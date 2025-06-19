using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class ScareRandomFishEffect : EffectSO
    {
        public int _chance;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit && targetSlotInfo.Unit.UnitTypes.Contains(UnitType_GameIDs.Fish.ToString()) && UnityEngine.Random.Range(0, 100) < _chance)
                {
                    exitAmount++;
                    targetSlotInfo.Unit.UnitWillFlee();
                    CombatManager.Instance.AddSubAction(new FleetingUnitAction(targetSlotInfo.Unit.ID, targetSlotInfo.Unit.IsUnitCharacter));
                }
            }

            return exitAmount > 0;
        }
    }
}
