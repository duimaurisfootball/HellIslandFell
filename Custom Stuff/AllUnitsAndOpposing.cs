using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class AllUnitsAndOpposing : BaseCombatTargettingSO
    {
        public override bool AreTargetAllies => false;
        public override bool AreTargetSlots => true;
        public override TargetSlotInfo[] GetTargets(SlotsCombat slots, int casterSlotID, bool isCasterCharacter)
        {
            List<TargetSlotInfo> list = [];
            
            list.Add(slots.GetOpponentSlotTarget(casterSlotID, 0, false));

            foreach (CharacterCombat characterCombat in CombatManager._instance._stats.CharactersOnField.Values)
            {
                if (casterSlotID != characterCombat.SlotID && slots.GetOpponentSlotTarget(characterCombat.SlotID, 0, false).HasUnit)
                {
                    list.Add(slots.GetOpponentSlotTarget(characterCombat.SlotID, 0, false));
                }
            }
            return [.. list];
        }
    }
}
