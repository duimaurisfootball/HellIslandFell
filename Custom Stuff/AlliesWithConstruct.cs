using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class AlliesWithConstruct : BaseCombatTargettingSO
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
                    list.Add(slots.GetAllySlotTarget(characterCombat.SlotID, 0, false));
                }
            }
            return [.. list];
        }
    }
}
