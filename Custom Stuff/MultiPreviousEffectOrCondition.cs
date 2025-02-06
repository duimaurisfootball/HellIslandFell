using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class MultiPreviousEffectOrCondition : EffectConditionSO
    {
        public bool wasSuccessful;

        [Range(1f, 50f)]
        public int[] previousAmount;

        public override bool MeetCondition(IUnit caster, EffectInfo[] effects, int currentIndex)
        {
            for (int i = 0; i < previousAmount.Length; i++)
            {
                int num = currentIndex - previousAmount[i];
                if (num < 0 || num > effects.Length)
                {
                    return false;
                }

                if (effects[num].EffectSuccess)
                {
                    return wasSuccessful;
                }
            }

            return !wasSuccessful;
        }
    }
}
