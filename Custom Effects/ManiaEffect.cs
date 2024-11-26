using BrutalAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class ManiaEffect : EffectSO
    {
        public int _repeatChance;
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            List<IUnit> list = [];
            List<IUnit> list2 = [];

            int ball = 1;
            for (int i = 0; i < 1; i++)
            {
                ball += (int)Math.Ceiling(Math.Log(UnityEngine.Random.value) / Math.Log(_repeatChance / 100.0));
            }

            for (int j = 0; j < ball; j++)
            {
                //update everything code
                TargetSlotInfo[] targets0 = Targeting.Slot_Front.GetTargets(stats.combatSlots, caster.SlotID, caster.IsUnitCharacter);
                TargetSlotInfo[] targets1 = Targeting.Slot_SelfSlot.GetTargets(stats.combatSlots, caster.SlotID, caster.IsUnitCharacter);

                //scream code
                CombatManager.Instance.AddUIAction(new PlayStatusEffectSoundAndWaitUIAction(LoadedAssetsHandler.GetEnemy("Visage_Siblings_EN").deathSound, 0));

                //damage code
                foreach (TargetSlotInfo targetSlotInfo in targets0)
                {
                    if (targetSlotInfo.HasUnit)
                    {
                        int targetSlotOffset = areTargetSlots ? (targetSlotInfo.SlotID - targetSlotInfo.Unit.SlotID) : (-1);
                        int amount = entryVariable;
                        DamageInfo damageInfo;
                        amount = caster.WillApplyDamage(amount, targetSlotInfo.Unit);
                        damageInfo = targetSlotInfo.Unit.Damage(amount, caster, "Basic", targetSlotOffset, true, true, false);
                        
                        exitAmount += damageInfo.damageAmount;
                    }
                }

                //swap to sides code
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
                    int num = (UnityEngine.Random.Range(0, 2) * 2) - 1;
                    if (item.SlotID + num >= 0 && item.SlotID + num < stats.combatSlots.CharacterSlots.Length)
                    {
                        if (stats.combatSlots.SwapCharacters(item.SlotID, item.SlotID + num, isMandatory: true))
                        {
                            exitAmount++;
                        }

                        continue;
                    }

                    num *= -1;
                    if (item.SlotID + num >= 0 && item.SlotID + num < stats.combatSlots.CharacterSlots.Length && stats.combatSlots.SwapCharacters(item.SlotID, item.SlotID + num, isMandatory: true))
                    {
                        exitAmount++;
                    }
                }

                foreach (IUnit item2 in list2)
                {
                    int num = (UnityEngine.Random.Range(0, 2) * (item2.Size + 1)) - 1;
                    if (stats.combatSlots.CanEnemiesSwap(item2.SlotID, item2.SlotID + num, out var firstSlotSwap, out var secondSlotSwap))
                    {
                        if (stats.combatSlots.SwapEnemies(item2.SlotID, firstSlotSwap, item2.SlotID + num, secondSlotSwap, isMandatory: true))
                        {
                            exitAmount++;
                        }

                        continue;
                    }

                    num = (num < 0) ? item2.Size : (-1);
                    if (stats.combatSlots.CanEnemiesSwap(item2.SlotID, item2.SlotID + num, out firstSlotSwap, out secondSlotSwap) && stats.combatSlots.SwapEnemies(item2.SlotID, firstSlotSwap, item2.SlotID + num, secondSlotSwap, isMandatory: true))
                    {
                        exitAmount++;
                    }
                }
            }

            return exitAmount > 0;
        }
    }
}
