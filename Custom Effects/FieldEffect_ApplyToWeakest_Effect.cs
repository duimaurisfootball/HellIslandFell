using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Custom_Effects
{
    public class FieldEffect_ApplyToWeakest_Effect : EffectSO
    {
        public FieldEffect_SO _Field;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            if (_Field == null)
            {
                return false;
            }

            List<TargetSlotInfo> list = [];
            int num = -1;
            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit && targetSlotInfo.Unit.IsAlive)
                {
                    if (num < 0)
                    {
                        list.Add(targetSlotInfo);
                        num = targetSlotInfo.Unit.CurrentHealth;
                    }
                    else if (targetSlotInfo.Unit.CurrentHealth < num)
                    {
                        list.Clear();
                        list.Add(targetSlotInfo);
                        num = targetSlotInfo.Unit.CurrentHealth;
                    }
                    else if (targetSlotInfo.Unit.CurrentHealth == num)
                    {
                        list.Add(targetSlotInfo);
                    }
                }
            }
            foreach (TargetSlotInfo item in list)
            {
                int amount = entryVariable;
                exitAmount += ApplyFieldEffect(stats, item, entryVariable);
            }

            return exitAmount > 0;
        }

        public int ApplyFieldEffect(CombatStats stats, TargetSlotInfo target, int entryVariable)
        {
            int num = entryVariable;
            if (num < _Field.MinimumRequiredToApply)
            {
                return 0;
            }

            if (!stats.combatSlots.ApplyFieldEffect(target.SlotID, target.IsTargetCharacterSlot, _Field, num))
            {
                return 0;
            }

            return num;
        }
    }
}
