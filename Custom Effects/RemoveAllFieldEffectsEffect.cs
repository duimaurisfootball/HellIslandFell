using Hell_Island_Fell.Field_Effects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class RemoveAllFieldEffectsEffect : EffectSO
    {
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            for (int i = 0; i < targets.Length; i++)
            {
                exitAmount += TryRemoveAllFieldEffects(stats, targets[i]);
            }

            return exitAmount > 0;
        }
        public int TryRemoveAllFieldEffects(CombatStats stats, TargetSlotInfo target)
        {
            CombatSlot combatSlot = (!target.IsTargetCharacterSlot) ? stats.combatSlots.EnemySlots[target.SlotID] : stats.combatSlots.CharacterSlots[target.SlotID];
            int num = 0;
            foreach (IFieldEffect fieldEffect in combatSlot.FieldEffects)
            {
                num = fieldEffect.FieldContent;
                combatSlot.RemoveFieldEffect(fieldEffect.FieldID);
            }
            return num;
        }
    }
}
