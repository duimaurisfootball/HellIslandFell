using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class CasterStoreValueSetterPreviousExitEffect : EffectSO
    {
        public bool _ignoreIfContains;

        public string m_unitStoredDataID = "";

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            bool flag = caster.TryGetStoredData(m_unitStoredDataID, out UnitStoreDataHolder holder);
            if (!_ignoreIfContains || !flag)
            {
                holder.m_MainData = entryVariable * PreviousExitValue;
                return true;
            }

            return false;
        }
    }
}
