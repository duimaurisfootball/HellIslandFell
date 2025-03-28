﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class CasterStoreValuedPercentageChangeEffect : EffectSO
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
                exitAmount = holder.m_MainData * entryVariable / 100;
                holder.m_MainData = holder.m_MainData * entryVariable / 100;
                return true;
            }

            return exitAmount > 0;
        }
    }
}
