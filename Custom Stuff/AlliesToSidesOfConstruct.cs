using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class AlliesToSidesOfConstruct : BaseCombatTargettingSO
    {
        public override bool AreTargetAllies => true;
        public override bool AreTargetSlots => true;
        public override TargetSlotInfo[] GetTargets(SlotsCombat slots, int casterSlotID, bool isCasterCharacter)
        {
            List<TargetSlotInfo> list = [];
            foreach (CharacterCombat characterCombat in CombatManager._instance._stats.CharactersOnField.Values)
            {
                bool flag = characterCombat.ContainsPassiveAbility(Passives.Construct.m_PassiveID);
                if (flag)
                {
                    if (characterCombat.SlotID + 1 < 5)
                    {
                        list.Add(slots.GetAllySlotTarget(characterCombat.SlotID + 1, 0, false));
                    }
                    if (characterCombat.SlotID - 1 > -1)
                    {
                        list.Add(slots.GetAllySlotTarget(characterCombat.SlotID - 1, 0, false));
                    }
                }
            }
            return [.. list];
        }
    }
}
