using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Custom_Effects
{
    public class DebugLogStoredValue : EffectSO
    {
        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            caster.TryGetStoredData("ConsistentFleetingStoredValue", out var holder);
            Debug.Log("Stored value: " + holder.m_MainData);
            return true;
        }
    }
}
