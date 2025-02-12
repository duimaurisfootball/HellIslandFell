using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class CasterStoreValueSetRandomBetweenExitEffect : EffectSO
    {
        public bool _ignoreIfContains;

        [UnitStoreValueNamesIDsEnumRef]
        public string m_unitStoredDataID = "";

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            bool flag = caster.TryGetStoredData(m_unitStoredDataID, out UnitStoreDataHolder holder);
            if (!_ignoreIfContains || !flag)
            {
                holder.m_MainData = UnityEngine.Random.Range(PreviousExitValue, entryVariable + 1);
                return true;
            }

            return false;
        }
    }
}
