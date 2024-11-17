using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class HillsShatterEffect : EffectSO
    {
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                for (int i = 0; i < 1;)
                {
                    if ((!stats.combatSlots.UnitInSlotContainsFieldEffect(targetSlotInfo.SlotID, targetSlotInfo.IsTargetCharacterSlot, StatusField_GameIDs.Shield_ID.ToString())) || (targetSlotInfo.HasUnit && targetSlotInfo.Unit.CurrentHealth == 0) || (!targetSlotInfo.HasUnit))
                    {
                        i++;
                    }
                    if (targetSlotInfo.HasUnit)
                    {
                        CombatManager.Instance.AddUIAction(new PlayStatusEffectSoundAndWaitUIAction(LoadedAssetsHandler.GetEnemy("Visage_Siblings_EN").deathSound, 0));
                        int targetSlotOffset = areTargetSlots ? (targetSlotInfo.SlotID - targetSlotInfo.Unit.SlotID) : (-1);
                        int amount = UnityEngine.Random.Range(PreviousExitValue, entryVariable + 1);
                        DamageInfo damageInfo;
                        amount = caster.WillApplyDamage(amount, targetSlotInfo.Unit);
                        damageInfo = targetSlotInfo.Unit.Damage(amount, caster, "Basic", targetSlotOffset, true, true, false);
                        exitAmount += damageInfo.damageAmount;
                    }
                }
            }

            return exitAmount > 0;
        }
    }
}
