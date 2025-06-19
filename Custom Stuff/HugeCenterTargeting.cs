using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class HugeCenterTargeting : BaseCombatTargettingSO
    {
        public override bool AreTargetAllies => true;

        public override bool AreTargetSlots => true;

        public override TargetSlotInfo[] GetTargets(SlotsCombat slots, int casterSlotID, bool isCasterCharacter)
        {
            List<TargetSlotInfo> list = [];

            list.Add(slots.GetOpponentSlotTarget(1, 0, true));
            list.Add(slots.GetOpponentSlotTarget(2, 0, true));

            return [.. list];
        }
    }
}
