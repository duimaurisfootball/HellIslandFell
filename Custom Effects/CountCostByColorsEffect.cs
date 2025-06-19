using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class CountCostByColorsEffect : EffectSO
    {
        public List<ManaColorSO> specialColors;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit && targetSlotInfo.Unit is CharacterCombat cc)
                {
                    foreach (var ab in cc.CombatAbilities)
                    {
                        foreach (var cost in ab.cost)
                        {
                            foreach (var color in cost.pigmentTypes)
                            {
                                if (specialColors.Contains(Pigments.GetPigmentWithID(color)))
                                {
                                    exitAmount += entryVariable;
                                    continue;
                                }
                            }
                        }
                    }
                }
            }
            return exitAmount > 0;
        }
    }
}
