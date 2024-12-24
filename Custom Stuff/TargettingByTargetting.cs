using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class TargettingByTargetting : BaseCombatTargettingSO
    {
        public BaseCombatTargettingSO first;

        public BaseCombatTargettingSO second;

        public bool OnlyIfUnit;

        public override bool AreTargetSlots => second.AreTargetSlots;

        public override bool AreTargetAllies
        {
            get
            {
                if (first.AreTargetAllies && second.AreTargetAllies)
                {
                    return true;
                }
                return !first.AreTargetAllies && !second.AreTargetAllies;
            }
        }

        public override TargetSlotInfo[] GetTargets(SlotsCombat slots, int casterSlotID, bool isCasterCharacter)
        {
            TargetSlotInfo[] targets = first.GetTargets(slots, casterSlotID, isCasterCharacter);
            List<TargetSlotInfo> list = [];
            TargetSlotInfo[] array = targets;
            foreach (TargetSlotInfo targetSlotInfo in array)
            {
                if (targetSlotInfo.HasUnit || !OnlyIfUnit)
                {
                    TargetSlotInfo[] targets2 = second.GetTargets(slots, targetSlotInfo.HasUnit ? targetSlotInfo.Unit.SlotID : targetSlotInfo.SlotID, targetSlotInfo.IsTargetCharacterSlot);
                    foreach (TargetSlotInfo item in targets2)
                    {
                        list.Add(item);
                    }
                }
            }
            return [.. list];
        }

        public static TargettingByTargetting Create(BaseCombatTargettingSO first, BaseCombatTargettingSO second)
        {
            TargettingByTargetting targettingByTargetting = CreateInstance<TargettingByTargetting>();
            targettingByTargetting.first = first;
            targettingByTargetting.second = second;
            return targettingByTargetting;
        }
    }

}
