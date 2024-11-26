using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Effects
{
    public class AddMaxHealthRandomEffect : EffectSO
    {
        [SerializeField]
        public bool _increase = true;

        [SerializeField]
        public int lowNum = 0;

        [SerializeField]
        public int highNum = 1;

        public override bool PerformEffect(CombatStats stats, IUnit caster, TargetSlotInfo[] targets, bool areTargetSlots, int entryVariable, out int exitAmount)
        {
            exitAmount = 0;
            for (int i = 0; i < targets.Length; i++)
            {
                if (targets[i].HasUnit)
                {
                    int num = UnityEngine.Random.Range(lowNum, highNum) * entryVariable;
                    int num2 = targets[i].Unit.MaximumHealth + (_increase ? num : (-num));
                    if (targets[i].Unit.MaximizeHealth(num2))
                    {
                        exitAmount += num;
                    }
                }
            }
            return exitAmount > 0;
        }
    }
}
