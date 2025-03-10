using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class AllFrontSlots : BaseCombatTargettingSO
    {
        public override bool AreTargetAllies => false;
        public override bool AreTargetSlots => true;
        public override TargetSlotInfo[] GetTargets(SlotsCombat slots, int casterSlotID, bool isCasterCharacter)
        {
            List<TargetSlotInfo> list = [];
            foreach (EnemyCombat enemyCombat in CombatManager._instance._stats.EnemiesOnField.Values)
            {
                if (enemyCombat.SlotID == casterSlotID)
                {
                    for (int i = 0; i < enemyCombat.Size; i++)
                    {
                        list.Add(slots.GetOpponentSlotTarget(casterSlotID + i, 0, false));
                    }
                }
            }
            return [.. list];
        }
    }
}
