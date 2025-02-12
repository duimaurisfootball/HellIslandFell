using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class CasterStoredValueDecreaseRandomlyEffect : EffectSO
    {
        public bool _ignoreIfContains;

        [UnitStoreValueNamesIDsEnumRef]
        public string m_unitStoredDataID = "";

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            bool flag = caster.TryGetStoredData(m_unitStoredDataID, out UnitStoreDataHolder holder);
            exitAmount = holder.m_MainData;
            if (!_ignoreIfContains || !flag)
            {
                holder.m_MainData = Math.Max(UnityEngine.Random.Range(0, holder.m_MainData + 1), 0);
                exitAmount -= holder.m_MainData;
                return true;
            }

            return false;
        }
    }
}
