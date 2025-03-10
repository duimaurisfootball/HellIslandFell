using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class RightmostTargeting : BaseCombatTargettingSO
    {
        public override bool AreTargetAllies => false;
        public override bool AreTargetSlots => true;
        public override TargetSlotInfo[] GetTargets(SlotsCombat slots, int casterSlotID, bool isCasterCharacter)
        {
            List<TargetSlotInfo> list = [];

            list.Add(slots.GetOpponentSlotTarget(4, 0, false));

            return [.. list];
        }
    }
}
