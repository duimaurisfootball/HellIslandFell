using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class RemoveFieldEffectEffect : EffectSO
    {
        public FieldEffect_SO _Field;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            for (int i = 0; i < targets.Length; i++)
            {
                if (targets[i].HasUnit)
                {
                    if (targets[i].Unit.IsUnitCharacter && stats.combatSlots.CharacterSlots[targets[i].SlotID].TryRemoveFieldEffect(_Field.ToString()) != 0)
                    {
                        exitAmount++;
                    }
                    if (!targets[i].Unit.IsUnitCharacter && stats.combatSlots.EnemySlots[targets[i].SlotID].TryRemoveFieldEffect(_Field.ToString()) != 0)
                    {
                        exitAmount++;
                    }
                }
            }
            return exitAmount > 0;
        }
    }
}
