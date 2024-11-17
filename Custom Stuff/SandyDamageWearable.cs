using BrutalAPI;
using Hell_Island_Fell.Custom_Passives;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Hell_Island_Fell.Items
{
    public class SandyDamageWearable : BaseWearableSO
    {
        [Header("Multiplier Data")]
        public bool _useDealt;

        public bool _useSimpleInt;

        public int _toMultiply0 = 100;

        public int _toMultiply1 = 50;

        public override bool IsItemImmediate => true;

        public override bool DoesItemTrigger => true;
        
        public override void TriggerPassive(object sender, object args)
        {
            if (args is DamageDealtValueChangeException context)
            {
                if (context.damagedUnit.HealthColor == Pigments.Blue)
                {
                    if (_useSimpleInt)
                    {
                        if (args is IntValueChangeException ex && !ex.Equals(null))
                        {
                            ex.AddModifier(new BasicPercentageValueModifier(true, _toMultiply0, true));
                        }
                    }
                    else if (_useDealt)
                    {
                        if (args is DamageDealtValueChangeException ex2 && !ex2.Equals(null))
                        {
                            ex2.AddModifier(new BasicPercentageValueModifier(true, _toMultiply0, true));
                        }
                    }
                    else if (args is DamageReceivedValueChangeException ex3 && !ex3.Equals(null))
                    {
                        ex3.AddModifier(new BasicPercentageValueModifier(true, _toMultiply0, true));
                    }
                }
                if (context.damagedUnit.HealthColor == Pigments.Yellow)
                {
                    if (_useSimpleInt)
                    {
                        if (args is IntValueChangeException ex && !ex.Equals(null))
                        {
                            ex.AddModifier(new BasicPercentageValueModifier(true, _toMultiply1, false));
                        }
                    }
                    else if (_useDealt)
                    {
                        if (args is DamageDealtValueChangeException ex2 && !ex2.Equals(null))
                        {
                            ex2.AddModifier(new BasicPercentageValueModifier(true, _toMultiply1, false));
                        }
                    }
                    else if (args is DamageReceivedValueChangeException ex3 && !ex3.Equals(null))
                    {
                        ex3.AddModifier(new BasicPercentageValueModifier(true, _toMultiply1, false));
                    }
                }
            }
        }

        public class ScrollCondition : EffectorConditionSO
        {
            public override bool MeetCondition(IEffectorChecks effector, object args)
            {
                return args is DamageDealtValueChangeException context && (context.damagedUnit.HealthColor == Pigments.Blue || context.damagedUnit.HealthColor == Pigments.Yellow);
            }
        }
    }
}
