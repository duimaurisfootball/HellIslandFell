using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class WaxmanCheckEffect : EffectSO
    {
        public UnitStoreData_BasicSO unitStoredData;

        [UnitStoreValueNamesIDsEnumRef]
        public string m_unitStoredDataID = "";

        public int m_Threshold;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            foreach (TargetSlotInfo target in targets)
            {
                if (target.HasUnit)
                {
                    target.Unit.TryGetStoredData(m_unitStoredDataID, out UnitStoreDataHolder holder);
                    if (holder.m_MainData != 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
