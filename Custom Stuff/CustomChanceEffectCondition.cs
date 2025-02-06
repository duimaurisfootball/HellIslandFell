using System;
using System.Collections.Generic;
using System.Text;

namespace Hell_Island_Fell.Custom_Stuff
{
    public class CustomChanceEffectCondition : EffectConditionSO
    {
        public int _dividend = 1;
        public int _divisor = 100;

        public override bool MeetCondition(IUnit caster, EffectInfo[] effects, int currentIndex)
        {
            return UnityEngine.Random.Range(0, _divisor) < _dividend;
        }
    }
}
