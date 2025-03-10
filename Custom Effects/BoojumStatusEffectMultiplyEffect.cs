using Hell_Island_Fell.Custom_Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class BoojumStatusEffectMultiplyEffect : EffectSO
    {
        public StatusEffect_SO _Status;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            List<IUnit> list = [];
            List<IUnit> list2 = [];

            for (int cont = 0; cont < 1;)
            {
                TargetSlotInfo[] targets0 = CreateInstance<RightmostTargeting>().GetTargets(stats.combatSlots, caster.SlotID, caster.IsUnitCharacter);
                TargetSlotInfo[] targets1 = Targeting.Slot_SelfSlot.GetTargets(stats.combatSlots, caster.SlotID, caster.IsUnitCharacter);

                for (int i = 0; i < targets0.Length; i++)
                {
                    if (targets0[i].HasUnit)
                    {
                        ApplyStatusEffect(targets0[i].Unit, entryVariable);
                        exitAmount += MultiplyStatusEffect(targets0[i].Unit);
                    }
                }

                for (int i = 0; i < targets1.Length; i++)
                {
                    if (targets1[i].HasUnit)
                    {
                        if (targets1[i].Unit.IsUnitCharacter && stats.combatSlots.CharacterSlots[targets1[i].SlotID].TryRemoveFieldEffect(StatusField.Constricted.ToString()) != 0)
                        {
                            exitAmount++;
                        }
                        if (!targets1[i].Unit.IsUnitCharacter && stats.combatSlots.EnemySlots[targets1[i].SlotID].TryRemoveFieldEffect(StatusField.Constricted.ToString()) != 0)
                        {
                            exitAmount++;
                        }
                    }
                }

                for (int i = 0; i < targets1.Length; i++)
                {
                    if (targets1[i].HasUnit)
                    {
                        IUnit unit = targets1[i].Unit;
                        if (unit.IsUnitCharacter && !list.Contains(unit))
                        {
                            list.Add(unit);
                        }
                        else if (!unit.IsUnitCharacter && !list2.Contains(unit))
                        {
                            list2.Add(unit);
                        }
                    }
                }

                foreach (IUnit item in list)
                {
                    if (item.SlotID + 1 >= 0 && item.SlotID + 1 < stats.combatSlots.CharacterSlots.Length && stats.combatSlots.SwapCharacters(item.SlotID, item.SlotID + 1, isMandatory: true))
                    {
                        exitAmount++;
                    }
                    else
                    {
                        cont++;
                    }
                }

                foreach (IUnit item2 in list2)
                {
                    if (stats.combatSlots.CanEnemiesSwap(item2.SlotID, item2.SlotID + 1, out var firstSlotSwap, out var secondSlotSwap) && stats.combatSlots.SwapEnemies(item2.SlotID, firstSlotSwap, item2.SlotID + 1, secondSlotSwap, isMandatory: true))
                    {
                        exitAmount++;
                    }
                    else
                    {
                        cont++;
                    }
                }
            }

            return exitAmount > 0;
        }
        public int ApplyStatusEffect(IUnit unit, int entryVariable)
        {
            return entryVariable < _Status.MinimumRequiredToApply
                ? 0
                : !unit.ApplyStatusEffect(_Status, entryVariable)
                    ? 0
                    : Mathf.Max(1, entryVariable);
        }

        public int MultiplyStatusEffect(IUnit unit)
        {
            int ball = 0;
            if (unit is not IStatusEffector effector || effector.StatusEffects == null)
            {
                return 0;
            }

            foreach (var st in effector.StatusEffects.ToList())
            {
                if (!st.IsStatus("Disappearing_ID")) continue;

                if (st is not StatusEffect_Holder hold || hold.m_ContentMain <= 0 || hold._Status == null) continue;

                var oldContent = hold.m_ContentMain;
                hold.m_ContentMain *= 3;
                ball += oldContent - hold.m_ContentMain; 
                
                if (oldContent != hold.m_ContentMain)
                {
                    effector.StatusEffectValuesChanged(hold.StatusID, hold.m_ContentMain - oldContent, true);
                }
            }
            return ball;
        }
    }
}
