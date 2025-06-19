using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class StatusEffect_ApplyToOneWithout_Effect : EffectSO
    {
        [Header("Status")]
        public StatusEffect_SO _Status;

        [Header("Data")]
        public bool _ApplyToFirstUnit;

        public bool _JustOneRandomTarget;

        public bool _RandomBetweenPrevious;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            if (_Status == null)
            {
                return false;
            }

            List<TargetSlotInfo> list = [];
            foreach (TargetSlotInfo targetSlotInfo in targets)
            {
                if (targetSlotInfo.HasUnit && !targetSlotInfo.Unit.ContainsStatusEffect(_Status._StatusID))
                {
                    list.Add(targetSlotInfo);
                }
            }

            if (list.Count > 0)
            {
                int index = UnityEngine.Random.Range(0, list.Count);
                exitAmount += ApplyStatusEffect(list[index].Unit, entryVariable);
            }

            return exitAmount > 0;
        }

        public int ApplyStatusEffect(IUnit unit, int num)
        {
            if (num < _Status.MinimumRequiredToApply)
            {
                return 0;
            }

            if (!unit.ApplyStatusEffect(_Status, num))
            {
                return 0;
            }

            return Mathf.Max(1, num);
        }
    }
}
