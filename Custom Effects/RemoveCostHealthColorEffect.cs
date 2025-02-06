using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class RemoveCostHealthColorEffect : EffectSO
    {
        private static ManaColorSO TransformPigmentKVPs(string colorString)
        {
            for (int i = 0; i < LoadedDBsHandler.PigmentDB.PigmentPool.Keys.Count; i++)
            {
                if (LoadedDBsHandler.PigmentDB.PigmentPool.Keys.ElementAt(i) == colorString)
                {
                    return LoadedDBsHandler.PigmentDB.PigmentPool.Values.ElementAt(i);
                }
            }
            return null;
        }
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
                            bool matches = false;
                            foreach (var color in cost.pigmentTypes)
                            {
                                if (TransformPigmentKVPs(color) == caster.HealthColor)
                                {
                                    matches = true;
                                }
                            }
                            if (!matches)
                            {
                                newCosts.Add(cost);
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
