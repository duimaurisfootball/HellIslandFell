using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class RemoveAllButColorsCostEffect : EffectSO
    {
        public List<ManaColorSO> _colors;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit && targetSlotInfo.Unit is CharacterCombat cc)
                {
                    foreach (var ab in cc.CombatAbilities)
                    {
                        List<ManaColorSO> newCosts = [];
                        foreach (var cost in ab.cost)
                        {
                            foreach (var color in _colors)
                            {
                                if (cost == color)
                                {
                                    newCosts.Add(cost);
                                }
                            }
                        }
                        ab.cost = new ManaColorSO[newCosts.Count];
                        for (int i = 0; i < newCosts.Count; i++)
                        {
                            ab.cost[i] = newCosts[i];
                        }
                    }
                    foreach (CharacterCombatUIInfo characterCombatUIInfo in stats.combatUI._charactersInCombat.Values)
                    {
                        bool flag3 = characterCombatUIInfo.SlotID == targetSlotInfo.Unit.SlotID;
                        if (flag3)
                        {
                            characterCombatUIInfo.UpdateAttacks([.. (targetSlotInfo.Unit as CharacterCombat).CombatAbilities]);
                            break;
                        }
                    }
                }
            }
            return exitAmount > 0;
        }
    }
}
