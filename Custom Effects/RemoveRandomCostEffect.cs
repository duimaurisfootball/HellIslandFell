using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class RemoveRandomCostEffect : EffectSO
    {
        public bool removeSingleCost = false;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit && targetSlotInfo.Unit is CharacterCombat cc)
                {
                    foreach (var ab in cc.CombatAbilities)
                    {
                        List<ManaColorSO> newCosts = [.. ab.cost];
                        for (int i = 0; i < entryVariable; i++)
                        {
                            if (removeSingleCost || newCosts.Count > 1)
                            {
                                newCosts.RemoveAt(UnityEngine.Random.Range(0, newCosts.Count));
                                exitAmount++;
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
                    CombatManager.Instance.AddUIAction(new CharacterUpdateAllAttacksUIAction((targetSlotInfo.Unit as CharacterCombat).ID, [.. (targetSlotInfo.Unit as CharacterCombat).CombatAbilities]));
                }
            }
            return exitAmount > 0;
        }
    }
}
