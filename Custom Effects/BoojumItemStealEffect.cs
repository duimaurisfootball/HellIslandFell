using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class BoojumItemStealEffect : EffectSO
    {
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            List<IUnit> list = [];
            List<IUnit> list2 = [];

            for (int cont = 0; cont < 1;)
            {
                TargetSlotInfo[] targets0 = Targeting.Slot_Front.GetTargets(stats.combatSlots, caster.SlotID, caster.IsUnitCharacter);
                TargetSlotInfo[] targets1 = Targeting.Slot_SelfSlot.GetTargets(stats.combatSlots, caster.SlotID, caster.IsUnitCharacter);
                TargetSlotInfo[] targets2 = Targeting.Slot_OpponentAllRights.GetTargets(stats.combatSlots, caster.SlotID, caster.IsUnitCharacter);

                for (int i = 0; i < targets0.Length; i++)
                {
                    if (targets0[i].HasUnit && targets0[i].Unit.TryConsumeWearable())
                    {
                        exitAmount++;
                        cont++;
                    }
                }

                bool flag = false;
                for (int i = 0; i < targets2.Length; i++)
                {
                    if (targets2[i].HasUnit)
                    {
                        int targetSlotOffset = areTargetSlots ? (targets2[i].SlotID - targets2[i].Unit.SlotID) : (-1);
                        int amount = entryVariable;
                        DamageInfo damageInfo;
                        amount = caster.WillApplyDamage(amount, targets2[i].Unit);
                        damageInfo = targets2[i].Unit.Damage(amount, caster, DeathType_GameIDs.Basic.ToString(), targetSlotOffset, true, true, false);
                        flag |= damageInfo.beenKilled;
                        exitAmount += damageInfo.damageAmount;
                    }
                }

                if (exitAmount > 0)
                {
                    caster.DidApplyDamage(exitAmount);
                }

                if (cont == 0)
                {
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
            }

            return exitAmount > 0;
        }
    }
}
