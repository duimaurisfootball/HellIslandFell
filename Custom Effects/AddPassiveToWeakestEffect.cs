using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class AddPassiveToWeakestEffect : EffectSO
    {
        public BasePassiveAbilitySO _passiveToAdd;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            List<TargetSlotInfo> list = [];
            int num = -1;
            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit && targetSlotInfo.Unit.IsAlive && !targetSlotInfo.Unit.ContainsPassiveAbility(Passives.Inanimate.m_PassiveID))
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
                item.Unit.AddPassiveAbility(_passiveToAdd);
            }

            return exitAmount > 0;
        }
    }
}
