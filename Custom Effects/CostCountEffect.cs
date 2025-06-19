using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class CostCountEffect : EffectSO
    {
        public bool OnlyCountUnique = false;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            List<ManaColorSO> colors = [];
            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit && targetSlotInfo.Unit is CharacterCombat cc)
                {
                    foreach (var ab in cc.CombatAbilities)
                    {
                        if (OnlyCountUnique)
                        {
                            foreach (var cost in ab.cost)
                            {
                                if (!colors.Contains(cost))
                                {
                                    colors.Add(cost);
                                    exitAmount++;
                                }
                            }
                        }
                        else
                        {
                            foreach (var cost in ab.cost)
                            {
                                exitAmount++;
                            }
                        }
                    }
                }
            }
            return exitAmount > 0;
        }
    }
}
