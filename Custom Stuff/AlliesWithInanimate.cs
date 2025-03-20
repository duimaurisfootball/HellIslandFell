using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class AlliesWithInanimate : BaseCombatTargettingSO
    {
        public override bool AreTargetAllies => true;
        public override bool AreTargetSlots => true;
        public override TargetSlotInfo[] GetTargets(SlotsCombat slots, int casterSlotID, bool isCasterCharacter)
        {
            List<TargetSlotInfo> list = [];
            foreach (EnemyCombat enemyCombat in CombatManager._instance._stats.EnemiesOnField.Values)
            {
                bool flag = enemyCombat.ContainsPassiveAbility(Passives.Inanimate.m_PassiveID);
                if (flag)
                {
                    list.Add(slots.GetAllySlotTarget(enemyCombat.SlotID, 0, false));
                }
            }
            return [.. list];
        }
    }
}
