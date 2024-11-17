using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class CasterStoreValueCheckOverEntryVariableEffect : EffectSO
    {
        public UnitStoreData_BasicSO unitStoredData;

        [UnitStoreValueNamesIDsEnumRef]
        public string m_unitStoredDataID = "";

        public int m_Threshold;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            caster.TryGetStoredData(m_unitStoredDataID, out var holder);
            exitAmount = holder.m_MainData;
            return exitAmount > entryVariable;
        }
    }
}
