using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class BoojumFurthestLeftEffect : EffectSO
    {
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            List<IUnit> list = [];
            List<IUnit> list2 = [];

            for (int cont = 0; cont < 1;)
            {
                TargetSlotInfo[] targets1 = Targeting.Slot_SelfSlot.GetTargets(stats.combatSlots, caster.SlotID, caster.IsUnitCharacter);

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
                    if (item.SlotID - 1 >= 0 && item.SlotID - 1 < stats.combatSlots.CharacterSlots.Length && stats.combatSlots.SwapCharacters(item.SlotID, item.SlotID - 1, isMandatory: true))
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
                    if (stats.combatSlots.CanEnemiesSwap(item2.SlotID, item2.SlotID - 1, out var firstSlotSwap, out var secondSlotSwap) && stats.combatSlots.SwapEnemies(item2.SlotID, firstSlotSwap, item2.SlotID - 1, secondSlotSwap, isMandatory: true))
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
    }
}
