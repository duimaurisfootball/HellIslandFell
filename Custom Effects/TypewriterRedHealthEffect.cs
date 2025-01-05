using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class TypewriterRedHealthEffect : EffectSO
    {

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            TargetSlotInfo targetSlotInfo = null;

            for (int i = 0; i < targets.Length; i++)
            {
                targetSlotInfo = targets[UnityEngine.Random.Range(0, targets.Length)];

                if (targetSlotInfo.HasUnit && !targetSlotInfo.Unit.ContainsPassiveAbility(PassiveType_GameIDs.Pure.ToString()))
                {
                    targetSlotInfo.Unit.ChangeHealthColor(Pigments.Red);
                    break;
                }
            }

            return exitAmount > 0;
        }
    }
}
